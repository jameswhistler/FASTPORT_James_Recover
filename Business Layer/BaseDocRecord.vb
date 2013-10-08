' This class is "generated" and will be overwritten.
' Your customizations should be made in DocRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="DocRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="DocTable"></see> class.
''' </remarks>
''' <seealso cref="DocTable"></seealso>
''' <seealso cref="DocRecord"></seealso>

<Serializable()> Public Class BaseDocRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As DocTable = DocTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub DocRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim DocRec As DocRecord = CType(sender,DocRecord)
        Validate_Inserting()
        If Not DocRec Is Nothing AndAlso Not DocRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub DocRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim DocRec As DocRecord = CType(sender,DocRecord)
        Validate_Updating()
        If Not DocRec Is Nothing AndAlso Not DocRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub DocRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim DocRec As DocRecord = CType(sender,DocRecord)
        If Not DocRec Is Nothing AndAlso Not DocRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocID field.
	''' </summary>
	Public Function GetDocIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocID field.
	''' </summary>
	Public Function GetDocIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DocIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.CIX field.
	''' </summary>
	Public Function GetCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.CIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.CIX field.
	''' </summary>
	Public Function GetCIXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CIXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.FiledAsID field.
	''' </summary>
	Public Function GetFiledAsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FiledAsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.FiledAsID field.
	''' </summary>
	Public Function GetFiledAsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FiledAsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.FiledAsID field.
	''' </summary>
	Public Sub SetFiledAsIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FiledAsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.FiledAsID field.
	''' </summary>
	Public Sub SetFiledAsIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FiledAsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.FiledAsID field.
	''' </summary>
	Public Sub SetFiledAsIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FiledAsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.FiledAsID field.
	''' </summary>
	Public Sub SetFiledAsIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FiledAsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.FiledAsID field.
	''' </summary>
	Public Sub SetFiledAsIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FiledAsIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.AgreementID field.
	''' </summary>
	Public Function GetAgreementIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AgreementIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.AgreementID field.
	''' </summary>
	Public Function GetAgreementIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AgreementIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocName field.
	''' </summary>
	Public Function GetDocNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocName field.
	''' </summary>
	Public Function GetDocNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocName field.
	''' </summary>
	Public Sub SetDocNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocName field.
	''' </summary>
	Public Sub SetDocNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocPdf field.
	''' </summary>
	Public Function GetDocPdfValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocPdfColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocPdf field.
	''' </summary>
	Public Function GetDocPdfFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.DocPdfColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocPdf field.
	''' </summary>
	Public Sub SetDocPdfFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocPdfColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocPdf field.
	''' </summary>
	Public Sub SetDocPdfFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocPdfColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocPdf field.
	''' </summary>
	Public Sub SetDocPdfFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocPdfColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocNumber field.
	''' </summary>
	Public Function GetDocNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocNumber field.
	''' </summary>
	Public Function GetDocNumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocNumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocNumber field.
	''' </summary>
	Public Sub SetDocNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocNumber field.
	''' </summary>
	Public Sub SetDocNumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocIssued field.
	''' </summary>
	Public Function GetDocIssuedValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocIssuedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocIssued field.
	''' </summary>
	Public Function GetDocIssuedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DocIssuedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocIssued field.
	''' </summary>
	Public Sub SetDocIssuedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocIssuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocIssued field.
	''' </summary>
	Public Sub SetDocIssuedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocIssuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocIssued field.
	''' </summary>
	Public Sub SetDocIssuedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocIssuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocIssuingStateID field.
	''' </summary>
	Public Function GetDocIssuingStateIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocIssuingStateIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocIssuingStateID field.
	''' </summary>
	Public Function GetDocIssuingStateIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DocIssuingStateIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocIssuingStateID field.
	''' </summary>
	Public Sub SetDocIssuingStateIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocIssuingStateIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocIssuingStateID field.
	''' </summary>
	Public Sub SetDocIssuingStateIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocIssuingStateIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocIssuingStateID field.
	''' </summary>
	Public Sub SetDocIssuingStateIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocIssuingStateIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocIssuingStateID field.
	''' </summary>
	Public Sub SetDocIssuingStateIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocIssuingStateIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocIssuingStateID field.
	''' </summary>
	Public Sub SetDocIssuingStateIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocIssuingStateIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocExpiration field.
	''' </summary>
	Public Function GetDocExpirationValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocExpirationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocExpiration field.
	''' </summary>
	Public Function GetDocExpirationFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DocExpirationColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocExpiration field.
	''' </summary>
	Public Sub SetDocExpirationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocExpirationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocExpiration field.
	''' </summary>
	Public Sub SetDocExpirationFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocExpirationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocExpiration field.
	''' </summary>
	Public Sub SetDocExpirationFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocExpirationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.Reissued field.
	''' </summary>
	Public Function GetReissuedValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReissuedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.Reissued field.
	''' </summary>
	Public Function GetReissuedFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ReissuedColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.Reissued field.
	''' </summary>
	Public Sub SetReissuedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReissuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.Reissued field.
	''' </summary>
	Public Sub SetReissuedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ReissuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.Reissued field.
	''' </summary>
	Public Sub SetReissuedFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReissuedColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocEndorsements field.
	''' </summary>
	Public Function GetDocEndorsementsValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocEndorsementsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocEndorsements field.
	''' </summary>
	Public Function GetDocEndorsementsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocEndorsementsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocEndorsements field.
	''' </summary>
	Public Sub SetDocEndorsementsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocEndorsementsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocEndorsements field.
	''' </summary>
	Public Sub SetDocEndorsementsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocEndorsementsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocNotes field.
	''' </summary>
	Public Function GetDocNotesValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocNotesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.DocNotes field.
	''' </summary>
	Public Function GetDocNotesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocNotesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocNotes field.
	''' </summary>
	Public Sub SetDocNotesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.DocNotes field.
	''' </summary>
	Public Sub SetDocNotesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.FinishedRecordingDetails field.
	''' </summary>
	Public Function GetFinishedRecordingDetailsValue() As ColumnValue
		Return Me.GetValue(TableUtils.FinishedRecordingDetailsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.FinishedRecordingDetails field.
	''' </summary>
	Public Function GetFinishedRecordingDetailsFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FinishedRecordingDetailsColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.FinishedRecordingDetails field.
	''' </summary>
	Public Sub SetFinishedRecordingDetailsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FinishedRecordingDetailsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.FinishedRecordingDetails field.
	''' </summary>
	Public Sub SetFinishedRecordingDetailsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FinishedRecordingDetailsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.FinishedRecordingDetails field.
	''' </summary>
	Public Sub SetFinishedRecordingDetailsFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FinishedRecordingDetailsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.PrivateFile field.
	''' </summary>
	Public Function GetPrivateFileValue() As ColumnValue
		Return Me.GetValue(TableUtils.PrivateFileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.PrivateFile field.
	''' </summary>
	Public Function GetPrivateFileFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.PrivateFileColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.PrivateFile field.
	''' </summary>
	Public Sub SetPrivateFileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PrivateFileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.PrivateFile field.
	''' </summary>
	Public Sub SetPrivateFileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PrivateFileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.PrivateFile field.
	''' </summary>
	Public Sub SetPrivateFileFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PrivateFileColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.FlowStepID field.
	''' </summary>
	Public Function GetFlowStepIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowStepIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.FlowStepID field.
	''' </summary>
	Public Function GetFlowStepIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowStepIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.InstanceID field.
	''' </summary>
	Public Function GetInstanceIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.InstanceIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.InstanceID field.
	''' </summary>
	Public Function GetInstanceIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.InstanceIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.ExecutionID field.
	''' </summary>
	Public Function GetExecutionIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExecutionIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.ExecutionID field.
	''' </summary>
	Public Function GetExecutionIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ExecutionIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.AttachmentID field.
	''' </summary>
	Public Function GetAttachmentIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AttachmentIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.AttachmentID field.
	''' </summary>
	Public Function GetAttachmentIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AttachmentIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.AttachmentID field.
	''' </summary>
	Public Sub SetAttachmentIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AttachmentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.AttachmentID field.
	''' </summary>
	Public Sub SetAttachmentIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AttachmentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.AttachmentID field.
	''' </summary>
	Public Sub SetAttachmentIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AttachmentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.AttachmentID field.
	''' </summary>
	Public Sub SetAttachmentIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AttachmentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.AttachmentID field.
	''' </summary>
	Public Sub SetAttachmentIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AttachmentIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.EquipID field.
	''' </summary>
	Public Function GetEquipIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EquipIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.EquipID field.
	''' </summary>
	Public Function GetEquipIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EquipIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.EquipID field.
	''' </summary>
	Public Sub SetEquipIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EquipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.EquipID field.
	''' </summary>
	Public Sub SetEquipIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EquipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.EquipID field.
	''' </summary>
	Public Sub SetEquipIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EquipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.EquipID field.
	''' </summary>
	Public Sub SetEquipIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EquipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.EquipID field.
	''' </summary>
	Public Sub SetEquipIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EquipIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.ProcessedPages field.
	''' </summary>
	Public Function GetProcessedPagesValue() As ColumnValue
		Return Me.GetValue(TableUtils.ProcessedPagesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.ProcessedPages field.
	''' </summary>
	Public Function GetProcessedPagesFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ProcessedPagesColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.ProcessedPages field.
	''' </summary>
	Public Sub SetProcessedPagesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ProcessedPagesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.ProcessedPages field.
	''' </summary>
	Public Sub SetProcessedPagesFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ProcessedPagesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.ProcessedPages field.
	''' </summary>
	Public Sub SetProcessedPagesFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProcessedPagesColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Doc_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Doc_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.DocID field.
	''' </summary>
	Public Property DocID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DocIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocIDDefault() As String
        Get
            Return TableUtils.DocIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.CIX field.
	''' </summary>
	Public Property CIX() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CIXColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CIXDefault() As String
        Get
            Return TableUtils.CIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Doc_.FiledAsID field.
	''' </summary>
	Public Property FiledAsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FiledAsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FiledAsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FiledAsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FiledAsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FiledAsIDDefault() As String
        Get
            Return TableUtils.FiledAsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.AgreementID field.
	''' </summary>
	Public Property AgreementID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AgreementIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AgreementIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AgreementIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AgreementIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AgreementIDDefault() As String
        Get
            Return TableUtils.AgreementIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.DocName field.
	''' </summary>
	Public Property DocName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DocNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DocNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocNameDefault() As String
        Get
            Return TableUtils.DocNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.DocPdf field.
	''' </summary>
	Public Property DocPdf() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.DocPdfColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocPdfColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocPdfSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocPdfColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocPdfDefault() As String
        Get
            Return TableUtils.DocPdfColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.DocNumber field.
	''' </summary>
	Public Property DocNumber() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DocNumberColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DocNumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocNumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocNumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocNumberDefault() As String
        Get
            Return TableUtils.DocNumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.DocIssued field.
	''' </summary>
	Public Property DocIssued() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.DocIssuedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocIssuedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocIssuedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocIssuedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocIssuedDefault() As String
        Get
            Return TableUtils.DocIssuedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.DocIssuingStateID field.
	''' </summary>
	Public Property DocIssuingStateID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DocIssuingStateIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocIssuingStateIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocIssuingStateIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocIssuingStateIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocIssuingStateIDDefault() As String
        Get
            Return TableUtils.DocIssuingStateIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.DocExpiration field.
	''' </summary>
	Public Property DocExpiration() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.DocExpirationColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocExpirationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocExpirationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocExpirationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocExpirationDefault() As String
        Get
            Return TableUtils.DocExpirationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.Reissued field.
	''' </summary>
	Public Property Reissued() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ReissuedColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ReissuedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReissuedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReissuedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReissuedDefault() As String
        Get
            Return TableUtils.ReissuedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.DocEndorsements field.
	''' </summary>
	Public Property DocEndorsements() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DocEndorsementsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DocEndorsementsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocEndorsementsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocEndorsementsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocEndorsementsDefault() As String
        Get
            Return TableUtils.DocEndorsementsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.DocNotes field.
	''' </summary>
	Public Property DocNotes() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DocNotesColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DocNotesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocNotesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocNotesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocNotesDefault() As String
        Get
            Return TableUtils.DocNotesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.FinishedRecordingDetails field.
	''' </summary>
	Public Property FinishedRecordingDetails() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FinishedRecordingDetailsColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FinishedRecordingDetailsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FinishedRecordingDetailsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FinishedRecordingDetailsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FinishedRecordingDetailsDefault() As String
        Get
            Return TableUtils.FinishedRecordingDetailsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.PrivateFile field.
	''' </summary>
	Public Property PrivateFile() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.PrivateFileColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PrivateFileColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PrivateFileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PrivateFileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PrivateFileDefault() As String
        Get
            Return TableUtils.PrivateFileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.FlowStepID field.
	''' </summary>
	Public Property FlowStepID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FlowStepIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FlowStepIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FlowStepIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FlowStepIDDefault() As String
        Get
            Return TableUtils.FlowStepIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.InstanceID field.
	''' </summary>
	Public Property InstanceID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.InstanceIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.InstanceIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property InstanceIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.InstanceIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property InstanceIDDefault() As String
        Get
            Return TableUtils.InstanceIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.ExecutionID field.
	''' </summary>
	Public Property ExecutionID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ExecutionIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExecutionIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExecutionIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExecutionIDDefault() As String
        Get
            Return TableUtils.ExecutionIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.AttachmentID field.
	''' </summary>
	Public Property AttachmentID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AttachmentIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AttachmentIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AttachmentIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AttachmentIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AttachmentIDDefault() As String
        Get
            Return TableUtils.AttachmentIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.EquipID field.
	''' </summary>
	Public Property EquipID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EquipIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EquipIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EquipIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EquipIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EquipIDDefault() As String
        Get
            Return TableUtils.EquipIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.ProcessedPages field.
	''' </summary>
	Public Property ProcessedPages() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ProcessedPagesColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ProcessedPagesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ProcessedPagesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ProcessedPagesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ProcessedPagesDefault() As String
        Get
            Return TableUtils.ProcessedPagesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Doc_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Doc_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's Doc_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Doc_.UpdatedAt field.
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
