' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyRepsRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PartyRepsRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="PartyRepsTable"></see> class.
''' </remarks>
''' <seealso cref="PartyRepsTable"></seealso>
''' <seealso cref="PartyRepsRecord"></seealso>

<Serializable()> Public Class BasePartyRepsRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As PartyRepsTable = PartyRepsTable.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub PartyRepsRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim PartyRepsRec As PartyRepsRecord = CType(sender,PartyRepsRecord)
        If Not PartyRepsRec Is Nothing AndAlso Not PartyRepsRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub PartyRepsRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim PartyRepsRec As PartyRepsRecord = CType(sender,PartyRepsRecord)
        Validate_Inserting()
        If Not PartyRepsRec Is Nothing AndAlso Not PartyRepsRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's PartyReps_.PartyRepsID field.
	''' </summary>
	Public Function GetPartyRepsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyRepsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyReps_.PartyRepsID field.
	''' </summary>
	Public Function GetPartyRepsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyRepsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyReps_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyReps_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyReps_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyReps_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyReps_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyReps_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyReps_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyReps_.RepID field.
	''' </summary>
	Public Function GetRepIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RepIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyReps_.RepID field.
	''' </summary>
	Public Function GetRepIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RepIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyReps_.RepID field.
	''' </summary>
	Public Sub SetRepIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyReps_.RepID field.
	''' </summary>
	Public Sub SetRepIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyReps_.RepID field.
	''' </summary>
	Public Sub SetRepIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyReps_.RepID field.
	''' </summary>
	Public Sub SetRepIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyReps_.RepID field.
	''' </summary>
	Public Sub SetRepIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RepIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyReps_.ReppedOn field.
	''' </summary>
	Public Function GetReppedOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReppedOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyReps_.ReppedOn field.
	''' </summary>
	Public Function GetReppedOnFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.ReppedOnColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyReps_.ReppedOn field.
	''' </summary>
	Public Sub SetReppedOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReppedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyReps_.ReppedOn field.
	''' </summary>
	Public Sub SetReppedOnFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ReppedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyReps_.ReppedOn field.
	''' </summary>
	Public Sub SetReppedOnFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReppedOnColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyReps_.PartyRepsID field.
	''' </summary>
	Public Property PartyRepsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PartyRepsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PartyRepsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PartyRepsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PartyRepsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PartyRepsIDDefault() As String
        Get
            Return TableUtils.PartyRepsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyReps_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyReps_.RepID field.
	''' </summary>
	Public Property RepID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RepIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RepIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RepIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RepIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RepIDDefault() As String
        Get
            Return TableUtils.RepIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyReps_.ReppedOn field.
	''' </summary>
	Public Property ReppedOn() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.ReppedOnColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ReppedOnColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReppedOnSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReppedOnColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReppedOnDefault() As String
        Get
            Return TableUtils.ReppedOnColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
