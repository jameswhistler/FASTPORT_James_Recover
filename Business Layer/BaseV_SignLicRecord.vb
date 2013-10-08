' This class is "generated" and will be overwritten.
' Your customizations should be made in V_SignLicRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_SignLicRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_SignLicView"></see> class.
''' </remarks>
''' <seealso cref="V_SignLicView"></seealso>
''' <seealso cref="V_SignLicRecord"></seealso>

<Serializable()> Public Class BaseV_SignLicRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_SignLicView = V_SignLicView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_SignLicRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_SignLicRec As V_SignLicRecord = CType(sender,V_SignLicRecord)
        If Not V_SignLicRec Is Nothing AndAlso Not V_SignLicRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_SignLicRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_SignLicRec As V_SignLicRecord = CType(sender,V_SignLicRecord)
        Validate_Inserting()
        If Not V_SignLicRec Is Nothing AndAlso Not V_SignLicRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocID field.
	''' </summary>
	Public Function GetDocIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocID field.
	''' </summary>
	Public Function GetDocIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DocIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocID field.
	''' </summary>
	Public Sub SetDocIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocID field.
	''' </summary>
	Public Sub SetDocIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocID field.
	''' </summary>
	Public Sub SetDocIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocID field.
	''' </summary>
	Public Sub SetDocIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocID field.
	''' </summary>
	Public Sub SetDocIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.FiledAsID field.
	''' </summary>
	Public Function GetFiledAsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FiledAsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.FiledAsID field.
	''' </summary>
	Public Function GetFiledAsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FiledAsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.FiledAsID field.
	''' </summary>
	Public Sub SetFiledAsIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FiledAsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.FiledAsID field.
	''' </summary>
	Public Sub SetFiledAsIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FiledAsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.FiledAsID field.
	''' </summary>
	Public Sub SetFiledAsIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FiledAsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.FiledAsID field.
	''' </summary>
	Public Sub SetFiledAsIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FiledAsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.FiledAsID field.
	''' </summary>
	Public Sub SetFiledAsIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FiledAsIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocInfo field.
	''' </summary>
	Public Function GetDocInfoValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocInfoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocInfo field.
	''' </summary>
	Public Function GetDocInfoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocInfoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocInfo field.
	''' </summary>
	Public Sub SetDocInfoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocInfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocInfo field.
	''' </summary>
	Public Sub SetDocInfoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocInfoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocShort field.
	''' </summary>
	Public Function GetDocShortValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocShortColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocShort field.
	''' </summary>
	Public Function GetDocShortFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocShortColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocShort field.
	''' </summary>
	Public Sub SetDocShortFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocShortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocShort field.
	''' </summary>
	Public Sub SetDocShortFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocShortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocNumber field.
	''' </summary>
	Public Function GetDocNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocNumber field.
	''' </summary>
	Public Function GetDocNumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocNumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocNumber field.
	''' </summary>
	Public Sub SetDocNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocNumber field.
	''' </summary>
	Public Sub SetDocNumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocIssued field.
	''' </summary>
	Public Function GetDocIssuedValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocIssuedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocIssued field.
	''' </summary>
	Public Function GetDocIssuedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DocIssuedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocIssued field.
	''' </summary>
	Public Sub SetDocIssuedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocIssuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocIssued field.
	''' </summary>
	Public Sub SetDocIssuedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocIssuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocIssued field.
	''' </summary>
	Public Sub SetDocIssuedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocIssuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocIssuingState field.
	''' </summary>
	Public Function GetDocIssuingStateValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocIssuingStateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocIssuingState field.
	''' </summary>
	Public Function GetDocIssuingStateFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocIssuingStateColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocIssuingState field.
	''' </summary>
	Public Sub SetDocIssuingStateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocIssuingStateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocIssuingState field.
	''' </summary>
	Public Sub SetDocIssuingStateFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocIssuingStateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocExpiration field.
	''' </summary>
	Public Function GetDocExpirationValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocExpirationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocExpiration field.
	''' </summary>
	Public Function GetDocExpirationFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DocExpirationColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocExpiration field.
	''' </summary>
	Public Sub SetDocExpirationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocExpirationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocExpiration field.
	''' </summary>
	Public Sub SetDocExpirationFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DocExpirationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocExpiration field.
	''' </summary>
	Public Sub SetDocExpirationFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocExpirationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.Reissued field.
	''' </summary>
	Public Function GetReissuedValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReissuedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.Reissued field.
	''' </summary>
	Public Function GetReissuedFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ReissuedColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.Reissued field.
	''' </summary>
	Public Sub SetReissuedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReissuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.Reissued field.
	''' </summary>
	Public Sub SetReissuedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ReissuedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.Reissued field.
	''' </summary>
	Public Sub SetReissuedFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReissuedColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocEndorsements field.
	''' </summary>
	Public Function GetDocEndorsementsValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocEndorsementsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocEndorsements field.
	''' </summary>
	Public Function GetDocEndorsementsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocEndorsementsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocEndorsements field.
	''' </summary>
	Public Sub SetDocEndorsementsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocEndorsementsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocEndorsements field.
	''' </summary>
	Public Sub SetDocEndorsementsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocEndorsementsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocNotes field.
	''' </summary>
	Public Function GetDocNotesValue() As ColumnValue
		Return Me.GetValue(TableUtils.DocNotesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SignLic_.DocNotes field.
	''' </summary>
	Public Function GetDocNotesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DocNotesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocNotes field.
	''' </summary>
	Public Sub SetDocNotesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DocNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SignLic_.DocNotes field.
	''' </summary>
	Public Sub SetDocNotesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DocNotesColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignLic_.DocID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SignLic_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SignLic_.FiledAsID field.
	''' </summary>
	Public Property FiledAsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FiledAsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FiledAsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FiledAsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FiledAsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FiledAsIDDefault() As String
        Get
            Return TableUtils.FiledAsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignLic_.DocInfo field.
	''' </summary>
	Public Property DocInfo() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DocInfoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DocInfoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocInfoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocInfoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocInfoDefault() As String
        Get
            Return TableUtils.DocInfoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignLic_.DocShort field.
	''' </summary>
	Public Property DocShort() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DocShortColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DocShortColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocShortSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocShortColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocShortDefault() As String
        Get
            Return TableUtils.DocShortColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignLic_.DocNumber field.
	''' </summary>
	Public Property DocNumber() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DocNumberColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DocNumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocNumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocNumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocNumberDefault() As String
        Get
            Return TableUtils.DocNumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignLic_.DocIssued field.
	''' </summary>
	Public Property DocIssued() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.DocIssuedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocIssuedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocIssuedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocIssuedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocIssuedDefault() As String
        Get
            Return TableUtils.DocIssuedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignLic_.DocIssuingState field.
	''' </summary>
	Public Property DocIssuingState() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DocIssuingStateColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DocIssuingStateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocIssuingStateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocIssuingStateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocIssuingStateDefault() As String
        Get
            Return TableUtils.DocIssuingStateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignLic_.DocExpiration field.
	''' </summary>
	Public Property DocExpiration() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.DocExpirationColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DocExpirationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocExpirationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocExpirationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocExpirationDefault() As String
        Get
            Return TableUtils.DocExpirationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignLic_.Reissued field.
	''' </summary>
	Public Property Reissued() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ReissuedColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ReissuedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReissuedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReissuedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReissuedDefault() As String
        Get
            Return TableUtils.ReissuedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignLic_.DocEndorsements field.
	''' </summary>
	Public Property DocEndorsements() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DocEndorsementsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DocEndorsementsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocEndorsementsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocEndorsementsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocEndorsementsDefault() As String
        Get
            Return TableUtils.DocEndorsementsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SignLic_.DocNotes field.
	''' </summary>
	Public Property DocNotes() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DocNotesColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DocNotesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DocNotesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DocNotesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DocNotesDefault() As String
        Get
            Return TableUtils.DocNotesColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
