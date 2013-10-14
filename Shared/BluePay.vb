
Imports System
Imports System.Web
Imports System.Collections.Generic
Imports System.Web.UI
Imports FASTPORT.Business
Imports FASTPORT.Data

Imports System.Data.SqlClient
Imports BaseClasses.Utils
Imports BaseClasses
Imports System.Threading
Imports BluePay2

Public Class BluePay

#Region "Payments"

    'Namespace BP10Emu

    Public Class Run_CC_Payment

        Public Sub New()
            MyBase.New()
        End Sub

        Public Shared Sub Main()

            Dim accountID As String = "MERCHANT'S ACCOUNT ID HERE"
            Dim secretKey As String = "MERCHANT'S SECRET KEY HERE"
            Dim mode As String = "TEST"

            ' Merchant's Account ID
            ' Merchant's Secret Key
            ' Transaction Mode: TEST (can also be LIVE)
            Dim payment As BluePayPayment_BP10Emu = New BluePayPayment_BP10Emu(
                    accountID,
                    secretKey,
                    mode)

            ' Card Number: 4111111111111111
            ' Card Expire: 12/15
            ' Card CVV2: 123
            payment.setCCInformation(
                    "4111111111111111",
                    "1215",
                    "123")

            ' First Name: Bob
            ' Last Name: Tester
            ' Address1: 123 Test St.
            ' Address2: Apt #500
            ' City: Testville
            ' State: IL
            ' Zip: 54321
            ' Country: USA
            payment.setCustomerInformation(
                    "Bob",
                    "Tester",
                    "123 Test St.",
                    "Apt #500",
                    "Testville",
                    "IL",
                    "54321",
                    "USA")

            ' Phone #: 123-123-1234
            payment.setPhone("1231231234")

            ' Email Address: test@bluepay.com
            payment.setEmail("test@bluepay.com")

            ' Sale Amount: $3.00
            payment.sale("3.00")

            payment.Process()

            ' Outputs response from BluePay gateway
            Console.Write("Transaction ID: " + payment.getTransID() + Environment.NewLine)
            Console.Write("Message: " + payment.getMessage() + Environment.NewLine)
            Console.Write("Status: " + payment.getStatus() + Environment.NewLine)
            Console.Write("AVS Result: " + payment.getAVS() + Environment.NewLine)
            Console.Write("CVV2 Result: " + payment.getCVV2() + Environment.NewLine)
            Console.Write("Masked Payment Account: " + payment.getMaskedPaymentAccount() + Environment.NewLine)
            Console.Write("Card Type: " + payment.getCardType() + Environment.NewLine)
            Console.Write("Authorization Code: " + payment.getAuthCode() + Environment.NewLine)
        End Sub
    End Class

    Public Class Run_ACH_Payment

        Public Sub New()
            MyBase.New()
        End Sub

        Public Shared Sub Main()

            Dim accountID As String = "MERCHANT'S ACCOUNT ID HERE"
            Dim secretKey As String = "MERCHANT'S SECRET KEY HERE"
            Dim mode As String = "TEST"

            ' Merchant's Account ID
            ' Merchant's Secret Key
            ' Transaction Mode: TEST (can also be LIVE)
            Dim payment As BluePayPayment_BP10Emu = New BluePayPayment_BP10Emu(
                    accountID,
                    secretKey,
                    mode)

            ' Routing Number: 071923307
            ' Account Number: 0523421
            ' Account Type: Checking
            ' ACH Document Type: WEB
            payment.setACHInformation(
                    "071923307",
                    "0523421",
                    "C",
                    "WEB")

            ' First Name: Bob
            ' Last Name: Tester
            ' Address1: 123 Test St.
            ' Address2: Apt #500
            ' City: Testville
            ' State: IL
            ' Zip: 54321
            ' Country: USA
            payment.setCustomerInformation(
                    "Bob",
                    "Tester",
                    "123 Test St.",
                    "Apt #500",
                    "Testville",
                    "IL",
                    "54321",
                    "USA")

            ' Phone #: 123-123-1234
            payment.setPhone("1231231234")

            ' Email Address: test@bluepay.com
            payment.setEmail("test@bluepay.com")

            ' Sale Amount: $3.00
            payment.sale("3.00")

            payment.Process()

            ' Outputs response from BluePay gateway
            Console.Write("Transaction ID: " + payment.getTransID() + Environment.NewLine)
            Console.Write("Message: " + payment.getMessage() + Environment.NewLine)
            Console.Write("Status: " + payment.getStatus() + Environment.NewLine)
            Console.Write("AVS Result: " + payment.getAVS() + Environment.NewLine)
            Console.Write("CVV2 Result: " + payment.getCVV2() + Environment.NewLine)
            Console.Write("Masked Payment Account: " + payment.getMaskedPaymentAccount() + Environment.NewLine)
            Console.Write("Bank Name: " + payment.getBank() + Environment.NewLine)
            Console.Write("Authorization Code: " + payment.getAuthCode() + Environment.NewLine)
        End Sub
    End Class

    Public Class Run_CC_Payment_Recurring

        Public Sub New()
            MyBase.New()
        End Sub

        Public Shared Sub Main()

            Dim accountID As String = "MERCHANT'S ACCOUNT ID HERE"
            Dim secretKey As String = "MERCHANT'S SECRET KEY HERE"
            Dim mode As String = "TEST"

            ' Merchant's Account ID
            ' Merchant's Secret Key
            ' Transaction Mode: TEST (can also be LIVE)
            Dim payment As BluePayPayment_BP10Emu = New BluePayPayment_BP10Emu(
                    accountID,
                    secretKey,
                    mode)

            ' Card Number: 4111111111111111
            ' Card Expire: 12/15
            ' Card CVV2: 123
            payment.setCCInformation(
                    "4111111111111111",
                    "1215",
                    "123")

            ' First Name: Bob
            ' Last Name: Tester
            ' Address1: 123 Test St.
            ' Address2: Apt #500
            ' City: Testville
            ' State: IL
            ' Zip: 54321
            ' Country: USA
            payment.setCustomerInformation(
                    "Bob",
                    "Tester",
                    "123 Test St.",
                    "Apt #500",
                    "Testville",
                    "IL",
                    "54321",
                    "USA")

            ' Rebill Amount: $3.50
            ' Rebill Start Date: Jan. 5, 2015
            ' Rebill Frequency: 1 MONTH
            ' Rebill # of Cycles: 5
            payment.setRebillingInformation(
                    "3.50",
                    "2015-01-05",
                    "1 MONTH",
                    "5")

            ' Phone #: 123-123-1234
            payment.setPhone("1231231234")

            ' Email Address: test@bluepay.com
            payment.setEmail("test@bluepay.com")

            ' Sale Amount: $3.00
            payment.sale("3.00")

            payment.Process()

            ' Outputs response from BluePay gateway
            Console.Write("Transaction ID: " + payment.getTransID() + Environment.NewLine)
            Console.Write("Rebill ID: " + payment.getRebillID() + Environment.NewLine)
            Console.Write("Message: " + payment.getMessage() + Environment.NewLine)
            Console.Write("Status: " + payment.getStatus() + Environment.NewLine)
            Console.Write("AVS Result: " + payment.getAVS() + Environment.NewLine)
            Console.Write("CVV2 Result: " + payment.getCVV2() + Environment.NewLine)
            Console.Write("Masked Payment Account: " + payment.getMaskedPaymentAccount() + Environment.NewLine)
            Console.Write("Card Type: " + payment.getCardType() + Environment.NewLine)
            Console.Write("Authorization Code: " + payment.getAuthCode() + Environment.NewLine)
        End Sub
    End Class

    Public Class Run_ACH_Payment_Recurring

        Public Sub New()
            MyBase.New()
        End Sub

        Public Shared Sub Main()

            Dim accountID As String = "MERCHANT'S ACCOUNT ID HERE"
            Dim secretKey As String = "MERCHANT'S SECRET KEY HERE"
            Dim mode As String = "TEST"

            ' Merchant's Account ID
            ' Merchant's Secret Key
            ' Transaction Mode: TEST (can also be LIVE)
            Dim payment As BluePayPayment_BP10Emu = New BluePayPayment_BP10Emu(
                    accountID,
                    secretKey,
                    mode)

            ' Routing Number: 071923307
            ' Account Number: 0523421
            ' Account Type: Checking
            ' ACH Document Type: WEB
            payment.setACHInformation(
                    "071923307",
                    "0523421",
                    "C",
                    "WEB")

            ' First Name: Bob
            ' Last Name: Tester
            ' Address1: 123 Test St.
            ' Address2: Apt #500
            ' City: Testville
            ' State: IL
            ' Zip: 54321
            ' Country: USA
            payment.setCustomerInformation(
                    "Bob",
                    "Tester",
                    "123 Test St.",
                    "Apt #500",
                    "Testville",
                    "IL",
                    "54321",
                    "USA")

            ' Rebill Amount: $3.50
            ' Rebill Start Date: Jan. 5, 2015
            ' Rebill Frequency: 1 MONTH
            ' Rebill # of Cycles: 5
            payment.setRebillingInformation(
                    "3.50",
                    "2015-01-05",
                    "1 MONTH",
                    "5")

            ' Phone #: 123-123-1234
            payment.setPhone("1231231234")

            ' Email Address: test@bluepay.com
            payment.setEmail("test@bluepay.com")

            ' Sale Amount: $3.00
            payment.sale("3.00")

            payment.Process()

            ' Outputs response from BluePay gateway
            Console.Write("Transaction ID: " + payment.getTransID() + Environment.NewLine)
            Console.Write("Rebill ID: " + payment.getRebillID() + Environment.NewLine)
            Console.Write("Message: " + payment.getMessage() + Environment.NewLine)
            Console.Write("Status: " + payment.getStatus() + Environment.NewLine)
            Console.Write("AVS Result: " + payment.getAVS() + Environment.NewLine)
            Console.Write("CVV2 Result: " + payment.getCVV2() + Environment.NewLine)
            Console.Write("Masked Payment Account: " + payment.getMaskedPaymentAccount() + Environment.NewLine)
            Console.Write("Bank Name: " + payment.getBank() + Environment.NewLine)
            Console.Write("Authorization Code: " + payment.getAuthCode() + Environment.NewLine)
        End Sub
    End Class

#End Region

    Public Class Retrieve_Transaction_Data

        Public Sub New()
            MyBase.New()
        End Sub

        Public Shared Sub Main()

            Dim accountID As String = "MERCHANT'S ACCOUNT ID HERE"
            Dim secretKey As String = "MERCHANT'S SECRET KEY HERE"
            Dim mode As String = "TEST"

            ' Merchant's Account ID
            ' Merchant's Secret Key
            ' Transaction Mode: TEST (can also be LIVE)
            Dim report As BluePayPayment_BP10Emu = New BluePayPayment_BP10Emu(
                    accountID,
                    secretKey,
                    mode)

            ' Report Start Date: Jan. 1, 2013
            ' Report End Date: Jan. 15, 2013
            ' Also search subaccounts? Yes
            ' Output response without commas? Yes
            ' Do not include errored transactions? Yes
            report.getTransactionReport(
                "2013-01-01",
                "2013-01-15",
                "1",
                "1",
                "1")

            report.Process()

            ' Outputs response from BluePay gateway
            Console.Write(report.response)
        End Sub
    End Class

End Class
