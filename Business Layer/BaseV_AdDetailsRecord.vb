' This class is "generated" and will be overwritten.
' Your customizations should be made in V_AdDetailsRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_AdDetailsRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_AdDetailsView"></see> class.
''' </remarks>
''' <seealso cref="V_AdDetailsView"></seealso>
''' <seealso cref="V_AdDetailsRecord"></seealso>

<Serializable()> Public Class BaseV_AdDetailsRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_AdDetailsView = V_AdDetailsView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_AdDetailsRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_AdDetailsRec As V_AdDetailsRecord = CType(sender,V_AdDetailsRecord)
        Validate_Inserting()
        If Not V_AdDetailsRec Is Nothing AndAlso Not V_AdDetailsRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_AdDetailsRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_AdDetailsRec As V_AdDetailsRecord = CType(sender,V_AdDetailsRecord)
        Validate_Updating()
        If Not V_AdDetailsRec Is Nothing AndAlso Not V_AdDetailsRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_AdDetailsRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_AdDetailsRec As V_AdDetailsRecord = CType(sender,V_AdDetailsRecord)
        If Not V_AdDetailsRec Is Nothing AndAlso Not V_AdDetailsRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.AdID field.
	''' </summary>
	Public Function GetAdIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.AdID field.
	''' </summary>
	Public Function GetAdIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.CarrierID field.
	''' </summary>
	Public Function GetCarrierIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.CarrierID field.
	''' </summary>
	Public Function GetCarrierIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CarrierIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.AdHTML field.
	''' </summary>
	Public Function GetAdHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.AdHTML field.
	''' </summary>
	Public Function GetAdHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AdHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.AdHTML field.
	''' </summary>
	Public Sub SetAdHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.AdHTML field.
	''' </summary>
	Public Sub SetAdHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.LongDescription field.
	''' </summary>
	Public Function GetLongDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.LongDescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.LongDescription field.
	''' </summary>
	Public Function GetLongDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.LongDescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.LongDescription field.
	''' </summary>
	Public Sub SetLongDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LongDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.LongDescription field.
	''' </summary>
	Public Sub SetLongDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LongDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.GeneralExperience field.
	''' </summary>
	Public Function GetGeneralExperienceValue() As ColumnValue
		Return Me.GetValue(TableUtils.GeneralExperienceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.GeneralExperience field.
	''' </summary>
	Public Function GetGeneralExperienceFieldValue() As String
		Return CType(Me.GetValue(TableUtils.GeneralExperienceColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.GeneralExperience field.
	''' </summary>
	Public Sub SetGeneralExperienceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GeneralExperienceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.GeneralExperience field.
	''' </summary>
	Public Sub SetGeneralExperienceFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GeneralExperienceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.EquipExperience field.
	''' </summary>
	Public Function GetEquipExperienceValue() As ColumnValue
		Return Me.GetValue(TableUtils.EquipExperienceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.EquipExperience field.
	''' </summary>
	Public Function GetEquipExperienceFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EquipExperienceColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.EquipExperience field.
	''' </summary>
	Public Sub SetEquipExperienceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EquipExperienceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.EquipExperience field.
	''' </summary>
	Public Sub SetEquipExperienceFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EquipExperienceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.CargoExperience field.
	''' </summary>
	Public Function GetCargoExperienceValue() As ColumnValue
		Return Me.GetValue(TableUtils.CargoExperienceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.CargoExperience field.
	''' </summary>
	Public Function GetCargoExperienceFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CargoExperienceColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.CargoExperience field.
	''' </summary>
	Public Sub SetCargoExperienceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CargoExperienceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.CargoExperience field.
	''' </summary>
	Public Sub SetCargoExperienceFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CargoExperienceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.RegionalExperience field.
	''' </summary>
	Public Function GetRegionalExperienceValue() As ColumnValue
		Return Me.GetValue(TableUtils.RegionalExperienceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.RegionalExperience field.
	''' </summary>
	Public Function GetRegionalExperienceFieldValue() As String
		Return CType(Me.GetValue(TableUtils.RegionalExperienceColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.RegionalExperience field.
	''' </summary>
	Public Sub SetRegionalExperienceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RegionalExperienceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.RegionalExperience field.
	''' </summary>
	Public Sub SetRegionalExperienceFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RegionalExperienceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.Requirements field.
	''' </summary>
	Public Function GetRequirementsValue() As ColumnValue
		Return Me.GetValue(TableUtils.RequirementsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.Requirements field.
	''' </summary>
	Public Function GetRequirementsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.RequirementsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.Requirements field.
	''' </summary>
	Public Sub SetRequirementsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RequirementsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.Requirements field.
	''' </summary>
	Public Sub SetRequirementsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RequirementsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.PayHTML field.
	''' </summary>
	Public Function GetPayHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.PayHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AdDetails_.PayHTML field.
	''' </summary>
	Public Function GetPayHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PayHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.PayHTML field.
	''' </summary>
	Public Sub SetPayHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PayHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AdDetails_.PayHTML field.
	''' </summary>
	Public Sub SetPayHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PayHTMLColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AdDetails_.AdID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_AdDetails_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_AdDetails_.CarrierID field.
	''' </summary>
	Public Property CarrierID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CarrierIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CarrierIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CarrierIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CarrierIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CarrierIDDefault() As String
        Get
            Return TableUtils.CarrierIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AdDetails_.AdHTML field.
	''' </summary>
	Public Property AdHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.AdHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.AdHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdHTMLDefault() As String
        Get
            Return TableUtils.AdHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AdDetails_.LongDescription field.
	''' </summary>
	Public Property LongDescription() As String
		Get 
			Return CType(Me.GetValue(TableUtils.LongDescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.LongDescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LongDescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LongDescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LongDescriptionDefault() As String
        Get
            Return TableUtils.LongDescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AdDetails_.GeneralExperience field.
	''' </summary>
	Public Property GeneralExperience() As String
		Get 
			Return CType(Me.GetValue(TableUtils.GeneralExperienceColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.GeneralExperienceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GeneralExperienceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GeneralExperienceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GeneralExperienceDefault() As String
        Get
            Return TableUtils.GeneralExperienceColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AdDetails_.EquipExperience field.
	''' </summary>
	Public Property EquipExperience() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EquipExperienceColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EquipExperienceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EquipExperienceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EquipExperienceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EquipExperienceDefault() As String
        Get
            Return TableUtils.EquipExperienceColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AdDetails_.CargoExperience field.
	''' </summary>
	Public Property CargoExperience() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CargoExperienceColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CargoExperienceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CargoExperienceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CargoExperienceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CargoExperienceDefault() As String
        Get
            Return TableUtils.CargoExperienceColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AdDetails_.RegionalExperience field.
	''' </summary>
	Public Property RegionalExperience() As String
		Get 
			Return CType(Me.GetValue(TableUtils.RegionalExperienceColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.RegionalExperienceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RegionalExperienceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RegionalExperienceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RegionalExperienceDefault() As String
        Get
            Return TableUtils.RegionalExperienceColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AdDetails_.Requirements field.
	''' </summary>
	Public Property Requirements() As String
		Get 
			Return CType(Me.GetValue(TableUtils.RequirementsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.RequirementsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RequirementsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RequirementsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RequirementsDefault() As String
        Get
            Return TableUtils.RequirementsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AdDetails_.PayHTML field.
	''' </summary>
	Public Property PayHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PayHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PayHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PayHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PayHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PayHTMLDefault() As String
        Get
            Return TableUtils.PayHTMLColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
