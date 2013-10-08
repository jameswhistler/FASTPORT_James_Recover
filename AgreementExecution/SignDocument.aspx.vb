Imports Telerik.Web.UI

Imports BaseClasses
Imports BaseClasses.Utils
Imports FASTPORT.UI

Imports FASTPORT.Business
Imports FASTPORT.Data
Imports System.Drawing

Partial Class Sign
    Inherits FlowBaseClass


    Protected Sub ShowSigRB_Click() Handles ShowSigRB.Click

        Dim myExecutionID As String = Me.HiddenTB_ExecutionID.Text
        s_SaveSignatures(myExecutionID)
        s_Generate(myExecutionID)

    End Sub

    Protected Sub ShowDataRB_Click() Handles ShowDataRB.Click

        Dim myExecutionID As String = Me.HiddenTB_ExecutionID.Text


        s_SaveCustomData(myExecutionID)
        s_Generate(myExecutionID)

    End Sub

    Protected Sub s_Generate(ByVal myExecutionID As String)

        s_GenerateDocument(myExecutionID)
        DocPageRLV.DataBind()

    End Sub

    Protected Sub DocPageRS_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)

        Dim selectedValue As Decimal = DirectCast(sender, RadSlider).Value

        If selectedValue = 1D Then
            ImageHeight = Unit.Pixel(150)
            ImageWidth = Unit.Pixel(198)
            DocPageRLV.PageSize = 40
        ElseIf selectedValue = 2D Then
            ImageHeight = Unit.Pixel(250)
            ImageWidth = Unit.Pixel(324)
            DocPageRLV.PageSize = 40
        ElseIf selectedValue = 4D Then
            ImageHeight = Unit.Pixel(350)
            ImageWidth = Unit.Pixel(454)
            DocPageRLV.PageSize = 20
        ElseIf selectedValue = 5D Then
            ImageHeight = Unit.Pixel(450)
            ImageWidth = Unit.Pixel(583)
            DocPageRLV.PageSize = 15
        ElseIf selectedValue = 6D Then
            ImageHeight = Unit.Pixel(650)
            ImageWidth = Unit.Pixel(842)
            DocPageRLV.PageSize = 15
        ElseIf selectedValue = 7D Then
            ImageHeight = Unit.Pixel(750)
            ImageWidth = Unit.Pixel(972)
            DocPageRLV.PageSize = 10
        ElseIf selectedValue = 8D Then
            ImageHeight = Unit.Pixel(850)
            ImageWidth = Unit.Pixel(1101)
            DocPageRLV.PageSize = 10
        ElseIf selectedValue = 9D Then
            ImageHeight = Unit.Pixel(950)
            ImageWidth = Unit.Pixel(1231)
            DocPageRLV.PageSize = 6
        ElseIf selectedValue = 10D Then
            ImageHeight = Unit.Pixel(1050)
            ImageWidth = Unit.Pixel(1361)
            DocPageRLV.PageSize = 6
        ElseIf selectedValue = 11D Then
            ImageHeight = Unit.Pixel(1150)
            ImageWidth = Unit.Pixel(1490)
            DocPageRLV.PageSize = 6
        End If

        DocPageRLV.CurrentPageIndex = 0
        DocPageRLV.Rebind()

    End Sub

    Protected Property ImageWidth() As Unit
        Get
            Dim state As Object = If(ViewState("ImageWidth"), Unit.Pixel(450))
            Return DirectCast(state, Unit)
        End Get
        Private Set(ByVal value As Unit)
            ViewState("ImageWidth") = value
        End Set
    End Property

    Protected Property ImageHeight() As Unit
        Get
            Dim state As Object = If(ViewState("ImageHeight"), Unit.Pixel(583))
            Return DirectCast(state, Unit)
        End Get
        Private Set(ByVal value As Unit)
            ViewState("ImageHeight") = value
        End Set
    End Property

    Public Sub SenderRCB_SelectedIndexChanged(ByVal o As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles SenderRCB.SelectedIndexChanged

        SenderAddrRCB.DataBind()
        SenderSignerRCB.DataBind()
        SenderAddrRCB.Focus()

        Dim mySenderID As String = SenderRCB.SelectedValue

        If Not String.IsNullOrEmpty(mySenderID) Then

            Dim mySenderAddrID As String = CustGenClass.f_Sproc("usp_AddrDefaultHeadquarters", SenderRCB.SelectedValue)

            If mySenderAddrID <> "0" Then
                SenderAddrRCB.SelectedValue = mySenderAddrID
                Dim myW As String = V_AddrView.AddrID.UniqueName & " = " & mySenderAddrID
                Dim myR As V_AddrRecord = V_AddrView.GetRecord(myW)
                SenderAddrRCB.Text = myR.OneLine
            Else
                SenderAddrRCB.SelectedValue = Nothing
                SenderAddrRCB.Text = Nothing
            End If

            Dim mySenderSignerID As String = CustGenClass.f_Sproc("usp_SignerDefault", SenderRCB.SelectedValue)

            If Not String.IsNullOrEmpty(mySenderSignerID) Then
                SenderSignerRCB.SelectedValue = mySenderSignerID
                SenderSignerRCB.Text = CustGenClass.f_GetPartyName(mySenderSignerID)
            Else
                SenderSignerRCB.SelectedValue = Nothing
                SenderSignerRCB.Text = Nothing
            End If

        Else

            SenderAddrRCB.SelectedValue = Nothing
            SenderAddrRCB.Text = Nothing

            SenderSignerRCB.SelectedValue = Nothing
            SenderSignerRCB.Text = Nothing

        End If

    End Sub


    Public Sub RecipientRCB_SelectedIndexChanged(ByVal o As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RecipientRCB.SelectedIndexChanged

        RecipientAddrRCB.DataBind()
        RecipientSignerRCB.DataBind()
        RecipientAddrRCB.Focus()

        Dim myRecipientID As String = RecipientRCB.SelectedValue

        If Not String.IsNullOrEmpty(myRecipientID) Then

            Dim myRecipientAddrID As String = CustGenClass.f_Sproc("usp_AddrDefaultHeadquarters", RecipientRCB.SelectedValue)

            If Not String.IsNullOrEmpty(myRecipientAddrID) And myRecipientAddrID <> "0" Then
                RecipientAddrRCB.SelectedValue = myRecipientAddrID
                Dim myW As String = V_AddrView.AddrID.UniqueName & " = " & myRecipientAddrID
                Dim myR As V_AddrRecord = V_AddrView.GetRecord(myW)
                RecipientAddrRCB.Text = myR.OneLine
            Else
                RecipientAddrRCB.SelectedValue = Nothing
                RecipientAddrRCB.Text = Nothing
            End If

            Dim myRecipientSignerID As String = CustGenClass.f_Sproc("usp_SignerDefault", RecipientRCB.SelectedValue)

            If Not String.IsNullOrEmpty(myRecipientSignerID) And myRecipientSignerID <> "0" Then
                RecipientSignerRCB.SelectedValue = myRecipientSignerID
                RecipientSignerRCB.Text = CustGenClass.f_GetPartyName(myRecipientSignerID)
            Else
                RecipientSignerRCB.SelectedValue = Nothing
                RecipientSignerRCB.Text = Nothing
            End If

        Else

            RecipientAddrRCB.SelectedValue = Nothing
            RecipientAddrRCB.Text = Nothing

            RecipientSignerRCB.SelectedValue = Nothing
            RecipientSignerRCB.Text = Nothing

        End If

    End Sub


    Public Sub FormerRCB_SelectedIndexChanged(ByVal o As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles FormerRCB.SelectedIndexChanged

        RecipientRCB.DataBind()
        RecipientRCB.Focus()

    End Sub

    Public Sub s_Vis()

        Dim myExecutionID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Execution"))
        Me.HiddenTB_ExecutionID.Text = myExecutionID

        Dim myDocWhere As String = DocTable.ExecutionID.UniqueName & " = " & myExecutionID
        Dim myDocRec As DocRecord = DocTable.GetRecord(myDocWhere)
        Me.HiddenTB_DocID.Text = CustGenClass.f_Encrypt(Convert.ToString(myDocRec.DocID))

        Dim myWhere As String = V_ExecutionView.ExecutionID.UniqueName & " = " & myExecutionID
        Dim myRec As V_ExecutionRecord = V_ExecutionView.GetRecord(myWhere)
        Dim myFlowStepID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("FlowStep"))
        Dim myRowOwnerCIX As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("RowOwnerCIX"))
        Dim myRowOIX As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("RowOIX"))
        Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

        Dim myFlowConfigRec As FlowConfigRecord = f_GetFlowConfig(myFlowStepID, myRowOwnerCIX, myUserID, myRowOIX)

        If myFlowConfigRec.FirstElement = True Then
            MiscUtils.FindControlRecursively(Me, "ConfigDocDiv").Visible = True
            If myRec.ShowSignatureDate = True Or myRec.ShowExpirationDate = True Then

                MiscUtils.FindControlRecursively(Me, "DatesRow").Visible = True

                If myRec.ShowSignatureDate = True Then

                    MiscUtils.FindControlRecursively(Me, "SignedOnRow").Visible = True

                Else

                    MiscUtils.FindControlRecursively(Me, "SignedOnRow").Visible = False

                End If

                If myRec.ShowExpirationDate = True Then

                    MiscUtils.FindControlRecursively(Me, "ExpiresOnRow").Visible = True

                Else

                    MiscUtils.FindControlRecursively(Me, "ExpiresOnRow").Visible = False

                End If

            Else

                MiscUtils.FindControlRecursively(Me, "DatesRow").Visible = False

            End If
            Me.HiddenTB_Review.Text = "With Config"
        Else
            MiscUtils.FindControlRecursively(Me, "ConfigDocDiv").Visible = False
        End If

        If myFlowConfigRec.SecondElement = True Then
            SignRS.Visible = True
            MiscUtils.FindControlRecursively(Me, "NoDocsDiv").Visible = False
            MiscUtils.FindControlRecursively(Me, "TopInstructionsLiteral").Visible = False
            Me.HiddenTB_Review.Text = "Yes"
        Else
            SignRS.Visible = False
            MiscUtils.FindControlRecursively(Me, "NoDocsDiv").Visible = True
            MiscUtils.FindControlRecursively(Me, "TopInstructionsLiteral").Visible = True
            Dim myInstructions As String = myFlowConfigRec.Instructions.ToString
            myInstructions = f_URL_ReplaceCommon(myInstructions)
            Me.TopInstructionsLiteral.Text = myInstructions
            If myFlowConfigRec.FirstElement = False Then
                Me.HiddenTB_Review.Text = "No Config"
            End If
        End If

        Dim myExecutionWhereStr As String = AgreementExecutionTable.ExecutionID.UniqueName & " = " & myExecutionID
        Dim myExecutionRec As AgreementExecutionRecord = AgreementExecutionTable.GetRecord(myExecutionWhereStr)
        Dim myAgreementWhereStr As String = AgreementTable.AgreementID.UniqueName & " = " & myExecutionRec.AgreementID
        Dim myAgreementRec As AgreementRecord = AgreementTable.GetRecord(myAgreementWhereStr)

        If myFlowConfigRec.ThirdElement = True Then
            SignRSP.Visible = True
            ctlSignature.Visible = True
            If myAgreementRec.InitialsInDocument Then
                MiscUtils.FindControlRecursively(Me, "InitialsTable").Visible = True
            Else
                MiscUtils.FindControlRecursively(Me, "InitialsTable").Visible = False
            End If
        Else
            SignRSP.Visible = False
            ctlSignature.Visible = False
        End If

        If myFlowConfigRec.FourthElement = True Or myFlowConfigRec.FifthElement = True Then
            OtherRSP.Visible = True
            If myFlowConfigRec.FourthElement = True Then
                Me.UploadTemplateButton.Visible = True
            Else
                Me.UploadTemplateButton.Visible = False
            End If
            If myFlowConfigRec.FifthElement = True Then
                Me.UploadPDFButton.Visible = True
            Else
                Me.UploadPDFButton.Visible = False
            End If
        Else
            OtherRSP.Visible = False
        End If

        If myFlowConfigRec.SixthElement = True Then

        Else

        End If


        If myFlowConfigRec.SeventhElement = True Then

            DataRSP.Visible = True

            Dim myAgreeWhere As String = AgreementTable.AgreementID.UniqueName & " = " & myRec.AgreementID
            Dim myAgreeRec As AgreementRecord = AgreementTable.GetRecord(myAgreeWhere)

            Dim myCustInstructions As String = ""

            If myAgreeRec.OtherInstructionsSpecified Then
                myCustInstructions = myAgreeRec.OtherInstructions
            End If

            Dim myWeAreTheParty As Boolean = f_WeAreTheParty(myRowOwnerCIX, myUserID)

            If myWeAreTheParty = True And myAgreeRec.SenderInstructionsSpecified Then
                If String.IsNullOrEmpty(myCustInstructions) Then
                    myCustInstructions = myAgreeRec.SenderInstructions
                Else
                    myCustInstructions = myCustInstructions & "<br /><br />" & myAgreeRec.SenderInstructions
                End If
            End If

            If myWeAreTheParty = True And myAgreeRec.RecipientInstructionsSpecified Then
                If String.IsNullOrEmpty(myCustInstructions) Then
                    myCustInstructions = myAgreeRec.RecipientInstructions
                Else
                    myCustInstructions = myCustInstructions & "<br /><br />" & myAgreeRec.RecipientInstructions
                End If
            End If

            If Not String.IsNullOrEmpty(myCustInstructions) Then
                Me.InstructionsLiteral1.Text = "<br /><br />" & f_URL_ReplaceCommon(myCustInstructions)
            Else
                Me.InstructionsLiteral1.Visible = False
            End If

            If myRec.FirstTypeIDSpecified = True _
                And myRec.FirstItemNameSpecified = True _
                And ( _
                    (myAgreeRec.FirstByCIX = False And myAgreeRec.FirstByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.FirstByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.FirstByOIX = True)) Then
                Dim myFirstItemLiteral As String = myAgreeRec.FirstItem
                Dim myFirstItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "FirstItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenFirstItem As Integer = Len(myFirstItemLiteral)
                If myLenFirstItem <= 50 Then
                    myFirstItemCell.Attributes.Add("width", "150px")
                ElseIf myLenFirstItem > 50 And myLenFirstItem <= 175 Then
                    myFirstItemCell.Attributes.Add("width", "250px")
                ElseIf myLenFirstItem > 175 Then
                    myFirstItemCell.Attributes.Add("width", "500px")
                End If
                Me.FirstItemLiteral.Text = myAgreeRec.FirstItem
                If myAgreeRec.FirstTypeIDSpecified = False Or myAgreeRec.FirstTypeID = 42 Then
                    FirstItemRTB.Visible = True
                    FirstItemCB.Visible = False
                    FirstItemRCB.Visible = False
                    FirstItemRDP.Visible = False
                    FirstItemRE.Visible = False
                ElseIf myAgreeRec.FirstTypeID = 43 Then
                    FirstItemRTB.Visible = False
                    FirstItemCB.Visible = True
                    FirstItemRCB.Visible = False
                    FirstItemRDP.Visible = False
                    FirstItemRE.Visible = False
                ElseIf myAgreeRec.FirstTypeID = 44 Then
                    FirstItemRTB.Visible = False
                    FirstItemCB.Visible = False
                    FirstItemRCB.Visible = True
                    FirstItemRDP.Visible = False
                    FirstItemRE.Visible = False
                ElseIf myAgreeRec.FirstTypeID = 45 Then
                    FirstItemRTB.Visible = False
                    FirstItemCB.Visible = False
                    FirstItemRCB.Visible = False
                    FirstItemRDP.Visible = True
                    FirstItemRE.Visible = False
                ElseIf myAgreeRec.FirstTypeID = 48 Then
                    FirstItemRTB.Visible = False
                    FirstItemCB.Visible = False
                    FirstItemRCB.Visible = False
                    FirstItemRDP.Visible = False
                    FirstItemRE.Visible = True
                End If

                If myAgreeRec.FirstTypeID = 44 And myAgreeRec.FirstDefaultSpecified Then
                    Dim myFirstItem As String = myRec.FirstItem
                    If myRec.FirstItemSpecified Then
                        FirstItemRCB.Items.Add(New RadComboBoxItem(myFirstItem))
                    Else
                        FirstItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    End If
                    Dim myString As String = myAgreeRec.FirstDefault
                    For Each myFirstResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        If myFirstResult <> myFirstItem Then
                            FirstItemRCB.Items.Add(New RadComboBoxItem(myFirstResult))
                        End If
                    Next
                End If

                If String.IsNullOrEmpty(myRec.FirstItem) = False Then
                    If myAgreeRec.FirstTypeID = 42 Then
                        FirstItemRTB.Text = myRec.FirstItem
                    ElseIf myAgreeRec.FirstTypeID = 43 Then
                        If myRec.FirstItem = "True" Then
                            FirstItemCB.Checked = True
                        Else
                            FirstItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.FirstTypeID = 44 Then
                        'Set above.
                    ElseIf myAgreeRec.FirstTypeID = 45 Then
                        Dim myFirstDate As DateTime = CDate(myRec.FirstItem)
                        FirstItemRDP.SelectedDate = myFirstDate
                    ElseIf myAgreeRec.FirstTypeID = 48 Then
                        FirstItemRE.Content = myRec.FirstItem
                    End If
                End If

            Else
                MiscUtils.FindControlRecursively(Me, "FirstItemRow").Visible = False

            End If


            If myRec.SecondTypeIDSpecified = True _
                And myRec.SecondItemNameSpecified = True _
                And ( _
                    (myAgreeRec.SecondByCIX = False And myAgreeRec.SecondByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.SecondByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.SecondByOIX = True)) Then
                MiscUtils.FindControlRecursively(Me, "SecondItemRow").Visible = True
                Dim mySecondItemLiteral As String = myAgreeRec.SecondItem
                Dim mySecondItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "SecondItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenSecondItem As Integer = Len(mySecondItemLiteral)
                If myLenSecondItem <= 50 Then
                    mySecondItemCell.Attributes.Add("width", "150px")
                ElseIf myLenSecondItem > 50 And myLenSecondItem <= 175 Then
                    mySecondItemCell.Attributes.Add("width", "250px")
                ElseIf myLenSecondItem > 175 Then
                    mySecondItemCell.Attributes.Add("width", "500px")
                End If
                Me.SecondItemLiteral.Text = myAgreeRec.SecondItem
                If myAgreeRec.SecondTypeIDSpecified = False Or myAgreeRec.SecondTypeID = 42 Then
                    SecondItemRTB.Visible = True
                    SecondItemCB.Visible = False
                    SecondItemRCB.Visible = False
                    SecondItemRDP.Visible = False
                    SecondItemRE.Visible = False
                ElseIf myAgreeRec.SecondTypeID = 43 Then
                    SecondItemRTB.Visible = False
                    SecondItemCB.Visible = True
                    SecondItemRCB.Visible = False
                    SecondItemRDP.Visible = False
                    SecondItemRE.Visible = False
                ElseIf myAgreeRec.SecondTypeID = 44 Then
                    SecondItemRTB.Visible = False
                    SecondItemCB.Visible = False
                    SecondItemRCB.Visible = True
                    SecondItemRDP.Visible = False
                    SecondItemRE.Visible = False
                ElseIf myAgreeRec.SecondTypeID = 45 Then
                    SecondItemRTB.Visible = False
                    SecondItemCB.Visible = False
                    SecondItemRCB.Visible = False
                    SecondItemRDP.Visible = True
                    SecondItemRE.Visible = False
                ElseIf myAgreeRec.SecondTypeID = 48 Then
                    SecondItemRTB.Visible = False
                    SecondItemCB.Visible = False
                    SecondItemRCB.Visible = False
                    SecondItemRDP.Visible = False
                    SecondItemRE.Visible = True
                End If

                If myAgreeRec.SecondTypeID = 44 And myAgreeRec.SecondDefaultSpecified Then
                    Dim mySecondItem As String = myRec.SecondItem
                    If myRec.SecondItemSpecified Then
                        SecondItemRCB.Items.Add(New RadComboBoxItem(mySecondItem))
                    Else
                        SecondItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    End If
                    Dim myString As String = myAgreeRec.SecondDefault
                    For Each mySecondResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        If mySecondResult <> mySecondItem Then
                            SecondItemRCB.Items.Add(New RadComboBoxItem(mySecondResult))
                        End If
                    Next
                End If

                If String.IsNullOrEmpty(myRec.SecondItem) = False Then
                    If myAgreeRec.SecondTypeID = 42 Then
                        SecondItemRTB.Text = myRec.SecondItem
                    ElseIf myAgreeRec.SecondTypeID = 43 Then
                        If myRec.SecondItem = "True" Then
                            SecondItemCB.Checked = True
                        Else
                            SecondItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.SecondTypeID = 44 Then
                        'Set above.
                    ElseIf myAgreeRec.SecondTypeID = 45 Then
                        Dim mySecondDate As DateTime = CDate(myRec.SecondItem)
                        SecondItemRDP.SelectedDate = mySecondDate
                    ElseIf myAgreeRec.SecondTypeID = 48 Then
                        SecondItemRE.Content = myRec.SecondItem
                    End If
                End If
            Else
                MiscUtils.FindControlRecursively(Me, "SecondItemRow").Visible = False
            End If

            If myRec.ThirdTypeIDSpecified = True _
                And myRec.ThirdItemNameSpecified = True _
                And ( _
                    (myAgreeRec.ThirdByCIX = False And myAgreeRec.ThirdByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.ThirdByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.ThirdByOIX = True)) Then
                MiscUtils.FindControlRecursively(Me, "ThirdItemRow").Visible = True
                Dim myThirdItemLiteral As String = myAgreeRec.ThirdItem
                Dim myThirdItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "ThirdItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenThirdItem As Integer = Len(myThirdItemLiteral)
                If myLenThirdItem <= 50 Then
                    myThirdItemCell.Attributes.Add("width", "150px")
                ElseIf myLenThirdItem > 50 And myLenThirdItem <= 175 Then
                    myThirdItemCell.Attributes.Add("width", "250px")
                ElseIf myLenThirdItem > 175 Then
                    myThirdItemCell.Attributes.Add("width", "500px")
                End If
                Me.ThirdItemLiteral.Text = myAgreeRec.ThirdItem
                If myAgreeRec.ThirdTypeIDSpecified = False Or myAgreeRec.ThirdTypeID = 42 Then
                    ThirdItemRTB.Visible = True
                    ThirdItemCB.Visible = False
                    ThirdItemRCB.Visible = False
                    ThirdItemRDP.Visible = False
                    ThirdItemRE.Visible = False
                ElseIf myAgreeRec.ThirdTypeID = 43 Then
                    ThirdItemRTB.Visible = False
                    ThirdItemCB.Visible = True
                    ThirdItemRCB.Visible = False
                    ThirdItemRDP.Visible = False
                    ThirdItemRE.Visible = False
                ElseIf myAgreeRec.ThirdTypeID = 44 Then
                    ThirdItemRTB.Visible = False
                    ThirdItemCB.Visible = False
                    ThirdItemRCB.Visible = True
                    ThirdItemRDP.Visible = False
                    ThirdItemRE.Visible = False
                ElseIf myAgreeRec.ThirdTypeID = 45 Then
                    ThirdItemRTB.Visible = False
                    ThirdItemCB.Visible = False
                    ThirdItemRCB.Visible = False
                    ThirdItemRDP.Visible = True
                    ThirdItemRE.Visible = False
                ElseIf myAgreeRec.ThirdTypeID = 48 Then
                    ThirdItemRTB.Visible = False
                    ThirdItemCB.Visible = False
                    ThirdItemRCB.Visible = False
                    ThirdItemRDP.Visible = False
                    ThirdItemRE.Visible = True
                End If

                If myAgreeRec.ThirdTypeID = 44 And myAgreeRec.ThirdDefaultSpecified Then
                    Dim myThirdItem As String = myRec.ThirdItem
                    If myRec.ThirdItemSpecified Then
                        ThirdItemRCB.Items.Add(New RadComboBoxItem(myThirdItem))
                    Else
                        ThirdItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    End If
                    Dim myString As String = myAgreeRec.ThirdDefault
                    For Each myThirdResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        If myThirdResult <> myThirdItem Then
                            ThirdItemRCB.Items.Add(New RadComboBoxItem(myThirdResult))
                        End If
                    Next
                End If

                If String.IsNullOrEmpty(myRec.ThirdItem) = False Then
                    If myAgreeRec.ThirdTypeID = 42 Then
                        ThirdItemRTB.Text = myRec.ThirdItem
                    ElseIf myAgreeRec.ThirdTypeID = 43 Then
                        If myRec.ThirdItem = "True" Then
                            ThirdItemCB.Checked = True
                        Else
                            ThirdItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.ThirdTypeID = 44 Then
                        'Set above.
                    ElseIf myAgreeRec.ThirdTypeID = 45 Then
                        Dim myThirdDate As DateTime = CDate(myRec.ThirdItem)
                        ThirdItemRDP.SelectedDate = myThirdDate
                    ElseIf myAgreeRec.ThirdTypeID = 48 Then
                        ThirdItemRE.Content = myRec.ThirdItem
                    End If
                End If

            Else
                MiscUtils.FindControlRecursively(Me, "ThirdItemRow").Visible = False
            End If


            If myRec.FourthTypeIDSpecified = True _
                And myRec.FourthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.FourthByCIX = False And myAgreeRec.FourthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.FourthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.FourthByOIX = True)) Then
                MiscUtils.FindControlRecursively(Me, "FourthItemRow").Visible = True
                Dim myFourthItemLiteral As String = myAgreeRec.FourthItem
                Dim myFourthItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "FourthItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenFourthItem As Integer = Len(myFourthItemLiteral)
                If myLenFourthItem <= 50 Then
                    myFourthItemCell.Attributes.Add("width", "150px")
                ElseIf myLenFourthItem > 50 And myLenFourthItem <= 175 Then
                    myFourthItemCell.Attributes.Add("width", "250px")
                ElseIf myLenFourthItem > 175 Then
                    myFourthItemCell.Attributes.Add("width", "500px")
                End If
                Me.FourthItemLiteral.Text = myAgreeRec.FourthItem
                'Text
                If myAgreeRec.FourthTypeIDSpecified = False Or myAgreeRec.FourthTypeID = 42 Then
                    FourthItemRTB.Visible = True
                    FourthItemCB.Visible = False
                    FourthItemRCB.Visible = False
                    FourthItemRDP.Visible = False
                    FourthItemRE.Visible = False
                    'Checkbox
                ElseIf myAgreeRec.FourthTypeID = 43 Then
                    FourthItemRTB.Visible = False
                    FourthItemCB.Visible = True
                    FourthItemRCB.Visible = False
                    FourthItemRDP.Visible = False
                    FourthItemRE.Visible = False
                    'Combo
                ElseIf myAgreeRec.FourthTypeID = 44 Then
                    FourthItemRTB.Visible = False
                    FourthItemCB.Visible = False
                    FourthItemRCB.Visible = True
                    FourthItemRDP.Visible = False
                    FourthItemRE.Visible = False
                    'Datepicker
                ElseIf myAgreeRec.FourthTypeID = 45 Then
                    FourthItemRTB.Visible = False
                    FourthItemCB.Visible = False
                    FourthItemRCB.Visible = False
                    FourthItemRDP.Visible = True
                    FourthItemRE.Visible = False
                    'Editor
                ElseIf myAgreeRec.FourthTypeID = 48 Then
                    Dim myFourthInputCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "FourthInputCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                    myFourthInputCell.Attributes.Add("width", "305px")
                    myFourthInputCell.Attributes.Add("height", "80px")
                    FourthItemRTB.Visible = False
                    FourthItemCB.Visible = False
                    FourthItemRCB.Visible = False
                    FourthItemRDP.Visible = False
                    FourthItemRE.Visible = True
                End If

                If myAgreeRec.FourthTypeID = 44 And myAgreeRec.FourthDefaultSpecified Then
                    Dim myFourthItem As String = myRec.FourthItem
                    If myRec.FourthItemSpecified Then
                        FourthItemRCB.Items.Add(New RadComboBoxItem(myFourthItem))
                    Else
                        FourthItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    End If
                    Dim myString As String = myAgreeRec.FourthDefault
                    For Each myFourthResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        If myFourthResult <> myFourthItem Then
                            FourthItemRCB.Items.Add(New RadComboBoxItem(myFourthResult))
                        End If
                    Next
                End If

                If String.IsNullOrEmpty(myRec.FourthItem) = False Then
                    If myAgreeRec.FourthTypeID = 42 Then
                        FourthItemRTB.Text = myRec.FourthItem
                    ElseIf myAgreeRec.FourthTypeID = 43 Then
                        If myRec.FourthItem = "True" Then
                            FourthItemCB.Checked = True
                        Else
                            FourthItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.FourthTypeID = 44 Then
                        'Set above.
                    ElseIf myAgreeRec.FourthTypeID = 45 Then
                        Dim myFourthDate As DateTime = CDate(myRec.FourthItem)
                        FourthItemRDP.SelectedDate = myFourthDate
                    ElseIf myAgreeRec.FourthTypeID = 48 Then
                        FourthItemRE.Content = myRec.FourthItem
                    End If
                End If

            Else
                MiscUtils.FindControlRecursively(Me, "FourthItemRow").Visible = False
            End If


            If myRec.FifthTypeIDSpecified = True _
                And myRec.FifthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.FifthByCIX = False And myAgreeRec.FifthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.FifthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.FifthByOIX = True)) Then
                MiscUtils.FindControlRecursively(Me, "FifthItemRow").Visible = True
                Dim myFifthItemLiteral As String = myAgreeRec.FifthItem
                Dim myFifthItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "FifthItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenFifthItem As Integer = Len(myFifthItemLiteral)
                If myLenFifthItem <= 50 Then
                    myFifthItemCell.Attributes.Add("width", "150px")
                ElseIf myLenFifthItem > 50 And myLenFifthItem <= 175 Then
                    myFifthItemCell.Attributes.Add("width", "250px")
                ElseIf myLenFifthItem > 175 Then
                    myFifthItemCell.Attributes.Add("width", "500px")
                End If
                Me.FifthItemLiteral.Text = myAgreeRec.FifthItem
                If myAgreeRec.FifthTypeIDSpecified = False Or myAgreeRec.FifthTypeID = 42 Then
                    FifthItemRTB.Visible = True
                    FifthItemCB.Visible = False
                    FifthItemRCB.Visible = False
                    FifthItemRDP.Visible = False
                    FifthItemRE.Visible = False
                ElseIf myAgreeRec.FifthTypeID = 43 Then
                    FifthItemRTB.Visible = False
                    FifthItemCB.Visible = True
                    FifthItemRCB.Visible = False
                    FifthItemRDP.Visible = False
                    FifthItemRE.Visible = False
                ElseIf myAgreeRec.FifthTypeID = 44 Then
                    FifthItemRTB.Visible = False
                    FifthItemCB.Visible = False
                    FifthItemRCB.Visible = True
                    FifthItemRDP.Visible = False
                    FifthItemRE.Visible = False
                ElseIf myAgreeRec.FifthTypeID = 45 Then
                    FifthItemRTB.Visible = False
                    FifthItemCB.Visible = False
                    FifthItemRCB.Visible = False
                    FifthItemRDP.Visible = True
                    FifthItemRE.Visible = False
                ElseIf myAgreeRec.FifthTypeID = 48 Then
                    FifthItemRTB.Visible = False
                    FifthItemCB.Visible = False
                    FifthItemRCB.Visible = False
                    FifthItemRDP.Visible = False
                    FifthItemRE.Visible = True
                End If

                If myAgreeRec.FifthTypeID = 44 And myAgreeRec.FifthDefaultSpecified Then
                    Dim myFifthItem As String = myRec.FifthItem
                    If myRec.FifthItemSpecified Then
                        FifthItemRCB.Items.Add(New RadComboBoxItem(myFifthItem))
                    Else
                        FifthItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    End If
                    Dim myString As String = myAgreeRec.FifthDefault
                    For Each myFifthResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        If myFifthResult <> myFifthItem Then
                            FifthItemRCB.Items.Add(New RadComboBoxItem(myFifthResult))
                        End If
                    Next
                End If

                If String.IsNullOrEmpty(myRec.FifthItem) = False Then
                    If myAgreeRec.FifthTypeID = 42 Then
                        FifthItemRTB.Text = myRec.FifthItem
                    ElseIf myAgreeRec.FifthTypeID = 43 Then
                        If myRec.FifthItem = "True" Then
                            FifthItemCB.Checked = True
                        Else
                            FifthItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.FifthTypeID = 44 Then
                        'Set above.
                    ElseIf myAgreeRec.FifthTypeID = 45 Then
                        Dim myFifthDate As DateTime = CDate(myRec.FifthItem)
                        FifthItemRDP.SelectedDate = myFifthDate
                    ElseIf myAgreeRec.FifthTypeID = 48 Then
                        FifthItemRE.Content = myRec.FifthItem
                    End If
                End If

            Else
                MiscUtils.FindControlRecursively(Me, "FifthItemRow").Visible = False
            End If


            If myRec.SixthTypeIDSpecified = True _
                And myRec.SixthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.SixthByCIX = False And myAgreeRec.SixthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.SixthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.SixthByOIX = True)) Then
                MiscUtils.FindControlRecursively(Me, "SixthItemRow").Visible = True
                Dim mySixthItemLiteral As String = myAgreeRec.SixthItem
                Dim mySixthItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "SixthItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenSixthItem As Integer = Len(mySixthItemLiteral)
                If myLenSixthItem <= 50 Then
                    mySixthItemCell.Attributes.Add("width", "150px")
                ElseIf myLenSixthItem > 50 And myLenSixthItem <= 175 Then
                    mySixthItemCell.Attributes.Add("width", "250px")
                ElseIf myLenSixthItem > 175 Then
                    mySixthItemCell.Attributes.Add("width", "500px")
                End If
                Me.SixthItemLiteral.Text = myAgreeRec.SixthItem
                If myAgreeRec.SixthTypeIDSpecified = False Or myAgreeRec.SixthTypeID = 42 Then
                    SixthItemRTB.Visible = True
                    SixthItemCB.Visible = False
                    SixthItemRCB.Visible = False
                    SixthItemRDP.Visible = False
                    SixthItemRE.Visible = False
                ElseIf myAgreeRec.SixthTypeID = 43 Then
                    SixthItemRTB.Visible = False
                    SixthItemCB.Visible = True
                    SixthItemRCB.Visible = False
                    SixthItemRDP.Visible = False
                    SixthItemRE.Visible = False
                ElseIf myAgreeRec.SixthTypeID = 44 Then
                    SixthItemRTB.Visible = False
                    SixthItemCB.Visible = False
                    SixthItemRCB.Visible = True
                    SixthItemRDP.Visible = False
                    SixthItemRE.Visible = False
                ElseIf myAgreeRec.SixthTypeID = 45 Then
                    SixthItemRTB.Visible = False
                    SixthItemCB.Visible = False
                    SixthItemRCB.Visible = False
                    SixthItemRDP.Visible = True
                    SixthItemRE.Visible = False
                ElseIf myAgreeRec.SixthTypeID = 48 Then
                    SixthItemRTB.Visible = False
                    SixthItemCB.Visible = False
                    SixthItemRCB.Visible = False
                    SixthItemRDP.Visible = False
                    SixthItemRE.Visible = True
                End If

                If myAgreeRec.SixthTypeID = 44 And myAgreeRec.SixthDefaultSpecified Then
                    Dim mySixthItem As String = myRec.SixthItem
                    If myRec.SixthItemSpecified Then
                        SixthItemRCB.Items.Add(New RadComboBoxItem(mySixthItem))
                    Else
                        SixthItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    End If
                    Dim myString As String = myAgreeRec.SixthDefault
                    For Each mySixthResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        If mySixthResult <> mySixthItem Then
                            SixthItemRCB.Items.Add(New RadComboBoxItem(mySixthResult))
                        End If
                    Next
                End If

                If String.IsNullOrEmpty(myRec.SixthItem) = False Then
                    If myAgreeRec.SixthTypeID = 42 Then
                        SixthItemRTB.Text = myRec.SixthItem
                    ElseIf myAgreeRec.SixthTypeID = 43 Then
                        If myRec.SixthItem = "True" Then
                            SixthItemCB.Checked = True
                        Else
                            SixthItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.SixthTypeID = 44 Then
                        'Set above.
                    ElseIf myAgreeRec.SixthTypeID = 45 Then
                        Dim mySixthDate As DateTime = CDate(myRec.SixthItem)
                        SixthItemRDP.SelectedDate = mySixthDate
                    ElseIf myAgreeRec.SixthTypeID = 48 Then
                        SixthItemRE.Content = myRec.SixthItem
                    End If
                End If

            Else
                MiscUtils.FindControlRecursively(Me, "SixthItemRow").Visible = False
            End If


            If myRec.SeventhTypeIDSpecified = True _
                And myRec.SeventhItemNameSpecified = True _
                And ( _
                    (myAgreeRec.SeventhByCIX = False And myAgreeRec.SeventhByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.SeventhByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.SeventhByOIX = True)) Then
                MiscUtils.FindControlRecursively(Me, "SeventhItemRow").Visible = True
                Dim mySeventhItemLiteral As String = myAgreeRec.SeventhItem
                Dim mySeventhItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "SeventhItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenSeventhItem As Integer = Len(mySeventhItemLiteral)
                If myLenSeventhItem <= 50 Then
                    mySeventhItemCell.Attributes.Add("width", "150px")
                ElseIf myLenSeventhItem > 50 And myLenSeventhItem <= 175 Then
                    mySeventhItemCell.Attributes.Add("width", "250px")
                ElseIf myLenSeventhItem > 175 Then
                    mySeventhItemCell.Attributes.Add("width", "500px")
                End If
                Me.SeventhItemLiteral.Text = myAgreeRec.SeventhItem
                If myAgreeRec.SeventhTypeIDSpecified = False Or myAgreeRec.SeventhTypeID = 42 Then
                    SeventhItemRTB.Visible = True
                    SeventhItemCB.Visible = False
                    SeventhItemRCB.Visible = False
                    SeventhItemRDP.Visible = False
                    SeventhItemRE.Visible = False
                ElseIf myAgreeRec.SeventhTypeID = 43 Then
                    SeventhItemRTB.Visible = False
                    SeventhItemCB.Visible = True
                    SeventhItemRCB.Visible = False
                    SeventhItemRDP.Visible = False
                    SeventhItemRE.Visible = False
                ElseIf myAgreeRec.SeventhTypeID = 44 Then
                    SeventhItemRTB.Visible = False
                    SeventhItemCB.Visible = False
                    SeventhItemRCB.Visible = True
                    SeventhItemRDP.Visible = False
                    SeventhItemRE.Visible = False
                ElseIf myAgreeRec.SeventhTypeID = 45 Then
                    SeventhItemRTB.Visible = False
                    SeventhItemCB.Visible = False
                    SeventhItemRCB.Visible = False
                    SeventhItemRDP.Visible = True
                    SeventhItemRE.Visible = False
                ElseIf myAgreeRec.SeventhTypeID = 48 Then
                    SeventhItemRTB.Visible = False
                    SeventhItemCB.Visible = False
                    SeventhItemRCB.Visible = False
                    SeventhItemRDP.Visible = False
                    SeventhItemRE.Visible = True
                End If

                If myAgreeRec.SeventhTypeID = 44 And myAgreeRec.SeventhDefaultSpecified Then
                    Dim mySeventhItem As String = myRec.SeventhItem
                    If myRec.SeventhItemSpecified Then
                        SeventhItemRCB.Items.Add(New RadComboBoxItem(mySeventhItem))
                    Else
                        SeventhItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    End If
                    Dim myString As String = myAgreeRec.SeventhDefault
                    For Each mySeventhResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        If mySeventhResult <> mySeventhItem Then
                            SeventhItemRCB.Items.Add(New RadComboBoxItem(mySeventhResult))
                        End If
                    Next
                End If

                If String.IsNullOrEmpty(myRec.SeventhItem) = False Then
                    If myAgreeRec.SeventhTypeID = 42 Then
                        SeventhItemRTB.Text = myRec.SeventhItem
                    ElseIf myAgreeRec.SeventhTypeID = 43 Then
                        If myRec.SeventhItem = "True" Then
                            SeventhItemCB.Checked = True
                        Else
                            SeventhItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.SeventhTypeID = 44 Then
                        'Set above.
                    ElseIf myAgreeRec.SeventhTypeID = 45 Then
                        Dim mySeventhDate As DateTime = CDate(myRec.SeventhItem)
                        SeventhItemRDP.SelectedDate = mySeventhDate
                    ElseIf myAgreeRec.SeventhTypeID = 48 Then
                        SeventhItemRE.Content = myRec.SeventhItem
                    End If
                End If

            Else
                MiscUtils.FindControlRecursively(Me, "SeventhItemRow").Visible = False
            End If


            If myRec.EighthTypeIDSpecified = True _
                And myRec.EighthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.EighthByCIX = False And myAgreeRec.EighthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.EighthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.EighthByOIX = True)) Then
                MiscUtils.FindControlRecursively(Me, "EighthItemRow").Visible = True
                Dim myEighthItemLiteral As String = myAgreeRec.EighthItem
                Dim myEighthItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "EighthItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenEighthItem As Integer = Len(myEighthItemLiteral)
                If myLenEighthItem <= 50 Then
                    myEighthItemCell.Attributes.Add("width", "150px")
                ElseIf myLenEighthItem > 50 And myLenEighthItem <= 175 Then
                    myEighthItemCell.Attributes.Add("width", "250px")
                ElseIf myLenEighthItem > 175 Then
                    myEighthItemCell.Attributes.Add("width", "500px")
                End If
                Me.EighthItemLiteral.Text = myAgreeRec.EighthItem
                If myAgreeRec.EighthTypeIDSpecified = False Or myAgreeRec.EighthTypeID = 42 Then
                    EighthItemRTB.Visible = True
                    EighthItemCB.Visible = False
                    EighthItemRCB.Visible = False
                    EighthItemRDP.Visible = False
                    EighthItemRE.Visible = False
                ElseIf myAgreeRec.EighthTypeID = 43 Then
                    EighthItemRTB.Visible = False
                    EighthItemCB.Visible = True
                    EighthItemRCB.Visible = False
                    EighthItemRDP.Visible = False
                    EighthItemRE.Visible = False
                ElseIf myAgreeRec.EighthTypeID = 44 Then
                    EighthItemRTB.Visible = False
                    EighthItemCB.Visible = False
                    EighthItemRCB.Visible = True
                    EighthItemRDP.Visible = False
                    EighthItemRE.Visible = False
                ElseIf myAgreeRec.EighthTypeID = 45 Then
                    EighthItemRTB.Visible = False
                    EighthItemCB.Visible = False
                    EighthItemRCB.Visible = False
                    EighthItemRDP.Visible = True
                    EighthItemRE.Visible = False
                ElseIf myAgreeRec.EighthTypeID = 48 Then
                    EighthItemRTB.Visible = False
                    EighthItemCB.Visible = False
                    EighthItemRCB.Visible = False
                    EighthItemRDP.Visible = False
                    EighthItemRE.Visible = True
                End If

                If myAgreeRec.EighthTypeID = 44 And myAgreeRec.EighthDefaultSpecified Then
                    Dim myEighthItem As String = myRec.EighthItem
                    If myRec.EighthItemSpecified Then
                        EighthItemRCB.Items.Add(New RadComboBoxItem(myEighthItem))
                    Else
                        EighthItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    End If
                    Dim myString As String = myAgreeRec.EighthDefault
                    For Each myEighthResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        If myEighthResult <> myEighthItem Then
                            EighthItemRCB.Items.Add(New RadComboBoxItem(myEighthResult))
                        End If
                    Next
                End If

                If String.IsNullOrEmpty(myRec.EighthItem) = False Then
                    If myAgreeRec.EighthTypeID = 42 Then
                        EighthItemRTB.Text = myRec.EighthItem
                    ElseIf myAgreeRec.EighthTypeID = 43 Then
                        If myRec.EighthItem = "True" Then
                            EighthItemCB.Checked = True
                        Else
                            EighthItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.EighthTypeID = 44 Then
                        'Set above.
                    ElseIf myAgreeRec.EighthTypeID = 45 Then
                        Dim myEighthDate As DateTime = CDate(myRec.EighthItem)
                        EighthItemRDP.SelectedDate = myEighthDate
                    ElseIf myAgreeRec.EighthTypeID = 48 Then
                        EighthItemRE.Content = myRec.EighthItem
                    End If
                End If


            Else
                MiscUtils.FindControlRecursively(Me, "EighthItemRow").Visible = False
            End If


            If myRec.NinthTypeIDSpecified = True _
                And myRec.NinthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.NinthByCIX = False And myAgreeRec.NinthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.NinthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.NinthByOIX = True)) Then
                MiscUtils.FindControlRecursively(Me, "NinthItemRow").Visible = True
                Dim myNinthItemLiteral As String = myAgreeRec.NinthItem
                Dim myNinthItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "NinthItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenNinthItem As Integer = Len(myNinthItemLiteral)
                If myLenNinthItem <= 50 Then
                    myNinthItemCell.Attributes.Add("width", "150px")
                ElseIf myLenNinthItem > 50 And myLenNinthItem <= 175 Then
                    myNinthItemCell.Attributes.Add("width", "250px")
                ElseIf myLenNinthItem > 175 Then
                    myNinthItemCell.Attributes.Add("width", "500px")
                End If
                Me.NinthitemLiteral.Text = myAgreeRec.NinthItem
                If myAgreeRec.NinthTypeIDSpecified = False Or myAgreeRec.NinthTypeID = 42 Then
                    NinthItemRTB.Visible = True
                    NinthItemCB.Visible = False
                    NinthItemRCB.Visible = False
                    NinthItemRDP.Visible = False
                    NinthItemRE.Visible = False
                ElseIf myAgreeRec.NinthTypeID = 43 Then
                    NinthItemRTB.Visible = False
                    NinthItemCB.Visible = True
                    NinthItemRCB.Visible = False
                    NinthItemRDP.Visible = False
                    NinthItemRE.Visible = False
                ElseIf myAgreeRec.NinthTypeID = 44 Then
                    NinthItemRTB.Visible = False
                    NinthItemCB.Visible = False
                    NinthItemRCB.Visible = True
                    NinthItemRDP.Visible = False
                    NinthItemRE.Visible = False
                ElseIf myAgreeRec.NinthTypeID = 45 Then
                    NinthItemRTB.Visible = False
                    NinthItemCB.Visible = False
                    NinthItemRCB.Visible = False
                    NinthItemRDP.Visible = True
                    NinthItemRE.Visible = False
                ElseIf myAgreeRec.NinthTypeID = 48 Then
                    NinthItemRTB.Visible = False
                    NinthItemCB.Visible = False
                    NinthItemRCB.Visible = False
                    NinthItemRDP.Visible = False
                    NinthItemRE.Visible = True
                End If

                If myAgreeRec.NinthTypeID = 44 And myAgreeRec.NinthDefaultSpecified Then
                    Dim myNinthItem As String = myRec.NinthItem
                    If myRec.NinthItemSpecified Then
                        NinthItemRCB.Items.Add(New RadComboBoxItem(myNinthItem))
                    Else
                        NinthItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    End If
                    Dim myString As String = myAgreeRec.NinthDefault
                    For Each myNinthResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        If myNinthResult <> myNinthItem Then
                            NinthItemRCB.Items.Add(New RadComboBoxItem(myNinthResult))
                        End If
                    Next
                End If

                If String.IsNullOrEmpty(myRec.NinthItem) = False Then
                    If myAgreeRec.NinthTypeID = 42 Then
                        NinthItemRTB.Text = myRec.NinthItem
                    ElseIf myAgreeRec.NinthTypeID = 43 Then
                        If myRec.NinthItem = "True" Then
                            NinthItemCB.Checked = True
                        Else
                            NinthItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.NinthTypeID = 44 Then
                        'Set above.
                    ElseIf myAgreeRec.NinthTypeID = 45 Then
                        Dim myNinthDate As DateTime = CDate(myRec.NinthItem)
                        NinthItemRDP.SelectedDate = myNinthDate
                    ElseIf myAgreeRec.NinthTypeID = 48 Then
                        NinthItemRE.Content = myRec.NinthItem
                    End If
                End If

            Else
                MiscUtils.FindControlRecursively(Me, "NinthItemRow").Visible = False
            End If


            If myRec.TenthTypeIDSpecified = True _
                And myRec.TenthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.TenthByCIX = False And myAgreeRec.TenthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.TenthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.TenthByOIX = True)) Then
                MiscUtils.FindControlRecursively(Me, "TenthItemRow").Visible = True
                Dim myTenthItemLiteral As String = myAgreeRec.TenthItem
                Dim myTenthItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "TenthItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenTenthItem As Integer = Len(myTenthItemLiteral)
                If myLenTenthItem <= 50 Then
                    myTenthItemCell.Attributes.Add("width", "150px")
                ElseIf myLenTenthItem > 50 And myLenTenthItem <= 175 Then
                    myTenthItemCell.Attributes.Add("width", "250px")
                ElseIf myLenTenthItem > 175 Then
                    myTenthItemCell.Attributes.Add("width", "500px")
                End If
                Me.TenthItemLiteral.Text = myAgreeRec.TenthItem
                If myAgreeRec.TenthTypeIDSpecified = False Or myAgreeRec.TenthTypeID = 42 Then
                    TenthItemRTB.Visible = True
                    TenthItemCB.Visible = False
                    TenthItemRCB.Visible = False
                    TenthItemRDP.Visible = False
                    TenthItemRE.Visible = False
                ElseIf myAgreeRec.TenthTypeID = 43 Then
                    TenthItemRTB.Visible = False
                    TenthItemCB.Visible = True
                    TenthItemRCB.Visible = False
                    TenthItemRDP.Visible = False
                    TenthItemRE.Visible = False
                ElseIf myAgreeRec.TenthTypeID = 44 Then
                    TenthItemRTB.Visible = False
                    TenthItemCB.Visible = False
                    TenthItemRCB.Visible = True
                    TenthItemRDP.Visible = False
                    TenthItemRE.Visible = False
                ElseIf myAgreeRec.TenthTypeID = 45 Then
                    TenthItemRTB.Visible = False
                    TenthItemCB.Visible = False
                    TenthItemRCB.Visible = False
                    TenthItemRDP.Visible = True
                    TenthItemRE.Visible = False
                ElseIf myAgreeRec.TenthTypeID = 48 Then
                    TenthItemRTB.Visible = False
                    TenthItemCB.Visible = False
                    TenthItemRCB.Visible = False
                    TenthItemRDP.Visible = False
                    TenthItemRE.Visible = True
                End If

                If myAgreeRec.TenthTypeID = 44 And myAgreeRec.TenthDefaultSpecified Then
                    TenthItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    Dim myString As String = myAgreeRec.TenthDefault
                    For Each myTenthResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        TenthItemRCB.Items.Add(New RadComboBoxItem(myTenthResult))
                    Next
                End If

                If String.IsNullOrEmpty(myRec.TenthItem) = False Then
                    If myAgreeRec.TenthTypeID = 42 Then
                        TenthItemRTB.Text = myRec.TenthItem
                    ElseIf myAgreeRec.TenthTypeID = 43 Then
                        If myRec.TenthItem = "True" Then
                            TenthItemCB.Checked = True
                        Else
                            TenthItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.TenthTypeID = 44 Then

                        TenthItemRCB.Text = myRec.TenthItem
                    ElseIf myAgreeRec.TenthTypeID = 45 Then
                        Dim myTenthDate As DateTime = CDate(myRec.TenthItem)
                        TenthItemRDP.SelectedDate = myTenthDate
                    ElseIf myAgreeRec.TenthTypeID = 48 Then
                        TenthItemRE.Content = myRec.TenthItem
                    End If
                End If

            Else
                MiscUtils.FindControlRecursively(Me, "TenthItemRow").Visible = False
            End If



            If myRec.EleventhTypeIDSpecified = True _
                And myRec.EleventhItemNameSpecified = True _
                And ( _
                    (myAgreeRec.EleventhByCIX = False And myAgreeRec.EleventhByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.EleventhByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.EleventhByOIX = True)) Then
                MiscUtils.FindControlRecursively(Me, "EleventhItemRow").Visible = True
                Dim myEleventhItemLiteral As String = myAgreeRec.EleventhItem
                Dim myEleventhItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "EleventhItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenEleventhItem As Integer = Len(myEleventhItemLiteral)
                If myLenEleventhItem <= 50 Then
                    myEleventhItemCell.Attributes.Add("width", "150px")
                ElseIf myLenEleventhItem > 50 And myLenEleventhItem <= 175 Then
                    myEleventhItemCell.Attributes.Add("width", "250px")
                ElseIf myLenEleventhItem > 175 Then
                    myEleventhItemCell.Attributes.Add("width", "500px")
                End If
                Me.EleventhItemLiteral.Text = myAgreeRec.EleventhItem
                If myAgreeRec.EleventhTypeIDSpecified = False Or myAgreeRec.EleventhTypeID = 42 Then
                    EleventhItemRTB.Visible = True
                    EleventhItemCB.Visible = False
                    EleventhItemRCB.Visible = False
                    EleventhItemRDP.Visible = False
                    EleventhItemRE.Visible = False
                ElseIf myAgreeRec.EleventhTypeID = 43 Then
                    EleventhItemRTB.Visible = False
                    EleventhItemCB.Visible = True
                    EleventhItemRCB.Visible = False
                    EleventhItemRDP.Visible = False
                    EleventhItemRE.Visible = False
                ElseIf myAgreeRec.EleventhTypeID = 44 Then
                    EleventhItemRTB.Visible = False
                    EleventhItemCB.Visible = False
                    EleventhItemRCB.Visible = True
                    EleventhItemRDP.Visible = False
                    EleventhItemRE.Visible = False
                ElseIf myAgreeRec.EleventhTypeID = 45 Then
                    EleventhItemRTB.Visible = False
                    EleventhItemCB.Visible = False
                    EleventhItemRCB.Visible = False
                    EleventhItemRDP.Visible = True
                    EleventhItemRE.Visible = False
                ElseIf myAgreeRec.EleventhTypeID = 48 Then
                    EleventhItemRTB.Visible = False
                    EleventhItemCB.Visible = False
                    EleventhItemRCB.Visible = False
                    EleventhItemRDP.Visible = False
                    EleventhItemRE.Visible = True
                End If

                If myAgreeRec.EleventhTypeID = 44 And myAgreeRec.EleventhDefaultSpecified Then
                    EleventhItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    Dim myString As String = myAgreeRec.EleventhDefault
                    For Each myEleventhResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        EleventhItemRCB.Items.Add(New RadComboBoxItem(myEleventhResult))
                    Next
                End If

                If String.IsNullOrEmpty(myRec.EleventhItem) = False Then
                    If myAgreeRec.EleventhTypeID = 42 Then
                        EleventhItemRTB.Text = myRec.EleventhItem
                    ElseIf myAgreeRec.EleventhTypeID = 43 Then
                        If myRec.EleventhItem = "True" Then
                            EleventhItemCB.Checked = True
                        Else
                            EleventhItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.EleventhTypeID = 44 Then

                        EleventhItemRCB.Text = myRec.EleventhItem
                    ElseIf myAgreeRec.EleventhTypeID = 45 Then
                        Dim myEleventhDate As DateTime = CDate(myRec.EleventhItem)
                        EleventhItemRDP.SelectedDate = myEleventhDate
                    ElseIf myAgreeRec.EleventhTypeID = 48 Then
                        EleventhItemRE.Content = myRec.EleventhItem
                    End If
                End If

            Else
                MiscUtils.FindControlRecursively(Me, "EleventhItemRow").Visible = False
            End If



            If myRec.TwelfthTypeIDSpecified = True _
                And myRec.TwelfthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.TwelfthByCIX = False And myAgreeRec.TwelfthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.TwelfthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.TwelfthByOIX = True)) Then
                MiscUtils.FindControlRecursively(Me, "TwelfthItemRow").Visible = True
                Dim myTwelfthItemLiteral As String = myAgreeRec.TwelfthItem
                Dim myTwelfthItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "TwelfthItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenTwelfthItem As Integer = Len(myTwelfthItemLiteral)
                If myLenTwelfthItem <= 50 Then
                    myTwelfthItemCell.Attributes.Add("width", "150px")
                ElseIf myLenTwelfthItem > 50 And myLenTwelfthItem <= 175 Then
                    myTwelfthItemCell.Attributes.Add("width", "250px")
                ElseIf myLenTwelfthItem > 175 Then
                    myTwelfthItemCell.Attributes.Add("width", "500px")
                End If
                Me.TwelfthItemLiteral.Text = myAgreeRec.TwelfthItem
                If myAgreeRec.TwelfthTypeIDSpecified = False Or myAgreeRec.TwelfthTypeID = 42 Then
                    TwelfthItemRTB.Visible = True
                    TwelfthItemCB.Visible = False
                    TwelfthItemRCB.Visible = False
                    TwelfthItemRDP.Visible = False
                    TwelfthItemRE.Visible = False
                ElseIf myAgreeRec.TwelfthTypeID = 43 Then
                    TwelfthItemRTB.Visible = False
                    TwelfthItemCB.Visible = True
                    TwelfthItemRCB.Visible = False
                    TwelfthItemRDP.Visible = False
                    TwelfthItemRE.Visible = False
                ElseIf myAgreeRec.TwelfthTypeID = 44 Then
                    TwelfthItemRTB.Visible = False
                    TwelfthItemCB.Visible = False
                    TwelfthItemRCB.Visible = True
                    TwelfthItemRDP.Visible = False
                    TwelfthItemRE.Visible = False
                ElseIf myAgreeRec.TwelfthTypeID = 45 Then
                    TwelfthItemRTB.Visible = False
                    TwelfthItemCB.Visible = False
                    TwelfthItemRCB.Visible = False
                    TwelfthItemRDP.Visible = True
                    TwelfthItemRE.Visible = False
                ElseIf myAgreeRec.TwelfthTypeID = 48 Then
                    TwelfthItemRTB.Visible = False
                    TwelfthItemCB.Visible = False
                    TwelfthItemRCB.Visible = False
                    TwelfthItemRDP.Visible = False
                    TwelfthItemRE.Visible = True
                End If

                If myAgreeRec.TwelfthTypeID = 44 And myAgreeRec.TwelfthDefaultSpecified Then
                    TwelfthItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    Dim myString As String = myAgreeRec.TwelfthDefault
                    For Each myTwelfthResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        TwelfthItemRCB.Items.Add(New RadComboBoxItem(myTwelfthResult))
                    Next
                End If

                If String.IsNullOrEmpty(myRec.TwelfthItem) = False Then
                    If myAgreeRec.TwelfthTypeID = 42 Then
                        TwelfthItemRTB.Text = myRec.TwelfthItem
                    ElseIf myAgreeRec.TwelfthTypeID = 43 Then
                        If myRec.TwelfthItem = "True" Then
                            TwelfthItemCB.Checked = True
                        Else
                            TwelfthItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.TwelfthTypeID = 44 Then

                        TwelfthItemRCB.Text = myRec.TwelfthItem
                    ElseIf myAgreeRec.TwelfthTypeID = 45 Then
                        Dim myTwelfthDate As DateTime = CDate(myRec.TwelfthItem)
                        TwelfthItemRDP.SelectedDate = myTwelfthDate
                    ElseIf myAgreeRec.TwelfthTypeID = 48 Then
                        TwelfthItemRE.Content = myRec.TwelfthItem
                    End If
                End If

            Else
                MiscUtils.FindControlRecursively(Me, "TwelfthItemRow").Visible = False
            End If



            If myRec.ThirteenthTypeIDSpecified = True _
                And myRec.ThirteenthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.ThirteenthByCIX = False And myAgreeRec.ThirteenthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.ThirteenthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.ThirteenthByOIX = True)) Then
                MiscUtils.FindControlRecursively(Me, "ThirteenthItemRow").Visible = True
                Dim myThirteenthItemLiteral As String = myAgreeRec.ThirteenthItem
                Dim myThirteenthItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "ThirteenthItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenThirteenthItem As Integer = Len(myThirteenthItemLiteral)
                If myLenThirteenthItem <= 50 Then
                    myThirteenthItemCell.Attributes.Add("width", "150px")
                ElseIf myLenThirteenthItem > 50 And myLenThirteenthItem <= 175 Then
                    myThirteenthItemCell.Attributes.Add("width", "250px")
                ElseIf myLenThirteenthItem > 175 Then
                    myThirteenthItemCell.Attributes.Add("width", "500px")
                End If
                Me.ThirteenthItemLiteral.Text = myAgreeRec.ThirteenthItem
                If myAgreeRec.ThirteenthTypeIDSpecified = False Or myAgreeRec.ThirteenthTypeID = 42 Then
                    ThirteenthItemRTB.Visible = True
                    ThirteenthItemCB.Visible = False
                    ThirteenthItemRCB.Visible = False
                    ThirteenthItemRDP.Visible = False
                    ThirteenthItemRE.Visible = False
                ElseIf myAgreeRec.ThirteenthTypeID = 43 Then
                    ThirteenthItemRTB.Visible = False
                    ThirteenthItemCB.Visible = True
                    ThirteenthItemRCB.Visible = False
                    ThirteenthItemRDP.Visible = False
                    ThirteenthItemRE.Visible = False
                ElseIf myAgreeRec.ThirteenthTypeID = 44 Then
                    ThirteenthItemRTB.Visible = False
                    ThirteenthItemCB.Visible = False
                    ThirteenthItemRCB.Visible = True
                    ThirteenthItemRDP.Visible = False
                    ThirteenthItemRE.Visible = False
                ElseIf myAgreeRec.ThirteenthTypeID = 45 Then
                    ThirteenthItemRTB.Visible = False
                    ThirteenthItemCB.Visible = False
                    ThirteenthItemRCB.Visible = False
                    ThirteenthItemRDP.Visible = True
                    ThirteenthItemRE.Visible = False
                ElseIf myAgreeRec.ThirteenthTypeID = 48 Then
                    ThirteenthItemRTB.Visible = False
                    ThirteenthItemCB.Visible = False
                    ThirteenthItemRCB.Visible = False
                    ThirteenthItemRDP.Visible = False
                    ThirteenthItemRE.Visible = True
                End If

                If myAgreeRec.ThirteenthTypeID = 44 And myAgreeRec.ThirteenthDefaultSpecified Then
                    ThirteenthItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    Dim myString As String = myAgreeRec.ThirteenthDefault
                    For Each myThirteenthResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        ThirteenthItemRCB.Items.Add(New RadComboBoxItem(myThirteenthResult))
                    Next
                End If

                If String.IsNullOrEmpty(myRec.ThirteenthItem) = False Then
                    If myAgreeRec.ThirteenthTypeID = 42 Then
                        ThirteenthItemRTB.Text = myRec.ThirteenthItem
                    ElseIf myAgreeRec.ThirteenthTypeID = 43 Then
                        If myRec.ThirteenthItem = "True" Then
                            ThirteenthItemCB.Checked = True
                        Else
                            ThirteenthItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.ThirteenthTypeID = 44 Then

                        ThirteenthItemRCB.Text = myRec.ThirteenthItem
                    ElseIf myAgreeRec.ThirteenthTypeID = 45 Then
                        Dim myThirteenthDate As DateTime = CDate(myRec.ThirteenthItem)
                        ThirteenthItemRDP.SelectedDate = myThirteenthDate
                    ElseIf myAgreeRec.ThirteenthTypeID = 48 Then
                        ThirteenthItemRE.Content = myRec.ThirteenthItem
                    End If
                End If

            Else
                MiscUtils.FindControlRecursively(Me, "ThirteenthItemRow").Visible = False
            End If



            If myRec.FourteenthTypeIDSpecified = True _
                And myRec.FourteenthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.FourteenthByCIX = False And myAgreeRec.FourteenthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.FourteenthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.FourteenthByOIX = True)) Then
                MiscUtils.FindControlRecursively(Me, "FourteenthItemRow").Visible = True
                Dim myFourteenthItemLiteral As String = myAgreeRec.FourteenthItem
                Dim myFourteenthItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "FourteenthItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenFourteenthItem As Integer = Len(myFourteenthItemLiteral)
                If myLenFourteenthItem <= 50 Then
                    myFourteenthItemCell.Attributes.Add("width", "150px")
                ElseIf myLenFourteenthItem > 50 And myLenFourteenthItem <= 175 Then
                    myFourteenthItemCell.Attributes.Add("width", "250px")
                ElseIf myLenFourteenthItem > 175 Then
                    myFourteenthItemCell.Attributes.Add("width", "500px")
                End If
                Me.FourteenthItemLiteral.Text = myAgreeRec.FourteenthItem
                If myAgreeRec.FourteenthTypeIDSpecified = False Or myAgreeRec.FourteenthTypeID = 42 Then
                    FourteenthItemRTB.Visible = True
                    FourteenthItemCB.Visible = False
                    FourteenthItemRCB.Visible = False
                    FourteenthItemRDP.Visible = False
                    FourteenthItemRE.Visible = False
                ElseIf myAgreeRec.FourteenthTypeID = 43 Then
                    FourteenthItemRTB.Visible = False
                    FourteenthItemCB.Visible = True
                    FourteenthItemRCB.Visible = False
                    FourteenthItemRDP.Visible = False
                    FourteenthItemRE.Visible = False
                ElseIf myAgreeRec.FourteenthTypeID = 44 Then
                    FourteenthItemRTB.Visible = False
                    FourteenthItemCB.Visible = False
                    FourteenthItemRCB.Visible = True
                    FourteenthItemRDP.Visible = False
                    FourteenthItemRE.Visible = False
                ElseIf myAgreeRec.FourteenthTypeID = 45 Then
                    FourteenthItemRTB.Visible = False
                    FourteenthItemCB.Visible = False
                    FourteenthItemRCB.Visible = False
                    FourteenthItemRDP.Visible = True
                    FourteenthItemRE.Visible = False
                ElseIf myAgreeRec.FourteenthTypeID = 48 Then
                    FourteenthItemRTB.Visible = False
                    FourteenthItemCB.Visible = False
                    FourteenthItemRCB.Visible = False
                    FourteenthItemRDP.Visible = False
                    FourteenthItemRE.Visible = True
                End If

                If myAgreeRec.FourteenthTypeID = 44 And myAgreeRec.FourteenthDefaultSpecified Then
                    FourteenthItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    Dim myString As String = myAgreeRec.FourteenthDefault
                    For Each myFourteenthResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        FourteenthItemRCB.Items.Add(New RadComboBoxItem(myFourteenthResult))
                    Next
                End If

                If String.IsNullOrEmpty(myRec.FourteenthItem) = False Then
                    If myAgreeRec.FourteenthTypeID = 42 Then
                        FourteenthItemRTB.Text = myRec.FourteenthItem
                    ElseIf myAgreeRec.FourteenthTypeID = 43 Then
                        If myRec.FourteenthItem = "True" Then
                            FourteenthItemCB.Checked = True
                        Else
                            FourteenthItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.FourteenthTypeID = 44 Then

                        FourteenthItemRCB.Text = myRec.FourteenthItem
                    ElseIf myAgreeRec.FourteenthTypeID = 45 Then
                        Dim myFourteenthDate As DateTime = CDate(myRec.FourteenthItem)
                        FourteenthItemRDP.SelectedDate = myFourteenthDate
                    ElseIf myAgreeRec.FourteenthTypeID = 48 Then
                        FourteenthItemRE.Content = myRec.FourteenthItem
                    End If
                End If

            Else
                MiscUtils.FindControlRecursively(Me, "FourteenthItemRow").Visible = False
            End If



            If myRec.FifteenthTypeIDSpecified = True _
                And myRec.FifteenthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.FifteenthByCIX = False And myAgreeRec.FifteenthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.FifteenthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.FifteenthByOIX = True)) Then
                MiscUtils.FindControlRecursively(Me, "FifteenthItemRow").Visible = True
                Dim myFifteenthItemLiteral As String = myAgreeRec.FifteenthItem
                Dim myFifteenthItemCell As System.Web.UI.HtmlControls.HtmlTableCell = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "FifteenthItemCell"), System.Web.UI.HtmlControls.HtmlTableCell)
                Dim myLenFifteenthItem As Integer = Len(myFifteenthItemLiteral)
                If myLenFifteenthItem <= 50 Then
                    myFifteenthItemCell.Attributes.Add("width", "150px")
                ElseIf myLenFifteenthItem > 50 And myLenFifteenthItem <= 175 Then
                    myFifteenthItemCell.Attributes.Add("width", "250px")
                ElseIf myLenFifteenthItem > 175 Then
                    myFifteenthItemCell.Attributes.Add("width", "500px")
                End If
                Me.FifteenthItemLiteral.Text = myAgreeRec.FifteenthItem
                If myAgreeRec.FifteenthTypeIDSpecified = False Or myAgreeRec.FifteenthTypeID = 42 Then
                    FifteenthItemRTB.Visible = True
                    FifteenthItemCB.Visible = False
                    FifteenthItemRCB.Visible = False
                    FifteenthItemRDP.Visible = False
                    FifteenthItemRE.Visible = False
                ElseIf myAgreeRec.FifteenthTypeID = 43 Then
                    FifteenthItemRTB.Visible = False
                    FifteenthItemCB.Visible = True
                    FifteenthItemRCB.Visible = False
                    FifteenthItemRDP.Visible = False
                    FifteenthItemRE.Visible = False
                ElseIf myAgreeRec.FifteenthTypeID = 44 Then
                    FifteenthItemRTB.Visible = False
                    FifteenthItemCB.Visible = False
                    FifteenthItemRCB.Visible = True
                    FifteenthItemRDP.Visible = False
                    FifteenthItemRE.Visible = False
                ElseIf myAgreeRec.FifteenthTypeID = 45 Then
                    FifteenthItemRTB.Visible = False
                    FifteenthItemCB.Visible = False
                    FifteenthItemRCB.Visible = False
                    FifteenthItemRDP.Visible = True
                    FifteenthItemRE.Visible = False
                ElseIf myAgreeRec.FifteenthTypeID = 48 Then
                    FifteenthItemRTB.Visible = False
                    FifteenthItemCB.Visible = False
                    FifteenthItemRCB.Visible = False
                    FifteenthItemRDP.Visible = False
                    FifteenthItemRE.Visible = True
                End If

                If myAgreeRec.FifteenthTypeID = 44 And myAgreeRec.FifteenthDefaultSpecified Then
                    FifteenthItemRCB.Items.Add(New RadComboBoxItem("**Please Select**"))
                    Dim myString As String = myAgreeRec.FifteenthDefault
                    For Each myFifteenthResult As String In BaseApplicationPage.f_Split_ByComma_ToList(myString)
                        FifteenthItemRCB.Items.Add(New RadComboBoxItem(myFifteenthResult))
                    Next
                End If

                If String.IsNullOrEmpty(myRec.FifteenthItem) = False Then
                    If myAgreeRec.FifteenthTypeID = 42 Then
                        FifteenthItemRTB.Text = myRec.FifteenthItem
                    ElseIf myAgreeRec.FifteenthTypeID = 43 Then
                        If myRec.FifteenthItem = "True" Then
                            FifteenthItemCB.Checked = True
                        Else
                            FifteenthItemCB.Checked = False
                        End If
                    ElseIf myAgreeRec.FifteenthTypeID = 44 Then

                        FifteenthItemRCB.Text = myRec.FifteenthItem
                    ElseIf myAgreeRec.FifteenthTypeID = 45 Then
                        Dim myFifteenthDate As DateTime = CDate(myRec.FifteenthItem)
                        FifteenthItemRDP.SelectedDate = myFifteenthDate
                    ElseIf myAgreeRec.FifteenthTypeID = 48 Then
                        FifteenthItemRE.Content = myRec.FifteenthItem
                    End If
                End If

            Else
                MiscUtils.FindControlRecursively(Me, "FifteenthItemRow").Visible = False
            End If

        Else

            DataRSP.Visible = False

        End If

        If myRec.CIXSpecified Then
            SenderRCB.ClearSelection()
            SenderRCB.SelectedValue = CStr(myRec.CIX)
            SenderRCB.Text = CustGenClass.f_GetPartyName(CStr(myRec.CIX))
        End If

        If myRec.SenderAddrIDSpecified Then
            SenderAddrRCB.ClearSelection()
            If myFlowConfigRec.FirstElement = True Then
                SenderAddrRCB.DataBind()
            End If
            Dim mySenderAddrID As String = CStr(myRec.SenderAddrID)
            SenderAddrRCB.SelectedValue = mySenderAddrID
            Dim myW As String = V_AddrView.AddrID.UniqueName & " = " & mySenderAddrID
            Dim myR As V_AddrRecord = V_AddrView.GetRecord(myW)
            SenderAddrRCB.Text = myR.OneLine
        End If

        If myRec.SenderSignerIDSpecified Then
            SenderSignerRCB.ClearSelection()
            If myFlowConfigRec.FirstElement = True Then
                SenderSignerRCB.DataBind()
            End If
            SenderSignerRCB.SelectedValue = CStr(myRec.SenderSignerID)
            SenderSignerRCB.Text = CustGenClass.f_GetPartyName(CStr(myRec.SenderSignerID))
        End If

        If myRec.OIXSpecified Then
            RecipientRCB.ClearSelection()
            RecipientRCB.SelectedValue = CStr(myRec.OIX)
            RecipientRCB.Text = CustGenClass.f_GetPartyName(CStr(myRec.OIX))
        End If

        If myRec.RecipientAddrIDSpecified Then
            RecipientAddrRCB.ClearSelection()
            If myFlowConfigRec.FirstElement = True Then
                RecipientAddrRCB.DataBind()
            End If
            Dim myRecipientAddrID As String = CStr(myRec.RecipientAddrID)
            RecipientAddrRCB.SelectedValue = myRecipientAddrID
            Dim myW As String = V_AddrView.AddrID.UniqueName & " = " & myRecipientAddrID
            Dim myR As V_AddrRecord = V_AddrView.GetRecord(myW)
            RecipientAddrRCB.Text = myR.OneLine
        End If

        If myRec.RecipientSignerIDSpecified Then
            RecipientSignerRCB.ClearSelection()
            If myFlowConfigRec.FirstElement = True Then
                RecipientSignerRCB.DataBind()
            End If
            RecipientSignerRCB.SelectedValue = CStr(myRec.RecipientSignerID)
            RecipientSignerRCB.Text = CustGenClass.f_GetPartyName(CStr(myRec.RecipientSignerID))
        End If

        If myRec.SignedOnSpecified And CStr(myRec.SignedOn) <> "#1/1/1900#" Then
            SignedOnRDP.SelectedDate = myRec.SignedOn
        End If

        If myRec.ExpiresOnSpecified And CStr(myRec.ExpiresOn) <> "#1/1/1900#" Then
            ExpiresOnRDP.SelectedDate = myRec.ExpiresOn
        End If


    End Sub


    Public Overrides Sub s_ButtonClick(ByVal sender As Object, ByVal args As EventArgs, ByVal myButtonID As String, ByVal myCloseYesNo As String, Optional ByVal myLeftPart As String = "http://app.fastport.com")


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
        'HANDLE FLOW ACTIONS
        '*****************************************
        '*****************************************

        Dim myWhere As String = FlowButtonTable.ButtonID.UniqueName & " = " & myButtonID
        Dim myRec As FlowButtonRecord = FlowButtonTable.GetRecord(myWhere)
        Dim myButtonFlowStepID As String = myRec.FlowStepID.ToString
        Dim myPK As String = CustGenClass.f_Decrypt(Execution)

        If myRec.FirstButtonAction = True Then

            Dim mySenderID As String = SenderRCB.SelectedValue
            Dim mySenderSignerID As String = SenderSignerRCB.SelectedValue
            Dim myRecipientID As String = RecipientRCB.SelectedValue
            Dim myRecipientSignerID As String = RecipientSignerRCB.SelectedValue
            Dim myWarning As String = Nothing

            If String.IsNullOrEmpty(mySenderID) Then
                Me.SenderWarning.Text = "Required!"
                myWarning = f_Warning(myWarning, "the sender must be recorded.")
            Else
                Me.SenderWarning.Text = ""
            End If

            If String.IsNullOrEmpty(mySenderSignerID) Then
                Me.SenderSignerWarning.Text = "Required!"
                myWarning = f_Warning(myWarning, "the SenderSigner must be recorded.")
            Else
                Me.SenderSignerWarning.Text = ""
            End If

            If myWarning <> "No Warning" Then
                MiscUtils.FindControlRecursively(Me, "SenderRecipientWarningRow").Visible = True
            Else
                MiscUtils.FindControlRecursively(Me, "SenderRecipientWarningRow").Visible = False
            End If

            If String.IsNullOrEmpty(myRecipientID) Then
                Me.RecipientWarning.Text = "Required!"
                myWarning = f_Warning(myWarning, "the Recipient must be recorded.")
            Else
                Me.RecipientWarning.Text = ""
            End If

            If String.IsNullOrEmpty(myRecipientSignerID) Then
                Me.RecipientSignerWarning.Text = "Required!"
                myWarning = f_Warning(myWarning, "the RecipientSigner must be recorded.")
            Else
                Me.RecipientSignerWarning.Text = ""
            End If

            If myWarning <> "No Warning" And Not String.IsNullOrEmpty(myWarning) Then
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", myWarning)
                Exit Sub
            End If

            s_SaveConfigData(myPK)
        End If

        If myRec.ThirdButtonAction = True Then
            ' Save signatures - MUST RUN BEFORE THE DOCUMENT GENERATION IN ORDER TO INCLUDE SIGNATURES IN DOC
            s_SaveSignatures(myPK)
        End If

        If myRec.FourthButtonAction = True Then
            s_SaveCustomData(myPK)
        End If

        If myRec.SecondButtonAction = True Then
            ' Generate document
            s_GenerateDocument(myPK)
        End If

        If myRec.FifthButtonAction = True Then
            s_ClearSignatures(myPK, "Sender")
        End If

        If myRec.SixthButtonAction = True Then
            s_ClearSignatures(myPK, "Recipient")
        End If

        If myRec.SeventhButtonAction = True Then
            CustGenClass.f_Sproc("usp_ExecutionCustomDefaults", myPK)
        End If

        If myRec.EighthButtonAction = True Then

            'Try

            '    'FIX!

            '    Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()
            '    Dim CIX As String = CType(HttpContext.Current.Session("ParentPartyID"), String)

            '    Dim myW As String = AgreementExecutionTable.ExecutionID.UniqueName & " = " & myPK
            '    Dim myR As AgreementExecutionRecord = AgreementExecutionTable.GetRecord(myW)
            '    myWhere = AgreementTable.AgreementID.UniqueName & " = " & CStr(myR.AgreementID)
            '    Dim myR_Agree As AgreementRecord = AgreementTable.GetRecord(myWhere)
            '    Dim fileName As String = myR_Agree.Agreement & ".pdf"
            '    Dim myRowOIX As String = CStr(myR.OIX)

            '    Dim pdfByte() As Byte
            '    pdfByte = CType(myR.AgreementFilePdf, Byte())
            '    Dim pdfMS As New System.IO.MemoryStream(pdfByte)
            '    Dim pdfDoc As Aspose.Pdf.Document = New Aspose.Pdf.Document(pdfMS)
            '    CustGenClass.f_SaveToDoc(pdfDoc, CIX, myUserID, myRowOIX, "0", myPK, fileName)

            'Catch ex As Exception

            '    Dim myMessage As String = ex.Message

            'End Try


        End If

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

        Dim myCIX As String = SenderRCB.SelectedValue
        Dim myOIX As String = RecipientRCB.SelectedValue

        If String.IsNullOrEmpty(myCIX) = False And myCIX <> "0" Then
            RowOwnerCIX = CType(Me.Page, BaseApplicationPage).Encrypt(myCIX)
        End If

        If String.IsNullOrEmpty(myOIX) = False And myOIX <> "0" Then
            RowOIX = CType(Me.Page, BaseApplicationPage).Encrypt(myOIX)
        End If

        'ButtonFlowStep IS AN EXAMPLE WHERE SOMETHING WILL ALMOST ALWAYS BE DIFFERENT THAN THE ITEM IN THE URL.
        FlowStep = DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myButtonFlowStepID, String))
        Dim myURL As String = f_URL_ByButton(myButtonID, Action, Close, Slider, RowOwnerCIX, RowOIX, FlowStep, Party, User, Message, Instance, FleetCircle, Execution, Ad, AdActivity, CheckIn, DocFiled, Ord, Payment, Carrier, Driver, Addr, Role, History, Parent, Email, Password, Button, Verification, myLeftPart)

        Dim myDecrypt As String = DirectCast(Me.Page, BaseApplicationPage).Decrypt(DirectCast(Execution, String))

        s_ButtonClick_2nd(sender, args, myURL, myButtonID, myCloseYesNo, myButtonFlowStepID, Action, , , RowOwnerCIX, RowOIX, FlowStep, Party, User, Message, Instance, FleetCircle, Execution, Ad, AdActivity, CheckIn, DocFiled, Ord, Payment, Carrier, Driver, Addr, Role, History, Parent, Email, Password, Button, Verification)

    End Sub
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


        myButtonFlowStepID = CustGenClass.f_Decrypt(myButtonFlowStepID)
        Dim myRowOwnerCIX_Decrypt As String = CustGenClass.f_Decrypt(RowOwnerCIX)
        Dim myRowOIX As String = CustGenClass.f_Decrypt(RowOIX)
        Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

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

            End If
        End If

        If myCloseYesNo = "False" And String.IsNullOrEmpty(myURL) = False Then
            myURL = CustGenClass.f_URL_Replace(myURL, Action, Close, Slider, RowOwnerCIX, RowOIX, FlowStep, Party, User, Message, Instance, FleetCircle, Execution, Ad, AdActivity, CheckIn, DocFiled, Ord, Payment, Carrier, Driver, Addr, Role, History, Parent, Email, Password, Button, Verification, Doc)
            s_Redirect(sender, args, myURL)
        ElseIf myCloseYesNo = "True" Then
            s_Close(myURL)
        End If

    End Sub


    Public Sub s_ClearSignatures(ByVal myPK As String, ByVal mySigToClear As String)

        Try

            DbUtils.StartTransaction()
            Dim myRec As New AgreementExecutionRecord 'Record class for table to update.
            myRec = AgreementExecutionTable.GetRecord(myPK, True)

            If mySigToClear = "Sender" Then

                myRec.SenderSignature = Nothing
                myRec.SenderInitials = Nothing
                myRec.SetSenderSignedAtFieldValue("")
                myRec.SenderSignedFrom = Nothing

            ElseIf mySigToClear = "Recipient" Then

                myRec.RecipientSignature = Nothing
                myRec.RecipientInitials = Nothing
                myRec.SetRecipientSignedAtFieldValue("")
                myRec.RecipientSignedFrom = Nothing

            End If

            DbUtils.CommitTransaction()
            myRec.Save()

        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)

        Finally
            DbUtils.EndTransaction()

        End Try

    End Sub

    Public Sub s_SaveSignatures(ByVal myPK As String)

        Try
            DbUtils.StartTransaction()

            ' Get an updateable AgreementExecution row
            Dim myAgreementExecutionRec As AgreementExecutionRecord = AgreementExecutionTable.GetRecord(myPK, True)
            Dim myRowOwnerCIX As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("RowOwnerCIX"))
            Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

            If ctlSignature.Visible = True Then

                Dim bmp As System.Drawing.Bitmap = ctlSignature.SaveSignature("")
                Dim imageData As Byte()
                Dim resizedImage As Byte()
                Using stream As New System.IO.MemoryStream()
                    bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
                    stream.Position = 0
                    imageData = New Byte(Convert.ToInt32(stream.Length) - 1) {}
                    stream.Read(imageData, 0, imageData.Length)
                    resizedImage = f_ResizeImage(imageData)
                    stream.Close()
                End Using

                If Not IsNothing(resizedImage) Then
                    If BaseApplicationPage.f_WeAreTheParty(myRowOwnerCIX, myUserID) Then
                        ' We are the sender
                        myAgreementExecutionRec.SenderSignature = resizedImage

                    Else
                        ' We are the recipient
                        myAgreementExecutionRec.RecipientSignature = resizedImage
                    End If
                End If

            End If

            If ctlInitials.Visible = True Then

                'Initials here.
                Dim intialsbmp As System.Drawing.Bitmap = ctlInitials.SaveSignature("")
                Dim intialsimageData As Byte()
                Using stream As New System.IO.MemoryStream()
                    intialsbmp.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
                    stream.Position = 0
                    intialsimageData = New Byte(Convert.ToInt32(stream.Length) - 1) {}
                    stream.Read(intialsimageData, 0, intialsimageData.Length)
                    stream.Close()
                End Using

                If Not IsNothing(intialsimageData) Then
                    If BaseApplicationPage.f_WeAreTheParty(myRowOwnerCIX, myUserID) Then
                        ' We are the sender
                        myAgreementExecutionRec.SenderInitials = intialsimageData

                    Else
                        ' We are the recipient
                        myAgreementExecutionRec.RecipientInitials = intialsimageData
                    End If
                End If

            End If


            myAgreementExecutionRec.Save()
            DbUtils.CommitTransaction()

        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)
        Finally
            DbUtils.EndTransaction()
        End Try

    End Sub

    Public Sub s_GenerateDocument(ByVal myPK As String)


        Dim myPartyID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Party"))
        If String.IsNullOrEmpty(myPartyID) Then
            myPartyID = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("RowOIX"))
        End If

        Dim myGenMessage As String = CustGenClass.f_GenerateDocument(myPK, myPartyID)

        If myGenMessage <> "Success" Then
            Utils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", myGenMessage)
        End If

    End Sub


    Public Sub s_SaveConfigData(ByVal myPK As String)

        Dim myCIX As String = SenderRCB.SelectedValue
        Dim mySenderAddrID As String = SenderAddrRCB.SelectedValue
        Dim mySenderSignerID As String = SenderSignerRCB.SelectedValue
        Dim myOIX As String = RecipientRCB.SelectedValue
        Dim myRecipientAddrID As String = RecipientAddrRCB.SelectedValue
        Dim myRecipientSignerID As String = RecipientSignerRCB.SelectedValue

        Dim mySignedOn As String = Nothing
        If Not IsNothing(SignedOnRDP.SelectedDate) Then
            mySignedOn = CStr(SignedOnRDP.SelectedDate)
        End If

        Dim myExpiresOn As String = Nothing
        If Not IsNothing(ExpiresOnRDP.SelectedDate) Then
            myExpiresOn = CStr(ExpiresOnRDP.SelectedDate)
        End If

        Dim myAddSignaturePage As String = "0"
        'If Me.AddSigPageCheckbox.Checked = True Then
        '    myAddSignaturePage = "1"
        'Else
        '    myAddSignaturePage = "0"
        'End If

        CustGenClass.f_Sproc("usp_ExecutionUpdate", myPK, myCIX & "," & mySenderAddrID & "," & mySenderSignerID & "," & myOIX & "," & myRecipientAddrID & "," & myRecipientSignerID & "," & mySignedOn & "," & myExpiresOn & "," & myAddSignaturePage)

    End Sub

    Public Sub s_SaveCustomData(ByVal myPK As String)

        Dim myExecutionID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Execution"))
        Dim myAgreeWhere As String = V_ExecutionView.ExecutionID.UniqueName & " = " & myExecutionID
        Dim myAgreeRec As V_ExecutionRecord = V_ExecutionView.GetRecord(myAgreeWhere)

        Dim myRowOwnerCIX As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("RowOwnerCIX"))
        Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

        Dim myWeAreTheParty As Boolean = f_WeAreTheParty(myRowOwnerCIX, myUserID)

        Try

            DbUtils.StartTransaction()
            Dim myRec As New AgreementExecutionRecord 'Record class for table to update.
            myRec = AgreementExecutionTable.GetRecord(myPK, True)

            If myAgreeRec.FirstTypeIDSpecified = True _
                And myAgreeRec.FirstItemNameSpecified = True _
                And ( _
                    (myAgreeRec.FirstByCIX = False And myAgreeRec.FirstByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.FirstByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.FirstByOIX = True)) Then
                If myAgreeRec.FirstTypeID = 42 Then
                    myRec.FirstItem = FirstItemRTB.Text
                ElseIf myAgreeRec.FirstTypeID = 43 Then
                    If FirstItemCB.Checked = True Then
                        myRec.FirstItem = "True"
                    Else
                        myRec.FirstItem = "False"
                    End If
                ElseIf myAgreeRec.FirstTypeID = 44 Then
                    myRec.FirstItem = FirstItemRCB.Text
                ElseIf myAgreeRec.FirstTypeID = 45 Then
                    myRec.FirstItem = CStr(FirstItemRDP.SelectedDate)
                ElseIf myAgreeRec.FirstTypeID = 48 Then
                    myRec.FirstItem = FirstItemRE.Content
                End If
            End If

            If myAgreeRec.SecondTypeIDSpecified = True _
                And myAgreeRec.SecondItemNameSpecified = True _
                And ( _
                    (myAgreeRec.SecondByCIX = False And myAgreeRec.SecondByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.SecondByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.SecondByOIX = True)) Then
                If myAgreeRec.SecondTypeID = 42 Then
                    myRec.SecondItem = SecondItemRTB.Text
                ElseIf myAgreeRec.SecondTypeID = 43 Then
                    If SecondItemCB.Checked = True Then
                        myRec.SecondItem = "True"
                    Else
                        myRec.SecondItem = "False"
                    End If
                ElseIf myAgreeRec.SecondTypeID = 44 Then
                    myRec.SecondItem = SecondItemRCB.Text
                ElseIf myAgreeRec.SecondTypeID = 45 Then
                    myRec.SecondItem = CStr(SecondItemRDP.SelectedDate)
                ElseIf myAgreeRec.SecondTypeID = 48 Then
                    myRec.SecondItem = SecondItemRE.Content
                End If
            End If

            If myAgreeRec.ThirdTypeIDSpecified = True _
                And myAgreeRec.ThirdItemNameSpecified = True _
                And ( _
                    (myAgreeRec.ThirdByCIX = False And myAgreeRec.ThirdByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.ThirdByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.ThirdByOIX = True)) Then
                If myAgreeRec.ThirdTypeID = 42 Then
                    myRec.ThirdItem = ThirdItemRTB.Text
                ElseIf myAgreeRec.ThirdTypeID = 43 Then
                    If ThirdItemCB.Checked = True Then
                        myRec.ThirdItem = "True"
                    Else
                        myRec.ThirdItem = "False"
                    End If
                ElseIf myAgreeRec.ThirdTypeID = 44 Then
                    myRec.ThirdItem = ThirdItemRCB.Text
                ElseIf myAgreeRec.ThirdTypeID = 45 Then
                    myRec.ThirdItem = CStr(ThirdItemRDP.SelectedDate)
                ElseIf myAgreeRec.ThirdTypeID = 48 Then
                    myRec.ThirdItem = ThirdItemRE.Content
                End If
            End If

            If myAgreeRec.FourthTypeIDSpecified = True _
                And myAgreeRec.FourthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.FourthByCIX = False And myAgreeRec.FourthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.FourthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.FourthByOIX = True)) Then
                If myAgreeRec.FourthTypeID = 42 Then
                    myRec.FourthItem = FourthItemRTB.Text
                ElseIf myAgreeRec.FourthTypeID = 43 Then
                    If FourthItemCB.Checked = True Then
                        myRec.FourthItem = "True"
                    Else
                        myRec.FourthItem = "False"
                    End If
                ElseIf myAgreeRec.FourthTypeID = 44 Then
                    myRec.FourthItem = FourthItemRCB.Text
                ElseIf myAgreeRec.FourthTypeID = 45 Then
                    myRec.FourthItem = CStr(FourthItemRDP.SelectedDate)
                ElseIf myAgreeRec.FourthTypeID = 48 Then
                    myRec.FourthItem = FourthItemRE.Content
                End If
            End If

            If myAgreeRec.FifthTypeIDSpecified = True _
                And myAgreeRec.FifthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.FifthByCIX = False And myAgreeRec.FifthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.FifthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.FifthByOIX = True)) Then
                If myAgreeRec.FifthTypeID = 42 Then
                    myRec.FifthItem = FifthItemRTB.Text
                ElseIf myAgreeRec.FifthTypeID = 43 Then
                    If FifthItemCB.Checked = True Then
                        myRec.FifthItem = "True"
                    Else
                        myRec.FifthItem = "False"
                    End If
                ElseIf myAgreeRec.FifthTypeID = 44 Then
                    myRec.FifthItem = FifthItemRCB.Text
                ElseIf myAgreeRec.FifthTypeID = 45 Then
                    myRec.FifthItem = CStr(FifthItemRDP.SelectedDate)
                ElseIf myAgreeRec.FifthTypeID = 48 Then
                    myRec.FifthItem = FifthItemRE.Content
                End If
            End If

            If myAgreeRec.SixthTypeIDSpecified = True _
                And myAgreeRec.SixthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.SixthByCIX = False And myAgreeRec.SixthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.SixthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.SixthByOIX = True)) Then
                If myAgreeRec.SixthTypeID = 42 Then
                    myRec.SixthItem = SixthItemRTB.Text
                ElseIf myAgreeRec.SixthTypeID = 43 Then
                    If SixthItemCB.Checked = True Then
                        myRec.SixthItem = "True"
                    Else
                        myRec.SixthItem = "False"
                    End If
                ElseIf myAgreeRec.SixthTypeID = 44 Then
                    myRec.SixthItem = SixthItemRCB.Text
                ElseIf myAgreeRec.SixthTypeID = 45 Then
                    myRec.SixthItem = CStr(SixthItemRDP.SelectedDate)
                ElseIf myAgreeRec.SixthTypeID = 48 Then
                    myRec.SixthItem = SixthItemRE.Content
                End If
            End If

            If myAgreeRec.SeventhTypeIDSpecified = True _
                And myAgreeRec.SeventhItemNameSpecified = True _
                And ( _
                    (myAgreeRec.SeventhByCIX = False And myAgreeRec.SeventhByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.SeventhByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.SeventhByOIX = True)) Then
                If myAgreeRec.SeventhTypeID = 42 Then
                    myRec.SeventhItem = SeventhItemRTB.Text
                ElseIf myAgreeRec.SeventhTypeID = 43 Then
                    If SeventhItemCB.Checked = True Then
                        myRec.SeventhItem = "True"
                    Else
                        myRec.SeventhItem = "False"
                    End If
                ElseIf myAgreeRec.SeventhTypeID = 44 Then
                    myRec.SeventhItem = SeventhItemRCB.Text
                ElseIf myAgreeRec.SeventhTypeID = 45 Then
                    myRec.SeventhItem = CStr(SeventhItemRDP.SelectedDate)
                ElseIf myAgreeRec.SeventhTypeID = 48 Then
                    myRec.SeventhItem = SeventhItemRE.Content
                End If
            End If

            If myAgreeRec.EighthTypeIDSpecified = True _
                And myAgreeRec.EighthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.EighthByCIX = False And myAgreeRec.EighthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.EighthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.EighthByOIX = True)) Then
                If myAgreeRec.EighthTypeID = 42 Then
                    myRec.EighthItem = EighthItemRTB.Text
                ElseIf myAgreeRec.EighthTypeID = 43 Then
                    If EighthItemCB.Checked = True Then
                        myRec.EighthItem = "True"
                    Else
                        myRec.EighthItem = "False"
                    End If
                ElseIf myAgreeRec.EighthTypeID = 44 Then
                    myRec.EighthItem = EighthItemRCB.Text
                ElseIf myAgreeRec.EighthTypeID = 45 Then
                    myRec.EighthItem = CStr(EighthItemRDP.SelectedDate)
                ElseIf myAgreeRec.EighthTypeID = 48 Then
                    myRec.EighthItem = EighthItemRE.Content
                End If
            End If

            If myAgreeRec.NinthTypeIDSpecified = True _
                And myAgreeRec.NinthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.NinthByCIX = False And myAgreeRec.NinthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.NinthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.NinthByOIX = True)) Then
                If myAgreeRec.NinthTypeID = 42 Then
                    myRec.NinthItem = NinthItemRTB.Text
                ElseIf myAgreeRec.NinthTypeID = 43 Then
                    If NinthItemCB.Checked = True Then
                        myRec.NinthItem = "True"
                    Else
                        myRec.NinthItem = "False"
                    End If
                ElseIf myAgreeRec.NinthTypeID = 44 Then
                    myRec.NinthItem = NinthItemRCB.Text
                ElseIf myAgreeRec.NinthTypeID = 45 Then
                    myRec.NinthItem = CStr(NinthItemRDP.SelectedDate)
                ElseIf myAgreeRec.NinthTypeID = 48 Then
                    myRec.NinthItem = NinthItemRE.Content
                End If
            End If

            If myAgreeRec.TenthTypeIDSpecified = True _
                And myAgreeRec.TenthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.TenthByCIX = False And myAgreeRec.TenthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.TenthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.TenthByOIX = True)) Then
                If myAgreeRec.TenthTypeID = 42 Then
                    myRec.TenthItem = TenthItemRTB.Text
                ElseIf myAgreeRec.TenthTypeID = 43 Then
                    If TenthItemCB.Checked = True Then
                        myRec.TenthItem = "True"
                    Else
                        myRec.TenthItem = "False"
                    End If
                ElseIf myAgreeRec.TenthTypeID = 44 Then
                    myRec.TenthItem = TenthItemRCB.Text
                ElseIf myAgreeRec.TenthTypeID = 45 Then
                    myRec.TenthItem = CStr(TenthItemRDP.SelectedDate)
                ElseIf myAgreeRec.TenthTypeID = 48 Then
                    myRec.TenthItem = TenthItemRE.Content
                End If
            End If

            If myAgreeRec.EleventhTypeIDSpecified = True _
                And myAgreeRec.EleventhItemNameSpecified = True _
                And ( _
                    (myAgreeRec.EleventhByCIX = False And myAgreeRec.EleventhByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.EleventhByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.EleventhByOIX = True)) Then
                If myAgreeRec.EleventhTypeID = 42 Then
                    myRec.EleventhItem = EleventhItemRTB.Text
                ElseIf myAgreeRec.EleventhTypeID = 43 Then
                    If EleventhItemCB.Checked = True Then
                        myRec.EleventhItem = "True"
                    Else
                        myRec.EleventhItem = "False"
                    End If
                ElseIf myAgreeRec.EleventhTypeID = 44 Then
                    myRec.EleventhItem = EleventhItemRCB.Text
                ElseIf myAgreeRec.EleventhTypeID = 45 Then
                    myRec.EleventhItem = CStr(EleventhItemRDP.SelectedDate)
                ElseIf myAgreeRec.EleventhTypeID = 48 Then
                    myRec.EleventhItem = EleventhItemRE.Content
                End If
            End If

            If myAgreeRec.TwelfthTypeIDSpecified = True _
                And myAgreeRec.TwelfthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.TwelfthByCIX = False And myAgreeRec.TwelfthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.TwelfthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.TwelfthByOIX = True)) Then
                If myAgreeRec.TwelfthTypeID = 42 Then
                    myRec.TwelfthItem = TwelfthItemRTB.Text
                ElseIf myAgreeRec.TwelfthTypeID = 43 Then
                    If TwelfthItemCB.Checked = True Then
                        myRec.TwelfthItem = "True"
                    Else
                        myRec.TwelfthItem = "False"
                    End If
                ElseIf myAgreeRec.TwelfthTypeID = 44 Then
                    myRec.TwelfthItem = TwelfthItemRCB.Text
                ElseIf myAgreeRec.TwelfthTypeID = 45 Then
                    myRec.TwelfthItem = CStr(TwelfthItemRDP.SelectedDate)
                ElseIf myAgreeRec.TwelfthTypeID = 48 Then
                    myRec.TwelfthItem = TwelfthItemRE.Content
                End If
            End If

            If myAgreeRec.ThirteenthTypeIDSpecified = True _
                And myAgreeRec.ThirteenthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.ThirteenthByCIX = False And myAgreeRec.ThirteenthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.ThirteenthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.ThirteenthByOIX = True)) Then
                If myAgreeRec.ThirteenthTypeID = 42 Then
                    myRec.ThirteenthItem = ThirteenthItemRTB.Text
                ElseIf myAgreeRec.ThirteenthTypeID = 43 Then
                    If ThirteenthItemCB.Checked = True Then
                        myRec.ThirteenthItem = "True"
                    Else
                        myRec.ThirteenthItem = "False"
                    End If
                ElseIf myAgreeRec.ThirteenthTypeID = 44 Then
                    myRec.ThirteenthItem = ThirteenthItemRCB.Text
                ElseIf myAgreeRec.ThirteenthTypeID = 45 Then
                    myRec.ThirteenthItem = CStr(ThirteenthItemRDP.SelectedDate)
                ElseIf myAgreeRec.ThirteenthTypeID = 48 Then
                    myRec.ThirteenthItem = ThirteenthItemRE.Content
                End If
            End If

            If myAgreeRec.FourteenthTypeIDSpecified = True _
                And myAgreeRec.FourteenthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.FourteenthByCIX = False And myAgreeRec.FourteenthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.FourteenthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.FourteenthByOIX = True)) Then
                If myAgreeRec.FourteenthTypeID = 42 Then
                    myRec.FourteenthItem = FourteenthItemRTB.Text
                ElseIf myAgreeRec.FourteenthTypeID = 43 Then
                    If FourteenthItemCB.Checked = True Then
                        myRec.FourteenthItem = "True"
                    Else
                        myRec.FourteenthItem = "False"
                    End If
                ElseIf myAgreeRec.FourteenthTypeID = 44 Then
                    myRec.FourteenthItem = FourteenthItemRCB.Text
                ElseIf myAgreeRec.FourteenthTypeID = 45 Then
                    myRec.FourteenthItem = CStr(FourteenthItemRDP.SelectedDate)
                ElseIf myAgreeRec.FourteenthTypeID = 48 Then
                    myRec.FourteenthItem = FourteenthItemRE.Content
                End If
            End If

            If myAgreeRec.FifteenthTypeIDSpecified = True _
                And myAgreeRec.FifteenthItemNameSpecified = True _
                And ( _
                    (myAgreeRec.FifteenthByCIX = False And myAgreeRec.FifteenthByOIX = False) _
                     Or (myWeAreTheParty = True And myAgreeRec.FifteenthByCIX = True) _
                     Or (myWeAreTheParty = False And myAgreeRec.FifteenthByOIX = True)) Then
                If myAgreeRec.FifteenthTypeID = 42 Then
                    myRec.FifteenthItem = FifteenthItemRTB.Text
                ElseIf myAgreeRec.FifteenthTypeID = 43 Then
                    If FifteenthItemCB.Checked = True Then
                        myRec.FifteenthItem = "True"
                    Else
                        myRec.FifteenthItem = "False"
                    End If
                ElseIf myAgreeRec.FifteenthTypeID = 44 Then
                    myRec.FifteenthItem = FifteenthItemRCB.Text
                ElseIf myAgreeRec.FifteenthTypeID = 45 Then
                    myRec.FifteenthItem = CStr(FifteenthItemRDP.SelectedDate)
                ElseIf myAgreeRec.FifteenthTypeID = 48 Then
                    myRec.FifteenthItem = FifteenthItemRE.Content
                End If
            End If

            DbUtils.CommitTransaction()
            myRec.Save()

        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)

        Finally
            DbUtils.EndTransaction()

        End Try

    End Sub


    Public Shared Function f_ResizeImage(ByVal imgByte As Byte()) As Byte()

        'Dim bmpMS As System.IO.MemoryStream = New System.IO.MemoryStream(imgByte)

        Dim myCurrentBmp As New Bitmap(New System.IO.MemoryStream(imgByte))
        'bmpMS.Seek(0, System.IO.SeekOrigin.Begin)
        'Dim myCurrentBmp As New Bitmap(bmpMS)

        Dim height As Integer = 50
        Dim percentResize As Double = 1 - height / myCurrentBmp.Height
        Dim width As Integer = Convert.ToInt32(myCurrentBmp.Width - (myCurrentBmp.Width * percentResize))

        Dim myHolderBmp As New Bitmap(width, height)
        Dim g As Graphics = Graphics.FromImage(myHolderBmp)
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.DrawImage(myCurrentBmp, New Rectangle(0, 0, width, height), New Rectangle(0, 0, myCurrentBmp.Width, myCurrentBmp.Height), GraphicsUnit.Pixel)

        Dim myBmpOutMS As System.IO.MemoryStream = New System.IO.MemoryStream()
        myHolderBmp.Save(myBmpOutMS, System.Drawing.Imaging.ImageFormat.Png) 'can use any image format 

        Return myBmpOutMS.ToArray()

    End Function

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


    Public Sub UploadTemplateButton_Click(ByVal sender As Object, ByVal args As EventArgs)
        ' Click handler for UploadTemplateButton.
        ' Customize by adding code before the call or replace the call to the Base function with your own code.
        Dim url As String = "../AgreementExecution/UploadTemplate.aspx?Execution=" & Me.Page.Request.QueryString("Execution")

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

    Public Sub UploadPDFButton_Click(ByVal sender As Object, ByVal args As EventArgs)
        ' Click handler for UploadPDFButton.
        ' Customize by adding code before the call or replace the call to the Base function with your own code.
        Dim url As String = "../AgreementExecution/UploadSignedDoc.aspx?Execution=" & Me.Page.Request.QueryString("Execution")

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



    Public Sub Page_PreRender() Handles Me.PreRender

        s_Vis()
        s_FlowControls()
        s_ShowButtons()

    End Sub



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

        AddHandler Me.UploadPDFButton.Button.Click, AddressOf UploadPDFButton_Click

        AddHandler Me.UploadTemplateButton.Button.Click, AddressOf UploadTemplateButton_Click

        Me.ClearControlsFromSession()
    End Sub

    Public Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
        ' Handles MyBase.Init. 
        ' Register the Event handler for any Events.
        Me.Page_InitializeEventHandlers_Base(sender, e)
    End Sub
End Class
