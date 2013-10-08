Imports BaseClasses
Imports BaseClasses.Utils

Imports FASTPORT.UI
Imports FASTPORT.Business
Imports FASTPORT.Data

Imports Telerik.Web.UI

Partial Class UploadDoc
    Inherits FASTPORT.UI.BaseApplicationPage

    Protected Sub s_Vis_PreRender()

        Dim myHiddenTB_PageTitle As TextBox = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "HiddenTB_PageTitle"), TextBox)

        If Not IsNothing(myHiddenTB_PageTitle) Then
            Dim myPageTitle As String
            Dim myDocID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Doc"))
            If Not String.IsNullOrEmpty(myDocID) Then
                myPageTitle = CustGenClass.f_Sproc("usp_DocName", myDocID)
            Else
                Dim myDocTreeID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("FiledAs"))
                myPageTitle = CustGenClass.f_Sproc("usp_DocTreeName", myDocTreeID)
            End If
            myHiddenTB_PageTitle.Text = myPageTitle
        End If

    End Sub



    Public Function s_SaveDoc(Optional ByVal myBarCodesYesNo As String = "No") As String

        'DOC -- Hard Code
        Dim myPartyID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Party"))
        Dim myFiledAsID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("FiledAs"))
        Dim myDocID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Doc"))

        Dim fileName As String = Nothing

        If RadAsyncUpload1.UploadedFiles.Count > 0 Then
            For Each file As UploadedFile In RadAsyncUpload1.UploadedFiles
               
                fileName = file.FileName

                If Not String.IsNullOrEmpty(fileName) Then

                    Dim fileData As Byte() = Nothing
                    Using binaryReader As System.IO.BinaryReader = New System.IO.BinaryReader(file.InputStream)
                        fileData = binaryReader.ReadBytes(CInt(file.InputStream.Length))
                    End Using

                    Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

                    If String.IsNullOrEmpty(myDocID) Or myDocID = "134" Or myDocID = "133" Then
                        Dim myCIX As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("CIX"))
                        If myCIX = "0" Or String.IsNullOrEmpty(myCIX) Then
                            Dim myMeID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()
                            Dim myTruckerYesNo As String = CustGenClass.f_Sproc("usp_IsMyRole_FromList", myMeID, "18")
                            If myTruckerYesNo = "Yes" Then
                                myCIX = myMeID
                            Else
                                myCIX = CType(HttpContext.Current.Session("ParentPartyID"), String)
                            End If
                        End If
                        Dim myDocPartyID As String = myPartyID
                        If String.IsNullOrEmpty(myFiledAsID) Then
                            myFiledAsID = myDocID
                        End If
                        If myFiledAsID = "134" Then
                            myDocPartyID = myUserID
                        End If
                        myDocID = CustGenClass.f_Sproc("usp_DocAdd", myCIX, fileName, myDocPartyID, myUserID, myFiledAsID)
                    End If

                    If ProcessBarCodesRB.SelectedToggleStateIndex = 0 Then
                        myBarCodesYesNo = "Yes"
                    End If

                    If myBarCodesYesNo = "No" Then
                        CustGenClass.s_Doc_Upload(fileData, myDocID, fileName, myUserID)
                    Else
                        Dim myCodeList As List(Of String) = CustGenClass.f_Doc_Inbound(fileData, , myUserID, , fileName, myDocID)
                        If Not IsNothing(myCodeList) Then
                            For Each myResult As String In myCodeList
                                Dim myType As String = CustGenClass.f_Split_ByComma(myResult, 1)
                                Dim myPK As String = CustGenClass.f_Split_ByComma(myResult, 2)
                                If myType = "AE" Or myType = "AA" Then
                                    Dim myNewFlowID As String = CustGenClass.f_Sproc("usp_FlowMove_FromReturnedDoc", myType, myPK)
                                    CustGenClass.s_Execution_SendMessage(myPK, myNewFlowID)
                                End If
                            Next
                        End If
                    End If

                End If

            Next

        End If

        CustGenClass.f_Sproc("usp_DocProgress_Calc_FromApp", myPartyID)

        Return myDocID

    End Function

    Public Sub UploadDocRB_Click() Handles UploadDocRB.Click

        Dim myDocID As String = s_SaveDoc()
        Dim myCompleteStatus As String = CustGenClass.f_Sproc("usp_DocDetails", myDocID)

        Dim myFiledAsID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("Doc"))
        If String.IsNullOrEmpty(myFiledAsID) Then
            myFiledAsID = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("DocNode"))
        End If
        If myFiledAsID = "133" Or myFiledAsID = "134" Then
            myDocID = myFiledAsID
            myCompleteStatus = "Hide"
        End If

        ClientScript.RegisterStartupScript(Page.GetType(), "mykey", "ChildCloseAndRedirect('rebindDocRTV," & myDocID & "," & myCompleteStatus & "');", True)
    End Sub

    Protected Sub Page_PreRender() Handles Me.PreRender

        If Me.Page.IsPostBack = False Then
            s_Vis_PreRender()
        End If

    End Sub

End Class
