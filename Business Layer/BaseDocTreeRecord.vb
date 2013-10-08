' This class is "generated" and will be overwritten.
' Your customizations should be made in DocTreeRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="DocTreeRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="DocTreeTable"></see> class.
''' </remarks>
''' <seealso cref="DocTreeTable"></seealso>
''' <seealso cref="DocTreeRecord"></seealso>

<Serializable()> Public Class BaseDocTreeRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As DocTreeTable = DocTreeTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub DocTreeRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim DocTreeRec As DocTreeRecord = CType(sender,DocTreeRecord)
        Validate_Inserting()
        If Not DocTreeRec Is Nothing AndAlso Not DocTreeRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub DocTreeRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim DocTreeRec As DocTreeRecord = CType(sender,DocTreeRecord)
        Validate_Updating()
        If Not DocTreeRec Is Nothing AndAlso Not DocTreeRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub DocTreeRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim DocTreeRec As DocTreeRecord = CType(sender,DocTreeRecord)
        If Not DocTreeRec Is Nothing AndAlso Not DocTreeRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.DocTreeID field.
	''' </summary>
	Public Function GetDocTreeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocTreeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.DocTreeID field.
	''' </summary>
	Public Function GetDocTreeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DocTreeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.CIX field.
	''' </summary>
	Public Function GetCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.CIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.CIX field.
	''' </summary>
	Public Function GetCIXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CIXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.DocTreeParentID field.
	''' </summary>
	Public Function GetDocTreeParentIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocTreeParentIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.DocTreeParentID field.
	''' </summary>
	Public Function GetDocTreeParentIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DocTreeParentIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocTreeParentID field.
	''' </summary>
	Public Sub SetDocTreeParentIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocTreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocTreeParentID field.
	''' </summary>
	Public Sub SetDocTreeParentIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocTreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocTreeParentID field.
	''' </summary>
	Public Sub SetDocTreeParentIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocTreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocTreeParentID field.
	''' </summary>
	Public Sub SetDocTreeParentIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocTreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocTreeParentID field.
	''' </summary>
	Public Sub SetDocTreeParentIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocTreeParentIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.RoleID field.
	''' </summary>
	Public Function GetRoleIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RoleIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.RoleID field.
	''' </summary>
	Public Function GetRoleIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RoleIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.DocIndex field.
	''' </summary>
	Public Function GetDocIndexValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocIndexColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.DocIndex field.
	''' </summary>
	Public Function GetDocIndexFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocIndexColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocIndex field.
	''' </summary>
	Public Sub SetDocIndexFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocIndexColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocIndex field.
	''' </summary>
	Public Sub SetDocIndexFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocIndexColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.DocSort field.
	''' </summary>
	Public Function GetDocSortValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocSortColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.DocSort field.
	''' </summary>
	Public Function GetDocSortFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocSortColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocSort field.
	''' </summary>
	Public Sub SetDocSortFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocSortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocSort field.
	''' </summary>
	Public Sub SetDocSortFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocSortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.DocName field.
	''' </summary>
	Public Function GetDocNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.DocName field.
	''' </summary>
	Public Function GetDocNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocName field.
	''' </summary>
	Public Sub SetDocNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocName field.
	''' </summary>
	Public Sub SetDocNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.DocDescription field.
	''' </summary>
	Public Function GetDocDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocDescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.DocDescription field.
	''' </summary>
	Public Function GetDocDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocDescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocDescription field.
	''' </summary>
	Public Sub SetDocDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocDescription field.
	''' </summary>
	Public Sub SetDocDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.DocTypeID field.
	''' </summary>
	Public Function GetDocTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.DocTypeID field.
	''' </summary>
	Public Function GetDocTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DocTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocTypeID field.
	''' </summary>
	Public Sub SetDocTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocTypeID field.
	''' </summary>
	Public Sub SetDocTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocTypeID field.
	''' </summary>
	Public Sub SetDocTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocTypeID field.
	''' </summary>
	Public Sub SetDocTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.DocTypeID field.
	''' </summary>
	Public Sub SetDocTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.Folder field.
	''' </summary>
	Public Function GetFolderValue() As ColumnValue
		Return Me.GetValue(TableUtils.FolderColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.Folder field.
	''' </summary>
	Public Function GetFolderFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FolderColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.Folder field.
	''' </summary>
	Public Sub SetFolderFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FolderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.Folder field.
	''' </summary>
	Public Sub SetFolderFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FolderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.Folder field.
	''' </summary>
	Public Sub SetFolderFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FolderColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.PrivateFolder field.
	''' </summary>
	Public Function GetPrivateFolderValue() As ColumnValue
		Return Me.GetValue(TableUtils.PrivateFolderColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.PrivateFolder field.
	''' </summary>
	Public Function GetPrivateFolderFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.PrivateFolderColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.PrivateFolder field.
	''' </summary>
	Public Sub SetPrivateFolderFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PrivateFolderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.PrivateFolder field.
	''' </summary>
	Public Sub SetPrivateFolderFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PrivateFolderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.PrivateFolder field.
	''' </summary>
	Public Sub SetPrivateFolderFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PrivateFolderColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.OneActiveCopy field.
	''' </summary>
	Public Function GetOneActiveCopyValue() As ColumnValue
		Return Me.GetValue(TableUtils.OneActiveCopyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.OneActiveCopy field.
	''' </summary>
	Public Function GetOneActiveCopyFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.OneActiveCopyColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.OneActiveCopy field.
	''' </summary>
	Public Sub SetOneActiveCopyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OneActiveCopyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.OneActiveCopy field.
	''' </summary>
	Public Sub SetOneActiveCopyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OneActiveCopyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.OneActiveCopy field.
	''' </summary>
	Public Sub SetOneActiveCopyFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OneActiveCopyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.OnApp field.
	''' </summary>
	Public Function GetOnAppValue() As ColumnValue
		Return Me.GetValue(TableUtils.OnAppColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.OnApp field.
	''' </summary>
	Public Function GetOnAppFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.OnAppColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.OnApp field.
	''' </summary>
	Public Sub SetOnAppFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OnAppColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.OnApp field.
	''' </summary>
	Public Sub SetOnAppFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OnAppColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.OnApp field.
	''' </summary>
	Public Sub SetOnAppFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OnAppColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.RecordDocDetails field.
	''' </summary>
	Public Function GetRecordDocDetailsValue() As ColumnValue
		Return Me.GetValue(TableUtils.RecordDocDetailsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.RecordDocDetails field.
	''' </summary>
	Public Function GetRecordDocDetailsFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.RecordDocDetailsColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.RecordDocDetails field.
	''' </summary>
	Public Sub SetRecordDocDetailsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RecordDocDetailsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.RecordDocDetails field.
	''' </summary>
	Public Sub SetRecordDocDetailsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RecordDocDetailsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.RecordDocDetails field.
	''' </summary>
	Public Sub SetRecordDocDetailsFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecordDocDetailsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.AlwaysShow field.
	''' </summary>
	Public Function GetAlwaysShowValue() As ColumnValue
		Return Me.GetValue(TableUtils.AlwaysShowColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.AlwaysShow field.
	''' </summary>
	Public Function GetAlwaysShowFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.AlwaysShowColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.AlwaysShow field.
	''' </summary>
	Public Sub SetAlwaysShowFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AlwaysShowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.AlwaysShow field.
	''' </summary>
	Public Sub SetAlwaysShowFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AlwaysShowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.AlwaysShow field.
	''' </summary>
	Public Sub SetAlwaysShowFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AlwaysShowColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.ItemRank field.
	''' </summary>
	Public Function GetItemRankValue() As ColumnValue
		Return Me.GetValue(TableUtils.ItemRankColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.ItemRank field.
	''' </summary>
	Public Function GetItemRankFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ItemRankColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ItemRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ItemRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemRankColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.Hide field.
	''' </summary>
	Public Function GetHideValue() As ColumnValue
		Return Me.GetValue(TableUtils.HideColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.Hide field.
	''' </summary>
	Public Function GetHideFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.HideColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.Hide field.
	''' </summary>
	Public Sub SetHideFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HideColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.Hide field.
	''' </summary>
	Public Sub SetHideFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HideColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.Hide field.
	''' </summary>
	Public Sub SetHideFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HideColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's DocTree_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's DocTree_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.DocTreeID field.
	''' </summary>
	Public Property DocTreeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DocTreeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocTreeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocTreeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocTreeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocTreeIDDefault() As String
        Get
            Return TableUtils.DocTreeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.CIX field.
	''' </summary>
	Public Property CIX() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CIXColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CIXDefault() As String
        Get
            Return TableUtils.CIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.DocTreeParentID field.
	''' </summary>
	Public Property DocTreeParentID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DocTreeParentIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocTreeParentIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocTreeParentIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocTreeParentIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocTreeParentIDDefault() As String
        Get
            Return TableUtils.DocTreeParentIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.RoleID field.
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
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.DocIndex field.
	''' </summary>
	Public Property DocIndex() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DocIndexColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DocIndexColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocIndexSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocIndexColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocIndexDefault() As String
        Get
            Return TableUtils.DocIndexColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.DocSort field.
	''' </summary>
	Public Property DocSort() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DocSortColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DocSortColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocSortSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocSortColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocSortDefault() As String
        Get
            Return TableUtils.DocSortColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.DocName field.
	''' </summary>
	Public Property DocName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DocNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DocNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocNameDefault() As String
        Get
            Return TableUtils.DocNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.DocDescription field.
	''' </summary>
	Public Property DocDescription() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DocDescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DocDescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocDescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocDescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocDescriptionDefault() As String
        Get
            Return TableUtils.DocDescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.DocTypeID field.
	''' </summary>
	Public Property DocTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DocTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocTypeIDDefault() As String
        Get
            Return TableUtils.DocTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.Folder field.
	''' </summary>
	Public Property Folder() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FolderColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FolderColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FolderSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FolderColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FolderDefault() As String
        Get
            Return TableUtils.FolderColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.PrivateFolder field.
	''' </summary>
	Public Property PrivateFolder() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.PrivateFolderColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PrivateFolderColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PrivateFolderSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PrivateFolderColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PrivateFolderDefault() As String
        Get
            Return TableUtils.PrivateFolderColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.OneActiveCopy field.
	''' </summary>
	Public Property OneActiveCopy() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.OneActiveCopyColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OneActiveCopyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OneActiveCopySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OneActiveCopyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OneActiveCopyDefault() As String
        Get
            Return TableUtils.OneActiveCopyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.OnApp field.
	''' </summary>
	Public Property OnApp() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.OnAppColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OnAppColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OnAppSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OnAppColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OnAppDefault() As String
        Get
            Return TableUtils.OnAppColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.RecordDocDetails field.
	''' </summary>
	Public Property RecordDocDetails() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.RecordDocDetailsColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RecordDocDetailsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RecordDocDetailsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RecordDocDetailsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RecordDocDetailsDefault() As String
        Get
            Return TableUtils.RecordDocDetailsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.AlwaysShow field.
	''' </summary>
	Public Property AlwaysShow() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.AlwaysShowColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AlwaysShowColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AlwaysShowSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AlwaysShowColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AlwaysShowDefault() As String
        Get
            Return TableUtils.AlwaysShowColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.ItemRank field.
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
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.Hide field.
	''' </summary>
	Public Property Hide() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.HideColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HideColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HideSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HideColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HideDefault() As String
        Get
            Return TableUtils.HideColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.CreatedByID field.
	''' </summary>
	Public Property CreatedByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CreatedByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CreatedByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CreatedByIDDefault() As String
        Get
            Return TableUtils.CreatedByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.CreatedAt field.
	''' </summary>
	Public Property CreatedAt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CreatedAtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CreatedAtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CreatedAtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CreatedAtDefault() As String
        Get
            Return TableUtils.CreatedAtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.UpdatedByID field.
	''' </summary>
	Public Property UpdatedByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UpdatedByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UpdatedByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UpdatedByIDDefault() As String
        Get
            Return TableUtils.UpdatedByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's DocTree_.UpdatedAt field.
	''' </summary>
	Public Property UpdatedAt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UpdatedAtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UpdatedAtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UpdatedAtDefault() As String
        Get
            Return TableUtils.UpdatedAtColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
