
Imports BaseClasses
Imports BaseClasses.Utils

Imports FASTPORT.UI
Imports FASTPORT.Business
Imports FASTPORT.Data

Imports Telerik.Web.UI

Partial Class Truckers
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
        Dim myReturn As String = "Nothing"
        Dim mySproc As String = "0"
        Dim myTab As String = "0"

        Dim myTopLeftLat As String = ""
        Dim myTopleftLong As String = ""
        Dim myBottomRightLat As String = ""
        Dim myBottomRightLong As String = ""
        Dim myPin As String = ""

        Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

        If myAction = "apply" Then

            myReturn = FlowBaseClass.f_ApplyURL(my1st, myUserID, my2nd)

        ElseIf myAction = "fastport" Then

            myReturn = "/Driver/FastportConfig.aspx?Party=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(my1st, String))

        ElseIf myAction = "openHelpVideo" Then

            Dim myConfigID As String = "571"
            myConfigID = DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myConfigID, String))
            myReturn = "../Dialogues/HelpVideo.aspx?Close=Yes&Config=" & myConfigID

        Else

            myReturn = "Nothing"

        End If

        Return myReturn

    End Function


    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest


        Dim myArg As String = e.Argument
        Dim myAction As String = CustGenClass.f_Split_ByComma(myArg, 1)
        Dim my1st As String = CustGenClass.f_Split_ByComma(myArg, 2)
        Dim my2nd As String = CustGenClass.f_Split_ByComma(myArg, 2)

        If myAction = "Redirect" Then

            Me.Response.Redirect(my1st)

        ElseIf myAction = "RefreshGrid" Or myAction = "RefreshApply" Then

            TruckersRadGrid.Rebind()

        End If

    End Sub

    Dim myEditButton As String = BaseApplicationPage.f_ImagePath("1917", , "~")
    Dim myEditButton_Glow As String = BaseApplicationPage.f_ImagePath("1917", , "~", "Glow")
    Dim myEditMouse_Out As String = f_ImagePath("1917")
    Dim myEditMouse_Over As String = f_ImagePath("1917", , , "Glow")

    Protected Sub TruckersRadGrid_ItemDataBound(ByVal sender As Object, ByVal e As GridItemEventArgs)

        If TypeOf e.Item Is GridDataItem Then

            Dim item As GridDataItem = DirectCast(e.Item, GridDataItem)
            Dim myFlowStepID As String = item.GetDataKeyValue("FlowStepID").ToString

            Dim myButtonTip As String = Nothing
            Dim myButtonPath As String = Nothing
            Dim myButtonOver As String = Nothing
            Dim myButton As ImageButton = DirectCast(item("EditButton").Controls(0), ImageButton)


            '***********************************
            'WARNING: Be careful if changing the tooltip text, because it drives the IF statement in TruckersRadGrid_ItemCommand.
            '***********************************

            If myFlowStepID <> "278" And myFlowStepID <> "279" And myFlowStepID <> "285" And myFlowStepID <> "281" And myFlowStepID <> "313" Then

                myButtonTip = "Click to edit this trucker's FASTPORT."

                myButton.ImageUrl = myEditButton
                myButton.ToolTip = myButtonTip

                myButton.Attributes.Add("OnMouseOut", "this.src='" & myEditMouse_Out & "';")
                myButton.Attributes.Add("OnMouseOver", "this.src='" & myEditMouse_Over & "';")

            Else

                myButton.Visible = False

            End If

        End If

    End Sub

    Protected Sub TruckersRadGrid_ItemCommand(ByVal sender As Object, ByVal e As GridCommandEventArgs) Handles TruckersRadGrid.ItemCommand

        Dim item As GridDataItem = DirectCast(e.Item, GridDataItem)
        Dim myPartyID As String = item.GetDataKeyValue("PartyID").ToString

        Dim myButton As ImageButton = DirectCast(e.CommandSource, ImageButton)
        Dim myButtonName As String = myButton.UniqueID
        Dim myTip As String = myButton.ToolTip
        Dim myURL As String = ""

        If myTip = "Click to edit this trucker's FASTPORT." Then

            myURL = "../Driver/FastportConfig.aspx?Party=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myPartyID, String))
            Me.Response.Redirect(myURL)

        End If

    End Sub

    Public Sub s_Vis()

        Me.Authorize("NOT_ANONYMOUS")

        'CarrierRCB.Items.Add(New RadComboBoxItem("All Carriers", "0"))
        'CarrierRCB.SelectedValue = "0"
        'CarrierRCB.Text = "All Carriers"

        InProgressRCB.SelectedValue = "1"
        InProgressRCB.Text = "In Progress"

    End Sub



    Public Sub Page_PreRender() Handles Me.PreRender

        If Page.IsPostBack = False Then
            s_Vis()
        End If

    End Sub
End Class
