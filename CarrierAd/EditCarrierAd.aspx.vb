
Imports BaseClasses
Imports BaseClasses.Utils

Imports FASTPORT.UI
Imports FASTPORT.Business
Imports FASTPORT.Data

Imports Telerik.Web.UI

Partial Class EditCarrierAd_aspx
    Inherits FASTPORT.UI.BaseApplicationPage
    Implements System.Web.UI.ICallbackEventHandler

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

        Dim myReturn As String = "Nothing"
        Dim mySproc As String = "Nothing"
        Dim myWarning As String = "Nothing"

        If myAction = "deleteLayer" Then

            myReturn = CustGenClass.f_Sproc("usp_AdGeo_Delete", my1st)

        ElseIf myAction = "GeoJsonRegionST" Then

            If (my2nd <> "Edit") Then
                myReturn = CustGenClass.f_Sproc("usp_GeoJson_ForRegions", "0", my1st)
            Else
                myReturn = CustGenClass.f_Sproc("usp_RegionPicker", my1st)
            End If

        ElseIf myAction = "GeoJsonLaneHub" Then

            myReturn = CustGenClass.f_Sproc("usp_GeoJson_ForLanes", "0", my1st) & "<|>" & CustGenClass.f_Sproc("usp_GeoJson_Circles", "0", my1st)

        ElseIf myAction = "GeoJsonRadius" Then

            myReturn = CustGenClass.f_Sproc("usp_GeoJson_Circles", "0", my1st)

        ElseIf myAction = "LoadAllGeoJson" Then

            myReturn = CustGenClass.f_Sproc("usp_GeoJson_ForLanes", my1st) & "<|>" & _
                    CustGenClass.f_Sproc("usp_GeoJson_ForRegions", my1st) & "<|>" & CustGenClass.f_Sproc("usp_GeoJson_Circles", my1st)

        ElseIf myAction = "updateExpSlider" Then

            mySproc = CustGenClass.f_Sproc("usp_Sliders_Importance", my1st, my2nd)

            If mySproc <> "1" Then
                myWarning = "<span style='color: #ff0000;'>WARNING:</span> The system was unable to update the importance of this item. " & _
                                "If the problem continues, please contact support. Here are the techincal details of this error: " & mySproc
            End If

            myReturn = myWarning

        End If

        Return myReturn

    End Function

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest

        Dim myArg As String = e.Argument
        Dim myAction As String = CustGenClass.f_Split_ByComma(myArg, 1)
        Dim my1st As String = CustGenClass.f_Split_ByComma(myArg, 2)
        Dim mySproc As String = "Nothing"

        If myAction = "rebindAdGeoRG" Then
            AdGeoRG.Rebind()
            RadAjaxManager1.ResponseScripts.Add("onAdGeoRGCreated();")
        ElseIf myAction = "rebindPrefs" Then
            s_Pref_Load()
        ElseIf myAction = "rebindPrefRG" Then
            PrefRG.Rebind()
        ElseIf myAction = "deletePrefItem" Then
            mySproc = CustGenClass.f_Sproc("usp_PrefDelete", my1st)
            If mySproc <> "1" Then
                Dim myWarning As String = "<span style='color: #FF0000;>WARNING: </span> the system was unable to delete this experience item.  If he problem continues, please contact support."
                Dim myWarningTitle As String = "Failed to Delete"
            End If
            PrefRG.Rebind()
            Pref_GeneralRAC.DataBind()
            Pref_EquipRAC.DataBind()
            Pref_CommodityRAC.DataBind()
            Pref_OtherRAC.DataBind()

        End If

    End Sub

    Partial Private Sub TestClass()

    End Sub

    Public Sub s_Save()

        Try
            Dim myID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Ad"))
            DbUtils.StartTransaction()
            Dim myRec As New CarrierAdRecord 'Record class for table to update.
            myRec = CarrierAdTable.GetRecord(myID, True)

            myRec.AdTemplate = CBool(AdTemplateRB.SelectedToggleStateIndex)
            myRec.AdName = Me.AdName.Text
            Dim myTruckerTypeID As Integer = CInt(TruckerTypeRCB.SelectedValue)
            If myTruckerTypeID <> 0 Then
                myRec.TruckerTypeID = CInt(TruckerTypeRCB.SelectedValue)
            Else
                myRec.SetTruckerTypeIDFieldValue("")
            End If
            myRec.ShortDescription = Me.ShortDescription.Text

            If String.IsNullOrEmpty(PositionsAvailableRTB.Text) = False Then
                myRec.PositionsAvail = CInt(PositionsAvailableRTB.Text)
            End If

            If Not IsNothing(Me.RunOnDatePicker.SelectedDate) Then
                myRec.RunOn = CDate(Me.RunOnDatePicker.SelectedDate)
            Else
                myRec.SetRunOnFieldValue("")
            End If

            If Not IsNothing(Me.ExpireOnDatePicker.SelectedDate) Then
                myRec.ExpireOn = CDate(Me.ExpireOnDatePicker.SelectedDate)
            Else
                myRec.SetExpireOnFieldValue("")
            End If

            myRec.LimitByAge = CBool(LimitByAgeRB.SelectedToggleStateIndex)
            myRec.MinAge = CInt(Replace(Me.MinAge.Text, "", Nothing))
            myRec.HideAd = Me.HideAd.Checked

            If String.IsNullOrEmpty(PSPPointMaxRTB.Text) = False Then
                myRec.PSPMaximum = CInt(PSPPointMaxRTB.Text)
            End If

            myRec.LimitByMajorAccidents = CBool(LimitByMajorAccidentsRB.SelectedToggleStateIndex)
            myRec.MajorByID = CInt(Me.MajorByCB.SelectedValue)
            myRec.MajorCountID = CInt(Me.MajorCountCB.SelectedValue)
            myRec.MajorMilesID = CInt(Me.MajorMilesCB.SelectedValue)
            myRec.MajorYearsID = CInt(Me.MajorYearsCB.SelectedValue)

            myRec.LimitByMinorAccidents = CBool(LimitByMinorAccidentsRB.SelectedToggleStateIndex)
            myRec.MinorByID = CInt(Me.MinorByCB.SelectedValue)
            myRec.MinorCountID = CInt(Me.MinorCountCB.SelectedValue)
            myRec.MinorMilesID = CInt(Me.MinorMilesCB.SelectedValue)
            myRec.MinorYearsID = CInt(Me.MinorYearsCB.SelectedValue)

            myRec.LimitByTickets = CBool(LimitByTicketsRB.SelectedToggleStateIndex)
            myRec.TicketsByID = CInt(Me.TicketsByCB.SelectedValue)
            myRec.TicketCountID = CInt(Me.TicketCountCB.SelectedValue)
            myRec.TicketMilesID = CInt(Me.TicketMilesCB.SelectedValue)
            myRec.TicketYearsID = CInt(Me.TicketYearsCB.SelectedValue)

            myRec.LimitBySeriousTickets = CBool(LimitBySeriousTicketsRB.SelectedToggleStateIndex)
            myRec.SeriousByID = CInt(Me.SeriousByCB.SelectedValue)
            myRec.SeriousCountID = CInt(Me.SeriousCountCB.SelectedValue)
            myRec.SeriousMilesID = CInt(Me.SeriousMilesCB.SelectedValue)
            myRec.SeriousYearsID = CInt(Me.SeriousYearsCB.SelectedValue)

            myRec.LimitByFelonies = CBool(LimitByFeloniesRB.SelectedToggleStateIndex)
            myRec.FeloniesByID = CInt(Me.FeloniesByCB.SelectedValue)
            myRec.FelonyCountID = CInt(Me.FeloniesCountCB.SelectedValue)
            myRec.FelonyMilesID = CInt(Me.FeloniesMilesCB.SelectedValue)
            myRec.FelonyYearsID = CInt(Me.FeloniesYearsCB.SelectedValue)

            myRec.LimitByDrugConvictions = CBool(LimitByDrugConvictionsRB.SelectedToggleStateIndex)
            myRec.DrugConvictionsByID = CInt(Me.DrugConvictionsByCB.SelectedValue)
            myRec.DrugCountID = CInt(Me.DrugCountCB.SelectedValue)
            myRec.DrugConvictionMilesID = CInt(Me.DrugMilesCB.SelectedValue)
            myRec.DrugYearsID = CInt(Me.DrugConvictionsYearsCB.SelectedValue)

            myRec.LimitByFailedTest = CBool(LimitByFailedTestRB.SelectedToggleStateIndex)
            myRec.FailedByID = CInt(Me.FailedByCB.SelectedValue)
            myRec.FailedCountID = CInt(Me.FailedCountCB.SelectedValue)
            myRec.FailedMilesID = CInt(Me.FailedMilesCB.SelectedValue)
            myRec.FailedYearsID = CInt(Me.FailedYearsCB.SelectedValue)

            myRec.LimitByDUICommercial = CBool(LimitByDUICommercialRB.SelectedToggleStateIndex)
            myRec.CommDUIByID = CInt(Me.CommDUIByCB.SelectedValue)
            myRec.CommDUICountID = CInt(Me.CommDUICountCB.SelectedValue)
            myRec.CommDUIMilesID = CInt(Me.CommDUIMilesCB.SelectedValue)
            myRec.CommDUIYearsID = CInt(Me.CommDUIYearsCB.SelectedValue)

            myRec.LimitByDUIPersonal = CBool(LimitByDUIPersonalRB.SelectedToggleStateIndex)
            myRec.PersonalDUIByID = CInt(Me.PersonalDUIByCB.SelectedValue)
            myRec.PersonalDUICountID = CInt(Me.PersonalDUICountCB.SelectedValue)
            myRec.PersonalDUIMilesID = CInt(Me.PersonalDUIMilesCB.SelectedValue)
            myRec.PersonalDUIYearsID = CInt(Me.PersonalDUIYearsCB.SelectedValue)

            myRec.LongDescription = Me.LongDescriptionRadEditor.Content
            myRec.LinksToOtherPostings = Me.LinksToJobPostingsRE.Content

            Dim myPayTypeID As String = PayTypeRCB.SelectedValue

            If BaseApplicationPage.f_StringEmpty(myPayTypeID) = "No" Then
                myRec.PayTypeID = CInt(myPayTypeID)
            Else
                myRec.SetPayTypeIDFieldValue("")
            End If

            myRec.LineHaulPerc = CDbl(Replace(Me.LineHaulPercTB.Text, "", Nothing)) / 100
            myRec.LoadedPerMile = CDec(Replace(Me.LoadedPerMile.Text, "", Nothing))
            myRec.EmptyPerMile = CDec(Replace(Me.EmptyPerMile.Text, "", Nothing))
            myRec.HourlyRate = CDec(Replace(Me.HourlyRate.Text, "", Nothing))
            myRec.AvgPayPerWeek = CDec(Replace(Me.AvgPayPerWeek.Text, "", Nothing))
            myRec.PayGuaranty = Me.PayGuaranty.Checked
            myRec.FuelReimbursed = CBool(FuelReimbursedRB.SelectedToggleStateIndex)
            myRec.AllFuel = Me.AllFuel.Checked
            myRec.PayNotes = Me.PayNotesRadEditor.Content

            DbUtils.CommitTransaction()
            myRec.Save()

        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)

        Finally
            DbUtils.EndTransaction()
            Dim myWarning As String = f_SavePrefFields()
            If myWarning <> "Success" Then
                RadAjaxManager1.ResponseScripts.Add("launchRadAlert('" & myWarning & "','Save Failed');")
            End If
        End Try

    End Sub

    Protected Sub s_SaveTerms()

        For Each dataItem As GridDataItem In TermRadGrid.MasterTableView.Items

            Dim mySelectedCB As CheckBox = CType(dataItem("TemplateColumn1").Controls(1), CheckBox)
            Dim myChecked As Boolean = mySelectedCB.Checked
            Dim myAddrID As String = dataItem.GetDataKeyValue("AddrID").ToString
            Dim myAdId As String = Me.HiddenTB_AdID.Text

            CustGenClass.f_Sproc("usp_AdTermAddDel", myAdId, myAddrID, CStr(myChecked))

        Next

    End Sub

    Protected Sub s_SavePeople()

        For Each dataItem As GridDataItem In PeopleRadGrid.MasterTableView.Items

            Dim mySelectedCB As CheckBox = CType(dataItem("TemplateColumn1").Controls(1), CheckBox)

            Dim myAdID As String = Me.HiddenTB_AdID.Text
            Dim myChecked As Boolean = mySelectedCB.Checked
            Dim myPK As String = dataItem.GetDataKeyValue("PartyID").ToString
            Dim myAction As String = CustGenClass.f_Split_ByComma(myPK, 1)
            Dim myID As String = CustGenClass.f_Split_ByComma(myPK, 2)

            CustGenClass.f_Sproc("usp_AdPeopleAddDel", myAdID, myID, CStr(myChecked), myAction)

        Next


    End Sub

    Protected Sub s_AdGeoValues(ByVal myAdGeoID As String)

        Dim myW As String = CarrierAdGeoTable.AdGeoID.UniqueName & " = " & myAdGeoID
        Dim myR As CarrierAdGeoRecord = CarrierAdGeoTable.GetRecord(myW)

        Dim myAdGeoTypeID As String = If(CStr(myR.AdGeoTypeID), "")
        AdGeoTypeRCB.SelectedValue = myAdGeoTypeID
        Dim myOriginCityID As String = If(CStr(myR.OriginCityID), "")
        Me.OriginCityRCB.SelectedValue = myOriginCityID
        OriginCityRCB.Text = CustGenClass.f_Sproc("usp_CityST", myOriginCityID)
        OrigRadiusRCB.SelectedValue = If(CStr(myR.OriginRadius), "")
        DestRadiusRCB.SelectedValue = If(CStr(myR.DestRadius), "")
        AdGeoNotesRE.Content = If(myR.AdGeoNotes, "")
        AdGeoTypeRCB.DataBind()

        If myAdGeoTypeID = "2589" Then
            DestCityRAC.Entries.Clear()
            s_LoadRACValues(DestCityRAC, myAdGeoID)
            DestCityRAC.DataBind()
        ElseIf myAdGeoTypeID = "2590" Then
            RegionsRAC.Entries.Clear()
            s_LoadRACValues(RegionsRAC, myAdGeoID)
            RegionsRAC.DataBind()
        ElseIf myAdGeoTypeID = "2591" Then
            StatesRAC.Entries.Clear()
            s_LoadRACValues(StatesRAC, myAdGeoID)
            StatesRAC.DataBind()
        Else
            PointsRAC.Entries.Clear()
            s_LoadRACValues(PointsRAC, myAdGeoID)
            PointsRAC.DataBind()
        End If

    End Sub

    Protected Sub s_LoadRACValues(ByVal myRAC As RadAutoCompleteBox, ByVal myAdGeoID As String)

        If myRAC Is RegionsRAC Or myRAC Is StatesRAC Then

            Try

                Dim data As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_AdGeoRegionValues", myAdGeoID)

                Dim endOffset As Integer = data.Rows.Count

                Dim i As Integer = 0
                While i < endOffset
                    Dim myNodeText As String = data.Rows(i)("ItemName").ToString()
                    Dim myNodeID As String = data.Rows(i)("RegionID").ToString()
                    myRAC.Entries.Add(New AutoCompleteBoxEntry(myNodeText, myNodeID))
                    i = i + 1
                End While

            Catch ex As Exception

            End Try

        Else

            Try
                Dim data As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_AdGeoPointValues", myAdGeoID)

                Dim endOffset As Integer = data.Rows.Count

                Dim i As Integer = 0
                While i < endOffset
                    Dim myNodeText As String = data.Rows(i)("City").ToString()
                    Dim myNodeID As String = data.Rows(i)("PointCityID").ToString()
                    myRAC.Entries.Add(New AutoCompleteBoxEntry(myNodeText, myNodeID))
                    i = i + 1
                End While

            Catch ex As Exception

            End Try

        End If

    End Sub

    Protected Sub TermRadGrid_ItemDatabound(ByVal sender As Object, ByVal e As GridItemEventArgs)

        If TypeOf e.Item Is GridDataItem Then
            Dim item As GridDataItem = DirectCast(e.Item, GridDataItem)

            Dim myAdID As String = Me.HiddenTB_AdID.Text
            Dim myAddrID As String = item.GetDataKeyValue("AddrID").ToString

            Dim myChecked As String = CustGenClass.f_Sproc("usp_AdTermStatus", myAdID, myAddrID)

            Dim mySelectedCB As CheckBox = CType(item("TemplateColumn1").Controls(1), CheckBox)

            If myChecked = "True" Then
                mySelectedCB.Checked = True
            Else
                mySelectedCB.Checked = False
            End If

        End If

    End Sub

    Private Const ItemsPerRequest As Integer = 10

    Protected Sub s_OriginCityRCB_ItemsRequested(ByVal sender As Object, ByVal e As RadComboBoxItemsRequestedEventArgs) Handles OriginCityRCB.ItemsRequested

        Try

            Dim data As DataTable = f_ZipCombo_GetData(e.Text)

            Dim itemOffset As Integer = e.NumberOfItems
            Dim endOffset As Integer = Math.Min(itemOffset + ItemsPerRequest, data.Rows.Count)
            e.EndOfItems = endOffset = data.Rows.Count

            Dim i As Integer = itemOffset
            While i < endOffset
                OriginCityRCB.Items.Add(New RadComboBoxItem(data.Rows(i)("Info").ToString(), data.Rows(i)("PK").ToString()))
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While

        Catch ex As Exception

        End Try

    End Sub

    Public Function f_ZipCombo_GetData(ByVal text As String) As DataTable

        Dim myDataTable As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_PickCity", text, "3")
        Return myDataTable

    End Function

    Public Sub DestCityRAC_DataSourceSelect(ByVal sender As Object, ByVal e As AutoCompleteBoxDataSourceSelectEventArgs) Handles DestCityRAC.DataSourceSelect

        Dim source As SqlDataSource = DirectCast(e.DataSource, SqlDataSource)
        Dim autoCompleteBox As RadAutoCompleteBox = DirectCast(sender, RadAutoCompleteBox)

        Dim filterString As String = e.FilterString
        source.SelectCommand = "EXEC dbo.usp_PickCity '" & filterString & "', '3', '0'"

    End Sub

    Public Sub PointsRAC_DataSourceSelect(ByVal sender As Object, ByVal e As AutoCompleteBoxDataSourceSelectEventArgs) Handles PointsRAC.DataSourceSelect

        Dim source As SqlDataSource = DirectCast(e.DataSource, SqlDataSource)
        Dim autoCompleteBox As RadAutoCompleteBox = DirectCast(sender, RadAutoCompleteBox)

        Dim filterString As String = e.FilterString
        source.SelectCommand = "EXEC dbo.usp_PickCity '" & filterString & "', '3', '0'"

    End Sub

    Public Sub AdGeoAddRB_Click() Handles AdGeoAddRB.Click

        Dim myAdID As String = Me.HiddenTB_AdID.Text
        Dim myAdGeoTypeID As String = AdGeoTypeRCB.SelectedValue
        Dim myOriginCityID As String = OriginCityRCB.SelectedValue
        Dim myOrigRadius As String = OrigRadiusRCB.SelectedValue
        Dim myDestRadius As String = DestRadiusRCB.SelectedValue
        Dim myAdGeoNotes As String = AdGeoNotesRE.Content
        Dim myNewAdGeoID As String = Nothing

        Try
            DbUtils.StartTransaction()
            Dim myRec As New CarrierAdGeoRecord
            myRec.AdID = CInt(myAdID)
            myRec.AdGeoTypeID = CInt(myAdGeoTypeID)
            If Not String.IsNullOrEmpty(myOriginCityID) Then
                myRec.OriginCityID = CInt(myOriginCityID)
            End If
            If Not String.IsNullOrEmpty(myOrigRadius) Then
                myRec.OriginRadius = CInt(myOrigRadius)
            End If
            If Not String.IsNullOrEmpty(myDestRadius) Then
                myRec.DestRadius = CInt(myDestRadius)
            End If
            If Not String.IsNullOrEmpty(myAdGeoNotes) Then
                myRec.AdGeoNotes = myAdGeoNotes
            End If
            myRec.Save()
            DbUtils.CommitTransaction()
            myNewAdGeoID = myRec.AdGeoID.ToString

        Catch ex As Exception
            ' Upon error, rollback the transaction
            DbUtils.RollBackTransaction()
            ' Report the error message to the end user
            Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
        Finally
            DbUtils.EndTransaction()
            s_RegionDests(myNewAdGeoID, myAdID)
            Me.HiddenTB_AdGeoStatus.Text = "Saved"
        End Try

        AdGeoRG.Rebind()
        RadAjaxManager1.ResponseScripts.Add("onAdGeoRGCreated();")

    End Sub

    Public Sub s_RegionDests(ByVal myAdGeoID As String, ByVal myAdID As String)

        'Get all of the IDs in the RAC.

        Dim myChildren As String = ""

        For Each entry As AutoCompleteBoxEntry In DestCityRAC.Entries
            Dim myExperienceID As String = entry.Value
            myChildren = myChildren & myExperienceID & ","
        Next
        'Aftre you have all the IDs run your new sproc.
        CustGenClass.f_Sproc("usp_PointCityAdd_FromRAC", myAdGeoID, If(myChildren, ""))

        myChildren = ""
        If RegionsRAC.Entries.Count() <> 0 Then

            For Each entry As AutoCompleteBoxEntry In RegionsRAC.Entries
                Dim myExperienceID As String = entry.Value
                myChildren = myChildren & myExperienceID & ","
            Next
            CustGenClass.f_Sproc("usp_RegionsAdd_FromRAC", myAdGeoID, If(myChildren, ""))

            Dim myParents As String = "741"
            Dim myWarning As String = "Nothing"
            Dim myReturnMessage As String = CustGenClass.f_Sproc("usp_ExpAdd_FromRAC", "Ad", myAdID, myParents, If(myChildren, ""))
            If myReturnMessage <> "Success" Then
                myWarning = BaseApplicationPage.f_Warning(myWarning, myReturnMessage)
            End If
        End If

        myChildren = ""
        If StatesRAC.Entries.Count() <> 0 Then
            For Each entry As AutoCompleteBoxEntry In StatesRAC.Entries
                Dim myExperienceID As String = entry.Value
                myChildren = myChildren & myExperienceID & ","
            Next
            CustGenClass.f_Sproc("usp_StatesAdd_FromRAC", myAdGeoID, If(myChildren, ""))
        End If

        myChildren = ""
        If PointsRAC.Entries.Count() <> 0 Then
            For Each entry As AutoCompleteBoxEntry In PointsRAC.Entries
                Dim myExperienceID As String = entry.Value
                myChildren = myChildren & myExperienceID & ","
            Next
            Dim myReturn As String = CustGenClass.f_Sproc("usp_PointCityAdd_FromRAC", myAdGeoID, If(myChildren, ""))
        End If

    End Sub

    Public Sub s_AdGeoRG_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles AdGeoRG.ItemDataBound

        If TypeOf e.Item Is GridDataItem Then

            Dim dataItem As GridDataItem = CType(e.Item, GridDataItem)
            Dim LayerDelIB As ImageButton = DirectCast(dataItem("DelLayer_TemplateColumn").FindControl("LayerDelIB"), ImageButton)
            LayerDelIB.Attributes.Add("onclick", "onLayerDelIBClicked(" + CStr(dataItem.ItemIndex) + ");")

        End If

    End Sub

    Public Sub s_AdGeoRG_ItemCommand(ByVal sender As Object, ByVal e As GridCommandEventArgs) Handles AdGeoRG.ItemCommand

        Dim item As GridDataItem = DirectCast(e.Item, GridDataItem)
        Dim myAdGeoID As String = item.GetDataKeyValue("AdGeoID").ToString
        Me.HiddenTB_AdGeoID.Text = myAdGeoID
        Me.HiddenTB_AdGeoStatus.Text = "Edit"

        Dim myLayerEditIB As ImageButton = DirectCast(e.CommandSource, ImageButton)
        Dim myLayerEditIBName As String = myLayerEditIB.UniqueID

        s_AdGeoValues(myAdGeoID)

        RadAjaxManager1.ResponseScripts.Add("v_AdGeoDisplay();")

    End Sub

    Protected Sub AdGeoSaveRB_Click() Handles AdGeoSaveRB.Click

        Dim myAdID As String = Me.HiddenTB_AdID.Text
        Dim myAdGeoID As String = Me.HiddenTB_AdGeoID.Text

        Try

            Dim myAdGeoType As String = AdGeoTypeRCB.SelectedValue
            Dim myOriginCity As String = OriginCityRCB.SelectedValue
            Dim myOrigRadius As String = OrigRadiusRCB.SelectedValue
            Dim myDestRadius As String = DestRadiusRCB.SelectedValue
            Dim myAdGeoNotes As String = AdGeoNotesRE.Content
            DbUtils.StartTransaction()
            Dim myRec As New CarrierAdGeoRecord  'Record class for table to update.
            myRec = CarrierAdGeoTable.GetRecord(myAdGeoID, True)
            myRec.AdGeoTypeID = CInt(myAdGeoType)
            If myOriginCity <> "0" And myOriginCity <> Nothing Then
                myRec.OriginCityID = CInt(myOriginCity)
            End If
            If Not String.IsNullOrEmpty(myOrigRadius) Then
                myRec.OriginRadius = CInt(myOrigRadius)
            End If
            If Not String.IsNullOrEmpty(myDestRadius) Then
                myRec.DestRadius = CInt(myDestRadius)
            End If
            If Not String.IsNullOrEmpty(myAdGeoNotes) Then
                myRec.AdGeoNotes = myAdGeoNotes
            End If
            DbUtils.CommitTransaction()
            myRec.Save()

        Catch ex As Exception
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)

        Finally
            DbUtils.EndTransaction()
            s_RegionDests(myAdGeoID, myAdID)
            Me.HiddenTB_AdGeoStatus.Text = "Saved"
        End Try

        RadAjaxManager1.ResponseScripts.Add("onAdGeoRGCreated();")
        AdGeoRG.DataBind()

    End Sub

    Public Function f_SavePrefFields() As String

        Dim myAdID As String = Me.HiddenTB_AdID.Text
        Dim myParents As String = "743"
        Dim myChildren As String = ""
        Dim myWarning As String = Nothing
        Dim myReturnMessage As String = Nothing

        For Each entry As AutoCompleteBoxEntry In Pref_GeneralRAC.Entries
            Dim myExperienceID As String = entry.Value
            myChildren = myChildren & myExperienceID & ","
        Next

        myReturnMessage = CustGenClass.f_Sproc("usp_ExpAdd_FromRAC", "Ad", myAdID, myParents, If(myChildren, ""))
        If myReturnMessage <> "Success" Then
            myWarning = BaseApplicationPage.f_Warning(myWarning, myReturnMessage)
        End If

        myParents = "666"
        myChildren = ""

        For Each entry As AutoCompleteBoxEntry In Pref_CommodityRAC.Entries
            Dim myExperienceID As String = entry.Value
            myChildren = myChildren & myExperienceID & ","
        Next

        myReturnMessage = CustGenClass.f_Sproc("usp_ExpAdd_FromRAC", "Ad", myAdID, myParents, If(myChildren, ""))
        If myReturnMessage <> "Success" Then
            myWarning = BaseApplicationPage.f_Warning(myWarning, myReturnMessage)
        End If

        myParents = "389"
        myChildren = ""

        For Each entry As AutoCompleteBoxEntry In Pref_EquipRAC.Entries
            Dim myExperienceID As String = entry.Value
            myChildren = myChildren & myExperienceID & ","
        Next

        myReturnMessage = CustGenClass.f_Sproc("usp_ExpAdd_FromRAC", "Ad", myAdID, myParents, If(myChildren, ""))
        If myReturnMessage <> "Success" Then
            myWarning = BaseApplicationPage.f_Warning(myWarning, myReturnMessage)
        End If

        myParents = "851,852,853"
        myChildren = ""

        For Each entry As AutoCompleteBoxEntry In Pref_OtherRAC.Entries
            Dim myExperienceID As String = entry.Value
            myChildren = myChildren & myExperienceID & ","
        Next

        myReturnMessage = CustGenClass.f_Sproc("usp_ExpAdd_FromRAC", "Ad", myAdID, myParents, If(myChildren, ""))
        If myReturnMessage <> "Success" Then
            myWarning = BaseApplicationPage.f_Warning(myWarning, myReturnMessage)
        End If

        If String.IsNullOrEmpty(myWarning) Then
            myWarning = "Success"
        End If

        Return myWarning

    End Function

    Protected Sub PeopleRadGrid_ItemDatabound(ByVal sender As Object, ByVal e As GridItemEventArgs)

        If TypeOf e.Item Is GridDataItem Then
            Dim item As GridDataItem = DirectCast(e.Item, GridDataItem)

            Dim myAdID As String = Me.HiddenTB_AdID.Text
            Dim myPK As String = item.GetDataKeyValue("PartyID").ToString
            Dim myAction As String = CustGenClass.f_Split_ByComma(myPK, 1)
            Dim myID As String = CustGenClass.f_Split_ByComma(myPK, 2)

            Dim myChecked As String = CustGenClass.f_Sproc("usp_AdPeopleStatus", myAdID, myID, myAction)

            Dim mySelectedCB As CheckBox = CType(item("TemplateColumn1").Controls(1), CheckBox)

            If myChecked = "True" Then
                mySelectedCB.Checked = True
            Else
                mySelectedCB.Checked = False
            End If

        End If

    End Sub

    Public Sub s_Prefs_RACs_Load(ByVal myParentID As String, ByVal myRAC As RadAutoCompleteBox, Optional ByVal myClear As String = "Yes")

        If myClear = "Yes" Then
            myRAC.Entries.Clear()
        End If

        Try

            Dim myAdID As String = Me.HiddenTB_AdID.Text
            Dim data As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_PrefsByDriver_ForRAC", "Ad", myAdID, myParentID)

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

    Public Sub s_Pref_Load()

        Pref_GeneralRAC.Enabled = False
        Pref_EquipRAC.Enabled = False
        Pref_CommodityRAC.Enabled = False
        Pref_OtherRAC.Enabled = False

        s_Prefs_RACs_Load("743", Pref_GeneralRAC)
        s_Prefs_RACs_Load("666", Pref_CommodityRAC)
        s_Prefs_RACs_Load("389", Pref_EquipRAC)
        s_Prefs_RACs_Load("851", Pref_OtherRAC)
        s_Prefs_RACs_Load("852", Pref_OtherRAC, "No")
        s_Prefs_RACs_Load("853", Pref_OtherRAC, "No")

    End Sub

    Protected Sub PrefRG_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles PrefRG.ItemDataBound

        If TypeOf e.Item Is GridDataItem Then

            Dim dataItem As GridDataItem = CType(e.Item, GridDataItem)
            Dim myImportance As Integer = CInt(dataItem.GetDataKeyValue("Importance").ToString)
            Dim mySlider As RadSlider = CType(dataItem("ImportanceColumn").Controls(1), RadSlider)
            Dim myYearSlider As Boolean = CBool(dataItem.GetDataKeyValue("YearSlider").ToString)
            Dim myAction As String = Me.Page.Request.QueryString("Action")

            If myYearSlider = True And myAction <> "CreateAccount" Then

                mySlider.Items.Clear()

                mySlider.Items.Add(New RadSliderItem("< 1 Year", "0"))
                mySlider.Items.Add(New RadSliderItem("", "1"))
                mySlider.Items.Add(New RadSliderItem("3 Years", "2"))
                mySlider.Items.Add(New RadSliderItem("", "3"))
                mySlider.Items.Add(New RadSliderItem("5 Years", "4"))

            End If
            mySlider.Value = CDec(myImportance)

            Dim PrefRTT_DelIB As ImageButton = DirectCast(dataItem("PrefRTT_PrefDelIBColumn").FindControl("PrefRTT_PrefDelIB"), ImageButton)
            PrefRTT_DelIB.Attributes.Add("onclick", "onPrefRTT_DelIBClick('" + CStr(dataItem.ItemIndex) + "');")

        End If

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
            Pref_OtherRAC.Enabled = False
            Pref_OtherRB.Visible = True
        Else
            Pref_GeneralRAC.Enabled = True
            Pref_GeneralRB.Visible = False
            Pref_EquipRAC.Enabled = True
            Pref_EquipRB.Visible = False
            Pref_CommodityRAC.Enabled = True
            Pref_CommodityRB.Visible = False
            Pref_OtherRAC.Enabled = True
            Pref_OtherRB.Visible = False
        End If

    End Sub

    Protected Sub TermRadGrid_ItemCommand(ByVal sender As Object, ByVal e As GridCommandEventArgs) Handles TermRadGrid.ItemCommand

        Dim item As GridDataItem = DirectCast(e.Item, GridDataItem)
        Dim myCarrierID As String = item.GetDataKeyValue("PartyID").ToString
        Dim myAddrID As String = item.GetDataKeyValue("AddrID").ToString

        If e.CommandName = "RowClick" Then

            Me.HiddenTB_AddrID.Text = myAddrID
            PeopleRadGrid.Rebind()
            UnselectAddrButton.Visible = True

        End If

    End Sub

    Public Sub s_Vis()

        Dim myPartyID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Party"))

        Me.HiddenTB_PartyID.Text = myPartyID

        Dim myAdID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Ad"))

        If String.IsNullOrEmpty(myAdID) = False Then
            Me.HiddenTB_AdID.Text = myAdID
        End If

        Dim myW As String = CarrierAdTable.AdID.UniqueName & " = " & myAdID
        Dim myR As CarrierAdRecord = CarrierAdTable.GetRecord(myW)

        If Not String.IsNullOrEmpty(myR.AdName) Then
            Me.AdName.Text = myR.AdName
        End If

        If Not String.IsNullOrEmpty(myR.ShortDescription) Then
            Me.ShortDescription.Text = myR.ShortDescription
        End If

        If Not IsNothing(myR.MinAge) Then
            Me.MinAge.Text = CStr(myR.MinAge)
        End If
        If String.IsNullOrEmpty(CStr(CInt(myR.PositionsAvail))) = False Then
            PositionsAvailableRTB.Text = CStr(myR.PositionsAvail)
        End If

        If myR.TruckerTypeID <> 0 Then
            TruckerTypeRCB.SelectedValue = Convert.ToString(myR.TruckerTypeID)
        End If

        LimitByAgeRB.SetSelectedToggleStateByValue(CStr(Convert.ToInt32(myR.LimitByAge)))
        
        If String.IsNullOrEmpty(CStr(myR.RunOn)) = False And CStr(myR.RunOn) <> "12:00:00 AM" Then
            Me.RunOnDatePicker.SelectedDate = myR.RunOn
        End If

        If String.IsNullOrEmpty(CStr(myR.ExpireOn)) = False And CStr(myR.ExpireOn) <> "12:00:00 AM" Then
            Me.ExpireOnDatePicker.SelectedDate = myR.ExpireOn
        End If

        LimitByMajorAccidentsRB.SetSelectedToggleStateByValue(CStr(Convert.ToInt32(myR.LimitByMajorAccidents)))
        Me.MajorByCB.SelectedValue = CStr(myR.MajorByID)
        Me.MajorByCB.Text = CStr(myR.MajorByID)
        Me.MajorYearsCB.SelectedValue = CStr(myR.MajorYearsID)
        Me.MajorYearsCB.Text = CStr(myR.MajorYearsID)

        LimitByMinorAccidentsRB.SetSelectedToggleStateByValue(CStr(Convert.ToInt32(myR.LimitByMinorAccidents)))
        Me.MinorByCB.SelectedValue = CStr(myR.MinorByID)
        Me.MinorByCB.Text = CStr(myR.MinorByID)
        Me.MinorYearsCB.SelectedValue = CStr(myR.MinorYearsID)
        Me.MinorYearsCB.Text = CStr(myR.MinorYearsID)

        LimitBySeriousTicketsRB.SetSelectedToggleStateByValue(CStr(Convert.ToInt32(myR.LimitBySeriousTickets)))
        Me.SeriousByCB.SelectedValue = CStr(myR.SeriousByID)
        Me.SeriousByCB.Text = CStr(myR.SeriousByID)
        Me.SeriousYearsCB.SelectedValue = CStr(myR.SeriousYearsID)
        Me.SeriousYearsCB.Text = CStr(myR.SeriousYearsID)

        LimitByTicketsRB.SetSelectedToggleStateByValue(CStr(Convert.ToInt32(myR.LimitByTickets)))
        Me.TicketsByCB.SelectedValue = CStr(myR.TicketsByID)
        Me.TicketsByCB.Text = CStr(myR.TicketsByID)
        Me.TicketYearsCB.SelectedValue = CStr(myR.TicketYearsID)
        Me.TicketYearsCB.Text = CStr(myR.TicketYearsID)

        LimitByFeloniesRB.SetSelectedToggleStateByValue(CStr(Convert.ToInt32(myR.LimitByFelonies)))
        Me.FeloniesByCB.SelectedValue = CStr(myR.FeloniesByID)
        Me.FeloniesByCB.Text = CStr(myR.FeloniesByID)
        Me.FeloniesYearsCB.SelectedValue = CStr(myR.FelonyYearsID)
        Me.FeloniesYearsCB.Text = CStr(myR.FelonyYearsID)

        LimitByDrugConvictionsRB.SetSelectedToggleStateByValue(CStr(Convert.ToInt32(myR.LimitByDrugConvictions)))
        Me.DrugConvictionsByCB.SelectedValue = CStr(myR.DrugConvictionsByID)
        Me.DrugConvictionsByCB.Text = CStr(myR.DrugConvictionsByID)
        Me.DrugConvictionsYearsCB.SelectedValue = CStr(myR.DrugYearsID)
        Me.DrugConvictionsYearsCB.Text = CStr(myR.DrugYearsID)

        LimitByFailedTestRB.SetSelectedToggleStateByValue(CStr(Convert.ToInt32(myR.LimitByFailedTest)))
        Me.FailedByCB.SelectedValue = CStr(myR.FailedByID)
        Me.FailedByCB.Text = CStr(myR.FailedByID)
        Me.FailedYearsCB.SelectedValue = CStr(myR.FailedYearsID)
        Me.FailedYearsCB.Text = CStr(myR.FailedYearsID)

        LimitByDUICommercialRB.SetSelectedToggleStateByValue(CStr(Convert.ToInt32(myR.LimitByDUICommercial)))
        Me.CommDUIByCB.SelectedValue = CStr(myR.CommDUIByID)
        Me.CommDUIByCB.Text = CStr(myR.CommDUIByID)
        Me.CommDUIYearsCB.SelectedValue = CStr(myR.CommDUIYearsID)
        Me.CommDUIYearsCB.Text = CStr(myR.CommDUIYearsID)

        LimitByDUIPersonalRB.SetSelectedToggleStateByValue(CStr(Convert.ToInt32(myR.LimitByDUIPersonal)))
        Me.PersonalDUIByCB.SelectedValue = CStr(myR.PersonalDUIByID)
        Me.PersonalDUIByCB.Text = CStr(myR.PersonalDUIByID)
        Me.PersonalDUIYearsCB.SelectedValue = CStr(myR.PersonalDUIYearsID)
        Me.PersonalDUIYearsCB.Text = CStr(myR.PersonalDUIYearsID)

        If String.IsNullOrEmpty(CStr(myR.PSPMaximum)) = False Then
            PSPPointMaxRTB.Text = CStr(myR.PSPMaximum)
        End If

        Me.MajorCountCB.SelectedValue = CStr(myR.MajorCountID)
        Me.MajorCountCB.Text = CStr(myR.MajorCountID)
        Me.MajorMilesCB.SelectedValue = CStr(myR.MajorMilesID)
        Me.MajorMilesCB.Text = CStr(myR.MajorMilesID)

        Me.MinorCountCB.SelectedValue = CStr(myR.MinorCountID)
        Me.MinorCountCB.Text = CStr(myR.MinorCountID)
        Me.MinorMilesCB.SelectedValue = CStr(myR.MinorMilesID)
        Me.MinorMilesCB.Text = CStr(myR.MinorMilesID)

        Me.SeriousCountCB.SelectedValue = CStr(myR.SeriousCountID)
        Me.SeriousCountCB.Text = CStr(myR.SeriousCountID)
        Me.SeriousMilesCB.SelectedValue = CStr(myR.SeriousMilesID)
        Me.SeriousMilesCB.Text = CStr(myR.SeriousMilesID)

        Me.TicketCountCB.SelectedValue = CStr(myR.TicketCountID)
        Me.TicketCountCB.Text = CStr(myR.TicketCountID)
        Me.TicketMilesCB.SelectedValue = CStr(myR.TicketMilesID)
        Me.TicketMilesCB.Text = CStr(myR.TicketMilesID)

        Me.FeloniesCountCB.SelectedValue = CStr(myR.FelonyCountID)
        Me.FeloniesCountCB.Text = CStr(myR.FelonyCountID)
        Me.FeloniesMilesCB.SelectedValue = CStr(myR.FelonyMilesID)
        Me.FeloniesMilesCB.Text = CStr(myR.FelonyMilesID)

        Me.DrugCountCB.SelectedValue = CStr(myR.DrugCountID)
        Me.DrugCountCB.Text = CStr(myR.DrugCountID)
        Me.DrugMilesCB.SelectedValue = CStr(myR.DrugConvictionMilesID)
        Me.DrugMilesCB.Text = CStr(myR.DrugConvictionMilesID)

        Me.CommDUICountCB.SelectedValue = CStr(myR.CommDUICountID)
        Me.CommDUICountCB.Text = CStr(myR.CommDUICountID)
        Me.CommDUIMilesCB.SelectedValue = CStr(myR.CommDUIMilesID)
        Me.CommDUIMilesCB.Text = CStr(myR.CommDUIMilesID)

        Me.PersonalDUICountCB.SelectedValue = CStr(myR.PersonalDUICountID)
        Me.PersonalDUICountCB.Text = CStr(myR.PersonalDUICountID)
        Me.PersonalDUIMilesCB.SelectedValue = CStr(myR.PersonalDUIMilesID)
        Me.PersonalDUIMilesCB.Text = CStr(myR.PersonalDUIMilesID)

        Me.LongDescriptionRadEditor.Content = myR.LongDescription
        Me.LinksToJobPostingsRE.Content = myR.LinksToOtherPostings

        Me.LineHaulPercTB.Text = CStr(CDbl(Replace(CStr(myR.LineHaulPerc), "", "0")) * 100)
        Me.PayNotesRadEditor.Content = CStr(myR.PayNotes)

        If myR.PayTypeID <> 0 Then
            PayTypeRCB.SelectedValue = Convert.ToString(myR.PayTypeID)
        End If

        If myR.FuelReimbursed = True Then
            MiscUtils.FindControlRecursively(Me, "AllFuelRow").Visible = True
        Else
            MiscUtils.FindControlRecursively(Me, "AllFuelRow").Visible = False
        End If

        AdTemplateRB.SetSelectedToggleStateByValue(CStr(Convert.ToInt32(myR.AdTemplate)))

        s_Pref_Load()

        Dim myTabIndex As String = Me.Page.Request.QueryString("TabIndex")

        If String.IsNullOrEmpty(myTabIndex) Then
            myTabIndex = "0"
        End If

        If myTabIndex <> "0" Then

            EditCarrierRTS.SelectedIndex = CInt(myTabIndex)
            EditCarrierRMP.SelectedIndex = CInt(myTabIndex)

        End If

        s_Instructions()


        Dim myImageURL As String
        Dim myImageURL_Glow As String

        myImageURL = BaseApplicationPage.f_ImagePath("847")
        myImageURL_Glow = BaseApplicationPage.f_ImagePath("877")
        Me.DescVideoButton.Attributes.Add("src", myImageURL)
        Me.DescVideoButton.Attributes.Add("OnMouseOut", "src='" & myImageURL & "';")
        Me.DescVideoButton.Attributes.Add("OnMouseOver", "src='" & myImageURL_Glow & "';")
        Me.DescVideoButton.Attributes.Add("Width", "32px")
        Me.DescVideoButton.Attributes.Add("Height", "25px")

        Dim myHelpVideoPK As String = "572"
        myHelpVideoPK = DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myHelpVideoPK, String))
        Dim myURL As String = "../Dialogues/HelpVideo.aspx?Config=" & myHelpVideoPK
        Me.DescVideoButton.Attributes.Add("onclick", "return openVideo('" & myURL & "');")

        myImageURL = BaseApplicationPage.f_ImagePath("847")
        myImageURL_Glow = BaseApplicationPage.f_ImagePath("877")
        Me.AvgPayVideoButton.Attributes.Add("src", myImageURL)
        Me.AvgPayVideoButton.Attributes.Add("OnMouseOut", "src='" & myImageURL & "';")
        Me.AvgPayVideoButton.Attributes.Add("OnMouseOver", "src='" & myImageURL_Glow & "';")
        Me.AvgPayVideoButton.Attributes.Add("Width", "32px")
        Me.AvgPayVideoButton.Attributes.Add("Height", "25px")

        myHelpVideoPK = "573"
        myHelpVideoPK = DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myHelpVideoPK, String))
        myURL = "../Dialogues/HelpVideo.aspx?Config=" & myHelpVideoPK
        Me.AvgPayVideoButton.Attributes.Add("onclick", "return openVideo('" & myURL & "');")

        s_Thumbnail(myR)

    End Sub

    Public Sub s_Thumbnail(ByVal myR As CarrierAdRecord)

        Dim buffer() As Byte = Nothing

        If myR.MapThumbnail IsNot Nothing Then
            buffer = CType(myR.MapThumbnail, Byte())
        Else
            Dim myWhere As String = TreeTable.TreeID.UniqueName & " = 2620"
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
                ThumbnailRBI.DataValue = myFileAsArray
            End If
        End If

    End Sub

    Public Sub ThumbnailRB_Click() Handles ThumbnailRB.Click

        Try

            If ThumbnailRAU.UploadedFiles.Count > 0 Then

                'Get file as array.
                Dim myFile As UploadedFile = ThumbnailRAU.UploadedFiles(0)
                Dim myFileAsArray As Byte() = New Byte(CInt(myFile.InputStream.Length) - 1) {}
                myFile.InputStream.Read(myFileAsArray, 0, myFileAsArray.Length)

                'Show image on page.

                ThumbnailRBI.DataValue = myFileAsArray
                s_ThumbnailSave(myFileAsArray)

            End If

        Catch ex As Exception

            Dim myMessage As String = "WARNING: The system was unable to update your image.  If the problem continues, please contact support. Detailed error message: " & ex.Message
            Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

        End Try

    End Sub

    Public Sub s_ThumbnailSave(ByVal myFileAsArray As Byte())

        Try

            Dim myAdID As String = Me.HiddenTB_AdID.Text
            Dim myRec As New CarrierAdRecord

            DbUtils.StartTransaction()
            myRec = CarrierAdTable.GetRecord(myAdID, True)
            myRec.MapThumbnail = myFileAsArray
            myRec.Save()
            DbUtils.CommitTransaction()


        Catch ex As Exception

            Dim myMessage As String = "WARNING: The system was unable to update your image.  If the problem continues, please contact support. Detailed error message: " & ex.Message
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

        Finally

            DbUtils.EndTransaction()

        End Try

    End Sub

    Public Sub s_Instructions()

        Dim myWhere As String
        Dim myRec As FlowConfigRecord

        Dim myCtrl As Literal = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "InstructionsStandard"), Literal)

        If Not IsNothing(myCtrl) Then

            Dim myConfigID As String = myCtrl.Text

            If String.IsNullOrEmpty(myConfigID) = False Then

                myWhere = FlowConfigTable.ConfigID.UniqueName & " = " & myConfigID
                myRec = FlowConfigTable.GetRecord(myWhere)
                If Not IsNothing(myRec) Then
                    Me.InstructionsStandard.Text = Replace(myRec.Instructions, "It's", "It is")
                    MiscUtils.FindControlRecursively(Me, "InstructionsRow").Visible = True
                End If

            End If

        End If

        myCtrl = Nothing
        myRec = Nothing

        myCtrl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "InstructionsStandard2"), Literal)


        If Not IsNothing(myCtrl) Then

            Dim myConfigID As String = myCtrl.Text

            If String.IsNullOrEmpty(myConfigID) = False Then

                myWhere = FlowConfigTable.ConfigID.UniqueName & " = " & myConfigID
                myRec = FlowConfigTable.GetRecord(myWhere)
                If Not IsNothing(myRec) Then
                    Me.InstructionsStandard2.Text = Replace(myRec.Instructions, "It's", "It is")
                    MiscUtils.FindControlRecursively(Me, "InstructionsRow2").Visible = True
                End If

            End If

        End If

        myCtrl = Nothing
        myRec = Nothing

        myCtrl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "InstructionsStandard3"), Literal)

        If Not IsNothing(myCtrl) Then

            Dim myConfigID As String = myCtrl.Text

            If String.IsNullOrEmpty(myConfigID) = False Then

                myWhere = FlowConfigTable.ConfigID.UniqueName & " = " & myConfigID
                myRec = FlowConfigTable.GetRecord(myWhere)
                If Not IsNothing(myRec) Then
                    Me.InstructionsStandard3.Text = Replace(myRec.Instructions, "It's", "It is")
                    MiscUtils.FindControlRecursively(Me, "InstructionsRow3").Visible = True
                End If

            End If

        End If

        myCtrl = Nothing
        myRec = Nothing

        myCtrl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "InstructionsStandard4"), Literal)

        If Not IsNothing(myCtrl) Then

            Dim myConfigID As String = myCtrl.Text

            If String.IsNullOrEmpty(myConfigID) = False Then

                myWhere = FlowConfigTable.ConfigID.UniqueName & " = " & myConfigID
                myRec = FlowConfigTable.GetRecord(myWhere)
                If Not IsNothing(myRec) Then
                    Me.InstructionsStandard4.Text = Replace(myRec.Instructions, "It's", "It is")
                    MiscUtils.FindControlRecursively(Me, "InstructionsRow4").Visible = True
                End If

            End If

        End If

        myCtrl = Nothing
        myRec = Nothing

        myCtrl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "InstructionsStandard5"), Literal)

        If Not IsNothing(myCtrl) Then

            Dim myConfigID As String = myCtrl.Text

            If String.IsNullOrEmpty(myConfigID) = False Then

                myWhere = FlowConfigTable.ConfigID.UniqueName & " = " & myConfigID
                myRec = FlowConfigTable.GetRecord(myWhere)
                If Not IsNothing(myRec) Then
                    Me.InstructionsStandard5.Text = Replace(myRec.Instructions, "It's", "It is")
                    MiscUtils.FindControlRecursively(Me, "InstructionsRow5").Visible = True

                End If

            End If

        End If

    End Sub

    Public Sub UnselectAddrButton_Click(ByVal sender As Object, ByVal args As EventArgs)

        Dim PeopleRadGrid As RadGrid = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "PeopleRadGrid"), RadGrid)
        Dim TermRadGrid As RadGrid = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "TermRadGrid"), RadGrid)

        Me.HiddenTB_AddrID.Text = "0"
        PeopleRadGrid.Rebind()
        UnselectAddrButton.Visible = False

        For Each dataItem As GridDataItem In TermRadGrid.MasterTableView.Items
            dataItem.Selected = False
        Next

    End Sub

    Public Sub SaveRB_Click(ByVal sender As Object, ByVal args As EventArgs) Handles SaveRB.Click

        s_Save()
        s_SaveTerms()
        s_SavePeople()

        If Me.HiddenTB_MapModifyStatus.Text <> "Modified" Then
            ClientScript.RegisterStartupScript(Page.GetType(), "mykey", "ChildCloseAndRedirect('RebindJobs');", True)
        Else
            Dim myURL As String = "../Dialogues/MapImage.aspx?Ad=" & CustGenClass.f_Encrypt(Me.HiddenTB_AdID.Text)
            Response.Redirect(myURL)
        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.Page.IsPostBack = False Then
            Me.Authorize("NOT_ANONYMOUS") 'Security
            s_Vis()
        End If

    End Sub

End Class

