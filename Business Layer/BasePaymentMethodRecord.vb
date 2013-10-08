' This class is "generated" and will be overwritten.
' Your customizations should be made in PaymentMethodRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PaymentMethodRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="PaymentMethodTable"></see> class.
''' </remarks>
''' <seealso cref="PaymentMethodTable"></seealso>
''' <seealso cref="PaymentMethodRecord"></seealso>

<Serializable()> Public Class BasePaymentMethodRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As PaymentMethodTable = PaymentMethodTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub PaymentMethodRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim PaymentMethodRec As PaymentMethodRecord = CType(sender,PaymentMethodRecord)
        Validate_Inserting()
        If Not PaymentMethodRec Is Nothing AndAlso Not PaymentMethodRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub PaymentMethodRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim PaymentMethodRec As PaymentMethodRecord = CType(sender,PaymentMethodRecord)
        Validate_Updating()
        If Not PaymentMethodRec Is Nothing AndAlso Not PaymentMethodRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub PaymentMethodRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim PaymentMethodRec As PaymentMethodRecord = CType(sender,PaymentMethodRecord)
        If Not PaymentMethodRec Is Nothing AndAlso Not PaymentMethodRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.PaymentMethodID field.
	''' </summary>
	Public Function GetPaymentMethodIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PaymentMethodIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.PaymentMethodID field.
	''' </summary>
	Public Function GetPaymentMethodIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PaymentMethodIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.CreditCardTypeID field.
	''' </summary>
	Public Function GetCreditCardTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreditCardTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.CreditCardTypeID field.
	''' </summary>
	Public Function GetCreditCardTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreditCardTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreditCardTypeID field.
	''' </summary>
	Public Sub SetCreditCardTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreditCardTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreditCardTypeID field.
	''' </summary>
	Public Sub SetCreditCardTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreditCardTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreditCardTypeID field.
	''' </summary>
	Public Sub SetCreditCardTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreditCardTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreditCardTypeID field.
	''' </summary>
	Public Sub SetCreditCardTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreditCardTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreditCardTypeID field.
	''' </summary>
	Public Sub SetCreditCardTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreditCardTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.CreditCardNumber field.
	''' </summary>
	Public Function GetCreditCardNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreditCardNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.CreditCardNumber field.
	''' </summary>
	Public Function GetCreditCardNumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CreditCardNumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreditCardNumber field.
	''' </summary>
	Public Sub SetCreditCardNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreditCardNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreditCardNumber field.
	''' </summary>
	Public Sub SetCreditCardNumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreditCardNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.CreditCardName field.
	''' </summary>
	Public Function GetCreditCardNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreditCardNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.CreditCardName field.
	''' </summary>
	Public Function GetCreditCardNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CreditCardNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreditCardName field.
	''' </summary>
	Public Sub SetCreditCardNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreditCardNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreditCardName field.
	''' </summary>
	Public Sub SetCreditCardNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreditCardNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.StartDate field.
	''' </summary>
	Public Function GetStartDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.StartDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.StartDate field.
	''' </summary>
	Public Function GetStartDateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.StartDateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.StartDate field.
	''' </summary>
	Public Sub SetStartDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StartDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.StartDate field.
	''' </summary>
	Public Sub SetStartDateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.StartDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.StartDate field.
	''' </summary>
	Public Sub SetStartDateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StartDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.ExpiryDate field.
	''' </summary>
	Public Function GetExpiryDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExpiryDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.ExpiryDate field.
	''' </summary>
	Public Function GetExpiryDateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.ExpiryDateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.ExpiryDate field.
	''' </summary>
	Public Sub SetExpiryDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExpiryDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.ExpiryDate field.
	''' </summary>
	Public Sub SetExpiryDateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExpiryDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.ExpiryDate field.
	''' </summary>
	Public Sub SetExpiryDateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExpiryDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.CVV field.
	''' </summary>
	Public Function GetCVVValue() As ColumnValue
		Return Me.GetValue(TableUtils.CVVColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.CVV field.
	''' </summary>
	Public Function GetCVVFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CVVColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CVV field.
	''' </summary>
	Public Sub SetCVVFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CVVColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CVV field.
	''' </summary>
	Public Sub SetCVVFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CVVColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.BankAccountNumber field.
	''' </summary>
	Public Function GetBankAccountNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.BankAccountNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.BankAccountNumber field.
	''' </summary>
	Public Function GetBankAccountNumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.BankAccountNumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.BankAccountNumber field.
	''' </summary>
	Public Sub SetBankAccountNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.BankAccountNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.BankAccountNumber field.
	''' </summary>
	Public Sub SetBankAccountNumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BankAccountNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.BankSortCode field.
	''' </summary>
	Public Function GetBankSortCodeValue() As ColumnValue
		Return Me.GetValue(TableUtils.BankSortCodeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.BankSortCode field.
	''' </summary>
	Public Function GetBankSortCodeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.BankSortCodeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.BankSortCode field.
	''' </summary>
	Public Sub SetBankSortCodeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.BankSortCodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.BankSortCode field.
	''' </summary>
	Public Sub SetBankSortCodeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BankSortCodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.BankAccountName field.
	''' </summary>
	Public Function GetBankAccountNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.BankAccountNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.BankAccountName field.
	''' </summary>
	Public Function GetBankAccountNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.BankAccountNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.BankAccountName field.
	''' </summary>
	Public Sub SetBankAccountNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.BankAccountNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.BankAccountName field.
	''' </summary>
	Public Sub SetBankAccountNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BankAccountNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.BankPaymentReference field.
	''' </summary>
	Public Function GetBankPaymentReferenceValue() As ColumnValue
		Return Me.GetValue(TableUtils.BankPaymentReferenceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.BankPaymentReference field.
	''' </summary>
	Public Function GetBankPaymentReferenceFieldValue() As String
		Return CType(Me.GetValue(TableUtils.BankPaymentReferenceColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.BankPaymentReference field.
	''' </summary>
	Public Sub SetBankPaymentReferenceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.BankPaymentReferenceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.BankPaymentReference field.
	''' </summary>
	Public Sub SetBankPaymentReferenceFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BankPaymentReferenceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.Preferred field.
	''' </summary>
	Public Function GetPreferredValue() As ColumnValue
		Return Me.GetValue(TableUtils.PreferredColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.Preferred field.
	''' </summary>
	Public Function GetPreferredFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.PreferredColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.Preferred field.
	''' </summary>
	Public Sub SetPreferredFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PreferredColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.Preferred field.
	''' </summary>
	Public Sub SetPreferredFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PreferredColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.Preferred field.
	''' </summary>
	Public Sub SetPreferredFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PreferredColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.CarrierAvailabilityID field.
	''' </summary>
	Public Function GetCarrierAvailabilityIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierAvailabilityIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.CarrierAvailabilityID field.
	''' </summary>
	Public Function GetCarrierAvailabilityIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CarrierAvailabilityIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CarrierAvailabilityID field.
	''' </summary>
	Public Sub SetCarrierAvailabilityIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CarrierAvailabilityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CarrierAvailabilityID field.
	''' </summary>
	Public Sub SetCarrierAvailabilityIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CarrierAvailabilityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CarrierAvailabilityID field.
	''' </summary>
	Public Sub SetCarrierAvailabilityIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierAvailabilityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CarrierAvailabilityID field.
	''' </summary>
	Public Sub SetCarrierAvailabilityIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierAvailabilityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CarrierAvailabilityID field.
	''' </summary>
	Public Sub SetCarrierAvailabilityIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierAvailabilityIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.PartyAvailabilityID field.
	''' </summary>
	Public Function GetPartyAvailabilityIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyAvailabilityIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.PartyAvailabilityID field.
	''' </summary>
	Public Function GetPartyAvailabilityIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyAvailabilityIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.PartyAvailabilityID field.
	''' </summary>
	Public Sub SetPartyAvailabilityIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyAvailabilityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.PartyAvailabilityID field.
	''' </summary>
	Public Sub SetPartyAvailabilityIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyAvailabilityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.PartyAvailabilityID field.
	''' </summary>
	Public Sub SetPartyAvailabilityIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyAvailabilityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.PartyAvailabilityID field.
	''' </summary>
	Public Sub SetPartyAvailabilityIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyAvailabilityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.PartyAvailabilityID field.
	''' </summary>
	Public Sub SetPartyAvailabilityIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyAvailabilityIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PaymentMethod_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PaymentMethod_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.PaymentMethodID field.
	''' </summary>
	Public Property PaymentMethodID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PaymentMethodIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PaymentMethodIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PaymentMethodIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PaymentMethodIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PaymentMethodIDDefault() As String
        Get
            Return TableUtils.PaymentMethodIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.CreditCardTypeID field.
	''' </summary>
	Public Property CreditCardTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CreditCardTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CreditCardTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CreditCardTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CreditCardTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CreditCardTypeIDDefault() As String
        Get
            Return TableUtils.CreditCardTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.CreditCardNumber field.
	''' </summary>
	Public Property CreditCardNumber() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CreditCardNumberColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CreditCardNumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CreditCardNumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CreditCardNumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CreditCardNumberDefault() As String
        Get
            Return TableUtils.CreditCardNumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.CreditCardName field.
	''' </summary>
	Public Property CreditCardName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CreditCardNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CreditCardNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CreditCardNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CreditCardNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CreditCardNameDefault() As String
        Get
            Return TableUtils.CreditCardNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.StartDate field.
	''' </summary>
	Public Property StartDate() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.StartDateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.StartDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property StartDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.StartDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property StartDateDefault() As String
        Get
            Return TableUtils.StartDateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.ExpiryDate field.
	''' </summary>
	Public Property ExpiryDate() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.ExpiryDateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExpiryDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExpiryDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExpiryDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExpiryDateDefault() As String
        Get
            Return TableUtils.ExpiryDateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.CVV field.
	''' </summary>
	Public Property CVV() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CVVColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CVVColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CVVSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CVVColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CVVDefault() As String
        Get
            Return TableUtils.CVVColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.BankAccountNumber field.
	''' </summary>
	Public Property BankAccountNumber() As String
		Get 
			Return CType(Me.GetValue(TableUtils.BankAccountNumberColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.BankAccountNumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property BankAccountNumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.BankAccountNumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property BankAccountNumberDefault() As String
        Get
            Return TableUtils.BankAccountNumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.BankSortCode field.
	''' </summary>
	Public Property BankSortCode() As String
		Get 
			Return CType(Me.GetValue(TableUtils.BankSortCodeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.BankSortCodeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property BankSortCodeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.BankSortCodeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property BankSortCodeDefault() As String
        Get
            Return TableUtils.BankSortCodeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.BankAccountName field.
	''' </summary>
	Public Property BankAccountName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.BankAccountNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.BankAccountNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property BankAccountNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.BankAccountNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property BankAccountNameDefault() As String
        Get
            Return TableUtils.BankAccountNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.BankPaymentReference field.
	''' </summary>
	Public Property BankPaymentReference() As String
		Get 
			Return CType(Me.GetValue(TableUtils.BankPaymentReferenceColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.BankPaymentReferenceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property BankPaymentReferenceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.BankPaymentReferenceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property BankPaymentReferenceDefault() As String
        Get
            Return TableUtils.BankPaymentReferenceColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.Preferred field.
	''' </summary>
	Public Property Preferred() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.PreferredColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PreferredColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PreferredSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PreferredColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PreferredDefault() As String
        Get
            Return TableUtils.PreferredColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.CarrierAvailabilityID field.
	''' </summary>
	Public Property CarrierAvailabilityID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CarrierAvailabilityIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CarrierAvailabilityIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CarrierAvailabilityIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CarrierAvailabilityIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CarrierAvailabilityIDDefault() As String
        Get
            Return TableUtils.CarrierAvailabilityIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.PartyAvailabilityID field.
	''' </summary>
	Public Property PartyAvailabilityID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PartyAvailabilityIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PartyAvailabilityIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PartyAvailabilityIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PartyAvailabilityIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PartyAvailabilityIDDefault() As String
        Get
            Return TableUtils.PartyAvailabilityIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.CreatedByID field.
	''' </summary>
	Public Property CreatedByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CreatedByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CreatedByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CreatedByIDDefault() As String
        Get
            Return TableUtils.CreatedByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.CreatedAt field.
	''' </summary>
	Public Property CreatedAt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CreatedAtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CreatedAtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CreatedAtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CreatedAtDefault() As String
        Get
            Return TableUtils.CreatedAtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.UpdatedByID field.
	''' </summary>
	Public Property UpdatedByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UpdatedByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UpdatedByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UpdatedByIDDefault() As String
        Get
            Return TableUtils.UpdatedByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PaymentMethod_.UpdatedAt field.
	''' </summary>
	Public Property UpdatedAt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UpdatedAtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UpdatedAtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UpdatedAtDefault() As String
        Get
            Return TableUtils.UpdatedAtColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
