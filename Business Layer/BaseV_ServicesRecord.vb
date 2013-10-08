' This class is "generated" and will be overwritten.
' Your customizations should be made in V_ServicesRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_ServicesRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_ServicesView"></see> class.
''' </remarks>
''' <seealso cref="V_ServicesView"></seealso>
''' <seealso cref="V_ServicesRecord"></seealso>

<Serializable()> Public Class BaseV_ServicesRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_ServicesView = V_ServicesView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_ServicesRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_ServicesRec As V_ServicesRecord = CType(sender,V_ServicesRecord)
        Validate_Inserting()
        If Not V_ServicesRec Is Nothing AndAlso Not V_ServicesRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_ServicesRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_ServicesRec As V_ServicesRecord = CType(sender,V_ServicesRecord)
        Validate_Updating()
        If Not V_ServicesRec Is Nothing AndAlso Not V_ServicesRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_ServicesRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_ServicesRec As V_ServicesRecord = CType(sender,V_ServicesRecord)
        If Not V_ServicesRec Is Nothing AndAlso Not V_ServicesRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceID field.
	''' </summary>
	Public Function GetServiceIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ServiceIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceID field.
	''' </summary>
	Public Function GetServiceIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ServiceIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceContextID field.
	''' </summary>
	Public Function GetServiceContextIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ServiceContextIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceContextID field.
	''' </summary>
	Public Function GetServiceContextIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ServiceContextIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceContextID field.
	''' </summary>
	Public Sub SetServiceContextIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ServiceContextIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceContextID field.
	''' </summary>
	Public Sub SetServiceContextIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ServiceContextIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceContextID field.
	''' </summary>
	Public Sub SetServiceContextIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ServiceContextIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceContextID field.
	''' </summary>
	Public Sub SetServiceContextIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ServiceContextIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceContextID field.
	''' </summary>
	Public Sub SetServiceContextIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ServiceContextIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceTypeID field.
	''' </summary>
	Public Function GetServiceTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ServiceTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceTypeID field.
	''' </summary>
	Public Function GetServiceTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ServiceTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceTypeID field.
	''' </summary>
	Public Sub SetServiceTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ServiceTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceTypeID field.
	''' </summary>
	Public Sub SetServiceTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ServiceTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceTypeID field.
	''' </summary>
	Public Sub SetServiceTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ServiceTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceTypeID field.
	''' </summary>
	Public Sub SetServiceTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ServiceTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceTypeID field.
	''' </summary>
	Public Sub SetServiceTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ServiceTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceType field.
	''' </summary>
	Public Function GetServiceTypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.ServiceTypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceType field.
	''' </summary>
	Public Function GetServiceTypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ServiceTypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceType field.
	''' </summary>
	Public Sub SetServiceTypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ServiceTypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceType field.
	''' </summary>
	Public Sub SetServiceTypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ServiceTypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceImage field.
	''' </summary>
	Public Function GetServiceImageValue() As ColumnValue
		Return Me.GetValue(TableUtils.ServiceImageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceImage field.
	''' </summary>
	Public Function GetServiceImageFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ServiceImageColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceImage field.
	''' </summary>
	Public Sub SetServiceImageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ServiceImageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceImage field.
	''' </summary>
	Public Sub SetServiceImageFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ServiceImageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.FastportService field.
	''' </summary>
	Public Function GetFastportServiceValue() As ColumnValue
		Return Me.GetValue(TableUtils.FastportServiceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.FastportService field.
	''' </summary>
	Public Function GetFastportServiceFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FastportServiceColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.FastportService field.
	''' </summary>
	Public Sub SetFastportServiceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FastportServiceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.FastportService field.
	''' </summary>
	Public Sub SetFastportServiceFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FastportServiceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceRequired field.
	''' </summary>
	Public Function GetServiceRequiredValue() As ColumnValue
		Return Me.GetValue(TableUtils.ServiceRequiredColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceRequired field.
	''' </summary>
	Public Function GetServiceRequiredFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ServiceRequiredColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceRequired field.
	''' </summary>
	Public Sub SetServiceRequiredFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ServiceRequiredColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceRequired field.
	''' </summary>
	Public Sub SetServiceRequiredFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ServiceRequiredColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceRequired field.
	''' </summary>
	Public Sub SetServiceRequiredFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ServiceRequiredColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.Cost field.
	''' </summary>
	Public Function GetCostValue() As ColumnValue
		Return Me.GetValue(TableUtils.CostColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.Cost field.
	''' </summary>
	Public Function GetCostFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CostColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.Cost field.
	''' </summary>
	Public Sub SetCostFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CostColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.Cost field.
	''' </summary>
	Public Sub SetCostFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CostColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceName field.
	''' </summary>
	Public Function GetServiceNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ServiceNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceName field.
	''' </summary>
	Public Function GetServiceNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ServiceNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceName field.
	''' </summary>
	Public Sub SetServiceNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ServiceNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceName field.
	''' </summary>
	Public Sub SetServiceNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ServiceNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceDescription field.
	''' </summary>
	Public Function GetServiceDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.ServiceDescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceDescription field.
	''' </summary>
	Public Function GetServiceDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ServiceDescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceDescription field.
	''' </summary>
	Public Sub SetServiceDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ServiceDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceDescription field.
	''' </summary>
	Public Sub SetServiceDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ServiceDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.Fee field.
	''' </summary>
	Public Function GetFeeValue() As ColumnValue
		Return Me.GetValue(TableUtils.FeeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.Fee field.
	''' </summary>
	Public Function GetFeeFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.FeeColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.Fee field.
	''' </summary>
	Public Sub SetFeeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FeeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.Fee field.
	''' </summary>
	Public Sub SetFeeFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FeeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.Fee field.
	''' </summary>
	Public Sub SetFeeFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FeeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.Fee field.
	''' </summary>
	Public Sub SetFeeFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FeeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.Fee field.
	''' </summary>
	Public Sub SetFeeFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FeeColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.Units field.
	''' </summary>
	Public Function GetUnitsValue() As ColumnValue
		Return Me.GetValue(TableUtils.UnitsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.Units field.
	''' </summary>
	Public Function GetUnitsFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UnitsColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.Units field.
	''' </summary>
	Public Sub SetUnitsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UnitsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.Units field.
	''' </summary>
	Public Sub SetUnitsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UnitsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.Units field.
	''' </summary>
	Public Sub SetUnitsFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UnitsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.Units field.
	''' </summary>
	Public Sub SetUnitsFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UnitsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.Units field.
	''' </summary>
	Public Sub SetUnitsFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UnitsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.DurationID field.
	''' </summary>
	Public Function GetDurationIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DurationIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.DurationID field.
	''' </summary>
	Public Function GetDurationIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DurationIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.DurationID field.
	''' </summary>
	Public Sub SetDurationIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DurationIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.DurationID field.
	''' </summary>
	Public Sub SetDurationIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DurationIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.DurationID field.
	''' </summary>
	Public Sub SetDurationIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DurationIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.DurationID field.
	''' </summary>
	Public Sub SetDurationIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DurationIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.DurationID field.
	''' </summary>
	Public Sub SetDurationIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DurationIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.Duration field.
	''' </summary>
	Public Function GetDurationValue() As ColumnValue
		Return Me.GetValue(TableUtils.DurationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.Duration field.
	''' </summary>
	Public Function GetDurationFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DurationColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.Duration field.
	''' </summary>
	Public Sub SetDurationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DurationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.Duration field.
	''' </summary>
	Public Sub SetDurationFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DurationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceRank field.
	''' </summary>
	Public Function GetServiceRankValue() As ColumnValue
		Return Me.GetValue(TableUtils.ServiceRankColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.ServiceRank field.
	''' </summary>
	Public Function GetServiceRankFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ServiceRankColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceRank field.
	''' </summary>
	Public Sub SetServiceRankFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ServiceRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceRank field.
	''' </summary>
	Public Sub SetServiceRankFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ServiceRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceRank field.
	''' </summary>
	Public Sub SetServiceRankFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ServiceRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceRank field.
	''' </summary>
	Public Sub SetServiceRankFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ServiceRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.ServiceRank field.
	''' </summary>
	Public Sub SetServiceRankFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ServiceRankColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.SubscriptionYesNo field.
	''' </summary>
	Public Function GetSubscriptionYesNoValue() As ColumnValue
		Return Me.GetValue(TableUtils.SubscriptionYesNoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Services_.SubscriptionYesNo field.
	''' </summary>
	Public Function GetSubscriptionYesNoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SubscriptionYesNoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.SubscriptionYesNo field.
	''' </summary>
	Public Sub SetSubscriptionYesNoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SubscriptionYesNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Services_.SubscriptionYesNo field.
	''' </summary>
	Public Sub SetSubscriptionYesNoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SubscriptionYesNoColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.ServiceID field.
	''' </summary>
	Public Property ServiceID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ServiceIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ServiceIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ServiceIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ServiceIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ServiceIDDefault() As String
        Get
            Return TableUtils.ServiceIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.ServiceContextID field.
	''' </summary>
	Public Property ServiceContextID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ServiceContextIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ServiceContextIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ServiceContextIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ServiceContextIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ServiceContextIDDefault() As String
        Get
            Return TableUtils.ServiceContextIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.ServiceTypeID field.
	''' </summary>
	Public Property ServiceTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ServiceTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ServiceTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ServiceTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ServiceTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ServiceTypeIDDefault() As String
        Get
            Return TableUtils.ServiceTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.ServiceType field.
	''' </summary>
	Public Property ServiceType() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ServiceTypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ServiceTypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ServiceTypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ServiceTypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ServiceTypeDefault() As String
        Get
            Return TableUtils.ServiceTypeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.ServiceImage field.
	''' </summary>
	Public Property ServiceImage() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ServiceImageColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ServiceImageColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ServiceImageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ServiceImageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ServiceImageDefault() As String
        Get
            Return TableUtils.ServiceImageColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.FastportService field.
	''' </summary>
	Public Property FastportService() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FastportServiceColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FastportServiceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FastportServiceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FastportServiceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FastportServiceDefault() As String
        Get
            Return TableUtils.FastportServiceColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.ServiceRequired field.
	''' </summary>
	Public Property ServiceRequired() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ServiceRequiredColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ServiceRequiredColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ServiceRequiredSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ServiceRequiredColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ServiceRequiredDefault() As String
        Get
            Return TableUtils.ServiceRequiredColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.Cost field.
	''' </summary>
	Public Property Cost() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CostColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CostColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CostSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CostColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CostDefault() As String
        Get
            Return TableUtils.CostColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.ServiceName field.
	''' </summary>
	Public Property ServiceName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ServiceNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ServiceNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ServiceNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ServiceNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ServiceNameDefault() As String
        Get
            Return TableUtils.ServiceNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.ServiceDescription field.
	''' </summary>
	Public Property ServiceDescription() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ServiceDescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ServiceDescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ServiceDescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ServiceDescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ServiceDescriptionDefault() As String
        Get
            Return TableUtils.ServiceDescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.Fee field.
	''' </summary>
	Public Property Fee() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.FeeColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FeeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FeeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FeeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FeeDefault() As String
        Get
            Return TableUtils.FeeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.Units field.
	''' </summary>
	Public Property Units() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.UnitsColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UnitsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UnitsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UnitsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UnitsDefault() As String
        Get
            Return TableUtils.UnitsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.DurationID field.
	''' </summary>
	Public Property DurationID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DurationIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DurationIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DurationIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DurationIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DurationIDDefault() As String
        Get
            Return TableUtils.DurationIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.Duration field.
	''' </summary>
	Public Property Duration() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DurationColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DurationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DurationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DurationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DurationDefault() As String
        Get
            Return TableUtils.DurationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.ServiceRank field.
	''' </summary>
	Public Property ServiceRank() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ServiceRankColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ServiceRankColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ServiceRankSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ServiceRankColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ServiceRankDefault() As String
        Get
            Return TableUtils.ServiceRankColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Services_.SubscriptionYesNo field.
	''' </summary>
	Public Property SubscriptionYesNo() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SubscriptionYesNoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SubscriptionYesNoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SubscriptionYesNoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SubscriptionYesNoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SubscriptionYesNoDefault() As String
        Get
            Return TableUtils.SubscriptionYesNoColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
