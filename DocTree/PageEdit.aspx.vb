Imports Telerik.Web.UI

Imports BaseClasses
Imports BaseClasses.Utils

Imports FASTPORT.Business
Imports FASTPORT.Data
Imports FASTPORT.UI

Imports System.Drawing
Imports System.IO

Partial Class PageEdit
    Inherits System.Web.UI.Page

    Private Sub DocIE_ImageLoading(ByVal sender As Object, ByVal args As ImageEditorLoadingEventArgs) Handles DocIE.ImageLoading

        Dim myPageID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Page"))
        Me.HiddenTB_PageID.Text = myPageID

        Dim myW As String = DocPageTable.PageID.UniqueName & " = " & myPageID
        Dim myR As DocPageRecord = DocPageTable.GetRecord(myW)

        'Load the image editor here, from the record control.  Other examples exists, like when we load the RadBinaryImage on the fastport page (before we removed it).  Get a code sample from there.
        Dim DocImageEditor As RadImageEditor = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "DocIE"), RadImageEditor)
        Dim DocImage As Byte() = CType(myR.DocFile, Byte())

        'If DocImage IsNot Nothing Then
        Dim newStream As New System.IO.MemoryStream(DocImage)
        Dim img As New Telerik.Web.UI.ImageEditor.EditableImage(newStream)
        args.Image = img

        args.Cancel = True
        'End If

    End Sub

    Public Sub DocIE_ImageSaving(ByVal sender As Object, ByVal args As ImageEditorSavingEventArgs)
        Dim myPageID As String = Me.HiddenTB_PageID.Text
        Dim myW As String = DocPageTable.PageID.UniqueName & " = " & myPageID
        Dim myR As DocPageRecord = DocPageTable.GetRecord(myW)
        Dim myDocID As String = CType(myR.DocID, String)
        Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

        Dim img As Telerik.Web.UI.ImageEditor.EditableImage = args.Image
        Dim newStream As New System.IO.MemoryStream()
        img.Image.Save(newStream, img.RawFormat)
        Dim myImage As Byte() = newStream.ToArray()

        CustGenClass.s_ModifyJpg(myImage, myDocID, myUserID)
        newStream.Close()
        args.Image.Dispose()
        args.Cancel = True
    End Sub

    Public Shared Function f_ResizeImage(ByVal imgByte As Byte(), ByVal percentResize As Double) As Byte()

        Dim myCurrentBmp As New Bitmap(New System.IO.MemoryStream(imgByte))

        Dim width As Integer = Convert.ToInt32(myCurrentBmp.Width - (myCurrentBmp.Width * percentResize))
        Dim height As Integer = Convert.ToInt32(myCurrentBmp.Height - (myCurrentBmp.Height * percentResize))

        Dim myHolderBmp As New Bitmap(width, height)
        Dim g As Graphics = Graphics.FromImage(myHolderBmp)
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.DrawImage(myCurrentBmp, New Rectangle(0, 0, width, height), New Rectangle(0, 0, myCurrentBmp.Width, myCurrentBmp.Height), GraphicsUnit.Pixel)
        g.Dispose()
        myCurrentBmp.Dispose()

        Dim myBmpOutMS As MemoryStream = New System.IO.MemoryStream()
        myHolderBmp.Save(myBmpOutMS, System.Drawing.Imaging.ImageFormat.Bmp) 'can use any image format 
        myHolderBmp.Dispose()

        Return myBmpOutMS.ToArray()

    End Function
End Class
