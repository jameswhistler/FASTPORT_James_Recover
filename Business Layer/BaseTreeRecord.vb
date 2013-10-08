' This class is "generated" and will be overwritten.
' Your customizations should be made in TreeRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="TreeRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="TreeTable"></see> class.
''' </remarks>
''' <seealso cref="TreeTable"></seealso>
''' <seealso cref="TreeRecord"></seealso>

<Serializable()> Public Class BaseTreeRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As TreeTable = TreeTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub TreeRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim TreeRec As TreeRecord = CType(sender,TreeRecord)
        Validate_Inserting()
        If Not TreeRec Is Nothing AndAlso Not TreeRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub TreeRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim TreeRec As TreeRecord = CType(sender,TreeRecord)
        Validate_Updating()
        If Not TreeRec Is Nothing AndAlso Not TreeRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub TreeRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim TreeRec As TreeRecord = CType(sender,TreeRecord)
        If Not TreeRec Is Nothing AndAlso Not TreeRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Tree_.TreeID field.
	''' </summary>
	Public Function GetTreeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TreeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.TreeID field.
	''' </summary>
	Public Function GetTreeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TreeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.CIX field.
	''' </summary>
	Public Function GetCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.CIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.CIX field.
	''' </summary>
	Public Function GetCIXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CIXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.TreeParentID field.
	''' </summary>
	Public Function GetTreeParentIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TreeParentIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.TreeParentID field.
	''' </summary>
	Public Function GetTreeParentIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TreeParentIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.TreeParentID field.
	''' </summary>
	Public Sub SetTreeParentIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.TreeParentID field.
	''' </summary>
	Public Sub SetTreeParentIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.TreeParentID field.
	''' </summary>
	Public Sub SetTreeParentIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.TreeParentID field.
	''' </summary>
	Public Sub SetTreeParentIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.TreeParentID field.
	''' </summary>
	Public Sub SetTreeParentIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TreeParentIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ItemName field.
	''' </summary>
	Public Function GetItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ItemName field.
	''' </summary>
	Public Function GetItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemName field.
	''' </summary>
	Public Sub SetItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemName field.
	''' </summary>
	Public Sub SetItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.Description field.
	''' </summary>
	Public Function GetDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.Description field.
	''' </summary>
	Public Function GetDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.Description field.
	''' </summary>
	Public Sub SetDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.Description field.
	''' </summary>
	Public Sub SetDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.Abbreviation field.
	''' </summary>
	Public Function GetAbbreviationValue() As ColumnValue
		Return Me.GetValue(TableUtils.AbbreviationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.Abbreviation field.
	''' </summary>
	Public Function GetAbbreviationFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AbbreviationColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.Abbreviation field.
	''' </summary>
	Public Sub SetAbbreviationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AbbreviationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.Abbreviation field.
	''' </summary>
	Public Sub SetAbbreviationFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AbbreviationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ItemImage field.
	''' </summary>
	Public Function GetItemImageValue() As ColumnValue
		Return Me.GetValue(TableUtils.ItemImageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ItemImage field.
	''' </summary>
	Public Function GetItemImageFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.ItemImageColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemImage field.
	''' </summary>
	Public Sub SetItemImageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ItemImageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemImage field.
	''' </summary>
	Public Sub SetItemImageFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ItemImageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemImage field.
	''' </summary>
	Public Sub SetItemImageFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemImageColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ImagePath field.
	''' </summary>
	Public Function GetImagePathValue() As ColumnValue
		Return Me.GetValue(TableUtils.ImagePathColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ImagePath field.
	''' </summary>
	Public Function GetImagePathFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ImagePathColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ImagePath field.
	''' </summary>
	Public Sub SetImagePathFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ImagePathColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ImagePath field.
	''' </summary>
	Public Sub SetImagePathFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ImagePathColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ItemImageGlow field.
	''' </summary>
	Public Function GetItemImageGlowValue() As ColumnValue
		Return Me.GetValue(TableUtils.ItemImageGlowColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ItemImageGlow field.
	''' </summary>
	Public Function GetItemImageGlowFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.ItemImageGlowColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemImageGlow field.
	''' </summary>
	Public Sub SetItemImageGlowFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ItemImageGlowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemImageGlow field.
	''' </summary>
	Public Sub SetItemImageGlowFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ItemImageGlowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemImageGlow field.
	''' </summary>
	Public Sub SetItemImageGlowFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemImageGlowColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ImageGlowPath field.
	''' </summary>
	Public Function GetImageGlowPathValue() As ColumnValue
		Return Me.GetValue(TableUtils.ImageGlowPathColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ImageGlowPath field.
	''' </summary>
	Public Function GetImageGlowPathFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ImageGlowPathColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ImageGlowPath field.
	''' </summary>
	Public Sub SetImageGlowPathFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ImageGlowPathColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ImageGlowPath field.
	''' </summary>
	Public Sub SetImageGlowPathFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ImageGlowPathColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ItemImageGray field.
	''' </summary>
	Public Function GetItemImageGrayValue() As ColumnValue
		Return Me.GetValue(TableUtils.ItemImageGrayColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ItemImageGray field.
	''' </summary>
	Public Function GetItemImageGrayFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.ItemImageGrayColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemImageGray field.
	''' </summary>
	Public Sub SetItemImageGrayFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ItemImageGrayColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemImageGray field.
	''' </summary>
	Public Sub SetItemImageGrayFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ItemImageGrayColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemImageGray field.
	''' </summary>
	Public Sub SetItemImageGrayFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemImageGrayColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ImageGrayPath field.
	''' </summary>
	Public Function GetImageGrayPathValue() As ColumnValue
		Return Me.GetValue(TableUtils.ImageGrayPathColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ImageGrayPath field.
	''' </summary>
	Public Function GetImageGrayPathFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ImageGrayPathColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ImageGrayPath field.
	''' </summary>
	Public Sub SetImageGrayPathFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ImageGrayPathColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ImageGrayPath field.
	''' </summary>
	Public Sub SetImageGrayPathFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ImageGrayPathColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ItemImageLowRes field.
	''' </summary>
	Public Function GetItemImageLowResValue() As ColumnValue
		Return Me.GetValue(TableUtils.ItemImageLowResColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ItemImageLowRes field.
	''' </summary>
	Public Function GetItemImageLowResFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.ItemImageLowResColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemImageLowRes field.
	''' </summary>
	Public Sub SetItemImageLowResFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ItemImageLowResColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemImageLowRes field.
	''' </summary>
	Public Sub SetItemImageLowResFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ItemImageLowResColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemImageLowRes field.
	''' </summary>
	Public Sub SetItemImageLowResFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemImageLowResColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ImageLowResPath field.
	''' </summary>
	Public Function GetImageLowResPathValue() As ColumnValue
		Return Me.GetValue(TableUtils.ImageLowResPathColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ImageLowResPath field.
	''' </summary>
	Public Function GetImageLowResPathFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ImageLowResPathColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ImageLowResPath field.
	''' </summary>
	Public Sub SetImageLowResPathFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ImageLowResPathColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ImageLowResPath field.
	''' </summary>
	Public Sub SetImageLowResPathFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ImageLowResPathColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.FolderOnly field.
	''' </summary>
	Public Function GetFolderOnlyValue() As ColumnValue
		Return Me.GetValue(TableUtils.FolderOnlyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.FolderOnly field.
	''' </summary>
	Public Function GetFolderOnlyFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FolderOnlyColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.FolderOnly field.
	''' </summary>
	Public Sub SetFolderOnlyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FolderOnlyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.FolderOnly field.
	''' </summary>
	Public Sub SetFolderOnlyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FolderOnlyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.FolderOnly field.
	''' </summary>
	Public Sub SetFolderOnlyFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FolderOnlyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ItemRank field.
	''' </summary>
	Public Function GetItemRankValue() As ColumnValue
		Return Me.GetValue(TableUtils.ItemRankColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ItemRank field.
	''' </summary>
	Public Function GetItemRankFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ItemRankColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ItemRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ItemRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ItemRank field.
	''' </summary>
	Public Sub SetItemRankFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemRankColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.Hide field.
	''' </summary>
	Public Function GetHideValue() As ColumnValue
		Return Me.GetValue(TableUtils.HideColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.Hide field.
	''' </summary>
	Public Function GetHideFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.HideColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.Hide field.
	''' </summary>
	Public Sub SetHideFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HideColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.Hide field.
	''' </summary>
	Public Sub SetHideFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HideColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.Hide field.
	''' </summary>
	Public Sub SetHideFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HideColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.AdminOnly field.
	''' </summary>
	Public Function GetAdminOnlyValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdminOnlyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.AdminOnly field.
	''' </summary>
	Public Function GetAdminOnlyFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.AdminOnlyColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.AdminOnly field.
	''' </summary>
	Public Sub SetAdminOnlyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdminOnlyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.AdminOnly field.
	''' </summary>
	Public Sub SetAdminOnlyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AdminOnlyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.AdminOnly field.
	''' </summary>
	Public Sub SetAdminOnlyFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdminOnlyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.GeoStateID field.
	''' </summary>
	Public Function GetGeoStateIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.GeoStateIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.GeoStateID field.
	''' </summary>
	Public Function GetGeoStateIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.GeoStateIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.GeoStateID field.
	''' </summary>
	Public Sub SetGeoStateIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GeoStateIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.GeoStateID field.
	''' </summary>
	Public Sub SetGeoStateIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.GeoStateIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.GeoStateID field.
	''' </summary>
	Public Sub SetGeoStateIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GeoStateIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.GeoStateID field.
	''' </summary>
	Public Sub SetGeoStateIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GeoStateIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.GeoStateID field.
	''' </summary>
	Public Sub SetGeoStateIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GeoStateIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.GeoMarketID field.
	''' </summary>
	Public Function GetGeoMarketIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.GeoMarketIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.GeoMarketID field.
	''' </summary>
	Public Function GetGeoMarketIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.GeoMarketIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.GeoMarketID field.
	''' </summary>
	Public Sub SetGeoMarketIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GeoMarketIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.GeoMarketID field.
	''' </summary>
	Public Sub SetGeoMarketIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.GeoMarketIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.GeoMarketID field.
	''' </summary>
	Public Sub SetGeoMarketIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GeoMarketIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.GeoMarketID field.
	''' </summary>
	Public Sub SetGeoMarketIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GeoMarketIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.GeoMarketID field.
	''' </summary>
	Public Sub SetGeoMarketIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GeoMarketIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.NoSlide field.
	''' </summary>
	Public Function GetNoSlideValue() As ColumnValue
		Return Me.GetValue(TableUtils.NoSlideColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.NoSlide field.
	''' </summary>
	Public Function GetNoSlideFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.NoSlideColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.NoSlide field.
	''' </summary>
	Public Sub SetNoSlideFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NoSlideColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.NoSlide field.
	''' </summary>
	Public Sub SetNoSlideFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.NoSlideColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.NoSlide field.
	''' </summary>
	Public Sub SetNoSlideFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NoSlideColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.YearSlider field.
	''' </summary>
	Public Function GetYearSliderValue() As ColumnValue
		Return Me.GetValue(TableUtils.YearSliderColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.YearSlider field.
	''' </summary>
	Public Function GetYearSliderFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.YearSliderColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.YearSlider field.
	''' </summary>
	Public Sub SetYearSliderFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.YearSliderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.YearSlider field.
	''' </summary>
	Public Sub SetYearSliderFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.YearSliderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.YearSlider field.
	''' </summary>
	Public Sub SetYearSliderFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.YearSliderColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ExternalID field.
	''' </summary>
	Public Function GetExternalIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExternalIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tree_.ExternalID field.
	''' </summary>
	Public Function GetExternalIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ExternalIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ExternalID field.
	''' </summary>
	Public Sub SetExternalIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExternalIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ExternalID field.
	''' </summary>
	Public Sub SetExternalIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExternalIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ExternalID field.
	''' </summary>
	Public Sub SetExternalIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExternalIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ExternalID field.
	''' </summary>
	Public Sub SetExternalIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExternalIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tree_.ExternalID field.
	''' </summary>
	Public Sub SetExternalIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExternalIDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.TreeID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tree_.CIX field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tree_.TreeParentID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tree_.ItemName field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tree_.Description field.
	''' </summary>
	Public Property Description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DescriptionDefault() As String
        Get
            Return TableUtils.DescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.Abbreviation field.
	''' </summary>
	Public Property Abbreviation() As String
		Get 
			Return CType(Me.GetValue(TableUtils.AbbreviationColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.AbbreviationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AbbreviationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AbbreviationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AbbreviationDefault() As String
        Get
            Return TableUtils.AbbreviationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.ItemImage field.
	''' </summary>
	Public Property ItemImage() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.ItemImageColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ItemImageColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ItemImageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ItemImageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ItemImageDefault() As String
        Get
            Return TableUtils.ItemImageColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.ImagePath field.
	''' </summary>
	Public Property ImagePath() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ImagePathColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ImagePathColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ImagePathSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ImagePathColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ImagePathDefault() As String
        Get
            Return TableUtils.ImagePathColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.ItemImageGlow field.
	''' </summary>
	Public Property ItemImageGlow() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.ItemImageGlowColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ItemImageGlowColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ItemImageGlowSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ItemImageGlowColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ItemImageGlowDefault() As String
        Get
            Return TableUtils.ItemImageGlowColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.ImageGlowPath field.
	''' </summary>
	Public Property ImageGlowPath() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ImageGlowPathColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ImageGlowPathColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ImageGlowPathSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ImageGlowPathColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ImageGlowPathDefault() As String
        Get
            Return TableUtils.ImageGlowPathColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.ItemImageGray field.
	''' </summary>
	Public Property ItemImageGray() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.ItemImageGrayColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ItemImageGrayColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ItemImageGraySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ItemImageGrayColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ItemImageGrayDefault() As String
        Get
            Return TableUtils.ItemImageGrayColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.ImageGrayPath field.
	''' </summary>
	Public Property ImageGrayPath() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ImageGrayPathColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ImageGrayPathColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ImageGrayPathSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ImageGrayPathColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ImageGrayPathDefault() As String
        Get
            Return TableUtils.ImageGrayPathColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.ItemImageLowRes field.
	''' </summary>
	Public Property ItemImageLowRes() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.ItemImageLowResColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ItemImageLowResColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ItemImageLowResSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ItemImageLowResColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ItemImageLowResDefault() As String
        Get
            Return TableUtils.ItemImageLowResColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.ImageLowResPath field.
	''' </summary>
	Public Property ImageLowResPath() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ImageLowResPathColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ImageLowResPathColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ImageLowResPathSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ImageLowResPathColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ImageLowResPathDefault() As String
        Get
            Return TableUtils.ImageLowResPathColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.FolderOnly field.
	''' </summary>
	Public Property FolderOnly() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FolderOnlyColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FolderOnlyColumn)
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.ItemRank field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tree_.Hide field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tree_.AdminOnly field.
	''' </summary>
	Public Property AdminOnly() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.AdminOnlyColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AdminOnlyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdminOnlySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdminOnlyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdminOnlyDefault() As String
        Get
            Return TableUtils.AdminOnlyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.GeoStateID field.
	''' </summary>
	Public Property GeoStateID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.GeoStateIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.GeoStateIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GeoStateIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GeoStateIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GeoStateIDDefault() As String
        Get
            Return TableUtils.GeoStateIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.GeoMarketID field.
	''' </summary>
	Public Property GeoMarketID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.GeoMarketIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.GeoMarketIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GeoMarketIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GeoMarketIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GeoMarketIDDefault() As String
        Get
            Return TableUtils.GeoMarketIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.NoSlide field.
	''' </summary>
	Public Property NoSlide() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.NoSlideColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.NoSlideColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NoSlideSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NoSlideColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NoSlideDefault() As String
        Get
            Return TableUtils.NoSlideColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.YearSlider field.
	''' </summary>
	Public Property YearSlider() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.YearSliderColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.YearSliderColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property YearSliderSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.YearSliderColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property YearSliderDefault() As String
        Get
            Return TableUtils.YearSliderColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tree_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tree_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tree_.UpdatedAt field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tree_.ExternalID field.
	''' </summary>
	Public Property ExternalID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ExternalIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExternalIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExternalIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExternalIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExternalIDDefault() As String
        Get
            Return TableUtils.ExternalIDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
