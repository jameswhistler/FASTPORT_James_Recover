' This class is "generated" and will be overwritten.
' Your customizations should be made in V_PersonWithPicRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_PersonWithPicRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_PersonWithPicView"></see> class.
''' </remarks>
''' <seealso cref="V_PersonWithPicView"></seealso>
''' <seealso cref="V_PersonWithPicRecord"></seealso>

<Serializable()> Public Class BaseV_PersonWithPicRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_PersonWithPicView = V_PersonWithPicView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_PersonWithPicRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_PersonWithPicRec As V_PersonWithPicRecord = CType(sender,V_PersonWithPicRecord)
        Validate_Inserting()
        If Not V_PersonWithPicRec Is Nothing AndAlso Not V_PersonWithPicRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_PersonWithPicRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_PersonWithPicRec As V_PersonWithPicRecord = CType(sender,V_PersonWithPicRecord)
        Validate_Updating()
        If Not V_PersonWithPicRec Is Nothing AndAlso Not V_PersonWithPicRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_PersonWithPicRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_PersonWithPicRec As V_PersonWithPicRecord = CType(sender,V_PersonWithPicRecord)
        If Not V_PersonWithPicRec Is Nothing AndAlso Not V_PersonWithPicRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.Name field.
	''' </summary>
	Public Function GetNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.Name field.
	''' </summary>
	Public Function GetNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.Email field.
	''' </summary>
	Public Function GetEmailValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.Email field.
	''' </summary>
	Public Function GetEmailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.FromPic field.
	''' </summary>
	Public Function GetFromPicValue() As ColumnValue
		Return Me.GetValue(TableUtils.FromPicColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.FromPic field.
	''' </summary>
	Public Function GetFromPicFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.FromPicColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.FromPic field.
	''' </summary>
	Public Sub SetFromPicFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FromPicColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.FromPic field.
	''' </summary>
	Public Sub SetFromPicFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FromPicColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.FromPic field.
	''' </summary>
	Public Sub SetFromPicFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FromPicColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.NameHTML field.
	''' </summary>
	Public Function GetNameHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.NameHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.NameHTML field.
	''' </summary>
	Public Function GetNameHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NameHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.NameHTML field.
	''' </summary>
	Public Sub SetNameHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NameHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.NameHTML field.
	''' </summary>
	Public Sub SetNameHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NameHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.MoreHTML field.
	''' </summary>
	Public Function GetMoreHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.MoreHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.MoreHTML field.
	''' </summary>
	Public Function GetMoreHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MoreHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.MoreHTML field.
	''' </summary>
	Public Sub SetMoreHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MoreHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.MoreHTML field.
	''' </summary>
	Public Sub SetMoreHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MoreHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.Details field.
	''' </summary>
	Public Function GetDetailsValue() As ColumnValue
		Return Me.GetValue(TableUtils.DetailsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.Details field.
	''' </summary>
	Public Function GetDetailsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DetailsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.Details field.
	''' </summary>
	Public Sub SetDetailsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DetailsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.Details field.
	''' </summary>
	Public Sub SetDetailsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DetailsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.ProfileSnippet field.
	''' </summary>
	Public Function GetProfileSnippetValue() As ColumnValue
		Return Me.GetValue(TableUtils.ProfileSnippetColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.ProfileSnippet field.
	''' </summary>
	Public Function GetProfileSnippetFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ProfileSnippetColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.ProfileSnippet field.
	''' </summary>
	Public Sub SetProfileSnippetFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ProfileSnippetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.ProfileSnippet field.
	''' </summary>
	Public Sub SetProfileSnippetFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProfileSnippetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.FullProfile field.
	''' </summary>
	Public Function GetFullProfileValue() As ColumnValue
		Return Me.GetValue(TableUtils.FullProfileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.FullProfile field.
	''' </summary>
	Public Function GetFullProfileFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FullProfileColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.FullProfile field.
	''' </summary>
	Public Sub SetFullProfileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FullProfileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.FullProfile field.
	''' </summary>
	Public Sub SetFullProfileFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FullProfileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.BuddyCount field.
	''' </summary>
	Public Function GetBuddyCountValue() As ColumnValue
		Return Me.GetValue(TableUtils.BuddyCountColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.BuddyCount field.
	''' </summary>
	Public Function GetBuddyCountFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.BuddyCountColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.BuddyCount field.
	''' </summary>
	Public Sub SetBuddyCountFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.BuddyCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.BuddyCount field.
	''' </summary>
	Public Sub SetBuddyCountFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.BuddyCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.BuddyCount field.
	''' </summary>
	Public Sub SetBuddyCountFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BuddyCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.BuddyCount field.
	''' </summary>
	Public Sub SetBuddyCountFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BuddyCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.BuddyCount field.
	''' </summary>
	Public Sub SetBuddyCountFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BuddyCountColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.RegisteredUserSince field.
	''' </summary>
	Public Function GetRegisteredUserSinceValue() As ColumnValue
		Return Me.GetValue(TableUtils.RegisteredUserSinceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonWithPic_.RegisteredUserSince field.
	''' </summary>
	Public Function GetRegisteredUserSinceFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.RegisteredUserSinceColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.RegisteredUserSince field.
	''' </summary>
	Public Sub SetRegisteredUserSinceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RegisteredUserSinceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.RegisteredUserSince field.
	''' </summary>
	Public Sub SetRegisteredUserSinceFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RegisteredUserSinceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonWithPic_.RegisteredUserSince field.
	''' </summary>
	Public Sub SetRegisteredUserSinceFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RegisteredUserSinceColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PersonWithPic_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PersonWithPic_.Name field.
	''' </summary>
	Public Property Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NameDefault() As String
        Get
            Return TableUtils.NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PersonWithPic_.Email field.
	''' </summary>
	Public Property Email() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EmailColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EmailColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmailSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmailColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmailDefault() As String
        Get
            Return TableUtils.EmailColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PersonWithPic_.FromPic field.
	''' </summary>
	Public Property FromPic() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.FromPicColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FromPicColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FromPicSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FromPicColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FromPicDefault() As String
        Get
            Return TableUtils.FromPicColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PersonWithPic_.NameHTML field.
	''' </summary>
	Public Property NameHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.NameHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.NameHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NameHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NameHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NameHTMLDefault() As String
        Get
            Return TableUtils.NameHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PersonWithPic_.MoreHTML field.
	''' </summary>
	Public Property MoreHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MoreHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MoreHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MoreHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MoreHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MoreHTMLDefault() As String
        Get
            Return TableUtils.MoreHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PersonWithPic_.Details field.
	''' </summary>
	Public Property Details() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DetailsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DetailsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DetailsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DetailsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DetailsDefault() As String
        Get
            Return TableUtils.DetailsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PersonWithPic_.ProfileSnippet field.
	''' </summary>
	Public Property ProfileSnippet() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ProfileSnippetColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ProfileSnippetColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ProfileSnippetSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ProfileSnippetColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ProfileSnippetDefault() As String
        Get
            Return TableUtils.ProfileSnippetColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PersonWithPic_.FullProfile field.
	''' </summary>
	Public Property FullProfile() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FullProfileColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FullProfileColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FullProfileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FullProfileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FullProfileDefault() As String
        Get
            Return TableUtils.FullProfileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PersonWithPic_.BuddyCount field.
	''' </summary>
	Public Property BuddyCount() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.BuddyCountColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.BuddyCountColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property BuddyCountSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.BuddyCountColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property BuddyCountDefault() As String
        Get
            Return TableUtils.BuddyCountColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PersonWithPic_.RegisteredUserSince field.
	''' </summary>
	Public Property RegisteredUserSince() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.RegisteredUserSinceColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RegisteredUserSinceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RegisteredUserSinceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RegisteredUserSinceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RegisteredUserSinceDefault() As String
        Get
            Return TableUtils.RegisteredUserSinceColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
