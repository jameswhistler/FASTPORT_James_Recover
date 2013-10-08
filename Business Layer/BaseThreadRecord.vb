' This class is "generated" and will be overwritten.
' Your customizations should be made in ThreadRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="ThreadRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="ThreadTable"></see> class.
''' </remarks>
''' <seealso cref="ThreadTable"></seealso>
''' <seealso cref="ThreadRecord"></seealso>

<Serializable()> Public Class BaseThreadRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As ThreadTable = ThreadTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub ThreadRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim ThreadRec As ThreadRecord = CType(sender,ThreadRecord)
        Validate_Inserting()
        If Not ThreadRec Is Nothing AndAlso Not ThreadRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub ThreadRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim ThreadRec As ThreadRecord = CType(sender,ThreadRecord)
        Validate_Updating()
        If Not ThreadRec Is Nothing AndAlso Not ThreadRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub ThreadRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim ThreadRec As ThreadRecord = CType(sender,ThreadRecord)
        If Not ThreadRec Is Nothing AndAlso Not ThreadRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Thread_.ThreadID field.
	''' </summary>
	Public Function GetThreadIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThreadIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.ThreadID field.
	''' </summary>
	Public Function GetThreadIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ThreadIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.ThreadTreeID field.
	''' </summary>
	Public Function GetThreadTreeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThreadTreeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.ThreadTreeID field.
	''' </summary>
	Public Function GetThreadTreeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ThreadTreeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.ThreadTreeID field.
	''' </summary>
	Public Sub SetThreadTreeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThreadTreeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.ThreadTreeID field.
	''' </summary>
	Public Sub SetThreadTreeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThreadTreeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.ThreadTreeID field.
	''' </summary>
	Public Sub SetThreadTreeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadTreeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.ThreadTreeID field.
	''' </summary>
	Public Sub SetThreadTreeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadTreeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.ThreadTreeID field.
	''' </summary>
	Public Sub SetThreadTreeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadTreeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.ThreadTypeID field.
	''' </summary>
	Public Function GetThreadTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThreadTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.ThreadTypeID field.
	''' </summary>
	Public Function GetThreadTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ThreadTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.ThreadTypeID field.
	''' </summary>
	Public Sub SetThreadTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThreadTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.ThreadTypeID field.
	''' </summary>
	Public Sub SetThreadTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThreadTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.ThreadTypeID field.
	''' </summary>
	Public Sub SetThreadTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.ThreadTypeID field.
	''' </summary>
	Public Sub SetThreadTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.ThreadTypeID field.
	''' </summary>
	Public Sub SetThreadTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.ThreadName field.
	''' </summary>
	Public Function GetThreadNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThreadNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.ThreadName field.
	''' </summary>
	Public Function GetThreadNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThreadNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.ThreadName field.
	''' </summary>
	Public Sub SetThreadNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThreadNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.ThreadName field.
	''' </summary>
	Public Sub SetThreadNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.FlowCollectionID field.
	''' </summary>
	Public Function GetFlowCollectionIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowCollectionIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.FlowCollectionID field.
	''' </summary>
	Public Function GetFlowCollectionIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowCollectionIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FlowCollectionID field.
	''' </summary>
	Public Sub SetFlowCollectionIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FlowCollectionID field.
	''' </summary>
	Public Sub SetFlowCollectionIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FlowCollectionID field.
	''' </summary>
	Public Sub SetFlowCollectionIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FlowCollectionID field.
	''' </summary>
	Public Sub SetFlowCollectionIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FlowCollectionID field.
	''' </summary>
	Public Sub SetFlowCollectionIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowCollectionIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.RelationTypeID field.
	''' </summary>
	Public Function GetRelationTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RelationTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.RelationTypeID field.
	''' </summary>
	Public Function GetRelationTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RelationTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.RelationTypeID field.
	''' </summary>
	Public Sub SetRelationTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RelationTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.RelationTypeID field.
	''' </summary>
	Public Sub SetRelationTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RelationTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.RelationTypeID field.
	''' </summary>
	Public Sub SetRelationTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RelationTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.RelationTypeID field.
	''' </summary>
	Public Sub SetRelationTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RelationTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.RelationTypeID field.
	''' </summary>
	Public Sub SetRelationTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RelationTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.FirstSubject field.
	''' </summary>
	Public Function GetFirstSubjectValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstSubjectColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.FirstSubject field.
	''' </summary>
	Public Function GetFirstSubjectFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstSubjectColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FirstSubject field.
	''' </summary>
	Public Sub SetFirstSubjectFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstSubjectColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FirstSubject field.
	''' </summary>
	Public Sub SetFirstSubjectFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstSubjectColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.FirstAction field.
	''' </summary>
	Public Function GetFirstActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.FirstAction field.
	''' </summary>
	Public Function GetFirstActionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstActionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FirstAction field.
	''' </summary>
	Public Sub SetFirstActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FirstAction field.
	''' </summary>
	Public Sub SetFirstActionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.FirstButtonText field.
	''' </summary>
	Public Function GetFirstButtonTextValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstButtonTextColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.FirstButtonText field.
	''' </summary>
	Public Function GetFirstButtonTextFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstButtonTextColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FirstButtonText field.
	''' </summary>
	Public Sub SetFirstButtonTextFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstButtonTextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FirstButtonText field.
	''' </summary>
	Public Sub SetFirstButtonTextFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstButtonTextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.NoRadWindow field.
	''' </summary>
	Public Function GetNoRadWindowValue() As ColumnValue
		Return Me.GetValue(TableUtils.NoRadWindowColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.NoRadWindow field.
	''' </summary>
	Public Function GetNoRadWindowFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.NoRadWindowColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.NoRadWindow field.
	''' </summary>
	Public Sub SetNoRadWindowFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NoRadWindowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.NoRadWindow field.
	''' </summary>
	Public Sub SetNoRadWindowFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.NoRadWindowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.NoRadWindow field.
	''' </summary>
	Public Sub SetNoRadWindowFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NoRadWindowColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.GoAction field.
	''' </summary>
	Public Function GetGoActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.GoActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.GoAction field.
	''' </summary>
	Public Function GetGoActionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.GoActionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.GoAction field.
	''' </summary>
	Public Sub SetGoActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GoActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.GoAction field.
	''' </summary>
	Public Sub SetGoActionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GoActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.FirstButtonPage field.
	''' </summary>
	Public Function GetFirstButtonPageValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstButtonPageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.FirstButtonPage field.
	''' </summary>
	Public Function GetFirstButtonPageFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstButtonPageColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FirstButtonPage field.
	''' </summary>
	Public Sub SetFirstButtonPageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstButtonPageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FirstButtonPage field.
	''' </summary>
	Public Sub SetFirstButtonPageFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstButtonPageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.FirstBody field.
	''' </summary>
	Public Function GetFirstBodyValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstBodyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.FirstBody field.
	''' </summary>
	Public Function GetFirstBodyFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstBodyColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FirstBody field.
	''' </summary>
	Public Sub SetFirstBodyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstBodyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.FirstBody field.
	''' </summary>
	Public Sub SetFirstBodyFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstBodyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Thread_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Thread_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Thread_.ThreadID field.
	''' </summary>
	Public Property ThreadID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ThreadIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThreadIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThreadIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThreadIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThreadIDDefault() As String
        Get
            Return TableUtils.ThreadIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Thread_.ThreadTreeID field.
	''' </summary>
	Public Property ThreadTreeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ThreadTreeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThreadTreeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThreadTreeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThreadTreeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThreadTreeIDDefault() As String
        Get
            Return TableUtils.ThreadTreeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Thread_.ThreadTypeID field.
	''' </summary>
	Public Property ThreadTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ThreadTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThreadTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThreadTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThreadTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThreadTypeIDDefault() As String
        Get
            Return TableUtils.ThreadTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Thread_.ThreadName field.
	''' </summary>
	Public Property ThreadName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThreadNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThreadNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThreadNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThreadNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThreadNameDefault() As String
        Get
            Return TableUtils.ThreadNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Thread_.FlowCollectionID field.
	''' </summary>
	Public Property FlowCollectionID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FlowCollectionIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FlowCollectionIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FlowCollectionIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FlowCollectionIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FlowCollectionIDDefault() As String
        Get
            Return TableUtils.FlowCollectionIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Thread_.RelationTypeID field.
	''' </summary>
	Public Property RelationTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RelationTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RelationTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RelationTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RelationTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RelationTypeIDDefault() As String
        Get
            Return TableUtils.RelationTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Thread_.FirstSubject field.
	''' </summary>
	Public Property FirstSubject() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstSubjectColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstSubjectColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstSubjectSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstSubjectColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstSubjectDefault() As String
        Get
            Return TableUtils.FirstSubjectColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Thread_.FirstAction field.
	''' </summary>
	Public Property FirstAction() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstActionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstActionDefault() As String
        Get
            Return TableUtils.FirstActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Thread_.FirstButtonText field.
	''' </summary>
	Public Property FirstButtonText() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstButtonTextColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstButtonTextColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstButtonTextSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstButtonTextColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstButtonTextDefault() As String
        Get
            Return TableUtils.FirstButtonTextColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Thread_.NoRadWindow field.
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
	''' This is a convenience property that provides direct access to the value of the record's Thread_.GoAction field.
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
	''' This is a convenience property that provides direct access to the value of the record's Thread_.FirstButtonPage field.
	''' </summary>
	Public Property FirstButtonPage() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstButtonPageColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstButtonPageColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstButtonPageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstButtonPageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstButtonPageDefault() As String
        Get
            Return TableUtils.FirstButtonPageColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Thread_.FirstBody field.
	''' </summary>
	Public Property FirstBody() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstBodyColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstBodyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstBodySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstBodyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstBodyDefault() As String
        Get
            Return TableUtils.FirstBodyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Thread_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Thread_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's Thread_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Thread_.UpdatedAt field.
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
