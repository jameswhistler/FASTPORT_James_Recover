Imports BaseClasses
Imports BaseClasses.Utils

Imports FASTPORT.UI
Imports FASTPORT.Business
Imports FASTPORT.Data

Imports Telerik.Web.UI
Imports System.Data.SqlClient

Partial Class MapImage
    Inherits System.Web.UI.Page
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

        Dim myReturn As String = "Nothing"

        If myAction = "LoadGeoData" Then

            myReturn = CustGenClass.f_Sproc("usp_GeoJson_ForLanes", my1st) & "<|>" & _
                        CustGenClass.f_Sproc("usp_GeoJson_ForRegions", my1st) & "<|>" & CustGenClass.f_Sproc("usp_GeoJson_Circles", my1st)

        ElseIf myAction = "SaveThumbnail" Then

            s_SaveThumbnail(my1st)

        End If
        Return myReturn

    End Function

    Public Sub s_SaveThumbnail(ByVal Base64String As String)

        Try

            DbUtils.StartTransaction()
            Dim AdID As String = Me.HiddenTB_AdID.Text
            Dim myRec As New CarrierAdRecord
            myRec = CarrierAdTable.GetRecord(AdID, True)

            Dim percentResize As Double = (1 - (350 / 800))
            Dim OutputRBIValue As Byte() = System.Convert.FromBase64String(Base64String)

            Dim OutputRBINewValue As Byte() = CustGenClass.f_ResizeImage(OutputRBIValue, percentResize)

            myRec.MapThumbnail = OutputRBINewValue
            myRec.Save()
            DbUtils.CommitTransaction()

        Catch ex As Exception

            Dim myMessage As String = "WARNING: The system was unable to update your image.  If the problem continues, please contact support. Detailed error message: " & ex.Message
            DbUtils.RollBackTransaction()
            Utils.MiscUtils.RegisterJScriptAlert(Me, "UNIQUE_SCRIPTKEY", ex.Message)

        Finally

            DbUtils.EndTransaction()

        End Try

    End Sub

    Public Sub s_Vis()

        Dim myAdID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Ad"))

        If String.IsNullOrEmpty(myAdID) = False Then
            Me.HiddenTB_AdID.Text = myAdID
        End If

    End Sub

    Public Sub Page_PreRender() Handles Me.PreRender

        If Page.IsPostBack = False Then
            s_Vis()
        End If

    End Sub
End Class
