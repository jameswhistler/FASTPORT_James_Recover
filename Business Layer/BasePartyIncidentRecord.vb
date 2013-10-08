' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyIncidentRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PartyIncidentRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="PartyIncidentTable"></see> class.
''' </remarks>
''' <seealso cref="PartyIncidentTable"></seealso>
''' <seealso cref="PartyIncidentRecord"></seealso>

<Serializable()> Public Class BasePartyIncidentRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As PartyIncidentTable = PartyIncidentTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub PartyIncidentRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim PartyIncidentRec As PartyIncidentRecord = CType(sender,PartyIncidentRecord)
        Validate_Inserting()
        If Not PartyIncidentRec Is Nothing AndAlso Not PartyIncidentRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub PartyIncidentRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim PartyIncidentRec As PartyIncidentRecord = CType(sender,PartyIncidentRecord)
        Validate_Updating()
        If Not PartyIncidentRec Is Nothing AndAlso Not PartyIncidentRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub PartyIncidentRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim PartyIncidentRec As PartyIncidentRecord = CType(sender,PartyIncidentRecord)
        If Not PartyIncidentRec Is Nothing AndAlso Not PartyIncidentRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.IncidentID field.
	''' </summary>
	Public Function GetIncidentIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.IncidentIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.IncidentID field.
	''' </summary>
	Public Function GetIncidentIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.IncidentIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.IncidentCategoryID field.
	''' </summary>
	Public Function GetIncidentCategoryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.IncidentCategoryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.IncidentCategoryID field.
	''' </summary>
	Public Function GetIncidentCategoryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.IncidentCategoryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.IncidentCategoryID field.
	''' </summary>
	Public Sub SetIncidentCategoryIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IncidentCategoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.IncidentCategoryID field.
	''' </summary>
	Public Sub SetIncidentCategoryIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IncidentCategoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.IncidentCategoryID field.
	''' </summary>
	Public Sub SetIncidentCategoryIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IncidentCategoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.IncidentCategoryID field.
	''' </summary>
	Public Sub SetIncidentCategoryIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IncidentCategoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.IncidentCategoryID field.
	''' </summary>
	Public Sub SetIncidentCategoryIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IncidentCategoryIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.ShortDescription field.
	''' </summary>
	Public Function GetShortDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShortDescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.ShortDescription field.
	''' </summary>
	Public Function GetShortDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ShortDescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.ShortDescription field.
	''' </summary>
	Public Sub SetShortDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShortDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.ShortDescription field.
	''' </summary>
	Public Sub SetShortDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShortDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.DetailedDescription field.
	''' </summary>
	Public Function GetDetailedDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.DetailedDescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.DetailedDescription field.
	''' </summary>
	Public Function GetDetailedDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DetailedDescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.DetailedDescription field.
	''' </summary>
	Public Sub SetDetailedDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DetailedDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.DetailedDescription field.
	''' </summary>
	Public Sub SetDetailedDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DetailedDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.OccurredOn field.
	''' </summary>
	Public Function GetOccurredOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.OccurredOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.OccurredOn field.
	''' </summary>
	Public Function GetOccurredOnFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.OccurredOnColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.OccurredOn field.
	''' </summary>
	Public Sub SetOccurredOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OccurredOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.OccurredOn field.
	''' </summary>
	Public Sub SetOccurredOnFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OccurredOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.OccurredOn field.
	''' </summary>
	Public Sub SetOccurredOnFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OccurredOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.AccidentLocationID field.
	''' </summary>
	Public Function GetAccidentLocationIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AccidentLocationIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.AccidentLocationID field.
	''' </summary>
	Public Function GetAccidentLocationIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AccidentLocationIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.AccidentLocationID field.
	''' </summary>
	Public Sub SetAccidentLocationIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AccidentLocationIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.AccidentLocationID field.
	''' </summary>
	Public Sub SetAccidentLocationIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AccidentLocationIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.AccidentLocationID field.
	''' </summary>
	Public Sub SetAccidentLocationIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AccidentLocationIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.AccidentLocationID field.
	''' </summary>
	Public Sub SetAccidentLocationIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AccidentLocationIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.AccidentLocationID field.
	''' </summary>
	Public Sub SetAccidentLocationIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AccidentLocationIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.IWasAtFault field.
	''' </summary>
	Public Function GetIWasAtFaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.IWasAtFaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.IWasAtFault field.
	''' </summary>
	Public Function GetIWasAtFaultFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.IWasAtFaultColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.IWasAtFault field.
	''' </summary>
	Public Sub SetIWasAtFaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IWasAtFaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.IWasAtFault field.
	''' </summary>
	Public Sub SetIWasAtFaultFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IWasAtFaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.IWasAtFault field.
	''' </summary>
	Public Sub SetIWasAtFaultFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IWasAtFaultColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.EstimatedCost field.
	''' </summary>
	Public Function GetEstimatedCostValue() As ColumnValue
		Return Me.GetValue(TableUtils.EstimatedCostColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.EstimatedCost field.
	''' </summary>
	Public Function GetEstimatedCostFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.EstimatedCostColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.EstimatedCost field.
	''' </summary>
	Public Sub SetEstimatedCostFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EstimatedCostColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.EstimatedCost field.
	''' </summary>
	Public Sub SetEstimatedCostFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EstimatedCostColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.EstimatedCost field.
	''' </summary>
	Public Sub SetEstimatedCostFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstimatedCostColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.EstimatedCost field.
	''' </summary>
	Public Sub SetEstimatedCostFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstimatedCostColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.EstimatedCost field.
	''' </summary>
	Public Sub SetEstimatedCostFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstimatedCostColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.FileClosed field.
	''' </summary>
	Public Function GetFileClosedValue() As ColumnValue
		Return Me.GetValue(TableUtils.FileClosedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.FileClosed field.
	''' </summary>
	Public Function GetFileClosedFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FileClosedColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.FileClosed field.
	''' </summary>
	Public Sub SetFileClosedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FileClosedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.FileClosed field.
	''' </summary>
	Public Sub SetFileClosedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FileClosedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.FileClosed field.
	''' </summary>
	Public Sub SetFileClosedFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FileClosedColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.TowAWayAccident field.
	''' </summary>
	Public Function GetTowAWayAccidentValue() As ColumnValue
		Return Me.GetValue(TableUtils.TowAWayAccidentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.TowAWayAccident field.
	''' </summary>
	Public Function GetTowAWayAccidentFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TowAWayAccidentColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.TowAWayAccident field.
	''' </summary>
	Public Sub SetTowAWayAccidentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TowAWayAccidentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.TowAWayAccident field.
	''' </summary>
	Public Sub SetTowAWayAccidentFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TowAWayAccidentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.TowAWayAccident field.
	''' </summary>
	Public Sub SetTowAWayAccidentFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TowAWayAccidentColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.FatalitiesOccured field.
	''' </summary>
	Public Function GetFatalitiesOccuredValue() As ColumnValue
		Return Me.GetValue(TableUtils.FatalitiesOccuredColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.FatalitiesOccured field.
	''' </summary>
	Public Function GetFatalitiesOccuredFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FatalitiesOccuredColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.FatalitiesOccured field.
	''' </summary>
	Public Sub SetFatalitiesOccuredFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FatalitiesOccuredColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.FatalitiesOccured field.
	''' </summary>
	Public Sub SetFatalitiesOccuredFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FatalitiesOccuredColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.FatalitiesOccured field.
	''' </summary>
	Public Sub SetFatalitiesOccuredFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FatalitiesOccuredColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.InjuriesOccured field.
	''' </summary>
	Public Function GetInjuriesOccuredValue() As ColumnValue
		Return Me.GetValue(TableUtils.InjuriesOccuredColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.InjuriesOccured field.
	''' </summary>
	Public Function GetInjuriesOccuredFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.InjuriesOccuredColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.InjuriesOccured field.
	''' </summary>
	Public Sub SetInjuriesOccuredFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.InjuriesOccuredColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.InjuriesOccured field.
	''' </summary>
	Public Sub SetInjuriesOccuredFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.InjuriesOccuredColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.InjuriesOccured field.
	''' </summary>
	Public Sub SetInjuriesOccuredFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InjuriesOccuredColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.TestedAfterAccident field.
	''' </summary>
	Public Function GetTestedAfterAccidentValue() As ColumnValue
		Return Me.GetValue(TableUtils.TestedAfterAccidentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.TestedAfterAccident field.
	''' </summary>
	Public Function GetTestedAfterAccidentFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TestedAfterAccidentColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.TestedAfterAccident field.
	''' </summary>
	Public Sub SetTestedAfterAccidentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TestedAfterAccidentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.TestedAfterAccident field.
	''' </summary>
	Public Sub SetTestedAfterAccidentFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TestedAfterAccidentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.TestedAfterAccident field.
	''' </summary>
	Public Sub SetTestedAfterAccidentFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TestedAfterAccidentColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.PositiveForDrugs field.
	''' </summary>
	Public Function GetPositiveForDrugsValue() As ColumnValue
		Return Me.GetValue(TableUtils.PositiveForDrugsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.PositiveForDrugs field.
	''' </summary>
	Public Function GetPositiveForDrugsFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.PositiveForDrugsColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PositiveForDrugs field.
	''' </summary>
	Public Sub SetPositiveForDrugsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PositiveForDrugsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PositiveForDrugs field.
	''' </summary>
	Public Sub SetPositiveForDrugsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PositiveForDrugsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PositiveForDrugs field.
	''' </summary>
	Public Sub SetPositiveForDrugsFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PositiveForDrugsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.PositiveForAlcohol field.
	''' </summary>
	Public Function GetPositiveForAlcoholValue() As ColumnValue
		Return Me.GetValue(TableUtils.PositiveForAlcoholColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.PositiveForAlcohol field.
	''' </summary>
	Public Function GetPositiveForAlcoholFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.PositiveForAlcoholColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PositiveForAlcohol field.
	''' </summary>
	Public Sub SetPositiveForAlcoholFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PositiveForAlcoholColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PositiveForAlcohol field.
	''' </summary>
	Public Sub SetPositiveForAlcoholFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PositiveForAlcoholColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PositiveForAlcohol field.
	''' </summary>
	Public Sub SetPositiveForAlcoholFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PositiveForAlcoholColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.EqiupTypeID field.
	''' </summary>
	Public Function GetEqiupTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EqiupTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.EqiupTypeID field.
	''' </summary>
	Public Function GetEqiupTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EqiupTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.EqiupTypeID field.
	''' </summary>
	Public Sub SetEqiupTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EqiupTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.EqiupTypeID field.
	''' </summary>
	Public Sub SetEqiupTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EqiupTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.EqiupTypeID field.
	''' </summary>
	Public Sub SetEqiupTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EqiupTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.EqiupTypeID field.
	''' </summary>
	Public Sub SetEqiupTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EqiupTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.EqiupTypeID field.
	''' </summary>
	Public Sub SetEqiupTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EqiupTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.CargoTypeID field.
	''' </summary>
	Public Function GetCargoTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CargoTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.CargoTypeID field.
	''' </summary>
	Public Function GetCargoTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CargoTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.CargoTypeID field.
	''' </summary>
	Public Sub SetCargoTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CargoTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.CargoTypeID field.
	''' </summary>
	Public Sub SetCargoTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CargoTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.CargoTypeID field.
	''' </summary>
	Public Sub SetCargoTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CargoTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.CargoTypeID field.
	''' </summary>
	Public Sub SetCargoTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CargoTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.CargoTypeID field.
	''' </summary>
	Public Sub SetCargoTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CargoTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.Ticketed field.
	''' </summary>
	Public Function GetTicketedValue() As ColumnValue
		Return Me.GetValue(TableUtils.TicketedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.Ticketed field.
	''' </summary>
	Public Function GetTicketedFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TicketedColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.Ticketed field.
	''' </summary>
	Public Sub SetTicketedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TicketedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.Ticketed field.
	''' </summary>
	Public Sub SetTicketedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TicketedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.Ticketed field.
	''' </summary>
	Public Sub SetTicketedFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketedColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.RuledAsRecklessDriving field.
	''' </summary>
	Public Function GetRuledAsRecklessDrivingValue() As ColumnValue
		Return Me.GetValue(TableUtils.RuledAsRecklessDrivingColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.RuledAsRecklessDriving field.
	''' </summary>
	Public Function GetRuledAsRecklessDrivingFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.RuledAsRecklessDrivingColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.RuledAsRecklessDriving field.
	''' </summary>
	Public Sub SetRuledAsRecklessDrivingFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RuledAsRecklessDrivingColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.RuledAsRecklessDriving field.
	''' </summary>
	Public Sub SetRuledAsRecklessDrivingFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RuledAsRecklessDrivingColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.RuledAsRecklessDriving field.
	''' </summary>
	Public Sub SetRuledAsRecklessDrivingFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RuledAsRecklessDrivingColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.FelonyIssued field.
	''' </summary>
	Public Function GetFelonyIssuedValue() As ColumnValue
		Return Me.GetValue(TableUtils.FelonyIssuedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.FelonyIssued field.
	''' </summary>
	Public Function GetFelonyIssuedFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FelonyIssuedColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.FelonyIssued field.
	''' </summary>
	Public Sub SetFelonyIssuedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FelonyIssuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.FelonyIssued field.
	''' </summary>
	Public Sub SetFelonyIssuedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FelonyIssuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.FelonyIssued field.
	''' </summary>
	Public Sub SetFelonyIssuedFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FelonyIssuedColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.LicenseSuspended field.
	''' </summary>
	Public Function GetLicenseSuspendedValue() As ColumnValue
		Return Me.GetValue(TableUtils.LicenseSuspendedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.LicenseSuspended field.
	''' </summary>
	Public Function GetLicenseSuspendedFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.LicenseSuspendedColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.LicenseSuspended field.
	''' </summary>
	Public Sub SetLicenseSuspendedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LicenseSuspendedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.LicenseSuspended field.
	''' </summary>
	Public Sub SetLicenseSuspendedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LicenseSuspendedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.LicenseSuspended field.
	''' </summary>
	Public Sub SetLicenseSuspendedFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LicenseSuspendedColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.ReinstatedOn field.
	''' </summary>
	Public Function GetReinstatedOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReinstatedOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.ReinstatedOn field.
	''' </summary>
	Public Function GetReinstatedOnFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.ReinstatedOnColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.ReinstatedOn field.
	''' </summary>
	Public Sub SetReinstatedOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReinstatedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.ReinstatedOn field.
	''' </summary>
	Public Sub SetReinstatedOnFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ReinstatedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.ReinstatedOn field.
	''' </summary>
	Public Sub SetReinstatedOnFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReinstatedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.SAPRelease field.
	''' </summary>
	Public Function GetSAPReleaseValue() As ColumnValue
		Return Me.GetValue(TableUtils.SAPReleaseColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.SAPRelease field.
	''' </summary>
	Public Function GetSAPReleaseFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SAPReleaseColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.SAPRelease field.
	''' </summary>
	Public Sub SetSAPReleaseFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SAPReleaseColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.SAPRelease field.
	''' </summary>
	Public Sub SetSAPReleaseFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SAPReleaseColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.SAPRelease field.
	''' </summary>
	Public Sub SetSAPReleaseFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SAPReleaseColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.SAPReleaseDate field.
	''' </summary>
	Public Function GetSAPReleaseDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.SAPReleaseDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.SAPReleaseDate field.
	''' </summary>
	Public Function GetSAPReleaseDateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.SAPReleaseDateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.SAPReleaseDate field.
	''' </summary>
	Public Sub SetSAPReleaseDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SAPReleaseDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.SAPReleaseDate field.
	''' </summary>
	Public Sub SetSAPReleaseDateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SAPReleaseDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.SAPReleaseDate field.
	''' </summary>
	Public Sub SetSAPReleaseDateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SAPReleaseDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.PhysicalLimitationExpiration field.
	''' </summary>
	Public Function GetPhysicalLimitationExpirationValue() As ColumnValue
		Return Me.GetValue(TableUtils.PhysicalLimitationExpirationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.PhysicalLimitationExpiration field.
	''' </summary>
	Public Function GetPhysicalLimitationExpirationFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.PhysicalLimitationExpirationColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PhysicalLimitationExpiration field.
	''' </summary>
	Public Sub SetPhysicalLimitationExpirationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PhysicalLimitationExpirationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PhysicalLimitationExpiration field.
	''' </summary>
	Public Sub SetPhysicalLimitationExpirationFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PhysicalLimitationExpirationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PhysicalLimitationExpiration field.
	''' </summary>
	Public Sub SetPhysicalLimitationExpirationFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PhysicalLimitationExpirationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.PhysicalObsolete field.
	''' </summary>
	Public Function GetPhysicalObsoleteValue() As ColumnValue
		Return Me.GetValue(TableUtils.PhysicalObsoleteColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.PhysicalObsolete field.
	''' </summary>
	Public Function GetPhysicalObsoleteFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.PhysicalObsoleteColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PhysicalObsolete field.
	''' </summary>
	Public Sub SetPhysicalObsoleteFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PhysicalObsoleteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PhysicalObsolete field.
	''' </summary>
	Public Sub SetPhysicalObsoleteFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PhysicalObsoleteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.PhysicalObsolete field.
	''' </summary>
	Public Sub SetPhysicalObsoleteFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PhysicalObsoleteColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.IncidentExpiration field.
	''' </summary>
	Public Function GetIncidentExpirationValue() As ColumnValue
		Return Me.GetValue(TableUtils.IncidentExpirationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.IncidentExpiration field.
	''' </summary>
	Public Function GetIncidentExpirationFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.IncidentExpirationColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.IncidentExpiration field.
	''' </summary>
	Public Sub SetIncidentExpirationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IncidentExpirationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.IncidentExpiration field.
	''' </summary>
	Public Sub SetIncidentExpirationFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IncidentExpirationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.IncidentExpiration field.
	''' </summary>
	Public Sub SetIncidentExpirationFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IncidentExpirationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.LockIncident field.
	''' </summary>
	Public Function GetLockIncidentValue() As ColumnValue
		Return Me.GetValue(TableUtils.LockIncidentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncident_.LockIncident field.
	''' </summary>
	Public Function GetLockIncidentFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.LockIncidentColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.LockIncident field.
	''' </summary>
	Public Sub SetLockIncidentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LockIncidentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.LockIncident field.
	''' </summary>
	Public Sub SetLockIncidentFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LockIncidentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncident_.LockIncident field.
	''' </summary>
	Public Sub SetLockIncidentFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LockIncidentColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.IncidentID field.
	''' </summary>
	Public Property IncidentID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.IncidentIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IncidentIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IncidentIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IncidentIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IncidentIDDefault() As String
        Get
            Return TableUtils.IncidentIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.IncidentCategoryID field.
	''' </summary>
	Public Property IncidentCategoryID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.IncidentCategoryIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IncidentCategoryIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IncidentCategoryIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IncidentCategoryIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IncidentCategoryIDDefault() As String
        Get
            Return TableUtils.IncidentCategoryIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.ShortDescription field.
	''' </summary>
	Public Property ShortDescription() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ShortDescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ShortDescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ShortDescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ShortDescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ShortDescriptionDefault() As String
        Get
            Return TableUtils.ShortDescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.DetailedDescription field.
	''' </summary>
	Public Property DetailedDescription() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DetailedDescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DetailedDescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DetailedDescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DetailedDescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DetailedDescriptionDefault() As String
        Get
            Return TableUtils.DetailedDescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.OccurredOn field.
	''' </summary>
	Public Property OccurredOn() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.OccurredOnColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OccurredOnColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OccurredOnSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OccurredOnColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OccurredOnDefault() As String
        Get
            Return TableUtils.OccurredOnColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.AccidentLocationID field.
	''' </summary>
	Public Property AccidentLocationID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AccidentLocationIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AccidentLocationIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AccidentLocationIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AccidentLocationIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AccidentLocationIDDefault() As String
        Get
            Return TableUtils.AccidentLocationIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.IWasAtFault field.
	''' </summary>
	Public Property IWasAtFault() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.IWasAtFaultColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IWasAtFaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IWasAtFaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IWasAtFaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IWasAtFaultDefault() As String
        Get
            Return TableUtils.IWasAtFaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.EstimatedCost field.
	''' </summary>
	Public Property EstimatedCost() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.EstimatedCostColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EstimatedCostColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EstimatedCostSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EstimatedCostColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EstimatedCostDefault() As String
        Get
            Return TableUtils.EstimatedCostColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.FileClosed field.
	''' </summary>
	Public Property FileClosed() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FileClosedColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FileClosedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FileClosedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FileClosedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FileClosedDefault() As String
        Get
            Return TableUtils.FileClosedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.TowAWayAccident field.
	''' </summary>
	Public Property TowAWayAccident() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TowAWayAccidentColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TowAWayAccidentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TowAWayAccidentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TowAWayAccidentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TowAWayAccidentDefault() As String
        Get
            Return TableUtils.TowAWayAccidentColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.FatalitiesOccured field.
	''' </summary>
	Public Property FatalitiesOccured() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FatalitiesOccuredColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FatalitiesOccuredColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FatalitiesOccuredSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FatalitiesOccuredColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FatalitiesOccuredDefault() As String
        Get
            Return TableUtils.FatalitiesOccuredColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.InjuriesOccured field.
	''' </summary>
	Public Property InjuriesOccured() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.InjuriesOccuredColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.InjuriesOccuredColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property InjuriesOccuredSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.InjuriesOccuredColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property InjuriesOccuredDefault() As String
        Get
            Return TableUtils.InjuriesOccuredColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.TestedAfterAccident field.
	''' </summary>
	Public Property TestedAfterAccident() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TestedAfterAccidentColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TestedAfterAccidentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TestedAfterAccidentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TestedAfterAccidentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TestedAfterAccidentDefault() As String
        Get
            Return TableUtils.TestedAfterAccidentColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.PositiveForDrugs field.
	''' </summary>
	Public Property PositiveForDrugs() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.PositiveForDrugsColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PositiveForDrugsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PositiveForDrugsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PositiveForDrugsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PositiveForDrugsDefault() As String
        Get
            Return TableUtils.PositiveForDrugsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.PositiveForAlcohol field.
	''' </summary>
	Public Property PositiveForAlcohol() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.PositiveForAlcoholColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PositiveForAlcoholColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PositiveForAlcoholSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PositiveForAlcoholColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PositiveForAlcoholDefault() As String
        Get
            Return TableUtils.PositiveForAlcoholColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.EqiupTypeID field.
	''' </summary>
	Public Property EqiupTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EqiupTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EqiupTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EqiupTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EqiupTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EqiupTypeIDDefault() As String
        Get
            Return TableUtils.EqiupTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.CargoTypeID field.
	''' </summary>
	Public Property CargoTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CargoTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CargoTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CargoTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CargoTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CargoTypeIDDefault() As String
        Get
            Return TableUtils.CargoTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.Ticketed field.
	''' </summary>
	Public Property Ticketed() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TicketedColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TicketedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TicketedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TicketedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TicketedDefault() As String
        Get
            Return TableUtils.TicketedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.RuledAsRecklessDriving field.
	''' </summary>
	Public Property RuledAsRecklessDriving() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.RuledAsRecklessDrivingColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RuledAsRecklessDrivingColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RuledAsRecklessDrivingSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RuledAsRecklessDrivingColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RuledAsRecklessDrivingDefault() As String
        Get
            Return TableUtils.RuledAsRecklessDrivingColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.FelonyIssued field.
	''' </summary>
	Public Property FelonyIssued() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FelonyIssuedColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FelonyIssuedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FelonyIssuedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FelonyIssuedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FelonyIssuedDefault() As String
        Get
            Return TableUtils.FelonyIssuedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.LicenseSuspended field.
	''' </summary>
	Public Property LicenseSuspended() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.LicenseSuspendedColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LicenseSuspendedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LicenseSuspendedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LicenseSuspendedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LicenseSuspendedDefault() As String
        Get
            Return TableUtils.LicenseSuspendedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.ReinstatedOn field.
	''' </summary>
	Public Property ReinstatedOn() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.ReinstatedOnColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ReinstatedOnColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReinstatedOnSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReinstatedOnColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReinstatedOnDefault() As String
        Get
            Return TableUtils.ReinstatedOnColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.SAPRelease field.
	''' </summary>
	Public Property SAPRelease() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SAPReleaseColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SAPReleaseColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SAPReleaseSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SAPReleaseColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SAPReleaseDefault() As String
        Get
            Return TableUtils.SAPReleaseColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.SAPReleaseDate field.
	''' </summary>
	Public Property SAPReleaseDate() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.SAPReleaseDateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SAPReleaseDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SAPReleaseDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SAPReleaseDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SAPReleaseDateDefault() As String
        Get
            Return TableUtils.SAPReleaseDateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.PhysicalLimitationExpiration field.
	''' </summary>
	Public Property PhysicalLimitationExpiration() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.PhysicalLimitationExpirationColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PhysicalLimitationExpirationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PhysicalLimitationExpirationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PhysicalLimitationExpirationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PhysicalLimitationExpirationDefault() As String
        Get
            Return TableUtils.PhysicalLimitationExpirationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.PhysicalObsolete field.
	''' </summary>
	Public Property PhysicalObsolete() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.PhysicalObsoleteColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PhysicalObsoleteColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PhysicalObsoleteSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PhysicalObsoleteColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PhysicalObsoleteDefault() As String
        Get
            Return TableUtils.PhysicalObsoleteColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.IncidentExpiration field.
	''' </summary>
	Public Property IncidentExpiration() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.IncidentExpirationColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IncidentExpirationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IncidentExpirationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IncidentExpirationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IncidentExpirationDefault() As String
        Get
            Return TableUtils.IncidentExpirationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.UpdatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyIncident_.LockIncident field.
	''' </summary>
	Public Property LockIncident() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.LockIncidentColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LockIncidentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LockIncidentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LockIncidentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LockIncidentDefault() As String
        Get
            Return TableUtils.LockIncidentColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
