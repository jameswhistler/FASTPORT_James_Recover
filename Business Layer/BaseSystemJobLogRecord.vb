' This class is "generated" and will be overwritten.
' Your customizations should be made in SystemJobLogRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="SystemJobLogRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="SystemJobLogTable"></see> class.
''' </remarks>
''' <seealso cref="SystemJobLogTable"></seealso>
''' <seealso cref="SystemJobLogRecord"></seealso>

<Serializable()> Public Class BaseSystemJobLogRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As SystemJobLogTable = SystemJobLogTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub SystemJobLogRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim SystemJobLogRec As SystemJobLogRecord = CType(sender,SystemJobLogRecord)
        Validate_Inserting()
        If Not SystemJobLogRec Is Nothing AndAlso Not SystemJobLogRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub SystemJobLogRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim SystemJobLogRec As SystemJobLogRecord = CType(sender,SystemJobLogRecord)
        Validate_Updating()
        If Not SystemJobLogRec Is Nothing AndAlso Not SystemJobLogRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub SystemJobLogRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim SystemJobLogRec As SystemJobLogRecord = CType(sender,SystemJobLogRecord)
        If Not SystemJobLogRec Is Nothing AndAlso Not SystemJobLogRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's SystemJobLog_.JobLogID field.
	''' </summary>
	Public Function GetJobLogIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.JobLogIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJobLog_.JobLogID field.
	''' </summary>
	Public Function GetJobLogIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.JobLogIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJobLog_.JobID field.
	''' </summary>
	Public Function GetJobIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.JobIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJobLog_.JobID field.
	''' </summary>
	Public Function GetJobIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.JobIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJobLog_.JobID field.
	''' </summary>
	Public Sub SetJobIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.JobIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJobLog_.JobID field.
	''' </summary>
	Public Sub SetJobIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.JobIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJobLog_.JobID field.
	''' </summary>
	Public Sub SetJobIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.JobIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJobLog_.JobID field.
	''' </summary>
	Public Sub SetJobIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.JobIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJobLog_.JobID field.
	''' </summary>
	Public Sub SetJobIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.JobIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJobLog_.JobStarted field.
	''' </summary>
	Public Function GetJobStartedValue() As ColumnValue
		Return Me.GetValue(TableUtils.JobStartedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJobLog_.JobStarted field.
	''' </summary>
	Public Function GetJobStartedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.JobStartedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJobLog_.JobStarted field.
	''' </summary>
	Public Sub SetJobStartedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.JobStartedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJobLog_.JobStarted field.
	''' </summary>
	Public Sub SetJobStartedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.JobStartedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJobLog_.JobStarted field.
	''' </summary>
	Public Sub SetJobStartedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.JobStartedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJobLog_.JobCompleted field.
	''' </summary>
	Public Function GetJobCompletedValue() As ColumnValue
		Return Me.GetValue(TableUtils.JobCompletedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJobLog_.JobCompleted field.
	''' </summary>
	Public Function GetJobCompletedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.JobCompletedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJobLog_.JobCompleted field.
	''' </summary>
	Public Sub SetJobCompletedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.JobCompletedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJobLog_.JobCompleted field.
	''' </summary>
	Public Sub SetJobCompletedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.JobCompletedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJobLog_.JobCompleted field.
	''' </summary>
	Public Sub SetJobCompletedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.JobCompletedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJobLog_.LogMessage field.
	''' </summary>
	Public Function GetLogMessageValue() As ColumnValue
		Return Me.GetValue(TableUtils.LogMessageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJobLog_.LogMessage field.
	''' </summary>
	Public Function GetLogMessageFieldValue() As String
		Return CType(Me.GetValue(TableUtils.LogMessageColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJobLog_.LogMessage field.
	''' </summary>
	Public Sub SetLogMessageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LogMessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJobLog_.LogMessage field.
	''' </summary>
	Public Sub SetLogMessageFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LogMessageColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SystemJobLog_.JobLogID field.
	''' </summary>
	Public Property JobLogID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.JobLogIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.JobLogIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property JobLogIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.JobLogIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property JobLogIDDefault() As String
        Get
            Return TableUtils.JobLogIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SystemJobLog_.JobID field.
	''' </summary>
	Public Property JobID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.JobIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.JobIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property JobIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.JobIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property JobIDDefault() As String
        Get
            Return TableUtils.JobIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SystemJobLog_.JobStarted field.
	''' </summary>
	Public Property JobStarted() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.JobStartedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.JobStartedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property JobStartedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.JobStartedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property JobStartedDefault() As String
        Get
            Return TableUtils.JobStartedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SystemJobLog_.JobCompleted field.
	''' </summary>
	Public Property JobCompleted() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.JobCompletedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.JobCompletedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property JobCompletedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.JobCompletedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property JobCompletedDefault() As String
        Get
            Return TableUtils.JobCompletedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SystemJobLog_.LogMessage field.
	''' </summary>
	Public Property LogMessage() As String
		Get 
			Return CType(Me.GetValue(TableUtils.LogMessageColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.LogMessageColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LogMessageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LogMessageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LogMessageDefault() As String
        Get
            Return TableUtils.LogMessageColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
