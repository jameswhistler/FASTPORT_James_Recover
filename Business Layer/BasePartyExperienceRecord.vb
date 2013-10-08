' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyExperienceRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PartyExperienceRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="PartyExperienceTable"></see> class.
''' </remarks>
''' <seealso cref="PartyExperienceTable"></seealso>
''' <seealso cref="PartyExperienceRecord"></seealso>

<Serializable()> Public Class BasePartyExperienceRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As PartyExperienceTable = PartyExperienceTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub PartyExperienceRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim PartyExperienceRec As PartyExperienceRecord = CType(sender,PartyExperienceRecord)
        Validate_Inserting()
        If Not PartyExperienceRec Is Nothing AndAlso Not PartyExperienceRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub PartyExperienceRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim PartyExperienceRec As PartyExperienceRecord = CType(sender,PartyExperienceRecord)
        Validate_Updating()
        If Not PartyExperienceRec Is Nothing AndAlso Not PartyExperienceRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub PartyExperienceRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim PartyExperienceRec As PartyExperienceRecord = CType(sender,PartyExperienceRecord)
        If Not PartyExperienceRec Is Nothing AndAlso Not PartyExperienceRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.PartyExperienceID field.
	''' </summary>
	Public Function GetPartyExperienceIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyExperienceIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.PartyExperienceID field.
	''' </summary>
	Public Function GetPartyExperienceIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyExperienceIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.HistoryID field.
	''' </summary>
	Public Function GetHistoryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.HistoryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.HistoryID field.
	''' </summary>
	Public Function GetHistoryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HistoryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.AdID field.
	''' </summary>
	Public Function GetAdIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.AdID field.
	''' </summary>
	Public Function GetAdIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.ExperienceParentID field.
	''' </summary>
	Public Function GetExperienceParentIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExperienceParentIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.ExperienceParentID field.
	''' </summary>
	Public Function GetExperienceParentIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ExperienceParentIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceParentID field.
	''' </summary>
	Public Sub SetExperienceParentIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExperienceParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceParentID field.
	''' </summary>
	Public Sub SetExperienceParentIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExperienceParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceParentID field.
	''' </summary>
	Public Sub SetExperienceParentIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExperienceParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceParentID field.
	''' </summary>
	Public Sub SetExperienceParentIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExperienceParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceParentID field.
	''' </summary>
	Public Sub SetExperienceParentIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExperienceParentIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.ExperienceID field.
	''' </summary>
	Public Function GetExperienceIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExperienceIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.ExperienceID field.
	''' </summary>
	Public Function GetExperienceIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ExperienceIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceID field.
	''' </summary>
	Public Sub SetExperienceIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExperienceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceID field.
	''' </summary>
	Public Sub SetExperienceIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExperienceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceID field.
	''' </summary>
	Public Sub SetExperienceIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExperienceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceID field.
	''' </summary>
	Public Sub SetExperienceIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExperienceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceID field.
	''' </summary>
	Public Sub SetExperienceIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExperienceIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.ExperienceNotes field.
	''' </summary>
	Public Function GetExperienceNotesValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExperienceNotesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.ExperienceNotes field.
	''' </summary>
	Public Function GetExperienceNotesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ExperienceNotesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceNotes field.
	''' </summary>
	Public Sub SetExperienceNotesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExperienceNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceNotes field.
	''' </summary>
	Public Sub SetExperienceNotesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExperienceNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.FocusedOn field.
	''' </summary>
	Public Function GetFocusedOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.FocusedOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.FocusedOn field.
	''' </summary>
	Public Function GetFocusedOnFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.FocusedOnColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.FocusedOn field.
	''' </summary>
	Public Sub SetFocusedOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FocusedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.FocusedOn field.
	''' </summary>
	Public Sub SetFocusedOnFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FocusedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.FocusedOn field.
	''' </summary>
	Public Sub SetFocusedOnFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FocusedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.FocusedOn field.
	''' </summary>
	Public Sub SetFocusedOnFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FocusedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.FocusedOn field.
	''' </summary>
	Public Sub SetFocusedOnFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FocusedOnColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.LockFocus field.
	''' </summary>
	Public Function GetLockFocusValue() As ColumnValue
		Return Me.GetValue(TableUtils.LockFocusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.LockFocus field.
	''' </summary>
	Public Function GetLockFocusFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.LockFocusColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.LockFocus field.
	''' </summary>
	Public Sub SetLockFocusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LockFocusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.LockFocus field.
	''' </summary>
	Public Sub SetLockFocusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LockFocusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.LockFocus field.
	''' </summary>
	Public Sub SetLockFocusFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LockFocusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.Importance field.
	''' </summary>
	Public Function GetImportanceValue() As ColumnValue
		Return Me.GetValue(TableUtils.ImportanceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.Importance field.
	''' </summary>
	Public Function GetImportanceFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ImportanceColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.Importance field.
	''' </summary>
	Public Sub SetImportanceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ImportanceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.Importance field.
	''' </summary>
	Public Sub SetImportanceFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ImportanceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.Importance field.
	''' </summary>
	Public Sub SetImportanceFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ImportanceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.Importance field.
	''' </summary>
	Public Sub SetImportanceFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ImportanceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.Importance field.
	''' </summary>
	Public Sub SetImportanceFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ImportanceColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.ExperienceRank field.
	''' </summary>
	Public Function GetExperienceRankValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExperienceRankColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyExperience_.ExperienceRank field.
	''' </summary>
	Public Function GetExperienceRankFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ExperienceRankColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceRank field.
	''' </summary>
	Public Sub SetExperienceRankFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExperienceRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceRank field.
	''' </summary>
	Public Sub SetExperienceRankFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExperienceRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceRank field.
	''' </summary>
	Public Sub SetExperienceRankFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExperienceRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceRank field.
	''' </summary>
	Public Sub SetExperienceRankFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExperienceRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyExperience_.ExperienceRank field.
	''' </summary>
	Public Sub SetExperienceRankFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExperienceRankColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyExperience_.PartyExperienceID field.
	''' </summary>
	Public Property PartyExperienceID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PartyExperienceIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PartyExperienceIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PartyExperienceIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PartyExperienceIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PartyExperienceIDDefault() As String
        Get
            Return TableUtils.PartyExperienceIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyExperience_.HistoryID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyExperience_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyExperience_.AdID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyExperience_.ExperienceParentID field.
	''' </summary>
	Public Property ExperienceParentID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ExperienceParentIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExperienceParentIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExperienceParentIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExperienceParentIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExperienceParentIDDefault() As String
        Get
            Return TableUtils.ExperienceParentIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyExperience_.ExperienceID field.
	''' </summary>
	Public Property ExperienceID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ExperienceIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExperienceIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExperienceIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExperienceIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExperienceIDDefault() As String
        Get
            Return TableUtils.ExperienceIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyExperience_.ExperienceNotes field.
	''' </summary>
	Public Property ExperienceNotes() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ExperienceNotesColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ExperienceNotesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExperienceNotesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExperienceNotesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExperienceNotesDefault() As String
        Get
            Return TableUtils.ExperienceNotesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyExperience_.FocusedOn field.
	''' </summary>
	Public Property FocusedOn() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.FocusedOnColumn).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FocusedOnColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FocusedOnSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FocusedOnColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FocusedOnDefault() As String
        Get
            Return TableUtils.FocusedOnColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyExperience_.LockFocus field.
	''' </summary>
	Public Property LockFocus() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.LockFocusColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LockFocusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LockFocusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LockFocusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LockFocusDefault() As String
        Get
            Return TableUtils.LockFocusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyExperience_.Importance field.
	''' </summary>
	Public Property Importance() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ImportanceColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ImportanceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ImportanceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ImportanceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ImportanceDefault() As String
        Get
            Return TableUtils.ImportanceColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyExperience_.ExperienceRank field.
	''' </summary>
	Public Property ExperienceRank() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ExperienceRankColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExperienceRankColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExperienceRankSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExperienceRankColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExperienceRankDefault() As String
        Get
            Return TableUtils.ExperienceRankColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
