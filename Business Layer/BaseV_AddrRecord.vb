' This class is "generated" and will be overwritten.
' Your customizations should be made in V_AddrRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_AddrRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_AddrView"></see> class.
''' </remarks>
''' <seealso cref="V_AddrView"></seealso>
''' <seealso cref="V_AddrRecord"></seealso>

<Serializable()> Public Class BaseV_AddrRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_AddrView = V_AddrView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_AddrRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_AddrRec As V_AddrRecord = CType(sender,V_AddrRecord)
        Validate_Inserting()
        If Not V_AddrRec Is Nothing AndAlso Not V_AddrRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_AddrRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_AddrRec As V_AddrRecord = CType(sender,V_AddrRecord)
        Validate_Updating()
        If Not V_AddrRec Is Nothing AndAlso Not V_AddrRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_AddrRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_AddrRec As V_AddrRecord = CType(sender,V_AddrRecord)
        If Not V_AddrRec Is Nothing AndAlso Not V_AddrRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.AddrID field.
	''' </summary>
	Public Function GetAddrIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.AddrID field.
	''' </summary>
	Public Function GetAddrIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AddrIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.AddrHTML field.
	''' </summary>
	Public Function GetAddrHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.AddrHTML field.
	''' </summary>
	Public Function GetAddrHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AddrHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.AddrHTML field.
	''' </summary>
	Public Sub SetAddrHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.AddrHTML field.
	''' </summary>
	Public Sub SetAddrHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.TermHTML field.
	''' </summary>
	Public Function GetTermHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.TermHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.TermHTML field.
	''' </summary>
	Public Function GetTermHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TermHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.TermHTML field.
	''' </summary>
	Public Sub SetTermHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TermHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.TermHTML field.
	''' </summary>
	Public Sub SetTermHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TermHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.SimpleHTML field.
	''' </summary>
	Public Function GetSimpleHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.SimpleHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.SimpleHTML field.
	''' </summary>
	Public Function GetSimpleHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SimpleHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.SimpleHTML field.
	''' </summary>
	Public Sub SetSimpleHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SimpleHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.SimpleHTML field.
	''' </summary>
	Public Sub SetSimpleHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SimpleHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.OneLine field.
	''' </summary>
	Public Function GetOneLineValue() As ColumnValue
		Return Me.GetValue(TableUtils.OneLineColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.OneLine field.
	''' </summary>
	Public Function GetOneLineFieldValue() As String
		Return CType(Me.GetValue(TableUtils.OneLineColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.OneLine field.
	''' </summary>
	Public Sub SetOneLineFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OneLineColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.OneLine field.
	''' </summary>
	Public Sub SetOneLineFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OneLineColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.Addr field.
	''' </summary>
	Public Function GetAddrValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.Addr field.
	''' </summary>
	Public Function GetAddrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AddrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.Addr field.
	''' </summary>
	Public Sub SetAddrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.Addr field.
	''' </summary>
	Public Sub SetAddrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.City field.
	''' </summary>
	Public Function GetCityValue() As ColumnValue
		Return Me.GetValue(TableUtils.CityColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.City field.
	''' </summary>
	Public Function GetCityFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CityColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.City field.
	''' </summary>
	Public Sub SetCityFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.City field.
	''' </summary>
	Public Sub SetCityFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.ST field.
	''' </summary>
	Public Function GetSTValue() As ColumnValue
		Return Me.GetValue(TableUtils.STColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.ST field.
	''' </summary>
	Public Function GetSTFieldValue() As String
		Return CType(Me.GetValue(TableUtils.STColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.ST field.
	''' </summary>
	Public Sub SetSTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.STColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.ST field.
	''' </summary>
	Public Sub SetSTFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.STColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.Zip field.
	''' </summary>
	Public Function GetZipValue() As ColumnValue
		Return Me.GetValue(TableUtils.ZipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.Zip field.
	''' </summary>
	Public Function GetZipFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ZipColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.Zip field.
	''' </summary>
	Public Sub SetZipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.Zip field.
	''' </summary>
	Public Sub SetZipFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.Country field.
	''' </summary>
	Public Function GetCountryValue() As ColumnValue
		Return Me.GetValue(TableUtils.CountryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.Country field.
	''' </summary>
	Public Function GetCountryFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CountryColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.Country field.
	''' </summary>
	Public Sub SetCountryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.Country field.
	''' </summary>
	Public Sub SetCountryFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.DeleteDesc field.
	''' </summary>
	Public Function GetDeleteDescValue() As ColumnValue
		Return Me.GetValue(TableUtils.DeleteDescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.DeleteDesc field.
	''' </summary>
	Public Function GetDeleteDescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DeleteDescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.DeleteDesc field.
	''' </summary>
	Public Sub SetDeleteDescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DeleteDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.DeleteDesc field.
	''' </summary>
	Public Sub SetDeleteDescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DeleteDescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.Dates field.
	''' </summary>
	Public Function GetDatesValue() As ColumnValue
		Return Me.GetValue(TableUtils.DatesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.Dates field.
	''' </summary>
	Public Function GetDatesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DatesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.Dates field.
	''' </summary>
	Public Sub SetDatesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DatesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.Dates field.
	''' </summary>
	Public Sub SetDatesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DatesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.EditButton field.
	''' </summary>
	Public Function GetEditButtonValue() As ColumnValue
		Return Me.GetValue(TableUtils.EditButtonColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.EditButton field.
	''' </summary>
	Public Function GetEditButtonFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EditButtonColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.EditButton field.
	''' </summary>
	Public Sub SetEditButtonFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EditButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.EditButton field.
	''' </summary>
	Public Sub SetEditButtonFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EditButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.DeleteButton field.
	''' </summary>
	Public Function GetDeleteButtonValue() As ColumnValue
		Return Me.GetValue(TableUtils.DeleteButtonColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.DeleteButton field.
	''' </summary>
	Public Function GetDeleteButtonFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DeleteButtonColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.DeleteButton field.
	''' </summary>
	Public Sub SetDeleteButtonFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DeleteButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.DeleteButton field.
	''' </summary>
	Public Sub SetDeleteButtonFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DeleteButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.EditImage field.
	''' </summary>
	Public Function GetEditImageValue() As ColumnValue
		Return Me.GetValue(TableUtils.EditImageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.EditImage field.
	''' </summary>
	Public Function GetEditImageFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EditImageColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.EditImage field.
	''' </summary>
	Public Sub SetEditImageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EditImageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.EditImage field.
	''' </summary>
	Public Sub SetEditImageFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EditImageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.MovedIn field.
	''' </summary>
	Public Function GetMovedInValue() As ColumnValue
		Return Me.GetValue(TableUtils.MovedInColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.MovedIn field.
	''' </summary>
	Public Function GetMovedInFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.MovedInColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.MovedIn field.
	''' </summary>
	Public Sub SetMovedInFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MovedInColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.MovedIn field.
	''' </summary>
	Public Sub SetMovedInFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MovedInColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.MovedIn field.
	''' </summary>
	Public Sub SetMovedInFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MovedInColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.MovedOut field.
	''' </summary>
	Public Function GetMovedOutValue() As ColumnValue
		Return Me.GetValue(TableUtils.MovedOutColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.MovedOut field.
	''' </summary>
	Public Function GetMovedOutFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.MovedOutColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.MovedOut field.
	''' </summary>
	Public Sub SetMovedOutFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MovedOutColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.MovedOut field.
	''' </summary>
	Public Sub SetMovedOutFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MovedOutColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.MovedOut field.
	''' </summary>
	Public Sub SetMovedOutFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MovedOutColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.MovedOutOn field.
	''' </summary>
	Public Function GetMovedOutOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.MovedOutOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.MovedOutOn field.
	''' </summary>
	Public Function GetMovedOutOnFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.MovedOutOnColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.MovedOutOn field.
	''' </summary>
	Public Sub SetMovedOutOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MovedOutOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.MovedOutOn field.
	''' </summary>
	Public Sub SetMovedOutOnFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MovedOutOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.MovedOutOn field.
	''' </summary>
	Public Sub SetMovedOutOnFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MovedOutOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.Headquarters field.
	''' </summary>
	Public Function GetHeadquartersValue() As ColumnValue
		Return Me.GetValue(TableUtils.HeadquartersColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.Headquarters field.
	''' </summary>
	Public Function GetHeadquartersFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.HeadquartersColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.Headquarters field.
	''' </summary>
	Public Sub SetHeadquartersFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HeadquartersColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.Headquarters field.
	''' </summary>
	Public Sub SetHeadquartersFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HeadquartersColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.Headquarters field.
	''' </summary>
	Public Sub SetHeadquartersFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HeadquartersColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.AddrName field.
	''' </summary>
	Public Function GetAddrNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.AddrName field.
	''' </summary>
	Public Function GetAddrNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AddrNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.AddrName field.
	''' </summary>
	Public Sub SetAddrNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.AddrName field.
	''' </summary>
	Public Sub SetAddrNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.CitySTZip field.
	''' </summary>
	Public Function GetCitySTZipValue() As ColumnValue
		Return Me.GetValue(TableUtils.CitySTZipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.CitySTZip field.
	''' </summary>
	Public Function GetCitySTZipFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CitySTZipColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.CitySTZip field.
	''' </summary>
	Public Sub SetCitySTZipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CitySTZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.CitySTZip field.
	''' </summary>
	Public Sub SetCitySTZipFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CitySTZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.CityST field.
	''' </summary>
	Public Function GetCitySTValue() As ColumnValue
		Return Me.GetValue(TableUtils.CitySTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Addr_.CityST field.
	''' </summary>
	Public Function GetCitySTFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CitySTColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.CityST field.
	''' </summary>
	Public Sub SetCitySTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CitySTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Addr_.CityST field.
	''' </summary>
	Public Sub SetCitySTFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CitySTColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.AddrID field.
	''' </summary>
	Public Property AddrID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AddrIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AddrIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AddrIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AddrIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AddrIDDefault() As String
        Get
            Return TableUtils.AddrIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.AddrHTML field.
	''' </summary>
	Public Property AddrHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.AddrHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.AddrHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AddrHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AddrHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AddrHTMLDefault() As String
        Get
            Return TableUtils.AddrHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.TermHTML field.
	''' </summary>
	Public Property TermHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TermHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TermHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TermHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TermHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TermHTMLDefault() As String
        Get
            Return TableUtils.TermHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.SimpleHTML field.
	''' </summary>
	Public Property SimpleHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SimpleHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SimpleHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SimpleHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SimpleHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SimpleHTMLDefault() As String
        Get
            Return TableUtils.SimpleHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.OneLine field.
	''' </summary>
	Public Property OneLine() As String
		Get 
			Return CType(Me.GetValue(TableUtils.OneLineColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.OneLineColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OneLineSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OneLineColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OneLineDefault() As String
        Get
            Return TableUtils.OneLineColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.Addr field.
	''' </summary>
	Public Property Addr() As String
		Get 
			Return CType(Me.GetValue(TableUtils.AddrColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.AddrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AddrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AddrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AddrDefault() As String
        Get
            Return TableUtils.AddrColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.City field.
	''' </summary>
	Public Property City() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CityColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CityColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CitySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CityColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CityDefault() As String
        Get
            Return TableUtils.CityColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.ST field.
	''' </summary>
	Public Property ST() As String
		Get 
			Return CType(Me.GetValue(TableUtils.STColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.STColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property STSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.STColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property STDefault() As String
        Get
            Return TableUtils.STColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.Zip field.
	''' </summary>
	Public Property Zip() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ZipColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ZipColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ZipSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ZipColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ZipDefault() As String
        Get
            Return TableUtils.ZipColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.Country field.
	''' </summary>
	Public Property Country() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CountryColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CountryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CountrySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CountryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CountryDefault() As String
        Get
            Return TableUtils.CountryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.DeleteDesc field.
	''' </summary>
	Public Property DeleteDesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DeleteDescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DeleteDescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DeleteDescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DeleteDescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DeleteDescDefault() As String
        Get
            Return TableUtils.DeleteDescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.Dates field.
	''' </summary>
	Public Property Dates() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DatesColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DatesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DatesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DatesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DatesDefault() As String
        Get
            Return TableUtils.DatesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.EditButton field.
	''' </summary>
	Public Property EditButton() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EditButtonColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EditButtonColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EditButtonSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EditButtonColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EditButtonDefault() As String
        Get
            Return TableUtils.EditButtonColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.DeleteButton field.
	''' </summary>
	Public Property DeleteButton() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DeleteButtonColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DeleteButtonColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DeleteButtonSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DeleteButtonColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DeleteButtonDefault() As String
        Get
            Return TableUtils.DeleteButtonColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.EditImage field.
	''' </summary>
	Public Property EditImage() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EditImageColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EditImageColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EditImageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EditImageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EditImageDefault() As String
        Get
            Return TableUtils.EditImageColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.MovedIn field.
	''' </summary>
	Public Property MovedIn() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.MovedInColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MovedInColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MovedInSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MovedInColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MovedInDefault() As String
        Get
            Return TableUtils.MovedInColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.MovedOut field.
	''' </summary>
	Public Property MovedOut() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.MovedOutColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MovedOutColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MovedOutSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MovedOutColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MovedOutDefault() As String
        Get
            Return TableUtils.MovedOutColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.MovedOutOn field.
	''' </summary>
	Public Property MovedOutOn() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.MovedOutOnColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MovedOutOnColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MovedOutOnSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MovedOutOnColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MovedOutOnDefault() As String
        Get
            Return TableUtils.MovedOutOnColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.Headquarters field.
	''' </summary>
	Public Property Headquarters() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.HeadquartersColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HeadquartersColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HeadquartersSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HeadquartersColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HeadquartersDefault() As String
        Get
            Return TableUtils.HeadquartersColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.AddrName field.
	''' </summary>
	Public Property AddrName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.AddrNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.AddrNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AddrNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AddrNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AddrNameDefault() As String
        Get
            Return TableUtils.AddrNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.CitySTZip field.
	''' </summary>
	Public Property CitySTZip() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CitySTZipColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CitySTZipColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CitySTZipSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CitySTZipColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CitySTZipDefault() As String
        Get
            Return TableUtils.CitySTZipColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Addr_.CityST field.
	''' </summary>
	Public Property CityST() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CitySTColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CitySTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CitySTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CitySTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CitySTDefault() As String
        Get
            Return TableUtils.CitySTColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
