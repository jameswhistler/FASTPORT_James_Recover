' This class is "generated" and will be overwritten.
' Your customizations should be made in RoleRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="RoleRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="RoleTable"></see> class.
''' </remarks>
''' <seealso cref="RoleTable"></seealso>
''' <seealso cref="RoleRecord"></seealso>

<Serializable()> Public Class BaseRoleRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As RoleTable = RoleTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub RoleRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim RoleRec As RoleRecord = CType(sender,RoleRecord)
        Validate_Inserting()
        If Not RoleRec Is Nothing AndAlso Not RoleRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub RoleRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim RoleRec As RoleRecord = CType(sender,RoleRecord)
        Validate_Updating()
        If Not RoleRec Is Nothing AndAlso Not RoleRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub RoleRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim RoleRec As RoleRecord = CType(sender,RoleRecord)
        If Not RoleRec Is Nothing AndAlso Not RoleRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Role_.RoleID field.
	''' </summary>
	Public Function GetRoleIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RoleIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Role_.RoleID field.
	''' </summary>
	Public Function GetRoleIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RoleIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Role_.GeneralRoleID field.
	''' </summary>
	Public Function GetGeneralRoleIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.GeneralRoleIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Role_.GeneralRoleID field.
	''' </summary>
	Public Function GetGeneralRoleIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.GeneralRoleIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.GeneralRoleID field.
	''' </summary>
	Public Sub SetGeneralRoleIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GeneralRoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.GeneralRoleID field.
	''' </summary>
	Public Sub SetGeneralRoleIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.GeneralRoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.GeneralRoleID field.
	''' </summary>
	Public Sub SetGeneralRoleIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GeneralRoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.GeneralRoleID field.
	''' </summary>
	Public Sub SetGeneralRoleIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GeneralRoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.GeneralRoleID field.
	''' </summary>
	Public Sub SetGeneralRoleIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GeneralRoleIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Role_.RoleTypeID field.
	''' </summary>
	Public Function GetRoleTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RoleTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Role_.RoleTypeID field.
	''' </summary>
	Public Function GetRoleTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RoleTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.RoleTypeID field.
	''' </summary>
	Public Sub SetRoleTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RoleTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.RoleTypeID field.
	''' </summary>
	Public Sub SetRoleTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RoleTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.RoleTypeID field.
	''' </summary>
	Public Sub SetRoleTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.RoleTypeID field.
	''' </summary>
	Public Sub SetRoleTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.RoleTypeID field.
	''' </summary>
	Public Sub SetRoleTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Role_.Role field.
	''' </summary>
	Public Function GetRoleValue() As ColumnValue
		Return Me.GetValue(TableUtils.RoleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Role_.Role field.
	''' </summary>
	Public Function GetRoleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.RoleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.Role field.
	''' </summary>
	Public Sub SetRoleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RoleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.Role field.
	''' </summary>
	Public Sub SetRoleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Role_.RoleDescription field.
	''' </summary>
	Public Function GetRoleDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.RoleDescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Role_.RoleDescription field.
	''' </summary>
	Public Function GetRoleDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.RoleDescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.RoleDescription field.
	''' </summary>
	Public Sub SetRoleDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RoleDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.RoleDescription field.
	''' </summary>
	Public Sub SetRoleDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Role_.RoleRank field.
	''' </summary>
	Public Function GetRoleRankValue() As ColumnValue
		Return Me.GetValue(TableUtils.RoleRankColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Role_.RoleRank field.
	''' </summary>
	Public Function GetRoleRankFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RoleRankColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.RoleRank field.
	''' </summary>
	Public Sub SetRoleRankFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RoleRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.RoleRank field.
	''' </summary>
	Public Sub SetRoleRankFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RoleRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.RoleRank field.
	''' </summary>
	Public Sub SetRoleRankFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.RoleRank field.
	''' </summary>
	Public Sub SetRoleRankFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Role_.RoleRank field.
	''' </summary>
	Public Sub SetRoleRankFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleRankColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Role_.RoleID field.
	''' </summary>
	Public Property RoleID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RoleIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RoleIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RoleIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RoleIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RoleIDDefault() As String
        Get
            Return TableUtils.RoleIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Role_.GeneralRoleID field.
	''' </summary>
	Public Property GeneralRoleID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.GeneralRoleIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.GeneralRoleIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GeneralRoleIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GeneralRoleIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GeneralRoleIDDefault() As String
        Get
            Return TableUtils.GeneralRoleIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Role_.RoleTypeID field.
	''' </summary>
	Public Property RoleTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RoleTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RoleTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RoleTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RoleTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RoleTypeIDDefault() As String
        Get
            Return TableUtils.RoleTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Role_.Role field.
	''' </summary>
	Public Property Role() As String
		Get 
			Return CType(Me.GetValue(TableUtils.RoleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.RoleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RoleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RoleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RoleDefault() As String
        Get
            Return TableUtils.RoleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Role_.RoleDescription field.
	''' </summary>
	Public Property RoleDescription() As String
		Get 
			Return CType(Me.GetValue(TableUtils.RoleDescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.RoleDescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RoleDescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RoleDescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RoleDescriptionDefault() As String
        Get
            Return TableUtils.RoleDescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Role_.RoleRank field.
	''' </summary>
	Public Property RoleRank() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RoleRankColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RoleRankColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RoleRankSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RoleRankColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RoleRankDefault() As String
        Get
            Return TableUtils.RoleRankColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
