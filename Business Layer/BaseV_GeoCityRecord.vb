' This class is "generated" and will be overwritten.
' Your customizations should be made in V_GeoCityRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_GeoCityRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_GeoCityView"></see> class.
''' </remarks>
''' <seealso cref="V_GeoCityView"></seealso>
''' <seealso cref="V_GeoCityRecord"></seealso>

<Serializable()> Public Class BaseV_GeoCityRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_GeoCityView = V_GeoCityView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_GeoCityRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_GeoCityRec As V_GeoCityRecord = CType(sender,V_GeoCityRecord)
        Validate_Inserting()
        If Not V_GeoCityRec Is Nothing AndAlso Not V_GeoCityRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_GeoCityRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_GeoCityRec As V_GeoCityRecord = CType(sender,V_GeoCityRecord)
        Validate_Updating()
        If Not V_GeoCityRec Is Nothing AndAlso Not V_GeoCityRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_GeoCityRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_GeoCityRec As V_GeoCityRecord = CType(sender,V_GeoCityRecord)
        If Not V_GeoCityRec Is Nothing AndAlso Not V_GeoCityRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.CountryID field.
	''' </summary>
	Public Function GetCountryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CountryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.CountryID field.
	''' </summary>
	Public Function GetCountryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CountryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.Country field.
	''' </summary>
	Public Function GetCountryValue() As ColumnValue
		Return Me.GetValue(TableUtils.CountryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.Country field.
	''' </summary>
	Public Function GetCountryFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CountryColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.Country field.
	''' </summary>
	Public Sub SetCountryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.Country field.
	''' </summary>
	Public Sub SetCountryFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.CountryAbbr field.
	''' </summary>
	Public Function GetCountryAbbrValue() As ColumnValue
		Return Me.GetValue(TableUtils.CountryAbbrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.CountryAbbr field.
	''' </summary>
	Public Function GetCountryAbbrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CountryAbbrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.CountryAbbr field.
	''' </summary>
	Public Sub SetCountryAbbrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CountryAbbrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.CountryAbbr field.
	''' </summary>
	Public Sub SetCountryAbbrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryAbbrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.StateID field.
	''' </summary>
	Public Function GetStateIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.StateIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.StateID field.
	''' </summary>
	Public Function GetStateIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.StateIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.StateID field.
	''' </summary>
	Public Sub SetStateIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StateIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.StateID field.
	''' </summary>
	Public Sub SetStateIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.StateIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.StateID field.
	''' </summary>
	Public Sub SetStateIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StateIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.StateID field.
	''' </summary>
	Public Sub SetStateIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StateIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.StateID field.
	''' </summary>
	Public Sub SetStateIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StateIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.CityST field.
	''' </summary>
	Public Function GetCitySTValue() As ColumnValue
		Return Me.GetValue(TableUtils.CitySTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.CityST field.
	''' </summary>
	Public Function GetCitySTFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CitySTColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.CityST field.
	''' </summary>
	Public Sub SetCitySTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CitySTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.CityST field.
	''' </summary>
	Public Sub SetCitySTFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CitySTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.CityID field.
	''' </summary>
	Public Function GetCityIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CityIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.CityID field.
	''' </summary>
	Public Function GetCityIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CityIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.CityID field.
	''' </summary>
	Public Sub SetCityIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.CityID field.
	''' </summary>
	Public Sub SetCityIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.CityID field.
	''' </summary>
	Public Sub SetCityIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.CityID field.
	''' </summary>
	Public Sub SetCityIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.CityID field.
	''' </summary>
	Public Sub SetCityIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CityIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.City field.
	''' </summary>
	Public Function GetCityValue() As ColumnValue
		Return Me.GetValue(TableUtils.CityColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.City field.
	''' </summary>
	Public Function GetCityFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CityColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.City field.
	''' </summary>
	Public Sub SetCityFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.City field.
	''' </summary>
	Public Sub SetCityFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.ST field.
	''' </summary>
	Public Function GetSTValue() As ColumnValue
		Return Me.GetValue(TableUtils.STColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.ST field.
	''' </summary>
	Public Function GetSTFieldValue() As String
		Return CType(Me.GetValue(TableUtils.STColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.ST field.
	''' </summary>
	Public Sub SetSTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.STColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.ST field.
	''' </summary>
	Public Sub SetSTFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.STColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.STName field.
	''' </summary>
	Public Function GetSTNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.STNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.STName field.
	''' </summary>
	Public Function GetSTNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.STNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.STName field.
	''' </summary>
	Public Sub SetSTNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.STNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.STName field.
	''' </summary>
	Public Sub SetSTNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.STNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.Lat field.
	''' </summary>
	Public Function GetLatValue() As ColumnValue
		Return Me.GetValue(TableUtils.LatColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.Lat field.
	''' </summary>
	Public Function GetLatFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.LatColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.Lat field.
	''' </summary>
	Public Sub SetLatFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LatColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.Long field.
	''' </summary>
	Public Function GetLong0Value() As ColumnValue
		Return Me.GetValue(TableUtils.Long0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCity_.Long field.
	''' </summary>
	Public Function GetLong0FieldValue() As Double
		Return CType(Me.GetValue(TableUtils.Long0Column).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Long0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Long0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Long0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Long0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCity_.Long field.
	''' </summary>
	Public Sub SetLong0FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Long0Column)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GeoCity_.CountryID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GeoCity_.Country field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GeoCity_.CountryAbbr field.
	''' </summary>
	Public Property CountryAbbr() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CountryAbbrColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CountryAbbrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CountryAbbrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CountryAbbrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CountryAbbrDefault() As String
        Get
            Return TableUtils.CountryAbbrColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GeoCity_.StateID field.
	''' </summary>
	Public Property StateID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.StateIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.StateIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property StateIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.StateIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property StateIDDefault() As String
        Get
            Return TableUtils.StateIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GeoCity_.CityST field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GeoCity_.CityID field.
	''' </summary>
	Public Property CityID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CityIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CityIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CityIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CityIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CityIDDefault() As String
        Get
            Return TableUtils.CityIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GeoCity_.City field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GeoCity_.ST field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GeoCity_.STName field.
	''' </summary>
	Public Property STName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.STNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.STNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property STNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.STNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property STNameDefault() As String
        Get
            Return TableUtils.STNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GeoCity_.Lat field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GeoCity_.Long field.
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



#End Region

End Class
End Namespace
