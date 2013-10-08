
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports FASTPORT.Business
Imports FASTPORT.Data
Imports Telerik.Web.UI

Imports System.Data.SqlClient

Imports BaseClasses.Utils

Imports BaseClasses

Namespace FASTPORT.UI

    Public Class FlowBaseClass
        Inherits BaseApplicationPage


        '*****************************************
        '*****************************************
        '*****************************************
        '*****************************************
        'JAR
        'PAGE EXAMPLE: /Dialogues/Instructions.aspx
        '
        'The class represents the standardization of the
        'work flow.  Best for "hopping around different
        'URLs.  Meant for for the situation where the user is
        'not on one page the whole time.  
        '
        'TO USE THIS:
        '1.  Add the "ButtonsPanel" like on /Dialogues/Instructions.aspx
        '2.  Change page to inherit FlowBaseClass
        '3.  DON'T FORGET TO COPY THE BUTTON CLICK EVENTS TO THE PAGE.
        '4.  Override where necessary.
        '
        '*****************************************
        '*****************************************
        '*****************************************
        '*****************************************

        Public myFlowConfigRec As FlowConfigRecord



        Public Overridable Sub s_FlowControls()

            '*****************************************
            '*****************************************
            'MUST BE IN PAGE PRERENDER OR LOAD DATA IF DATA EXISTS
            '*****************************************
            '*****************************************

            Dim myFlowStepID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("FlowStep"))
            Dim myRowOwnerCIX As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("RowOwnerCIX"))
            myFlowConfigRec = BaseApplicationPage.f_GetFlowConfig(myFlowStepID, myRowOwnerCIX) 'ADD myRowOwnerCIX if needed, etc.
            Dim myHiddenTB_PageTitle As TextBox = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "HiddenTB_PageTitle"), TextBox)



            If Not IsNothing(myHiddenTB_PageTitle) Then

                Dim myUserID As String = BaseClasses.Utils.SecurityControls.GetCurrentUserID()
                Dim myRowOIX As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("RowOIX"))
                Dim myDocID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Doc"))
                Dim myExecutionID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Execution"))
                myExecutionID = If(myExecutionID, "0")
                myDocID = If(myDocID, "0")
                Dim myPageTitle As String = CustGenClass.f_Sproc("usp_FlowPageTitle", myFlowStepID, myRowOwnerCIX, myRowOIX, myUserID, myDocID, myExecutionID)
                myHiddenTB_PageTitle.Text = myPageTitle

            End If

        End Sub

        Public Overridable Sub s_ShowButtons()

            '*****************************************
            '*****************************************
            'MUST BE IN PAGE PRERENDER OR LOAD DATA IF DATA EXISTS
            '*****************************************
            '*****************************************

            Dim myInstructionsLiteral As Literal = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "InstructionsLiteral"), Literal)
            Dim myNext1Button As ThemeButton = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Next1Button"), ThemeButton)
            Dim myNext2Button As ThemeButton = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Next2Button"), ThemeButton)
            Dim myNext3Button As ThemeButton = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Next3Button"), ThemeButton)
            Dim myNext4Button As ThemeButton = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Next4Button"), ThemeButton)
            Dim myRewindButton As ImageButton = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "RewindButton"), ImageButton)
            Dim myMessageButton As ImageButton = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "MessageButton"), ImageButton)
            Dim myDashboardButton As ImageButton = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "DashboardButton"), ImageButton)

            If IsNothing(myFlowConfigRec) Then
                Dim myFlowStep As String = DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast("256", String))
                Dim myURL As String = "/Dialogues/Instructions.aspx?FlowStep=" & myFlowStep
                Me.Response.Redirect(myURL)
                Exit Sub
            End If

            If Not IsNothing(myFlowConfigRec.Instructions) And Not IsNothing(myInstructionsLiteral) Then
                Dim myInstructions As String = myFlowConfigRec.Instructions.ToString
                myInstructions = f_URL_ReplaceCommon(myInstructions)
                myInstructionsLiteral.Text = myInstructions
            End If


            If myFlowConfigRec.ButtonOneIDSpecified Then

                Dim myButtonRec1 As FlowButtonRecord
                myButtonRec1 = BaseApplicationPage.f_GetFlowButton(myFlowConfigRec, 1)
                If myButtonRec1.HideButton = False Then
                    myNext1Button.Button.Text = myButtonRec1.ButtonText
                    myNext1Button.Button.ToolTip = myButtonRec1.ButtonToolTip
                    myNext1Button.Visible = True
                    myNext1Button.Button.Attributes.Add("ButtonID", myFlowConfigRec.ButtonOneID.ToString)
                    myNext1Button.Button.Attributes.Add("CloseYesNo", myButtonRec1.Redirect.ToString)
                End If

            End If

            If myFlowConfigRec.ButtonTwoIDSpecified Then

                Dim myButtonRec2 As FlowButtonRecord
                myButtonRec2 = BaseApplicationPage.f_GetFlowButton(myFlowConfigRec, 2)
                If myButtonRec2.HideButton = False Then
                    myNext2Button.Button.Text = myButtonRec2.ButtonText
                    myNext2Button.Button.ToolTip = myButtonRec2.ButtonToolTip
                    myNext2Button.Visible = True
                    myNext2Button.Button.Attributes.Add("ButtonID", myFlowConfigRec.ButtonTwoID.ToString)
                    myNext2Button.Button.Attributes.Add("CloseYesNo", myButtonRec2.Redirect.ToString)
                End If

            End If

            If myFlowConfigRec.ButtonThreeIDSpecified Then


                Dim myButtonRec3 As FlowButtonRecord
                myButtonRec3 = BaseApplicationPage.f_GetFlowButton(myFlowConfigRec, 3)
                If myButtonRec3.HideButton = False Then
                    myNext3Button.Button.Text = myButtonRec3.ButtonText
                    myNext3Button.Button.ToolTip = myButtonRec3.ButtonToolTip
                    myNext3Button.Visible = True
                    myNext3Button.Button.Attributes.Add("ButtonID", myFlowConfigRec.ButtonThreeID.ToString)
                    myNext3Button.Button.Attributes.Add("CloseYesNo", myButtonRec3.Redirect.ToString)
                End If
            End If

            If myFlowConfigRec.ButtonFourIDSpecified Then

                Dim myButtonRec4 As FlowButtonRecord
                myButtonRec4 = BaseApplicationPage.f_GetFlowButton(myFlowConfigRec, 4)
                If myButtonRec4.HideButton = False Then
                    myNext4Button.Button.Text = myButtonRec4.ButtonText
                    myNext4Button.Button.ToolTip = myButtonRec4.ButtonToolTip
                    myNext4Button.Visible = True
                    myNext4Button.Button.Attributes.Add("ButtonID", myFlowConfigRec.ButtonFourID.ToString)
                    myNext4Button.Button.Attributes.Add("CloseYesNo", myButtonRec4.Redirect.ToString)
                End If

            End If


            Dim myImageURL As String

            If Not IsNothing(myRewindButton) Then

                If myFlowConfigRec.RewindIDSpecified Then

                    myRewindButton.Visible = True
                    myRewindButton.ToolTip = "Click to go back to the previous step in this workflow."
                    myRewindButton.Attributes.Add("FlowStepID", myFlowConfigRec.RewindID.ToString)

                    myImageURL = BaseApplicationPage.f_ImagePath("2334")
                    myRewindButton.Attributes.Add("src", myImageURL)
                    myRewindButton.Attributes.Add("Width", "25px")
                    myRewindButton.Attributes.Add("Height", "25px")

                Else

                    myRewindButton.Visible = False

                End If

            End If

            If Not IsNothing(myMessageButton) Then

                If myFlowConfigRec.SendMessage = True Then

                    myMessageButton.Visible = True
                    myMessageButton.ToolTip = "Click to send a message to the other party to this workflow."
                    myMessageButton.Attributes.Add("CloseYesNo", "False")

                    myImageURL = BaseApplicationPage.f_ImagePath("2333")
                    myMessageButton.Attributes.Add("src", myImageURL)
                    myMessageButton.Attributes.Add("Width", "30px")
                    myMessageButton.Attributes.Add("Height", "25px")

                Else

                    myMessageButton.Visible = False

                End If

            End If


            If Not IsNothing(myDashboardButton) Then

                If myFlowConfigRec.Dashboard = True Then

                    myDashboardButton.Visible = True
                    myDashboardButton.ToolTip = "Click to jump to your Dashboard without changing this workflow"
                    myDashboardButton.Attributes.Add("CloseYesNo", "False")

                    myImageURL = BaseApplicationPage.f_ImagePath("2335")
                    myDashboardButton.Attributes.Add("src", myImageURL)
                    myDashboardButton.Attributes.Add("Width", "32px")
                    myDashboardButton.Attributes.Add("Height", "25px")

                Else

                    myDashboardButton.Visible = False

                End If

            End If



        End Sub

        Public Overridable Sub s_Slider()

            If Not Page.IsPostBack Then

                Dim mySliderSettings As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Slider"))
                Dim mySliderRow As HtmlTableRow = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "SliderRow"), HtmlTableRow)

                If Not IsNothing(mySliderRow) And Not IsNull(mySliderSettings) Then


                    Dim mySlider As String = CustGenClass.f_Split_ByComma(mySliderSettings, 1)
                    Dim mySliderValue As String = CustGenClass.f_Split_ByComma(mySliderSettings, 2)

                    Dim myRadSlider As RadSlider = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "ProgressRadSlider"), RadSlider)

                    If mySlider = "PaySettings" Then

                        myRadSlider.Width = 500

                        myRadSlider.Items.Add(New RadSliderItem("1. Link to PayPal", "0"))
                        myRadSlider.Items.Add(New RadSliderItem("2. Link Success", "1"))
                        myRadSlider.Items.Add(New RadSliderItem("3. Select Services", "2"))

                        myRadSlider.Value = CInt(mySliderValue)

                    ElseIf mySlider = "CreateAccount" Then

                        myRadSlider.Width = 500

                        myRadSlider.Items.Add(New RadSliderItem("1. Your Sign-on Info", "0"))
                        myRadSlider.Items.Add(New RadSliderItem("2. Your Details", "1"))
                        myRadSlider.Items.Add(New RadSliderItem("3. Your Preferences", "2"))

                        myRadSlider.Value = CInt(mySliderValue)

                    ElseIf mySlider = "PayPal" Then

                        myRadSlider.Width = 500

                        myRadSlider.Items.Add(New RadSliderItem("1. Start", "0"))
                        myRadSlider.Items.Add(New RadSliderItem("2. PayPal Settings", "1"))
                        myRadSlider.Items.Add(New RadSliderItem("3. Finish", "2"))

                        myRadSlider.Value = CInt(mySliderValue)

                    ElseIf mySlider = "AddUser" Then

                        myRadSlider.Width = 400

                        myRadSlider.Items.Add(New RadSliderItem("1. Person Details", "0"))
                        myRadSlider.Items.Add(New RadSliderItem("2. Grant Access", "1"))

                        myRadSlider.Value = CInt(mySliderValue)

                    End If

                    mySliderRow.Visible = True

                ElseIf Not IsNothing(mySliderRow) Then

                    mySliderRow.Visible = False

                End If

            End If

        End Sub

        Public Overridable Sub s_ButtonClick(ByVal sender As Object, ByVal args As EventArgs, ByVal myButtonID As String, ByVal myCloseYesNo As String, Optional ByVal myLeftPart As String = "http://app.fastport.com")

            '*****************************************
            '*****************************************
            'Change flow step here, when required.
            '*****************************************
            '*****************************************

            Dim myWhere As String = FlowButtonTable.ButtonID.UniqueName & " = " & myButtonID
            Dim myRec As FlowButtonRecord = FlowButtonTable.GetRecord(myWhere)
            Dim myButtonFlowStepID As String = myRec.FlowStepID.ToString


            '*****************************************
            '*****************************************
            'LOAD DIFFERENT REQUIRED URL PARAMETERS HERE.
            'YES IN THE 2ND SPOT WHEN YOU WANT TO SEND THE FLOW STEP.
            'ENCRYPT WHERE NECESSARY.
            '*****************************************
            '*****************************************

            'CHANGE THESE IF YOU WANT TO RETURN SOMETHING OTHER THAN WHAT IS IN THE USL
            Dim Action As String = Me.Page.Request.QueryString("Action")
            Dim Close As String = Me.Page.Request.QueryString("Close")
            Dim Slider As String = Me.Page.Request.QueryString("Slider")
            Dim RowOwnerCIX As String = Me.Page.Request.QueryString("RowOwnerCIX")
            Dim RowOIX As String = Me.Page.Request.QueryString("RowOIX")
            Dim FlowStep As String = Me.Page.Request.QueryString("FlowStep")
            Dim Party As String = Me.Page.Request.QueryString("Party")
            Dim User As String = Me.Page.Request.QueryString("User")
            Dim Message As String = Me.Page.Request.QueryString("Message")
            Dim Instance As String = Me.Page.Request.QueryString("Instance")
            Dim FleetCircle As String = Me.Page.Request.QueryString("FleetCircle")
            Dim Execution As String = Me.Page.Request.QueryString("Execution")
            Dim Ad As String = Me.Page.Request.QueryString("Ad")
            Dim AdActivity As String = Me.Page.Request.QueryString("AdActivity")
            Dim CheckIn As String = Me.Page.Request.QueryString("CheckIn")
            Dim DocFiled As String = Me.Page.Request.QueryString("DocFiled")
            Dim Ord As String = Me.Page.Request.QueryString("Ord")
            Dim Payment As String = Me.Page.Request.QueryString("Payment")
            Dim Carrier As String = Me.Page.Request.QueryString("Carrier")
            Dim Driver As String = Me.Page.Request.QueryString("Driver")
            Dim Addr As String = Me.Page.Request.QueryString("Addr")
            Dim Role As String = Me.Page.Request.QueryString("Role")
            Dim History As String = Me.Page.Request.QueryString("History")
            Dim Parent As String = Me.Page.Request.QueryString("Parent")
            Dim Email As String = Me.Page.Request.QueryString("Email")
            Dim Password As String = Me.Page.Request.QueryString("Password")
            Dim Button As String = Me.Page.Request.QueryString("Button")
            Dim Verification As String = Me.Page.Request.QueryString("Verification")
            Dim Doc As String = Me.Page.Request.QueryString("Doc")

            '*****************************************
            '*****************************************
            'If change below, don't forget to change SignDocument.aspx.vb
            '*****************************************
            '*****************************************

            If Action = "Apply" Then

                If myButtonID = "437" Then

                    Parent = DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast("2325", String))

                End If

                If myButtonID = "443" Then

                    Dim myRowOwnerCIX_Decrypt As String = CustGenClass.f_Decrypt(RowOwnerCIX)
                    Dim myRowOIX As String = CustGenClass.f_Decrypt(RowOIX)

                    Dim myExecutionID As String = s_ApplyExecution(myButtonFlowStepID, myRowOwnerCIX_Decrypt, myRowOIX, AdActivity)

                    If Not String.IsNullOrEmpty(myExecutionID) Then

                        Execution = myExecutionID

                    End If

                End If

                If myButtonID = "384" Then

                    Dim myAdActivityID As String = CustGenClass.f_Decrypt(AdActivity)
                    CustGenClass.f_Sproc("usp_AcceptJob", myAdActivityID)

                End If

            End If

            'ButtonFlowStep IS AN EXAMPLE WHERE SOMETHING WILL ALMOST ALWAYS BE DIFFERENT THAN THE ITEM IN THE URL.
            myButtonFlowStepID = DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myButtonFlowStepID, String))
            Dim myURL As String = f_URL_ByButton(myButtonID, Action, Close, Slider, RowOwnerCIX, RowOIX, FlowStep, Party, User, Message, Instance, FleetCircle, Execution, Ad, AdActivity, CheckIn, DocFiled, Ord, Payment, Carrier, Driver, Addr, Role, History, Parent, Email, Password, Button, Verification, myLeftPart, Doc)

            Dim myDecrypt As String = DirectCast(Me.Page, BaseApplicationPage).Decrypt(DirectCast(Execution, String))

            s_ButtonClick_2nd(sender, args, myURL, myButtonID, myCloseYesNo, myButtonFlowStepID, Action, Close, Slider, RowOwnerCIX, RowOIX, FlowStep, Party, User, Message, Instance, FleetCircle, Execution, Ad, AdActivity, CheckIn, DocFiled, Ord, Payment, Carrier, Driver, Addr, Role, History, Parent, Email, Password, Button, Verification, Doc)

        End Sub
        Public Shared Function f_URL_FromFlowStep_Shared(ByVal myFlowStepID As String, _
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
                                                        Optional ByVal Verification As String = Nothing) As String


            FlowStep = CustGenClass.f_Encrypt(myFlowStepID)

            Dim myRowOwnerCIX As String = CustGenClass.f_Decrypt(RowOwnerCIX)
            Dim myRowOIX As String = CustGenClass.f_Decrypt(RowOIX)
            Dim myUserID As String = BaseClasses.Utils.SecurityControls.GetCurrentUserID()

            Dim myURL As String = Nothing
            Dim myFlowConfigRec As FlowConfigRecord = f_GetFlowConfig(myFlowStepID, myRowOwnerCIX, myUserID, myRowOIX)

            If Not IsNothing(myFlowConfigRec) Then
                Dim myConfigID As String = CStr(myFlowConfigRec.ConfigID)
                myURL = CustGenClass.f_Sproc("usp_ParamsByID", "0", myConfigID, "0")
            End If

            If Not String.IsNullOrEmpty(myURL) Then

                myURL = CustGenClass.f_URL_Replace(myURL, Action, Close, Slider, RowOwnerCIX, RowOIX, FlowStep, Party, User, Message, Instance, FleetCircle, Execution, Ad, AdActivity, CheckIn, DocFiled, Ord, Payment, Carrier, Driver, Addr, Role, History, Parent, Email, Password, Button, Verification)

            Else

                Dim myFlowStep As String = CustGenClass.f_Encrypt("316")
                myURL = "/Dialogues/Instructions.aspx?FlowStep=" & myFlowStep

            End If

            Return myURL



        End Function
        Public Overridable Function f_URL_FromFlowStep(ByVal myFlowStepID As String, _
                                                        Optional ByVal Action As String = Nothing, _
                                                        Optional ByVal Close As String = Nothing, _
                                                        Optional ByVal Slider As String = Nothing, _
                                                        Optional ByVal RowOwnerCIX As String = Nothing, _
                                                        Optional ByVal RowOIX As String = Nothing, _
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
                                                        Optional ByVal Doc As String = Nothing) As String


            Dim FlowStep As String = CustGenClass.f_Encrypt(myFlowStepID)

            If String.IsNullOrEmpty(Action) Then
                Action = Me.Page.Request.QueryString(Action)
            End If

            If String.IsNullOrEmpty(Close) Then
                Close = Me.Page.Request.QueryString(Close)
            End If

            If String.IsNullOrEmpty(Slider) Then
                Slider = Me.Page.Request.QueryString(Slider)
            End If

            If String.IsNullOrEmpty(RowOwnerCIX) Then
                RowOwnerCIX = Me.Page.Request.QueryString(RowOwnerCIX)
            End If

            If String.IsNullOrEmpty(RowOIX) Then
                RowOIX = Me.Page.Request.QueryString(RowOIX)
            End If

            If String.IsNullOrEmpty(FlowStep) Then
                FlowStep = Me.Page.Request.QueryString(FlowStep)
            End If

            If String.IsNullOrEmpty(Party) Then
                Party = Me.Page.Request.QueryString(Party)
            End If

            If String.IsNullOrEmpty(User) Then
                User = Me.Page.Request.QueryString(User)
            End If

            If String.IsNullOrEmpty(Message) Then
                Message = Me.Page.Request.QueryString(Message)
            End If

            If String.IsNullOrEmpty(Instance) Then
                Instance = Me.Page.Request.QueryString(Instance)
            End If

            If String.IsNullOrEmpty(FleetCircle) Then
                FleetCircle = Me.Page.Request.QueryString(FleetCircle)
            End If

            If String.IsNullOrEmpty(Execution) Then
                Execution = Me.Page.Request.QueryString(Execution)
            End If

            If String.IsNullOrEmpty(Ad) Then
                Ad = Me.Page.Request.QueryString(Ad)
            End If

            If String.IsNullOrEmpty(AdActivity) Then
                AdActivity = Me.Page.Request.QueryString(AdActivity)
            End If

            If String.IsNullOrEmpty(CheckIn) Then
                CheckIn = Me.Page.Request.QueryString(CheckIn)
            End If

            If String.IsNullOrEmpty(DocFiled) Then
                DocFiled = Me.Page.Request.QueryString(DocFiled)
            End If

            If String.IsNullOrEmpty(Ord) Then
                Ord = Me.Page.Request.QueryString(Ord)
            End If

            If String.IsNullOrEmpty(Payment) Then
                Payment = Me.Page.Request.QueryString(Payment)
            End If

            If String.IsNullOrEmpty(Carrier) Then
                Carrier = Me.Page.Request.QueryString(Carrier)
            End If

            If String.IsNullOrEmpty(Driver) Then
                Driver = Me.Page.Request.QueryString(Driver)
            End If

            If String.IsNullOrEmpty(Addr) Then
                Addr = Me.Page.Request.QueryString(Addr)
            End If

            If String.IsNullOrEmpty(Role) Then
                Role = Me.Page.Request.QueryString(Role)
            End If

            If String.IsNullOrEmpty(History) Then
                History = Me.Page.Request.QueryString(History)
            End If

            If String.IsNullOrEmpty(Parent) Then
                Parent = Me.Page.Request.QueryString(Parent)
            End If

            If String.IsNullOrEmpty(Email) Then
                Email = CustGenClass.f_Decrypt(Email)
            End If

            If String.IsNullOrEmpty(Password) Then
                Password = CustGenClass.f_Decrypt(Password)
            End If

            If String.IsNullOrEmpty(Button) Then
                Button = Me.Page.Request.QueryString(Button)
            End If

            Dim myRowOwnerCIX As String = CustGenClass.f_Decrypt(RowOwnerCIX)
            Dim myRowOIX As String = CustGenClass.f_Decrypt(RowOIX)
            Dim myUserID As String = BaseClasses.Utils.SecurityControls.GetCurrentUserID()

            Dim myURL As String = Nothing
            Dim myFlowConfigRec As FlowConfigRecord = f_GetFlowConfig(myFlowStepID, myRowOwnerCIX, myUserID, myRowOIX)

            If Not IsNothing(myFlowConfigRec) Then
                Dim myConfigID As String = CStr(myFlowConfigRec.ConfigID)
                myURL = CustGenClass.f_Sproc("usp_ParamsByID", "0", myConfigID, "0")
            End If

            If Not String.IsNullOrEmpty(myURL) Then

                myURL = CustGenClass.f_URL_Replace(myURL, Action, Close, Slider, RowOwnerCIX, RowOIX, FlowStep, Party, User, Message, Instance, FleetCircle, Execution, Ad, AdActivity, , DocFiled, Ord, Payment, Carrier, Driver, Addr, Role, History, Parent, Email, Password, Button, Verification, Doc)

            Else

                Dim myFlowStep As String = CustGenClass.f_Encrypt("316")
                myURL = "/Dialogues/Instructions.aspx?FlowStep=" & myFlowStep

            End If

            Return myURL

        End Function

        Public Shared Function f_URL_ByButton(ByVal ButtonID As String, _
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
                                            Optional ByVal myLeftPart As String = "http://app.fastport.com", _
                                            Optional ByVal Doc As String = "Doc"
                                            ) As String

            Dim Where As String = FlowButtonTable.ButtonID.UniqueName & " = " & ButtonID
            Dim Rec As FlowButtonRecord = FlowButtonTable.GetRecord(Where)
            Dim myFlowStepID As String = CStr(Rec.FlowStepID)

            'JAR -- Important to move to the next flow step.
            FlowStep = CustGenClass.f_Encrypt(myFlowStepID)

            Dim myURL As String = ""

            If Not String.IsNullOrEmpty(Button) Then
                Button = CustGenClass.f_Encrypt(ButtonID)
            End If

            Dim myIncludeAttachment As Boolean = Rec.IncludeAttachment
            Dim myAutoMessage As Boolean = Rec.AutoMessage
            Dim mySendMessage As Boolean = Rec.SendMessage
            Dim myGoToCompletion As Boolean = Rec.GoToCompletion
            Dim myRedirectURLSpecified As Boolean = Rec.RedirectURLSpecified


            If Rec.SendMessage = True Then

                Dim myMessageID As String = f_URL_Email_ByButton(myFlowStepID, ButtonID, Action, Execution, AdActivity, RowOwnerCIX, RowOIX, Party, FleetCircle, myLeftPart)

                If Action = "AgreementExecution" Or Action = "Apply" Then

                    If myIncludeAttachment = True Then

                        Dim myExecutionID As String = CustGenClass.f_Decrypt(Execution)
                        CustGenClass.s_AttachExecution(myMessageID, myExecutionID)

                    End If

                End If

                If myAutoMessage = False Then

                    'JAMES -- Fix required so that we can navigate to the page that edits a thread.
                    Dim myMessage_Encrypt As String = CustGenClass.f_Encrypt(myMessageID)
                    ' Get the ThreadInstance for this message
                    Dim myThreadInstanceMessageWhereStr As String = ThreadInstanceMessageTable.MessageID.UniqueName & " = " & myMessageID
                    Dim myThreadInstanceMessageRec As ThreadInstanceMessageRecord = ThreadInstanceMessageTable.GetRecord(myThreadInstanceMessageWhereStr)
                    Dim myThreadInstance_Encrypt As String = CustGenClass.f_Encrypt(myThreadInstanceMessageRec.InstanceID.ToString)
                    myURL = CustGenClass.f_InstanceURL(myFlowStepID, myThreadInstance_Encrypt, myMessage_Encrypt, RowOwnerCIX, RowOIX, Party, Execution, AdActivity, FleetCircle, CheckIn, DocFiled, Verification, , , Doc)

                Else

                    If Not String.IsNullOrEmpty(myMessageID) Then
                        CustGenClass.s_UpdateContent(myMessageID, , , , , "Yes")
                    End If

                End If
            End If


            If mySendMessage = False Or (mySendMessage = True And myAutoMessage = True) Then

                If myGoToCompletion = True Then

                    'If Action = "Apply" Or Action = "AgreementExecution" Then

                    myURL = "/Dialogues/Complete.aspx?Button=" & ButtonID & "&Close=Yes&Action=Apply&RowOwnerCIX=" & RowOwnerCIX & "&RowOIX=" & RowOIX & "&Execution=" & If(Execution, "{Execution}") & "&Party=" & Party & "&AdActivity=" & AdActivity & "&Parent=" & If(Parent, "{Parent}")

                    'Else

                    '    myURL = "/Dialogues/Complete.aspx?Button=" & Button & "&Close=Yes"

                    'End If

                Else

                    Dim myRowOwnerCIX As String = CustGenClass.f_Decrypt(RowOwnerCIX)
                    Dim myRowOIX As String = CustGenClass.f_Decrypt(RowOIX)
                    Dim myUserID As String = BaseClasses.Utils.SecurityControls.GetCurrentUserID()

                    Dim myFlowConfigRec As FlowConfigRecord = f_GetFlowConfig(myFlowStepID, myRowOwnerCIX, myUserID, myRowOIX)

                    If myRedirectURLSpecified Or Not IsNothing(myFlowConfigRec) Then

                        If myRedirectURLSpecified Then
                            myURL = CustGenClass.f_Sproc("usp_ParamsByID", ButtonID, "0", "0")
                        Else
                            Dim myConfigID As String = CStr(myFlowConfigRec.ConfigID)
                            myURL = CustGenClass.f_Sproc("usp_ParamsByID", "0", myConfigID, "0")
                        End If

                    Else

                        Dim myFlowStep As String = CustGenClass.f_Encrypt("316")
                        myURL = "/Dialogues/Instructions.aspx?FlowStep=" & myFlowStep

                    End If

                End If


            End If

            If ButtonID = "299" Then

                Dim myPartyID_Decrypt As String = CustGenClass.f_Decrypt(Party)
                Dim myIsDriver As String = CustGenClass.f_Sproc("usp_RoleHold", myPartyID_Decrypt, "Null", "18")
                Dim myLeftURL As String = "../Driver/DriverSnapshot.aspx?"

                If myIsDriver <> "Yes" Then

                    myLeftURL = "../Party/PersonSnapshot.aspx?"

                End If

                myURL = myLeftURL & "Action=FindFriends&Close=Yes&Party=" & Party

            End If

            'If Right(myURL, 1) = "+" Then
            '    Dim myDefaultURLParams As String = CustGenClass.f_Sproc("usp_FlowURLParams", myFlowStepID)
            '    If Not String.IsNullOrEmpty(myDefaultURLParams) Then
            '        myURL = Left(myURL, Len(myURL) - 1) & myDefaultURLParams
            '    Else
            '        myURL = Left(myURL, Len(myURL) - 1)
            '    End If
            'End If

            myURL = CustGenClass.f_URL_Replace(myURL, Action, Close, Slider, RowOwnerCIX, RowOIX, FlowStep, Party, User, Message, Instance, FleetCircle, Execution, Ad, AdActivity, , DocFiled, Ord, Payment, Carrier, Driver, Addr, Role, History, Parent, Email, Password, Button, Verification)

            Return myURL

        End Function

        Public Overridable Sub s_Rewind(ByVal sender As Object, ByVal args As EventArgs, ByVal myFlowStepID As String)

            'CHANGE THESE IF YOU WANT TO RETURN SOMETHING OTHER THAN WHAT IS IN THE USL
            Dim Button As String = Me.Page.Request.QueryString("Button")
            Dim FlowStep As String = Me.Page.Request.QueryString("FlowStep")
            Dim Action As String = Me.Page.Request.QueryString("Action")
            Dim User As String = Me.Page.Request.QueryString("User")
            Dim Role As String = Me.Page.Request.QueryString("Role")
            Dim RowOwnerCIX As String = Me.Page.Request.QueryString("RowOwnerCIX")
            Dim RowOIX As String = Me.Page.Request.QueryString("RowOIX")
            Dim Party As String = Me.Page.Request.QueryString("Party")
            Dim Instance As String = Me.Page.Request.QueryString("Instance")
            Dim Message As String = Me.Page.Request.QueryString("Message")
            Dim Execution As String = Me.Page.Request.QueryString("Execution")
            Dim Email As String = Me.Page.Request.QueryString("Email")
            Dim Password As String = Me.Page.Request.QueryString("Password")
            Dim FleetCircle As String = Me.Page.Request.QueryString("FleetCircle")
            Dim Ord As String = Me.Page.Request.QueryString("Ord")
            Dim Parent As String = Me.Page.Request.QueryString("Parent")
            Dim AdActivity As String = Me.Page.Request.QueryString("AdActivity")
            Dim Verification As String = Me.Page.Request.QueryString("Verification")
            Dim Doc As String = Me.Page.Request.QueryString("Doc")

            Dim CheckCrypto As Crypto = New Crypto(Crypto.Providers.DES)

            If Not String.IsNullOrEmpty(Execution) Then
                Dim myPK As String = CheckCrypto.Decrypt(Execution)
                s_UpdateFlowStep(myFlowStepID, "AgreementExecution", myPK)
            End If

            If Not String.IsNullOrEmpty(AdActivity) Then
                Dim myPK As String = CheckCrypto.Decrypt(AdActivity)
                s_UpdateFlowStep(myFlowStepID, "CarrierAdActivity", myPK)
            End If

            'JAR -- To make sure that we navigate to the correct record.
            Dim myFlowStepNew As String = CheckCrypto.Encrypt(myFlowStepID)

            Dim myURL As String = f_URL_FromFlowStep(myFlowStepID, Action, , , RowOwnerCIX, RowOIX, Party, User, Message, Instance, FleetCircle, Execution, , AdActivity, , , Ord, , , , , Role, , Parent, Email, Password, Button, Verification, Doc)

            s_Redirect(sender, args, myURL)

        End Sub

        Public Shared Function f_URL_FromFlowConfig(ByVal myConfigID As String,
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
                                                        Optional ByVal Verification As String = Nothing
                                            ) As String


            Dim myWhere As String = FlowConfigTable.ConfigID.UniqueName & " = " & myConfigID
            Dim myRec As FlowConfigRecord = FlowConfigTable.GetRecord(myWhere)

            Dim myURL As String = ""

            If Not IsNothing(myRec) Then

                Dim CheckCrypto As Crypto = New Crypto(Crypto.Providers.DES)
                Dim myFlowStep As String = CheckCrypto.Encrypt(CStr(myRec.FlowStepID))

                myURL = CustGenClass.f_Sproc("usp_ParamsByID", "0", myConfigID, "0")

                Dim myFlowStepID As String = CStr(myRec.FlowStepID)

                'If Right(myURL, 1) = "+" Then
                '    Dim myDefaultURLParams As String = CustGenClass.f_Sproc("usp_FlowURLParams", myFlowStepID)
                '    If Not String.IsNullOrEmpty(myDefaultURLParams) Then
                '        myURL = Left(myURL, Len(myURL) - 1) & myDefaultURLParams
                '    Else
                '        myURL = Left(myURL, Len(myURL) - 1)
                '    End If
                'End If

                If Not String.IsNullOrEmpty(myURL) Then
                    myURL = CustGenClass.f_URL_Replace(myURL, Action, Close, Slider, RowOwnerCIX, RowOIX, FlowStep, Party, User, Message, Instance, FleetCircle, Execution, Ad, AdActivity, , DocFiled, Ord, Payment, Carrier, Driver, Addr, Role, History, Parent, Email, Password, Button, Verification)

                End If

            End If

            Return myURL

        End Function


        Public Overridable Sub s_ButtonClick_2nd(ByVal sender As Object, ByVal args As EventArgs, ByVal myURL As String, _
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
            'Examples below.
            '*****************************************
            '*****************************************

            Dim myPK As String = Nothing
            myButtonFlowStepID = CustGenClass.f_Decrypt(myButtonFlowStepID)

            myButtonFlowStepID = CustGenClass.f_Decrypt(myButtonFlowStepID)
            Dim myRowOwnerCIX_Decrypt As String = CustGenClass.f_Decrypt(RowOwnerCIX)
            Dim myRowOIX As String = CustGenClass.f_Decrypt(RowOIX)

            Dim myNextFowConfig As FlowConfigRecord = BaseApplicationPage.f_GetFlowConfig(myButtonFlowStepID, myRowOwnerCIX_Decrypt, , myRowOIX)

            If Not IsNothing(myNextFowConfig) Then

                If myNextFowConfig.SkipJump = False Then

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

                    If (Action = "Apply" Or Action = "ApplyFromLink") Then

                        If Action = "ApplyFromLink" And myButtonID = "469" Then

                            'JAR
                            s_Inquire(myPK, AdActivity, RowOIX, RowOwnerCIX, AdActivity)

                        End If

                    End If

                    If Action = "PayPal" Then

                        myPK = CustGenClass.f_Decrypt(Party)
                        s_UpdateFlowStep(myButtonFlowStepID, "PartyPaySettings", myPK)

                    End If

                End If
            End If

            If myCloseYesNo = "False" Then
                s_Redirect(sender, args, myURL)
            ElseIf myCloseYesNo = "True" Then
                s_Close(myURL, Action)
            End If

        End Sub

        Public Sub s_Inquire(ByRef myPartyID As String, ByRef myAdActivity As String, ByVal CarrierEncrypt As String, ByVal TruckerEncrypt As String, ByVal AdActivityEncrypt As String)

            Dim myTruckerID As String = CustGenClass.f_Decrypt(TruckerEncrypt)
            Dim myLinkID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Link"))
            Dim myW As String = CarrierAdActivityTable.AdActivityID.UniqueName & " = " & myAdActivity
            Dim myR As CarrierAdActivityRecord = CarrierAdActivityTable.GetRecord(myW)

            Dim myAdID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Ad"))
            Dim mySproc As String = CustGenClass.f_Sproc("usp_AdActivityApply", myTruckerID, myAdID, "360", myLinkID)
            Dim myAdActivityID As String = CustGenClass.f_Split_ByComma(mySproc, 1)
            Dim myMessageID As String = CustGenClass.f_Split_ByComma(mySproc, 2)

            myPartyID = CustGenClass.f_Decrypt(myPartyID)
            Dim myLeftPart As String = Me.Request.Url.GetLeftPart(UriPartial.Authority)
            CustGenClass.s_URL_UpdateCommonContent(myMessageID, , "3", myPartyID, , , , , , , , , , , , , , , , myPartyID, , myAdActivityID)
            CustGenClass.s_URL_Update(myMessageID, , myLeftPart, , , , , myPartyID, myTruckerID, , , , , , , CStr(myR.ExecutionID), , myAdActivityID)

        End Sub

        Public Overridable Sub s_Redirect(ByVal sender As Object, ByVal args As EventArgs, ByVal url As String)

            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.

            Me.ShouldSaveControlsToSession = True
            Me.Response.Redirect(url)

        End Sub

        Public Overridable Sub s_Close(ByVal myURL As String, Optional ByVal myAction As String = Nothing)

            Me.ShouldSaveControlsToSession = True
            Me.CloseWindow(True)

            If myAction = "Apply" Or myAction = "PayPal" Then
                If String.IsNullOrEmpty(myURL) Then
                    ClientScript.RegisterStartupScript(Page.GetType(), "mykey", "ChildCloseAndRedirect('RefreshApply');", True)
                Else
                    ClientScript.RegisterStartupScript(Page.GetType(), "mykey", "ChildCloseAndRedirect('RefreshApply," & myURL & "');", True)
                End If
            ElseIf String.IsNullOrEmpty(myURL) Then
                ClientScript.RegisterStartupScript(Page.GetType(), "mykey", "ChildClose();", True)
            Else
                ClientScript.RegisterStartupScript(Page.GetType(), "mykey", "ChildCloseAndRedirect('Redirect," & myURL & "');", True)
            End If

        End Sub


        Public Shared Sub s_UpdateFlowStep(ByVal myButtonFlowStepID As String, ByVal myTable As String, ByVal myPK As String)

            If myTable = "Party" Then
                s_UpdateFlowStep_Party(myPK, myButtonFlowStepID)
            ElseIf myTable = "PartyFleetCircle" Then
                s_UpdateFlowStep_Circle(myPK, myButtonFlowStepID)
            ElseIf myTable = "ThreadInstance" Then
                s_UpdateFlowStep_ThreadInstance(myPK, myButtonFlowStepID)
            ElseIf myTable = "AgreementExecution" Then
                s_UpdateFlowStep_AgreementExecution(myPK, myButtonFlowStepID)
            ElseIf myTable = "CarrierAdActivity" Then
                s_UpdateFlowStep_CarrierAdActivity(myPK, myButtonFlowStepID)
            ElseIf myTable = "PartyPaySettings" Then
                s_UpdateFlowStep_PartyPaySettings(myPK, myButtonFlowStepID)
            End If

        End Sub

        Public Shared Sub s_UpdateFlowStep_Party(ByVal myPK As String, ByVal myFlowStep As String)


            Try
                DbUtils.StartTransaction()
                Dim myRec As New PartyRecord 'Record class for table to update.
                myRec = PartyTable.GetRecord(myPK, True)
                myRec.AccountFlowStepID = CInt(myFlowStep)
                DbUtils.CommitTransaction()
                myRec.Save()

            Catch ex As Exception

                DbUtils.RollBackTransaction()

            Finally

                DbUtils.EndTransaction()

            End Try

        End Sub


        Public Shared Sub s_UpdateFlowStep_Circle(ByVal myPK As String, ByVal myFlowStep As String)


            Try
                DbUtils.StartTransaction()
                Dim myRec As New PartyFleetCircleRecord 'Record class for table to update.
                myRec = PartyFleetCircleTable.GetRecord(myPK, True)
                myRec.StatusID = CInt(myFlowStep)
                DbUtils.CommitTransaction()
                myRec.Save()

            Catch ex As Exception

                DbUtils.RollBackTransaction()

            Finally

                DbUtils.EndTransaction()

            End Try

        End Sub


        Public Shared Sub s_UpdateFlowStep_ThreadInstance(ByVal myPK As String, ByVal myFlowStep As String)


            Try
                DbUtils.StartTransaction()
                Dim myRec As New ThreadInstanceRecord 'Record class for table to update.
                myRec = ThreadInstanceTable.GetRecord(myPK, True)
                myRec.FlowStepID = CInt(myFlowStep)
                DbUtils.CommitTransaction()
                myRec.Save()

            Catch ex As Exception

                DbUtils.RollBackTransaction()

            Finally

                DbUtils.EndTransaction()

            End Try

        End Sub

        Public Shared Sub s_UpdateFlowStep_AgreementExecution(ByVal myPK As String, ByVal myFlowStep As String)


            Try
                DbUtils.StartTransaction()
                Dim myRec As New AgreementExecutionRecord 'Record class for table to update.
                myRec = AgreementExecutionTable.GetRecord(myPK, True)
                myRec.FlowStepID = CInt(myFlowStep)
                DbUtils.CommitTransaction()
                myRec.Save()

            Catch ex As Exception

                DbUtils.RollBackTransaction()

            Finally

                DbUtils.EndTransaction()

            End Try

        End Sub

        Public Shared Sub s_UpdateFlowStep_CarrierAdActivity(ByVal myPK As String, ByVal myFlowStep As String)


            Try
                DbUtils.StartTransaction()
                Dim myRec As New CarrierAdActivityRecord 'Record class for table to update.
                myRec = CarrierAdActivityTable.GetRecord(myPK, True)
                myRec.FlowStepID = CInt(myFlowStep)
                DbUtils.CommitTransaction()
                myRec.Save()

            Catch ex As Exception

                DbUtils.RollBackTransaction()

            Finally

                DbUtils.EndTransaction()

            End Try

        End Sub


        Public Shared Sub s_UpdateFlowStep_PartyPaySettings(ByVal myPK As String, ByVal myFlowStep As String)


            Dim myW As String = PartyPaySettingsTable.PartyID.UniqueName & " = " & myPK
            Dim myR As PartyPaySettingsRecord = PartyPaySettingsTable.GetRecord(myW)
            Dim myPaySettingsID As String = CStr(myR.PaySettingsID)

            Try

                DbUtils.StartTransaction()
                Dim myRec As New PartyPaySettingsRecord 'Record class for table to update.
                myRec = PartyPaySettingsTable.GetRecord(myPaySettingsID, True)
                myRec.FlowStepID = CInt(myFlowStep)
                DbUtils.CommitTransaction()
                myRec.Save()

            Catch ex As Exception

                DbUtils.RollBackTransaction()

            Finally

                DbUtils.EndTransaction()

            End Try

        End Sub


        Public Shared Function f_URL_Launch(ByVal myMessageID As String, ByVal myUserID As String, ByVal myR As ThreadInstanceMessageRecord) As String

            '*****************************************
            '*****************************************
            'CROSS-REFERENCE:  Landing.aspx/LandingSecured.aspx (FlowBasePage)
            'SIMILAR -- NOT EXACT
            '*****************************************
            '*****************************************

            Dim myCIX As String = CStr(myR.RowOwnerCIX)
            Dim myOIX As String = CStr(myR.RowOIX)
            Dim myFlowStepID As String = CStr(myR.FlowStep)
            myFlowStepID = CustGenClass.f_Sproc("usp_FlowStep_Current", myFlowStepID, myMessageID)
            Dim myFlowConfigRec As FlowConfigRecord = BaseApplicationPage.f_GetFlowConfig(myFlowStepID, myCIX, myUserID, myOIX)
            Dim myURL As String = Nothing

            If IsNothing(myFlowConfigRec) And Not String.IsNullOrEmpty(myR.ActionURL) Then

                myURL = myR.ActionURL

                If myR.ExcludeParams = False Then
                    myURL = myURL & CustGenClass.f_Sproc("usp_Params_FromMessage", myMessageID)
                End If

            ElseIf Not IsNothing(myFlowConfigRec) Then

                Dim myConfigID As String = CStr(myFlowConfigRec.ConfigID)

                If String.IsNullOrEmpty(myR.ActionURL) Then

                    myURL = CustGenClass.f_Sproc("usp_ParamsByID", "0", myConfigID, "0")

                Else

                    myURL = myR.ActionURL

                    '******************************************
                    '******************************************
                    'COMPLEX URLs from Buttons
                    '******************************************
                    '******************************************
                    If myURL = "{ViewFriendURL}" Then
                        Dim myPartyID As String = CStr(myR.RowOwnerCIX)
                        Dim myIsDriver As String = CustGenClass.f_Sproc("usp_RoleHold", myPartyID, "Null", "18")
                        myURL = "../Driver/DriverSnapshot.aspx?"
                        If myIsDriver <> "Yes" Then
                            myURL = "../Party/PersonSnapshot.aspx?"
                        End If
                        myURL = myURL & "Action=MyFriend&Close=Yes&Party={RowOwnerCIX}"
                    End If
                    '******************************************
                    '******************************************
                    'END
                    '******************************************
                    '******************************************

                    If myR.ExcludeParams = False Then
                        myURL = myURL & CustGenClass.f_Sproc("usp_ParamsByID", "0", myConfigID, "0", "Yes")
                    End If

                End If

            End If

            If String.IsNullOrEmpty(myURL) Then

                Dim myFlowStep As String = CustGenClass.f_Encrypt("316")
                myURL = "/Dialogues/Instructions.aspx?FlowStep=" & myFlowStep

            Else

                myURL = CustGenClass.f_URL_Replace_FromMessageRec(myURL, myR)

            End If

            Return myURL

        End Function

        Public Overridable Function f_URL_ReplaceCommon(ByVal myToReplace As String, _
                                                            Optional ByVal About As String = Nothing, _
                                                            Optional ByVal ButtonText As String = Nothing, _
                                                            Optional ByVal WildTag1 As String = Nothing, _
                                                            Optional ByVal WildValue1 As String = Nothing, _
                                                            Optional ByVal WildTag2 As String = Nothing, _
                                                            Optional ByVal WildValue2 As String = Nothing, _
                                                            Optional ByVal WildTag3 As String = Nothing, _
                                                            Optional ByVal WildValue3 As String = Nothing, _
                                                            Optional ByVal WildTag4 As String = Nothing, _
                                                            Optional ByVal WildValue4 As String = Nothing, _
                                                            Optional ByVal WildTag5 As String = Nothing, _
                                                            Optional ByVal WildValue5 As String = Nothing) As String

            Dim FlowStep As String = Me.Page.Request.QueryString("FlowStep")
            Dim Action As String = Me.Page.Request.QueryString("Action")
            Dim User As String = Me.Page.Request.QueryString("User")
            Dim Role As String = Me.Page.Request.QueryString("Role")
            Dim RowOwnerCIX As String = Me.Page.Request.QueryString("RowOwnerCIX")
            Dim RowOIX As String = Me.Page.Request.QueryString("RowOIX")
            Dim Party As String = Me.Page.Request.QueryString("Party")
            Dim AdActivity As String = Me.Page.Request.QueryString("AdActivity")
            Dim Execution As String = Me.Page.Request.QueryString("Execution")

            Dim myReturn As String = myToReplace

            If Not String.IsNullOrEmpty(About) Then

                About = CustGenClass.f_Decrypt(About)

            End If

            If Not String.IsNullOrEmpty(FlowStep) Then

                FlowStep = CustGenClass.f_Decrypt(FlowStep)

            End If

            If Not String.IsNullOrEmpty(Action) Then

                Action = CustGenClass.f_Decrypt(Action)

            End If

            If Not String.IsNullOrEmpty(Role) Then

                Role = CustGenClass.f_Decrypt(Role)

            End If


            If Not String.IsNullOrEmpty(RowOwnerCIX) Then

                RowOwnerCIX = CustGenClass.f_Decrypt(RowOwnerCIX)

            End If


            If Not String.IsNullOrEmpty(RowOIX) Then

                RowOIX = CustGenClass.f_Decrypt(RowOIX)

            End If

            If Not String.IsNullOrEmpty(Party) Then

                Party = CustGenClass.f_Decrypt(Party)

            End If

            If Not String.IsNullOrEmpty(AdActivity) Then

                AdActivity = CustGenClass.f_Decrypt(AdActivity)

            End If

            If Not String.IsNullOrEmpty(Execution) Then

                Execution = CustGenClass.f_Decrypt(Execution)

            End If

            myReturn = CustGenClass.f_URL_ReplaceCommonText(myReturn, RowOwnerCIX, RowOIX, About, ButtonText, WildTag1, WildValue1, WildTag2, WildValue2, WildTag3, WildValue3, WildTag4, WildValue4, WildTag5, WildValue5, FlowStep, Action, Party, Role, AdActivity, Execution)

            Return myReturn

        End Function



        Public Shared Function f_URL_Email_ByButton(ByVal myFlowStepID As String, Optional ByVal myButtonID As String = Nothing, Optional ByVal myAction As String = Nothing, _
                                                        Optional ByVal myExecutionID As String = Nothing, Optional ByVal myAdActivityID As String = Nothing, _
                                                        Optional ByVal RowOwnerCIX As String = Nothing, Optional ByVal RowOIX As String = Nothing, _
                                                        Optional ByVal Party As String = Nothing, Optional ByVal FleetCircle As String = Nothing, _
                                                        Optional ByVal LeftPartURL As String = Nothing) As String

            '***********************************
            '***********************************
            'IMPORTANT: If you want add messsages to
            'existing instances.  You will need to store
            'the instance ID on the relevant table, and
            'then call the instance ID here.
            '***********************************
            '***********************************

            Dim myMessageID As String = "0"
            Dim myInstanceID As String = "0"
            Dim myUserID As String = BaseClasses.Utils.SecurityControls.GetCurrentUserID()
            Dim myRecipientID As String = Nothing
            Dim myW As String = Nothing

            Dim mySproc As String

            RowOwnerCIX = CustGenClass.f_Decrypt(RowOwnerCIX)
            RowOIX = CustGenClass.f_Decrypt(RowOIX)

            Dim myAdName As String = Nothing

            If Not String.IsNullOrEmpty(myAdActivityID) Then
                myAdActivityID = CustGenClass.f_Decrypt(myAdActivityID)
                mySproc = CustGenClass.f_Sproc("usp_ThreadGetInstance", "CarrierAdActivity", myFlowStepID, myAdActivityID)
                myInstanceID = CustGenClass.f_Split_ByComma(mySproc, 2)
            ElseIf Not String.IsNullOrEmpty(myExecutionID) Then
                myExecutionID = CustGenClass.f_Decrypt(myExecutionID)
                mySproc = CustGenClass.f_Sproc("usp_ThreadGetInstance", "AgreementExecution", myFlowStepID, myExecutionID)
                Dim my1st As String = CustGenClass.f_Split_ByComma(mySproc, 1)
                Dim my2nd As String = CustGenClass.f_Split_ByComma(mySproc, 2)
                myInstanceID = "0"
                If my1st = "Thread" Or my1st = "Instance" Then
                    myW = AgreementExecutionTable.ExecutionID.UniqueName & " = " & myExecutionID
                    Dim myRec As AgreementExecutionRecord = AgreementExecutionTable.GetRecord(myW)
                    Dim myCIX As String = CType(HttpContext.Current.Session("ParentPartyID"), String)
                    Dim mySenderSignerID As String = myUserID
                    myRecipientID = CStr(myRec.RecipientSignerID)
                    If my1st = "Thread" Then
                        myInstanceID = CustGenClass.f_Sproc("usp_ThreadInstanceAdd", my2nd, myCIX, mySenderSignerID, "Yes", "", myRecipientID)
                        CustGenClass.s_InstanceRelatedIDsUpdate(myInstanceID, myExecutionID, myAdActivityID)
                    Else
                        myInstanceID = my2nd
                    End If
                End If
            End If

            If Not String.IsNullOrEmpty(FleetCircle) Then
                FleetCircle = CustGenClass.f_Decrypt(FleetCircle)
                myW = PartyFleetCircleTable.FleetCircleID.UniqueName & " = " & FleetCircle
                Dim myR_Circle As PartyFleetCircleRecord = PartyFleetCircleTable.GetRecord(myW)
                myInstanceID = CStr(myR_Circle.InstanceID)
                Dim myFleetID As String = CStr(myR_Circle.FleetID)
                myW = PartyFleetTable.FleetID.UniqueName & " = " & myFleetID
                Dim myR_Fleet As PartyFleetRecord = PartyFleetTable.GetRecord(myW)
                Dim myFleet_PartyID As String = CStr(myR_Fleet.MyPartyID)
                Dim myFleet_BuddyID As String = CStr(myR_Fleet.MyBuddyID)
                If myUserID = myFleet_PartyID Then
                    myRecipientID = myFleet_BuddyID
                Else
                    myRecipientID = myFleet_PartyID
                End If
            End If

            If String.IsNullOrEmpty(myInstanceID) Then
                myInstanceID = CustGenClass.f_Sproc("usp_ThreadInstanceAdd", "5", "Null", myUserID, "Yes")
            End If

            Dim myCollectionID As String = CustGenClass.f_FlowCollectionIDGet(myFlowStepID)

            Dim CIXName As String = CustGenClass.f_GetPartyName(RowOwnerCIX)
            Dim OIXName As String = CustGenClass.f_GetPartyName(RowOIX)
            Party = CustGenClass.f_Decrypt(Party)

            myMessageID = CustGenClass.f_URL_MessageCreate(myInstanceID, myButtonID, myUserID, myRecipientID, , "{CIXName}", CIXName, "{OIXName}", OIXName, , , , , , , , , , , myAdActivityID, myExecutionID, "37")
            CustGenClass.s_URL_Update(myMessageID, myCollectionID, LeftPartURL, , myAction, , , RowOwnerCIX, RowOIX, myFlowStepID, Party, myUserID, myMessageID, myInstanceID, FleetCircle, myExecutionID, , myAdActivityID, , , , , , , , , , , , , myButtonID)

            Return myMessageID

        End Function

        Public Function s_ApplyExecution(ByVal myButtonFlowStepID As String, ByVal myRowOwnerCIX_Decrypt As String, ByVal myRowOIX As String, Optional ByVal AdActivity As String = Nothing) As String

            Dim myWhere As String
            Dim CheckCrypto As Crypto = New Crypto(Crypto.Providers.DES)
            Dim myExecutionID As String = Nothing
            Dim myPK As String

            Dim myUserID As String = BaseClasses.Utils.SecurityControls.GetCurrentUserID()

            myPK = CheckCrypto.Decrypt(AdActivity)

            If myButtonFlowStepID = "309" Then

                myWhere = CarrierAdActivityTable.AdActivityID.UniqueName & " = " & myPK
                Dim myActRec As CarrierAdActivityRecord = CarrierAdActivityTable.GetRecord(myWhere)

                If myActRec.ExecutionID = 0 Then

                    'HARD CODE:  Need to make agreement ID dynamic.
                    myExecutionID = CustGenClass.f_Sproc("usp_ExecutionAdd", myRowOwnerCIX_Decrypt, "45", myUserID, myRowOIX, "309")
                    Dim myInstanceID As String = CustGenClass.f_Sproc("usp_ThreadGetInstance", "CarrierAdActivity", myButtonFlowStepID, myPK)
                    Dim myAddrID As String = Nothing
                    s_ExecutionUpdates(myPK, myExecutionID, myRowOIX, myInstanceID)
                    CustGenClass.s_InstanceRelatedIDsUpdate(myInstanceID, myExecutionID, myPK)
                End If

            End If

            If Not String.IsNullOrEmpty(myExecutionID) Then
                Return CheckCrypto.Encrypt(myExecutionID)
            Else
                Return Nothing
            End If

        End Function


        Public Sub s_ExecutionUpdates(ByVal myAdActivityID As String, ByVal myExecutionID As String, ByVal myOIX As String, Optional myInstanceID As String = Nothing, Optional myAddrID As String = Nothing)

            Try
                DbUtils.StartTransaction()
                Dim myRec As New CarrierAdActivityRecord 'Record class for table to update.
                myRec = CarrierAdActivityTable.GetRecord(myAdActivityID, True)
                myRec.ExecutionID = CInt(myExecutionID)
                DbUtils.CommitTransaction()
                myRec.Save()

            Catch ex As Exception
                DbUtils.RollBackTransaction()
                Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)

            Finally
                DbUtils.EndTransaction()

            End Try

        End Sub


        Public Shared Function f_ApplyURL(ByVal myAdActivity As String, ByVal myUserID As String, ByVal myPartyID As String, Optional ByVal myOverview As String = Nothing, Optional ByVal myFlowStatus As String = Nothing, Optional ByVal myPage As String = Nothing) As String

            Dim myReturn As String
            Dim CheckCrypto As Crypto = New Crypto(Crypto.Providers.DES)

            Dim myW As String = CarrierAdActivityTable.AdActivityID.UniqueName & " = " & myAdActivity
            Dim myR As CarrierAdActivityRecord = CarrierAdActivityTable.GetRecord(myW)

            Dim myWhere As String = PartyCarrierTable.CarrierID.UniqueName & " = " & CStr(myR.CarrierID)
            Dim myRec As PartyCarrierRecord = PartyCarrierTable.GetRecord(myWhere)

            Dim myAction As String = "Apply"
            Dim myRowOwnerCIX As String = CStr(myRec.PartyID)
            Dim myRowOIX As String = CStr(myR.PartyID)
            Dim myExecutionID As String = CStr(myR.ExecutionID)
            Dim myAdActivityID As String = CStr(myR.AdActivityID)
            Dim myFlowStepID As String = CStr(myR.FlowStepID)

            '******************************************
            '******************************************
            'Special actions by page.
            '******************************************
            '******************************************


            If myPage = "FastportConfig" Then

                s_FPConfigGenInstructions(myUserID, myPartyID, myRowOwnerCIX, myOverview, myFlowStatus)

            End If


            '******************************************
            '******************************************
            'End

            '******************************************
            '******************************************



            Dim myFlowConfigRec As FlowConfigRecord = BaseApplicationPage.f_GetFlowConfig(myFlowStepID, myRowOwnerCIX, myUserID, myRowOIX)

            Dim myConfigID As String = CStr(myFlowConfigRec.ConfigID)
            Dim myURL As String = CustGenClass.f_Sproc("usp_ParamsByID", "0", myConfigID, "0")

            myRowOwnerCIX = CheckCrypto.Encrypt(DirectCast(myRowOwnerCIX, String))
            myRowOIX = CheckCrypto.Encrypt(DirectCast(myRowOIX, String))
            myExecutionID = CheckCrypto.Encrypt(DirectCast(myExecutionID, String))
            myAdActivityID = CheckCrypto.Encrypt(DirectCast(myAdActivityID, String))
            Dim myFlowStepID_Encrypt As String = CheckCrypto.Encrypt(DirectCast(myFlowStepID, String))

            'If Right(myURL, 1) = "+" Then
            '    Dim myDefaultURLParams As String = CustGenClass.f_Sproc("usp_FlowURLParams", myFlowStepID)
            '    If Not String.IsNullOrEmpty(myDefaultURLParams) Then
            '        myURL = Left(myURL, Len(myURL) - 1) & myDefaultURLParams
            '    Else
            '        myURL = Left(myURL, Len(myURL) - 1)
            '    End If
            'End If

            myReturn = CustGenClass.f_URL_Replace(myURL, myAction, , , myRowOwnerCIX, myRowOIX, myFlowStepID_Encrypt, myRowOIX, , , , , myExecutionID, , myAdActivityID)

            Return myReturn

        End Function

        Public Shared Function f_ExecutionURL(ByVal myExecutionID As String, ByVal myUserID As String) As String

            Dim myReturn As String
            Dim CheckCrypto As Crypto = New Crypto(Crypto.Providers.DES)

            Dim myW As String = AgreementExecutionTable.ExecutionID.UniqueName & " = " & myExecutionID
            Dim myR As AgreementExecutionRecord = AgreementExecutionTable.GetRecord(myW)

            Dim myAction As String = "GetSig"
            Dim myRowOwnerCIX As String = CStr(myR.CIX)
            Dim myRowOIX As String = CStr(myR.OIX)
            Dim myFlowStepID As String = CStr(myR.FlowStepID)


            Dim myFlowConfigRec As FlowConfigRecord = BaseApplicationPage.f_GetFlowConfig(myFlowStepID, myRowOwnerCIX, myUserID, myRowOIX)

            Dim myConfigID As String = CStr(myFlowConfigRec.ConfigID)
            Dim myURL As String = CustGenClass.f_Sproc("usp_ParamsByID", "0", myConfigID, "0")

            myRowOwnerCIX = CheckCrypto.Encrypt(DirectCast(myRowOwnerCIX, String))
            myRowOIX = CheckCrypto.Encrypt(DirectCast(myRowOIX, String))
            myExecutionID = CheckCrypto.Encrypt(DirectCast(myExecutionID, String))
            Dim myFlowStepID_Encrypt As String = CheckCrypto.Encrypt(DirectCast(myFlowStepID, String))

            myReturn = CustGenClass.f_URL_Replace(myURL, myAction, , , myRowOwnerCIX, myRowOIX, myFlowStepID_Encrypt, myRowOIX, , , , , myExecutionID)

            Return myReturn

        End Function


        Public Shared Function f_PayPalURL(ByVal myPartyID As String, ByVal myUserID As String) As String

            Dim myReturn As String
            Dim CheckCrypto As Crypto = New Crypto(Crypto.Providers.DES)

            Dim myW As String = PartyPaySettingsTable.PartyID.UniqueName & " = " & myPartyID
            Dim myR As PartyPaySettingsRecord = PartyPaySettingsTable.GetRecord(myW)
            Dim myFlowStepID As String = CStr(myR.FlowStepID)

            Dim myFlowConfigRec As FlowConfigRecord = BaseApplicationPage.f_GetFlowConfig(myFlowStepID, myPartyID, myUserID)

            Dim myConfigID As String = CStr(myFlowConfigRec.ConfigID)
            Dim myURL As String = CustGenClass.f_Sproc("usp_ParamsByID", "0", myConfigID, "0")

            Dim myPartyID_Encrypt As String = CheckCrypto.Encrypt(DirectCast(myPartyID, String))
            Dim myFlowStepID_Encrypt As String = CheckCrypto.Encrypt(DirectCast(myFlowStepID, String))

            'If Right(myURL, 1) = "+" Then
            '    Dim myDefaultURLParams As String = CustGenClass.f_Sproc("usp_FlowURLParams", myFlowStepID)
            '    If Not String.IsNullOrEmpty(myDefaultURLParams) Then
            '        myURL = Left(myURL, Len(myURL) - 1) & myDefaultURLParams
            '    Else
            '        myURL = Left(myURL, Len(myURL) - 1)
            '    End If
            'End If

            myReturn = CustGenClass.f_URL_Replace(myURL, , , , myPartyID_Encrypt, , myFlowStepID_Encrypt, myPartyID_Encrypt)

            Return myReturn

        End Function

        Public Shared Sub s_FPConfigGenInstructions(ByVal myUserID As String, ByVal myPartyID As String, ByVal myRowOwnerCIX As String, ByVal myOverview As String, ByVal myFlowStatus As String)


            Dim myGenInstrucitons As String = ""

            Dim myConfigID As String = NothingInside

            If myUserID = myPartyID Then

                myConfigID = "544"

            Else

                myConfigID = "545"

            End If

            Dim myConfigWhere As String = FlowConfigTable.ConfigID.UniqueName & " = " & myConfigID
            Dim myConfigRec As FlowConfigRecord = FlowConfigTable.GetRecord(myConfigWhere)

            If Not IsNothing(myConfigRec) Then

                myGenInstrucitons = myConfigRec.Instructions

                If myUserID = myPartyID Then

                    Dim myCIXName As String = CustGenClass.f_GetPartyName(myRowOwnerCIX)
                    myGenInstrucitons = Replace(myGenInstrucitons, "{CIXName}", myCIXName)

                End If

                myGenInstrucitons = Replace(myGenInstrucitons, "{OverviewName}", myOverview)
                myGenInstrucitons = Replace(myGenInstrucitons, "{FlowStatus}", myFlowStatus)

                CustGenClass.s_SetVariables(myGenInstrucitons)

            End If

        End Sub


        Public Shared Sub s_UpdateInstance_ForCircle(ByVal myFleetCircleID As String, ByVal myInstanceID As String)

            Try

                DbUtils.StartTransaction()
                Dim myRec As New PartyFleetCircleRecord 'Record class for table to update.
                myRec = PartyFleetCircleTable.GetRecord(myFleetCircleID, True)
                myRec.InstanceID = CInt(myInstanceID)
                DbUtils.CommitTransaction()
                myRec.Save()

            Catch ex As Exception

                DbUtils.RollBackTransaction()

            Finally

                DbUtils.EndTransaction()

            End Try

        End Sub

    End Class


End Namespace