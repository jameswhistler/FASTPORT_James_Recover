' This class is "generated" and will be overwritten.
' Your customizations should be made in V_SignOwnerRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_SignOwnerRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_SignOwnerView"></see> class.
''' </remarks>
''' <seealso cref="V_SignOwnerView"></seealso>
''' <seealso cref="V_SignOwnerRecord"></seealso>

<Serializable()> Public Class BaseV_SignOwnerRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_SignOwnerView = V_SignOwnerView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_SignOwnerRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_SignOwnerRec As V_SignOwnerRecord = CType(sender,V_SignOwnerRecord)
        Validate_Inserting()
        If Not V_SignOwnerRec Is Nothing AndAlso Not V_SignOwnerRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_SignOwnerRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_SignOwnerRec As V_SignOwnerRecord = CType(sender,V_SignOwnerRecord)
        Validate_Updating()
        If Not V_SignOwnerRec Is Nothing AndAlso Not V_SignOwnerRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_SignOwnerRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_SignOwnerRec As V_SignOwnerRecord = CType(sender,V_SignOwnerRecord)
        If Not V_SignOwnerRec Is Nothing AndAlso Not V_SignOwnerRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_Name field.
	''' </summary>
	Public Function GetO_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_Name field.
	''' </summary>
	Public Function GetO_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_Name field.
	''' </summary>
	Public Sub SetO_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_Name field.
	''' </summary>
	Public Sub SetO_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_DBA field.
	''' </summary>
	Public Function GetO_DBAValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_DBAColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_DBA field.
	''' </summary>
	Public Function GetO_DBAFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_DBAColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_DBA field.
	''' </summary>
	Public Sub SetO_DBAFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_DBAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_DBA field.
	''' </summary>
	Public Sub SetO_DBAFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_DBAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_DBAOrName field.
	''' </summary>
	Public Function GetO_DBAOrNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_DBAOrNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_DBAOrName field.
	''' </summary>
	Public Function GetO_DBAOrNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_DBAOrNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_DBAOrName field.
	''' </summary>
	Public Sub SetO_DBAOrNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_DBAOrNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_DBAOrName field.
	''' </summary>
	Public Sub SetO_DBAOrNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_DBAOrNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_AddrHTML field.
	''' </summary>
	Public Function GetO_AddrHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_AddrHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_AddrHTML field.
	''' </summary>
	Public Function GetO_AddrHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_AddrHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_AddrHTML field.
	''' </summary>
	Public Sub SetO_AddrHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_AddrHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_AddrHTML field.
	''' </summary>
	Public Sub SetO_AddrHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_AddrHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_Addr field.
	''' </summary>
	Public Function GetO_AddrValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_AddrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_Addr field.
	''' </summary>
	Public Function GetO_AddrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_AddrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_Addr field.
	''' </summary>
	Public Sub SetO_AddrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_Addr field.
	''' </summary>
	Public Sub SetO_AddrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_CitySTZip field.
	''' </summary>
	Public Function GetO_CitySTZipValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_CitySTZipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_CitySTZip field.
	''' </summary>
	Public Function GetO_CitySTZipFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_CitySTZipColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_CitySTZip field.
	''' </summary>
	Public Sub SetO_CitySTZipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_CitySTZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_CitySTZip field.
	''' </summary>
	Public Sub SetO_CitySTZipFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_CitySTZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_City field.
	''' </summary>
	Public Function GetO_CityValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_CityColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_City field.
	''' </summary>
	Public Function GetO_CityFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_CityColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_City field.
	''' </summary>
	Public Sub SetO_CityFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_CityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_City field.
	''' </summary>
	Public Sub SetO_CityFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_CityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_ST field.
	''' </summary>
	Public Function GetO_STValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_STColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_ST field.
	''' </summary>
	Public Function GetO_STFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_STColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_ST field.
	''' </summary>
	Public Sub SetO_STFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_STColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_ST field.
	''' </summary>
	Public Sub SetO_STFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_STColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_Zip field.
	''' </summary>
	Public Function GetO_ZipValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_ZipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_Zip field.
	''' </summary>
	Public Function GetO_ZipFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_ZipColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_Zip field.
	''' </summary>
	Public Sub SetO_ZipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_ZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_Zip field.
	''' </summary>
	Public Sub SetO_ZipFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_ZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_Country field.
	''' </summary>
	Public Function GetO_CountryValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_CountryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_Country field.
	''' </summary>
	Public Function GetO_CountryFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_CountryColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_Country field.
	''' </summary>
	Public Sub SetO_CountryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_Country field.
	''' </summary>
	Public Sub SetO_CountryFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_SSNorEIN field.
	''' </summary>
	Public Function GetO_SSNorEINValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_SSNorEINColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_SSNorEIN field.
	''' </summary>
	Public Function GetO_SSNorEINFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_SSNorEINColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_SSNorEIN field.
	''' </summary>
	Public Sub SetO_SSNorEINFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_SSNorEINColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_SSNorEIN field.
	''' </summary>
	Public Sub SetO_SSNorEINFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_SSNorEINColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_SSN field.
	''' </summary>
	Public Function GetO_SSNValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_SSNColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_SSN field.
	''' </summary>
	Public Function GetO_SSNFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_SSNColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_SSN field.
	''' </summary>
	Public Sub SetO_SSNFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_SSNColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_SSN field.
	''' </summary>
	Public Sub SetO_SSNFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_SSNColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EIN field.
	''' </summary>
	Public Function GetO_EINValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_EINColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EIN field.
	''' </summary>
	Public Function GetO_EINFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_EINColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EIN field.
	''' </summary>
	Public Sub SetO_EINFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_EINColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EIN field.
	''' </summary>
	Public Sub SetO_EINFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_EINColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_Entity field.
	''' </summary>
	Public Function GetO_EntityValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_EntityColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_Entity field.
	''' </summary>
	Public Function GetO_EntityFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_EntityColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_Entity field.
	''' </summary>
	Public Sub SetO_EntityFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_EntityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_Entity field.
	''' </summary>
	Public Sub SetO_EntityFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_EntityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EntitySole field.
	''' </summary>
	Public Function GetO_EntitySoleValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_EntitySoleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EntitySole field.
	''' </summary>
	Public Function GetO_EntitySoleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_EntitySoleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EntitySole field.
	''' </summary>
	Public Sub SetO_EntitySoleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_EntitySoleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EntitySole field.
	''' </summary>
	Public Sub SetO_EntitySoleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_EntitySoleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EntityCCorp field.
	''' </summary>
	Public Function GetO_EntityCCorpValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_EntityCCorpColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EntityCCorp field.
	''' </summary>
	Public Function GetO_EntityCCorpFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_EntityCCorpColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EntityCCorp field.
	''' </summary>
	Public Sub SetO_EntityCCorpFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_EntityCCorpColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EntityCCorp field.
	''' </summary>
	Public Sub SetO_EntityCCorpFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_EntityCCorpColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EntitySCorp field.
	''' </summary>
	Public Function GetO_EntitySCorpValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_EntitySCorpColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EntitySCorp field.
	''' </summary>
	Public Function GetO_EntitySCorpFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_EntitySCorpColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EntitySCorp field.
	''' </summary>
	Public Sub SetO_EntitySCorpFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_EntitySCorpColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EntitySCorp field.
	''' </summary>
	Public Sub SetO_EntitySCorpFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_EntitySCorpColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EntityPartner field.
	''' </summary>
	Public Function GetO_EntityPartnerValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_EntityPartnerColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EntityPartner field.
	''' </summary>
	Public Function GetO_EntityPartnerFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_EntityPartnerColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EntityPartner field.
	''' </summary>
	Public Sub SetO_EntityPartnerFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_EntityPartnerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EntityPartner field.
	''' </summary>
	Public Sub SetO_EntityPartnerFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_EntityPartnerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EntityTrustEstate field.
	''' </summary>
	Public Function GetO_EntityTrustEstateValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_EntityTrustEstateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EntityTrustEstate field.
	''' </summary>
	Public Function GetO_EntityTrustEstateFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_EntityTrustEstateColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EntityTrustEstate field.
	''' </summary>
	Public Sub SetO_EntityTrustEstateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_EntityTrustEstateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EntityTrustEstate field.
	''' </summary>
	Public Sub SetO_EntityTrustEstateFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_EntityTrustEstateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EntityLLC field.
	''' </summary>
	Public Function GetO_EntityLLCValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_EntityLLCColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EntityLLC field.
	''' </summary>
	Public Function GetO_EntityLLCFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_EntityLLCColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EntityLLC field.
	''' </summary>
	Public Sub SetO_EntityLLCFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_EntityLLCColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EntityLLC field.
	''' </summary>
	Public Sub SetO_EntityLLCFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_EntityLLCColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EntityOther field.
	''' </summary>
	Public Function GetO_EntityOtherValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_EntityOtherColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignOwner_.O_EntityOther field.
	''' </summary>
	Public Function GetO_EntityOtherFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_EntityOtherColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EntityOther field.
	''' </summary>
	Public Sub SetO_EntityOtherFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_EntityOtherColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignOwner_.O_EntityOther field.
	''' </summary>
	Public Sub SetO_EntityOtherFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_EntityOtherColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.PartyID field.
	''' </summary>
	Public Property PartyID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PartyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PartyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PartyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PartyIDDefault() As String
        Get
            Return TableUtils.PartyIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_Name field.
	''' </summary>
	Public Property O_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_NameDefault() As String
        Get
            Return TableUtils.O_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_DBA field.
	''' </summary>
	Public Property O_DBA() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_DBAColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_DBAColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_DBASpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_DBAColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_DBADefault() As String
        Get
            Return TableUtils.O_DBAColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_DBAOrName field.
	''' </summary>
	Public Property O_DBAOrName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_DBAOrNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_DBAOrNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_DBAOrNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_DBAOrNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_DBAOrNameDefault() As String
        Get
            Return TableUtils.O_DBAOrNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_AddrHTML field.
	''' </summary>
	Public Property O_AddrHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_AddrHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_AddrHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_AddrHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_AddrHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_AddrHTMLDefault() As String
        Get
            Return TableUtils.O_AddrHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_Addr field.
	''' </summary>
	Public Property O_Addr() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_AddrColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_AddrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_AddrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_AddrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_AddrDefault() As String
        Get
            Return TableUtils.O_AddrColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_CitySTZip field.
	''' </summary>
	Public Property O_CitySTZip() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_CitySTZipColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_CitySTZipColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_CitySTZipSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_CitySTZipColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_CitySTZipDefault() As String
        Get
            Return TableUtils.O_CitySTZipColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_City field.
	''' </summary>
	Public Property O_City() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_CityColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_CityColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_CitySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_CityColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_CityDefault() As String
        Get
            Return TableUtils.O_CityColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_ST field.
	''' </summary>
	Public Property O_ST() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_STColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_STColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_STSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_STColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_STDefault() As String
        Get
            Return TableUtils.O_STColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_Zip field.
	''' </summary>
	Public Property O_Zip() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_ZipColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_ZipColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_ZipSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_ZipColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_ZipDefault() As String
        Get
            Return TableUtils.O_ZipColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_Country field.
	''' </summary>
	Public Property O_Country() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_CountryColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_CountryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_CountrySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_CountryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_CountryDefault() As String
        Get
            Return TableUtils.O_CountryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_SSNorEIN field.
	''' </summary>
	Public Property O_SSNorEIN() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_SSNorEINColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_SSNorEINColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_SSNorEINSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_SSNorEINColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_SSNorEINDefault() As String
        Get
            Return TableUtils.O_SSNorEINColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_SSN field.
	''' </summary>
	Public Property O_SSN() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_SSNColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_SSNColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_SSNSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_SSNColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_SSNDefault() As String
        Get
            Return TableUtils.O_SSNColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_EIN field.
	''' </summary>
	Public Property O_EIN() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_EINColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_EINColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_EINSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_EINColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_EINDefault() As String
        Get
            Return TableUtils.O_EINColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_Entity field.
	''' </summary>
	Public Property O_Entity() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_EntityColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_EntityColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_EntitySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_EntityColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_EntityDefault() As String
        Get
            Return TableUtils.O_EntityColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_EntitySole field.
	''' </summary>
	Public Property O_EntitySole() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_EntitySoleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_EntitySoleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_EntitySoleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_EntitySoleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_EntitySoleDefault() As String
        Get
            Return TableUtils.O_EntitySoleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_EntityCCorp field.
	''' </summary>
	Public Property O_EntityCCorp() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_EntityCCorpColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_EntityCCorpColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_EntityCCorpSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_EntityCCorpColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_EntityCCorpDefault() As String
        Get
            Return TableUtils.O_EntityCCorpColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_EntitySCorp field.
	''' </summary>
	Public Property O_EntitySCorp() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_EntitySCorpColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_EntitySCorpColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_EntitySCorpSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_EntitySCorpColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_EntitySCorpDefault() As String
        Get
            Return TableUtils.O_EntitySCorpColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_EntityPartner field.
	''' </summary>
	Public Property O_EntityPartner() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_EntityPartnerColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_EntityPartnerColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_EntityPartnerSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_EntityPartnerColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_EntityPartnerDefault() As String
        Get
            Return TableUtils.O_EntityPartnerColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_EntityTrustEstate field.
	''' </summary>
	Public Property O_EntityTrustEstate() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_EntityTrustEstateColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_EntityTrustEstateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_EntityTrustEstateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_EntityTrustEstateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_EntityTrustEstateDefault() As String
        Get
            Return TableUtils.O_EntityTrustEstateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_EntityLLC field.
	''' </summary>
	Public Property O_EntityLLC() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_EntityLLCColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_EntityLLCColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_EntityLLCSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_EntityLLCColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_EntityLLCDefault() As String
        Get
            Return TableUtils.O_EntityLLCColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignOwner_.O_EntityOther field.
	''' </summary>
	Public Property O_EntityOther() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_EntityOtherColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_EntityOtherColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_EntityOtherSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_EntityOtherColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_EntityOtherDefault() As String
        Get
            Return TableUtils.O_EntityOtherColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
