' This class is "generated" and will be overwritten.
' Your customizations should be made in ThreadInstancePartiesRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="ThreadInstancePartiesRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="ThreadInstancePartiesTable"></see> class.
''' </remarks>
''' <seealso cref="ThreadInstancePartiesTable"></seealso>
''' <seealso cref="ThreadInstancePartiesRecord"></seealso>

<Serializable()> Public Class BaseThreadInstancePartiesRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As ThreadInstancePartiesTable = ThreadInstancePartiesTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub ThreadInstancePartiesRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim ThreadInstancePartiesRec As ThreadInstancePartiesRecord = CType(sender,ThreadInstancePartiesRecord)
        Validate_Inserting()
        If Not ThreadInstancePartiesRec Is Nothing AndAlso Not ThreadInstancePartiesRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub ThreadInstancePartiesRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim ThreadInstancePartiesRec As ThreadInstancePartiesRecord = CType(sender,ThreadInstancePartiesRecord)
        Validate_Updating()
        If Not ThreadInstancePartiesRec Is Nothing AndAlso Not ThreadInstancePartiesRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub ThreadInstancePartiesRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim ThreadInstancePartiesRec As ThreadInstancePartiesRecord = CType(sender,ThreadInstancePartiesRecord)
        If Not ThreadInstancePartiesRec Is Nothing AndAlso Not ThreadInstancePartiesRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.InstancePartyID field.
	''' </summary>
	Public Function GetInstancePartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.InstancePartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.InstancePartyID field.
	''' </summary>
	Public Function GetInstancePartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.InstancePartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.InstanceID field.
	''' </summary>
	Public Function GetInstanceIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.InstanceIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.InstanceID field.
	''' </summary>
	Public Function GetInstanceIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.InstanceIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.PartyTypeID field.
	''' </summary>
	Public Function GetPartyTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.PartyTypeID field.
	''' </summary>
	Public Function GetPartyTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.PartyTypeID field.
	''' </summary>
	Public Sub SetPartyTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.PartyTypeID field.
	''' </summary>
	Public Sub SetPartyTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.PartyTypeID field.
	''' </summary>
	Public Sub SetPartyTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.PartyTypeID field.
	''' </summary>
	Public Sub SetPartyTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.PartyTypeID field.
	''' </summary>
	Public Sub SetPartyTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.UserID field.
	''' </summary>
	Public Function GetUserId0Value() As ColumnValue
		Return Me.GetValue(TableUtils.UserId0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.UserID field.
	''' </summary>
	Public Function GetUserId0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UserId0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.UserID field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.UserID field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.UserID field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.UserID field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.UserID field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserId0Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.RoleID field.
	''' </summary>
	Public Function GetRoleIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RoleIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.RoleID field.
	''' </summary>
	Public Function GetRoleIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RoleIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.RoleID field.
	''' </summary>
	Public Sub SetRoleIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.FreeHand field.
	''' </summary>
	Public Function GetFreeHandValue() As ColumnValue
		Return Me.GetValue(TableUtils.FreeHandColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.FreeHand field.
	''' </summary>
	Public Function GetFreeHandFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FreeHandColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.FreeHand field.
	''' </summary>
	Public Sub SetFreeHandFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FreeHandColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.FreeHand field.
	''' </summary>
	Public Sub SetFreeHandFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FreeHandColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.ThreadPriorityID field.
	''' </summary>
	Public Function GetThreadPriorityIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThreadPriorityIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.ThreadPriorityID field.
	''' </summary>
	Public Function GetThreadPriorityIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ThreadPriorityIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.ThreadPriorityID field.
	''' </summary>
	Public Sub SetThreadPriorityIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThreadPriorityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.ThreadPriorityID field.
	''' </summary>
	Public Sub SetThreadPriorityIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThreadPriorityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.ThreadPriorityID field.
	''' </summary>
	Public Sub SetThreadPriorityIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadPriorityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.ThreadPriorityID field.
	''' </summary>
	Public Sub SetThreadPriorityIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadPriorityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.ThreadPriorityID field.
	''' </summary>
	Public Sub SetThreadPriorityIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadPriorityIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.Email field.
	''' </summary>
	Public Function GetEmailValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.Email field.
	''' </summary>
	Public Function GetEmailFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.EmailColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmailColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.MobileText field.
	''' </summary>
	Public Function GetMobileTextValue() As ColumnValue
		Return Me.GetValue(TableUtils.MobileTextColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.MobileText field.
	''' </summary>
	Public Function GetMobileTextFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.MobileTextColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.MobileText field.
	''' </summary>
	Public Sub SetMobileTextFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MobileTextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.MobileText field.
	''' </summary>
	Public Sub SetMobileTextFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MobileTextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.MobileText field.
	''' </summary>
	Public Sub SetMobileTextFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MobileTextColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.Fax field.
	''' </summary>
	Public Function GetFaxValue() As ColumnValue
		Return Me.GetValue(TableUtils.FaxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.Fax field.
	''' </summary>
	Public Function GetFaxFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FaxColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.Fax field.
	''' </summary>
	Public Sub SetFaxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.Fax field.
	''' </summary>
	Public Sub SetFaxFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.Fax field.
	''' </summary>
	Public Sub SetFaxFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FaxColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.InstantMessage field.
	''' </summary>
	Public Function GetInstantMessageValue() As ColumnValue
		Return Me.GetValue(TableUtils.InstantMessageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.InstantMessage field.
	''' </summary>
	Public Function GetInstantMessageFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.InstantMessageColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.InstantMessage field.
	''' </summary>
	Public Sub SetInstantMessageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.InstantMessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.InstantMessage field.
	''' </summary>
	Public Sub SetInstantMessageFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.InstantMessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.InstantMessage field.
	''' </summary>
	Public Sub SetInstantMessageFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstantMessageColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.BoardOnly field.
	''' </summary>
	Public Function GetBoardOnlyValue() As ColumnValue
		Return Me.GetValue(TableUtils.BoardOnlyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.BoardOnly field.
	''' </summary>
	Public Function GetBoardOnlyFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.BoardOnlyColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.BoardOnly field.
	''' </summary>
	Public Sub SetBoardOnlyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.BoardOnlyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.BoardOnly field.
	''' </summary>
	Public Sub SetBoardOnlyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.BoardOnlyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.BoardOnly field.
	''' </summary>
	Public Sub SetBoardOnlyFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BoardOnlyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.FileInstance field.
	''' </summary>
	Public Function GetFileInstanceValue() As ColumnValue
		Return Me.GetValue(TableUtils.FileInstanceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.FileInstance field.
	''' </summary>
	Public Function GetFileInstanceFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FileInstanceColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.FileInstance field.
	''' </summary>
	Public Sub SetFileInstanceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FileInstanceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.FileInstance field.
	''' </summary>
	Public Sub SetFileInstanceFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FileInstanceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.FileInstance field.
	''' </summary>
	Public Sub SetFileInstanceFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FileInstanceColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.OneTime field.
	''' </summary>
	Public Function GetOneTimeValue() As ColumnValue
		Return Me.GetValue(TableUtils.OneTimeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.OneTime field.
	''' </summary>
	Public Function GetOneTimeFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.OneTimeColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.OneTime field.
	''' </summary>
	Public Sub SetOneTimeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OneTimeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.OneTime field.
	''' </summary>
	Public Sub SetOneTimeFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OneTimeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.OneTime field.
	''' </summary>
	Public Sub SetOneTimeFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OneTimeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.OneTime field.
	''' </summary>
	Public Sub SetOneTimeFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OneTimeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.OneTime field.
	''' </summary>
	Public Sub SetOneTimeFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OneTimeColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ThreadInstanceParties_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ThreadInstanceParties_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.InstancePartyID field.
	''' </summary>
	Public Property InstancePartyID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.InstancePartyIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.InstancePartyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property InstancePartyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.InstancePartyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property InstancePartyIDDefault() As String
        Get
            Return TableUtils.InstancePartyIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.InstanceID field.
	''' </summary>
	Public Property InstanceID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.InstanceIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.InstanceIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property InstanceIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.InstanceIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property InstanceIDDefault() As String
        Get
            Return TableUtils.InstanceIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.PartyTypeID field.
	''' </summary>
	Public Property PartyTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PartyTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PartyTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PartyTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PartyTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PartyTypeIDDefault() As String
        Get
            Return TableUtils.PartyTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.UserID field.
	''' </summary>
	Public Property UserId0() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.UserId0Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UserId0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UserId0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UserId0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UserId0Default() As String
        Get
            Return TableUtils.UserId0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.RoleID field.
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
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.FreeHand field.
	''' </summary>
	Public Property FreeHand() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FreeHandColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FreeHandColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FreeHandSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FreeHandColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FreeHandDefault() As String
        Get
            Return TableUtils.FreeHandColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.ThreadPriorityID field.
	''' </summary>
	Public Property ThreadPriorityID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ThreadPriorityIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThreadPriorityIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThreadPriorityIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThreadPriorityIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThreadPriorityIDDefault() As String
        Get
            Return TableUtils.ThreadPriorityIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.Email field.
	''' </summary>
	Public Property Email() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.EmailColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EmailColumn)
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
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.MobileText field.
	''' </summary>
	Public Property MobileText() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.MobileTextColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MobileTextColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MobileTextSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MobileTextColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MobileTextDefault() As String
        Get
            Return TableUtils.MobileTextColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.Fax field.
	''' </summary>
	Public Property Fax() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FaxColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FaxColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FaxSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FaxColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FaxDefault() As String
        Get
            Return TableUtils.FaxColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.InstantMessage field.
	''' </summary>
	Public Property InstantMessage() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.InstantMessageColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.InstantMessageColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property InstantMessageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.InstantMessageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property InstantMessageDefault() As String
        Get
            Return TableUtils.InstantMessageColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.BoardOnly field.
	''' </summary>
	Public Property BoardOnly() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.BoardOnlyColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.BoardOnlyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property BoardOnlySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.BoardOnlyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property BoardOnlyDefault() As String
        Get
            Return TableUtils.BoardOnlyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.FileInstance field.
	''' </summary>
	Public Property FileInstance() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FileInstanceColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FileInstanceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FileInstanceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FileInstanceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FileInstanceDefault() As String
        Get
            Return TableUtils.FileInstanceColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.OneTime field.
	''' </summary>
	Public Property OneTime() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.OneTimeColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OneTimeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OneTimeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OneTimeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OneTimeDefault() As String
        Get
            Return TableUtils.OneTimeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's ThreadInstanceParties_.UpdatedAt field.
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
