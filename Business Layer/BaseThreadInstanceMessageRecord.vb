' This class is "generated" and will be overwritten.
' Your customizations should be made in ThreadInstanceMessageRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="ThreadInstanceMessageRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="ThreadInstanceMessageTable"></see> class.
''' </remarks>
''' <seealso cref="ThreadInstanceMessageTable"></seealso>
''' <seealso cref="ThreadInstanceMessageRecord"></seealso>

<Serializable()> Public Class BaseThreadInstanceMessageRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As ThreadInstanceMessageTable = ThreadInstanceMessageTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub ThreadInstanceMessageRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim ThreadInstanceMessageRec As ThreadInstanceMessageRecord = CType(sender,ThreadInstanceMessageRecord)
        Validate_Inserting()
        If Not ThreadInstanceMessageRec Is Nothing AndAlso Not ThreadInstanceMessageRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub ThreadInstanceMessageRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim ThreadInstanceMessageRec As ThreadInstanceMessageRecord = CType(sender,ThreadInstanceMessageRecord)
        Validate_Updating()
        If Not ThreadInstanceMessageRec Is Nothing AndAlso Not ThreadInstanceMessageRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub ThreadInstanceMessageRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim ThreadInstanceMessageRec As ThreadInstanceMessageRecord = CType(sender,ThreadInstanceMessageRecord)
        If Not ThreadInstanceMessageRec Is Nothing AndAlso Not ThreadInstanceMessageRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.MessageID field.
	''' </summary>
	Public Function GetMessageIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.MessageIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.MessageID field.
	''' </summary>
	Public Function GetMessageIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MessageIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.InstanceID field.
	''' </summary>
	Public Function GetInstanceIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.InstanceIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.InstanceID field.
	''' </summary>
	Public Function GetInstanceIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.InstanceIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.SenderID field.
	''' </summary>
	Public Function GetSenderIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.SenderID field.
	''' </summary>
	Public Function GetSenderIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SenderIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SenderIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.MessageAction field.
	''' </summary>
	Public Function GetMessageActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.MessageActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.MessageAction field.
	''' </summary>
	Public Function GetMessageActionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MessageActionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.MessageAction field.
	''' </summary>
	Public Sub SetMessageActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MessageActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.MessageAction field.
	''' </summary>
	Public Sub SetMessageActionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MessageActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.MessageButtonText field.
	''' </summary>
	Public Function GetMessageButtonTextValue() As ColumnValue
		Return Me.GetValue(TableUtils.MessageButtonTextColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.MessageButtonText field.
	''' </summary>
	Public Function GetMessageButtonTextFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MessageButtonTextColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.MessageButtonText field.
	''' </summary>
	Public Sub SetMessageButtonTextFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MessageButtonTextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.MessageButtonText field.
	''' </summary>
	Public Sub SetMessageButtonTextFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MessageButtonTextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.MessageSubject field.
	''' </summary>
	Public Function GetMessageSubjectValue() As ColumnValue
		Return Me.GetValue(TableUtils.MessageSubjectColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.MessageSubject field.
	''' </summary>
	Public Function GetMessageSubjectFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MessageSubjectColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.MessageSubject field.
	''' </summary>
	Public Sub SetMessageSubjectFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MessageSubjectColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.MessageSubject field.
	''' </summary>
	Public Sub SetMessageSubjectFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MessageSubjectColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.MessageBody field.
	''' </summary>
	Public Function GetMessageBodyValue() As ColumnValue
		Return Me.GetValue(TableUtils.MessageBodyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.MessageBody field.
	''' </summary>
	Public Function GetMessageBodyFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MessageBodyColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.MessageBody field.
	''' </summary>
	Public Sub SetMessageBodyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MessageBodyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.MessageBody field.
	''' </summary>
	Public Sub SetMessageBodyFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MessageBodyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.ButtonID field.
	''' </summary>
	Public Function GetButtonIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ButtonIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.ButtonID field.
	''' </summary>
	Public Function GetButtonIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ButtonIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ButtonID field.
	''' </summary>
	Public Sub SetButtonIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ButtonIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ButtonID field.
	''' </summary>
	Public Sub SetButtonIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ButtonIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ButtonID field.
	''' </summary>
	Public Sub SetButtonIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ButtonID field.
	''' </summary>
	Public Sub SetButtonIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ButtonID field.
	''' </summary>
	Public Sub SetButtonIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Queued field.
	''' </summary>
	Public Function GetQueuedValue() As ColumnValue
		Return Me.GetValue(TableUtils.QueuedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Queued field.
	''' </summary>
	Public Function GetQueuedFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.QueuedColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Queued field.
	''' </summary>
	Public Sub SetQueuedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.QueuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Queued field.
	''' </summary>
	Public Sub SetQueuedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.QueuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Queued field.
	''' </summary>
	Public Sub SetQueuedFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.QueuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Queued field.
	''' </summary>
	Public Sub SetQueuedFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.QueuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Queued field.
	''' </summary>
	Public Sub SetQueuedFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.QueuedColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.ActionCollectionID field.
	''' </summary>
	Public Function GetActionCollectionIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ActionCollectionIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.ActionCollectionID field.
	''' </summary>
	Public Function GetActionCollectionIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ActionCollectionIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ActionCollectionID field.
	''' </summary>
	Public Sub SetActionCollectionIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ActionCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ActionCollectionID field.
	''' </summary>
	Public Sub SetActionCollectionIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ActionCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ActionCollectionID field.
	''' </summary>
	Public Sub SetActionCollectionIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ActionCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ActionCollectionID field.
	''' </summary>
	Public Sub SetActionCollectionIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ActionCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ActionCollectionID field.
	''' </summary>
	Public Sub SetActionCollectionIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ActionCollectionIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.LeftPartURL field.
	''' </summary>
	Public Function GetLeftPartURLValue() As ColumnValue
		Return Me.GetValue(TableUtils.LeftPartURLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.LeftPartURL field.
	''' </summary>
	Public Function GetLeftPartURLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.LeftPartURLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.LeftPartURL field.
	''' </summary>
	Public Sub SetLeftPartURLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LeftPartURLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.LeftPartURL field.
	''' </summary>
	Public Sub SetLeftPartURLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LeftPartURLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.ActionURL field.
	''' </summary>
	Public Function GetActionURLValue() As ColumnValue
		Return Me.GetValue(TableUtils.ActionURLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.ActionURL field.
	''' </summary>
	Public Function GetActionURLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ActionURLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ActionURL field.
	''' </summary>
	Public Sub SetActionURLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ActionURLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ActionURL field.
	''' </summary>
	Public Sub SetActionURLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ActionURLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.ExcludeParams field.
	''' </summary>
	Public Function GetExcludeParamsValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExcludeParamsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.ExcludeParams field.
	''' </summary>
	Public Function GetExcludeParamsFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ExcludeParamsColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ExcludeParams field.
	''' </summary>
	Public Sub SetExcludeParamsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExcludeParamsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ExcludeParams field.
	''' </summary>
	Public Sub SetExcludeParamsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExcludeParamsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.ExcludeParams field.
	''' </summary>
	Public Sub SetExcludeParamsFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExcludeParamsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.NoRadWindow field.
	''' </summary>
	Public Function GetNoRadWindowValue() As ColumnValue
		Return Me.GetValue(TableUtils.NoRadWindowColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.NoRadWindow field.
	''' </summary>
	Public Function GetNoRadWindowFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.NoRadWindowColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.NoRadWindow field.
	''' </summary>
	Public Sub SetNoRadWindowFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NoRadWindowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.NoRadWindow field.
	''' </summary>
	Public Sub SetNoRadWindowFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.NoRadWindowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.NoRadWindow field.
	''' </summary>
	Public Sub SetNoRadWindowFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NoRadWindowColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.GoAction field.
	''' </summary>
	Public Function GetGoActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.GoActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.GoAction field.
	''' </summary>
	Public Function GetGoActionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.GoActionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.GoAction field.
	''' </summary>
	Public Sub SetGoActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GoActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.GoAction field.
	''' </summary>
	Public Sub SetGoActionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GoActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Action field.
	''' </summary>
	Public Function GetActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.ActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Action field.
	''' </summary>
	Public Function GetActionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ActionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Action field.
	''' </summary>
	Public Sub SetActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Action field.
	''' </summary>
	Public Sub SetActionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.CloseAction field.
	''' </summary>
	Public Function GetCloseActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.CloseActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.CloseAction field.
	''' </summary>
	Public Function GetCloseActionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CloseActionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CloseAction field.
	''' </summary>
	Public Sub SetCloseActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CloseActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CloseAction field.
	''' </summary>
	Public Sub SetCloseActionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CloseActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.SliderValue field.
	''' </summary>
	Public Function GetSliderValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.SliderValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.SliderValue field.
	''' </summary>
	Public Function GetSliderValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SliderValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.SliderValue field.
	''' </summary>
	Public Sub SetSliderValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SliderValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.SliderValue field.
	''' </summary>
	Public Sub SetSliderValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SliderValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.RowOwnerCIX field.
	''' </summary>
	Public Function GetRowOwnerCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.RowOwnerCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.RowOwnerCIX field.
	''' </summary>
	Public Function GetRowOwnerCIXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RowOwnerCIXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.RowOwnerCIX field.
	''' </summary>
	Public Sub SetRowOwnerCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RowOwnerCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.RowOwnerCIX field.
	''' </summary>
	Public Sub SetRowOwnerCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RowOwnerCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.RowOwnerCIX field.
	''' </summary>
	Public Sub SetRowOwnerCIXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RowOwnerCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.RowOwnerCIX field.
	''' </summary>
	Public Sub SetRowOwnerCIXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RowOwnerCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.RowOwnerCIX field.
	''' </summary>
	Public Sub SetRowOwnerCIXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RowOwnerCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.RowOIX field.
	''' </summary>
	Public Function GetRowOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.RowOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.RowOIX field.
	''' </summary>
	Public Function GetRowOIXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RowOIXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.RowOIX field.
	''' </summary>
	Public Sub SetRowOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RowOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.RowOIX field.
	''' </summary>
	Public Sub SetRowOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RowOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.RowOIX field.
	''' </summary>
	Public Sub SetRowOIXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RowOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.RowOIX field.
	''' </summary>
	Public Sub SetRowOIXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RowOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.RowOIX field.
	''' </summary>
	Public Sub SetRowOIXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RowOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.FlowStep field.
	''' </summary>
	Public Function GetFlowStepValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowStepColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.FlowStep field.
	''' </summary>
	Public Function GetFlowStepFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowStepColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.FlowStep field.
	''' </summary>
	Public Sub SetFlowStepFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowStepColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.FlowStep field.
	''' </summary>
	Public Sub SetFlowStepFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowStepColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.FlowStep field.
	''' </summary>
	Public Sub SetFlowStepFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.FlowStep field.
	''' </summary>
	Public Sub SetFlowStepFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.FlowStep field.
	''' </summary>
	Public Sub SetFlowStepFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Party field.
	''' </summary>
	Public Function GetPartyValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Party field.
	''' </summary>
	Public Function GetPartyFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Party field.
	''' </summary>
	Public Sub SetPartyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Party field.
	''' </summary>
	Public Sub SetPartyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Party field.
	''' </summary>
	Public Sub SetPartyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Party field.
	''' </summary>
	Public Sub SetPartyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Party field.
	''' </summary>
	Public Sub SetPartyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.UserSystem field.
	''' </summary>
	Public Function GetUserSystemValue() As ColumnValue
		Return Me.GetValue(TableUtils.UserSystemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.UserSystem field.
	''' </summary>
	Public Function GetUserSystemFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UserSystemColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.UserSystem field.
	''' </summary>
	Public Sub SetUserSystemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UserSystemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.UserSystem field.
	''' </summary>
	Public Sub SetUserSystemFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UserSystemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.UserSystem field.
	''' </summary>
	Public Sub SetUserSystemFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserSystemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.UserSystem field.
	''' </summary>
	Public Sub SetUserSystemFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserSystemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.UserSystem field.
	''' </summary>
	Public Sub SetUserSystemFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserSystemColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Message field.
	''' </summary>
	Public Function GetMessageValue() As ColumnValue
		Return Me.GetValue(TableUtils.MessageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Message field.
	''' </summary>
	Public Function GetMessageFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MessageColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Message field.
	''' </summary>
	Public Sub SetMessageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Message field.
	''' </summary>
	Public Sub SetMessageFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Message field.
	''' </summary>
	Public Sub SetMessageFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Message field.
	''' </summary>
	Public Sub SetMessageFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Message field.
	''' </summary>
	Public Sub SetMessageFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MessageColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Instance field.
	''' </summary>
	Public Function GetInstance0Value() As ColumnValue
		Return Me.GetValue(TableUtils.Instance0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Instance field.
	''' </summary>
	Public Function GetInstance0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Instance0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Instance field.
	''' </summary>
	Public Sub SetInstance0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Instance0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Instance field.
	''' </summary>
	Public Sub SetInstance0FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Instance0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Instance field.
	''' </summary>
	Public Sub SetInstance0FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Instance0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Instance field.
	''' </summary>
	Public Sub SetInstance0FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Instance0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Instance field.
	''' </summary>
	Public Sub SetInstance0FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Instance0Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.FleetCircle field.
	''' </summary>
	Public Function GetFleetCircleValue() As ColumnValue
		Return Me.GetValue(TableUtils.FleetCircleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.FleetCircle field.
	''' </summary>
	Public Function GetFleetCircleFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FleetCircleColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.FleetCircle field.
	''' </summary>
	Public Sub SetFleetCircleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FleetCircleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.FleetCircle field.
	''' </summary>
	Public Sub SetFleetCircleFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FleetCircleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.FleetCircle field.
	''' </summary>
	Public Sub SetFleetCircleFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FleetCircleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.FleetCircle field.
	''' </summary>
	Public Sub SetFleetCircleFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FleetCircleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.FleetCircle field.
	''' </summary>
	Public Sub SetFleetCircleFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FleetCircleColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Execution field.
	''' </summary>
	Public Function GetExecutionValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExecutionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Execution field.
	''' </summary>
	Public Function GetExecutionFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ExecutionColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Execution field.
	''' </summary>
	Public Sub SetExecutionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExecutionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Execution field.
	''' </summary>
	Public Sub SetExecutionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExecutionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Execution field.
	''' </summary>
	Public Sub SetExecutionFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Execution field.
	''' </summary>
	Public Sub SetExecutionFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Execution field.
	''' </summary>
	Public Sub SetExecutionFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Ad field.
	''' </summary>
	Public Function GetAdValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Ad field.
	''' </summary>
	Public Function GetAdFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Ad field.
	''' </summary>
	Public Sub SetAdFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Ad field.
	''' </summary>
	Public Sub SetAdFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Ad field.
	''' </summary>
	Public Sub SetAdFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Ad field.
	''' </summary>
	Public Sub SetAdFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Ad field.
	''' </summary>
	Public Sub SetAdFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.AdActivity field.
	''' </summary>
	Public Function GetAdActivityValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdActivityColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.AdActivity field.
	''' </summary>
	Public Function GetAdActivityFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdActivityColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.AdActivity field.
	''' </summary>
	Public Sub SetAdActivityFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdActivityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.AdActivity field.
	''' </summary>
	Public Sub SetAdActivityFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AdActivityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.AdActivity field.
	''' </summary>
	Public Sub SetAdActivityFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdActivityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.AdActivity field.
	''' </summary>
	Public Sub SetAdActivityFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdActivityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.AdActivity field.
	''' </summary>
	Public Sub SetAdActivityFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdActivityColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.CheckIn field.
	''' </summary>
	Public Function GetCheckInValue() As ColumnValue
		Return Me.GetValue(TableUtils.CheckInColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.CheckIn field.
	''' </summary>
	Public Function GetCheckInFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CheckInColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CheckIn field.
	''' </summary>
	Public Sub SetCheckInFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CheckInColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CheckIn field.
	''' </summary>
	Public Sub SetCheckInFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CheckInColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CheckIn field.
	''' </summary>
	Public Sub SetCheckInFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CheckInColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CheckIn field.
	''' </summary>
	Public Sub SetCheckInFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CheckInColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.CheckIn field.
	''' </summary>
	Public Sub SetCheckInFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CheckInColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.DocFiled field.
	''' </summary>
	Public Function GetDocFiledValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocFiledColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.DocFiled field.
	''' </summary>
	Public Function GetDocFiledFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DocFiledColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.DocFiled field.
	''' </summary>
	Public Sub SetDocFiledFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocFiledColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.DocFiled field.
	''' </summary>
	Public Sub SetDocFiledFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocFiledColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.DocFiled field.
	''' </summary>
	Public Sub SetDocFiledFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocFiledColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.DocFiled field.
	''' </summary>
	Public Sub SetDocFiledFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocFiledColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.DocFiled field.
	''' </summary>
	Public Sub SetDocFiledFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocFiledColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Ord field.
	''' </summary>
	Public Function GetOrdValue() As ColumnValue
		Return Me.GetValue(TableUtils.OrdColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Ord field.
	''' </summary>
	Public Function GetOrdFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.OrdColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Ord field.
	''' </summary>
	Public Sub SetOrdFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OrdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Ord field.
	''' </summary>
	Public Sub SetOrdFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OrdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Ord field.
	''' </summary>
	Public Sub SetOrdFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OrdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Ord field.
	''' </summary>
	Public Sub SetOrdFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OrdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Ord field.
	''' </summary>
	Public Sub SetOrdFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OrdColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Payment field.
	''' </summary>
	Public Function GetPaymentValue() As ColumnValue
		Return Me.GetValue(TableUtils.PaymentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Payment field.
	''' </summary>
	Public Function GetPaymentFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PaymentColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Payment field.
	''' </summary>
	Public Sub SetPaymentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PaymentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Payment field.
	''' </summary>
	Public Sub SetPaymentFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PaymentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Payment field.
	''' </summary>
	Public Sub SetPaymentFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PaymentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Payment field.
	''' </summary>
	Public Sub SetPaymentFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PaymentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Payment field.
	''' </summary>
	Public Sub SetPaymentFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PaymentColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Carrier field.
	''' </summary>
	Public Function GetCarrierValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Carrier field.
	''' </summary>
	Public Function GetCarrierFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CarrierColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Carrier field.
	''' </summary>
	Public Sub SetCarrierFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CarrierColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Carrier field.
	''' </summary>
	Public Sub SetCarrierFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CarrierColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Carrier field.
	''' </summary>
	Public Sub SetCarrierFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Carrier field.
	''' </summary>
	Public Sub SetCarrierFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Carrier field.
	''' </summary>
	Public Sub SetCarrierFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Driver field.
	''' </summary>
	Public Function GetDriverValue() As ColumnValue
		Return Me.GetValue(TableUtils.DriverColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Driver field.
	''' </summary>
	Public Function GetDriverFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DriverColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Driver field.
	''' </summary>
	Public Sub SetDriverFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DriverColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Driver field.
	''' </summary>
	Public Sub SetDriverFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DriverColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Driver field.
	''' </summary>
	Public Sub SetDriverFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DriverColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Driver field.
	''' </summary>
	Public Sub SetDriverFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DriverColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Driver field.
	''' </summary>
	Public Sub SetDriverFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DriverColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Addr field.
	''' </summary>
	Public Function GetAddrValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Addr field.
	''' </summary>
	Public Function GetAddrFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AddrColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Addr field.
	''' </summary>
	Public Sub SetAddrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Addr field.
	''' </summary>
	Public Sub SetAddrFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Addr field.
	''' </summary>
	Public Sub SetAddrFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Addr field.
	''' </summary>
	Public Sub SetAddrFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Addr field.
	''' </summary>
	Public Sub SetAddrFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Role field.
	''' </summary>
	Public Function GetRoleValue() As ColumnValue
		Return Me.GetValue(TableUtils.RoleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Role field.
	''' </summary>
	Public Function GetRoleFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RoleColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Role field.
	''' </summary>
	Public Sub SetRoleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RoleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Role field.
	''' </summary>
	Public Sub SetRoleFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RoleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Role field.
	''' </summary>
	Public Sub SetRoleFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Role field.
	''' </summary>
	Public Sub SetRoleFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Role field.
	''' </summary>
	Public Sub SetRoleFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.History field.
	''' </summary>
	Public Function GetHistoryValue() As ColumnValue
		Return Me.GetValue(TableUtils.HistoryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.History field.
	''' </summary>
	Public Function GetHistoryFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HistoryColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.History field.
	''' </summary>
	Public Sub SetHistoryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HistoryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.History field.
	''' </summary>
	Public Sub SetHistoryFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HistoryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.History field.
	''' </summary>
	Public Sub SetHistoryFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.History field.
	''' </summary>
	Public Sub SetHistoryFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.History field.
	''' </summary>
	Public Sub SetHistoryFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Parent field.
	''' </summary>
	Public Function GetParent0Value() As ColumnValue
		Return Me.GetValue(TableUtils.Parent0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Parent field.
	''' </summary>
	Public Function GetParent0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Parent0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Parent field.
	''' </summary>
	Public Sub SetParent0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Parent0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Parent field.
	''' </summary>
	Public Sub SetParent0FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Parent0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Parent field.
	''' </summary>
	Public Sub SetParent0FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Parent0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Parent field.
	''' </summary>
	Public Sub SetParent0FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Parent0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Parent field.
	''' </summary>
	Public Sub SetParent0FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Parent0Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Email field.
	''' </summary>
	Public Function GetEmailValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Email field.
	''' </summary>
	Public Function GetEmailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Password field.
	''' </summary>
	Public Function GetPasswordValue() As ColumnValue
		Return Me.GetValue(TableUtils.PasswordColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Password field.
	''' </summary>
	Public Function GetPasswordFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PasswordColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Password field.
	''' </summary>
	Public Sub SetPasswordFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Password field.
	''' </summary>
	Public Sub SetPasswordFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Button field.
	''' </summary>
	Public Function GetButtonValue() As ColumnValue
		Return Me.GetValue(TableUtils.ButtonColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Button field.
	''' </summary>
	Public Function GetButtonFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ButtonColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Button field.
	''' </summary>
	Public Sub SetButtonFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Button field.
	''' </summary>
	Public Sub SetButtonFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Button field.
	''' </summary>
	Public Sub SetButtonFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Button field.
	''' </summary>
	Public Sub SetButtonFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Button field.
	''' </summary>
	Public Sub SetButtonFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Verification field.
	''' </summary>
	Public Function GetVerificationValue() As ColumnValue
		Return Me.GetValue(TableUtils.VerificationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Verification field.
	''' </summary>
	Public Function GetVerificationFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.VerificationColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Verification field.
	''' </summary>
	Public Sub SetVerificationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VerificationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Verification field.
	''' </summary>
	Public Sub SetVerificationFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.VerificationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Verification field.
	''' </summary>
	Public Sub SetVerificationFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VerificationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Verification field.
	''' </summary>
	Public Sub SetVerificationFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VerificationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Verification field.
	''' </summary>
	Public Sub SetVerificationFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VerificationColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Doc field.
	''' </summary>
	Public Function GetDocValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceMessage_.Doc field.
	''' </summary>
	Public Function GetDocFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DocColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Doc field.
	''' </summary>
	Public Sub SetDocFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Doc field.
	''' </summary>
	Public Sub SetDocFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Doc field.
	''' </summary>
	Public Sub SetDocFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Doc field.
	''' </summary>
	Public Sub SetDocFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceMessage_.Doc field.
	''' </summary>
	Public Sub SetDocFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.MessageID field.
	''' </summary>
	Public Property MessageID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MessageIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MessageIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MessageIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MessageIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MessageIDDefault() As String
        Get
            Return TableUtils.MessageIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.InstanceID field.
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
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.SenderID field.
	''' </summary>
	Public Property SenderID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SenderIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SenderIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SenderIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SenderIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SenderIDDefault() As String
        Get
            Return TableUtils.SenderIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.MessageAction field.
	''' </summary>
	Public Property MessageAction() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MessageActionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MessageActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MessageActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MessageActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MessageActionDefault() As String
        Get
            Return TableUtils.MessageActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.MessageButtonText field.
	''' </summary>
	Public Property MessageButtonText() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MessageButtonTextColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MessageButtonTextColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MessageButtonTextSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MessageButtonTextColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MessageButtonTextDefault() As String
        Get
            Return TableUtils.MessageButtonTextColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.MessageSubject field.
	''' </summary>
	Public Property MessageSubject() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MessageSubjectColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MessageSubjectColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MessageSubjectSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MessageSubjectColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MessageSubjectDefault() As String
        Get
            Return TableUtils.MessageSubjectColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.MessageBody field.
	''' </summary>
	Public Property MessageBody() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MessageBodyColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MessageBodyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MessageBodySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MessageBodyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MessageBodyDefault() As String
        Get
            Return TableUtils.MessageBodyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.ButtonID field.
	''' </summary>
	Public Property ButtonID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ButtonIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ButtonIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ButtonIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ButtonIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ButtonIDDefault() As String
        Get
            Return TableUtils.ButtonIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Queued field.
	''' </summary>
	Public Property Queued() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.QueuedColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.QueuedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property QueuedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.QueuedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property QueuedDefault() As String
        Get
            Return TableUtils.QueuedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.UpdatedAt field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.ActionCollectionID field.
	''' </summary>
	Public Property ActionCollectionID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ActionCollectionIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ActionCollectionIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ActionCollectionIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ActionCollectionIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ActionCollectionIDDefault() As String
        Get
            Return TableUtils.ActionCollectionIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.LeftPartURL field.
	''' </summary>
	Public Property LeftPartURL() As String
		Get 
			Return CType(Me.GetValue(TableUtils.LeftPartURLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.LeftPartURLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LeftPartURLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LeftPartURLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LeftPartURLDefault() As String
        Get
            Return TableUtils.LeftPartURLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.ActionURL field.
	''' </summary>
	Public Property ActionURL() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ActionURLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ActionURLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ActionURLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ActionURLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ActionURLDefault() As String
        Get
            Return TableUtils.ActionURLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.ExcludeParams field.
	''' </summary>
	Public Property ExcludeParams() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ExcludeParamsColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExcludeParamsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExcludeParamsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExcludeParamsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExcludeParamsDefault() As String
        Get
            Return TableUtils.ExcludeParamsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.NoRadWindow field.
	''' </summary>
	Public Property NoRadWindow() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.NoRadWindowColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.NoRadWindowColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NoRadWindowSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NoRadWindowColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NoRadWindowDefault() As String
        Get
            Return TableUtils.NoRadWindowColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.GoAction field.
	''' </summary>
	Public Property GoAction() As String
		Get 
			Return CType(Me.GetValue(TableUtils.GoActionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.GoActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GoActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GoActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GoActionDefault() As String
        Get
            Return TableUtils.GoActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Action field.
	''' </summary>
	Public Property Action() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ActionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ActionDefault() As String
        Get
            Return TableUtils.ActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.CloseAction field.
	''' </summary>
	Public Property CloseAction() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CloseActionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CloseActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CloseActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CloseActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CloseActionDefault() As String
        Get
            Return TableUtils.CloseActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.SliderValue field.
	''' </summary>
	Public Property SliderValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SliderValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SliderValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SliderValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SliderValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SliderValueDefault() As String
        Get
            Return TableUtils.SliderValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.RowOwnerCIX field.
	''' </summary>
	Public Property RowOwnerCIX() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RowOwnerCIXColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RowOwnerCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RowOwnerCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RowOwnerCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RowOwnerCIXDefault() As String
        Get
            Return TableUtils.RowOwnerCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.RowOIX field.
	''' </summary>
	Public Property RowOIX() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RowOIXColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RowOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RowOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RowOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RowOIXDefault() As String
        Get
            Return TableUtils.RowOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.FlowStep field.
	''' </summary>
	Public Property FlowStep() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FlowStepColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FlowStepColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FlowStepSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FlowStepColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FlowStepDefault() As String
        Get
            Return TableUtils.FlowStepColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Party field.
	''' </summary>
	Public Property Party() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PartyColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PartyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PartySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PartyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PartyDefault() As String
        Get
            Return TableUtils.PartyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.UserSystem field.
	''' </summary>
	Public Property UserSystem() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.UserSystemColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UserSystemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UserSystemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UserSystemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UserSystemDefault() As String
        Get
            Return TableUtils.UserSystemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Message field.
	''' </summary>
	Public Property Message() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MessageColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MessageColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MessageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MessageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MessageDefault() As String
        Get
            Return TableUtils.MessageColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Instance field.
	''' </summary>
	Public Property Instance0() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.Instance0Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Instance0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Instance0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Instance0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Instance0Default() As String
        Get
            Return TableUtils.Instance0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.FleetCircle field.
	''' </summary>
	Public Property FleetCircle() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FleetCircleColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FleetCircleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FleetCircleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FleetCircleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FleetCircleDefault() As String
        Get
            Return TableUtils.FleetCircleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Execution field.
	''' </summary>
	Public Property Execution() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ExecutionColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExecutionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExecutionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExecutionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExecutionDefault() As String
        Get
            Return TableUtils.ExecutionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Ad field.
	''' </summary>
	Public Property Ad() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AdColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AdColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdDefault() As String
        Get
            Return TableUtils.AdColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.AdActivity field.
	''' </summary>
	Public Property AdActivity() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AdActivityColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AdActivityColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdActivitySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdActivityColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdActivityDefault() As String
        Get
            Return TableUtils.AdActivityColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.CheckIn field.
	''' </summary>
	Public Property CheckIn() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CheckInColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CheckInColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CheckInSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CheckInColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CheckInDefault() As String
        Get
            Return TableUtils.CheckInColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.DocFiled field.
	''' </summary>
	Public Property DocFiled() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DocFiledColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocFiledColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocFiledSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocFiledColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocFiledDefault() As String
        Get
            Return TableUtils.DocFiledColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Ord field.
	''' </summary>
	Public Property Ord() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.OrdColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OrdColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OrdSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OrdColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OrdDefault() As String
        Get
            Return TableUtils.OrdColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Payment field.
	''' </summary>
	Public Property Payment() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PaymentColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PaymentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PaymentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PaymentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PaymentDefault() As String
        Get
            Return TableUtils.PaymentColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Carrier field.
	''' </summary>
	Public Property Carrier() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CarrierColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CarrierColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CarrierSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CarrierColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CarrierDefault() As String
        Get
            Return TableUtils.CarrierColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Driver field.
	''' </summary>
	Public Property Driver() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DriverColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DriverColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DriverSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DriverColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DriverDefault() As String
        Get
            Return TableUtils.DriverColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Addr field.
	''' </summary>
	Public Property Addr() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AddrColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AddrColumn)
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
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Role field.
	''' </summary>
	Public Property Role() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RoleColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RoleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RoleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RoleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RoleDefault() As String
        Get
            Return TableUtils.RoleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.History field.
	''' </summary>
	Public Property History() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HistoryColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HistoryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HistorySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HistoryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HistoryDefault() As String
        Get
            Return TableUtils.HistoryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Parent field.
	''' </summary>
	Public Property Parent0() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.Parent0Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Parent0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Parent0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Parent0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Parent0Default() As String
        Get
            Return TableUtils.Parent0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Email field.
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
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Password field.
	''' </summary>
	Public Property Password() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PasswordColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PasswordColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PasswordSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PasswordColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PasswordDefault() As String
        Get
            Return TableUtils.PasswordColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Button field.
	''' </summary>
	Public Property Button() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ButtonColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ButtonColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ButtonSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ButtonColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ButtonDefault() As String
        Get
            Return TableUtils.ButtonColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Verification field.
	''' </summary>
	Public Property Verification() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.VerificationColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.VerificationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property VerificationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.VerificationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property VerificationDefault() As String
        Get
            Return TableUtils.VerificationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceMessage_.Doc field.
	''' </summary>
	Public Property Doc() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DocColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocDefault() As String
        Get
            Return TableUtils.DocColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
