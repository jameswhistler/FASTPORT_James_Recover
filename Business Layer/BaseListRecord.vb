' This class is "generated" and will be overwritten.
' Your customizations should be made in ListRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="ListRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="ListTable"></see> class.
''' </remarks>
''' <seealso cref="ListTable"></seealso>
''' <seealso cref="ListRecord"></seealso>

<Serializable()> Public Class BaseListRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As ListTable = ListTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub ListRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim ListRec As ListRecord = CType(sender,ListRecord)
        Validate_Inserting()
        If Not ListRec Is Nothing AndAlso Not ListRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub ListRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim ListRec As ListRecord = CType(sender,ListRecord)
        Validate_Updating()
        If Not ListRec Is Nothing AndAlso Not ListRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub ListRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim ListRec As ListRecord = CType(sender,ListRecord)
        If Not ListRec Is Nothing AndAlso Not ListRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's List_.ListID field.
	''' </summary>
	Public Function GetListIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ListIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's List_.ListID field.
	''' </summary>
	Public Function GetListIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ListIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's List_.ListType field.
	''' </summary>
	Public Function GetListTypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.ListTypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's List_.ListType field.
	''' </summary>
	Public Function GetListTypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ListTypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's List_.ListType field.
	''' </summary>
	Public Sub SetListTypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ListTypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's List_.ListType field.
	''' </summary>
	Public Sub SetListTypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ListTypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's List_.ListName field.
	''' </summary>
	Public Function GetListNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ListNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's List_.ListName field.
	''' </summary>
	Public Function GetListNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ListNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's List_.ListName field.
	''' </summary>
	Public Sub SetListNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ListNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's List_.ListName field.
	''' </summary>
	Public Sub SetListNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ListNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's List_.ListRank field.
	''' </summary>
	Public Function GetListRankValue() As ColumnValue
		Return Me.GetValue(TableUtils.ListRankColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's List_.ListRank field.
	''' </summary>
	Public Function GetListRankFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ListRankColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's List_.ListRank field.
	''' </summary>
	Public Sub SetListRankFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ListRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's List_.ListRank field.
	''' </summary>
	Public Sub SetListRankFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ListRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's List_.ListRank field.
	''' </summary>
	Public Sub SetListRankFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ListRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's List_.ListRank field.
	''' </summary>
	Public Sub SetListRankFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ListRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's List_.ListRank field.
	''' </summary>
	Public Sub SetListRankFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ListRankColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's List_.ListValue field.
	''' </summary>
	Public Function GetListValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.ListValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's List_.ListValue field.
	''' </summary>
	Public Function GetListValueFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ListValueColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's List_.ListValue field.
	''' </summary>
	Public Sub SetListValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ListValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's List_.ListValue field.
	''' </summary>
	Public Sub SetListValueFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ListValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's List_.ListValue field.
	''' </summary>
	Public Sub SetListValueFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ListValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's List_.ListValue field.
	''' </summary>
	Public Sub SetListValueFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ListValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's List_.ListValue field.
	''' </summary>
	Public Sub SetListValueFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ListValueColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's List_.ListID field.
	''' </summary>
	Public Property ListID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ListIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ListIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ListIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ListIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ListIDDefault() As String
        Get
            Return TableUtils.ListIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's List_.ListType field.
	''' </summary>
	Public Property ListType() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ListTypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ListTypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ListTypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ListTypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ListTypeDefault() As String
        Get
            Return TableUtils.ListTypeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's List_.ListName field.
	''' </summary>
	Public Property ListName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ListNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ListNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ListNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ListNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ListNameDefault() As String
        Get
            Return TableUtils.ListNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's List_.ListRank field.
	''' </summary>
	Public Property ListRank() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ListRankColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ListRankColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ListRankSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ListRankColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ListRankDefault() As String
        Get
            Return TableUtils.ListRankColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's List_.ListValue field.
	''' </summary>
	Public Property ListValue() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ListValueColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ListValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ListValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ListValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ListValueDefault() As String
        Get
            Return TableUtils.ListValueColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
