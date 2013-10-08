
' This file implements the code-behind class for AddDocTree.aspx.
' AddDocTree.Controls.vb contains the Table, Row and Record control classes
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
        

#End Region

  
Namespace FASTPORT.UI
  
Partial Public Class AddDocTree
        Inherits BaseApplicationPage
' Code-behind class for the AddDocTree page.
' Place your customizations in Section 1. Do not modify Section 2.
        
#Region "Section 1: Place your customizations here."

        Public Sub s_Vis()

            Dim myFolder As String = Me.Page.Request.QueryString("Folder")

            If myFolder = "Yes" Then
                Me.DocTreeRecordControl.Folder.Checked = True
                Me.DocTreeRecordControl.DocNameLabel.Text = "Folder Name"
                Me.DocTreeRecordControl.DocTypeID.Text = "2512"
                Me.SaveButton.Visible = True
                Me.ConfigureButton.Visible = False
            Else
                Me.SaveButton.Visible = False
                Me.ConfigureButton.Visible = True
                Me.DocTreeRecordControl.Folder.Checked = False
                Me.DocTreeRecordControl.DocTypeID.Text = "2351"
            End If
            s_Instructions(myFolder)

        End Sub

        Public Sub s_Instructions(ByVal myFolder As String)

            Dim myConfigID As String = Nothing
			
			If myFolder = "Yes" Then
                Dim myCtrl As Literal = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "InstructionsStandard"), Literal)
                If Not IsNothing(myCtrl) Then
                    myConfigID = myCtrl.Text
                End If
            Else
                myConfigID = "890"
                Me.DocTreeRecordControl.DocNameLabel.Text = "Document Name"
            End If

            If String.IsNullOrEmpty(myConfigID) = False Then
                Dim myWhere As String = FlowConfigTable.ConfigID.UniqueName & " = " & myConfigID
                Dim myRec As FlowConfigRecord = FlowConfigTable.GetRecord(myWhere)
                If Not IsNothing(myRec) Then
                    Me.InstructionsStandard.Text = myRec.Instructions
                    MiscUtils.FindControlRecursively(Me, "InstructionsRow").Visible = True
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

            s_Vis()
            LoadData_Base()

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
    
		Public Sub CancelButton_Click(ByVal sender As Object, ByVal args As EventArgs)
          
            ClientScript.RegisterStartupScript(Page.GetType(), "mykey", "ChildClose();", True)
            CancelButton_Click_Base(sender, args)

        End Sub
            
		Public Sub SaveButton_Click(ByVal sender As Object, ByVal args As EventArgs)

            ClientScript.RegisterStartupScript(Page.GetType(), "mykey", "ChildClose();", True)
            SaveButton_Click_Base(sender, args)

        End Sub

        Public Sub s_Save(ByVal myDocName As String)

            Dim myCIX As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("CIX"))
            Dim myDocTreeParentID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("DocTreeParent"))

            Try

                DbUtils.StartTransaction()
                Dim myRec As New DocTreeRecord
                myRec.CIX = CInt(myCIX)
                myRec.DocTreeParentID = CInt(myDocTreeParentID)
                myRec.DocName = myDocName
                myRec.Folder = False
                myRec.Save()
                DbUtils.CommitTransaction()
                Dim myDocTreeID As String = CStr(myRec.DocTreeID)
                CustGenClass.s_SetVariables(myDocTreeID)

            Catch ex As Exception

                DbUtils.RollBackTransaction()
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try

        End Sub

        ' Write out the Set methods
        
        
        ' Write out the methods for DataSource
        

        Public Sub ConfigureButton_Click(ByVal sender As Object, ByVal args As EventArgs)

            Dim myDocName As String = Me.DocTreeRecordControl.DocName.Text
            If Not String.IsNullOrEmpty(myDocName) Then
                s_Save(myDocName)
                Dim myDocTreeID As String = CustGenClass.f_GetVariable("myVar1")
                myDocTreeID = CustGenClass.f_Encrypt(myDocTreeID)
                Dim myURL As String = "../DocTree/EditDocTree.aspx?DocTree=" & myDocTreeID & "&Close=Yes"
                Me.Page.Response.Redirect(myURL)
            Else
                Dim myMessage As String = "Please enter a Name before continuing."
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", myMessage)
            End If

        End Sub

