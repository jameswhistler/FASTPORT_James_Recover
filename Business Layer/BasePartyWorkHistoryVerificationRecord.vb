' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyWorkHistoryVerificationRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PartyWorkHistoryVerificationRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="PartyWorkHistoryVerificationTable"></see> class.
''' </remarks>
''' <seealso cref="PartyWorkHistoryVerificationTable"></seealso>
''' <seealso cref="PartyWorkHistoryVerificationRecord"></seealso>

<Serializable()> Public Class BasePartyWorkHistoryVerificationRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As PartyWorkHistoryVerificationTable = PartyWorkHistoryVerificationTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub PartyWorkHistoryVerificationRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim PartyWorkHistoryVerificationRec As PartyWorkHistoryVerificationRecord = CType(sender,PartyWorkHistoryVerificationRecord)
        Validate_Inserting()
        If Not PartyWorkHistoryVerificationRec Is Nothing AndAlso Not PartyWorkHistoryVerificationRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub PartyWorkHistoryVerificationRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim PartyWorkHistoryVerificationRec As PartyWorkHistoryVerificationRecord = CType(sender,PartyWorkHistoryVerificationRecord)
        Validate_Updating()
        If Not PartyWorkHistoryVerificationRec Is Nothing AndAlso Not PartyWorkHistoryVerificationRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub PartyWorkHistoryVerificationRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim PartyWorkHistoryVerificationRec As PartyWorkHistoryVerificationRecord = CType(sender,PartyWorkHistoryVerificationRecord)
        If Not PartyWorkHistoryVerificationRec Is Nothing AndAlso Not PartyWorkHistoryVerificationRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.VerificationID field.
	''' </summary>
	Public Function GetVerificationIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.VerificationIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.VerificationID field.
	''' </summary>
	Public Function GetVerificationIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.VerificationIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.HistoryID field.
	''' </summary>
	Public Function GetHistoryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.HistoryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.HistoryID field.
	''' </summary>
	Public Function GetHistoryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HistoryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.FlowStepID field.
	''' </summary>
	Public Function GetFlowStepIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowStepIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.FlowStepID field.
	''' </summary>
	Public Function GetFlowStepIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowStepIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.RequestedByID field.
	''' </summary>
	Public Function GetRequestedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RequestedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.RequestedByID field.
	''' </summary>
	Public Function GetRequestedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RequestedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestedByID field.
	''' </summary>
	Public Sub SetRequestedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RequestedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestedByID field.
	''' </summary>
	Public Sub SetRequestedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RequestedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestedByID field.
	''' </summary>
	Public Sub SetRequestedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RequestedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestedByID field.
	''' </summary>
	Public Sub SetRequestedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RequestedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestedByID field.
	''' </summary>
	Public Sub SetRequestedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RequestedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.RequestedAt field.
	''' </summary>
	Public Function GetRequestedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.RequestedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.RequestedAt field.
	''' </summary>
	Public Function GetRequestedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.RequestedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestedAt field.
	''' </summary>
	Public Sub SetRequestedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RequestedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestedAt field.
	''' </summary>
	Public Sub SetRequestedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RequestedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestedAt field.
	''' </summary>
	Public Sub SetRequestedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RequestedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.RequestAttempts field.
	''' </summary>
	Public Function GetRequestAttemptsValue() As ColumnValue
		Return Me.GetValue(TableUtils.RequestAttemptsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.RequestAttempts field.
	''' </summary>
	Public Function GetRequestAttemptsFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RequestAttemptsColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestAttempts field.
	''' </summary>
	Public Sub SetRequestAttemptsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RequestAttemptsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestAttempts field.
	''' </summary>
	Public Sub SetRequestAttemptsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RequestAttemptsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestAttempts field.
	''' </summary>
	Public Sub SetRequestAttemptsFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RequestAttemptsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestAttempts field.
	''' </summary>
	Public Sub SetRequestAttemptsFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RequestAttemptsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestAttempts field.
	''' </summary>
	Public Sub SetRequestAttemptsFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RequestAttemptsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.RequestIntervalID field.
	''' </summary>
	Public Function GetRequestIntervalIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RequestIntervalIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.RequestIntervalID field.
	''' </summary>
	Public Function GetRequestIntervalIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RequestIntervalIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestIntervalID field.
	''' </summary>
	Public Sub SetRequestIntervalIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RequestIntervalIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestIntervalID field.
	''' </summary>
	Public Sub SetRequestIntervalIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RequestIntervalIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestIntervalID field.
	''' </summary>
	Public Sub SetRequestIntervalIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RequestIntervalIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestIntervalID field.
	''' </summary>
	Public Sub SetRequestIntervalIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RequestIntervalIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RequestIntervalID field.
	''' </summary>
	Public Sub SetRequestIntervalIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RequestIntervalIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.DatesYesNo field.
	''' </summary>
	Public Function GetDatesYesNoValue() As ColumnValue
		Return Me.GetValue(TableUtils.DatesYesNoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.DatesYesNo field.
	''' </summary>
	Public Function GetDatesYesNoFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.DatesYesNoColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.DatesYesNo field.
	''' </summary>
	Public Sub SetDatesYesNoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DatesYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.DatesYesNo field.
	''' </summary>
	Public Sub SetDatesYesNoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DatesYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.DatesYesNo field.
	''' </summary>
	Public Sub SetDatesYesNoFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DatesYesNoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.DatesExplain field.
	''' </summary>
	Public Function GetDatesExplainValue() As ColumnValue
		Return Me.GetValue(TableUtils.DatesExplainColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.DatesExplain field.
	''' </summary>
	Public Function GetDatesExplainFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DatesExplainColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.DatesExplain field.
	''' </summary>
	Public Sub SetDatesExplainFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DatesExplainColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.DatesExplain field.
	''' </summary>
	Public Sub SetDatesExplainFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DatesExplainColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.MotorVehicleYesNo field.
	''' </summary>
	Public Function GetMotorVehicleYesNoValue() As ColumnValue
		Return Me.GetValue(TableUtils.MotorVehicleYesNoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.MotorVehicleYesNo field.
	''' </summary>
	Public Function GetMotorVehicleYesNoFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.MotorVehicleYesNoColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.MotorVehicleYesNo field.
	''' </summary>
	Public Sub SetMotorVehicleYesNoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MotorVehicleYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.MotorVehicleYesNo field.
	''' </summary>
	Public Sub SetMotorVehicleYesNoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MotorVehicleYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.MotorVehicleYesNo field.
	''' </summary>
	Public Sub SetMotorVehicleYesNoFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MotorVehicleYesNoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.FailedTestYesNo field.
	''' </summary>
	Public Function GetFailedTestYesNoValue() As ColumnValue
		Return Me.GetValue(TableUtils.FailedTestYesNoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.FailedTestYesNo field.
	''' </summary>
	Public Function GetFailedTestYesNoFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FailedTestYesNoColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.FailedTestYesNo field.
	''' </summary>
	Public Sub SetFailedTestYesNoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FailedTestYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.FailedTestYesNo field.
	''' </summary>
	Public Sub SetFailedTestYesNoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FailedTestYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.FailedTestYesNo field.
	''' </summary>
	Public Sub SetFailedTestYesNoFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FailedTestYesNoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.FailedTestExplain field.
	''' </summary>
	Public Function GetFailedTestExplainValue() As ColumnValue
		Return Me.GetValue(TableUtils.FailedTestExplainColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.FailedTestExplain field.
	''' </summary>
	Public Function GetFailedTestExplainFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FailedTestExplainColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.FailedTestExplain field.
	''' </summary>
	Public Sub SetFailedTestExplainFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FailedTestExplainColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.FailedTestExplain field.
	''' </summary>
	Public Sub SetFailedTestExplainFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FailedTestExplainColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.RefusedTestYesNo field.
	''' </summary>
	Public Function GetRefusedTestYesNoValue() As ColumnValue
		Return Me.GetValue(TableUtils.RefusedTestYesNoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.RefusedTestYesNo field.
	''' </summary>
	Public Function GetRefusedTestYesNoFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.RefusedTestYesNoColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RefusedTestYesNo field.
	''' </summary>
	Public Sub SetRefusedTestYesNoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RefusedTestYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RefusedTestYesNo field.
	''' </summary>
	Public Sub SetRefusedTestYesNoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RefusedTestYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RefusedTestYesNo field.
	''' </summary>
	Public Sub SetRefusedTestYesNoFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RefusedTestYesNoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.RefusedTestExplain field.
	''' </summary>
	Public Function GetRefusedTestExplainValue() As ColumnValue
		Return Me.GetValue(TableUtils.RefusedTestExplainColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.RefusedTestExplain field.
	''' </summary>
	Public Function GetRefusedTestExplainFieldValue() As String
		Return CType(Me.GetValue(TableUtils.RefusedTestExplainColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RefusedTestExplain field.
	''' </summary>
	Public Sub SetRefusedTestExplainFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RefusedTestExplainColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.RefusedTestExplain field.
	''' </summary>
	Public Sub SetRefusedTestExplainFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RefusedTestExplainColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.ConductYesNo field.
	''' </summary>
	Public Function GetConductYesNoValue() As ColumnValue
		Return Me.GetValue(TableUtils.ConductYesNoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.ConductYesNo field.
	''' </summary>
	Public Function GetConductYesNoFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ConductYesNoColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.ConductYesNo field.
	''' </summary>
	Public Sub SetConductYesNoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ConductYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.ConductYesNo field.
	''' </summary>
	Public Sub SetConductYesNoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ConductYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.ConductYesNo field.
	''' </summary>
	Public Sub SetConductYesNoFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ConductYesNoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.ConductExplain field.
	''' </summary>
	Public Function GetConductExplainValue() As ColumnValue
		Return Me.GetValue(TableUtils.ConductExplainColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.ConductExplain field.
	''' </summary>
	Public Function GetConductExplainFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ConductExplainColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.ConductExplain field.
	''' </summary>
	Public Sub SetConductExplainFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ConductExplainColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.ConductExplain field.
	''' </summary>
	Public Sub SetConductExplainFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ConductExplainColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.TruckingInfoYesNo field.
	''' </summary>
	Public Function GetTruckingInfoYesNoValue() As ColumnValue
		Return Me.GetValue(TableUtils.TruckingInfoYesNoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.TruckingInfoYesNo field.
	''' </summary>
	Public Function GetTruckingInfoYesNoFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TruckingInfoYesNoColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.TruckingInfoYesNo field.
	''' </summary>
	Public Sub SetTruckingInfoYesNoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TruckingInfoYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.TruckingInfoYesNo field.
	''' </summary>
	Public Sub SetTruckingInfoYesNoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TruckingInfoYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.TruckingInfoYesNo field.
	''' </summary>
	Public Sub SetTruckingInfoYesNoFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TruckingInfoYesNoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.TruckingInfoComments field.
	''' </summary>
	Public Function GetTruckingInfoCommentsValue() As ColumnValue
		Return Me.GetValue(TableUtils.TruckingInfoCommentsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.TruckingInfoComments field.
	''' </summary>
	Public Function GetTruckingInfoCommentsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TruckingInfoCommentsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.TruckingInfoComments field.
	''' </summary>
	Public Sub SetTruckingInfoCommentsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TruckingInfoCommentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.TruckingInfoComments field.
	''' </summary>
	Public Sub SetTruckingInfoCommentsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TruckingInfoCommentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.GeneralComments field.
	''' </summary>
	Public Function GetGeneralCommentsValue() As ColumnValue
		Return Me.GetValue(TableUtils.GeneralCommentsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.GeneralComments field.
	''' </summary>
	Public Function GetGeneralCommentsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.GeneralCommentsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.GeneralComments field.
	''' </summary>
	Public Sub SetGeneralCommentsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GeneralCommentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.GeneralComments field.
	''' </summary>
	Public Sub SetGeneralCommentsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GeneralCommentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.SignerID field.
	''' </summary>
	Public Function GetSignerIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SignerIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.SignerID field.
	''' </summary>
	Public Function GetSignerIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SignerIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.SignerID field.
	''' </summary>
	Public Sub SetSignerIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.SignerID field.
	''' </summary>
	Public Sub SetSignerIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.SignerID field.
	''' </summary>
	Public Sub SetSignerIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.SignerID field.
	''' </summary>
	Public Sub SetSignerIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.SignerID field.
	''' </summary>
	Public Sub SetSignerIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SignerIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.SignerFreeHand field.
	''' </summary>
	Public Function GetSignerFreeHandValue() As ColumnValue
		Return Me.GetValue(TableUtils.SignerFreeHandColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.SignerFreeHand field.
	''' </summary>
	Public Function GetSignerFreeHandFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SignerFreeHandColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.SignerFreeHand field.
	''' </summary>
	Public Sub SetSignerFreeHandFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SignerFreeHandColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.SignerFreeHand field.
	''' </summary>
	Public Sub SetSignerFreeHandFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SignerFreeHandColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.SignatureFile field.
	''' </summary>
	Public Function GetSignatureFileValue() As ColumnValue
		Return Me.GetValue(TableUtils.SignatureFileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.SignatureFile field.
	''' </summary>
	Public Function GetSignatureFileFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.SignatureFileColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.SignatureFile field.
	''' </summary>
	Public Sub SetSignatureFileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SignatureFileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.SignatureFile field.
	''' </summary>
	Public Sub SetSignatureFileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SignatureFileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.SignatureFile field.
	''' </summary>
	Public Sub SetSignatureFileFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SignatureFileColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.InstanceID field.
	''' </summary>
	Public Function GetInstanceIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.InstanceIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.InstanceID field.
	''' </summary>
	Public Function GetInstanceIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.InstanceIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyWorkHistoryVerification_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyWorkHistoryVerification_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.VerificationID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.HistoryID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.FlowStepID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.RequestedByID field.
	''' </summary>
	Public Property RequestedByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RequestedByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RequestedByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RequestedByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RequestedByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RequestedByIDDefault() As String
        Get
            Return TableUtils.RequestedByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.RequestedAt field.
	''' </summary>
	Public Property RequestedAt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.RequestedAtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RequestedAtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RequestedAtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RequestedAtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RequestedAtDefault() As String
        Get
            Return TableUtils.RequestedAtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.RequestAttempts field.
	''' </summary>
	Public Property RequestAttempts() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RequestAttemptsColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RequestAttemptsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RequestAttemptsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RequestAttemptsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RequestAttemptsDefault() As String
        Get
            Return TableUtils.RequestAttemptsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.RequestIntervalID field.
	''' </summary>
	Public Property RequestIntervalID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RequestIntervalIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RequestIntervalIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RequestIntervalIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RequestIntervalIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RequestIntervalIDDefault() As String
        Get
            Return TableUtils.RequestIntervalIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.DatesYesNo field.
	''' </summary>
	Public Property DatesYesNo() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.DatesYesNoColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DatesYesNoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DatesYesNoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DatesYesNoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DatesYesNoDefault() As String
        Get
            Return TableUtils.DatesYesNoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.DatesExplain field.
	''' </summary>
	Public Property DatesExplain() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DatesExplainColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DatesExplainColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DatesExplainSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DatesExplainColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DatesExplainDefault() As String
        Get
            Return TableUtils.DatesExplainColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.MotorVehicleYesNo field.
	''' </summary>
	Public Property MotorVehicleYesNo() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.MotorVehicleYesNoColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MotorVehicleYesNoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MotorVehicleYesNoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MotorVehicleYesNoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MotorVehicleYesNoDefault() As String
        Get
            Return TableUtils.MotorVehicleYesNoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.FailedTestYesNo field.
	''' </summary>
	Public Property FailedTestYesNo() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FailedTestYesNoColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FailedTestYesNoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FailedTestYesNoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FailedTestYesNoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FailedTestYesNoDefault() As String
        Get
            Return TableUtils.FailedTestYesNoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.FailedTestExplain field.
	''' </summary>
	Public Property FailedTestExplain() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FailedTestExplainColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FailedTestExplainColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FailedTestExplainSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FailedTestExplainColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FailedTestExplainDefault() As String
        Get
            Return TableUtils.FailedTestExplainColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.RefusedTestYesNo field.
	''' </summary>
	Public Property RefusedTestYesNo() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.RefusedTestYesNoColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RefusedTestYesNoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RefusedTestYesNoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RefusedTestYesNoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RefusedTestYesNoDefault() As String
        Get
            Return TableUtils.RefusedTestYesNoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.RefusedTestExplain field.
	''' </summary>
	Public Property RefusedTestExplain() As String
		Get 
			Return CType(Me.GetValue(TableUtils.RefusedTestExplainColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.RefusedTestExplainColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RefusedTestExplainSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RefusedTestExplainColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RefusedTestExplainDefault() As String
        Get
            Return TableUtils.RefusedTestExplainColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.ConductYesNo field.
	''' </summary>
	Public Property ConductYesNo() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ConductYesNoColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ConductYesNoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ConductYesNoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ConductYesNoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ConductYesNoDefault() As String
        Get
            Return TableUtils.ConductYesNoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.ConductExplain field.
	''' </summary>
	Public Property ConductExplain() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ConductExplainColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ConductExplainColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ConductExplainSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ConductExplainColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ConductExplainDefault() As String
        Get
            Return TableUtils.ConductExplainColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.TruckingInfoYesNo field.
	''' </summary>
	Public Property TruckingInfoYesNo() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TruckingInfoYesNoColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TruckingInfoYesNoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TruckingInfoYesNoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TruckingInfoYesNoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TruckingInfoYesNoDefault() As String
        Get
            Return TableUtils.TruckingInfoYesNoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.TruckingInfoComments field.
	''' </summary>
	Public Property TruckingInfoComments() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TruckingInfoCommentsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TruckingInfoCommentsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TruckingInfoCommentsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TruckingInfoCommentsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TruckingInfoCommentsDefault() As String
        Get
            Return TableUtils.TruckingInfoCommentsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.GeneralComments field.
	''' </summary>
	Public Property GeneralComments() As String
		Get 
			Return CType(Me.GetValue(TableUtils.GeneralCommentsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.GeneralCommentsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GeneralCommentsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GeneralCommentsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GeneralCommentsDefault() As String
        Get
            Return TableUtils.GeneralCommentsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.SignerID field.
	''' </summary>
	Public Property SignerID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SignerIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SignerIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SignerIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SignerIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SignerIDDefault() As String
        Get
            Return TableUtils.SignerIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.SignerFreeHand field.
	''' </summary>
	Public Property SignerFreeHand() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SignerFreeHandColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SignerFreeHandColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SignerFreeHandSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SignerFreeHandColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SignerFreeHandDefault() As String
        Get
            Return TableUtils.SignerFreeHandColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.SignatureFile field.
	''' </summary>
	Public Property SignatureFile() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.SignatureFileColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SignatureFileColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SignatureFileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SignatureFileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SignatureFileDefault() As String
        Get
            Return TableUtils.SignatureFileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.InstanceID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyWorkHistoryVerification_.UpdatedAt field.
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
