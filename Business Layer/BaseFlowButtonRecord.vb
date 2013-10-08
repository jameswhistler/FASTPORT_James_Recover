' This class is "generated" and will be overwritten.
' Your customizations should be made in FlowButtonRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="FlowButtonRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="FlowButtonTable"></see> class.
''' </remarks>
''' <seealso cref="FlowButtonTable"></seealso>
''' <seealso cref="FlowButtonRecord"></seealso>

<Serializable()> Public Class BaseFlowButtonRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As FlowButtonTable = FlowButtonTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub FlowButtonRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim FlowButtonRec As FlowButtonRecord = CType(sender,FlowButtonRecord)
        Validate_Inserting()
        If Not FlowButtonRec Is Nothing AndAlso Not FlowButtonRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub FlowButtonRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim FlowButtonRec As FlowButtonRecord = CType(sender,FlowButtonRecord)
        Validate_Updating()
        If Not FlowButtonRec Is Nothing AndAlso Not FlowButtonRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub FlowButtonRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim FlowButtonRec As FlowButtonRecord = CType(sender,FlowButtonRecord)
        If Not FlowButtonRec Is Nothing AndAlso Not FlowButtonRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ButtonID field.
	''' </summary>
	Public Function GetButtonIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ButtonIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ButtonID field.
	''' </summary>
	Public Function GetButtonIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ButtonIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.FlowStepID field.
	''' </summary>
	Public Function GetFlowStepIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowStepIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.FlowStepID field.
	''' </summary>
	Public Function GetFlowStepIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowStepIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.FlowStepID field.
	''' </summary>
	Public Sub SetFlowStepIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowStepIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ButtonRank field.
	''' </summary>
	Public Function GetButtonRankValue() As ColumnValue
		Return Me.GetValue(TableUtils.ButtonRankColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ButtonRank field.
	''' </summary>
	Public Function GetButtonRankFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ButtonRankColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ButtonRank field.
	''' </summary>
	Public Sub SetButtonRankFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ButtonRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ButtonRank field.
	''' </summary>
	Public Sub SetButtonRankFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ButtonRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ButtonRank field.
	''' </summary>
	Public Sub SetButtonRankFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ButtonRank field.
	''' </summary>
	Public Sub SetButtonRankFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ButtonRank field.
	''' </summary>
	Public Sub SetButtonRankFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonRankColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.RefName field.
	''' </summary>
	Public Function GetRefNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.RefNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.RefName field.
	''' </summary>
	Public Function GetRefNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.RefNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.RefName field.
	''' </summary>
	Public Sub SetRefNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RefNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.RefName field.
	''' </summary>
	Public Sub SetRefNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RefNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ButtonText field.
	''' </summary>
	Public Function GetButtonTextValue() As ColumnValue
		Return Me.GetValue(TableUtils.ButtonTextColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ButtonText field.
	''' </summary>
	Public Function GetButtonTextFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ButtonTextColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ButtonText field.
	''' </summary>
	Public Sub SetButtonTextFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ButtonTextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ButtonText field.
	''' </summary>
	Public Sub SetButtonTextFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonTextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.HideButton field.
	''' </summary>
	Public Function GetHideButtonValue() As ColumnValue
		Return Me.GetValue(TableUtils.HideButtonColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.HideButton field.
	''' </summary>
	Public Function GetHideButtonFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.HideButtonColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.HideButton field.
	''' </summary>
	Public Sub SetHideButtonFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HideButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.HideButton field.
	''' </summary>
	Public Sub SetHideButtonFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HideButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.HideButton field.
	''' </summary>
	Public Sub SetHideButtonFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HideButtonColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ButtonToolTip field.
	''' </summary>
	Public Function GetButtonToolTipValue() As ColumnValue
		Return Me.GetValue(TableUtils.ButtonToolTipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ButtonToolTip field.
	''' </summary>
	Public Function GetButtonToolTipFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ButtonToolTipColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ButtonToolTip field.
	''' </summary>
	Public Sub SetButtonToolTipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ButtonToolTipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ButtonToolTip field.
	''' </summary>
	Public Sub SetButtonToolTipFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ButtonToolTipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ImportantCSS field.
	''' </summary>
	Public Function GetImportantCSSValue() As ColumnValue
		Return Me.GetValue(TableUtils.ImportantCSSColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ImportantCSS field.
	''' </summary>
	Public Function GetImportantCSSFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ImportantCSSColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ImportantCSS field.
	''' </summary>
	Public Sub SetImportantCSSFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ImportantCSSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ImportantCSS field.
	''' </summary>
	Public Sub SetImportantCSSFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ImportantCSSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ImportantCSS field.
	''' </summary>
	Public Sub SetImportantCSSFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ImportantCSSColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.Redirect field.
	''' </summary>
	Public Function GetRedirectValue() As ColumnValue
		Return Me.GetValue(TableUtils.RedirectColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.Redirect field.
	''' </summary>
	Public Function GetRedirectFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.RedirectColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.Redirect field.
	''' </summary>
	Public Sub SetRedirectFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RedirectColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.Redirect field.
	''' </summary>
	Public Sub SetRedirectFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RedirectColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.Redirect field.
	''' </summary>
	Public Sub SetRedirectFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RedirectColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.RedirectURL field.
	''' </summary>
	Public Function GetRedirectURLValue() As ColumnValue
		Return Me.GetValue(TableUtils.RedirectURLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.RedirectURL field.
	''' </summary>
	Public Function GetRedirectURLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.RedirectURLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.RedirectURL field.
	''' </summary>
	Public Sub SetRedirectURLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RedirectURLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.RedirectURL field.
	''' </summary>
	Public Sub SetRedirectURLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RedirectURLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.GoToCompletion field.
	''' </summary>
	Public Function GetGoToCompletionValue() As ColumnValue
		Return Me.GetValue(TableUtils.GoToCompletionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.GoToCompletion field.
	''' </summary>
	Public Function GetGoToCompletionFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.GoToCompletionColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.GoToCompletion field.
	''' </summary>
	Public Sub SetGoToCompletionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GoToCompletionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.GoToCompletion field.
	''' </summary>
	Public Sub SetGoToCompletionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.GoToCompletionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.GoToCompletion field.
	''' </summary>
	Public Sub SetGoToCompletionFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GoToCompletionColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.CompletionMessage field.
	''' </summary>
	Public Function GetCompletionMessageValue() As ColumnValue
		Return Me.GetValue(TableUtils.CompletionMessageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.CompletionMessage field.
	''' </summary>
	Public Function GetCompletionMessageFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CompletionMessageColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CompletionMessage field.
	''' </summary>
	Public Sub SetCompletionMessageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CompletionMessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CompletionMessage field.
	''' </summary>
	Public Sub SetCompletionMessageFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompletionMessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.SendMessage field.
	''' </summary>
	Public Function GetSendMessageValue() As ColumnValue
		Return Me.GetValue(TableUtils.SendMessageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.SendMessage field.
	''' </summary>
	Public Function GetSendMessageFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SendMessageColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.SendMessage field.
	''' </summary>
	Public Sub SetSendMessageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SendMessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.SendMessage field.
	''' </summary>
	Public Sub SetSendMessageFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SendMessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.SendMessage field.
	''' </summary>
	Public Sub SetSendMessageFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SendMessageColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.MessageSubject field.
	''' </summary>
	Public Function GetMessageSubjectValue() As ColumnValue
		Return Me.GetValue(TableUtils.MessageSubjectColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.MessageSubject field.
	''' </summary>
	Public Function GetMessageSubjectFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MessageSubjectColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.MessageSubject field.
	''' </summary>
	Public Sub SetMessageSubjectFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MessageSubjectColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.MessageSubject field.
	''' </summary>
	Public Sub SetMessageSubjectFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MessageSubjectColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.MessageAction field.
	''' </summary>
	Public Function GetMessageActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.MessageActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.MessageAction field.
	''' </summary>
	Public Function GetMessageActionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MessageActionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.MessageAction field.
	''' </summary>
	Public Sub SetMessageActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MessageActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.MessageAction field.
	''' </summary>
	Public Sub SetMessageActionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MessageActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.MessageButtonText field.
	''' </summary>
	Public Function GetMessageButtonTextValue() As ColumnValue
		Return Me.GetValue(TableUtils.MessageButtonTextColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.MessageButtonText field.
	''' </summary>
	Public Function GetMessageButtonTextFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MessageButtonTextColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.MessageButtonText field.
	''' </summary>
	Public Sub SetMessageButtonTextFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MessageButtonTextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.MessageButtonText field.
	''' </summary>
	Public Sub SetMessageButtonTextFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MessageButtonTextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ActionURL field.
	''' </summary>
	Public Function GetActionURLValue() As ColumnValue
		Return Me.GetValue(TableUtils.ActionURLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ActionURL field.
	''' </summary>
	Public Function GetActionURLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ActionURLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ActionURL field.
	''' </summary>
	Public Sub SetActionURLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ActionURLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ActionURL field.
	''' </summary>
	Public Sub SetActionURLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ActionURLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ExcludeParams field.
	''' </summary>
	Public Function GetExcludeParamsValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExcludeParamsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ExcludeParams field.
	''' </summary>
	Public Function GetExcludeParamsFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ExcludeParamsColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ExcludeParams field.
	''' </summary>
	Public Sub SetExcludeParamsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExcludeParamsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ExcludeParams field.
	''' </summary>
	Public Sub SetExcludeParamsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExcludeParamsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ExcludeParams field.
	''' </summary>
	Public Sub SetExcludeParamsFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExcludeParamsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.NoRadWindow field.
	''' </summary>
	Public Function GetNoRadWindowValue() As ColumnValue
		Return Me.GetValue(TableUtils.NoRadWindowColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.NoRadWindow field.
	''' </summary>
	Public Function GetNoRadWindowFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.NoRadWindowColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.NoRadWindow field.
	''' </summary>
	Public Sub SetNoRadWindowFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NoRadWindowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.NoRadWindow field.
	''' </summary>
	Public Sub SetNoRadWindowFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.NoRadWindowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.NoRadWindow field.
	''' </summary>
	Public Sub SetNoRadWindowFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NoRadWindowColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.GoAction field.
	''' </summary>
	Public Function GetGoActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.GoActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.GoAction field.
	''' </summary>
	Public Function GetGoActionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.GoActionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.GoAction field.
	''' </summary>
	Public Sub SetGoActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GoActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.GoAction field.
	''' </summary>
	Public Sub SetGoActionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GoActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.MessageBody field.
	''' </summary>
	Public Function GetMessageBodyValue() As ColumnValue
		Return Me.GetValue(TableUtils.MessageBodyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.MessageBody field.
	''' </summary>
	Public Function GetMessageBodyFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MessageBodyColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.MessageBody field.
	''' </summary>
	Public Sub SetMessageBodyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MessageBodyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.MessageBody field.
	''' </summary>
	Public Sub SetMessageBodyFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MessageBodyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.AutoMessage field.
	''' </summary>
	Public Function GetAutoMessageValue() As ColumnValue
		Return Me.GetValue(TableUtils.AutoMessageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.AutoMessage field.
	''' </summary>
	Public Function GetAutoMessageFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.AutoMessageColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.AutoMessage field.
	''' </summary>
	Public Sub SetAutoMessageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AutoMessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.AutoMessage field.
	''' </summary>
	Public Sub SetAutoMessageFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AutoMessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.AutoMessage field.
	''' </summary>
	Public Sub SetAutoMessageFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AutoMessageColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.CopySender field.
	''' </summary>
	Public Function GetCopySenderValue() As ColumnValue
		Return Me.GetValue(TableUtils.CopySenderColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.CopySender field.
	''' </summary>
	Public Function GetCopySenderFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.CopySenderColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CopySender field.
	''' </summary>
	Public Sub SetCopySenderFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CopySenderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CopySender field.
	''' </summary>
	Public Sub SetCopySenderFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CopySenderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CopySender field.
	''' </summary>
	Public Sub SetCopySenderFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CopySenderColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.IncludeAttachment field.
	''' </summary>
	Public Function GetIncludeAttachmentValue() As ColumnValue
		Return Me.GetValue(TableUtils.IncludeAttachmentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.IncludeAttachment field.
	''' </summary>
	Public Function GetIncludeAttachmentFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.IncludeAttachmentColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.IncludeAttachment field.
	''' </summary>
	Public Sub SetIncludeAttachmentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IncludeAttachmentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.IncludeAttachment field.
	''' </summary>
	Public Sub SetIncludeAttachmentFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IncludeAttachmentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.IncludeAttachment field.
	''' </summary>
	Public Sub SetIncludeAttachmentFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IncludeAttachmentColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.FirstButtonAction field.
	''' </summary>
	Public Function GetFirstButtonActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstButtonActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.FirstButtonAction field.
	''' </summary>
	Public Function GetFirstButtonActionFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FirstButtonActionColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.FirstButtonAction field.
	''' </summary>
	Public Sub SetFirstButtonActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.FirstButtonAction field.
	''' </summary>
	Public Sub SetFirstButtonActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FirstButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.FirstButtonAction field.
	''' </summary>
	Public Sub SetFirstButtonActionFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstButtonActionColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.SecondButtonAction field.
	''' </summary>
	Public Function GetSecondButtonActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondButtonActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.SecondButtonAction field.
	''' </summary>
	Public Function GetSecondButtonActionFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SecondButtonActionColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.SecondButtonAction field.
	''' </summary>
	Public Sub SetSecondButtonActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.SecondButtonAction field.
	''' </summary>
	Public Sub SetSecondButtonActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SecondButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.SecondButtonAction field.
	''' </summary>
	Public Sub SetSecondButtonActionFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondButtonActionColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ThirdButtonAction field.
	''' </summary>
	Public Function GetThirdButtonActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdButtonActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.ThirdButtonAction field.
	''' </summary>
	Public Function GetThirdButtonActionFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThirdButtonActionColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ThirdButtonAction field.
	''' </summary>
	Public Sub SetThirdButtonActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ThirdButtonAction field.
	''' </summary>
	Public Sub SetThirdButtonActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThirdButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.ThirdButtonAction field.
	''' </summary>
	Public Sub SetThirdButtonActionFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdButtonActionColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.FourthButtonAction field.
	''' </summary>
	Public Function GetFourthButtonActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthButtonActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.FourthButtonAction field.
	''' </summary>
	Public Function GetFourthButtonActionFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FourthButtonActionColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.FourthButtonAction field.
	''' </summary>
	Public Sub SetFourthButtonActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.FourthButtonAction field.
	''' </summary>
	Public Sub SetFourthButtonActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FourthButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.FourthButtonAction field.
	''' </summary>
	Public Sub SetFourthButtonActionFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthButtonActionColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.FifthButtonAction field.
	''' </summary>
	Public Function GetFifthButtonActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthButtonActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.FifthButtonAction field.
	''' </summary>
	Public Function GetFifthButtonActionFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FifthButtonActionColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.FifthButtonAction field.
	''' </summary>
	Public Sub SetFifthButtonActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.FifthButtonAction field.
	''' </summary>
	Public Sub SetFifthButtonActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FifthButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.FifthButtonAction field.
	''' </summary>
	Public Sub SetFifthButtonActionFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthButtonActionColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.SixthButtonAction field.
	''' </summary>
	Public Function GetSixthButtonActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthButtonActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.SixthButtonAction field.
	''' </summary>
	Public Function GetSixthButtonActionFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SixthButtonActionColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.SixthButtonAction field.
	''' </summary>
	Public Sub SetSixthButtonActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.SixthButtonAction field.
	''' </summary>
	Public Sub SetSixthButtonActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SixthButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.SixthButtonAction field.
	''' </summary>
	Public Sub SetSixthButtonActionFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthButtonActionColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.SeventhButtonAction field.
	''' </summary>
	Public Function GetSeventhButtonActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhButtonActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.SeventhButtonAction field.
	''' </summary>
	Public Function GetSeventhButtonActionFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SeventhButtonActionColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.SeventhButtonAction field.
	''' </summary>
	Public Sub SetSeventhButtonActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.SeventhButtonAction field.
	''' </summary>
	Public Sub SetSeventhButtonActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SeventhButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.SeventhButtonAction field.
	''' </summary>
	Public Sub SetSeventhButtonActionFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhButtonActionColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.EighthButtonAction field.
	''' </summary>
	Public Function GetEighthButtonActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthButtonActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.EighthButtonAction field.
	''' </summary>
	Public Function GetEighthButtonActionFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.EighthButtonActionColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.EighthButtonAction field.
	''' </summary>
	Public Sub SetEighthButtonActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.EighthButtonAction field.
	''' </summary>
	Public Sub SetEighthButtonActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EighthButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.EighthButtonAction field.
	''' </summary>
	Public Sub SetEighthButtonActionFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthButtonActionColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.NinthButtonAction field.
	''' </summary>
	Public Function GetNinthButtonActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthButtonActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.NinthButtonAction field.
	''' </summary>
	Public Function GetNinthButtonActionFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.NinthButtonActionColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.NinthButtonAction field.
	''' </summary>
	Public Sub SetNinthButtonActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.NinthButtonAction field.
	''' </summary>
	Public Sub SetNinthButtonActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.NinthButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.NinthButtonAction field.
	''' </summary>
	Public Sub SetNinthButtonActionFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthButtonActionColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.TenthButtonAction field.
	''' </summary>
	Public Function GetTenthButtonActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthButtonActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.TenthButtonAction field.
	''' </summary>
	Public Function GetTenthButtonActionFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.TenthButtonActionColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.TenthButtonAction field.
	''' </summary>
	Public Sub SetTenthButtonActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.TenthButtonAction field.
	''' </summary>
	Public Sub SetTenthButtonActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TenthButtonActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.TenthButtonAction field.
	''' </summary>
	Public Sub SetTenthButtonActionFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthButtonActionColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.CopyButtonID field.
	''' </summary>
	Public Function GetCopyButtonIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CopyButtonIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowButton_.CopyButtonID field.
	''' </summary>
	Public Function GetCopyButtonIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CopyButtonIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CopyButtonID field.
	''' </summary>
	Public Sub SetCopyButtonIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CopyButtonIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CopyButtonID field.
	''' </summary>
	Public Sub SetCopyButtonIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CopyButtonIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CopyButtonID field.
	''' </summary>
	Public Sub SetCopyButtonIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CopyButtonIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CopyButtonID field.
	''' </summary>
	Public Sub SetCopyButtonIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CopyButtonIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowButton_.CopyButtonID field.
	''' </summary>
	Public Sub SetCopyButtonIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CopyButtonIDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.ButtonID field.
	''' </summary>
	Public Property ButtonID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ButtonIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ButtonIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ButtonIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ButtonIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ButtonIDDefault() As String
        Get
            Return TableUtils.ButtonIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.FlowStepID field.
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
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.ButtonRank field.
	''' </summary>
	Public Property ButtonRank() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ButtonRankColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ButtonRankColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ButtonRankSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ButtonRankColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ButtonRankDefault() As String
        Get
            Return TableUtils.ButtonRankColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.RefName field.
	''' </summary>
	Public Property RefName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.RefNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.RefNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RefNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RefNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RefNameDefault() As String
        Get
            Return TableUtils.RefNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.ButtonText field.
	''' </summary>
	Public Property ButtonText() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ButtonTextColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ButtonTextColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ButtonTextSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ButtonTextColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ButtonTextDefault() As String
        Get
            Return TableUtils.ButtonTextColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.HideButton field.
	''' </summary>
	Public Property HideButton() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.HideButtonColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HideButtonColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HideButtonSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HideButtonColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HideButtonDefault() As String
        Get
            Return TableUtils.HideButtonColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.ButtonToolTip field.
	''' </summary>
	Public Property ButtonToolTip() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ButtonToolTipColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ButtonToolTipColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ButtonToolTipSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ButtonToolTipColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ButtonToolTipDefault() As String
        Get
            Return TableUtils.ButtonToolTipColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.ImportantCSS field.
	''' </summary>
	Public Property ImportantCSS() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ImportantCSSColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ImportantCSSColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ImportantCSSSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ImportantCSSColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ImportantCSSDefault() As String
        Get
            Return TableUtils.ImportantCSSColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.Redirect field.
	''' </summary>
	Public Property Redirect() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.RedirectColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RedirectColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RedirectSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RedirectColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RedirectDefault() As String
        Get
            Return TableUtils.RedirectColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.RedirectURL field.
	''' </summary>
	Public Property RedirectURL() As String
		Get 
			Return CType(Me.GetValue(TableUtils.RedirectURLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.RedirectURLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RedirectURLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RedirectURLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RedirectURLDefault() As String
        Get
            Return TableUtils.RedirectURLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.GoToCompletion field.
	''' </summary>
	Public Property GoToCompletion() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.GoToCompletionColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.GoToCompletionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GoToCompletionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GoToCompletionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GoToCompletionDefault() As String
        Get
            Return TableUtils.GoToCompletionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.CompletionMessage field.
	''' </summary>
	Public Property CompletionMessage() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CompletionMessageColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CompletionMessageColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CompletionMessageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CompletionMessageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CompletionMessageDefault() As String
        Get
            Return TableUtils.CompletionMessageColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.SendMessage field.
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
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.MessageSubject field.
	''' </summary>
	Public Property MessageSubject() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MessageSubjectColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MessageSubjectColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MessageSubjectSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MessageSubjectColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MessageSubjectDefault() As String
        Get
            Return TableUtils.MessageSubjectColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.MessageAction field.
	''' </summary>
	Public Property MessageAction() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MessageActionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MessageActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MessageActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MessageActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MessageActionDefault() As String
        Get
            Return TableUtils.MessageActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.MessageButtonText field.
	''' </summary>
	Public Property MessageButtonText() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MessageButtonTextColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MessageButtonTextColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MessageButtonTextSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MessageButtonTextColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MessageButtonTextDefault() As String
        Get
            Return TableUtils.MessageButtonTextColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.ActionURL field.
	''' </summary>
	Public Property ActionURL() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ActionURLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ActionURLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ActionURLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ActionURLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ActionURLDefault() As String
        Get
            Return TableUtils.ActionURLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.ExcludeParams field.
	''' </summary>
	Public Property ExcludeParams() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ExcludeParamsColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExcludeParamsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExcludeParamsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExcludeParamsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExcludeParamsDefault() As String
        Get
            Return TableUtils.ExcludeParamsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.NoRadWindow field.
	''' </summary>
	Public Property NoRadWindow() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.NoRadWindowColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.NoRadWindowColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NoRadWindowSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NoRadWindowColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NoRadWindowDefault() As String
        Get
            Return TableUtils.NoRadWindowColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.GoAction field.
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
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.MessageBody field.
	''' </summary>
	Public Property MessageBody() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MessageBodyColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MessageBodyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MessageBodySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MessageBodyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MessageBodyDefault() As String
        Get
            Return TableUtils.MessageBodyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.AutoMessage field.
	''' </summary>
	Public Property AutoMessage() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.AutoMessageColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AutoMessageColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AutoMessageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AutoMessageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AutoMessageDefault() As String
        Get
            Return TableUtils.AutoMessageColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.CopySender field.
	''' </summary>
	Public Property CopySender() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.CopySenderColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CopySenderColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CopySenderSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CopySenderColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CopySenderDefault() As String
        Get
            Return TableUtils.CopySenderColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.IncludeAttachment field.
	''' </summary>
	Public Property IncludeAttachment() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.IncludeAttachmentColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IncludeAttachmentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IncludeAttachmentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IncludeAttachmentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IncludeAttachmentDefault() As String
        Get
            Return TableUtils.IncludeAttachmentColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.FirstButtonAction field.
	''' </summary>
	Public Property FirstButtonAction() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FirstButtonActionColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FirstButtonActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstButtonActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstButtonActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstButtonActionDefault() As String
        Get
            Return TableUtils.FirstButtonActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.SecondButtonAction field.
	''' </summary>
	Public Property SecondButtonAction() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SecondButtonActionColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SecondButtonActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondButtonActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondButtonActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondButtonActionDefault() As String
        Get
            Return TableUtils.SecondButtonActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.ThirdButtonAction field.
	''' </summary>
	Public Property ThirdButtonAction() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdButtonActionColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThirdButtonActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdButtonActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdButtonActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdButtonActionDefault() As String
        Get
            Return TableUtils.ThirdButtonActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.FourthButtonAction field.
	''' </summary>
	Public Property FourthButtonAction() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FourthButtonActionColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FourthButtonActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthButtonActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthButtonActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthButtonActionDefault() As String
        Get
            Return TableUtils.FourthButtonActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.FifthButtonAction field.
	''' </summary>
	Public Property FifthButtonAction() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FifthButtonActionColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FifthButtonActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthButtonActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthButtonActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthButtonActionDefault() As String
        Get
            Return TableUtils.FifthButtonActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.SixthButtonAction field.
	''' </summary>
	Public Property SixthButtonAction() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SixthButtonActionColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SixthButtonActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthButtonActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthButtonActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthButtonActionDefault() As String
        Get
            Return TableUtils.SixthButtonActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.SeventhButtonAction field.
	''' </summary>
	Public Property SeventhButtonAction() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhButtonActionColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SeventhButtonActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhButtonActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhButtonActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhButtonActionDefault() As String
        Get
            Return TableUtils.SeventhButtonActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.EighthButtonAction field.
	''' </summary>
	Public Property EighthButtonAction() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.EighthButtonActionColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EighthButtonActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthButtonActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthButtonActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthButtonActionDefault() As String
        Get
            Return TableUtils.EighthButtonActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.NinthButtonAction field.
	''' </summary>
	Public Property NinthButtonAction() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.NinthButtonActionColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.NinthButtonActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthButtonActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthButtonActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthButtonActionDefault() As String
        Get
            Return TableUtils.NinthButtonActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.TenthButtonAction field.
	''' </summary>
	Public Property TenthButtonAction() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.TenthButtonActionColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TenthButtonActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthButtonActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthButtonActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthButtonActionDefault() As String
        Get
            Return TableUtils.TenthButtonActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.UpdatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's FlowButton_.CopyButtonID field.
	''' </summary>
	Public Property CopyButtonID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CopyButtonIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CopyButtonIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CopyButtonIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CopyButtonIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CopyButtonIDDefault() As String
        Get
            Return TableUtils.CopyButtonIDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
