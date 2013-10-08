
' This file implements the code-behind class for Instructions.aspx.
' Instructions.Controls.vb contains the Table, Row and Record control classes
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
  
Partial Public Class Instructions
        Inherits FlowBaseClass
' Code-behind class for the Instructions page.
' Place your customizations in Section 1. Do not modify Section 2.
        
#Region "Section 1: Place your customizations here."


        Public Overrides Sub s_ButtonClick_2nd(ByVal sender As Object, ByVal args As EventArgs, ByVal myURL As String, _
                                                    Optional ByVal myButtonID As String = Nothing, _
                                                    Optional ByVal myCloseYesNo As String = Nothing, _
                                                    Optional ByVal myButtonFlowStepID As String = Nothing, _
                                                    Optional ByVal Action As String = Nothing, _
                                                    Optional ByVal Close As String = Nothing, _
                                                    Optional ByVal Slider As String = Nothing, _
                                                    Optional ByVal RowOwnerCIX As String = Nothing, _
                                                    Optional ByVal RowOIX As String = Nothing, _
                                                    Optional ByVal FlowStep As String = Nothing, _
                                                    Optional ByVal Party As String = Nothing, _
                                                    Optional ByVal User As String = Nothing, _
                                                    Optional ByVal Message As String = Nothing, _
                                                    Optional ByVal Instance As String = Nothing, _
                                                    Optional ByVal FleetCircle As String = Nothing, _
                                                    Optional ByVal Execution As String = Nothing, _
                                                    Optional ByVal Ad As String = Nothing, _
                                                    Optional ByVal AdActivity As String = Nothing, _
                                                    Optional ByVal CheckIn As String = Nothing, _
                                                    Optional ByVal DocFiled As String = Nothing, _
                                                    Optional ByVal Ord As String = Nothing, _
                                                    Optional ByVal Payment As String = Nothing, _
                                                    Optional ByVal Carrier As String = Nothing, _
                                                    Optional ByVal Driver As String = Nothing, _
                                                    Optional ByVal Addr As String = Nothing, _
                                                    Optional ByVal Role As String = Nothing, _
                                                    Optional ByVal History As String = Nothing, _
                                                    Optional ByVal Parent As String = Nothing, _
                                                    Optional ByVal Email As String = Nothing, _
                                                    Optional ByVal Password As String = Nothing, _
                                                    Optional ByVal Button As String = Nothing, _
                                                    Optional ByVal Verification As String = Nothing, _
                                                    Optional ByVal Doc As String = Nothing
                                                    )



            '*****************************************
            '*****************************************
            'UPDATE FLOW STEPS AS NECESSARY BELOW.
            '*****************************************
            '*****************************************
            Dim myWhere As String
            Dim myPK As String

            myButtonFlowStepID = CustGenClass.f_Decrypt(myButtonFlowStepID)
            Dim myRowOwnerCIX_Decrypt As String = CustGenClass.f_Decrypt(RowOwnerCIX)
            Dim myRowOIX As String = CustGenClass.f_Decrypt(RowOIX)
            Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

            Dim myNextFowConfig As FlowConfigRecord = BaseApplicationPage.f_GetFlowConfig(myButtonFlowStepID, myRowOwnerCIX_Decrypt, , myRowOIX)

            If Not IsNothing(myNextFowConfig) Then
                If myNextFowConfig.SkipJump = False Then

                    If Action = "AcceptFriend" Then

                        myPK = CustGenClass.f_Decrypt(FleetCircle)
                        s_UpdateFlowStep(myButtonFlowStepID, "PartyFleetCircle", myPK)


                    End If


                    If myButtonID = "355" Then

                        Dim myFlowStep_Encrypt As String = DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast("202", String))
                        myURL = "../Dialogues/Instructions.aspx?FlowStep=" & myFlowStep_Encrypt

                    End If

                    If Action = "Apply" Or Action = "ApplyFromLink" Or Action = "AgreementExecution" Then

                        Dim myAdActivityID As String = CustGenClass.f_Decrypt(AdActivity)

                        If Not String.IsNullOrEmpty(myAdActivityID) Then
                            s_UpdateFlowStep(myButtonFlowStepID, "CarrierAdActivity", myAdActivityID)
                        End If

                        Dim myExecutionID As String = CustGenClass.f_Decrypt(Execution)

                        If Not String.IsNullOrEmpty(myExecutionID) Then
                            s_UpdateFlowStep(myButtonFlowStepID, "AgreementExecution", myExecutionID)
                        End If

                    End If

                End If
            End If


            If Action = "LinkToPayPal" Then

                'ANDY:  Here is where you can build the PayPal URL.

                myWhere = FlowConfigTable.ConfigID.UniqueName & " = 525"
                Dim myRec As FlowConfigRecord = FlowConfigTable.GetRecord(myWhere)
                FlowStep = DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(CStr(myRec.FlowStepID), String))

                Dim myRedirectURL As String = myRec.LandingRedirect
                myURL = myRedirectURL
                myURL = CustGenClass.f_URL_Replace(myURL, Action, Close, Slider, RowOwnerCIX, RowOIX, FlowStep, Party, User, Message, Instance, FleetCircle, Execution, Ad, AdActivity, CheckIn, DocFiled, Ord, Payment, Carrier, Driver, Addr, Role, History, Parent, Email, Password, Button, Verification)

                'myURL = Replace(myURL, "{ReturnURL}", myRedirectURL)

            End If

            If myCloseYesNo = "False" Then
                s_Redirect(sender, args, myURL)
            ElseIf myCloseYesNo = "True" Then
                s_Close(myURL)
            End If

        End Sub

        Public Sub s_Login(ByVal myUsername As String, ByVal myPassword As String, ByVal myPartyID As String)

            '******************
            '******************
            'In Land.aspx and Instructions.aspx and SignUp01
            '******************
            '******************
            Dim myLoginSuccess As Boolean = DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.SetLoginInfo(myUsername, myPassword, "")

            Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

            If myLoginSuccess = False Then
                Dim myMessage As String = "WARNING: The system failed to load your page.  If the problem continues, please contact us at fastport.com/contact."
                Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", myMessage)
            Else
                System.Web.HttpContext.Current.Session("PartyID") = myPartyID
                System.Web.HttpContext.Current.Session("ParentPartyID") = myPartyID
            End If

        End Sub

        Public Sub s_Action()

            Dim myAction As String = Me.Page.Request.QueryString("Action")
            Dim myPartyID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Party"))
            Dim myOrdID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Ord"))

            If myAction = "VerifyAccount" Then

                s_VerifyAccount(myPartyID)
                s_ThreadFlow()
                Dim myW As String = PartyTable.PartyID.UniqueName & " = " & myPartyID
                Dim myR As PartyRecord = PartyTable.GetRecord(myW)

                Dim myPassword As String = myR.Password
                Dim myEmail As String = myR.Email
                s_Login(myEmail, myPassword, myPartyID)

                'ANDY: Here is where we can write the token.
            ElseIf myAction = "ReturnWithToken" Then

                Dim myToken As String = "Test"
                s_TokenUpdate(myToken)

            ElseIf myAction = "LinkToPayPal" Then

                '*** -- Checking for a subscription would be a good idea.

                Dim myWhere As String = PartyTable.PartyID.UniqueName & " = " & myPartyID
                Dim myRec As PartyRecord = PartyTable.GetRecord(myWhere)

                If myRec.PayPalTokenSpecified = True Then

                    Dim Action As String = Me.Page.Request.QueryString("Action")
                    Dim User As String = Me.Page.Request.QueryString("User")
                    Dim Party As String = Me.Page.Request.QueryString("Party")
                    Dim Parent As String = Me.Page.Request.QueryString("Parent")

                    Dim myURL As String = f_URL_FromFlowConfig("526", Action, , , , , , Party, User, , , , , , , , , , , , , , , , Parent)

                    Me.Response.Redirect(myURL)

                End If

            ElseIf myAction = "RecordPayment" Then

                Dim myAmount As String = Me.Page.Request.QueryString("Amount")
                Dim myPayRef As String = Me.Page.Request.QueryString("PayRef")
                Dim myDate As String = CStr(Now())

                If myAmount = "{Amount}" Then myAmount = "0.00"
                If myPayRef = "{PayRef}" Then myPayRef = "n/a"

                s_UpdateFlowStep("211", "PaymentFlowStep", myPartyID)
                Dim mySproc As String = CustGenClass.f_Sproc("usp_ServicesRecordPayment", myOrdID, myAmount, myDate, myPayRef)

                'JAR -- Must fix.
                If mySproc = "Paid" Then
                    'f_SystemEmail("11", "1", "5", "3", , myPartyID, , , "{Amount}", myAmount)
                Else
                    'f_SystemEmail("10", "1", "5", "3", , myPartyID, , , "{Balance}", mySproc)
                End If

            End If

        End Sub

        Public Sub s_VerifyAccount(ByVal myPartyID As String)

            Try

                DbUtils.StartTransaction()
                Dim myRec As New PartyRecord 'Record class for table to update.
                myRec = PartyTable.GetRecord(myPartyID, True)
                myRec.RegisteredUserSince = Now() 'Field of fields to update.
                myRec.Save()
                DbUtils.CommitTransaction()

            Catch ex As Exception

                DbUtils.RollBackTransaction()
                Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)

            Finally
                DbUtils.EndTransaction()

            End Try


        End Sub


        Public Sub s_TokenUpdate(ByVal myToken As String)

            Try
                Dim myID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Party"))
                DbUtils.StartTransaction()
                Dim myRec As New PartyRecord 'Record class for table to update.
                myRec = PartyTable.GetRecord(myID, True)
                myRec.PayPalToken = myToken
                DbUtils.CommitTransaction()
                myRec.Save()

            Catch ex As Exception
                DbUtils.RollBackTransaction()
                Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)

            Finally
                DbUtils.EndTransaction()

            End Try

        End Sub
        Public Sub Next1Button_Click(ByVal sender As Object, ByVal args As EventArgs)

            '*****************************************
            '*****************************************
            'DO ACTIONS UNIQUE TO BUTTON CLICKS HERE.
            'BE CAREFUL, IF THE FLOW DATA CHANGES, YOU MAY BE SCREWED.
            'ALSO USE THE myAction PARAMETER TO DRIVE ACTIONS ON THE PAGE.
            '*****************************************
            '*****************************************

            Dim myButtonID As String = Me.Next1Button.Button.Attributes.Item("ButtonID").ToString
            Dim myCloseYesNo As String = Me.Next1Button.Button.Attributes.Item("CloseYesNo").ToString
            Dim myLeftPart As String = Me.Request.Url.GetLeftPart(UriPartial.Authority)
            s_ButtonClick(sender, args, myButtonID, myCloseYesNo, myLeftPart)

        End Sub

        Public Sub Next2Button_Click(ByVal sender As Object, ByVal args As EventArgs)

            Dim myButtonID As String = Me.Next2Button.Button.Attributes.Item("ButtonID").ToString
            Dim myCloseYesNo As String = Me.Next2Button.Button.Attributes.Item("CloseYesNo").ToString
            Dim myLeftPart As String = Me.Request.Url.GetLeftPart(UriPartial.Authority)
            s_ButtonClick(sender, args, myButtonID, myCloseYesNo, myLeftPart)

        End Sub


        Public Sub Next3Button_Click(ByVal sender As Object, ByVal args As EventArgs)

            Dim myButtonID As String = Me.Next3Button.Button.Attributes.Item("ButtonID").ToString
            Dim myCloseYesNo As String = Me.Next3Button.Button.Attributes.Item("CloseYesNo").ToString
            Dim myLeftPart As String = Me.Request.Url.GetLeftPart(UriPartial.Authority)
            s_ButtonClick(sender, args, myButtonID, myCloseYesNo, myLeftPart)

        End Sub


        Public Sub Next4Button_Click(ByVal sender As Object, ByVal args As EventArgs)

            Dim myButtonID As String = Me.Next4Button.Button.Attributes.Item("ButtonID").ToString
            Dim myCloseYesNo As String = Me.Next4Button.Button.Attributes.Item("CloseYesNo").ToString
            Dim myLeftPart As String = Me.Request.Url.GetLeftPart(UriPartial.Authority)
            s_ButtonClick(sender, args, myButtonID, myCloseYesNo, myLeftPart)

        End Sub

        Public Sub RewindButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Dim myFlowStepID As String = Me.RewindButton.Attributes.Item("FlowStepID").ToString
            s_Rewind(sender, args, myFlowStepID)

        End Sub

        Public Sub MessageButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Dim FlowStep As String = Me.Page.Request.QueryString("FlowStep")
            Dim Message As String = Me.Page.Request.QueryString("Message")
            Dim Instance As String = Me.Page.Request.QueryString("Instance")
            Dim RowOwnerCIX As String = Me.Page.Request.QueryString("RowOwnerCIX")
            Dim RowOIX As String = Me.Page.Request.QueryString("RowOIX")
            Dim Party As String = Me.Page.Request.QueryString("Party")
            Dim FleetCircle As String = Me.Page.Request.QueryString("FleetCircle")
            Dim Execution As String = Me.Page.Request.QueryString("Execution")
            Dim AdActivity As String = Me.Page.Request.QueryString("AdActivity")
            Dim CheckIn As String = Me.Page.Request.QueryString("CheckIn")
            Dim DocFiled As String = Me.Page.Request.QueryString("DocFiled")
            Dim Verification As String = Me.Page.Request.QueryString("Verification")
            Dim Doc As String = Me.Page.Request.QueryString("Doc")

            Dim myURL As String = CustGenClass.f_InstanceURL(FlowStep, Instance, Message, RowOwnerCIX, RowOIX, Party, Execution, AdActivity, FleetCircle, CheckIn, DocFiled, Verification, Doc)

            s_Redirect(sender, args, myURL)

        End Sub

        Public Sub DashboardButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            'JAR
            s_Close("/Dashboards/Dashboard.aspx")

        End Sub

        Public Sub s_ThreadFlow()

            Dim myMessageID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Message"))
            Dim mySproc As String = CustGenClass.f_Sproc("usp_ThreadFlowUpdate", "0", myMessageID, "193")

        End Sub

        Public Sub s_Vis()


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

        End Sub

        Private Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula_Base(formula, dataSourceForEvaluate, format, variables, includeDS)
        End Function

        Public Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
            ' Handles MyBase.Init. 
            ' Register the Event handler for any Events.
            Me.Page_InitializeEventHandlers_Base(sender, e)
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

            s_FlowControls()
            s_ShowButtons()
            s_Slider()
            s_Action()

            Me.Page_PreRender_Base(sender, e)

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

