Imports BaseClasses
Imports BaseClasses.Utils

Imports FASTPORT.UI
Imports FASTPORT.Business
Imports FASTPORT.Data

Imports Telerik.Web.UI

Partial Class CarrierSnapshot
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
        Dim my4th As String = CustGenClass.f_Split_ByComma(myArgs, 5)

        Dim myReturn As String = "Nothing"
        Dim myMeID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

        Dim myPosLat As String = Me.HiddenTB_PosLat.Text
        Dim myPosLong As String = Me.HiddenTB_PosLong.Text

        If myAction = "SaveExp" Then
            myReturn = CustGenClass.f_Sproc("usp_ExpThumbsUpdate", myMeID, my1st, my2nd, my3rd, my4th, "No", myPosLat, myPosLong)
        ElseIf myAction = "SaveReq" Then
            myReturn = CustGenClass.f_Sproc("usp_ExpThumbsUpdate", myMeID, my1st, my2nd, my3rd, my4th, "Yes", myPosLat, myPosLong)
        ElseIf myAction = "SaveReviews" Then
            If my1st = "Carrier" Then
                myReturn = CustGenClass.f_Sproc("usp_CheckIn_Add", my2nd, myMeID, my3rd, "0", myPosLat, myPosLong)
            ElseIf my1st = "Ad" Then
                myReturn = CustGenClass.f_Sproc("usp_CheckIn_Add", my2nd, myMeID, "0", my3rd, myPosLat, myPosLong)
            Else
                myReturn = CustGenClass.f_Sproc("usp_CheckIn_Add", my2nd, myMeID, "0", my3rd, myPosLat, myPosLong)
            End If
        ElseIf myAction = "SaveIncidents" Then
            myReturn = CustGenClass.f_Sproc("usp_CheckIn_Add", my2nd, myMeID, "0", my3rd, myPosLat, myPosLong)
        End If

        Return myReturn

    End Function

    Public Sub GridItemDataBound(ByVal sender As Object, ByVal e As GridItemEventArgs)

        If TypeOf e.Item Is GridDataItem Then
            Dim dataItem As GridDataItem = DirectCast(e.Item, GridDataItem)
            Dim myThumbs As Integer = CInt(dataItem.GetDataKeyValue("Thumbs").ToString)
            Dim ThumbsUpRB As RadButton = CType(dataItem("ThumbsUpColumn").Controls(1), RadButton)
            ThumbsUpRB.SelectedToggleStateIndex = myThumbs
        End If

    End Sub

    Public Sub ReqGridItemDataBound(ByVal sender As Object, ByVal e As GridItemEventArgs) Handles AdReqRG.ItemDataBound

        If TypeOf e.Item Is GridDataItem Then
            Dim dataItem As GridDataItem = DirectCast(e.Item, GridDataItem)
            Dim myThumbs As Integer = CInt(dataItem.GetDataKeyValue("YearStatus").ToString)
            Dim ThumbsUpRB As RadButton = CType(dataItem("ThumbsUpColumn").Controls(1), RadButton)
            ThumbsUpRB.SelectedToggleStateIndex = myThumbs
        End If

    End Sub

    Public Sub IncidentGridItemDataBound(ByVal sender As Object, ByVal e As GridItemEventArgs) Handles AdIncidentsRG.ItemDataBound

        If TypeOf e.Item Is GridDataItem Then
            Dim dataItem As GridDataItem = DirectCast(e.Item, GridDataItem)
            Dim myThumbs As Integer = CInt(dataItem.GetDataKeyValue("CheckStatus").ToString)
            Dim ThumbsUpRB As RadButton = CType(dataItem("ThumbsUpColumn").Controls(1), RadButton)
            ThumbsUpRB.SelectedToggleStateIndex = myThumbs
        End If

    End Sub

    Public Sub s_Vis()

        Dim myMeID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()
        Dim myPartyID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Party"))
        Dim myAdID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Ad"))
        Dim myHaveRole As String = CustGenClass.f_Sproc("usp_Role_HighLevel", myMeID)
        Dim myPosLat As String = Me.Page.Request.QueryString("Lat")
        Dim myPosLong As String = Me.Page.Request.QueryString("Long")

        If String.IsNullOrEmpty(myPosLat) = False Then
            Me.HiddenTB_PosLat.Text = myPosLat
        Else
            myPosLat = "0"
        End If

        If String.IsNullOrEmpty(myPosLong) = False Then
            Me.HiddenTB_PosLong.Text = myPosLong
        Else
            myPosLong = "0"
        End If

        If myHaveRole = "Trucker" Then
            Dim mySproc As String = CustGenClass.f_Sproc("usp_CheckIn_AutoThumb", myMeID, myAdID, myPosLat, myPosLong)
        End If

        Me.HiddenTB_AdID.Text = myAdID

        Dim myWhere As String = PartyCarrierTable.PartyID.UniqueName & " = " & myPartyID
        Dim myRec As PartyCarrierRecord = PartyCarrierTable.GetRecord(myWhere)
        Dim myCarrierID As String = CStr(myRec.CarrierID)
        Page.Title = myRec.CarrierFullName
        Me.HiddenTB_PartyID.Text = myPartyID
        Me.HiddenTB_CarrierID.Text = myCarrierID

        Dim myCarrierThumb As String = CustGenClass.f_Sproc("usp_CheckIn_Status", "Thumbs", myMeID, myPartyID, "0")
        CarrierThumbsRB.SetSelectedToggleStateByValue(myCarrierThumb)
        Dim myCarrierFavorite As String = CustGenClass.f_Sproc("usp_CheckIn_Status", "Favorite", myMeID, myPartyID, "0")
        CarrierFavoriteRB.SetSelectedToggleStateByValue(myCarrierFavorite)
        Dim myCarrierHide As String = CustGenClass.f_Sproc("usp_CheckIn_Status", "Hide", myMeID, myPartyID, "0")
        CarrierHideRB.SetSelectedToggleStateByValue(myCarrierHide)

        Dim myAdThumb As String = CustGenClass.f_Sproc("usp_CheckIn_Status", "Thumbs", myMeID, "0", myAdID)
        AdThumbsRB.SetSelectedToggleStateByValue(myAdThumb)
        Dim myAdFavorite As String = CustGenClass.f_Sproc("usp_CheckIn_Status", "Favorite", myMeID, "0", myAdID)
        AdFavoriteRB.SetSelectedToggleStateByValue(myAdFavorite)
        Dim myAdHide As String = CustGenClass.f_Sproc("usp_CheckIn_Status", "Hide", myMeID, "0", myAdID)
        AdHideRB.SetSelectedToggleStateByValue(myAdHide)

        Dim myPayThumb As String = CustGenClass.f_Sproc("usp_CheckIn_Status", "Thumbs$", myMeID, "0", myAdID)
        PayThumbsRB.SetSelectedToggleStateByValue(myPayThumb)

        If String.IsNullOrEmpty(myAdID) Then

            RadTabStrip1.Tabs(0).Visible = False
            RadMultiPage1.PageViews(0).Visible = False
            RadTabStrip1.Tabs(1).Selected = True
            RadMultiPage1.PageViews(1).Selected = True

        Else

            RadTabStrip1.Tabs(0).Visible = True
            RadMultiPage1.PageViews(0).Visible = True

            s_LoadLogo()

            Dim myW As String = V_AdDetailsView.AdID.UniqueName & " = " & myAdID
            Dim myAdR As V_AdDetailsRecord = V_AdDetailsView.GetRecord(myW)

            Me.AdSummaryLiteral.Text = myAdR.AdHTML
            Me.AdPayLiteral.Text = myAdR.PayHTML
            Me.AdDetailsLiteral.Text = myAdR.LongDescription
            'Me.AdReqDetailsLiteral.Text = myAdR.Requirements

            Dim myCarrierW As String = V_CarrierSimpleView.CarrierID.UniqueName & " = " & myCarrierID
            Dim myCarrierR As V_CarrierSimpleRecord = V_CarrierSimpleView.GetRecord(myCarrierW)

            Me.CarrierDetailsLiteral.Text = myCarrierR.CarrierHTML

            Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

            Dim myProbs As String = CustGenClass.f_Sproc("usp_AdWarningOut", myAdID, myUserID, "<br /><br />")

            If myProbs <> "0" And Not String.IsNullOrEmpty(myProbs) Then

                myProbs = "<strong><span style=""text-decoration: underline; color: #ff0000;"">Requirements Not Met</span></strong><br /><br />" & myProbs
                Me.AdReqProblemsLiteral.Text = myProbs

            End If

        End If

    End Sub

    Public Sub s_LoadLogo()

        Dim myLogoRBI As RadBinaryImage = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "LogoRBI"), RadBinaryImage)
        Dim buffer() As Byte = Nothing

        Dim myPartyWhere As String = PartyTable.PartyID.UniqueName & " = " & CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Party"))
        Dim myPartyRec As PartyRecord = PartyTable.GetRecord(myPartyWhere)

        If myPartyRec.Logo IsNot Nothing Then
            buffer = CType(myPartyRec.Logo, Byte())
        End If

        If buffer IsNot Nothing Then
            Dim newStream As New System.IO.MemoryStream(buffer)
            Dim myFileAsArray As Byte() = New Byte(CInt(newStream.Length) - 1) {}
            newStream.Read(myFileAsArray, 0, myFileAsArray.Length)

            If myFileAsArray IsNot Nothing Then
                myLogoRBI.DataValue = myFileAsArray
            End If
        End If

    End Sub

    Protected Overridable Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Authorize("NOT_ANONYMOUS")

        s_Vis()

    End Sub

End Class
