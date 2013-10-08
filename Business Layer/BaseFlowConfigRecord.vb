' This class is "generated" and will be overwritten.
' Your customizations should be made in FlowConfigRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="FlowConfigRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="FlowConfigTable"></see> class.
''' </remarks>
''' <seealso cref="FlowConfigTable"></seealso>
''' <seealso cref="FlowConfigRecord"></seealso>

<Serializable()> Public Class BaseFlowConfigRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As FlowConfigTable = FlowConfigTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub FlowConfigRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim FlowConfigRec As FlowConfigRecord = CType(sender,FlowConfigRecord)
        Validate_Inserting()
        If Not FlowConfigRec Is Nothing AndAlso Not FlowConfigRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub FlowConfigRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim FlowConfigRec As FlowConfigRecord = CType(sender,FlowConfigRecord)
        Validate_Updating()
        If Not FlowConfigRec Is Nothing AndAlso Not FlowConfigRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub FlowConfigRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim FlowConfigRec As FlowConfigRecord = CType(sender,FlowConfigRecord)
        If Not FlowConfigRec Is Nothing AndAlso Not FlowConfigRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ConfigID field.
	''' </summary>
	Public Function GetConfigIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ConfigIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ConfigID field.
	''' </summary>
	Public Function GetConfigIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ConfigIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FlowStepID field.
	''' </summary>
	Public Function GetFlowStepIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowStepIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FlowStepID field.
	''' </summary>
	Public Function GetFlowStepIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowStepIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ConfigRank field.
	''' </summary>
	Public Function GetConfigRankValue() As ColumnValue
		Return Me.GetValue(TableUtils.ConfigRankColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ConfigRank field.
	''' </summary>
	Public Function GetConfigRankFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ConfigRankColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ConfigRank field.
	''' </summary>
	Public Sub SetConfigRankFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ConfigRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ConfigRank field.
	''' </summary>
	Public Sub SetConfigRankFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ConfigRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ConfigRank field.
	''' </summary>
	Public Sub SetConfigRankFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ConfigRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ConfigRank field.
	''' </summary>
	Public Sub SetConfigRankFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ConfigRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ConfigRank field.
	''' </summary>
	Public Sub SetConfigRankFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ConfigRankColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.IntendedForID field.
	''' </summary>
	Public Function GetIntendedForIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.IntendedForIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.IntendedForID field.
	''' </summary>
	Public Function GetIntendedForIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.IntendedForIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.IntendedForID field.
	''' </summary>
	Public Sub SetIntendedForIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IntendedForIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.IntendedForID field.
	''' </summary>
	Public Sub SetIntendedForIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IntendedForIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.IntendedForID field.
	''' </summary>
	Public Sub SetIntendedForIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IntendedForIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.IntendedForID field.
	''' </summary>
	Public Sub SetIntendedForIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IntendedForIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.IntendedForID field.
	''' </summary>
	Public Sub SetIntendedForIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IntendedForIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.RoleID field.
	''' </summary>
	Public Function GetRoleIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RoleIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.RoleID field.
	''' </summary>
	Public Function GetRoleIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RoleIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.MustAct field.
	''' </summary>
	Public Function GetMustActValue() As ColumnValue
		Return Me.GetValue(TableUtils.MustActColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.MustAct field.
	''' </summary>
	Public Function GetMustActFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.MustActColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.MustAct field.
	''' </summary>
	Public Sub SetMustActFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MustActColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.MustAct field.
	''' </summary>
	Public Sub SetMustActFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MustActColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.MustAct field.
	''' </summary>
	Public Sub SetMustActFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MustActColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.SkipJump field.
	''' </summary>
	Public Function GetSkipJumpValue() As ColumnValue
		Return Me.GetValue(TableUtils.SkipJumpColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.SkipJump field.
	''' </summary>
	Public Function GetSkipJumpFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SkipJumpColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SkipJump field.
	''' </summary>
	Public Sub SetSkipJumpFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SkipJumpColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SkipJump field.
	''' </summary>
	Public Sub SetSkipJumpFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SkipJumpColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SkipJump field.
	''' </summary>
	Public Sub SetSkipJumpFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SkipJumpColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.SendMessage field.
	''' </summary>
	Public Function GetSendMessageValue() As ColumnValue
		Return Me.GetValue(TableUtils.SendMessageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.SendMessage field.
	''' </summary>
	Public Function GetSendMessageFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SendMessageColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SendMessage field.
	''' </summary>
	Public Sub SetSendMessageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SendMessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SendMessage field.
	''' </summary>
	Public Sub SetSendMessageFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SendMessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SendMessage field.
	''' </summary>
	Public Sub SetSendMessageFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SendMessageColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.Dashboard field.
	''' </summary>
	Public Function GetDashboardValue() As ColumnValue
		Return Me.GetValue(TableUtils.DashboardColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.Dashboard field.
	''' </summary>
	Public Function GetDashboardFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.DashboardColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.Dashboard field.
	''' </summary>
	Public Sub SetDashboardFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DashboardColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.Dashboard field.
	''' </summary>
	Public Sub SetDashboardFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DashboardColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.Dashboard field.
	''' </summary>
	Public Sub SetDashboardFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DashboardColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.PageTitle field.
	''' </summary>
	Public Function GetPageTitle0Value() As ColumnValue
		Return Me.GetValue(TableUtils.PageTitle0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.PageTitle field.
	''' </summary>
	Public Function GetPageTitle0FieldValue() As String
		Return CType(Me.GetValue(TableUtils.PageTitle0Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.PageTitle field.
	''' </summary>
	Public Sub SetPageTitle0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PageTitle0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.PageTitle field.
	''' </summary>
	Public Sub SetPageTitle0FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PageTitle0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.Instructions field.
	''' </summary>
	Public Function GetInstructionsValue() As ColumnValue
		Return Me.GetValue(TableUtils.InstructionsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.Instructions field.
	''' </summary>
	Public Function GetInstructionsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.InstructionsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.Instructions field.
	''' </summary>
	Public Sub SetInstructionsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.InstructionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.Instructions field.
	''' </summary>
	Public Sub SetInstructionsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstructionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.LandingRedirect field.
	''' </summary>
	Public Function GetLandingRedirectValue() As ColumnValue
		Return Me.GetValue(TableUtils.LandingRedirectColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.LandingRedirect field.
	''' </summary>
	Public Function GetLandingRedirectFieldValue() As String
		Return CType(Me.GetValue(TableUtils.LandingRedirectColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.LandingRedirect field.
	''' </summary>
	Public Sub SetLandingRedirectFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LandingRedirectColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.LandingRedirect field.
	''' </summary>
	Public Sub SetLandingRedirectFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LandingRedirectColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.GoAction field.
	''' </summary>
	Public Function GetGoActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.GoActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.GoAction field.
	''' </summary>
	Public Function GetGoActionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.GoActionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.GoAction field.
	''' </summary>
	Public Sub SetGoActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GoActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.GoAction field.
	''' </summary>
	Public Sub SetGoActionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GoActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.VideoURL field.
	''' </summary>
	Public Function GetVideoURLValue() As ColumnValue
		Return Me.GetValue(TableUtils.VideoURLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.VideoURL field.
	''' </summary>
	Public Function GetVideoURLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.VideoURLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.VideoURL field.
	''' </summary>
	Public Sub SetVideoURLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VideoURLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.VideoURL field.
	''' </summary>
	Public Sub SetVideoURLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VideoURLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.VideoDescription field.
	''' </summary>
	Public Function GetVideoDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.VideoDescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.VideoDescription field.
	''' </summary>
	Public Function GetVideoDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.VideoDescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.VideoDescription field.
	''' </summary>
	Public Sub SetVideoDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VideoDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.VideoDescription field.
	''' </summary>
	Public Sub SetVideoDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VideoDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FlowStepOneID field.
	''' </summary>
	Public Function GetFlowStepOneIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowStepOneIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FlowStepOneID field.
	''' </summary>
	Public Function GetFlowStepOneIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowStepOneIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepOneID field.
	''' </summary>
	Public Sub SetFlowStepOneIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowStepOneIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepOneID field.
	''' </summary>
	Public Sub SetFlowStepOneIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowStepOneIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepOneID field.
	''' </summary>
	Public Sub SetFlowStepOneIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepOneIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepOneID field.
	''' </summary>
	Public Sub SetFlowStepOneIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepOneIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepOneID field.
	''' </summary>
	Public Sub SetFlowStepOneIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepOneIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ButtonOneID field.
	''' </summary>
	Public Function GetButtonOneIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ButtonOneIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ButtonOneID field.
	''' </summary>
	Public Function GetButtonOneIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ButtonOneIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonOneID field.
	''' </summary>
	Public Sub SetButtonOneIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ButtonOneIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonOneID field.
	''' </summary>
	Public Sub SetButtonOneIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ButtonOneIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonOneID field.
	''' </summary>
	Public Sub SetButtonOneIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonOneIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonOneID field.
	''' </summary>
	Public Sub SetButtonOneIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonOneIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonOneID field.
	''' </summary>
	Public Sub SetButtonOneIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonOneIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FlowStepTwoID field.
	''' </summary>
	Public Function GetFlowStepTwoIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowStepTwoIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FlowStepTwoID field.
	''' </summary>
	Public Function GetFlowStepTwoIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowStepTwoIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepTwoID field.
	''' </summary>
	Public Sub SetFlowStepTwoIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowStepTwoIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepTwoID field.
	''' </summary>
	Public Sub SetFlowStepTwoIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowStepTwoIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepTwoID field.
	''' </summary>
	Public Sub SetFlowStepTwoIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepTwoIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepTwoID field.
	''' </summary>
	Public Sub SetFlowStepTwoIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepTwoIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepTwoID field.
	''' </summary>
	Public Sub SetFlowStepTwoIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepTwoIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ButtonTwoID field.
	''' </summary>
	Public Function GetButtonTwoIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ButtonTwoIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ButtonTwoID field.
	''' </summary>
	Public Function GetButtonTwoIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ButtonTwoIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonTwoID field.
	''' </summary>
	Public Sub SetButtonTwoIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ButtonTwoIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonTwoID field.
	''' </summary>
	Public Sub SetButtonTwoIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ButtonTwoIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonTwoID field.
	''' </summary>
	Public Sub SetButtonTwoIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonTwoIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonTwoID field.
	''' </summary>
	Public Sub SetButtonTwoIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonTwoIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonTwoID field.
	''' </summary>
	Public Sub SetButtonTwoIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonTwoIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FlowStepThreeID field.
	''' </summary>
	Public Function GetFlowStepThreeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowStepThreeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FlowStepThreeID field.
	''' </summary>
	Public Function GetFlowStepThreeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowStepThreeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepThreeID field.
	''' </summary>
	Public Sub SetFlowStepThreeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowStepThreeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepThreeID field.
	''' </summary>
	Public Sub SetFlowStepThreeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowStepThreeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepThreeID field.
	''' </summary>
	Public Sub SetFlowStepThreeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepThreeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepThreeID field.
	''' </summary>
	Public Sub SetFlowStepThreeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepThreeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepThreeID field.
	''' </summary>
	Public Sub SetFlowStepThreeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepThreeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ButtonThreeID field.
	''' </summary>
	Public Function GetButtonThreeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ButtonThreeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ButtonThreeID field.
	''' </summary>
	Public Function GetButtonThreeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ButtonThreeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonThreeID field.
	''' </summary>
	Public Sub SetButtonThreeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ButtonThreeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonThreeID field.
	''' </summary>
	Public Sub SetButtonThreeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ButtonThreeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonThreeID field.
	''' </summary>
	Public Sub SetButtonThreeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonThreeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonThreeID field.
	''' </summary>
	Public Sub SetButtonThreeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonThreeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonThreeID field.
	''' </summary>
	Public Sub SetButtonThreeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonThreeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FlowStepFourID field.
	''' </summary>
	Public Function GetFlowStepFourIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowStepFourIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FlowStepFourID field.
	''' </summary>
	Public Function GetFlowStepFourIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowStepFourIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepFourID field.
	''' </summary>
	Public Sub SetFlowStepFourIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowStepFourIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepFourID field.
	''' </summary>
	Public Sub SetFlowStepFourIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowStepFourIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepFourID field.
	''' </summary>
	Public Sub SetFlowStepFourIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepFourIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepFourID field.
	''' </summary>
	Public Sub SetFlowStepFourIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepFourIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FlowStepFourID field.
	''' </summary>
	Public Sub SetFlowStepFourIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepFourIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ButtonFourID field.
	''' </summary>
	Public Function GetButtonFourIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ButtonFourIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ButtonFourID field.
	''' </summary>
	Public Function GetButtonFourIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ButtonFourIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonFourID field.
	''' </summary>
	Public Sub SetButtonFourIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ButtonFourIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonFourID field.
	''' </summary>
	Public Sub SetButtonFourIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ButtonFourIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonFourID field.
	''' </summary>
	Public Sub SetButtonFourIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonFourIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonFourID field.
	''' </summary>
	Public Sub SetButtonFourIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonFourIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ButtonFourID field.
	''' </summary>
	Public Sub SetButtonFourIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonFourIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.RewindID field.
	''' </summary>
	Public Function GetRewindIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RewindIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.RewindID field.
	''' </summary>
	Public Function GetRewindIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RewindIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.RewindID field.
	''' </summary>
	Public Sub SetRewindIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RewindIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.RewindID field.
	''' </summary>
	Public Sub SetRewindIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RewindIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.RewindID field.
	''' </summary>
	Public Sub SetRewindIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RewindIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.RewindID field.
	''' </summary>
	Public Sub SetRewindIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RewindIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.RewindID field.
	''' </summary>
	Public Sub SetRewindIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RewindIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FirstElement field.
	''' </summary>
	Public Function GetFirstElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FirstElement field.
	''' </summary>
	Public Function GetFirstElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FirstElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FirstElement field.
	''' </summary>
	Public Sub SetFirstElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FirstElement field.
	''' </summary>
	Public Sub SetFirstElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FirstElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FirstElement field.
	''' </summary>
	Public Sub SetFirstElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.SecondElement field.
	''' </summary>
	Public Function GetSecondElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.SecondElement field.
	''' </summary>
	Public Function GetSecondElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SecondElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SecondElement field.
	''' </summary>
	Public Sub SetSecondElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SecondElement field.
	''' </summary>
	Public Sub SetSecondElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SecondElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SecondElement field.
	''' </summary>
	Public Sub SetSecondElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ThirdElement field.
	''' </summary>
	Public Function GetThirdElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ThirdElement field.
	''' </summary>
	Public Function GetThirdElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThirdElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ThirdElement field.
	''' </summary>
	Public Sub SetThirdElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ThirdElement field.
	''' </summary>
	Public Sub SetThirdElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirdElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ThirdElement field.
	''' </summary>
	Public Sub SetThirdElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FourthElement field.
	''' </summary>
	Public Function GetFourthElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FourthElement field.
	''' </summary>
	Public Function GetFourthElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FourthElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FourthElement field.
	''' </summary>
	Public Sub SetFourthElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FourthElement field.
	''' </summary>
	Public Sub SetFourthElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FourthElement field.
	''' </summary>
	Public Sub SetFourthElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FifthElement field.
	''' </summary>
	Public Function GetFifthElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FifthElement field.
	''' </summary>
	Public Function GetFifthElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FifthElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FifthElement field.
	''' </summary>
	Public Sub SetFifthElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FifthElement field.
	''' </summary>
	Public Sub SetFifthElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FifthElement field.
	''' </summary>
	Public Sub SetFifthElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.SixthElement field.
	''' </summary>
	Public Function GetSixthElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.SixthElement field.
	''' </summary>
	Public Function GetSixthElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SixthElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SixthElement field.
	''' </summary>
	Public Sub SetSixthElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SixthElement field.
	''' </summary>
	Public Sub SetSixthElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SixthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SixthElement field.
	''' </summary>
	Public Sub SetSixthElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.SeventhElement field.
	''' </summary>
	Public Function GetSeventhElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.SeventhElement field.
	''' </summary>
	Public Function GetSeventhElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SeventhElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SeventhElement field.
	''' </summary>
	Public Sub SetSeventhElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SeventhElement field.
	''' </summary>
	Public Sub SetSeventhElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SeventhElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.SeventhElement field.
	''' </summary>
	Public Sub SetSeventhElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.EighthElement field.
	''' </summary>
	Public Function GetEighthElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.EighthElement field.
	''' </summary>
	Public Function GetEighthElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.EighthElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.EighthElement field.
	''' </summary>
	Public Sub SetEighthElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.EighthElement field.
	''' </summary>
	Public Sub SetEighthElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EighthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.EighthElement field.
	''' </summary>
	Public Sub SetEighthElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.NinthElement field.
	''' </summary>
	Public Function GetNinthElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.NinthElement field.
	''' </summary>
	Public Function GetNinthElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.NinthElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.NinthElement field.
	''' </summary>
	Public Sub SetNinthElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.NinthElement field.
	''' </summary>
	Public Sub SetNinthElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.NinthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.NinthElement field.
	''' </summary>
	Public Sub SetNinthElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.TenthElement field.
	''' </summary>
	Public Function GetTenthElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.TenthElement field.
	''' </summary>
	Public Function GetTenthElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TenthElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.TenthElement field.
	''' </summary>
	Public Sub SetTenthElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.TenthElement field.
	''' </summary>
	Public Sub SetTenthElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TenthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.TenthElement field.
	''' </summary>
	Public Sub SetTenthElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.EleventhElement field.
	''' </summary>
	Public Function GetEleventhElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.EleventhElement field.
	''' </summary>
	Public Function GetEleventhElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.EleventhElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.EleventhElement field.
	''' </summary>
	Public Sub SetEleventhElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.EleventhElement field.
	''' </summary>
	Public Sub SetEleventhElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EleventhElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.EleventhElement field.
	''' </summary>
	Public Sub SetEleventhElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.TwelfthElement field.
	''' </summary>
	Public Function GetTwelfthElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.TwelfthElement field.
	''' </summary>
	Public Function GetTwelfthElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TwelfthElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.TwelfthElement field.
	''' </summary>
	Public Sub SetTwelfthElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.TwelfthElement field.
	''' </summary>
	Public Sub SetTwelfthElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TwelfthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.TwelfthElement field.
	''' </summary>
	Public Sub SetTwelfthElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ThirteenthElement field.
	''' </summary>
	Public Function GetThirteenthElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.ThirteenthElement field.
	''' </summary>
	Public Function GetThirteenthElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThirteenthElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ThirteenthElement field.
	''' </summary>
	Public Sub SetThirteenthElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ThirteenthElement field.
	''' </summary>
	Public Sub SetThirteenthElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirteenthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.ThirteenthElement field.
	''' </summary>
	Public Sub SetThirteenthElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FourteenthElement field.
	''' </summary>
	Public Function GetFourteenthElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FourteenthElement field.
	''' </summary>
	Public Function GetFourteenthElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FourteenthElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FourteenthElement field.
	''' </summary>
	Public Sub SetFourteenthElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FourteenthElement field.
	''' </summary>
	Public Sub SetFourteenthElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourteenthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FourteenthElement field.
	''' </summary>
	Public Sub SetFourteenthElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FifteenthElement field.
	''' </summary>
	Public Function GetFifteenthElementValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthElementColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.FifteenthElement field.
	''' </summary>
	Public Function GetFifteenthElementFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FifteenthElementColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FifteenthElement field.
	''' </summary>
	Public Sub SetFifteenthElementFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FifteenthElement field.
	''' </summary>
	Public Sub SetFifteenthElementFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifteenthElementColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.FifteenthElement field.
	''' </summary>
	Public Sub SetFifteenthElementFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthElementColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.CopyConfigID field.
	''' </summary>
	Public Function GetCopyConfigIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CopyConfigIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowConfig_.CopyConfigID field.
	''' </summary>
	Public Function GetCopyConfigIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CopyConfigIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.CopyConfigID field.
	''' </summary>
	Public Sub SetCopyConfigIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CopyConfigIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.CopyConfigID field.
	''' </summary>
	Public Sub SetCopyConfigIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CopyConfigIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.CopyConfigID field.
	''' </summary>
	Public Sub SetCopyConfigIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CopyConfigIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.CopyConfigID field.
	''' </summary>
	Public Sub SetCopyConfigIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CopyConfigIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowConfig_.CopyConfigID field.
	''' </summary>
	Public Sub SetCopyConfigIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CopyConfigIDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.ConfigID field.
	''' </summary>
	Public Property ConfigID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ConfigIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ConfigIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ConfigIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ConfigIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ConfigIDDefault() As String
        Get
            Return TableUtils.ConfigIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.FlowStepID field.
	''' </summary>
	Public Property FlowStepID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FlowStepIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FlowStepIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FlowStepIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FlowStepIDDefault() As String
        Get
            Return TableUtils.FlowStepIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.ConfigRank field.
	''' </summary>
	Public Property ConfigRank() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ConfigRankColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ConfigRankColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ConfigRankSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ConfigRankColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ConfigRankDefault() As String
        Get
            Return TableUtils.ConfigRankColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.IntendedForID field.
	''' </summary>
	Public Property IntendedForID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.IntendedForIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IntendedForIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IntendedForIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IntendedForIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IntendedForIDDefault() As String
        Get
            Return TableUtils.IntendedForIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.RoleID field.
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
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.MustAct field.
	''' </summary>
	Public Property MustAct() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.MustActColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MustActColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MustActSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MustActColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MustActDefault() As String
        Get
            Return TableUtils.MustActColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.SkipJump field.
	''' </summary>
	Public Property SkipJump() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SkipJumpColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SkipJumpColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SkipJumpSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SkipJumpColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SkipJumpDefault() As String
        Get
            Return TableUtils.SkipJumpColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.SendMessage field.
	''' </summary>
	Public Property SendMessage() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SendMessageColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SendMessageColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SendMessageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SendMessageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SendMessageDefault() As String
        Get
            Return TableUtils.SendMessageColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.Dashboard field.
	''' </summary>
	Public Property Dashboard() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.DashboardColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DashboardColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DashboardSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DashboardColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DashboardDefault() As String
        Get
            Return TableUtils.DashboardColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.PageTitle field.
	''' </summary>
	Public Property PageTitle0() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PageTitle0Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PageTitle0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PageTitle0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PageTitle0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PageTitle0Default() As String
        Get
            Return TableUtils.PageTitle0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.Instructions field.
	''' </summary>
	Public Property Instructions() As String
		Get 
			Return CType(Me.GetValue(TableUtils.InstructionsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.InstructionsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property InstructionsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.InstructionsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property InstructionsDefault() As String
        Get
            Return TableUtils.InstructionsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.LandingRedirect field.
	''' </summary>
	Public Property LandingRedirect() As String
		Get 
			Return CType(Me.GetValue(TableUtils.LandingRedirectColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.LandingRedirectColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LandingRedirectSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LandingRedirectColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LandingRedirectDefault() As String
        Get
            Return TableUtils.LandingRedirectColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.GoAction field.
	''' </summary>
	Public Property GoAction() As String
		Get 
			Return CType(Me.GetValue(TableUtils.GoActionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.GoActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GoActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GoActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GoActionDefault() As String
        Get
            Return TableUtils.GoActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.VideoURL field.
	''' </summary>
	Public Property VideoURL() As String
		Get 
			Return CType(Me.GetValue(TableUtils.VideoURLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.VideoURLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property VideoURLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.VideoURLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property VideoURLDefault() As String
        Get
            Return TableUtils.VideoURLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.VideoDescription field.
	''' </summary>
	Public Property VideoDescription() As String
		Get 
			Return CType(Me.GetValue(TableUtils.VideoDescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.VideoDescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property VideoDescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.VideoDescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property VideoDescriptionDefault() As String
        Get
            Return TableUtils.VideoDescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.FlowStepOneID field.
	''' </summary>
	Public Property FlowStepOneID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FlowStepOneIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FlowStepOneIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FlowStepOneIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FlowStepOneIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FlowStepOneIDDefault() As String
        Get
            Return TableUtils.FlowStepOneIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.ButtonOneID field.
	''' </summary>
	Public Property ButtonOneID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ButtonOneIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ButtonOneIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ButtonOneIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ButtonOneIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ButtonOneIDDefault() As String
        Get
            Return TableUtils.ButtonOneIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.FlowStepTwoID field.
	''' </summary>
	Public Property FlowStepTwoID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FlowStepTwoIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FlowStepTwoIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FlowStepTwoIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FlowStepTwoIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FlowStepTwoIDDefault() As String
        Get
            Return TableUtils.FlowStepTwoIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.ButtonTwoID field.
	''' </summary>
	Public Property ButtonTwoID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ButtonTwoIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ButtonTwoIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ButtonTwoIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ButtonTwoIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ButtonTwoIDDefault() As String
        Get
            Return TableUtils.ButtonTwoIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.FlowStepThreeID field.
	''' </summary>
	Public Property FlowStepThreeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FlowStepThreeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FlowStepThreeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FlowStepThreeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FlowStepThreeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FlowStepThreeIDDefault() As String
        Get
            Return TableUtils.FlowStepThreeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.ButtonThreeID field.
	''' </summary>
	Public Property ButtonThreeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ButtonThreeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ButtonThreeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ButtonThreeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ButtonThreeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ButtonThreeIDDefault() As String
        Get
            Return TableUtils.ButtonThreeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.FlowStepFourID field.
	''' </summary>
	Public Property FlowStepFourID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FlowStepFourIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FlowStepFourIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FlowStepFourIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FlowStepFourIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FlowStepFourIDDefault() As String
        Get
            Return TableUtils.FlowStepFourIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.ButtonFourID field.
	''' </summary>
	Public Property ButtonFourID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ButtonFourIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ButtonFourIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ButtonFourIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ButtonFourIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ButtonFourIDDefault() As String
        Get
            Return TableUtils.ButtonFourIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.RewindID field.
	''' </summary>
	Public Property RewindID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RewindIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RewindIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RewindIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RewindIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RewindIDDefault() As String
        Get
            Return TableUtils.RewindIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.FirstElement field.
	''' </summary>
	Public Property FirstElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FirstElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FirstElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstElementDefault() As String
        Get
            Return TableUtils.FirstElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.SecondElement field.
	''' </summary>
	Public Property SecondElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SecondElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SecondElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondElementDefault() As String
        Get
            Return TableUtils.SecondElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.ThirdElement field.
	''' </summary>
	Public Property ThirdElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirdElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdElementDefault() As String
        Get
            Return TableUtils.ThirdElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.FourthElement field.
	''' </summary>
	Public Property FourthElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FourthElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourthElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthElementDefault() As String
        Get
            Return TableUtils.FourthElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.FifthElement field.
	''' </summary>
	Public Property FifthElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FifthElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifthElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthElementDefault() As String
        Get
            Return TableUtils.FifthElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.SixthElement field.
	''' </summary>
	Public Property SixthElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SixthElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SixthElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthElementDefault() As String
        Get
            Return TableUtils.SixthElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.SeventhElement field.
	''' </summary>
	Public Property SeventhElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SeventhElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhElementDefault() As String
        Get
            Return TableUtils.SeventhElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.EighthElement field.
	''' </summary>
	Public Property EighthElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.EighthElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EighthElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthElementDefault() As String
        Get
            Return TableUtils.EighthElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.NinthElement field.
	''' </summary>
	Public Property NinthElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.NinthElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.NinthElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthElementDefault() As String
        Get
            Return TableUtils.NinthElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.TenthElement field.
	''' </summary>
	Public Property TenthElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TenthElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TenthElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthElementDefault() As String
        Get
            Return TableUtils.TenthElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.EleventhElement field.
	''' </summary>
	Public Property EleventhElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EleventhElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhElementDefault() As String
        Get
            Return TableUtils.EleventhElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.TwelfthElement field.
	''' </summary>
	Public Property TwelfthElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TwelfthElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthElementDefault() As String
        Get
            Return TableUtils.TwelfthElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.ThirteenthElement field.
	''' </summary>
	Public Property ThirteenthElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirteenthElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthElementDefault() As String
        Get
            Return TableUtils.ThirteenthElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.FourteenthElement field.
	''' </summary>
	Public Property FourteenthElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourteenthElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthElementDefault() As String
        Get
            Return TableUtils.FourteenthElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.FifteenthElement field.
	''' </summary>
	Public Property FifteenthElement() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthElementColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifteenthElementColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthElementSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthElementColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthElementDefault() As String
        Get
            Return TableUtils.FifteenthElementColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.UpdatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's FlowConfig_.CopyConfigID field.
	''' </summary>
	Public Property CopyConfigID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CopyConfigIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CopyConfigIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CopyConfigIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CopyConfigIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CopyConfigIDDefault() As String
        Get
            Return TableUtils.CopyConfigIDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
