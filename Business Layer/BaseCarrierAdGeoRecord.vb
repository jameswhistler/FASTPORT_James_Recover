' This class is "generated" and will be overwritten.
' Your customizations should be made in CarrierAdGeoRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="CarrierAdGeoRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="CarrierAdGeoTable"></see> class.
''' </remarks>
''' <seealso cref="CarrierAdGeoTable"></seealso>
''' <seealso cref="CarrierAdGeoRecord"></seealso>

<Serializable()> Public Class BaseCarrierAdGeoRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As CarrierAdGeoTable = CarrierAdGeoTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub CarrierAdGeoRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim CarrierAdGeoRec As CarrierAdGeoRecord = CType(sender,CarrierAdGeoRecord)
        Validate_Inserting()
        If Not CarrierAdGeoRec Is Nothing AndAlso Not CarrierAdGeoRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub CarrierAdGeoRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim CarrierAdGeoRec As CarrierAdGeoRecord = CType(sender,CarrierAdGeoRecord)
        Validate_Updating()
        If Not CarrierAdGeoRec Is Nothing AndAlso Not CarrierAdGeoRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub CarrierAdGeoRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim CarrierAdGeoRec As CarrierAdGeoRecord = CType(sender,CarrierAdGeoRecord)
        If Not CarrierAdGeoRec Is Nothing AndAlso Not CarrierAdGeoRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdGeo_.AdGeoID field.
	''' </summary>
	Public Function GetAdGeoIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdGeoIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdGeo_.AdGeoID field.
	''' </summary>
	Public Function GetAdGeoIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdGeoIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdGeo_.AdID field.
	''' </summary>
	Public Function GetAdIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdGeo_.AdID field.
	''' </summary>
	Public Function GetAdIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdGeo_.AdGeoTypeID field.
	''' </summary>
	Public Function GetAdGeoTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdGeoTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdGeo_.AdGeoTypeID field.
	''' </summary>
	Public Function GetAdGeoTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdGeoTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.AdGeoTypeID field.
	''' </summary>
	Public Sub SetAdGeoTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdGeoTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.AdGeoTypeID field.
	''' </summary>
	Public Sub SetAdGeoTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AdGeoTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.AdGeoTypeID field.
	''' </summary>
	Public Sub SetAdGeoTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdGeoTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.AdGeoTypeID field.
	''' </summary>
	Public Sub SetAdGeoTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdGeoTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.AdGeoTypeID field.
	''' </summary>
	Public Sub SetAdGeoTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdGeoTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdGeo_.OriginCityID field.
	''' </summary>
	Public Function GetOriginCityIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.OriginCityIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdGeo_.OriginCityID field.
	''' </summary>
	Public Function GetOriginCityIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.OriginCityIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.OriginCityID field.
	''' </summary>
	Public Sub SetOriginCityIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OriginCityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.OriginCityID field.
	''' </summary>
	Public Sub SetOriginCityIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OriginCityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.OriginCityID field.
	''' </summary>
	Public Sub SetOriginCityIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OriginCityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.OriginCityID field.
	''' </summary>
	Public Sub SetOriginCityIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OriginCityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.OriginCityID field.
	''' </summary>
	Public Sub SetOriginCityIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OriginCityIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdGeo_.OriginRadius field.
	''' </summary>
	Public Function GetOriginRadiusValue() As ColumnValue
		Return Me.GetValue(TableUtils.OriginRadiusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdGeo_.OriginRadius field.
	''' </summary>
	Public Function GetOriginRadiusFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.OriginRadiusColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.OriginRadius field.
	''' </summary>
	Public Sub SetOriginRadiusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OriginRadiusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.OriginRadius field.
	''' </summary>
	Public Sub SetOriginRadiusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OriginRadiusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.OriginRadius field.
	''' </summary>
	Public Sub SetOriginRadiusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OriginRadiusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.OriginRadius field.
	''' </summary>
	Public Sub SetOriginRadiusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OriginRadiusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.OriginRadius field.
	''' </summary>
	Public Sub SetOriginRadiusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OriginRadiusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdGeo_.DestRadius field.
	''' </summary>
	Public Function GetDestRadiusValue() As ColumnValue
		Return Me.GetValue(TableUtils.DestRadiusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdGeo_.DestRadius field.
	''' </summary>
	Public Function GetDestRadiusFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DestRadiusColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.DestRadius field.
	''' </summary>
	Public Sub SetDestRadiusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DestRadiusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.DestRadius field.
	''' </summary>
	Public Sub SetDestRadiusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DestRadiusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.DestRadius field.
	''' </summary>
	Public Sub SetDestRadiusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DestRadiusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.DestRadius field.
	''' </summary>
	Public Sub SetDestRadiusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DestRadiusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.DestRadius field.
	''' </summary>
	Public Sub SetDestRadiusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DestRadiusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdGeo_.AdGeoNotes field.
	''' </summary>
	Public Function GetAdGeoNotesValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdGeoNotesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdGeo_.AdGeoNotes field.
	''' </summary>
	Public Function GetAdGeoNotesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AdGeoNotesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.AdGeoNotes field.
	''' </summary>
	Public Sub SetAdGeoNotesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdGeoNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdGeo_.AdGeoNotes field.
	''' </summary>
	Public Sub SetAdGeoNotesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdGeoNotesColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdGeo_.AdGeoID field.
	''' </summary>
	Public Property AdGeoID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AdGeoIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AdGeoIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdGeoIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdGeoIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdGeoIDDefault() As String
        Get
            Return TableUtils.AdGeoIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdGeo_.AdID field.
	''' </summary>
	Public Property AdID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AdIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AdIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdIDDefault() As String
        Get
            Return TableUtils.AdIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdGeo_.AdGeoTypeID field.
	''' </summary>
	Public Property AdGeoTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AdGeoTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AdGeoTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdGeoTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdGeoTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdGeoTypeIDDefault() As String
        Get
            Return TableUtils.AdGeoTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdGeo_.OriginCityID field.
	''' </summary>
	Public Property OriginCityID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.OriginCityIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OriginCityIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OriginCityIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OriginCityIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OriginCityIDDefault() As String
        Get
            Return TableUtils.OriginCityIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdGeo_.OriginRadius field.
	''' </summary>
	Public Property OriginRadius() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.OriginRadiusColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OriginRadiusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OriginRadiusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OriginRadiusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OriginRadiusDefault() As String
        Get
            Return TableUtils.OriginRadiusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdGeo_.DestRadius field.
	''' </summary>
	Public Property DestRadius() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DestRadiusColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DestRadiusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DestRadiusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DestRadiusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DestRadiusDefault() As String
        Get
            Return TableUtils.DestRadiusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdGeo_.AdGeoNotes field.
	''' </summary>
	Public Property AdGeoNotes() As String
		Get 
			Return CType(Me.GetValue(TableUtils.AdGeoNotesColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.AdGeoNotesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdGeoNotesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdGeoNotesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdGeoNotesDefault() As String
        Get
            Return TableUtils.AdGeoNotesColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
