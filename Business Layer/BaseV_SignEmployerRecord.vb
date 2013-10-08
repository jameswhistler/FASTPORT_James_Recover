' This class is "generated" and will be overwritten.
' Your customizations should be made in V_SignEmployerRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_SignEmployerRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_SignEmployerView"></see> class.
''' </remarks>
''' <seealso cref="V_SignEmployerView"></seealso>
''' <seealso cref="V_SignEmployerRecord"></seealso>

<Serializable()> Public Class BaseV_SignEmployerRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_SignEmployerView = V_SignEmployerView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_SignEmployerRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_SignEmployerRec As V_SignEmployerRecord = CType(sender,V_SignEmployerRecord)
        Validate_Inserting()
        If Not V_SignEmployerRec Is Nothing AndAlso Not V_SignEmployerRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_SignEmployerRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_SignEmployerRec As V_SignEmployerRecord = CType(sender,V_SignEmployerRecord)
        Validate_Updating()
        If Not V_SignEmployerRec Is Nothing AndAlso Not V_SignEmployerRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_SignEmployerRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_SignEmployerRec As V_SignEmployerRecord = CType(sender,V_SignEmployerRecord)
        If Not V_SignEmployerRec Is Nothing AndAlso Not V_SignEmployerRec.IsReadOnly Then
                End If
    End Sub
    
   'Evaluates Validate when->Inserting formulas specified at the data access layer
   Public Overridable Sub Validate_Inserting ()
		Dim fullValidationMessage As String = ""
		Dim validationMessage As String = ""

		dim formula as String = ""


		If validationMessage <> "" AndAlso validationMessage.ToLower() <> "true" Then
			fullValidationMessage &= validationMessage & vbCrLf
		End If

		If fullValidationMessage <> "" Then
			Throw New Exception(fullValidationMessage)
		End If 
	End Sub
	
	'Evaluates Validate when->Updating formulas specified at the data access layer
   Public Overridable Sub Validate_Updating ()
		Dim fullValidationMessage As String = ""
		Dim validationMessage As String = ""

		dim formula as String = ""


		If validationMessage <> "" AndAlso validationMessage.ToLower() <> "true" Then
			fullValidationMessage &= validationMessage & vbCrLf
		End If

		If fullValidationMessage <> "" Then
			Throw New Exception(fullValidationMessage)
		End If 
	End Sub
 
	Public Overridable Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format As String = Nothing) As String

		Dim e As Data.BaseFormulaEvaluator = New Data.BaseFormulaEvaluator()

            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If
        	Return resultObj.ToString()
	End Function







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.VerificationID field.
	''' </summary>
	Public Function GetVerificationIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.VerificationIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.VerificationID field.
	''' </summary>
	Public Function GetVerificationIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.VerificationIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.VerificationID field.
	''' </summary>
	Public Sub SetVerificationIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VerificationIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.VerificationID field.
	''' </summary>
	Public Sub SetVerificationIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.VerificationIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.VerificationID field.
	''' </summary>
	Public Sub SetVerificationIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VerificationIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.VerificationID field.
	''' </summary>
	Public Sub SetVerificationIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VerificationIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.VerificationID field.
	''' </summary>
	Public Sub SetVerificationIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VerificationIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.HistoryID field.
	''' </summary>
	Public Function GetHistoryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.HistoryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.HistoryID field.
	''' </summary>
	Public Function GetHistoryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HistoryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_Name field.
	''' </summary>
	Public Function GetE_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_Name field.
	''' </summary>
	Public Function GetE_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_Name field.
	''' </summary>
	Public Sub SetE_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_Name field.
	''' </summary>
	Public Sub SetE_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_DBA field.
	''' </summary>
	Public Function GetE_DBAValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_DBAColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_DBA field.
	''' </summary>
	Public Function GetE_DBAFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_DBAColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_DBA field.
	''' </summary>
	Public Sub SetE_DBAFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_DBAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_DBA field.
	''' </summary>
	Public Sub SetE_DBAFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_DBAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_DBAOrName field.
	''' </summary>
	Public Function GetE_DBAOrNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_DBAOrNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_DBAOrName field.
	''' </summary>
	Public Function GetE_DBAOrNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_DBAOrNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_DBAOrName field.
	''' </summary>
	Public Sub SetE_DBAOrNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_DBAOrNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_DBAOrName field.
	''' </summary>
	Public Sub SetE_DBAOrNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_DBAOrNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_AddrHTML field.
	''' </summary>
	Public Function GetE_AddrHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_AddrHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_AddrHTML field.
	''' </summary>
	Public Function GetE_AddrHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_AddrHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_AddrHTML field.
	''' </summary>
	Public Sub SetE_AddrHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_AddrHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_AddrHTML field.
	''' </summary>
	Public Sub SetE_AddrHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_AddrHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_Addr field.
	''' </summary>
	Public Function GetE_AddrValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_AddrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_Addr field.
	''' </summary>
	Public Function GetE_AddrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_AddrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_Addr field.
	''' </summary>
	Public Sub SetE_AddrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_Addr field.
	''' </summary>
	Public Sub SetE_AddrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_CitySTZip field.
	''' </summary>
	Public Function GetE_CitySTZipValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_CitySTZipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_CitySTZip field.
	''' </summary>
	Public Function GetE_CitySTZipFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_CitySTZipColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_CitySTZip field.
	''' </summary>
	Public Sub SetE_CitySTZipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_CitySTZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_CitySTZip field.
	''' </summary>
	Public Sub SetE_CitySTZipFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_CitySTZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_City field.
	''' </summary>
	Public Function GetE_CityValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_CityColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_City field.
	''' </summary>
	Public Function GetE_CityFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_CityColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_City field.
	''' </summary>
	Public Sub SetE_CityFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_CityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_City field.
	''' </summary>
	Public Sub SetE_CityFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_CityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_ST field.
	''' </summary>
	Public Function GetE_STValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_STColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_ST field.
	''' </summary>
	Public Function GetE_STFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_STColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_ST field.
	''' </summary>
	Public Sub SetE_STFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_STColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_ST field.
	''' </summary>
	Public Sub SetE_STFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_STColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_Zip field.
	''' </summary>
	Public Function GetE_ZipValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_ZipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_Zip field.
	''' </summary>
	Public Function GetE_ZipFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_ZipColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_Zip field.
	''' </summary>
	Public Sub SetE_ZipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_ZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_Zip field.
	''' </summary>
	Public Sub SetE_ZipFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_ZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_Country field.
	''' </summary>
	Public Function GetE_CountryValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_CountryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_Country field.
	''' </summary>
	Public Function GetE_CountryFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_CountryColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_Country field.
	''' </summary>
	Public Sub SetE_CountryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_Country field.
	''' </summary>
	Public Sub SetE_CountryFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_ContactInfoHTML field.
	''' </summary>
	Public Function GetE_ContactInfoHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_ContactInfoHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_ContactInfoHTML field.
	''' </summary>
	Public Function GetE_ContactInfoHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_ContactInfoHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_ContactInfoHTML field.
	''' </summary>
	Public Sub SetE_ContactInfoHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_ContactInfoHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_ContactInfoHTML field.
	''' </summary>
	Public Sub SetE_ContactInfoHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_ContactInfoHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_EmploymentDates field.
	''' </summary>
	Public Function GetE_EmploymentDatesValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_EmploymentDatesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_EmploymentDates field.
	''' </summary>
	Public Function GetE_EmploymentDatesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_EmploymentDatesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_EmploymentDates field.
	''' </summary>
	Public Sub SetE_EmploymentDatesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_EmploymentDatesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_EmploymentDates field.
	''' </summary>
	Public Sub SetE_EmploymentDatesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_EmploymentDatesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_VerQuestions field.
	''' </summary>
	Public Function GetE_VerQuestionsValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_VerQuestionsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_VerQuestions field.
	''' </summary>
	Public Function GetE_VerQuestionsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_VerQuestionsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_VerQuestions field.
	''' </summary>
	Public Sub SetE_VerQuestionsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_VerQuestionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_VerQuestions field.
	''' </summary>
	Public Sub SetE_VerQuestionsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_VerQuestionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_TruckingInfoYesNo field.
	''' </summary>
	Public Function GetE_TruckingInfoYesNoValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_TruckingInfoYesNoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_TruckingInfoYesNo field.
	''' </summary>
	Public Function GetE_TruckingInfoYesNoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_TruckingInfoYesNoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_TruckingInfoYesNo field.
	''' </summary>
	Public Sub SetE_TruckingInfoYesNoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_TruckingInfoYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_TruckingInfoYesNo field.
	''' </summary>
	Public Sub SetE_TruckingInfoYesNoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_TruckingInfoYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_TruckingInfoExplain field.
	''' </summary>
	Public Function GetE_TruckingInfoExplainValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_TruckingInfoExplainColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_TruckingInfoExplain field.
	''' </summary>
	Public Function GetE_TruckingInfoExplainFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_TruckingInfoExplainColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_TruckingInfoExplain field.
	''' </summary>
	Public Sub SetE_TruckingInfoExplainFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_TruckingInfoExplainColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_TruckingInfoExplain field.
	''' </summary>
	Public Sub SetE_TruckingInfoExplainFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_TruckingInfoExplainColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_GeneralComments field.
	''' </summary>
	Public Function GetE_GeneralCommentsValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_GeneralCommentsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_GeneralComments field.
	''' </summary>
	Public Function GetE_GeneralCommentsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_GeneralCommentsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_GeneralComments field.
	''' </summary>
	Public Sub SetE_GeneralCommentsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_GeneralCommentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_GeneralComments field.
	''' </summary>
	Public Sub SetE_GeneralCommentsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_GeneralCommentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_Signer field.
	''' </summary>
	Public Function GetE_SignerValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_SignerColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_Signer field.
	''' </summary>
	Public Function GetE_SignerFieldValue() As String
		Return CType(Me.GetValue(TableUtils.E_SignerColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_Signer field.
	''' </summary>
	Public Sub SetE_SignerFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_SignerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_Signer field.
	''' </summary>
	Public Sub SetE_SignerFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_SignerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_Signature field.
	''' </summary>
	Public Function GetE_SignatureValue() As ColumnValue
		Return Me.GetValue(TableUtils.E_SignatureColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEmployer_.E_Signature field.
	''' </summary>
	Public Function GetE_SignatureFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.E_SignatureColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_Signature field.
	''' </summary>
	Public Sub SetE_SignatureFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.E_SignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_Signature field.
	''' </summary>
	Public Sub SetE_SignatureFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.E_SignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEmployer_.E_Signature field.
	''' </summary>
	Public Sub SetE_SignatureFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.E_SignatureColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.VerificationID field.
	''' </summary>
	Public Property VerificationID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.VerificationIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.VerificationIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property VerificationIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.VerificationIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property VerificationIDDefault() As String
        Get
            Return TableUtils.VerificationIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.HistoryID field.
	''' </summary>
	Public Property HistoryID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HistoryIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HistoryIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HistoryIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HistoryIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HistoryIDDefault() As String
        Get
            Return TableUtils.HistoryIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.PartyID field.
	''' </summary>
	Public Property PartyID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PartyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PartyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PartyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PartyIDDefault() As String
        Get
            Return TableUtils.PartyIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_Name field.
	''' </summary>
	Public Property E_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_NameDefault() As String
        Get
            Return TableUtils.E_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_DBA field.
	''' </summary>
	Public Property E_DBA() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_DBAColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_DBAColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_DBASpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_DBAColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_DBADefault() As String
        Get
            Return TableUtils.E_DBAColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_DBAOrName field.
	''' </summary>
	Public Property E_DBAOrName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_DBAOrNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_DBAOrNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_DBAOrNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_DBAOrNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_DBAOrNameDefault() As String
        Get
            Return TableUtils.E_DBAOrNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_AddrHTML field.
	''' </summary>
	Public Property E_AddrHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_AddrHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_AddrHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_AddrHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_AddrHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_AddrHTMLDefault() As String
        Get
            Return TableUtils.E_AddrHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_Addr field.
	''' </summary>
	Public Property E_Addr() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_AddrColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_AddrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_AddrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_AddrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_AddrDefault() As String
        Get
            Return TableUtils.E_AddrColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_CitySTZip field.
	''' </summary>
	Public Property E_CitySTZip() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_CitySTZipColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_CitySTZipColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_CitySTZipSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_CitySTZipColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_CitySTZipDefault() As String
        Get
            Return TableUtils.E_CitySTZipColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_City field.
	''' </summary>
	Public Property E_City() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_CityColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_CityColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_CitySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_CityColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_CityDefault() As String
        Get
            Return TableUtils.E_CityColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_ST field.
	''' </summary>
	Public Property E_ST() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_STColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_STColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_STSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_STColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_STDefault() As String
        Get
            Return TableUtils.E_STColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_Zip field.
	''' </summary>
	Public Property E_Zip() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_ZipColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_ZipColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_ZipSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_ZipColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_ZipDefault() As String
        Get
            Return TableUtils.E_ZipColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_Country field.
	''' </summary>
	Public Property E_Country() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_CountryColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_CountryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_CountrySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_CountryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_CountryDefault() As String
        Get
            Return TableUtils.E_CountryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_ContactInfoHTML field.
	''' </summary>
	Public Property E_ContactInfoHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_ContactInfoHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_ContactInfoHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_ContactInfoHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_ContactInfoHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_ContactInfoHTMLDefault() As String
        Get
            Return TableUtils.E_ContactInfoHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_EmploymentDates field.
	''' </summary>
	Public Property E_EmploymentDates() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_EmploymentDatesColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_EmploymentDatesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_EmploymentDatesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_EmploymentDatesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_EmploymentDatesDefault() As String
        Get
            Return TableUtils.E_EmploymentDatesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_VerQuestions field.
	''' </summary>
	Public Property E_VerQuestions() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_VerQuestionsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_VerQuestionsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_VerQuestionsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_VerQuestionsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_VerQuestionsDefault() As String
        Get
            Return TableUtils.E_VerQuestionsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_TruckingInfoYesNo field.
	''' </summary>
	Public Property E_TruckingInfoYesNo() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_TruckingInfoYesNoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_TruckingInfoYesNoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_TruckingInfoYesNoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_TruckingInfoYesNoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_TruckingInfoYesNoDefault() As String
        Get
            Return TableUtils.E_TruckingInfoYesNoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_TruckingInfoExplain field.
	''' </summary>
	Public Property E_TruckingInfoExplain() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_TruckingInfoExplainColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_TruckingInfoExplainColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_TruckingInfoExplainSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_TruckingInfoExplainColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_TruckingInfoExplainDefault() As String
        Get
            Return TableUtils.E_TruckingInfoExplainColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_GeneralComments field.
	''' </summary>
	Public Property E_GeneralComments() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_GeneralCommentsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_GeneralCommentsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_GeneralCommentsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_GeneralCommentsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_GeneralCommentsDefault() As String
        Get
            Return TableUtils.E_GeneralCommentsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_Signer field.
	''' </summary>
	Public Property E_Signer() As String
		Get 
			Return CType(Me.GetValue(TableUtils.E_SignerColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.E_SignerColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_SignerSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_SignerColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_SignerDefault() As String
        Get
            Return TableUtils.E_SignerColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEmployer_.E_Signature field.
	''' </summary>
	Public Property E_Signature() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.E_SignatureColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.E_SignatureColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property E_SignatureSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.E_SignatureColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property E_SignatureDefault() As String
        Get
            Return TableUtils.E_SignatureColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
