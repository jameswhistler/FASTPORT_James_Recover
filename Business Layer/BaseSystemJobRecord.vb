' This class is "generated" and will be overwritten.
' Your customizations should be made in SystemJobRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="SystemJobRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="SystemJobTable"></see> class.
''' </remarks>
''' <seealso cref="SystemJobTable"></seealso>
''' <seealso cref="SystemJobRecord"></seealso>

<Serializable()> Public Class BaseSystemJobRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As SystemJobTable = SystemJobTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub SystemJobRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim SystemJobRec As SystemJobRecord = CType(sender,SystemJobRecord)
        Validate_Inserting()
        If Not SystemJobRec Is Nothing AndAlso Not SystemJobRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub SystemJobRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim SystemJobRec As SystemJobRecord = CType(sender,SystemJobRecord)
        Validate_Updating()
        If Not SystemJobRec Is Nothing AndAlso Not SystemJobRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub SystemJobRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim SystemJobRec As SystemJobRecord = CType(sender,SystemJobRecord)
        If Not SystemJobRec Is Nothing AndAlso Not SystemJobRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.JobID field.
	''' </summary>
	Public Function GetJobIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.JobIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.JobID field.
	''' </summary>
	Public Function GetJobIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.JobIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.SprocName field.
	''' </summary>
	Public Function GetSprocNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SprocNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.SprocName field.
	''' </summary>
	Public Function GetSprocNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SprocNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.SprocName field.
	''' </summary>
	Public Sub SetSprocNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SprocNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.SprocName field.
	''' </summary>
	Public Sub SetSprocNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SprocNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.HourToRun field.
	''' </summary>
	Public Function GetHourToRunValue() As ColumnValue
		Return Me.GetValue(TableUtils.HourToRunColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.HourToRun field.
	''' </summary>
	Public Function GetHourToRunFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.HourToRunColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.HourToRun field.
	''' </summary>
	Public Sub SetHourToRunFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HourToRunColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.HourToRun field.
	''' </summary>
	Public Sub SetHourToRunFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HourToRunColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.HourToRun field.
	''' </summary>
	Public Sub SetHourToRunFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HourToRunColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.Param1 field.
	''' </summary>
	Public Function GetParam1Value() As ColumnValue
		Return Me.GetValue(TableUtils.Param1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.Param1 field.
	''' </summary>
	Public Function GetParam1FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Param1Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.Param1 field.
	''' </summary>
	Public Sub SetParam1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Param1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.Param1 field.
	''' </summary>
	Public Sub SetParam1FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Param1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.Param2 field.
	''' </summary>
	Public Function GetParam2Value() As ColumnValue
		Return Me.GetValue(TableUtils.Param2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.Param2 field.
	''' </summary>
	Public Function GetParam2FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Param2Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.Param2 field.
	''' </summary>
	Public Sub SetParam2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Param2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.Param2 field.
	''' </summary>
	Public Sub SetParam2FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Param2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.Param3 field.
	''' </summary>
	Public Function GetParam3Value() As ColumnValue
		Return Me.GetValue(TableUtils.Param3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.Param3 field.
	''' </summary>
	Public Function GetParam3FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Param3Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.Param3 field.
	''' </summary>
	Public Sub SetParam3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Param3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.Param3 field.
	''' </summary>
	Public Sub SetParam3FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Param3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.Param4 field.
	''' </summary>
	Public Function GetParam4Value() As ColumnValue
		Return Me.GetValue(TableUtils.Param4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.Param4 field.
	''' </summary>
	Public Function GetParam4FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Param4Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.Param4 field.
	''' </summary>
	Public Sub SetParam4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Param4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.Param4 field.
	''' </summary>
	Public Sub SetParam4FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Param4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.Param5 field.
	''' </summary>
	Public Function GetParam5Value() As ColumnValue
		Return Me.GetValue(TableUtils.Param5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.Param5 field.
	''' </summary>
	Public Function GetParam5FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Param5Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.Param5 field.
	''' </summary>
	Public Sub SetParam5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Param5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.Param5 field.
	''' </summary>
	Public Sub SetParam5FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Param5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.Param6 field.
	''' </summary>
	Public Function GetParam6Value() As ColumnValue
		Return Me.GetValue(TableUtils.Param6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SystemJob_.Param6 field.
	''' </summary>
	Public Function GetParam6FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Param6Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.Param6 field.
	''' </summary>
	Public Sub SetParam6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Param6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SystemJob_.Param6 field.
	''' </summary>
	Public Sub SetParam6FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Param6Column)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SystemJob_.JobID field.
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
	''' This is a convenience property that provides direct access to the value of the record's SystemJob_.SprocName field.
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
	''' This is a convenience property that provides direct access to the value of the record's SystemJob_.HourToRun field.
	''' </summary>
	Public Property HourToRun() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.HourToRunColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HourToRunColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HourToRunSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HourToRunColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HourToRunDefault() As String
        Get
            Return TableUtils.HourToRunColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SystemJob_.Param1 field.
	''' </summary>
	Public Property Param1() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Param1Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Param1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Param1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Param1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Param1Default() As String
        Get
            Return TableUtils.Param1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SystemJob_.Param2 field.
	''' </summary>
	Public Property Param2() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Param2Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Param2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Param2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Param2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Param2Default() As String
        Get
            Return TableUtils.Param2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SystemJob_.Param3 field.
	''' </summary>
	Public Property Param3() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Param3Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Param3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Param3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Param3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Param3Default() As String
        Get
            Return TableUtils.Param3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SystemJob_.Param4 field.
	''' </summary>
	Public Property Param4() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Param4Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Param4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Param4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Param4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Param4Default() As String
        Get
            Return TableUtils.Param4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SystemJob_.Param5 field.
	''' </summary>
	Public Property Param5() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Param5Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Param5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Param5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Param5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Param5Default() As String
        Get
            Return TableUtils.Param5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SystemJob_.Param6 field.
	''' </summary>
	Public Property Param6() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Param6Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Param6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Param6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Param6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Param6Default() As String
        Get
            Return TableUtils.Param6Column.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
