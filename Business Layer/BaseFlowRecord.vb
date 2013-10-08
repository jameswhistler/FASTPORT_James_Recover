' This class is "generated" and will be overwritten.
' Your customizations should be made in FlowRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="FlowRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="FlowTable"></see> class.
''' </remarks>
''' <seealso cref="FlowTable"></seealso>
''' <seealso cref="FlowRecord"></seealso>

<Serializable()> Public Class BaseFlowRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As FlowTable = FlowTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub FlowRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim FlowRec As FlowRecord = CType(sender,FlowRecord)
        Validate_Inserting()
        If Not FlowRec Is Nothing AndAlso Not FlowRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub FlowRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim FlowRec As FlowRecord = CType(sender,FlowRecord)
        Validate_Updating()
        If Not FlowRec Is Nothing AndAlso Not FlowRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub FlowRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim FlowRec As FlowRecord = CType(sender,FlowRecord)
        If Not FlowRec Is Nothing AndAlso Not FlowRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FlowID field.
	''' </summary>
	Public Function GetFlowIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FlowID field.
	''' </summary>
	Public Function GetFlowIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FlowPage field.
	''' </summary>
	Public Function GetFlowPageValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowPageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FlowPage field.
	''' </summary>
	Public Function GetFlowPageFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FlowPageColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FlowPage field.
	''' </summary>
	Public Sub SetFlowPageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowPageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FlowPage field.
	''' </summary>
	Public Sub SetFlowPageFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowPageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FirstElementDesc field.
	''' </summary>
	Public Function GetFirstElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FirstElementDesc field.
	''' </summary>
	Public Function GetFirstElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FirstElementDesc field.
	''' </summary>
	Public Sub SetFirstElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FirstElementDesc field.
	''' </summary>
	Public Sub SetFirstElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.SecondElementDesc field.
	''' </summary>
	Public Function GetSecondElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.SecondElementDesc field.
	''' </summary>
	Public Function GetSecondElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SecondElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.SecondElementDesc field.
	''' </summary>
	Public Sub SetSecondElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.SecondElementDesc field.
	''' </summary>
	Public Sub SetSecondElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.ThirdElementDesc field.
	''' </summary>
	Public Function GetThirdElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.ThirdElementDesc field.
	''' </summary>
	Public Function GetThirdElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirdElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.ThirdElementDesc field.
	''' </summary>
	Public Sub SetThirdElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.ThirdElementDesc field.
	''' </summary>
	Public Sub SetThirdElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FourthElementDesc field.
	''' </summary>
	Public Function GetFourthElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FourthElementDesc field.
	''' </summary>
	Public Function GetFourthElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourthElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FourthElementDesc field.
	''' </summary>
	Public Sub SetFourthElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FourthElementDesc field.
	''' </summary>
	Public Sub SetFourthElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FifthElementDesc field.
	''' </summary>
	Public Function GetFifthElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FifthElementDesc field.
	''' </summary>
	Public Function GetFifthElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifthElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FifthElementDesc field.
	''' </summary>
	Public Sub SetFifthElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FifthElementDesc field.
	''' </summary>
	Public Sub SetFifthElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.SixthElementDesc field.
	''' </summary>
	Public Function GetSixthElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.SixthElementDesc field.
	''' </summary>
	Public Function GetSixthElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SixthElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.SixthElementDesc field.
	''' </summary>
	Public Sub SetSixthElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.SixthElementDesc field.
	''' </summary>
	Public Sub SetSixthElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.SeventhElementDesc field.
	''' </summary>
	Public Function GetSeventhElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.SeventhElementDesc field.
	''' </summary>
	Public Function GetSeventhElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SeventhElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.SeventhElementDesc field.
	''' </summary>
	Public Sub SetSeventhElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.SeventhElementDesc field.
	''' </summary>
	Public Sub SetSeventhElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.EighthElementDesc field.
	''' </summary>
	Public Function GetEighthElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.EighthElementDesc field.
	''' </summary>
	Public Function GetEighthElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EighthElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.EighthElementDesc field.
	''' </summary>
	Public Sub SetEighthElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.EighthElementDesc field.
	''' </summary>
	Public Sub SetEighthElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.NinthElementDesc field.
	''' </summary>
	Public Function GetNinthElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.NinthElementDesc field.
	''' </summary>
	Public Function GetNinthElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NinthElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.NinthElementDesc field.
	''' </summary>
	Public Sub SetNinthElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.NinthElementDesc field.
	''' </summary>
	Public Sub SetNinthElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.TenthElementDesc field.
	''' </summary>
	Public Function GetTenthElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.TenthElementDesc field.
	''' </summary>
	Public Function GetTenthElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TenthElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.TenthElementDesc field.
	''' </summary>
	Public Sub SetTenthElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.TenthElementDesc field.
	''' </summary>
	Public Sub SetTenthElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.EleventhElementDesc field.
	''' </summary>
	Public Function GetEleventhElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.EleventhElementDesc field.
	''' </summary>
	Public Function GetEleventhElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EleventhElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.EleventhElementDesc field.
	''' </summary>
	Public Sub SetEleventhElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.EleventhElementDesc field.
	''' </summary>
	Public Sub SetEleventhElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.TwelfthElementDesc field.
	''' </summary>
	Public Function GetTwelfthElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.TwelfthElementDesc field.
	''' </summary>
	Public Function GetTwelfthElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TwelfthElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.TwelfthElementDesc field.
	''' </summary>
	Public Sub SetTwelfthElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.TwelfthElementDesc field.
	''' </summary>
	Public Sub SetTwelfthElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.ThirteenthElementDesc field.
	''' </summary>
	Public Function GetThirteenthElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.ThirteenthElementDesc field.
	''' </summary>
	Public Function GetThirteenthElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirteenthElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.ThirteenthElementDesc field.
	''' </summary>
	Public Sub SetThirteenthElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.ThirteenthElementDesc field.
	''' </summary>
	Public Sub SetThirteenthElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FourteenthElementDesc field.
	''' </summary>
	Public Function GetFourteenthElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FourteenthElementDesc field.
	''' </summary>
	Public Function GetFourteenthElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourteenthElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FourteenthElementDesc field.
	''' </summary>
	Public Sub SetFourteenthElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FourteenthElementDesc field.
	''' </summary>
	Public Sub SetFourteenthElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FifteenthElementDesc field.
	''' </summary>
	Public Function GetFifteenthElementDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthElementDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FifteenthElementDesc field.
	''' </summary>
	Public Function GetFifteenthElementDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifteenthElementDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FifteenthElementDesc field.
	''' </summary>
	Public Sub SetFifteenthElementDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FifteenthElementDesc field.
	''' </summary>
	Public Sub SetFifteenthElementDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthElementDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FirstButtonDesc field.
	''' </summary>
	Public Function GetFirstButtonDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstButtonDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FirstButtonDesc field.
	''' </summary>
	Public Function GetFirstButtonDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstButtonDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FirstButtonDesc field.
	''' </summary>
	Public Sub SetFirstButtonDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FirstButtonDesc field.
	''' </summary>
	Public Sub SetFirstButtonDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.SecondButtonDesc field.
	''' </summary>
	Public Function GetSecondButtonDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondButtonDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.SecondButtonDesc field.
	''' </summary>
	Public Function GetSecondButtonDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SecondButtonDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.SecondButtonDesc field.
	''' </summary>
	Public Sub SetSecondButtonDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.SecondButtonDesc field.
	''' </summary>
	Public Sub SetSecondButtonDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.ThirdButtonDesc field.
	''' </summary>
	Public Function GetThirdButtonDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdButtonDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.ThirdButtonDesc field.
	''' </summary>
	Public Function GetThirdButtonDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirdButtonDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.ThirdButtonDesc field.
	''' </summary>
	Public Sub SetThirdButtonDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.ThirdButtonDesc field.
	''' </summary>
	Public Sub SetThirdButtonDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FourthButtonDesc field.
	''' </summary>
	Public Function GetFourthButtonDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthButtonDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FourthButtonDesc field.
	''' </summary>
	Public Function GetFourthButtonDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourthButtonDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FourthButtonDesc field.
	''' </summary>
	Public Sub SetFourthButtonDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FourthButtonDesc field.
	''' </summary>
	Public Sub SetFourthButtonDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FifthButtonDesc field.
	''' </summary>
	Public Function GetFifthButtonDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthButtonDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.FifthButtonDesc field.
	''' </summary>
	Public Function GetFifthButtonDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifthButtonDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FifthButtonDesc field.
	''' </summary>
	Public Sub SetFifthButtonDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.FifthButtonDesc field.
	''' </summary>
	Public Sub SetFifthButtonDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.SixthButtonDesc field.
	''' </summary>
	Public Function GetSixthButtonDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthButtonDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.SixthButtonDesc field.
	''' </summary>
	Public Function GetSixthButtonDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SixthButtonDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.SixthButtonDesc field.
	''' </summary>
	Public Sub SetSixthButtonDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.SixthButtonDesc field.
	''' </summary>
	Public Sub SetSixthButtonDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.SeventhButtonDesc field.
	''' </summary>
	Public Function GetSeventhButtonDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhButtonDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.SeventhButtonDesc field.
	''' </summary>
	Public Function GetSeventhButtonDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SeventhButtonDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.SeventhButtonDesc field.
	''' </summary>
	Public Sub SetSeventhButtonDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.SeventhButtonDesc field.
	''' </summary>
	Public Sub SetSeventhButtonDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.EighthButtonDesc field.
	''' </summary>
	Public Function GetEighthButtonDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthButtonDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.EighthButtonDesc field.
	''' </summary>
	Public Function GetEighthButtonDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EighthButtonDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.EighthButtonDesc field.
	''' </summary>
	Public Sub SetEighthButtonDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.EighthButtonDesc field.
	''' </summary>
	Public Sub SetEighthButtonDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.NinthButtonDesc field.
	''' </summary>
	Public Function GetNinthButtonDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthButtonDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.NinthButtonDesc field.
	''' </summary>
	Public Function GetNinthButtonDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NinthButtonDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.NinthButtonDesc field.
	''' </summary>
	Public Sub SetNinthButtonDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.NinthButtonDesc field.
	''' </summary>
	Public Sub SetNinthButtonDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.TenthButtonDesc field.
	''' </summary>
	Public Function GetTenthButtonDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthButtonDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.TenthButtonDesc field.
	''' </summary>
	Public Function GetTenthButtonDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TenthButtonDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.TenthButtonDesc field.
	''' </summary>
	Public Sub SetTenthButtonDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.TenthButtonDesc field.
	''' </summary>
	Public Sub SetTenthButtonDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthButtonDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.RelatedToID field.
	''' </summary>
	Public Function GetRelatedToIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RelatedToIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.RelatedToID field.
	''' </summary>
	Public Function GetRelatedToIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RelatedToIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.RelatedToID field.
	''' </summary>
	Public Sub SetRelatedToIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RelatedToIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.RelatedToID field.
	''' </summary>
	Public Sub SetRelatedToIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RelatedToIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.RelatedToID field.
	''' </summary>
	Public Sub SetRelatedToIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RelatedToIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.RelatedToID field.
	''' </summary>
	Public Sub SetRelatedToIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RelatedToIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.RelatedToID field.
	''' </summary>
	Public Sub SetRelatedToIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RelatedToIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Flow_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Flow_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.FlowID field.
	''' </summary>
	Public Property FlowID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FlowIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FlowIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FlowIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FlowIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FlowIDDefault() As String
        Get
            Return TableUtils.FlowIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.FlowPage field.
	''' </summary>
	Public Property FlowPage() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FlowPageColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FlowPageColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FlowPageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FlowPageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FlowPageDefault() As String
        Get
            Return TableUtils.FlowPageColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.FirstElementDesc field.
	''' </summary>
	Public Property FirstElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstElementDescDefault() As String
        Get
            Return TableUtils.FirstElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.SecondElementDesc field.
	''' </summary>
	Public Property SecondElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SecondElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SecondElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondElementDescDefault() As String
        Get
            Return TableUtils.SecondElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.ThirdElementDesc field.
	''' </summary>
	Public Property ThirdElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirdElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdElementDescDefault() As String
        Get
            Return TableUtils.ThirdElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.FourthElementDesc field.
	''' </summary>
	Public Property FourthElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourthElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourthElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthElementDescDefault() As String
        Get
            Return TableUtils.FourthElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.FifthElementDesc field.
	''' </summary>
	Public Property FifthElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifthElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifthElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthElementDescDefault() As String
        Get
            Return TableUtils.FifthElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.SixthElementDesc field.
	''' </summary>
	Public Property SixthElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SixthElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SixthElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthElementDescDefault() As String
        Get
            Return TableUtils.SixthElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.SeventhElementDesc field.
	''' </summary>
	Public Property SeventhElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SeventhElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhElementDescDefault() As String
        Get
            Return TableUtils.SeventhElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.EighthElementDesc field.
	''' </summary>
	Public Property EighthElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EighthElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EighthElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthElementDescDefault() As String
        Get
            Return TableUtils.EighthElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.NinthElementDesc field.
	''' </summary>
	Public Property NinthElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.NinthElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.NinthElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthElementDescDefault() As String
        Get
            Return TableUtils.NinthElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.TenthElementDesc field.
	''' </summary>
	Public Property TenthElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TenthElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TenthElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthElementDescDefault() As String
        Get
            Return TableUtils.TenthElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.EleventhElementDesc field.
	''' </summary>
	Public Property EleventhElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EleventhElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhElementDescDefault() As String
        Get
            Return TableUtils.EleventhElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.TwelfthElementDesc field.
	''' </summary>
	Public Property TwelfthElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TwelfthElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthElementDescDefault() As String
        Get
            Return TableUtils.TwelfthElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.ThirteenthElementDesc field.
	''' </summary>
	Public Property ThirteenthElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirteenthElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthElementDescDefault() As String
        Get
            Return TableUtils.ThirteenthElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.FourteenthElementDesc field.
	''' </summary>
	Public Property FourteenthElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourteenthElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthElementDescDefault() As String
        Get
            Return TableUtils.FourteenthElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.FifteenthElementDesc field.
	''' </summary>
	Public Property FifteenthElementDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthElementDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifteenthElementDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthElementDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthElementDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthElementDescDefault() As String
        Get
            Return TableUtils.FifteenthElementDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.FirstButtonDesc field.
	''' </summary>
	Public Property FirstButtonDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstButtonDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstButtonDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstButtonDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstButtonDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstButtonDescDefault() As String
        Get
            Return TableUtils.FirstButtonDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.SecondButtonDesc field.
	''' </summary>
	Public Property SecondButtonDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SecondButtonDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SecondButtonDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondButtonDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondButtonDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondButtonDescDefault() As String
        Get
            Return TableUtils.SecondButtonDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.ThirdButtonDesc field.
	''' </summary>
	Public Property ThirdButtonDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdButtonDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirdButtonDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdButtonDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdButtonDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdButtonDescDefault() As String
        Get
            Return TableUtils.ThirdButtonDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.FourthButtonDesc field.
	''' </summary>
	Public Property FourthButtonDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourthButtonDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourthButtonDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthButtonDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthButtonDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthButtonDescDefault() As String
        Get
            Return TableUtils.FourthButtonDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.FifthButtonDesc field.
	''' </summary>
	Public Property FifthButtonDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifthButtonDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifthButtonDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthButtonDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthButtonDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthButtonDescDefault() As String
        Get
            Return TableUtils.FifthButtonDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.SixthButtonDesc field.
	''' </summary>
	Public Property SixthButtonDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SixthButtonDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SixthButtonDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthButtonDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthButtonDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthButtonDescDefault() As String
        Get
            Return TableUtils.SixthButtonDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.SeventhButtonDesc field.
	''' </summary>
	Public Property SeventhButtonDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhButtonDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SeventhButtonDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhButtonDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhButtonDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhButtonDescDefault() As String
        Get
            Return TableUtils.SeventhButtonDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.EighthButtonDesc field.
	''' </summary>
	Public Property EighthButtonDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EighthButtonDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EighthButtonDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthButtonDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthButtonDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthButtonDescDefault() As String
        Get
            Return TableUtils.EighthButtonDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.NinthButtonDesc field.
	''' </summary>
	Public Property NinthButtonDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.NinthButtonDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.NinthButtonDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthButtonDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthButtonDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthButtonDescDefault() As String
        Get
            Return TableUtils.NinthButtonDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.TenthButtonDesc field.
	''' </summary>
	Public Property TenthButtonDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TenthButtonDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TenthButtonDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthButtonDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthButtonDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthButtonDescDefault() As String
        Get
            Return TableUtils.TenthButtonDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.RelatedToID field.
	''' </summary>
	Public Property RelatedToID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RelatedToIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RelatedToIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RelatedToIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RelatedToIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RelatedToIDDefault() As String
        Get
            Return TableUtils.RelatedToIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Flow_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Flow_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's Flow_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Flow_.UpdatedAt field.
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
