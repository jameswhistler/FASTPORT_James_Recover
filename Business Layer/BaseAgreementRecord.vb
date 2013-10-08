' This class is "generated" and will be overwritten.
' Your customizations should be made in AgreementRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="AgreementRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="AgreementTable"></see> class.
''' </remarks>
''' <seealso cref="AgreementTable"></seealso>
''' <seealso cref="AgreementRecord"></seealso>

<Serializable()> Public Class BaseAgreementRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As AgreementTable = AgreementTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub AgreementRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim AgreementRec As AgreementRecord = CType(sender,AgreementRecord)
        Validate_Inserting()
        If Not AgreementRec Is Nothing AndAlso Not AgreementRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub AgreementRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim AgreementRec As AgreementRecord = CType(sender,AgreementRecord)
        Validate_Updating()
        If Not AgreementRec Is Nothing AndAlso Not AgreementRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub AgreementRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim AgreementRec As AgreementRecord = CType(sender,AgreementRecord)
        If Not AgreementRec Is Nothing AndAlso Not AgreementRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.AgreementID field.
	''' </summary>
	Public Function GetAgreementIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AgreementIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.AgreementID field.
	''' </summary>
	Public Function GetAgreementIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AgreementIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.CIX field.
	''' </summary>
	Public Function GetCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.CIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.CIX field.
	''' </summary>
	Public Function GetCIXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CIXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.DocTreeParentID field.
	''' </summary>
	Public Function GetDocTreeParentIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocTreeParentIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.DocTreeParentID field.
	''' </summary>
	Public Function GetDocTreeParentIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DocTreeParentIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocTreeParentID field.
	''' </summary>
	Public Sub SetDocTreeParentIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocTreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocTreeParentID field.
	''' </summary>
	Public Sub SetDocTreeParentIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocTreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocTreeParentID field.
	''' </summary>
	Public Sub SetDocTreeParentIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocTreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocTreeParentID field.
	''' </summary>
	Public Sub SetDocTreeParentIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocTreeParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocTreeParentID field.
	''' </summary>
	Public Sub SetDocTreeParentIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocTreeParentIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.RoleID field.
	''' </summary>
	Public Function GetRoleIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RoleIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.RoleID field.
	''' </summary>
	Public Function GetRoleIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RoleIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.CustomID field.
	''' </summary>
	Public Function GetCustomIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CustomIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.CustomID field.
	''' </summary>
	Public Function GetCustomIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CustomIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CustomID field.
	''' </summary>
	Public Sub SetCustomIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CustomIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CustomID field.
	''' </summary>
	Public Sub SetCustomIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CustomIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CustomID field.
	''' </summary>
	Public Sub SetCustomIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CustomIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CustomID field.
	''' </summary>
	Public Sub SetCustomIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CustomIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CustomID field.
	''' </summary>
	Public Sub SetCustomIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CustomIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.DocIndex field.
	''' </summary>
	Public Function GetDocIndexValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocIndexColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.DocIndex field.
	''' </summary>
	Public Function GetDocIndexFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocIndexColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocIndex field.
	''' </summary>
	Public Sub SetDocIndexFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocIndexColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocIndex field.
	''' </summary>
	Public Sub SetDocIndexFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocIndexColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.DocSort field.
	''' </summary>
	Public Function GetDocSortValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocSortColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.DocSort field.
	''' </summary>
	Public Function GetDocSortFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocSortColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocSort field.
	''' </summary>
	Public Sub SetDocSortFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocSortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocSort field.
	''' </summary>
	Public Sub SetDocSortFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocSortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.Agreement field.
	''' </summary>
	Public Function GetAgreementValue() As ColumnValue
		Return Me.GetValue(TableUtils.AgreementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.Agreement field.
	''' </summary>
	Public Function GetAgreementFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AgreementColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.Agreement field.
	''' </summary>
	Public Sub SetAgreementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AgreementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.Agreement field.
	''' </summary>
	Public Sub SetAgreementFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.Description field.
	''' </summary>
	Public Function GetDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.Description field.
	''' </summary>
	Public Function GetDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.Description field.
	''' </summary>
	Public Sub SetDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.Description field.
	''' </summary>
	Public Sub SetDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.RequiredDoc field.
	''' </summary>
	Public Function GetRequiredDocValue() As ColumnValue
		Return Me.GetValue(TableUtils.RequiredDocColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.RequiredDoc field.
	''' </summary>
	Public Function GetRequiredDocFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.RequiredDocColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.RequiredDoc field.
	''' </summary>
	Public Sub SetRequiredDocFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RequiredDocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.RequiredDoc field.
	''' </summary>
	Public Sub SetRequiredDocFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RequiredDocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.RequiredDoc field.
	''' </summary>
	Public Sub SetRequiredDocFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RequiredDocColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.DocRank field.
	''' </summary>
	Public Function GetDocRankValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocRankColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.DocRank field.
	''' </summary>
	Public Function GetDocRankFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DocRankColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocRank field.
	''' </summary>
	Public Sub SetDocRankFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocRank field.
	''' </summary>
	Public Sub SetDocRankFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocRank field.
	''' </summary>
	Public Sub SetDocRankFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocRank field.
	''' </summary>
	Public Sub SetDocRankFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocRank field.
	''' </summary>
	Public Sub SetDocRankFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocRankColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.Hide field.
	''' </summary>
	Public Function GetHideValue() As ColumnValue
		Return Me.GetValue(TableUtils.HideColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.Hide field.
	''' </summary>
	Public Function GetHideFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.HideColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.Hide field.
	''' </summary>
	Public Sub SetHideFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HideColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.Hide field.
	''' </summary>
	Public Sub SetHideFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HideColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.Hide field.
	''' </summary>
	Public Sub SetHideFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HideColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.AgreementFile field.
	''' </summary>
	Public Function GetAgreementFileValue() As ColumnValue
		Return Me.GetValue(TableUtils.AgreementFileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.AgreementFile field.
	''' </summary>
	Public Function GetAgreementFileFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.AgreementFileColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.AgreementFile field.
	''' </summary>
	Public Sub SetAgreementFileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AgreementFileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.AgreementFile field.
	''' </summary>
	Public Sub SetAgreementFileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AgreementFileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.AgreementFile field.
	''' </summary>
	Public Sub SetAgreementFileFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementFileColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.AgreementFileName field.
	''' </summary>
	Public Function GetAgreementFileNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.AgreementFileNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.AgreementFileName field.
	''' </summary>
	Public Function GetAgreementFileNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AgreementFileNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.AgreementFileName field.
	''' </summary>
	Public Sub SetAgreementFileNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AgreementFileNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.AgreementFileName field.
	''' </summary>
	Public Sub SetAgreementFileNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementFileNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FlowCollectionID field.
	''' </summary>
	Public Function GetFlowCollectionIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowCollectionIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FlowCollectionID field.
	''' </summary>
	Public Function GetFlowCollectionIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowCollectionIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FlowCollectionID field.
	''' </summary>
	Public Sub SetFlowCollectionIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FlowCollectionID field.
	''' </summary>
	Public Sub SetFlowCollectionIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FlowCollectionID field.
	''' </summary>
	Public Sub SetFlowCollectionIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FlowCollectionID field.
	''' </summary>
	Public Sub SetFlowCollectionIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FlowCollectionID field.
	''' </summary>
	Public Sub SetFlowCollectionIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowCollectionIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.UseStoredSignature field.
	''' </summary>
	Public Function GetUseStoredSignatureValue() As ColumnValue
		Return Me.GetValue(TableUtils.UseStoredSignatureColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.UseStoredSignature field.
	''' </summary>
	Public Function GetUseStoredSignatureFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.UseStoredSignatureColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.UseStoredSignature field.
	''' </summary>
	Public Sub SetUseStoredSignatureFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UseStoredSignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.UseStoredSignature field.
	''' </summary>
	Public Sub SetUseStoredSignatureFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UseStoredSignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.UseStoredSignature field.
	''' </summary>
	Public Sub SetUseStoredSignatureFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UseStoredSignatureColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ShowSignatureDate field.
	''' </summary>
	Public Function GetShowSignatureDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShowSignatureDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ShowSignatureDate field.
	''' </summary>
	Public Function GetShowSignatureDateFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ShowSignatureDateColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ShowSignatureDate field.
	''' </summary>
	Public Sub SetShowSignatureDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShowSignatureDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ShowSignatureDate field.
	''' </summary>
	Public Sub SetShowSignatureDateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ShowSignatureDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ShowSignatureDate field.
	''' </summary>
	Public Sub SetShowSignatureDateFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShowSignatureDateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ShowExpirationDate field.
	''' </summary>
	Public Function GetShowExpirationDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShowExpirationDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ShowExpirationDate field.
	''' </summary>
	Public Function GetShowExpirationDateFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ShowExpirationDateColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ShowExpirationDate field.
	''' </summary>
	Public Sub SetShowExpirationDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShowExpirationDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ShowExpirationDate field.
	''' </summary>
	Public Sub SetShowExpirationDateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ShowExpirationDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ShowExpirationDate field.
	''' </summary>
	Public Sub SetShowExpirationDateFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShowExpirationDateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.InitialsInDocument field.
	''' </summary>
	Public Function GetInitialsInDocumentValue() As ColumnValue
		Return Me.GetValue(TableUtils.InitialsInDocumentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.InitialsInDocument field.
	''' </summary>
	Public Function GetInitialsInDocumentFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.InitialsInDocumentColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.InitialsInDocument field.
	''' </summary>
	Public Sub SetInitialsInDocumentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.InitialsInDocumentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.InitialsInDocument field.
	''' </summary>
	Public Sub SetInitialsInDocumentFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.InitialsInDocumentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.InitialsInDocument field.
	''' </summary>
	Public Sub SetInitialsInDocumentFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InitialsInDocumentColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.DocHasCustomFields field.
	''' </summary>
	Public Function GetDocHasCustomFieldsValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocHasCustomFieldsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.DocHasCustomFields field.
	''' </summary>
	Public Function GetDocHasCustomFieldsFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.DocHasCustomFieldsColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocHasCustomFields field.
	''' </summary>
	Public Sub SetDocHasCustomFieldsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocHasCustomFieldsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocHasCustomFields field.
	''' </summary>
	Public Sub SetDocHasCustomFieldsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocHasCustomFieldsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.DocHasCustomFields field.
	''' </summary>
	Public Sub SetDocHasCustomFieldsFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocHasCustomFieldsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ExecuteFromBoard field.
	''' </summary>
	Public Function GetExecuteFromBoardValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExecuteFromBoardColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ExecuteFromBoard field.
	''' </summary>
	Public Function GetExecuteFromBoardFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ExecuteFromBoardColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ExecuteFromBoard field.
	''' </summary>
	Public Sub SetExecuteFromBoardFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExecuteFromBoardColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ExecuteFromBoard field.
	''' </summary>
	Public Sub SetExecuteFromBoardFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExecuteFromBoardColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ExecuteFromBoard field.
	''' </summary>
	Public Sub SetExecuteFromBoardFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecuteFromBoardColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SenderInstructions field.
	''' </summary>
	Public Function GetSenderInstructionsValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderInstructionsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SenderInstructions field.
	''' </summary>
	Public Function GetSenderInstructionsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SenderInstructionsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SenderInstructions field.
	''' </summary>
	Public Sub SetSenderInstructionsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderInstructionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SenderInstructions field.
	''' </summary>
	Public Sub SetSenderInstructionsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderInstructionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.RecipientInstructions field.
	''' </summary>
	Public Function GetRecipientInstructionsValue() As ColumnValue
		Return Me.GetValue(TableUtils.RecipientInstructionsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.RecipientInstructions field.
	''' </summary>
	Public Function GetRecipientInstructionsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.RecipientInstructionsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.RecipientInstructions field.
	''' </summary>
	Public Sub SetRecipientInstructionsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RecipientInstructionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.RecipientInstructions field.
	''' </summary>
	Public Sub SetRecipientInstructionsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientInstructionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.OtherInstructions field.
	''' </summary>
	Public Function GetOtherInstructionsValue() As ColumnValue
		Return Me.GetValue(TableUtils.OtherInstructionsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.OtherInstructions field.
	''' </summary>
	Public Function GetOtherInstructionsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.OtherInstructionsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.OtherInstructions field.
	''' </summary>
	Public Sub SetOtherInstructionsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OtherInstructionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.OtherInstructions field.
	''' </summary>
	Public Sub SetOtherInstructionsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OtherInstructionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FirstItem field.
	''' </summary>
	Public Function GetFirstItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FirstItem field.
	''' </summary>
	Public Function GetFirstItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstItem field.
	''' </summary>
	Public Sub SetFirstItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstItem field.
	''' </summary>
	Public Sub SetFirstItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FirstTypeID field.
	''' </summary>
	Public Function GetFirstTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FirstTypeID field.
	''' </summary>
	Public Function GetFirstTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FirstTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstTypeID field.
	''' </summary>
	Public Sub SetFirstTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstTypeID field.
	''' </summary>
	Public Sub SetFirstTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FirstTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstTypeID field.
	''' </summary>
	Public Sub SetFirstTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstTypeID field.
	''' </summary>
	Public Sub SetFirstTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstTypeID field.
	''' </summary>
	Public Sub SetFirstTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FirstDefault field.
	''' </summary>
	Public Function GetFirstDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FirstDefault field.
	''' </summary>
	Public Function GetFirstDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstDefault field.
	''' </summary>
	Public Sub SetFirstDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstDefault field.
	''' </summary>
	Public Sub SetFirstDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FirstByCIX field.
	''' </summary>
	Public Function GetFirstByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FirstByCIX field.
	''' </summary>
	Public Function GetFirstByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FirstByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstByCIX field.
	''' </summary>
	Public Sub SetFirstByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstByCIX field.
	''' </summary>
	Public Sub SetFirstByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FirstByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstByCIX field.
	''' </summary>
	Public Sub SetFirstByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FirstByOIX field.
	''' </summary>
	Public Function GetFirstByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FirstByOIX field.
	''' </summary>
	Public Function GetFirstByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FirstByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstByOIX field.
	''' </summary>
	Public Sub SetFirstByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstByOIX field.
	''' </summary>
	Public Sub SetFirstByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FirstByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FirstByOIX field.
	''' </summary>
	Public Sub SetFirstByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SecondItem field.
	''' </summary>
	Public Function GetSecondItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SecondItem field.
	''' </summary>
	Public Function GetSecondItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SecondItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondItem field.
	''' </summary>
	Public Sub SetSecondItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondItem field.
	''' </summary>
	Public Sub SetSecondItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SecondTypeID field.
	''' </summary>
	Public Function GetSecondTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SecondTypeID field.
	''' </summary>
	Public Function GetSecondTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SecondTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondTypeID field.
	''' </summary>
	Public Sub SetSecondTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondTypeID field.
	''' </summary>
	Public Sub SetSecondTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SecondTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondTypeID field.
	''' </summary>
	Public Sub SetSecondTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondTypeID field.
	''' </summary>
	Public Sub SetSecondTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondTypeID field.
	''' </summary>
	Public Sub SetSecondTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SecondDefault field.
	''' </summary>
	Public Function GetSecondDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SecondDefault field.
	''' </summary>
	Public Function GetSecondDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SecondDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondDefault field.
	''' </summary>
	Public Sub SetSecondDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondDefault field.
	''' </summary>
	Public Sub SetSecondDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SecondByCIX field.
	''' </summary>
	Public Function GetSecondByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SecondByCIX field.
	''' </summary>
	Public Function GetSecondByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SecondByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondByCIX field.
	''' </summary>
	Public Sub SetSecondByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondByCIX field.
	''' </summary>
	Public Sub SetSecondByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SecondByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondByCIX field.
	''' </summary>
	Public Sub SetSecondByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SecondByOIX field.
	''' </summary>
	Public Function GetSecondByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SecondByOIX field.
	''' </summary>
	Public Function GetSecondByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SecondByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondByOIX field.
	''' </summary>
	Public Sub SetSecondByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondByOIX field.
	''' </summary>
	Public Sub SetSecondByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SecondByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SecondByOIX field.
	''' </summary>
	Public Sub SetSecondByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirdItem field.
	''' </summary>
	Public Function GetThirdItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirdItem field.
	''' </summary>
	Public Function GetThirdItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirdItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdItem field.
	''' </summary>
	Public Sub SetThirdItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdItem field.
	''' </summary>
	Public Sub SetThirdItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirdTypeID field.
	''' </summary>
	Public Function GetThirdTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirdTypeID field.
	''' </summary>
	Public Function GetThirdTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ThirdTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdTypeID field.
	''' </summary>
	Public Sub SetThirdTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdTypeID field.
	''' </summary>
	Public Sub SetThirdTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirdTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdTypeID field.
	''' </summary>
	Public Sub SetThirdTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdTypeID field.
	''' </summary>
	Public Sub SetThirdTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdTypeID field.
	''' </summary>
	Public Sub SetThirdTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirdDefault field.
	''' </summary>
	Public Function GetThirdDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirdDefault field.
	''' </summary>
	Public Function GetThirdDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirdDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdDefault field.
	''' </summary>
	Public Sub SetThirdDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdDefault field.
	''' </summary>
	Public Sub SetThirdDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirdByCIX field.
	''' </summary>
	Public Function GetThirdByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirdByCIX field.
	''' </summary>
	Public Function GetThirdByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThirdByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdByCIX field.
	''' </summary>
	Public Sub SetThirdByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdByCIX field.
	''' </summary>
	Public Sub SetThirdByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirdByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdByCIX field.
	''' </summary>
	Public Sub SetThirdByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirdByOIX field.
	''' </summary>
	Public Function GetThirdByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirdByOIX field.
	''' </summary>
	Public Function GetThirdByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThirdByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdByOIX field.
	''' </summary>
	Public Sub SetThirdByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdByOIX field.
	''' </summary>
	Public Sub SetThirdByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirdByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirdByOIX field.
	''' </summary>
	Public Sub SetThirdByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourthItem field.
	''' </summary>
	Public Function GetFourthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourthItem field.
	''' </summary>
	Public Function GetFourthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthItem field.
	''' </summary>
	Public Sub SetFourthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthItem field.
	''' </summary>
	Public Sub SetFourthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourthTypeID field.
	''' </summary>
	Public Function GetFourthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourthTypeID field.
	''' </summary>
	Public Function GetFourthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FourthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthTypeID field.
	''' </summary>
	Public Sub SetFourthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthTypeID field.
	''' </summary>
	Public Sub SetFourthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthTypeID field.
	''' </summary>
	Public Sub SetFourthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthTypeID field.
	''' </summary>
	Public Sub SetFourthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthTypeID field.
	''' </summary>
	Public Sub SetFourthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourthDefault field.
	''' </summary>
	Public Function GetFourthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourthDefault field.
	''' </summary>
	Public Function GetFourthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthDefault field.
	''' </summary>
	Public Sub SetFourthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthDefault field.
	''' </summary>
	Public Sub SetFourthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourthByCIX field.
	''' </summary>
	Public Function GetFourthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourthByCIX field.
	''' </summary>
	Public Function GetFourthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FourthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthByCIX field.
	''' </summary>
	Public Sub SetFourthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthByCIX field.
	''' </summary>
	Public Sub SetFourthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthByCIX field.
	''' </summary>
	Public Sub SetFourthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourthByOIX field.
	''' </summary>
	Public Function GetFourthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourthByOIX field.
	''' </summary>
	Public Function GetFourthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FourthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthByOIX field.
	''' </summary>
	Public Sub SetFourthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthByOIX field.
	''' </summary>
	Public Sub SetFourthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourthByOIX field.
	''' </summary>
	Public Sub SetFourthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifthItem field.
	''' </summary>
	Public Function GetFifthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifthItem field.
	''' </summary>
	Public Function GetFifthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthItem field.
	''' </summary>
	Public Sub SetFifthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthItem field.
	''' </summary>
	Public Sub SetFifthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifthTypeID field.
	''' </summary>
	Public Function GetFifthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifthTypeID field.
	''' </summary>
	Public Function GetFifthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FifthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthTypeID field.
	''' </summary>
	Public Sub SetFifthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthTypeID field.
	''' </summary>
	Public Sub SetFifthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthTypeID field.
	''' </summary>
	Public Sub SetFifthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthTypeID field.
	''' </summary>
	Public Sub SetFifthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthTypeID field.
	''' </summary>
	Public Sub SetFifthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifthDefault field.
	''' </summary>
	Public Function GetFifthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifthDefault field.
	''' </summary>
	Public Function GetFifthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthDefault field.
	''' </summary>
	Public Sub SetFifthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthDefault field.
	''' </summary>
	Public Sub SetFifthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifthByCIX field.
	''' </summary>
	Public Function GetFifthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifthByCIX field.
	''' </summary>
	Public Function GetFifthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FifthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthByCIX field.
	''' </summary>
	Public Sub SetFifthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthByCIX field.
	''' </summary>
	Public Sub SetFifthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthByCIX field.
	''' </summary>
	Public Sub SetFifthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifthByOIX field.
	''' </summary>
	Public Function GetFifthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifthByOIX field.
	''' </summary>
	Public Function GetFifthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FifthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthByOIX field.
	''' </summary>
	Public Sub SetFifthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthByOIX field.
	''' </summary>
	Public Sub SetFifthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifthByOIX field.
	''' </summary>
	Public Sub SetFifthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SixthItem field.
	''' </summary>
	Public Function GetSixthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SixthItem field.
	''' </summary>
	Public Function GetSixthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SixthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthItem field.
	''' </summary>
	Public Sub SetSixthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthItem field.
	''' </summary>
	Public Sub SetSixthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SixthTypeID field.
	''' </summary>
	Public Function GetSixthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SixthTypeID field.
	''' </summary>
	Public Function GetSixthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SixthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthTypeID field.
	''' </summary>
	Public Sub SetSixthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthTypeID field.
	''' </summary>
	Public Sub SetSixthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SixthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthTypeID field.
	''' </summary>
	Public Sub SetSixthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthTypeID field.
	''' </summary>
	Public Sub SetSixthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthTypeID field.
	''' </summary>
	Public Sub SetSixthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SixthDefault field.
	''' </summary>
	Public Function GetSixthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SixthDefault field.
	''' </summary>
	Public Function GetSixthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SixthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthDefault field.
	''' </summary>
	Public Sub SetSixthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthDefault field.
	''' </summary>
	Public Sub SetSixthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SixthByCIX field.
	''' </summary>
	Public Function GetSixthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SixthByCIX field.
	''' </summary>
	Public Function GetSixthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SixthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthByCIX field.
	''' </summary>
	Public Sub SetSixthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthByCIX field.
	''' </summary>
	Public Sub SetSixthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SixthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthByCIX field.
	''' </summary>
	Public Sub SetSixthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SixthByOIX field.
	''' </summary>
	Public Function GetSixthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SixthByOIX field.
	''' </summary>
	Public Function GetSixthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SixthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthByOIX field.
	''' </summary>
	Public Sub SetSixthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthByOIX field.
	''' </summary>
	Public Sub SetSixthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SixthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SixthByOIX field.
	''' </summary>
	Public Sub SetSixthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SeventhItem field.
	''' </summary>
	Public Function GetSeventhItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SeventhItem field.
	''' </summary>
	Public Function GetSeventhItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SeventhItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhItem field.
	''' </summary>
	Public Sub SetSeventhItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhItem field.
	''' </summary>
	Public Sub SetSeventhItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SeventhTypeID field.
	''' </summary>
	Public Function GetSeventhTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SeventhTypeID field.
	''' </summary>
	Public Function GetSeventhTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SeventhTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhTypeID field.
	''' </summary>
	Public Sub SetSeventhTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhTypeID field.
	''' </summary>
	Public Sub SetSeventhTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SeventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhTypeID field.
	''' </summary>
	Public Sub SetSeventhTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhTypeID field.
	''' </summary>
	Public Sub SetSeventhTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhTypeID field.
	''' </summary>
	Public Sub SetSeventhTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SeventhDefault field.
	''' </summary>
	Public Function GetSeventhDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SeventhDefault field.
	''' </summary>
	Public Function GetSeventhDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SeventhDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhDefault field.
	''' </summary>
	Public Sub SetSeventhDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhDefault field.
	''' </summary>
	Public Sub SetSeventhDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SeventhByCIX field.
	''' </summary>
	Public Function GetSeventhByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SeventhByCIX field.
	''' </summary>
	Public Function GetSeventhByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SeventhByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhByCIX field.
	''' </summary>
	Public Sub SetSeventhByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhByCIX field.
	''' </summary>
	Public Sub SetSeventhByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SeventhByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhByCIX field.
	''' </summary>
	Public Sub SetSeventhByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SeventhByOIX field.
	''' </summary>
	Public Function GetSeventhByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.SeventhByOIX field.
	''' </summary>
	Public Function GetSeventhByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SeventhByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhByOIX field.
	''' </summary>
	Public Sub SetSeventhByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhByOIX field.
	''' </summary>
	Public Sub SetSeventhByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SeventhByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.SeventhByOIX field.
	''' </summary>
	Public Sub SetSeventhByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EighthItem field.
	''' </summary>
	Public Function GetEighthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EighthItem field.
	''' </summary>
	Public Function GetEighthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EighthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthItem field.
	''' </summary>
	Public Sub SetEighthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthItem field.
	''' </summary>
	Public Sub SetEighthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EighthTypeID field.
	''' </summary>
	Public Function GetEighthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EighthTypeID field.
	''' </summary>
	Public Function GetEighthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EighthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthTypeID field.
	''' </summary>
	Public Sub SetEighthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthTypeID field.
	''' </summary>
	Public Sub SetEighthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EighthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthTypeID field.
	''' </summary>
	Public Sub SetEighthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthTypeID field.
	''' </summary>
	Public Sub SetEighthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthTypeID field.
	''' </summary>
	Public Sub SetEighthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EighthDefault field.
	''' </summary>
	Public Function GetEighthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EighthDefault field.
	''' </summary>
	Public Function GetEighthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EighthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthDefault field.
	''' </summary>
	Public Sub SetEighthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthDefault field.
	''' </summary>
	Public Sub SetEighthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EighthByCIX field.
	''' </summary>
	Public Function GetEighthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EighthByCIX field.
	''' </summary>
	Public Function GetEighthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.EighthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthByCIX field.
	''' </summary>
	Public Sub SetEighthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthByCIX field.
	''' </summary>
	Public Sub SetEighthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EighthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthByCIX field.
	''' </summary>
	Public Sub SetEighthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EighthByOIX field.
	''' </summary>
	Public Function GetEighthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EighthByOIX field.
	''' </summary>
	Public Function GetEighthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.EighthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthByOIX field.
	''' </summary>
	Public Sub SetEighthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthByOIX field.
	''' </summary>
	Public Sub SetEighthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EighthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EighthByOIX field.
	''' </summary>
	Public Sub SetEighthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.NinthItem field.
	''' </summary>
	Public Function GetNinthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.NinthItem field.
	''' </summary>
	Public Function GetNinthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NinthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthItem field.
	''' </summary>
	Public Sub SetNinthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthItem field.
	''' </summary>
	Public Sub SetNinthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.NinthTypeID field.
	''' </summary>
	Public Function GetNinthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.NinthTypeID field.
	''' </summary>
	Public Function GetNinthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.NinthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthTypeID field.
	''' </summary>
	Public Sub SetNinthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthTypeID field.
	''' </summary>
	Public Sub SetNinthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.NinthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthTypeID field.
	''' </summary>
	Public Sub SetNinthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthTypeID field.
	''' </summary>
	Public Sub SetNinthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthTypeID field.
	''' </summary>
	Public Sub SetNinthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.NinthDefault field.
	''' </summary>
	Public Function GetNinthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.NinthDefault field.
	''' </summary>
	Public Function GetNinthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NinthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthDefault field.
	''' </summary>
	Public Sub SetNinthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthDefault field.
	''' </summary>
	Public Sub SetNinthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.NinthByCIX field.
	''' </summary>
	Public Function GetNinthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.NinthByCIX field.
	''' </summary>
	Public Function GetNinthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.NinthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthByCIX field.
	''' </summary>
	Public Sub SetNinthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthByCIX field.
	''' </summary>
	Public Sub SetNinthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.NinthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthByCIX field.
	''' </summary>
	Public Sub SetNinthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.NinthByOIX field.
	''' </summary>
	Public Function GetNinthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.NinthByOIX field.
	''' </summary>
	Public Function GetNinthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.NinthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthByOIX field.
	''' </summary>
	Public Sub SetNinthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthByOIX field.
	''' </summary>
	Public Sub SetNinthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.NinthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.NinthByOIX field.
	''' </summary>
	Public Sub SetNinthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TenthItem field.
	''' </summary>
	Public Function GetTenthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TenthItem field.
	''' </summary>
	Public Function GetTenthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TenthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthItem field.
	''' </summary>
	Public Sub SetTenthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthItem field.
	''' </summary>
	Public Sub SetTenthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TenthTypeID field.
	''' </summary>
	Public Function GetTenthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TenthTypeID field.
	''' </summary>
	Public Function GetTenthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TenthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthTypeID field.
	''' </summary>
	Public Sub SetTenthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthTypeID field.
	''' </summary>
	Public Sub SetTenthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthTypeID field.
	''' </summary>
	Public Sub SetTenthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthTypeID field.
	''' </summary>
	Public Sub SetTenthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthTypeID field.
	''' </summary>
	Public Sub SetTenthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TenthDefault field.
	''' </summary>
	Public Function GetTenthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TenthDefault field.
	''' </summary>
	Public Function GetTenthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TenthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthDefault field.
	''' </summary>
	Public Sub SetTenthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthDefault field.
	''' </summary>
	Public Sub SetTenthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TenthByCIX field.
	''' </summary>
	Public Function GetTenthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TenthByCIX field.
	''' </summary>
	Public Function GetTenthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TenthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthByCIX field.
	''' </summary>
	Public Sub SetTenthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthByCIX field.
	''' </summary>
	Public Sub SetTenthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthByCIX field.
	''' </summary>
	Public Sub SetTenthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TenthByOIX field.
	''' </summary>
	Public Function GetTenthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TenthByOIX field.
	''' </summary>
	Public Function GetTenthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TenthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthByOIX field.
	''' </summary>
	Public Sub SetTenthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthByOIX field.
	''' </summary>
	Public Sub SetTenthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TenthByOIX field.
	''' </summary>
	Public Sub SetTenthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EleventhItem field.
	''' </summary>
	Public Function GetEleventhItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EleventhItem field.
	''' </summary>
	Public Function GetEleventhItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EleventhItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhItem field.
	''' </summary>
	Public Sub SetEleventhItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhItem field.
	''' </summary>
	Public Sub SetEleventhItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EleventhTypeID field.
	''' </summary>
	Public Function GetEleventhTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EleventhTypeID field.
	''' </summary>
	Public Function GetEleventhTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EleventhTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhTypeID field.
	''' </summary>
	Public Sub SetEleventhTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhTypeID field.
	''' </summary>
	Public Sub SetEleventhTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EleventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhTypeID field.
	''' </summary>
	Public Sub SetEleventhTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhTypeID field.
	''' </summary>
	Public Sub SetEleventhTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhTypeID field.
	''' </summary>
	Public Sub SetEleventhTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EleventhDefault field.
	''' </summary>
	Public Function GetEleventhDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EleventhDefault field.
	''' </summary>
	Public Function GetEleventhDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EleventhDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhDefault field.
	''' </summary>
	Public Sub SetEleventhDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhDefault field.
	''' </summary>
	Public Sub SetEleventhDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EleventhByCIX field.
	''' </summary>
	Public Function GetEleventhByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EleventhByCIX field.
	''' </summary>
	Public Function GetEleventhByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.EleventhByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhByCIX field.
	''' </summary>
	Public Sub SetEleventhByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhByCIX field.
	''' </summary>
	Public Sub SetEleventhByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EleventhByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhByCIX field.
	''' </summary>
	Public Sub SetEleventhByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EleventhByOIX field.
	''' </summary>
	Public Function GetEleventhByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.EleventhByOIX field.
	''' </summary>
	Public Function GetEleventhByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.EleventhByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhByOIX field.
	''' </summary>
	Public Sub SetEleventhByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhByOIX field.
	''' </summary>
	Public Sub SetEleventhByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EleventhByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.EleventhByOIX field.
	''' </summary>
	Public Sub SetEleventhByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TwelfthItem field.
	''' </summary>
	Public Function GetTwelfthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TwelfthItem field.
	''' </summary>
	Public Function GetTwelfthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TwelfthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthItem field.
	''' </summary>
	Public Sub SetTwelfthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthItem field.
	''' </summary>
	Public Sub SetTwelfthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TwelfthTypeID field.
	''' </summary>
	Public Function GetTwelfthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TwelfthTypeID field.
	''' </summary>
	Public Function GetTwelfthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TwelfthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthTypeID field.
	''' </summary>
	Public Sub SetTwelfthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthTypeID field.
	''' </summary>
	Public Sub SetTwelfthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TwelfthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthTypeID field.
	''' </summary>
	Public Sub SetTwelfthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthTypeID field.
	''' </summary>
	Public Sub SetTwelfthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthTypeID field.
	''' </summary>
	Public Sub SetTwelfthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TwelfthDefault field.
	''' </summary>
	Public Function GetTwelfthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TwelfthDefault field.
	''' </summary>
	Public Function GetTwelfthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TwelfthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthDefault field.
	''' </summary>
	Public Sub SetTwelfthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthDefault field.
	''' </summary>
	Public Sub SetTwelfthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TwelfthByCIX field.
	''' </summary>
	Public Function GetTwelfthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TwelfthByCIX field.
	''' </summary>
	Public Function GetTwelfthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TwelfthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthByCIX field.
	''' </summary>
	Public Sub SetTwelfthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthByCIX field.
	''' </summary>
	Public Sub SetTwelfthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TwelfthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthByCIX field.
	''' </summary>
	Public Sub SetTwelfthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TwelfthByOIX field.
	''' </summary>
	Public Function GetTwelfthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.TwelfthByOIX field.
	''' </summary>
	Public Function GetTwelfthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TwelfthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthByOIX field.
	''' </summary>
	Public Sub SetTwelfthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthByOIX field.
	''' </summary>
	Public Sub SetTwelfthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TwelfthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.TwelfthByOIX field.
	''' </summary>
	Public Sub SetTwelfthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirteenthItem field.
	''' </summary>
	Public Function GetThirteenthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirteenthItem field.
	''' </summary>
	Public Function GetThirteenthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirteenthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthItem field.
	''' </summary>
	Public Sub SetThirteenthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthItem field.
	''' </summary>
	Public Sub SetThirteenthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirteenthTypeID field.
	''' </summary>
	Public Function GetThirteenthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirteenthTypeID field.
	''' </summary>
	Public Function GetThirteenthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ThirteenthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthTypeID field.
	''' </summary>
	Public Sub SetThirteenthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthTypeID field.
	''' </summary>
	Public Sub SetThirteenthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthTypeID field.
	''' </summary>
	Public Sub SetThirteenthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthTypeID field.
	''' </summary>
	Public Sub SetThirteenthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthTypeID field.
	''' </summary>
	Public Sub SetThirteenthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirteenthDefault field.
	''' </summary>
	Public Function GetThirteenthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirteenthDefault field.
	''' </summary>
	Public Function GetThirteenthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirteenthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthDefault field.
	''' </summary>
	Public Sub SetThirteenthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthDefault field.
	''' </summary>
	Public Sub SetThirteenthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirteenthByCIX field.
	''' </summary>
	Public Function GetThirteenthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirteenthByCIX field.
	''' </summary>
	Public Function GetThirteenthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThirteenthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthByCIX field.
	''' </summary>
	Public Sub SetThirteenthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthByCIX field.
	''' </summary>
	Public Sub SetThirteenthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirteenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthByCIX field.
	''' </summary>
	Public Sub SetThirteenthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirteenthByOIX field.
	''' </summary>
	Public Function GetThirteenthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.ThirteenthByOIX field.
	''' </summary>
	Public Function GetThirteenthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThirteenthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthByOIX field.
	''' </summary>
	Public Sub SetThirteenthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthByOIX field.
	''' </summary>
	Public Sub SetThirteenthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirteenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.ThirteenthByOIX field.
	''' </summary>
	Public Sub SetThirteenthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourteenthItem field.
	''' </summary>
	Public Function GetFourteenthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourteenthItem field.
	''' </summary>
	Public Function GetFourteenthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourteenthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthItem field.
	''' </summary>
	Public Sub SetFourteenthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthItem field.
	''' </summary>
	Public Sub SetFourteenthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourteenthTypeID field.
	''' </summary>
	Public Function GetFourteenthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourteenthTypeID field.
	''' </summary>
	Public Function GetFourteenthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FourteenthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthTypeID field.
	''' </summary>
	Public Sub SetFourteenthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthTypeID field.
	''' </summary>
	Public Sub SetFourteenthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthTypeID field.
	''' </summary>
	Public Sub SetFourteenthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthTypeID field.
	''' </summary>
	Public Sub SetFourteenthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthTypeID field.
	''' </summary>
	Public Sub SetFourteenthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourteenthDefault field.
	''' </summary>
	Public Function GetFourteenthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourteenthDefault field.
	''' </summary>
	Public Function GetFourteenthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourteenthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthDefault field.
	''' </summary>
	Public Sub SetFourteenthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthDefault field.
	''' </summary>
	Public Sub SetFourteenthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourteenthByCIX field.
	''' </summary>
	Public Function GetFourteenthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourteenthByCIX field.
	''' </summary>
	Public Function GetFourteenthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FourteenthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthByCIX field.
	''' </summary>
	Public Sub SetFourteenthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthByCIX field.
	''' </summary>
	Public Sub SetFourteenthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourteenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthByCIX field.
	''' </summary>
	Public Sub SetFourteenthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourteenthByOIX field.
	''' </summary>
	Public Function GetFourteenthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FourteenthByOIX field.
	''' </summary>
	Public Function GetFourteenthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FourteenthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthByOIX field.
	''' </summary>
	Public Sub SetFourteenthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthByOIX field.
	''' </summary>
	Public Sub SetFourteenthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourteenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FourteenthByOIX field.
	''' </summary>
	Public Sub SetFourteenthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifteenthItem field.
	''' </summary>
	Public Function GetFifteenthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifteenthItem field.
	''' </summary>
	Public Function GetFifteenthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifteenthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthItem field.
	''' </summary>
	Public Sub SetFifteenthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthItem field.
	''' </summary>
	Public Sub SetFifteenthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifteenthTypeID field.
	''' </summary>
	Public Function GetFifteenthTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifteenthTypeID field.
	''' </summary>
	Public Function GetFifteenthTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FifteenthTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthTypeID field.
	''' </summary>
	Public Sub SetFifteenthTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthTypeID field.
	''' </summary>
	Public Sub SetFifteenthTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthTypeID field.
	''' </summary>
	Public Sub SetFifteenthTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthTypeID field.
	''' </summary>
	Public Sub SetFifteenthTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthTypeID field.
	''' </summary>
	Public Sub SetFifteenthTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifteenthDefault field.
	''' </summary>
	Public Function GetFifteenthDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifteenthDefault field.
	''' </summary>
	Public Function GetFifteenthDefaultFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifteenthDefaultColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthDefault field.
	''' </summary>
	Public Sub SetFifteenthDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthDefault field.
	''' </summary>
	Public Sub SetFifteenthDefaultFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifteenthByCIX field.
	''' </summary>
	Public Function GetFifteenthByCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthByCIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifteenthByCIX field.
	''' </summary>
	Public Function GetFifteenthByCIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FifteenthByCIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthByCIX field.
	''' </summary>
	Public Sub SetFifteenthByCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthByCIX field.
	''' </summary>
	Public Sub SetFifteenthByCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifteenthByCIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthByCIX field.
	''' </summary>
	Public Sub SetFifteenthByCIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthByCIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifteenthByOIX field.
	''' </summary>
	Public Function GetFifteenthByOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthByOIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.FifteenthByOIX field.
	''' </summary>
	Public Function GetFifteenthByOIXFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FifteenthByOIXColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthByOIX field.
	''' </summary>
	Public Sub SetFifteenthByOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthByOIX field.
	''' </summary>
	Public Sub SetFifteenthByOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifteenthByOIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.FifteenthByOIX field.
	''' </summary>
	Public Sub SetFifteenthByOIXFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthByOIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Agreement_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Agreement_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.AgreementID field.
	''' </summary>
	Public Property AgreementID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AgreementIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AgreementIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AgreementIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AgreementIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AgreementIDDefault() As String
        Get
            Return TableUtils.AgreementIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.CIX field.
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
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.DocTreeParentID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.RoleID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.CustomID field.
	''' </summary>
	Public Property CustomID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CustomIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CustomIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CustomIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CustomIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CustomIDDefault() As String
        Get
            Return TableUtils.CustomIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.DocIndex field.
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
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.DocSort field.
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
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.Agreement field.
	''' </summary>
	Public Property Agreement() As String
		Get 
			Return CType(Me.GetValue(TableUtils.AgreementColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.AgreementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AgreementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AgreementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AgreementDefault() As String
        Get
            Return TableUtils.AgreementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.Description field.
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
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.RequiredDoc field.
	''' </summary>
	Public Property RequiredDoc() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.RequiredDocColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RequiredDocColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RequiredDocSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RequiredDocColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RequiredDocDefault() As String
        Get
            Return TableUtils.RequiredDocColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.DocRank field.
	''' </summary>
	Public Property DocRank() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DocRankColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocRankColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocRankSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocRankColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocRankDefault() As String
        Get
            Return TableUtils.DocRankColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.Hide field.
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
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.AgreementFile field.
	''' </summary>
	Public Property AgreementFile() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.AgreementFileColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AgreementFileColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AgreementFileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AgreementFileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AgreementFileDefault() As String
        Get
            Return TableUtils.AgreementFileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.AgreementFileName field.
	''' </summary>
	Public Property AgreementFileName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.AgreementFileNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.AgreementFileNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AgreementFileNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AgreementFileNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AgreementFileNameDefault() As String
        Get
            Return TableUtils.AgreementFileNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FlowCollectionID field.
	''' </summary>
	Public Property FlowCollectionID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FlowCollectionIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FlowCollectionIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FlowCollectionIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FlowCollectionIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FlowCollectionIDDefault() As String
        Get
            Return TableUtils.FlowCollectionIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.UseStoredSignature field.
	''' </summary>
	Public Property UseStoredSignature() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.UseStoredSignatureColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UseStoredSignatureColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UseStoredSignatureSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UseStoredSignatureColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UseStoredSignatureDefault() As String
        Get
            Return TableUtils.UseStoredSignatureColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.ShowSignatureDate field.
	''' </summary>
	Public Property ShowSignatureDate() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ShowSignatureDateColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ShowSignatureDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ShowSignatureDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ShowSignatureDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ShowSignatureDateDefault() As String
        Get
            Return TableUtils.ShowSignatureDateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.ShowExpirationDate field.
	''' </summary>
	Public Property ShowExpirationDate() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ShowExpirationDateColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ShowExpirationDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ShowExpirationDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ShowExpirationDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ShowExpirationDateDefault() As String
        Get
            Return TableUtils.ShowExpirationDateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.InitialsInDocument field.
	''' </summary>
	Public Property InitialsInDocument() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.InitialsInDocumentColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.InitialsInDocumentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property InitialsInDocumentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.InitialsInDocumentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property InitialsInDocumentDefault() As String
        Get
            Return TableUtils.InitialsInDocumentColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.DocHasCustomFields field.
	''' </summary>
	Public Property DocHasCustomFields() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.DocHasCustomFieldsColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocHasCustomFieldsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocHasCustomFieldsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocHasCustomFieldsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocHasCustomFieldsDefault() As String
        Get
            Return TableUtils.DocHasCustomFieldsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.ExecuteFromBoard field.
	''' </summary>
	Public Property ExecuteFromBoard() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ExecuteFromBoardColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExecuteFromBoardColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExecuteFromBoardSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExecuteFromBoardColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExecuteFromBoardDefault() As String
        Get
            Return TableUtils.ExecuteFromBoardColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SenderInstructions field.
	''' </summary>
	Public Property SenderInstructions() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SenderInstructionsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SenderInstructionsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SenderInstructionsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SenderInstructionsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SenderInstructionsDefault() As String
        Get
            Return TableUtils.SenderInstructionsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.RecipientInstructions field.
	''' </summary>
	Public Property RecipientInstructions() As String
		Get 
			Return CType(Me.GetValue(TableUtils.RecipientInstructionsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.RecipientInstructionsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RecipientInstructionsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RecipientInstructionsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RecipientInstructionsDefault() As String
        Get
            Return TableUtils.RecipientInstructionsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.OtherInstructions field.
	''' </summary>
	Public Property OtherInstructions() As String
		Get 
			Return CType(Me.GetValue(TableUtils.OtherInstructionsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.OtherInstructionsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OtherInstructionsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OtherInstructionsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OtherInstructionsDefault() As String
        Get
            Return TableUtils.OtherInstructionsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FirstItem field.
	''' </summary>
	Public Property FirstItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstItemDefault() As String
        Get
            Return TableUtils.FirstItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FirstTypeID field.
	''' </summary>
	Public Property FirstTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FirstTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FirstTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstTypeIDDefault() As String
        Get
            Return TableUtils.FirstTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FirstDefault field.
	''' </summary>
	Public Property FirstDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstDefaultDefault() As String
        Get
            Return TableUtils.FirstDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FirstByCIX field.
	''' </summary>
	Public Property FirstByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FirstByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FirstByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstByCIXDefault() As String
        Get
            Return TableUtils.FirstByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FirstByOIX field.
	''' </summary>
	Public Property FirstByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FirstByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FirstByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstByOIXDefault() As String
        Get
            Return TableUtils.FirstByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SecondItem field.
	''' </summary>
	Public Property SecondItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SecondItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SecondItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondItemDefault() As String
        Get
            Return TableUtils.SecondItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SecondTypeID field.
	''' </summary>
	Public Property SecondTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SecondTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SecondTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondTypeIDDefault() As String
        Get
            Return TableUtils.SecondTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SecondDefault field.
	''' </summary>
	Public Property SecondDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SecondDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SecondDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondDefaultDefault() As String
        Get
            Return TableUtils.SecondDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SecondByCIX field.
	''' </summary>
	Public Property SecondByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SecondByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SecondByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondByCIXDefault() As String
        Get
            Return TableUtils.SecondByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SecondByOIX field.
	''' </summary>
	Public Property SecondByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SecondByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SecondByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondByOIXDefault() As String
        Get
            Return TableUtils.SecondByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.ThirdItem field.
	''' </summary>
	Public Property ThirdItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirdItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdItemDefault() As String
        Get
            Return TableUtils.ThirdItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.ThirdTypeID field.
	''' </summary>
	Public Property ThirdTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirdTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdTypeIDDefault() As String
        Get
            Return TableUtils.ThirdTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.ThirdDefault field.
	''' </summary>
	Public Property ThirdDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirdDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdDefaultDefault() As String
        Get
            Return TableUtils.ThirdDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.ThirdByCIX field.
	''' </summary>
	Public Property ThirdByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirdByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdByCIXDefault() As String
        Get
            Return TableUtils.ThirdByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.ThirdByOIX field.
	''' </summary>
	Public Property ThirdByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirdByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdByOIXDefault() As String
        Get
            Return TableUtils.ThirdByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FourthItem field.
	''' </summary>
	Public Property FourthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthItemDefault() As String
        Get
            Return TableUtils.FourthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FourthTypeID field.
	''' </summary>
	Public Property FourthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FourthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthTypeIDDefault() As String
        Get
            Return TableUtils.FourthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FourthDefault field.
	''' </summary>
	Public Property FourthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthDefaultDefault() As String
        Get
            Return TableUtils.FourthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FourthByCIX field.
	''' </summary>
	Public Property FourthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FourthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthByCIXDefault() As String
        Get
            Return TableUtils.FourthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FourthByOIX field.
	''' </summary>
	Public Property FourthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FourthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthByOIXDefault() As String
        Get
            Return TableUtils.FourthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FifthItem field.
	''' </summary>
	Public Property FifthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthItemDefault() As String
        Get
            Return TableUtils.FifthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FifthTypeID field.
	''' </summary>
	Public Property FifthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FifthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthTypeIDDefault() As String
        Get
            Return TableUtils.FifthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FifthDefault field.
	''' </summary>
	Public Property FifthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthDefaultDefault() As String
        Get
            Return TableUtils.FifthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FifthByCIX field.
	''' </summary>
	Public Property FifthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FifthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthByCIXDefault() As String
        Get
            Return TableUtils.FifthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FifthByOIX field.
	''' </summary>
	Public Property FifthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FifthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthByOIXDefault() As String
        Get
            Return TableUtils.FifthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SixthItem field.
	''' </summary>
	Public Property SixthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SixthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SixthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthItemDefault() As String
        Get
            Return TableUtils.SixthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SixthTypeID field.
	''' </summary>
	Public Property SixthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SixthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SixthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthTypeIDDefault() As String
        Get
            Return TableUtils.SixthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SixthDefault field.
	''' </summary>
	Public Property SixthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SixthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SixthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthDefaultDefault() As String
        Get
            Return TableUtils.SixthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SixthByCIX field.
	''' </summary>
	Public Property SixthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SixthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SixthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthByCIXDefault() As String
        Get
            Return TableUtils.SixthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SixthByOIX field.
	''' </summary>
	Public Property SixthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SixthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SixthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthByOIXDefault() As String
        Get
            Return TableUtils.SixthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SeventhItem field.
	''' </summary>
	Public Property SeventhItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SeventhItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhItemDefault() As String
        Get
            Return TableUtils.SeventhItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SeventhTypeID field.
	''' </summary>
	Public Property SeventhTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SeventhTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhTypeIDDefault() As String
        Get
            Return TableUtils.SeventhTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SeventhDefault field.
	''' </summary>
	Public Property SeventhDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SeventhDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhDefaultDefault() As String
        Get
            Return TableUtils.SeventhDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SeventhByCIX field.
	''' </summary>
	Public Property SeventhByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SeventhByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhByCIXDefault() As String
        Get
            Return TableUtils.SeventhByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.SeventhByOIX field.
	''' </summary>
	Public Property SeventhByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SeventhByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhByOIXDefault() As String
        Get
            Return TableUtils.SeventhByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.EighthItem field.
	''' </summary>
	Public Property EighthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EighthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EighthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthItemDefault() As String
        Get
            Return TableUtils.EighthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.EighthTypeID field.
	''' </summary>
	Public Property EighthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EighthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EighthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthTypeIDDefault() As String
        Get
            Return TableUtils.EighthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.EighthDefault field.
	''' </summary>
	Public Property EighthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EighthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EighthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthDefaultDefault() As String
        Get
            Return TableUtils.EighthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.EighthByCIX field.
	''' </summary>
	Public Property EighthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.EighthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EighthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthByCIXDefault() As String
        Get
            Return TableUtils.EighthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.EighthByOIX field.
	''' </summary>
	Public Property EighthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.EighthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EighthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthByOIXDefault() As String
        Get
            Return TableUtils.EighthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.NinthItem field.
	''' </summary>
	Public Property NinthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.NinthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.NinthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthItemDefault() As String
        Get
            Return TableUtils.NinthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.NinthTypeID field.
	''' </summary>
	Public Property NinthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.NinthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.NinthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthTypeIDDefault() As String
        Get
            Return TableUtils.NinthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.NinthDefault field.
	''' </summary>
	Public Property NinthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.NinthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.NinthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthDefaultDefault() As String
        Get
            Return TableUtils.NinthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.NinthByCIX field.
	''' </summary>
	Public Property NinthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.NinthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.NinthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthByCIXDefault() As String
        Get
            Return TableUtils.NinthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.NinthByOIX field.
	''' </summary>
	Public Property NinthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.NinthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.NinthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthByOIXDefault() As String
        Get
            Return TableUtils.NinthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.TenthItem field.
	''' </summary>
	Public Property TenthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TenthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TenthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthItemDefault() As String
        Get
            Return TableUtils.TenthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.TenthTypeID field.
	''' </summary>
	Public Property TenthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TenthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TenthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthTypeIDDefault() As String
        Get
            Return TableUtils.TenthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.TenthDefault field.
	''' </summary>
	Public Property TenthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TenthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TenthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthDefaultDefault() As String
        Get
            Return TableUtils.TenthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.TenthByCIX field.
	''' </summary>
	Public Property TenthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TenthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TenthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthByCIXDefault() As String
        Get
            Return TableUtils.TenthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.TenthByOIX field.
	''' </summary>
	Public Property TenthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TenthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TenthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthByOIXDefault() As String
        Get
            Return TableUtils.TenthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.EleventhItem field.
	''' </summary>
	Public Property EleventhItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EleventhItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhItemDefault() As String
        Get
            Return TableUtils.EleventhItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.EleventhTypeID field.
	''' </summary>
	Public Property EleventhTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EleventhTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhTypeIDDefault() As String
        Get
            Return TableUtils.EleventhTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.EleventhDefault field.
	''' </summary>
	Public Property EleventhDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EleventhDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhDefaultDefault() As String
        Get
            Return TableUtils.EleventhDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.EleventhByCIX field.
	''' </summary>
	Public Property EleventhByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EleventhByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhByCIXDefault() As String
        Get
            Return TableUtils.EleventhByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.EleventhByOIX field.
	''' </summary>
	Public Property EleventhByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EleventhByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhByOIXDefault() As String
        Get
            Return TableUtils.EleventhByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.TwelfthItem field.
	''' </summary>
	Public Property TwelfthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TwelfthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthItemDefault() As String
        Get
            Return TableUtils.TwelfthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.TwelfthTypeID field.
	''' </summary>
	Public Property TwelfthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TwelfthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthTypeIDDefault() As String
        Get
            Return TableUtils.TwelfthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.TwelfthDefault field.
	''' </summary>
	Public Property TwelfthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TwelfthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthDefaultDefault() As String
        Get
            Return TableUtils.TwelfthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.TwelfthByCIX field.
	''' </summary>
	Public Property TwelfthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TwelfthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthByCIXDefault() As String
        Get
            Return TableUtils.TwelfthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.TwelfthByOIX field.
	''' </summary>
	Public Property TwelfthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TwelfthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthByOIXDefault() As String
        Get
            Return TableUtils.TwelfthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.ThirteenthItem field.
	''' </summary>
	Public Property ThirteenthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirteenthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthItemDefault() As String
        Get
            Return TableUtils.ThirteenthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.ThirteenthTypeID field.
	''' </summary>
	Public Property ThirteenthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirteenthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthTypeIDDefault() As String
        Get
            Return TableUtils.ThirteenthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.ThirteenthDefault field.
	''' </summary>
	Public Property ThirteenthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirteenthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthDefaultDefault() As String
        Get
            Return TableUtils.ThirteenthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.ThirteenthByCIX field.
	''' </summary>
	Public Property ThirteenthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirteenthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthByCIXDefault() As String
        Get
            Return TableUtils.ThirteenthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.ThirteenthByOIX field.
	''' </summary>
	Public Property ThirteenthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirteenthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthByOIXDefault() As String
        Get
            Return TableUtils.ThirteenthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FourteenthItem field.
	''' </summary>
	Public Property FourteenthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourteenthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthItemDefault() As String
        Get
            Return TableUtils.FourteenthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FourteenthTypeID field.
	''' </summary>
	Public Property FourteenthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourteenthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthTypeIDDefault() As String
        Get
            Return TableUtils.FourteenthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FourteenthDefault field.
	''' </summary>
	Public Property FourteenthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourteenthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthDefaultDefault() As String
        Get
            Return TableUtils.FourteenthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FourteenthByCIX field.
	''' </summary>
	Public Property FourteenthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourteenthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthByCIXDefault() As String
        Get
            Return TableUtils.FourteenthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FourteenthByOIX field.
	''' </summary>
	Public Property FourteenthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourteenthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthByOIXDefault() As String
        Get
            Return TableUtils.FourteenthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FifteenthItem field.
	''' </summary>
	Public Property FifteenthItem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifteenthItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthItemDefault() As String
        Get
            Return TableUtils.FifteenthItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FifteenthTypeID field.
	''' </summary>
	Public Property FifteenthTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifteenthTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthTypeIDDefault() As String
        Get
            Return TableUtils.FifteenthTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FifteenthDefault field.
	''' </summary>
	Public Property FifteenthDefault() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthDefaultColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifteenthDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthDefaultDefault() As String
        Get
            Return TableUtils.FifteenthDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FifteenthByCIX field.
	''' </summary>
	Public Property FifteenthByCIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthByCIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifteenthByCIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthByCIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthByCIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthByCIXDefault() As String
        Get
            Return TableUtils.FifteenthByCIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.FifteenthByOIX field.
	''' </summary>
	Public Property FifteenthByOIX() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthByOIXColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifteenthByOIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthByOIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthByOIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthByOIXDefault() As String
        Get
            Return TableUtils.FifteenthByOIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Agreement_.UpdatedAt field.
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
