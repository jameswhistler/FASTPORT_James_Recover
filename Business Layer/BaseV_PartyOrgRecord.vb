' This class is "generated" and will be overwritten.
' Your customizations should be made in V_PartyOrgRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_PartyOrgRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_PartyOrgView"></see> class.
''' </remarks>
''' <seealso cref="V_PartyOrgView"></seealso>
''' <seealso cref="V_PartyOrgRecord"></seealso>

<Serializable()> Public Class BaseV_PartyOrgRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_PartyOrgView = V_PartyOrgView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_PartyOrgRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_PartyOrgRec As V_PartyOrgRecord = CType(sender,V_PartyOrgRecord)
        Validate_Inserting()
        If Not V_PartyOrgRec Is Nothing AndAlso Not V_PartyOrgRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_PartyOrgRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_PartyOrgRec As V_PartyOrgRecord = CType(sender,V_PartyOrgRecord)
        Validate_Updating()
        If Not V_PartyOrgRec Is Nothing AndAlso Not V_PartyOrgRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_PartyOrgRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_PartyOrgRec As V_PartyOrgRecord = CType(sender,V_PartyOrgRecord)
        If Not V_PartyOrgRec Is Nothing AndAlso Not V_PartyOrgRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.AddrID field.
	''' </summary>
	Public Function GetAddrIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.AddrID field.
	''' </summary>
	Public Function GetAddrIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AddrIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.Logo field.
	''' </summary>
	Public Function GetLogoValue() As ColumnValue
		Return Me.GetValue(TableUtils.LogoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.Logo field.
	''' </summary>
	Public Function GetLogoFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.LogoColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.Logo field.
	''' </summary>
	Public Sub SetLogoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LogoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.Logo field.
	''' </summary>
	Public Sub SetLogoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LogoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.Logo field.
	''' </summary>
	Public Sub SetLogoFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LogoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.Company field.
	''' </summary>
	Public Function GetCompanyValue() As ColumnValue
		Return Me.GetValue(TableUtils.CompanyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.Company field.
	''' </summary>
	Public Function GetCompanyFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CompanyColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.Company field.
	''' </summary>
	Public Sub SetCompanyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.Company field.
	''' </summary>
	Public Sub SetCompanyFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.AddrName field.
	''' </summary>
	Public Function GetAddrNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.AddrName field.
	''' </summary>
	Public Function GetAddrNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AddrNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.AddrName field.
	''' </summary>
	Public Sub SetAddrNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.AddrName field.
	''' </summary>
	Public Sub SetAddrNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.PointOfInterest field.
	''' </summary>
	Public Function GetPointOfInterestValue() As ColumnValue
		Return Me.GetValue(TableUtils.PointOfInterestColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.PointOfInterest field.
	''' </summary>
	Public Function GetPointOfInterestFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PointOfInterestColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.PointOfInterest field.
	''' </summary>
	Public Sub SetPointOfInterestFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PointOfInterestColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.PointOfInterest field.
	''' </summary>
	Public Sub SetPointOfInterestFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PointOfInterestColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.ContactInfo field.
	''' </summary>
	Public Function GetContactInfoValue() As ColumnValue
		Return Me.GetValue(TableUtils.ContactInfoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.ContactInfo field.
	''' </summary>
	Public Function GetContactInfoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ContactInfoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.ContactInfo field.
	''' </summary>
	Public Sub SetContactInfoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ContactInfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.ContactInfo field.
	''' </summary>
	Public Sub SetContactInfoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ContactInfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.Pins field.
	''' </summary>
	Public Function GetPinsValue() As ColumnValue
		Return Me.GetValue(TableUtils.PinsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.Pins field.
	''' </summary>
	Public Function GetPinsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PinsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.Pins field.
	''' </summary>
	Public Sub SetPinsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PinsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.Pins field.
	''' </summary>
	Public Sub SetPinsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PinsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.PinsSmall field.
	''' </summary>
	Public Function GetPinsSmallValue() As ColumnValue
		Return Me.GetValue(TableUtils.PinsSmallColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.PinsSmall field.
	''' </summary>
	Public Function GetPinsSmallFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PinsSmallColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.PinsSmall field.
	''' </summary>
	Public Sub SetPinsSmallFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PinsSmallColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.PinsSmall field.
	''' </summary>
	Public Sub SetPinsSmallFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PinsSmallColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.PointStats field.
	''' </summary>
	Public Function GetPointStatsValue() As ColumnValue
		Return Me.GetValue(TableUtils.PointStatsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.PointStats field.
	''' </summary>
	Public Function GetPointStatsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PointStatsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.PointStats field.
	''' </summary>
	Public Sub SetPointStatsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PointStatsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.PointStats field.
	''' </summary>
	Public Sub SetPointStatsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PointStatsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.CityST field.
	''' </summary>
	Public Function GetCitySTValue() As ColumnValue
		Return Me.GetValue(TableUtils.CitySTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyOrg_.CityST field.
	''' </summary>
	Public Function GetCitySTFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CitySTColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.CityST field.
	''' </summary>
	Public Sub SetCitySTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CitySTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyOrg_.CityST field.
	''' </summary>
	Public Sub SetCitySTFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CitySTColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PartyOrg_.AddrID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PartyOrg_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PartyOrg_.Logo field.
	''' </summary>
	Public Property Logo() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.LogoColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LogoColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LogoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LogoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LogoDefault() As String
        Get
            Return TableUtils.LogoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PartyOrg_.Company field.
	''' </summary>
	Public Property Company() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CompanyColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CompanyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CompanySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CompanyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CompanyDefault() As String
        Get
            Return TableUtils.CompanyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PartyOrg_.AddrName field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PartyOrg_.PointOfInterest field.
	''' </summary>
	Public Property PointOfInterest() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PointOfInterestColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PointOfInterestColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PointOfInterestSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PointOfInterestColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PointOfInterestDefault() As String
        Get
            Return TableUtils.PointOfInterestColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PartyOrg_.ContactInfo field.
	''' </summary>
	Public Property ContactInfo() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ContactInfoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ContactInfoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ContactInfoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ContactInfoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ContactInfoDefault() As String
        Get
            Return TableUtils.ContactInfoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PartyOrg_.Pins field.
	''' </summary>
	Public Property Pins() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PinsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PinsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PinsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PinsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PinsDefault() As String
        Get
            Return TableUtils.PinsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PartyOrg_.PinsSmall field.
	''' </summary>
	Public Property PinsSmall() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PinsSmallColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PinsSmallColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PinsSmallSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PinsSmallColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PinsSmallDefault() As String
        Get
            Return TableUtils.PinsSmallColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PartyOrg_.PointStats field.
	''' </summary>
	Public Property PointStats() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PointStatsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PointStatsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PointStatsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PointStatsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PointStatsDefault() As String
        Get
            Return TableUtils.PointStatsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PartyOrg_.CityST field.
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
