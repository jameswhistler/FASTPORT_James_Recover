' This class is "generated" and will be overwritten.
' Your customizations should be made in V_SignRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_SignRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_SignView"></see> class.
''' </remarks>
''' <seealso cref="V_SignView"></seealso>
''' <seealso cref="V_SignRecord"></seealso>

<Serializable()> Public Class BaseV_SignRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_SignView = V_SignView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_SignRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_SignRec As V_SignRecord = CType(sender,V_SignRecord)
        Validate_Inserting()
        If Not V_SignRec Is Nothing AndAlso Not V_SignRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_SignRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_SignRec As V_SignRecord = CType(sender,V_SignRecord)
        Validate_Updating()
        If Not V_SignRec Is Nothing AndAlso Not V_SignRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_SignRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_SignRec As V_SignRecord = CType(sender,V_SignRecord)
        If Not V_SignRec Is Nothing AndAlso Not V_SignRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.ExecutionID field.
	''' </summary>
	Public Function GetExecutionIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExecutionIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.ExecutionID field.
	''' </summary>
	Public Function GetExecutionIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ExecutionIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.SignedOn field.
	''' </summary>
	Public Function GetSignedOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.SignedOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.SignedOn field.
	''' </summary>
	Public Function GetSignedOnFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SignedOnColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.SignedOn field.
	''' </summary>
	Public Sub SetSignedOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SignedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.SignedOn field.
	''' </summary>
	Public Sub SetSignedOnFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SignedOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.ExpiresOn field.
	''' </summary>
	Public Function GetExpiresOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExpiresOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.ExpiresOn field.
	''' </summary>
	Public Function GetExpiresOnFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ExpiresOnColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ExpiresOn field.
	''' </summary>
	Public Sub SetExpiresOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExpiresOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ExpiresOn field.
	''' </summary>
	Public Sub SetExpiresOnFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExpiresOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.BarCode field.
	''' </summary>
	Public Function GetBarCodeValue() As ColumnValue
		Return Me.GetValue(TableUtils.BarCodeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.BarCode field.
	''' </summary>
	Public Function GetBarCodeFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.BarCodeColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.BarCode field.
	''' </summary>
	Public Sub SetBarCodeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.BarCodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.BarCode field.
	''' </summary>
	Public Sub SetBarCodeFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.BarCodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.BarCode field.
	''' </summary>
	Public Sub SetBarCodeFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BarCodeColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Logo field.
	''' </summary>
	Public Function GetC_LogoValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_LogoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Logo field.
	''' </summary>
	Public Function GetC_LogoFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.C_LogoColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Logo field.
	''' </summary>
	Public Sub SetC_LogoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_LogoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Logo field.
	''' </summary>
	Public Sub SetC_LogoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.C_LogoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Logo field.
	''' </summary>
	Public Sub SetC_LogoFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_LogoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_LogoSmall field.
	''' </summary>
	Public Function GetC_LogoSmallValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_LogoSmallColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_LogoSmall field.
	''' </summary>
	Public Function GetC_LogoSmallFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.C_LogoSmallColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_LogoSmall field.
	''' </summary>
	Public Sub SetC_LogoSmallFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_LogoSmallColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_LogoSmall field.
	''' </summary>
	Public Sub SetC_LogoSmallFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.C_LogoSmallColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_LogoSmall field.
	''' </summary>
	Public Sub SetC_LogoSmallFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_LogoSmallColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Name field.
	''' </summary>
	Public Function GetC_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Name field.
	''' </summary>
	Public Function GetC_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Name field.
	''' </summary>
	Public Sub SetC_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Name field.
	''' </summary>
	Public Sub SetC_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_DBA field.
	''' </summary>
	Public Function GetC_DBAValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_DBAColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_DBA field.
	''' </summary>
	Public Function GetC_DBAFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_DBAColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_DBA field.
	''' </summary>
	Public Sub SetC_DBAFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_DBAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_DBA field.
	''' </summary>
	Public Sub SetC_DBAFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_DBAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_DBAOrName field.
	''' </summary>
	Public Function GetC_DBAOrNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_DBAOrNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_DBAOrName field.
	''' </summary>
	Public Function GetC_DBAOrNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_DBAOrNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_DBAOrName field.
	''' </summary>
	Public Sub SetC_DBAOrNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_DBAOrNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_DBAOrName field.
	''' </summary>
	Public Sub SetC_DBAOrNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_DBAOrNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_AddrHTML field.
	''' </summary>
	Public Function GetC_AddrHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_AddrHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_AddrHTML field.
	''' </summary>
	Public Function GetC_AddrHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_AddrHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_AddrHTML field.
	''' </summary>
	Public Sub SetC_AddrHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_AddrHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_AddrHTML field.
	''' </summary>
	Public Sub SetC_AddrHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_AddrHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Addr field.
	''' </summary>
	Public Function GetC_AddrValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_AddrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Addr field.
	''' </summary>
	Public Function GetC_AddrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_AddrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Addr field.
	''' </summary>
	Public Sub SetC_AddrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Addr field.
	''' </summary>
	Public Sub SetC_AddrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_CitySTZip field.
	''' </summary>
	Public Function GetC_CitySTZipValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_CitySTZipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_CitySTZip field.
	''' </summary>
	Public Function GetC_CitySTZipFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_CitySTZipColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_CitySTZip field.
	''' </summary>
	Public Sub SetC_CitySTZipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_CitySTZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_CitySTZip field.
	''' </summary>
	Public Sub SetC_CitySTZipFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_CitySTZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_City field.
	''' </summary>
	Public Function GetC_CityValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_CityColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_City field.
	''' </summary>
	Public Function GetC_CityFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_CityColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_City field.
	''' </summary>
	Public Sub SetC_CityFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_CityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_City field.
	''' </summary>
	Public Sub SetC_CityFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_CityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_ST field.
	''' </summary>
	Public Function GetC_STValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_STColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_ST field.
	''' </summary>
	Public Function GetC_STFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_STColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_ST field.
	''' </summary>
	Public Sub SetC_STFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_STColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_ST field.
	''' </summary>
	Public Sub SetC_STFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_STColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Zip field.
	''' </summary>
	Public Function GetC_ZipValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_ZipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Zip field.
	''' </summary>
	Public Function GetC_ZipFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_ZipColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Zip field.
	''' </summary>
	Public Sub SetC_ZipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_ZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Zip field.
	''' </summary>
	Public Sub SetC_ZipFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_ZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Country field.
	''' </summary>
	Public Function GetC_CountryValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_CountryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Country field.
	''' </summary>
	Public Function GetC_CountryFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_CountryColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Country field.
	''' </summary>
	Public Sub SetC_CountryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Country field.
	''' </summary>
	Public Sub SetC_CountryFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Signer field.
	''' </summary>
	Public Function GetC_SignerValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_SignerColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Signer field.
	''' </summary>
	Public Function GetC_SignerFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_SignerColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Signer field.
	''' </summary>
	Public Sub SetC_SignerFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_SignerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Signer field.
	''' </summary>
	Public Sub SetC_SignerFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_SignerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_SignerTitle field.
	''' </summary>
	Public Function GetC_SignerTitleValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_SignerTitleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_SignerTitle field.
	''' </summary>
	Public Function GetC_SignerTitleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_SignerTitleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_SignerTitle field.
	''' </summary>
	Public Sub SetC_SignerTitleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_SignerTitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_SignerTitle field.
	''' </summary>
	Public Sub SetC_SignerTitleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_SignerTitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_SignerContactInfo field.
	''' </summary>
	Public Function GetC_SignerContactInfoValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_SignerContactInfoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_SignerContactInfo field.
	''' </summary>
	Public Function GetC_SignerContactInfoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_SignerContactInfoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_SignerContactInfo field.
	''' </summary>
	Public Sub SetC_SignerContactInfoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_SignerContactInfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_SignerContactInfo field.
	''' </summary>
	Public Sub SetC_SignerContactInfoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_SignerContactInfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Phone field.
	''' </summary>
	Public Function GetC_PhoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_PhoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Phone field.
	''' </summary>
	Public Function GetC_PhoneFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_PhoneColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Phone field.
	''' </summary>
	Public Sub SetC_PhoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_PhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Phone field.
	''' </summary>
	Public Sub SetC_PhoneFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_PhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Mobile field.
	''' </summary>
	Public Function GetC_MobileValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_MobileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Mobile field.
	''' </summary>
	Public Function GetC_MobileFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_MobileColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Mobile field.
	''' </summary>
	Public Sub SetC_MobileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_MobileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Mobile field.
	''' </summary>
	Public Sub SetC_MobileFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_MobileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_OtherPhone field.
	''' </summary>
	Public Function GetC_OtherPhoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_OtherPhoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_OtherPhone field.
	''' </summary>
	Public Function GetC_OtherPhoneFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_OtherPhoneColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_OtherPhone field.
	''' </summary>
	Public Sub SetC_OtherPhoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_OtherPhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_OtherPhone field.
	''' </summary>
	Public Sub SetC_OtherPhoneFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_OtherPhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Fax field.
	''' </summary>
	Public Function GetC_FaxValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_FaxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Fax field.
	''' </summary>
	Public Function GetC_FaxFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_FaxColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Fax field.
	''' </summary>
	Public Sub SetC_FaxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_FaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Fax field.
	''' </summary>
	Public Sub SetC_FaxFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_FaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Email field.
	''' </summary>
	Public Function GetC_EmailValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_EmailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Email field.
	''' </summary>
	Public Function GetC_EmailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_EmailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Email field.
	''' </summary>
	Public Sub SetC_EmailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Email field.
	''' </summary>
	Public Sub SetC_EmailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Signature field.
	''' </summary>
	Public Function GetC_SignatureValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_SignatureColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Signature field.
	''' </summary>
	Public Function GetC_SignatureFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.C_SignatureColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Signature field.
	''' </summary>
	Public Sub SetC_SignatureFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_SignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Signature field.
	''' </summary>
	Public Sub SetC_SignatureFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.C_SignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Signature field.
	''' </summary>
	Public Sub SetC_SignatureFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_SignatureColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_SignatureSmall field.
	''' </summary>
	Public Function GetC_SignatureSmallValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_SignatureSmallColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_SignatureSmall field.
	''' </summary>
	Public Function GetC_SignatureSmallFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.C_SignatureSmallColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_SignatureSmall field.
	''' </summary>
	Public Sub SetC_SignatureSmallFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_SignatureSmallColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_SignatureSmall field.
	''' </summary>
	Public Sub SetC_SignatureSmallFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.C_SignatureSmallColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_SignatureSmall field.
	''' </summary>
	Public Sub SetC_SignatureSmallFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_SignatureSmallColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Initials field.
	''' </summary>
	Public Function GetC_InitialsValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_InitialsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_Initials field.
	''' </summary>
	Public Function GetC_InitialsFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.C_InitialsColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Initials field.
	''' </summary>
	Public Sub SetC_InitialsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_InitialsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Initials field.
	''' </summary>
	Public Sub SetC_InitialsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.C_InitialsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_Initials field.
	''' </summary>
	Public Sub SetC_InitialsFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_InitialsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_DOT field.
	''' </summary>
	Public Function GetC_DOTValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_DOTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_DOT field.
	''' </summary>
	Public Function GetC_DOTFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_DOTColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_DOT field.
	''' </summary>
	Public Sub SetC_DOTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_DOTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_DOT field.
	''' </summary>
	Public Sub SetC_DOTFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_DOTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_MC field.
	''' </summary>
	Public Function GetC_MCValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_MCColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_MC field.
	''' </summary>
	Public Function GetC_MCFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_MCColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_MC field.
	''' </summary>
	Public Sub SetC_MCFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_MCColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_MC field.
	''' </summary>
	Public Sub SetC_MCFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_MCColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN field.
	''' </summary>
	Public Function GetC_EINValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_EINColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN field.
	''' </summary>
	Public Function GetC_EINFieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_EINColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN field.
	''' </summary>
	Public Sub SetC_EINFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_EINColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN field.
	''' </summary>
	Public Sub SetC_EINFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_EINColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN1 field.
	''' </summary>
	Public Function GetC_EIN1Value() As ColumnValue
		Return Me.GetValue(TableUtils.C_EIN1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN1 field.
	''' </summary>
	Public Function GetC_EIN1FieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_EIN1Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN1 field.
	''' </summary>
	Public Sub SetC_EIN1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_EIN1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN1 field.
	''' </summary>
	Public Sub SetC_EIN1FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_EIN1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN2 field.
	''' </summary>
	Public Function GetC_EIN2Value() As ColumnValue
		Return Me.GetValue(TableUtils.C_EIN2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN2 field.
	''' </summary>
	Public Function GetC_EIN2FieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_EIN2Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN2 field.
	''' </summary>
	Public Sub SetC_EIN2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_EIN2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN2 field.
	''' </summary>
	Public Sub SetC_EIN2FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_EIN2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN3 field.
	''' </summary>
	Public Function GetC_EIN3Value() As ColumnValue
		Return Me.GetValue(TableUtils.C_EIN3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN3 field.
	''' </summary>
	Public Function GetC_EIN3FieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_EIN3Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN3 field.
	''' </summary>
	Public Sub SetC_EIN3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_EIN3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN3 field.
	''' </summary>
	Public Sub SetC_EIN3FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_EIN3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN4 field.
	''' </summary>
	Public Function GetC_EIN4Value() As ColumnValue
		Return Me.GetValue(TableUtils.C_EIN4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN4 field.
	''' </summary>
	Public Function GetC_EIN4FieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_EIN4Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN4 field.
	''' </summary>
	Public Sub SetC_EIN4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_EIN4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN4 field.
	''' </summary>
	Public Sub SetC_EIN4FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_EIN4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN5 field.
	''' </summary>
	Public Function GetC_EIN5Value() As ColumnValue
		Return Me.GetValue(TableUtils.C_EIN5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN5 field.
	''' </summary>
	Public Function GetC_EIN5FieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_EIN5Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN5 field.
	''' </summary>
	Public Sub SetC_EIN5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_EIN5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN5 field.
	''' </summary>
	Public Sub SetC_EIN5FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_EIN5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN6 field.
	''' </summary>
	Public Function GetC_EIN6Value() As ColumnValue
		Return Me.GetValue(TableUtils.C_EIN6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN6 field.
	''' </summary>
	Public Function GetC_EIN6FieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_EIN6Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN6 field.
	''' </summary>
	Public Sub SetC_EIN6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_EIN6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN6 field.
	''' </summary>
	Public Sub SetC_EIN6FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_EIN6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN7 field.
	''' </summary>
	Public Function GetC_EIN7Value() As ColumnValue
		Return Me.GetValue(TableUtils.C_EIN7Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN7 field.
	''' </summary>
	Public Function GetC_EIN7FieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_EIN7Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN7 field.
	''' </summary>
	Public Sub SetC_EIN7FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_EIN7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN7 field.
	''' </summary>
	Public Sub SetC_EIN7FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_EIN7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN8 field.
	''' </summary>
	Public Function GetC_EIN8Value() As ColumnValue
		Return Me.GetValue(TableUtils.C_EIN8Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN8 field.
	''' </summary>
	Public Function GetC_EIN8FieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_EIN8Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN8 field.
	''' </summary>
	Public Sub SetC_EIN8FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_EIN8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN8 field.
	''' </summary>
	Public Sub SetC_EIN8FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_EIN8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN9 field.
	''' </summary>
	Public Function GetC_EIN9Value() As ColumnValue
		Return Me.GetValue(TableUtils.C_EIN9Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.C_EIN9 field.
	''' </summary>
	Public Function GetC_EIN9FieldValue() As String
		Return CType(Me.GetValue(TableUtils.C_EIN9Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN9 field.
	''' </summary>
	Public Sub SetC_EIN9FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_EIN9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.C_EIN9 field.
	''' </summary>
	Public Sub SetC_EIN9FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_EIN9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_ProfilePic field.
	''' </summary>
	Public Function GetD_ProfilePicValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_ProfilePicColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_ProfilePic field.
	''' </summary>
	Public Function GetD_ProfilePicFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.D_ProfilePicColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ProfilePic field.
	''' </summary>
	Public Sub SetD_ProfilePicFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_ProfilePicColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ProfilePic field.
	''' </summary>
	Public Sub SetD_ProfilePicFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.D_ProfilePicColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ProfilePic field.
	''' </summary>
	Public Sub SetD_ProfilePicFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_ProfilePicColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Name field.
	''' </summary>
	Public Function GetD_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Name field.
	''' </summary>
	Public Function GetD_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Name field.
	''' </summary>
	Public Sub SetD_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Name field.
	''' </summary>
	Public Sub SetD_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_ContactInfo field.
	''' </summary>
	Public Function GetD_ContactInfoValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_ContactInfoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_ContactInfo field.
	''' </summary>
	Public Function GetD_ContactInfoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_ContactInfoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ContactInfo field.
	''' </summary>
	Public Sub SetD_ContactInfoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_ContactInfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ContactInfo field.
	''' </summary>
	Public Sub SetD_ContactInfoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_ContactInfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Phone field.
	''' </summary>
	Public Function GetD_PhoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_PhoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Phone field.
	''' </summary>
	Public Function GetD_PhoneFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_PhoneColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Phone field.
	''' </summary>
	Public Sub SetD_PhoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_PhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Phone field.
	''' </summary>
	Public Sub SetD_PhoneFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_PhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Mobile field.
	''' </summary>
	Public Function GetD_MobileValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_MobileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Mobile field.
	''' </summary>
	Public Function GetD_MobileFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_MobileColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Mobile field.
	''' </summary>
	Public Sub SetD_MobileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_MobileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Mobile field.
	''' </summary>
	Public Sub SetD_MobileFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_MobileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_OtherPhone field.
	''' </summary>
	Public Function GetD_OtherPhoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_OtherPhoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_OtherPhone field.
	''' </summary>
	Public Function GetD_OtherPhoneFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_OtherPhoneColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_OtherPhone field.
	''' </summary>
	Public Sub SetD_OtherPhoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_OtherPhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_OtherPhone field.
	''' </summary>
	Public Sub SetD_OtherPhoneFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_OtherPhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Fax field.
	''' </summary>
	Public Function GetD_FaxValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_FaxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Fax field.
	''' </summary>
	Public Function GetD_FaxFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_FaxColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Fax field.
	''' </summary>
	Public Sub SetD_FaxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_FaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Fax field.
	''' </summary>
	Public Sub SetD_FaxFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_FaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Email field.
	''' </summary>
	Public Function GetD_EmailValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_EmailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Email field.
	''' </summary>
	Public Function GetD_EmailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_EmailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Email field.
	''' </summary>
	Public Sub SetD_EmailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Email field.
	''' </summary>
	Public Sub SetD_EmailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Signature field.
	''' </summary>
	Public Function GetD_SignatureValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_SignatureColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Signature field.
	''' </summary>
	Public Function GetD_SignatureFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.D_SignatureColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Signature field.
	''' </summary>
	Public Sub SetD_SignatureFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_SignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Signature field.
	''' </summary>
	Public Sub SetD_SignatureFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.D_SignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Signature field.
	''' </summary>
	Public Sub SetD_SignatureFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_SignatureColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SignatureSmall field.
	''' </summary>
	Public Function GetD_SignatureSmallValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_SignatureSmallColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SignatureSmall field.
	''' </summary>
	Public Function GetD_SignatureSmallFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.D_SignatureSmallColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SignatureSmall field.
	''' </summary>
	Public Sub SetD_SignatureSmallFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_SignatureSmallColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SignatureSmall field.
	''' </summary>
	Public Sub SetD_SignatureSmallFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.D_SignatureSmallColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SignatureSmall field.
	''' </summary>
	Public Sub SetD_SignatureSmallFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_SignatureSmallColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Initials field.
	''' </summary>
	Public Function GetD_InitialsValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_InitialsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Initials field.
	''' </summary>
	Public Function GetD_InitialsFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.D_InitialsColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Initials field.
	''' </summary>
	Public Sub SetD_InitialsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_InitialsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Initials field.
	''' </summary>
	Public Sub SetD_InitialsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.D_InitialsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Initials field.
	''' </summary>
	Public Sub SetD_InitialsFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_InitialsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Overview field.
	''' </summary>
	Public Function GetD_OverviewValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_OverviewColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Overview field.
	''' </summary>
	Public Function GetD_OverviewFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_OverviewColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Overview field.
	''' </summary>
	Public Sub SetD_OverviewFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_OverviewColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Overview field.
	''' </summary>
	Public Sub SetD_OverviewFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_OverviewColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Incidents field.
	''' </summary>
	Public Function GetD_IncidentsValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_IncidentsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Incidents field.
	''' </summary>
	Public Function GetD_IncidentsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_IncidentsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Incidents field.
	''' </summary>
	Public Sub SetD_IncidentsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_IncidentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Incidents field.
	''' </summary>
	Public Sub SetD_IncidentsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_IncidentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_ExpGeneral field.
	''' </summary>
	Public Function GetD_ExpGeneralValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_ExpGeneralColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_ExpGeneral field.
	''' </summary>
	Public Function GetD_ExpGeneralFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_ExpGeneralColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ExpGeneral field.
	''' </summary>
	Public Sub SetD_ExpGeneralFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_ExpGeneralColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ExpGeneral field.
	''' </summary>
	Public Sub SetD_ExpGeneralFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_ExpGeneralColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_ExpEquipment field.
	''' </summary>
	Public Function GetD_ExpEquipmentValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_ExpEquipmentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_ExpEquipment field.
	''' </summary>
	Public Function GetD_ExpEquipmentFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_ExpEquipmentColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ExpEquipment field.
	''' </summary>
	Public Sub SetD_ExpEquipmentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_ExpEquipmentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ExpEquipment field.
	''' </summary>
	Public Sub SetD_ExpEquipmentFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_ExpEquipmentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_ExpCargo field.
	''' </summary>
	Public Function GetD_ExpCargoValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_ExpCargoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_ExpCargo field.
	''' </summary>
	Public Function GetD_ExpCargoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_ExpCargoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ExpCargo field.
	''' </summary>
	Public Sub SetD_ExpCargoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_ExpCargoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ExpCargo field.
	''' </summary>
	Public Sub SetD_ExpCargoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_ExpCargoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_ExpRegions field.
	''' </summary>
	Public Function GetD_ExpRegionsValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_ExpRegionsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_ExpRegions field.
	''' </summary>
	Public Function GetD_ExpRegionsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_ExpRegionsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ExpRegions field.
	''' </summary>
	Public Sub SetD_ExpRegionsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_ExpRegionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ExpRegions field.
	''' </summary>
	Public Sub SetD_ExpRegionsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_ExpRegionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Gauge field.
	''' </summary>
	Public Function GetD_GaugeValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_GaugeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Gauge field.
	''' </summary>
	Public Function GetD_GaugeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_GaugeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Gauge field.
	''' </summary>
	Public Sub SetD_GaugeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_GaugeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Gauge field.
	''' </summary>
	Public Sub SetD_GaugeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_GaugeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_AddrHTML field.
	''' </summary>
	Public Function GetD_AddrHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_AddrHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_AddrHTML field.
	''' </summary>
	Public Function GetD_AddrHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_AddrHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_AddrHTML field.
	''' </summary>
	Public Sub SetD_AddrHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_AddrHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_AddrHTML field.
	''' </summary>
	Public Sub SetD_AddrHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_AddrHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Addr field.
	''' </summary>
	Public Function GetD_AddrValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_AddrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Addr field.
	''' </summary>
	Public Function GetD_AddrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_AddrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Addr field.
	''' </summary>
	Public Sub SetD_AddrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Addr field.
	''' </summary>
	Public Sub SetD_AddrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_CitySTZip field.
	''' </summary>
	Public Function GetD_CitySTZipValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_CitySTZipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_CitySTZip field.
	''' </summary>
	Public Function GetD_CitySTZipFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_CitySTZipColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_CitySTZip field.
	''' </summary>
	Public Sub SetD_CitySTZipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_CitySTZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_CitySTZip field.
	''' </summary>
	Public Sub SetD_CitySTZipFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_CitySTZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_City field.
	''' </summary>
	Public Function GetD_CityValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_CityColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_City field.
	''' </summary>
	Public Function GetD_CityFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_CityColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_City field.
	''' </summary>
	Public Sub SetD_CityFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_CityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_City field.
	''' </summary>
	Public Sub SetD_CityFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_CityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_ST field.
	''' </summary>
	Public Function GetD_STValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_STColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_ST field.
	''' </summary>
	Public Function GetD_STFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_STColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ST field.
	''' </summary>
	Public Sub SetD_STFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_STColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_ST field.
	''' </summary>
	Public Sub SetD_STFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_STColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Zip field.
	''' </summary>
	Public Function GetD_ZipValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_ZipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Zip field.
	''' </summary>
	Public Function GetD_ZipFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_ZipColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Zip field.
	''' </summary>
	Public Sub SetD_ZipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_ZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Zip field.
	''' </summary>
	Public Sub SetD_ZipFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_ZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Country field.
	''' </summary>
	Public Function GetD_CountryValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_CountryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Country field.
	''' </summary>
	Public Function GetD_CountryFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_CountryColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Country field.
	''' </summary>
	Public Sub SetD_CountryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Country field.
	''' </summary>
	Public Sub SetD_CountryFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_DOB field.
	''' </summary>
	Public Function GetD_DOBValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_DOBColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_DOB field.
	''' </summary>
	Public Function GetD_DOBFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_DOBColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_DOB field.
	''' </summary>
	Public Sub SetD_DOBFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_DOBColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_DOB field.
	''' </summary>
	Public Sub SetD_DOBFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_DOBColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_CDLInfo field.
	''' </summary>
	Public Function GetD_CDLInfoValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_CDLInfoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_CDLInfo field.
	''' </summary>
	Public Function GetD_CDLInfoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_CDLInfoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_CDLInfo field.
	''' </summary>
	Public Sub SetD_CDLInfoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_CDLInfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_CDLInfo field.
	''' </summary>
	Public Sub SetD_CDLInfoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_CDLInfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_CDLShort field.
	''' </summary>
	Public Function GetD_CDLShortValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_CDLShortColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_CDLShort field.
	''' </summary>
	Public Function GetD_CDLShortFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_CDLShortColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_CDLShort field.
	''' </summary>
	Public Sub SetD_CDLShortFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_CDLShortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_CDLShort field.
	''' </summary>
	Public Sub SetD_CDLShortFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_CDLShortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_CDLOnly field.
	''' </summary>
	Public Function GetD_CDLOnlyValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_CDLOnlyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_CDLOnly field.
	''' </summary>
	Public Function GetD_CDLOnlyFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_CDLOnlyColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_CDLOnly field.
	''' </summary>
	Public Sub SetD_CDLOnlyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_CDLOnlyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_CDLOnly field.
	''' </summary>
	Public Sub SetD_CDLOnlyFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_CDLOnlyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_CDLState field.
	''' </summary>
	Public Function GetD_CDLStateValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_CDLStateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_CDLState field.
	''' </summary>
	Public Function GetD_CDLStateFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_CDLStateColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_CDLState field.
	''' </summary>
	Public Sub SetD_CDLStateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_CDLStateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_CDLState field.
	''' </summary>
	Public Sub SetD_CDLStateFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_CDLStateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_USCitizen field.
	''' </summary>
	Public Function GetD_USCitizenValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_USCitizenColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_USCitizen field.
	''' </summary>
	Public Function GetD_USCitizenFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_USCitizenColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_USCitizen field.
	''' </summary>
	Public Sub SetD_USCitizenFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_USCitizenColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_USCitizen field.
	''' </summary>
	Public Sub SetD_USCitizenFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_USCitizenColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_PersonalInfo field.
	''' </summary>
	Public Function GetD_PersonalInfoValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_PersonalInfoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_PersonalInfo field.
	''' </summary>
	Public Function GetD_PersonalInfoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_PersonalInfoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_PersonalInfo field.
	''' </summary>
	Public Sub SetD_PersonalInfoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_PersonalInfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_PersonalInfo field.
	''' </summary>
	Public Sub SetD_PersonalInfoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_PersonalInfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SSN field.
	''' </summary>
	Public Function GetD_SSNValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_SSNColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SSN field.
	''' </summary>
	Public Function GetD_SSNFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_SSNColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SSN field.
	''' </summary>
	Public Sub SetD_SSNFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_SSNColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SSN field.
	''' </summary>
	Public Sub SetD_SSNFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_SSNColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SSX4 field.
	''' </summary>
	Public Function GetD_SSX4Value() As ColumnValue
		Return Me.GetValue(TableUtils.D_SSX4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SSX4 field.
	''' </summary>
	Public Function GetD_SSX4FieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_SSX4Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SSX4 field.
	''' </summary>
	Public Sub SetD_SSX4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_SSX4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SSX4 field.
	''' </summary>
	Public Sub SetD_SSX4FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_SSX4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS1 field.
	''' </summary>
	Public Function GetD_SS1Value() As ColumnValue
		Return Me.GetValue(TableUtils.D_SS1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS1 field.
	''' </summary>
	Public Function GetD_SS1FieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_SS1Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS1 field.
	''' </summary>
	Public Sub SetD_SS1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_SS1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS1 field.
	''' </summary>
	Public Sub SetD_SS1FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_SS1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS2 field.
	''' </summary>
	Public Function GetD_SS2Value() As ColumnValue
		Return Me.GetValue(TableUtils.D_SS2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS2 field.
	''' </summary>
	Public Function GetD_SS2FieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_SS2Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS2 field.
	''' </summary>
	Public Sub SetD_SS2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_SS2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS2 field.
	''' </summary>
	Public Sub SetD_SS2FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_SS2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS3 field.
	''' </summary>
	Public Function GetD_SS3Value() As ColumnValue
		Return Me.GetValue(TableUtils.D_SS3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS3 field.
	''' </summary>
	Public Function GetD_SS3FieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_SS3Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS3 field.
	''' </summary>
	Public Sub SetD_SS3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_SS3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS3 field.
	''' </summary>
	Public Sub SetD_SS3FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_SS3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS4 field.
	''' </summary>
	Public Function GetD_SS4Value() As ColumnValue
		Return Me.GetValue(TableUtils.D_SS4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS4 field.
	''' </summary>
	Public Function GetD_SS4FieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_SS4Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS4 field.
	''' </summary>
	Public Sub SetD_SS4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_SS4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS4 field.
	''' </summary>
	Public Sub SetD_SS4FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_SS4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS5 field.
	''' </summary>
	Public Function GetD_SS5Value() As ColumnValue
		Return Me.GetValue(TableUtils.D_SS5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS5 field.
	''' </summary>
	Public Function GetD_SS5FieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_SS5Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS5 field.
	''' </summary>
	Public Sub SetD_SS5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_SS5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS5 field.
	''' </summary>
	Public Sub SetD_SS5FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_SS5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS6 field.
	''' </summary>
	Public Function GetD_SS6Value() As ColumnValue
		Return Me.GetValue(TableUtils.D_SS6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS6 field.
	''' </summary>
	Public Function GetD_SS6FieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_SS6Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS6 field.
	''' </summary>
	Public Sub SetD_SS6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_SS6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS6 field.
	''' </summary>
	Public Sub SetD_SS6FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_SS6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS7 field.
	''' </summary>
	Public Function GetD_SS7Value() As ColumnValue
		Return Me.GetValue(TableUtils.D_SS7Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS7 field.
	''' </summary>
	Public Function GetD_SS7FieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_SS7Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS7 field.
	''' </summary>
	Public Sub SetD_SS7FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_SS7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS7 field.
	''' </summary>
	Public Sub SetD_SS7FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_SS7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS8 field.
	''' </summary>
	Public Function GetD_SS8Value() As ColumnValue
		Return Me.GetValue(TableUtils.D_SS8Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS8 field.
	''' </summary>
	Public Function GetD_SS8FieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_SS8Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS8 field.
	''' </summary>
	Public Sub SetD_SS8FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_SS8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS8 field.
	''' </summary>
	Public Sub SetD_SS8FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_SS8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS9 field.
	''' </summary>
	Public Function GetD_SS9Value() As ColumnValue
		Return Me.GetValue(TableUtils.D_SS9Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_SS9 field.
	''' </summary>
	Public Function GetD_SS9FieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_SS9Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS9 field.
	''' </summary>
	Public Sub SetD_SS9FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_SS9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_SS9 field.
	''' </summary>
	Public Sub SetD_SS9FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_SS9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_PRA field.
	''' </summary>
	Public Function GetD_PRAValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_PRAColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_PRA field.
	''' </summary>
	Public Function GetD_PRAFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_PRAColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_PRA field.
	''' </summary>
	Public Sub SetD_PRAFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_PRAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_PRA field.
	''' </summary>
	Public Sub SetD_PRAFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_PRAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_PRANumber field.
	''' </summary>
	Public Function GetD_PRANumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_PRANumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_PRANumber field.
	''' </summary>
	Public Function GetD_PRANumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_PRANumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_PRANumber field.
	''' </summary>
	Public Sub SetD_PRANumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_PRANumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_PRANumber field.
	''' </summary>
	Public Sub SetD_PRANumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_PRANumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Passport field.
	''' </summary>
	Public Function GetD_PassportValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_PassportColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_Passport field.
	''' </summary>
	Public Function GetD_PassportFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_PassportColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Passport field.
	''' </summary>
	Public Sub SetD_PassportFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_PassportColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_Passport field.
	''' </summary>
	Public Sub SetD_PassportFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_PassportColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_PassportExpiration field.
	''' </summary>
	Public Function GetD_PassportExpirationValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_PassportExpirationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_PassportExpiration field.
	''' </summary>
	Public Function GetD_PassportExpirationFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_PassportExpirationColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_PassportExpiration field.
	''' </summary>
	Public Sub SetD_PassportExpirationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_PassportExpirationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_PassportExpiration field.
	''' </summary>
	Public Sub SetD_PassportExpirationFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_PassportExpirationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_TerminalAssigned field.
	''' </summary>
	Public Function GetD_TerminalAssignedValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_TerminalAssignedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_TerminalAssigned field.
	''' </summary>
	Public Function GetD_TerminalAssignedFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_TerminalAssignedColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_TerminalAssigned field.
	''' </summary>
	Public Sub SetD_TerminalAssignedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_TerminalAssignedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_TerminalAssigned field.
	''' </summary>
	Public Sub SetD_TerminalAssignedFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_TerminalAssignedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_I9OtherAlien field.
	''' </summary>
	Public Function GetD_I9OtherAlienValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_I9OtherAlienColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_I9OtherAlien field.
	''' </summary>
	Public Function GetD_I9OtherAlienFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_I9OtherAlienColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_I9OtherAlien field.
	''' </summary>
	Public Sub SetD_I9OtherAlienFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_I9OtherAlienColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_I9OtherAlien field.
	''' </summary>
	Public Sub SetD_I9OtherAlienFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_I9OtherAlienColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_I9a field.
	''' </summary>
	Public Function GetD_I9aValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_I9aColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_I9a field.
	''' </summary>
	Public Function GetD_I9aFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_I9aColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_I9a field.
	''' </summary>
	Public Sub SetD_I9aFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_I9aColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_I9a field.
	''' </summary>
	Public Sub SetD_I9aFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_I9aColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_I9b field.
	''' </summary>
	Public Function GetD_I9bValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_I9bColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_I9b field.
	''' </summary>
	Public Function GetD_I9bFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_I9bColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_I9b field.
	''' </summary>
	Public Sub SetD_I9bFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_I9bColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_I9b field.
	''' </summary>
	Public Sub SetD_I9bFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_I9bColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_I9c field.
	''' </summary>
	Public Function GetD_I9cValue() As ColumnValue
		Return Me.GetValue(TableUtils.D_I9cColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.D_I9c field.
	''' </summary>
	Public Function GetD_I9cFieldValue() As String
		Return CType(Me.GetValue(TableUtils.D_I9cColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_I9c field.
	''' </summary>
	Public Sub SetD_I9cFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.D_I9cColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.D_I9c field.
	''' </summary>
	Public Sub SetD_I9cFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.D_I9cColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FirstLabel field.
	''' </summary>
	Public Function GetFirstLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FirstLabel field.
	''' </summary>
	Public Function GetFirstLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FirstLabel field.
	''' </summary>
	Public Sub SetFirstLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FirstLabel field.
	''' </summary>
	Public Sub SetFirstLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FirstValue field.
	''' </summary>
	Public Function GetFirstValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FirstValue field.
	''' </summary>
	Public Function GetFirstValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FirstValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FirstValue field.
	''' </summary>
	Public Sub SetFirstValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FirstValue field.
	''' </summary>
	Public Sub SetFirstValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.SecondLabel field.
	''' </summary>
	Public Function GetSecondLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.SecondLabel field.
	''' </summary>
	Public Function GetSecondLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SecondLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.SecondLabel field.
	''' </summary>
	Public Sub SetSecondLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.SecondLabel field.
	''' </summary>
	Public Sub SetSecondLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.SecondValue field.
	''' </summary>
	Public Function GetSecondValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.SecondValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.SecondValue field.
	''' </summary>
	Public Function GetSecondValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SecondValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.SecondValue field.
	''' </summary>
	Public Sub SetSecondValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SecondValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.SecondValue field.
	''' </summary>
	Public Sub SetSecondValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SecondValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.ThirdLabel field.
	''' </summary>
	Public Function GetThirdLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.ThirdLabel field.
	''' </summary>
	Public Function GetThirdLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirdLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ThirdLabel field.
	''' </summary>
	Public Sub SetThirdLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ThirdLabel field.
	''' </summary>
	Public Sub SetThirdLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.ThirdValue field.
	''' </summary>
	Public Function GetThirdValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirdValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.ThirdValue field.
	''' </summary>
	Public Function GetThirdValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirdValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ThirdValue field.
	''' </summary>
	Public Sub SetThirdValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirdValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ThirdValue field.
	''' </summary>
	Public Sub SetThirdValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirdValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FourthLabel field.
	''' </summary>
	Public Function GetFourthLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FourthLabel field.
	''' </summary>
	Public Function GetFourthLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourthLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FourthLabel field.
	''' </summary>
	Public Sub SetFourthLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FourthLabel field.
	''' </summary>
	Public Sub SetFourthLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FourthValue field.
	''' </summary>
	Public Function GetFourthValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourthValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FourthValue field.
	''' </summary>
	Public Function GetFourthValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourthValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FourthValue field.
	''' </summary>
	Public Sub SetFourthValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FourthValue field.
	''' </summary>
	Public Sub SetFourthValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FifthLabel field.
	''' </summary>
	Public Function GetFifthLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FifthLabel field.
	''' </summary>
	Public Function GetFifthLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifthLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FifthLabel field.
	''' </summary>
	Public Sub SetFifthLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FifthLabel field.
	''' </summary>
	Public Sub SetFifthLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FifthValue field.
	''' </summary>
	Public Function GetFifthValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifthValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FifthValue field.
	''' </summary>
	Public Function GetFifthValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifthValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FifthValue field.
	''' </summary>
	Public Sub SetFifthValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FifthValue field.
	''' </summary>
	Public Sub SetFifthValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.SixthLabel field.
	''' </summary>
	Public Function GetSixthLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.SixthLabel field.
	''' </summary>
	Public Function GetSixthLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SixthLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.SixthLabel field.
	''' </summary>
	Public Sub SetSixthLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.SixthLabel field.
	''' </summary>
	Public Sub SetSixthLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.SixthValue field.
	''' </summary>
	Public Function GetSixthValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.SixthValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.SixthValue field.
	''' </summary>
	Public Function GetSixthValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SixthValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.SixthValue field.
	''' </summary>
	Public Sub SetSixthValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SixthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.SixthValue field.
	''' </summary>
	Public Sub SetSixthValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SixthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.SeventhLabel field.
	''' </summary>
	Public Function GetSeventhLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.SeventhLabel field.
	''' </summary>
	Public Function GetSeventhLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SeventhLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.SeventhLabel field.
	''' </summary>
	Public Sub SetSeventhLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.SeventhLabel field.
	''' </summary>
	Public Sub SetSeventhLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.SeventhValue field.
	''' </summary>
	Public Function GetSeventhValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeventhValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.SeventhValue field.
	''' </summary>
	Public Function GetSeventhValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SeventhValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.SeventhValue field.
	''' </summary>
	Public Sub SetSeventhValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeventhValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.SeventhValue field.
	''' </summary>
	Public Sub SetSeventhValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeventhValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.EighthLabel field.
	''' </summary>
	Public Function GetEighthLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.EighthLabel field.
	''' </summary>
	Public Function GetEighthLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EighthLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.EighthLabel field.
	''' </summary>
	Public Sub SetEighthLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.EighthLabel field.
	''' </summary>
	Public Sub SetEighthLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.EighthValue field.
	''' </summary>
	Public Function GetEighthValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.EighthValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.EighthValue field.
	''' </summary>
	Public Function GetEighthValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EighthValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.EighthValue field.
	''' </summary>
	Public Sub SetEighthValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EighthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.EighthValue field.
	''' </summary>
	Public Sub SetEighthValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EighthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.NinthLabel field.
	''' </summary>
	Public Function GetNinthLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.NinthLabel field.
	''' </summary>
	Public Function GetNinthLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NinthLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.NinthLabel field.
	''' </summary>
	Public Sub SetNinthLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.NinthLabel field.
	''' </summary>
	Public Sub SetNinthLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.NinthValue field.
	''' </summary>
	Public Function GetNinthValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.NinthValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.NinthValue field.
	''' </summary>
	Public Function GetNinthValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NinthValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.NinthValue field.
	''' </summary>
	Public Sub SetNinthValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NinthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.NinthValue field.
	''' </summary>
	Public Sub SetNinthValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NinthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.TenthLabel field.
	''' </summary>
	Public Function GetTenthLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.TenthLabel field.
	''' </summary>
	Public Function GetTenthLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TenthLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.TenthLabel field.
	''' </summary>
	Public Sub SetTenthLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.TenthLabel field.
	''' </summary>
	Public Sub SetTenthLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.TenthValue field.
	''' </summary>
	Public Function GetTenthValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.TenthValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.TenthValue field.
	''' </summary>
	Public Function GetTenthValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TenthValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.TenthValue field.
	''' </summary>
	Public Sub SetTenthValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TenthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.TenthValue field.
	''' </summary>
	Public Sub SetTenthValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TenthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.EleventhLabel field.
	''' </summary>
	Public Function GetEleventhLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.EleventhLabel field.
	''' </summary>
	Public Function GetEleventhLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EleventhLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.EleventhLabel field.
	''' </summary>
	Public Sub SetEleventhLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.EleventhLabel field.
	''' </summary>
	Public Sub SetEleventhLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.EleventhValue field.
	''' </summary>
	Public Function GetEleventhValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.EleventhValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.EleventhValue field.
	''' </summary>
	Public Function GetEleventhValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EleventhValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.EleventhValue field.
	''' </summary>
	Public Sub SetEleventhValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EleventhValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.EleventhValue field.
	''' </summary>
	Public Sub SetEleventhValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EleventhValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.TwelfthLabel field.
	''' </summary>
	Public Function GetTwelfthLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.TwelfthLabel field.
	''' </summary>
	Public Function GetTwelfthLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TwelfthLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.TwelfthLabel field.
	''' </summary>
	Public Sub SetTwelfthLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.TwelfthLabel field.
	''' </summary>
	Public Sub SetTwelfthLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.TwelfthValue field.
	''' </summary>
	Public Function GetTwelfthValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.TwelfthValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.TwelfthValue field.
	''' </summary>
	Public Function GetTwelfthValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TwelfthValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.TwelfthValue field.
	''' </summary>
	Public Sub SetTwelfthValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TwelfthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.TwelfthValue field.
	''' </summary>
	Public Sub SetTwelfthValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TwelfthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.ThirteenthLabel field.
	''' </summary>
	Public Function GetThirteenthLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.ThirteenthLabel field.
	''' </summary>
	Public Function GetThirteenthLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirteenthLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ThirteenthLabel field.
	''' </summary>
	Public Sub SetThirteenthLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ThirteenthLabel field.
	''' </summary>
	Public Sub SetThirteenthLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.ThirteenthValue field.
	''' </summary>
	Public Function GetThirteenthValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThirteenthValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.ThirteenthValue field.
	''' </summary>
	Public Function GetThirteenthValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ThirteenthValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ThirteenthValue field.
	''' </summary>
	Public Sub SetThirteenthValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThirteenthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.ThirteenthValue field.
	''' </summary>
	Public Sub SetThirteenthValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThirteenthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FourteenthLabel field.
	''' </summary>
	Public Function GetFourteenthLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FourteenthLabel field.
	''' </summary>
	Public Function GetFourteenthLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourteenthLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FourteenthLabel field.
	''' </summary>
	Public Sub SetFourteenthLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FourteenthLabel field.
	''' </summary>
	Public Sub SetFourteenthLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FourteenthValue field.
	''' </summary>
	Public Function GetFourteenthValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.FourteenthValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FourteenthValue field.
	''' </summary>
	Public Function GetFourteenthValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FourteenthValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FourteenthValue field.
	''' </summary>
	Public Sub SetFourteenthValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FourteenthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FourteenthValue field.
	''' </summary>
	Public Sub SetFourteenthValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FourteenthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FifteenthLabel field.
	''' </summary>
	Public Function GetFifteenthLabelValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthLabelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FifteenthLabel field.
	''' </summary>
	Public Function GetFifteenthLabelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifteenthLabelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FifteenthLabel field.
	''' </summary>
	Public Sub SetFifteenthLabelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FifteenthLabel field.
	''' </summary>
	Public Sub SetFifteenthLabelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthLabelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FifteenthValue field.
	''' </summary>
	Public Function GetFifteenthValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.FifteenthValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.FifteenthValue field.
	''' </summary>
	Public Function GetFifteenthValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FifteenthValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FifteenthValue field.
	''' </summary>
	Public Sub SetFifteenthValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FifteenthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.FifteenthValue field.
	''' </summary>
	Public Sub SetFifteenthValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FifteenthValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.Cust_Plus1 field.
	''' </summary>
	Public Function GetCust_Plus1Value() As ColumnValue
		Return Me.GetValue(TableUtils.Cust_Plus1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.Cust_Plus1 field.
	''' </summary>
	Public Function GetCust_Plus1FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Cust_Plus1Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.Cust_Plus1 field.
	''' </summary>
	Public Sub SetCust_Plus1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Cust_Plus1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.Cust_Plus1 field.
	''' </summary>
	Public Sub SetCust_Plus1FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Cust_Plus1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.Cust_Plus2 field.
	''' </summary>
	Public Function GetCust_Plus2Value() As ColumnValue
		Return Me.GetValue(TableUtils.Cust_Plus2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.Cust_Plus2 field.
	''' </summary>
	Public Function GetCust_Plus2FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Cust_Plus2Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.Cust_Plus2 field.
	''' </summary>
	Public Sub SetCust_Plus2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Cust_Plus2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.Cust_Plus2 field.
	''' </summary>
	Public Sub SetCust_Plus2FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Cust_Plus2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.Cust_Plus3 field.
	''' </summary>
	Public Function GetCust_Plus3Value() As ColumnValue
		Return Me.GetValue(TableUtils.Cust_Plus3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.Cust_Plus3 field.
	''' </summary>
	Public Function GetCust_Plus3FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Cust_Plus3Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.Cust_Plus3 field.
	''' </summary>
	Public Sub SetCust_Plus3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Cust_Plus3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.Cust_Plus3 field.
	''' </summary>
	Public Sub SetCust_Plus3FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Cust_Plus3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.Cust_Plus4 field.
	''' </summary>
	Public Function GetCust_Plus4Value() As ColumnValue
		Return Me.GetValue(TableUtils.Cust_Plus4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.Cust_Plus4 field.
	''' </summary>
	Public Function GetCust_Plus4FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Cust_Plus4Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.Cust_Plus4 field.
	''' </summary>
	Public Sub SetCust_Plus4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Cust_Plus4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.Cust_Plus4 field.
	''' </summary>
	Public Sub SetCust_Plus4FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Cust_Plus4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.Cust_Plus5 field.
	''' </summary>
	Public Function GetCust_Plus5Value() As ColumnValue
		Return Me.GetValue(TableUtils.Cust_Plus5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.Cust_Plus5 field.
	''' </summary>
	Public Function GetCust_Plus5FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Cust_Plus5Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.Cust_Plus5 field.
	''' </summary>
	Public Sub SetCust_Plus5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Cust_Plus5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.Cust_Plus5 field.
	''' </summary>
	Public Sub SetCust_Plus5FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Cust_Plus5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.Cust_Plus6 field.
	''' </summary>
	Public Function GetCust_Plus6Value() As ColumnValue
		Return Me.GetValue(TableUtils.Cust_Plus6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.Cust_Plus6 field.
	''' </summary>
	Public Function GetCust_Plus6FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Cust_Plus6Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.Cust_Plus6 field.
	''' </summary>
	Public Sub SetCust_Plus6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Cust_Plus6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.Cust_Plus6 field.
	''' </summary>
	Public Sub SetCust_Plus6FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Cust_Plus6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.Cust_HrsTtl field.
	''' </summary>
	Public Function GetCust_HrsTtlValue() As ColumnValue
		Return Me.GetValue(TableUtils.Cust_HrsTtlColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Sign_.Cust_HrsTtl field.
	''' </summary>
	Public Function GetCust_HrsTtlFieldValue() As String
		Return CType(Me.GetValue(TableUtils.Cust_HrsTtlColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.Cust_HrsTtl field.
	''' </summary>
	Public Sub SetCust_HrsTtlFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Cust_HrsTtlColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Sign_.Cust_HrsTtl field.
	''' </summary>
	Public Sub SetCust_HrsTtlFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Cust_HrsTtlColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.ExecutionID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.SignedOn field.
	''' </summary>
	Public Property SignedOn() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SignedOnColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SignedOnColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SignedOnSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SignedOnColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SignedOnDefault() As String
        Get
            Return TableUtils.SignedOnColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.ExpiresOn field.
	''' </summary>
	Public Property ExpiresOn() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ExpiresOnColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ExpiresOnColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExpiresOnSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExpiresOnColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExpiresOnDefault() As String
        Get
            Return TableUtils.ExpiresOnColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.BarCode field.
	''' </summary>
	Public Property BarCode() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.BarCodeColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.BarCodeColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property BarCodeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.BarCodeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property BarCodeDefault() As String
        Get
            Return TableUtils.BarCodeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_Logo field.
	''' </summary>
	Public Property C_Logo() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.C_LogoColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.C_LogoColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_LogoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_LogoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_LogoDefault() As String
        Get
            Return TableUtils.C_LogoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_LogoSmall field.
	''' </summary>
	Public Property C_LogoSmall() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.C_LogoSmallColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.C_LogoSmallColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_LogoSmallSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_LogoSmallColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_LogoSmallDefault() As String
        Get
            Return TableUtils.C_LogoSmallColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_Name field.
	''' </summary>
	Public Property C_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_NameDefault() As String
        Get
            Return TableUtils.C_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_DBA field.
	''' </summary>
	Public Property C_DBA() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_DBAColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_DBAColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_DBASpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_DBAColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_DBADefault() As String
        Get
            Return TableUtils.C_DBAColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_DBAOrName field.
	''' </summary>
	Public Property C_DBAOrName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_DBAOrNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_DBAOrNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_DBAOrNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_DBAOrNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_DBAOrNameDefault() As String
        Get
            Return TableUtils.C_DBAOrNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_AddrHTML field.
	''' </summary>
	Public Property C_AddrHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_AddrHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_AddrHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_AddrHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_AddrHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_AddrHTMLDefault() As String
        Get
            Return TableUtils.C_AddrHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_Addr field.
	''' </summary>
	Public Property C_Addr() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_AddrColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_AddrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_AddrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_AddrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_AddrDefault() As String
        Get
            Return TableUtils.C_AddrColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_CitySTZip field.
	''' </summary>
	Public Property C_CitySTZip() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_CitySTZipColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_CitySTZipColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_CitySTZipSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_CitySTZipColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_CitySTZipDefault() As String
        Get
            Return TableUtils.C_CitySTZipColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_City field.
	''' </summary>
	Public Property C_City() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_CityColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_CityColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_CitySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_CityColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_CityDefault() As String
        Get
            Return TableUtils.C_CityColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_ST field.
	''' </summary>
	Public Property C_ST() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_STColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_STColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_STSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_STColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_STDefault() As String
        Get
            Return TableUtils.C_STColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_Zip field.
	''' </summary>
	Public Property C_Zip() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_ZipColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_ZipColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_ZipSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_ZipColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_ZipDefault() As String
        Get
            Return TableUtils.C_ZipColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_Country field.
	''' </summary>
	Public Property C_Country() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_CountryColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_CountryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_CountrySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_CountryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_CountryDefault() As String
        Get
            Return TableUtils.C_CountryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_Signer field.
	''' </summary>
	Public Property C_Signer() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_SignerColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_SignerColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_SignerSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_SignerColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_SignerDefault() As String
        Get
            Return TableUtils.C_SignerColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_SignerTitle field.
	''' </summary>
	Public Property C_SignerTitle() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_SignerTitleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_SignerTitleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_SignerTitleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_SignerTitleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_SignerTitleDefault() As String
        Get
            Return TableUtils.C_SignerTitleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_SignerContactInfo field.
	''' </summary>
	Public Property C_SignerContactInfo() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_SignerContactInfoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_SignerContactInfoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_SignerContactInfoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_SignerContactInfoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_SignerContactInfoDefault() As String
        Get
            Return TableUtils.C_SignerContactInfoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_Phone field.
	''' </summary>
	Public Property C_Phone() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_PhoneColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_PhoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_PhoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_PhoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_PhoneDefault() As String
        Get
            Return TableUtils.C_PhoneColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_Mobile field.
	''' </summary>
	Public Property C_Mobile() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_MobileColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_MobileColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_MobileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_MobileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_MobileDefault() As String
        Get
            Return TableUtils.C_MobileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_OtherPhone field.
	''' </summary>
	Public Property C_OtherPhone() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_OtherPhoneColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_OtherPhoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_OtherPhoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_OtherPhoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_OtherPhoneDefault() As String
        Get
            Return TableUtils.C_OtherPhoneColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_Fax field.
	''' </summary>
	Public Property C_Fax() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_FaxColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_FaxColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_FaxSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_FaxColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_FaxDefault() As String
        Get
            Return TableUtils.C_FaxColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_Email field.
	''' </summary>
	Public Property C_Email() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_EmailColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_EmailColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_EmailSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_EmailColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_EmailDefault() As String
        Get
            Return TableUtils.C_EmailColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_Signature field.
	''' </summary>
	Public Property C_Signature() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.C_SignatureColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.C_SignatureColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_SignatureSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_SignatureColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_SignatureDefault() As String
        Get
            Return TableUtils.C_SignatureColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_SignatureSmall field.
	''' </summary>
	Public Property C_SignatureSmall() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.C_SignatureSmallColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.C_SignatureSmallColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_SignatureSmallSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_SignatureSmallColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_SignatureSmallDefault() As String
        Get
            Return TableUtils.C_SignatureSmallColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_Initials field.
	''' </summary>
	Public Property C_Initials() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.C_InitialsColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.C_InitialsColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_InitialsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_InitialsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_InitialsDefault() As String
        Get
            Return TableUtils.C_InitialsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_DOT field.
	''' </summary>
	Public Property C_DOT() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_DOTColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_DOTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_DOTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_DOTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_DOTDefault() As String
        Get
            Return TableUtils.C_DOTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_MC field.
	''' </summary>
	Public Property C_MC() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_MCColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_MCColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_MCSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_MCColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_MCDefault() As String
        Get
            Return TableUtils.C_MCColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_EIN field.
	''' </summary>
	Public Property C_EIN() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_EINColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_EINColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_EINSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_EINColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_EINDefault() As String
        Get
            Return TableUtils.C_EINColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_EIN1 field.
	''' </summary>
	Public Property C_EIN1() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_EIN1Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_EIN1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_EIN1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_EIN1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_EIN1Default() As String
        Get
            Return TableUtils.C_EIN1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_EIN2 field.
	''' </summary>
	Public Property C_EIN2() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_EIN2Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_EIN2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_EIN2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_EIN2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_EIN2Default() As String
        Get
            Return TableUtils.C_EIN2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_EIN3 field.
	''' </summary>
	Public Property C_EIN3() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_EIN3Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_EIN3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_EIN3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_EIN3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_EIN3Default() As String
        Get
            Return TableUtils.C_EIN3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_EIN4 field.
	''' </summary>
	Public Property C_EIN4() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_EIN4Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_EIN4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_EIN4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_EIN4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_EIN4Default() As String
        Get
            Return TableUtils.C_EIN4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_EIN5 field.
	''' </summary>
	Public Property C_EIN5() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_EIN5Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_EIN5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_EIN5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_EIN5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_EIN5Default() As String
        Get
            Return TableUtils.C_EIN5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_EIN6 field.
	''' </summary>
	Public Property C_EIN6() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_EIN6Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_EIN6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_EIN6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_EIN6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_EIN6Default() As String
        Get
            Return TableUtils.C_EIN6Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_EIN7 field.
	''' </summary>
	Public Property C_EIN7() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_EIN7Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_EIN7Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_EIN7Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_EIN7Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_EIN7Default() As String
        Get
            Return TableUtils.C_EIN7Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_EIN8 field.
	''' </summary>
	Public Property C_EIN8() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_EIN8Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_EIN8Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_EIN8Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_EIN8Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_EIN8Default() As String
        Get
            Return TableUtils.C_EIN8Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.C_EIN9 field.
	''' </summary>
	Public Property C_EIN9() As String
		Get 
			Return CType(Me.GetValue(TableUtils.C_EIN9Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.C_EIN9Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_EIN9Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_EIN9Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_EIN9Default() As String
        Get
            Return TableUtils.C_EIN9Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_ProfilePic field.
	''' </summary>
	Public Property D_ProfilePic() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.D_ProfilePicColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.D_ProfilePicColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_ProfilePicSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_ProfilePicColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_ProfilePicDefault() As String
        Get
            Return TableUtils.D_ProfilePicColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_Name field.
	''' </summary>
	Public Property D_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_NameDefault() As String
        Get
            Return TableUtils.D_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_ContactInfo field.
	''' </summary>
	Public Property D_ContactInfo() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_ContactInfoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_ContactInfoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_ContactInfoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_ContactInfoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_ContactInfoDefault() As String
        Get
            Return TableUtils.D_ContactInfoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_Phone field.
	''' </summary>
	Public Property D_Phone() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_PhoneColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_PhoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_PhoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_PhoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_PhoneDefault() As String
        Get
            Return TableUtils.D_PhoneColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_Mobile field.
	''' </summary>
	Public Property D_Mobile() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_MobileColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_MobileColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_MobileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_MobileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_MobileDefault() As String
        Get
            Return TableUtils.D_MobileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_OtherPhone field.
	''' </summary>
	Public Property D_OtherPhone() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_OtherPhoneColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_OtherPhoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_OtherPhoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_OtherPhoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_OtherPhoneDefault() As String
        Get
            Return TableUtils.D_OtherPhoneColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_Fax field.
	''' </summary>
	Public Property D_Fax() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_FaxColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_FaxColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_FaxSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_FaxColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_FaxDefault() As String
        Get
            Return TableUtils.D_FaxColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_Email field.
	''' </summary>
	Public Property D_Email() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_EmailColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_EmailColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_EmailSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_EmailColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_EmailDefault() As String
        Get
            Return TableUtils.D_EmailColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_Signature field.
	''' </summary>
	Public Property D_Signature() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.D_SignatureColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.D_SignatureColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_SignatureSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_SignatureColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_SignatureDefault() As String
        Get
            Return TableUtils.D_SignatureColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_SignatureSmall field.
	''' </summary>
	Public Property D_SignatureSmall() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.D_SignatureSmallColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.D_SignatureSmallColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_SignatureSmallSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_SignatureSmallColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_SignatureSmallDefault() As String
        Get
            Return TableUtils.D_SignatureSmallColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_Initials field.
	''' </summary>
	Public Property D_Initials() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.D_InitialsColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.D_InitialsColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_InitialsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_InitialsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_InitialsDefault() As String
        Get
            Return TableUtils.D_InitialsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_Overview field.
	''' </summary>
	Public Property D_Overview() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_OverviewColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_OverviewColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_OverviewSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_OverviewColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_OverviewDefault() As String
        Get
            Return TableUtils.D_OverviewColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_Incidents field.
	''' </summary>
	Public Property D_Incidents() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_IncidentsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_IncidentsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_IncidentsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_IncidentsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_IncidentsDefault() As String
        Get
            Return TableUtils.D_IncidentsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_ExpGeneral field.
	''' </summary>
	Public Property D_ExpGeneral() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_ExpGeneralColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_ExpGeneralColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_ExpGeneralSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_ExpGeneralColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_ExpGeneralDefault() As String
        Get
            Return TableUtils.D_ExpGeneralColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_ExpEquipment field.
	''' </summary>
	Public Property D_ExpEquipment() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_ExpEquipmentColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_ExpEquipmentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_ExpEquipmentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_ExpEquipmentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_ExpEquipmentDefault() As String
        Get
            Return TableUtils.D_ExpEquipmentColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_ExpCargo field.
	''' </summary>
	Public Property D_ExpCargo() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_ExpCargoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_ExpCargoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_ExpCargoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_ExpCargoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_ExpCargoDefault() As String
        Get
            Return TableUtils.D_ExpCargoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_ExpRegions field.
	''' </summary>
	Public Property D_ExpRegions() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_ExpRegionsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_ExpRegionsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_ExpRegionsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_ExpRegionsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_ExpRegionsDefault() As String
        Get
            Return TableUtils.D_ExpRegionsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_Gauge field.
	''' </summary>
	Public Property D_Gauge() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_GaugeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_GaugeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_GaugeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_GaugeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_GaugeDefault() As String
        Get
            Return TableUtils.D_GaugeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_AddrHTML field.
	''' </summary>
	Public Property D_AddrHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_AddrHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_AddrHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_AddrHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_AddrHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_AddrHTMLDefault() As String
        Get
            Return TableUtils.D_AddrHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_Addr field.
	''' </summary>
	Public Property D_Addr() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_AddrColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_AddrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_AddrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_AddrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_AddrDefault() As String
        Get
            Return TableUtils.D_AddrColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_CitySTZip field.
	''' </summary>
	Public Property D_CitySTZip() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_CitySTZipColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_CitySTZipColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_CitySTZipSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_CitySTZipColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_CitySTZipDefault() As String
        Get
            Return TableUtils.D_CitySTZipColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_City field.
	''' </summary>
	Public Property D_City() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_CityColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_CityColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_CitySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_CityColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_CityDefault() As String
        Get
            Return TableUtils.D_CityColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_ST field.
	''' </summary>
	Public Property D_ST() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_STColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_STColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_STSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_STColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_STDefault() As String
        Get
            Return TableUtils.D_STColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_Zip field.
	''' </summary>
	Public Property D_Zip() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_ZipColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_ZipColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_ZipSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_ZipColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_ZipDefault() As String
        Get
            Return TableUtils.D_ZipColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_Country field.
	''' </summary>
	Public Property D_Country() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_CountryColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_CountryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_CountrySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_CountryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_CountryDefault() As String
        Get
            Return TableUtils.D_CountryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_DOB field.
	''' </summary>
	Public Property D_DOB() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_DOBColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_DOBColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_DOBSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_DOBColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_DOBDefault() As String
        Get
            Return TableUtils.D_DOBColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_CDLInfo field.
	''' </summary>
	Public Property D_CDLInfo() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_CDLInfoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_CDLInfoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_CDLInfoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_CDLInfoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_CDLInfoDefault() As String
        Get
            Return TableUtils.D_CDLInfoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_CDLShort field.
	''' </summary>
	Public Property D_CDLShort() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_CDLShortColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_CDLShortColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_CDLShortSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_CDLShortColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_CDLShortDefault() As String
        Get
            Return TableUtils.D_CDLShortColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_CDLOnly field.
	''' </summary>
	Public Property D_CDLOnly() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_CDLOnlyColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_CDLOnlyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_CDLOnlySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_CDLOnlyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_CDLOnlyDefault() As String
        Get
            Return TableUtils.D_CDLOnlyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_CDLState field.
	''' </summary>
	Public Property D_CDLState() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_CDLStateColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_CDLStateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_CDLStateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_CDLStateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_CDLStateDefault() As String
        Get
            Return TableUtils.D_CDLStateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_USCitizen field.
	''' </summary>
	Public Property D_USCitizen() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_USCitizenColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_USCitizenColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_USCitizenSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_USCitizenColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_USCitizenDefault() As String
        Get
            Return TableUtils.D_USCitizenColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_PersonalInfo field.
	''' </summary>
	Public Property D_PersonalInfo() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_PersonalInfoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_PersonalInfoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_PersonalInfoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_PersonalInfoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_PersonalInfoDefault() As String
        Get
            Return TableUtils.D_PersonalInfoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_SSN field.
	''' </summary>
	Public Property D_SSN() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_SSNColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_SSNColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_SSNSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_SSNColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_SSNDefault() As String
        Get
            Return TableUtils.D_SSNColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_SSX4 field.
	''' </summary>
	Public Property D_SSX4() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_SSX4Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_SSX4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_SSX4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_SSX4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_SSX4Default() As String
        Get
            Return TableUtils.D_SSX4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_SS1 field.
	''' </summary>
	Public Property D_SS1() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_SS1Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_SS1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_SS1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_SS1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_SS1Default() As String
        Get
            Return TableUtils.D_SS1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_SS2 field.
	''' </summary>
	Public Property D_SS2() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_SS2Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_SS2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_SS2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_SS2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_SS2Default() As String
        Get
            Return TableUtils.D_SS2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_SS3 field.
	''' </summary>
	Public Property D_SS3() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_SS3Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_SS3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_SS3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_SS3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_SS3Default() As String
        Get
            Return TableUtils.D_SS3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_SS4 field.
	''' </summary>
	Public Property D_SS4() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_SS4Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_SS4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_SS4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_SS4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_SS4Default() As String
        Get
            Return TableUtils.D_SS4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_SS5 field.
	''' </summary>
	Public Property D_SS5() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_SS5Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_SS5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_SS5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_SS5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_SS5Default() As String
        Get
            Return TableUtils.D_SS5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_SS6 field.
	''' </summary>
	Public Property D_SS6() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_SS6Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_SS6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_SS6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_SS6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_SS6Default() As String
        Get
            Return TableUtils.D_SS6Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_SS7 field.
	''' </summary>
	Public Property D_SS7() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_SS7Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_SS7Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_SS7Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_SS7Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_SS7Default() As String
        Get
            Return TableUtils.D_SS7Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_SS8 field.
	''' </summary>
	Public Property D_SS8() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_SS8Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_SS8Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_SS8Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_SS8Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_SS8Default() As String
        Get
            Return TableUtils.D_SS8Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_SS9 field.
	''' </summary>
	Public Property D_SS9() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_SS9Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_SS9Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_SS9Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_SS9Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_SS9Default() As String
        Get
            Return TableUtils.D_SS9Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_PRA field.
	''' </summary>
	Public Property D_PRA() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_PRAColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_PRAColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_PRASpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_PRAColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_PRADefault() As String
        Get
            Return TableUtils.D_PRAColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_PRANumber field.
	''' </summary>
	Public Property D_PRANumber() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_PRANumberColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_PRANumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_PRANumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_PRANumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_PRANumberDefault() As String
        Get
            Return TableUtils.D_PRANumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_Passport field.
	''' </summary>
	Public Property D_Passport() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_PassportColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_PassportColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_PassportSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_PassportColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_PassportDefault() As String
        Get
            Return TableUtils.D_PassportColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_PassportExpiration field.
	''' </summary>
	Public Property D_PassportExpiration() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_PassportExpirationColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_PassportExpirationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_PassportExpirationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_PassportExpirationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_PassportExpirationDefault() As String
        Get
            Return TableUtils.D_PassportExpirationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_TerminalAssigned field.
	''' </summary>
	Public Property D_TerminalAssigned() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_TerminalAssignedColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_TerminalAssignedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_TerminalAssignedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_TerminalAssignedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_TerminalAssignedDefault() As String
        Get
            Return TableUtils.D_TerminalAssignedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_I9OtherAlien field.
	''' </summary>
	Public Property D_I9OtherAlien() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_I9OtherAlienColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_I9OtherAlienColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_I9OtherAlienSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_I9OtherAlienColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_I9OtherAlienDefault() As String
        Get
            Return TableUtils.D_I9OtherAlienColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_I9a field.
	''' </summary>
	Public Property D_I9a() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_I9aColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_I9aColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_I9aSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_I9aColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_I9aDefault() As String
        Get
            Return TableUtils.D_I9aColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_I9b field.
	''' </summary>
	Public Property D_I9b() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_I9bColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_I9bColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_I9bSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_I9bColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_I9bDefault() As String
        Get
            Return TableUtils.D_I9bColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.D_I9c field.
	''' </summary>
	Public Property D_I9c() As String
		Get 
			Return CType(Me.GetValue(TableUtils.D_I9cColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.D_I9cColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property D_I9cSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.D_I9cColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property D_I9cDefault() As String
        Get
            Return TableUtils.D_I9cColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.FirstLabel field.
	''' </summary>
	Public Property FirstLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstLabelDefault() As String
        Get
            Return TableUtils.FirstLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.FirstValue field.
	''' </summary>
	Public Property FirstValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FirstValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FirstValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstValueDefault() As String
        Get
            Return TableUtils.FirstValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.SecondLabel field.
	''' </summary>
	Public Property SecondLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SecondLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SecondLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondLabelDefault() As String
        Get
            Return TableUtils.SecondLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.SecondValue field.
	''' </summary>
	Public Property SecondValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SecondValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SecondValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SecondValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SecondValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SecondValueDefault() As String
        Get
            Return TableUtils.SecondValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.ThirdLabel field.
	''' </summary>
	Public Property ThirdLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirdLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdLabelDefault() As String
        Get
            Return TableUtils.ThirdLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.ThirdValue field.
	''' </summary>
	Public Property ThirdValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirdValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirdValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirdValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirdValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirdValueDefault() As String
        Get
            Return TableUtils.ThirdValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.FourthLabel field.
	''' </summary>
	Public Property FourthLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourthLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourthLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthLabelDefault() As String
        Get
            Return TableUtils.FourthLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.FourthValue field.
	''' </summary>
	Public Property FourthValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourthValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourthValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourthValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourthValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourthValueDefault() As String
        Get
            Return TableUtils.FourthValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.FifthLabel field.
	''' </summary>
	Public Property FifthLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifthLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifthLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthLabelDefault() As String
        Get
            Return TableUtils.FifthLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.FifthValue field.
	''' </summary>
	Public Property FifthValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifthValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifthValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifthValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifthValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifthValueDefault() As String
        Get
            Return TableUtils.FifthValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.SixthLabel field.
	''' </summary>
	Public Property SixthLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SixthLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SixthLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthLabelDefault() As String
        Get
            Return TableUtils.SixthLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.SixthValue field.
	''' </summary>
	Public Property SixthValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SixthValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SixthValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SixthValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SixthValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SixthValueDefault() As String
        Get
            Return TableUtils.SixthValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.SeventhLabel field.
	''' </summary>
	Public Property SeventhLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SeventhLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhLabelDefault() As String
        Get
            Return TableUtils.SeventhLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.SeventhValue field.
	''' </summary>
	Public Property SeventhValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SeventhValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SeventhValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeventhValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeventhValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeventhValueDefault() As String
        Get
            Return TableUtils.SeventhValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.EighthLabel field.
	''' </summary>
	Public Property EighthLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EighthLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EighthLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthLabelDefault() As String
        Get
            Return TableUtils.EighthLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.EighthValue field.
	''' </summary>
	Public Property EighthValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EighthValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EighthValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EighthValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EighthValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EighthValueDefault() As String
        Get
            Return TableUtils.EighthValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.NinthLabel field.
	''' </summary>
	Public Property NinthLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.NinthLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.NinthLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthLabelDefault() As String
        Get
            Return TableUtils.NinthLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.NinthValue field.
	''' </summary>
	Public Property NinthValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.NinthValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.NinthValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NinthValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NinthValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NinthValueDefault() As String
        Get
            Return TableUtils.NinthValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.TenthLabel field.
	''' </summary>
	Public Property TenthLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TenthLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TenthLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthLabelDefault() As String
        Get
            Return TableUtils.TenthLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.TenthValue field.
	''' </summary>
	Public Property TenthValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TenthValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TenthValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TenthValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TenthValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TenthValueDefault() As String
        Get
            Return TableUtils.TenthValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.EleventhLabel field.
	''' </summary>
	Public Property EleventhLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EleventhLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhLabelDefault() As String
        Get
            Return TableUtils.EleventhLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.EleventhValue field.
	''' </summary>
	Public Property EleventhValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EleventhValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EleventhValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EleventhValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EleventhValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EleventhValueDefault() As String
        Get
            Return TableUtils.EleventhValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.TwelfthLabel field.
	''' </summary>
	Public Property TwelfthLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TwelfthLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthLabelDefault() As String
        Get
            Return TableUtils.TwelfthLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.TwelfthValue field.
	''' </summary>
	Public Property TwelfthValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TwelfthValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TwelfthValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TwelfthValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TwelfthValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TwelfthValueDefault() As String
        Get
            Return TableUtils.TwelfthValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.ThirteenthLabel field.
	''' </summary>
	Public Property ThirteenthLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirteenthLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthLabelDefault() As String
        Get
            Return TableUtils.ThirteenthLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.ThirteenthValue field.
	''' </summary>
	Public Property ThirteenthValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ThirteenthValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ThirteenthValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThirteenthValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThirteenthValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThirteenthValueDefault() As String
        Get
            Return TableUtils.ThirteenthValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.FourteenthLabel field.
	''' </summary>
	Public Property FourteenthLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourteenthLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthLabelDefault() As String
        Get
            Return TableUtils.FourteenthLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.FourteenthValue field.
	''' </summary>
	Public Property FourteenthValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FourteenthValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FourteenthValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FourteenthValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FourteenthValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FourteenthValueDefault() As String
        Get
            Return TableUtils.FourteenthValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.FifteenthLabel field.
	''' </summary>
	Public Property FifteenthLabel() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthLabelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifteenthLabelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthLabelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthLabelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthLabelDefault() As String
        Get
            Return TableUtils.FifteenthLabelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.FifteenthValue field.
	''' </summary>
	Public Property FifteenthValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FifteenthValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FifteenthValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FifteenthValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FifteenthValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FifteenthValueDefault() As String
        Get
            Return TableUtils.FifteenthValueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.Cust_Plus1 field.
	''' </summary>
	Public Property Cust_Plus1() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Cust_Plus1Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Cust_Plus1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Cust_Plus1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Cust_Plus1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Cust_Plus1Default() As String
        Get
            Return TableUtils.Cust_Plus1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.Cust_Plus2 field.
	''' </summary>
	Public Property Cust_Plus2() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Cust_Plus2Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Cust_Plus2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Cust_Plus2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Cust_Plus2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Cust_Plus2Default() As String
        Get
            Return TableUtils.Cust_Plus2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.Cust_Plus3 field.
	''' </summary>
	Public Property Cust_Plus3() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Cust_Plus3Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Cust_Plus3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Cust_Plus3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Cust_Plus3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Cust_Plus3Default() As String
        Get
            Return TableUtils.Cust_Plus3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.Cust_Plus4 field.
	''' </summary>
	Public Property Cust_Plus4() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Cust_Plus4Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Cust_Plus4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Cust_Plus4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Cust_Plus4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Cust_Plus4Default() As String
        Get
            Return TableUtils.Cust_Plus4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.Cust_Plus5 field.
	''' </summary>
	Public Property Cust_Plus5() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Cust_Plus5Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Cust_Plus5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Cust_Plus5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Cust_Plus5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Cust_Plus5Default() As String
        Get
            Return TableUtils.Cust_Plus5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.Cust_Plus6 field.
	''' </summary>
	Public Property Cust_Plus6() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Cust_Plus6Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Cust_Plus6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Cust_Plus6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Cust_Plus6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Cust_Plus6Default() As String
        Get
            Return TableUtils.Cust_Plus6Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Sign_.Cust_HrsTtl field.
	''' </summary>
	Public Property Cust_HrsTtl() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Cust_HrsTtlColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Cust_HrsTtlColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Cust_HrsTtlSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Cust_HrsTtlColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Cust_HrsTtlDefault() As String
        Get
            Return TableUtils.Cust_HrsTtlColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
