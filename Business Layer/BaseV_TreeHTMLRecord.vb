' This class is "generated" and will be overwritten.
' Your customizations should be made in V_TreeHTMLRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_TreeHTMLRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_TreeHTMLView"></see> class.
''' </remarks>
''' <seealso cref="V_TreeHTMLView"></seealso>
''' <seealso cref="V_TreeHTMLRecord"></seealso>

<Serializable()> Public Class BaseV_TreeHTMLRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_TreeHTMLView = V_TreeHTMLView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_TreeHTMLRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_TreeHTMLRec As V_TreeHTMLRecord = CType(sender,V_TreeHTMLRecord)
        Validate_Inserting()
        If Not V_TreeHTMLRec Is Nothing AndAlso Not V_TreeHTMLRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_TreeHTMLRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_TreeHTMLRec As V_TreeHTMLRecord = CType(sender,V_TreeHTMLRecord)
        Validate_Updating()
        If Not V_TreeHTMLRec Is Nothing AndAlso Not V_TreeHTMLRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_TreeHTMLRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_TreeHTMLRec As V_TreeHTMLRecord = CType(sender,V_TreeHTMLRecord)
        If Not V_TreeHTMLRec Is Nothing AndAlso Not V_TreeHTMLRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_TreeHTML_.TreeID field.
	''' </summary>
	Public Function GetTreeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TreeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_TreeHTML_.TreeID field.
	''' </summary>
	Public Function GetTreeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TreeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_TreeHTML_.TreeParentID field.
	''' </summary>
	Public Function GetTreeParentIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TreeParentIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_TreeHTML_.TreeParentID field.
	''' </summary>
	Public Function GetTreeParentIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TreeParentIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.TreeParentID field.
	''' </summary>
	Public Sub SetTreeParentIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.TreeParentID field.
	''' </summary>
	Public Sub SetTreeParentIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.TreeParentID field.
	''' </summary>
	Public Sub SetTreeParentIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.TreeParentID field.
	''' </summary>
	Public Sub SetTreeParentIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.TreeParentID field.
	''' </summary>
	Public Sub SetTreeParentIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TreeParentIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_TreeHTML_.ItemName field.
	''' </summary>
	Public Function GetItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_TreeHTML_.ItemName field.
	''' </summary>
	Public Function GetItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.ItemName field.
	''' </summary>
	Public Sub SetItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.ItemName field.
	''' </summary>
	Public Sub SetItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_TreeHTML_.TreeHTML field.
	''' </summary>
	Public Function GetTreeHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.TreeHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_TreeHTML_.TreeHTML field.
	''' </summary>
	Public Function GetTreeHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TreeHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.TreeHTML field.
	''' </summary>
	Public Sub SetTreeHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TreeHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.TreeHTML field.
	''' </summary>
	Public Sub SetTreeHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TreeHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_TreeHTML_.ItemRank field.
	''' </summary>
	Public Function GetItemRankValue() As ColumnValue
		Return Me.GetValue(TableUtils.ItemRankColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_TreeHTML_.ItemRank field.
	''' </summary>
	Public Function GetItemRankFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ItemRankColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ItemRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ItemRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemRankColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_TreeHTML_.FolderOnly field.
	''' </summary>
	Public Function GetFolderOnlyValue() As ColumnValue
		Return Me.GetValue(TableUtils.FolderOnlyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_TreeHTML_.FolderOnly field.
	''' </summary>
	Public Function GetFolderOnlyFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FolderOnlyColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.FolderOnly field.
	''' </summary>
	Public Sub SetFolderOnlyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FolderOnlyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_TreeHTML_.FolderOnly field.
	''' </summary>
	Public Sub SetFolderOnlyFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FolderOnlyColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_TreeHTML_.TreeID field.
	''' </summary>
	Public Property TreeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TreeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TreeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TreeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TreeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TreeIDDefault() As String
        Get
            Return TableUtils.TreeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_TreeHTML_.TreeParentID field.
	''' </summary>
	Public Property TreeParentID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TreeParentIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TreeParentIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TreeParentIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TreeParentIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TreeParentIDDefault() As String
        Get
            Return TableUtils.TreeParentIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_TreeHTML_.ItemName field.
	''' </summary>
	Public Property ItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ItemNameDefault() As String
        Get
            Return TableUtils.ItemNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_TreeHTML_.TreeHTML field.
	''' </summary>
	Public Property TreeHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TreeHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TreeHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TreeHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TreeHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TreeHTMLDefault() As String
        Get
            Return TableUtils.TreeHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_TreeHTML_.ItemRank field.
	''' </summary>
	Public Property ItemRank() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ItemRankColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ItemRankColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ItemRankSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ItemRankColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ItemRankDefault() As String
        Get
            Return TableUtils.ItemRankColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_TreeHTML_.FolderOnly field.
	''' </summary>
	Public Property FolderOnly() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FolderOnlyColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FolderOnlyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FolderOnlySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FolderOnlyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FolderOnlyDefault() As String
        Get
            Return TableUtils.FolderOnlyColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
