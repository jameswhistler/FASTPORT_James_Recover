' This class is "generated" and will be overwritten.
' Your customizations should be made in V_SecurityUserRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_SecurityUserRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_SecurityUserView"></see> class.
''' </remarks>
''' <seealso cref="V_SecurityUserView"></seealso>
''' <seealso cref="V_SecurityUserRecord"></seealso>

<Serializable()> Public Class BaseV_SecurityUserRecord
	Inherits PrimaryKeyRecord
	Implements IUserIdentityRecord


	Public Shared Shadows ReadOnly TableUtils As V_SecurityUserView = V_SecurityUserView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_SecurityUserRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_SecurityUserRec As V_SecurityUserRecord = CType(sender,V_SecurityUserRecord)
        Validate_Inserting()
        If Not V_SecurityUserRec Is Nothing AndAlso Not V_SecurityUserRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_SecurityUserRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_SecurityUserRec As V_SecurityUserRecord = CType(sender,V_SecurityUserRecord)
        Validate_Updating()
        If Not V_SecurityUserRec Is Nothing AndAlso Not V_SecurityUserRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_SecurityUserRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_SecurityUserRec As V_SecurityUserRecord = CType(sender,V_SecurityUserRecord)
        If Not V_SecurityUserRec Is Nothing AndAlso Not V_SecurityUserRec.IsReadOnly Then
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

#Region "IUserRecord Members"

	' Get the user's unique identifier
	Public Function GetUserId() As String Implements IUserRecord.GetUserId
		Return CType(Me, IRecord).GetString(CType(Me.TableAccess, IUserTable).UserIdColumn)
	End Function

#End Region


#Region "IUserIdentityRecord Members"

	' Get the user's name
	Public Function GetUserName() As String Implements IUserIdentityRecord.GetUserName
		Return CType(Me, IRecord).getString(CType(Me.TableAccess, IUserIdentityTable).UserNameColumn)
	End Function

	' Get the user's password
	Public Function GetUserPassword() As String Implements IUserIdentityRecord.GetUserPassword
		Return CType(Me, IRecord).getString(CType(Me.TableAccess, IUserIdentityTable).UserPasswordColumn)
	End Function

	' Get the user's email address
	Public Function GetUserEmail() As String Implements IUserIdentityRecord.GetUserEmail
		Return CType(Me, IRecord).getString(CType(Me.TableAccess, IUserIdentityTable).UserEmailColumn)
	End Function

	' Get a list of roles to which the user belongs
	Public Function GetUserRoles() As String() Implements IUserIdentityRecord.GetUserRoles
		Dim roles() As String
		If (TypeOf (Me) Is IUserRoleRecord) Then
			roles = New String(0) {}
			roles(0) = CType(Me, IUserRoleRecord).GetUserRole()
		Else
			Dim roleTable As IUserRoleTable = CType(Me.TableAccess, IUserIdentityTable).GetUserRoleTable()
			If (IsNothing(roleTable)) Then
				Return Nothing
#If False Then
			'Note: Not compiled for performance
			ElseIf (CType(roleTable, Object).Equals(Me.TableAccess)) Then
				'This should never occur because it should be handled above instead
#End If
			Else
				Dim filter As ColumnValueFilter = BaseFilter.CreateUserIdFilter(roleTable, Me.GetUserId())
				Dim order As New OrderBy(False, False)
				Dim join As BaseClasses.Data.BaseFilter = Nothing
				Dim roleRecords As ArrayList = roleTable.GetRecordList(join, filter, Nothing, order, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
				Dim roleRecord As IUserRoleRecord
				Dim roleList As New ArrayList(roleRecords.Count)
				For Each roleRecord In roleRecords
					roleList.Add(roleRecord.GetUserRole())
				Next
				roles = CType(roleList.ToArray(GetType(String)), String())
			End If
		End If
		Return roles
	End Function

#End Region




#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SecurityUser_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SecurityUser_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SecurityUser_.Name field.
	''' </summary>
	Public Function GetNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SecurityUser_.Name field.
	''' </summary>
	Public Function GetNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SecurityUser_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SecurityUser_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SecurityUser_.Email field.
	''' </summary>
	Public Function GetEmailValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SecurityUser_.Email field.
	''' </summary>
	Public Function GetEmailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SecurityUser_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SecurityUser_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SecurityUser_.Password field.
	''' </summary>
	Public Function GetPasswordValue() As ColumnValue
		Return Me.GetValue(TableUtils.PasswordColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SecurityUser_.Password field.
	''' </summary>
	Public Function GetPasswordFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PasswordColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SecurityUser_.Password field.
	''' </summary>
	Public Sub SetPasswordFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SecurityUser_.Password field.
	''' </summary>
	Public Sub SetPasswordFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SecurityUser_.RegisteredUserSince field.
	''' </summary>
	Public Function GetRegisteredUserSinceValue() As ColumnValue
		Return Me.GetValue(TableUtils.RegisteredUserSinceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_SecurityUser_.RegisteredUserSince field.
	''' </summary>
	Public Function GetRegisteredUserSinceFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.RegisteredUserSinceColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SecurityUser_.RegisteredUserSince field.
	''' </summary>
	Public Sub SetRegisteredUserSinceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RegisteredUserSinceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SecurityUser_.RegisteredUserSince field.
	''' </summary>
	Public Sub SetRegisteredUserSinceFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RegisteredUserSinceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_SecurityUser_.RegisteredUserSince field.
	''' </summary>
	Public Sub SetRegisteredUserSinceFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RegisteredUserSinceColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SecurityUser_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SecurityUser_.Name field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SecurityUser_.Email field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_SecurityUser_.Password field.
	''' </summary>
	Public Property Password() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PasswordColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PasswordColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PasswordSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PasswordColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PasswordDefault() As String
        Get
            Return TableUtils.PasswordColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_SecurityUser_.RegisteredUserSince field.
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
