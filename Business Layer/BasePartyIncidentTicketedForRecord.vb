' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyIncidentTicketedForRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PartyIncidentTicketedForRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="PartyIncidentTicketedForTable"></see> class.
''' </remarks>
''' <seealso cref="PartyIncidentTicketedForTable"></seealso>
''' <seealso cref="PartyIncidentTicketedForRecord"></seealso>

<Serializable()> Public Class BasePartyIncidentTicketedForRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As PartyIncidentTicketedForTable = PartyIncidentTicketedForTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub PartyIncidentTicketedForRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim PartyIncidentTicketedForRec As PartyIncidentTicketedForRecord = CType(sender,PartyIncidentTicketedForRecord)
        Validate_Inserting()
        If Not PartyIncidentTicketedForRec Is Nothing AndAlso Not PartyIncidentTicketedForRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub PartyIncidentTicketedForRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim PartyIncidentTicketedForRec As PartyIncidentTicketedForRecord = CType(sender,PartyIncidentTicketedForRecord)
        Validate_Updating()
        If Not PartyIncidentTicketedForRec Is Nothing AndAlso Not PartyIncidentTicketedForRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub PartyIncidentTicketedForRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim PartyIncidentTicketedForRec As PartyIncidentTicketedForRecord = CType(sender,PartyIncidentTicketedForRecord)
        If Not PartyIncidentTicketedForRec Is Nothing AndAlso Not PartyIncidentTicketedForRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's PartyIncidentTicketedFor_.TicketedID field.
	''' </summary>
	Public Function GetTicketedIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TicketedIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncidentTicketedFor_.TicketedID field.
	''' </summary>
	Public Function GetTicketedIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TicketedIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncidentTicketedFor_.IncidentID field.
	''' </summary>
	Public Function GetIncidentIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.IncidentIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncidentTicketedFor_.IncidentID field.
	''' </summary>
	Public Function GetIncidentIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.IncidentIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.IncidentID field.
	''' </summary>
	Public Sub SetIncidentIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IncidentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.IncidentID field.
	''' </summary>
	Public Sub SetIncidentIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IncidentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.IncidentID field.
	''' </summary>
	Public Sub SetIncidentIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IncidentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.IncidentID field.
	''' </summary>
	Public Sub SetIncidentIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IncidentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.IncidentID field.
	''' </summary>
	Public Sub SetIncidentIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IncidentIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncidentTicketedFor_.TicketedForID field.
	''' </summary>
	Public Function GetTicketedForIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TicketedForIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncidentTicketedFor_.TicketedForID field.
	''' </summary>
	Public Function GetTicketedForIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TicketedForIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.TicketedForID field.
	''' </summary>
	Public Sub SetTicketedForIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TicketedForIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.TicketedForID field.
	''' </summary>
	Public Sub SetTicketedForIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TicketedForIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.TicketedForID field.
	''' </summary>
	Public Sub SetTicketedForIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketedForIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.TicketedForID field.
	''' </summary>
	Public Sub SetTicketedForIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketedForIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.TicketedForID field.
	''' </summary>
	Public Sub SetTicketedForIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketedForIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncidentTicketedFor_.Speed field.
	''' </summary>
	Public Function GetSpeedValue() As ColumnValue
		Return Me.GetValue(TableUtils.SpeedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncidentTicketedFor_.Speed field.
	''' </summary>
	Public Function GetSpeedFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SpeedColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.Speed field.
	''' </summary>
	Public Sub SetSpeedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SpeedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.Speed field.
	''' </summary>
	Public Sub SetSpeedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SpeedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.Speed field.
	''' </summary>
	Public Sub SetSpeedFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SpeedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.Speed field.
	''' </summary>
	Public Sub SetSpeedFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SpeedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.Speed field.
	''' </summary>
	Public Sub SetSpeedFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SpeedColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncidentTicketedFor_.Limit field.
	''' </summary>
	Public Function GetLimitValue() As ColumnValue
		Return Me.GetValue(TableUtils.LimitColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyIncidentTicketedFor_.Limit field.
	''' </summary>
	Public Function GetLimitFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.LimitColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.Limit field.
	''' </summary>
	Public Sub SetLimitFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LimitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.Limit field.
	''' </summary>
	Public Sub SetLimitFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LimitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.Limit field.
	''' </summary>
	Public Sub SetLimitFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LimitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.Limit field.
	''' </summary>
	Public Sub SetLimitFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LimitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyIncidentTicketedFor_.Limit field.
	''' </summary>
	Public Sub SetLimitFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LimitColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncidentTicketedFor_.TicketedID field.
	''' </summary>
	Public Property TicketedID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TicketedIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TicketedIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TicketedIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TicketedIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TicketedIDDefault() As String
        Get
            Return TableUtils.TicketedIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncidentTicketedFor_.IncidentID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyIncidentTicketedFor_.TicketedForID field.
	''' </summary>
	Public Property TicketedForID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TicketedForIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TicketedForIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TicketedForIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TicketedForIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TicketedForIDDefault() As String
        Get
            Return TableUtils.TicketedForIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncidentTicketedFor_.Speed field.
	''' </summary>
	Public Property Speed() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SpeedColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SpeedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SpeedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SpeedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SpeedDefault() As String
        Get
            Return TableUtils.SpeedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyIncidentTicketedFor_.Limit field.
	''' </summary>
	Public Property Limit() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.LimitColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LimitColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LimitSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LimitColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LimitDefault() As String
        Get
            Return TableUtils.LimitColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
