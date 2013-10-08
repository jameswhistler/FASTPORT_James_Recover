' This class is "generated" and will be overwritten.
' Your customizations should be made in CalendarRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="CalendarRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="CalendarTable"></see> class.
''' </remarks>
''' <seealso cref="CalendarTable"></seealso>
''' <seealso cref="CalendarRecord"></seealso>

<Serializable()> Public Class BaseCalendarRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As CalendarTable = CalendarTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub CalendarRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim CalendarRec As CalendarRecord = CType(sender,CalendarRecord)
        Validate_Inserting()
        If Not CalendarRec Is Nothing AndAlso Not CalendarRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub CalendarRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim CalendarRec As CalendarRecord = CType(sender,CalendarRecord)
        Validate_Updating()
        If Not CalendarRec Is Nothing AndAlso Not CalendarRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub CalendarRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim CalendarRec As CalendarRecord = CType(sender,CalendarRecord)
        If Not CalendarRec Is Nothing AndAlso Not CalendarRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Calendar_.CalID field.
	''' </summary>
	Public Function GetCalIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CalIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Calendar_.CalID field.
	''' </summary>
	Public Function GetCalIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CalIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Calendar_.CalType field.
	''' </summary>
	Public Function GetCalTypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.CalTypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Calendar_.CalType field.
	''' </summary>
	Public Function GetCalTypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CalTypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Calendar_.CalType field.
	''' </summary>
	Public Sub SetCalTypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CalTypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Calendar_.CalType field.
	''' </summary>
	Public Sub SetCalTypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CalTypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Calendar_.CalDate field.
	''' </summary>
	Public Function GetCalDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.CalDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Calendar_.CalDate field.
	''' </summary>
	Public Function GetCalDateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CalDateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Calendar_.CalDate field.
	''' </summary>
	Public Sub SetCalDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CalDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Calendar_.CalDate field.
	''' </summary>
	Public Sub SetCalDateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CalDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Calendar_.CalDate field.
	''' </summary>
	Public Sub SetCalDateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CalDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Calendar_.CountryID field.
	''' </summary>
	Public Function GetCountryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CountryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Calendar_.CountryID field.
	''' </summary>
	Public Function GetCountryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CountryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Calendar_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Calendar_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Calendar_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Calendar_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Calendar_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Calendar_.Holiday field.
	''' </summary>
	Public Function GetHolidayValue() As ColumnValue
		Return Me.GetValue(TableUtils.HolidayColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Calendar_.Holiday field.
	''' </summary>
	Public Function GetHolidayFieldValue() As String
		Return CType(Me.GetValue(TableUtils.HolidayColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Calendar_.Holiday field.
	''' </summary>
	Public Sub SetHolidayFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HolidayColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Calendar_.Holiday field.
	''' </summary>
	Public Sub SetHolidayFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HolidayColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Calendar_.HolType field.
	''' </summary>
	Public Function GetHolTypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.HolTypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Calendar_.HolType field.
	''' </summary>
	Public Function GetHolTypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.HolTypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Calendar_.HolType field.
	''' </summary>
	Public Sub SetHolTypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HolTypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Calendar_.HolType field.
	''' </summary>
	Public Sub SetHolTypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HolTypeColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Calendar_.CalID field.
	''' </summary>
	Public Property CalID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CalIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CalIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CalIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CalIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CalIDDefault() As String
        Get
            Return TableUtils.CalIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Calendar_.CalType field.
	''' </summary>
	Public Property CalType() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CalTypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CalTypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CalTypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CalTypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CalTypeDefault() As String
        Get
            Return TableUtils.CalTypeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Calendar_.CalDate field.
	''' </summary>
	Public Property CalDate() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.CalDateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CalDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CalDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CalDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CalDateDefault() As String
        Get
            Return TableUtils.CalDateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Calendar_.CountryID field.
	''' </summary>
	Public Property CountryID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CountryIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CountryIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CountryIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CountryIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CountryIDDefault() As String
        Get
            Return TableUtils.CountryIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Calendar_.Holiday field.
	''' </summary>
	Public Property Holiday() As String
		Get 
			Return CType(Me.GetValue(TableUtils.HolidayColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.HolidayColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HolidaySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HolidayColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HolidayDefault() As String
        Get
            Return TableUtils.HolidayColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Calendar_.HolType field.
	''' </summary>
	Public Property HolType() As String
		Get 
			Return CType(Me.GetValue(TableUtils.HolTypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.HolTypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HolTypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HolTypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HolTypeDefault() As String
        Get
            Return TableUtils.HolTypeColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
