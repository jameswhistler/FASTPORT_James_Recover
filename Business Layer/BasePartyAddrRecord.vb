' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyAddrRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PartyAddrRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="PartyAddrTable"></see> class.
''' </remarks>
''' <seealso cref="PartyAddrTable"></seealso>
''' <seealso cref="PartyAddrRecord"></seealso>

<Serializable()> Public Class BasePartyAddrRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As PartyAddrTable = PartyAddrTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub PartyAddrRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim PartyAddrRec As PartyAddrRecord = CType(sender,PartyAddrRecord)
        Validate_Inserting()
        If Not PartyAddrRec Is Nothing AndAlso Not PartyAddrRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub PartyAddrRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim PartyAddrRec As PartyAddrRecord = CType(sender,PartyAddrRecord)
        Validate_Updating()
        If Not PartyAddrRec Is Nothing AndAlso Not PartyAddrRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub PartyAddrRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim PartyAddrRec As PartyAddrRecord = CType(sender,PartyAddrRecord)
        If Not PartyAddrRec Is Nothing AndAlso Not PartyAddrRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.AddrID field.
	''' </summary>
	Public Function GetAddrIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.AddrID field.
	''' </summary>
	Public Function GetAddrIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AddrIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.AddrName field.
	''' </summary>
	Public Function GetAddrNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.AddrName field.
	''' </summary>
	Public Function GetAddrNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AddrNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.AddrName field.
	''' </summary>
	Public Sub SetAddrNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.AddrName field.
	''' </summary>
	Public Sub SetAddrNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Addr field.
	''' </summary>
	Public Function GetAddrValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Addr field.
	''' </summary>
	Public Function GetAddrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AddrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Addr field.
	''' </summary>
	Public Sub SetAddrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Addr field.
	''' </summary>
	Public Sub SetAddrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Addr2 field.
	''' </summary>
	Public Function GetAddr2Value() As ColumnValue
		Return Me.GetValue(TableUtils.Addr2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Addr2 field.
	''' </summary>
	Public Function GetAddr2FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Addr2Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Addr2 field.
	''' </summary>
	Public Sub SetAddr2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Addr2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Addr2 field.
	''' </summary>
	Public Sub SetAddr2FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Addr2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.AddrZipID field.
	''' </summary>
	Public Function GetAddrZipIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrZipIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.AddrZipID field.
	''' </summary>
	Public Function GetAddrZipIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AddrZipIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.AddrZipID field.
	''' </summary>
	Public Sub SetAddrZipIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.AddrZipID field.
	''' </summary>
	Public Sub SetAddrZipIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AddrZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.AddrZipID field.
	''' </summary>
	Public Sub SetAddrZipIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.AddrZipID field.
	''' </summary>
	Public Sub SetAddrZipIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrZipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.AddrZipID field.
	''' </summary>
	Public Sub SetAddrZipIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrZipIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.CountryID field.
	''' </summary>
	Public Function GetCountryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CountryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.CountryID field.
	''' </summary>
	Public Function GetCountryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CountryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Headquarters field.
	''' </summary>
	Public Function GetHeadquartersValue() As ColumnValue
		Return Me.GetValue(TableUtils.HeadquartersColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Headquarters field.
	''' </summary>
	Public Function GetHeadquartersFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.HeadquartersColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Headquarters field.
	''' </summary>
	Public Sub SetHeadquartersFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HeadquartersColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Headquarters field.
	''' </summary>
	Public Sub SetHeadquartersFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HeadquartersColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Headquarters field.
	''' </summary>
	Public Sub SetHeadquartersFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HeadquartersColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.DirectDail field.
	''' </summary>
	Public Function GetDirectDailValue() As ColumnValue
		Return Me.GetValue(TableUtils.DirectDailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.DirectDail field.
	''' </summary>
	Public Function GetDirectDailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DirectDailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.DirectDail field.
	''' </summary>
	Public Sub SetDirectDailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DirectDailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.DirectDail field.
	''' </summary>
	Public Sub SetDirectDailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DirectDailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.OtherPhone field.
	''' </summary>
	Public Function GetOtherPhoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.OtherPhoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.OtherPhone field.
	''' </summary>
	Public Function GetOtherPhoneFieldValue() As String
		Return CType(Me.GetValue(TableUtils.OtherPhoneColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.OtherPhone field.
	''' </summary>
	Public Sub SetOtherPhoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OtherPhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.OtherPhone field.
	''' </summary>
	Public Sub SetOtherPhoneFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OtherPhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Fax field.
	''' </summary>
	Public Function GetFaxValue() As ColumnValue
		Return Me.GetValue(TableUtils.FaxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Fax field.
	''' </summary>
	Public Function GetFaxFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FaxColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Fax field.
	''' </summary>
	Public Sub SetFaxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Fax field.
	''' </summary>
	Public Sub SetFaxFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Email field.
	''' </summary>
	Public Function GetEmailValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Email field.
	''' </summary>
	Public Function GetEmailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Website field.
	''' </summary>
	Public Function GetWebsiteValue() As ColumnValue
		Return Me.GetValue(TableUtils.WebsiteColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Website field.
	''' </summary>
	Public Function GetWebsiteFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WebsiteColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Website field.
	''' </summary>
	Public Sub SetWebsiteFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WebsiteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Website field.
	''' </summary>
	Public Sub SetWebsiteFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WebsiteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Directions field.
	''' </summary>
	Public Function GetDirectionsValue() As ColumnValue
		Return Me.GetValue(TableUtils.DirectionsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Directions field.
	''' </summary>
	Public Function GetDirectionsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DirectionsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Directions field.
	''' </summary>
	Public Sub SetDirectionsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DirectionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Directions field.
	''' </summary>
	Public Sub SetDirectionsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DirectionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Lat field.
	''' </summary>
	Public Function GetLatValue() As ColumnValue
		Return Me.GetValue(TableUtils.LatColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Lat field.
	''' </summary>
	Public Function GetLatFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.LatColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LatColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Long field.
	''' </summary>
	Public Function GetLong0Value() As ColumnValue
		Return Me.GetValue(TableUtils.Long0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.Long field.
	''' </summary>
	Public Function GetLong0FieldValue() As Double
		Return CType(Me.GetValue(TableUtils.Long0Column).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Long0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Long0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Long0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Long0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Long0Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.MovedIn field.
	''' </summary>
	Public Function GetMovedInValue() As ColumnValue
		Return Me.GetValue(TableUtils.MovedInColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.MovedIn field.
	''' </summary>
	Public Function GetMovedInFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.MovedInColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.MovedIn field.
	''' </summary>
	Public Sub SetMovedInFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MovedInColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.MovedIn field.
	''' </summary>
	Public Sub SetMovedInFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MovedInColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.MovedIn field.
	''' </summary>
	Public Sub SetMovedInFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MovedInColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.MovedOut field.
	''' </summary>
	Public Function GetMovedOutValue() As ColumnValue
		Return Me.GetValue(TableUtils.MovedOutColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.MovedOut field.
	''' </summary>
	Public Function GetMovedOutFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.MovedOutColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.MovedOut field.
	''' </summary>
	Public Sub SetMovedOutFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MovedOutColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.MovedOut field.
	''' </summary>
	Public Sub SetMovedOutFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MovedOutColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.MovedOut field.
	''' </summary>
	Public Sub SetMovedOutFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MovedOutColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.MovedOutOn field.
	''' </summary>
	Public Function GetMovedOutOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.MovedOutOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.MovedOutOn field.
	''' </summary>
	Public Function GetMovedOutOnFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.MovedOutOnColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.MovedOutOn field.
	''' </summary>
	Public Sub SetMovedOutOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MovedOutOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.MovedOutOn field.
	''' </summary>
	Public Sub SetMovedOutOnFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MovedOutOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.MovedOutOn field.
	''' </summary>
	Public Sub SetMovedOutOnFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MovedOutOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.FuelTypeID field.
	''' </summary>
	Public Function GetFuelTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FuelTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.FuelTypeID field.
	''' </summary>
	Public Function GetFuelTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FuelTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.FuelTypeID field.
	''' </summary>
	Public Sub SetFuelTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FuelTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.FuelTypeID field.
	''' </summary>
	Public Sub SetFuelTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FuelTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.FuelTypeID field.
	''' </summary>
	Public Sub SetFuelTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FuelTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.FuelTypeID field.
	''' </summary>
	Public Sub SetFuelTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FuelTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.FuelTypeID field.
	''' </summary>
	Public Sub SetFuelTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FuelTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.OutsideID field.
	''' </summary>
	Public Function GetOutsideIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.OutsideIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.OutsideID field.
	''' </summary>
	Public Function GetOutsideIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.OutsideIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.OutsideID field.
	''' </summary>
	Public Sub SetOutsideIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OutsideIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.OutsideID field.
	''' </summary>
	Public Sub SetOutsideIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OutsideIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyAddr_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyAddr_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.AddrID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.AddrName field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.Addr field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.Addr2 field.
	''' </summary>
	Public Property Addr2() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Addr2Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Addr2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Addr2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Addr2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Addr2Default() As String
        Get
            Return TableUtils.Addr2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.AddrZipID field.
	''' </summary>
	Public Property AddrZipID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AddrZipIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AddrZipIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AddrZipIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AddrZipIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AddrZipIDDefault() As String
        Get
            Return TableUtils.AddrZipIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.CountryID field.
	''' </summary>
	Public Property CountryID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CountryIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CountryIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CountryIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CountryIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CountryIDDefault() As String
        Get
            Return TableUtils.CountryIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.Headquarters field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.DirectDail field.
	''' </summary>
	Public Property DirectDail() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DirectDailColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DirectDailColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DirectDailSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DirectDailColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DirectDailDefault() As String
        Get
            Return TableUtils.DirectDailColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.OtherPhone field.
	''' </summary>
	Public Property OtherPhone() As String
		Get 
			Return CType(Me.GetValue(TableUtils.OtherPhoneColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.OtherPhoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OtherPhoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OtherPhoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OtherPhoneDefault() As String
        Get
            Return TableUtils.OtherPhoneColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.Fax field.
	''' </summary>
	Public Property Fax() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FaxColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FaxColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FaxSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FaxColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FaxDefault() As String
        Get
            Return TableUtils.FaxColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.Email field.
	''' </summary>
	Public Property Email() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EmailColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EmailColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmailSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmailColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmailDefault() As String
        Get
            Return TableUtils.EmailColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.Website field.
	''' </summary>
	Public Property Website() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WebsiteColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WebsiteColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WebsiteSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WebsiteColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WebsiteDefault() As String
        Get
            Return TableUtils.WebsiteColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.Directions field.
	''' </summary>
	Public Property Directions() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DirectionsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DirectionsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DirectionsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DirectionsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DirectionsDefault() As String
        Get
            Return TableUtils.DirectionsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.Lat field.
	''' </summary>
	Public Property Lat() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.LatColumn).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LatColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LatSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LatColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LatDefault() As String
        Get
            Return TableUtils.LatColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.Long field.
	''' </summary>
	Public Property Long0() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.Long0Column).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Long0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Long0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Long0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Long0Default() As String
        Get
            Return TableUtils.Long0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.MovedIn field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.MovedOut field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.MovedOutOn field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.FuelTypeID field.
	''' </summary>
	Public Property FuelTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FuelTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FuelTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FuelTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FuelTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FuelTypeIDDefault() As String
        Get
            Return TableUtils.FuelTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.OutsideID field.
	''' </summary>
	Public Property OutsideID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.OutsideIDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.OutsideIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OutsideIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OutsideIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OutsideIDDefault() As String
        Get
            Return TableUtils.OutsideIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyAddr_.UpdatedAt field.
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
