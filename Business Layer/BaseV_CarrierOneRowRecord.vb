' This class is "generated" and will be overwritten.
' Your customizations should be made in V_CarrierOneRowRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_CarrierOneRowRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_CarrierOneRowView"></see> class.
''' </remarks>
''' <seealso cref="V_CarrierOneRowView"></seealso>
''' <seealso cref="V_CarrierOneRowRecord"></seealso>

<Serializable()> Public Class BaseV_CarrierOneRowRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_CarrierOneRowView = V_CarrierOneRowView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_CarrierOneRowRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_CarrierOneRowRec As V_CarrierOneRowRecord = CType(sender,V_CarrierOneRowRecord)
        Validate_Inserting()
        If Not V_CarrierOneRowRec Is Nothing AndAlso Not V_CarrierOneRowRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_CarrierOneRowRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_CarrierOneRowRec As V_CarrierOneRowRecord = CType(sender,V_CarrierOneRowRecord)
        Validate_Updating()
        If Not V_CarrierOneRowRec Is Nothing AndAlso Not V_CarrierOneRowRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_CarrierOneRowRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_CarrierOneRowRec As V_CarrierOneRowRecord = CType(sender,V_CarrierOneRowRecord)
        If Not V_CarrierOneRowRec Is Nothing AndAlso Not V_CarrierOneRowRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.PK field.
	''' </summary>
	Public Function GetPKValue() As ColumnValue
		Return Me.GetValue(TableUtils.PKColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.PK field.
	''' </summary>
	Public Function GetPKFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PKColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.PK field.
	''' </summary>
	Public Sub SetPKFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PKColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.PK field.
	''' </summary>
	Public Sub SetPKFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PKColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.AddrID field.
	''' </summary>
	Public Function GetAddrIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.AddrID field.
	''' </summary>
	Public Function GetAddrIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AddrIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.DOTNumber field.
	''' </summary>
	Public Function GetDOTNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.DOTNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.DOTNumber field.
	''' </summary>
	Public Function GetDOTNumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DOTNumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.DOTNumber field.
	''' </summary>
	Public Sub SetDOTNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DOTNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.DOTNumber field.
	''' </summary>
	Public Sub SetDOTNumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DOTNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.MCNumber field.
	''' </summary>
	Public Function GetMCNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.MCNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.MCNumber field.
	''' </summary>
	Public Function GetMCNumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MCNumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.MCNumber field.
	''' </summary>
	Public Sub SetMCNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MCNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.MCNumber field.
	''' </summary>
	Public Sub SetMCNumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MCNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.CarrierName field.
	''' </summary>
	Public Function GetCarrierNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.CarrierName field.
	''' </summary>
	Public Function GetCarrierNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CarrierNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CarrierName field.
	''' </summary>
	Public Sub SetCarrierNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CarrierNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CarrierName field.
	''' </summary>
	Public Sub SetCarrierNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.CarrierDBA field.
	''' </summary>
	Public Function GetCarrierDBAValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierDBAColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.CarrierDBA field.
	''' </summary>
	Public Function GetCarrierDBAFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CarrierDBAColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CarrierDBA field.
	''' </summary>
	Public Sub SetCarrierDBAFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CarrierDBAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CarrierDBA field.
	''' </summary>
	Public Sub SetCarrierDBAFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierDBAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.Addr field.
	''' </summary>
	Public Function GetAddrValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.Addr field.
	''' </summary>
	Public Function GetAddrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AddrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Addr field.
	''' </summary>
	Public Sub SetAddrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Addr field.
	''' </summary>
	Public Sub SetAddrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.Addr2 field.
	''' </summary>
	Public Function GetAddr2Value() As ColumnValue
		Return Me.GetValue(TableUtils.Addr2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.Addr2 field.
	''' </summary>
	Public Function GetAddr2FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Addr2Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Addr2 field.
	''' </summary>
	Public Sub SetAddr2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Addr2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Addr2 field.
	''' </summary>
	Public Sub SetAddr2FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Addr2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.CitySTZip field.
	''' </summary>
	Public Function GetCitySTZipValue() As ColumnValue
		Return Me.GetValue(TableUtils.CitySTZipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.CitySTZip field.
	''' </summary>
	Public Function GetCitySTZipFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CitySTZipColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CitySTZip field.
	''' </summary>
	Public Sub SetCitySTZipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CitySTZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CitySTZip field.
	''' </summary>
	Public Sub SetCitySTZipFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CitySTZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.CountryID field.
	''' </summary>
	Public Function GetCountryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CountryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.CountryID field.
	''' </summary>
	Public Function GetCountryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CountryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.Country field.
	''' </summary>
	Public Function GetCountryValue() As ColumnValue
		Return Me.GetValue(TableUtils.CountryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.Country field.
	''' </summary>
	Public Function GetCountryFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CountryColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Country field.
	''' </summary>
	Public Sub SetCountryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Country field.
	''' </summary>
	Public Sub SetCountryFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.AddrZipID field.
	''' </summary>
	Public Function GetAddrZipIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrZipIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.AddrZipID field.
	''' </summary>
	Public Function GetAddrZipIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AddrZipIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.AddrZipID field.
	''' </summary>
	Public Sub SetAddrZipIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.AddrZipID field.
	''' </summary>
	Public Sub SetAddrZipIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AddrZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.AddrZipID field.
	''' </summary>
	Public Sub SetAddrZipIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.AddrZipID field.
	''' </summary>
	Public Sub SetAddrZipIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.AddrZipID field.
	''' </summary>
	Public Sub SetAddrZipIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrZipIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.Email field.
	''' </summary>
	Public Function GetEmailValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.Email field.
	''' </summary>
	Public Function GetEmailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.DirectDial field.
	''' </summary>
	Public Function GetDirectDialValue() As ColumnValue
		Return Me.GetValue(TableUtils.DirectDialColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.DirectDial field.
	''' </summary>
	Public Function GetDirectDialFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DirectDialColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.DirectDial field.
	''' </summary>
	Public Sub SetDirectDialFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DirectDialColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.DirectDial field.
	''' </summary>
	Public Sub SetDirectDialFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DirectDialColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.Fax field.
	''' </summary>
	Public Function GetFaxValue() As ColumnValue
		Return Me.GetValue(TableUtils.FaxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.Fax field.
	''' </summary>
	Public Function GetFaxFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FaxColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Fax field.
	''' </summary>
	Public Sub SetFaxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Fax field.
	''' </summary>
	Public Sub SetFaxFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.CarrierHTML field.
	''' </summary>
	Public Function GetCarrierHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.CarrierHTML field.
	''' </summary>
	Public Function GetCarrierHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CarrierHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CarrierHTML field.
	''' </summary>
	Public Sub SetCarrierHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CarrierHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CarrierHTML field.
	''' </summary>
	Public Sub SetCarrierHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.StripSearch field.
	''' </summary>
	Public Function GetStripSearchValue() As ColumnValue
		Return Me.GetValue(TableUtils.StripSearchColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.StripSearch field.
	''' </summary>
	Public Function GetStripSearchFieldValue() As String
		Return CType(Me.GetValue(TableUtils.StripSearchColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.StripSearch field.
	''' </summary>
	Public Sub SetStripSearchFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StripSearchColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.StripSearch field.
	''' </summary>
	Public Sub SetStripSearchFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StripSearchColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.StripSearchDBA field.
	''' </summary>
	Public Function GetStripSearchDBAValue() As ColumnValue
		Return Me.GetValue(TableUtils.StripSearchDBAColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.StripSearchDBA field.
	''' </summary>
	Public Function GetStripSearchDBAFieldValue() As String
		Return CType(Me.GetValue(TableUtils.StripSearchDBAColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.StripSearchDBA field.
	''' </summary>
	Public Sub SetStripSearchDBAFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StripSearchDBAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.StripSearchDBA field.
	''' </summary>
	Public Sub SetStripSearchDBAFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StripSearchDBAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.Lat field.
	''' </summary>
	Public Function GetLatValue() As ColumnValue
		Return Me.GetValue(TableUtils.LatColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.Lat field.
	''' </summary>
	Public Function GetLatFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.LatColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LatColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.Long field.
	''' </summary>
	Public Function GetLong0Value() As ColumnValue
		Return Me.GetValue(TableUtils.Long0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.Long field.
	''' </summary>
	Public Function GetLong0FieldValue() As Double
		Return CType(Me.GetValue(TableUtils.Long0Column).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Long0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Long0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Long0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Long0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Long0Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.CountryAbbr field.
	''' </summary>
	Public Function GetCountryAbbrValue() As ColumnValue
		Return Me.GetValue(TableUtils.CountryAbbrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierOneRow_.CountryAbbr field.
	''' </summary>
	Public Function GetCountryAbbrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CountryAbbrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CountryAbbr field.
	''' </summary>
	Public Sub SetCountryAbbrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CountryAbbrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierOneRow_.CountryAbbr field.
	''' </summary>
	Public Sub SetCountryAbbrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryAbbrColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.PK field.
	''' </summary>
	Public Property PK() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PKColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PKColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PKSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PKColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PKDefault() As String
        Get
            Return TableUtils.PKColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.AddrID field.
	''' </summary>
	Public Property AddrID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AddrIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AddrIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AddrIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AddrIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AddrIDDefault() As String
        Get
            Return TableUtils.AddrIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.DOTNumber field.
	''' </summary>
	Public Property DOTNumber() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DOTNumberColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DOTNumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DOTNumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DOTNumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DOTNumberDefault() As String
        Get
            Return TableUtils.DOTNumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.MCNumber field.
	''' </summary>
	Public Property MCNumber() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MCNumberColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MCNumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MCNumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MCNumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MCNumberDefault() As String
        Get
            Return TableUtils.MCNumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.CarrierName field.
	''' </summary>
	Public Property CarrierName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CarrierNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CarrierNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CarrierNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CarrierNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CarrierNameDefault() As String
        Get
            Return TableUtils.CarrierNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.CarrierDBA field.
	''' </summary>
	Public Property CarrierDBA() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CarrierDBAColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CarrierDBAColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CarrierDBASpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CarrierDBAColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CarrierDBADefault() As String
        Get
            Return TableUtils.CarrierDBAColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.Addr field.
	''' </summary>
	Public Property Addr() As String
		Get 
			Return CType(Me.GetValue(TableUtils.AddrColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.AddrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AddrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AddrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AddrDefault() As String
        Get
            Return TableUtils.AddrColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.Addr2 field.
	''' </summary>
	Public Property Addr2() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Addr2Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Addr2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Addr2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Addr2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Addr2Default() As String
        Get
            Return TableUtils.Addr2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.CitySTZip field.
	''' </summary>
	Public Property CitySTZip() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CitySTZipColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CitySTZipColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CitySTZipSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CitySTZipColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CitySTZipDefault() As String
        Get
            Return TableUtils.CitySTZipColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.CountryID field.
	''' </summary>
	Public Property CountryID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CountryIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CountryIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CountryIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CountryIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CountryIDDefault() As String
        Get
            Return TableUtils.CountryIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.Country field.
	''' </summary>
	Public Property Country() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CountryColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CountryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CountrySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CountryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CountryDefault() As String
        Get
            Return TableUtils.CountryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.AddrZipID field.
	''' </summary>
	Public Property AddrZipID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AddrZipIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AddrZipIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AddrZipIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AddrZipIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AddrZipIDDefault() As String
        Get
            Return TableUtils.AddrZipIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.Email field.
	''' </summary>
	Public Property Email() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EmailColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EmailColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmailSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmailColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmailDefault() As String
        Get
            Return TableUtils.EmailColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.DirectDial field.
	''' </summary>
	Public Property DirectDial() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DirectDialColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DirectDialColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DirectDialSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DirectDialColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DirectDialDefault() As String
        Get
            Return TableUtils.DirectDialColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.Fax field.
	''' </summary>
	Public Property Fax() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FaxColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FaxColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FaxSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FaxColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FaxDefault() As String
        Get
            Return TableUtils.FaxColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.CarrierHTML field.
	''' </summary>
	Public Property CarrierHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CarrierHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CarrierHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CarrierHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CarrierHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CarrierHTMLDefault() As String
        Get
            Return TableUtils.CarrierHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.StripSearch field.
	''' </summary>
	Public Property StripSearch() As String
		Get 
			Return CType(Me.GetValue(TableUtils.StripSearchColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.StripSearchColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property StripSearchSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.StripSearchColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property StripSearchDefault() As String
        Get
            Return TableUtils.StripSearchColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.StripSearchDBA field.
	''' </summary>
	Public Property StripSearchDBA() As String
		Get 
			Return CType(Me.GetValue(TableUtils.StripSearchDBAColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.StripSearchDBAColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property StripSearchDBASpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.StripSearchDBAColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property StripSearchDBADefault() As String
        Get
            Return TableUtils.StripSearchDBAColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.Lat field.
	''' </summary>
	Public Property Lat() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.LatColumn).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LatColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LatSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LatColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LatDefault() As String
        Get
            Return TableUtils.LatColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.Long field.
	''' </summary>
	Public Property Long0() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.Long0Column).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Long0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Long0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Long0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Long0Default() As String
        Get
            Return TableUtils.Long0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierOneRow_.CountryAbbr field.
	''' </summary>
	Public Property CountryAbbr() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CountryAbbrColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CountryAbbrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CountryAbbrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CountryAbbrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CountryAbbrDefault() As String
        Get
            Return TableUtils.CountryAbbrColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
