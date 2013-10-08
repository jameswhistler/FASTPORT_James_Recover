' This class is "generated" and will be overwritten.
' Your customizations should be made in V_SignHistoryRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_SignHistoryRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_SignHistoryView"></see> class.
''' </remarks>
''' <seealso cref="V_SignHistoryView"></seealso>
''' <seealso cref="V_SignHistoryRecord"></seealso>

<Serializable()> Public Class BaseV_SignHistoryRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_SignHistoryView = V_SignHistoryView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_SignHistoryRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_SignHistoryRec As V_SignHistoryRecord = CType(sender,V_SignHistoryRecord)
        Validate_Inserting()
        If Not V_SignHistoryRec Is Nothing AndAlso Not V_SignHistoryRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_SignHistoryRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_SignHistoryRec As V_SignHistoryRecord = CType(sender,V_SignHistoryRecord)
        Validate_Updating()
        If Not V_SignHistoryRec Is Nothing AndAlso Not V_SignHistoryRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_SignHistoryRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_SignHistoryRec As V_SignHistoryRecord = CType(sender,V_SignHistoryRecord)
        If Not V_SignHistoryRec Is Nothing AndAlso Not V_SignHistoryRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.HistoryID field.
	''' </summary>
	Public Function GetHistoryIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.HistoryIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.HistoryID field.
	''' </summary>
	Public Function GetHistoryIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HistoryIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.HistoryID field.
	''' </summary>
	Public Sub SetHistoryIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.HistoryHTML field.
	''' </summary>
	Public Function GetHistoryHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.HistoryHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.HistoryHTML field.
	''' </summary>
	Public Function GetHistoryHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.HistoryHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.HistoryHTML field.
	''' </summary>
	Public Sub SetHistoryHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HistoryHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.HistoryHTML field.
	''' </summary>
	Public Sub SetHistoryHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HistoryHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.ExpGeneral field.
	''' </summary>
	Public Function GetExpGeneralValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExpGeneralColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.ExpGeneral field.
	''' </summary>
	Public Function GetExpGeneralFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ExpGeneralColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.ExpGeneral field.
	''' </summary>
	Public Sub SetExpGeneralFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExpGeneralColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.ExpGeneral field.
	''' </summary>
	Public Sub SetExpGeneralFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExpGeneralColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.ExpEquipment field.
	''' </summary>
	Public Function GetExpEquipmentValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExpEquipmentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.ExpEquipment field.
	''' </summary>
	Public Function GetExpEquipmentFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ExpEquipmentColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.ExpEquipment field.
	''' </summary>
	Public Sub SetExpEquipmentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExpEquipmentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.ExpEquipment field.
	''' </summary>
	Public Sub SetExpEquipmentFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExpEquipmentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.ExpCargo field.
	''' </summary>
	Public Function GetExpCargoValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExpCargoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.ExpCargo field.
	''' </summary>
	Public Function GetExpCargoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ExpCargoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.ExpCargo field.
	''' </summary>
	Public Sub SetExpCargoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExpCargoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.ExpCargo field.
	''' </summary>
	Public Sub SetExpCargoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExpCargoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.ExpRegions field.
	''' </summary>
	Public Function GetExpRegionsValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExpRegionsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.ExpRegions field.
	''' </summary>
	Public Function GetExpRegionsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ExpRegionsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.ExpRegions field.
	''' </summary>
	Public Sub SetExpRegionsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExpRegionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.ExpRegions field.
	''' </summary>
	Public Sub SetExpRegionsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExpRegionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.FirstSort field.
	''' </summary>
	Public Function GetFirstSortValue() As ColumnValue
		Return Me.GetValue(TableUtils.FirstSortColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.FirstSort field.
	''' </summary>
	Public Function GetFirstSortFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FirstSortColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.FirstSort field.
	''' </summary>
	Public Sub SetFirstSortFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FirstSortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.FirstSort field.
	''' </summary>
	Public Sub SetFirstSortFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FirstSortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.FirstSort field.
	''' </summary>
	Public Sub SetFirstSortFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstSortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.FirstSort field.
	''' </summary>
	Public Sub SetFirstSortFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstSortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.FirstSort field.
	''' </summary>
	Public Sub SetFirstSortFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FirstSortColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.StartDate field.
	''' </summary>
	Public Function GetStartDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.StartDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.StartDate field.
	''' </summary>
	Public Function GetStartDateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.StartDateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.StartDate field.
	''' </summary>
	Public Sub SetStartDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StartDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.StartDate field.
	''' </summary>
	Public Sub SetStartDateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.StartDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.StartDate field.
	''' </summary>
	Public Sub SetStartDateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StartDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.EndDate field.
	''' </summary>
	Public Function GetEndDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.EndDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignHistory_.EndDate field.
	''' </summary>
	Public Function GetEndDateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.EndDateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.EndDate field.
	''' </summary>
	Public Sub SetEndDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EndDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.EndDate field.
	''' </summary>
	Public Sub SetEndDateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EndDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignHistory_.EndDate field.
	''' </summary>
	Public Sub SetEndDateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EndDateColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignHistory_.HistoryID field.
	''' </summary>
	Public Property HistoryID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HistoryIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HistoryIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HistoryIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HistoryIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HistoryIDDefault() As String
        Get
            Return TableUtils.HistoryIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignHistory_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SignHistory_.HistoryHTML field.
	''' </summary>
	Public Property HistoryHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.HistoryHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.HistoryHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HistoryHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HistoryHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HistoryHTMLDefault() As String
        Get
            Return TableUtils.HistoryHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignHistory_.ExpGeneral field.
	''' </summary>
	Public Property ExpGeneral() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ExpGeneralColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ExpGeneralColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExpGeneralSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExpGeneralColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExpGeneralDefault() As String
        Get
            Return TableUtils.ExpGeneralColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignHistory_.ExpEquipment field.
	''' </summary>
	Public Property ExpEquipment() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ExpEquipmentColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ExpEquipmentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExpEquipmentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExpEquipmentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExpEquipmentDefault() As String
        Get
            Return TableUtils.ExpEquipmentColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignHistory_.ExpCargo field.
	''' </summary>
	Public Property ExpCargo() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ExpCargoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ExpCargoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExpCargoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExpCargoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExpCargoDefault() As String
        Get
            Return TableUtils.ExpCargoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignHistory_.ExpRegions field.
	''' </summary>
	Public Property ExpRegions() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ExpRegionsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ExpRegionsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExpRegionsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExpRegionsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExpRegionsDefault() As String
        Get
            Return TableUtils.ExpRegionsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignHistory_.FirstSort field.
	''' </summary>
	Public Property FirstSort() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FirstSortColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FirstSortColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FirstSortSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FirstSortColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FirstSortDefault() As String
        Get
            Return TableUtils.FirstSortColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignHistory_.StartDate field.
	''' </summary>
	Public Property StartDate() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.StartDateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.StartDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property StartDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.StartDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property StartDateDefault() As String
        Get
            Return TableUtils.StartDateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignHistory_.EndDate field.
	''' </summary>
	Public Property EndDate() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.EndDateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EndDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EndDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EndDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EndDateDefault() As String
        Get
            Return TableUtils.EndDateColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
