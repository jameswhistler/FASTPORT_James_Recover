
#Region "Imports statements"

Option Strict On
Imports System
Imports System.Data
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel

Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports BaseClasses
Imports BaseClasses.Utils
Imports BaseClasses.Utils.StringUtils
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports BaseClasses.Data.OrderByItem.OrderDir
Imports BaseClasses.Data.BaseFilter
Imports BaseClasses.Data.BaseFilter.ComparisonOperator
Imports BaseClasses.Web.UI.WebControls

Imports FASTPORT.Business
Imports FASTPORT.Data


#End Region

Namespace FASTPORT.UI

    Partial Public Class PDFFull
        Inherits BaseApplicationPage

        Public Sub s_Vis()

            Dim myDocID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Doc"))
            If myDocID <> "0" Then
                Dim myPDFByte As Byte() = CustGenClass.f_DocToPdf(myDocID)
                Dim myDocName As String = Me.Page.Request.QueryString("DocName")

                Try
                    Response.Buffer = True
                    Response.Clear()
                    Response.ClearContent()
                    Response.ClearHeaders()
                    Response.ContentType = "application/pdf"
                    Response.AddHeader("Content-Disposition", "inline;filename=" & myDocName & ".pdf")
                    'Response.BinaryWrite(myPDFByte)
                    Response.OutputStream.Write(myPDFByte, 0, myPDFByte.Length)
                    Response.Flush()
                    Response.End()
                Catch ex As Exception
                    Response.Write(ex.StackTrace.ToString())
                End Try
            Else

                Dim mySenderID As String = Me.Page.Request.QueryString("Sender")
                Dim myRecipientID As String = Me.Page.Request.QueryString("Recipient")
                Dim myMeID As String = Me.Page.Request.QueryString("User")
                Dim myPruneID As String = Me.Page.Request.QueryString("Prune")
                Dim data As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_DocsToPrint", mySenderID, myRecipientID, myMeID, myPruneID)
                Dim myPDF As Aspose.Pdf.Document = New Aspose.Pdf.Document
                Dim endOffset As Integer = data.Rows.Count
                Dim i As Integer = 0
                While i < endOffset

                    Dim myFolderDocID As String = data.Rows(i)("DocID").ToString
                    Dim myPDFByte As Byte() = CustGenClass.f_DocToPdf(myFolderDocID)
                    Dim fs As System.IO.MemoryStream = New System.IO.MemoryStream(myPDFByte)
                    If i = 0 Then
                        myPDF = New Aspose.Pdf.Document(fs)
                    Else
                        Dim myNewPdf As Aspose.Pdf.Document = New Aspose.Pdf.Document(fs)
                        myPDF = CustGenClass.f_PDFConcatenate(myPDF, myNewPdf)
                    End If
                    i = i + 1
                End While

                Dim pdfMS As New System.IO.MemoryStream()
                myPDF.Save(pdfMS)
                Dim myPDFByteArray As Byte() = pdfMS.ToArray()

                Try
                    Response.Buffer = True
                    Response.Clear()
                    Response.ClearContent()
                    Response.ClearHeaders()
                    Response.ContentType = "application/pdf"
                    Response.AddHeader("Content-Disposition", "inline;filename=ViewFolder")
                    'Response.BinaryWrite(myPDFByteArray)
                    Response.OutputStream.Write(myPDFByteArray, 0, myPDFByteArray.Length)
                    Response.Flush()
                    Response.End()
                Catch ex As Exception
                    Response.Write(ex.StackTrace.ToString())
                End Try
            End If

        End Sub
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            s_Vis()

        End Sub

    End Class

End Namespace