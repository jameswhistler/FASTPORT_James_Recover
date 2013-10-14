' *
' * Bluepay 2.0 .NET Sample code.
' *
' * Developed by Joel Tosi and Chris Jansen of Bluepay.
' *
' * This code is Free.  You may use it, modify it and redistribute it.
' * If you do make modifications that are useful, Bluepay would love it if you donated
' * them back to us!
' *
' *
' *
 
Imports System
Imports System.Text
Imports System.Security.Cryptography
Imports System.Net
Imports System.IO
Imports System.Web
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography.X509Certificates
Imports System.Collections
Namespace BluePay2
    ''' <summary>
    ''' This is the BluePay2 API COM object.
    ''' </summary>
    Public Class BluePay2API

        'required for every transaction
        Public BPMerchant As String = ""
        Public BPURL As String = ""
        Public BPKey As String = ""
        Public BPMode As String = ""
        Public BPDebug As String = ""

        'required for auth or sale
        Public BPCCNum As String = ""
        Public BPCVV2 As String = ""
        Public BPExpire As String = ""
        Public BPName As String = ""
        Public BPAddr1 As String = ""
        Public BPCity As String = ""
        Public BPState As String = ""
        Public BPZip As String = ""

        'optional for auth or sale
        Public BPAddr2 As String = ""
        Public BPComment As String = ""
        Public BPPhone As String = ""
        Public BPEmail As String = ""

        'transaction variables
        Public BPAmount As String = ""
        Public BPTransaction_Type As String = ""
        Public BPAVS_Allowed As String = ""
        Public BPCVV2_Allowed As String = ""
        Public BPAutocap As String = ""
        Public BPRRNO As String = ""

        'rebill variables
        Public BPRebilling As String = ""
        Public BPReb_Amount As String = ""
        Public BPReb_First_Date As String = ""
        Public BPReb_Expr As String = ""
        Public BPReb_Cycles As String = ""

        'level2 variables
        Public BPOrder_ID As String = ""
        Public BPInvoice_ID As String = ""
        Public BPAmount_Tip As String = ""
        Public BPAmount_Tax As String = ""
        Public BPTPS As String = ""
        Public BPheaderstring As String = ""

        'variables for ach storage
        Public PAYMENT_TYPE As String = "CREDIT"
        Public ACH_ACCOUNT_TYPE As String = ""
        Public ACH_ROUTING As String = ""
        Public ACH_ACCOUNT As String = ""
        Public DOC_TYPE As String = "WEB"
        Public IS_CORPORATE As String = "0"
        Public COMPANY_NAME As String = ""

        'f&b variables
        Public BPAmount_Food As String = ""
        Public BPAmount_Misc As String = ""

        Public Function BluePay2API(ByVal Merchant As String, ByVal URL As String, ByVal Secret_key As String, ByVal Mode As String)
            'initialisation code 
            BPMerchant = Merchant
            BPURL = URL
            BPKey = Secret_key
            BPMode = Mode
        End Function

        Public Sub New(ByVal Merchant As String, ByVal URL As String, ByVal Secret_key As String, ByVal Mode As String)
            Me.New(Merchant, URL, Secret_key, Mode, "0")
        End Sub

        Public Sub New(ByVal Merchant As String, ByVal URL As String, ByVal Secret_key As String, ByVal Mode As String, ByVal Debug As String)
            BPMerchant = Merchant
            BPURL = URL
            BPKey = Secret_key
            BPMode = Mode
            BPDebug = Debug
        End Sub

        Public Sub Set_Cust_Required(ByVal CCNum As String, ByVal CVV2 As String, ByVal Expire As String, ByVal Name As String, ByVal Addr1 As String, ByVal City As String, ByVal State As String, ByVal Zip As String)
            BPCCNum = CCNum
            BPCVV2 = CVV2
            BPExpire = Expire
            BPName = Name
            BPAddr1 = Addr1
            BPCity = City
            BPState = State
            BPZip = Zip
        End Sub

        Public Sub Set_ACH_Required(ByVal i_account As String, ByVal i_routing As String, ByVal i_name As String, ByVal i_addr1 As String, ByVal i_city As String, ByVal i_state As String, ByVal i_zip As String, ByVal i_phone As String)
            PAYMENT_TYPE = "ACH"
            ACH_ACCOUNT_TYPE = "C"
            ACH_ROUTING = i_routing
            ACH_ACCOUNT = i_account
            DOC_TYPE = "WEB"
            BPName = i_name
            BPAddr1 = i_addr1
            BPCity = i_city
            BPState = i_state
            BPZip = i_zip
            BPPhone = i_phone
        End Sub

        ' use savings account instead of checking.
        Public Sub Set_ACH_Savings()
            ACH_ACCOUNT_TYPE = "S"
        End Sub

        Public Sub Set_Doc_Type(ByVal i_doc_type As String)
            DOC_TYPE = i_doc_type
        End Sub

        Public Sub Set_Corporate_Charge(ByVal i_company_name As String)
            IS_CORPORATE = "1"
            COMPANY_NAME = i_company_name
        End Sub

        Public Sub Easy_Sale(ByVal Amount As String)
            BPAmount = Amount
            BPTransaction_Type = "SALE"
        End Sub

        Public Sub Easy_Auth(ByVal Amount As String)
            BPAmount = Amount
            BPTransaction_Type = "AUTH"
        End Sub

        Public Sub Easy_Add_Rebill(ByVal Reb_Amount As String, ByVal Reb_First_Date As String, ByVal Reb_Expr As String, ByVal Reb_Cycles As String)
            'need to put logic in to confirm that trans_type is a sale,auth,or capture. if not then throw execption.
            BPRebilling = "1"
            BPReb_Amount = Reb_Amount
            BPReb_First_Date = Reb_First_Date
            BPReb_Expr = Reb_Expr
            BPReb_Cycles = Reb_Cycles
        End Sub

        Public Sub Easy_Add_AVS_Proofing(ByVal AVS_Allowed As String)
            'Need to make sure that trans_type is auth
            BPAVS_Allowed = AVS_Allowed
        End Sub

        Public Sub Easy_Add_CVV2_Proofing(ByVal CVV2_Allowed As String)
            'Need to make sure that trans_type is auth
            BPCVV2_Allowed = CVV2_Allowed
        End Sub

        Public Sub Easy_Add_Autocap()
            BPAutocap = "1"
        End Sub

        Public Sub Easy_Refund(ByVal RRNO As String)
            BPTransaction_Type = "REFUND"
            BPRRNO = RRNO
        End Sub

        Public Sub Easy_Rebcancel(ByVal RRNO As String)
            BPTransaction_Type = "REBCANCEL"
            BPRRNO = RRNO
        End Sub

        Public Sub Easy_Capture(ByVal RRNO As String)
            BPTransaction_Type = "CAPTURE"
            BPRRNO = RRNO
        End Sub

        Public Sub Set_Order_ID(ByVal Order_ID As String)
            BPOrder_ID = Order_ID
        End Sub

        Public Sub Set_Level2(ByVal Order_ID As String, ByVal Invoice_ID As String, ByVal Amount_Tip As String, ByVal Amount_Tax As String)
            BPOrder_ID = Order_ID
            BPInvoice_ID = Invoice_ID
            BPAmount_Tip = Amount_Tip
            BPAmount_Tax = Amount_Tax
        End Sub

        Public Sub Set_FnB(ByVal Food_Amount As String, ByVal Misc_Amount As String, ByVal Amount_Tip As String, ByVal Amount_Tax As String)
            BPAmount_Food = Food_Amount
            BPAmount_Misc = Misc_Amount
            BPAmount_Tip = Amount_Tip
            BPAmount_Tax = Amount_Tax
        End Sub

        Public Sub Set_Addr2(ByVal Addr2 As String)
            BPAddr2 = Addr2
        End Sub

        Public Sub Set_Comment(ByVal Comment As String)
            BPComment = Comment
        End Sub

        Public Sub Set_Phone(ByVal Phone As String)
            BPPhone = Phone
        End Sub

        Public Sub Set_Email(ByVal Email As String)
            BPEmail = Email
        End Sub

        Public Sub Set_Param(ByVal Name As String, ByVal Value As String)
            Name = Value
        End Sub

        Public Sub Calc_TPS()
            Dim tamper_proof_seal As String = (BPKey _
                        + (BPMerchant _
                        + (BPTransaction_Type _
                        + (BPAmount _
                        + (BPRebilling _
                        + (BPReb_First_Date _
                        + (BPReb_Expr _
                        + (BPReb_Cycles _
                        + (BPReb_Amount _
                        + (BPRRNO _
                        + (BPAVS_Allowed _
                        + (BPAutocap + BPMode))))))))))))
            Dim md5 As MD5 = New MD5CryptoServiceProvider
            Dim hash() As Byte
            Dim encode As ASCIIEncoding = New ASCIIEncoding
            Dim buffer() As Byte = encode.GetBytes(tamper_proof_seal)
            hash = md5.ComputeHash(buffer)
            BPTPS = ByteArrayToString(hash)
        End Sub

        'This is used to convert a byte array to a hex string
        Private Shared Function ByteArrayToString(ByVal arrInput() As Byte) As String
            Dim i As Integer
            Dim sOutput As StringBuilder = New StringBuilder(arrInput.Length)
            i = 0
            Do While (i < arrInput.Length)
                sOutput.Append(arrInput(i).ToString("X2"))
                i = (i + 1)
            Loop
            Return sOutput.ToString
        End Function

        Public Function Process() As String
            ' Calculate the Tamperproof Seal
            Calc_TPS()
            'post data
            Dim encoding As ASCIIEncoding = New ASCIIEncoding
            Dim request As HttpWebRequest = CType(WebRequest.Create(New Uri(BPURL)), HttpWebRequest)
            request.AllowAutoRedirect = False
            ' If experiencing connection issues the following line will disable SSL certificate validation.
            'ServicePointManager.CertificatePolicy = new FakeCertificatePolicy ();
            ServicePointManager.CheckCertificateRevocationList = True
            Dim serverquery As String = ("MERCHANT=" _
                        + (HttpUtility.UrlEncode(BPMerchant) + ("&MISSING_URL=nu" + ("&APPROVED_URL=nu" + ("&DECLINED_URL=nu" + ("&MODE=" _
                        + (HttpUtility.UrlEncode(BPMode) + ("&TAMPER_PROOF_SEAL=" _
                        + (HttpUtility.UrlEncode(BPTPS) + ("&TRANSACTION_TYPE=" _
                        + (HttpUtility.UrlEncode(BPTransaction_Type) + ("&NAME=" _
                        + (HttpUtility.UrlEncode(BPName) + ("&CC_NUM=" _
                        + (HttpUtility.UrlEncode(BPCCNum) + ("&CVCCVV2=" _
                        + (HttpUtility.UrlEncode(BPCVV2) + ("&CC_EXPIRES=" _
                        + (HttpUtility.UrlEncode(BPExpire) + ("&AMOUNT=" _
                        + (HttpUtility.UrlEncode(BPAmount) + ("&Order_ID=" _
                        + (HttpUtility.UrlEncode(BPOrder_ID) + ("&Addr1=" _
                        + (HttpUtility.UrlEncode(BPAddr1) + ("&Addr2=" _
                        + (HttpUtility.UrlEncode(BPAddr2) + ("&CITY=" _
                        + (HttpUtility.UrlEncode(BPCity) + ("&STATE=" _
                        + (HttpUtility.UrlEncode(BPState) + ("&ZIPCODE=" _
                        + (HttpUtility.UrlEncode(BPZip) + ("&COMMENT=" _
                        + (HttpUtility.UrlEncode(BPComment) + ("&PHONE=" _
                        + (HttpUtility.UrlEncode(BPPhone) + ("&EMAIL=" _
                        + (HttpUtility.UrlEncode(BPEmail) + ("&REBILLING=" _
                        + (HttpUtility.UrlEncode(BPRebilling) + ("&REB_FIRST_DATE=" _
                        + (HttpUtility.UrlEncode(BPReb_First_Date) + ("&REB_EXPR=" _
                        + (HttpUtility.UrlEncode(BPReb_Expr) + ("&REB_CYCLES=" _
                        + (HttpUtility.UrlEncode(BPReb_Cycles) + ("&REB_AMOUNT=" _
                        + (HttpUtility.UrlEncode(BPReb_Amount) + ("&RRNO=" _
                        + (HttpUtility.UrlEncode(BPRRNO) + ("&AUTOCAP=" _
                        + (HttpUtility.UrlEncode(BPAutocap) + ("&AVS_ALLOWED=" _
                        + (HttpUtility.UrlEncode(BPAVS_Allowed) + ("&PAYMENT_TYPE=" _
                        + (HttpUtility.UrlEncode(PAYMENT_TYPE) + ("&ACH_ACCOUNT_TYPE=" _
                        + (HttpUtility.UrlEncode(ACH_ACCOUNT_TYPE) + ("&ACH_ROUTING=" _
                        + (HttpUtility.UrlEncode(ACH_ROUTING) + ("&ACH_ACCOUNT=" _
                        + (HttpUtility.UrlEncode(ACH_ACCOUNT) + ("&DOC_TYPE=" _
                        + (HttpUtility.UrlEncode(DOC_TYPE) + ("&IS_CORPORATE=" _
                        + (HttpUtility.UrlEncode(IS_CORPORATE) + ("&COMPANY_NAME=" _
                        + (HttpUtility.UrlEncode(COMPANY_NAME) + ("&INVOICE_ID=" _
                        + (HttpUtility.UrlEncode(BPInvoice_ID) + ("&AMOUNT_TIP=" _
                        + (HttpUtility.UrlEncode(BPAmount_Tip) + ("&AMOUNT_TAX=" _
                        + (HttpUtility.UrlEncode(BPAmount_Tax) + ("&AMOUNT_FOOD=" _
                        + (HttpUtility.UrlEncode(BPAmount_Food) + ("&AMOUNT_MISC=" + HttpUtility.UrlEncode(BPAmount_Misc)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
            Dim data() As Byte = encoding.GetBytes(serverquery)
            request.Method = "POST"
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = data.Length
            Dim postdata As Stream = request.GetRequestStream
            postdata.Write(data, 0, data.Length)
            postdata.Close()
            'get response
            Try
                Dim response As HttpWebResponse = CType(request.GetResponse, HttpWebResponse)
                'WebHeaderCollection headers = response.Headers;
                'if ((response.StatusCode == HttpStatusCode.Found) || 
                '    (response.StatusCode == HttpStatusCode.Redirect) ||
                '    (response.StatusCode == HttpStatusCode.Moved) ||
                '    (response.StatusCode == HttpStatusCode.MovedPermanently))
                ' {
                '  Get redirected uri
                '  string uri = headers["Location"] ;
                '  uri = uri.Trim();
                '  Console.Write(uri + " foo\n\n");
                '}
                'Console.Write(response.StatusCode + " code\n\n");
                BPheaderstring = response.GetResponseHeader("Location")
                'Console.Write(BPheaderstring + " = BPHEAD\n\n");
                response.Close()
            Catch e As WebException
                Dim response As HttpWebResponse = CType(e.Response, HttpWebResponse)
                If (Not (response) Is Nothing) Then
                    Return ("The following WebException was raised :" + e.Message)
                Else
                    Return "Response Received from server was null"
                End If
            End Try
            'responsedata.Close();
            Dim headerstring As String = Get_Status
            Return headerstring
        End Function

        Public Function Get_Status() As String
            Dim regexresult As Regex = New Regex("Result=([^&$]*)")
            Dim resultheaderstring As String = regexresult.Match(BPheaderstring).Result("$1")
            Select Case (resultheaderstring)
                Case "APPROVED"
                    Return "1"
                Case "DECLINED"
                    Return "0"
                Case "ERROR"
                    Return "E"
                Case "MISSING"
                    Return "M"
                Case Else
                    Return "!"
            End Select
        End Function

        Public Function Get_RRNO() As String
            Dim r As Regex = New Regex("RRNO=([^&$]*)")
            Dim m As Match = r.Match(BPheaderstring)
            If m.Success Then
                Return m.Value.Substring(5)
            Else
                Return ""
            End If
            'return regexrrno.Match(BPheaderstring).Result("$1");
            'Match matchrrno = regexrrno.Match(BPheaderstring);
            'return matchrrno.Value;
            'string stringrrno = matchrrno.ToString();
            'return stringrrno; //.Substring(5);
        End Function

        Public Function Get_Message() As String
            Dim r As Regex = New Regex("MESSAGE=([^&$]+)")
            Dim m As Match = r.Match(BPheaderstring)
            If m.Success Then
                Return m.Value.Substring(8)
            Else
                Return ""
            End If
            'return regexmessage.Match(BPheaderstring).Result("$1");
            'Regex regexmessage = new Regex(@"MESSAGE=(\w+)");
            'Match matchmessage = regexmessage.Match(BPheaderstring);
            'return matchmessage.Value;
            'string stringmessage = matchmessage.ToString();
            'return stringmessage.Substring(8);
        End Function

        Public Function Get_CCV() As String
            Dim r As Regex = New Regex("CVV2=([^&$]*)")
            Dim m As Match = r.Match(BPheaderstring)
            If m.Success Then
                Return m.Value.Substring(5)
            Else
                Return ""
            End If
            'return regexcvv.Match(BPheaderstring).Result("$1");
            'Match matchcvv = regexcvv.Match(BPheaderstring);
            'return matchcvv.Value;
            'string stringcvv = matchcvv.ToString();
            'return stringcvv.Substring(5);
        End Function

        Public Function Get_AVS() As String
            Dim r As Regex = New Regex("AVS=([^&$]+)")
            Dim m As Match = r.Match(BPheaderstring)
            If m.Success Then
                Return m.Value.Substring(5)
            Else
                Return ""
            End If
            'return regexavs.Match(BPheaderstring).Result("$1");
            'Match matchavs = regexavs.Match(BPheaderstring);
            'return matchavs.Value;
            'string stringavs = matchavs.ToString();
            'return stringavs.Substring(5);
        End Function

        Public Function Get_AuthCode() As String
            Dim r As Regex = New Regex("AUTH_CODE=([^&$]+)")
            Dim m As Match = r.Match(BPheaderstring)
            If m.Success Then
                Return m.Value.Substring(10)
            Else
                Return ""
            End If
            'return regexauth.Match(BPheaderstring).Result("$1");
            'Match matchauth = regexauth.Match(BPheaderstring);
            'string stringauth = matchauth.ToString();
            'return stringauth; //.Substring(6);
        End Function

        Public Function Get_Missing() As String
            Dim r As Regex = New Regex("MISSING=([^&$]+)")
            Dim m As Match = r.Match(BPheaderstring)
            If m.Success Then
                Return m.Value.Substring(5)
            Else
                Return ""
            End If
        End Function
    End Class

    Public Class FakeCertificatePolicy
        'Inherits ICertificatePolicy
        Implements ICertificatePolicy

        Public Function CheckValidationResult(ByVal srvPoint As ServicePoint, ByVal certificate As X509Certificate, ByVal request As WebRequest, ByVal certificateProblem As Integer) As Boolean Implements ICertificatePolicy.CheckValidationResult
            Return True
        End Function
    End Class
End Namespace