#End Region

#Region "Section 2: Do not modify this section."

        Public WithEvents CancelButton As ThemeButton
        Public WithEvents ConfigureButton As ThemeButton
        Public WithEvents DocNameLabel As System.Web.UI.WebControls.Literal
        Public WithEvents DocTreeRecordControl As FASTPORT.UI.Controls.AddDocTree.DocTreeRecordControl
        Public WithEvents Folder As System.Web.UI.WebControls.CheckBox
        Public WithEvents InstructionsStandard As System.Web.UI.WebControls.Literal
        Public WithEvents PageTitle As System.Web.UI.WebControls.Literal
        Public WithEvents RoleID As System.Web.UI.WebControls.DropDownList
        Public WithEvents RoleIDLabel As System.Web.UI.WebControls.Literal
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
        
            AddHandler Me.ConfigureButton.Button.Click, AddressOf ConfigureButton_Click
        
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
            Me.Authorize("20;24;25")
    
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
        
        
            Page.Title = GetResourceValue("Title:Add") + " Document Tree"
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
              
        Me.DocTreeRecordControl.SaveData()
        
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
                        
        Me.DocTreeRecordControl.LoadData()
        Me.DocTreeRecordControl.DataBind()
        
    
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
    
            Catch ex As Exception
                shouldRedirect = False
                Me.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
            If shouldRedirect Then
                Me.ShouldSaveControlsToSession = True
                Me.CloseWindow(True)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.ShouldSaveControlsToSession = True
            Me.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for Button with Layout
        Public Sub ConfigureButton_Click_Base(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
                Me.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
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
                      If Not Me.DocTreeRecordControl Is Nothing AndAlso Not Me.DocTreeRecordControl.DataSource Is Nothing Then
                      
                      id = Me.DocTreeRecordControl.DataSource.DocTreeID.ToString
                      If not String.IsNullOrEmpty(DFKA) then
                          If DFKA.Trim().StartsWith("=") then
                          Dim variables as System.Collections.Generic.IDictionary(Of String, Object) = new System.Collections.Generic.Dictionary(Of String, Object)()
                          variables.Add(Me.DocTreeRecordControl.DataSource.TableAccess.TableDefinition.TableCodeName, Me.DocTreeRecordControl.DataSource)
                              value = EvaluateFormula(DFKA, Me.DocTreeRecordControl.DataSource, Nothing,variables)
                          Else
                              value = Me.DocTreeRecordControl.DataSource.GetValue(Me.DocTreeRecordControl.DataSource.TableAccess.TableDefinition.ColumnList.GetByAnyName(DFKA)).ToString
                          End If
                       End If
                          If value is Nothing Then
                              value = id
                          End If
                      
                      Dim Formula As String = Me.Page.Request.QueryString.Item("Formula")
                      If Not Formula Is Nothing Then
                          Dim variables as System.Collections.Generic.IDictionary(Of String, Object) = new System.Collections.Generic.Dictionary(Of String, Object)()
                          variables.Add(Me.DocTreeRecordControl.DataSource.TableAccess.TableDefinition.TableCodeName, Me.DocTreeRecordControl.DataSource)
                          value = EvaluateFormula(formula, Me.DocTreeRecordControl.DataSource, Nothing,variables)
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
                Me.CloseWindow(True)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.ShouldSaveControlsToSession = True
            Me.CloseWindow(True)
        
            End If
        End Sub
                
    
#End Region

  
End Class
  
End Namespace
  