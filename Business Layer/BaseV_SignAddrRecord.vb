' This class is "generated" and will be overwritten.
' Your customizations should be made in V_SignAddrRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_SignAddrRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_SignAddrView"></see> class.
''' </remarks>
''' <seealso cref="V_SignAddrView"></seealso>
''' <seealso cref="V_SignAddrRecord"></seealso>

<Serializable()> Public Class BaseV_SignAddrRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_SignAddrView = V_SignAddrView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_SignAddrRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_SignAddrRec As V_SignAddrRecord = CType(sender,V_SignAddrRecord)
        Validate_Inserting()
        If Not V_SignAddrRec Is Nothing AndAlso Not V_SignAddrRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_SignAddrRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_SignAddrRec As V_SignAddrRecord = CType(sender,V_SignAddrRecord)
        Validate_Updating()
        If Not V_SignAddrRec Is Nothing AndAlso Not V_SignAddrRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_SignAddrRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_SignAddrRec As V_SignAddrRecord = CType(sender,V_SignAddrRecord)
        If Not V_SignAddrRec Is Nothing AndAlso Not V_SignAddrRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.AddrID field.
	''' </summary>
	Public Function GetAddrIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.AddrID field.
	''' </summary>
	Public Function GetAddrIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AddrIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.AddrID field.
	''' </summary>
	Public Sub SetAddrIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.AddrHTML field.
	''' </summary>
	Public Function GetAddrHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.AddrHTML field.
	''' </summary>
	Public Function GetAddrHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AddrHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.AddrHTML field.
	''' </summary>
	Public Sub SetAddrHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.AddrHTML field.
	''' </summary>
	Public Sub SetAddrHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.Addr field.
	''' </summary>
	Public Function GetAddrValue() As ColumnValue
		Return Me.GetValue(TableUtils.AddrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.Addr field.
	''' </summary>
	Public Function GetAddrFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AddrColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.Addr field.
	''' </summary>
	Public Sub SetAddrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.Addr field.
	''' </summary>
	Public Sub SetAddrFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AddrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.City field.
	''' </summary>
	Public Function GetCityValue() As ColumnValue
		Return Me.GetValue(TableUtils.CityColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.City field.
	''' </summary>
	Public Function GetCityFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CityColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.City field.
	''' </summary>
	Public Sub SetCityFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.City field.
	''' </summary>
	Public Sub SetCityFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.ST field.
	''' </summary>
	Public Function GetSTValue() As ColumnValue
		Return Me.GetValue(TableUtils.STColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.ST field.
	''' </summary>
	Public Function GetSTFieldValue() As String
		Return CType(Me.GetValue(TableUtils.STColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.ST field.
	''' </summary>
	Public Sub SetSTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.STColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.ST field.
	''' </summary>
	Public Sub SetSTFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.STColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.Zip field.
	''' </summary>
	Public Function GetZipValue() As ColumnValue
		Return Me.GetValue(TableUtils.ZipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.Zip field.
	''' </summary>
	Public Function GetZipFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ZipColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.Zip field.
	''' </summary>
	Public Sub SetZipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.Zip field.
	''' </summary>
	Public Sub SetZipFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ZipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.Country field.
	''' </summary>
	Public Function GetCountryValue() As ColumnValue
		Return Me.GetValue(TableUtils.CountryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignAddr_.Country field.
	''' </summary>
	Public Function GetCountryFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CountryColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.Country field.
	''' </summary>
	Public Sub SetCountryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CountryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignAddr_.Country field.
	''' </summary>
	Public Sub SetCountryFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CountryColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignAddr_.AddrID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SignAddr_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SignAddr_.AddrHTML field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SignAddr_.Addr field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SignAddr_.City field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SignAddr_.ST field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SignAddr_.Zip field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SignAddr_.Country field.
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



#End Region

End Class
End Namespace
