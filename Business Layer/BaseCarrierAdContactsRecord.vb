' This class is "generated" and will be overwritten.
' Your customizations should be made in CarrierAdContactsRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="CarrierAdContactsRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="CarrierAdContactsTable"></see> class.
''' </remarks>
''' <seealso cref="CarrierAdContactsTable"></seealso>
''' <seealso cref="CarrierAdContactsRecord"></seealso>

<Serializable()> Public Class BaseCarrierAdContactsRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As CarrierAdContactsTable = CarrierAdContactsTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub CarrierAdContactsRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim CarrierAdContactsRec As CarrierAdContactsRecord = CType(sender,CarrierAdContactsRecord)
        Validate_Inserting()
        If Not CarrierAdContactsRec Is Nothing AndAlso Not CarrierAdContactsRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub CarrierAdContactsRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim CarrierAdContactsRec As CarrierAdContactsRecord = CType(sender,CarrierAdContactsRecord)
        Validate_Updating()
        If Not CarrierAdContactsRec Is Nothing AndAlso Not CarrierAdContactsRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub CarrierAdContactsRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim CarrierAdContactsRec As CarrierAdContactsRecord = CType(sender,CarrierAdContactsRecord)
        If Not CarrierAdContactsRec Is Nothing AndAlso Not CarrierAdContactsRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdContacts_.AdContactsID field.
	''' </summary>
	Public Function GetAdContactsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdContactsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdContacts_.AdContactsID field.
	''' </summary>
	Public Function GetAdContactsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdContactsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdContacts_.AdID field.
	''' </summary>
	Public Function GetAdIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdContacts_.AdID field.
	''' </summary>
	Public Function GetAdIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdContacts_.ContactTypeID field.
	''' </summary>
	Public Function GetContactTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ContactTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdContacts_.ContactTypeID field.
	''' </summary>
	Public Function GetContactTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ContactTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.ContactTypeID field.
	''' </summary>
	Public Sub SetContactTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ContactTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.ContactTypeID field.
	''' </summary>
	Public Sub SetContactTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ContactTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.ContactTypeID field.
	''' </summary>
	Public Sub SetContactTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ContactTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.ContactTypeID field.
	''' </summary>
	Public Sub SetContactTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ContactTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.ContactTypeID field.
	''' </summary>
	Public Sub SetContactTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ContactTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdContacts_.RoleID field.
	''' </summary>
	Public Function GetRoleIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RoleIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdContacts_.RoleID field.
	''' </summary>
	Public Function GetRoleIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RoleIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdContacts_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdContacts_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdContacts_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdContacts_.AdContactsID field.
	''' </summary>
	Public Property AdContactsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AdContactsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AdContactsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdContactsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdContactsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdContactsIDDefault() As String
        Get
            Return TableUtils.AdContactsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdContacts_.AdID field.
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
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdContacts_.ContactTypeID field.
	''' </summary>
	Public Property ContactTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ContactTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ContactTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ContactTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ContactTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ContactTypeIDDefault() As String
        Get
            Return TableUtils.ContactTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdContacts_.RoleID field.
	''' </summary>
	Public Property RoleID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RoleIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RoleIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RoleIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RoleIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RoleIDDefault() As String
        Get
            Return TableUtils.RoleIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdContacts_.PartyID field.
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



#End Region

End Class
End Namespace
