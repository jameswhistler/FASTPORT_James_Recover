Imports BaseClasses
Imports BaseClasses.Utils

Imports FASTPORT.UI
Imports FASTPORT.Business
Imports FASTPORT.Data

Imports Telerik.Web.UI

Partial Class SignUpFP
    Inherits BaseApplicationPage

    Private Const ItemsPerRequest As Integer = 10

    Protected Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'var MobileRTB = $find("<%=MobileRTB.ClientID %>");
        '        MobileRTB.set_visible(false);

        '        var TruckerRPB = $find("<%=TruckerRPB.ClientID %>");
        '        var ContactRP = TruckerRPB.findItemByText("Contact information");
        '        var CarrierRP = TruckerRPB.findItemByText("Carrier information");
        '        ContactRP.set_enabled(false);
        '        CarrierRP.set_visible(false);

        ContactRPI.Enabled = False
        CarrierRPI.Visible = False
    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest

        Dim myArg As String = e.Argument
        Dim myAction As String = CustGenClass.f_Split_ByComma(myArg, 1)
        Dim my1st As String = CustGenClass.f_Split_ByComma(myArg, 2)
        Dim my2nd As String = CustGenClass.f_Split_ByComma(myArg, 3)
        Dim my3rd As String = CustGenClass.f_Split_ByComma(myArg, 4)
        Dim myPartyID As String = Me.HiddenTB_PartyID.Text
        Dim mySproc As String = Nothing
        Dim myWarning As String = "Nothing"
        Dim myWarningTitle As String = "Nothing"

        If myAction = "rebindAddr" Then
            '
        ElseIf myAction = "rebindPickCarrierRG" Then
            PickCarrierRG.Rebind()
        End If

        If myWarning <> "Nothing" Then
            RadAjaxManager1.ResponseScripts.Add("launchRadAlert('" & myWarning & "','" & myWarningTitle & "');")
        End If

    End Sub
    Protected Sub CarrierEditRB_OnClick(sender As Object, e As EventArgs) Handles CarrierEditRB.Click

        Dim btn As RadButton = TryCast(sender, RadButton)
        Dim myButtonText As String = btn.Text

        If myButtonText = "Save" Or myButtonText = "Add" Or (myButtonText = "Edit" And Me.HiddenTB_CarrierDataStatus.Text = "Selected") Then

            Dim myPartyID As String = Me.HiddenTB_PartyID.Text
            Dim myCarrierID As String = Me.HiddenTB_CarrierID.Text
            If Me.HiddenTB_CarrierDataStatus.Text = "Selected" Then
                Me.HiddenTB_CarrierDataStatus.Text = "Edit"
            End If
            Dim myCarrierDataStatus As String = Me.HiddenTB_CarrierDataStatus.Text
            Dim myMC As String = MCNumberRTB.Text
            Dim myDOT As String = DOTNumberRTB.Text
            Dim myCarrierName As String = CarrierNameRTB.Text
            Dim myCarrierAddr As String = CarrierAddrRTB.Text
            Dim myCarrierZipID As String = CarrierZipRCB.SelectedValue
            Dim myCarrierEmail As String = CarrierEmailRTB.Text
            Dim myCarrierPhone As String = CarrierPhoneRTB.Text
            Dim myCarrierFax As String = CarrierFaxRTB.Text

            'f_SaveOrAddNew(myCarrierDataStatus, myCarrierID, myMC, myDOT, myCarrierName, myCarrierAddr, myCarrierZipID, myCarrierEmail, myCarrierPhone, myCarrierFax)

        End If

    End Sub

    Protected Sub s_CityRCB_ItemsRequested(ByVal sender As Object, ByVal e As RadComboBoxItemsRequestedEventArgs) Handles CityRCB.ItemsRequested

        Try

            Dim data As DataTable = f_CityCombo_GetData(e.Text)

            Dim itemOffset As Integer = e.NumberOfItems
            Dim endOffset As Integer = Math.Min(itemOffset + ItemsPerRequest, data.Rows.Count)
            e.EndOfItems = endOffset = data.Rows.Count

            Dim i As Integer = itemOffset
            While i < endOffset
                CityRCB.Items.Add(New RadComboBoxItem(data.Rows(i)("Info").ToString(), data.Rows(i)("PK").ToString()))
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While


        Catch ex As Exception

        End Try

    End Sub

    Public Function f_CityCombo_GetData(ByVal text As String) As DataTable

        Dim myDataTable As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_PickCity", text, SearchCountryRCB.SelectedValue)
        Return myDataTable

    End Function

    Public Function f_ZipCombo_GetData(ByVal text As String, Optional ByVal myWhichControl As String = "NonCarrier") As DataTable

        Dim myCountryID As String

        myCountryID = CarrierCountryRCB.SelectedValue

        Dim myDataTable As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_PickZip", text, myCountryID)
        Return myDataTable

    End Function

    Protected Sub s_CarrierZipRCB_ItemsRequested(ByVal sender As Object, ByVal e As RadComboBoxItemsRequestedEventArgs) Handles CarrierZipRCB.ItemsRequested

        Try

            Dim data As DataTable = f_ZipCombo_GetData(e.Text, "Carrier")

            Dim itemOffset As Integer = e.NumberOfItems
            Dim endOffset As Integer = Math.Min(itemOffset + ItemsPerRequest, data.Rows.Count)
            e.EndOfItems = endOffset = data.Rows.Count

            Dim i As Integer = itemOffset
            While i < endOffset
                CarrierZipRCB.Items.Add(New RadComboBoxItem(data.Rows(i)("Info").ToString(), data.Rows(i)("PK").ToString()))
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While

        Catch ex As Exception

        End Try

    End Sub

    Public Sub CreateTruckerRadButton_Click() Handles TruckerRadButton.Click

        If UIValid() Then
            ' Create Trucker account

            ' Switch to Contact information RadPanel
            RadAjaxManager1.ResponseScripts.Add("ActivateContactRadPanel();")
        End If

    End Sub

    Public Sub CreateCarrierRadButton_Click() Handles CarrierRadButton.Click

        If UIValid() Then

            ' Switch to Contact information RadPanel and show carrier panel 
            RadAjaxManager1.ResponseScripts.Add("ActivateContactRadPanel();")
            CarrierRPI.Visible = True
            RadAjaxManager1.ResponseScripts.Add("ExpandCarrierRadPanel();")
        End If

    End Sub
    Public Function UIValid() As Boolean

        Dim UIIsValid As Boolean = True

        ' First reset literals, CSS etc

        'Me.NoMatchLiteral.Visible = False
        'Me.NoMatchLiteral.Text = Nothing
        Me.EmailRTB.CssClass = "field_input"
        Me.MobileRTB.CssClass = "field_input"
        Me.PasswordRTB.CssClass = "field_input"
        Me.RetypePasswordRTB.CssClass = "field_input"
        'Me.WrongCodeLiteral.Visible = False
        'Me.WrongCodeLiteral.Text = Nothing
        'Me.IDNotAvailableLiteral.Visible = False
        'Me.IDNotAvailableLiteral.Text = Nothing

        ' Check for unique ID

        Dim UniqueUserID As Boolean = True
        Dim UserIDValue As String
        Dim CheckType As String
        Dim ColumnToCheck As BaseClasses.Data.BaseColumn
        If Me.MobileRadButton.Checked Then
            UserIDValue = Me.MobileRTB.Text
            ColumnToCheck = PartyTable.Mobile
            CheckType = "Mobile"
        Else
            UserIDValue = Me.EmailRTB.Text
            ColumnToCheck = PartyTable.Email
            CheckType = "Email"
        End If
        Dim myUserWhereStr As String = ColumnToCheck.UniqueName & " = '" & UserIDValue & "'"
        Dim myUserRec As PartyRecord = PartyTable.GetRecord(myUserWhereStr)
        If Not IsNothing(myUserRec) Then
            UniqueUserID = False
        End If
        If Not UniqueUserID Then
            ' User ID is already taken
            'Me.IDNotAvailableLiteral.Visible = True
            'Me.IDNotAvailableLiteral.Text = "The ID is unavailable.  Please try another."
            'UIIsValid = False
            Dim myURL As String = "../Security/ForgotUser.aspx?UserID=" & UserIDValue & "&Type=" & CheckType
            s_Redirect(myURL)
        End If

        ' Check passwords match

        If (Me.PasswordRTB.Text <> Me.RetypePasswordRTB.Text) Or String.IsNullOrEmpty(Me.PasswordRTB.Text) = True Or String.IsNullOrEmpty(Me.RetypePasswordRTB.Text) = True Then
            'Me.NoMatchLiteral.Visible = True
            'Me.NoMatchLiteral.Text = "The passwords do not match."
            SignUpRTT.Text = "The passwords do not match"
            SignUpRTT.TargetControlID = Me.RetypePasswordRTB.ID
            SignUpRTT.Show()
            UIIsValid = False

            Return UIIsValid
        End If

        ' Check captcha matches
        'If Not Me.Page.IsValid() Then
        '    'Me.WrongCodeLiteral.Visible = True
        '    'Me.WrongCodeLiteral.Text = "The verification words are incorrect."
        '    SignUpRTT.Text = "The verification words are incorrect"
        '    Dim CaptchaDiv As HtmlGenericControl = DirectCast(Me.FindControlRecursively("CaptchaDiv"), HtmlGenericControl)
        '    SignUpRTT.TargetControlID = CaptchaDiv.ID
        '    SignUpRTT.Show()
        '    UIIsValid = False

        '    Return UIIsValid
        'End If

        Return UIIsValid

    End Function

    Public Sub s_Redirect(ByVal url As String)

        ' The redirect URL is set on the Properties, Custom Properties or Actions.
        ' The ModifyRedirectURL call resolves the parameters before the
        ' Response.Redirect redirects the page to the URL.  
        ' Any code after the Response.Redirect call will not be executed, since the page is
        ' redirected to the URL.

        Dim shouldRedirect As Boolean = True
        Dim TargetKey As String = Nothing
        Dim DFKA As String = TargetKey
        Dim id As String = DFKA
        Dim value As String = id

        Try
            ' Enclose all database retrieval/update code within a Transaction boundary
            DbUtils.StartTransaction()

            url = Me.ModifyRedirectUrl(url, "", True)

        Catch ex As Exception
            ' Upon error, rollback the transaction
            DbUtils.RollBackTransaction()
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
End Class
