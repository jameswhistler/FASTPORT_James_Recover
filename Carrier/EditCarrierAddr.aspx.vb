
' This file implements the code-behind class for EditCarrierAddr.aspx.
' EditCarrierAddr.Controls.vb contains the Table, Row and Record control classes
' for the page.  Best practices calls for overriding methods in the Row or Record control classes.

#Region "Imports statements"

Option Strict On
Imports System
Imports System.Data
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
        
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports BaseClasses
Imports BaseClasses.Utils
Imports BaseClasses.Utils.StringUtils
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports BaseClasses.Data.OrderByItem.OrderDir
Imports BaseClasses.Data.BaseFilter
Imports BaseClasses.Data.BaseFilter.ComparisonOperator
Imports BaseClasses.Web.UI.WebControls
        
Imports FASTPORT.Business
Imports FASTPORT.Data
Imports Telerik.Web.UI
        

#End Region

  
Namespace FASTPORT.UI
  
Partial Public Class EditCarrierAddr
        Inherits BaseApplicationPage
' Code-behind class for the EditCarrierAddr page.
' Place your customizations in Section 1. Do not modify Section 2.
        
#Region "Section 1: Place your customizations here."


        Protected WithEvents ZipCombo As RadComboBox
        Protected WithEvents EmailTB As RadTextBox
        Protected WithEvents PhoneTB As RadMaskedTextBox
        Protected WithEvents FaxTB As RadMaskedTextBox

        ' Protected WithEvents DirectionsRadEditor As RadEditor

        Private Const ItemsPerRequest As Integer = 10

        Protected Sub s_ZipCombo_ItemsRequested(ByVal sender As Object, ByVal e As RadComboBoxItemsRequestedEventArgs) Handles ZipCombo.ItemsRequested

            Try

                Dim data As DataTable = f_ZipCombo_GetData(e.Text)

                Dim itemOffset As Integer = e.NumberOfItems
                Dim endOffset As Integer = Math.Min(itemOffset + ItemsPerRequest, data.Rows.Count)
                e.EndOfItems = endOffset = data.Rows.Count

                Dim i As Integer = itemOffset
                While i < endOffset
                    ZipCombo.Items.Add(New RadComboBoxItem(data.Rows(i)("Info").ToString(), data.Rows(i)("PK").ToString()))
                    System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
                End While


            Catch ex As Exception

            End Try

        End Sub

        Public Function f_ZipCombo_GetData(ByVal text As String) As DataTable

            Dim myCountryID As String = Me.PartyAddrRecordControl.CountryID.SelectedValue

            Dim myDataTable As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_PickZip", text, myCountryID)
            Return myDataTable

        End Function


		Public Sub SaveButton_Click(ByVal sender As Object, ByVal args As EventArgs)


            s_PreSave()

            SaveButton_Click_Base(sender, args)


            Dim myParty_Encrypt As String = Me.Page.Request.QueryString("Party")

            Dim url As String = "../Carrier/EditCarrier.aspx?Party=" & myParty_Encrypt & "&TabIndex=1"

            s_Redirect(sender, args, url)
            ' NOTE: If the Base function redirects to another page, any code here will not be executed.
        End Sub

        Public Sub s_Redirect(ByVal sender As Object, ByVal args As EventArgs, ByVal url As String)


            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = TargetKey
            Dim id As String = DFKA
            Dim value As String = id

            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()


                If (Not Me.IsPageRefresh) Then
                    Me.SaveData()
                End If


                url = Me.ModifyRedirectUrl(url, "", True)
                Me.CommitTransaction(sender)
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.RollBackTransaction(sender)
                shouldRedirect = False
                Me.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try
            If shouldRedirect Then
                Me.ShouldSaveControlsToSession = True
                Me.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
                Me.ShouldSaveControlsToSession = True
                Me.CloseWindow(True)

            End If

        End Sub


        Public Sub s_PreSave()

            Dim myZipID As String = ZipCombo.SelectedValue
            Dim myEmail As String = EmailTB.Text
            Dim myPhone As String = PhoneTB.Text
            Dim myFax As String = FaxTB.Text

            Me.PartyAddrRecordControl.AddrZipID.Text = myZipID
            Me.PartyAddrRecordControl.Email.Text = myEmail
            Me.PartyAddrRecordControl.DirectDail.Text = myPhone
            Me.PartyAddrRecordControl.Fax.Text = myFax

            Dim myAddrToSave As String = Me.PartyAddrRecordControl.Addr.Text

            If String.IsNullOrEmpty(myAddrToSave) = False Then
                myAddrToSave = CustGenClass.f_Sproc("usp_AddrFix", myAddrToSave)
                Me.PartyAddrRecordControl.Addr.Text = myAddrToSave
                Dim myAddress As String = myAddrToSave & ", " & ZipCombo.Text
                Dim myLatLong As String = GetGeoCoords(myAddress, 1)
                Dim myLat As String = CustGenClass.f_Split_ByComma(myLatLong, 2)
                Dim myLong As String = CustGenClass.f_Split_ByComma(myLatLong, 1)
                If myLat <> "0" And myLong <> "0" Then
                    Me.PartyAddrRecordControl.Lat.Text = myLat
                    Me.PartyAddrRecordControl.Long1.Text = myLong
                End If
            End If


        End Sub
        Public Function GetGeoCoords(ByVal inString As String, ByVal inType As Integer) As String
            ' Explanation of function:
            ' Use inType=0 and feed in a specific Google Maps URL to parse out the GeoCoords from the URL
            ' e.g. http://maps.google.com/maps?f=q&source=s_q&hl=en&geocode=&q=53154&sll=37.0625,-95.677068&sspn=52.505328,80.507812&ie=UTF8&ll=42.858224,-88.000832&spn=0.047943,0.078621&t=h&z=14
            ' Function returns a string of geocoords (e.g. "-87.9010610,42.8864960")
            '
            ' Use inType=1 and feed in a zip code, address, or business name
            ' Function returns a string of geocoords (e.g. "-87.9010610,42.8864960")
            ' If an invalid address, zip code or location was entered, the function will return "0,0"

            Dim Chunks As String()
            Dim outString As String = ""

            If inType = 0 Then
                Chunks = Regex.Split(inString, "&")
                For Each s As String In Chunks
                    If InStr(s, "ll") > 0 Then outString = s
                Next
                outString = Replace(Replace(outString, "sll=", ""), "ll=", "")
            Else
                Dim xmlString As String = GetHTML("http://maps.google.com/maps/geo?output=xml&key=abcdefg&q=" & inString, 1)
                Chunks = Regex.Split(xmlString, "coordinates>", RegexOptions.Multiline)
                If Chunks.Length > 1 Then
                    outString = Replace(Chunks(1), ",0</", "")
                Else
                    outString = "0,0"
                End If

            End If
            Return outString
        End Function

        Public Function GetHTML(ByVal sURL As String, ByVal e As Integer) As String
            Dim oHttpWebRequest As System.Net.HttpWebRequest
            Dim oStream As System.IO.Stream
            Dim sChunk As String
            oHttpWebRequest = CType((System.Net.HttpWebRequest.Create(sURL)), Net.HttpWebRequest)
            Dim oHttpWebResponse As System.Net.WebResponse = oHttpWebRequest.GetResponse()
            oStream = oHttpWebResponse.GetResponseStream
            sChunk = New System.IO.StreamReader(oStream).ReadToEnd()
            oStream.Close()
            oHttpWebResponse.Close()
            If e = 0 Then
                Return Server.HtmlEncode(sChunk)
            Else
                Return Server.HtmlDecode(sChunk)
            End If
        End Function

        Public Sub s_Vis()

            Dim myZipID As String = Me.PartyAddrRecordControl.AddrZipID.Text
            If String.IsNullOrEmpty(myZipID) = False Then
                Dim myCitySTZip As String = CustGenClass.f_Sproc("usp_GetCitySTZip", myZipID)
                ZipCombo.SelectedValue = myZipID
                ZipCombo.Text = myCitySTZip
            End If

            EmailTB.Text = Me.PartyAddrRecordControl.Email.Text
            PhoneTB.Text = Me.PartyAddrRecordControl.DirectDail.Text
            FaxTB.Text = Me.PartyAddrRecordControl.Fax.Text

            s_Instructions()

        End Sub



        Public Sub s_Instructions()

            Dim myCtrl As Literal = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "InstructionsStandard"), Literal)

            If Not IsNothing(myCtrl) Then

                Dim myConfigID As String = myCtrl.Text

                If String.IsNullOrEmpty(myConfigID) = False Then

                    Dim myWhere As String = FlowConfigTable.ConfigID.UniqueName & " = " & myConfigID
                    Dim myRec As FlowConfigRecord = FlowConfigTable.GetRecord(myWhere)
                    If Not IsNothing(myRec) Then
                        Me.InstructionsStandard.Text = myRec.Instructions
                        MiscUtils.FindControlRecursively(Me, "InstructionsRow").Visible = True
                    End If

                End If

            End If

        End Sub

      Public Sub SetPageFocus()
      'load scripts to all controls on page so that they will retain focus on PostBack
      Me.LoadFocusScripts(Me.Page)	  
          'To set focus on page load to a specific control pass this control to the SetStartupFocus method. To get a hold of  a control
          'use FindControlRecursively method. For example:
          'Dim controlToFocus As System.Web.UI.WebControls.TextBox = DirectCast(Me.FindControlRecursively("ProductsSearch"), System.Web.UI.WebControls.TextBox)
          'Me.SetFocusOnLoad(controlToFocus)
          'If no control is passed or control does not exist this method will set focus on the first focusable control on the page.
          Me.SetFocusOnLoad()  
      End Sub
       
      Public Sub LoadData()
          ' LoadData reads database data and assigns it to UI controls.
          ' Customize by adding code before or after the call to LoadData_Base()
          ' or replace the call to LoadData_Base().
          LoadData_Base()
          s_Vis()
		
		
      End Sub
      
      Private Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS as Boolean) As String
          Return EvaluateFormula_Base(formula, dataSourceForEvaluate, format, variables, includeDS)
      End Function

      Public Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
            ' Handles MyBase.Init. 
            ' Register the Event handler for any Events.
           Me.Page_InitializeEventHandlers_Base(sender,e)
      End Sub
      
        Protected Overrides Sub SaveControlsToSession()
            SaveControlsToSession_Base()
        End Sub


        Protected Overrides Sub ClearControlsFromSession()
            ClearControlsFromSession_Base()
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            LoadViewState_Base(savedState)
        End Sub


        Protected Overrides Function SaveViewState() As Object
            Return SaveViewState_Base()
        End Function
      
      Public Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
          Me.Page_PreRender_Base(sender,e)
      End Sub


      
      Public Overrides Sub SaveData()
          Me.SaveData_Base()
      End Sub
               
    

      Public Overrides Sub SetChartControl(ByVal chartCtrlName As String)
          Me.SetChartControl_Base(chartCtrlName)
      End Sub    
      
      
      Public Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
          'Override call to PreInit_Base() here to change top level master page used by this page.
          'For example for SharePoint applications uncomment next line to use Microsoft SharePoint default master page
          'If Not Me.Master Is Nothing Then Me.Master.MasterPageFile = Microsoft.SharePoint.SPContext.Current.Web.MasterUrl	
          'You may change here assignment of application theme
          Try
              Me.PreInit_Base()
          Catch ex As Exception
          
          End Try			  
      End Sub
      
