' This class is "generated" and will be overwritten.
' Your customizations should be made in V_SignEquipRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_SignEquipRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_SignEquipView"></see> class.
''' </remarks>
''' <seealso cref="V_SignEquipView"></seealso>
''' <seealso cref="V_SignEquipRecord"></seealso>

<Serializable()> Public Class BaseV_SignEquipRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_SignEquipView = V_SignEquipView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_SignEquipRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_SignEquipRec As V_SignEquipRecord = CType(sender,V_SignEquipRecord)
        Validate_Inserting()
        If Not V_SignEquipRec Is Nothing AndAlso Not V_SignEquipRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_SignEquipRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_SignEquipRec As V_SignEquipRecord = CType(sender,V_SignEquipRecord)
        Validate_Updating()
        If Not V_SignEquipRec Is Nothing AndAlso Not V_SignEquipRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_SignEquipRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_SignEquipRec As V_SignEquipRecord = CType(sender,V_SignEquipRecord)
        If Not V_SignEquipRec Is Nothing AndAlso Not V_SignEquipRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.EquipID field.
	''' </summary>
	Public Function GetEquipIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EquipIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.EquipID field.
	''' </summary>
	Public Function GetEquipIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EquipIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.EquipID field.
	''' </summary>
	Public Sub SetEquipIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EquipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.EquipID field.
	''' </summary>
	Public Sub SetEquipIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EquipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.EquipID field.
	''' </summary>
	Public Sub SetEquipIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EquipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.EquipID field.
	''' </summary>
	Public Sub SetEquipIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EquipIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.EquipID field.
	''' </summary>
	Public Sub SetEquipIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EquipIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.OwnerID field.
	''' </summary>
	Public Function GetOwnerIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.OwnerIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.OwnerID field.
	''' </summary>
	Public Function GetOwnerIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.OwnerIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.OwnerID field.
	''' </summary>
	Public Sub SetOwnerIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OwnerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.OwnerID field.
	''' </summary>
	Public Sub SetOwnerIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OwnerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.OwnerID field.
	''' </summary>
	Public Sub SetOwnerIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OwnerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.OwnerID field.
	''' </summary>
	Public Sub SetOwnerIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OwnerIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.OwnerID field.
	''' </summary>
	Public Sub SetOwnerIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OwnerIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.O_Name field.
	''' </summary>
	Public Function GetO_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.O_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.O_Name field.
	''' </summary>
	Public Function GetO_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.O_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.O_Name field.
	''' </summary>
	Public Sub SetO_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.O_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.O_Name field.
	''' </summary>
	Public Sub SetO_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.O_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Info field.
	''' </summary>
	Public Function GetV_InfoValue() As ColumnValue
		Return Me.GetValue(TableUtils.V_InfoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Info field.
	''' </summary>
	Public Function GetV_InfoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.V_InfoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Info field.
	''' </summary>
	Public Sub SetV_InfoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.V_InfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Info field.
	''' </summary>
	Public Sub SetV_InfoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.V_InfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Registration field.
	''' </summary>
	Public Function GetV_RegistrationValue() As ColumnValue
		Return Me.GetValue(TableUtils.V_RegistrationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Registration field.
	''' </summary>
	Public Function GetV_RegistrationFieldValue() As String
		Return CType(Me.GetValue(TableUtils.V_RegistrationColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Registration field.
	''' </summary>
	Public Sub SetV_RegistrationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.V_RegistrationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Registration field.
	''' </summary>
	Public Sub SetV_RegistrationFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.V_RegistrationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Specs field.
	''' </summary>
	Public Function GetV_SpecsValue() As ColumnValue
		Return Me.GetValue(TableUtils.V_SpecsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Specs field.
	''' </summary>
	Public Function GetV_SpecsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.V_SpecsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Specs field.
	''' </summary>
	Public Sub SetV_SpecsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.V_SpecsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Specs field.
	''' </summary>
	Public Sub SetV_SpecsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.V_SpecsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_PurchaseInfo field.
	''' </summary>
	Public Function GetV_PurchaseInfoValue() As ColumnValue
		Return Me.GetValue(TableUtils.V_PurchaseInfoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_PurchaseInfo field.
	''' </summary>
	Public Function GetV_PurchaseInfoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.V_PurchaseInfoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_PurchaseInfo field.
	''' </summary>
	Public Sub SetV_PurchaseInfoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.V_PurchaseInfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_PurchaseInfo field.
	''' </summary>
	Public Sub SetV_PurchaseInfoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.V_PurchaseInfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Year field.
	''' </summary>
	Public Function GetV_YearValue() As ColumnValue
		Return Me.GetValue(TableUtils.V_YearColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Year field.
	''' </summary>
	Public Function GetV_YearFieldValue() As String
		Return CType(Me.GetValue(TableUtils.V_YearColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Year field.
	''' </summary>
	Public Sub SetV_YearFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.V_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Year field.
	''' </summary>
	Public Sub SetV_YearFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.V_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Make field.
	''' </summary>
	Public Function GetV_MakeValue() As ColumnValue
		Return Me.GetValue(TableUtils.V_MakeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Make field.
	''' </summary>
	Public Function GetV_MakeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.V_MakeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Make field.
	''' </summary>
	Public Sub SetV_MakeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.V_MakeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Make field.
	''' </summary>
	Public Sub SetV_MakeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.V_MakeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Model field.
	''' </summary>
	Public Function GetV_ModelValue() As ColumnValue
		Return Me.GetValue(TableUtils.V_ModelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Model field.
	''' </summary>
	Public Function GetV_ModelFieldValue() As String
		Return CType(Me.GetValue(TableUtils.V_ModelColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Model field.
	''' </summary>
	Public Sub SetV_ModelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.V_ModelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Model field.
	''' </summary>
	Public Sub SetV_ModelFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.V_ModelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Axels field.
	''' </summary>
	Public Function GetV_AxelsValue() As ColumnValue
		Return Me.GetValue(TableUtils.V_AxelsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Axels field.
	''' </summary>
	Public Function GetV_AxelsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.V_AxelsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Axels field.
	''' </summary>
	Public Sub SetV_AxelsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.V_AxelsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Axels field.
	''' </summary>
	Public Sub SetV_AxelsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.V_AxelsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_UnladenWeight field.
	''' </summary>
	Public Function GetV_UnladenWeightValue() As ColumnValue
		Return Me.GetValue(TableUtils.V_UnladenWeightColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_UnladenWeight field.
	''' </summary>
	Public Function GetV_UnladenWeightFieldValue() As String
		Return CType(Me.GetValue(TableUtils.V_UnladenWeightColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_UnladenWeight field.
	''' </summary>
	Public Sub SetV_UnladenWeightFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.V_UnladenWeightColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_UnladenWeight field.
	''' </summary>
	Public Sub SetV_UnladenWeightFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.V_UnladenWeightColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Height field.
	''' </summary>
	Public Function GetV_HeightValue() As ColumnValue
		Return Me.GetValue(TableUtils.V_HeightColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_Height field.
	''' </summary>
	Public Function GetV_HeightFieldValue() As String
		Return CType(Me.GetValue(TableUtils.V_HeightColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Height field.
	''' </summary>
	Public Sub SetV_HeightFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.V_HeightColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_Height field.
	''' </summary>
	Public Sub SetV_HeightFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.V_HeightColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_PurchasedDate field.
	''' </summary>
	Public Function GetV_PurchasedDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.V_PurchasedDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_PurchasedDate field.
	''' </summary>
	Public Function GetV_PurchasedDateFieldValue() As String
		Return CType(Me.GetValue(TableUtils.V_PurchasedDateColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_PurchasedDate field.
	''' </summary>
	Public Sub SetV_PurchasedDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.V_PurchasedDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_PurchasedDate field.
	''' </summary>
	Public Sub SetV_PurchasedDateFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.V_PurchasedDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_PurchasedValue field.
	''' </summary>
	Public Function GetV_PurchasedValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.V_PurchasedValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignEquip_.V_PurchasedValue field.
	''' </summary>
	Public Function GetV_PurchasedValueFieldValue() As String
		Return CType(Me.GetValue(TableUtils.V_PurchasedValueColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_PurchasedValue field.
	''' </summary>
	Public Sub SetV_PurchasedValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.V_PurchasedValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignEquip_.V_PurchasedValue field.
	''' </summary>
	Public Sub SetV_PurchasedValueFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.V_PurchasedValueColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.EquipID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.OwnerID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.O_Name field.
	''' </summary>
	Public Property O_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.O_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.O_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property O_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.O_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property O_NameDefault() As String
        Get
            Return TableUtils.O_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.V_Info field.
	''' </summary>
	Public Property V_Info() As String
		Get 
			Return CType(Me.GetValue(TableUtils.V_InfoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.V_InfoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property V_InfoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.V_InfoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property V_InfoDefault() As String
        Get
            Return TableUtils.V_InfoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.V_Registration field.
	''' </summary>
	Public Property V_Registration() As String
		Get 
			Return CType(Me.GetValue(TableUtils.V_RegistrationColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.V_RegistrationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property V_RegistrationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.V_RegistrationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property V_RegistrationDefault() As String
        Get
            Return TableUtils.V_RegistrationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.V_Specs field.
	''' </summary>
	Public Property V_Specs() As String
		Get 
			Return CType(Me.GetValue(TableUtils.V_SpecsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.V_SpecsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property V_SpecsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.V_SpecsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property V_SpecsDefault() As String
        Get
            Return TableUtils.V_SpecsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.V_PurchaseInfo field.
	''' </summary>
	Public Property V_PurchaseInfo() As String
		Get 
			Return CType(Me.GetValue(TableUtils.V_PurchaseInfoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.V_PurchaseInfoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property V_PurchaseInfoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.V_PurchaseInfoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property V_PurchaseInfoDefault() As String
        Get
            Return TableUtils.V_PurchaseInfoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.V_Year field.
	''' </summary>
	Public Property V_Year() As String
		Get 
			Return CType(Me.GetValue(TableUtils.V_YearColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.V_YearColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property V_YearSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.V_YearColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property V_YearDefault() As String
        Get
            Return TableUtils.V_YearColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.V_Make field.
	''' </summary>
	Public Property V_Make() As String
		Get 
			Return CType(Me.GetValue(TableUtils.V_MakeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.V_MakeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property V_MakeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.V_MakeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property V_MakeDefault() As String
        Get
            Return TableUtils.V_MakeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.V_Model field.
	''' </summary>
	Public Property V_Model() As String
		Get 
			Return CType(Me.GetValue(TableUtils.V_ModelColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.V_ModelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property V_ModelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.V_ModelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property V_ModelDefault() As String
        Get
            Return TableUtils.V_ModelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.V_Axels field.
	''' </summary>
	Public Property V_Axels() As String
		Get 
			Return CType(Me.GetValue(TableUtils.V_AxelsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.V_AxelsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property V_AxelsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.V_AxelsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property V_AxelsDefault() As String
        Get
            Return TableUtils.V_AxelsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.V_UnladenWeight field.
	''' </summary>
	Public Property V_UnladenWeight() As String
		Get 
			Return CType(Me.GetValue(TableUtils.V_UnladenWeightColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.V_UnladenWeightColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property V_UnladenWeightSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.V_UnladenWeightColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property V_UnladenWeightDefault() As String
        Get
            Return TableUtils.V_UnladenWeightColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.V_Height field.
	''' </summary>
	Public Property V_Height() As String
		Get 
			Return CType(Me.GetValue(TableUtils.V_HeightColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.V_HeightColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property V_HeightSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.V_HeightColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property V_HeightDefault() As String
        Get
            Return TableUtils.V_HeightColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.V_PurchasedDate field.
	''' </summary>
	Public Property V_PurchasedDate() As String
		Get 
			Return CType(Me.GetValue(TableUtils.V_PurchasedDateColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.V_PurchasedDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property V_PurchasedDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.V_PurchasedDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property V_PurchasedDateDefault() As String
        Get
            Return TableUtils.V_PurchasedDateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignEquip_.V_PurchasedValue field.
	''' </summary>
	Public Property V_PurchasedValue() As String
		Get 
			Return CType(Me.GetValue(TableUtils.V_PurchasedValueColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.V_PurchasedValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property V_PurchasedValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.V_PurchasedValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property V_PurchasedValueDefault() As String
        Get
            Return TableUtils.V_PurchasedValueColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
