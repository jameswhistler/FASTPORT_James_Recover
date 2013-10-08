' This class is "generated" and will be overwritten.
' Your customizations should be made in SprocLogRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="SprocLogRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="SprocLogTable"></see> class.
''' </remarks>
''' <seealso cref="SprocLogTable"></seealso>
''' <seealso cref="SprocLogRecord"></seealso>

<Serializable()> Public Class BaseSprocLogRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As SprocLogTable = SprocLogTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub SprocLogRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim SprocLogRec As SprocLogRecord = CType(sender,SprocLogRecord)
        Validate_Inserting()
        If Not SprocLogRec Is Nothing AndAlso Not SprocLogRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub SprocLogRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim SprocLogRec As SprocLogRecord = CType(sender,SprocLogRecord)
        Validate_Updating()
        If Not SprocLogRec Is Nothing AndAlso Not SprocLogRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub SprocLogRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim SprocLogRec As SprocLogRecord = CType(sender,SprocLogRecord)
        If Not SprocLogRec Is Nothing AndAlso Not SprocLogRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's SprocLog_.SprocLogID field.
	''' </summary>
	Public Function GetSprocLogIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SprocLogIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SprocLog_.SprocLogID field.
	''' </summary>
	Public Function GetSprocLogIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SprocLogIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SprocLog_.LoggedAt field.
	''' </summary>
	Public Function GetLoggedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.LoggedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SprocLog_.LoggedAt field.
	''' </summary>
	Public Function GetLoggedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.LoggedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SprocLog_.LoggedAt field.
	''' </summary>
	Public Sub SetLoggedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LoggedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SprocLog_.LoggedAt field.
	''' </summary>
	Public Sub SetLoggedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LoggedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SprocLog_.LoggedAt field.
	''' </summary>
	Public Sub SetLoggedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LoggedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SprocLog_.SprocName field.
	''' </summary>
	Public Function GetSprocNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SprocNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SprocLog_.SprocName field.
	''' </summary>
	Public Function GetSprocNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SprocNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SprocLog_.SprocName field.
	''' </summary>
	Public Sub SetSprocNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SprocNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SprocLog_.SprocName field.
	''' </summary>
	Public Sub SetSprocNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SprocNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SprocLog_.Params field.
	''' </summary>
	Public Function GetParams0Value() As ColumnValue
		Return Me.GetValue(TableUtils.Params0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SprocLog_.Params field.
	''' </summary>
	Public Function GetParams0FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Params0Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SprocLog_.Params field.
	''' </summary>
	Public Sub SetParams0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Params0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SprocLog_.Params field.
	''' </summary>
	Public Sub SetParams0FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Params0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SprocLog_.JoinString field.
	''' </summary>
	Public Function GetJoinStringValue() As ColumnValue
		Return Me.GetValue(TableUtils.JoinStringColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SprocLog_.JoinString field.
	''' </summary>
	Public Function GetJoinStringFieldValue() As String
		Return CType(Me.GetValue(TableUtils.JoinStringColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SprocLog_.JoinString field.
	''' </summary>
	Public Sub SetJoinStringFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.JoinStringColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SprocLog_.JoinString field.
	''' </summary>
	Public Sub SetJoinStringFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.JoinStringColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SprocLog_.WhereString field.
	''' </summary>
	Public Function GetWhereStringValue() As ColumnValue
		Return Me.GetValue(TableUtils.WhereStringColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SprocLog_.WhereString field.
	''' </summary>
	Public Function GetWhereStringFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WhereStringColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SprocLog_.WhereString field.
	''' </summary>
	Public Sub SetWhereStringFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WhereStringColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SprocLog_.WhereString field.
	''' </summary>
	Public Sub SetWhereStringFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WhereStringColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SprocLog_.SortString field.
	''' </summary>
	Public Function GetSortStringValue() As ColumnValue
		Return Me.GetValue(TableUtils.SortStringColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SprocLog_.SortString field.
	''' </summary>
	Public Function GetSortStringFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SortStringColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SprocLog_.SortString field.
	''' </summary>
	Public Sub SetSortStringFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SortStringColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SprocLog_.SortString field.
	''' </summary>
	Public Sub SetSortStringFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SortStringColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SprocLog_.SprocLogID field.
	''' </summary>
	Public Property SprocLogID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SprocLogIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SprocLogIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SprocLogIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SprocLogIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SprocLogIDDefault() As String
        Get
            Return TableUtils.SprocLogIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SprocLog_.LoggedAt field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SprocLog_.SprocName field.
	''' </summary>
	Public Property SprocName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SprocNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SprocNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SprocNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SprocNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SprocNameDefault() As String
        Get
            Return TableUtils.SprocNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SprocLog_.Params field.
	''' </summary>
	Public Property Params0() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Params0Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Params0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Params0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Params0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Params0Default() As String
        Get
            Return TableUtils.Params0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SprocLog_.JoinString field.
	''' </summary>
	Public Property JoinString() As String
		Get 
			Return CType(Me.GetValue(TableUtils.JoinStringColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.JoinStringColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property JoinStringSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.JoinStringColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property JoinStringDefault() As String
        Get
            Return TableUtils.JoinStringColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SprocLog_.WhereString field.
	''' </summary>
	Public Property WhereString() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WhereStringColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WhereStringColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WhereStringSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WhereStringColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WhereStringDefault() As String
        Get
            Return TableUtils.WhereStringColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SprocLog_.SortString field.
	''' </summary>
	Public Property SortString() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SortStringColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SortStringColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SortStringSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SortStringColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SortStringDefault() As String
        Get
            Return TableUtils.SortStringColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
