' This class is "generated" and will be overwritten.
' Your customizations should be made in V_AgreementRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_AgreementRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_AgreementView"></see> class.
''' </remarks>
''' <seealso cref="V_AgreementView"></seealso>
''' <seealso cref="V_AgreementRecord"></seealso>

<Serializable()> Public Class BaseV_AgreementRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_AgreementView = V_AgreementView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_AgreementRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_AgreementRec As V_AgreementRecord = CType(sender,V_AgreementRecord)
        If Not V_AgreementRec Is Nothing AndAlso Not V_AgreementRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_AgreementRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_AgreementRec As V_AgreementRecord = CType(sender,V_AgreementRecord)
        Validate_Inserting()
        If Not V_AgreementRec Is Nothing AndAlso Not V_AgreementRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.ExecutionID field.
	''' </summary>
	Public Function GetExecutionIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExecutionIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.ExecutionID field.
	''' </summary>
	Public Function GetExecutionIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ExecutionIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.AgreementID field.
	''' </summary>
	Public Function GetAgreementIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AgreementIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.AgreementID field.
	''' </summary>
	Public Function GetAgreementIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AgreementIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.AgreementID field.
	''' </summary>
	Public Sub SetAgreementIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AgreementIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.CIX field.
	''' </summary>
	Public Function GetCIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.CIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.CIX field.
	''' </summary>
	Public Function GetCIXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CIXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.CIX field.
	''' </summary>
	Public Sub SetCIXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OIX field.
	''' </summary>
	Public Function GetOIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.OIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OIX field.
	''' </summary>
	Public Function GetOIXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.OIXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OIX field.
	''' </summary>
	Public Sub SetOIXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.DateToExecute field.
	''' </summary>
	Public Function GetDateToExecuteValue() As ColumnValue
		Return Me.GetValue(TableUtils.DateToExecuteColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.DateToExecute field.
	''' </summary>
	Public Function GetDateToExecuteFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DateToExecuteColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.DateToExecute field.
	''' </summary>
	Public Sub SetDateToExecuteFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DateToExecuteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.DateToExecute field.
	''' </summary>
	Public Sub SetDateToExecuteFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DateToExecuteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.DateToExecute field.
	''' </summary>
	Public Sub SetDateToExecuteFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DateToExecuteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerAddrID field.
	''' </summary>
	Public Function GetMakerAddrIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.MakerAddrIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerAddrID field.
	''' </summary>
	Public Function GetMakerAddrIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MakerAddrIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerAddrID field.
	''' </summary>
	Public Sub SetMakerAddrIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MakerAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerAddrID field.
	''' </summary>
	Public Sub SetMakerAddrIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MakerAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerAddrID field.
	''' </summary>
	Public Sub SetMakerAddrIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakerAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerAddrID field.
	''' </summary>
	Public Sub SetMakerAddrIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakerAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerAddrID field.
	''' </summary>
	Public Sub SetMakerAddrIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakerAddrIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerName field.
	''' </summary>
	Public Function GetMakerNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.MakerNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerName field.
	''' </summary>
	Public Function GetMakerNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MakerNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerName field.
	''' </summary>
	Public Sub SetMakerNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MakerNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerName field.
	''' </summary>
	Public Sub SetMakerNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakerNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerLogo field.
	''' </summary>
	Public Function GetMakerLogoValue() As ColumnValue
		Return Me.GetValue(TableUtils.MakerLogoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerLogo field.
	''' </summary>
	Public Function GetMakerLogoFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.MakerLogoColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerLogo field.
	''' </summary>
	Public Sub SetMakerLogoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MakerLogoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerLogo field.
	''' </summary>
	Public Sub SetMakerLogoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MakerLogoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerLogo field.
	''' </summary>
	Public Sub SetMakerLogoFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakerLogoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerAddr field.
	''' </summary>
	Public Function GetMakerAddrValue() As ColumnValue
		Return Me.GetValue(TableUtils.MakerAddrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerAddr field.
	''' </summary>
	Public Function GetMakerAddrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MakerAddrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerAddr field.
	''' </summary>
	Public Sub SetMakerAddrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MakerAddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerAddr field.
	''' </summary>
	Public Sub SetMakerAddrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakerAddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerCityST field.
	''' </summary>
	Public Function GetMakerCitySTValue() As ColumnValue
		Return Me.GetValue(TableUtils.MakerCitySTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerCityST field.
	''' </summary>
	Public Function GetMakerCitySTFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MakerCitySTColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerCityST field.
	''' </summary>
	Public Sub SetMakerCitySTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MakerCitySTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerCityST field.
	''' </summary>
	Public Sub SetMakerCitySTFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakerCitySTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerCountry field.
	''' </summary>
	Public Function GetMakerCountryValue() As ColumnValue
		Return Me.GetValue(TableUtils.MakerCountryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerCountry field.
	''' </summary>
	Public Function GetMakerCountryFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MakerCountryColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerCountry field.
	''' </summary>
	Public Sub SetMakerCountryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MakerCountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerCountry field.
	''' </summary>
	Public Sub SetMakerCountryFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakerCountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerSignerID field.
	''' </summary>
	Public Function GetMakerSignerIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.MakerSignerIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerSignerID field.
	''' </summary>
	Public Function GetMakerSignerIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MakerSignerIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerSignerID field.
	''' </summary>
	Public Sub SetMakerSignerIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MakerSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerSignerID field.
	''' </summary>
	Public Sub SetMakerSignerIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MakerSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerSignerID field.
	''' </summary>
	Public Sub SetMakerSignerIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakerSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerSignerID field.
	''' </summary>
	Public Sub SetMakerSignerIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakerSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerSignerID field.
	''' </summary>
	Public Sub SetMakerSignerIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakerSignerIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerSigner field.
	''' </summary>
	Public Function GetMakerSignerValue() As ColumnValue
		Return Me.GetValue(TableUtils.MakerSignerColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerSigner field.
	''' </summary>
	Public Function GetMakerSignerFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MakerSignerColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerSigner field.
	''' </summary>
	Public Sub SetMakerSignerFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MakerSignerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerSigner field.
	''' </summary>
	Public Sub SetMakerSignerFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakerSignerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerSignerTitle field.
	''' </summary>
	Public Function GetMakerSignerTitleValue() As ColumnValue
		Return Me.GetValue(TableUtils.MakerSignerTitleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerSignerTitle field.
	''' </summary>
	Public Function GetMakerSignerTitleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MakerSignerTitleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerSignerTitle field.
	''' </summary>
	Public Sub SetMakerSignerTitleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MakerSignerTitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerSignerTitle field.
	''' </summary>
	Public Sub SetMakerSignerTitleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakerSignerTitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerSignature field.
	''' </summary>
	Public Function GetMakerSignatureValue() As ColumnValue
		Return Me.GetValue(TableUtils.MakerSignatureColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.MakerSignature field.
	''' </summary>
	Public Function GetMakerSignatureFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.MakerSignatureColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerSignature field.
	''' </summary>
	Public Sub SetMakerSignatureFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MakerSignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerSignature field.
	''' </summary>
	Public Sub SetMakerSignatureFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MakerSignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.MakerSignature field.
	''' </summary>
	Public Sub SetMakerSignatureFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakerSignatureColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeAddrID field.
	''' </summary>
	Public Function GetOffereeAddrIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.OffereeAddrIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeAddrID field.
	''' </summary>
	Public Function GetOffereeAddrIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.OffereeAddrIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeAddrID field.
	''' </summary>
	Public Sub SetOffereeAddrIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OffereeAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeAddrID field.
	''' </summary>
	Public Sub SetOffereeAddrIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OffereeAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeAddrID field.
	''' </summary>
	Public Sub SetOffereeAddrIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OffereeAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeAddrID field.
	''' </summary>
	Public Sub SetOffereeAddrIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OffereeAddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeAddrID field.
	''' </summary>
	Public Sub SetOffereeAddrIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OffereeAddrIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeName field.
	''' </summary>
	Public Function GetOffereeNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.OffereeNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeName field.
	''' </summary>
	Public Function GetOffereeNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.OffereeNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeName field.
	''' </summary>
	Public Sub SetOffereeNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OffereeNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeName field.
	''' </summary>
	Public Sub SetOffereeNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OffereeNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeAddr field.
	''' </summary>
	Public Function GetOffereeAddrValue() As ColumnValue
		Return Me.GetValue(TableUtils.OffereeAddrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeAddr field.
	''' </summary>
	Public Function GetOffereeAddrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.OffereeAddrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeAddr field.
	''' </summary>
	Public Sub SetOffereeAddrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OffereeAddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeAddr field.
	''' </summary>
	Public Sub SetOffereeAddrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OffereeAddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeCityST field.
	''' </summary>
	Public Function GetOffereeCitySTValue() As ColumnValue
		Return Me.GetValue(TableUtils.OffereeCitySTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeCityST field.
	''' </summary>
	Public Function GetOffereeCitySTFieldValue() As String
		Return CType(Me.GetValue(TableUtils.OffereeCitySTColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeCityST field.
	''' </summary>
	Public Sub SetOffereeCitySTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OffereeCitySTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeCityST field.
	''' </summary>
	Public Sub SetOffereeCitySTFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OffereeCitySTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeCountry field.
	''' </summary>
	Public Function GetOffereeCountryValue() As ColumnValue
		Return Me.GetValue(TableUtils.OffereeCountryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeCountry field.
	''' </summary>
	Public Function GetOffereeCountryFieldValue() As String
		Return CType(Me.GetValue(TableUtils.OffereeCountryColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeCountry field.
	''' </summary>
	Public Sub SetOffereeCountryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OffereeCountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeCountry field.
	''' </summary>
	Public Sub SetOffereeCountryFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OffereeCountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeSignerID field.
	''' </summary>
	Public Function GetOffereeSignerIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.OffereeSignerIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeSignerID field.
	''' </summary>
	Public Function GetOffereeSignerIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.OffereeSignerIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeSignerID field.
	''' </summary>
	Public Sub SetOffereeSignerIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OffereeSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeSignerID field.
	''' </summary>
	Public Sub SetOffereeSignerIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OffereeSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeSignerID field.
	''' </summary>
	Public Sub SetOffereeSignerIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OffereeSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeSignerID field.
	''' </summary>
	Public Sub SetOffereeSignerIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OffereeSignerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeSignerID field.
	''' </summary>
	Public Sub SetOffereeSignerIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OffereeSignerIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeSigner field.
	''' </summary>
	Public Function GetOffereeSignerValue() As ColumnValue
		Return Me.GetValue(TableUtils.OffereeSignerColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeSigner field.
	''' </summary>
	Public Function GetOffereeSignerFieldValue() As String
		Return CType(Me.GetValue(TableUtils.OffereeSignerColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeSigner field.
	''' </summary>
	Public Sub SetOffereeSignerFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OffereeSignerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeSigner field.
	''' </summary>
	Public Sub SetOffereeSignerFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OffereeSignerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeSignerTitle field.
	''' </summary>
	Public Function GetOffereeSignerTitleValue() As ColumnValue
		Return Me.GetValue(TableUtils.OffereeSignerTitleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeSignerTitle field.
	''' </summary>
	Public Function GetOffereeSignerTitleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.OffereeSignerTitleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeSignerTitle field.
	''' </summary>
	Public Sub SetOffereeSignerTitleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OffereeSignerTitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeSignerTitle field.
	''' </summary>
	Public Sub SetOffereeSignerTitleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OffereeSignerTitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeSignature field.
	''' </summary>
	Public Function GetOffereeSignatureValue() As ColumnValue
		Return Me.GetValue(TableUtils.OffereeSignatureColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.OffereeSignature field.
	''' </summary>
	Public Function GetOffereeSignatureFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.OffereeSignatureColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeSignature field.
	''' </summary>
	Public Sub SetOffereeSignatureFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OffereeSignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeSignature field.
	''' </summary>
	Public Sub SetOffereeSignatureFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OffereeSignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.OffereeSignature field.
	''' </summary>
	Public Sub SetOffereeSignatureFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OffereeSignatureColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.FirstItemLabel field.
	''' </summary>
	Public Function GetFirstItemLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstItemLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.FirstItemLabel field.
	''' </summary>
	Public Function GetFirstItemLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstItemLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.FirstItemLabel field.
	''' </summary>
	Public Sub SetFirstItemLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.FirstItemLabel field.
	''' </summary>
	Public Sub SetFirstItemLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.FirstItem field.
	''' </summary>
	Public Function GetFirstItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.FirstItem field.
	''' </summary>
	Public Function GetFirstItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.FirstItem field.
	''' </summary>
	Public Sub SetFirstItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.FirstItem field.
	''' </summary>
	Public Sub SetFirstItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.SecondItemLabel field.
	''' </summary>
	Public Function GetSecondItemLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondItemLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.SecondItemLabel field.
	''' </summary>
	Public Function GetSecondItemLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SecondItemLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.SecondItemLabel field.
	''' </summary>
	Public Sub SetSecondItemLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.SecondItemLabel field.
	''' </summary>
	Public Sub SetSecondItemLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.SecondItem field.
	''' </summary>
	Public Function GetSecondItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.SecondItem field.
	''' </summary>
	Public Function GetSecondItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SecondItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.SecondItem field.
	''' </summary>
	Public Sub SetSecondItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.SecondItem field.
	''' </summary>
	Public Sub SetSecondItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.ThirdItemLabel field.
	''' </summary>
	Public Function GetThirdItemLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdItemLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.ThirdItemLabel field.
	''' </summary>
	Public Function GetThirdItemLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirdItemLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.ThirdItemLabel field.
	''' </summary>
	Public Sub SetThirdItemLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.ThirdItemLabel field.
	''' </summary>
	Public Sub SetThirdItemLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.ThirdItem field.
	''' </summary>
	Public Function GetThirdItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.ThirdItem field.
	''' </summary>
	Public Function GetThirdItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirdItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.ThirdItem field.
	''' </summary>
	Public Sub SetThirdItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.ThirdItem field.
	''' </summary>
	Public Sub SetThirdItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.FourthItemLabel field.
	''' </summary>
	Public Function GetFourthItemLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthItemLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.FourthItemLabel field.
	''' </summary>
	Public Function GetFourthItemLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourthItemLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.FourthItemLabel field.
	''' </summary>
	Public Sub SetFourthItemLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.FourthItemLabel field.
	''' </summary>
	Public Sub SetFourthItemLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.FourthItem field.
	''' </summary>
	Public Function GetFourthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.FourthItem field.
	''' </summary>
	Public Function GetFourthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.FourthItem field.
	''' </summary>
	Public Sub SetFourthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.FourthItem field.
	''' </summary>
	Public Sub SetFourthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.FifthItemLabel field.
	''' </summary>
	Public Function GetFifthItemLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthItemLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.FifthItemLabel field.
	''' </summary>
	Public Function GetFifthItemLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifthItemLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.FifthItemLabel field.
	''' </summary>
	Public Sub SetFifthItemLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.FifthItemLabel field.
	''' </summary>
	Public Sub SetFifthItemLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.FifthItem field.
	''' </summary>
	Public Function GetFifthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.FifthItem field.
	''' </summary>
	Public Function GetFifthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.FifthItem field.
	''' </summary>
	Public Sub SetFifthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.FifthItem field.
	''' </summary>
	Public Sub SetFifthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.SixthItemLabel field.
	''' </summary>
	Public Function GetSixthItemLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthItemLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.SixthItemLabel field.
	''' </summary>
	Public Function GetSixthItemLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SixthItemLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.SixthItemLabel field.
	''' </summary>
	Public Sub SetSixthItemLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.SixthItemLabel field.
	''' </summary>
	Public Sub SetSixthItemLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.SixthItem field.
	''' </summary>
	Public Function GetSixthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.SixthItem field.
	''' </summary>
	Public Function GetSixthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SixthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.SixthItem field.
	''' </summary>
	Public Sub SetSixthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.SixthItem field.
	''' </summary>
	Public Sub SetSixthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.SeventhItemLabel field.
	''' </summary>
	Public Function GetSeventhItemLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhItemLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.SeventhItemLabel field.
	''' </summary>
	Public Function GetSeventhItemLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SeventhItemLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.SeventhItemLabel field.
	''' </summary>
	Public Sub SetSeventhItemLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.SeventhItemLabel field.
	''' </summary>
	Public Sub SetSeventhItemLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.SeventhItem field.
	''' </summary>
	Public Function GetSeventhItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.SeventhItem field.
	''' </summary>
	Public Function GetSeventhItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SeventhItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.SeventhItem field.
	''' </summary>
	Public Sub SetSeventhItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.SeventhItem field.
	''' </summary>
	Public Sub SetSeventhItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.EightItemLabel field.
	''' </summary>
	Public Function GetEightItemLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.EightItemLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.EightItemLabel field.
	''' </summary>
	Public Function GetEightItemLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EightItemLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.EightItemLabel field.
	''' </summary>
	Public Sub SetEightItemLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EightItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.EightItemLabel field.
	''' </summary>
	Public Sub SetEightItemLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EightItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.EighthItem field.
	''' </summary>
	Public Function GetEighthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.EighthItem field.
	''' </summary>
	Public Function GetEighthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EighthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.EighthItem field.
	''' </summary>
	Public Sub SetEighthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.EighthItem field.
	''' </summary>
	Public Sub SetEighthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.NinthItemLabel field.
	''' </summary>
	Public Function GetNinthItemLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthItemLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.NinthItemLabel field.
	''' </summary>
	Public Function GetNinthItemLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NinthItemLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.NinthItemLabel field.
	''' </summary>
	Public Sub SetNinthItemLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.NinthItemLabel field.
	''' </summary>
	Public Sub SetNinthItemLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.NinthItem field.
	''' </summary>
	Public Function GetNinthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.NinthItem field.
	''' </summary>
	Public Function GetNinthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NinthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.NinthItem field.
	''' </summary>
	Public Sub SetNinthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.NinthItem field.
	''' </summary>
	Public Sub SetNinthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.TenthItemLabel field.
	''' </summary>
	Public Function GetTenthItemLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthItemLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.TenthItemLabel field.
	''' </summary>
	Public Function GetTenthItemLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TenthItemLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.TenthItemLabel field.
	''' </summary>
	Public Sub SetTenthItemLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.TenthItemLabel field.
	''' </summary>
	Public Sub SetTenthItemLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthItemLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.TenthItem field.
	''' </summary>
	Public Function GetTenthItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Agreement_.TenthItem field.
	''' </summary>
	Public Function GetTenthItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TenthItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.TenthItem field.
	''' </summary>
	Public Sub SetTenthItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Agreement_.TenthItem field.
	''' </summary>
	Public Sub SetTenthItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthItemColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.ExecutionID field.
	''' </summary>
	Public Property ExecutionID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ExecutionIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExecutionIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExecutionIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExecutionIDDefault() As String
        Get
            Return TableUtils.ExecutionIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.AgreementID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.CIX field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.OIX field.
	''' </summary>
	Public Property OIX() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.OIXColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OIXDefault() As String
        Get
            Return TableUtils.OIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.DateToExecute field.
	''' </summary>
	Public Property DateToExecute() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.DateToExecuteColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DateToExecuteColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DateToExecuteSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DateToExecuteColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DateToExecuteDefault() As String
        Get
            Return TableUtils.DateToExecuteColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.MakerAddrID field.
	''' </summary>
	Public Property MakerAddrID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MakerAddrIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MakerAddrIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MakerAddrIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MakerAddrIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MakerAddrIDDefault() As String
        Get
            Return TableUtils.MakerAddrIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.MakerName field.
	''' </summary>
	Public Property MakerName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MakerNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MakerNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MakerNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MakerNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MakerNameDefault() As String
        Get
            Return TableUtils.MakerNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.MakerLogo field.
	''' </summary>
	Public Property MakerLogo() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.MakerLogoColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MakerLogoColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MakerLogoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MakerLogoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MakerLogoDefault() As String
        Get
            Return TableUtils.MakerLogoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.MakerAddr field.
	''' </summary>
	Public Property MakerAddr() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MakerAddrColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MakerAddrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MakerAddrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MakerAddrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MakerAddrDefault() As String
        Get
            Return TableUtils.MakerAddrColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.MakerCityST field.
	''' </summary>
	Public Property MakerCityST() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MakerCitySTColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MakerCitySTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MakerCitySTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MakerCitySTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MakerCitySTDefault() As String
        Get
            Return TableUtils.MakerCitySTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.MakerCountry field.
	''' </summary>
	Public Property MakerCountry() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MakerCountryColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MakerCountryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MakerCountrySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MakerCountryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MakerCountryDefault() As String
        Get
            Return TableUtils.MakerCountryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.MakerSignerID field.
	''' </summary>
	Public Property MakerSignerID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MakerSignerIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MakerSignerIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MakerSignerIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MakerSignerIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MakerSignerIDDefault() As String
        Get
            Return TableUtils.MakerSignerIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.MakerSigner field.
	''' </summary>
	Public Property MakerSigner() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MakerSignerColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MakerSignerColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MakerSignerSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MakerSignerColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MakerSignerDefault() As String
        Get
            Return TableUtils.MakerSignerColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.MakerSignerTitle field.
	''' </summary>
	Public Property MakerSignerTitle() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MakerSignerTitleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MakerSignerTitleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MakerSignerTitleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MakerSignerTitleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MakerSignerTitleDefault() As String
        Get
            Return TableUtils.MakerSignerTitleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.MakerSignature field.
	''' </summary>
	Public Property MakerSignature() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.MakerSignatureColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MakerSignatureColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MakerSignatureSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MakerSignatureColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MakerSignatureDefault() As String
        Get
            Return TableUtils.MakerSignatureColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.OffereeAddrID field.
	''' </summary>
	Public Property OffereeAddrID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.OffereeAddrIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OffereeAddrIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OffereeAddrIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OffereeAddrIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OffereeAddrIDDefault() As String
        Get
            Return TableUtils.OffereeAddrIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.OffereeName field.
	''' </summary>
	Public Property OffereeName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.OffereeNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.OffereeNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OffereeNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OffereeNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OffereeNameDefault() As String
        Get
            Return TableUtils.OffereeNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.OffereeAddr field.
	''' </summary>
	Public Property OffereeAddr() As String
		Get 
			Return CType(Me.GetValue(TableUtils.OffereeAddrColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.OffereeAddrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OffereeAddrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OffereeAddrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OffereeAddrDefault() As String
        Get
            Return TableUtils.OffereeAddrColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.OffereeCityST field.
	''' </summary>
	Public Property OffereeCityST() As String
		Get 
			Return CType(Me.GetValue(TableUtils.OffereeCitySTColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.OffereeCitySTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OffereeCitySTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OffereeCitySTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OffereeCitySTDefault() As String
        Get
            Return TableUtils.OffereeCitySTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.OffereeCountry field.
	''' </summary>
	Public Property OffereeCountry() As String
		Get 
			Return CType(Me.GetValue(TableUtils.OffereeCountryColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.OffereeCountryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OffereeCountrySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OffereeCountryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OffereeCountryDefault() As String
        Get
            Return TableUtils.OffereeCountryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.OffereeSignerID field.
	''' </summary>
	Public Property OffereeSignerID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.OffereeSignerIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OffereeSignerIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OffereeSignerIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OffereeSignerIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OffereeSignerIDDefault() As String
        Get
            Return TableUtils.OffereeSignerIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.OffereeSigner field.
	''' </summary>
	Public Property OffereeSigner() As String
		Get 
			Return CType(Me.GetValue(TableUtils.OffereeSignerColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.OffereeSignerColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OffereeSignerSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OffereeSignerColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OffereeSignerDefault() As String
        Get
            Return TableUtils.OffereeSignerColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.OffereeSignerTitle field.
	''' </summary>
	Public Property OffereeSignerTitle() As String
		Get 
			Return CType(Me.GetValue(TableUtils.OffereeSignerTitleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.OffereeSignerTitleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OffereeSignerTitleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OffereeSignerTitleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OffereeSignerTitleDefault() As String
        Get
            Return TableUtils.OffereeSignerTitleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.OffereeSignature field.
	''' </summary>
	Public Property OffereeSignature() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.OffereeSignatureColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OffereeSignatureColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OffereeSignatureSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OffereeSignatureColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OffereeSignatureDefault() As String
        Get
            Return TableUtils.OffereeSignatureColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.FirstItemLabel field.
	''' </summary>
	Public Property FirstItemLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstItemLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstItemLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstItemLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstItemLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstItemLabelDefault() As String
        Get
            Return TableUtils.FirstItemLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.FirstItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.SecondItemLabel field.
	''' </summary>
	Public Property SecondItemLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SecondItemLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SecondItemLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondItemLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondItemLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondItemLabelDefault() As String
        Get
            Return TableUtils.SecondItemLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.SecondItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.ThirdItemLabel field.
	''' </summary>
	Public Property ThirdItemLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdItemLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirdItemLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdItemLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdItemLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdItemLabelDefault() As String
        Get
            Return TableUtils.ThirdItemLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.ThirdItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.FourthItemLabel field.
	''' </summary>
	Public Property FourthItemLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourthItemLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourthItemLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthItemLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthItemLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthItemLabelDefault() As String
        Get
            Return TableUtils.FourthItemLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.FourthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.FifthItemLabel field.
	''' </summary>
	Public Property FifthItemLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifthItemLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifthItemLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthItemLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthItemLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthItemLabelDefault() As String
        Get
            Return TableUtils.FifthItemLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.FifthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.SixthItemLabel field.
	''' </summary>
	Public Property SixthItemLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SixthItemLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SixthItemLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthItemLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthItemLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthItemLabelDefault() As String
        Get
            Return TableUtils.SixthItemLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.SixthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.SeventhItemLabel field.
	''' </summary>
	Public Property SeventhItemLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhItemLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SeventhItemLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhItemLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhItemLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhItemLabelDefault() As String
        Get
            Return TableUtils.SeventhItemLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.SeventhItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.EightItemLabel field.
	''' </summary>
	Public Property EightItemLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EightItemLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EightItemLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EightItemLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EightItemLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EightItemLabelDefault() As String
        Get
            Return TableUtils.EightItemLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.EighthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.NinthItemLabel field.
	''' </summary>
	Public Property NinthItemLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.NinthItemLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.NinthItemLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthItemLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthItemLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthItemLabelDefault() As String
        Get
            Return TableUtils.NinthItemLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.NinthItem field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.TenthItemLabel field.
	''' </summary>
	Public Property TenthItemLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TenthItemLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TenthItemLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthItemLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthItemLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthItemLabelDefault() As String
        Get
            Return TableUtils.TenthItemLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Agreement_.TenthItem field.
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



#End Region

End Class
End Namespace
