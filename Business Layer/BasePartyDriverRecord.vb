' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyDriverRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PartyDriverRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="PartyDriverTable"></see> class.
''' </remarks>
''' <seealso cref="PartyDriverTable"></seealso>
''' <seealso cref="PartyDriverRecord"></seealso>

<Serializable()> Public Class BasePartyDriverRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As PartyDriverTable = PartyDriverTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub PartyDriverRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim PartyDriverRec As PartyDriverRecord = CType(sender,PartyDriverRecord)
        Validate_Inserting()
        If Not PartyDriverRec Is Nothing AndAlso Not PartyDriverRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub PartyDriverRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim PartyDriverRec As PartyDriverRecord = CType(sender,PartyDriverRecord)
        Validate_Updating()
        If Not PartyDriverRec Is Nothing AndAlso Not PartyDriverRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub PartyDriverRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim PartyDriverRec As PartyDriverRecord = CType(sender,PartyDriverRecord)
        If Not PartyDriverRec Is Nothing AndAlso Not PartyDriverRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.DriverID field.
	''' </summary>
	Public Function GetDriverIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DriverIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.DriverID field.
	''' </summary>
	Public Function GetDriverIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DriverIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.TruckerTypeID field.
	''' </summary>
	Public Function GetTruckerTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TruckerTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.TruckerTypeID field.
	''' </summary>
	Public Function GetTruckerTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TruckerTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.TruckerTypeID field.
	''' </summary>
	Public Sub SetTruckerTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TruckerTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.TruckerTypeID field.
	''' </summary>
	Public Sub SetTruckerTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TruckerTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.TruckerTypeID field.
	''' </summary>
	Public Sub SetTruckerTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TruckerTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.TruckerTypeID field.
	''' </summary>
	Public Sub SetTruckerTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TruckerTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.TruckerTypeID field.
	''' </summary>
	Public Sub SetTruckerTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TruckerTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.DateOfBirth field.
	''' </summary>
	Public Function GetDateOfBirthValue() As ColumnValue
		Return Me.GetValue(TableUtils.DateOfBirthColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.DateOfBirth field.
	''' </summary>
	Public Function GetDateOfBirthFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DateOfBirthColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.DateOfBirth field.
	''' </summary>
	Public Sub SetDateOfBirthFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DateOfBirthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.DateOfBirth field.
	''' </summary>
	Public Sub SetDateOfBirthFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DateOfBirthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.DateOfBirth field.
	''' </summary>
	Public Sub SetDateOfBirthFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DateOfBirthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.SocialSecurityNumber field.
	''' </summary>
	Public Function GetSocialSecurityNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.SocialSecurityNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.SocialSecurityNumber field.
	''' </summary>
	Public Function GetSocialSecurityNumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SocialSecurityNumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.SocialSecurityNumber field.
	''' </summary>
	Public Sub SetSocialSecurityNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SocialSecurityNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.SocialSecurityNumber field.
	''' </summary>
	Public Sub SetSocialSecurityNumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SocialSecurityNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.USCitizen field.
	''' </summary>
	Public Function GetUSCitizenValue() As ColumnValue
		Return Me.GetValue(TableUtils.USCitizenColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.USCitizen field.
	''' </summary>
	Public Function GetUSCitizenFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.USCitizenColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.USCitizen field.
	''' </summary>
	Public Sub SetUSCitizenFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.USCitizenColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.USCitizen field.
	''' </summary>
	Public Sub SetUSCitizenFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.USCitizenColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.USCitizen field.
	''' </summary>
	Public Sub SetUSCitizenFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.USCitizenColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.AuthorizedAlien field.
	''' </summary>
	Public Function GetAuthorizedAlienValue() As ColumnValue
		Return Me.GetValue(TableUtils.AuthorizedAlienColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.AuthorizedAlien field.
	''' </summary>
	Public Function GetAuthorizedAlienFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.AuthorizedAlienColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.AuthorizedAlien field.
	''' </summary>
	Public Sub SetAuthorizedAlienFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AuthorizedAlienColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.AuthorizedAlien field.
	''' </summary>
	Public Sub SetAuthorizedAlienFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AuthorizedAlienColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.AuthorizedAlien field.
	''' </summary>
	Public Sub SetAuthorizedAlienFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AuthorizedAlienColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.AuthorizationTypeID field.
	''' </summary>
	Public Function GetAuthorizationTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AuthorizationTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.AuthorizationTypeID field.
	''' </summary>
	Public Function GetAuthorizationTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AuthorizationTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.AuthorizationTypeID field.
	''' </summary>
	Public Sub SetAuthorizationTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AuthorizationTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.AuthorizationTypeID field.
	''' </summary>
	Public Sub SetAuthorizationTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AuthorizationTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.AuthorizationTypeID field.
	''' </summary>
	Public Sub SetAuthorizationTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AuthorizationTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.AuthorizationTypeID field.
	''' </summary>
	Public Sub SetAuthorizationTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AuthorizationTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.AuthorizationTypeID field.
	''' </summary>
	Public Sub SetAuthorizationTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AuthorizationTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.VisaNumber field.
	''' </summary>
	Public Function GetVisaNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.VisaNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.VisaNumber field.
	''' </summary>
	Public Function GetVisaNumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.VisaNumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.VisaNumber field.
	''' </summary>
	Public Sub SetVisaNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VisaNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.VisaNumber field.
	''' </summary>
	Public Sub SetVisaNumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VisaNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.CertifiedBrakeInspector field.
	''' </summary>
	Public Function GetCertifiedBrakeInspectorValue() As ColumnValue
		Return Me.GetValue(TableUtils.CertifiedBrakeInspectorColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.CertifiedBrakeInspector field.
	''' </summary>
	Public Function GetCertifiedBrakeInspectorFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.CertifiedBrakeInspectorColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.CertifiedBrakeInspector field.
	''' </summary>
	Public Sub SetCertifiedBrakeInspectorFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CertifiedBrakeInspectorColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.CertifiedBrakeInspector field.
	''' </summary>
	Public Sub SetCertifiedBrakeInspectorFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CertifiedBrakeInspectorColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.CertifiedBrakeInspector field.
	''' </summary>
	Public Sub SetCertifiedBrakeInspectorFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CertifiedBrakeInspectorColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.MoreThanOneLicense field.
	''' </summary>
	Public Function GetMoreThanOneLicenseValue() As ColumnValue
		Return Me.GetValue(TableUtils.MoreThanOneLicenseColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.MoreThanOneLicense field.
	''' </summary>
	Public Function GetMoreThanOneLicenseFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.MoreThanOneLicenseColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.MoreThanOneLicense field.
	''' </summary>
	Public Sub SetMoreThanOneLicenseFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MoreThanOneLicenseColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.MoreThanOneLicense field.
	''' </summary>
	Public Sub SetMoreThanOneLicenseFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MoreThanOneLicenseColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.MoreThanOneLicense field.
	''' </summary>
	Public Sub SetMoreThanOneLicenseFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MoreThanOneLicenseColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.PromiseToNotifyIn24Hours field.
	''' </summary>
	Public Function GetPromiseToNotifyIn24HoursValue() As ColumnValue
		Return Me.GetValue(TableUtils.PromiseToNotifyIn24HoursColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.PromiseToNotifyIn24Hours field.
	''' </summary>
	Public Function GetPromiseToNotifyIn24HoursFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.PromiseToNotifyIn24HoursColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PromiseToNotifyIn24Hours field.
	''' </summary>
	Public Sub SetPromiseToNotifyIn24HoursFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PromiseToNotifyIn24HoursColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PromiseToNotifyIn24Hours field.
	''' </summary>
	Public Sub SetPromiseToNotifyIn24HoursFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PromiseToNotifyIn24HoursColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PromiseToNotifyIn24Hours field.
	''' </summary>
	Public Sub SetPromiseToNotifyIn24HoursFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PromiseToNotifyIn24HoursColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.PromiseNeverSuspended field.
	''' </summary>
	Public Function GetPromiseNeverSuspendedValue() As ColumnValue
		Return Me.GetValue(TableUtils.PromiseNeverSuspendedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.PromiseNeverSuspended field.
	''' </summary>
	Public Function GetPromiseNeverSuspendedFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.PromiseNeverSuspendedColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PromiseNeverSuspended field.
	''' </summary>
	Public Sub SetPromiseNeverSuspendedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PromiseNeverSuspendedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PromiseNeverSuspended field.
	''' </summary>
	Public Sub SetPromiseNeverSuspendedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PromiseNeverSuspendedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PromiseNeverSuspended field.
	''' </summary>
	Public Sub SetPromiseNeverSuspendedFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PromiseNeverSuspendedColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.DrugTestedWithLastCarrier field.
	''' </summary>
	Public Function GetDrugTestedWithLastCarrierValue() As ColumnValue
		Return Me.GetValue(TableUtils.DrugTestedWithLastCarrierColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.DrugTestedWithLastCarrier field.
	''' </summary>
	Public Function GetDrugTestedWithLastCarrierFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.DrugTestedWithLastCarrierColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.DrugTestedWithLastCarrier field.
	''' </summary>
	Public Sub SetDrugTestedWithLastCarrierFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DrugTestedWithLastCarrierColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.DrugTestedWithLastCarrier field.
	''' </summary>
	Public Sub SetDrugTestedWithLastCarrierFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DrugTestedWithLastCarrierColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.DrugTestedWithLastCarrier field.
	''' </summary>
	Public Sub SetDrugTestedWithLastCarrierFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DrugTestedWithLastCarrierColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.PromisedNeverPostiveOnDrugTest field.
	''' </summary>
	Public Function GetPromisedNeverPostiveOnDrugTestValue() As ColumnValue
		Return Me.GetValue(TableUtils.PromisedNeverPostiveOnDrugTestColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.PromisedNeverPostiveOnDrugTest field.
	''' </summary>
	Public Function GetPromisedNeverPostiveOnDrugTestFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.PromisedNeverPostiveOnDrugTestColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PromisedNeverPostiveOnDrugTest field.
	''' </summary>
	Public Sub SetPromisedNeverPostiveOnDrugTestFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PromisedNeverPostiveOnDrugTestColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PromisedNeverPostiveOnDrugTest field.
	''' </summary>
	Public Sub SetPromisedNeverPostiveOnDrugTestFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PromisedNeverPostiveOnDrugTestColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PromisedNeverPostiveOnDrugTest field.
	''' </summary>
	Public Sub SetPromisedNeverPostiveOnDrugTestFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PromisedNeverPostiveOnDrugTestColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ReturnedToDuty field.
	''' </summary>
	Public Function GetReturnedToDutyValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReturnedToDutyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ReturnedToDuty field.
	''' </summary>
	Public Function GetReturnedToDutyFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ReturnedToDutyColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ReturnedToDuty field.
	''' </summary>
	Public Sub SetReturnedToDutyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReturnedToDutyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ReturnedToDuty field.
	''' </summary>
	Public Sub SetReturnedToDutyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ReturnedToDutyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ReturnedToDuty field.
	''' </summary>
	Public Sub SetReturnedToDutyFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReturnedToDutyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ContactInfoComplete field.
	''' </summary>
	Public Function GetContactInfoCompleteValue() As ColumnValue
		Return Me.GetValue(TableUtils.ContactInfoCompleteColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ContactInfoComplete field.
	''' </summary>
	Public Function GetContactInfoCompleteFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ContactInfoCompleteColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ContactInfoComplete field.
	''' </summary>
	Public Sub SetContactInfoCompleteFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ContactInfoCompleteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ContactInfoComplete field.
	''' </summary>
	Public Sub SetContactInfoCompleteFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ContactInfoCompleteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ContactInfoComplete field.
	''' </summary>
	Public Sub SetContactInfoCompleteFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ContactInfoCompleteColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.PersonalInfoComplete field.
	''' </summary>
	Public Function GetPersonalInfoCompleteValue() As ColumnValue
		Return Me.GetValue(TableUtils.PersonalInfoCompleteColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.PersonalInfoComplete field.
	''' </summary>
	Public Function GetPersonalInfoCompleteFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.PersonalInfoCompleteColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PersonalInfoComplete field.
	''' </summary>
	Public Sub SetPersonalInfoCompleteFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PersonalInfoCompleteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PersonalInfoComplete field.
	''' </summary>
	Public Sub SetPersonalInfoCompleteFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PersonalInfoCompleteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.PersonalInfoComplete field.
	''' </summary>
	Public Sub SetPersonalInfoCompleteFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PersonalInfoCompleteColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.RepresentationsComplete field.
	''' </summary>
	Public Function GetRepresentationsCompleteValue() As ColumnValue
		Return Me.GetValue(TableUtils.RepresentationsCompleteColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.RepresentationsComplete field.
	''' </summary>
	Public Function GetRepresentationsCompleteFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.RepresentationsCompleteColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.RepresentationsComplete field.
	''' </summary>
	Public Sub SetRepresentationsCompleteFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RepresentationsCompleteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.RepresentationsComplete field.
	''' </summary>
	Public Sub SetRepresentationsCompleteFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RepresentationsCompleteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.RepresentationsComplete field.
	''' </summary>
	Public Sub SetRepresentationsCompleteFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RepresentationsCompleteColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.EstAccidentsID field.
	''' </summary>
	Public Function GetEstAccidentsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EstAccidentsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.EstAccidentsID field.
	''' </summary>
	Public Function GetEstAccidentsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EstAccidentsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstAccidentsID field.
	''' </summary>
	Public Sub SetEstAccidentsIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EstAccidentsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstAccidentsID field.
	''' </summary>
	Public Sub SetEstAccidentsIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EstAccidentsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstAccidentsID field.
	''' </summary>
	Public Sub SetEstAccidentsIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstAccidentsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstAccidentsID field.
	''' </summary>
	Public Sub SetEstAccidentsIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstAccidentsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstAccidentsID field.
	''' </summary>
	Public Sub SetEstAccidentsIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstAccidentsIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.EstTicketsID field.
	''' </summary>
	Public Function GetEstTicketsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EstTicketsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.EstTicketsID field.
	''' </summary>
	Public Function GetEstTicketsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EstTicketsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstTicketsID field.
	''' </summary>
	Public Sub SetEstTicketsIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EstTicketsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstTicketsID field.
	''' </summary>
	Public Sub SetEstTicketsIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EstTicketsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstTicketsID field.
	''' </summary>
	Public Sub SetEstTicketsIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstTicketsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstTicketsID field.
	''' </summary>
	Public Sub SetEstTicketsIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstTicketsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstTicketsID field.
	''' </summary>
	Public Sub SetEstTicketsIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstTicketsIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.EstFailedTestsID field.
	''' </summary>
	Public Function GetEstFailedTestsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EstFailedTestsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.EstFailedTestsID field.
	''' </summary>
	Public Function GetEstFailedTestsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EstFailedTestsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstFailedTestsID field.
	''' </summary>
	Public Sub SetEstFailedTestsIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EstFailedTestsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstFailedTestsID field.
	''' </summary>
	Public Sub SetEstFailedTestsIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EstFailedTestsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstFailedTestsID field.
	''' </summary>
	Public Sub SetEstFailedTestsIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstFailedTestsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstFailedTestsID field.
	''' </summary>
	Public Sub SetEstFailedTestsIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstFailedTestsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstFailedTestsID field.
	''' </summary>
	Public Sub SetEstFailedTestsIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstFailedTestsIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.EstFeloniesID field.
	''' </summary>
	Public Function GetEstFeloniesIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.EstFeloniesIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.EstFeloniesID field.
	''' </summary>
	Public Function GetEstFeloniesIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.EstFeloniesIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstFeloniesID field.
	''' </summary>
	Public Sub SetEstFeloniesIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EstFeloniesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstFeloniesID field.
	''' </summary>
	Public Sub SetEstFeloniesIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EstFeloniesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstFeloniesID field.
	''' </summary>
	Public Sub SetEstFeloniesIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstFeloniesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstFeloniesID field.
	''' </summary>
	Public Sub SetEstFeloniesIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstFeloniesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.EstFeloniesID field.
	''' </summary>
	Public Sub SetEstFeloniesIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EstFeloniesIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ProgBasic field.
	''' </summary>
	Public Function GetProgBasicValue() As ColumnValue
		Return Me.GetValue(TableUtils.ProgBasicColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ProgBasic field.
	''' </summary>
	Public Function GetProgBasicFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.ProgBasicColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgBasic field.
	''' </summary>
	Public Sub SetProgBasicFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ProgBasicColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgBasic field.
	''' </summary>
	Public Sub SetProgBasicFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ProgBasicColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgBasic field.
	''' </summary>
	Public Sub SetProgBasicFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgBasicColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgBasic field.
	''' </summary>
	Public Sub SetProgBasicFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgBasicColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgBasic field.
	''' </summary>
	Public Sub SetProgBasicFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgBasicColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ProgHistory field.
	''' </summary>
	Public Function GetProgHistoryValue() As ColumnValue
		Return Me.GetValue(TableUtils.ProgHistoryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ProgHistory field.
	''' </summary>
	Public Function GetProgHistoryFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.ProgHistoryColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgHistory field.
	''' </summary>
	Public Sub SetProgHistoryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ProgHistoryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgHistory field.
	''' </summary>
	Public Sub SetProgHistoryFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ProgHistoryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgHistory field.
	''' </summary>
	Public Sub SetProgHistoryFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgHistoryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgHistory field.
	''' </summary>
	Public Sub SetProgHistoryFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgHistoryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgHistory field.
	''' </summary>
	Public Sub SetProgHistoryFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgHistoryColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ProgExperience field.
	''' </summary>
	Public Function GetProgExperienceValue() As ColumnValue
		Return Me.GetValue(TableUtils.ProgExperienceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ProgExperience field.
	''' </summary>
	Public Function GetProgExperienceFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.ProgExperienceColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgExperience field.
	''' </summary>
	Public Sub SetProgExperienceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ProgExperienceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgExperience field.
	''' </summary>
	Public Sub SetProgExperienceFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ProgExperienceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgExperience field.
	''' </summary>
	Public Sub SetProgExperienceFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgExperienceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgExperience field.
	''' </summary>
	Public Sub SetProgExperienceFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgExperienceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgExperience field.
	''' </summary>
	Public Sub SetProgExperienceFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgExperienceColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ProgIncidents field.
	''' </summary>
	Public Function GetProgIncidentsValue() As ColumnValue
		Return Me.GetValue(TableUtils.ProgIncidentsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ProgIncidents field.
	''' </summary>
	Public Function GetProgIncidentsFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.ProgIncidentsColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgIncidents field.
	''' </summary>
	Public Sub SetProgIncidentsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ProgIncidentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgIncidents field.
	''' </summary>
	Public Sub SetProgIncidentsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ProgIncidentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgIncidents field.
	''' </summary>
	Public Sub SetProgIncidentsFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgIncidentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgIncidents field.
	''' </summary>
	Public Sub SetProgIncidentsFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgIncidentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgIncidents field.
	''' </summary>
	Public Sub SetProgIncidentsFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgIncidentsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ProgDoc field.
	''' </summary>
	Public Function GetProgDocValue() As ColumnValue
		Return Me.GetValue(TableUtils.ProgDocColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ProgDoc field.
	''' </summary>
	Public Function GetProgDocFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.ProgDocColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgDoc field.
	''' </summary>
	Public Sub SetProgDocFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ProgDocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgDoc field.
	''' </summary>
	Public Sub SetProgDocFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ProgDocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgDoc field.
	''' </summary>
	Public Sub SetProgDocFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgDocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgDoc field.
	''' </summary>
	Public Sub SetProgDocFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgDocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgDoc field.
	''' </summary>
	Public Sub SetProgDocFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgDocColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ProgeeEquip field.
	''' </summary>
	Public Function GetProgeeEquipValue() As ColumnValue
		Return Me.GetValue(TableUtils.ProgeeEquipColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.ProgeeEquip field.
	''' </summary>
	Public Function GetProgeeEquipFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.ProgeeEquipColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgeeEquip field.
	''' </summary>
	Public Sub SetProgeeEquipFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ProgeeEquipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgeeEquip field.
	''' </summary>
	Public Sub SetProgeeEquipFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ProgeeEquipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgeeEquip field.
	''' </summary>
	Public Sub SetProgeeEquipFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgeeEquipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgeeEquip field.
	''' </summary>
	Public Sub SetProgeeEquipFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgeeEquipColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.ProgeeEquip field.
	''' </summary>
	Public Sub SetProgeeEquipFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProgeeEquipColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.GaugeID field.
	''' </summary>
	Public Function GetGaugeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.GaugeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.GaugeID field.
	''' </summary>
	Public Function GetGaugeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.GaugeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.GaugeID field.
	''' </summary>
	Public Sub SetGaugeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GaugeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.GaugeID field.
	''' </summary>
	Public Sub SetGaugeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.GaugeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.GaugeID field.
	''' </summary>
	Public Sub SetGaugeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GaugeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.GaugeID field.
	''' </summary>
	Public Sub SetGaugeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GaugeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.GaugeID field.
	''' </summary>
	Public Sub SetGaugeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GaugeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's PartyDriver_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's PartyDriver_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.DriverID field.
	''' </summary>
	Public Property DriverID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DriverIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DriverIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DriverIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DriverIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DriverIDDefault() As String
        Get
            Return TableUtils.DriverIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.TruckerTypeID field.
	''' </summary>
	Public Property TruckerTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TruckerTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TruckerTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TruckerTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TruckerTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TruckerTypeIDDefault() As String
        Get
            Return TableUtils.TruckerTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.DateOfBirth field.
	''' </summary>
	Public Property DateOfBirth() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.DateOfBirthColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DateOfBirthColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DateOfBirthSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DateOfBirthColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DateOfBirthDefault() As String
        Get
            Return TableUtils.DateOfBirthColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.SocialSecurityNumber field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.USCitizen field.
	''' </summary>
	Public Property USCitizen() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.USCitizenColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.USCitizenColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property USCitizenSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.USCitizenColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property USCitizenDefault() As String
        Get
            Return TableUtils.USCitizenColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.AuthorizedAlien field.
	''' </summary>
	Public Property AuthorizedAlien() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.AuthorizedAlienColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AuthorizedAlienColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AuthorizedAlienSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AuthorizedAlienColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AuthorizedAlienDefault() As String
        Get
            Return TableUtils.AuthorizedAlienColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.AuthorizationTypeID field.
	''' </summary>
	Public Property AuthorizationTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AuthorizationTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AuthorizationTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AuthorizationTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AuthorizationTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AuthorizationTypeIDDefault() As String
        Get
            Return TableUtils.AuthorizationTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.VisaNumber field.
	''' </summary>
	Public Property VisaNumber() As String
		Get 
			Return CType(Me.GetValue(TableUtils.VisaNumberColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.VisaNumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property VisaNumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.VisaNumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property VisaNumberDefault() As String
        Get
            Return TableUtils.VisaNumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.CertifiedBrakeInspector field.
	''' </summary>
	Public Property CertifiedBrakeInspector() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.CertifiedBrakeInspectorColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CertifiedBrakeInspectorColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CertifiedBrakeInspectorSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CertifiedBrakeInspectorColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CertifiedBrakeInspectorDefault() As String
        Get
            Return TableUtils.CertifiedBrakeInspectorColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.MoreThanOneLicense field.
	''' </summary>
	Public Property MoreThanOneLicense() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.MoreThanOneLicenseColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MoreThanOneLicenseColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MoreThanOneLicenseSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MoreThanOneLicenseColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MoreThanOneLicenseDefault() As String
        Get
            Return TableUtils.MoreThanOneLicenseColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.PromiseToNotifyIn24Hours field.
	''' </summary>
	Public Property PromiseToNotifyIn24Hours() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.PromiseToNotifyIn24HoursColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PromiseToNotifyIn24HoursColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PromiseToNotifyIn24HoursSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PromiseToNotifyIn24HoursColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PromiseToNotifyIn24HoursDefault() As String
        Get
            Return TableUtils.PromiseToNotifyIn24HoursColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.PromiseNeverSuspended field.
	''' </summary>
	Public Property PromiseNeverSuspended() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.PromiseNeverSuspendedColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PromiseNeverSuspendedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PromiseNeverSuspendedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PromiseNeverSuspendedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PromiseNeverSuspendedDefault() As String
        Get
            Return TableUtils.PromiseNeverSuspendedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.DrugTestedWithLastCarrier field.
	''' </summary>
	Public Property DrugTestedWithLastCarrier() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.DrugTestedWithLastCarrierColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DrugTestedWithLastCarrierColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DrugTestedWithLastCarrierSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DrugTestedWithLastCarrierColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DrugTestedWithLastCarrierDefault() As String
        Get
            Return TableUtils.DrugTestedWithLastCarrierColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.PromisedNeverPostiveOnDrugTest field.
	''' </summary>
	Public Property PromisedNeverPostiveOnDrugTest() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.PromisedNeverPostiveOnDrugTestColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PromisedNeverPostiveOnDrugTestColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PromisedNeverPostiveOnDrugTestSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PromisedNeverPostiveOnDrugTestColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PromisedNeverPostiveOnDrugTestDefault() As String
        Get
            Return TableUtils.PromisedNeverPostiveOnDrugTestColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.ReturnedToDuty field.
	''' </summary>
	Public Property ReturnedToDuty() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ReturnedToDutyColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ReturnedToDutyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReturnedToDutySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReturnedToDutyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReturnedToDutyDefault() As String
        Get
            Return TableUtils.ReturnedToDutyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.ContactInfoComplete field.
	''' </summary>
	Public Property ContactInfoComplete() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ContactInfoCompleteColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ContactInfoCompleteColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ContactInfoCompleteSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ContactInfoCompleteColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ContactInfoCompleteDefault() As String
        Get
            Return TableUtils.ContactInfoCompleteColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.PersonalInfoComplete field.
	''' </summary>
	Public Property PersonalInfoComplete() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.PersonalInfoCompleteColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PersonalInfoCompleteColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PersonalInfoCompleteSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PersonalInfoCompleteColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PersonalInfoCompleteDefault() As String
        Get
            Return TableUtils.PersonalInfoCompleteColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.RepresentationsComplete field.
	''' </summary>
	Public Property RepresentationsComplete() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.RepresentationsCompleteColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RepresentationsCompleteColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RepresentationsCompleteSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RepresentationsCompleteColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RepresentationsCompleteDefault() As String
        Get
            Return TableUtils.RepresentationsCompleteColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.EstAccidentsID field.
	''' </summary>
	Public Property EstAccidentsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EstAccidentsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EstAccidentsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EstAccidentsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EstAccidentsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EstAccidentsIDDefault() As String
        Get
            Return TableUtils.EstAccidentsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.EstTicketsID field.
	''' </summary>
	Public Property EstTicketsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EstTicketsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EstTicketsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EstTicketsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EstTicketsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EstTicketsIDDefault() As String
        Get
            Return TableUtils.EstTicketsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.EstFailedTestsID field.
	''' </summary>
	Public Property EstFailedTestsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EstFailedTestsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EstFailedTestsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EstFailedTestsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EstFailedTestsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EstFailedTestsIDDefault() As String
        Get
            Return TableUtils.EstFailedTestsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.EstFeloniesID field.
	''' </summary>
	Public Property EstFeloniesID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.EstFeloniesIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EstFeloniesIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EstFeloniesIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EstFeloniesIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EstFeloniesIDDefault() As String
        Get
            Return TableUtils.EstFeloniesIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.ProgBasic field.
	''' </summary>
	Public Property ProgBasic() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.ProgBasicColumn).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ProgBasicColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ProgBasicSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ProgBasicColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ProgBasicDefault() As String
        Get
            Return TableUtils.ProgBasicColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.ProgHistory field.
	''' </summary>
	Public Property ProgHistory() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.ProgHistoryColumn).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ProgHistoryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ProgHistorySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ProgHistoryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ProgHistoryDefault() As String
        Get
            Return TableUtils.ProgHistoryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.ProgExperience field.
	''' </summary>
	Public Property ProgExperience() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.ProgExperienceColumn).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ProgExperienceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ProgExperienceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ProgExperienceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ProgExperienceDefault() As String
        Get
            Return TableUtils.ProgExperienceColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.ProgIncidents field.
	''' </summary>
	Public Property ProgIncidents() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.ProgIncidentsColumn).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ProgIncidentsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ProgIncidentsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ProgIncidentsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ProgIncidentsDefault() As String
        Get
            Return TableUtils.ProgIncidentsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.ProgDoc field.
	''' </summary>
	Public Property ProgDoc() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.ProgDocColumn).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ProgDocColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ProgDocSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ProgDocColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ProgDocDefault() As String
        Get
            Return TableUtils.ProgDocColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.ProgeeEquip field.
	''' </summary>
	Public Property ProgeeEquip() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.ProgeeEquipColumn).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ProgeeEquipColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ProgeeEquipSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ProgeeEquipColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ProgeeEquipDefault() As String
        Get
            Return TableUtils.ProgeeEquipColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.GaugeID field.
	''' </summary>
	Public Property GaugeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.GaugeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.GaugeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GaugeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GaugeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GaugeIDDefault() As String
        Get
            Return TableUtils.GaugeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's PartyDriver_.UpdatedAt field.
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
