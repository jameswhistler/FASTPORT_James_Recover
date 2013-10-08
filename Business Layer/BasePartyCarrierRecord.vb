' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyCarrierRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PartyCarrierRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="PartyCarrierTable"></see> class.
''' </remarks>
''' <seealso cref="PartyCarrierTable"></seealso>
''' <seealso cref="PartyCarrierRecord"></seealso>

<Serializable()> Public Class BasePartyCarrierRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As PartyCarrierTable = PartyCarrierTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub PartyCarrierRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim PartyCarrierRec As PartyCarrierRecord = CType(sender,PartyCarrierRecord)
        Validate_Inserting()
        If Not PartyCarrierRec Is Nothing AndAlso Not PartyCarrierRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub PartyCarrierRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim PartyCarrierRec As PartyCarrierRecord = CType(sender,PartyCarrierRecord)
        Validate_Updating()
        If Not PartyCarrierRec Is Nothing AndAlso Not PartyCarrierRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub PartyCarrierRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim PartyCarrierRec As PartyCarrierRecord = CType(sender,PartyCarrierRecord)
        If Not PartyCarrierRec Is Nothing AndAlso Not PartyCarrierRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.CarrierID field.
	''' </summary>
	Public Function GetCarrierIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.CarrierID field.
	''' </summary>
	Public Function GetCarrierIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CarrierIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.CarrierFullName field.
	''' </summary>
	Public Function GetCarrierFullNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierFullNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.CarrierFullName field.
	''' </summary>
	Public Function GetCarrierFullNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CarrierFullNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.CarrierFullName field.
	''' </summary>
	Public Sub SetCarrierFullNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CarrierFullNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.CarrierFullName field.
	''' </summary>
	Public Sub SetCarrierFullNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierFullNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.DOTNumber field.
	''' </summary>
	Public Function GetDOTNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.DOTNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.DOTNumber field.
	''' </summary>
	Public Function GetDOTNumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DOTNumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.DOTNumber field.
	''' </summary>
	Public Sub SetDOTNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DOTNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.DOTNumber field.
	''' </summary>
	Public Sub SetDOTNumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DOTNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.MCNumber field.
	''' </summary>
	Public Function GetMCNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.MCNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.MCNumber field.
	''' </summary>
	Public Function GetMCNumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MCNumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.MCNumber field.
	''' </summary>
	Public Sub SetMCNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MCNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.MCNumber field.
	''' </summary>
	Public Sub SetMCNumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MCNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.Drivers field.
	''' </summary>
	Public Function GetDriversValue() As ColumnValue
		Return Me.GetValue(TableUtils.DriversColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.Drivers field.
	''' </summary>
	Public Function GetDriversFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DriversColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.Drivers field.
	''' </summary>
	Public Sub SetDriversFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DriversColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.Drivers field.
	''' </summary>
	Public Sub SetDriversFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DriversColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.Drivers field.
	''' </summary>
	Public Sub SetDriversFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DriversColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.Drivers field.
	''' </summary>
	Public Sub SetDriversFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DriversColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.Drivers field.
	''' </summary>
	Public Sub SetDriversFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DriversColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.Certified field.
	''' </summary>
	Public Function GetCertifiedValue() As ColumnValue
		Return Me.GetValue(TableUtils.CertifiedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.Certified field.
	''' </summary>
	Public Function GetCertifiedFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.CertifiedColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.Certified field.
	''' </summary>
	Public Sub SetCertifiedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CertifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.Certified field.
	''' </summary>
	Public Sub SetCertifiedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CertifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.Certified field.
	''' </summary>
	Public Sub SetCertifiedFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CertifiedColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.PayCertified field.
	''' </summary>
	Public Function GetPayCertifiedValue() As ColumnValue
		Return Me.GetValue(TableUtils.PayCertifiedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyCarrier_.PayCertified field.
	''' </summary>
	Public Function GetPayCertifiedFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.PayCertifiedColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.PayCertified field.
	''' </summary>
	Public Sub SetPayCertifiedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PayCertifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.PayCertified field.
	''' </summary>
	Public Sub SetPayCertifiedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PayCertifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyCarrier_.PayCertified field.
	''' </summary>
	Public Sub SetPayCertifiedFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PayCertifiedColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyCarrier_.CarrierID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyCarrier_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyCarrier_.CarrierFullName field.
	''' </summary>
	Public Property CarrierFullName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CarrierFullNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CarrierFullNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CarrierFullNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CarrierFullNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CarrierFullNameDefault() As String
        Get
            Return TableUtils.CarrierFullNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyCarrier_.DOTNumber field.
	''' </summary>
	Public Property DOTNumber() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DOTNumberColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DOTNumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DOTNumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DOTNumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DOTNumberDefault() As String
        Get
            Return TableUtils.DOTNumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyCarrier_.MCNumber field.
	''' </summary>
	Public Property MCNumber() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MCNumberColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MCNumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MCNumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MCNumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MCNumberDefault() As String
        Get
            Return TableUtils.MCNumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyCarrier_.Drivers field.
	''' </summary>
	Public Property Drivers() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DriversColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DriversColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DriversSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DriversColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DriversDefault() As String
        Get
            Return TableUtils.DriversColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyCarrier_.Certified field.
	''' </summary>
	Public Property Certified() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.CertifiedColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CertifiedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CertifiedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CertifiedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CertifiedDefault() As String
        Get
            Return TableUtils.CertifiedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyCarrier_.PayCertified field.
	''' </summary>
	Public Property PayCertified() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.PayCertifiedColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PayCertifiedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PayCertifiedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PayCertifiedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PayCertifiedDefault() As String
        Get
            Return TableUtils.PayCertifiedColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