#Region "Ajax Functions"

        <Services.WebMethod()> _
        Public Shared Function GetRecordFieldValue(ByVal tableName As String, _
                                                  ByVal recordID As String, _
                                                  ByVal columnName As String, _
                                                  ByVal fieldName As String, _
                                                  ByVal title As String, _
                                                  ByVal persist As Boolean, _
                                                  ByVal popupWindowHeight As Integer, _
                                                  ByVal popupWindowWidth As Integer, _
                                                  ByVal popupWindowScrollBar As Boolean _
                                                  ) As Object()
            ' GetRecordFieldValue gets the pop up window content from the column specified by
            ' columnName in the record specified by the recordID in data base table specified by tableName.
            ' Customize by adding code before or after the call to  GetRecordFieldValue_Base()
            ' or replace the call to  GetRecordFieldValue_Base().
            Return GetRecordFieldValue_Base(tableName, recordID, columnName, fieldName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
        End Function

        <Services.WebMethod()> _
        Public Shared Function GetImage(ByVal tableName As String, _
                                        ByVal recordID As String, _
                                        ByVal columnName As String, _
                                        ByVal title As String, _
                                        ByVal persist As Boolean, _
                                        ByVal popupWindowHeight As Integer, _
                                        ByVal popupWindowWidth As Integer, _
                                        ByVal popupWindowScrollBar As Boolean _
                                        ) As Object()
            ' GetImage gets the Image url for the image in the column "columnName" and
            ' in the record specified by recordID in data base table specified by tableName.
            ' Customize by adding code before or after the call to  GetImage_Base()
            ' or replace the call to  GetImage_Base().
            Return GetImage_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
        End Function
    
      Protected Overloads Overrides Sub BasePage_PreRender(ByVal sender As Object, ByVal e As EventArgs)
          MyBase.BasePage_PreRender(sender, e)
          Base_RegisterPostback()
      End Sub
      
    
      


#End Region

    ' Page Event Handlers - buttons, sort, links
    

        ' Write out the Set methods
        
        
        ' Write out the methods for DataSource

        Public Sub CancelButton_Click(ByVal sender As Object, ByVal args As EventArgs)

            Dim myParty_Encrypt As String = Me.Page.Request.QueryString("Party")
            Dim url As String = "../Carrier/EditCarrier.aspx?Party=" & myParty_Encrypt & "&TabIndex=1"
            url = Me.ModifyRedirectUrl(url, "", True)
            Me.Response.Redirect(url)

        End Sub

#End Region

#Region "Section 2: Do not modify this section."

        Public WithEvents AddressHeaderLabel As System.Web.UI.WebControls.Label
        Public WithEvents AddrLabel As System.Web.UI.WebControls.Literal
        Public WithEvents AddrNameLabel As System.Web.UI.WebControls.Literal
        Public WithEvents CancelButton As ThemeButton
        Public WithEvents ContactInfoLabel As System.Web.UI.WebControls.Label
        Public WithEvents CountryID As System.Web.UI.WebControls.DropDownList
        Public WithEvents DirectDailLabel As System.Web.UI.WebControls.Literal
        Public WithEvents EmailLabel As System.Web.UI.WebControls.Literal
        Public WithEvents emailValidator As System.Web.UI.WebControls.RegularExpressionValidator
        Public WithEvents FaxLabel As System.Web.UI.WebControls.Literal
        Public WithEvents Headquarters As System.Web.UI.WebControls.CheckBox
        Public WithEvents HeadquartersLabel As System.Web.UI.WebControls.Literal
        Public WithEvents InstructionsStandard As System.Web.UI.WebControls.Literal
        Public WithEvents MovedOut As System.Web.UI.WebControls.CheckBox
        Public WithEvents MovedOutLabel As System.Web.UI.WebControls.Literal
        Public WithEvents PageTitle As System.Web.UI.WebControls.Literal
        Public WithEvents PartyAddrRecordControl As FASTPORT.UI.Controls.EditCarrierAddr.PartyAddrRecordControl
        Public WithEvents SaveButton As ThemeButton
        Public WithEvents ValidationSummary1 As ValidationSummary
    
  
        Protected Sub Page_InitializeEventHandlers_Base(ByVal sender As Object, ByVal e As System.EventArgs)            		
           
            ' This page does not have FileInput  control inside repeater which requires "multipart/form-data" form encoding, but it might
            'include ascx controls which in turn do have FileInput controls inside repeater. So check if they set Enctype property.
            If Not String.IsNullOrEmpty(Me.Enctype) Then Me.Page.Form.Enctype = Me.Enctype
                 
    
            ' the following code for accordion is necessary or the Me.{ControlName} will return Nothing
        
            ' Register the Event handler for any Events.
      

          ' Setup the pagination events.
        
            AddHandler Me.CancelButton.Button.Click, AddressOf CancelButton_Click
        
            AddHandler Me.SaveButton.Button.Click, AddressOf SaveButton_Click
        
            Me.SaveButton.Button.Attributes.Add("onclick", "SubmitHRefOnce(this, """ & Me.GetResourceValue("Txt:SaveRecord", "FASTPORT") & """);")
        
          Me.ClearControlsFromSession()
        End Sub

        Private Sub Base_RegisterPostback()
        
              Me.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"SaveButton"))
                        
        End Sub

    

       ' Handles MyBase.Load.  Read database data and put into the UI controls.
       ' If you need to, you can add additional Load handlers in Section 1.
       Protected Overridable Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
           Me.SetPageFocus()
    
            ' Check if user has access to this page.  Redirects to either sign-in page
            ' or 'no access' page if not. Does not do anything if role-based security
            ' is not turned on, but you can override to add your own security.
            Me.Authorize("20;24")
    
            If (Not Me.IsPostBack) Then
            
                ' Setup the header text for the validation summary control.
                Me.ValidationSummary1.HeaderText = GetResourceValue("ValidationSummaryHeaderText", "FASTPORT")
              
            End If
            
            'set value of the hidden control depending on the postback. It will be used by SetFocus script on the client side.	
            Dim clientSideIsPostBack As System.Web.UI.HtmlControls.HtmlInputHidden = DirectCast(Me.FindControlRecursively("_clientSideIsPostBack"), System.Web.UI.HtmlControls.HtmlInputHidden)
            If Not clientSideIsPostBack Is Nothing Then
                If Me.IsPostBack AndAlso Not Me.Request("__EVENTTARGET") = "ChildWindowPostBack" Then
                    clientSideIsPostBack.Value = "Y"
                Else
                    clientSideIsPostBack.Value = "N"
                End If
            End If

            ' Load data only when displaying the page for the first time or if postback from child window
            If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack") Then
                ' Read the data for all controls on the page.
                ' To change the behavior, override the DataBind method for the individual
                ' record or table UI controls.
                Me.LoadData()
            End If
        
        
            Page.Title = "Blank page"
        End Sub

    Public Shared Function GetRecordFieldValue_Base(ByVal tableName As String, _
                                                ByVal recordID As String, _
                                                ByVal columnName As String, _
                                                ByVal fieldName As String, _
                                                ByVal title As String, _
                                                ByVal persist As Boolean, _
                                                ByVal popupWindowHeight As Integer, _
                                                ByVal popupWindowWidth As Integer, _
                                                ByVal popupWindowScrollBar As Boolean _
                                                ) As Object()
        If Not IsNothing(recordID) Then
            recordID = System.Web.HttpUtility.UrlDecode(recordID)
        End If
        Dim content as String = BaseClasses.Utils.MiscUtils.GetFieldData(tableName, recordID, columnName)
    
        content = NetUtils.EncodeStringForHtmlDisplay(content)

        'returnValue is an array of string values.
        'returnValue(0) represents title of the pop up window
        'returnValue(1) represents content of the pop up window
        ' retrunValue(2) represents whether pop up window should be made persistant
        ' or it should closes as soon as mouse moved out.
        ' returnValue(5) represents whether pop up window should contain scroll bar.
        ' returnValue(3), (4) represents pop up window height and width respectivly
        ' (0),(2),(3),(4) and (5)  is initially set as pass through attribute.
        ' They can be modified by going to Attribute tab of the properties window of the control in aspx page.
        Dim returnValue(6) As Object
        returnValue(0) = title
        returnValue(1) = content
        returnValue(2) = persist
        returnValue(3) = popupWindowWidth
        returnValue(4) = popupWindowHeight
        returnValue(5) = popupWindowScrollBar
        Return returnValue
    End Function


    Public Shared Function GetImage_Base(ByVal tableName As String, _
                                    ByVal recordID As String, _
                                    ByVal columnName As String, _
                                    ByVal title As String, _
                                    ByVal persist As Boolean, _
                                    ByVal popupWindowHeight As Integer, _
                                    ByVal popupWindowWidth As Integer, _
                                    ByVal popupWindowScrollBar As Boolean _
                                    ) As Object()
        Dim content As String = "<IMG alt =""" & title & """ src =" & """../Shared/ExportFieldValue.aspx?Table=" & tableName & "&Field=" & columnName & "&Record=" & recordID & """/>"
        'returnValue is an array of string values.
        'returnValue(0) represents title of the pop up window.
        'returnValue(1) represents content ie, image url.
        ' retrunValue(2) represents whether pop up window should be made persistant
        ' or it should closes as soon as mouse moved out.
        ' returnValue(3), (4) represents pop up window height and width respectivly
        ' returnValue(5) represents whether pop up window should contain scroll bar.
        ' (0),(2),(3),(4) and (5) is initially set as pass through attribute.
        ' They can be modified by going to Attribute tab of the properties window of the control in aspx page.
        Dim returnValue(6) As Object
        returnValue(0) = title
        returnValue(1) = content
        returnValue(2) = persist
        returnValue(3) = popupWindowWidth
        returnValue(4) = popupWindowHeight
        returnValue(5) = popupWindowScrollBar
        Return returnValue
    End Function
        
      Public Sub SetChartControl_Base(ByVal chartCtrlName As String)
          ' Load data for each record and table UI control.
        
      End Sub          


    
      
      Public Sub SaveData_Base()
              
        Me.PartyAddrRecordControl.SaveData()
        
      End Sub
      
      

        
    
        Protected Sub SaveControlsToSession_Base()
            MyBase.SaveControlsToSession()
        
        End Sub


        Protected Sub ClearControlsFromSession_Base()
            MyBase.ClearControlsFromSession()
        
        End Sub

        Protected Sub LoadViewState_Base(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
        
        End Sub


        Protected Function SaveViewState_Base() As Object
            
            Return MyBase.SaveViewState()
        End Function


      Public Sub PreInit_Base()
      'If it is SharePoint application this function performs dynamic Master Page assignment.
      
      End Sub
      
      Public Sub Page_PreRender_Base(ByVal sender As Object, ByVal e As System.EventArgs)
     
            ' Load data for each record and table UI control.
                  
            ' Data bind for each chart UI control.
              
      End Sub  

    
        ' Load data from database into UI controls.
        ' Modify LoadData in Section 1 above to customize.  Or override DataBind() in
        ' the individual table and record controls to customize.
        Public Sub LoadData_Base()
            Try
              
                If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack")  Then
                    ' Must start a transaction before performing database operations
                    DbUtils.StartTransaction()
                End If

              
     
                Me.DataBind()

                ' Load and bind data for each record and table UI control.
                        
        Me.PartyAddrRecordControl.LoadData()
        Me.PartyAddrRecordControl.DataBind()
        
    
                ' Load data for chart.
                
            
                ' initialize aspx controls
                
                

            Catch ex As Exception
                ' An error has occured so display an error message.
                Utils.RegisterJScriptAlert(Me, "Page_Load_Error_Message", ex.Message)
            Finally
                If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack")  Then
                    ' End database transaction
                      DbUtils.EndTransaction()
                End If
            End Try
        End Sub
        
        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)
        
        Public Overridable Function EvaluateFormula_Base(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Dim e As FormulaEvaluator = New FormulaEvaluator()

            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If

            If includeDS
                
            End If

            
            e.CallingControl = Me

            e.DataSource = dataSourceForEvaluate


            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If

            If Not String.IsNullOrEmpty(format) AndAlso (String.IsNullOrEmpty(formula) OrElse formula.IndexOf("Format(") < 0) Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function      
        
        Public Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
          Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, True)
        End Function


        Private Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
          Return EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True)
        End Function

        Public Function EvaluateFormula(ByVal formula As String, ByVal includeDS As Boolean) As String
          Return EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS)
        End Function

        Public Function EvaluateFormula(ByVal formula As String) As String
          Return EvaluateFormula(formula, Nothing, Nothing, Nothing, True)
        End Function
 
        

        ' Write out the Set methods
        

        ' Write out the DataSource properties and methods
                

        ' Write out event methods for the page events
        
        ' event handler for Button with Layout
        Public Sub CancelButton_Click_Base(ByVal sender As Object, ByVal args As EventArgs)
              
        Dim shouldRedirect As Boolean = True
        Dim TargetKey As String = Nothing
        Dim DFKA As String = TargetKey
        Dim id As String = DFKA
        Dim value As String = id
      
    Try
    

                TargetKey = Me.Page.Request.QueryString.Item("Target")
                If Not TargetKey Is Nothing Then
                   shouldRedirect = False
                End If
      
            Catch ex As Exception
                shouldRedirect = False
                Me.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
            If shouldRedirect Then
                Me.ShouldSaveControlsToSession = True
                Me.RedirectBack()
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.ShouldSaveControlsToSession = True
            Me.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for Button with Layout
        Public Sub SaveButton_Click_Base(ByVal sender As Object, ByVal args As EventArgs)
              
        Dim shouldRedirect As Boolean = True
        Dim TargetKey As String = Nothing
        Dim DFKA As String = TargetKey
        Dim id As String = DFKA
        Dim value As String = id
      
    Try
    ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
        
              If (Not Me.IsPageRefresh) Then         
                  Me.SaveData()
              End If        
        
            Me.CommitTransaction(sender)
            TargetKey = Me.Page.Request.QueryString.Item("Target")

            If Not TargetKey Is Nothing Then
                  
                      DFKA = NetUtils.GetUrlParam(Me, "DFKA", false)
                      If Not Me.PartyAddrRecordControl Is Nothing AndAlso Not Me.PartyAddrRecordControl.DataSource Is Nothing Then
                      
                      id = Me.PartyAddrRecordControl.DataSource.AddrID.ToString
                      If not String.IsNullOrEmpty(DFKA) then
                          If DFKA.Trim().StartsWith("=") then
                          Dim variables as System.Collections.Generic.IDictionary(Of String, Object) = new System.Collections.Generic.Dictionary(Of String, Object)()
                          variables.Add(Me.PartyAddrRecordControl.DataSource.TableAccess.TableDefinition.TableCodeName, Me.PartyAddrRecordControl.DataSource)
                              value = EvaluateFormula(DFKA, Me.PartyAddrRecordControl.DataSource, Nothing,variables)
                          Else
                              value = Me.PartyAddrRecordControl.DataSource.GetValue(Me.PartyAddrRecordControl.DataSource.TableAccess.TableDefinition.ColumnList.GetByAnyName(DFKA)).ToString
                          End If
                       End If
                          If value is Nothing Then
                              value = id
                          End If
                      
                      Dim Formula As String = Me.Page.Request.QueryString.Item("Formula")
                      If Not Formula Is Nothing Then
                          Dim variables as System.Collections.Generic.IDictionary(Of String, Object) = new System.Collections.Generic.Dictionary(Of String, Object)()
                          variables.Add(Me.PartyAddrRecordControl.DataSource.TableAccess.TableDefinition.TableCodeName, Me.PartyAddrRecordControl.DataSource)
                          value = EvaluateFormula(formula, Me.PartyAddrRecordControl.DataSource, Nothing,variables)
                      End If

                      BaseClasses.Utils.MiscUtils.RegisterAddButtonScript(Me, TargetKey, id, value)
                End If
                shouldRedirect = False
                        
            End If
        
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.RollBackTransaction(sender)
                shouldRedirect = False
                Me.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.ShouldSaveControlsToSession = True
                Me.RedirectBack()
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.ShouldSaveControlsToSession = True
            Me.CloseWindow(True)
        
            End If
        End Sub
                
    
#End Region

  
End Class
  
End Namespace
  