#End Region

#Region "Section 2: Do not modify this section."

        Public WithEvents DashboardButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents InstructionsLiteral As System.Web.UI.WebControls.Literal
        Public WithEvents MessageButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents Next1Button As ThemeButton
        Public WithEvents Next2Button As ThemeButton
        Public WithEvents Next3Button As ThemeButton
        Public WithEvents Next4Button As ThemeButton
        Public WithEvents PageTitle As System.Web.UI.WebControls.Literal
        Public WithEvents RewindButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents ValidationSummary1 As ValidationSummary
        Public WithEvents HiddenTB_PageTitle As System.Web.UI.WebControls.TextBox
    
  
        Protected Sub Page_InitializeEventHandlers_Base(ByVal sender As Object, ByVal e As System.EventArgs)            		
           
            ' This page does not have FileInput  control inside repeater which requires "multipart/form-data" form encoding, but it might
            'include ascx controls which in turn do have FileInput controls inside repeater. So check if they set Enctype property.
            If Not String.IsNullOrEmpty(Me.Enctype) Then Me.Page.Form.Enctype = Me.Enctype
                 
    
            ' the following code for accordion is necessary or the Me.{ControlName} will return Nothing
        
            ' Register the Event handler for any Events.
      

          ' Setup the pagination events.
        
              AddHandler Me.DashboardButton.Click, AddressOf DashboardButton_Click
              
              AddHandler Me.MessageButton.Click, AddressOf MessageButton_Click
              
              AddHandler Me.RewindButton.Click, AddressOf RewindButton_Click
              
            AddHandler Me.Next1Button.Button.Click, AddressOf Next1Button_Click
        
            AddHandler Me.Next2Button.Button.Click, AddressOf Next2Button_Click
        
            AddHandler Me.Next3Button.Button.Click, AddressOf Next3Button_Click
        
            AddHandler Me.Next4Button.Button.Click, AddressOf Next4Button_Click
        
          Me.ClearControlsFromSession()
        End Sub

        Private Sub Base_RegisterPostback()
        
        End Sub

    

       ' Handles MyBase.Load.  Read database data and put into the UI controls.
       ' If you need to, you can add additional Load handlers in Section 1.
       Protected Overridable Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
           Me.SetPageFocus()
    
            ' Check if user has access to this page.  Redirects to either sign-in page
            ' or 'no access' page if not. Does not do anything if role-based security
            ' is not turned on, but you can override to add your own security.
            Me.Authorize("")
    
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
        
        ' event handler for ImageButton
        Public Sub DashboardButton_Click_Base(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        
        ' event handler for ImageButton
        Public Sub MessageButton_Click_Base(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Catch ex As Exception
                Me.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Sub RewindButton_Click_Base(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Catch ex As Exception
                Me.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for Button with Layout
        Public Sub Next1Button_Click_Base(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Party/SignUp_01User.aspx?UseCase=1"
                
        Dim shouldRedirect As Boolean = True
        Dim TargetKey As String = Nothing
        Dim DFKA As String = TargetKey
        Dim id As String = DFKA
        Dim value As String = id
      
    Try
    ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
      url = Me.ModifyRedirectUrl(url, "",True)
              
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
                Me.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.ShouldSaveControlsToSession = True
            Me.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for Button with Layout
        Public Sub Next2Button_Click_Base(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Party/SignUp_01User.aspx?UseCase=1"
                
        Dim shouldRedirect As Boolean = True
        Dim TargetKey As String = Nothing
        Dim DFKA As String = TargetKey
        Dim id As String = DFKA
        Dim value As String = id
      
    Try
    ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
      url = Me.ModifyRedirectUrl(url, "",True)
              
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
                Me.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.ShouldSaveControlsToSession = True
            Me.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for Button with Layout
        Public Sub Next3Button_Click_Base(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Party/SignUp_01User.aspx?UseCase=1"
                
        Dim shouldRedirect As Boolean = True
        Dim TargetKey As String = Nothing
        Dim DFKA As String = TargetKey
        Dim id As String = DFKA
        Dim value As String = id
      
    Try
    ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
      url = Me.ModifyRedirectUrl(url, "",True)
              
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
                Me.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.ShouldSaveControlsToSession = True
            Me.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for Button with Layout
        Public Sub Next4Button_Click_Base(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Party/SignUp_01User.aspx?UseCase=1"
                
        Dim shouldRedirect As Boolean = True
        Dim TargetKey As String = Nothing
        Dim DFKA As String = TargetKey
        Dim id As String = DFKA
        Dim value As String = id
      
    Try
    ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
      url = Me.ModifyRedirectUrl(url, "",True)
              
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
                Me.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.ShouldSaveControlsToSession = True
            Me.CloseWindow(True)
        
            End If
        End Sub
                
    
#End Region


    End Class
  
End Namespace
  