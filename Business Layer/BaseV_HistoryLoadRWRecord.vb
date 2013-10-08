' This class is "generated" and will be overwritten.
' Your customizations should be made in V_HistoryLoadRWRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_HistoryLoadRWRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_HistoryLoadRWView"></see> class.
''' </remarks>
''' <seealso cref="V_HistoryLoadRWView"></seealso>
''' <seealso cref="V_HistoryLoadRWRecord"></seealso>

<Serializable()> Public Class BaseV_HistoryLoadRWRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_HistoryLoadRWView = V_HistoryLoadRWView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_HistoryLoadRWRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_HistoryLoadRWRec As V_HistoryLoadRWRecord = CType(sender,V_HistoryLoadRWRecord)
        Validate_Inserting()
        If Not V_HistoryLoadRWRec Is Nothing AndAlso Not V_HistoryLoadRWRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_HistoryLoadRWRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_HistoryLoadRWRec As V_HistoryLoadRWRecord = CType(sender,V_HistoryLoadRWRecord)
        Validate_Updating()
        If Not V_HistoryLoadRWRec Is Nothing AndAlso Not V_HistoryLoadRWRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_HistoryLoadRWRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_HistoryLoadRWRec As V_HistoryLoadRWRecord = CType(sender,V_HistoryLoadRWRecord)
        If Not V_HistoryLoadRWRec Is Nothing AndAlso Not V_HistoryLoadRWRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.HistoryID field.
	''' </summary>
	Public Function GetHistoryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.HistoryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.HistoryID field.
	''' </summary>
	Public Function GetHistoryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HistoryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.StartMonth field.
	''' </summary>
	Public Function GetStartMonthValue() As ColumnValue
		Return Me.GetValue(TableUtils.StartMonthColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.StartMonth field.
	''' </summary>
	Public Function GetStartMonthFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.StartMonthColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.StartMonth field.
	''' </summary>
	Public Sub SetStartMonthFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StartMonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.StartMonth field.
	''' </summary>
	Public Sub SetStartMonthFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.StartMonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.StartMonth field.
	''' </summary>
	Public Sub SetStartMonthFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StartMonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EndMonth field.
	''' </summary>
	Public Function GetEndMonthValue() As ColumnValue
		Return Me.GetValue(TableUtils.EndMonthColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EndMonth field.
	''' </summary>
	Public Function GetEndMonthFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.EndMonthColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EndMonth field.
	''' </summary>
	Public Sub SetEndMonthFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EndMonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EndMonth field.
	''' </summary>
	Public Sub SetEndMonthFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EndMonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EndMonth field.
	''' </summary>
	Public Sub SetEndMonthFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EndMonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.PositionTypeID field.
	''' </summary>
	Public Function GetPositionTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PositionTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.PositionTypeID field.
	''' </summary>
	Public Function GetPositionTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PositionTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.PositionTypeID field.
	''' </summary>
	Public Sub SetPositionTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PositionTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.PositionTypeID field.
	''' </summary>
	Public Sub SetPositionTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PositionTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.PositionTypeID field.
	''' </summary>
	Public Sub SetPositionTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PositionTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.PositionTypeID field.
	''' </summary>
	Public Sub SetPositionTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PositionTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.PositionTypeID field.
	''' </summary>
	Public Sub SetPositionTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PositionTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.CurrentPastID field.
	''' </summary>
	Public Function GetCurrentPastIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CurrentPastIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.CurrentPastID field.
	''' </summary>
	Public Function GetCurrentPastIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CurrentPastIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.CurrentPastID field.
	''' </summary>
	Public Sub SetCurrentPastIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CurrentPastIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.CurrentPastID field.
	''' </summary>
	Public Sub SetCurrentPastIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CurrentPastIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.CarrierID field.
	''' </summary>
	Public Function GetCarrierIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.CarrierID field.
	''' </summary>
	Public Function GetCarrierIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CarrierIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerCompany field.
	''' </summary>
	Public Function GetEmployerCompanyValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerCompanyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerCompany field.
	''' </summary>
	Public Function GetEmployerCompanyFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerCompanyColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerCompany field.
	''' </summary>
	Public Sub SetEmployerCompanyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerCompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerCompany field.
	''' </summary>
	Public Sub SetEmployerCompanyFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerCompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerAddr field.
	''' </summary>
	Public Function GetEmployerAddrValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerAddrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerAddr field.
	''' </summary>
	Public Function GetEmployerAddrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerAddrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerAddr field.
	''' </summary>
	Public Sub SetEmployerAddrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerAddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerAddr field.
	''' </summary>
	Public Sub SetEmployerAddrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerAddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerZipID field.
	''' </summary>
	Public Function GetEmployerZipIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerZipIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerZipID field.
	''' </summary>
	Public Function GetEmployerZipIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EmployerZipIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerZipID field.
	''' </summary>
	Public Sub SetEmployerZipIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerZipID field.
	''' </summary>
	Public Sub SetEmployerZipIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EmployerZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerZipID field.
	''' </summary>
	Public Sub SetEmployerZipIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerZipID field.
	''' </summary>
	Public Sub SetEmployerZipIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerZipID field.
	''' </summary>
	Public Sub SetEmployerZipIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerZipIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerCitySTZip field.
	''' </summary>
	Public Function GetEmployerCitySTZipValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerCitySTZipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerCitySTZip field.
	''' </summary>
	Public Function GetEmployerCitySTZipFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerCitySTZipColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerCitySTZip field.
	''' </summary>
	Public Sub SetEmployerCitySTZipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerCitySTZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerCitySTZip field.
	''' </summary>
	Public Sub SetEmployerCitySTZipFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerCitySTZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerCountryID field.
	''' </summary>
	Public Function GetEmployerCountryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerCountryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerCountryID field.
	''' </summary>
	Public Function GetEmployerCountryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EmployerCountryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerCountryID field.
	''' </summary>
	Public Sub SetEmployerCountryIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerCountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerCountryID field.
	''' </summary>
	Public Sub SetEmployerCountryIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EmployerCountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerCountryID field.
	''' </summary>
	Public Sub SetEmployerCountryIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerCountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerCountryID field.
	''' </summary>
	Public Sub SetEmployerCountryIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerCountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerCountryID field.
	''' </summary>
	Public Sub SetEmployerCountryIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerCountryIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerCountry field.
	''' </summary>
	Public Function GetEmployerCountryValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerCountryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerCountry field.
	''' </summary>
	Public Function GetEmployerCountryFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerCountryColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerCountry field.
	''' </summary>
	Public Sub SetEmployerCountryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerCountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerCountry field.
	''' </summary>
	Public Sub SetEmployerCountryFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerCountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerEmail field.
	''' </summary>
	Public Function GetEmployerEmailValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerEmailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerEmail field.
	''' </summary>
	Public Function GetEmployerEmailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerEmailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerEmail field.
	''' </summary>
	Public Sub SetEmployerEmailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerEmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerEmail field.
	''' </summary>
	Public Sub SetEmployerEmailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerEmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerPhone field.
	''' </summary>
	Public Function GetEmployerPhoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerPhoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerPhone field.
	''' </summary>
	Public Function GetEmployerPhoneFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerPhoneColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerPhone field.
	''' </summary>
	Public Sub SetEmployerPhoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerPhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerPhone field.
	''' </summary>
	Public Sub SetEmployerPhoneFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerPhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerFax field.
	''' </summary>
	Public Function GetEmployerFaxValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerFaxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerFax field.
	''' </summary>
	Public Function GetEmployerFaxFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerFaxColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerFax field.
	''' </summary>
	Public Sub SetEmployerFaxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerFaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerFax field.
	''' </summary>
	Public Sub SetEmployerFaxFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerFaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerContact field.
	''' </summary>
	Public Function GetEmployerContactValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerContactColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerContact field.
	''' </summary>
	Public Function GetEmployerContactFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerContactColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerContact field.
	''' </summary>
	Public Sub SetEmployerContactFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerContactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.EmployerContact field.
	''' </summary>
	Public Sub SetEmployerContactFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerContactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.MilesPerWeek field.
	''' </summary>
	Public Function GetMilesPerWeekValue() As ColumnValue
		Return Me.GetValue(TableUtils.MilesPerWeekColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.MilesPerWeek field.
	''' </summary>
	Public Function GetMilesPerWeekFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MilesPerWeekColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.MilesPerWeek field.
	''' </summary>
	Public Sub SetMilesPerWeekFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MilesPerWeekColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.MilesPerWeek field.
	''' </summary>
	Public Sub SetMilesPerWeekFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MilesPerWeekColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.MilesPerWeek field.
	''' </summary>
	Public Sub SetMilesPerWeekFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MilesPerWeekColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.MilesPerWeek field.
	''' </summary>
	Public Sub SetMilesPerWeekFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MilesPerWeekColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.MilesPerWeek field.
	''' </summary>
	Public Sub SetMilesPerWeekFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MilesPerWeekColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.ReasonForLeavingID field.
	''' </summary>
	Public Function GetReasonForLeavingIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReasonForLeavingIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.ReasonForLeavingID field.
	''' </summary>
	Public Function GetReasonForLeavingIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ReasonForLeavingIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.ReasonForLeavingID field.
	''' </summary>
	Public Sub SetReasonForLeavingIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReasonForLeavingIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.ReasonForLeavingID field.
	''' </summary>
	Public Sub SetReasonForLeavingIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ReasonForLeavingIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.ReasonForLeavingID field.
	''' </summary>
	Public Sub SetReasonForLeavingIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReasonForLeavingIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.ReasonForLeavingID field.
	''' </summary>
	Public Sub SetReasonForLeavingIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReasonForLeavingIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.ReasonForLeavingID field.
	''' </summary>
	Public Sub SetReasonForLeavingIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReasonForLeavingIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.ReasonForLeaving field.
	''' </summary>
	Public Function GetReasonForLeavingValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReasonForLeavingColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.ReasonForLeaving field.
	''' </summary>
	Public Function GetReasonForLeavingFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ReasonForLeavingColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.ReasonForLeaving field.
	''' </summary>
	Public Sub SetReasonForLeavingFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReasonForLeavingColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.ReasonForLeaving field.
	''' </summary>
	Public Sub SetReasonForLeavingFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReasonForLeavingColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.ReasonForLeavingNotes field.
	''' </summary>
	Public Function GetReasonForLeavingNotesValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReasonForLeavingNotesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.ReasonForLeavingNotes field.
	''' </summary>
	Public Function GetReasonForLeavingNotesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ReasonForLeavingNotesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.ReasonForLeavingNotes field.
	''' </summary>
	Public Sub SetReasonForLeavingNotesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReasonForLeavingNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.ReasonForLeavingNotes field.
	''' </summary>
	Public Sub SetReasonForLeavingNotesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReasonForLeavingNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.OperatedCommercialMotorVechicle field.
	''' </summary>
	Public Function GetOperatedCommercialMotorVechicleValue() As ColumnValue
		Return Me.GetValue(TableUtils.OperatedCommercialMotorVechicleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.OperatedCommercialMotorVechicle field.
	''' </summary>
	Public Function GetOperatedCommercialMotorVechicleFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.OperatedCommercialMotorVechicleColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.OperatedCommercialMotorVechicle field.
	''' </summary>
	Public Sub SetOperatedCommercialMotorVechicleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OperatedCommercialMotorVechicleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.OperatedCommercialMotorVechicle field.
	''' </summary>
	Public Sub SetOperatedCommercialMotorVechicleFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OperatedCommercialMotorVechicleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.OperatedCommercialMotorVechicle field.
	''' </summary>
	Public Sub SetOperatedCommercialMotorVechicleFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OperatedCommercialMotorVechicleColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.HadDrugTestingProgram field.
	''' </summary>
	Public Function GetHadDrugTestingProgramValue() As ColumnValue
		Return Me.GetValue(TableUtils.HadDrugTestingProgramColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.HadDrugTestingProgram field.
	''' </summary>
	Public Function GetHadDrugTestingProgramFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.HadDrugTestingProgramColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.HadDrugTestingProgram field.
	''' </summary>
	Public Sub SetHadDrugTestingProgramFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HadDrugTestingProgramColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.HadDrugTestingProgram field.
	''' </summary>
	Public Sub SetHadDrugTestingProgramFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HadDrugTestingProgramColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.HadDrugTestingProgram field.
	''' </summary>
	Public Sub SetHadDrugTestingProgramFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HadDrugTestingProgramColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.Notes field.
	''' </summary>
	Public Function GetNotesValue() As ColumnValue
		Return Me.GetValue(TableUtils.NotesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.Notes field.
	''' </summary>
	Public Function GetNotesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NotesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.Notes field.
	''' </summary>
	Public Sub SetNotesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.Notes field.
	''' </summary>
	Public Sub SetNotesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.MayWeContact field.
	''' </summary>
	Public Function GetMayWeContactValue() As ColumnValue
		Return Me.GetValue(TableUtils.MayWeContactColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.MayWeContact field.
	''' </summary>
	Public Function GetMayWeContactFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.MayWeContactColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.MayWeContact field.
	''' </summary>
	Public Sub SetMayWeContactFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MayWeContactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.MayWeContact field.
	''' </summary>
	Public Sub SetMayWeContactFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MayWeContactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.MayWeContact field.
	''' </summary>
	Public Sub SetMayWeContactFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MayWeContactColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.FirstJob field.
	''' </summary>
	Public Function GetFirstJobValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstJobColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.FirstJob field.
	''' </summary>
	Public Function GetFirstJobFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FirstJobColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.FirstJob field.
	''' </summary>
	Public Sub SetFirstJobFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstJobColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.FirstJob field.
	''' </summary>
	Public Sub SetFirstJobFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FirstJobColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.FirstJob field.
	''' </summary>
	Public Sub SetFirstJobFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstJobColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.ShowFirstJob field.
	''' </summary>
	Public Function GetShowFirstJobValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShowFirstJobColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.ShowFirstJob field.
	''' </summary>
	Public Function GetShowFirstJobFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ShowFirstJobColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.ShowFirstJob field.
	''' </summary>
	Public Sub SetShowFirstJobFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShowFirstJobColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.ShowFirstJob field.
	''' </summary>
	Public Sub SetShowFirstJobFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShowFirstJobColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.Finished field.
	''' </summary>
	Public Function GetFinishedValue() As ColumnValue
		Return Me.GetValue(TableUtils.FinishedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_HistoryLoadRW_.Finished field.
	''' </summary>
	Public Function GetFinishedFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FinishedColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.Finished field.
	''' </summary>
	Public Sub SetFinishedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FinishedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.Finished field.
	''' </summary>
	Public Sub SetFinishedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FinishedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_HistoryLoadRW_.Finished field.
	''' </summary>
	Public Sub SetFinishedFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FinishedColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.HistoryID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.StartMonth field.
	''' </summary>
	Public Property StartMonth() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.StartMonthColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.StartMonthColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property StartMonthSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.StartMonthColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property StartMonthDefault() As String
        Get
            Return TableUtils.StartMonthColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.EndMonth field.
	''' </summary>
	Public Property EndMonth() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.EndMonthColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EndMonthColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EndMonthSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EndMonthColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EndMonthDefault() As String
        Get
            Return TableUtils.EndMonthColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.PositionTypeID field.
	''' </summary>
	Public Property PositionTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PositionTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PositionTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PositionTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PositionTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PositionTypeIDDefault() As String
        Get
            Return TableUtils.PositionTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.CurrentPastID field.
	''' </summary>
	Public Property CurrentPastID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CurrentPastIDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CurrentPastIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CurrentPastIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CurrentPastIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CurrentPastIDDefault() As String
        Get
            Return TableUtils.CurrentPastIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.CarrierID field.
	''' </summary>
	Public Property CarrierID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CarrierIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CarrierIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CarrierIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CarrierIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CarrierIDDefault() As String
        Get
            Return TableUtils.CarrierIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerCompany field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerAddr field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerZipID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerCitySTZip field.
	''' </summary>
	Public Property EmployerCitySTZip() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EmployerCitySTZipColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EmployerCitySTZipColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmployerCitySTZipSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmployerCitySTZipColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmployerCitySTZipDefault() As String
        Get
            Return TableUtils.EmployerCitySTZipColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerCountryID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerCountry field.
	''' </summary>
	Public Property EmployerCountry() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EmployerCountryColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EmployerCountryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmployerCountrySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmployerCountryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmployerCountryDefault() As String
        Get
            Return TableUtils.EmployerCountryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerEmail field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerPhone field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerFax field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.EmployerContact field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.MilesPerWeek field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.ReasonForLeavingID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.ReasonForLeaving field.
	''' </summary>
	Public Property ReasonForLeaving() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ReasonForLeavingColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ReasonForLeavingColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReasonForLeavingSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReasonForLeavingColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReasonForLeavingDefault() As String
        Get
            Return TableUtils.ReasonForLeavingColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.ReasonForLeavingNotes field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.OperatedCommercialMotorVechicle field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.HadDrugTestingProgram field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.Notes field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.MayWeContact field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.FirstJob field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.ShowFirstJob field.
	''' </summary>
	Public Property ShowFirstJob() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ShowFirstJobColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ShowFirstJobColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ShowFirstJobSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ShowFirstJobColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ShowFirstJobDefault() As String
        Get
            Return TableUtils.ShowFirstJobColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_HistoryLoadRW_.Finished field.
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



#End Region

End Class
End Namespace
