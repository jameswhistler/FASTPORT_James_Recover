' This class is "generated" and will be overwritten.
' Your customizations should be made in AgreementExecutionRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="AgreementExecutionRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="AgreementExecutionTable"></see> class.
''' </remarks>
''' <seealso cref="AgreementExecutionTable"></seealso>
''' <seealso cref="AgreementExecutionRecord"></seealso>

<Serializable()> Public Class BaseAgreementExecutionRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As AgreementExecutionTable = AgreementExecutionTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub AgreementExecutionRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim AgreementExecutionRec As AgreementExecutionRecord = CType(sender,AgreementExecutionRecord)
        Validate_Inserting()
        If Not AgreementExecutionRec Is Nothing AndAlso Not AgreementExecutionRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub AgreementExecutionRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim AgreementExecutionRec As AgreementExecutionRecord = CType(sender,AgreementExecutionRecord)
        Validate_Updating()
        If Not AgreementExecutionRec Is Nothing AndAlso Not AgreementExecutionRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub AgreementExecutionRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim AgreementExecutionRec As AgreementExecutionRecord = CType(sender,AgreementExecutionRecord)
        If Not AgreementExecutionRec Is Nothing AndAlso Not AgreementExecutionRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.ExecutionID field.
	''' </summary>
	Public Function GetExecutionIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExecutionIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.ExecutionID field.
	''' </summary>
	Public Function GetExecutionIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ExecutionIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.CIX field.
	''' </summary>
	Public Function GetCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.CIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.CIX field.
	''' </summary>
	Public Function GetCIXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CIXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.OIX field.
	''' </summary>
	Public Function GetOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.OIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.OIX field.
	''' </summary>
	Public Function GetOIXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.OIXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.AgreementID field.
	''' </summary>
	Public Function GetAgreementIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AgreementIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.AgreementID field.
	''' </summary>
	Public Function GetAgreementIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AgreementIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SenderAddrID field.
	''' </summary>
	Public Function GetSenderAddrIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderAddrIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SenderAddrID field.
	''' </summary>
	Public Function GetSenderAddrIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SenderAddrIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderAddrID field.
	''' </summary>
	Public Sub SetSenderAddrIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderAddrID field.
	''' </summary>
	Public Sub SetSenderAddrIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SenderAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderAddrID field.
	''' </summary>
	Public Sub SetSenderAddrIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderAddrID field.
	''' </summary>
	Public Sub SetSenderAddrIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderAddrID field.
	''' </summary>
	Public Sub SetSenderAddrIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderAddrIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SenderSignerID field.
	''' </summary>
	Public Function GetSenderSignerIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderSignerIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SenderSignerID field.
	''' </summary>
	Public Function GetSenderSignerIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SenderSignerIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderSignerID field.
	''' </summary>
	Public Sub SetSenderSignerIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderSignerID field.
	''' </summary>
	Public Sub SetSenderSignerIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SenderSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderSignerID field.
	''' </summary>
	Public Sub SetSenderSignerIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderSignerID field.
	''' </summary>
	Public Sub SetSenderSignerIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderSignerID field.
	''' </summary>
	Public Sub SetSenderSignerIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderSignerIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.RecipientAddrID field.
	''' </summary>
	Public Function GetRecipientAddrIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RecipientAddrIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.RecipientAddrID field.
	''' </summary>
	Public Function GetRecipientAddrIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RecipientAddrIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientAddrID field.
	''' </summary>
	Public Sub SetRecipientAddrIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RecipientAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientAddrID field.
	''' </summary>
	Public Sub SetRecipientAddrIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RecipientAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientAddrID field.
	''' </summary>
	Public Sub SetRecipientAddrIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientAddrID field.
	''' </summary>
	Public Sub SetRecipientAddrIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientAddrID field.
	''' </summary>
	Public Sub SetRecipientAddrIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientAddrIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.RecipientSignerID field.
	''' </summary>
	Public Function GetRecipientSignerIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RecipientSignerIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.RecipientSignerID field.
	''' </summary>
	Public Function GetRecipientSignerIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RecipientSignerIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientSignerID field.
	''' </summary>
	Public Sub SetRecipientSignerIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RecipientSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientSignerID field.
	''' </summary>
	Public Sub SetRecipientSignerIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RecipientSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientSignerID field.
	''' </summary>
	Public Sub SetRecipientSignerIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientSignerID field.
	''' </summary>
	Public Sub SetRecipientSignerIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientSignerID field.
	''' </summary>
	Public Sub SetRecipientSignerIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientSignerIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SignedOn field.
	''' </summary>
	Public Function GetSignedOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.SignedOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SignedOn field.
	''' </summary>
	Public Function GetSignedOnFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.SignedOnColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SignedOn field.
	''' </summary>
	Public Sub SetSignedOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SignedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SignedOn field.
	''' </summary>
	Public Sub SetSignedOnFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SignedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SignedOn field.
	''' </summary>
	Public Sub SetSignedOnFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SignedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.ExpiresOn field.
	''' </summary>
	Public Function GetExpiresOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExpiresOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.ExpiresOn field.
	''' </summary>
	Public Function GetExpiresOnFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.ExpiresOnColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.ExpiresOn field.
	''' </summary>
	Public Sub SetExpiresOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExpiresOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.ExpiresOn field.
	''' </summary>
	Public Sub SetExpiresOnFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExpiresOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.ExpiresOn field.
	''' </summary>
	Public Sub SetExpiresOnFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExpiresOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.UseOutsideTemplate field.
	''' </summary>
	Public Function GetUseOutsideTemplateValue() As ColumnValue
		Return Me.GetValue(TableUtils.UseOutsideTemplateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.UseOutsideTemplate field.
	''' </summary>
	Public Function GetUseOutsideTemplateFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.UseOutsideTemplateColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.UseOutsideTemplate field.
	''' </summary>
	Public Sub SetUseOutsideTemplateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UseOutsideTemplateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.UseOutsideTemplate field.
	''' </summary>
	Public Sub SetUseOutsideTemplateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UseOutsideTemplateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.UseOutsideTemplate field.
	''' </summary>
	Public Sub SetUseOutsideTemplateFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UseOutsideTemplateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.UseOutsidePdf field.
	''' </summary>
	Public Function GetUseOutsidePdfValue() As ColumnValue
		Return Me.GetValue(TableUtils.UseOutsidePdfColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.UseOutsidePdf field.
	''' </summary>
	Public Function GetUseOutsidePdfFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.UseOutsidePdfColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.UseOutsidePdf field.
	''' </summary>
	Public Sub SetUseOutsidePdfFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UseOutsidePdfColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.UseOutsidePdf field.
	''' </summary>
	Public Sub SetUseOutsidePdfFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UseOutsidePdfColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.UseOutsidePdf field.
	''' </summary>
	Public Sub SetUseOutsidePdfFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UseOutsidePdfColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.AgreementFileDoc field.
	''' </summary>
	Public Function GetAgreementFileDocValue() As ColumnValue
		Return Me.GetValue(TableUtils.AgreementFileDocColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.AgreementFileDoc field.
	''' </summary>
	Public Function GetAgreementFileDocFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.AgreementFileDocColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.AgreementFileDoc field.
	''' </summary>
	Public Sub SetAgreementFileDocFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AgreementFileDocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.AgreementFileDoc field.
	''' </summary>
	Public Sub SetAgreementFileDocFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AgreementFileDocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.AgreementFileDoc field.
	''' </summary>
	Public Sub SetAgreementFileDocFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementFileDocColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.AgreementFilePdf field.
	''' </summary>
	Public Function GetAgreementFilePdfValue() As ColumnValue
		Return Me.GetValue(TableUtils.AgreementFilePdfColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.AgreementFilePdf field.
	''' </summary>
	Public Function GetAgreementFilePdfFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.AgreementFilePdfColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.AgreementFilePdf field.
	''' </summary>
	Public Sub SetAgreementFilePdfFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AgreementFilePdfColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.AgreementFilePdf field.
	''' </summary>
	Public Sub SetAgreementFilePdfFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AgreementFilePdfColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.AgreementFilePdf field.
	''' </summary>
	Public Sub SetAgreementFilePdfFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementFilePdfColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SenderSignature field.
	''' </summary>
	Public Function GetSenderSignatureValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderSignatureColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SenderSignature field.
	''' </summary>
	Public Function GetSenderSignatureFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.SenderSignatureColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderSignature field.
	''' </summary>
	Public Sub SetSenderSignatureFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderSignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderSignature field.
	''' </summary>
	Public Sub SetSenderSignatureFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SenderSignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderSignature field.
	''' </summary>
	Public Sub SetSenderSignatureFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderSignatureColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SenderInitials field.
	''' </summary>
	Public Function GetSenderInitialsValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderInitialsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SenderInitials field.
	''' </summary>
	Public Function GetSenderInitialsFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.SenderInitialsColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderInitials field.
	''' </summary>
	Public Sub SetSenderInitialsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderInitialsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderInitials field.
	''' </summary>
	Public Sub SetSenderInitialsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SenderInitialsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderInitials field.
	''' </summary>
	Public Sub SetSenderInitialsFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderInitialsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SenderSignedAt field.
	''' </summary>
	Public Function GetSenderSignedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderSignedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SenderSignedAt field.
	''' </summary>
	Public Function GetSenderSignedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.SenderSignedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderSignedAt field.
	''' </summary>
	Public Sub SetSenderSignedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderSignedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderSignedAt field.
	''' </summary>
	Public Sub SetSenderSignedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SenderSignedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderSignedAt field.
	''' </summary>
	Public Sub SetSenderSignedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderSignedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SenderSignedFrom field.
	''' </summary>
	Public Function GetSenderSignedFromValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderSignedFromColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SenderSignedFrom field.
	''' </summary>
	Public Function GetSenderSignedFromFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SenderSignedFromColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderSignedFrom field.
	''' </summary>
	Public Sub SetSenderSignedFromFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderSignedFromColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SenderSignedFrom field.
	''' </summary>
	Public Sub SetSenderSignedFromFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderSignedFromColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.RecipientSignature field.
	''' </summary>
	Public Function GetRecipientSignatureValue() As ColumnValue
		Return Me.GetValue(TableUtils.RecipientSignatureColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.RecipientSignature field.
	''' </summary>
	Public Function GetRecipientSignatureFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.RecipientSignatureColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientSignature field.
	''' </summary>
	Public Sub SetRecipientSignatureFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RecipientSignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientSignature field.
	''' </summary>
	Public Sub SetRecipientSignatureFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RecipientSignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientSignature field.
	''' </summary>
	Public Sub SetRecipientSignatureFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientSignatureColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.RecipientInitials field.
	''' </summary>
	Public Function GetRecipientInitialsValue() As ColumnValue
		Return Me.GetValue(TableUtils.RecipientInitialsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.RecipientInitials field.
	''' </summary>
	Public Function GetRecipientInitialsFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.RecipientInitialsColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientInitials field.
	''' </summary>
	Public Sub SetRecipientInitialsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RecipientInitialsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientInitials field.
	''' </summary>
	Public Sub SetRecipientInitialsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RecipientInitialsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientInitials field.
	''' </summary>
	Public Sub SetRecipientInitialsFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientInitialsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.RecipientSignedAt field.
	''' </summary>
	Public Function GetRecipientSignedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.RecipientSignedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.RecipientSignedAt field.
	''' </summary>
	Public Function GetRecipientSignedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.RecipientSignedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientSignedAt field.
	''' </summary>
	Public Sub SetRecipientSignedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RecipientSignedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientSignedAt field.
	''' </summary>
	Public Sub SetRecipientSignedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RecipientSignedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientSignedAt field.
	''' </summary>
	Public Sub SetRecipientSignedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientSignedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.RecipientSignedFrom field.
	''' </summary>
	Public Function GetRecipientSignedFromValue() As ColumnValue
		Return Me.GetValue(TableUtils.RecipientSignedFromColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.RecipientSignedFrom field.
	''' </summary>
	Public Function GetRecipientSignedFromFieldValue() As String
		Return CType(Me.GetValue(TableUtils.RecipientSignedFromColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientSignedFrom field.
	''' </summary>
	Public Sub SetRecipientSignedFromFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RecipientSignedFromColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.RecipientSignedFrom field.
	''' </summary>
	Public Sub SetRecipientSignedFromFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientSignedFromColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.AddSignaturePage field.
	''' </summary>
	Public Function GetAddSignaturePageValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddSignaturePageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.AddSignaturePage field.
	''' </summary>
	Public Function GetAddSignaturePageFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.AddSignaturePageColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.AddSignaturePage field.
	''' </summary>
	Public Sub SetAddSignaturePageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddSignaturePageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.AddSignaturePage field.
	''' </summary>
	Public Sub SetAddSignaturePageFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AddSignaturePageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.AddSignaturePage field.
	''' </summary>
	Public Sub SetAddSignaturePageFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddSignaturePageColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.FlowStepID field.
	''' </summary>
	Public Function GetFlowStepIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowStepIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.FlowStepID field.
	''' </summary>
	Public Function GetFlowStepIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowStepIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.InstanceID field.
	''' </summary>
	Public Function GetInstanceIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.InstanceIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.InstanceID field.
	''' </summary>
	Public Function GetInstanceIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.InstanceIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.FirstItem field.
	''' </summary>
	Public Function GetFirstItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.FirstItem field.
	''' </summary>
	Public Function GetFirstItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FirstItem field.
	''' </summary>
	Public Sub SetFirstItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FirstItem field.
	''' </summary>
	Public Sub SetFirstItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SecondItem field.
	''' </summary>
	Public Function GetSecondItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SecondItem field.
	''' </summary>
	Public Function GetSecondItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SecondItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SecondItem field.
	''' </summary>
	Public Sub SetSecondItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SecondItem field.
	''' </summary>
	Public Sub SetSecondItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.ThirdItem field.
	''' </summary>
	Public Function GetThirdItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.ThirdItem field.
	''' </summary>
	Public Function GetThirdItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirdItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.ThirdItem field.
	''' </summary>
	Public Sub SetThirdItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.ThirdItem field.
	''' </summary>
	Public Sub SetThirdItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.FourthItem field.
	''' </summary>
	Public Function GetFourthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.FourthItem field.
	''' </summary>
	Public Function GetFourthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FourthItem field.
	''' </summary>
	Public Sub SetFourthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FourthItem field.
	''' </summary>
	Public Sub SetFourthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.FifthItem field.
	''' </summary>
	Public Function GetFifthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.FifthItem field.
	''' </summary>
	Public Function GetFifthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FifthItem field.
	''' </summary>
	Public Sub SetFifthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FifthItem field.
	''' </summary>
	Public Sub SetFifthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SixthItem field.
	''' </summary>
	Public Function GetSixthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SixthItem field.
	''' </summary>
	Public Function GetSixthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SixthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SixthItem field.
	''' </summary>
	Public Sub SetSixthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SixthItem field.
	''' </summary>
	Public Sub SetSixthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SeventhItem field.
	''' </summary>
	Public Function GetSeventhItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.SeventhItem field.
	''' </summary>
	Public Function GetSeventhItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SeventhItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SeventhItem field.
	''' </summary>
	Public Sub SetSeventhItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.SeventhItem field.
	''' </summary>
	Public Sub SetSeventhItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.EighthItem field.
	''' </summary>
	Public Function GetEighthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.EighthItem field.
	''' </summary>
	Public Function GetEighthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EighthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.EighthItem field.
	''' </summary>
	Public Sub SetEighthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.EighthItem field.
	''' </summary>
	Public Sub SetEighthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.NinthItem field.
	''' </summary>
	Public Function GetNinthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.NinthItem field.
	''' </summary>
	Public Function GetNinthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NinthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.NinthItem field.
	''' </summary>
	Public Sub SetNinthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.NinthItem field.
	''' </summary>
	Public Sub SetNinthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.TenthItem field.
	''' </summary>
	Public Function GetTenthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.TenthItem field.
	''' </summary>
	Public Function GetTenthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TenthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.TenthItem field.
	''' </summary>
	Public Sub SetTenthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.TenthItem field.
	''' </summary>
	Public Sub SetTenthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.EleventhItem field.
	''' </summary>
	Public Function GetEleventhItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.EleventhItem field.
	''' </summary>
	Public Function GetEleventhItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EleventhItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.EleventhItem field.
	''' </summary>
	Public Sub SetEleventhItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.EleventhItem field.
	''' </summary>
	Public Sub SetEleventhItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.TwelfthItem field.
	''' </summary>
	Public Function GetTwelfthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.TwelfthItem field.
	''' </summary>
	Public Function GetTwelfthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TwelfthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.TwelfthItem field.
	''' </summary>
	Public Sub SetTwelfthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.TwelfthItem field.
	''' </summary>
	Public Sub SetTwelfthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.ThirteenthItem field.
	''' </summary>
	Public Function GetThirteenthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.ThirteenthItem field.
	''' </summary>
	Public Function GetThirteenthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirteenthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.ThirteenthItem field.
	''' </summary>
	Public Sub SetThirteenthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.ThirteenthItem field.
	''' </summary>
	Public Sub SetThirteenthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.FourteenthItem field.
	''' </summary>
	Public Function GetFourteenthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.FourteenthItem field.
	''' </summary>
	Public Function GetFourteenthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourteenthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FourteenthItem field.
	''' </summary>
	Public Sub SetFourteenthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FourteenthItem field.
	''' </summary>
	Public Sub SetFourteenthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.FifteenthItem field.
	''' </summary>
	Public Function GetFifteenthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.FifteenthItem field.
	''' </summary>
	Public Function GetFifteenthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifteenthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FifteenthItem field.
	''' </summary>
	Public Sub SetFifteenthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.FifteenthItem field.
	''' </summary>
	Public Sub SetFifteenthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.BarCode field.
	''' </summary>
	Public Function GetBarCodeValue() As ColumnValue
		Return Me.GetValue(TableUtils.BarCodeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.BarCode field.
	''' </summary>
	Public Function GetBarCodeFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.BarCodeColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.BarCode field.
	''' </summary>
	Public Sub SetBarCodeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.BarCodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.BarCode field.
	''' </summary>
	Public Sub SetBarCodeFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.BarCodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.BarCode field.
	''' </summary>
	Public Sub SetBarCodeFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BarCodeColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's AgreementExecution_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's AgreementExecution_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.ExecutionID field.
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
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.CIX field.
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
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.OIX field.
	''' </summary>
	Public Property OIX() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.OIXColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OIXDefault() As String
        Get
            Return TableUtils.OIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.AgreementID field.
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
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.SenderAddrID field.
	''' </summary>
	Public Property SenderAddrID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SenderAddrIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SenderAddrIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SenderAddrIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SenderAddrIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SenderAddrIDDefault() As String
        Get
            Return TableUtils.SenderAddrIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.SenderSignerID field.
	''' </summary>
	Public Property SenderSignerID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SenderSignerIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SenderSignerIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SenderSignerIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SenderSignerIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SenderSignerIDDefault() As String
        Get
            Return TableUtils.SenderSignerIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.RecipientAddrID field.
	''' </summary>
	Public Property RecipientAddrID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RecipientAddrIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RecipientAddrIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RecipientAddrIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RecipientAddrIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RecipientAddrIDDefault() As String
        Get
            Return TableUtils.RecipientAddrIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.RecipientSignerID field.
	''' </summary>
	Public Property RecipientSignerID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RecipientSignerIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RecipientSignerIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RecipientSignerIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RecipientSignerIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RecipientSignerIDDefault() As String
        Get
            Return TableUtils.RecipientSignerIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.SignedOn field.
	''' </summary>
	Public Property SignedOn() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.SignedOnColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SignedOnColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SignedOnSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SignedOnColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SignedOnDefault() As String
        Get
            Return TableUtils.SignedOnColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.ExpiresOn field.
	''' </summary>
	Public Property ExpiresOn() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.ExpiresOnColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExpiresOnColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExpiresOnSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExpiresOnColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExpiresOnDefault() As String
        Get
            Return TableUtils.ExpiresOnColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.UseOutsideTemplate field.
	''' </summary>
	Public Property UseOutsideTemplate() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.UseOutsideTemplateColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UseOutsideTemplateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UseOutsideTemplateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UseOutsideTemplateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UseOutsideTemplateDefault() As String
        Get
            Return TableUtils.UseOutsideTemplateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.UseOutsidePdf field.
	''' </summary>
	Public Property UseOutsidePdf() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.UseOutsidePdfColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UseOutsidePdfColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UseOutsidePdfSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UseOutsidePdfColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UseOutsidePdfDefault() As String
        Get
            Return TableUtils.UseOutsidePdfColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.AgreementFileDoc field.
	''' </summary>
	Public Property AgreementFileDoc() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.AgreementFileDocColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AgreementFileDocColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AgreementFileDocSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AgreementFileDocColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AgreementFileDocDefault() As String
        Get
            Return TableUtils.AgreementFileDocColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.AgreementFilePdf field.
	''' </summary>
	Public Property AgreementFilePdf() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.AgreementFilePdfColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AgreementFilePdfColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AgreementFilePdfSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AgreementFilePdfColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AgreementFilePdfDefault() As String
        Get
            Return TableUtils.AgreementFilePdfColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.SenderSignature field.
	''' </summary>
	Public Property SenderSignature() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.SenderSignatureColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SenderSignatureColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SenderSignatureSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SenderSignatureColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SenderSignatureDefault() As String
        Get
            Return TableUtils.SenderSignatureColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.SenderInitials field.
	''' </summary>
	Public Property SenderInitials() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.SenderInitialsColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SenderInitialsColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SenderInitialsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SenderInitialsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SenderInitialsDefault() As String
        Get
            Return TableUtils.SenderInitialsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.SenderSignedAt field.
	''' </summary>
	Public Property SenderSignedAt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.SenderSignedAtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SenderSignedAtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SenderSignedAtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SenderSignedAtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SenderSignedAtDefault() As String
        Get
            Return TableUtils.SenderSignedAtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.SenderSignedFrom field.
	''' </summary>
	Public Property SenderSignedFrom() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SenderSignedFromColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SenderSignedFromColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SenderSignedFromSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SenderSignedFromColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SenderSignedFromDefault() As String
        Get
            Return TableUtils.SenderSignedFromColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.RecipientSignature field.
	''' </summary>
	Public Property RecipientSignature() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.RecipientSignatureColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RecipientSignatureColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RecipientSignatureSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RecipientSignatureColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RecipientSignatureDefault() As String
        Get
            Return TableUtils.RecipientSignatureColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.RecipientInitials field.
	''' </summary>
	Public Property RecipientInitials() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.RecipientInitialsColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RecipientInitialsColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RecipientInitialsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RecipientInitialsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RecipientInitialsDefault() As String
        Get
            Return TableUtils.RecipientInitialsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.RecipientSignedAt field.
	''' </summary>
	Public Property RecipientSignedAt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.RecipientSignedAtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RecipientSignedAtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RecipientSignedAtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RecipientSignedAtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RecipientSignedAtDefault() As String
        Get
            Return TableUtils.RecipientSignedAtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.RecipientSignedFrom field.
	''' </summary>
	Public Property RecipientSignedFrom() As String
		Get 
			Return CType(Me.GetValue(TableUtils.RecipientSignedFromColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.RecipientSignedFromColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RecipientSignedFromSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RecipientSignedFromColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RecipientSignedFromDefault() As String
        Get
            Return TableUtils.RecipientSignedFromColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.AddSignaturePage field.
	''' </summary>
	Public Property AddSignaturePage() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.AddSignaturePageColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AddSignaturePageColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AddSignaturePageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AddSignaturePageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AddSignaturePageDefault() As String
        Get
            Return TableUtils.AddSignaturePageColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.FlowStepID field.
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
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.InstanceID field.
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
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.FirstItem field.
	''' </summary>
	Public Property FirstItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstItemDefault() As String
        Get
            Return TableUtils.FirstItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.SecondItem field.
	''' </summary>
	Public Property SecondItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SecondItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SecondItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondItemDefault() As String
        Get
            Return TableUtils.SecondItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.ThirdItem field.
	''' </summary>
	Public Property ThirdItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirdItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdItemDefault() As String
        Get
            Return TableUtils.ThirdItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.FourthItem field.
	''' </summary>
	Public Property FourthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthItemDefault() As String
        Get
            Return TableUtils.FourthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.FifthItem field.
	''' </summary>
	Public Property FifthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthItemDefault() As String
        Get
            Return TableUtils.FifthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.SixthItem field.
	''' </summary>
	Public Property SixthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SixthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SixthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthItemDefault() As String
        Get
            Return TableUtils.SixthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.SeventhItem field.
	''' </summary>
	Public Property SeventhItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SeventhItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhItemDefault() As String
        Get
            Return TableUtils.SeventhItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.EighthItem field.
	''' </summary>
	Public Property EighthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EighthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EighthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthItemDefault() As String
        Get
            Return TableUtils.EighthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.NinthItem field.
	''' </summary>
	Public Property NinthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.NinthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.NinthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthItemDefault() As String
        Get
            Return TableUtils.NinthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.TenthItem field.
	''' </summary>
	Public Property TenthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TenthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TenthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthItemDefault() As String
        Get
            Return TableUtils.TenthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.EleventhItem field.
	''' </summary>
	Public Property EleventhItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EleventhItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhItemDefault() As String
        Get
            Return TableUtils.EleventhItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.TwelfthItem field.
	''' </summary>
	Public Property TwelfthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TwelfthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthItemDefault() As String
        Get
            Return TableUtils.TwelfthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.ThirteenthItem field.
	''' </summary>
	Public Property ThirteenthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirteenthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthItemDefault() As String
        Get
            Return TableUtils.ThirteenthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.FourteenthItem field.
	''' </summary>
	Public Property FourteenthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourteenthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthItemDefault() As String
        Get
            Return TableUtils.FourteenthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.FifteenthItem field.
	''' </summary>
	Public Property FifteenthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifteenthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthItemDefault() As String
        Get
            Return TableUtils.FifteenthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.BarCode field.
	''' </summary>
	Public Property BarCode() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.BarCodeColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.BarCodeColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property BarCodeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.BarCodeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property BarCodeDefault() As String
        Get
            Return TableUtils.BarCodeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's AgreementExecution_.UpdatedAt field.
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
