
Imports System
Imports System.Web
Imports System.Collections.Generic
Imports System.Web.UI
Imports FASTPORT.Business
Imports FASTPORT.Data

Imports System.Data.SqlClient

Imports BaseClasses.Utils

Imports BaseClasses

Imports System.Drawing
Imports Aspose.BarCodeRecognition
Imports System.IO
Imports Aspose.Pdf.Devices

Imports Aspose.Words
Imports Aspose.Words.Drawing
Imports Aspose.Words.Saving
Imports Aspose.Words.Reporting
Imports Aspose.BarCode
Imports System.Threading

Public Class CustGenClass

#Region "Sprocs"

    Public Shared Function f_Sproc(ByVal SprocName As String, ByVal Param1 As String, Optional ByRef Param2 As String = "SkipMe", _
                                   Optional ByRef Param3 As String = "SkipMe", Optional ByRef Param4 As String = "SkipMe", _
                                   Optional ByRef Param5 As String = "SkipMe", Optional ByRef Param6 As String = "SkipMe", _
                                   Optional ByRef Param7 As String = "SkipMe", Optional ByRef Param8 As String = "SkipMe") As String

        Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Param1", Param1, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)

        Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param2 <> "SkipMe" Then
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@Param2", Param2, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim thirdParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param3 <> "SkipMe" Then
            thirdParameter = New BaseClasses.Data.StoredProcedureParameter("@Param3", Param3, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim fourthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param4 <> "SkipMe" Then
            fourthParameter = New BaseClasses.Data.StoredProcedureParameter("@Param4", Param4, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim fifthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param5 <> "SkipMe" Then
            fifthParameter = New BaseClasses.Data.StoredProcedureParameter("@Param5", Param5, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim sixthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param6 <> "SkipMe" Then
            sixthParameter = New BaseClasses.Data.StoredProcedureParameter("@Param6", Param6, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim seventhParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param7 <> "SkipMe" Then
            seventhParameter = New BaseClasses.Data.StoredProcedureParameter("@Param7", Param7, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim eightParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param8 <> "SkipMe" Then
            eightParameter = New BaseClasses.Data.StoredProcedureParameter("@Param8", Param8, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim outParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        outParameter = New BaseClasses.Data.StoredProcedureParameter("@Return", Nothing, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Output)
        outParameter.Size = 2097152

        Dim paramCount As Integer

        If Param8 <> "SkipMe" Then
            paramCount = 8
        ElseIf Param7 <> "SkipMe" Then
            paramCount = 7
        ElseIf Param6 <> "SkipMe" Then
            paramCount = 6
        ElseIf Param5 <> "SkipMe" Then
            paramCount = 5
        ElseIf Param4 <> "SkipMe" Then
            paramCount = 4
        ElseIf Param3 <> "SkipMe" Then
            paramCount = 3
        ElseIf Param2 <> "SkipMe" Then
            paramCount = 2
        Else
            paramCount = 1
        End If

        Dim parameterList(paramCount) As BaseClasses.Data.StoredProcedureParameter 'JAR -- Don't forget to set parameterList to 0 for 1 Parameter, 1 for 2.
        parameterList(0) = firstParameter

        If Param8 <> "SkipMe" Then
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = fourthParameter
            parameterList(4) = fifthParameter
            parameterList(5) = sixthParameter
            parameterList(6) = seventhParameter
            parameterList(7) = eightParameter
            parameterList(8) = outParameter
        ElseIf Param7 <> "SkipMe" Then
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = fourthParameter
            parameterList(4) = fifthParameter
            parameterList(5) = sixthParameter
            parameterList(6) = seventhParameter
            parameterList(7) = outParameter
        ElseIf Param6 <> "SkipMe" Then
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = fourthParameter
            parameterList(4) = fifthParameter
            parameterList(5) = sixthParameter
            parameterList(6) = outParameter
        ElseIf Param5 <> "SkipMe" Then
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = fourthParameter
            parameterList(4) = fifthParameter
            parameterList(5) = outParameter
        ElseIf Param4 <> "SkipMe" Then
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = fourthParameter
            parameterList(4) = outParameter
        ElseIf Param3 <> "SkipMe" Then
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = outParameter
        ElseIf Param2 <> "SkipMe" Then
            parameterList(1) = secondParameter
            parameterList(2) = outParameter
        Else
            parameterList(1) = outParameter
        End If

        Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing

        myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseFASTPORT1", SprocName, parameterList)

        Dim Return_Out As String = "None"

        If (myStoredProcedure.RunNonQuery()) Then

            Dim outArray As ArrayList = New ArrayList
            For Each outputParameter As System.Data.IDataParameter In myStoredProcedure.OutputParameters
                outArray.Add(outputParameter.Value)
            Next

            Dim myOutArray As String = Nothing

            If Not IsDBNull(outArray(0)) Then
                myOutArray = DirectCast(outArray(0), String)
            End If

            If myOutArray IsNot Nothing Then
                Return_Out = myOutArray
            Else
                Return_Out = "0"
            End If

        Else

            Dim myMessage As String = myStoredProcedure.ErrorMessage.ToString
            Return_Out = myMessage

        End If

        Return Return_Out

    End Function

    Public Shared Function f_Sproc_ArrayOut(ByVal SprocName As String, ByVal Param1 As String, Optional ByRef Param2 As String = "SkipMe", Optional ByRef Param3 As String = "SkipMe", Optional ByRef Param4 As String = "SkipMe") As Array

        Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Param1", Param1, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)

        Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param2 <> "SkipMe" Then
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@Param2", Param2, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim thirdParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param3 <> "SkipMe" Then
            thirdParameter = New BaseClasses.Data.StoredProcedureParameter("@Param3", Param3, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim fourthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param4 <> "SkipMe" Then
            fourthParameter = New BaseClasses.Data.StoredProcedureParameter("@Param4", Param4, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim outParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        outParameter = New BaseClasses.Data.StoredProcedureParameter("@Return", Nothing, System.Data.SqlDbType.Int, System.Data.ParameterDirection.Output)

        Dim paramCount As Integer

        If Param4 <> "SkipMe" Then
            paramCount = 4
        ElseIf Param3 <> "SkipMe" Then
            paramCount = 3
        ElseIf Param2 <> "SkipMe" Then
            paramCount = 2
        Else
            paramCount = 1
        End If

        Dim parameterList(paramCount) As BaseClasses.Data.StoredProcedureParameter 'JAR -- Don't forget to set parameterList to 0 for 1 Parameter, 1 for 2.
        parameterList(0) = firstParameter
        If Param4 <> "SkipMe" Then
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = fourthParameter
            parameterList(4) = outParameter
        ElseIf Param3 <> "SkipMe" Then
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = outParameter
        ElseIf Param2 <> "SkipMe" Then
            parameterList(1) = secondParameter
            parameterList(2) = outParameter
        Else
            parameterList(1) = outParameter
        End If

        Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing

        myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseFASTPORT1", SprocName, parameterList)

        Dim records As Array
        If (myStoredProcedure.RunQuery()) Then

            records = myStoredProcedure.Records.ToArray

        Else

            records = Nothing

            Dim myMessage As String = myStoredProcedure.ErrorMessage.ToString
            Throw New Exception(myMessage)

        End If

        Return records

    End Function


    Public Shared Function f_Sproc_ImageIn(ByVal SprocName As String, ByVal Image As Byte(), _
                                            Optional ByRef Param1 As String = "SkipMe", Optional ByRef Param2 As String = "SkipMe", _
                                            Optional ByRef Param3 As String = "SkipMe", Optional ByRef Param4 As String = "SkipMe", _
                                            Optional ByRef Param5 As String = "SkipMe", Optional ByRef Param6 As String = "SkipMe", _
                                            Optional ByRef Param7 As String = "SkipMe", Optional ByRef Param8 As String = "SkipMe") As String

        Dim imageParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        imageParameter = New BaseClasses.Data.StoredProcedureParameter("@Image", Image, System.Data.SqlDbType.Image, System.Data.ParameterDirection.Input)

        Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param1 <> "SkipMe" Then
            firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Param1", Param1, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param2 <> "SkipMe" Then
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@Param2", Param2, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim thirdParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param3 <> "SkipMe" Then
            thirdParameter = New BaseClasses.Data.StoredProcedureParameter("@Param3", Param3, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim fourthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param4 <> "SkipMe" Then
            fourthParameter = New BaseClasses.Data.StoredProcedureParameter("@Param4", Param4, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim fifthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param5 <> "SkipMe" Then
            fifthParameter = New BaseClasses.Data.StoredProcedureParameter("@Param5", Param5, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim sixthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param6 <> "SkipMe" Then
            sixthParameter = New BaseClasses.Data.StoredProcedureParameter("@Param6", Param6, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim seventhParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param7 <> "SkipMe" Then
            seventhParameter = New BaseClasses.Data.StoredProcedureParameter("@Param7", Param7, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim eightParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param8 <> "SkipMe" Then
            eightParameter = New BaseClasses.Data.StoredProcedureParameter("@Param8", Param8, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim outParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        outParameter = New BaseClasses.Data.StoredProcedureParameter("@Return", Nothing, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Output)
        outParameter.Size = 40000

        Dim paramCount As Integer

        If Param8 <> "SkipMe" Then
            paramCount = 8
        ElseIf Param7 <> "SkipMe" Then
            paramCount = 7
        ElseIf Param6 <> "SkipMe" Then
            paramCount = 6
        ElseIf Param5 <> "SkipMe" Then
            paramCount = 5
        ElseIf Param4 <> "SkipMe" Then
            paramCount = 4
        ElseIf Param3 <> "SkipMe" Then
            paramCount = 3
        ElseIf Param2 <> "SkipMe" Then
            paramCount = 2
        ElseIf Param1 <> "SkipMe" Then
            paramCount = 1
        Else
            paramCount = 0
        End If

        paramCount = paramCount + 1

        Dim parameterList(paramCount) As BaseClasses.Data.StoredProcedureParameter 'JAR -- Don't forget to set parameterList to 0 for 1 Parameter, 1 for 2.
        parameterList(0) = imageParameter

        If Param8 <> "SkipMe" Then
            parameterList(1) = firstParameter
            parameterList(2) = secondParameter
            parameterList(3) = thirdParameter
            parameterList(4) = fourthParameter
            parameterList(5) = fifthParameter
            parameterList(6) = sixthParameter
            parameterList(7) = seventhParameter
            parameterList(8) = eightParameter
            parameterList(9) = outParameter
        ElseIf Param7 <> "SkipMe" Then
            parameterList(1) = firstParameter
            parameterList(2) = secondParameter
            parameterList(3) = thirdParameter
            parameterList(4) = fourthParameter
            parameterList(5) = fifthParameter
            parameterList(6) = sixthParameter
            parameterList(7) = seventhParameter
            parameterList(8) = outParameter
        ElseIf Param6 <> "SkipMe" Then
            parameterList(1) = firstParameter
            parameterList(2) = secondParameter
            parameterList(3) = thirdParameter
            parameterList(4) = fourthParameter
            parameterList(5) = fifthParameter
            parameterList(6) = sixthParameter
            parameterList(7) = outParameter
        ElseIf Param5 <> "SkipMe" Then
            parameterList(1) = firstParameter
            parameterList(2) = secondParameter
            parameterList(3) = thirdParameter
            parameterList(4) = fourthParameter
            parameterList(5) = fifthParameter
            parameterList(6) = outParameter
        ElseIf Param4 <> "SkipMe" Then
            parameterList(1) = firstParameter
            parameterList(2) = secondParameter
            parameterList(3) = thirdParameter
            parameterList(4) = fourthParameter
            parameterList(5) = outParameter
        ElseIf Param3 <> "SkipMe" Then
            parameterList(1) = firstParameter
            parameterList(2) = secondParameter
            parameterList(3) = thirdParameter
            parameterList(4) = outParameter
        ElseIf Param2 <> "SkipMe" Then
            parameterList(1) = firstParameter
            parameterList(2) = secondParameter
            parameterList(3) = outParameter
        ElseIf Param1 <> "SkipMe" Then
            parameterList(1) = firstParameter
            parameterList(2) = outParameter
        End If

        Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing

        myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseFASTPORT1", SprocName, parameterList)

        Dim Return_Out As String = "None"

        If (myStoredProcedure.RunNonQuery()) Then

            Dim outArray As ArrayList = New ArrayList
            For Each outputParameter As System.Data.IDataParameter In myStoredProcedure.OutputParameters
                outArray.Add(outputParameter.Value)
            Next

            Dim myOutArray As String = Nothing

            If Not IsDBNull(outArray(0)) Then
                myOutArray = DirectCast(outArray(0), String)
            End If

            If myOutArray IsNot Nothing Then
                Return_Out = myOutArray
            Else
                Return_Out = "0"
            End If

        Else

            Dim myMessage As String = myStoredProcedure.ErrorMessage.ToString
            Throw New Exception(myMessage)

        End If

        Return Return_Out

    End Function


    Public Shared Function f_Sproc_DataTableOut(ByVal SprocName As String, ByVal Param1 As String, Optional ByRef Param2 As String = "SkipMe", Optional ByRef Param3 As String = "SkipMe", Optional ByRef Param4 As String = "SkipMe", Optional ByRef Param5 As String = "SkipMe") As DataTable


        Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Param1", Param1, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        firstParameter.Size = 4000


        Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param2 <> "SkipMe" Then
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@Param2", Param2, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If


        Dim thirdParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param3 <> "SkipMe" Then
            thirdParameter = New BaseClasses.Data.StoredProcedureParameter("@Param3", Param3, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If


        Dim fourthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param4 <> "SkipMe" Then
            fourthParameter = New BaseClasses.Data.StoredProcedureParameter("@Param4", Param4, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim fifthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        If Param5 <> "SkipMe" Then
            fifthParameter = New BaseClasses.Data.StoredProcedureParameter("@Param5", Param5, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)
        End If

        Dim outParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
        outParameter = New BaseClasses.Data.StoredProcedureParameter("@Return", Nothing, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Output)
        outParameter.Size = 4000


        Dim paramCount As Integer

        If Param5 <> "SkipMe" Then
            paramCount = 5
        ElseIf Param4 <> "SkipMe" Then
            paramCount = 4
        ElseIf Param3 <> "SkipMe" Then
            paramCount = 3
        ElseIf Param2 <> "SkipMe" Then
            paramCount = 2
        Else
            paramCount = 1
        End If


        Dim parameterList(paramCount) As BaseClasses.Data.StoredProcedureParameter 'JAR -- Don't forget to set parameterList to 0 for 1 Parameter, 1 for 2.
        parameterList(0) = firstParameter
        If Param5 <> "SkipMe" Then
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = fourthParameter
            parameterList(4) = fifthParameter
            parameterList(5) = outParameter
        ElseIf Param4 <> "SkipMe" Then
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = fourthParameter
            parameterList(4) = outParameter
        ElseIf Param3 <> "SkipMe" Then
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = outParameter
        ElseIf Param2 <> "SkipMe" Then
            parameterList(1) = secondParameter
            parameterList(2) = outParameter
        Else
            parameterList(1) = outParameter
        End If


        Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing

        myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseFASTPORT1", SprocName, parameterList)


        Dim Return_Out As String = "None"

        '' Step 4: Run the stored procedure. 
        Dim dt As System.Data.DataTable
        If (myStoredProcedure.RunQuery()) Then


            '' Result from stored procedure is available 
            '' as a DataSet or as an array of RecordValue objects.


            'return (myStoredProcedure.DataSet)
            ' return (myStoredProcedure.Records) 


            '' If you want to go through the data set and access each row and column,
            '' see below
            Dim ds As System.Data.DataSet = myStoredProcedure.DataSet
            dt = ds.Tables(0)


        Else
            dt = Nothing
            '' You can raise an exception in the custom stored procedure and catch the exception and reporting it to the user.
            '' To raise the exception:

            Dim myMessage As String = myStoredProcedure.ErrorMessage.ToString
            Throw New Exception(myMessage)


            '' IMPORTANT: If you raise an error that has a severity level of 10 or less, it is considered  
            '' a warning, and no exception is raised. The severity of the error must be between 11 and 20
            '' for an exception to be thrown.


            '' Once the exception is raised, you can look at:
            '' myStoredProcedure.ErrorMessage to get the text of the error message and use RegisterJScriptAlert to report this to the user.
        End If


        Return dt


    End Function

#End Region


#Region "General Tools"

    'JAR -- Set's time variable and up to 4 session variables.
    Public Shared Sub s_SetVariables(ByVal myVar1 As String, Optional ByVal myVar2 As String = "_None", _
                              Optional ByVal myVar3 As String = "_None", Optional ByVal myVar4 As String = "_None", _
                              Optional ByVal myVar5 As String = "_None", Optional ByVal myVar6 As String = "_None")

        HttpContext.Current.Session("mySetTime") = Now()
        HttpContext.Current.Session("myVar1") = myVar1

        If myVar2 <> "_None" Then
            HttpContext.Current.Session("myVar2") = myVar2
        End If

        If myVar3 <> "_None" Then
            HttpContext.Current.Session("myVar3") = myVar3
        End If

        If myVar4 <> "_None" Then
            HttpContext.Current.Session("myVar4") = myVar4
        End If

        If myVar5 <> "_None" Then
            HttpContext.Current.Session("myVar5") = myVar5
        End If

        If myVar6 <> "_None" Then
            HttpContext.Current.Session("myVar6") = myVar6
        End If

    End Sub

    Public Shared Function f_GetVariable(ByVal myVarNo As String) As String

        Dim mySetTime As DateTime = CType(HttpContext.Current.Session("mySetTime"), DateTime)
        Dim mySecs As Long = DateDiff("s", mySetTime, Now())

        'JAR -- If the variables are not used in 2 seconds, the procedure will fail.
        If mySecs > 200 Then
            Return "_None"
            Exit Function
        End If

        Dim myReturn As String

        If myVarNo = "myVar1" Then
            myReturn = CType(HttpContext.Current.Session("myVar1"), String)
            Return myReturn
            HttpContext.Current.Session("myVar1") = Nothing
        ElseIf myVarNo = "myVar2" Then
            myReturn = CType(HttpContext.Current.Session("myVar2"), String)
            Return myReturn
            HttpContext.Current.Session("myVar2") = Nothing
        ElseIf myVarNo = "myVar3" Then
            myReturn = CType(HttpContext.Current.Session("myVar3"), String)
            Return myReturn
            HttpContext.Current.Session("myVar3") = Nothing
        ElseIf myVarNo = "myVar4" Then
            myReturn = CType(HttpContext.Current.Session("myVar4"), String)
            Return myReturn
            HttpContext.Current.Session("myVar4") = Nothing
        ElseIf myVarNo = "myVar5" Then
            myReturn = CType(HttpContext.Current.Session("myVar5"), String)
            Return myReturn
            HttpContext.Current.Session("myVar5") = Nothing
        ElseIf myVarNo = "myVar6" Then
            myReturn = CType(HttpContext.Current.Session("myVar6"), String)
            Return myReturn
            HttpContext.Current.Session("myVar6") = Nothing
        Else
            Return "_None"
        End If


    End Function

    Public Shared Function f_Split_ByComma(ByRef myString As String, ByVal myPosition As Integer) As String


        Dim myReturn As String = Nothing
        If String.IsNullOrEmpty(myString) = False Then
            Dim myCount As Integer = 0

            myString = Replace(myString, "'", "")
            myString = Replace(myString, """", "")

            Dim myParts As String() = myString.Split(New Char() {","c})

            ' Loop through result strings with For Each
            Dim myPart As String
            For Each myPart In myParts
                myCount = myCount + 1
                If myCount = myPosition Then
                    myReturn = myPart
                End If
            Next

        End If

        Return myReturn

    End Function

    Public Shared Function f_Decrypt(ByVal myToDecrypt As String) As String

        Dim myReturn As String

        Try
            Dim CheckCrypto As Crypto = New Crypto(Crypto.Providers.DES)
            myReturn = CheckCrypto.Decrypt(myToDecrypt)
        Catch ex As Exception
            myReturn = myToDecrypt
        End Try

        Return myReturn

    End Function

    Public Shared Function f_Encrypt(ByVal myToEncrypt As String) As String

        Dim myReturn As String

        Try
            Dim CheckCrypto As Crypto = New Crypto(Crypto.Providers.DES)
            myReturn = CheckCrypto.Encrypt(myToEncrypt)
        Catch ex As Exception
            myReturn = myToEncrypt
        End Try

        Return myReturn

    End Function

    Public Shared Function f_GetPartyName(ByVal myUserID As String) As String

        If String.IsNullOrEmpty(myUserID) = False Then

            Dim myWhere As String = PartyTable.PartyID.UniqueName & " = " & myUserID
            Dim myRec As PartyRecord = PartyTable.GetRecord(myWhere)
            Dim myName As String = ""

            If Not IsNothing(myRec) Then
                If Not IsNothing(myRec.Name) Then
                    myName = myRec.Name.ToString
                ElseIf Not IsNothing(myRec.Email) Then
                    myName = myRec.Email.ToString
                End If
            End If

            Return myName

        Else

            Return "Name Not Specified"

        End If

    End Function

    Public Shared Function f_FlowCollectionIDGet(Optional ByVal myFlowStepID As String = Nothing) As String

        Dim myW As String = FlowStepTable.FlowStepID.UniqueName & " = " & myFlowStepID
        Dim myR As FlowStepRecord = FlowStepTable.GetRecord(myW)
        Dim myCollectionID As String = Nothing
        If Not IsNull(myR) Then
            myCollectionID = CStr(myR.FlowCollectionID)
        End If

        Return myCollectionID

    End Function

    Public Shared Function f_EmailStrip(ByVal emailIn As String) As String

        Dim leftLen = emailIn.IndexOf("<") + 1
        Dim rightLen = emailIn.IndexOf(">")
        Dim fullLen = Len(emailIn)

        Dim myReturn As String = Left(emailIn, rightLen)
        fullLen = Len(myReturn)
        myReturn = Right(myReturn, fullLen - leftLen)

        Return myReturn

    End Function

#End Region


#Region "URL Tools"

    Public Shared Sub s_URL_Update(
                                        ByVal myMessageID As String, _
                                        Optional ByVal myCollectionID As String = Nothing, _
                                        Optional ByVal myLeftPart As String = "http://app.fastport.com", _
                                        Optional ByVal ActionURL As String = Nothing, _
                                        Optional ByVal Action As String = Nothing, _
                                        Optional ByVal Close As String = Nothing, _
                                        Optional ByVal Slider As String = Nothing, _
                                        Optional ByVal RowOwnerCIX As String = Nothing, _
                                        Optional ByVal RowOIX As String = Nothing, _
                                        Optional ByVal FlowStep As String = Nothing, _
                                        Optional ByVal Party As String = Nothing, _
                                        Optional ByVal User As String = Nothing, _
                                        Optional ByVal Message As String = Nothing, _
                                        Optional ByVal Instance As String = Nothing, _
                                        Optional ByVal FleetCircle As String = Nothing, _
                                        Optional ByVal Execution As String = Nothing, _
                                        Optional ByVal Ad As String = Nothing, _
                                        Optional ByVal AdActivity As String = Nothing, _
                                        Optional ByVal CheckIn As String = Nothing, _
                                        Optional ByVal DocFiled As String = Nothing, _
                                        Optional ByVal Ord As String = Nothing, _
                                        Optional ByVal Payment As String = Nothing, _
                                        Optional ByVal Carrier As String = Nothing, _
                                        Optional ByVal Driver As String = Nothing, _
                                        Optional ByVal Addr As String = Nothing, _
                                        Optional ByVal Role As String = Nothing, _
                                        Optional ByVal History As String = Nothing, _
                                        Optional ByVal Parent As String = Nothing, _
                                        Optional ByVal Email As String = Nothing, _
                                        Optional ByVal Password As String = Nothing, _
                                        Optional ByVal Button As String = Nothing, _
                                        Optional ByVal ExcludeParams As String = Nothing, _
                                        Optional ByVal NoRadWindow As String = Nothing, _
                                        Optional ByVal GoAction As String = Nothing, _
                                        Optional ByVal Verification As String = Nothing, _
                                        Optional ByVal Doc As String = Nothing)


        If Not String.IsNullOrEmpty(Button) Then
            CustGenClass.f_Sproc("usp_ThreadMessage_UpdateRareParams", Button, myMessageID)
        End If


        Try
            DbUtils.StartTransaction()
            Dim myRec As New ThreadInstanceMessageRecord 'Record class for table to update.
            myRec = ThreadInstanceMessageTable.GetRecord(myMessageID, True)

            If Not String.IsNullOrEmpty(myCollectionID) Then
                myRec.ActionCollectionID = CInt(myCollectionID)
            End If

            If Not String.IsNullOrEmpty(myLeftPart) Then
                myRec.LeftPartURL = myLeftPart
            End If

            If Not String.IsNullOrEmpty(ActionURL) Then
                myRec.ActionURL = ActionURL
            End If

            myRec.Action = Action
            myRec.CloseAction = Close

            If Not String.IsNullOrEmpty(RowOwnerCIX) Then
                myRec.RowOwnerCIX = CInt(CustGenClass.f_Decrypt(RowOwnerCIX))
            End If

            If Not String.IsNullOrEmpty(RowOIX) Then
                myRec.RowOIX = CInt(CustGenClass.f_Decrypt(RowOIX))
            End If

            If Not String.IsNullOrEmpty(FlowStep) Then
                myRec.FlowStep = CInt(CustGenClass.f_Decrypt(FlowStep))
            End If

            If Not String.IsNullOrEmpty(Party) Then
                myRec.Party = CInt(CustGenClass.f_Decrypt(Party))
            End If

            If Not String.IsNullOrEmpty(User) Then
                myRec.UserSystem = CInt(CustGenClass.f_Decrypt(User))
            End If

            If Not String.IsNullOrEmpty(Message) Then
                myRec.Message = CInt(CustGenClass.f_Decrypt(Message))
            End If

            If Not String.IsNullOrEmpty(Instance) Then
                myRec.Instance0 = CInt(CustGenClass.f_Decrypt(Instance))
            End If

            If Not String.IsNullOrEmpty(FleetCircle) Then
                myRec.FleetCircle = CInt(CustGenClass.f_Decrypt(FleetCircle))
            End If

            If Not String.IsNullOrEmpty(Execution) Then
                myRec.Execution = CInt(CustGenClass.f_Decrypt(Execution))
            End If

            If Not String.IsNullOrEmpty(Ad) Then
                myRec.Ad = CInt(CustGenClass.f_Decrypt(Ad))
            End If

            If Not String.IsNullOrEmpty(AdActivity) Then
                myRec.AdActivity = CInt(CustGenClass.f_Decrypt(AdActivity))
            End If

            If Not String.IsNullOrEmpty(CheckIn) Then
                myRec.CheckIn = CInt(CustGenClass.f_Decrypt(CheckIn))
            End If

            If Not String.IsNullOrEmpty(DocFiled) Then
                myRec.DocFiled = CInt(CustGenClass.f_Decrypt(DocFiled))
            End If

            If Not String.IsNullOrEmpty(Ord) Then
                myRec.Ord = CInt(CustGenClass.f_Decrypt(Ord))
            End If

            If Not String.IsNullOrEmpty(Payment) Then
                myRec.Payment = CInt(CustGenClass.f_Decrypt(Payment))
            End If

            If Not String.IsNullOrEmpty(Carrier) Then
                myRec.Carrier = CInt(CustGenClass.f_Decrypt(Carrier))
            End If

            If Not String.IsNullOrEmpty(Driver) Then
                myRec.Driver = CInt(CustGenClass.f_Decrypt(Driver))
            End If

            If Not String.IsNullOrEmpty(Addr) Then
                myRec.Addr = CInt(CustGenClass.f_Decrypt(Addr))
            End If

            If Not String.IsNullOrEmpty(Role) Then
                myRec.Role = CInt(CustGenClass.f_Decrypt(Role))
            End If

            If Not String.IsNullOrEmpty(History) Then
                myRec.History = CInt(CustGenClass.f_Decrypt(History))
            End If

            If Not String.IsNullOrEmpty(Parent) Then
                myRec.Parent0 = CInt(CustGenClass.f_Decrypt(Parent))
            End If

            If Not String.IsNullOrEmpty(Email) Then
                myRec.Email = CustGenClass.f_Decrypt(Email)
            End If

            If Not String.IsNullOrEmpty(Password) Then
                myRec.Password = CustGenClass.f_Decrypt(Password)
            End If

            If Not String.IsNullOrEmpty(Button) Then
                myRec.Button = CInt(CustGenClass.f_Decrypt(Button))
            End If

            If Not String.IsNullOrEmpty(ExcludeParams) Then
                If ExcludeParams = "True" Then
                    myRec.ExcludeParams = True
                Else
                    myRec.ExcludeParams = False
                End If
            End If

            If Not String.IsNullOrEmpty(NoRadWindow) Then
                If NoRadWindow = "True" Then
                    myRec.NoRadWindow = True
                Else
                    myRec.NoRadWindow = False
                End If
            End If

            If Not String.IsNullOrEmpty(Verification) Then
                myRec.Verification = CInt(CustGenClass.f_Decrypt(Verification))
            End If

            If Not String.IsNullOrEmpty(Doc) Then
                myRec.Doc = CInt(CustGenClass.f_Decrypt(Doc))
            End If

            DbUtils.CommitTransaction()
            myRec.Save()

        Catch ex As Exception
            DbUtils.RollBackTransaction()

        Finally
            DbUtils.EndTransaction()

        End Try

    End Sub

    Public Shared Function f_URL_Replace(
                                        ByVal myOldURL As String,
                                        Optional ByVal Action As String = Nothing, _
                                        Optional ByVal Close As String = Nothing, _
                                        Optional ByVal Slider As String = Nothing, _
                                        Optional ByVal RowOwnerCIX As String = Nothing, _
                                        Optional ByVal RowOIX As String = Nothing, _
                                        Optional ByVal FlowStep As String = Nothing, _
                                        Optional ByVal Party As String = Nothing, _
                                        Optional ByVal User As String = Nothing, _
                                        Optional ByVal Message As String = Nothing, _
                                        Optional ByVal Instance As String = Nothing, _
                                        Optional ByVal FleetCircle As String = Nothing, _
                                        Optional ByVal Execution As String = Nothing, _
                                        Optional ByVal Ad As String = Nothing, _
                                        Optional ByVal AdActivity As String = Nothing, _
                                        Optional ByVal CheckIn As String = Nothing, _
                                        Optional ByVal DocFiled As String = Nothing, _
                                        Optional ByVal Ord As String = Nothing, _
                                        Optional ByVal Payment As String = Nothing, _
                                        Optional ByVal Carrier As String = Nothing, _
                                        Optional ByVal Driver As String = Nothing, _
                                        Optional ByVal Addr As String = Nothing, _
                                        Optional ByVal Role As String = Nothing, _
                                        Optional ByVal History As String = Nothing, _
                                        Optional ByVal Parent As String = Nothing, _
                                        Optional ByVal Email As String = Nothing, _
                                        Optional ByVal Password As String = Nothing, _
                                        Optional ByVal Button As String = Nothing, _
                                        Optional ByVal Verification As String = Nothing, _
                                        Optional ByVal Doc As String = Nothing) As String


        Dim myURL As String = myOldURL

        myURL = Replace(myURL, "{Action}", Action)
        myURL = Replace(myURL, "{Close}", Close)
        myURL = Replace(myURL, "{Slider}", Slider)
        myURL = Replace(myURL, "{RowOwnerCIX}", RowOwnerCIX)
        myURL = Replace(myURL, "{RowOIX}", RowOIX)
        myURL = Replace(myURL, "{FlowStep}", FlowStep)
        myURL = Replace(myURL, "{Party}", Party)
        myURL = Replace(myURL, "{User}", User)
        myURL = Replace(myURL, "{Message}", Message)
        myURL = Replace(myURL, "{Instance}", Instance)
        myURL = Replace(myURL, "{FleetCircle}", FleetCircle)
        myURL = Replace(myURL, "{Execution}", Execution)
        myURL = Replace(myURL, "{Ad}", Ad)
        myURL = Replace(myURL, "{AdActivity}", AdActivity)
        myURL = Replace(myURL, "{CheckIn}", CheckIn)
        myURL = Replace(myURL, "{DocFiled}", DocFiled)
        myURL = Replace(myURL, "{Ord}", Ord)
        myURL = Replace(myURL, "{Payment}", Payment)
        myURL = Replace(myURL, "{Carrier}", Carrier)
        myURL = Replace(myURL, "{Driver}", Driver)
        myURL = Replace(myURL, "{Addr}", Addr)
        myURL = Replace(myURL, "{Role}", Role)
        myURL = Replace(myURL, "{History}", History)
        myURL = Replace(myURL, "{Parent}", Parent)
        myURL = Replace(myURL, "{Email}", Email)
        myURL = Replace(myURL, "{Password}", Password)
        myURL = Replace(myURL, "{Button}", Button)
        myURL = Replace(myURL, "{Verification}", Verification)
        myURL = Replace(myURL, "{Doc}", Doc)

        If Left(myURL, 1) = "/" Then
            myURL = ".." & myURL
        ElseIf Left(myURL, 1) <> "." Then
            myURL = "../" & myURL
        End If

        Return myURL

    End Function

    Public Shared Function f_URL_Cleanup(ByVal myURL As String) As String

        myURL = Replace(myURL, "Action={Action}", "")
        myURL = Replace(myURL, "Close={Close}", "")
        myURL = Replace(myURL, "Slider={Slider}", "")
        myURL = Replace(myURL, "RowOwnerCIX={RowOwnerCIX}", "")
        myURL = Replace(myURL, "RowOIX={RowOIX}", "")
        myURL = Replace(myURL, "FlowStep={FlowStep}", "")
        myURL = Replace(myURL, "Party={Party}", "")
        myURL = Replace(myURL, "User={User}", "")
        myURL = Replace(myURL, "Message={Message}", "")
        myURL = Replace(myURL, "Instance={Instance}", "")
        myURL = Replace(myURL, "FleetCircle={FleetCircle}", "")
        myURL = Replace(myURL, "Execution={Execution}", "")
        myURL = Replace(myURL, "Ad={Ad}", "")
        myURL = Replace(myURL, "AdActivity={AdActivity}", "")
        myURL = Replace(myURL, "CheckIn={CheckIn}", "")
        myURL = Replace(myURL, "DocFiled={DocFiled}", "")
        myURL = Replace(myURL, "Ord={Ord}", "")
        myURL = Replace(myURL, "Payment={Payment}", "")
        myURL = Replace(myURL, "Carrier={Carrier}", "")
        myURL = Replace(myURL, "Driver={Driver}", "")
        myURL = Replace(myURL, "Addr={Addr}", "")
        myURL = Replace(myURL, "Role={Role}", "")
        myURL = Replace(myURL, "History={History}", "")
        myURL = Replace(myURL, "Parent={Parent}", "")
        myURL = Replace(myURL, "Email={Email}", "")
        myURL = Replace(myURL, "Password={Password}", "")
        myURL = Replace(myURL, "Button={Button}", "")
        myURL = Replace(myURL, "Verification={Verification}", "")
        myURL = Replace(myURL, "Doc={Doc}", "")

        myURL = Replace(myURL, "Action=&", "")
        myURL = Replace(myURL, "Close=&", "")
        myURL = Replace(myURL, "Slider=&", "")
        myURL = Replace(myURL, "RowOwnerCIX=&", "")
        myURL = Replace(myURL, "RowOIX=&", "")
        myURL = Replace(myURL, "FlowStep=&", "")
        myURL = Replace(myURL, "Party=&", "")
        myURL = Replace(myURL, "User=&", "")
        myURL = Replace(myURL, "Message=&", "")
        myURL = Replace(myURL, "Instance=&", "")
        myURL = Replace(myURL, "FleetCircle=&", "")
        myURL = Replace(myURL, "Execution=&", "")
        myURL = Replace(myURL, "Ad={Ad}", "")
        myURL = Replace(myURL, "AdActivity=&", "")
        myURL = Replace(myURL, "CheckIn=&", "")
        myURL = Replace(myURL, "DocFiled=&", "")
        myURL = Replace(myURL, "Ord=&", "")
        myURL = Replace(myURL, "Payment=&", "")
        myURL = Replace(myURL, "Carrier=&", "")
        myURL = Replace(myURL, "Driver=&", "")
        myURL = Replace(myURL, "Addr=&", "")
        myURL = Replace(myURL, "Role=&", "")
        myURL = Replace(myURL, "History=&", "")
        myURL = Replace(myURL, "Parent=&", "")
        myURL = Replace(myURL, "Email=&", "")
        myURL = Replace(myURL, "Password=&", "")
        myURL = Replace(myURL, "Button=&", "")
        myURL = Replace(myURL, "Verification=&", "")
        myURL = Replace(myURL, "Doc=&", "")
        myURL = Replace(myURL, "?&", "?")

        Dim myClean As Boolean = myURL.Contains("&&")

        Do While myClean = True
            myURL = Replace(myURL, "&&", "&")
            myClean = myURL.Contains("&&")
        Loop

        If Right(myURL, 1) = "&" Then

            myURL = Left(myURL, Len(myURL) - 1)

        End If

        Return myURL

    End Function

    Public Shared Function f_URL_Replace_FromMessageRec(ByVal myURL As String, ByVal myR As ThreadInstanceMessageRecord) As String

        Dim myToReplace As String = Nothing

        myToReplace = CStr(myR.ActionCollectionID)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Collection}", myToReplace)
        End If

        myToReplace = CStr(myR.Action)
        If Not String.IsNullOrEmpty(myToReplace) Then
            myURL = Replace(myURL, "{Action}", myToReplace)
        End If

        myToReplace = CStr(myR.CloseAction)
        If Not String.IsNullOrEmpty(myToReplace) Then
            myURL = Replace(myURL, "{Close}", myToReplace)
        End If

        myToReplace = CStr(myR.RowOwnerCIX)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{RowOwnerCIX}", myToReplace)
        End If

        myToReplace = CStr(myR.RowOIX)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{RowOIX}", myToReplace)
        End If

        myToReplace = CStr(myR.FlowStep)
        Dim myID As String = Nothing
        Dim myThisAction As String = myR.Action
        If myThisAction = "AgreementExecution" Then
            myID = CStr(myR.Execution)
        ElseIf myThisAction = "Apply" Then
            myID = CStr(myR.AdActivity)
        End If

        myToReplace = f_URL_GetCurrentFlowID(myThisAction, myID, myToReplace)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{FlowStep}", myToReplace)
        End If

        myToReplace = CStr(myR.Party)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Party}", myToReplace)
        End If

        myToReplace = CStr(myR.UserSystem)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{User}", myToReplace)
        End If

        myToReplace = CStr(myR.Message)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Message}", myToReplace)
        Else
            myToReplace = CStr(myR.MessageID)
            If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
                myToReplace = CustGenClass.f_Encrypt(myToReplace)
                myURL = Replace(myURL, "{Message}", myToReplace)
            End If
        End If

        myToReplace = CStr(myR.Instance0)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Instance}", myToReplace)
        End If

        myToReplace = CStr(myR.FleetCircle)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{FleetCircle}", myToReplace)
        End If

        myToReplace = CStr(myR.Execution)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Execution}", myToReplace)
        End If

        myToReplace = CStr(myR.Ad)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Ad}", myToReplace)
        End If

        myToReplace = CStr(myR.AdActivity)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{AdActivity}", myToReplace)
        End If

        myToReplace = CStr(myR.CheckIn)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{CheckIn}", myToReplace)
        End If

        myToReplace = CStr(myR.DocFiled)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{DocFiled}", myToReplace)
        End If

        myToReplace = CStr(myR.Payment)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Payment}", myToReplace)
        End If

        myToReplace = CStr(myR.Carrier)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Carrier}", myToReplace)
        End If

        myToReplace = CStr(myR.Driver)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Driver}", myToReplace)
        End If

        myToReplace = CStr(myR.Addr)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Addr}", myToReplace)
        End If

        myToReplace = CStr(myR.Role)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Role}", myToReplace)
        End If

        myToReplace = CStr(myR.History)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{History}", myToReplace)
        End If

        myToReplace = CStr(myR.Parent0)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Parent}", myToReplace)
        End If

        myToReplace = CStr(myR.Email)
        If Not String.IsNullOrEmpty(myToReplace) Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Email}", myToReplace)
        End If

        myToReplace = CStr(myR.Password)
        If Not String.IsNullOrEmpty(myToReplace) Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Password}", myToReplace)
        End If

        myToReplace = CStr(myR.Button)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Button}", myToReplace)
        End If

        myToReplace = CStr(myR.Verification)
        If Not String.IsNullOrEmpty(myToReplace) And myToReplace <> "0" Then
            myToReplace = CustGenClass.f_Encrypt(myToReplace)
            myURL = Replace(myURL, "{Verification}", myToReplace)
        End If

        myURL = f_URL_Cleanup(myURL)

        Return myURL

    End Function

    Public Shared Function f_URL_GetCurrentFlowID(ByVal Action As String, ByVal myID As String, Optional ByVal myCurrentFlowStepID As String = Nothing) As String

        Dim myW As String
        Dim myFlowStepID As String = Nothing

        If Action = "AgreementExecution" Then
            myW = AgreementExecutionTable.ExecutionID.UniqueName & " = " & myID
            Dim myR_Execution As AgreementExecutionRecord = AgreementExecutionTable.GetRecord(myW)
            myFlowStepID = CStr(myR_Execution.FlowStepID)
        ElseIf Action = "Apply" Then
            myW = CarrierAdActivityTable.AdActivityID.UniqueName & " = " & myID
            Dim myR_AdActiivty As CarrierAdActivityRecord = CarrierAdActivityTable.GetRecord(myW)
            myFlowStepID = CStr(myR_AdActiivty.FlowStepID)
        End If

        If String.IsNullOrEmpty(myFlowStepID) Then
            myFlowStepID = myCurrentFlowStepID
        End If

        Return myFlowStepID

    End Function

    Public Shared Sub s_AttachExecution(ByVal myMessageID As String, ByVal myExeuctionID As String)

        Dim myW As String = DocTable.ExecutionID.UniqueName & " = " & myExeuctionID
        Dim myR As DocRecord = DocTable.GetRecord(myW)

        If Not IsNothing(myR) Then
            Dim myDocID As String = CStr(myR.DocID)
            Dim myDocName As String = CustGenClass.f_Sproc("usp_DocName", myDocID)
            Dim myPdfByte As Byte() = f_DocToPdf(myDocID)
            s_AttachToEmail(myMessageID, myPdfByte, myDocName & ".pdf")
        End If

    End Sub

    Public Shared Sub s_AttachToEmail(ByVal myMessageID As String, ByVal myAttachment As Byte(), Optional ByVal myFileName As String = "Attachment.pdf")

        Try
            ' Enclose all database retrieval/update code within a Transaction boundary

            DbUtils.StartTransaction()
            Dim myRec As New ThreadInstanceMessageAttachmentsRecord
            myRec.MessageID = CInt(myMessageID)
            myRec.Attachment = myAttachment
            myRec.FileName = myFileName
            myRec.Save()
            DbUtils.CommitTransaction()

        Catch ex As Exception
            ' Upon error, rollback the transaction
            DbUtils.RollBackTransaction()
            ' Report the error message to the end user
        Finally
            DbUtils.EndTransaction()
        End Try

    End Sub


    Public Shared Function f_InstanceURL(
                                        Optional ByVal FlowStep As String = Nothing, _
                                        Optional ByVal Instance As String = Nothing, _
                                        Optional ByVal Message As String = Nothing, _
                                        Optional ByVal RowOwnerCIX As String = Nothing, _
                                        Optional ByVal RowOIX As String = Nothing, _
                                        Optional ByVal Party As String = Nothing, _
                                        Optional ByVal Execution As String = Nothing, _
                                        Optional ByVal AdActivity As String = Nothing, _
                                        Optional ByVal FleetCircle As String = Nothing, _
                                        Optional ByVal CheckIn As String = Nothing, _
                                        Optional ByVal DocFiled As String = Nothing, _
                                        Optional ByVal Verification As String = Nothing, _
                                        Optional ByVal Close As String = "Yes", _
                                        Optional ByVal AddOverride As String = "No", _
                                        Optional ByVal Doc As String = Nothing) As String

        If String.IsNullOrEmpty(Instance) Then

            Dim myMessage As String = CustGenClass.f_Decrypt(Message)
            Dim myExecution As String = CustGenClass.f_Decrypt(Execution)
            Dim myAdActivity As String = CustGenClass.f_Decrypt(AdActivity)
            Dim myFleetCircle As String = CustGenClass.f_Decrypt(FleetCircle)
            Dim myCheckIn As String = CustGenClass.f_Decrypt(CheckIn)
            Dim myFiled As String = CustGenClass.f_Decrypt(DocFiled)
            Dim myVerification As String = CustGenClass.f_Decrypt(Verification)
            Dim myDoc As String = CustGenClass.f_Decrypt(Doc)

            Dim myInstanceID As String = CustGenClass.f_Sproc("usp_InstanceIDGet", myMessage, myExecution, myAdActivity, myFleetCircle, myCheckIn, myFiled, myVerification, myDoc)
            Instance = CustGenClass.f_Encrypt(myInstanceID)

        End If

        Dim myURL As String
        If AddOverride = "Show" Then
            myURL = "../ThreadInstance/ShowThread.aspx?"
        ElseIf AddOverride = "Yes" Or Not String.IsNullOrEmpty(Message) Or (String.IsNullOrEmpty(Instance) And String.IsNullOrEmpty(Message)) Then
            myURL = "../ThreadInstance/ThreadAdd.aspx?"
        Else
            myURL = "../ThreadInstance/Thread.aspx?"
        End If

        myURL = myURL & "FlowStep={FlowStep}&Instance={Instance}&Message={Message}&RowOwnerCIX={RowOwnerCIX}&RowOIX={RowOIX}&Party={Party}&Execution={Execution}&AdActivity={AdActivity}&FleetCircle={FleetCircle}&CheckIn={CheckIn}&DocFiled={DocFiled}&Verification={Verification}&Doc={Doc}&Close=" & Close
        myURL = CustGenClass.f_URL_Replace(myURL, , , , RowOwnerCIX, RowOIX, FlowStep, Party, , Message, Instance, FleetCircle, Execution, , AdActivity, CheckIn, DocFiled, , , , , , , , , , , , Verification, Doc)
        myURL = CustGenClass.f_URL_Cleanup(myURL)

        Return myURL

    End Function

    Public Shared Sub s_UpdateContent(ByVal myMessageID As String, Optional ByVal myBody As String = Nothing, Optional ByVal mySubject As String = Nothing, Optional ByVal myAction As String = Nothing, Optional ByVal myButtonText As String = Nothing, Optional ByVal myFlagToSend As String = "Yes")

        If Not String.IsNullOrEmpty(myBody) Or Not String.IsNullOrEmpty(mySubject) Or Not String.IsNullOrEmpty(myFlagToSend) Then

            Try
                DbUtils.StartTransaction()
                Dim myRec As New ThreadInstanceMessageRecord 'Record class for table to update.
                myRec = ThreadInstanceMessageTable.GetRecord(myMessageID, True)
                If Not IsNothing(myBody) Then
                    myRec.MessageBody = myBody
                End If
                If Not IsNothing(mySubject) Then
                    myRec.MessageSubject = mySubject
                End If
                If Not IsNothing(myAction) Then
                    myRec.MessageAction = myAction
                End If
                If Not IsNothing(myButtonText) Then
                    myRec.MessageButtonText = myButtonText
                End If
                If myFlagToSend = "Yes" Then
                    myRec.Queued = 1
                End If
                DbUtils.CommitTransaction()
                myRec.Save()

            Catch ex As Exception
                DbUtils.RollBackTransaction()

            Finally
                DbUtils.EndTransaction()

            End Try


        End If

    End Sub




    Public Shared Function f_URL_MessageCreate(ByVal myInstanceID As String,
                                ByVal myButtonID As String,
                                Optional ByVal SenderID As String = Nothing, _
                                Optional ByVal RecipientID As String = Nothing, _
                                Optional ByVal AboutID As String = Nothing, _
                                Optional ByVal WildTag1 As String = Nothing, _
                                Optional ByVal WildValue1 As String = Nothing, _
                                Optional ByVal WildTag2 As String = Nothing, _
                                Optional ByVal WildValue2 As String = Nothing, _
                                Optional ByVal WildTag3 As String = Nothing, _
                                Optional ByVal WildValue3 As String = Nothing, _
                                Optional ByVal WildTag4 As String = Nothing, _
                                Optional ByVal WildValue4 As String = Nothing, _
                                Optional ByVal WildTag5 As String = Nothing, _
                                Optional ByVal WildValue5 As String = Nothing, _
                                Optional ByVal FlowStepID As String = Nothing, _
                                Optional ByVal Action As String = Nothing, _
                                Optional ByVal PartyID As String = Nothing, _
                                Optional ByVal RoleID As String = Nothing, _
                                Optional ByVal AdActivityID As String = Nothing, _
                                Optional ByVal ExecutionID As String = Nothing, _
                                Optional ByVal ThreadID As String = "31") As String

        Dim myMessageID As String = "0"
        Dim CheckCrypto As Crypto = New Crypto(Crypto.Providers.DES)
        Dim myInstanceID_Encrypt As String = CheckCrypto.Encrypt(myInstanceID)
        Dim mySubject As String = Nothing
        Dim myAction As String = Nothing
        Dim myButtonText As String = Nothing
        Dim myBody As String = Nothing

        If String.IsNullOrEmpty(myButtonID) = False Then

            Dim myWhere As String = FlowButtonTable.ButtonID.UniqueName & " = " & myButtonID
            Dim myRec As FlowButtonRecord = FlowButtonTable.GetRecord(myWhere)

            mySubject = myRec.MessageSubject
            myAction = myRec.MessageAction
            myButtonText = myRec.MessageButtonText
            myBody = myRec.MessageBody

        Else

            Dim myWhere2 As String = ThreadTable.ThreadID.UniqueName & " = " & ThreadID
            Dim myRec2 As ThreadRecord = ThreadTable.GetRecord(myWhere2)

            mySubject = myRec2.FirstSubject
            myAction = myRec2.FirstAction
            myButtonText = myRec2.FirstButtonText
            myBody = myRec2.FirstBody

        End If

        '**************************
        'Custom parameters here.
        '**************************

        Dim URL As String = Nothing

        '**************************
        'End replace parameters code.
        '**************************

        If String.IsNullOrEmpty(mySubject) = False Then

            mySubject = f_URL_ReplaceCommonText(mySubject, SenderID, RecipientID, AboutID, myButtonText, WildTag1, WildValue1, WildTag2, WildValue2, WildTag3, WildValue3, WildTag4, WildValue4, WildTag5, WildValue5, FlowStepID, Action, PartyID, RoleID, AdActivityID, ExecutionID)

        End If

        If String.IsNullOrEmpty(myButtonText) = False Then

            myButtonText = f_URL_ReplaceCommonText(myButtonText, SenderID, RecipientID, AboutID, myButtonText, WildTag1, WildValue1, WildTag2, WildValue2, WildTag3, WildValue3, WildTag4, WildValue4, WildTag5, WildValue5, FlowStepID, Action, PartyID, RoleID, AdActivityID, ExecutionID)

        End If

        If String.IsNullOrEmpty(myAction) = False Then

            myAction = f_URL_ReplaceCommonText(myAction, SenderID, RecipientID, AboutID, myButtonText, WildTag1, WildValue1, WildTag2, WildValue2, WildTag3, WildValue3, WildTag4, WildValue4, WildTag5, WildValue5, FlowStepID, Action, PartyID, RoleID, AdActivityID, ExecutionID)

        End If

        If String.IsNullOrEmpty(myBody) = False Then

            myBody = f_URL_ReplaceCommonText(myBody, SenderID, RecipientID, AboutID, myButtonText, WildTag1, WildValue1, WildTag2, WildValue2, WildTag3, WildValue3, WildTag4, WildValue4, WildTag5, WildValue5, FlowStepID, Action, PartyID, RoleID, AdActivityID, ExecutionID)

        End If

        myMessageID = CustGenClass.f_Sproc("usp_ThreadMessageAdd", myInstanceID, myBody, SenderID, "No", mySubject, myAction, myButtonText, myButtonID)

        Return myMessageID

    End Function


    Public Shared Function f_URL_ReplaceCommonText(
                        ByVal ReplaceString As String, _
                        Optional ByVal SenderID As String = Nothing, _
                        Optional ByVal RecipientID As String = Nothing, _
                        Optional ByVal AboutID As String = Nothing, _
                        Optional ByVal ButtonText As String = Nothing,
                        Optional ByVal WildTag1 As String = Nothing, _
                        Optional ByVal WildValue1 As String = Nothing, _
                        Optional ByVal WildTag2 As String = Nothing, _
                        Optional ByVal WildValue2 As String = Nothing, _
                        Optional ByVal WildTag3 As String = Nothing, _
                        Optional ByVal WildValue3 As String = Nothing, _
                        Optional ByVal WildTag4 As String = Nothing, _
                        Optional ByVal WildValue4 As String = Nothing, _
                        Optional ByVal WildTag5 As String = Nothing, _
                        Optional ByVal WildValue5 As String = Nothing, _
                        Optional ByVal FlowStepID As String = Nothing, _
                        Optional ByVal Action As String = Nothing, _
                        Optional ByVal PartyID As String = Nothing, _
                        Optional ByVal RoleID As String = Nothing, _
                        Optional ByVal AdActivityID As String = Nothing, _
                        Optional ByVal ExecutionID As String = Nothing _
                        ) As String

        Try

            If String.IsNullOrEmpty(WildTag1) = False And String.IsNullOrEmpty(WildValue1) = False Then
                ReplaceString = Replace(ReplaceString, WildTag1, WildValue1)
            End If

            If String.IsNullOrEmpty(WildTag2) = False And String.IsNullOrEmpty(WildValue2) = False Then
                ReplaceString = Replace(ReplaceString, WildTag2, WildValue2)
            End If

            If String.IsNullOrEmpty(WildTag3) = False And String.IsNullOrEmpty(WildValue3) = False Then
                ReplaceString = Replace(ReplaceString, WildTag3, WildValue3)
            End If

            If String.IsNullOrEmpty(WildTag4) = False And String.IsNullOrEmpty(WildValue4) = False Then
                ReplaceString = Replace(ReplaceString, WildTag4, WildValue4)
            End If

            If String.IsNullOrEmpty(WildTag5) = False And String.IsNullOrEmpty(WildValue5) = False Then
                ReplaceString = Replace(ReplaceString, WildTag5, WildValue5)
            End If

            Dim myWhere As String
            Dim myRec As PartyRecord

            If Not String.IsNullOrEmpty(SenderID) And SenderID <> "0" Then

                myWhere = PartyTable.PartyID.UniqueName & " = " & SenderID
                myRec = PartyTable.GetRecord(myWhere)

                If Not IsNothing(myRec) Then
                    Dim mySender As String = myRec.Name
                    Dim mySenderEmail As String = myRec.Email
                    If String.IsNullOrEmpty(mySender) = False Then
                        ReplaceString = Replace(Replace(ReplaceString, "{Sender}", mySender), "{CIXName}", mySender)
                    End If
                    If String.IsNullOrEmpty(mySenderEmail) = False Then
                        ReplaceString = Replace(ReplaceString, "{SenderEmail}", mySenderEmail)
                    End If
                    If String.IsNullOrEmpty(mySender) And String.IsNullOrEmpty(mySenderEmail) = False Then
                        ReplaceString = Replace(ReplaceString, "{Sender}", mySenderEmail)
                    End If
                    If String.IsNullOrEmpty(mySender) = False And String.IsNullOrEmpty(mySenderEmail) Then
                        ReplaceString = Replace(ReplaceString, "{SenderEmail}", mySender)
                    End If
                End If


            End If

            If Not String.IsNullOrEmpty(RecipientID) And RecipientID <> "0" Then

                myWhere = PartyTable.PartyID.UniqueName & " = " & RecipientID
                myRec = PartyTable.GetRecord(myWhere)

                If Not IsNothing(myRec) Then
                    Dim myRecipient As String = myRec.Name
                    Dim myRecipientEmail As String = myRec.Email
                    If String.IsNullOrEmpty(myRecipient) = False Then
                        ReplaceString = Replace(Replace(ReplaceString, "{Recipient}", myRecipient), "{OIXName}", myRecipient)
                    End If
                    If String.IsNullOrEmpty(myRecipientEmail) = False Then
                        ReplaceString = Replace(ReplaceString, "{RecipientEmail}", myRecipientEmail)
                    End If
                    If String.IsNullOrEmpty(myRecipient) And String.IsNullOrEmpty(myRecipientEmail) = False Then
                        ReplaceString = Replace(ReplaceString, "{Recipient}", myRecipientEmail)
                    End If
                    If String.IsNullOrEmpty(myRecipient) = False And String.IsNullOrEmpty(myRecipientEmail) Then
                        ReplaceString = Replace(ReplaceString, "{RecipientEmail}", myRecipient)
                    End If
                End If

            End If

            If Not String.IsNullOrEmpty(AboutID) And AboutID <> "0" Then

                myWhere = PartyTable.PartyID.UniqueName & " = " & AboutID
                myRec = PartyTable.GetRecord(myWhere)

                If Not IsNothing(myRec) Then
                    Dim myAbout As String = myRec.Name
                    Dim myAboutEmail As String = myRec.Email
                    If String.IsNullOrEmpty(myAbout) = False Then
                        ReplaceString = Replace(ReplaceString, "{About}", myAbout)
                    End If
                    If String.IsNullOrEmpty(myAboutEmail) = False Then
                        ReplaceString = Replace(ReplaceString, "{AboutEmail}", myAboutEmail)
                    End If
                    If String.IsNullOrEmpty(myAbout) And String.IsNullOrEmpty(myAboutEmail) = False Then
                        ReplaceString = Replace(ReplaceString, "{About}", myAboutEmail)
                    End If
                    If String.IsNullOrEmpty(myAbout) = False And String.IsNullOrEmpty(myAboutEmail) Then
                        ReplaceString = Replace(ReplaceString, "{AboutEmail}", myAbout)
                    End If
                End If

            End If

            If Not String.IsNullOrEmpty(ButtonText) Then

                ReplaceString = Replace(ReplaceString, "{ButtonText}", ButtonText)

            End If

            Dim myReplace As String = Nothing
            Dim myCollectionName As String = Nothing

            If Not String.IsNullOrEmpty(FlowStepID) And FlowStepID <> "0" Then

                myWhere = FlowStepTable.FlowStepID.UniqueName & " = " & FlowStepID
                Dim myFSRec As FlowStepRecord = FlowStepTable.GetRecord(myWhere)
                myReplace = myFSRec.FlowStatus

                If Not String.IsNullOrEmpty(myReplace) Then

                    ReplaceString = Replace(ReplaceString, "{FlowStepName}", myReplace)

                End If

                myWhere = FlowCollectionTable.FlowCollectionID.UniqueName & " = " & myFSRec.FlowCollectionID.ToString
                Dim myR_Collection As FlowCollectionRecord = FlowCollectionTable.GetRecord(myWhere)
                myCollectionName = myR_Collection.CollectionName
                ReplaceString = Replace(ReplaceString, "{CollectionName}", myCollectionName)

            End If

            If Not String.IsNullOrEmpty(Action) Then

                'Action = CheckCrypto.Decrypt(Action)

                myReplace = Action

                If Not String.IsNullOrEmpty(myReplace) Then

                    ReplaceString = Replace(ReplaceString, "{ActionName}", myReplace)

                End If

            End If

            If Not String.IsNullOrEmpty(PartyID) And PartyID <> "0" Then

                myReplace = CustGenClass.f_GetPartyName(PartyID)

                If Not String.IsNullOrEmpty(myReplace) Then

                    ReplaceString = Replace(Replace(ReplaceString, "{UserName}", myReplace), "{PartyName}", myReplace)

                End If

            End If



            If Not String.IsNullOrEmpty(RoleID) And RoleID <> "0" Then


                myWhere = RoleTable.RoleID.UniqueName & " = " & RoleID
                Dim myRRec As RoleRecord = RoleTable.GetRecord(myWhere)
                myReplace = myRRec.Role

                If Not String.IsNullOrEmpty(myReplace) Then

                    ReplaceString = Replace(ReplaceString, "{RoleName}", myReplace)

                End If
            End If


            If Not String.IsNullOrEmpty(AdActivityID) And AdActivityID <> "0" Then

                myWhere = CarrierAdActivityTable.AdActivityID.UniqueName & " = " & AdActivityID
                Dim myActRec As CarrierAdActivityRecord = CarrierAdActivityTable.GetRecord(myWhere)
                myWhere = CarrierAdTable.AdID.UniqueName & " = " & myActRec.AdID
                Dim myAdRec As CarrierAdRecord = CarrierAdTable.GetRecord(myWhere)
                myReplace = myAdRec.AdName

                If Not String.IsNullOrEmpty(myReplace) Then

                    ReplaceString = Replace(Replace(ReplaceString, "{AdName}", myReplace), "{ProcessName}", myReplace)

                End If

            End If

            Dim myAgreementName As String = Nothing
            If Not String.IsNullOrEmpty(ExecutionID) And ExecutionID <> "0" Then

                myWhere = AgreementExecutionTable.ExecutionID.UniqueName & " = " & ExecutionID
                Dim myR_Exec As AgreementExecutionRecord = AgreementExecutionTable.GetRecord(myWhere)
                myWhere = AgreementTable.AgreementID.UniqueName & " = " & CStr(myR_Exec.AgreementID)
                Dim myR_Agee As AgreementRecord = AgreementTable.GetRecord(myWhere)
                myAgreementName = myR_Agee.Agreement

                If Not String.IsNullOrEmpty(myAgreementName) Then

                    ReplaceString = Replace(Replace(ReplaceString, "{AgreementName}", myAgreementName), "{ProcessName}", myAgreementName)

                End If

            End If

            If Not String.IsNullOrEmpty(myCollectionName) Then

                ReplaceString = Replace(ReplaceString, "{ProcessName}", myCollectionName)

            End If


            Return ReplaceString

        Catch ex As Exception

            Return ReplaceString

        End Try

    End Function


    Public Shared Sub s_URL_UpdateCommonContent(
                        ByVal myMessageID As String, _
                        Optional ByVal myToQ As String = "Yes", _
                        Optional ByVal SenderID As String = Nothing, _
                        Optional ByVal RecipientID As String = Nothing, _
                        Optional ByVal AboutID As String = Nothing, _
                        Optional ByVal URL As String = Nothing, _
                        Optional ByVal Instance As String = Nothing, _
                        Optional ByVal WildTag1 As String = Nothing, _
                        Optional ByVal WildValue1 As String = Nothing, _
                        Optional ByVal WildTag2 As String = Nothing, _
                        Optional ByVal WildValue2 As String = Nothing, _
                        Optional ByVal WildTag3 As String = Nothing, _
                        Optional ByVal WildValue3 As String = Nothing, _
                        Optional ByVal WildTag4 As String = Nothing, _
                        Optional ByVal WildValue4 As String = Nothing, _
                        Optional ByVal WildTag5 As String = Nothing, _
                        Optional ByVal WildValue5 As String = Nothing, _
                        Optional ByVal FlowStepID As String = Nothing, _
                        Optional ByVal Action As String = Nothing, _
                        Optional ByVal PartyID As String = Nothing, _
                        Optional ByVal RoleID As String = Nothing, _
                        Optional ByVal AdActivityID As String = Nothing _
                        )

        Dim myW As String = ThreadInstanceMessageTable.MessageID.UniqueName & " = " & myMessageID
        Dim myR As ThreadInstanceMessageRecord = ThreadInstanceMessageTable.GetRecord(myW)

        Dim mySubject As String = myR.MessageSubject
        mySubject = f_URL_ReplaceCommonText(mySubject, SenderID, RecipientID, AboutID, , WildTag1, WildValue1, WildTag2, WildValue2, WildTag3, WildValue3, WildTag4, WildValue4, WildTag5, WildValue5, FlowStepID, Action, PartyID, RoleID, AdActivityID)

        Dim myAction As String = myR.MessageAction
        myAction = f_URL_ReplaceCommonText(myAction, SenderID, RecipientID, AboutID, , WildTag1, WildValue1, WildTag2, WildValue2, WildTag3, WildValue3, WildTag4, WildValue4, WildTag5, WildValue5, FlowStepID, Action, PartyID, RoleID, AdActivityID)

        Dim myButtonText As String = myR.MessageButtonText
        myButtonText = f_URL_ReplaceCommonText(myButtonText, SenderID, RecipientID, AboutID, , WildTag1, WildValue1, WildTag2, WildValue2, WildTag3, WildValue3, WildTag4, WildValue4, WildTag5, WildValue5, FlowStepID, Action, PartyID, RoleID, AdActivityID)

        Dim myBody As String = myR.MessageBody
        myBody = f_URL_ReplaceCommonText(myBody, SenderID, RecipientID, AboutID, , WildTag1, WildValue1, WildTag2, WildValue2, WildTag3, WildValue3, WildTag4, WildValue4, WildTag5, WildValue5, FlowStepID, Action, PartyID, RoleID, AdActivityID)

        s_UpdateContent(myMessageID, myBody, mySubject, myAction, myButtonText, "Yes")


    End Sub

    Public Shared Sub s_InstanceRelatedIDsUpdate(ByVal myInstanceID As String, _
                                                    Optional ByVal myExecutionID As String = Nothing, _
                                                    Optional ByVal myAdActivityID As String = Nothing, _
                                                    Optional ByVal myFiledID As String = Nothing, _
                                                    Optional ByVal myVerificationID As String = Nothing,
                                                    Optional ByVal myCheckInID As String = Nothing,
                                                    Optional ByVal myFleetCircleID As String = Nothing,
                                                    Optional ByVal myDocID As String = Nothing)

        Dim myRelatedIDs As String = ""

        If Not String.IsNullOrEmpty(myExecutionID) Then
            myRelatedIDs = myRelatedIDs & "Execution-" & myExecutionID & ","
        End If

        If Not String.IsNullOrEmpty(myAdActivityID) Then
            myRelatedIDs = myRelatedIDs & "AdActivity-" & myAdActivityID & ","
        End If

        If Not String.IsNullOrEmpty(myFiledID) Then
            myRelatedIDs = myRelatedIDs & "Filed-" & myFiledID & ","
        End If

        If Not String.IsNullOrEmpty(myVerificationID) Then
            myRelatedIDs = myRelatedIDs & "Verification-" & myVerificationID & ","
        End If

        If Not String.IsNullOrEmpty(myCheckInID) Then
            myRelatedIDs = myRelatedIDs & "CheckIn-" & myCheckInID & ","
        End If

        If Not String.IsNullOrEmpty(myCheckInID) Then
            myRelatedIDs = myRelatedIDs & "FleetCircle-" & myFleetCircleID & ","
        End If

        If Not String.IsNullOrEmpty(myDocID) Then
            myRelatedIDs = myRelatedIDs & "Doc-" & myDocID & ","
        End If

        If Not String.IsNullOrEmpty(myRelatedIDs) Then
            CustGenClass.f_Sproc("usp_InstanceRelatedIDs", myInstanceID, myRelatedIDs)
        End If

    End Sub

    Public Shared Function f_DocToPdf(ByVal myDocID As String) As Byte()

        Dim myPDF As Aspose.Pdf.Document = New Aspose.Pdf.Document
        Dim myPDFName As String = CustGenClass.f_Sproc("usp_DocName", myDocID)

        Dim myW As String = DocPageTable.DocID.UniqueName & " = " & myDocID

        For Each myPageRec As DocPageRecord In DocPageTable.GetRecords(myW)

            Dim fs As System.IO.MemoryStream = New System.IO.MemoryStream(f_JpgToPDF(myPageRec.DocFile))
            Dim myNewPdf As Aspose.Pdf.Document = New Aspose.Pdf.Document(fs)

            myPDF = f_PDFConcatenate(myPDF, myNewPdf)

        Next

        Dim pdfMS As New System.IO.MemoryStream()
        myPDF.Optimize()
        myPDF.Save(pdfMS)
        Dim pdfByte As Byte() = pdfMS.ToArray()

        Return pdfByte

    End Function

    Public Shared Sub s_Message_AddAttachment(ByVal myMessageID As String, ByVal myFileName As String, ByVal myDocID As String)

        Dim pdfByte As Byte() = f_DocToPdf(myDocID)

        Try
            DbUtils.StartTransaction()
            Dim myR_ThreadAttach As ThreadInstanceMessageAttachmentsRecord = New ThreadInstanceMessageAttachmentsRecord
            myR_ThreadAttach.MessageID = CInt(myMessageID)
            myR_ThreadAttach.FileName = myFileName
            myR_ThreadAttach.Attachment = pdfByte
            myR_ThreadAttach.Save()
            DbUtils.CommitTransaction()
        Catch ex As Exception
            DbUtils.RollBackTransaction()
        Finally
            DbUtils.EndTransaction()
        End Try

    End Sub

#End Region


#Region "ASPOSE"

    'STEP 1:  Generate.
    Public Shared Function f_GenerateDocument(ByVal myPK As String, Optional ByVal myPartyID As String = "0") As String

        Dim myW As String = AgreementExecutionTable.ExecutionID.UniqueName & " = " & myPK
        Dim myR As AgreementExecutionRecord = AgreementExecutionTable.GetRecord(myW)

        If myPartyID = "0" Then

            myPartyID = CStr(myR.OIX)

        End If

        Dim myDoc As Aspose.Words.Document = f_GenerateDocument_Process(myR.AgreementID.ToString, myPK, myPartyID)

        'Cycle through doc pages and convert to .jpg.
        Dim mySaveOptions As ImageSaveOptions = New ImageSaveOptions(SaveFormat.Bmp)
        mySaveOptions.PageCount = 1
        Dim myPageNo As Integer = 1

        Dim myDocID As String = CustGenClass.f_Sproc("usp_DocID_ForExecution", myPK, "Yes")

        For pageIndex As Integer = 0 To myDoc.PageCount - 1
            Dim myPageMS As New System.IO.MemoryStream()
            mySaveOptions.PageIndex = pageIndex
            myDoc.Save(myPageMS, mySaveOptions)
            Dim myPageByte As Byte() = myPageMS.ToArray()
            Dim myPageID As String = CustGenClass.f_Sproc("usp_DocPageAdd", myDocID, CStr(myPageNo))
            Dim myPageBarCoded As Byte() = f_BmpCombine(myPageByte, f_BarCodeCreate(myPageID, CStr(myPageNo)), , , 350, 955)
            CustGenClass.f_Sproc_ImageIn("usp_DocPageUpdate", f_BmpToJpg(myPageBarCoded), myPageID)
            myPageNo = myPageNo + 1
        Next

        Return "Success"

    End Function
    
    Public Shared Function f_BmpCombine(ByVal myFirstBmp As Byte(), ByVal mySecondBmp As Byte(), _
                                            Optional ByVal myXFirst As Integer = 0, Optional ByVal myYFirst As Integer = 0, _
                                            Optional ByVal myXSecond As Integer = 100, Optional myYSecond As Integer = 100) As Byte()

        'Create the page that will be returned in the shape of "paper."
        Dim myPageOutBmp As New Bitmap(816, 1056)
        Dim g As Graphics = Graphics.FromImage(myPageOutBmp)

        'Insert the into our output file.
        Dim myFirstMs As MemoryStream = New MemoryStream(myFirstBmp)
        Dim myFirstImage As Image = Image.FromStream(myFirstMs)
        g.DrawImage(myFirstImage, New Point(myXFirst, myYFirst))

        'Insert the barcode into our output file.
        Dim mySecondMs As MemoryStream = New MemoryStream(mySecondBmp)
        Dim mySecondImage As Image = Image.FromStream(mySecondMs)
        g.DrawImage(mySecondImage, New Point(myXSecond, myYSecond))

        Dim myPageOutMs As System.IO.MemoryStream = New System.IO.MemoryStream()
        myPageOutBmp.Save(myPageOutMs, System.Drawing.Imaging.ImageFormat.Bmp)

        Dim myPageOutByte As Byte() = myPageOutMs.ToArray()

        Return myPageOutByte

    End Function

    Public Shared Function f_BarCodeCreate(ByVal myPK As String, ByVal myPageNo As String, Optional ByVal myDocType As String = "AE") As Byte()

        Dim myEncrypt As String = Nothing
        Dim myImage As System.Drawing.Image

        'String to encrypt with page.
        Dim myCodeValue As String = myDocType & "," & myPK & "," & myPageNo
        myEncrypt = CustGenClass.f_Encrypt(myCodeValue)

        'Create barcode with page.
        Dim bb As BarCodeBuilder = New BarCodeBuilder
        bb.CodeText = myEncrypt
        bb.CodeLocation = CodeLocation.None
        bb.SymbologyType = Symbology.QR
        bb.QRErrorLevel = QRErrorLevel.LevelQ
        bb.xDimension = 1.0F
        myImage = bb.BarCodeImage

        Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream()
        myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)

        Return ms.ToArray()

    End Function
    Public Shared Function f_BmpToJpg(ByVal myBmpByte As Byte()) As Byte()

        Dim myImage As New Bitmap(New System.IO.MemoryStream(myBmpByte))
        Dim myJpgMS As MemoryStream = New System.IO.MemoryStream()
        myImage.Save(myJpgMS, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim formattedJpgByte As Byte() = myJpgMS.ToArray()
        Return formattedJpgByte

    End Function

    Public Shared Function f_ResizeImage(ByVal imgByte As Byte(), ByVal percentResize As Double) As Byte()

        Dim myCurrentBmp As New Bitmap(New System.IO.MemoryStream(imgByte))

        Dim width As Integer = Convert.ToInt32(myCurrentBmp.Width * (1 - percentResize))
        Dim height As Integer = Convert.ToInt32(myCurrentBmp.Height * (1 - percentResize))

        Dim myHolderBmp As New Bitmap(width, height)
        Dim g As Graphics = Graphics.FromImage(myHolderBmp)
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.DrawImage(myCurrentBmp, New Rectangle(0, 0, width, height), New Rectangle(0, 0, myCurrentBmp.Width, myCurrentBmp.Height), GraphicsUnit.Pixel)

        Dim myBmpOutMS As MemoryStream = New System.IO.MemoryStream()
        myHolderBmp.Save(myBmpOutMS, System.Drawing.Imaging.ImageFormat.Bmp) 'can use any image format 

        Return myBmpOutMS.ToArray()

    End Function

    Public Shared Function f_FormatJpg(ByVal jpgByte As Byte(), ByVal jpgWidth As Integer, ByVal jpgHeight As Integer) As Byte()

        Dim percentResize As Double
        If jpgHeight > 1056 Then
            percentResize = (jpgHeight - 976) / jpgHeight
        ElseIf jpgWidth > 816 Then
            percentResize = (jpgWidth - 746) / jpgWidth
        End If
        Dim newJpgByte As Byte() = f_ResizeImage(jpgByte, percentResize)
        Dim newBmp As New Bitmap(New System.IO.MemoryStream(newJpgByte))

        Dim bmpStream As System.IO.MemoryStream = New System.IO.MemoryStream()
        newBmp.Save(bmpStream, System.Drawing.Imaging.ImageFormat.Bmp)

        Dim myPageOut As New Bitmap(816, 1056)
        Dim g As Graphics = Graphics.FromImage(myPageOut)

        Dim myAppPath As String = System.AppDomain.CurrentDomain.BaseDirectory
        Dim myPathFull As String = myAppPath & "Images\Custom\background.jpg"
        Dim background_blank As FileStream = File.OpenRead(myPathFull)
        Dim background As New Bitmap(background_blank)
        g.DrawImage(background, New Point(0, 0))

        Dim formattedImage As Image = Image.FromStream(bmpStream)
        g.DrawImage(formattedImage, New Point(40, 40))

        Dim outStream As MemoryStream = New System.IO.MemoryStream()
        myPageOut.Save(outStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        g.Dispose()
        Dim formattedJpgByte As Byte() = outStream.ToArray()
        outStream.Dispose()

        Return formattedJpgByte

    End Function

    Public Shared Function f_GenerateDocument_Process(ByVal myAgreementID As String, ByVal myExecutionID As String, ByVal myPartyID As String) As Aspose.Words.Document

        Dim ReturnDoc As New Document
        Dim SignaturePageDoc As New Document
        Dim SignaturePage As Boolean = False

        Try

            Dim buffer() As Byte
            Dim myFileName As String

            DbUtils.StartTransaction()

            Dim myAgreementExecutionWhereStr As String = AgreementExecutionTable.ExecutionID.UniqueName & " = " & myExecutionID
            Dim myAgreementExecutionRec As AgreementExecutionRecord = AgreementExecutionTable.GetRecord(myAgreementExecutionWhereStr)

            If Not myAgreementExecutionRec.UseOutsidePdf Then
                ' Determine which template to use, the agreement level one or an outside template
                If myAgreementExecutionRec.UseOutsideTemplate Then
                    buffer = CType(myAgreementExecutionRec.AgreementFileDoc, Byte())
                    myFileName = "ExternalTemplate.doc"
                Else
                    Dim myAgreementWhereStr As String = AgreementTable.AgreementID.UniqueName & " = " & myAgreementID
                    Dim myAgreementRecord As AgreementRecord = AgreementTable.GetRecord(myAgreementWhereStr)
                    buffer = CType(myAgreementRecord.AgreementFile, Byte())
                    myFileName = myAgreementRecord.AgreementFileName
                End If

                If buffer.Length > 0 Then
                    Dim newStream As New System.IO.MemoryStream(buffer)

                    ' 2a:  I think this section was not in your example.  I forget why this is important.

                    ' Read the document from the stream.
                    Dim doc As New Document(newStream)
                    doc.MailMerge.FieldMergingCallback = New HandleMergeImageFieldFromBlob()
                    doc.MailMerge.FieldMergingCallback = New HandleMergeFields()

                    '*********************
                    'ROOT TABLE
                    '*********************

                    Try

                        Dim mySignWhere As String = V_SignView.ExecutionID.UniqueName & " = " & myExecutionID
                        Dim mySignRec As V_SignRecord = V_SignView.GetRecord(mySignWhere)

                        doc.MailMerge.Execute(New String() {"SignedOn", _
                                                                "ExpiresOn", _
                                                                "BarCode", _
                                                                "C_Logo", _
                                                                "C_LogoSmall", _
                                                                "C_Name", _
                                                                "C_DBA", _
                                                                "C_DBAOrName", _
                                                                "C_AddrHTML", _
                                                                "C_Addr", _
                                                                "C_CitySTZip", _
                                                                "C_City", _
                                                                "C_ST", _
                                                                "C_Zip", _
                                                                "C_Country", _
                                                                "C_Signer", _
                                                                "C_SignerTitle", _
                                                                "C_SignerContactInfo", _
                                                                "C_Phone", _
                                                                "C_Mobile", _
                                                                "C_OtherPhone", _
                                                                "C_Fax", _
                                                                "C_Email", _
                                                                "C_Signature", _
                                                                "C_SignatureSmall", _
                                                                "C_Initials", _
                                                                "C_DOT", _
                                                                "C_MC", _
                                                                "C_EIN", _
                                                                "C_EIN1", _
                                                                "C_EIN2", _
                                                                "C_EIN3", _
                                                                "C_EIN4", _
                                                                "C_EIN5", _
                                                                "C_EIN6", _
                                                                "C_EIN7", _
                                                                "C_EIN8", _
                                                                "C_EIN9", _
                                                                "D_ProfilePic", _
                                                                "D_Name", _
                                                                "D_ContactInfo", _
                                                                "D_Phone", _
                                                                "D_Mobile", _
                                                                "D_OtherPhone", _
                                                                "D_Fax", _
                                                                "D_Email", _
                                                                "D_Signature", _
                                                                "D_SignatureSmall", _
                                                                "D_Initials", _
                                                                "D_Overview", _
                                                                "D_Incidents", _
                                                                "D_ExpGeneral", _
                                                                "D_ExpEquipment", _
                                                                "D_ExpCargo", _
                                                                "D_ExpRegions", _
                                                                "D_Gauge", _
                                                                "D_AddrHTML", _
                                                                "D_Addr", _
                                                                "D_CitySTZip", _
                                                                "D_City", _
                                                                "D_ST", _
                                                                "D_Zip", _
                                                                "D_Country", _
                                                                "D_DOB", _
                                                                "D_CDLInfo", _
                                                                "D_CDLShort", _
                                                                "D_CDLOnly", _
                                                                "D_CDLState", _
                                                                "D_USCitizen", _
                                                                "D_PersonalInfo", _
                                                                "D_SSN", _
                                                                "D_SSX4", _
                                                                "D_SS1", _
                                                                "D_SS2", _
                                                                "D_SS3", _
                                                                "D_SS4", _
                                                                "D_SS5", _
                                                                "D_SS6", _
                                                                "D_SS7", _
                                                                "D_SS8", _
                                                                "D_SS9", _
                                                                "D_PRA", _
                                                                "D_PRANumber", _
                                                                "D_Passport", _
                                                                "D_PassportExpiration", _
                                                                "D_TerminalAssigned", _
                                                                "D_I9OtherAlien", _
                                                                "D_I9a", _
                                                                "D_I9b", _
                                                                "D_I9c", _
                                                                "FirstLabel", _
                                                                "FirstValue", _
                                                                "SecondLabel", _
                                                                "SecondValue", _
                                                                "ThirdLabel", _
                                                                "ThirdValue", _
                                                                "FourthLabel", _
                                                                "FourthValue", _
                                                                "FifthLabel", _
                                                                "FifthValue", _
                                                                "SixthLabel", _
                                                                "SixthValue", _
                                                                "SeventhLabel", _
                                                                "SeventhValue", _
                                                                "EighthLabel", _
                                                                "EighthValue", _
                                                                "NinthLabel", _
                                                                "NinthValue", _
                                                                "TenthLabel", _
                                                                "TenthValue", _
                                                                "EleventhLabel", _
                                                                "EleventhValue", _
                                                                "TwelfthLabel", _
                                                                "TwelfthValue", _
                                                                "ThirteenthLabel", _
                                                                "ThirteenthValue", _
                                                                "FourteenthLabel", _
                                                                "FourteenthValue", _
                                                                "FifteenthLabel", _
                                                                "FifteenthValue", _
                                                                "Cust_Plus1", _
                                                                "Cust_Plus2", _
                                                                "Cust_Plus3", _
                                                                "Cust_Plus4", _
                                                                "Cust_Plus5", _
                                                                "Cust_Plus6", _
                                                                "Cust_HrsTtl"}, _
                                              New Object() {mySignRec.SignedOn, _
                                                                mySignRec.ExpiresOn, _
                                                                mySignRec.BarCode, _
                                                                mySignRec.C_Logo, _
                                                                mySignRec.C_LogoSmall, _
                                                                mySignRec.C_Name, _
                                                                mySignRec.C_DBA, _
                                                                mySignRec.C_DBAOrName, _
                                                                mySignRec.C_AddrHTML, _
                                                                mySignRec.C_Addr, _
                                                                mySignRec.C_CitySTZip, _
                                                                mySignRec.C_City, _
                                                                mySignRec.C_ST, _
                                                                mySignRec.C_Zip, _
                                                                mySignRec.C_Country, _
                                                                mySignRec.C_Signer, _
                                                                mySignRec.C_SignerTitle, _
                                                                mySignRec.C_SignerContactInfo, _
                                                                mySignRec.C_Phone, _
                                                                mySignRec.C_Mobile, _
                                                                mySignRec.C_OtherPhone, _
                                                                mySignRec.C_Fax, _
                                                                mySignRec.C_Email, _
                                                                mySignRec.C_Signature, _
                                                                mySignRec.C_SignatureSmall, _
                                                                mySignRec.C_Initials, _
                                                                mySignRec.C_DOT, _
                                                                mySignRec.C_MC, _
                                                                mySignRec.C_EIN, _
                                                                mySignRec.C_EIN1, _
                                                                mySignRec.C_EIN2, _
                                                                mySignRec.C_EIN3, _
                                                                mySignRec.C_EIN4, _
                                                                mySignRec.C_EIN5, _
                                                                mySignRec.C_EIN6, _
                                                                mySignRec.C_EIN7, _
                                                                mySignRec.C_EIN8, _
                                                                mySignRec.C_EIN9, _
                                                                mySignRec.D_ProfilePic, _
                                                                mySignRec.D_Name, _
                                                                mySignRec.D_ContactInfo, _
                                                                mySignRec.D_Phone, _
                                                                mySignRec.D_Mobile, _
                                                                mySignRec.D_OtherPhone, _
                                                                mySignRec.D_Fax, _
                                                                mySignRec.D_Email, _
                                                                mySignRec.D_Signature, _
                                                                mySignRec.D_SignatureSmall, _
                                                                mySignRec.D_Initials, _
                                                                mySignRec.D_Overview, _
                                                                mySignRec.D_Incidents, _
                                                                mySignRec.D_ExpGeneral, _
                                                                mySignRec.D_ExpEquipment, _
                                                                mySignRec.D_ExpCargo, _
                                                                mySignRec.D_ExpRegions, _
                                                                mySignRec.D_Gauge, _
                                                                mySignRec.D_AddrHTML, _
                                                                mySignRec.D_Addr, _
                                                                mySignRec.D_CitySTZip, _
                                                                mySignRec.D_City, _
                                                                mySignRec.D_ST, _
                                                                mySignRec.D_Zip, _
                                                                mySignRec.D_Country, _
                                                                mySignRec.D_DOB, _
                                                                mySignRec.D_CDLInfo, _
                                                                mySignRec.D_CDLShort, _
                                                                mySignRec.D_CDLOnly, _
                                                                mySignRec.D_CDLState, _
                                                                mySignRec.D_USCitizen, _
                                                                mySignRec.D_PersonalInfo, _
                                                                mySignRec.D_SSN, _
                                                                mySignRec.D_SSX4, _
                                                                mySignRec.D_SS1, _
                                                                mySignRec.D_SS2, _
                                                                mySignRec.D_SS3, _
                                                                mySignRec.D_SS4, _
                                                                mySignRec.D_SS5, _
                                                                mySignRec.D_SS6, _
                                                                mySignRec.D_SS7, _
                                                                mySignRec.D_SS8, _
                                                                mySignRec.D_SS9, _
                                                                mySignRec.D_PRA, _
                                                                mySignRec.D_PRANumber, _
                                                                mySignRec.D_Passport, _
                                                                mySignRec.D_PassportExpiration, _
                                                                mySignRec.D_TerminalAssigned, _
                                                                mySignRec.D_I9OtherAlien, _
                                                                mySignRec.D_I9a, _
                                                                mySignRec.D_I9b, _
                                                                mySignRec.D_I9c, _
                                                                mySignRec.FirstLabel, _
                                                                mySignRec.FirstValue, _
                                                                mySignRec.SecondLabel, _
                                                                mySignRec.SecondValue, _
                                                                mySignRec.ThirdLabel, _
                                                                mySignRec.ThirdValue, _
                                                                mySignRec.FourthLabel, _
                                                                mySignRec.FourthValue, _
                                                                mySignRec.FifthLabel, _
                                                                mySignRec.FifthValue, _
                                                                mySignRec.SixthLabel, _
                                                                mySignRec.SixthValue, _
                                                                mySignRec.SeventhLabel, _
                                                                mySignRec.SeventhValue, _
                                                                mySignRec.EighthLabel, _
                                                                mySignRec.EighthValue, _
                                                                mySignRec.NinthLabel, _
                                                                mySignRec.NinthValue, _
                                                                mySignRec.TenthLabel, _
                                                                mySignRec.TenthValue, _
                                                                mySignRec.EleventhLabel, _
                                                                mySignRec.EleventhValue, _
                                                                mySignRec.TwelfthLabel, _
                                                                mySignRec.TwelfthValue, _
                                                                mySignRec.ThirteenthLabel, _
                                                                mySignRec.ThirteenthValue, _
                                                                mySignRec.FourteenthLabel, _
                                                                mySignRec.FourteenthValue, _
                                                                mySignRec.FifteenthLabel, _
                                                                mySignRec.FifteenthValue, _
                                                                mySignRec.Cust_Plus1, _
                                                                mySignRec.Cust_Plus2, _
                                                                mySignRec.Cust_Plus3, _
                                                                mySignRec.Cust_Plus4, _
                                                                mySignRec.Cust_Plus5, _
                                                                mySignRec.Cust_Plus6, _
                                                                mySignRec.Cust_HrsTtl})

                    Catch ex As Exception

                        Dim myMessage As String = ex.Message

                    End Try


                    '*********************
                    'ADDR TABLE
                    '*********************

                    Try


                        Dim myAddrWhere As String = V_SignAddrView.PartyID.UniqueName & " = " & myPartyID
                        Dim myAddrRec As DataTable = V_SignAddrView.GetDataTable(myAddrWhere)

                        myAddrRec.TableName = "v_SignAddr"
                        myAddrRec.Columns(2).ColumnName = "AddrHTML"
                        myAddrRec.Columns(3).ColumnName = "Addr"
                        myAddrRec.Columns(4).ColumnName = "City"
                        myAddrRec.Columns(5).ColumnName = "ST"
                        myAddrRec.Columns(6).ColumnName = "Zip"
                        myAddrRec.Columns(7).ColumnName = "Country"

                        doc.MailMerge.ExecuteWithRegions(myAddrRec)


                    Catch ex As Exception

                        Dim myMessage As String = ex.Message

                    End Try

                    '********************
                    'HISTORY TABLE
                    '********************

                    Try

                        Dim myHistRec As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_SignHistory", myPartyID)

                        myHistRec.TableName = "v_SignHistory"
                        myHistRec.Columns(2).ColumnName = "HistoryHTML"
                        myHistRec.Columns(3).ColumnName = "ExpGeneral"
                        myHistRec.Columns(4).ColumnName = "ExpEquipment"
                        myHistRec.Columns(5).ColumnName = "ExpCargo"
                        myHistRec.Columns(6).ColumnName = "ExpRegions"
                        myHistRec.Columns(7).ColumnName = "FirstSort"
                        myHistRec.Columns(8).ColumnName = "StartDate"
                        myHistRec.Columns(9).ColumnName = "EndDate"

                        doc.MailMerge.ExecuteWithRegions(myHistRec)

                    Catch ex As Exception

                        Dim myMessage As String = ex.Message

                    End Try


                    '*********************
                    ' LIC/CERT TABLE
                    '*********************

                    Try


                        Dim myLicRec As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_SignLic", myPartyID)

                        myLicRec.TableName = "v_SignLic"
                        myLicRec.Columns(3).ColumnName = "DocInfo"
                        myLicRec.Columns(4).ColumnName = "DocShort"
                        myLicRec.Columns(5).ColumnName = "DocNumber"
                        myLicRec.Columns(6).ColumnName = "DocIssued"
                        myLicRec.Columns(7).ColumnName = "DocIssuingState"
                        myLicRec.Columns(8).ColumnName = "DocExpiration"
                        myLicRec.Columns(9).ColumnName = "Reissued"
                        myLicRec.Columns(10).ColumnName = "DocEndorsements"
                        myLicRec.Columns(11).ColumnName = "DocNotes"

                        doc.MailMerge.ExecuteWithRegions(myLicRec)


                    Catch ex As Exception

                        Dim myMessage As String = ex.Message

                    End Try


                    '*********************
                    'Docs Table
                    '*********************

                    Try


                        Dim myDocsWhere As String = V_SignDocsView.PartyID.UniqueName & " = " & myPartyID
                        Dim myDocsRec As DataTable = V_SignDocsView.GetDataTable(myDocsWhere)

                        myDocsRec.TableName = "v_SignDocs"
                        myDocsRec.Columns(3).ColumnName = "DocInfo"
                        myDocsRec.Columns(4).ColumnName = "DocShort"
                        myDocsRec.Columns(5).ColumnName = "DocNumber"
                        myDocsRec.Columns(6).ColumnName = "DocIssued"
                        myDocsRec.Columns(7).ColumnName = "DocIssuingState"
                        myDocsRec.Columns(8).ColumnName = "DocExpiration"
                        myDocsRec.Columns(9).ColumnName = "Reissued"
                        myDocsRec.Columns(10).ColumnName = "DocEndorsements"
                        myDocsRec.Columns(11).ColumnName = "DocNotes"

                        doc.MailMerge.ExecuteWithRegions(myDocsRec)


                    Catch ex As Exception

                        Dim myMessage As String = ex.Message

                    End Try

                    '*********************
                    'Owners Table
                    '*********************

                    Try


                        Dim myOwnerWhere As String = V_SignOwnerView.PartyID.UniqueName & " = " & myPartyID
                        Dim myOwnerRec As DataTable = V_SignOwnerView.GetDataTable(myOwnerWhere)

                        myOwnerRec.TableName = "v_SignOwner"
                        myOwnerRec.Columns(1).ColumnName = "O_Name"
                        myOwnerRec.Columns(2).ColumnName = "O_DBA"
                        myOwnerRec.Columns(3).ColumnName = "O_DBAOrName"
                        myOwnerRec.Columns(4).ColumnName = "O_AddrHTML"
                        myOwnerRec.Columns(5).ColumnName = "O_Addr"
                        myOwnerRec.Columns(6).ColumnName = "O_CitySTZip"
                        myOwnerRec.Columns(7).ColumnName = "O_City"
                        myOwnerRec.Columns(8).ColumnName = "O_ST"
                        myOwnerRec.Columns(9).ColumnName = "O_Zip"
                        myOwnerRec.Columns(10).ColumnName = "O_Country"
                        myOwnerRec.Columns(11).ColumnName = "O_SSNorEIN"
                        myOwnerRec.Columns(12).ColumnName = "O_SSN"
                        myOwnerRec.Columns(13).ColumnName = "O_EIN"
                        myOwnerRec.Columns(14).ColumnName = "O_Entity"
                        myOwnerRec.Columns(15).ColumnName = "O_EntitySole"
                        myOwnerRec.Columns(16).ColumnName = "O_EntityCCorp"
                        myOwnerRec.Columns(17).ColumnName = "O_EntitySCorp"
                        myOwnerRec.Columns(18).ColumnName = "O_EntityPartner"
                        myOwnerRec.Columns(19).ColumnName = "O_EntityTrustEstate"
                        myOwnerRec.Columns(20).ColumnName = "O_EntityLLC"
                        myOwnerRec.Columns(21).ColumnName = "O_EntityOther"

                        doc.MailMerge.ExecuteWithRegions(myOwnerRec)


                    Catch ex As Exception

                        Dim myMessage As String = ex.Message

                    End Try



                    '*********************
                    'Owners Table
                    '*********************

                    Try


                        Dim myEquipWhere As String = V_SignEquipView.PartyID.UniqueName & " = " & myPartyID
                        Dim myEquipRec As DataTable = V_SignEquipView.GetDataTable(myEquipWhere)

                        myEquipRec.TableName = "v_SignEquip"
                        myEquipRec.Columns(2).ColumnName = "O_Name"
                        myEquipRec.Columns(3).ColumnName = "V_Info"
                        myEquipRec.Columns(4).ColumnName = "V_Registration"
                        myEquipRec.Columns(5).ColumnName = "V_Specs"
                        myEquipRec.Columns(6).ColumnName = "V_PurchaseInfo"
                        myEquipRec.Columns(7).ColumnName = "V_Year"
                        myEquipRec.Columns(8).ColumnName = "V_Make"
                        myEquipRec.Columns(9).ColumnName = "V_Model"
                        myEquipRec.Columns(10).ColumnName = "V_Axels"
                        myEquipRec.Columns(11).ColumnName = "V_UnladenWeight"
                        myEquipRec.Columns(12).ColumnName = "V_Height"
                        myEquipRec.Columns(13).ColumnName = "V_PurchasedDate"
                        myEquipRec.Columns(14).ColumnName = "V_PurchasedValue"

                        doc.MailMerge.ExecuteWithRegions(myEquipRec)


                    Catch ex As Exception

                        Dim myMessage As String = ex.Message

                    End Try



                    '********************
                    'ACCIDENTS TABLE
                    '********************

                    Try

                        Dim myAccidents As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_IncidentsForAspose", myPartyID, "823")

                        myAccidents.TableName = "usp_Accidents"
                        myAccidents.Columns(3).ColumnName = "IncidentImage"
                        myAccidents.Columns(4).ColumnName = "IncidentImageLowRes"
                        myAccidents.Columns(5).ColumnName = "IncidentHTML"
                        myAccidents.Columns(6).ColumnName = "DetailsHTML"

                        doc.MailMerge.ExecuteWithRegions(myAccidents)


                    Catch ex As Exception

                        Dim myMessage As String = ex.Message

                    End Try

                    '********************
                    'Events TABLE
                    '********************

                    Try

                        Dim myEvents As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_IncidentsForAspose", myPartyID, "1927")

                        myEvents.TableName = "usp_Events"
                        myEvents.Columns(3).ColumnName = "IncidentImage"
                        myEvents.Columns(4).ColumnName = "IncidentImageLowRes"
                        myEvents.Columns(5).ColumnName = "IncidentHTML"
                        myEvents.Columns(6).ColumnName = "DetailsHTML"

                        doc.MailMerge.ExecuteWithRegions(myEvents)


                    Catch ex As Exception

                        Dim myMessage As String = ex.Message

                    End Try

                    '********************
                    'Honors TABLE
                    '********************

                    Try

                        Dim myHonors As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_IncidentsForAspose", myPartyID, "747", "No")

                        myHonors.TableName = "usp_Honors"
                        myHonors.Columns(3).ColumnName = "IncidentImage"
                        myHonors.Columns(4).ColumnName = "IncidentImageLowRes"
                        myHonors.Columns(5).ColumnName = "IncidentHTML"
                        myHonors.Columns(6).ColumnName = "DetailsHTML"

                        doc.MailMerge.ExecuteWithRegions(myHonors)

                    Catch ex As Exception

                        Dim myMessage As String = ex.Message

                    End Try

                    doc.MailMerge.CleanupOptions = doc.MailMerge.CleanupOptions Or Aspose.Words.Reporting.MailMergeCleanupOptions.RemoveEmptyParagraphs
                    doc.MailMerge.CleanupOptions = doc.MailMerge.CleanupOptions Or Aspose.Words.Reporting.MailMergeCleanupOptions.RemoveUnusedRegions
                    doc.MailMerge.CleanupOptions = doc.MailMerge.CleanupOptions Or Aspose.Words.Reporting.MailMergeCleanupOptions.RemoveUnusedFields
                    doc.MailMerge.CleanupOptions = doc.MailMerge.CleanupOptions Or Aspose.Words.Reporting.MailMergeCleanupOptions.RemoveContainingFields
                    doc.MailMerge.DeleteFields()

                    Dim builder As Aspose.Words.DocumentBuilder = New Aspose.Words.DocumentBuilder(doc)

                    newStream.Close()

                    ReturnDoc = doc


                End If
            Else

            End If

        Catch ex As Exception

            Dim myMessage As String = ex.Message

        Finally

        End Try

        Return ReturnDoc

    End Function

    Public Class HandleMergeFields
        Implements IFieldMergingCallback

        Private Sub FieldMerging(ByVal e As FieldMergingArgs) Implements IFieldMergingCallback.FieldMerging

            Dim myInsertHTML As String = "No"
            Dim myFieldName As String = e.FieldName
            Dim myFieldValue As String = e.FieldValue.ToString()

            If String.IsNullOrEmpty(myFieldValue) Or myFieldValue = "||html||**Please Select**" Or myFieldValue = "||html||**Please Select**" Then

                myInsertHTML = "<img id=""RightTriangle"" src=""http://app.fastport.com/Images/Custom/RightTriangle.png""  >"

            ElseIf Left(myFieldValue, 8) = "||html||" Then

                myFieldValue = Right(myFieldValue, Len(myFieldValue) - 8)

                If Not IsNothing(e.FieldValue) Then

                    If myFieldName = "IncidentHTML" Or myFieldName = "DetailsHTML" Then

                        myFieldValue = "<span style=""font-size: 11px;"">" & myFieldValue & "</span>"

                    End If

                    myInsertHTML = myFieldValue

                End If

            End If

            If myInsertHTML <> "No" Then

                Dim builder As New DocumentBuilder(e.Document)
                'Move cursor to field
                builder.MoveToField(e.Field, True)
                ' Insert HTML
                builder.InsertHtml(myInsertHTML)
                ' Remove the string representation of HTML
                e.Text = String.Empty

            End If

        End Sub

        Private Sub ImageFieldMerging(ByVal args As ImageFieldMergingArgs) Implements IFieldMergingCallback.ImageFieldMerging
            ' DO NOTHING
        End Sub

    End Class
    Public Class HandleMergeImageFieldFromBlob
        Implements IFieldMergingCallback
        Private Sub IFieldMergingCallback_FieldMerging(ByVal args As FieldMergingArgs) Implements IFieldMergingCallback.FieldMerging
            ' Do nothing.
        End Sub

        Private Sub ImageFieldMerging(ByVal e As ImageFieldMergingArgs) Implements IFieldMergingCallback.ImageFieldMerging
            ''' <summary>
            ''' This is called when mail merge engine encounters Image:XXX merge field in the document.
            ''' You have a chance to return an Image object, file name or a stream that contains the image.
            ''' </summary>
            ' The field value is a byte array, just cast it and create a stream on it.

            Dim myFieldName As String = e.FieldName

            If e.FieldValue IsNot Nothing Then

                If myFieldName = "C_LogoSmall" Then
                    Dim builder As New DocumentBuilder(e.Document)
                    builder.MoveToMergeField(e.FieldName)
                    builder.InsertImage(e.FieldValue.ToString(), 50, 50)
                ElseIf myFieldName = "C_SignatureSmall" Or myFieldName = "D_SignatureSmall" Then
                    Dim builder As New DocumentBuilder(e.Document)
                    builder.MoveToMergeField(e.FieldName)
                    builder.InsertImage(e.FieldValue.ToString(), 100, 25)
                Else
                    Dim imageStream As New System.IO.MemoryStream(CType(e.FieldValue, Byte()))
                    e.ImageStream = imageStream
                End If

            End If

        End Sub

    End Class
    
    Public Shared Function f_ReadBarcode(ByVal InputByteArray As Byte()) As String

        Dim myResult As String = "Not Found"
        Dim myfilestream As System.IO.MemoryStream = New System.IO.MemoryStream(InputByteArray)

        Dim reader As BarCodeReader
        Try
            reader = New BarCodeReader(myfilestream, BarCodeReadType.QR)
            Do While reader.Read
                myResult = reader.GetCodeText()
            Loop
        Catch 'ex As Exception
            ' Do nothing - no barcode found
        Finally

        End Try

        Return myResult

    End Function


    Public Shared myBarCode As String
    Public Shared myBarCode_Old As String
    Public Shared myType As String
    Public Shared myType_Old As String
    Public Shared myPage As String
    Public Shared myPK As String
    Public Shared myPK_Old As String
    Public Shared myCodeList As List(Of String)
    Public Shared myOrphans As String
    Public Shared myOrphanDocID As String
    Public Shared myRecipientID As String

    Public Shared Function f_Doc_Inbound(ByVal myInputByte As Byte(), _
                                                Optional ByVal myOldMessageID As String = Nothing, _
                                                Optional ByVal myInstancePartyID As String = Nothing, _
                                                Optional ByVal sender As String = Nothing, _
                                                Optional ByVal filename As String = Nothing, _
                                                Optional ByVal myOrphanDocID_override As String = Nothing
                                                                                    ) As List(Of String)

        myCodeList = New List(Of String)
        myBarCode = Nothing
        myType = Nothing
        myPK = Nothing
        myPage = Nothing
        myType_Old = ""
        myPK_Old = ""
        myBarCode_Old = ""
        myOrphans = "No Orphans"
        If Not String.IsNullOrEmpty(myOrphanDocID_override) Then
            myOrphanDocID = myOrphanDocID_override
        Else
            myOrphanDocID = Nothing
        End If

        myRecipientID = Nothing

        If Not String.IsNullOrEmpty(myInstancePartyID) Then
            'If InstanceParty is known.
            myRecipientID = myInstancePartyID
        ElseIf Not String.IsNullOrEmpty(sender) And Not sender.Contains("ringcentral.com") Then
            'If email is known.
            Dim myW3 As String = V_SecurityUserView.Email.UniqueName & " = '" & sender & "'"
            Dim myR3 As V_SecurityUserRecord = V_SecurityUserView.GetRecord(myW3)
            If Not IsNothing(myR3) Then
                myRecipientID = CStr(myR3.PartyID)
            Else
                myRecipientID = "3"
            End If
        Else
            'Thread instance.
            myRecipientID = "3"
        End If

        Dim myFileNameRight As String = Right(filename, 3)

        If myFileNameRight = "pdf" Then
            s_Doc_Inbound_Pdf(myInputByte, myOldMessageID, myInstancePartyID)
        ElseIf myFileNameRight = "iff" Or myFileNameRight = "tif" Then
            Dim myPDFByte As Byte() = f_TiffToPDF(myInputByte)
            s_Doc_Inbound_Pdf(myPDFByte)
        ElseIf myFileNameRight = "bmp" Then
            Dim myJpgByte As Byte() = f_BmpToJpg(myInputByte)
            s_Doc_Inbound_Process(myJpgByte, myRecipientID)
        ElseIf myFileNameRight = "peg" Or myFileNameRight = "jpg" Then
            s_Doc_Inbound_Process(myInputByte, myRecipientID)
        End If

        If myOrphans <> "No Orphans" Then
            Dim myMessageID As String = Nothing
            Dim RecipientID As String = Nothing
            If Not String.IsNullOrEmpty(myInstancePartyID) Then
                myMessageID = CustGenClass.f_SendReply_ThreadID(myOldMessageID, myInstancePartyID, "39")
            ElseIf Not String.IsNullOrEmpty(sender) And Not sender.Contains("ringcentral.com") Then
                myMessageID = CustGenClass.f_Sproc("usp_ThreadInstanceAdd", "38", "1", "3", "No", "0", "0", "Yes")
                Dim myW2 As String = ThreadInstanceMessageTable.MessageID.UniqueName & " = " & myMessageID
                Dim myR2 As ThreadInstanceMessageRecord = ThreadInstanceMessageTable.GetRecord(myW2)
                Dim myInstanceID As String = CStr(myR2.InstanceID)
                CustGenClass.f_Sproc("usp_ThreadRecipientsAdd", myInstanceID, "3", sender)
            Else
                myMessageID = CustGenClass.f_Sproc("usp_ThreadInstanceAdd", "40", "1", "5", "No", "0", "3", "Yes")
            End If
            If Not String.IsNullOrEmpty(myMessageID) Then
                s_Message_AddAttachment(myMessageID, filename, myOrphanDocID)
                Dim myW As String = ThreadInstanceMessageTable.MessageID.UniqueName & " = " & myMessageID
                Dim myR As ThreadInstanceMessageRecord = ThreadInstanceMessageTable.GetRecord(myW)
                If Not String.IsNullOrEmpty(myInstancePartyID) Then
                    RecipientID = CStr(myR.SenderID)
                ElseIf String.IsNullOrEmpty(sender) Or String.IsNullOrEmpty(RecipientID) Then
                    RecipientID = "3"
                End If
                Dim mySubject As String = myR.MessageSubject
                Dim myBody As String = myR.MessageBody
                mySubject = f_URL_ReplaceCommonText(mySubject, , RecipientID)
                myBody = f_URL_ReplaceCommonText(myBody, , RecipientID)
                s_UpdateContent(myMessageID, myBody, mySubject)
            End If
        End If

        Return myCodeList

    End Function

    Public Shared Sub s_Doc_Inbound_Pdf(ByVal myInputByte As Byte(), _
                                                Optional ByVal myOldMessageID As String = Nothing, _
                                                Optional ByVal myInstancePartyID As String = Nothing)


        Try

            Dim myfilestream As System.IO.MemoryStream = New System.IO.MemoryStream(myInputByte)
            Dim pdfDocument As Aspose.Pdf.Document = New Aspose.Pdf.Document(myfilestream)

            For pageCount As Integer = 1 To pdfDocument.Pages.Count

                Dim pdfPage As Aspose.Pdf.Page = pdfDocument.Pages(pageCount)
                Dim pageAsPdf As Aspose.Pdf.Document = New Aspose.Pdf.Document
                pageAsPdf.Pages.Add(pdfPage)

                Dim pageAsJpg As Byte() = f_PDFtoJpgByte(pageAsPdf)
                s_Doc_Inbound_Process(pageAsJpg, myRecipientID)

            Next

        Catch ex As Exception

            Dim myMessage As String = ex.Message

        End Try

    End Sub

    Public Shared Sub s_Doc_Inbound_Process(ByVal pageAsJpg As Byte(), ByVal myRecipientID As String)

        myBarCode = f_ReadBarcode(pageAsJpg)

        'Files in right place.
        'ElseIF files after previous page.
        'Else handles orphans.
        If myBarCode <> "Not Found" Then
            myBarCode = f_Decrypt(myBarCode)
            myType = f_Split_ByComma(myBarCode, 1)
            Dim myPageID As String = f_Split_ByComma(myBarCode, 2)
            myPage = f_Split_ByComma(myBarCode, 3)
            CustGenClass.f_Sproc_ImageIn("usp_DocPageUpdate", pageAsJpg, myPageID)
            If myType = "AE" Or myType = "AA" Then
                myPK = CustGenClass.f_Sproc("usp_ExecutionID_FromPage", myPageID)
            ElseIf myType = "D" Then
                Dim myW As String = DocPageTable.PageID.UniqueName & " = " & myPK
                Dim myR As DocPageRecord = DocPageTable.GetRecord(myW)
                myPK = CStr(myR.DocID)
                f_Sproc("dbo.usp_Doc_FlowStatus", myPK)
            End If
            If myType <> myType_Old Or (myType = myType_Old And myPK <> myPK_Old) Then
                myCodeList.Add(myType & "," & myPK)
                myType_Old = myType
                myPK_Old = myPK
            End If
        ElseIf myBarCode = "Not Found" And Not String.IsNullOrEmpty(myType_Old) And Not String.IsNullOrEmpty(myPK_Old) Then
            If myType_Old = "AE" Or myType_Old = "AA" Then
                Dim myW As String = DocTable.ExecutionID.UniqueName & " = " & myPK_Old
                Dim myR As DocRecord = DocTable.GetRecord(myW)
                Dim myDocID As String = CStr(myR.DocID)
                CustGenClass.f_Sproc_ImageIn("usp_DocPageAdd_WithImage", pageAsJpg, myDocID, "0")
            ElseIf myType_Old = "D" Then
                CustGenClass.f_Sproc_ImageIn("usp_DocPageAdd_WithImage", pageAsJpg, myPK_Old, "0")
            End If
        Else
            If String.IsNullOrEmpty(myOrphans) Then
                myOrphans = "Not Filed: " & Now()
            End If
            If String.IsNullOrEmpty(myOrphanDocID) Then
                myOrphanDocID = CustGenClass.f_Sproc("usp_DocAdd", myRecipientID, myOrphans, myRecipientID, myRecipientID, "1")
            End If
            CustGenClass.f_Sproc_ImageIn("usp_DocPageAdd_WithImage", pageAsJpg, myOrphanDocID, "0")
        End If

        myBarCode = Nothing

    End Sub

    Public Shared Sub s_Doc_Upload(ByVal myFileByte As Byte(), ByVal myDocID As String, ByVal myFileName As String, ByVal myUserID As String)

        Dim myFileNameRight As String = Right(myFileName, 3)
        'Dim myOutputSmallJpg As Byte()
        If myFileNameRight = "pdf" Then
            s_Doc_Upload_Pdf(myFileByte, myDocID, myUserID)
        ElseIf myFileNameRight = "iff" Or myFileNameRight = "tif" Then
            Dim myPDFByte As Byte() = f_TiffToPDF(myFileByte)
            s_Doc_Upload_Pdf(myPDFByte, myDocID, myUserID)
        ElseIf myFileNameRight = "bmp" Then
            Dim myJpgByte As Byte() = f_BmpToJpg(myFileByte)
            s_ModifyJpg(myJpgByte, myDocID, myUserID)
        ElseIf myFileNameRight = "peg" Or myFileNameRight = "jpg" Then
            s_ModifyJpg(myFileByte, myDocID, myUserID)
        End If

        f_Sproc("dbo.usp_Doc_FlowStatus", myDocID)

    End Sub

    Public Shared Sub s_Doc_Upload_Pdf(ByVal myInputByte As Byte(), ByVal myDocID As String, ByVal myUserID As String)

        Try

            Dim myfilestream As System.IO.MemoryStream = New System.IO.MemoryStream(myInputByte)
            Dim pdfDocument As Aspose.Pdf.Document = New Aspose.Pdf.Document(myfilestream)

            For pageCount As Integer = 1 To pdfDocument.Pages.Count

                Dim pdfPage As Aspose.Pdf.Page = pdfDocument.Pages(pageCount)
                Dim pageAsPdf As Aspose.Pdf.Document = New Aspose.Pdf.Document
                pageAsPdf.Pages.Add(pdfPage)

                Dim pageAsJpg As Byte() = f_PDFtoJpgByte(pageAsPdf)
                s_ModifyJpg(pageAsJpg, myDocID, myUserID)

            Next

        Catch ex As Exception

            Dim myMessage As String = ex.Message

        End Try

    End Sub

    Public Shared Sub s_Execution_SendMessage(ByVal myExecutionID As String, ByVal myFlowStepID As String)

        Try

            Dim myW As String = AgreementExecutionTable.ExecutionID.UniqueName & " = " & myExecutionID
            Dim myRec As AgreementExecutionRecord = AgreementExecutionTable.GetRecord(myW)
            Dim myCIX As String = CStr(myRec.CIX)
            Dim mySenderSignerID As String = CStr(myRec.SenderSignerID)
            Dim myOIX As String = CStr(myRec.OIX)
            Dim myRecipientSignerID As String = CStr(myRec.RecipientSignerID)
            myW = CarrierAdActivityTable.ExecutionID.UniqueName & " = " & myExecutionID
            Dim myRec_AdActivity As CarrierAdActivityRecord = CarrierAdActivityTable.GetRecord(myW)
            Dim myAdActivityID As String = Nothing
            If Not IsNothing(myRec_AdActivity) Then
                myAdActivityID = CStr(myRec_AdActivity.AdActivityID)
            End If

            Dim mySproc As String = CustGenClass.f_Sproc("usp_ThreadGetInstance", "AgreementExecution", myFlowStepID, myExecutionID)
            Dim my1st As String = CustGenClass.f_Split_ByComma(mySproc, 1)
            Dim my2nd As String = CustGenClass.f_Split_ByComma(mySproc, 2)
            Dim myInstanceID As String = "0"

            If my1st = "Thread" Or my1st = "Instance" Then
                If my1st = "Thread" Then
                    myInstanceID = CustGenClass.f_Sproc("usp_ThreadInstanceAdd", my2nd, myCIX, mySenderSignerID, "Yes", "", myRecipientSignerID)
                    CustGenClass.s_InstanceRelatedIDsUpdate(myInstanceID, myExecutionID, myAdActivityID)
                Else
                    myInstanceID = my2nd
                End If
            End If

            If String.IsNullOrEmpty(myInstanceID) Then
                myInstanceID = CustGenClass.f_Sproc("usp_ThreadInstanceAdd", "5", "Null", myRecipientSignerID, "Yes")
            End If

            Dim myCollectionID As String = CustGenClass.f_FlowCollectionIDGet(myFlowStepID)

            Dim CIXName As String = CustGenClass.f_GetPartyName(mySenderSignerID)
            Dim OIXName As String = CustGenClass.f_GetPartyName(myRecipientSignerID)
            Dim Party As String = myRecipientSignerID

            Dim myAction As String

            If String.IsNullOrEmpty(myAdActivityID) Then
                myAction = "AgreementExecution"
            Else
                myAction = "AdActivity"
            End If

            Dim myMessageID As String = CustGenClass.f_URL_MessageCreate(myInstanceID, Nothing, myRecipientSignerID, mySenderSignerID, , "{CIXName}", CIXName, "{OIXName}", OIXName, , , , , , , , , , , myAdActivityID, myExecutionID, "37")
            CustGenClass.s_URL_Update(myMessageID, myCollectionID, , , myAction, , , myCIX, myOIX, myFlowStepID, Party, myRecipientSignerID, myMessageID, myInstanceID, , myExecutionID, , myAdActivityID)


        Catch ex As Exception

            Dim myMessage As String = ex.Message

        End Try

    End Sub

    Public Shared Function f_SendReply(ByVal myOldMessageID As String, ByVal myInstancePartyID As String, ByVal mySubject As String, ByVal myBody As String) As String

        Dim myW As String = ThreadInstanceMessageTable.MessageID.UniqueName & " = " & myOldMessageID
        Dim myR_Message As ThreadInstanceMessageRecord = ThreadInstanceMessageTable.GetRecord(myW)

        myW = ThreadInstancePartiesTable.InstancePartyID.UniqueName & " = " & myInstancePartyID
        Dim myR_InstanceParty As ThreadInstancePartiesRecord = ThreadInstancePartiesTable.GetRecord(myW)

        Dim myInstanceID As String = CStr(myR_Message.InstanceID)
        Dim mySenderID As String = CStr(myR_InstanceParty.UserId0)

        Dim myNewMessageID As String = CustGenClass.f_Sproc("usp_ThreadMessageAdd", myInstanceID, myBody, mySenderID, "Yes", mySubject)
        CustGenClass.f_Sproc("usp_ThreadMessage_CopyParams", myOldMessageID, myNewMessageID)

        Return myNewMessageID

    End Function


    Public Shared Function f_SendReply_ThreadID(ByVal myOldMessageID As String, ByVal myInstancePartyID As String, ByVal myThreadID As String) As String

        Dim myW As String = ThreadInstanceMessageTable.MessageID.UniqueName & " = " & myOldMessageID
        Dim myR_Message As ThreadInstanceMessageRecord = ThreadInstanceMessageTable.GetRecord(myW)

        myW = ThreadInstancePartiesTable.InstancePartyID.UniqueName & " = " & myInstancePartyID
        Dim myR_InstanceParty As ThreadInstancePartiesRecord = ThreadInstancePartiesTable.GetRecord(myW)

        Dim myInstanceID As String = CStr(myR_Message.InstanceID)
        Dim mySenderID As String = CStr(myR_InstanceParty.UserId0)

        Dim myExecutionID As String = CStr(myR_Message.Execution)
        Dim myRecipientID As String = CStr(myR_Message.RowOIX)
        If String.IsNullOrEmpty(myRecipientID) Then
            myRecipientID = CStr(myR_Message.Party)
        End If
        Dim myAdActivityID As String = CStr(myR_Message.AdActivity)

        Dim myNewMessageID As String = CustGenClass.f_URL_MessageCreate(myInstanceID, Nothing, mySenderID, myRecipientID, , , , , , , , , , , , , , , , myAdActivityID, myExecutionID, myThreadID)
        CustGenClass.f_Sproc("usp_ThreadMessage_CopyParams", myOldMessageID, myNewMessageID)

        Return myNewMessageID

    End Function

    Public Shared Function f_PDFInsertPage(ByVal pdfDocument As Aspose.Pdf.Document, ByVal pdfNewPage As Aspose.Pdf.Page, ByVal myPageNo As Integer) As Aspose.Pdf.Document

        Dim pageCount As Integer = 1
        Dim pdfNew As Aspose.Pdf.Document = New Aspose.Pdf.Document

        For Each pdfPage As Aspose.Pdf.Page In pdfDocument.Pages
            If pageCount = myPageNo Then
                pdfNew.Pages.Add(pdfNewPage)
            Else
                pdfNew.Pages.Add(pdfPage)
            End If
            pageCount += 1
        Next pdfPage

        If myPageNo = 0 Then
            pdfNew.Pages.Add(pdfNewPage)
        End If

        Return pdfNew

    End Function

    Public Shared Function f_PDFConcatenate(ByVal Pdf As Aspose.Pdf.Document, ByVal pdf2 As Aspose.Pdf.Document) As Aspose.Pdf.Document

        If Pdf.Pages.Count > 0 AndAlso pdf2.Pages.Count > 0 Then

            Try

                'add pages of second document to the first
                Pdf.Pages.Add(pdf2.Pages)

            Catch ex As Exception

            End Try

        ElseIf Pdf.Pages.Count = 0 And pdf2.Pages.Count > 0 Then

            Pdf = pdf2

        End If

        Return Pdf

    End Function

    Public Shared Function f_IsPDF(ByVal FileName As String) As Boolean

        'Checks whether a file is a PDF file or not
        Dim ItIsAPDF As Boolean = True
        Dim ItIsntAPDF As Boolean = False

        Dim FileSuffix As String = Right(FileName, 3)
        Select Case FileSuffix
            Case "PDF", "pdf"
                Return ItIsAPDF
            Case Else
                Return ItIsntAPDF
        End Select

    End Function

    Public Shared Function f_PDFSplit(ByVal pdfDocument As Aspose.Pdf.Document, ByVal myStartPage As Integer, ByVal myEndPage As Integer) As Aspose.Pdf.Document

        Dim pageCount As Integer = 1
        'loop through all the pages
        If pdfDocument.Pages.Count > 0 Then
            Dim newDocument As New Aspose.Pdf.Document
            For Each pdfPage As Page In pdfDocument.Pages
                If pageCount >= myStartPage And pageCount <= myEndPage Then
                    newDocument.Pages.Add(pdfPage)
                    newDocument.Save("page_" & pageCount & ".pdf")
                End If
                pageCount += 1
            Next pdfPage
            If newDocument.Pages.Count > 0 Then
                Return newDocument
            Else
                Return Nothing
            End If
        Else
            Return Nothing
        End If

    End Function

    Public Shared Function f_PDFToByteArray(ByVal pdfDocument As Aspose.Pdf.Document) As Byte()

        Dim myOutputMemoryStream As System.IO.MemoryStream = f_PDFToStream(pdfDocument)
        Dim myOutputByteArray As Byte() = myOutputMemoryStream.ToArray()
        Return myOutputByteArray

    End Function

    Public Shared Function f_PDFToStream(ByVal pdfDocument As Aspose.Pdf.Document) As System.IO.MemoryStream

        Dim myOutputMemoryStream As System.IO.MemoryStream = New System.IO.MemoryStream
        pdfDocument.Save(myOutputMemoryStream)
        Return myOutputMemoryStream

    End Function

    Public Shared Function f_ConvertPDFPageToByteArray(ByVal InputPDFPage As Aspose.Pdf.Page) As Byte()

        ' Converts a PDF file to a byte array

        Dim myPDF As Aspose.Pdf.Document = New Aspose.Pdf.Document()
        myPDF.Pages.Add(InputPDFPage)

        Dim myOutputMemoryStream As System.IO.MemoryStream = New System.IO.MemoryStream
        Dim myOutputByteArray As Byte()

        Try
            myPDF.Save(myOutputMemoryStream)
            myOutputByteArray = myOutputMemoryStream.ToArray()
            Return myOutputByteArray
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function f_JpgToPDF(ByVal myJpg As Byte()) As Byte()

        ''Instantiate a Pdf object by calling its empty constructor
        'Dim pdf1 As Aspose.Pdf.Generator.Pdf = New Aspose.Pdf.Generator.Pdf()

        ''Create a section in the Pdf object
        'Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

        ''Create an image object in the section
        'Dim image1 As Aspose.Pdf.Generator.Image = New Aspose.Pdf.Generator.Image(sec1)

        ''Add image object into the Paragraphs collection of the section
        'sec1.Paragraphs.Add(image1)

        ''Set the path of image file
        'image1.ImageInfo.ImageStream = New System.IO.MemoryStream(myJpg)

        ''Set the type of image using ImageFileType enumeration
        'image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg

        ''Save the Pdf 
        'Dim pdfMS As New System.IO.MemoryStream()
        'pdf1.Save(pdfMS)
        'Dim pdfByte As Byte() = pdfMS.ToArray()

        'Return pdfByte

        'open document
        Dim myAppPath As String = System.AppDomain.CurrentDomain.BaseDirectory
        Dim myPathFull As String = myAppPath & "Images\Custom\background.pdf"
        Dim pdfDocument As New Aspose.Pdf.Document(myPathFull)
        Dim page As Aspose.Pdf.Page = pdfDocument.Pages(1)

        Dim imageStream As MemoryStream = New System.IO.MemoryStream(myJpg)
        Dim bmp As New System.Drawing.Bitmap(imageStream)
        Dim bmpWidth As Integer = bmp.Width
        Dim bmpHeight As Integer = bmp.Height

        'set coordinates
        Dim lowerLeftX As Integer = 0
        Dim lowerLeftY As Integer = 0
        Dim upperRightX As Integer
        Dim upperRightY As Integer
        If bmpWidth > 650 Or bmpHeight > 842 Then
            Dim percentResize As Double
            If bmpHeight > 842 Then
                percentResize = (bmpHeight - 842) / bmpHeight
            ElseIf bmpWidth > 650 Then
                percentResize = (bmpWidth - 650) / bmpWidth
            End If
            upperRightX = Convert.ToInt32(bmpWidth - (bmpWidth * percentResize) - 40)
            upperRightY = Convert.ToInt32(bmpHeight - (bmpHeight * percentResize) - 40)
        Else
            upperRightX = bmpWidth
            upperRightY = bmpHeight
        End If

        'add image to Images collection of Page Resources
        page.Resources.Images.Add(imageStream)
        'using GSave operator: this operator saves current graphics state
        page.Contents.Add(New Aspose.Pdf.Operator.GSave())
        'create Rectangle and Matrix objects
        Dim rectangle As New Aspose.Pdf.Rectangle(lowerLeftX, lowerLeftY, upperRightX, upperRightY)
        Dim matrix As New Aspose.Pdf.DOM.Matrix(New Double() {rectangle.URX - rectangle.LLX, 0, 0, rectangle.URY - rectangle.LLY, rectangle.LLX, rectangle.LLY})
        'using ConcatenateMatrix (concatenate matrix) operator: defines how image must be placed
        page.Contents.Add(New Aspose.Pdf.Operator.ConcatenateMatrix(matrix))
        Dim ximage As Aspose.Pdf.XImage = page.Resources.Images(page.Resources.Images.Count)
        'using Do operator: this operator draws image
        page.Contents.Add(New Aspose.Pdf.Operator.Do(ximage.Name))
        'using GRestore operator: this operator restores graphics state
        page.Contents.Add(New Aspose.Pdf.Operator.GRestore())
        'save updated document
        Dim pdfMS As New System.IO.MemoryStream()
        pdfDocument.Save(pdfMS)
        Dim pdfByte As Byte() = pdfMS.ToArray()

        Return pdfByte

    End Function

    Public Shared Function f_BmpToPDF(ByVal myBmp As Byte()) As Byte()

        'Instantiate a Pdf object by calling its empty constructor
        Dim pdf1 As Aspose.Pdf.Generator.Pdf = New Aspose.Pdf.Generator.Pdf()

        'Create a section in the Pdf object
        Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

        'Create an image object in the section
        Dim image1 As Aspose.Pdf.Generator.Image = New Aspose.Pdf.Generator.Image(sec1)

        'Add image object into the Paragraphs collection of the section
        sec1.Paragraphs.Add(image1)

        'Set the path of image file
        image1.ImageInfo.ImageStream = New System.IO.MemoryStream(myBmp)

        'Set the type of image using ImageFileType enumeration
        image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Bmp

        'Save the Pdf 
        Dim pdfMS As New System.IO.MemoryStream()
        pdf1.Save(pdfMS)
        Dim pdfByte As Byte() = pdfMS.ToArray()

        Return pdfByte

    End Function
    Public Shared Function f_TiffToPDF(ByVal myTiff As Byte()) As Byte()

        'Instantiate a Pdf object by calling its empty constructor
        Dim pdf1 As Aspose.Pdf.Generator.Pdf = New Aspose.Pdf.Generator.Pdf()

        Dim mystream As New System.IO.MemoryStream(myTiff)
        Dim b As New Bitmap(mystream)

        'Create a new section in the Pdf document
        Dim sec1 As New Aspose.Pdf.Generator.Section(pdf1)

        'Set margins so image will fit, etc.
        sec1.PageInfo.Margin.Top = 5
        sec1.PageInfo.Margin.Bottom = 5
        sec1.PageInfo.Margin.Left = 5
        sec1.PageInfo.Margin.Right = 5

        sec1.PageInfo.PageWidth = (b.Width / b.HorizontalResolution) * 72
        sec1.PageInfo.PageHeight = (b.Height / b.VerticalResolution) * 72
        'Add the section in the sections collection of the Pdf document
        pdf1.Sections.Add(sec1)

        'Create an image object
        Dim image1 As New Aspose.Pdf.Generator.Image(sec1)

        'Add the image into paragraphs collection of the section
        sec1.Paragraphs.Add(image1)
        image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Tiff
        'set IsBlackWhite property to true for performance improvement
        image1.ImageInfo.IsBlackWhite = True
        'Set the ImageStream to a MemoryStream object
        image1.ImageInfo.ImageStream = mystream
        'Set desired image scale
        image1.ImageScale = 0.95F

        'Save the Pdf 
        Dim pdfMS As New System.IO.MemoryStream()
        pdf1.Save(pdfMS)
        Dim pdfByte As Byte() = pdfMS.ToArray()

        Return pdfByte

    End Function

    Public Shared Function f_PDFtoJpgByte(ByVal myPDF As Aspose.Pdf.Document) As Byte()

        Dim jpgMS As MemoryStream = New MemoryStream()

        Dim myPDFPageEditor As New Aspose.Pdf.Facades.PdfPageEditor()
        myPDFPageEditor.BindPdf(myPDF)
        Dim resolution As New Aspose.Pdf.Devices.Resolution(150)

        Dim jpegDevice As New JpegDevice(816, 1056, resolution, 25)

        'convert a particular page and save the image to stream
        jpegDevice.Process(myPDF.Pages(1), jpgMS)

        Dim jpgByte As Byte() = jpgMS.ToArray()

        Return jpgByte

    End Function

    Public Shared Function f_DocRequest_GenerateDoc(ByVal myDocName As String) As Aspose.Words.Document

        Dim ReturnDoc As New Document
        Dim buffer() As Byte
        Dim myFileName As String

        Dim myW As String = GlobalTable.GlobalID.UniqueName & " = 6"
        Dim myR As GlobalRecord = GlobalTable.GetRecord(myW)
        buffer = CType(myR.GlobalFile, Byte())
        myFileName = "Docs_To_Provide.pdf"

        If buffer.Length > 0 Then

            Dim newStream As New System.IO.MemoryStream(buffer)
            Dim doc As New Document(newStream)

            doc.MailMerge.FieldMergingCallback = New HandleMergeImageFieldFromBlob()
            doc.MailMerge.FieldMergingCallback = New HandleMergeFields()

            Try

                doc.MailMerge.Execute(New String() {"DocName"}, _
                                      New Object() {myDocName})


                ReturnDoc = doc

            Catch ex As Exception

                Dim myMessage As String = ex.Message

            End Try

        End If

        Return ReturnDoc

    End Function

    Public Shared Function f_DocRequest_GeneratePDF(ByVal myDocID As String, ByVal myDocName As String) As Aspose.Pdf.Document

        Dim myDoc As Aspose.Words.Document = f_DocRequest_GenerateDoc(myDocName)
        Dim myDocMS As New System.IO.MemoryStream()
        myDoc.Save(myDocMS, SaveFormat.Bmp)
        Dim myDocByte As Byte() = myDocMS.ToArray()
        Dim myDocBarCoded As Byte() = f_BmpCombine(myDocByte, f_BarCodeCreate(myDocID, "1", "D"), , , 350, 955)

        Dim myPdfMS As System.IO.MemoryStream = New System.IO.MemoryStream(f_BmpToPDF(myDocBarCoded))
        Dim pdfDoc As Aspose.Pdf.Document = New Aspose.Pdf.Document(myPdfMS)

        Return pdfDoc

    End Function

    Public Shared Sub s_RotateImage(ByVal myArray() As String, ByVal target As String)

        Dim index As Integer = 0
        While index < myArray.Length
            Dim myPageID As String = myArray(index)
            Dim myW As String = DocPageTable.PageID.UniqueName & " = " & myPageID
            Dim myR As DocPageRecord = DocPageTable.GetRecord(myW)
            Dim myDocImage As Byte() = CType(myR.DocFile, Byte())
            Dim ms As MemoryStream = New MemoryStream(myDocImage)
            Dim myNewImage As New Bitmap(ms)
            If target = "Rotate90RB" Then
                myNewImage.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Else
                myNewImage.RotateFlip(RotateFlipType.Rotate180FlipNone)
            End If
            ms.Close()
            Dim outStream As New MemoryStream()
            myNewImage.Save(outStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim myNewImageByte As Byte() = outStream.ToArray()
            CustGenClass.f_Sproc_ImageIn("usp_DocPageUpdate", myNewImageByte, myPageID)
            outStream.Close()
            ms.Dispose()
            outStream.Dispose()
            index = index + 1
        End While
    End Sub

    Public Shared Sub s_ModifyJpg(ByVal pageAsJpg As Byte(), ByVal myDocID As String, ByVal myUserID As String)

        Dim myPageID As String = "Nothing"
        Dim pageAsSmallJpg As Byte()
        Dim bmp As New Bitmap(New System.IO.MemoryStream(pageAsJpg))
        Dim bmpWidth As Integer = Convert.ToInt32(bmp.Width.ToString)
        Dim bmpHeight As Integer = Convert.ToInt32(bmp.Height.ToString)
        Dim bmpResolution As Integer = Convert.ToInt32(bmp.HorizontalResolution)
        If bmpResolution <> 200 Then
            bmpWidth = Convert.ToInt32(bmpWidth * 200 / bmpResolution)
            bmpHeight = Convert.ToInt32(bmpHeight * 200 / bmpResolution)
            bmpResolution = 200
        End If
        Dim modifiedJpg As Byte() = Nothing
        Dim percentResize As Double = 1 - (80 / bmpResolution)
        Dim bmpRatioDiff As Double = Math.Abs(bmpWidth / bmpHeight - 816 / 1056)
        If bmpRatioDiff > 0.05 Then
            modifiedJpg = f_FormatJpg(pageAsJpg, bmpWidth, bmpHeight)
            pageAsSmallJpg = f_ResizeImage(modifiedJpg, percentResize)
            myPageID = CustGenClass.f_Sproc_ImageIn("usp_DocPageAdd_WithImage", modifiedJpg, myDocID, "0", myUserID)
        Else
            pageAsSmallJpg = f_ResizeImage(pageAsJpg, percentResize)
            myPageID = CustGenClass.f_Sproc_ImageIn("usp_DocPageAdd_WithImage", pageAsJpg, myDocID, "0", myUserID)
        End If
        CustGenClass.f_Sproc_ImageIn("usp_DocPageSmallUpdate", pageAsSmallJpg, myPageID)
    End Sub

#End Region

End Class

#Region "Aspose Bitmap Converter"

'a class implementing IIndexBimapConverter
Public Class WinAPIIndexBitmapConverter
    Implements Aspose.Pdf.IIndexBitmapConverter
    Public Function Get1BppImage(ByVal src As Bitmap) As Bitmap Implements Aspose.Pdf.IIndexBitmapConverter.Get1BppImage
        Return CopyToBpp(src, 1)
    End Function

    Public Function Get4BppImage(ByVal src As Bitmap) As Bitmap Implements Aspose.Pdf.IIndexBitmapConverter.Get4BppImage
        Return CopyToBpp(src, 4)
    End Function

    Public Function Get8BppImage(ByVal src As Bitmap) As Bitmap Implements Aspose.Pdf.IIndexBitmapConverter.Get8BppImage
        Return CopyToBpp(src, 8)
    End Function

    <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
    Public Shared Function DeleteObject(ByVal hObject As IntPtr) As Boolean
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Public Shared Function GetDC(ByVal hwnd As IntPtr) As IntPtr
    End Function

    <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
    Public Shared Function CreateCompatibleDC(ByVal hdc As IntPtr) As IntPtr
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Public Shared Function ReleaseDC(ByVal hwnd As IntPtr, ByVal hdc As IntPtr) As Integer
    End Function

    <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
    Public Shared Function DeleteDC(ByVal hdc As IntPtr) As Integer
    End Function

    <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
    Public Shared Function SelectObject(ByVal hdc As IntPtr, ByVal hgdiobj As IntPtr) As IntPtr
    End Function

    <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
    Public Shared Function BitBlt(ByVal hdcDst As IntPtr, ByVal xDst As Integer, ByVal yDst As Integer, ByVal w As Integer, ByVal h As Integer, ByVal hdcSrc As IntPtr, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal rop As Integer) As Integer
    End Function
    Private Shared SRCCOPY As Integer = &HCC0020

    <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
    Shared Function CreateDIBSection(ByVal hdc As IntPtr, ByRef bmi As BITMAPINFO, ByVal Usage As UInteger, <System.Runtime.InteropServices.Out()> ByRef bits As IntPtr, ByVal hSection As IntPtr, ByVal dwOffset As UInteger) As IntPtr
    End Function
    Private Shared BI_RGB As UInteger = 0
    Private Shared DIB_RGB_COLORS As UInteger = 0
    <System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)> _
    Public Structure BITMAPINFO
        Public biSize As UInteger
        Public biWidth, biHeight As Integer
        Public biPlanes, biBitCount As Short
        Public biCompression, biSizeImage As UInteger
        Public biXPelsPerMeter, biYPelsPerMeter As Integer
        Public biClrUsed, biClrImportant As UInteger
        <System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=256)> _
        Public cols() As UInteger
    End Structure

    Private Shared Function MAKERGB(ByVal r As Integer, ByVal g As Integer, ByVal b As Integer) As UInteger
        Return (CUInt(b And 255)) Or (CUInt((r And 255) << 8)) Or (CUInt((g And 255) << 16))
    End Function

    Private Function CopyToBpp(ByVal b As System.Drawing.Bitmap, ByVal bpp As Integer) As Bitmap
        If bpp <> 1 AndAlso bpp <> 8 AndAlso bpp <> 4 Then
            Throw New System.ArgumentException("1 or 4 or 8 ", "bpp")
        End If

        ' Plan: built into Windows GDI is the ability to convert
        ' bitmaps from one format to another. Most of the time, this
        ' job is actually done by the graphics hardware accelerator card
        ' and so is extremely fast. The rest of the time, the job is done by
        ' very fast native code.
        ' We will call into this GDI functionality from C#. Our plan:
        ' (1) Convert our Bitmap into a GDI hbitmap (ie. copy unmanaged->managed)
        ' (2) Create a GDI monochrome hbitmap
        ' (3) Use GDI "BitBlt" function to copy from hbitmap into monochrome (as above)
        ' (4) Convert the monochrone hbitmap into a Bitmap (ie. copy unmanaged->managed)

        Dim w As Integer = b.Width, h As Integer = b.Height
        Dim hbm As IntPtr = b.GetHbitmap() ' this is step (1)
        '
        ' Step (2): create the monochrome bitmap.
        ' "BITMAPINFO" is an interop-struct which we define below.
        ' In GDI terms, it's a BITMAPHEADERINFO followed by an array of two RGBQUADs
        Dim bmi As New BITMAPINFO()
        bmi.biSize = 40 ' the size of the BITMAPHEADERINFO struct
        bmi.biWidth = w
        bmi.biHeight = h
        bmi.biPlanes = 1 ' "planes" are confusing. We always use just 1. Read MSDN for more info.
        bmi.biBitCount = CShort(Fix(bpp)) ' ie. 1bpp or 8bpp
        bmi.biCompression = BI_RGB ' ie. the pixels in our RGBQUAD table are stored as RGBs, not palette indexes
        bmi.biSizeImage = CUInt(((w + 7) And &HFFFFFFF8L) * h \ 8)
        bmi.biXPelsPerMeter = 1000000 ' not really important
        bmi.biYPelsPerMeter = 1000000 ' not really important
        ' Now for the colour table.
        Dim ncols As UInteger = CUInt(1) << bpp ' 2 colours for 1bpp; 256 colours for 8bpp
        bmi.biClrUsed = ncols
        bmi.biClrImportant = ncols
        bmi.cols = New UInteger(255) {} ' The structure always has fixed size 256, even if we end up using fewer colours
        If bpp = 1 Then
            bmi.cols(0) = MAKERGB(0, 0, 0)
            bmi.cols(1) = MAKERGB(255, 255, 255)
        ElseIf bpp = 4 Then
            ' For 8bpp we've created an palette with just greyscale colours.
            ' You can set up any palette you want here. Here are some possibilities:
            ' rainbow: 
            bmi.biClrUsed = 16
            bmi.biClrImportant = 16
            Dim colv() As Integer = {8, 24, 38, 56, 72, 88, 104, 120, 136, 152, 168, 184, 210, 216, 232, 248}
            '          
            For i As Integer = 0 To 15
                bmi.cols(i) = MAKERGB(colv(i), colv(i), colv(i))
            Next i
        ElseIf bpp = 8 Then
            ' For 8bpp we've created an palette with just greyscale colours.
            ' You can set up any palette you want here. Here are some possibilities:
            ' rainbow:
            bmi.biClrUsed = 216
            bmi.biClrImportant = 216
            Dim colv As Integer() = New Integer(5) {0, 51, 102, 153, 204, 255}


            For i As Integer = 0 To 215
                bmi.cols(i) = MAKERGB(colv(i \ 36), colv((i \ 6) Mod 6), colv(i Mod 6))
            Next i
            ' optimal: a difficult topic: http://en.wikipedia.org/wiki/Color_quantization
        End If

        ' 
        ' Now create the indexed bitmap "hbm0"
        Dim bits0 As IntPtr ' not used for our purposes. It returns a pointer to the raw bits that make up the bitmap.
        Dim hbm0 As IntPtr = CreateDIBSection(IntPtr.Zero, bmi, DIB_RGB_COLORS, bits0, IntPtr.Zero, 0)
        '
        ' Step (3): use GDI's BitBlt function to copy from original hbitmap into monocrhome bitmap
        ' GDI programming is kind of confusing... nb. The GDI equivalent of "Graphics" is called a "DC".
        Dim sdc As IntPtr = GetDC(IntPtr.Zero) ' First we obtain the DC for the screen
        ' Next, create a DC for the original hbitmap
        Dim hdc As IntPtr = CreateCompatibleDC(sdc)
        SelectObject(hdc, hbm)
        ' and create a DC for the monochrome hbitmap
        Dim hdc0 As IntPtr = CreateCompatibleDC(sdc)
        SelectObject(hdc0, hbm0)
        ' Now we can do the BitBlt:
        BitBlt(hdc0, 0, 0, w, h, hdc, 0, 0, SRCCOPY)
        ' Step (4): convert this monochrome hbitmap back into a Bitmap:
        Dim b0 As Bitmap = Image.FromHbitmap(hbm0)
        '
        ' Finally some cleanup.
        DeleteDC(hdc)
        DeleteDC(hdc0)
        ReleaseDC(IntPtr.Zero, sdc)
        DeleteObject(hbm)
        DeleteObject(hbm0)
        '
        Return b0
    End Function
End Class


#End Region
