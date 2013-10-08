' This class is "generated" and will be overwritten.
' Your customizations should be made in GlobalRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="GlobalRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="GlobalTable"></see> class.
''' </remarks>
''' <seealso cref="GlobalTable"></seealso>
''' <seealso cref="GlobalRecord"></seealso>

<Serializable()> Public Class BaseGlobalRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As GlobalTable = GlobalTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub GlobalRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim GlobalRec As GlobalRecord = CType(sender,GlobalRecord)
        Validate_Inserting()
        If Not GlobalRec Is Nothing AndAlso Not GlobalRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub GlobalRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim GlobalRec As GlobalRecord = CType(sender,GlobalRecord)
        Validate_Updating()
        If Not GlobalRec Is Nothing AndAlso Not GlobalRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub GlobalRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim GlobalRec As GlobalRecord = CType(sender,GlobalRecord)
        If Not GlobalRec Is Nothing AndAlso Not GlobalRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Global_.GlobalID field.
	''' </summary>
	Public Function GetGlobalIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.GlobalIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Global_.GlobalID field.
	''' </summary>
	Public Function GetGlobalIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.GlobalIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Global_.GlobalName field.
	''' </summary>
	Public Function GetGlobalNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.GlobalNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Global_.GlobalName field.
	''' </summary>
	Public Function GetGlobalNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.GlobalNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Global_.GlobalName field.
	''' </summary>
	Public Sub SetGlobalNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GlobalNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Global_.GlobalName field.
	''' </summary>
	Public Sub SetGlobalNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GlobalNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Global_.GlobalDescription field.
	''' </summary>
	Public Function GetGlobalDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.GlobalDescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Global_.GlobalDescription field.
	''' </summary>
	Public Function GetGlobalDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.GlobalDescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Global_.GlobalDescription field.
	''' </summary>
	Public Sub SetGlobalDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GlobalDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Global_.GlobalDescription field.
	''' </summary>
	Public Sub SetGlobalDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GlobalDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Global_.GlobalFile field.
	''' </summary>
	Public Function GetGlobalFileValue() As ColumnValue
		Return Me.GetValue(TableUtils.GlobalFileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Global_.GlobalFile field.
	''' </summary>
	Public Function GetGlobalFileFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.GlobalFileColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Global_.GlobalFile field.
	''' </summary>
	Public Sub SetGlobalFileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GlobalFileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Global_.GlobalFile field.
	''' </summary>
	Public Sub SetGlobalFileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.GlobalFileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Global_.GlobalFile field.
	''' </summary>
	Public Sub SetGlobalFileFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GlobalFileColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Global_.GlobalValue field.
	''' </summary>
	Public Function GetGlobalValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.GlobalValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Global_.GlobalValue field.
	''' </summary>
	Public Function GetGlobalValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.GlobalValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Global_.GlobalValue field.
	''' </summary>
	Public Sub SetGlobalValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GlobalValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Global_.GlobalValue field.
	''' </summary>
	Public Sub SetGlobalValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GlobalValueColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Global_.GlobalID field.
	''' </summary>
	Public Property GlobalID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.GlobalIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.GlobalIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GlobalIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GlobalIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GlobalIDDefault() As String
        Get
            Return TableUtils.GlobalIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Global_.GlobalName field.
	''' </summary>
	Public Property GlobalName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.GlobalNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.GlobalNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GlobalNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GlobalNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GlobalNameDefault() As String
        Get
            Return TableUtils.GlobalNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Global_.GlobalDescription field.
	''' </summary>
	Public Property GlobalDescription() As String
		Get 
			Return CType(Me.GetValue(TableUtils.GlobalDescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.GlobalDescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GlobalDescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GlobalDescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GlobalDescriptionDefault() As String
        Get
            Return TableUtils.GlobalDescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Global_.GlobalFile field.
	''' </summary>
	Public Property GlobalFile() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.GlobalFileColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.GlobalFileColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GlobalFileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GlobalFileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GlobalFileDefault() As String
        Get
            Return TableUtils.GlobalFileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Global_.GlobalValue field.
	''' </summary>
	Public Property GlobalValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.GlobalValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.GlobalValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GlobalValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GlobalValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GlobalValueDefault() As String
        Get
            Return TableUtils.GlobalValueColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
