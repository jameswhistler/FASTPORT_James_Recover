' This class is "generated" and will be overwritten.
' Your customizations should be made in V_HistoryRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_HistoryRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_HistoryView"></see> class.
''' </remarks>
''' <seealso cref="V_HistoryView"></seealso>
''' <seealso cref="V_HistoryRecord"></seealso>

<Serializable()> Public Class BaseV_HistoryRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_HistoryView = V_HistoryView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_HistoryRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_HistoryRec As V_HistoryRecord = CType(sender,V_HistoryRecord)
        Validate_Inserting()
        If Not V_HistoryRec Is Nothing AndAlso Not V_HistoryRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_HistoryRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_HistoryRec As V_HistoryRecord = CType(sender,V_HistoryRecord)
        Validate_Updating()
        If Not V_HistoryRec Is Nothing AndAlso Not V_HistoryRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_HistoryRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_HistoryRec As V_HistoryRecord = CType(sender,V_HistoryRecord)
        If Not V_HistoryRec Is Nothing AndAlso Not V_HistoryRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_History_.HistoryID field.
	''' </summary>
	Public Function GetHistoryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.HistoryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.HistoryID field.
	''' </summary>
	Public Function GetHistoryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HistoryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.EmployerID field.
	''' </summary>
	Public Function GetEmployerIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.EmployerID field.
	''' </summary>
	Public Function GetEmployerIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EmployerIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.EmployerID field.
	''' </summary>
	Public Sub SetEmployerIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.EmployerID field.
	''' </summary>
	Public Sub SetEmployerIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EmployerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.EmployerID field.
	''' </summary>
	Public Sub SetEmployerIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.EmployerID field.
	''' </summary>
	Public Sub SetEmployerIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.EmployerID field.
	''' </summary>
	Public Sub SetEmployerIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.EmployerName field.
	''' </summary>
	Public Function GetEmployerNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmployerNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.EmployerName field.
	''' </summary>
	Public Function GetEmployerNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmployerNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.EmployerName field.
	''' </summary>
	Public Sub SetEmployerNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmployerNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.EmployerName field.
	''' </summary>
	Public Sub SetEmployerNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmployerNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.HistoryHTML field.
	''' </summary>
	Public Function GetHistoryHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.HistoryHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.HistoryHTML field.
	''' </summary>
	Public Function GetHistoryHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.HistoryHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.HistoryHTML field.
	''' </summary>
	Public Sub SetHistoryHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HistoryHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.HistoryHTML field.
	''' </summary>
	Public Sub SetHistoryHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.ExpHTML field.
	''' </summary>
	Public Function GetExpHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExpHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.ExpHTML field.
	''' </summary>
	Public Function GetExpHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ExpHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.ExpHTML field.
	''' </summary>
	Public Sub SetExpHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExpHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.ExpHTML field.
	''' </summary>
	Public Sub SetExpHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExpHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.ExpItemsHTML field.
	''' </summary>
	Public Function GetExpItemsHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExpItemsHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.ExpItemsHTML field.
	''' </summary>
	Public Function GetExpItemsHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ExpItemsHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.ExpItemsHTML field.
	''' </summary>
	Public Sub SetExpItemsHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExpItemsHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.ExpItemsHTML field.
	''' </summary>
	Public Sub SetExpItemsHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExpItemsHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.StartMonthID field.
	''' </summary>
	Public Function GetStartMonthIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.StartMonthIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.StartMonthID field.
	''' </summary>
	Public Function GetStartMonthIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.StartMonthIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.StartMonthID field.
	''' </summary>
	Public Sub SetStartMonthIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StartMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.StartMonthID field.
	''' </summary>
	Public Sub SetStartMonthIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.StartMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.StartMonthID field.
	''' </summary>
	Public Sub SetStartMonthIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StartMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.StartMonthID field.
	''' </summary>
	Public Sub SetStartMonthIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StartMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.StartMonthID field.
	''' </summary>
	Public Sub SetStartMonthIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StartMonthIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.EndMonthID field.
	''' </summary>
	Public Function GetEndMonthIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EndMonthIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.EndMonthID field.
	''' </summary>
	Public Function GetEndMonthIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EndMonthIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.EndMonthID field.
	''' </summary>
	Public Sub SetEndMonthIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EndMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.EndMonthID field.
	''' </summary>
	Public Sub SetEndMonthIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EndMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.EndMonthID field.
	''' </summary>
	Public Sub SetEndMonthIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EndMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.EndMonthID field.
	''' </summary>
	Public Sub SetEndMonthIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EndMonthIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.EndMonthID field.
	''' </summary>
	Public Sub SetEndMonthIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EndMonthIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.Duration field.
	''' </summary>
	Public Function GetDurationValue() As ColumnValue
		Return Me.GetValue(TableUtils.DurationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.Duration field.
	''' </summary>
	Public Function GetDurationFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DurationColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.Duration field.
	''' </summary>
	Public Sub SetDurationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DurationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.Duration field.
	''' </summary>
	Public Sub SetDurationFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DurationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.EditButton field.
	''' </summary>
	Public Function GetEditButtonValue() As ColumnValue
		Return Me.GetValue(TableUtils.EditButtonColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.EditButton field.
	''' </summary>
	Public Function GetEditButtonFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EditButtonColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.EditButton field.
	''' </summary>
	Public Sub SetEditButtonFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EditButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.EditButton field.
	''' </summary>
	Public Sub SetEditButtonFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EditButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.DeleteButton field.
	''' </summary>
	Public Function GetDeleteButtonValue() As ColumnValue
		Return Me.GetValue(TableUtils.DeleteButtonColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_History_.DeleteButton field.
	''' </summary>
	Public Function GetDeleteButtonFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DeleteButtonColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.DeleteButton field.
	''' </summary>
	Public Sub SetDeleteButtonFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DeleteButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_History_.DeleteButton field.
	''' </summary>
	Public Sub SetDeleteButtonFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DeleteButtonColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_History_.HistoryID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_History_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_History_.EmployerID field.
	''' </summary>
	Public Property EmployerID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EmployerIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EmployerIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmployerIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmployerIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmployerIDDefault() As String
        Get
            Return TableUtils.EmployerIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_History_.EmployerName field.
	''' </summary>
	Public Property EmployerName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EmployerNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EmployerNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmployerNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmployerNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmployerNameDefault() As String
        Get
            Return TableUtils.EmployerNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_History_.HistoryHTML field.
	''' </summary>
	Public Property HistoryHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.HistoryHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.HistoryHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HistoryHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HistoryHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HistoryHTMLDefault() As String
        Get
            Return TableUtils.HistoryHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_History_.ExpHTML field.
	''' </summary>
	Public Property ExpHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ExpHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ExpHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExpHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExpHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExpHTMLDefault() As String
        Get
            Return TableUtils.ExpHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_History_.ExpItemsHTML field.
	''' </summary>
	Public Property ExpItemsHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ExpItemsHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ExpItemsHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExpItemsHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExpItemsHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExpItemsHTMLDefault() As String
        Get
            Return TableUtils.ExpItemsHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_History_.StartMonthID field.
	''' </summary>
	Public Property StartMonthID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.StartMonthIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.StartMonthIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property StartMonthIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.StartMonthIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property StartMonthIDDefault() As String
        Get
            Return TableUtils.StartMonthIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_History_.EndMonthID field.
	''' </summary>
	Public Property EndMonthID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EndMonthIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EndMonthIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EndMonthIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EndMonthIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EndMonthIDDefault() As String
        Get
            Return TableUtils.EndMonthIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_History_.Duration field.
	''' </summary>
	Public Property Duration() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DurationColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DurationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DurationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DurationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DurationDefault() As String
        Get
            Return TableUtils.DurationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_History_.EditButton field.
	''' </summary>
	Public Property EditButton() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EditButtonColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EditButtonColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EditButtonSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EditButtonColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EditButtonDefault() As String
        Get
            Return TableUtils.EditButtonColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_History_.DeleteButton field.
	''' </summary>
	Public Property DeleteButton() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DeleteButtonColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DeleteButtonColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DeleteButtonSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DeleteButtonColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DeleteButtonDefault() As String
        Get
            Return TableUtils.DeleteButtonColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
