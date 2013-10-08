' This class is "generated" and will be overwritten.
' Your customizations should be made in V_ExecutionRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_ExecutionRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_ExecutionView"></see> class.
''' </remarks>
''' <seealso cref="V_ExecutionView"></seealso>
''' <seealso cref="V_ExecutionRecord"></seealso>

<Serializable()> Public Class BaseV_ExecutionRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_ExecutionView = V_ExecutionView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_ExecutionRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_ExecutionRec As V_ExecutionRecord = CType(sender,V_ExecutionRecord)
        Validate_Inserting()
        If Not V_ExecutionRec Is Nothing AndAlso Not V_ExecutionRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_ExecutionRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_ExecutionRec As V_ExecutionRecord = CType(sender,V_ExecutionRecord)
        Validate_Updating()
        If Not V_ExecutionRec Is Nothing AndAlso Not V_ExecutionRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_ExecutionRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_ExecutionRec As V_ExecutionRecord = CType(sender,V_ExecutionRecord)
        If Not V_ExecutionRec Is Nothing AndAlso Not V_ExecutionRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ExecutionID field.
	''' </summary>
	Public Function GetExecutionIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExecutionIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ExecutionID field.
	''' </summary>
	Public Function GetExecutionIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ExecutionIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.CIX field.
	''' </summary>
	Public Function GetCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.CIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.CIX field.
	''' </summary>
	Public Function GetCIXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CIXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.OIX field.
	''' </summary>
	Public Function GetOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.OIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.OIX field.
	''' </summary>
	Public Function GetOIXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.OIXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.AgreementID field.
	''' </summary>
	Public Function GetAgreementIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AgreementIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.AgreementID field.
	''' </summary>
	Public Function GetAgreementIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AgreementIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FlowStepID field.
	''' </summary>
	Public Function GetFlowStepIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowStepIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FlowStepID field.
	''' </summary>
	Public Function GetFlowStepIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowStepIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SenderAddrID field.
	''' </summary>
	Public Function GetSenderAddrIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderAddrIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SenderAddrID field.
	''' </summary>
	Public Function GetSenderAddrIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SenderAddrIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SenderAddrID field.
	''' </summary>
	Public Sub SetSenderAddrIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SenderAddrID field.
	''' </summary>
	Public Sub SetSenderAddrIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SenderAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SenderAddrID field.
	''' </summary>
	Public Sub SetSenderAddrIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SenderAddrID field.
	''' </summary>
	Public Sub SetSenderAddrIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SenderAddrID field.
	''' </summary>
	Public Sub SetSenderAddrIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderAddrIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SenderSignerID field.
	''' </summary>
	Public Function GetSenderSignerIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderSignerIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SenderSignerID field.
	''' </summary>
	Public Function GetSenderSignerIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SenderSignerIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SenderSignerID field.
	''' </summary>
	Public Sub SetSenderSignerIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SenderSignerID field.
	''' </summary>
	Public Sub SetSenderSignerIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SenderSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SenderSignerID field.
	''' </summary>
	Public Sub SetSenderSignerIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SenderSignerID field.
	''' </summary>
	Public Sub SetSenderSignerIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SenderSignerID field.
	''' </summary>
	Public Sub SetSenderSignerIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderSignerIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.RecipientAddrID field.
	''' </summary>
	Public Function GetRecipientAddrIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RecipientAddrIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.RecipientAddrID field.
	''' </summary>
	Public Function GetRecipientAddrIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RecipientAddrIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.RecipientAddrID field.
	''' </summary>
	Public Sub SetRecipientAddrIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RecipientAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.RecipientAddrID field.
	''' </summary>
	Public Sub SetRecipientAddrIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RecipientAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.RecipientAddrID field.
	''' </summary>
	Public Sub SetRecipientAddrIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.RecipientAddrID field.
	''' </summary>
	Public Sub SetRecipientAddrIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.RecipientAddrID field.
	''' </summary>
	Public Sub SetRecipientAddrIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientAddrIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.RecipientSignerID field.
	''' </summary>
	Public Function GetRecipientSignerIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RecipientSignerIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.RecipientSignerID field.
	''' </summary>
	Public Function GetRecipientSignerIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RecipientSignerIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.RecipientSignerID field.
	''' </summary>
	Public Sub SetRecipientSignerIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RecipientSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.RecipientSignerID field.
	''' </summary>
	Public Sub SetRecipientSignerIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RecipientSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.RecipientSignerID field.
	''' </summary>
	Public Sub SetRecipientSignerIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.RecipientSignerID field.
	''' </summary>
	Public Sub SetRecipientSignerIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.RecipientSignerID field.
	''' </summary>
	Public Sub SetRecipientSignerIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientSignerIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SignedOn field.
	''' </summary>
	Public Function GetSignedOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.SignedOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SignedOn field.
	''' </summary>
	Public Function GetSignedOnFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.SignedOnColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SignedOn field.
	''' </summary>
	Public Sub SetSignedOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SignedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SignedOn field.
	''' </summary>
	Public Sub SetSignedOnFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SignedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SignedOn field.
	''' </summary>
	Public Sub SetSignedOnFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SignedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ExpiresOn field.
	''' </summary>
	Public Function GetExpiresOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExpiresOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ExpiresOn field.
	''' </summary>
	Public Function GetExpiresOnFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.ExpiresOnColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ExpiresOn field.
	''' </summary>
	Public Sub SetExpiresOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExpiresOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ExpiresOn field.
	''' </summary>
	Public Sub SetExpiresOnFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExpiresOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ExpiresOn field.
	''' </summary>
	Public Sub SetExpiresOnFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExpiresOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.AddSignaturePage field.
	''' </summary>
	Public Function GetAddSignaturePageValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddSignaturePageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.AddSignaturePage field.
	''' </summary>
	Public Function GetAddSignaturePageFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.AddSignaturePageColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.AddSignaturePage field.
	''' </summary>
	Public Sub SetAddSignaturePageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddSignaturePageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.AddSignaturePage field.
	''' </summary>
	Public Sub SetAddSignaturePageFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AddSignaturePageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.AddSignaturePage field.
	''' </summary>
	Public Sub SetAddSignaturePageFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddSignaturePageColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FirstItem field.
	''' </summary>
	Public Function GetFirstItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FirstItem field.
	''' </summary>
	Public Function GetFirstItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstItem field.
	''' </summary>
	Public Sub SetFirstItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstItem field.
	''' </summary>
	Public Sub SetFirstItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SecondItem field.
	''' </summary>
	Public Function GetSecondItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SecondItem field.
	''' </summary>
	Public Function GetSecondItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SecondItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondItem field.
	''' </summary>
	Public Sub SetSecondItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondItem field.
	''' </summary>
	Public Sub SetSecondItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirdItem field.
	''' </summary>
	Public Function GetThirdItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirdItem field.
	''' </summary>
	Public Function GetThirdItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirdItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdItem field.
	''' </summary>
	Public Sub SetThirdItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdItem field.
	''' </summary>
	Public Sub SetThirdItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourthItem field.
	''' </summary>
	Public Function GetFourthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourthItem field.
	''' </summary>
	Public Function GetFourthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthItem field.
	''' </summary>
	Public Sub SetFourthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthItem field.
	''' </summary>
	Public Sub SetFourthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifthItem field.
	''' </summary>
	Public Function GetFifthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifthItem field.
	''' </summary>
	Public Function GetFifthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthItem field.
	''' </summary>
	Public Sub SetFifthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthItem field.
	''' </summary>
	Public Sub SetFifthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SixthItem field.
	''' </summary>
	Public Function GetSixthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SixthItem field.
	''' </summary>
	Public Function GetSixthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SixthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthItem field.
	''' </summary>
	Public Sub SetSixthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthItem field.
	''' </summary>
	Public Sub SetSixthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SeventhItem field.
	''' </summary>
	Public Function GetSeventhItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SeventhItem field.
	''' </summary>
	Public Function GetSeventhItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SeventhItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhItem field.
	''' </summary>
	Public Sub SetSeventhItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhItem field.
	''' </summary>
	Public Sub SetSeventhItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EighthItem field.
	''' </summary>
	Public Function GetEighthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EighthItem field.
	''' </summary>
	Public Function GetEighthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EighthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthItem field.
	''' </summary>
	Public Sub SetEighthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthItem field.
	''' </summary>
	Public Sub SetEighthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.NinthItem field.
	''' </summary>
	Public Function GetNinthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.NinthItem field.
	''' </summary>
	Public Function GetNinthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NinthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthItem field.
	''' </summary>
	Public Sub SetNinthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthItem field.
	''' </summary>
	Public Sub SetNinthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TenthItem field.
	''' </summary>
	Public Function GetTenthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TenthItem field.
	''' </summary>
	Public Function GetTenthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TenthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthItem field.
	''' </summary>
	Public Sub SetTenthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthItem field.
	''' </summary>
	Public Sub SetTenthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EleventhItem field.
	''' </summary>
	Public Function GetEleventhItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EleventhItem field.
	''' </summary>
	Public Function GetEleventhItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EleventhItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhItem field.
	''' </summary>
	Public Sub SetEleventhItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhItem field.
	''' </summary>
	Public Sub SetEleventhItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TwelfthItem field.
	''' </summary>
	Public Function GetTwelfthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TwelfthItem field.
	''' </summary>
	Public Function GetTwelfthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TwelfthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthItem field.
	''' </summary>
	Public Sub SetTwelfthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthItem field.
	''' </summary>
	Public Sub SetTwelfthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirteenthItem field.
	''' </summary>
	Public Function GetThirteenthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirteenthItem field.
	''' </summary>
	Public Function GetThirteenthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirteenthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthItem field.
	''' </summary>
	Public Sub SetThirteenthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthItem field.
	''' </summary>
	Public Sub SetThirteenthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourteenthItem field.
	''' </summary>
	Public Function GetFourteenthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourteenthItem field.
	''' </summary>
	Public Function GetFourteenthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourteenthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthItem field.
	''' </summary>
	Public Sub SetFourteenthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthItem field.
	''' </summary>
	Public Sub SetFourteenthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifteenthItem field.
	''' </summary>
	Public Function GetFifteenthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifteenthItem field.
	''' </summary>
	Public Function GetFifteenthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifteenthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthItem field.
	''' </summary>
	Public Sub SetFifteenthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthItem field.
	''' </summary>
	Public Sub SetFifteenthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ShowSignatureDate field.
	''' </summary>
	Public Function GetShowSignatureDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShowSignatureDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ShowSignatureDate field.
	''' </summary>
	Public Function GetShowSignatureDateFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ShowSignatureDateColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ShowSignatureDate field.
	''' </summary>
	Public Sub SetShowSignatureDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShowSignatureDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ShowSignatureDate field.
	''' </summary>
	Public Sub SetShowSignatureDateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ShowSignatureDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ShowSignatureDate field.
	''' </summary>
	Public Sub SetShowSignatureDateFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShowSignatureDateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ShowExpirationDate field.
	''' </summary>
	Public Function GetShowExpirationDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShowExpirationDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ShowExpirationDate field.
	''' </summary>
	Public Function GetShowExpirationDateFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ShowExpirationDateColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ShowExpirationDate field.
	''' </summary>
	Public Sub SetShowExpirationDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShowExpirationDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ShowExpirationDate field.
	''' </summary>
	Public Sub SetShowExpirationDateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ShowExpirationDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ShowExpirationDate field.
	''' </summary>
	Public Sub SetShowExpirationDateFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShowExpirationDateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ExecuteFromBoard field.
	''' </summary>
	Public Function GetExecuteFromBoardValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExecuteFromBoardColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ExecuteFromBoard field.
	''' </summary>
	Public Function GetExecuteFromBoardFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ExecuteFromBoardColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ExecuteFromBoard field.
	''' </summary>
	Public Sub SetExecuteFromBoardFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExecuteFromBoardColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ExecuteFromBoard field.
	''' </summary>
	Public Sub SetExecuteFromBoardFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExecuteFromBoardColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ExecuteFromBoard field.
	''' </summary>
	Public Sub SetExecuteFromBoardFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecuteFromBoardColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.OtherInstructions field.
	''' </summary>
	Public Function GetOtherInstructionsValue() As ColumnValue
		Return Me.GetValue(TableUtils.OtherInstructionsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.OtherInstructions field.
	''' </summary>
	Public Function GetOtherInstructionsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.OtherInstructionsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.OtherInstructions field.
	''' </summary>
	Public Sub SetOtherInstructionsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OtherInstructionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.OtherInstructions field.
	''' </summary>
	Public Sub SetOtherInstructionsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OtherInstructionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SenderInstructions field.
	''' </summary>
	Public Function GetSenderInstructionsValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderInstructionsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SenderInstructions field.
	''' </summary>
	Public Function GetSenderInstructionsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SenderInstructionsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SenderInstructions field.
	''' </summary>
	Public Sub SetSenderInstructionsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderInstructionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SenderInstructions field.
	''' </summary>
	Public Sub SetSenderInstructionsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderInstructionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.RecipientInstructions field.
	''' </summary>
	Public Function GetRecipientInstructionsValue() As ColumnValue
		Return Me.GetValue(TableUtils.RecipientInstructionsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.RecipientInstructions field.
	''' </summary>
	Public Function GetRecipientInstructionsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.RecipientInstructionsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.RecipientInstructions field.
	''' </summary>
	Public Sub SetRecipientInstructionsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RecipientInstructionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.RecipientInstructions field.
	''' </summary>
	Public Sub SetRecipientInstructionsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientInstructionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FirstItemName field.
	''' </summary>
	Public Function GetFirstItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FirstItemName field.
	''' </summary>
	Public Function GetFirstItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstItemName field.
	''' </summary>
	Public Sub SetFirstItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstItemName field.
	''' </summary>
	Public Sub SetFirstItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FirstTypeID field.
	''' </summary>
	Public Function GetFirstTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FirstTypeID field.
	''' </summary>
	Public Function GetFirstTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FirstTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstTypeID field.
	''' </summary>
	Public Sub SetFirstTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstTypeID field.
	''' </summary>
	Public Sub SetFirstTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FirstTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstTypeID field.
	''' </summary>
	Public Sub SetFirstTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstTypeID field.
	''' </summary>
	Public Sub SetFirstTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstTypeID field.
	''' </summary>
	Public Sub SetFirstTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FirstDefault field.
	''' </summary>
	Public Function GetFirstDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FirstDefault field.
	''' </summary>
	Public Function GetFirstDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstDefault field.
	''' </summary>
	Public Sub SetFirstDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstDefault field.
	''' </summary>
	Public Sub SetFirstDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FirstByCIX field.
	''' </summary>
	Public Function GetFirstByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FirstByCIX field.
	''' </summary>
	Public Function GetFirstByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FirstByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstByCIX field.
	''' </summary>
	Public Sub SetFirstByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstByCIX field.
	''' </summary>
	Public Sub SetFirstByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FirstByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstByCIX field.
	''' </summary>
	Public Sub SetFirstByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FirstByOIX field.
	''' </summary>
	Public Function GetFirstByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FirstByOIX field.
	''' </summary>
	Public Function GetFirstByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FirstByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstByOIX field.
	''' </summary>
	Public Sub SetFirstByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstByOIX field.
	''' </summary>
	Public Sub SetFirstByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FirstByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FirstByOIX field.
	''' </summary>
	Public Sub SetFirstByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SecondItemName field.
	''' </summary>
	Public Function GetSecondItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SecondItemName field.
	''' </summary>
	Public Function GetSecondItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SecondItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondItemName field.
	''' </summary>
	Public Sub SetSecondItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondItemName field.
	''' </summary>
	Public Sub SetSecondItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SecondTypeID field.
	''' </summary>
	Public Function GetSecondTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SecondTypeID field.
	''' </summary>
	Public Function GetSecondTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SecondTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondTypeID field.
	''' </summary>
	Public Sub SetSecondTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondTypeID field.
	''' </summary>
	Public Sub SetSecondTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SecondTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondTypeID field.
	''' </summary>
	Public Sub SetSecondTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondTypeID field.
	''' </summary>
	Public Sub SetSecondTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondTypeID field.
	''' </summary>
	Public Sub SetSecondTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SecondDefault field.
	''' </summary>
	Public Function GetSecondDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SecondDefault field.
	''' </summary>
	Public Function GetSecondDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SecondDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondDefault field.
	''' </summary>
	Public Sub SetSecondDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondDefault field.
	''' </summary>
	Public Sub SetSecondDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SecondByCIX field.
	''' </summary>
	Public Function GetSecondByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SecondByCIX field.
	''' </summary>
	Public Function GetSecondByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SecondByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondByCIX field.
	''' </summary>
	Public Sub SetSecondByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondByCIX field.
	''' </summary>
	Public Sub SetSecondByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SecondByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondByCIX field.
	''' </summary>
	Public Sub SetSecondByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SecondByOIX field.
	''' </summary>
	Public Function GetSecondByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SecondByOIX field.
	''' </summary>
	Public Function GetSecondByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SecondByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondByOIX field.
	''' </summary>
	Public Sub SetSecondByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondByOIX field.
	''' </summary>
	Public Sub SetSecondByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SecondByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SecondByOIX field.
	''' </summary>
	Public Sub SetSecondByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirdItemName field.
	''' </summary>
	Public Function GetThirdItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirdItemName field.
	''' </summary>
	Public Function GetThirdItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirdItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdItemName field.
	''' </summary>
	Public Sub SetThirdItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdItemName field.
	''' </summary>
	Public Sub SetThirdItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirdTypeID field.
	''' </summary>
	Public Function GetThirdTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirdTypeID field.
	''' </summary>
	Public Function GetThirdTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ThirdTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdTypeID field.
	''' </summary>
	Public Sub SetThirdTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdTypeID field.
	''' </summary>
	Public Sub SetThirdTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirdTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdTypeID field.
	''' </summary>
	Public Sub SetThirdTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdTypeID field.
	''' </summary>
	Public Sub SetThirdTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdTypeID field.
	''' </summary>
	Public Sub SetThirdTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirdDefault field.
	''' </summary>
	Public Function GetThirdDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirdDefault field.
	''' </summary>
	Public Function GetThirdDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirdDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdDefault field.
	''' </summary>
	Public Sub SetThirdDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdDefault field.
	''' </summary>
	Public Sub SetThirdDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirdByCIX field.
	''' </summary>
	Public Function GetThirdByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirdByCIX field.
	''' </summary>
	Public Function GetThirdByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThirdByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdByCIX field.
	''' </summary>
	Public Sub SetThirdByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdByCIX field.
	''' </summary>
	Public Sub SetThirdByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirdByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdByCIX field.
	''' </summary>
	Public Sub SetThirdByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirdByOIX field.
	''' </summary>
	Public Function GetThirdByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirdByOIX field.
	''' </summary>
	Public Function GetThirdByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThirdByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdByOIX field.
	''' </summary>
	Public Sub SetThirdByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdByOIX field.
	''' </summary>
	Public Sub SetThirdByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirdByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirdByOIX field.
	''' </summary>
	Public Sub SetThirdByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourthItemName field.
	''' </summary>
	Public Function GetFourthItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourthItemName field.
	''' </summary>
	Public Function GetFourthItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourthItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthItemName field.
	''' </summary>
	Public Sub SetFourthItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthItemName field.
	''' </summary>
	Public Sub SetFourthItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourthTypeID field.
	''' </summary>
	Public Function GetFourthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourthTypeID field.
	''' </summary>
	Public Function GetFourthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FourthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthTypeID field.
	''' </summary>
	Public Sub SetFourthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthTypeID field.
	''' </summary>
	Public Sub SetFourthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthTypeID field.
	''' </summary>
	Public Sub SetFourthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthTypeID field.
	''' </summary>
	Public Sub SetFourthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthTypeID field.
	''' </summary>
	Public Sub SetFourthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourthDefault field.
	''' </summary>
	Public Function GetFourthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourthDefault field.
	''' </summary>
	Public Function GetFourthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthDefault field.
	''' </summary>
	Public Sub SetFourthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthDefault field.
	''' </summary>
	Public Sub SetFourthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourthByCIX field.
	''' </summary>
	Public Function GetFourthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourthByCIX field.
	''' </summary>
	Public Function GetFourthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FourthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthByCIX field.
	''' </summary>
	Public Sub SetFourthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthByCIX field.
	''' </summary>
	Public Sub SetFourthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthByCIX field.
	''' </summary>
	Public Sub SetFourthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourthByOIX field.
	''' </summary>
	Public Function GetFourthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourthByOIX field.
	''' </summary>
	Public Function GetFourthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FourthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthByOIX field.
	''' </summary>
	Public Sub SetFourthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthByOIX field.
	''' </summary>
	Public Sub SetFourthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourthByOIX field.
	''' </summary>
	Public Sub SetFourthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifthItemName field.
	''' </summary>
	Public Function GetFifthItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifthItemName field.
	''' </summary>
	Public Function GetFifthItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifthItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthItemName field.
	''' </summary>
	Public Sub SetFifthItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthItemName field.
	''' </summary>
	Public Sub SetFifthItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifthTypeID field.
	''' </summary>
	Public Function GetFifthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifthTypeID field.
	''' </summary>
	Public Function GetFifthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FifthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthTypeID field.
	''' </summary>
	Public Sub SetFifthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthTypeID field.
	''' </summary>
	Public Sub SetFifthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthTypeID field.
	''' </summary>
	Public Sub SetFifthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthTypeID field.
	''' </summary>
	Public Sub SetFifthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthTypeID field.
	''' </summary>
	Public Sub SetFifthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifthDefault field.
	''' </summary>
	Public Function GetFifthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifthDefault field.
	''' </summary>
	Public Function GetFifthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthDefault field.
	''' </summary>
	Public Sub SetFifthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthDefault field.
	''' </summary>
	Public Sub SetFifthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifthByCIX field.
	''' </summary>
	Public Function GetFifthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifthByCIX field.
	''' </summary>
	Public Function GetFifthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FifthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthByCIX field.
	''' </summary>
	Public Sub SetFifthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthByCIX field.
	''' </summary>
	Public Sub SetFifthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthByCIX field.
	''' </summary>
	Public Sub SetFifthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifthByOIX field.
	''' </summary>
	Public Function GetFifthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifthByOIX field.
	''' </summary>
	Public Function GetFifthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FifthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthByOIX field.
	''' </summary>
	Public Sub SetFifthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthByOIX field.
	''' </summary>
	Public Sub SetFifthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifthByOIX field.
	''' </summary>
	Public Sub SetFifthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SixthItemName field.
	''' </summary>
	Public Function GetSixthItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SixthItemName field.
	''' </summary>
	Public Function GetSixthItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SixthItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthItemName field.
	''' </summary>
	Public Sub SetSixthItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthItemName field.
	''' </summary>
	Public Sub SetSixthItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SixthTypeID field.
	''' </summary>
	Public Function GetSixthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SixthTypeID field.
	''' </summary>
	Public Function GetSixthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SixthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthTypeID field.
	''' </summary>
	Public Sub SetSixthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthTypeID field.
	''' </summary>
	Public Sub SetSixthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SixthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthTypeID field.
	''' </summary>
	Public Sub SetSixthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthTypeID field.
	''' </summary>
	Public Sub SetSixthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthTypeID field.
	''' </summary>
	Public Sub SetSixthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SixthDefault field.
	''' </summary>
	Public Function GetSixthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SixthDefault field.
	''' </summary>
	Public Function GetSixthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SixthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthDefault field.
	''' </summary>
	Public Sub SetSixthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthDefault field.
	''' </summary>
	Public Sub SetSixthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SixthByCIX field.
	''' </summary>
	Public Function GetSixthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SixthByCIX field.
	''' </summary>
	Public Function GetSixthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SixthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthByCIX field.
	''' </summary>
	Public Sub SetSixthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthByCIX field.
	''' </summary>
	Public Sub SetSixthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SixthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthByCIX field.
	''' </summary>
	Public Sub SetSixthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SixthByOIX field.
	''' </summary>
	Public Function GetSixthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SixthByOIX field.
	''' </summary>
	Public Function GetSixthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SixthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthByOIX field.
	''' </summary>
	Public Sub SetSixthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthByOIX field.
	''' </summary>
	Public Sub SetSixthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SixthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SixthByOIX field.
	''' </summary>
	Public Sub SetSixthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SeventhItemName field.
	''' </summary>
	Public Function GetSeventhItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SeventhItemName field.
	''' </summary>
	Public Function GetSeventhItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SeventhItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhItemName field.
	''' </summary>
	Public Sub SetSeventhItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhItemName field.
	''' </summary>
	Public Sub SetSeventhItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SeventhTypeID field.
	''' </summary>
	Public Function GetSeventhTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SeventhTypeID field.
	''' </summary>
	Public Function GetSeventhTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SeventhTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhTypeID field.
	''' </summary>
	Public Sub SetSeventhTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhTypeID field.
	''' </summary>
	Public Sub SetSeventhTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SeventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhTypeID field.
	''' </summary>
	Public Sub SetSeventhTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhTypeID field.
	''' </summary>
	Public Sub SetSeventhTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhTypeID field.
	''' </summary>
	Public Sub SetSeventhTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SeventhDefault field.
	''' </summary>
	Public Function GetSeventhDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SeventhDefault field.
	''' </summary>
	Public Function GetSeventhDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SeventhDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhDefault field.
	''' </summary>
	Public Sub SetSeventhDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhDefault field.
	''' </summary>
	Public Sub SetSeventhDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SeventhByCIX field.
	''' </summary>
	Public Function GetSeventhByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SeventhByCIX field.
	''' </summary>
	Public Function GetSeventhByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SeventhByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhByCIX field.
	''' </summary>
	Public Sub SetSeventhByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhByCIX field.
	''' </summary>
	Public Sub SetSeventhByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SeventhByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhByCIX field.
	''' </summary>
	Public Sub SetSeventhByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SeventhByOIX field.
	''' </summary>
	Public Function GetSeventhByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.SeventhByOIX field.
	''' </summary>
	Public Function GetSeventhByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SeventhByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhByOIX field.
	''' </summary>
	Public Sub SetSeventhByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhByOIX field.
	''' </summary>
	Public Sub SetSeventhByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SeventhByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.SeventhByOIX field.
	''' </summary>
	Public Sub SetSeventhByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EighthItemName field.
	''' </summary>
	Public Function GetEighthItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EighthItemName field.
	''' </summary>
	Public Function GetEighthItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EighthItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthItemName field.
	''' </summary>
	Public Sub SetEighthItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthItemName field.
	''' </summary>
	Public Sub SetEighthItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EighthTypeID field.
	''' </summary>
	Public Function GetEighthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EighthTypeID field.
	''' </summary>
	Public Function GetEighthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EighthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthTypeID field.
	''' </summary>
	Public Sub SetEighthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthTypeID field.
	''' </summary>
	Public Sub SetEighthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EighthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthTypeID field.
	''' </summary>
	Public Sub SetEighthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthTypeID field.
	''' </summary>
	Public Sub SetEighthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthTypeID field.
	''' </summary>
	Public Sub SetEighthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EighthDefault field.
	''' </summary>
	Public Function GetEighthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EighthDefault field.
	''' </summary>
	Public Function GetEighthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EighthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthDefault field.
	''' </summary>
	Public Sub SetEighthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthDefault field.
	''' </summary>
	Public Sub SetEighthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EighthByCIX field.
	''' </summary>
	Public Function GetEighthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EighthByCIX field.
	''' </summary>
	Public Function GetEighthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.EighthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthByCIX field.
	''' </summary>
	Public Sub SetEighthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthByCIX field.
	''' </summary>
	Public Sub SetEighthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EighthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthByCIX field.
	''' </summary>
	Public Sub SetEighthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EighthByOIX field.
	''' </summary>
	Public Function GetEighthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EighthByOIX field.
	''' </summary>
	Public Function GetEighthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.EighthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthByOIX field.
	''' </summary>
	Public Sub SetEighthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthByOIX field.
	''' </summary>
	Public Sub SetEighthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EighthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EighthByOIX field.
	''' </summary>
	Public Sub SetEighthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.NinthItemName field.
	''' </summary>
	Public Function GetNinthItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.NinthItemName field.
	''' </summary>
	Public Function GetNinthItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NinthItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthItemName field.
	''' </summary>
	Public Sub SetNinthItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthItemName field.
	''' </summary>
	Public Sub SetNinthItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.NinthTypeID field.
	''' </summary>
	Public Function GetNinthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.NinthTypeID field.
	''' </summary>
	Public Function GetNinthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.NinthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthTypeID field.
	''' </summary>
	Public Sub SetNinthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthTypeID field.
	''' </summary>
	Public Sub SetNinthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.NinthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthTypeID field.
	''' </summary>
	Public Sub SetNinthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthTypeID field.
	''' </summary>
	Public Sub SetNinthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthTypeID field.
	''' </summary>
	Public Sub SetNinthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.NinthDefault field.
	''' </summary>
	Public Function GetNinthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.NinthDefault field.
	''' </summary>
	Public Function GetNinthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NinthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthDefault field.
	''' </summary>
	Public Sub SetNinthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthDefault field.
	''' </summary>
	Public Sub SetNinthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.NinthByCIX field.
	''' </summary>
	Public Function GetNinthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.NinthByCIX field.
	''' </summary>
	Public Function GetNinthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.NinthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthByCIX field.
	''' </summary>
	Public Sub SetNinthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthByCIX field.
	''' </summary>
	Public Sub SetNinthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.NinthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthByCIX field.
	''' </summary>
	Public Sub SetNinthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.NinthByOIX field.
	''' </summary>
	Public Function GetNinthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.NinthByOIX field.
	''' </summary>
	Public Function GetNinthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.NinthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthByOIX field.
	''' </summary>
	Public Sub SetNinthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthByOIX field.
	''' </summary>
	Public Sub SetNinthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.NinthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.NinthByOIX field.
	''' </summary>
	Public Sub SetNinthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TenthItemName field.
	''' </summary>
	Public Function GetTenthItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TenthItemName field.
	''' </summary>
	Public Function GetTenthItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TenthItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthItemName field.
	''' </summary>
	Public Sub SetTenthItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthItemName field.
	''' </summary>
	Public Sub SetTenthItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TenthTypeID field.
	''' </summary>
	Public Function GetTenthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TenthTypeID field.
	''' </summary>
	Public Function GetTenthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TenthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthTypeID field.
	''' </summary>
	Public Sub SetTenthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthTypeID field.
	''' </summary>
	Public Sub SetTenthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthTypeID field.
	''' </summary>
	Public Sub SetTenthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthTypeID field.
	''' </summary>
	Public Sub SetTenthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthTypeID field.
	''' </summary>
	Public Sub SetTenthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TenthDefault field.
	''' </summary>
	Public Function GetTenthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TenthDefault field.
	''' </summary>
	Public Function GetTenthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TenthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthDefault field.
	''' </summary>
	Public Sub SetTenthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthDefault field.
	''' </summary>
	Public Sub SetTenthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TenthByCIX field.
	''' </summary>
	Public Function GetTenthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TenthByCIX field.
	''' </summary>
	Public Function GetTenthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TenthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthByCIX field.
	''' </summary>
	Public Sub SetTenthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthByCIX field.
	''' </summary>
	Public Sub SetTenthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthByCIX field.
	''' </summary>
	Public Sub SetTenthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TenthByOIX field.
	''' </summary>
	Public Function GetTenthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TenthByOIX field.
	''' </summary>
	Public Function GetTenthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TenthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthByOIX field.
	''' </summary>
	Public Sub SetTenthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthByOIX field.
	''' </summary>
	Public Sub SetTenthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TenthByOIX field.
	''' </summary>
	Public Sub SetTenthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EleventhItemName field.
	''' </summary>
	Public Function GetEleventhItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EleventhItemName field.
	''' </summary>
	Public Function GetEleventhItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EleventhItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhItemName field.
	''' </summary>
	Public Sub SetEleventhItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhItemName field.
	''' </summary>
	Public Sub SetEleventhItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EleventhTypeID field.
	''' </summary>
	Public Function GetEleventhTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EleventhTypeID field.
	''' </summary>
	Public Function GetEleventhTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EleventhTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhTypeID field.
	''' </summary>
	Public Sub SetEleventhTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhTypeID field.
	''' </summary>
	Public Sub SetEleventhTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EleventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhTypeID field.
	''' </summary>
	Public Sub SetEleventhTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhTypeID field.
	''' </summary>
	Public Sub SetEleventhTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhTypeID field.
	''' </summary>
	Public Sub SetEleventhTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EleventhDefault field.
	''' </summary>
	Public Function GetEleventhDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EleventhDefault field.
	''' </summary>
	Public Function GetEleventhDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EleventhDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhDefault field.
	''' </summary>
	Public Sub SetEleventhDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhDefault field.
	''' </summary>
	Public Sub SetEleventhDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EleventhByCIX field.
	''' </summary>
	Public Function GetEleventhByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EleventhByCIX field.
	''' </summary>
	Public Function GetEleventhByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.EleventhByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhByCIX field.
	''' </summary>
	Public Sub SetEleventhByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhByCIX field.
	''' </summary>
	Public Sub SetEleventhByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EleventhByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhByCIX field.
	''' </summary>
	Public Sub SetEleventhByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EleventhByOIX field.
	''' </summary>
	Public Function GetEleventhByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.EleventhByOIX field.
	''' </summary>
	Public Function GetEleventhByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.EleventhByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhByOIX field.
	''' </summary>
	Public Sub SetEleventhByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhByOIX field.
	''' </summary>
	Public Sub SetEleventhByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EleventhByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.EleventhByOIX field.
	''' </summary>
	Public Sub SetEleventhByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TwelfthItemName field.
	''' </summary>
	Public Function GetTwelfthItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TwelfthItemName field.
	''' </summary>
	Public Function GetTwelfthItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TwelfthItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthItemName field.
	''' </summary>
	Public Sub SetTwelfthItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthItemName field.
	''' </summary>
	Public Sub SetTwelfthItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TwelfthTypeID field.
	''' </summary>
	Public Function GetTwelfthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TwelfthTypeID field.
	''' </summary>
	Public Function GetTwelfthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TwelfthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthTypeID field.
	''' </summary>
	Public Sub SetTwelfthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthTypeID field.
	''' </summary>
	Public Sub SetTwelfthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TwelfthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthTypeID field.
	''' </summary>
	Public Sub SetTwelfthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthTypeID field.
	''' </summary>
	Public Sub SetTwelfthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthTypeID field.
	''' </summary>
	Public Sub SetTwelfthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TwelfthDefault field.
	''' </summary>
	Public Function GetTwelfthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TwelfthDefault field.
	''' </summary>
	Public Function GetTwelfthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TwelfthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthDefault field.
	''' </summary>
	Public Sub SetTwelfthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthDefault field.
	''' </summary>
	Public Sub SetTwelfthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TwelfthByCIX field.
	''' </summary>
	Public Function GetTwelfthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TwelfthByCIX field.
	''' </summary>
	Public Function GetTwelfthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TwelfthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthByCIX field.
	''' </summary>
	Public Sub SetTwelfthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthByCIX field.
	''' </summary>
	Public Sub SetTwelfthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TwelfthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthByCIX field.
	''' </summary>
	Public Sub SetTwelfthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TwelfthByOIX field.
	''' </summary>
	Public Function GetTwelfthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.TwelfthByOIX field.
	''' </summary>
	Public Function GetTwelfthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TwelfthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthByOIX field.
	''' </summary>
	Public Sub SetTwelfthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthByOIX field.
	''' </summary>
	Public Sub SetTwelfthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TwelfthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.TwelfthByOIX field.
	''' </summary>
	Public Sub SetTwelfthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirteenthItemName field.
	''' </summary>
	Public Function GetThirteenthItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirteenthItemName field.
	''' </summary>
	Public Function GetThirteenthItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirteenthItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthItemName field.
	''' </summary>
	Public Sub SetThirteenthItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthItemName field.
	''' </summary>
	Public Sub SetThirteenthItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirteenthTypeID field.
	''' </summary>
	Public Function GetThirteenthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirteenthTypeID field.
	''' </summary>
	Public Function GetThirteenthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ThirteenthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthTypeID field.
	''' </summary>
	Public Sub SetThirteenthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthTypeID field.
	''' </summary>
	Public Sub SetThirteenthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthTypeID field.
	''' </summary>
	Public Sub SetThirteenthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthTypeID field.
	''' </summary>
	Public Sub SetThirteenthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthTypeID field.
	''' </summary>
	Public Sub SetThirteenthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirteenthDefault field.
	''' </summary>
	Public Function GetThirteenthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirteenthDefault field.
	''' </summary>
	Public Function GetThirteenthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirteenthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthDefault field.
	''' </summary>
	Public Sub SetThirteenthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthDefault field.
	''' </summary>
	Public Sub SetThirteenthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirteenthByCIX field.
	''' </summary>
	Public Function GetThirteenthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirteenthByCIX field.
	''' </summary>
	Public Function GetThirteenthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThirteenthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthByCIX field.
	''' </summary>
	Public Sub SetThirteenthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthByCIX field.
	''' </summary>
	Public Sub SetThirteenthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirteenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthByCIX field.
	''' </summary>
	Public Sub SetThirteenthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirteenthByOIX field.
	''' </summary>
	Public Function GetThirteenthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.ThirteenthByOIX field.
	''' </summary>
	Public Function GetThirteenthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThirteenthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthByOIX field.
	''' </summary>
	Public Sub SetThirteenthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthByOIX field.
	''' </summary>
	Public Sub SetThirteenthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirteenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.ThirteenthByOIX field.
	''' </summary>
	Public Sub SetThirteenthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourteenthItemName field.
	''' </summary>
	Public Function GetFourteenthItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourteenthItemName field.
	''' </summary>
	Public Function GetFourteenthItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourteenthItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthItemName field.
	''' </summary>
	Public Sub SetFourteenthItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthItemName field.
	''' </summary>
	Public Sub SetFourteenthItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourteenthTypeID field.
	''' </summary>
	Public Function GetFourteenthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourteenthTypeID field.
	''' </summary>
	Public Function GetFourteenthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FourteenthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthTypeID field.
	''' </summary>
	Public Sub SetFourteenthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthTypeID field.
	''' </summary>
	Public Sub SetFourteenthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthTypeID field.
	''' </summary>
	Public Sub SetFourteenthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthTypeID field.
	''' </summary>
	Public Sub SetFourteenthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthTypeID field.
	''' </summary>
	Public Sub SetFourteenthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourteenthDefault field.
	''' </summary>
	Public Function GetFourteenthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourteenthDefault field.
	''' </summary>
	Public Function GetFourteenthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourteenthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthDefault field.
	''' </summary>
	Public Sub SetFourteenthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthDefault field.
	''' </summary>
	Public Sub SetFourteenthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourteenthByCIX field.
	''' </summary>
	Public Function GetFourteenthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourteenthByCIX field.
	''' </summary>
	Public Function GetFourteenthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FourteenthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthByCIX field.
	''' </summary>
	Public Sub SetFourteenthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthByCIX field.
	''' </summary>
	Public Sub SetFourteenthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourteenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthByCIX field.
	''' </summary>
	Public Sub SetFourteenthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourteenthByOIX field.
	''' </summary>
	Public Function GetFourteenthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FourteenthByOIX field.
	''' </summary>
	Public Function GetFourteenthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FourteenthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthByOIX field.
	''' </summary>
	Public Sub SetFourteenthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthByOIX field.
	''' </summary>
	Public Sub SetFourteenthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourteenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FourteenthByOIX field.
	''' </summary>
	Public Sub SetFourteenthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifteenthItemName field.
	''' </summary>
	Public Function GetFifteenthItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifteenthItemName field.
	''' </summary>
	Public Function GetFifteenthItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifteenthItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthItemName field.
	''' </summary>
	Public Sub SetFifteenthItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthItemName field.
	''' </summary>
	Public Sub SetFifteenthItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifteenthTypeID field.
	''' </summary>
	Public Function GetFifteenthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifteenthTypeID field.
	''' </summary>
	Public Function GetFifteenthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FifteenthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthTypeID field.
	''' </summary>
	Public Sub SetFifteenthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthTypeID field.
	''' </summary>
	Public Sub SetFifteenthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthTypeID field.
	''' </summary>
	Public Sub SetFifteenthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthTypeID field.
	''' </summary>
	Public Sub SetFifteenthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthTypeID field.
	''' </summary>
	Public Sub SetFifteenthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifteenthDefault field.
	''' </summary>
	Public Function GetFifteenthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifteenthDefault field.
	''' </summary>
	Public Function GetFifteenthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifteenthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthDefault field.
	''' </summary>
	Public Sub SetFifteenthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthDefault field.
	''' </summary>
	Public Sub SetFifteenthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifteenthByCIX field.
	''' </summary>
	Public Function GetFifteenthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifteenthByCIX field.
	''' </summary>
	Public Function GetFifteenthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FifteenthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthByCIX field.
	''' </summary>
	Public Sub SetFifteenthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthByCIX field.
	''' </summary>
	Public Sub SetFifteenthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifteenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthByCIX field.
	''' </summary>
	Public Sub SetFifteenthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifteenthByOIX field.
	''' </summary>
	Public Function GetFifteenthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Execution_.FifteenthByOIX field.
	''' </summary>
	Public Function GetFifteenthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FifteenthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthByOIX field.
	''' </summary>
	Public Sub SetFifteenthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthByOIX field.
	''' </summary>
	Public Sub SetFifteenthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifteenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Execution_.FifteenthByOIX field.
	''' </summary>
	Public Sub SetFifteenthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthByOIXColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ExecutionID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.CIX field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.OIX field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.AgreementID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FlowStepID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SenderAddrID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SenderSignerID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.RecipientAddrID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.RecipientSignerID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SignedOn field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ExpiresOn field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.AddSignaturePage field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FirstItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SecondItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ThirdItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FourthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FifthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SixthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SeventhItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.EighthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.NinthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.TenthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.EleventhItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.TwelfthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ThirteenthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FourteenthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FifteenthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ShowSignatureDate field.
	''' </summary>
	Public Property ShowSignatureDate() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ShowSignatureDateColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ShowSignatureDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ShowSignatureDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ShowSignatureDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ShowSignatureDateDefault() As String
        Get
            Return TableUtils.ShowSignatureDateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ShowExpirationDate field.
	''' </summary>
	Public Property ShowExpirationDate() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ShowExpirationDateColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ShowExpirationDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ShowExpirationDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ShowExpirationDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ShowExpirationDateDefault() As String
        Get
            Return TableUtils.ShowExpirationDateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ExecuteFromBoard field.
	''' </summary>
	Public Property ExecuteFromBoard() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ExecuteFromBoardColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExecuteFromBoardColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExecuteFromBoardSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExecuteFromBoardColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExecuteFromBoardDefault() As String
        Get
            Return TableUtils.ExecuteFromBoardColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.OtherInstructions field.
	''' </summary>
	Public Property OtherInstructions() As String
		Get 
			Return CType(Me.GetValue(TableUtils.OtherInstructionsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.OtherInstructionsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OtherInstructionsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OtherInstructionsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OtherInstructionsDefault() As String
        Get
            Return TableUtils.OtherInstructionsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SenderInstructions field.
	''' </summary>
	Public Property SenderInstructions() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SenderInstructionsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SenderInstructionsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SenderInstructionsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SenderInstructionsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SenderInstructionsDefault() As String
        Get
            Return TableUtils.SenderInstructionsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.RecipientInstructions field.
	''' </summary>
	Public Property RecipientInstructions() As String
		Get 
			Return CType(Me.GetValue(TableUtils.RecipientInstructionsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.RecipientInstructionsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RecipientInstructionsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RecipientInstructionsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RecipientInstructionsDefault() As String
        Get
            Return TableUtils.RecipientInstructionsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FirstItemName field.
	''' </summary>
	Public Property FirstItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstItemNameDefault() As String
        Get
            Return TableUtils.FirstItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FirstTypeID field.
	''' </summary>
	Public Property FirstTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FirstTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FirstTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstTypeIDDefault() As String
        Get
            Return TableUtils.FirstTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FirstDefault field.
	''' </summary>
	Public Property FirstDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstDefaultDefault() As String
        Get
            Return TableUtils.FirstDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FirstByCIX field.
	''' </summary>
	Public Property FirstByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FirstByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FirstByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstByCIXDefault() As String
        Get
            Return TableUtils.FirstByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FirstByOIX field.
	''' </summary>
	Public Property FirstByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FirstByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FirstByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstByOIXDefault() As String
        Get
            Return TableUtils.FirstByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SecondItemName field.
	''' </summary>
	Public Property SecondItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SecondItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SecondItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondItemNameDefault() As String
        Get
            Return TableUtils.SecondItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SecondTypeID field.
	''' </summary>
	Public Property SecondTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SecondTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SecondTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondTypeIDDefault() As String
        Get
            Return TableUtils.SecondTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SecondDefault field.
	''' </summary>
	Public Property SecondDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SecondDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SecondDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondDefaultDefault() As String
        Get
            Return TableUtils.SecondDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SecondByCIX field.
	''' </summary>
	Public Property SecondByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SecondByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SecondByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondByCIXDefault() As String
        Get
            Return TableUtils.SecondByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SecondByOIX field.
	''' </summary>
	Public Property SecondByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SecondByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SecondByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondByOIXDefault() As String
        Get
            Return TableUtils.SecondByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ThirdItemName field.
	''' </summary>
	Public Property ThirdItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirdItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdItemNameDefault() As String
        Get
            Return TableUtils.ThirdItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ThirdTypeID field.
	''' </summary>
	Public Property ThirdTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirdTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdTypeIDDefault() As String
        Get
            Return TableUtils.ThirdTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ThirdDefault field.
	''' </summary>
	Public Property ThirdDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirdDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdDefaultDefault() As String
        Get
            Return TableUtils.ThirdDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ThirdByCIX field.
	''' </summary>
	Public Property ThirdByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirdByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdByCIXDefault() As String
        Get
            Return TableUtils.ThirdByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ThirdByOIX field.
	''' </summary>
	Public Property ThirdByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirdByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdByOIXDefault() As String
        Get
            Return TableUtils.ThirdByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FourthItemName field.
	''' </summary>
	Public Property FourthItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourthItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourthItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthItemNameDefault() As String
        Get
            Return TableUtils.FourthItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FourthTypeID field.
	''' </summary>
	Public Property FourthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FourthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthTypeIDDefault() As String
        Get
            Return TableUtils.FourthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FourthDefault field.
	''' </summary>
	Public Property FourthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthDefaultDefault() As String
        Get
            Return TableUtils.FourthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FourthByCIX field.
	''' </summary>
	Public Property FourthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FourthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthByCIXDefault() As String
        Get
            Return TableUtils.FourthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FourthByOIX field.
	''' </summary>
	Public Property FourthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FourthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthByOIXDefault() As String
        Get
            Return TableUtils.FourthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FifthItemName field.
	''' </summary>
	Public Property FifthItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifthItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifthItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthItemNameDefault() As String
        Get
            Return TableUtils.FifthItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FifthTypeID field.
	''' </summary>
	Public Property FifthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FifthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthTypeIDDefault() As String
        Get
            Return TableUtils.FifthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FifthDefault field.
	''' </summary>
	Public Property FifthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthDefaultDefault() As String
        Get
            Return TableUtils.FifthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FifthByCIX field.
	''' </summary>
	Public Property FifthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FifthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthByCIXDefault() As String
        Get
            Return TableUtils.FifthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FifthByOIX field.
	''' </summary>
	Public Property FifthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FifthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthByOIXDefault() As String
        Get
            Return TableUtils.FifthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SixthItemName field.
	''' </summary>
	Public Property SixthItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SixthItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SixthItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthItemNameDefault() As String
        Get
            Return TableUtils.SixthItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SixthTypeID field.
	''' </summary>
	Public Property SixthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SixthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SixthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthTypeIDDefault() As String
        Get
            Return TableUtils.SixthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SixthDefault field.
	''' </summary>
	Public Property SixthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SixthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SixthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthDefaultDefault() As String
        Get
            Return TableUtils.SixthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SixthByCIX field.
	''' </summary>
	Public Property SixthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SixthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SixthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthByCIXDefault() As String
        Get
            Return TableUtils.SixthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SixthByOIX field.
	''' </summary>
	Public Property SixthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SixthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SixthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthByOIXDefault() As String
        Get
            Return TableUtils.SixthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SeventhItemName field.
	''' </summary>
	Public Property SeventhItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SeventhItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhItemNameDefault() As String
        Get
            Return TableUtils.SeventhItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SeventhTypeID field.
	''' </summary>
	Public Property SeventhTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SeventhTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhTypeIDDefault() As String
        Get
            Return TableUtils.SeventhTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SeventhDefault field.
	''' </summary>
	Public Property SeventhDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SeventhDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhDefaultDefault() As String
        Get
            Return TableUtils.SeventhDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SeventhByCIX field.
	''' </summary>
	Public Property SeventhByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SeventhByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhByCIXDefault() As String
        Get
            Return TableUtils.SeventhByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.SeventhByOIX field.
	''' </summary>
	Public Property SeventhByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SeventhByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhByOIXDefault() As String
        Get
            Return TableUtils.SeventhByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.EighthItemName field.
	''' </summary>
	Public Property EighthItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EighthItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EighthItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthItemNameDefault() As String
        Get
            Return TableUtils.EighthItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.EighthTypeID field.
	''' </summary>
	Public Property EighthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EighthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EighthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthTypeIDDefault() As String
        Get
            Return TableUtils.EighthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.EighthDefault field.
	''' </summary>
	Public Property EighthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EighthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EighthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthDefaultDefault() As String
        Get
            Return TableUtils.EighthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.EighthByCIX field.
	''' </summary>
	Public Property EighthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.EighthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EighthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthByCIXDefault() As String
        Get
            Return TableUtils.EighthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.EighthByOIX field.
	''' </summary>
	Public Property EighthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.EighthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EighthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthByOIXDefault() As String
        Get
            Return TableUtils.EighthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.NinthItemName field.
	''' </summary>
	Public Property NinthItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.NinthItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.NinthItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthItemNameDefault() As String
        Get
            Return TableUtils.NinthItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.NinthTypeID field.
	''' </summary>
	Public Property NinthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.NinthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.NinthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthTypeIDDefault() As String
        Get
            Return TableUtils.NinthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.NinthDefault field.
	''' </summary>
	Public Property NinthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.NinthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.NinthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthDefaultDefault() As String
        Get
            Return TableUtils.NinthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.NinthByCIX field.
	''' </summary>
	Public Property NinthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.NinthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.NinthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthByCIXDefault() As String
        Get
            Return TableUtils.NinthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.NinthByOIX field.
	''' </summary>
	Public Property NinthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.NinthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.NinthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthByOIXDefault() As String
        Get
            Return TableUtils.NinthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.TenthItemName field.
	''' </summary>
	Public Property TenthItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TenthItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TenthItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthItemNameDefault() As String
        Get
            Return TableUtils.TenthItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.TenthTypeID field.
	''' </summary>
	Public Property TenthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TenthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TenthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthTypeIDDefault() As String
        Get
            Return TableUtils.TenthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.TenthDefault field.
	''' </summary>
	Public Property TenthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TenthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TenthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthDefaultDefault() As String
        Get
            Return TableUtils.TenthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.TenthByCIX field.
	''' </summary>
	Public Property TenthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TenthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TenthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthByCIXDefault() As String
        Get
            Return TableUtils.TenthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.TenthByOIX field.
	''' </summary>
	Public Property TenthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TenthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TenthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthByOIXDefault() As String
        Get
            Return TableUtils.TenthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.EleventhItemName field.
	''' </summary>
	Public Property EleventhItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EleventhItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhItemNameDefault() As String
        Get
            Return TableUtils.EleventhItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.EleventhTypeID field.
	''' </summary>
	Public Property EleventhTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EleventhTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhTypeIDDefault() As String
        Get
            Return TableUtils.EleventhTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.EleventhDefault field.
	''' </summary>
	Public Property EleventhDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EleventhDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhDefaultDefault() As String
        Get
            Return TableUtils.EleventhDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.EleventhByCIX field.
	''' </summary>
	Public Property EleventhByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EleventhByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhByCIXDefault() As String
        Get
            Return TableUtils.EleventhByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.EleventhByOIX field.
	''' </summary>
	Public Property EleventhByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EleventhByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhByOIXDefault() As String
        Get
            Return TableUtils.EleventhByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.TwelfthItemName field.
	''' </summary>
	Public Property TwelfthItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TwelfthItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthItemNameDefault() As String
        Get
            Return TableUtils.TwelfthItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.TwelfthTypeID field.
	''' </summary>
	Public Property TwelfthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TwelfthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthTypeIDDefault() As String
        Get
            Return TableUtils.TwelfthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.TwelfthDefault field.
	''' </summary>
	Public Property TwelfthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TwelfthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthDefaultDefault() As String
        Get
            Return TableUtils.TwelfthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.TwelfthByCIX field.
	''' </summary>
	Public Property TwelfthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TwelfthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthByCIXDefault() As String
        Get
            Return TableUtils.TwelfthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.TwelfthByOIX field.
	''' </summary>
	Public Property TwelfthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TwelfthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthByOIXDefault() As String
        Get
            Return TableUtils.TwelfthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ThirteenthItemName field.
	''' </summary>
	Public Property ThirteenthItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirteenthItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthItemNameDefault() As String
        Get
            Return TableUtils.ThirteenthItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ThirteenthTypeID field.
	''' </summary>
	Public Property ThirteenthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirteenthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthTypeIDDefault() As String
        Get
            Return TableUtils.ThirteenthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ThirteenthDefault field.
	''' </summary>
	Public Property ThirteenthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirteenthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthDefaultDefault() As String
        Get
            Return TableUtils.ThirteenthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ThirteenthByCIX field.
	''' </summary>
	Public Property ThirteenthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirteenthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthByCIXDefault() As String
        Get
            Return TableUtils.ThirteenthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.ThirteenthByOIX field.
	''' </summary>
	Public Property ThirteenthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirteenthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthByOIXDefault() As String
        Get
            Return TableUtils.ThirteenthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FourteenthItemName field.
	''' </summary>
	Public Property FourteenthItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourteenthItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthItemNameDefault() As String
        Get
            Return TableUtils.FourteenthItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FourteenthTypeID field.
	''' </summary>
	Public Property FourteenthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourteenthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthTypeIDDefault() As String
        Get
            Return TableUtils.FourteenthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FourteenthDefault field.
	''' </summary>
	Public Property FourteenthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourteenthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthDefaultDefault() As String
        Get
            Return TableUtils.FourteenthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FourteenthByCIX field.
	''' </summary>
	Public Property FourteenthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourteenthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthByCIXDefault() As String
        Get
            Return TableUtils.FourteenthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FourteenthByOIX field.
	''' </summary>
	Public Property FourteenthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourteenthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthByOIXDefault() As String
        Get
            Return TableUtils.FourteenthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FifteenthItemName field.
	''' </summary>
	Public Property FifteenthItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifteenthItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthItemNameDefault() As String
        Get
            Return TableUtils.FifteenthItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FifteenthTypeID field.
	''' </summary>
	Public Property FifteenthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifteenthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthTypeIDDefault() As String
        Get
            Return TableUtils.FifteenthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FifteenthDefault field.
	''' </summary>
	Public Property FifteenthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifteenthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthDefaultDefault() As String
        Get
            Return TableUtils.FifteenthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FifteenthByCIX field.
	''' </summary>
	Public Property FifteenthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifteenthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthByCIXDefault() As String
        Get
            Return TableUtils.FifteenthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Execution_.FifteenthByOIX field.
	''' </summary>
	Public Property FifteenthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifteenthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthByOIXDefault() As String
        Get
            Return TableUtils.FifteenthByOIXColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
