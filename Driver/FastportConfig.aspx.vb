
Imports BaseClasses
Imports BaseClasses.Utils

Imports FASTPORT.UI
Imports FASTPORT.Business
Imports FASTPORT.Data

Imports Telerik.Web.UI
Imports System.Data.SqlClient

Partial Class FastportConfig
    Inherits FASTPORT.UI.BaseApplicationPage
    Implements System.Web.UI.ICallbackEventHandler

    ' hold callback return value
    Private returnValue As String

    Public Function GetCallbackResult() As String Implements System.Web.UI.ICallbackEventHandler.GetCallbackResult
        'Paul -- Step 6:  Proceedure sends result back to JavaScript.
        Return returnValue
    End Function

    Public Sub RaiseCallbackEvent(ByVal args As String) Implements System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent
        ' encrypt whatever is passed to args and pass to returnValue
        'Paul -- Step 5:  Code behind gets and processes value sent by ISD.  Function below provides encryption and whatever else is needed (could even set session variables.  awesome.)
        returnValue = f_ProcessURL(args)
    End Sub

    Public Function f_ProcessURL(ByVal myArgs As String) As String

        Dim myAction As String = CustGenClass.f_Split_ByComma(myArgs, 1)
        Dim my1st As String = CustGenClass.f_Split_ByComma(myArgs, 2)
        Dim my2nd As String = CustGenClass.f_Split_ByComma(myArgs, 3)
        Dim my3rd As String = CustGenClass.f_Split_ByComma(myArgs, 4)
        Dim my4th As String = CustGenClass.f_Split_ByComma(myArgs, 5)
        Dim my5th As String = CustGenClass.f_Split_ByComma(myArgs, 6)

        Dim myMessage As String = "Nothing"
        Dim myReturn As String = "Nothing"
        Dim mySproc As String = "0"
        Dim myTab As String = "0"

        Dim myPartyID As String = Me.HiddenTB_PartyID.Text
        Dim myPartyID_Encrypt As String = CustGenClass.f_Encrypt(myPartyID)
        Dim myMeID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

        Dim myTreeID As String
        Dim myTreeParentID As String
        Dim myTreeName As String
        Dim myFlowStep As String = Nothing

        'Actions for general tab.
        If myAction = "AddrEdit" Then

            Dim myW As String = PartyAddrTable.AddrID.UniqueName & " = " & my1st
            Dim myR As PartyAddrRecord = PartyAddrTable.GetRecord(myW)
            Dim myZipID As String = CStr(myR.AddrZipID)
            Dim myCitySTZip As String = CustGenClass.f_Sproc("usp_GetCitySTZip", myZipID)
            myReturn = _
                If(myR.Addr, "") & "<|>" & _
                If(myR.Addr2, "") & "<|>" & _
                If(myZipID, "") & "<|>" & _
                If(myCitySTZip, "") & "<|>" & _
                If(CStr(myR.MovedIn.ToShortDateString), "") & "<|>" & _
                If(CStr(myR.MovedOut), "") & "<|>" & _
                If(CStr(myR.MovedOutOn.ToShortDateString), "")

        ElseIf myAction = "onInstClick" Then

            Dim myWhere As String = FlowConfigTable.ConfigID.UniqueName & " = " & my1st
            Dim myRec As FlowConfigRecord = FlowConfigTable.GetRecord(myWhere)
            myReturn = myRec.Instructions

        ElseIf myAction = "deleteAddr" Then

            myReturn = CustGenClass.f_Sproc("usp_AddrDelete", my1st)

        ElseIf myAction = "updateExpSlider" Then

            mySproc = CustGenClass.f_Sproc("usp_Sliders_Importance", my1st, my2nd)

            If mySproc <> "1" Then
                myMessage = "<span style='color: #ff0000;'>WARNING:</span> The system was unable to update the importance of this item. " & _
                                "If the problem continues, please contact support. Here are the techincal details of this error: " & mySproc
            End If

            myReturn = myMessage

        ElseIf myAction = "HistValues" Then

            myReturn = f_HistValues(my1st)

        ElseIf myAction = "CarrierValues" Then

            myReturn = f_CarrierValues(my1st)

        ElseIf myAction = "HistDel" Then

            mySproc = CustGenClass.f_Sproc("usp_HistoryDelete", my1st)
            If mySproc = "1" Then
                myReturn = "Nothing"
            Else
                myReturn = mySproc
            End If
            'Added By Princy-27.5.2013
        ElseIf myAction = "dropJob" Then

            mySproc = CustGenClass.f_Sproc("usp_HistoryOverlap", my1st, my2nd)
            myReturn = mySproc

        ElseIf myAction = "reorderJob" Then

            mySproc = CustGenClass.f_Sproc("usp_HistoryDragToReorder", my1st, my2nd, my3rd)
            myReturn = mySproc

        ElseIf myAction = "DateWarning" Then

            myReturn = f_DateWarnings(my1st, my2nd, my3rd, my4th)

        ElseIf myAction = "DateWarning1" Then

            mySproc = CustGenClass.f_Sproc("usp_FirstJob", my1st, my3rd, my4th)
            Dim myReturn1 As String = mySproc
            Dim myReturn2 As String = f_DateWarnings(my1st, my2nd, my4th, my5th)
            myReturn = myReturn1 & "<||>" & myReturn2

        ElseIf myAction = "MCNumberDup" Then

            myReturn = f_MCNumberDups(my1st, my2nd)

        ElseIf myAction = "DOTNumberDup" Then

            myReturn = f_DOTNumberDups(my1st, my2nd)

        ElseIf myAction = "loadExperienceNotes" Then

            myReturn = f_ExperienceNotesGet(my1st)

        ElseIf myAction = "updateExperienceNotes" Then

            my2nd = Replace(my2nd, "<|>", ",")
            myReturn = f_UpdateExperienceNotes(my1st, my2nd)

        ElseIf myAction = "onLockIncidentRBClicked" Then

            CustGenClass.f_Sproc("usp_IncidentLock", my1st, my2nd)
            Return "Incident"

        ElseIf myAction = "deleteIncidentItem" Then

            mySproc = CustGenClass.f_Sproc("usp_IncidentDelete", my1st)
            If mySproc = "1" Then
                myReturn = "Nothing"
            Else
                myReturn = "<span style='color: #FF0000;>WARNING: </span> the system was unable to delete this accident, event, or honor.  If the problem continues, please contact support."
            End If

        ElseIf myAction = "editIncident" Then

            myReturn = f_IncidentEditURL(my1st, my2nd)

        End If

        Return myReturn

    End Function

    '*************************
    '*************************
    '*************************
    'To Do Begin
    '*************************
    '*************************
    '*************************

    Protected Sub FastportRTS_TabClick(sender As Object, e As Telerik.Web.UI.RadTabStripEventArgs) Handles FastportRTS.TabClick

        Dim myTab As RadTab = e.Tab
        Dim myItemID As String = myTab.Attributes("ItemID")

        If myItemID = "2526" Then

            MenuRadGrid.Rebind()
            MustActRG.Rebind()
            WaitingRG.Rebind()
            Dim myPartyID As String = Me.HiddenTB_PartyID.Text
            Dim myGaugeID As String = CustGenClass.f_Sproc("usp_GaugeImageID", myPartyID)
            Dim myGaugeURL As String = f_ImagePath(myGaugeID)
            Me.GaugeImage.ImageUrl = myGaugeURL
            Me.GaugeImage.Attributes.Add("Width", "110px")
            Me.GaugeImage.Attributes.Add("Height", "175px")

        Else

            Dim myPartyID As String = Me.HiddenTB_PartyID.Text
            myPartyID = CustGenClass.f_Encrypt(myPartyID)

            Me.Response.Redirect("../Sandbox/DocSandbox.aspx?Party=" & myPartyID)

        End If

    End Sub

    '*************************
    '*************************
    '*************************
    'To Do End
    '*************************
    '*************************
    '*************************

    '*************************
    '*************************
    '*************************
    'GeneralBegin
    '*************************
    '*************************
    '*************************

    Public Sub s_LoadData(ByVal myPartyID As String)

        Dim myWhere As String = PartyTable.PartyID.UniqueName & " = " & myPartyID
        Dim myRec As PartyRecord = PartyTable.GetRecord(myWhere)

        EmailTB.Text = myRec.Email
        NameTB.Text = myRec.Name
        HandleTB.Text = myRec.Handle
        DirectDialRadTB.Text = myRec.DirectDial
        MobileRadTB.Text = myRec.Mobile
        OtherRadTB.Text = myRec.OtherPhone
        FaxRadTB.Text = myRec.Fax

        Dim myDriverWhere As String = PartyDriverTable.PartyID.UniqueName & " = " & myPartyID
        Dim myDriverRecord As PartyDriverRecord = PartyDriverTable.GetRecord(myDriverWhere)

        Dim myTruckerTypeID As String = CStr(myDriverRecord.TruckerTypeID)

        If Not IsNull(myTruckerTypeID) Then
            TruckerTypeRCB.SelectedValue = myTruckerTypeID
            Dim myTreeName As String
            If myTruckerTypeID <> "0" Then
                myTreeName = CustGenClass.f_Sproc("usp_TreeName", myTruckerTypeID)
            Else
                myTreeName = "**Please Select**'"
            End If
            TruckerTypeRCB.Text = myTreeName
        End If

        If Not IsNull(myDriverRecord.DateOfBirth) And myDriverRecord.DateOfBirth <> CDate("#12:00:00 AM#") Then
            DOBRadTB.Text = CStr(myDriverRecord.DateOfBirth)
        End If
        If Not IsNull(myDriverRecord.SocialSecurityNumber) Then
            SSNRadTB.Text = myDriverRecord.SocialSecurityNumber
        End If
        USCitizenCB.Checked = myDriverRecord.USCitizen
        AuthAlienCB.Checked = myDriverRecord.AuthorizedAlien
        Dim myAuthTypeID As String = CStr(myDriverRecord.AuthorizationTypeID)
        If Not String.IsNullOrEmpty(myAuthTypeID) Then
            AuthTypeRadCombo.SelectedValue = myAuthTypeID
        End If
        VisaTB.Text = myDriverRecord.VisaNumber

        If Not IsNull(myDriverRecord.AuthorizationTypeID) Then
            Dim myAuthType As String = CustGenClass.f_Sproc("usp_TreeName", CStr(myDriverRecord.AuthorizationTypeID))
            AuthTypeRadCombo.Text = myAuthType
        End If

        s_VisPersonalFields(myDriverRecord.USCitizen, myDriverRecord.AuthorizedAlien)

    End Sub

    Public Sub s_LockNameFields(ByVal LockYesNo As String)


        If LockYesNo = "Yes" Then
            EmailTB.Enabled = False
            NameTB.Enabled = False
            HandleTB.Enabled = False
            TruckerTypeRCB.Enabled = False
            DirectDialRadTB.Enabled = False
            MobileRadTB.Enabled = False
            OtherRadTB.Enabled = False
            FaxRadTB.Enabled = False
        Else
            EmailTB.Enabled = True
            NameTB.Enabled = True
            HandleTB.Enabled = True
            TruckerTypeRCB.Enabled = True
            DirectDialRadTB.Enabled = True
            MobileRadTB.Enabled = True
            OtherRadTB.Enabled = True
            FaxRadTB.Enabled = True
        End If

    End Sub

    Public Sub s_LockPersonalFields(ByVal LockYesNo As String)

        If LockYesNo = "Yes" Then
            DOBRadTB.Enabled = False
            SSNRadTB.Enabled = False
            USCitizenCB.Enabled = False
            AuthAlienCB.Enabled = False
            AuthTypeRadCombo.Enabled = False
            VisaTB.Enabled = False
        Else
            DOBRadTB.Enabled = True
            SSNRadTB.Enabled = True
            USCitizenCB.Enabled = True
            AuthAlienCB.Enabled = True
            AuthTypeRadCombo.Enabled = True
            VisaTB.Enabled = True
        End If

    End Sub

    Public Sub s_USCitizenCB_Checked() Handles USCitizenCB.CheckedChanged

        s_VisPersonalFields(USCitizenCB.Checked, AuthAlienCB.Checked)

    End Sub

    Public Sub s_AuthAlienCB() Handles AuthAlienCB.CheckedChanged

        s_VisPersonalFields(USCitizenCB.Checked, AuthAlienCB.Checked)

    End Sub

    Public Sub s_VisPersonalFields(ByVal USCitizen As Boolean, ByVal AuthAlien As Boolean)

        If USCitizen = True Then
            AuthorizedAlienLabel.Visible = False
            AuthAlienCB.Visible = False
            AuthTypeLabel.Visible = False
            AuthTypeRadCombo.Visible = False
            VisaLabel.Visible = False
            VisaTB.Visible = False
        Else
            AuthorizedAlienLabel.Visible = True
            AuthAlienCB.Visible = True
            If AuthAlien = True Then
                AuthTypeLabel.Visible = True
                AuthTypeRadCombo.Visible = True
                VisaLabel.Visible = True
                VisaTB.Visible = True
            Else
                AuthTypeLabel.Visible = False
                AuthTypeRadCombo.Visible = False
                VisaLabel.Visible = False
                VisaTB.Visible = False
            End If
        End If

    End Sub

    Public Sub s_NameRadButton_Click() Handles NameRadButton.Click

        Dim myButtonText As String = NameRadButton.Text
        Dim myPartyID As String = Me.HiddenTB_PartyID.Text

        If myButtonText = "Edit" Then
            s_LockNameFields("No")
            NameRadButton.Text = "Save"
            NameRadButton.ToolTip = "Click here to edit the fields shown above."
        Else
            s_LockNameFields("Yes")
            NameRadButton.Text = "Edit"
            NameRadButton.ToolTip = "Click to save the data in the fields shown above."
            s_SaveNameFields()

            FastportRTS.Tabs.Clear()
            s_Vis_FastportRTS(myPartyID)
            FastportRTS.DataBind()

            'To Do: Rebind tasks here.
        End If

    End Sub

    Public Sub s_SaveNameFields()

        Dim myPartyID As String = Me.HiddenTB_PartyID.Text
        Dim myTruckerTypeID As Integer = CInt(TruckerTypeRCB.SelectedValue)

        Try
            DbUtils.StartTransaction()
            Dim myRec As New PartyRecord 'Record class for table to update.
            myRec = PartyTable.GetRecord(myPartyID, True)
            If Not IsNothing(EmailTB.Text) And Not IsNull(EmailTB.Text) Then
                myRec.Email = EmailTB.Text
            End If
            myRec.Name = NameTB.Text
            myRec.Handle = HandleTB.Text
            myRec.DirectDial = DirectDialRadTB.Text
            myRec.Mobile = MobileRadTB.Text
            myRec.OtherPhone = OtherRadTB.Text
            myRec.Fax = FaxRadTB.Text
            DbUtils.CommitTransaction()
            myRec.Save()
        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)
        Finally
            DbUtils.EndTransaction()
        End Try


        Dim myDriverID As String = Me.HiddenTB_DriverID.Text

        Try
            DbUtils.StartTransaction()
            Dim myRec As New PartyDriverRecord 'Record class for table to update.
            myRec = PartyDriverTable.GetRecord(myDriverID, True)
            If myTruckerTypeID <> 0 Then
                myRec.TruckerTypeID = myTruckerTypeID
            Else
                myRec.SetTruckerTypeIDFieldValue("")
            End If
            DbUtils.CommitTransaction()
            myRec.Save()
        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)
        Finally
            DbUtils.EndTransaction()
        End Try

        Dim myPref_OwnerOpYesNo As String

        If myTruckerTypeID = 2529 Or myTruckerTypeID = 2530 Or myTruckerTypeID = 2531 Then
            myPref_OwnerOpYesNo = "Yes"
        Else
            myPref_OwnerOpYesNo = "No"
        End If

        Dim mySproc As String = CustGenClass.f_Sproc("usp_OwnerOperatorFlip", myPartyID, myPref_OwnerOpYesNo)

    End Sub

    Public Sub s_PersonalRadButton_Click() Handles PersonalRadButton.Click

        Dim myButtonText As String = PersonalRadButton.Text

        If myButtonText = "Edit" Then
            s_LockPersonalFields("No")
            PersonalRadButton.Text = "Save"
            PersonalRadButton.ToolTip = "Click here to edit the fields shown above."
        Else
            s_LockPersonalFields("Yes")
            PersonalRadButton.Text = "Edit"
            PersonalRadButton.ToolTip = "Click to save the data in the fields shown above."
            s_SavePersonalFields()
            'To Do: Rebind tasks here.
        End If

    End Sub

    Public Sub s_SavePersonalFields()


        Dim myDriverID As String = Me.HiddenTB_DriverID.Text

        Try
            DbUtils.StartTransaction()
            Dim myRec As New PartyDriverRecord 'Record class for table to update.
            myRec = PartyDriverTable.GetRecord(myDriverID, True)
            If String.IsNullOrEmpty(DOBRadTB.Text) Then
                myRec.SetDateOfBirthFieldValue("")
            Else
                myRec.DateOfBirth = CDate(Replace(DOBRadTB.TextWithPromptAndLiterals, "_", ""))
            End If
            myRec.SocialSecurityNumber = SSNRadTB.Text
            myRec.USCitizen = USCitizenCB.Checked
            myRec.AuthorizedAlien = AuthAlienCB.Checked
            If AuthTypeRadCombo.SelectedValue <> "0" Then
                myRec.AuthorizationTypeID = CInt(AuthTypeRadCombo.SelectedValue)
            End If
            myRec.VisaNumber = VisaTB.Text
            DbUtils.CommitTransaction()
            myRec.Save()

        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)

        Finally
            DbUtils.EndTransaction()

        End Try

    End Sub

    Public Sub s_Pref_EditRB_Click() Handles Pref_EditRB.Click

        Dim myButtonText As String = Pref_EditRB.Text

        If myButtonText = "Edit" Then
            s_LockPrefFields("No")
            Pref_EditRB.Text = "Save"
            Pref_EditRB.ToolTip = "Click here to edit the fields shown above."
        Else
            s_LockPrefFields("Yes")
            Pref_EditRB.Text = "Edit"
            Pref_EditRB.ToolTip = "Click to save the data in the fields shown above."
            Dim myWarning As String = f_SavePrefFields()
            If myWarning <> "Success" Then
                RadAjaxManager1.ResponseScripts.Add("launchRadAlert('" & myWarning & "','Save Failed');")
            End If
        End If

    End Sub

    Public Sub s_LockPrefFields(ByVal LockYesNo As String)

        If LockYesNo = "Yes" Then
            Pref_GeneralRAC.Enabled = False
            Pref_GeneralRB.Visible = True
            Pref_EquipRAC.Enabled = False
            Pref_EquipRB.Visible = True
            Pref_CommodityRAC.Enabled = False
            Pref_CommodityRB.Visible = True
            Pref_RegionsRAC.Enabled = False
            Pref_RegionsRB.Visible = True
            Pref_OtherRAC.Enabled = False
            Pref_OtherRB.Visible = True
        Else
            Pref_GeneralRAC.Enabled = True
            Pref_GeneralRB.Visible = False
            Pref_EquipRAC.Enabled = True
            Pref_EquipRB.Visible = False
            Pref_CommodityRAC.Enabled = True
            Pref_CommodityRB.Visible = False
            Pref_RegionsRAC.Enabled = True
            Pref_RegionsRB.Visible = False
            Pref_OtherRAC.Enabled = True
            Pref_OtherRB.Visible = False
        End If

    End Sub

    Public Function f_SavePrefFields() As String

        Dim myPartyID As String = Me.HiddenTB_PartyID.Text
        Dim myParents As String = "743"
        Dim myChildren As String = ""
        Dim myWarning As String = Nothing
        Dim myReturnMessage As String = Nothing

        For Each entry As AutoCompleteBoxEntry In Pref_GeneralRAC.Entries
            Dim myExperienceID As String = entry.Value
            myChildren = myChildren & myExperienceID & ","
        Next

        myReturnMessage = CustGenClass.f_Sproc("usp_ExpAdd_FromRAC", "Party", myPartyID, myParents, If(myChildren, ""))
        If myReturnMessage <> "Success" Then
            myWarning = BaseApplicationPage.f_Warning(myWarning, myReturnMessage)
        End If

        myParents = "389"
        myChildren = ""

        For Each entry As AutoCompleteBoxEntry In Pref_EquipRAC.Entries
            Dim myExperienceID As String = entry.Value
            myChildren = myChildren & myExperienceID & ","
        Next

        myReturnMessage = CustGenClass.f_Sproc("usp_ExpAdd_FromRAC", "Party", myPartyID, myParents, If(myChildren, ""))
        If myReturnMessage <> "Success" Then
            myWarning = BaseApplicationPage.f_Warning(myWarning, myReturnMessage)
        End If

        myParents = "666"
        myChildren = ""

        For Each entry As AutoCompleteBoxEntry In Pref_CommodityRAC.Entries
            Dim myExperienceID As String = entry.Value
            myChildren = myChildren & myExperienceID & ","
        Next

        myReturnMessage = CustGenClass.f_Sproc("usp_ExpAdd_FromRAC", "Party", myPartyID, myParents, If(myChildren, ""))
        If myReturnMessage <> "Success" Then
            myWarning = BaseApplicationPage.f_Warning(myWarning, myReturnMessage)
        End If

        myParents = "741"
        myChildren = ""

        For Each entry As AutoCompleteBoxEntry In Pref_RegionsRAC.Entries
            Dim myExperienceID As String = entry.Value
            myChildren = myChildren & myExperienceID & ","
        Next

        myReturnMessage = CustGenClass.f_Sproc("usp_ExpAdd_FromRAC", "Party", myPartyID, myParents, If(myChildren, ""))
        If myReturnMessage <> "Success" Then
            myWarning = BaseApplicationPage.f_Warning(myWarning, myReturnMessage)
        End If

        myParents = "851,852,853"
        myChildren = ""

        For Each entry As AutoCompleteBoxEntry In Pref_OtherRAC.Entries
            Dim myExperienceID As String = entry.Value
            myChildren = myChildren & myExperienceID & ","
        Next

        myReturnMessage = CustGenClass.f_Sproc("usp_ExpAdd_FromRAC", "Party", myPartyID, myParents, If(myChildren, ""))
        If myReturnMessage <> "Success" Then
            myWarning = BaseApplicationPage.f_Warning(myWarning, myReturnMessage)
        End If

        If String.IsNullOrEmpty(myWarning) Then
            myWarning = "Success"
        End If

        Return myWarning

    End Function

    Public Sub s_Pref_Load()

        s_Prefs_RACs_Load("743", Pref_GeneralRAC)
        s_Prefs_RACs_Load("389", Pref_EquipRAC)
        s_Prefs_RACs_Load("666", Pref_CommodityRAC)
        s_Prefs_RACs_Load("741", Pref_RegionsRAC)
        s_Prefs_RACs_Load("851", Pref_OtherRAC)
        s_Prefs_RACs_Load("852", Pref_OtherRAC, "No")
        s_Prefs_RACs_Load("853", Pref_OtherRAC, "No")

    End Sub


    Public Sub s_Prefs_RACs_Load(ByVal myParentID As String, ByVal myRAC As RadAutoCompleteBox, Optional ByVal myClear As String = "Yes")

        If myClear = "Yes" Then
            myRAC.Entries.Clear()
        End If

        Try

            Dim myPartyID As String = Me.HiddenTB_PartyID.Text
            Dim data As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_PrefsByDriver_ForRAC", "Party", myPartyID, myParentID)

            Dim endOffset As Integer = data.Rows.Count

            Dim i As Integer = 0
            While i < endOffset
                Dim myNodeText As String = data.Rows(i)("PrefsHTML").ToString()
                Dim myNodeID As String = data.Rows(i)("ExperienceID").ToString()
                myRAC.Entries.Add(New AutoCompleteBoxEntry(myNodeText, myNodeID))
                i = i + 1
            End While

        Catch ex As Exception

        End Try

    End Sub

    Protected Sub PrefRG_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles PrefRG.ItemDataBound

        If TypeOf e.Item Is GridDataItem Then

            Dim dataItem As GridDataItem = CType(e.Item, GridDataItem)
            Dim myImportance As Integer = CInt(dataItem.GetDataKeyValue("Importance").ToString)
            Dim mySlider As RadSlider = CType(dataItem("ImportanceColumn").Controls(1), RadSlider)
            mySlider.Value = CDec(myImportance)

            Dim PrefRTT_DelIB As ImageButton = DirectCast(dataItem("PrefRTT_PrefDelIBColumn").FindControl("PrefRTT_PrefDelIB"), ImageButton)
            PrefRTT_DelIB.Attributes.Add("onclick", "onPrefRTT_DelIBClick('" + CStr(dataItem.ItemIndex) + "');")

        End If

    End Sub

    '*************************
    '*************************
    '*************************
    'GenEnd
    '*************************
    '*************************
    '*************************


    '*************************
    '*************************
    '*************************
    'AddrRWStart
    '*************************
    '*************************
    '*************************


    Protected Sub AddrRadGrid_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles AddrRadGrid.ItemDataBound

        If TypeOf e.Item Is GridDataItem Then

            Dim dataItem As GridDataItem = CType(e.Item, GridDataItem)
            Dim myAddrID As String = dataItem.GetDataKeyValue("AddrID").ToString

            If String.IsNullOrEmpty(myAddrID) Then
                Dim AddrDeleteIB As ImageButton = DirectCast(dataItem("AddrDeleteCol").FindControl("AddrDeleteIB"), ImageButton)
                AddrDeleteIB.Visible = False
            End If

        End If

    End Sub

    Private Const ItemsPerRequest As Integer = 10
    Protected Sub s_AddrZipRCB_ItemsRequested(ByVal sender As Object, ByVal e As RadComboBoxItemsRequestedEventArgs) Handles AddrZipRCB.ItemsRequested

        Try

            Dim data As DataTable = f_ZipCombo_GetDataAddr(e.Text)

            Dim itemOffset As Integer = e.NumberOfItems
            Dim endOffset As Integer = Math.Min(itemOffset + ItemsPerRequest, data.Rows.Count)
            e.EndOfItems = endOffset = data.Rows.Count

            Dim i As Integer = itemOffset
            While i < endOffset
                AddrZipRCB.Items.Add(New RadComboBoxItem(data.Rows(i)("Info").ToString(), data.Rows(i)("PK").ToString()))
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While


        Catch ex As Exception

        End Try

    End Sub

    Public Function f_ZipCombo_GetDataAddr(ByVal text As String) As DataTable

        Dim myCountryID As String = "3"
        Dim myDataTable As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_PickZip", text, myCountryID)
        Return myDataTable

    End Function

    Protected Sub AddrRadGrid_ItemCreated(sender As Object, e As GridItemEventArgs) Handles AddrRadGrid.ItemCreated
        If TypeOf e.Item Is GridDataItem Then
            Dim item As GridDataItem = DirectCast(e.Item, GridDataItem)
            'Dim AddrEditRB As RadButton = DirectCast(item("AddrEditCol").FindControl("AddrEditRB"), RadButton)
            'AddrEditRB.Attributes.Add("onclick", "onAddrEditClick('" + CStr(item.ItemIndex) + "');")
            Dim AddrDeleteRB As ImageButton = DirectCast(item("AddrDeleteCol").FindControl("AddrDeleteIB"), ImageButton)
            AddrDeleteRB.Attributes.Add("onclick", "onAddrDeleteClick('" + CStr(item.ItemIndex) + "');")
        End If
    End Sub

    Public Sub AddrSaveRB_Click() Handles AddrSaveRB.Click

        Try

            Dim myAddrID As String = HiddenTB_AddrID.Text
            Dim myAddr As String = AddrRTB.Text
            Dim myAddr2 As String = Addr2RTB.Text
            Dim myZipID As String = AddrZipRCB.SelectedValue
            If String.IsNullOrEmpty(myZipID) Then
                myZipID = Me.HiddenTB_AddrZipID.Text
            End If

            Dim myMovedIn As String = Nothing
            If Not IsNull(MovedInRDP.SelectedDate) Then
                myMovedIn = CStr(MovedInRDP.SelectedDate)
            End If
            Dim myMovedOut As Boolean = MovedOutCB.Checked
            Dim myMovedOutOn As String = Nothing
            If myMovedOut = True And Not IsNull(MovedOutRDP.SelectedDate) Then
                myMovedOutOn = CStr(MovedOutRDP.SelectedDate)
            End If

            'LAT/LONGS HERE

            Dim myLat As String = ""
            Dim myLong As String = ""



            If myAddrID = "0" Then
                s_AddrAdd(myAddr, myAddr2, myZipID, myMovedIn, myMovedOut, myMovedOutOn)
            Else
                s_AddrEdit(myAddr, myAddr2, myZipID, myMovedIn, myMovedOut, myMovedOutOn)
            End If

            AddrRadSlider.DataBind()
            AddrRadGrid.Rebind()

            RadAjaxManager1.ResponseScripts.Add("closeAddrRW();")

        Catch ex As Exception

            Dim myMessage As String = ex.Message

        End Try

    End Sub

    Public Sub s_AddrAdd(ByVal myAddr As String, ByVal myAddr2 As String, ByVal myZipID As String, ByVal myMovedIn As String, _
                            ByVal myMovedOut As Boolean, ByVal myMovedOutOn As String)

        Try
            ' Enclose all database retrieval/update code within a Transaction boundary
            Dim myPartyID As String = Me.HiddenTB_PartyID.Text
            DbUtils.StartTransaction()
            Dim myRec As New PartyAddrRecord
            myRec.PartyID = CInt(myPartyID)
            myRec.Addr = myAddr
            myRec.Addr2 = myAddr2
            If myZipID <> "0" Then
                myRec.AddrZipID = CInt(myZipID)
            Else
                myRec.SetAddrZipIDFieldValue("")
            End If
            If Not String.IsNullOrEmpty(myMovedIn) Then
                myRec.MovedIn = CDate(myMovedIn)
            Else
                myRec.SetMovedInFieldValue("")
            End If
            myRec.MovedOut = myMovedOut
            If Not String.IsNullOrEmpty(myMovedOutOn) Then
                myRec.MovedOutOn = CDate(myMovedOutOn)
            Else
                myRec.SetMovedOutOnFieldValue("")
            End If
            myRec.Save()
            DbUtils.CommitTransaction()

        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
        Finally
            DbUtils.EndTransaction()
        End Try

    End Sub

    Public Sub s_AddrEdit(ByVal myAddr As String, ByVal myAddr2 As String, ByVal myZipID As String, ByVal myMovedIn As String, _
                            ByVal myMovedOut As Boolean, ByVal myMovedOutOn As String)

        Try
            Dim myAddrID As String = Me.HiddenTB_AddrID.Text
            DbUtils.StartTransaction()
            Dim myRec As New PartyAddrRecord 'Record class for table to update.
            myRec = PartyAddrTable.GetRecord(myAddrID, True)
            myRec.Addr = myAddr
            myRec.Addr2 = myAddr2
            If myZipID <> "0" Then
                myRec.AddrZipID = CInt(myZipID)
            Else
                myRec.SetAddrZipIDFieldValue("")
            End If
            If Not String.IsNullOrEmpty(myMovedIn) Then
                myRec.MovedIn = CDate(myMovedIn)
            Else
                myRec.SetMovedInFieldValue("")
            End If
            myRec.MovedOut = myMovedOut
            If Not String.IsNullOrEmpty(myMovedOutOn) Then
                myRec.MovedOutOn = CDate(myMovedOutOn)
            Else
                myRec.SetMovedOutOnFieldValue("")
            End If
            myRec.Save()
            DbUtils.CommitTransaction()

        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
        Finally
            DbUtils.EndTransaction()
        End Try

    End Sub

    '*************************
    '*************************
    '*************************
    'AddrRWEnd
    '*************************
    '*************************
    '*************************

    '*************************
    '*************************
    '*************************
    'Hist Begin
    '*************************
    '*************************
    '*************************

    Protected Function f_HistValues(ByVal myHistoryID As String) As String

        Dim myW As String = V_HistoryLoadRWView.HistoryID.UniqueName & " = " & myHistoryID
        Dim myR As V_HistoryLoadRWRecord = V_HistoryLoadRWView.GetRecord(myW)
        Dim myReturn As String = Nothing

        Dim StartMonth As String = If(myR.StartMonth.ToShortDateString, "")
        Dim EndMonth As String = If(myR.EndMonth.ToShortDateString, "")
        Dim PositionTypeID As String = If(CStr(myR.PositionTypeID), "")
        Dim CurrentPastID As String = If(CStr(myR.CurrentPastID), "")
        Dim CarrierID As String = If(CStr(myR.CarrierID), "")
        Dim EmployerCompany As String = If(myR.EmployerCompany, "")
        Dim EmployerAddr As String = If(myR.EmployerAddr, "")
        Dim EmployerZipID As String = If(CStr(myR.EmployerZipID), "")
        Dim EmployerCitySTZip As String = If(myR.EmployerCitySTZip, "")
        Dim EmployerCountryID As String = If(CStr(myR.EmployerCountryID), "")
        Dim EmployerCountry As String = If(myR.EmployerCountry, "")
        Dim EmployerEmail As String = If(myR.EmployerEmail, "")
        Dim EmployerPhone As String = If(myR.EmployerPhone, "")
        Dim EmployerFax As String = If(myR.EmployerFax, "")
        Dim EmployerContact As String = If(myR.EmployerContact, "")
        Dim MilesPerWeek As String = If(CStr(myR.MilesPerWeek), "")
        Dim ReasonForLeavingID As String = If(CStr(myR.ReasonForLeavingID), "")
        Dim ReasonForLeaving As String = If(myR.ReasonForLeaving, "")
        Dim ReasonForLeavingNotes As String = If(myR.ReasonForLeavingNotes, "")
        Dim OperatedCommercialMotorVechicle As String = If(myR.OperatedCommercialMotorVechicle.ToString, "")
        Dim HadDrugTestingProgram As String = If(myR.HadDrugTestingProgram.ToString, "")
        Dim Notes As String = If(myR.Notes, "")
        Dim MayWeContact As String = If(myR.MayWeContact.ToString, "")
        Dim FirstJob As String = If(myR.FirstJob.ToString, "")
        Dim ShowFirstJob As String = If(myR.ShowFirstJob.ToString, "")
        Dim Finished As String = If(myR.Finished.ToString, "")

        myReturn = _
            If(StartMonth, "") & "<|>" & _
            If(EndMonth, "") & "<|>" & _
            If(PositionTypeID, "") & "<|>" & _
            If(CurrentPastID, "") & "<|>" & _
            If(CarrierID, "") & "<|>" & _
            If(EmployerCompany, "") & "<|>" & _
            If(EmployerAddr, "") & "<|>" & _
            If(EmployerZipID, "") & "<|>" & _
            If(EmployerCitySTZip, "") & "<|>" & _
            If(EmployerCountryID, "") & "<|>" & _
            If(EmployerCountry, "") & "<|>" & _
            If(EmployerEmail, "") & "<|>" & _
            If(EmployerPhone, "") & "<|>" & _
            If(EmployerFax, "") & "<|>" & _
            If(EmployerContact, "") & "<|>" & _
            If(MilesPerWeek, "") & "<|>" & _
            If(ReasonForLeavingID, "") & "<|>" & _
            If(ReasonForLeaving, "") & "<|>" & _
            If(ReasonForLeavingNotes, "") & "<|>" & _
            If(OperatedCommercialMotorVechicle, "") & "<|>" & _
            If(HadDrugTestingProgram, "") & "<|>" & _
            If(Notes, "") & "<|>" & _
            If(MayWeContact, "") & "<|>" & _
            If(FirstJob, "") & "<|>" & _
            If(ShowFirstJob, "") & "<|>" & _
            If(Finished, "") &
            "<||>"

        Dim myCarrierID As String = CStr(myR.CarrierID)
        If myR.PositionTypeID = 1 And CInt(myCarrierID) > 0 Then

            Dim myCarrierValues As String = f_CarrierValues(myCarrierID)
            myReturn = myReturn & myCarrierValues

        End If

        Return myReturn

    End Function

    Protected Function f_CarrierValues(ByVal myPartyID As String) As String

        Dim myReturn As String = Nothing
        Dim mySproc As String = Nothing

        Dim myR As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_CarrierOneRow", myPartyID)
        Dim myCarrierName As String = myR.Rows(0)(5).ToString()
        Dim myAddr As String = myR.Rows(0)(7).ToString()
        Dim myAddr2 As String = myR.Rows(0)(8).ToString()
        Dim myAddrZipID As String = myR.Rows(0)(12).ToString()
        Dim myCitySTZip As String = myR.Rows(0)(9).ToString()
        Dim myCountryID As String = myR.Rows(0)(10).ToString()
        Dim myCountry As String = myR.Rows(0)(11).ToString()
        Dim myEmail As String = myR.Rows(0)(13).ToString()
        Dim myDirectDial As String = myR.Rows(0)(14).ToString()
        Dim myFax As String = myR.Rows(0)(15).ToString()
        Dim myDOTNumber As String = myR.Rows(0)(3).ToString()
        Dim myMCNumber As String = myR.Rows(0)(4).ToString()
        myMCNumber = Replace(myMCNumber, "-", "")
        mySproc = CustGenClass.f_Sproc("usp_PartyBeingAdmined", myPartyID)

        myReturn = _
            If(myCarrierName, "") & "<|>" & _
            If(myAddr, "") & "<|>" & _
            If(myAddr2, "") & "<|>" & _
            If(myAddrZipID, "") & "<|>" & _
            If(myCitySTZip, "") & "<|>" & _
            If(myCountryID, "") & "<|>" & _
            If(myCountry, "") & "<|>" & _
            If(myEmail, "") & "<|>" & _
            If(myDirectDial, "") & "<|>" & _
            If(myFax, "") & "<|>" & _
            If(myDOTNumber, "") & "<|>" & _
            If(myMCNumber, "") & "<|>" & _
            If(mySproc, "")

        Return myReturn

    End Function

    Protected Sub R1HistoryRLV_ItemCommand(ByVal sender As Object, ByVal e As RadListViewCommandEventArgs) Handles R1HistoryRLV.ItemCommand

        s_RLV_ItemCommands(sender, e)

    End Sub


    Protected Sub R2HistoryRLV_ItemCommand(ByVal sender As Object, ByVal e As RadListViewCommandEventArgs) Handles R2HistoryRLV.ItemCommand


        s_RLV_ItemCommands(sender, e)

    End Sub


    Protected Sub R3HistoryRLV_ItemCommand(ByVal sender As Object, ByVal e As RadListViewCommandEventArgs) Handles R3HistoryRLV.ItemCommand

        s_RLV_ItemCommands(sender, e)

    End Sub

    Protected Sub s_RLV_ItemCommands(ByVal sender As Object, ByVal e As RadListViewCommandEventArgs)

        Dim item As RadListViewDataItem = TryCast(e.ListViewItem, RadListViewDataItem)
        Dim myValue As String = item.GetDataKeyValue("HistoryID").ToString()
        Dim myScript As String = Nothing

        Dim myCommandName As String = e.CommandName

        If myCommandName = "HistOpenTip" Then

            Dim myInfo As String = item.GetDataKeyValue("HistoryToolTipHTML").ToString()
            GeneralRTT.Text = myInfo
            myScript = "showGeneralRTT();"

        ElseIf myCommandName = "HistEdit" Then

            myScript = "openJobRW(" & myValue & ")"

        ElseIf myCommandName = "HistAdd" Then

            Dim myStartDate As Date = CDate(item.GetDataKeyValue("StartDate").ToString())
            Dim myStartDateShort As String = myStartDate.ToShortDateString
            Dim myEndDate As Date = CDate(item.GetDataKeyValue("EndDate").ToString())
            Dim myEndDateShort As String = myEndDate.ToShortDateString
            myScript = "openJobRW_wDates('" & myStartDateShort & "','" & myEndDateShort & "');"

        ElseIf myCommandName = "HistDel" Then

            myScript = "confirmCall('HistDel','" & myValue & "','Delete Job or Unemployment Perod');"

        Else

            myScript = "alert('" & myCommandName & ": " & myValue & "');"

        End If

        RadAjaxManager1.ResponseScripts.Add(myScript)

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


    Protected Sub s_CarrierZipRCB_ItemsRequested(ByVal sender As Object, ByVal e As RadComboBoxItemsRequestedEventArgs) Handles CarrierZipRCB.ItemsRequested

        Try

            Dim data As DataTable = f_ZipCombo_GetData(e.Text)

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

    Public Function f_ZipCombo_GetData(ByVal text As String) As DataTable

        Dim myCountryID As String = CarrierCountryRCB.SelectedValue
        Dim myDataTable As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_PickZip", text, myCountryID)
        Return myDataTable

    End Function


    Public Function f_DateWarnings(ByVal myHistoryID As String, ByVal myCurrentPastID As String, Optional ByVal myStartMonth As String = "Null", _
                                    Optional ByVal myEndMonth As String = "Null", Optional ByVal mySkipReqWarning As String = "Yes") As String

        Dim myPartyID As String = Me.HiddenTB_PartyID.Text

        Dim myReturn As String = "No"

        'Convert strings to dates.
        Dim myStartDate As Date = Nothing
        If Not String.IsNullOrEmpty(myStartMonth) And myStartMonth <> "Null" And myStartMonth <> "no" Then
            myStartDate = CDate(myStartMonth)
        End If

        Dim myEndDate As Date = Nothing
        If Not String.IsNullOrEmpty(myEndMonth) And myEndMonth <> "Null" And myEndMonth <> "no" Then
            myEndDate = CDate(myEndMonth)
        End If

        If String.IsNullOrEmpty(myStartMonth) Then
            myStartMonth = "None"
        End If

        If String.IsNullOrEmpty(myEndMonth) Then
            myEndMonth = "Null"
        End If

        'If StartMonth > EndMonth, stop all and warn.
        Dim myGreaterThenWarn As Boolean = False
        Dim myGreaterThenMessage As String = ""

        'If EndMonth is "Null", stop all and warn.
        Dim mySprocWarn As Boolean = False
        Dim mySprocMessage As String = ""
        Dim myAction As String = "Stop"

        'If Sproc returns and error, stop all and warn, unless a NoStop error.
        Dim myNullWarn As Boolean = False
        Dim myNullMessage As String = ""

        Dim myTabIndex As String = "No"

        If myStartMonth <> "None" And myEndMonth <> "Null" Then

            If myStartDate > myEndDate Then

                myGreaterThenMessage = "You hire/begin date cannot occur <span style=""color: #ff0000;"">AFTER</span> your quit/end date.<br /><br />"
                myGreaterThenWarn = True

            End If

        End If

        If myStartMonth = "Null" And myEndMonth = "Null" Then

            myNullMessage = "The dates cannot be <span style=""color: #ff0000;"">EMPTY</span>.<br /><br />"
            myNullWarn = True

        End If

        If mySkipReqWarning = "No" And (myStartMonth = "None" Or ((myCurrentPastID = "1") And myEndMonth = "Null")) Then

            myTabIndex = "0"
            myNullMessage = "The date range for this time period is required.  Please complete these dates before continuing.<br /><br />"
            myNullWarn = True

        End If

        If myStartMonth <> "None" And (myCurrentPastID = "2" Or myEndMonth <> "Null") Then

            Dim mySproc As String = CustGenClass.f_Sproc("usp_HistoryReorderWarning_v2", myPartyID, myHistoryID, myStartMonth, myEndMonth)
            myAction = CustGenClass.f_Split_ByComma(mySproc, 1)
            mySprocMessage = Replace(CustGenClass.f_Split_ByComma(mySproc, 2), "~", ",")
            If mySprocMessage <> "No Warning" And Not String.IsNullOrEmpty(mySprocMessage) Then
                mySprocWarn = True
            End If

        End If

        If myGreaterThenWarn = True Or myNullWarn = True Or (mySprocWarn = True And (mySkipReqWarning = "Yes" Or (mySkipReqWarning = "No" And myAction = "Stop"))) Then
            Dim myWarning As String = "<span style=""color: #ff0000;""><strong>WARNING:</strong></span> Please correct the following errors: "

            If myGreaterThenWarn = True Then
                myWarning = myWarning & "<br /><br />" & myGreaterThenMessage
            End If

            If myNullWarn = True Then
                myWarning = myWarning & "<br /><br />" & myNullMessage
            End If

            If mySprocWarn = True Then
                myWarning = myWarning & "<br /><br />" & mySprocMessage
            End If

            myTabIndex = "0"
            myAction = myWarning

            myReturn = "Yes"

        End If

        myReturn = myReturn & "<|>" & myTabIndex & "<|>" & myAction

        Return myReturn

    End Function

    Public Function f_MCNumberDups(ByVal myMCNumber As String, ByVal myCarrierID As String) As String


        '**************************************************
        '**************************************************
        'Also in code behind / controls file / addcarrier.aspx / editcarrier.aspx
        '**************************************************
        '**************************************************

        Dim myReturn As String = "No"

        Dim myWarning As String = ""

        If String.IsNullOrEmpty(myMCNumber) = False Then

            Dim myWhere As String = "Replace(Left(" & PartyCarrierTable.MCNumber.UniqueName & ",9),'-','') = REPLACE('" & Left(myMCNumber, 9) & "','-','')" & _
                                            " AND " & PartyCarrierTable.MCNumber.UniqueName & " <> 'MC-'"
            If String.IsNullOrEmpty(myCarrierID) = False Then
                myWhere = myWhere & " AND " & PartyCarrierTable.PartyID.UniqueName & " <> " & myCarrierID
            End If

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

                myWarning = "<span style=""color: Green;""><strong>NOTE:</strong></span> This MC Number is already assigned to: " & myMCMatches & ".  Please be certain that you wish to enter a duplicate MC number."

                myReturn = "Yes"

            End If

        End If

        myReturn = myReturn & "<|>" & myWarning
        Return myReturn
    End Function

    Public Function f_DOTNumberDups(ByVal myDOTNumber As String, ByVal myEmployerID As String) As String
        '**************************************************
        '**************************************************
        'Also in code behind / controls file / addcarrier.aspx / editcarrier.aspx
        '**************************************************
        '**************************************************
        Dim myReturn As String = "No"

        Dim myWarning As String = ""
        If String.IsNullOrEmpty(myDOTNumber) = False Then

            Dim myWhere As String = "Left(" & PartyCarrierTable.DOTNumber.UniqueName & ",9) ='" & Left(myDOTNumber, 9) & "'"
            If String.IsNullOrEmpty(myEmployerID) = False Then
                myWhere = myWhere & " AND " & PartyCarrierTable.PartyID.UniqueName & " <> " & myEmployerID
            End If
            Dim myRec As PartyCarrierRecord = PartyCarrierTable.GetRecord(myWhere)
            If Not IsNothing(myRec) Then
                myWarning = "<span style=""color: #FF0000;""><strong>WARNING:</strong></span> This DOT Number is already assigned to " & CustGenClass.f_GetPartyName(CStr(myRec.PartyID)) & ".  The system does <span style=""color: #ff0000;"">NOT</span> allow duplicate DOT numbers.  Please (1) correct the number or (2) click the ""X"" to find the carrier using this DOT number."
                myReturn = "Yes"
            End If
        End If

        myReturn = myReturn & "<|>" & myWarning
        Return myReturn

    End Function

    Protected Sub s_HistSave(ByVal myCloseJobRW As String)


        Dim myPartyID As String = Me.HiddenTB_PartyID.Text
        Dim myHistoryID As String = Me.HiddenTB_HistoryID.Text

        Dim myPositionTypeID As String = PositionTypeRCB.SelectedValue
        Dim myCurrentPastID As String = CurrentPastRCB.SelectedValue
        Dim myHiredRaw As Date? = HiredRDP.SelectedDate
        Dim myHired As Date = Nothing
        Dim myHiredStr As String = "Null"
        If Not IsNothing(myHiredRaw) Then
            myHired = CDate(myHiredRaw)
            myHiredStr = myHired.ToShortDateString()
        End If
        Dim myQuitRaw As Date? = QuitRDP.SelectedDate
        Dim myQuit As Date = Nothing
        Dim myQuitStr As String = "Null"
        If Not IsNothing(myQuitRaw) Then
            myQuit = CDate(myQuitRaw)
            myQuitStr = myQuit.ToShortDateString()
        End If
        Dim myCarrierID As String = Me.HiddenTB_CarrierID.Text
        Dim myCarrierDataStatus As String = Me.HiddenTB_CarrierDataStatus.Text
        Dim myMC As String = MCNumberRTB.Text
        Dim myDOT As String = DOTNumberRTB.Text
        Dim myCarrierName As String = CarrierNameRTB.Text
        Dim myCarrierAddr As String = CarrierAddrRTB.Text
        Dim myCarrierZipID As String = CarrierZipRCB.SelectedValue
        Dim myCarrierEmail As String = CarrierEmailRTB.Text
        Dim myCarrierPhone As String = CarrierPhoneRTB.Text
        Dim myCarrierFax As String = CarrierFaxRTB.Text
        Dim myEmployerContactInfo As String = ContactRTB.Text
        Dim myMiles As String = MilesRTB.Text
        If String.IsNullOrEmpty(myMiles) Then
            myMiles = "0"
        End If
        Dim myReasonLeft As String = ReasonLeftRCB.SelectedValue
        Dim myReasonLeftNotes As String = ReasonLeftRE.Content
        Dim myCommVech As Boolean = CommVechCB.Checked
        Dim myDrugProgram As Boolean = DrugProgramCB.Checked
        Dim myUnemployedNotes As String = UnemployedNotesRE.Content
        Dim myEmploymentNotes As String = EmploymentNotesRE.Content
        Dim myVerify As Integer = VerifyRB.SelectedToggleStateIndex
        Dim myFirstJob As Integer = FirstJobRB.SelectedToggleStateIndex
        Dim myComplete As Integer = LockRB.SelectedToggleStateIndex

        Dim myDateWarnings As String = f_DateWarnings(myHistoryID, myCurrentPastID, myHiredStr, myQuitStr, "no")
        Dim myScript As String = "None"

        If CustGenClass.f_Split_ByComma(Replace(myDateWarnings, "<|>", ","), 1) = "Yes" Then

            myDateWarnings = Replace(myDateWarnings, "'", "")
            myScript = "w_dates('" & myDateWarnings & "');"

        Else

            If myCarrierDataStatus = "Add" Then

                myCarrierID = f_SaveOrAddNew(myCarrierDataStatus, myCarrierID, myMC, myDOT, myCarrierName, myCarrierAddr, myCarrierZipiD, myCarrierEmail, myCarrierPhone, myCarrierFax)

            End If

            Try

                DbUtils.StartTransaction()
                Dim myRec As New PartyWorkHistoryRecord 'Record class for table to update.

                If myHistoryID <> "0" Then
                    myRec = PartyWorkHistoryTable.GetRecord(myHistoryID, True)
                Else
                    myRec.PartyID = CInt(myPartyID)
                End If

                If myPositionTypeID = "1" Or myPositionTypeID = "2" Then
                    myRec.Employed = True
                Else
                    myRec.Employed = False
                End If

                If myPositionTypeID = "1" Then
                    myRec.DrivingPosition = True
                Else
                    myRec.DrivingPosition = False
                End If

                If myPositionTypeID = "2" Then

                    myRec.EmployerCompany = myCarrierName
                    myRec.EmployerAddr = myCarrierAddr
                    If Not String.IsNullOrEmpty(myCarrierZipID) And myCarrierZipID <> "0" Then
                        myRec.EmployerZipID = CInt(myCarrierZipID)
                    Else
                        myRec.SetEmployerZipIDFieldValue("")
                    End If
                    myRec.EmployerEmail = myCarrierEmail
                    myRec.EmployerPhone = myCarrierPhone
                    myRec.EmployerFax = myCarrierFax
                    myRec.EmployerContact = myEmployerContactInfo
                    myRec.SetEmployerIDFieldValue("")

                End If

                If Not String.IsNullOrEmpty(myCarrierID) And myCarrierID <> "0" Then
                    myRec.EmployerID = CInt(myCarrierID)
                Else
                    myRec.SetEmployerIDFieldValue("")
                End If

                myRec.MilesPerWeek = CInt(myMiles)

                If myReasonLeft <> "0" Then
                    myRec.ReasonForLeavingID = CInt(myReasonLeft)
                Else
                    myRec.SetReasonForLeavingIDFieldValue("")
                End If

                If Not String.IsNullOrEmpty(myReasonLeft) And myReasonLeft <> "0" Then
                    myRec.ReasonForLeavingNotes = myReasonLeftNotes
                Else
                    myRec.ReasonForLeavingNotes = Nothing
                End If

                myRec.OperatedCommercialMotorVechicle = myCommVech
                myRec.HadDrugTestingProgram = myDrugProgram

                If myPositionTypeID <> "3" Then
                    myRec.Notes = myEmploymentNotes
                Else
                    myRec.Notes = myUnemployedNotes
                End If

                myRec.MayWeContact = CBool(myVerify)
                myRec.FirstJob = CBool(myFirstJob)
                myRec.Finished = CBool(myComplete)

                If myHistoryID = "0" Then
                    myRec.Save()
                    DbUtils.CommitTransaction()
                Else
                    DbUtils.CommitTransaction()
                    myRec.Save()
                End If

                Dim myNewHistoryID As String = CStr(myRec.HistoryID)
                System.Web.HttpContext.Current.Session("NewHistoryID") = myNewHistoryID

            Catch ex As Exception

                DbUtils.RollBackTransaction()
                Dim myMessage As String = "<span style=""color: #ff0000;"">WARNING:</span> The system was unable to save your changes to this job or unemployment period.  If the problem continues, please contact support.  The technical details are as follows: " & ex.Message
                myMessage = Replace(myMessage, "'", "")
                myScript = "launchRadAlert('" & myMessage & "', 'Failed to Save Changes');"
                RadAjaxManager1.ResponseScripts.Add(myScript)

            Finally
                DbUtils.EndTransaction()
                myScript = "closeJobRW();"

            End Try

            If myScript = "closeJobRW();" Then

                Dim myHistoryID_Return As String = CType(HttpContext.Current.Session("NewHistoryID"), String)
                HttpContext.Current.Session.Remove("NewHistoryID")

                If String.IsNullOrEmpty(myQuitStr) Or myCurrentPastID = "2" Then
                    myQuitStr = "Null"
                End If

                If myHistoryID = "0" Then
                    myHistoryID = myHistoryID_Return
                End If

                Dim mySproc As String = CustGenClass.f_Sproc("usp_HistoryReorderDates", myHistoryID, myHiredStr, myQuitStr, "Yes")

                Dim myYears As Decimal = CDec(CustGenClass.f_Sproc("usp_HistorySlider", myPartyID))
                YearsRadSlider.Value = myYears
                YearsRadSlider.DataBind()

                s_HistWarning()

                R1HistoryRLV.DataBind()
                R2HistoryRLV.DataBind()
                R3HistoryRLV.DataBind()

                ExpRG.Rebind()

            End If

        End If

        If myScript <> "None" Then
            If myCloseJobRW = "No" Or (myScript <> "closeJobRW();" And myCloseJobRW = "Yes") Then
                RadAjaxManager1.ResponseScripts.Add(myScript)
            End If

        End If

    End Sub

    Protected Sub s_HistSaveRB_Click() Handles HistSaveRB.Click

        s_HistSave("No")

    End Sub

    Public Function f_SaveOrAddNew(ByVal myEditOrAdd As String, ByVal myEmployeerID As String, ByVal myMCNumber As String, _
                                ByVal myDOTNumber As String, ByVal myCarrierName As String, myAddr As String, _
                                ByVal myZipID As String, ByVal myEmail As String, ByVal myPhone As String, ByVal myFax As String) As String

        Dim myReturnID As String = "Edit"

        If myMCNumber = "" Then
            myMCNumber = Nothing
        End If

        If myDOTNumber = "" Then
            myDOTNumber = Nothing
        End If

        If myCarrierName = "" Then
            myCarrierName = Nothing
        End If

        If myAddr = "" Then
            myAddr = Nothing
        End If

        If myZipID = "" Then
            myZipID = Nothing
        End If

        If myPhone = "" Then
            myPhone = Nothing
        End If

        If myEmail = "" Then
            myEmail = Nothing
        End If

        If myFax = "" Then
            myFax = Nothing
        End If

        If myEditOrAdd = "Edit" Then
            s_SaveToParty(myEmployeerID, myCarrierName, myEmail, myPhone, myFax)
            s_SaveToPartyCarrier(myEmployeerID, myMCNumber, myDOTNumber)

            Dim myW As String = V_CarrierOneRowView.PartyID.UniqueName & " = " & myEmployeerID
            Dim myR As V_CarrierOneRowRecord = V_CarrierOneRowView.GetRecord(myW)
            Dim myLat As String = Me.HiddenTB_CarrierLat.Text
            Dim myLong As String = Me.HiddenTB_CarrierLong.Text
            Dim myAddrID As String = CStr(myR.AddrID)

            If myAddrID <> "0" Then
                s_SaveToPartyAddr(myAddrID, myAddr, myZipID, myLat, myLong)
            Else
                If String.IsNullOrEmpty(myAddr) = False And String.IsNullOrEmpty(myZipID) = False Then
                    s_SaveAddr(myEmployeerID, myAddr, myZipID, myLat, myLong, myEmail, myPhone, myFax)
                End If
            End If

        ElseIf myEditOrAdd = "Add" Then

            myReturnID = f_Save(myCarrierName, myAddr, myZipID, myEmail, myPhone, myFax, myMCNumber, myDOTNumber)

        End If

        Return myReturnID

    End Function
    Public Sub s_SaveToParty(ByVal myPartyID As String, ByVal myCarrierName As String, ByVal myEmail As String, ByVal myPhone As String, ByVal myFax As String)

        If String.IsNullOrEmpty(myCarrierName) = False Then
            myCarrierName = CustGenClass.f_Sproc("usp_PartyFix", myCarrierName)
        End If

        Try
            DbUtils.StartTransaction()
            Dim myRec As New PartyRecord 'Record class for table to update.
            myRec = PartyTable.GetRecord(myPartyID, True)
            myRec.Name = myCarrierName
            myRec.Email = myEmail
            myRec.DirectDial = myPhone
            myRec.Fax = myFax
            DbUtils.CommitTransaction()
            myRec.Save()

        Catch ex As Exception

            DbUtils.RollBackTransaction()
            'Alert

        Finally
            DbUtils.EndTransaction()
        End Try

    End Sub

    Public Sub s_SaveToPartyCarrier(ByVal myPartyID As String, ByVal myMCNumber As String, ByVal myDOTNumber As String)

        Dim myWhere As String = PartyCarrierTable.PartyID.UniqueName & " = " & myPartyID
        Dim myCarrierRec As PartyCarrierRecord = PartyCarrierTable.GetRecord(myWhere)
        Dim myCarrierID As String = CStr(myCarrierRec.CarrierID)

        Try
            DbUtils.StartTransaction()
            Dim myRec As New PartyCarrierRecord 'Record class for table to update.
            myRec = PartyCarrierTable.GetRecord(myCarrierID, True)
            myRec.MCNumber = myMCNumber
            myRec.DOTNumber = myDOTNumber
            DbUtils.CommitTransaction()
            myRec.Save()

        Catch ex As Exception

            DbUtils.RollBackTransaction()
            'Alert

        Finally
            DbUtils.EndTransaction()
        End Try

    End Sub

    Public Function f_Save(ByVal myName As String, ByVal myAddr As String, ByVal myZipID As String, _
                        ByVal myEmail As String, ByVal myPhone As String, ByVal myFax As String, _
                            ByVal myMCNumber As String, ByVal myDOTNumber As String) As String

        Dim myLat As String = "0"
        Dim myLong As String = "0"

        If Not String.IsNullOrEmpty(myName) Then
            myName = CustGenClass.f_Sproc("usp_PartyFix", myName)
        End If
        If Not String.IsNullOrEmpty(myAddr) Then
            myAddr = CustGenClass.f_Sproc("usp_AddrFix", myAddr)
        End If

        If String.IsNullOrEmpty(myAddr) = False And String.IsNullOrEmpty(myZipID) = False Then

            'Get GeoCords
            myLat = Me.HiddenTB_CarrierLat.Text
            myLong = Me.HiddenTB_CarrierLong.Text

        End If

        Dim myEmployeerID As String = f_SaveParty(myName, myAddr, myLat, myLong, myEmail, myPhone, myFax, myMCNumber, myDOTNumber, myZipID)
        Return myEmployeerID

    End Function
    Public Function f_SaveParty(ByVal myName As String, ByVal myAddr As String, ByVal myLat As String, ByVal myLong As String, _
                            ByVal myEmail As String, ByVal myPhone As String, ByVal myFax As String, _
                            ByVal myMCNumber As String, ByVal myDOTNumber As String, ByVal myZipID As String) As String


        Dim myUserID As String = CType(Me.Page, FASTPORT.UI.BaseApplicationPage).SystemUtils.GetUserID()

        Dim myID As String = CustGenClass.f_Sproc("usp_PartyAdd", myUserID, "5", myName)
        Dim myCarrierID As String = CustGenClass.f_Sproc("usp_CarrierAddUpdate", myID, myMCNumber, myDOTNumber)
        Dim mySproc As String = CustGenClass.f_Sproc("usp_RoleAdd", myID, "14", myUserID)

        Dim myValidEmail As Boolean = FASTPORT.UI.BaseApplicationPage.f_EmailIsValid(myEmail)

        Try
            DbUtils.StartTransaction()
            Dim myRec As New PartyRecord 'Record class for table to update.
            myRec = PartyTable.GetRecord(myID, True)

            If myValidEmail = True Then
                myRec.Email = myEmail
            End If
            myRec.DirectDial = myPhone
            myRec.Fax = myFax

            DbUtils.CommitTransaction()
            myRec.Save()

            Dim myNewEmployerID As String = CStr(myRec.PartyID)
            System.Web.HttpContext.Current.Session("NewEmployerID") = myNewEmployerID

        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)

        Finally
            DbUtils.EndTransaction()
        End Try

        s_SaveAddr(myID, myAddr, myZipID, myLat, myLong, myEmail, myPhone, myFax)


        If String.IsNullOrEmpty(myEmail) = False And myValidEmail = True Then

            's_SendEmail(myID, myUserID, myEmail)

        End If

        Dim myGetEmployerID As String = CType(HttpContext.Current.Session("NewEmployerID"), String)
        HttpContext.Current.Session.Remove("NewEmployerID")
        Me.HiddenTB_CarrierID.Text = myGetEmployerID

        Return myGetEmployerID

    End Function

    Public Sub s_SaveAddr(ByVal myPartyID As String, ByVal myAddr As String, ByVal myZipID As String, _
                            ByVal myLat As String, ByVal myLong As String, _
                            ByVal myEmail As String, ByVal myPhone As String, ByVal myFax As String)


        If Not String.IsNullOrEmpty(myAddr) Then
            myAddr = CustGenClass.f_Sproc("usp_AddrFix", myAddr)
        End If

        Try
            ' Enclose all database retrieval/update code within a Transaction boundary

            DbUtils.StartTransaction()
            Dim myRec As New PartyAddrRecord

            myRec.PartyID = CInt(myPartyID)
            myRec.Addr = myAddr
            myRec.AddrZipID = CInt(myZipID)
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


    Public Sub s_SaveToPartyAddr(ByVal myAddrID As String, ByVal myAddr As String, ByVal myZipID As String, ByVal myLat As String, ByVal myLong As String)

        If Not String.IsNullOrEmpty(myAddr) Then
            myAddr = CustGenClass.f_Sproc("usp_AddrFix", myAddr)
        End If

        Try
            DbUtils.StartTransaction()
            Dim myRec As New PartyAddrRecord 'Record class for table to update.
            myRec = PartyAddrTable.GetRecord(myAddrID, True)

            myRec.Addr = myAddr
            myRec.AddrZipID = CInt(myZipID)
            myRec.Lat = CDbl(myLat)
            myRec.Long0 = CDbl(myLong)

            DbUtils.CommitTransaction()
            myRec.Save()

        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)

        Finally
            DbUtils.EndTransaction()
        End Try

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

            f_SaveOrAddNew(myCarrierDataStatus, myCarrierID, myMC, myDOT, myCarrierName, myCarrierAddr, myCarrierZipID, myCarrierEmail, myCarrierPhone, myCarrierFax)

        End If

    End Sub


    Public Sub s_HistWarning()

        Dim myPartyID As String = Me.HiddenTB_PartyID.Text

        Dim mySproc As String = CustGenClass.f_Sproc("usp_HistToDo_Warning", myPartyID)

        If mySproc <> "No Warning" Then

            Me.HistWarningLtl.Text = mySproc

        Else

            Me.HistWarningLtl.Text = "abc"

        End If

    End Sub

    Public Sub s_HistoryYearsSliderSet(ByVal myPartyID As String)

        Dim myYears As String = CustGenClass.f_Sproc("usp_HistorySlider", myPartyID)
        YearsRadSlider.Value = CDec(myYears)

    End Sub

    '*************************
    '*************************
    '*************************
    'Hist End
    '*************************
    '*************************
    '*************************


    '*************************
    '*************************
    '*************************
    'Exp Begin
    '*************************
    '*************************
    '*************************


    Public Sub s_UpdateLock(ByVal myPartyExperienceID As String, ByVal myCheckboxValue As String)

        Dim myCheckboxBool As Boolean

        If myCheckboxValue = "true" Then
            myCheckboxBool = True
        Else
            myCheckboxBool = False
        End If


        Try
            DbUtils.StartTransaction()
            Dim myRec As New PartyExperienceRecord 'Record class for table to update.
            myRec = PartyExperienceTable.GetRecord(myPartyExperienceID, True)
            myRec.LockFocus = myCheckboxBool
            DbUtils.CommitTransaction()
            myRec.Save()

        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)

        Finally
            DbUtils.EndTransaction()

        End Try

    End Sub

    Dim myExpRG_Bound As Boolean = False

    Public Sub ExpRG_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles ExpRG.ItemDataBound

        If TypeOf e.Item Is GridDataItem Then

            Dim dataItem As GridDataItem = CType(e.Item, GridDataItem)
            Dim myHistoryID As String = dataItem.GetDataKeyValue("HistoryID").ToString

            Dim myGenExpRG As RadGrid = CType(dataItem("GenExpTemplateCol").Controls(1), RadGrid)
            s_ExpDSSet(myGenExpRG, myHistoryID, "743")

            Dim myEquipExpRG As RadGrid = CType(dataItem("EquipExpTemplateCol").Controls(1), RadGrid)
            s_ExpDSSet(myEquipExpRG, myHistoryID, "389")

            Dim myCargoExpRG As RadGrid = CType(dataItem("CargoExpTemplateCol").Controls(1), RadGrid)
            s_ExpDSSet(myCargoExpRG, myHistoryID, "666")

            Dim myRegionsExpRG As RadGrid = CType(dataItem("RegionsExpTemplateCol").Controls(1), RadGrid)
            s_ExpDSSet(myRegionsExpRG, myHistoryID, "741")

        End If

    End Sub

    Public Sub s_ExpDSSet(ByVal myRG As RadGrid, ByVal myHistoryID As String, ByVal myExperienceID As String)

        myRG.DataSource = Nothing
        Dim ConnString As String = ConfigurationManager.ConnectionStrings("DatabaseFASTPORT1").ConnectionString
        Dim conn As SqlConnection = New SqlConnection(ConnString)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter
        Dim mySQL As String = "SELECT * FROM dbo.v_PartyExperience WHERE HistoryID = " & myHistoryID & " AND ExperienceParentID = " & myExperienceID
        adapter.SelectCommand = New SqlCommand(mySQL, conn)
        Dim myDataTable As New DataTable
        conn.Open()
        Try
            adapter.Fill(myDataTable)
        Finally
            conn.Close()
        End Try
        myRG.DataSource = myDataTable
        myRG.DataBind()

    End Sub
    Protected Sub ExpRG_ItemCommand(ByVal source As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles ExpRG.ItemCommand

        Dim myCommandName As String = e.CommandName
        Dim myRB As RadButton = CType(e.CommandSource, RadButton)
        Dim myRBID As String = myRB.UniqueID
        Dim myExperienceID As String = Nothing

        If myCommandName = "Exp_GenRB" Then
            myExperienceID = "743"
        ElseIf myCommandName = "Exp_EquipRB" Then
            myExperienceID = "389"
        ElseIf myCommandName = "Exp_CargoRB" Then
            myExperienceID = "666"
        ElseIf myCommandName = "Exp_RegionsRB" Then
            myExperienceID = "741"
        End If

        Me.HiddenTB_ExperienceID.Text = myExperienceID
        ExpRTT_RG.Rebind()
        ExpRTT.TargetControlID = myRBID
        ExpRTT.Show()

    End Sub

    Protected Sub NodeDataBound(ByVal sender As Object, ByVal e As RadTreeNodeEventArgs)

        Dim myFolderOnly As String = (TryCast(e.Node.DataItem, DataRowView))("FolderOnly").ToString()

        If myFolderOnly = "True" Then
            e.Node.AllowDrag = False
        Else
            e.Node.AllowDrag = True
        End If

    End Sub

    Protected Sub ExpRTV_HandleDrop(ByVal sender As Object, ByVal e As RadTreeNodeDragDropEventArgs)

        Dim myReturnMessage As String = "Success"
        Dim myMessage As String = ""
        Dim myHtmlElementID As String = e.HtmlElementID


        If myHtmlElementID = ExpRG.ClientID Or Left(myHtmlElementID, 9) = "ItemImage" Or Left(myHtmlElementID, 5) = "ExpRG" Then

            Dim myHistoryID As String = Me.HiddenTB_HistoryHoverID.Text

            For Each node As RadTreeNode In e.DraggedNodes

                myReturnMessage = f_ExpAdd(myHistoryID, node)

                If myReturnMessage <> "Success" Then
                    myMessage = FASTPORT.UI.BaseApplicationPage.f_Warning(myMessage, myReturnMessage)
                End If

            Next

        ElseIf e.HtmlElementID = DropExpImg.ClientID Then

            Dim myPartyID As String = Me.HiddenTB_PartyID.Text
            Dim myExpID As String = Nothing

            For Each node As RadTreeNode In e.DraggedNodes

                myExpID = node.Value
                myReturnMessage = CustGenClass.f_Sproc("usp_ExpAdd_ToAll", myPartyID, myExpID)

                If myReturnMessage <> "Success" And Not String.IsNullOrEmpty(myReturnMessage) Then
                    myMessage = FASTPORT.UI.BaseApplicationPage.f_Warning(myMessage, myReturnMessage)
                End If

            Next

        End If

        If String.IsNullOrEmpty(myMessage) = False And myMessage <> "No Warning" Then
            myMessage = Replace(myMessage, "'", "")
            Dim myScript As String = "launchRadAlert('" & myMessage & "', 'Failed to Save Changes');"

            ExpRG.DataBind()
            RadAjaxManager1.ResponseScripts.Add(myScript)
        Else
            s_ExpLock()
            ExpRG.DataBind()
        End If

    End Sub

    Private Function f_ExpAdd(ByVal myHistoryID As String, ByVal node As RadTreeNode) As String

        Dim myTreeID As String = node.Value
        'Dim myTreeParentID As String = node.ParentNode.Value

        Dim myWhere As String = TreeTable.TreeID.UniqueName + " = " + myTreeID
        Dim myRec As TreeRecord = TreeTable.GetRecord(myWhere)
        Dim myFolderOnly As Boolean = myRec.FolderOnly
        Dim myReturnMessage As String = "No"

        If myFolderOnly = False Then

            Dim mySproc As String = CustGenClass.f_Sproc("usp_ExpAdd", "History", myHistoryID, myTreeID)
            Dim mySprocReturn As String = CustGenClass.f_Split_ByComma(mySproc, 1)

            If mySprocReturn = "1" Then

                myReturnMessage = "Success"

            ElseIf mySprocReturn = "Duplicate" Then

                myReturnMessage = "You attempted to drag a duplicate item.  This item has been skipped."

            Else

                myReturnMessage = "The system was unable to add an item.  If the problem continues, please contact support."

            End If

        Else

            myReturnMessage = "You attempted to drag a general category.  Please pick a more specific item."

        End If

        Return myReturnMessage

    End Function

    Protected Sub ExpRSB_Search(sender As Object, e As SearchBoxEventArgs)

        Dim myNodeID As String = e.Value

        'If not null, get best match.
        If String.IsNullOrEmpty(myNodeID) Then
            Dim myNodeText As String = e.Text
            If String.IsNullOrEmpty(myNodeText) = False Then
                Dim mySproc As String = CustGenClass.f_Sproc("usp_TRU_ExpRTV_BestMatch", myNodeText)
                If mySproc <> "0" Then
                    myNodeID = CustGenClass.f_Split_ByComma(mySproc, 1)
                    myNodeText = Replace(CustGenClass.f_Split_ByComma(mySproc, 2), "<|>", "")
                    ExpRSB.Text = myNodeText
                End If
            End If
        End If

        'Set RSB to best match, value and text.
        s_SearchTree(ExpRTV, myNodeID)

    End Sub

    Public Sub s_SearchTree(ByVal myRTV As RadTreeView, ByVal myNodeID As String)

        ' collapse any open nodes
        myRTV.CollapseAllNodes()

        ' find the node in the tree view
        Dim node As RadTreeNode = myRTV.FindNodeByValue(myNodeID)
        If Not node Is Nothing Then
            ' select the node
            node.Selected = True
            ' traverse the hierarchy upwards, expanding parent nodes
            Dim parentNode As RadTreeNode = node.ParentNode
            While Not parentNode Is Nothing
                parentNode.Expanded = True
                parentNode = parentNode.ParentNode
            End While
            ' if this is not a leaf node, expand all child nodes

        End If

    End Sub

    Protected Sub ExpRTT_RG_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs)

        If TypeOf e.Item Is GridDataItem Then

            Dim dataItem As GridDataItem = CType(e.Item, GridDataItem)
            Dim mySlider As RadSlider = CType(dataItem("ExpRTT_RS_TemplateColumn").Controls(1), RadSlider)
            Dim myNoSlideLiteral As LiteralControl = CType(dataItem("ExpRTT_RS_TemplateColumn").Controls(2), LiteralControl)
            Dim myExpRTT_LockRB As RadButton = CType(dataItem("LockSlider_TemplateColumn").Controls(1), RadButton)
            Dim myNoSlide As Boolean = CBool(dataItem.GetDataKeyValue("NoSlide").ToString)
            Dim myExperienceNotesRB As RadButton = CType(dataItem("ExperienceNotes_TemplateColumn").Controls(1), RadButton)
            Dim myExpRTT_ExpDelIB As ImageButton = CType(dataItem("ExpRTT_ExpDelIB_TemplateColumn").Controls(1), ImageButton)

            If myNoSlide = False Then

                mySlider.Visible = True
                Dim myFocusedOn As Decimal = CDec(dataItem.GetDataKeyValue("FocusedOn").ToString)
                mySlider.Value = CDec(myFocusedOn)

                Dim myLockFocus As Boolean = CBool(dataItem.GetDataKeyValue("LockFocus").ToString)
                If myLockFocus = False Then
                    myExpRTT_LockRB.SelectedToggleStateIndex = 0
                    myExperienceNotesRB.Visible = True
                    mySlider.Enabled = True
                    myExpRTT_ExpDelIB.Visible = True
                Else
                    myExpRTT_LockRB.SelectedToggleStateIndex = 1
                    myExperienceNotesRB.Visible = False
                    mySlider.Enabled = False
                    myExpRTT_ExpDelIB.Visible = False
                End If

                myExpRTT_LockRB.Visible = True
                myNoSlideLiteral.Text = Nothing

            Else

                mySlider.Visible = False
                myExpRTT_LockRB.Visible = False
                myNoSlideLiteral.Text = "% Not Required"

            End If

            Dim ExpRTT_DelIB As ImageButton = DirectCast(dataItem("ExpRTT_ExpDelIB_TemplateColumn").FindControl("ExpRTT_ExpDelIB"), ImageButton)
            ExpRTT_DelIB.Attributes.Add("onclick", "onExpRTT_DelIBClick('" + CStr(dataItem.ItemIndex) + "');")

        End If

    End Sub


    Public Sub ExpLockRB_Click() Handles ExpLockRB.Click

        Dim myPartyID As String = Me.HiddenTB_PartyID.Text
        Dim myExpLockOrNot As String = ExpLockRB.SelectedToggleStateIndex.ToString

        If myExpLockOrNot = "1" Then
            myExpLockOrNot = "Lock"
        Else
            myExpLockOrNot = "Not"
        End If

        CustGenClass.f_Sproc("usp_ExpLock", myPartyID, myExpLockOrNot)
        ExpRG.Rebind()

    End Sub
    Public Sub s_ExpLock()

        Dim myPartyID As String = Me.HiddenTB_PartyID.Text
        Dim myUnlocked As String = CustGenClass.f_Sproc("usp_ExpUnLockedCount", myPartyID)

        If myUnlocked = "0" Then
            ExpLockRB.SelectedToggleStateIndex = 1
        Else
            ExpLockRB.SelectedToggleStateIndex = 0
        End If

    End Sub


    Public Function f_UpdateExperienceNotes(ByVal myPartyExperienceID As String, ByVal myExperienceNotes As String) As String

        Dim myWarning As String = "Nothing"

        Try

            DbUtils.StartTransaction()
            Dim myRec As New PartyExperienceRecord 'Record class for table to update.
            myRec = PartyExperienceTable.GetRecord(myPartyExperienceID, True)
            myRec.ExperienceNotes = myExperienceNotes
            DbUtils.CommitTransaction()
            myRec.Save()

        Catch ex As Exception

            DbUtils.RollBackTransaction()
            myWarning = "<span style='color: #FF0000;'><strong>WARNING:</span></strong> The system failed to add notes to this experience time.  If the problem continues, please contact support.  The technical error details are: " & ex.Message

        Finally

            DbUtils.EndTransaction()

        End Try

        Return myWarning

    End Function

    Public Function f_ExperienceNotesGet(ByVal myPartyExperienceID As String) As String

        Dim myW As String = PartyExperienceTable.PartyExperienceID.UniqueName & " = " & myPartyExperienceID
        Dim myR As PartyExperienceRecord = PartyExperienceTable.GetRecord(myW)
        Dim myExperienceNotes As String = myR.ExperienceNotes

        Return myExperienceNotes

    End Function

    '*************************
    '*************************
    '*************************
    'Exp End
    '*************************
    '*************************
    '*************************

    Protected Sub IncidentsRTV_HandleDrop(ByVal sender As Object, ByVal e As RadTreeNodeDragDropEventArgs)

        Dim myPartyID As String = Me.HiddenTB_PartyID.Text
        Dim myMessage As String = Nothing

        For Each node As RadTreeNode In e.DraggedNodes

            Dim myReturnMessage As String = f_AddToIncidents(myPartyID, node)

            If myReturnMessage <> "Success" Then
                myMessage = BaseApplicationPage.f_Warning(myMessage, myReturnMessage)
            End If

        Next

        If String.IsNullOrEmpty(myMessage) = False Then
            AccidentsRadGrid.Rebind()
            IncidentsRadGrid.Rebind()
            HonorsAwardsRadGrid.Rebind()
            RadAjaxManager1.ResponseScripts.Add("launchRadAlert('" & myMessage & "','Failed to Add Accident/Event/Honor');")
        Else
            s_IncidentLock()
            AccidentsRadGrid.Rebind()
            IncidentsRadGrid.Rebind()
            HonorsAwardsRadGrid.Rebind()
        End If

    End Sub

    Protected Function f_AddToIncidents(ByVal myPartyID As String, ByVal myNode As RadTreeNode) As String

        Dim myNodeID As String = myNode.Value
        Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()
        Dim myReturn As String = "Success"

        Dim myParentWhere As String = TreeTable.TreeID.UniqueName & " = " & myNodeID
        Dim myParentRec As TreeRecord = TreeTable.GetRecord(myParentWhere)

        Dim myParentID As String = CStr(myParentRec.TreeParentID)

        Try
            DbUtils.StartTransaction()
            Dim myRec As New PartyIncidentRecord
            myRec.PartyID = CInt(myPartyID)
            myRec.IncidentCategoryID = CInt(myNodeID)

            If myNodeID = "2017" Then
                myRec.FatalitiesOccured = True
            End If

            If myNodeID = "2018" Then
                myRec.InjuriesOccured = True
            End If

            If myNodeID = "2128" Then
                myRec.TowAWayAccident = True
            End If

            If myNodeID = "2129" Then
                myRec.Ticketed = True
            End If

            If myParentID = "2130" Then
                myRec.LicenseSuspended = True
            End If

            If myNodeID = "2008" Then
                myRec.FelonyIssued = True
            End If

            myRec.Save()
            DbUtils.CommitTransaction()

        Catch ex As Exception
            ' Upon error, rollback the transaction
            DbUtils.RollBackTransaction()
            ' Report the error message to the end user
            myReturn = ex.Message
        Finally
            DbUtils.EndTransaction()
        End Try

        Return myReturn

    End Function


    Public Sub AccidentsRadGrid_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles AccidentsRadGrid.ItemDataBound

        If TypeOf e.Item Is GridDataItem Then

            Dim dataItem As GridDataItem = CType(e.Item, GridDataItem)
            s_Incidents_SetLocks(dataItem, "accidents")

        End If

    End Sub


    Public Sub IncidentsRadGrid_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles IncidentsRadGrid.ItemDataBound

        If TypeOf e.Item Is GridDataItem Then

            Dim dataItem As GridDataItem = CType(e.Item, GridDataItem)
            s_Incidents_SetLocks(dataItem, "incidents")

        End If

    End Sub


    Public Sub HonorsAwardsRadGrid_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles HonorsAwardsRadGrid.ItemDataBound

        If TypeOf e.Item Is GridDataItem Then

            Dim dataItem As GridDataItem = CType(e.Item, GridDataItem)
            s_Incidents_SetLocks(dataItem, "honorsawards")

        End If

    End Sub


    Public Sub s_Incidents_SetLocks(ByVal dataItem As GridDataItem, ByVal gridName As String)

        Dim myLockIncident As Boolean = CBool(dataItem.GetDataKeyValue("LockIncident").ToString)
        Dim myLockIncidentRB As RadButton = CType(dataItem("LockDel_TemplateColumn").Controls(1), RadButton)

        If myLockIncident = False Then
            myLockIncidentRB.SelectedToggleStateIndex = 0
        Else
            myLockIncidentRB.SelectedToggleStateIndex = 1
        End If

        Dim IncidentsDelIB As ImageButton = DirectCast(dataItem("LockDel_TemplateColumn").FindControl("IncidentsDelIB"), ImageButton)
        IncidentsDelIB.Attributes.Add("onclick", "onIncidentsDelIBClick('" + CStr(dataItem.ItemIndex) + "','" + gridName + "');")

    End Sub

    Public Sub IncidentLockRB_Click() Handles IncidentLockRB.Click

        Dim myPartyID As String = Me.HiddenTB_PartyID.Text
        Dim myIncidentLockOrNot As String = IncidentLockRB.SelectedToggleStateIndex.ToString

        If myIncidentLockOrNot = "1" Then
            myIncidentLockOrNot = "Lock"
        Else
            myIncidentLockOrNot = "Not"
        End If

        CustGenClass.f_Sproc("usp_IncidentLockAll", myPartyID, myIncidentLockOrNot)
        AccidentsRadGrid.Rebind()
        IncidentsRadGrid.Rebind()
        HonorsAwardsRadGrid.Rebind()

    End Sub

    Public Sub s_IncidentLock()

        Dim myPartyID As String = Me.HiddenTB_PartyID.Text
        Dim myUnlocked As String = CustGenClass.f_Sproc("usp_IncidentUnLockedCount", myPartyID)

        If myUnlocked = "0" Then
            IncidentLockRB.SelectedToggleStateIndex = 1
        Else
            IncidentLockRB.SelectedToggleStateIndex = 0
        End If

    End Sub

    Public Function f_IncidentEditURL(ByVal my1st As String, ByVal my2nd As String) As String

        Dim myIncidentCategoryID As String = my2nd

        Dim myIncWhere As String = TreeTable.TreeID.UniqueName & " = " & myIncidentCategoryID
        Dim myIncRec As TreeRecord = TreeTable.GetRecord(myIncWhere)
        Dim myParentID As String = CStr(myIncRec.TreeParentID)
        Dim myCheckboxParentID As String = ""

        If myParentID = "823" Or myParentID = "824" Then
            myCheckboxParentID = "2021"
        ElseIf myParentID = "2123" Then
            myCheckboxParentID = "2140"
        ElseIf myIncidentCategoryID = "830" Or myIncidentCategoryID = "2126" Then
            myCheckboxParentID = "2141"
        ElseIf myParentID = "826" Then
            myCheckboxParentID = "2142"
        Else
            myCheckboxParentID = "0"
        End If

        Dim myReturn As String = "../Driver/EditIncident.aspx?PartyIncident=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(my1st, String)) & "&CheckboxParent=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myCheckboxParentID, String))

        Return myReturn

    End Function


    '*************************
    '*************************
    '*************************
    'Incidents End
    '*************************
    '*************************
    '*************************

    '*************************
    '*************************
    '*************************
    'PageStart
    '*************************
    '*************************
    '*************************

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
            AddrRadSlider.DataBind()
            AddrRadGrid.Rebind()
        ElseIf myAction = "rebindPrefRG" Then
            PrefRG.Rebind()
        ElseIf myAction = "rebindPrefs" Then
            s_Pref_Load()
        ElseIf myAction = "rebindPickCarrierRG" Then
            PickCarrierRG.Rebind()
        ElseIf myAction = "rebindHist" Then
            R1HistoryRLV.DataBind()
            R2HistoryRLV.DataBind()
            R3HistoryRLV.DataBind()
            s_HistWarning()
            s_HistoryYearsSliderSet(myPartyID)
            ExpRG.Rebind()
        ElseIf myAction = "rebindExpRG" Then
            ExpRG.Rebind()
            ExpRTT.TargetControlID = ""
        ElseIf myAction = "rebindExpRTT_RG" Then
            ExpRTT_RG.Rebind()
        ElseIf myAction = "rebindIncidents" Then
            AccidentsRadGrid.Rebind()
            IncidentsRadGrid.Rebind()
            HonorsAwardsRadGrid.Rebind()
        ElseIf myAction = "updateSlider" Then
            CustGenClass.f_Sproc("usp_Sliders", my1st, my2nd)
            ExpRTT_RG.Rebind()
        ElseIf myAction = "deleteExpItem" Then
            mySproc = CustGenClass.f_Sproc("usp_ExpDelete", my1st)
            If mySproc <> "1" Then
                myWarning = "<span style='color: #FF0000;>WARNING: </span> the system was unable to delete this experience item.  If he problem continues, please contact support."
                myWarningTitle = "Failed to Delete"
            End If
            ExpRTT_RG.Rebind()
        ElseIf myAction = "updateLock" Then
            s_UpdateLock(my1st, my2nd)
            ExpRTT_RG.Rebind()
            s_ExpLock()
        ElseIf myAction = "deletePrefItem" Then
            mySproc = CustGenClass.f_Sproc("usp_PrefDelete", my1st)
            If mySproc <> "1" Then
                myWarning = "<span style='color: #FF0000;>WARNING: </span> the system was unable to delete this experience item.  If he problem continues, please contact support."
                myWarningTitle = "Failed to Delete"
            End If
            PrefRG.Rebind()
            Pref_GeneralRAC.DataBind()
            Pref_EquipRAC.DataBind()
            Pref_CommodityRAC.DataBind()
            Pref_RegionsRAC.DataBind()
            Pref_OtherRAC.DataBind()
        ElseIf myAction = "rebindExp" Then
            ExpRG.Rebind()
            ExpRTT.TargetControlID = ""
            ExpRTT_RG.Rebind()
        ElseIf myAction = "rebindInfo" Then
            AddrRadSlider.DataBind()
            AddrRadGrid.Rebind()
            s_Pref_Load()
        ElseIf myAction = "rebindToDos" Then
            MenuRadGrid.Rebind()
            MustActRG.Rebind()
            WaitingRG.Rebind()
        End If

        If myWarning <> "Nothing" Then
            RadAjaxManager1.ResponseScripts.Add("launchRadAlert('" & myWarning & "','" & myWarningTitle & "');")
        End If

    End Sub

    Public Sub s_Vis_OnPreRender()

        Dim myPartyID As String = Me.HiddenTB_PartyID.Text
        Dim myAddrYears As String = CustGenClass.f_Sproc("usp_AddrSlider", myPartyID)
        AddrRadSlider.Value = CDec(myAddrYears)
        's_HistoryYearsSliderSet(myPartyID)
        s_HistWarning()
    End Sub

    Public Sub s_Vis()

        Me.Authorize("NOT_ANONYMOUS")

        Dim myMeID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

        Dim myPartyID As String = Me.Page.Request.QueryString("Party")
        If Not String.IsNullOrEmpty(myPartyID) Then
            myPartyID = CustGenClass.f_Decrypt(myPartyID)
        Else
            myPartyID = myMeID
        End If



        'If no party from URL, the party for this page is also the user.
        If String.IsNullOrEmpty(myPartyID) Then
            myPartyID = myMeID
        End If

        'Set the hidden text field used by all controls needing the FASTPORT party.
        Me.HiddenTB_PartyID.Text = myPartyID
        Me.HiddenTB_MeID.Text = myMeID

        'Set the hidden text field used by all controls needing the DriverID.
        Dim myDriverWhere As String = PartyDriverTable.PartyID.UniqueName & " = " & myPartyID
        Dim myDriverRecord As PartyDriverRecord = PartyDriverTable.GetRecord(myDriverWhere)
        Me.HiddenTB_DriverID.Text = CStr(myDriverRecord.DriverID)

        'Load the general tab.
        s_LoadData(myPartyID)
        s_Pref_Load()
        s_LockNameFields("Yes")
        s_LockPersonalFields("Yes")
        s_LockPrefFields("Yes")


        s_ExpLock()
        s_IncidentLock()

        Dim myDropYearImageURL As String = FASTPORT.UI.BaseApplicationPage.f_ImagePath("850")
        Dim myDropYearImageURL_Glow As String = FASTPORT.UI.BaseApplicationPage.f_ImagePath("849")

        Me.DropExpImg.Attributes.Add("src", myDropYearImageURL)
        Me.DropExpImg.Attributes.Add("OnMouseOut", "src='" & myDropYearImageURL & "';")
        Me.DropExpImg.Attributes.Add("OnMouseOver", "src='" & myDropYearImageURL_Glow & "';")

        'Build the menu.
        s_Vis_FastportRTS(myPartyID)

        Dim myTab As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Tab"))
        If Not String.IsNullOrEmpty(myTab) Then
            Me.HiddenTB_Tab.Text = myTab
        End If

        Me.DropIncidentImage.Attributes.Add("src", myDropYearImageURL)
        Me.DropIncidentImage.Attributes.Add("OnMouseOut", "src='" & myDropYearImageURL & "';")
        Me.DropIncidentImage.Attributes.Add("OnMouseOver", "src='" & myDropYearImageURL_Glow & "';")

        'ToDo tab.

        Dim myTruckerName As String = CustGenClass.f_GetPartyName(myPartyID)
        Me.FPHeaderLiteral.Text = f_ApostS(myTruckerName) & " FASTPORT"
        s_GenInstRefresh(myPartyID)

        Dim myGaugeID As String = CustGenClass.f_Sproc("usp_GaugeImageID", myPartyID)
        Dim myGaugeURL As String = f_ImagePath(myGaugeID)
        Me.GaugeImage.ImageUrl = myGaugeURL
        Me.GaugeImage.Attributes.Add("Width", "110px")
        Me.GaugeImage.Attributes.Add("Height", "175px")

        s_LoadProfilePic()

    End Sub

    Public Sub s_Vis_FastportRTS(ByVal myPartyID As String)

        'Cycle through the menu sproc to build the tabs.

        Dim myTruckerTypeID As Integer = CInt(TruckerTypeRCB.SelectedValue)
        Dim myOwnerOpYesNo As String = "No"


        If myTruckerTypeID = 2529 Or myTruckerTypeID = 2530 Or myTruckerTypeID = 2531 Then
            myOwnerOpYesNo = "Yes"
        End If

        Dim data As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_FastportMenu", myPartyID, myOwnerOpYesNo)
        Dim endOffset As Integer = data.Rows.Count
        Dim i As Integer = 0

        While i < endOffset
            Dim myItemHTML As String = data.Rows(i)("ItemHTML").ToString()
            Dim myItemID As String = data.Rows(i)("TreeID").ToString()
            s_FastportMenu_AddTabs(myItemHTML, myItemID)
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While

    End Sub

    Public Sub s_FastportMenu_AddTabs(ByVal myItemHTML As String, ByVal myItemID As String)

        Dim tab As New RadTab()
        tab.Text = myItemHTML
        tab.Value = myItemID
        'Required to identify a tab clicked.
        tab.Attributes.Add("ItemID", myItemID)
        If myItemID = "2526" Or myItemID = "761" Then
            tab.PostBack = True
        Else
            tab.PostBack = False
        End If
        FastportRTS.Tabs.Add(tab)

    End Sub


    Public Sub s_GenInstRefresh(ByVal myPartyID As String)

        Dim myConfigID As String = "412"
        Dim myWhere As String = FlowConfigTable.ConfigID.UniqueName & " = " & myConfigID
        Dim myRec As FlowConfigRecord = FlowConfigTable.GetRecord(myWhere)
        Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()
        Dim mySproc As String = CustGenClass.f_Sproc("usp_Apply_GetAdActivity", myPartyID)

        If mySproc = "0" Then

            If myPartyID = myUserID Then

                If Not IsNothing(myRec) Then
                    Me.GeneralInstructionsLiteral.Text = myRec.Instructions
                End If

                MiscUtils.FindControlRecursively(Me, "TruckerDiv").Visible = True
                MiscUtils.FindControlRecursively(Me, "CarrierDiv").Visible = False

                GetHelpRB.Visible = True
                SendAppRB.Visible = True
                ApplyRB.Visible = False

            Else

                myConfigID = "551"
                myWhere = FlowConfigTable.ConfigID.UniqueName & " = " & myConfigID
                myRec = Nothing
                myRec = FlowConfigTable.GetRecord(myWhere)

                If Not IsNothing(myRec) Then
                    Me.GeneralInstructionsLiteral.Text = myRec.Instructions
                End If


                MiscUtils.FindControlRecursively(Me, "TruckerDiv").Visible = False
                MiscUtils.FindControlRecursively(Me, "CarrierDiv").Visible = False

            End If

        Else

            Dim myAdActivityID As String = CustGenClass.f_Split_ByComma(mySproc, 1)
            Dim myOverview As String = CustGenClass.f_Split_ByComma(mySproc, 2)
            Dim myFlowStatus As String = CustGenClass.f_Split_ByComma(mySproc, 3)
            Dim myApplyURL As String = FlowBaseClass.f_ApplyURL(myAdActivityID, myUserID, myPartyID, myOverview, myFlowStatus, "FastportConfig")
            Dim myGenLit As String = CustGenClass.f_GetVariable("myVar1")
            CustGenClass.s_SetVariables(Nothing)

            If Not String.IsNullOrEmpty(myGenLit) Then
                Me.GeneralInstructionsLiteral.Text = myGenLit
            End If

            Me.HiddenTB_ApplyURL.Text = myApplyURL

            If myPartyID = myUserID Then

                MiscUtils.FindControlRecursively(Me, "TruckerDiv").Visible = True
                MiscUtils.FindControlRecursively(Me, "CarrierDiv").Visible = False

                GetHelpRB.Visible = False
                SendAppRB.Visible = False
                ApplyRB.Visible = True

            Else

                MiscUtils.FindControlRecursively(Me, "TruckerDiv").Visible = False
                MiscUtils.FindControlRecursively(Me, "CarrierDiv").Visible = True

            End If

        End If

    End Sub
    Public Sub s_LoadProfilePic()

        Dim buffer() As Byte = Nothing

        Dim myPartyWhere As String = PartyTable.PartyID.UniqueName & " = " & Me.HiddenTB_PartyID.Text
        Dim myPartyRec As PartyRecord = PartyTable.GetRecord(myPartyWhere)

        If myPartyRec.ProfilePicture IsNot Nothing Then
            buffer = CType(myPartyRec.ProfilePicture, Byte())
        Else
            Dim myWhere As String = TreeTable.TreeID.UniqueName & " = 848"
            Dim myRec As TreeRecord = TreeTable.GetRecord(myWhere)
            If myRec.ItemImage IsNot NothingInside Then
                buffer = CType(myRec.ItemImage, Byte())
            End If
        End If

        If buffer IsNot Nothing Then
            Dim newStream As New System.IO.MemoryStream(buffer)
            Dim myFileAsArray As Byte() = New Byte(CInt(newStream.Length) - 1) {}
            newStream.Read(myFileAsArray, 0, myFileAsArray.Length)

            If myFileAsArray IsNot Nothing Then
                MiniProfileRadBinaryImage.DataValue = myFileAsArray
            End If
        End If

    End Sub
    Public Sub Page_PreRender() Handles Me.PreRender

        If Page.IsPostBack = False Then
            s_Vis()
        End If
        s_Vis_OnPreRender()

    End Sub

    '*************************
    '*************************
    '*************************
    'PageEnd
    '*************************
    '*************************
    '*************************


End Class
