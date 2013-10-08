' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PartyRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="PartyTable"></see> class.
''' </remarks>
''' <seealso cref="PartyTable"></seealso>
''' <seealso cref="PartyRecord"></seealso>

<Serializable()> Public Class BasePartyRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As PartyTable = PartyTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub PartyRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim PartyRec As PartyRecord = CType(sender,PartyRecord)
        Validate_Inserting()
        If Not PartyRec Is Nothing AndAlso Not PartyRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub PartyRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim PartyRec As PartyRecord = CType(sender,PartyRecord)
        Validate_Updating()
        If Not PartyRec Is Nothing AndAlso Not PartyRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub PartyRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim PartyRec As PartyRecord = CType(sender,PartyRecord)
        If Not PartyRec Is Nothing AndAlso Not PartyRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Party_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.PartyTypeID field.
	''' </summary>
	Public Function GetPartyTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.PartyTypeID field.
	''' </summary>
	Public Function GetPartyTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.PartyTypeID field.
	''' </summary>
	Public Sub SetPartyTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.PartyTypeID field.
	''' </summary>
	Public Sub SetPartyTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.PartyTypeID field.
	''' </summary>
	Public Sub SetPartyTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.PartyTypeID field.
	''' </summary>
	Public Sub SetPartyTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.PartyTypeID field.
	''' </summary>
	Public Sub SetPartyTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Logo field.
	''' </summary>
	Public Function GetLogoValue() As ColumnValue
		Return Me.GetValue(TableUtils.LogoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Logo field.
	''' </summary>
	Public Function GetLogoFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.LogoColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Logo field.
	''' </summary>
	Public Sub SetLogoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LogoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Logo field.
	''' </summary>
	Public Sub SetLogoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LogoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Logo field.
	''' </summary>
	Public Sub SetLogoFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LogoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ProfilePicture field.
	''' </summary>
	Public Function GetProfilePictureValue() As ColumnValue
		Return Me.GetValue(TableUtils.ProfilePictureColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ProfilePicture field.
	''' </summary>
	Public Function GetProfilePictureFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.ProfilePictureColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ProfilePicture field.
	''' </summary>
	Public Sub SetProfilePictureFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ProfilePictureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ProfilePicture field.
	''' </summary>
	Public Sub SetProfilePictureFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ProfilePictureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ProfilePicture field.
	''' </summary>
	Public Sub SetProfilePictureFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProfilePictureColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Name field.
	''' </summary>
	Public Function GetNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Name field.
	''' </summary>
	Public Function GetNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.DBA field.
	''' </summary>
	Public Function GetDBAValue() As ColumnValue
		Return Me.GetValue(TableUtils.DBAColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.DBA field.
	''' </summary>
	Public Function GetDBAFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DBAColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.DBA field.
	''' </summary>
	Public Sub SetDBAFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DBAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.DBA field.
	''' </summary>
	Public Sub SetDBAFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DBAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Title field.
	''' </summary>
	Public Function GetTitleValue() As ColumnValue
		Return Me.GetValue(TableUtils.TitleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Title field.
	''' </summary>
	Public Function GetTitleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TitleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Title field.
	''' </summary>
	Public Sub SetTitleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Title field.
	''' </summary>
	Public Sub SetTitleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Handle field.
	''' </summary>
	Public Function GetHandleValue() As ColumnValue
		Return Me.GetValue(TableUtils.HandleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Handle field.
	''' </summary>
	Public Function GetHandleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.HandleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Handle field.
	''' </summary>
	Public Sub SetHandleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HandleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Handle field.
	''' </summary>
	Public Sub SetHandleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HandleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Email field.
	''' </summary>
	Public Function GetEmailValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Email field.
	''' </summary>
	Public Function GetEmailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EmailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Email field.
	''' </summary>
	Public Sub SetEmailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Password field.
	''' </summary>
	Public Function GetPasswordValue() As ColumnValue
		Return Me.GetValue(TableUtils.PasswordColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Password field.
	''' </summary>
	Public Function GetPasswordFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PasswordColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Password field.
	''' </summary>
	Public Sub SetPasswordFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Password field.
	''' </summary>
	Public Sub SetPasswordFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Contact field.
	''' </summary>
	Public Function GetContactValue() As ColumnValue
		Return Me.GetValue(TableUtils.ContactColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Contact field.
	''' </summary>
	Public Function GetContactFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ContactColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Contact field.
	''' </summary>
	Public Sub SetContactFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ContactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Contact field.
	''' </summary>
	Public Sub SetContactFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ContactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.DirectDial field.
	''' </summary>
	Public Function GetDirectDialValue() As ColumnValue
		Return Me.GetValue(TableUtils.DirectDialColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.DirectDial field.
	''' </summary>
	Public Function GetDirectDialFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DirectDialColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.DirectDial field.
	''' </summary>
	Public Sub SetDirectDialFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DirectDialColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.DirectDial field.
	''' </summary>
	Public Sub SetDirectDialFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DirectDialColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Mobile field.
	''' </summary>
	Public Function GetMobileValue() As ColumnValue
		Return Me.GetValue(TableUtils.MobileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Mobile field.
	''' </summary>
	Public Function GetMobileFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MobileColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Mobile field.
	''' </summary>
	Public Sub SetMobileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MobileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Mobile field.
	''' </summary>
	Public Sub SetMobileFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MobileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Fax field.
	''' </summary>
	Public Function GetFaxValue() As ColumnValue
		Return Me.GetValue(TableUtils.FaxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.Fax field.
	''' </summary>
	Public Function GetFaxFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FaxColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Fax field.
	''' </summary>
	Public Sub SetFaxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.Fax field.
	''' </summary>
	Public Sub SetFaxFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.OtherPhone field.
	''' </summary>
	Public Function GetOtherPhoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.OtherPhoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.OtherPhone field.
	''' </summary>
	Public Function GetOtherPhoneFieldValue() As String
		Return CType(Me.GetValue(TableUtils.OtherPhoneColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.OtherPhone field.
	''' </summary>
	Public Sub SetOtherPhoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OtherPhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.OtherPhone field.
	''' </summary>
	Public Sub SetOtherPhoneFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OtherPhoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ShareWithFriends field.
	''' </summary>
	Public Function GetShareWithFriendsValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShareWithFriendsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ShareWithFriends field.
	''' </summary>
	Public Function GetShareWithFriendsFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ShareWithFriendsColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithFriends field.
	''' </summary>
	Public Sub SetShareWithFriendsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShareWithFriendsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithFriends field.
	''' </summary>
	Public Sub SetShareWithFriendsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ShareWithFriendsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithFriends field.
	''' </summary>
	Public Sub SetShareWithFriendsFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShareWithFriendsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ShareWithDrivers field.
	''' </summary>
	Public Function GetShareWithDriversValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShareWithDriversColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ShareWithDrivers field.
	''' </summary>
	Public Function GetShareWithDriversFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ShareWithDriversColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithDrivers field.
	''' </summary>
	Public Sub SetShareWithDriversFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShareWithDriversColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithDrivers field.
	''' </summary>
	Public Sub SetShareWithDriversFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ShareWithDriversColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithDrivers field.
	''' </summary>
	Public Sub SetShareWithDriversFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShareWithDriversColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ShareWithCarrier field.
	''' </summary>
	Public Function GetShareWithCarrierValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShareWithCarrierColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ShareWithCarrier field.
	''' </summary>
	Public Function GetShareWithCarrierFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ShareWithCarrierColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithCarrier field.
	''' </summary>
	Public Sub SetShareWithCarrierFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShareWithCarrierColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithCarrier field.
	''' </summary>
	Public Sub SetShareWithCarrierFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ShareWithCarrierColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithCarrier field.
	''' </summary>
	Public Sub SetShareWithCarrierFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShareWithCarrierColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ShareWithCloseBy field.
	''' </summary>
	Public Function GetShareWithCloseByValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShareWithCloseByColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ShareWithCloseBy field.
	''' </summary>
	Public Function GetShareWithCloseByFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ShareWithCloseByColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithCloseBy field.
	''' </summary>
	Public Sub SetShareWithCloseByFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShareWithCloseByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithCloseBy field.
	''' </summary>
	Public Sub SetShareWithCloseByFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ShareWithCloseByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithCloseBy field.
	''' </summary>
	Public Sub SetShareWithCloseByFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShareWithCloseByColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ShareWithLikeMe field.
	''' </summary>
	Public Function GetShareWithLikeMeValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShareWithLikeMeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ShareWithLikeMe field.
	''' </summary>
	Public Function GetShareWithLikeMeFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ShareWithLikeMeColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithLikeMe field.
	''' </summary>
	Public Sub SetShareWithLikeMeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShareWithLikeMeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithLikeMe field.
	''' </summary>
	Public Sub SetShareWithLikeMeFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ShareWithLikeMeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ShareWithLikeMe field.
	''' </summary>
	Public Sub SetShareWithLikeMeFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShareWithLikeMeColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.AllowInvitations field.
	''' </summary>
	Public Function GetAllowInvitationsValue() As ColumnValue
		Return Me.GetValue(TableUtils.AllowInvitationsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.AllowInvitations field.
	''' </summary>
	Public Function GetAllowInvitationsFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.AllowInvitationsColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.AllowInvitations field.
	''' </summary>
	Public Sub SetAllowInvitationsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AllowInvitationsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.AllowInvitations field.
	''' </summary>
	Public Sub SetAllowInvitationsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AllowInvitationsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.AllowInvitations field.
	''' </summary>
	Public Sub SetAllowInvitationsFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AllowInvitationsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ThreadEmail field.
	''' </summary>
	Public Function GetThreadEmailValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThreadEmailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ThreadEmail field.
	''' </summary>
	Public Function GetThreadEmailFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThreadEmailColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadEmail field.
	''' </summary>
	Public Sub SetThreadEmailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThreadEmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadEmail field.
	''' </summary>
	Public Sub SetThreadEmailFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThreadEmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadEmail field.
	''' </summary>
	Public Sub SetThreadEmailFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadEmailColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ThreadMobileText field.
	''' </summary>
	Public Function GetThreadMobileTextValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThreadMobileTextColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ThreadMobileText field.
	''' </summary>
	Public Function GetThreadMobileTextFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThreadMobileTextColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadMobileText field.
	''' </summary>
	Public Sub SetThreadMobileTextFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThreadMobileTextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadMobileText field.
	''' </summary>
	Public Sub SetThreadMobileTextFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThreadMobileTextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadMobileText field.
	''' </summary>
	Public Sub SetThreadMobileTextFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadMobileTextColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ThreadFax field.
	''' </summary>
	Public Function GetThreadFaxValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThreadFaxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ThreadFax field.
	''' </summary>
	Public Function GetThreadFaxFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThreadFaxColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadFax field.
	''' </summary>
	Public Sub SetThreadFaxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThreadFaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadFax field.
	''' </summary>
	Public Sub SetThreadFaxFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThreadFaxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadFax field.
	''' </summary>
	Public Sub SetThreadFaxFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadFaxColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ThreadInstantMessage field.
	''' </summary>
	Public Function GetThreadInstantMessageValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThreadInstantMessageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ThreadInstantMessage field.
	''' </summary>
	Public Function GetThreadInstantMessageFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThreadInstantMessageColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadInstantMessage field.
	''' </summary>
	Public Sub SetThreadInstantMessageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThreadInstantMessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadInstantMessage field.
	''' </summary>
	Public Sub SetThreadInstantMessageFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThreadInstantMessageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadInstantMessage field.
	''' </summary>
	Public Sub SetThreadInstantMessageFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadInstantMessageColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ThreadBoardOnly field.
	''' </summary>
	Public Function GetThreadBoardOnlyValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThreadBoardOnlyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.ThreadBoardOnly field.
	''' </summary>
	Public Function GetThreadBoardOnlyFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThreadBoardOnlyColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadBoardOnly field.
	''' </summary>
	Public Sub SetThreadBoardOnlyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThreadBoardOnlyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadBoardOnly field.
	''' </summary>
	Public Sub SetThreadBoardOnlyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThreadBoardOnlyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.ThreadBoardOnly field.
	''' </summary>
	Public Sub SetThreadBoardOnlyFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadBoardOnlyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.FullProfile field.
	''' </summary>
	Public Function GetFullProfileValue() As ColumnValue
		Return Me.GetValue(TableUtils.FullProfileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.FullProfile field.
	''' </summary>
	Public Function GetFullProfileFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FullProfileColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FullProfile field.
	''' </summary>
	Public Sub SetFullProfileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FullProfileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FullProfile field.
	''' </summary>
	Public Sub SetFullProfileFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FullProfileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.SignatureFile field.
	''' </summary>
	Public Function GetSignatureFileValue() As ColumnValue
		Return Me.GetValue(TableUtils.SignatureFileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.SignatureFile field.
	''' </summary>
	Public Function GetSignatureFileFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.SignatureFileColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.SignatureFile field.
	''' </summary>
	Public Sub SetSignatureFileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SignatureFileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.SignatureFile field.
	''' </summary>
	Public Sub SetSignatureFileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SignatureFileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.SignatureFile field.
	''' </summary>
	Public Sub SetSignatureFileFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SignatureFileColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.InitialsFile field.
	''' </summary>
	Public Function GetInitialsFileValue() As ColumnValue
		Return Me.GetValue(TableUtils.InitialsFileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.InitialsFile field.
	''' </summary>
	Public Function GetInitialsFileFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.InitialsFileColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.InitialsFile field.
	''' </summary>
	Public Sub SetInitialsFileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.InitialsFileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.InitialsFile field.
	''' </summary>
	Public Sub SetInitialsFileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.InitialsFileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.InitialsFile field.
	''' </summary>
	Public Sub SetInitialsFileFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InitialsFileColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.EntityID field.
	''' </summary>
	Public Function GetEntityIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EntityIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.EntityID field.
	''' </summary>
	Public Function GetEntityIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EntityIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.EntityID field.
	''' </summary>
	Public Sub SetEntityIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EntityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.EntityID field.
	''' </summary>
	Public Sub SetEntityIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EntityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.EntityID field.
	''' </summary>
	Public Sub SetEntityIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EntityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.EntityID field.
	''' </summary>
	Public Sub SetEntityIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EntityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.EntityID field.
	''' </summary>
	Public Sub SetEntityIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EntityIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.SocialSecurityNumber field.
	''' </summary>
	Public Function GetSocialSecurityNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.SocialSecurityNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.SocialSecurityNumber field.
	''' </summary>
	Public Function GetSocialSecurityNumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SocialSecurityNumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.SocialSecurityNumber field.
	''' </summary>
	Public Sub SetSocialSecurityNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SocialSecurityNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.SocialSecurityNumber field.
	''' </summary>
	Public Sub SetSocialSecurityNumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SocialSecurityNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.EINNumber field.
	''' </summary>
	Public Function GetEINNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.EINNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.EINNumber field.
	''' </summary>
	Public Function GetEINNumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.EINNumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.EINNumber field.
	''' </summary>
	Public Sub SetEINNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EINNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.EINNumber field.
	''' </summary>
	Public Sub SetEINNumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EINNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.SMTPPort field.
	''' </summary>
	Public Function GetSMTPPortValue() As ColumnValue
		Return Me.GetValue(TableUtils.SMTPPortColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.SMTPPort field.
	''' </summary>
	Public Function GetSMTPPortFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SMTPPortColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.SMTPPort field.
	''' </summary>
	Public Sub SetSMTPPortFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SMTPPortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.SMTPPort field.
	''' </summary>
	Public Sub SetSMTPPortFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SMTPPortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.SMTPPort field.
	''' </summary>
	Public Sub SetSMTPPortFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SMTPPortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.SMTPPort field.
	''' </summary>
	Public Sub SetSMTPPortFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SMTPPortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.SMTPPort field.
	''' </summary>
	Public Sub SetSMTPPortFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SMTPPortColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.SMTPServer field.
	''' </summary>
	Public Function GetSMTPServerValue() As ColumnValue
		Return Me.GetValue(TableUtils.SMTPServerColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.SMTPServer field.
	''' </summary>
	Public Function GetSMTPServerFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SMTPServerColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.SMTPServer field.
	''' </summary>
	Public Sub SetSMTPServerFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SMTPServerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.SMTPServer field.
	''' </summary>
	Public Sub SetSMTPServerFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SMTPServerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.SMTPPassword field.
	''' </summary>
	Public Function GetSMTPPasswordValue() As ColumnValue
		Return Me.GetValue(TableUtils.SMTPPasswordColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.SMTPPassword field.
	''' </summary>
	Public Function GetSMTPPasswordFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SMTPPasswordColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.SMTPPassword field.
	''' </summary>
	Public Sub SetSMTPPasswordFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SMTPPasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.SMTPPassword field.
	''' </summary>
	Public Sub SetSMTPPasswordFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SMTPPasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.EnableSSLYN field.
	''' </summary>
	Public Function GetEnableSSLYNValue() As ColumnValue
		Return Me.GetValue(TableUtils.EnableSSLYNColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.EnableSSLYN field.
	''' </summary>
	Public Function GetEnableSSLYNFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EnableSSLYNColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.EnableSSLYN field.
	''' </summary>
	Public Sub SetEnableSSLYNFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EnableSSLYNColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.EnableSSLYN field.
	''' </summary>
	Public Sub SetEnableSSLYNFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EnableSSLYNColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.EnableSSLYN field.
	''' </summary>
	Public Sub SetEnableSSLYNFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EnableSSLYNColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.EnableSSLYN field.
	''' </summary>
	Public Sub SetEnableSSLYNFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EnableSSLYNColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.EnableSSLYN field.
	''' </summary>
	Public Sub SetEnableSSLYNFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EnableSSLYNColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.FaxCredentials field.
	''' </summary>
	Public Function GetFaxCredentialsValue() As ColumnValue
		Return Me.GetValue(TableUtils.FaxCredentialsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.FaxCredentials field.
	''' </summary>
	Public Function GetFaxCredentialsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FaxCredentialsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxCredentials field.
	''' </summary>
	Public Sub SetFaxCredentialsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FaxCredentialsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxCredentials field.
	''' </summary>
	Public Sub SetFaxCredentialsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FaxCredentialsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.FaxAccount field.
	''' </summary>
	Public Function GetFaxAccountValue() As ColumnValue
		Return Me.GetValue(TableUtils.FaxAccountColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.FaxAccount field.
	''' </summary>
	Public Function GetFaxAccountFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FaxAccountColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxAccount field.
	''' </summary>
	Public Sub SetFaxAccountFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FaxAccountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxAccount field.
	''' </summary>
	Public Sub SetFaxAccountFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FaxAccountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.FaxPassword field.
	''' </summary>
	Public Function GetFaxPasswordValue() As ColumnValue
		Return Me.GetValue(TableUtils.FaxPasswordColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.FaxPassword field.
	''' </summary>
	Public Function GetFaxPasswordFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FaxPasswordColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxPassword field.
	''' </summary>
	Public Sub SetFaxPasswordFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FaxPasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxPassword field.
	''' </summary>
	Public Sub SetFaxPasswordFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FaxPasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.FaxSMTPPort field.
	''' </summary>
	Public Function GetFaxSMTPPortValue() As ColumnValue
		Return Me.GetValue(TableUtils.FaxSMTPPortColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.FaxSMTPPort field.
	''' </summary>
	Public Function GetFaxSMTPPortFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FaxSMTPPortColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxSMTPPort field.
	''' </summary>
	Public Sub SetFaxSMTPPortFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FaxSMTPPortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxSMTPPort field.
	''' </summary>
	Public Sub SetFaxSMTPPortFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FaxSMTPPortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxSMTPPort field.
	''' </summary>
	Public Sub SetFaxSMTPPortFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FaxSMTPPortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxSMTPPort field.
	''' </summary>
	Public Sub SetFaxSMTPPortFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FaxSMTPPortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxSMTPPort field.
	''' </summary>
	Public Sub SetFaxSMTPPortFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FaxSMTPPortColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.FaxSMTPServer field.
	''' </summary>
	Public Function GetFaxSMTPServerValue() As ColumnValue
		Return Me.GetValue(TableUtils.FaxSMTPServerColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.FaxSMTPServer field.
	''' </summary>
	Public Function GetFaxSMTPServerFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FaxSMTPServerColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxSMTPServer field.
	''' </summary>
	Public Sub SetFaxSMTPServerFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FaxSMTPServerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxSMTPServer field.
	''' </summary>
	Public Sub SetFaxSMTPServerFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FaxSMTPServerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.FaxEnableSSLYN field.
	''' </summary>
	Public Function GetFaxEnableSSLYNValue() As ColumnValue
		Return Me.GetValue(TableUtils.FaxEnableSSLYNColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.FaxEnableSSLYN field.
	''' </summary>
	Public Function GetFaxEnableSSLYNFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FaxEnableSSLYNColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxEnableSSLYN field.
	''' </summary>
	Public Sub SetFaxEnableSSLYNFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FaxEnableSSLYNColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxEnableSSLYN field.
	''' </summary>
	Public Sub SetFaxEnableSSLYNFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FaxEnableSSLYNColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxEnableSSLYN field.
	''' </summary>
	Public Sub SetFaxEnableSSLYNFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FaxEnableSSLYNColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxEnableSSLYN field.
	''' </summary>
	Public Sub SetFaxEnableSSLYNFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FaxEnableSSLYNColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.FaxEnableSSLYN field.
	''' </summary>
	Public Sub SetFaxEnableSSLYNFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FaxEnableSSLYNColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.RegisteredUserSince field.
	''' </summary>
	Public Function GetRegisteredUserSinceValue() As ColumnValue
		Return Me.GetValue(TableUtils.RegisteredUserSinceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.RegisteredUserSince field.
	''' </summary>
	Public Function GetRegisteredUserSinceFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.RegisteredUserSinceColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.RegisteredUserSince field.
	''' </summary>
	Public Sub SetRegisteredUserSinceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RegisteredUserSinceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.RegisteredUserSince field.
	''' </summary>
	Public Sub SetRegisteredUserSinceFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RegisteredUserSinceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.RegisteredUserSince field.
	''' </summary>
	Public Sub SetRegisteredUserSinceFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RegisteredUserSinceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.AccountFlowStepID field.
	''' </summary>
	Public Function GetAccountFlowStepIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AccountFlowStepIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.AccountFlowStepID field.
	''' </summary>
	Public Function GetAccountFlowStepIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AccountFlowStepIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.AccountFlowStepID field.
	''' </summary>
	Public Sub SetAccountFlowStepIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AccountFlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.AccountFlowStepID field.
	''' </summary>
	Public Sub SetAccountFlowStepIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AccountFlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.AccountFlowStepID field.
	''' </summary>
	Public Sub SetAccountFlowStepIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AccountFlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.AccountFlowStepID field.
	''' </summary>
	Public Sub SetAccountFlowStepIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AccountFlowStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.AccountFlowStepID field.
	''' </summary>
	Public Sub SetAccountFlowStepIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AccountFlowStepIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.PayPalToken field.
	''' </summary>
	Public Function GetPayPalTokenValue() As ColumnValue
		Return Me.GetValue(TableUtils.PayPalTokenColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.PayPalToken field.
	''' </summary>
	Public Function GetPayPalTokenFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PayPalTokenColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.PayPalToken field.
	''' </summary>
	Public Sub SetPayPalTokenFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PayPalTokenColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.PayPalToken field.
	''' </summary>
	Public Sub SetPayPalTokenFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PayPalTokenColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.StripSearch field.
	''' </summary>
	Public Function GetStripSearchValue() As ColumnValue
		Return Me.GetValue(TableUtils.StripSearchColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.StripSearch field.
	''' </summary>
	Public Function GetStripSearchFieldValue() As String
		Return CType(Me.GetValue(TableUtils.StripSearchColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.StripSearch field.
	''' </summary>
	Public Sub SetStripSearchFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StripSearchColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.StripSearch field.
	''' </summary>
	Public Sub SetStripSearchFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StripSearchColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.StripSearchDBA field.
	''' </summary>
	Public Function GetStripSearchDBAValue() As ColumnValue
		Return Me.GetValue(TableUtils.StripSearchDBAColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.StripSearchDBA field.
	''' </summary>
	Public Function GetStripSearchDBAFieldValue() As String
		Return CType(Me.GetValue(TableUtils.StripSearchDBAColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.StripSearchDBA field.
	''' </summary>
	Public Sub SetStripSearchDBAFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StripSearchDBAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.StripSearchDBA field.
	''' </summary>
	Public Sub SetStripSearchDBAFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StripSearchDBAColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.OutsideID field.
	''' </summary>
	Public Function GetOutsideIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.OutsideIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.OutsideID field.
	''' </summary>
	Public Function GetOutsideIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.OutsideIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.OutsideID field.
	''' </summary>
	Public Sub SetOutsideIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OutsideIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.OutsideID field.
	''' </summary>
	Public Sub SetOutsideIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OutsideIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Party_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Party_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Party_.PartyTypeID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Party_.Logo field.
	''' </summary>
	Public Property Logo() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.LogoColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LogoColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LogoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LogoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LogoDefault() As String
        Get
            Return TableUtils.LogoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.ProfilePicture field.
	''' </summary>
	Public Property ProfilePicture() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.ProfilePictureColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ProfilePictureColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ProfilePictureSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ProfilePictureColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ProfilePictureDefault() As String
        Get
            Return TableUtils.ProfilePictureColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.Name field.
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
	''' This is a convenience property that provides direct access to the value of the record's Party_.DBA field.
	''' </summary>
	Public Property DBA() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DBAColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DBAColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DBASpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DBAColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DBADefault() As String
        Get
            Return TableUtils.DBAColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.Title field.
	''' </summary>
	Public Property Title() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TitleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TitleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TitleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TitleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TitleDefault() As String
        Get
            Return TableUtils.TitleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.Handle field.
	''' </summary>
	Public Property Handle() As String
		Get 
			Return CType(Me.GetValue(TableUtils.HandleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.HandleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HandleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HandleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HandleDefault() As String
        Get
            Return TableUtils.HandleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.Email field.
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
	''' This is a convenience property that provides direct access to the value of the record's Party_.Password field.
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
	''' This is a convenience property that provides direct access to the value of the record's Party_.Contact field.
	''' </summary>
	Public Property Contact() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ContactColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ContactColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ContactSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ContactColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ContactDefault() As String
        Get
            Return TableUtils.ContactColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.DirectDial field.
	''' </summary>
	Public Property DirectDial() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DirectDialColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DirectDialColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DirectDialSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DirectDialColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DirectDialDefault() As String
        Get
            Return TableUtils.DirectDialColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.Mobile field.
	''' </summary>
	Public Property Mobile() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MobileColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MobileColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MobileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MobileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MobileDefault() As String
        Get
            Return TableUtils.MobileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.Fax field.
	''' </summary>
	Public Property Fax() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FaxColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FaxColumn)
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
	''' This is a convenience property that provides direct access to the value of the record's Party_.OtherPhone field.
	''' </summary>
	Public Property OtherPhone() As String
		Get 
			Return CType(Me.GetValue(TableUtils.OtherPhoneColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.OtherPhoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OtherPhoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OtherPhoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OtherPhoneDefault() As String
        Get
            Return TableUtils.OtherPhoneColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.ShareWithFriends field.
	''' </summary>
	Public Property ShareWithFriends() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ShareWithFriendsColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ShareWithFriendsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ShareWithFriendsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ShareWithFriendsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ShareWithFriendsDefault() As String
        Get
            Return TableUtils.ShareWithFriendsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.ShareWithDrivers field.
	''' </summary>
	Public Property ShareWithDrivers() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ShareWithDriversColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ShareWithDriversColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ShareWithDriversSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ShareWithDriversColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ShareWithDriversDefault() As String
        Get
            Return TableUtils.ShareWithDriversColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.ShareWithCarrier field.
	''' </summary>
	Public Property ShareWithCarrier() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ShareWithCarrierColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ShareWithCarrierColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ShareWithCarrierSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ShareWithCarrierColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ShareWithCarrierDefault() As String
        Get
            Return TableUtils.ShareWithCarrierColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.ShareWithCloseBy field.
	''' </summary>
	Public Property ShareWithCloseBy() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ShareWithCloseByColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ShareWithCloseByColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ShareWithCloseBySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ShareWithCloseByColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ShareWithCloseByDefault() As String
        Get
            Return TableUtils.ShareWithCloseByColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.ShareWithLikeMe field.
	''' </summary>
	Public Property ShareWithLikeMe() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ShareWithLikeMeColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ShareWithLikeMeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ShareWithLikeMeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ShareWithLikeMeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ShareWithLikeMeDefault() As String
        Get
            Return TableUtils.ShareWithLikeMeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.AllowInvitations field.
	''' </summary>
	Public Property AllowInvitations() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.AllowInvitationsColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AllowInvitationsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AllowInvitationsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AllowInvitationsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AllowInvitationsDefault() As String
        Get
            Return TableUtils.AllowInvitationsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.ThreadEmail field.
	''' </summary>
	Public Property ThreadEmail() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThreadEmailColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThreadEmailColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThreadEmailSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThreadEmailColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThreadEmailDefault() As String
        Get
            Return TableUtils.ThreadEmailColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.ThreadMobileText field.
	''' </summary>
	Public Property ThreadMobileText() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThreadMobileTextColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThreadMobileTextColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThreadMobileTextSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThreadMobileTextColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThreadMobileTextDefault() As String
        Get
            Return TableUtils.ThreadMobileTextColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.ThreadFax field.
	''' </summary>
	Public Property ThreadFax() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThreadFaxColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThreadFaxColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThreadFaxSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThreadFaxColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThreadFaxDefault() As String
        Get
            Return TableUtils.ThreadFaxColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.ThreadInstantMessage field.
	''' </summary>
	Public Property ThreadInstantMessage() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThreadInstantMessageColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThreadInstantMessageColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThreadInstantMessageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThreadInstantMessageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThreadInstantMessageDefault() As String
        Get
            Return TableUtils.ThreadInstantMessageColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.ThreadBoardOnly field.
	''' </summary>
	Public Property ThreadBoardOnly() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThreadBoardOnlyColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThreadBoardOnlyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThreadBoardOnlySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThreadBoardOnlyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThreadBoardOnlyDefault() As String
        Get
            Return TableUtils.ThreadBoardOnlyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.FullProfile field.
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
	''' This is a convenience property that provides direct access to the value of the record's Party_.SignatureFile field.
	''' </summary>
	Public Property SignatureFile() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.SignatureFileColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SignatureFileColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SignatureFileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SignatureFileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SignatureFileDefault() As String
        Get
            Return TableUtils.SignatureFileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.InitialsFile field.
	''' </summary>
	Public Property InitialsFile() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.InitialsFileColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.InitialsFileColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property InitialsFileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.InitialsFileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property InitialsFileDefault() As String
        Get
            Return TableUtils.InitialsFileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.EntityID field.
	''' </summary>
	Public Property EntityID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EntityIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EntityIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EntityIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EntityIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EntityIDDefault() As String
        Get
            Return TableUtils.EntityIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.SocialSecurityNumber field.
	''' </summary>
	Public Property SocialSecurityNumber() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SocialSecurityNumberColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SocialSecurityNumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SocialSecurityNumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SocialSecurityNumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SocialSecurityNumberDefault() As String
        Get
            Return TableUtils.SocialSecurityNumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.EINNumber field.
	''' </summary>
	Public Property EINNumber() As String
		Get 
			Return CType(Me.GetValue(TableUtils.EINNumberColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.EINNumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EINNumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EINNumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EINNumberDefault() As String
        Get
            Return TableUtils.EINNumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.SMTPPort field.
	''' </summary>
	Public Property SMTPPort() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SMTPPortColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SMTPPortColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SMTPPortSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SMTPPortColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SMTPPortDefault() As String
        Get
            Return TableUtils.SMTPPortColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.SMTPServer field.
	''' </summary>
	Public Property SMTPServer() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SMTPServerColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SMTPServerColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SMTPServerSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SMTPServerColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SMTPServerDefault() As String
        Get
            Return TableUtils.SMTPServerColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.SMTPPassword field.
	''' </summary>
	Public Property SMTPPassword() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SMTPPasswordColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SMTPPasswordColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SMTPPasswordSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SMTPPasswordColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SMTPPasswordDefault() As String
        Get
            Return TableUtils.SMTPPasswordColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.EnableSSLYN field.
	''' </summary>
	Public Property EnableSSLYN() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EnableSSLYNColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EnableSSLYNColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EnableSSLYNSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EnableSSLYNColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EnableSSLYNDefault() As String
        Get
            Return TableUtils.EnableSSLYNColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.FaxCredentials field.
	''' </summary>
	Public Property FaxCredentials() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FaxCredentialsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FaxCredentialsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FaxCredentialsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FaxCredentialsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FaxCredentialsDefault() As String
        Get
            Return TableUtils.FaxCredentialsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.FaxAccount field.
	''' </summary>
	Public Property FaxAccount() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FaxAccountColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FaxAccountColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FaxAccountSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FaxAccountColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FaxAccountDefault() As String
        Get
            Return TableUtils.FaxAccountColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.FaxPassword field.
	''' </summary>
	Public Property FaxPassword() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FaxPasswordColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FaxPasswordColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FaxPasswordSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FaxPasswordColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FaxPasswordDefault() As String
        Get
            Return TableUtils.FaxPasswordColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.FaxSMTPPort field.
	''' </summary>
	Public Property FaxSMTPPort() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FaxSMTPPortColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FaxSMTPPortColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FaxSMTPPortSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FaxSMTPPortColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FaxSMTPPortDefault() As String
        Get
            Return TableUtils.FaxSMTPPortColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.FaxSMTPServer field.
	''' </summary>
	Public Property FaxSMTPServer() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FaxSMTPServerColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FaxSMTPServerColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FaxSMTPServerSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FaxSMTPServerColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FaxSMTPServerDefault() As String
        Get
            Return TableUtils.FaxSMTPServerColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.FaxEnableSSLYN field.
	''' </summary>
	Public Property FaxEnableSSLYN() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FaxEnableSSLYNColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FaxEnableSSLYNColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FaxEnableSSLYNSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FaxEnableSSLYNColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FaxEnableSSLYNDefault() As String
        Get
            Return TableUtils.FaxEnableSSLYNColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.RegisteredUserSince field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.AccountFlowStepID field.
	''' </summary>
	Public Property AccountFlowStepID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AccountFlowStepIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AccountFlowStepIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AccountFlowStepIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AccountFlowStepIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AccountFlowStepIDDefault() As String
        Get
            Return TableUtils.AccountFlowStepIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.PayPalToken field.
	''' </summary>
	Public Property PayPalToken() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PayPalTokenColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PayPalTokenColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PayPalTokenSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PayPalTokenColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PayPalTokenDefault() As String
        Get
            Return TableUtils.PayPalTokenColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.StripSearch field.
	''' </summary>
	Public Property StripSearch() As String
		Get 
			Return CType(Me.GetValue(TableUtils.StripSearchColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.StripSearchColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property StripSearchSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.StripSearchColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property StripSearchDefault() As String
        Get
            Return TableUtils.StripSearchColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.StripSearchDBA field.
	''' </summary>
	Public Property StripSearchDBA() As String
		Get 
			Return CType(Me.GetValue(TableUtils.StripSearchDBAColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.StripSearchDBAColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property StripSearchDBASpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.StripSearchDBAColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property StripSearchDBADefault() As String
        Get
            Return TableUtils.StripSearchDBAColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.OutsideID field.
	''' </summary>
	Public Property OutsideID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.OutsideIDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.OutsideIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OutsideIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OutsideIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OutsideIDDefault() As String
        Get
            Return TableUtils.OutsideIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Party_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Party_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's Party_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Party_.UpdatedAt field.
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
