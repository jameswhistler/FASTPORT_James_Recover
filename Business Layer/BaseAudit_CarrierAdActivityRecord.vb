' This class is "generated" and will be overwritten.
' Your customizations should be made in Audit_CarrierAdActivityRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="Audit_CarrierAdActivityRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Audit_CarrierAdActivityTable"></see> class.
''' </remarks>
''' <seealso cref="Audit_CarrierAdActivityTable"></seealso>
''' <seealso cref="Audit_CarrierAdActivityRecord"></seealso>

<Serializable()> Public Class BaseAudit_CarrierAdActivityRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Audit_CarrierAdActivityTable = Audit_CarrierAdActivityTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Audit_CarrierAdActivityRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Audit_CarrierAdActivityRec As Audit_CarrierAdActivityRecord = CType(sender,Audit_CarrierAdActivityRecord)
        Validate_Inserting()
        If Not Audit_CarrierAdActivityRec Is Nothing AndAlso Not Audit_CarrierAdActivityRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub Audit_CarrierAdActivityRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim Audit_CarrierAdActivityRec As Audit_CarrierAdActivityRecord = CType(sender,Audit_CarrierAdActivityRecord)
        Validate_Updating()
        If Not Audit_CarrierAdActivityRec Is Nothing AndAlso Not Audit_CarrierAdActivityRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Audit_CarrierAdActivityRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Audit_CarrierAdActivityRec As Audit_CarrierAdActivityRecord = CType(sender,Audit_CarrierAdActivityRecord)
        If Not Audit_CarrierAdActivityRec Is Nothing AndAlso Not Audit_CarrierAdActivityRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.AdActivityLogID field.
	''' </summary>
	Public Function GetAdActivityLogIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdActivityLogIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.AdActivityLogID field.
	''' </summary>
	Public Function GetAdActivityLogIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdActivityLogIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.PreAdActivityLogID field.
	''' </summary>
	Public Function GetPreAdActivityLogIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PreAdActivityLogIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.PreAdActivityLogID field.
	''' </summary>
	Public Function GetPreAdActivityLogIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PreAdActivityLogIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.PreAdActivityLogID field.
	''' </summary>
	Public Sub SetPreAdActivityLogIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PreAdActivityLogIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.PreAdActivityLogID field.
	''' </summary>
	Public Sub SetPreAdActivityLogIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PreAdActivityLogIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.PreAdActivityLogID field.
	''' </summary>
	Public Sub SetPreAdActivityLogIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PreAdActivityLogIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.PreAdActivityLogID field.
	''' </summary>
	Public Sub SetPreAdActivityLogIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PreAdActivityLogIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.PreAdActivityLogID field.
	''' </summary>
	Public Sub SetPreAdActivityLogIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PreAdActivityLogIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.AdActivityID field.
	''' </summary>
	Public Function GetAdActivityIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdActivityIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.AdActivityID field.
	''' </summary>
	Public Function GetAdActivityIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdActivityIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.AdActivityID field.
	''' </summary>
	Public Sub SetAdActivityIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdActivityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.AdActivityID field.
	''' </summary>
	Public Sub SetAdActivityIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AdActivityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.AdActivityID field.
	''' </summary>
	Public Sub SetAdActivityIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdActivityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.AdActivityID field.
	''' </summary>
	Public Sub SetAdActivityIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdActivityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.AdActivityID field.
	''' </summary>
	Public Sub SetAdActivityIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdActivityIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.AdID field.
	''' </summary>
	Public Function GetAdIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.AdID field.
	''' </summary>
	Public Function GetAdIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.CarrierID field.
	''' </summary>
	Public Function GetCarrierIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.CarrierID field.
	''' </summary>
	Public Function GetCarrierIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CarrierIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.FavoriteAd field.
	''' </summary>
	Public Function GetFavoriteAdValue() As ColumnValue
		Return Me.GetValue(TableUtils.FavoriteAdColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.FavoriteAd field.
	''' </summary>
	Public Function GetFavoriteAdFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FavoriteAdColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.FavoriteAd field.
	''' </summary>
	Public Sub SetFavoriteAdFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FavoriteAdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.FavoriteAd field.
	''' </summary>
	Public Sub SetFavoriteAdFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FavoriteAdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.FavoriteAd field.
	''' </summary>
	Public Sub SetFavoriteAdFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FavoriteAdColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.FileAd field.
	''' </summary>
	Public Function GetFileAdValue() As ColumnValue
		Return Me.GetValue(TableUtils.FileAdColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.FileAd field.
	''' </summary>
	Public Function GetFileAdFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FileAdColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.FileAd field.
	''' </summary>
	Public Sub SetFileAdFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FileAdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.FileAd field.
	''' </summary>
	Public Sub SetFileAdFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FileAdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.FileAd field.
	''' </summary>
	Public Sub SetFileAdFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FileAdColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.Viewed field.
	''' </summary>
	Public Function GetViewedValue() As ColumnValue
		Return Me.GetValue(TableUtils.ViewedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.Viewed field.
	''' </summary>
	Public Function GetViewedFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ViewedColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.Viewed field.
	''' </summary>
	Public Sub SetViewedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ViewedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.Viewed field.
	''' </summary>
	Public Sub SetViewedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ViewedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.Viewed field.
	''' </summary>
	Public Sub SetViewedFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ViewedColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.FlowStepID field.
	''' </summary>
	Public Function GetFlowStepIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowStepIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.FlowStepID field.
	''' </summary>
	Public Function GetFlowStepIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowStepIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.InstanceID field.
	''' </summary>
	Public Function GetInstanceIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.InstanceIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.InstanceID field.
	''' </summary>
	Public Function GetInstanceIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.InstanceIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.ExecutionID field.
	''' </summary>
	Public Function GetExecutionIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExecutionIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.ExecutionID field.
	''' </summary>
	Public Function GetExecutionIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ExecutionIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.LinkID field.
	''' </summary>
	Public Function GetLinkIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.LinkIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.LinkID field.
	''' </summary>
	Public Function GetLinkIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.LinkIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.LinkID field.
	''' </summary>
	Public Sub SetLinkIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LinkIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.LinkID field.
	''' </summary>
	Public Sub SetLinkIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LinkIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.LinkID field.
	''' </summary>
	Public Sub SetLinkIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LinkIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.LinkID field.
	''' </summary>
	Public Sub SetLinkIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LinkIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.LinkID field.
	''' </summary>
	Public Sub SetLinkIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LinkIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.LoggedAt field.
	''' </summary>
	Public Function GetLoggedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.LoggedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Audit_CarrierAdActivity_.LoggedAt field.
	''' </summary>
	Public Function GetLoggedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.LoggedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.LoggedAt field.
	''' </summary>
	Public Sub SetLoggedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LoggedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.LoggedAt field.
	''' </summary>
	Public Sub SetLoggedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LoggedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Audit_CarrierAdActivity_.LoggedAt field.
	''' </summary>
	Public Sub SetLoggedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LoggedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.AdActivityLogID field.
	''' </summary>
	Public Property AdActivityLogID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AdActivityLogIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AdActivityLogIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdActivityLogIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdActivityLogIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdActivityLogIDDefault() As String
        Get
            Return TableUtils.AdActivityLogIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.PreAdActivityLogID field.
	''' </summary>
	Public Property PreAdActivityLogID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PreAdActivityLogIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PreAdActivityLogIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PreAdActivityLogIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PreAdActivityLogIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PreAdActivityLogIDDefault() As String
        Get
            Return TableUtils.PreAdActivityLogIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.AdActivityID field.
	''' </summary>
	Public Property AdActivityID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AdActivityIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AdActivityIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdActivityIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdActivityIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdActivityIDDefault() As String
        Get
            Return TableUtils.AdActivityIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.AdID field.
	''' </summary>
	Public Property AdID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AdIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AdIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdIDDefault() As String
        Get
            Return TableUtils.AdIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.CarrierID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.FavoriteAd field.
	''' </summary>
	Public Property FavoriteAd() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FavoriteAdColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FavoriteAdColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FavoriteAdSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FavoriteAdColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FavoriteAdDefault() As String
        Get
            Return TableUtils.FavoriteAdColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.FileAd field.
	''' </summary>
	Public Property FileAd() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FileAdColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FileAdColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FileAdSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FileAdColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FileAdDefault() As String
        Get
            Return TableUtils.FileAdColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.Viewed field.
	''' </summary>
	Public Property Viewed() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ViewedColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ViewedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ViewedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ViewedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ViewedDefault() As String
        Get
            Return TableUtils.ViewedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.FlowStepID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.InstanceID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.ExecutionID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.LinkID field.
	''' </summary>
	Public Property LinkID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.LinkIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LinkIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LinkIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LinkIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LinkIDDefault() As String
        Get
            Return TableUtils.LinkIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.UpdatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Audit_CarrierAdActivity_.LoggedAt field.
	''' </summary>
	Public Property LoggedAt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.LoggedAtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LoggedAtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LoggedAtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LoggedAtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LoggedAtDefault() As String
        Get
            Return TableUtils.LoggedAtColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
