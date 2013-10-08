﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in V_GeoCountryRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_GeoCountryRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_GeoCountryView"></see> class.
''' </remarks>
''' <seealso cref="V_GeoCountryView"></seealso>
''' <seealso cref="V_GeoCountryRecord"></seealso>

<Serializable()> Public Class BaseV_GeoCountryRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_GeoCountryView = V_GeoCountryView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_GeoCountryRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_GeoCountryRec As V_GeoCountryRecord = CType(sender,V_GeoCountryRecord)
        Validate_Inserting()
        If Not V_GeoCountryRec Is Nothing AndAlso Not V_GeoCountryRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_GeoCountryRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_GeoCountryRec As V_GeoCountryRecord = CType(sender,V_GeoCountryRecord)
        Validate_Updating()
        If Not V_GeoCountryRec Is Nothing AndAlso Not V_GeoCountryRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_GeoCountryRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_GeoCountryRec As V_GeoCountryRecord = CType(sender,V_GeoCountryRecord)
        If Not V_GeoCountryRec Is Nothing AndAlso Not V_GeoCountryRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCountry_.CountryID field.
	''' </summary>
	Public Function GetCountryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CountryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCountry_.CountryID field.
	''' </summary>
	Public Function GetCountryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CountryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCountry_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCountry_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCountry_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCountry_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCountry_.CountryID field.
	''' </summary>
	Public Sub SetCountryIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCountry_.Country field.
	''' </summary>
	Public Function GetCountryValue() As ColumnValue
		Return Me.GetValue(TableUtils.CountryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCountry_.Country field.
	''' </summary>
	Public Function GetCountryFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CountryColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCountry_.Country field.
	''' </summary>
	Public Sub SetCountryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCountry_.Country field.
	''' </summary>
	Public Sub SetCountryFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCountry_.CountryAbbr field.
	''' </summary>
	Public Function GetCountryAbbrValue() As ColumnValue
		Return Me.GetValue(TableUtils.CountryAbbrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GeoCountry_.CountryAbbr field.
	''' </summary>
	Public Function GetCountryAbbrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CountryAbbrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCountry_.CountryAbbr field.
	''' </summary>
	Public Sub SetCountryAbbrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CountryAbbrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GeoCountry_.CountryAbbr field.
	''' </summary>
	Public Sub SetCountryAbbrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryAbbrColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GeoCountry_.CountryID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GeoCountry_.Country field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GeoCountry_.CountryAbbr field.
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



#End Region

End Class
End Namespace
