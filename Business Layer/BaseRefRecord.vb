' This class is "generated" and will be overwritten.
' Your customizations should be made in RefRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="RefRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="RefTable"></see> class.
''' </remarks>
''' <seealso cref="RefTable"></seealso>
''' <seealso cref="RefRecord"></seealso>

<Serializable()> Public Class BaseRefRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As RefTable = RefTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub RefRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim RefRec As RefRecord = CType(sender,RefRecord)
        Validate_Inserting()
        If Not RefRec Is Nothing AndAlso Not RefRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub RefRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim RefRec As RefRecord = CType(sender,RefRecord)
        Validate_Updating()
        If Not RefRec Is Nothing AndAlso Not RefRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub RefRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim RefRec As RefRecord = CType(sender,RefRecord)
        If Not RefRec Is Nothing AndAlso Not RefRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Ref_.RefID field.
	''' </summary>
	Public Function GetRefIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RefIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.RefID field.
	''' </summary>
	Public Function GetRefIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RefIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.RefTypeID field.
	''' </summary>
	Public Function GetRefTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RefTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.RefTypeID field.
	''' </summary>
	Public Function GetRefTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RefTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.RefTypeID field.
	''' </summary>
	Public Sub SetRefTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RefTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.RefTypeID field.
	''' </summary>
	Public Sub SetRefTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RefTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.RefTypeID field.
	''' </summary>
	Public Sub SetRefTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RefTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.RefTypeID field.
	''' </summary>
	Public Sub SetRefTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RefTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.RefTypeID field.
	''' </summary>
	Public Sub SetRefTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RefTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.Ref field.
	''' </summary>
	Public Function GetRef0Value() As ColumnValue
		Return Me.GetValue(TableUtils.Ref0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.Ref field.
	''' </summary>
	Public Function GetRef0FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Ref0Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.Ref field.
	''' </summary>
	Public Sub SetRef0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Ref0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.Ref field.
	''' </summary>
	Public Sub SetRef0FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Ref0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.OrdID field.
	''' </summary>
	Public Function GetOrdIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.OrdIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.OrdID field.
	''' </summary>
	Public Function GetOrdIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.OrdIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.OrdID field.
	''' </summary>
	Public Sub SetOrdIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OrdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.OrdID field.
	''' </summary>
	Public Sub SetOrdIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OrdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.OrdID field.
	''' </summary>
	Public Sub SetOrdIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OrdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.OrdID field.
	''' </summary>
	Public Sub SetOrdIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OrdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.OrdID field.
	''' </summary>
	Public Sub SetOrdIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OrdIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.PartyUserID field.
	''' </summary>
	Public Function GetPartyUserIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyUserIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.PartyUserID field.
	''' </summary>
	Public Function GetPartyUserIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyUserIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.PartyUserID field.
	''' </summary>
	Public Sub SetPartyUserIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyUserIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.PartyUserID field.
	''' </summary>
	Public Sub SetPartyUserIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyUserIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.PartyUserID field.
	''' </summary>
	Public Sub SetPartyUserIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyUserIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.PartyUserID field.
	''' </summary>
	Public Sub SetPartyUserIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyUserIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.PartyUserID field.
	''' </summary>
	Public Sub SetPartyUserIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyUserIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.DocID field.
	''' </summary>
	Public Function GetDocIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.DocID field.
	''' </summary>
	Public Function GetDocIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DocIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.DocID field.
	''' </summary>
	Public Sub SetDocIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.DocID field.
	''' </summary>
	Public Sub SetDocIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.DocID field.
	''' </summary>
	Public Sub SetDocIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.DocID field.
	''' </summary>
	Public Sub SetDocIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.DocID field.
	''' </summary>
	Public Sub SetDocIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.IssuedAt field.
	''' </summary>
	Public Function GetIssuedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.IssuedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.IssuedAt field.
	''' </summary>
	Public Function GetIssuedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.IssuedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.IssuedAt field.
	''' </summary>
	Public Sub SetIssuedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IssuedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.IssuedAt field.
	''' </summary>
	Public Sub SetIssuedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IssuedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.IssuedAt field.
	''' </summary>
	Public Sub SetIssuedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IssuedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.ExpiresOn field.
	''' </summary>
	Public Function GetExpiresOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExpiresOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.ExpiresOn field.
	''' </summary>
	Public Function GetExpiresOnFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.ExpiresOnColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.ExpiresOn field.
	''' </summary>
	Public Sub SetExpiresOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExpiresOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.ExpiresOn field.
	''' </summary>
	Public Sub SetExpiresOnFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExpiresOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.ExpiresOn field.
	''' </summary>
	Public Sub SetExpiresOnFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExpiresOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Ref_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Ref_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Ref_.RefID field.
	''' </summary>
	Public Property RefID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RefIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RefIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RefIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RefIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RefIDDefault() As String
        Get
            Return TableUtils.RefIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Ref_.RefTypeID field.
	''' </summary>
	Public Property RefTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RefTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RefTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RefTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RefTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RefTypeIDDefault() As String
        Get
            Return TableUtils.RefTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Ref_.Ref field.
	''' </summary>
	Public Property Ref0() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Ref0Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Ref0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Ref0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Ref0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Ref0Default() As String
        Get
            Return TableUtils.Ref0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Ref_.OrdID field.
	''' </summary>
	Public Property OrdID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.OrdIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OrdIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OrdIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OrdIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OrdIDDefault() As String
        Get
            Return TableUtils.OrdIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Ref_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Ref_.PartyUserID field.
	''' </summary>
	Public Property PartyUserID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PartyUserIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PartyUserIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PartyUserIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PartyUserIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PartyUserIDDefault() As String
        Get
            Return TableUtils.PartyUserIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Ref_.DocID field.
	''' </summary>
	Public Property DocID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DocIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocIDDefault() As String
        Get
            Return TableUtils.DocIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Ref_.IssuedAt field.
	''' </summary>
	Public Property IssuedAt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.IssuedAtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IssuedAtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IssuedAtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IssuedAtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IssuedAtDefault() As String
        Get
            Return TableUtils.IssuedAtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Ref_.ExpiresOn field.
	''' </summary>
	Public Property ExpiresOn() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.ExpiresOnColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExpiresOnColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExpiresOnSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExpiresOnColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExpiresOnDefault() As String
        Get
            Return TableUtils.ExpiresOnColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Ref_.CreatedByID field.
	''' </summary>
	Public Property CreatedByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CreatedByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CreatedByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CreatedByIDDefault() As String
        Get
            Return TableUtils.CreatedByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Ref_.CreatedAt field.
	''' </summary>
	Public Property CreatedAt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CreatedAtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CreatedAtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CreatedAtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CreatedAtDefault() As String
        Get
            Return TableUtils.CreatedAtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Ref_.UpdatedByID field.
	''' </summary>
	Public Property UpdatedByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UpdatedByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UpdatedByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UpdatedByIDDefault() As String
        Get
            Return TableUtils.UpdatedByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Ref_.UpdatedAt field.
	''' </summary>
	Public Property UpdatedAt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UpdatedAtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UpdatedAtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UpdatedAtDefault() As String
        Get
            Return TableUtils.UpdatedAtColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
