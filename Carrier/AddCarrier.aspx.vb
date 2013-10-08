Imports BaseClasses
Imports BaseClasses.Utils

Imports FASTPORT.UI
Imports FASTPORT.Business
Imports FASTPORT.Data

Imports Telerik.Web.UI

Partial Class AddCarrier
    Inherits FASTPORT.UI.BaseApplicationPage

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

        Dim myCountryID As String = CountryID.SelectedValue

        Dim myDataTable As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_PickZip", text, myCountryID)
        Return myDataTable

    End Function


    Public Sub SaveRB_Click(ByVal sender As Object, ByVal args As EventArgs) Handles SaveRB.Click

        Dim myWarningText As String = f_DOTNumberDups(DOTNumberTB.Text)

        If myWarningText <> "No" Then

            WarningRTT.Text = myWarningText
            WarningRTT.TargetControlID = "DOTNumberTB"
            WarningRTT.Position = ToolTipPosition.TopCenter
            WarningRTT.Show()
            DOTNumberTB.BackColor = Drawing.ColorTranslator.FromHtml("#FF4D4D")
            DOTNumberTB.ForeColor = Drawing.ColorTranslator.FromHtml("#FFFFFF")
            DOTNumberTB.Focus()

        Else

            s_Save()


            Dim myAction As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Action"))

            If myAction = "AddMyCarrier" Then

                Me.CloseWindow(True)
                ClientScript.RegisterStartupScript(Page.GetType(), "mykey", "ChildCloseAndRedirect('RebindCarriers');", True)

            ElseIf myAction = "AdminAdd" Then

                Me.CloseWindow(True)
                ClientScript.RegisterStartupScript(Page.GetType(), "mykey", "ChildClose();", True)

            End If



        End If


    End Sub


    Public Sub s_Save()

        Dim myName As String = NameTB.Text
        Dim myAddr As String = AddrTB.Text
        Dim myAddr2 As String = Addr2TB.Text
        Dim myCityST As String = ZipCombo.Text
        Dim myLatLong As String
        Dim myLat As String = "0"
        Dim myLong As String = "0"

        myName = CustGenClass.f_Sproc("usp_PartyFix", myName)
        myAddr = CustGenClass.f_Sproc("usp_AddrFix", myAddr)
        myAddr2 = CustGenClass.f_Sproc("usp_AddrFix", myAddr2)

        'HARD CODE
        If String.IsNullOrEmpty(myAddr) = False And String.IsNullOrEmpty(myCityST) = False Then

            'myLatLong = GetGeoCoords(myAddr & ", " & myCityST, 1)
            'myLat = CustGenClass.f_Split_ByComma(myLatLong, 2)
            'myLong = CustGenClass.f_Split_ByComma(myLatLong, 1)

        End If

        s_SaveParty(myName, myAddr, myAddr2, myLat, myLong)

    End Sub


    Public Sub s_SaveParty(ByVal myName As String, ByVal myAddr As String, ByVal myAddr2 As String, ByVal myLat As String, ByVal myLong As String)


        Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

        Dim myID As String = CustGenClass.f_Sproc("usp_PartyAdd", myUserID, "5", myName)
        Dim myCarrierID As String = CustGenClass.f_Sproc("usp_CarrierAddUpdate", myID, MCNumberTB.TextWithLiterals, DOTNumberTB.Text)
        Dim mySproc As String = CustGenClass.f_Sproc("usp_RoleAdd", myID, "14", myUserID)

        Dim myAction As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Action"))

        Dim myDBA As String = DBATB.Text
        myDBA = CustGenClass.f_Sproc("usp_PartyFix", myDBA)

        Dim myEmail As String = EmailTB.Text
        Dim myValidEmail As Boolean = f_EmailIsValid(myEmail)

        If myAction = "AddMyCarrier" Then
            Dim mySproc2 As String = CustGenClass.f_Sproc("usp_RollupAdd", myID, myUserID, "24")
        End If

        Try
            DbUtils.StartTransaction()
            Dim myRec As New PartyRecord 'Record class for table to update.
            myRec = PartyTable.GetRecord(myID, True)

            myRec.DBA = myDBA

            If myValidEmail = True Then
                myRec.Email = myEmail
            End If
            myRec.DirectDial = PhoneTB.Text
            myRec.Fax = FaxTB.Text

            DbUtils.CommitTransaction()
            myRec.Save()

        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)

        Finally
            DbUtils.EndTransaction()
        End Try



        s_SaveAddr(myID, myAddr, myAddr2, myLat, myLong)


        Dim myHistoryID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("History"))

        If Not String.IsNullOrEmpty(myHistoryID) Then

            s_HistoryUpdate(CInt(myID))

        End If


        If String.IsNullOrEmpty(myEmail) = False And myValidEmail = True Then

            's_SendEmail(myID, myUserID, myEmail)

        End If

    End Sub


    Public Sub s_SaveAddr(ByVal myPartyID As String, ByVal myAddr As String, ByVal myAddr2 As String, ByVal myLat As String, ByVal myLong As String)

        Dim myEmail As String = EmailTB.Text
        Dim myPhone As String = PhoneTB.Text
        Dim myFax As String = FaxTB.Text

        Try
            ' Enclose all database retrieval/update code within a Transaction boundary

            DbUtils.StartTransaction()
            Dim myRec As New PartyAddrRecord

            myRec.PartyID = CInt(myPartyID)
            myRec.Addr = myAddr
            myRec.Addr2 = myAddr2
            myRec.AddrZipID = CInt(ZipCombo.SelectedValue)
            myRec.Email = myEmail
            myRec.DirectDail = myPhone
            myRec.Fax = myFax
            myRec.Headquarters = True
            myRec.Lat = CDbl(myLat)
            myRec.Long0 = CDbl(myLong)

            myRec.Save()
            DbUtils.CommitTransaction()

        Catch ex As Exception
            ' Upon error, rollback the transaction
            DbUtils.RollBackTransaction()
            ' Report the error message to the end user
            Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
        Finally
            DbUtils.EndTransaction()
        End Try

    End Sub


    Public Sub s_HistoryUpdate(ByVal myCarrierID As Integer)

        Dim myHistoryID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("History"))

        Try
            DbUtils.StartTransaction()
            Dim myRec As New PartyWorkHistoryRecord 'Record class for table to update.
            myRec = PartyWorkHistoryTable.GetRecord(myHistoryID, True)
            myRec.Employed = True
            myRec.EmployerID = myCarrierID
            DbUtils.CommitTransaction()
            myRec.Save()

        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)

        Finally
            DbUtils.EndTransaction()

        End Try

    End Sub
   
    Public Sub s_SendEmail(ByVal myID As String, ByVal myUserID As String, ByVal myEmail As String)

        Dim myThreadID As String = "27"

        'HARD CODE
        Dim mySproc As String = CustGenClass.f_Sproc("usp_ThreadInstanceAdd", myThreadID, "1", "3", "No")
        Dim myInstanceID As String = DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(mySproc, String))
        CustGenClass.f_Sproc("usp_ThreadRecipientsAdd", mySproc, myUserID, myEmail)

        Dim myChildWhere As String = PartyTable.Email.UniqueName & " = '" & myEmail & "' AND " & PartyTable.PartyTypeID.UniqueName & " = 7"
        Dim myChildRec As PartyRecord = PartyTable.GetRecord(myChildWhere)

        Dim myEmailUserID As String = CStr(myChildRec.PartyID)

        Dim myWhere2 As String = ThreadInstanceMessageTable.InstanceID.UniqueName & " = " & mySproc
        Dim myRec2 As ThreadInstanceMessageRecord = ThreadInstanceMessageTable.GetRecord(myWhere2)
        Dim myMessageID As String = myRec2.MessageID.ToString

        If mySproc <> "0" Then

            'S1: Gather params.
            Dim myClose As String = "Yes"
            Dim myFlowStepID As String = "266"
            Dim myRowOwnerCIX As String = myEmailUserID
            Dim myPartyID As String = myID
            Dim myCarrierName As String = CustGenClass.f_GetPartyName(myID)
            Dim myLeftPart As String = Me.Request.Url.GetLeftPart(UriPartial.Authority)

            'S2: Run message functions.
            CustGenClass.s_URL_UpdateCommonContent(myMessageID, , , , , , , "{Recipient}", myCarrierName)
            CustGenClass.s_URL_Update(myMessageID, , myLeftPart, , , myClose, , myRowOwnerCIX, , myFlowStepID, myPartyID)

        End If

    End Sub



    Public Sub s_MCNumber_TextChanged() Handles MCNumberTB.TextChanged


        Dim myMCNumber As String = MCNumberTB.TextWithLiterals
        Dim myWarningText As String = f_MCNumberDups(myMCNumber)

        If myWarningText <> "No" Then
            WarningRTT.Text = myWarningText
            WarningRTT.TargetControlID = "MCNumberTB"
            WarningRTT.Position = ToolTipPosition.TopCenter
            WarningRTT.Show()
        End If

        NameTB.Focus()

    End Sub

    Public Function f_MCNumberDups(ByVal myMCNumber As String) As String

        '**************************************************
        '**************************************************
        'Also in code behind / controls file / addcarrier.aspx / editcarrier.aspx
        '**************************************************
        '**************************************************

        Dim myReturn As String = "No"
        'Dim myEmployerID As String = Me.PartyWorkHistoryRecordControl.EmployeerID.Text

        If String.IsNullOrEmpty(myMCNumber) = False Then

            Dim myWhere As String = "Replace(Left(" & PartyCarrierTable.MCNumber.UniqueName & ",9),'-','') =REPLACE('" & Left(myMCNumber, 9) & "','-','')" & _
                                        " AND " & PartyCarrierTable.MCNumber.UniqueName & " <> 'MC-'"
            'If String.IsNullOrEmpty(myEmployerID) = False Then
            '    myWhere = myWhere & " AND " & PartyCarrierTable.PartyID.UniqueName & " <> " & myEmployerID
            'End If

            Dim myCount As Integer = 0
            Dim myMCMatches As String = ""

            For Each myRec As PartyCarrierRecord In PartyCarrierTable.GetRecords(myWhere)

                If myCount > 0 Then

                    myMCMatches = myMCMatches & ", "

                End If

                myMCMatches = myMCMatches & CustGenClass.f_GetPartyName(CStr(myRec.PartyID))

                myCount = myCount + 1

            Next

            If myCount > 0 Then

                myReturn = "<span style=""color: Green;""><strong>NOTE:</strong></span> This MC Number is already assigned to: " & myMCMatches & ".  Please be certain that you wish to enter a duplicate MC number."

            End If

        End If

        Return myReturn

    End Function

    Public Sub s_DOTNumber_TextChanged() Handles DOTNumberTB.TextChanged

        Dim myDOTNumber As String = DOTNumberTB.TextWithLiterals
        Dim myWarningText As String = f_DOTNumberDups(myDOTNumber)

        If myWarningText <> "No" Then
            WarningRTT.Text = myWarningText
            WarningRTT.TargetControlID = "DOTNumberTB"
            WarningRTT.Position = ToolTipPosition.TopCenter
            WarningRTT.Show()
            DOTNumberTB.BackColor = Drawing.ColorTranslator.FromHtml("#FF4D4D")
            DOTNumberTB.ForeColor = Drawing.ColorTranslator.FromHtml("#FFFFFF")
            DOTNumberTB.Text = Nothing
            DOTNumberTB.Focus()
        Else
            DOTNumberTB.BackColor = Drawing.ColorTranslator.FromHtml("#FFFFFF")
            DOTNumberTB.ForeColor = Drawing.ColorTranslator.FromHtml("#000000")
            MCNumberTB.Focus()
        End If

    End Sub

    Public Function f_DOTNumberDups(ByVal myDOTNumber As String) As String

        '**************************************************
        '**************************************************
        'Also in code behind / controls file / addcarrier.aspx / editcarrier.aspx
        '**************************************************
        '**************************************************

        Dim myReturn As String = "No"
        'Dim myEmployerID As String = Me.PartyWorkHistoryRecordControl.EmployeerID.Text

        If String.IsNullOrEmpty(myDOTNumber) = False Then

            Dim myWhere As String = "Left(" & PartyCarrierTable.DOTNumber.UniqueName & ",9) ='" & Left(myDOTNumber, 9) & "'"
            'If String.IsNullOrEmpty(myEmployerID) = False Then
            '    myWhere = myWhere & " AND " & PartyCarrierTable.PartyID.UniqueName & " <> " & myEmployerID
            'End If

            Dim myRec As PartyCarrierRecord = PartyCarrierTable.GetRecord(myWhere)

            If Not IsNothing(myRec) Then

                myReturn = "<span style=""color: #FF0000;""><strong>WARNING:</strong></span> This DOT Number is already assigned to " & CustGenClass.f_GetPartyName(CStr(myRec.PartyID)) & ".  The system does <span style=""color: #ff0000;"">NOT</span> allow duplicate DOT numbers.  Please (1) correct the number or (2) click the ""X"" to find the carrier using this DOT number."

            End If

        End If

        Return myReturn

    End Function

    Public Sub s_Name_TextChanged() Handles NameTB.TextChanged

        Dim myName As String = NameTB.Text

        If String.IsNullOrEmpty(myName) = False Then

            Dim mySproc As String = CustGenClass.f_Sproc("usp_CarrierDuplicates", myName)

            If mySproc <> "None" Then

                Dim myWarningText As String = "NOTICE: Some similar carrier names exist, such as: " & mySproc & ". If the carrier you''re entering may already be in FASTPORT, please return to the previous page and find that carrier there."
                WarningRTT.Text = myWarningText
                WarningRTT.TargetControlID = "NameTB"
                WarningRTT.Position = ToolTipPosition.TopCenter
                WarningRTT.Show()
                NameTB.BackColor = Drawing.ColorTranslator.FromHtml("#FF4D4D")
                NameTB.ForeColor = Drawing.ColorTranslator.FromHtml("#FFFFFF")
                NameTB.Focus()
            Else
                NameTB.BackColor = Drawing.ColorTranslator.FromHtml("#FFFFFF")
                NameTB.ForeColor = Drawing.ColorTranslator.FromHtml("#000000")
                DBATB.Focus()

            End If

        End If

    End Sub


    Public Sub s_DBA_TextChanged() Handles DBATB.TextChanged

        Dim myDBA As String = DBATB.Text

        If String.IsNullOrEmpty(myDBA) = False Then

            Dim mySproc As String = CustGenClass.f_Sproc("usp_CarrierDuplicates", myDBA)

            If mySproc <> "None" Then

                Dim myWarningText As String = "NOTICE: Some similar carrier names exist, such as: " & mySproc & ". If the carrier you''re entering may already be in FASTPORT, please return to the previous page and find that carrier there."
                WarningRTT.Text = myWarningText
                WarningRTT.TargetControlID = "DBATB"
                WarningRTT.Position = ToolTipPosition.TopCenter
                WarningRTT.Show()
                DBATB.BackColor = Drawing.ColorTranslator.FromHtml("#FF4D4D")
                DBATB.ForeColor = Drawing.ColorTranslator.FromHtml("#FFFFFF")
                DBATB.Focus()
            Else
                DBATB.BackColor = Drawing.ColorTranslator.FromHtml("#FFFFFF")
                DBATB.ForeColor = Drawing.ColorTranslator.FromHtml("#000000")
                AddrTB.Focus()

            End If

        End If


    End Sub

    Public Sub s_Vis()

        s_Instructions()

        CountryID.SelectedValue = "3"
        CountryID.Text = "United States"

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

    Public Sub Page_PreRender() Handles Me.PreRender

        If Page.IsPostBack = False Then
            s_Vis()
        End If

    End Sub


    Public Sub CancelRB_Click(ByVal sender As Object, ByVal args As EventArgs) Handles CancelRB.Click


        Dim myAction As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Action"))

        If myAction = "AddMyCarrier" Then

            Me.CloseWindow(True)

            ClientScript.RegisterStartupScript(Page.GetType(), "mykey", "ChildClose();", True)

        Else

            Me.RedirectBack()

        End If

    End Sub



End Class
