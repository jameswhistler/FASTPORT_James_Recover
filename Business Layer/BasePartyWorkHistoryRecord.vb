' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyWorkHistoryRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PartyWorkHistoryRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="PartyWorkHistoryTable"></see> class.
''' </remarks>
''' <seealso cref="PartyWorkHistoryTable"></seealso>
''' <seealso cref="PartyWorkHistoryRecord"></seealso>

<Serializable()> Public Class BasePartyWorkHistoryRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As PartyWorkHistoryTable = PartyWorkHistoryTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub PartyWorkHistoryRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim PartyWorkHistoryRec As PartyWorkHistoryRecord = CType(sender,PartyWorkHistoryRecord)
        Validate_Inserting()
        If Not PartyWorkHistoryRec Is Nothing AndAlso Not PartyWorkHistoryRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub PartyWorkHistoryRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim PartyWorkHistoryRec As PartyWorkHistoryRecord = CType(sender,PartyWorkHistoryRecord)
        Validate_Updating()
        If Not PartyWorkHistoryRec Is Nothing AndAlso Not PartyWorkHistoryRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub PartyWorkHistoryRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim PartyWorkHistoryRec As PartyWorkHistoryRecord = CType(sender,PartyWorkHistoryRecord)
        If Not PartyWorkHistoryRec Is Nothing AndAlso Not PartyWorkHistoryRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.HistoryID field.
	''' </summary>
	Public Function GetHistoryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.HistoryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.HistoryID field.
	''' </summary>
	Public Function GetHistoryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HistoryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.StartMonthID field.
	''' </summary>
	Public Function GetStartMonthIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.StartMonthIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.StartMonthID field.
	''' </summary>
	Public Function GetStartMonthIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.StartMonthIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.StartMonthID field.
	''' </summary>
	Public Sub SetStartMonthIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StartMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.StartMonthID field.
	''' </summary>
	Public Sub SetStartMonthIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.StartMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.StartMonthID field.
	''' </summary>
	Public Sub SetStartMonthIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StartMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.StartMonthID field.
	''' </summary>
	Public Sub SetStartMonthIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StartMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.StartMonthID field.
	''' </summary>
	Public Sub SetStartMonthIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StartMonthIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EndMonthID field.
	''' </summary>
	Public Function GetEndMonthIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EndMonthIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EndMonthID field.
	''' </summary>
	Public Function GetEndMonthIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EndMonthIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EndMonthID field.
	''' </summary>
	Public Sub SetEndMonthIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EndMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EndMonthID field.
	''' </summary>
	Public Sub SetEndMonthIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EndMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EndMonthID field.
	''' </summary>
	Public Sub SetEndMonthIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EndMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EndMonthID field.
	''' </summary>
	Public Sub SetEndMonthIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EndMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EndMonthID field.
	''' </summary>
	Public Sub SetEndMonthIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EndMonthIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.Employed field.
	''' </summary>
	Public Function GetEmployedValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.Employed field.
	''' </summary>
	Public Function GetEmployedFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.EmployedColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.Employed field.
	''' </summary>
	Public Sub SetEmployedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.Employed field.
	''' </summary>
	Public Sub SetEmployedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EmployedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.Employed field.
	''' </summary>
	Public Sub SetEmployedFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployedColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.DrivingPosition field.
	''' </summary>
	Public Function GetDrivingPositionValue() As ColumnValue
		Return Me.GetValue(TableUtils.DrivingPositionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.DrivingPosition field.
	''' </summary>
	Public Function GetDrivingPositionFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.DrivingPositionColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.DrivingPosition field.
	''' </summary>
	Public Sub SetDrivingPositionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DrivingPositionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.DrivingPosition field.
	''' </summary>
	Public Sub SetDrivingPositionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DrivingPositionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.DrivingPosition field.
	''' </summary>
	Public Sub SetDrivingPositionFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DrivingPositionColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerID field.
	''' </summary>
	Public Function GetEmployerIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerID field.
	''' </summary>
	Public Function GetEmployerIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EmployerIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerID field.
	''' </summary>
	Public Sub SetEmployerIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerID field.
	''' </summary>
	Public Sub SetEmployerIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EmployerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerID field.
	''' </summary>
	Public Sub SetEmployerIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerID field.
	''' </summary>
	Public Sub SetEmployerIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerID field.
	''' </summary>
	Public Sub SetEmployerIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerCompany field.
	''' </summary>
	Public Function GetEmployerCompanyValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerCompanyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerCompany field.
	''' </summary>
	Public Function GetEmployerCompanyFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerCompanyColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerCompany field.
	''' </summary>
	Public Sub SetEmployerCompanyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerCompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerCompany field.
	''' </summary>
	Public Sub SetEmployerCompanyFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerCompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerAddr field.
	''' </summary>
	Public Function GetEmployerAddrValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerAddrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerAddr field.
	''' </summary>
	Public Function GetEmployerAddrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerAddrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerAddr field.
	''' </summary>
	Public Sub SetEmployerAddrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerAddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerAddr field.
	''' </summary>
	Public Sub SetEmployerAddrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerAddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerZipID field.
	''' </summary>
	Public Function GetEmployerZipIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerZipIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerZipID field.
	''' </summary>
	Public Function GetEmployerZipIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EmployerZipIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerZipID field.
	''' </summary>
	Public Sub SetEmployerZipIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerZipID field.
	''' </summary>
	Public Sub SetEmployerZipIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EmployerZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerZipID field.
	''' </summary>
	Public Sub SetEmployerZipIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerZipID field.
	''' </summary>
	Public Sub SetEmployerZipIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerZipID field.
	''' </summary>
	Public Sub SetEmployerZipIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerZipIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerCountryID field.
	''' </summary>
	Public Function GetEmployerCountryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerCountryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerCountryID field.
	''' </summary>
	Public Function GetEmployerCountryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EmployerCountryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerCountryID field.
	''' </summary>
	Public Sub SetEmployerCountryIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerCountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerCountryID field.
	''' </summary>
	Public Sub SetEmployerCountryIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EmployerCountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerCountryID field.
	''' </summary>
	Public Sub SetEmployerCountryIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerCountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerCountryID field.
	''' </summary>
	Public Sub SetEmployerCountryIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerCountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerCountryID field.
	''' </summary>
	Public Sub SetEmployerCountryIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerCountryIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerContact field.
	''' </summary>
	Public Function GetEmployerContactValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerContactColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerContact field.
	''' </summary>
	Public Function GetEmployerContactFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerContactColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerContact field.
	''' </summary>
	Public Sub SetEmployerContactFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerContactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerContact field.
	''' </summary>
	Public Sub SetEmployerContactFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerContactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerEmail field.
	''' </summary>
	Public Function GetEmployerEmailValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerEmailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerEmail field.
	''' </summary>
	Public Function GetEmployerEmailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerEmailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerEmail field.
	''' </summary>
	Public Sub SetEmployerEmailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerEmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerEmail field.
	''' </summary>
	Public Sub SetEmployerEmailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerEmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerPhone field.
	''' </summary>
	Public Function GetEmployerPhoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerPhoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerPhone field.
	''' </summary>
	Public Function GetEmployerPhoneFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerPhoneColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerPhone field.
	''' </summary>
	Public Sub SetEmployerPhoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerPhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerPhone field.
	''' </summary>
	Public Sub SetEmployerPhoneFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerPhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerFax field.
	''' </summary>
	Public Function GetEmployerFaxValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerFaxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.EmployerFax field.
	''' </summary>
	Public Function GetEmployerFaxFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerFaxColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerFax field.
	''' </summary>
	Public Sub SetEmployerFaxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerFaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.EmployerFax field.
	''' </summary>
	Public Sub SetEmployerFaxFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerFaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.ReasonForLeavingID field.
	''' </summary>
	Public Function GetReasonForLeavingIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReasonForLeavingIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.ReasonForLeavingID field.
	''' </summary>
	Public Function GetReasonForLeavingIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ReasonForLeavingIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.ReasonForLeavingID field.
	''' </summary>
	Public Sub SetReasonForLeavingIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReasonForLeavingIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.ReasonForLeavingID field.
	''' </summary>
	Public Sub SetReasonForLeavingIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ReasonForLeavingIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.ReasonForLeavingID field.
	''' </summary>
	Public Sub SetReasonForLeavingIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReasonForLeavingIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.ReasonForLeavingID field.
	''' </summary>
	Public Sub SetReasonForLeavingIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReasonForLeavingIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.ReasonForLeavingID field.
	''' </summary>
	Public Sub SetReasonForLeavingIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReasonForLeavingIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.ReasonForLeavingNotes field.
	''' </summary>
	Public Function GetReasonForLeavingNotesValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReasonForLeavingNotesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.ReasonForLeavingNotes field.
	''' </summary>
	Public Function GetReasonForLeavingNotesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ReasonForLeavingNotesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.ReasonForLeavingNotes field.
	''' </summary>
	Public Sub SetReasonForLeavingNotesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReasonForLeavingNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.ReasonForLeavingNotes field.
	''' </summary>
	Public Sub SetReasonForLeavingNotesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReasonForLeavingNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.MilesPerWeek field.
	''' </summary>
	Public Function GetMilesPerWeekValue() As ColumnValue
		Return Me.GetValue(TableUtils.MilesPerWeekColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.MilesPerWeek field.
	''' </summary>
	Public Function GetMilesPerWeekFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MilesPerWeekColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.MilesPerWeek field.
	''' </summary>
	Public Sub SetMilesPerWeekFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MilesPerWeekColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.MilesPerWeek field.
	''' </summary>
	Public Sub SetMilesPerWeekFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MilesPerWeekColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.MilesPerWeek field.
	''' </summary>
	Public Sub SetMilesPerWeekFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MilesPerWeekColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.MilesPerWeek field.
	''' </summary>
	Public Sub SetMilesPerWeekFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MilesPerWeekColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.MilesPerWeek field.
	''' </summary>
	Public Sub SetMilesPerWeekFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MilesPerWeekColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.OperatedCommercialMotorVechicle field.
	''' </summary>
	Public Function GetOperatedCommercialMotorVechicleValue() As ColumnValue
		Return Me.GetValue(TableUtils.OperatedCommercialMotorVechicleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.OperatedCommercialMotorVechicle field.
	''' </summary>
	Public Function GetOperatedCommercialMotorVechicleFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.OperatedCommercialMotorVechicleColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.OperatedCommercialMotorVechicle field.
	''' </summary>
	Public Sub SetOperatedCommercialMotorVechicleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OperatedCommercialMotorVechicleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.OperatedCommercialMotorVechicle field.
	''' </summary>
	Public Sub SetOperatedCommercialMotorVechicleFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OperatedCommercialMotorVechicleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.OperatedCommercialMotorVechicle field.
	''' </summary>
	Public Sub SetOperatedCommercialMotorVechicleFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OperatedCommercialMotorVechicleColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.HadDrugTestingProgram field.
	''' </summary>
	Public Function GetHadDrugTestingProgramValue() As ColumnValue
		Return Me.GetValue(TableUtils.HadDrugTestingProgramColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.HadDrugTestingProgram field.
	''' </summary>
	Public Function GetHadDrugTestingProgramFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.HadDrugTestingProgramColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.HadDrugTestingProgram field.
	''' </summary>
	Public Sub SetHadDrugTestingProgramFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HadDrugTestingProgramColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.HadDrugTestingProgram field.
	''' </summary>
	Public Sub SetHadDrugTestingProgramFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HadDrugTestingProgramColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.HadDrugTestingProgram field.
	''' </summary>
	Public Sub SetHadDrugTestingProgramFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HadDrugTestingProgramColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.MayWeContact field.
	''' </summary>
	Public Function GetMayWeContactValue() As ColumnValue
		Return Me.GetValue(TableUtils.MayWeContactColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.MayWeContact field.
	''' </summary>
	Public Function GetMayWeContactFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.MayWeContactColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.MayWeContact field.
	''' </summary>
	Public Sub SetMayWeContactFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MayWeContactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.MayWeContact field.
	''' </summary>
	Public Sub SetMayWeContactFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MayWeContactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.MayWeContact field.
	''' </summary>
	Public Sub SetMayWeContactFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MayWeContactColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.FirstJob field.
	''' </summary>
	Public Function GetFirstJobValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstJobColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.FirstJob field.
	''' </summary>
	Public Function GetFirstJobFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FirstJobColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.FirstJob field.
	''' </summary>
	Public Sub SetFirstJobFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstJobColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.FirstJob field.
	''' </summary>
	Public Sub SetFirstJobFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FirstJobColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.FirstJob field.
	''' </summary>
	Public Sub SetFirstJobFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstJobColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.Finished field.
	''' </summary>
	Public Function GetFinishedValue() As ColumnValue
		Return Me.GetValue(TableUtils.FinishedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.Finished field.
	''' </summary>
	Public Function GetFinishedFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FinishedColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.Finished field.
	''' </summary>
	Public Sub SetFinishedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FinishedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.Finished field.
	''' </summary>
	Public Sub SetFinishedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FinishedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.Finished field.
	''' </summary>
	Public Sub SetFinishedFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FinishedColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.FinishedExp field.
	''' </summary>
	Public Function GetFinishedExpValue() As ColumnValue
		Return Me.GetValue(TableUtils.FinishedExpColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.FinishedExp field.
	''' </summary>
	Public Function GetFinishedExpFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FinishedExpColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.FinishedExp field.
	''' </summary>
	Public Sub SetFinishedExpFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FinishedExpColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.FinishedExp field.
	''' </summary>
	Public Sub SetFinishedExpFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FinishedExpColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.FinishedExp field.
	''' </summary>
	Public Sub SetFinishedExpFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FinishedExpColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.Notes field.
	''' </summary>
	Public Function GetNotesValue() As ColumnValue
		Return Me.GetValue(TableUtils.NotesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.Notes field.
	''' </summary>
	Public Function GetNotesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NotesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.Notes field.
	''' </summary>
	Public Sub SetNotesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.Notes field.
	''' </summary>
	Public Sub SetNotesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.TerminalID field.
	''' </summary>
	Public Function GetTerminalIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TerminalIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.TerminalID field.
	''' </summary>
	Public Function GetTerminalIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TerminalIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.TerminalID field.
	''' </summary>
	Public Sub SetTerminalIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TerminalIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.TerminalID field.
	''' </summary>
	Public Sub SetTerminalIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TerminalIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.TerminalID field.
	''' </summary>
	Public Sub SetTerminalIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TerminalIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.TerminalID field.
	''' </summary>
	Public Sub SetTerminalIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TerminalIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.TerminalID field.
	''' </summary>
	Public Sub SetTerminalIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TerminalIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.HireDate field.
	''' </summary>
	Public Function GetHireDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.HireDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.HireDate field.
	''' </summary>
	Public Function GetHireDateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.HireDateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.HireDate field.
	''' </summary>
	Public Sub SetHireDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HireDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.HireDate field.
	''' </summary>
	Public Sub SetHireDateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HireDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.HireDate field.
	''' </summary>
	Public Sub SetHireDateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HireDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.TermDate field.
	''' </summary>
	Public Function GetTermDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.TermDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.TermDate field.
	''' </summary>
	Public Function GetTermDateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.TermDateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.TermDate field.
	''' </summary>
	Public Sub SetTermDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TermDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.TermDate field.
	''' </summary>
	Public Sub SetTermDateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TermDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.TermDate field.
	''' </summary>
	Public Sub SetTermDateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TermDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.Overlap field.
	''' </summary>
	Public Function GetOverlapValue() As ColumnValue
		Return Me.GetValue(TableUtils.OverlapColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistory_.Overlap field.
	''' </summary>
	Public Function GetOverlapFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.OverlapColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.Overlap field.
	''' </summary>
	Public Sub SetOverlapFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OverlapColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.Overlap field.
	''' </summary>
	Public Sub SetOverlapFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OverlapColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.Overlap field.
	''' </summary>
	Public Sub SetOverlapFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OverlapColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.Overlap field.
	''' </summary>
	Public Sub SetOverlapFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OverlapColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistory_.Overlap field.
	''' </summary>
	Public Sub SetOverlapFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OverlapColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.HistoryID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.StartMonthID field.
	''' </summary>
	Public Property StartMonthID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.StartMonthIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.StartMonthIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property StartMonthIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.StartMonthIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property StartMonthIDDefault() As String
        Get
            Return TableUtils.StartMonthIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.EndMonthID field.
	''' </summary>
	Public Property EndMonthID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EndMonthIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EndMonthIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EndMonthIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EndMonthIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EndMonthIDDefault() As String
        Get
            Return TableUtils.EndMonthIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.Employed field.
	''' </summary>
	Public Property Employed() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.EmployedColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EmployedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmployedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmployedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmployedDefault() As String
        Get
            Return TableUtils.EmployedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.DrivingPosition field.
	''' </summary>
	Public Property DrivingPosition() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.DrivingPositionColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DrivingPositionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DrivingPositionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DrivingPositionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DrivingPositionDefault() As String
        Get
            Return TableUtils.DrivingPositionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.EmployerID field.
	''' </summary>
	Public Property EmployerID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EmployerIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EmployerIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmployerIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmployerIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmployerIDDefault() As String
        Get
            Return TableUtils.EmployerIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.EmployerCompany field.
	''' </summary>
	Public Property EmployerCompany() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EmployerCompanyColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EmployerCompanyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmployerCompanySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmployerCompanyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmployerCompanyDefault() As String
        Get
            Return TableUtils.EmployerCompanyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.EmployerAddr field.
	''' </summary>
	Public Property EmployerAddr() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EmployerAddrColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EmployerAddrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmployerAddrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmployerAddrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmployerAddrDefault() As String
        Get
            Return TableUtils.EmployerAddrColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.EmployerZipID field.
	''' </summary>
	Public Property EmployerZipID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EmployerZipIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EmployerZipIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmployerZipIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmployerZipIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmployerZipIDDefault() As String
        Get
            Return TableUtils.EmployerZipIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.EmployerCountryID field.
	''' </summary>
	Public Property EmployerCountryID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EmployerCountryIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EmployerCountryIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmployerCountryIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmployerCountryIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmployerCountryIDDefault() As String
        Get
            Return TableUtils.EmployerCountryIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.EmployerContact field.
	''' </summary>
	Public Property EmployerContact() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EmployerContactColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EmployerContactColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmployerContactSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmployerContactColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmployerContactDefault() As String
        Get
            Return TableUtils.EmployerContactColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.EmployerEmail field.
	''' </summary>
	Public Property EmployerEmail() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EmployerEmailColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EmployerEmailColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmployerEmailSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmployerEmailColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmployerEmailDefault() As String
        Get
            Return TableUtils.EmployerEmailColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.EmployerPhone field.
	''' </summary>
	Public Property EmployerPhone() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EmployerPhoneColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EmployerPhoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmployerPhoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmployerPhoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmployerPhoneDefault() As String
        Get
            Return TableUtils.EmployerPhoneColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.EmployerFax field.
	''' </summary>
	Public Property EmployerFax() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EmployerFaxColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EmployerFaxColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmployerFaxSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmployerFaxColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmployerFaxDefault() As String
        Get
            Return TableUtils.EmployerFaxColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.ReasonForLeavingID field.
	''' </summary>
	Public Property ReasonForLeavingID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ReasonForLeavingIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ReasonForLeavingIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReasonForLeavingIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReasonForLeavingIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReasonForLeavingIDDefault() As String
        Get
            Return TableUtils.ReasonForLeavingIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.ReasonForLeavingNotes field.
	''' </summary>
	Public Property ReasonForLeavingNotes() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ReasonForLeavingNotesColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ReasonForLeavingNotesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReasonForLeavingNotesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReasonForLeavingNotesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReasonForLeavingNotesDefault() As String
        Get
            Return TableUtils.ReasonForLeavingNotesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.MilesPerWeek field.
	''' </summary>
	Public Property MilesPerWeek() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MilesPerWeekColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MilesPerWeekColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MilesPerWeekSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MilesPerWeekColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MilesPerWeekDefault() As String
        Get
            Return TableUtils.MilesPerWeekColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.OperatedCommercialMotorVechicle field.
	''' </summary>
	Public Property OperatedCommercialMotorVechicle() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.OperatedCommercialMotorVechicleColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OperatedCommercialMotorVechicleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OperatedCommercialMotorVechicleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OperatedCommercialMotorVechicleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OperatedCommercialMotorVechicleDefault() As String
        Get
            Return TableUtils.OperatedCommercialMotorVechicleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.HadDrugTestingProgram field.
	''' </summary>
	Public Property HadDrugTestingProgram() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.HadDrugTestingProgramColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HadDrugTestingProgramColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HadDrugTestingProgramSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HadDrugTestingProgramColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HadDrugTestingProgramDefault() As String
        Get
            Return TableUtils.HadDrugTestingProgramColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.MayWeContact field.
	''' </summary>
	Public Property MayWeContact() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.MayWeContactColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MayWeContactColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MayWeContactSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MayWeContactColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MayWeContactDefault() As String
        Get
            Return TableUtils.MayWeContactColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.FirstJob field.
	''' </summary>
	Public Property FirstJob() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FirstJobColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FirstJobColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstJobSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstJobColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstJobDefault() As String
        Get
            Return TableUtils.FirstJobColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.Finished field.
	''' </summary>
	Public Property Finished() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FinishedColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FinishedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FinishedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FinishedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FinishedDefault() As String
        Get
            Return TableUtils.FinishedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.FinishedExp field.
	''' </summary>
	Public Property FinishedExp() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FinishedExpColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FinishedExpColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FinishedExpSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FinishedExpColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FinishedExpDefault() As String
        Get
            Return TableUtils.FinishedExpColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.Notes field.
	''' </summary>
	Public Property Notes() As String
		Get 
			Return CType(Me.GetValue(TableUtils.NotesColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.NotesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NotesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NotesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NotesDefault() As String
        Get
            Return TableUtils.NotesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.TerminalID field.
	''' </summary>
	Public Property TerminalID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TerminalIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TerminalIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TerminalIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TerminalIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TerminalIDDefault() As String
        Get
            Return TableUtils.TerminalIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.HireDate field.
	''' </summary>
	Public Property HireDate() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.HireDateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HireDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HireDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HireDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HireDateDefault() As String
        Get
            Return TableUtils.HireDateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.TermDate field.
	''' </summary>
	Public Property TermDate() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.TermDateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TermDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TermDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TermDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TermDateDefault() As String
        Get
            Return TableUtils.TermDateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistory_.Overlap field.
	''' </summary>
	Public Property Overlap() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.OverlapColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OverlapColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OverlapSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OverlapColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OverlapDefault() As String
        Get
            Return TableUtils.OverlapColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
