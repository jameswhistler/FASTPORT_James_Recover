Imports BaseClasses
Imports BaseClasses.Utils

Imports FASTPORT.UI
Imports FASTPORT.Business
Imports FASTPORT.Data

Imports Telerik.Web.UI
Imports System.Data.SqlClient

Partial Class TelerikWebForm1
    Inherits BaseApplicationPage
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
        Dim myReturn As String = Nothing

        If myAction = "OpenRadWindowDialogue" Then

            myReturn = "../CarrierAd/EditCarrierAd.aspx?Ad=" & CustGenClass.f_Encrypt(my1st) & "&Close=Yes&Party=" & CustGenClass.f_Encrypt(my2nd)

        ElseIf myAction = "CarrierAdd" Then

            myReturn = "../Carrier/AddCarrier.aspx?Close=Yes&Action=AdminAdd"

        ElseIf myAction = "CarrierEdit" Then
            
            myReturn = "../Carrier/EditCarrier.aspx?Close=Yes&Action=FromManageAds&Party=" & CustGenClass.f_Encrypt(my1st)

        ElseIf myAction = "onPostingAddRBClicked" Then

            Dim myW As String = PartyCarrierTable.PartyID.UniqueName & " = " & my1st
            Dim myR As PartyCarrierRecord = PartyCarrierTable.GetRecord(myW)
            Dim myAdID As String = f_AddAd(CStr(myR.CarrierID))
            myAdID = DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myAdID, String))
            myReturn = "../CarrierAd/EditCarrierAd.aspx?Ad=" & myAdID & "&Close=Yes&Party=" & CustGenClass.f_Encrypt(my1st) & "&callback=?"

        End If

        Return myReturn

    End Function


    Private Function f_AddAd(ByVal myCarrierID As String) As String


        Try
            'Enclose all database retrieval/update code within a Transaction boundary

            DbUtils.StartTransaction()
            Dim myRec As New CarrierAdRecord
            myRec.CarrierID = CInt(myCarrierID)

            Dim myLinkRec As New CarrierAdLinkRecord
            myLinkRec.AdID = myRec.AdID
            myLinkRec.LinkName = "Default Posting Link"

            myRec.Save()
            DbUtils.CommitTransaction()

            Dim myNewAdID As String = CStr(myRec.AdID)
            CustGenClass.s_SetVariables(myNewAdID)

        Catch ex As Exception
            ' Upon error, rollback the transaction
            DbUtils.RollBackTransaction()
            ' Report the error message to the end user
            Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
        Finally
            DbUtils.EndTransaction()
        End Try

        Return CustGenClass.f_GetVariable("myVar1")

    End Function

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest

        Dim myArg As String = e.Argument

        If myArg = "RebindJobs" Then

            CarrierAdsRG.Rebind()

        End If

    End Sub

    Public Sub s_Vis()

        Me.Authorize("NOT_ANONYMOUS")

        Dim myMeID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()
        Dim myHaveRole As String = CustGenClass.f_Sproc("usp_IsMyRole_FromList", myMeID, "20")

        If myHaveRole <> "Yes" Then
            PartiesRCB.Visible = True
            PickCarrierRSB.Visible = False
        Else
            PartiesRCB.Visible = False
            PickCarrierRSB.Visible = True
        End If

    End Sub

    Public Sub Page_PreRender() Handles Me.PreRender

        s_Vis()

        If Page.IsPostBack = False Then
            PartiesRCB.DataBind()
            CarrierAdsRG.DataBind()
        End If

    End Sub

End Class
