' This class is "generated" and will be overwritten.
' Your customizations should be made in EquipRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="EquipRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="EquipTable"></see> class.
''' </remarks>
''' <seealso cref="EquipTable"></seealso>
''' <seealso cref="EquipRecord"></seealso>

<Serializable()> Public Class BaseEquipRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As EquipTable = EquipTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub EquipRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim EquipRec As EquipRecord = CType(sender,EquipRecord)
        Validate_Inserting()
        If Not EquipRec Is Nothing AndAlso Not EquipRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub EquipRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim EquipRec As EquipRecord = CType(sender,EquipRecord)
        Validate_Updating()
        If Not EquipRec Is Nothing AndAlso Not EquipRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub EquipRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim EquipRec As EquipRecord = CType(sender,EquipRecord)
        If Not EquipRec Is Nothing AndAlso Not EquipRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Equip_.EquipID field.
	''' </summary>
	Public Function GetEquipIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EquipIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.EquipID field.
	''' </summary>
	Public Function GetEquipIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EquipIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.OwnerID field.
	''' </summary>
	Public Function GetOwnerIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.OwnerIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.OwnerID field.
	''' </summary>
	Public Function GetOwnerIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.OwnerIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.OwnerID field.
	''' </summary>
	Public Sub SetOwnerIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OwnerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.OwnerID field.
	''' </summary>
	Public Sub SetOwnerIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OwnerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.OwnerID field.
	''' </summary>
	Public Sub SetOwnerIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OwnerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.OwnerID field.
	''' </summary>
	Public Sub SetOwnerIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OwnerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.OwnerID field.
	''' </summary>
	Public Sub SetOwnerIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OwnerIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.YearID field.
	''' </summary>
	Public Function GetYearIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.YearIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.YearID field.
	''' </summary>
	Public Function GetYearIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.YearIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.YearID field.
	''' </summary>
	Public Sub SetYearIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.YearIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.YearID field.
	''' </summary>
	Public Sub SetYearIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.YearIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.YearID field.
	''' </summary>
	Public Sub SetYearIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.YearIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.YearID field.
	''' </summary>
	Public Sub SetYearIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.YearIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.YearID field.
	''' </summary>
	Public Sub SetYearIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.YearIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.Make field.
	''' </summary>
	Public Function GetMakeValue() As ColumnValue
		Return Me.GetValue(TableUtils.MakeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.Make field.
	''' </summary>
	Public Function GetMakeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MakeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.Make field.
	''' </summary>
	Public Sub SetMakeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MakeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.Make field.
	''' </summary>
	Public Sub SetMakeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MakeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.Model field.
	''' </summary>
	Public Function GetModelValue() As ColumnValue
		Return Me.GetValue(TableUtils.ModelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.Model field.
	''' </summary>
	Public Function GetModelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ModelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.Model field.
	''' </summary>
	Public Sub SetModelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ModelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.Model field.
	''' </summary>
	Public Sub SetModelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ModelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.Axels field.
	''' </summary>
	Public Function GetAxelsValue() As ColumnValue
		Return Me.GetValue(TableUtils.AxelsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.Axels field.
	''' </summary>
	Public Function GetAxelsFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AxelsColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.Axels field.
	''' </summary>
	Public Sub SetAxelsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AxelsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.Axels field.
	''' </summary>
	Public Sub SetAxelsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AxelsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.Axels field.
	''' </summary>
	Public Sub SetAxelsFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AxelsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.Axels field.
	''' </summary>
	Public Sub SetAxelsFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AxelsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.Axels field.
	''' </summary>
	Public Sub SetAxelsFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AxelsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.UnladenWeight field.
	''' </summary>
	Public Function GetUnladenWeightValue() As ColumnValue
		Return Me.GetValue(TableUtils.UnladenWeightColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.UnladenWeight field.
	''' </summary>
	Public Function GetUnladenWeightFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UnladenWeightColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.UnladenWeight field.
	''' </summary>
	Public Sub SetUnladenWeightFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UnladenWeightColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.UnladenWeight field.
	''' </summary>
	Public Sub SetUnladenWeightFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UnladenWeightColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.UnladenWeight field.
	''' </summary>
	Public Sub SetUnladenWeightFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UnladenWeightColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.UnladenWeight field.
	''' </summary>
	Public Sub SetUnladenWeightFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UnladenWeightColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.UnladenWeight field.
	''' </summary>
	Public Sub SetUnladenWeightFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UnladenWeightColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.HeightFeet field.
	''' </summary>
	Public Function GetHeightFeetValue() As ColumnValue
		Return Me.GetValue(TableUtils.HeightFeetColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.HeightFeet field.
	''' </summary>
	Public Function GetHeightFeetFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HeightFeetColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.HeightFeet field.
	''' </summary>
	Public Sub SetHeightFeetFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HeightFeetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.HeightFeet field.
	''' </summary>
	Public Sub SetHeightFeetFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HeightFeetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.HeightFeet field.
	''' </summary>
	Public Sub SetHeightFeetFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HeightFeetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.HeightFeet field.
	''' </summary>
	Public Sub SetHeightFeetFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HeightFeetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.HeightFeet field.
	''' </summary>
	Public Sub SetHeightFeetFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HeightFeetColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.HeightInches field.
	''' </summary>
	Public Function GetHeightInchesValue() As ColumnValue
		Return Me.GetValue(TableUtils.HeightInchesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.HeightInches field.
	''' </summary>
	Public Function GetHeightInchesFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HeightInchesColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.HeightInches field.
	''' </summary>
	Public Sub SetHeightInchesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HeightInchesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.HeightInches field.
	''' </summary>
	Public Sub SetHeightInchesFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HeightInchesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.HeightInches field.
	''' </summary>
	Public Sub SetHeightInchesFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HeightInchesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.HeightInches field.
	''' </summary>
	Public Sub SetHeightInchesFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HeightInchesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.HeightInches field.
	''' </summary>
	Public Sub SetHeightInchesFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HeightInchesColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.PurchasedDate field.
	''' </summary>
	Public Function GetPurchasedDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.PurchasedDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.PurchasedDate field.
	''' </summary>
	Public Function GetPurchasedDateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.PurchasedDateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.PurchasedDate field.
	''' </summary>
	Public Sub SetPurchasedDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PurchasedDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.PurchasedDate field.
	''' </summary>
	Public Sub SetPurchasedDateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PurchasedDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.PurchasedDate field.
	''' </summary>
	Public Sub SetPurchasedDateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PurchasedDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.PurchasedValue field.
	''' </summary>
	Public Function GetPurchasedValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.PurchasedValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Equip_.PurchasedValue field.
	''' </summary>
	Public Function GetPurchasedValueFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.PurchasedValueColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.PurchasedValue field.
	''' </summary>
	Public Sub SetPurchasedValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PurchasedValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.PurchasedValue field.
	''' </summary>
	Public Sub SetPurchasedValueFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PurchasedValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.PurchasedValue field.
	''' </summary>
	Public Sub SetPurchasedValueFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PurchasedValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.PurchasedValue field.
	''' </summary>
	Public Sub SetPurchasedValueFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PurchasedValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Equip_.PurchasedValue field.
	''' </summary>
	Public Sub SetPurchasedValueFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PurchasedValueColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Equip_.EquipID field.
	''' </summary>
	Public Property EquipID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EquipIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EquipIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EquipIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EquipIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EquipIDDefault() As String
        Get
            Return TableUtils.EquipIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Equip_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Equip_.OwnerID field.
	''' </summary>
	Public Property OwnerID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.OwnerIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OwnerIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OwnerIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OwnerIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OwnerIDDefault() As String
        Get
            Return TableUtils.OwnerIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Equip_.YearID field.
	''' </summary>
	Public Property YearID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.YearIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.YearIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property YearIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.YearIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property YearIDDefault() As String
        Get
            Return TableUtils.YearIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Equip_.Make field.
	''' </summary>
	Public Property Make() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MakeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MakeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MakeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MakeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MakeDefault() As String
        Get
            Return TableUtils.MakeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Equip_.Model field.
	''' </summary>
	Public Property Model() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ModelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ModelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ModelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ModelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ModelDefault() As String
        Get
            Return TableUtils.ModelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Equip_.Axels field.
	''' </summary>
	Public Property Axels() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AxelsColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AxelsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AxelsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AxelsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AxelsDefault() As String
        Get
            Return TableUtils.AxelsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Equip_.UnladenWeight field.
	''' </summary>
	Public Property UnladenWeight() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.UnladenWeightColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UnladenWeightColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UnladenWeightSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UnladenWeightColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UnladenWeightDefault() As String
        Get
            Return TableUtils.UnladenWeightColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Equip_.HeightFeet field.
	''' </summary>
	Public Property HeightFeet() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HeightFeetColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HeightFeetColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HeightFeetSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HeightFeetColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HeightFeetDefault() As String
        Get
            Return TableUtils.HeightFeetColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Equip_.HeightInches field.
	''' </summary>
	Public Property HeightInches() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HeightInchesColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HeightInchesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HeightInchesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HeightInchesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HeightInchesDefault() As String
        Get
            Return TableUtils.HeightInchesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Equip_.PurchasedDate field.
	''' </summary>
	Public Property PurchasedDate() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.PurchasedDateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PurchasedDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PurchasedDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PurchasedDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PurchasedDateDefault() As String
        Get
            Return TableUtils.PurchasedDateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Equip_.PurchasedValue field.
	''' </summary>
	Public Property PurchasedValue() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.PurchasedValueColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PurchasedValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PurchasedValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PurchasedValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PurchasedValueDefault() As String
        Get
            Return TableUtils.PurchasedValueColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
