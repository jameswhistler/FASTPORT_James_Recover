' This class is "generated" and will be overwritten.
' Your customizations should be made in CarrierAdRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="CarrierAdRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="CarrierAdTable"></see> class.
''' </remarks>
''' <seealso cref="CarrierAdTable"></seealso>
''' <seealso cref="CarrierAdRecord"></seealso>

<Serializable()> Public Class BaseCarrierAdRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As CarrierAdTable = CarrierAdTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub CarrierAdRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim CarrierAdRec As CarrierAdRecord = CType(sender,CarrierAdRecord)
        Validate_Inserting()
        If Not CarrierAdRec Is Nothing AndAlso Not CarrierAdRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub CarrierAdRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim CarrierAdRec As CarrierAdRecord = CType(sender,CarrierAdRecord)
        Validate_Updating()
        If Not CarrierAdRec Is Nothing AndAlso Not CarrierAdRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub CarrierAdRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim CarrierAdRec As CarrierAdRecord = CType(sender,CarrierAdRecord)
        If Not CarrierAdRec Is Nothing AndAlso Not CarrierAdRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.AdID field.
	''' </summary>
	Public Function GetAdIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.AdID field.
	''' </summary>
	Public Function GetAdIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.CarrierID field.
	''' </summary>
	Public Function GetCarrierIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.CarrierID field.
	''' </summary>
	Public Function GetCarrierIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CarrierIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.AdTemplate field.
	''' </summary>
	Public Function GetAdTemplateValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdTemplateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.AdTemplate field.
	''' </summary>
	Public Function GetAdTemplateFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.AdTemplateColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.AdTemplate field.
	''' </summary>
	Public Sub SetAdTemplateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdTemplateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.AdTemplate field.
	''' </summary>
	Public Sub SetAdTemplateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AdTemplateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.AdTemplate field.
	''' </summary>
	Public Sub SetAdTemplateFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdTemplateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.AdName field.
	''' </summary>
	Public Function GetAdNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.AdName field.
	''' </summary>
	Public Function GetAdNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AdNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.AdName field.
	''' </summary>
	Public Sub SetAdNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.AdName field.
	''' </summary>
	Public Sub SetAdNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.TruckerTypeID field.
	''' </summary>
	Public Function GetTruckerTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TruckerTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.TruckerTypeID field.
	''' </summary>
	Public Function GetTruckerTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TruckerTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TruckerTypeID field.
	''' </summary>
	Public Sub SetTruckerTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TruckerTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TruckerTypeID field.
	''' </summary>
	Public Sub SetTruckerTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TruckerTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TruckerTypeID field.
	''' </summary>
	Public Sub SetTruckerTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TruckerTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TruckerTypeID field.
	''' </summary>
	Public Sub SetTruckerTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TruckerTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TruckerTypeID field.
	''' </summary>
	Public Sub SetTruckerTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TruckerTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.ShortDescription field.
	''' </summary>
	Public Function GetShortDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShortDescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.ShortDescription field.
	''' </summary>
	Public Function GetShortDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ShortDescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.ShortDescription field.
	''' </summary>
	Public Sub SetShortDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShortDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.ShortDescription field.
	''' </summary>
	Public Sub SetShortDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShortDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LongDescription field.
	''' </summary>
	Public Function GetLongDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.LongDescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LongDescription field.
	''' </summary>
	Public Function GetLongDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.LongDescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LongDescription field.
	''' </summary>
	Public Sub SetLongDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LongDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LongDescription field.
	''' </summary>
	Public Sub SetLongDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LongDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.RunOn field.
	''' </summary>
	Public Function GetRunOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.RunOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.RunOn field.
	''' </summary>
	Public Function GetRunOnFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.RunOnColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.RunOn field.
	''' </summary>
	Public Sub SetRunOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RunOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.RunOn field.
	''' </summary>
	Public Sub SetRunOnFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RunOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.RunOn field.
	''' </summary>
	Public Sub SetRunOnFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RunOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.ExpireOn field.
	''' </summary>
	Public Function GetExpireOnValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExpireOnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.ExpireOn field.
	''' </summary>
	Public Function GetExpireOnFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.ExpireOnColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.ExpireOn field.
	''' </summary>
	Public Sub SetExpireOnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExpireOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.ExpireOn field.
	''' </summary>
	Public Sub SetExpireOnFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExpireOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.ExpireOn field.
	''' </summary>
	Public Sub SetExpireOnFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExpireOnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByAge field.
	''' </summary>
	Public Function GetLimitByAgeValue() As ColumnValue
		Return Me.GetValue(TableUtils.LimitByAgeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByAge field.
	''' </summary>
	Public Function GetLimitByAgeFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.LimitByAgeColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByAge field.
	''' </summary>
	Public Sub SetLimitByAgeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LimitByAgeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByAge field.
	''' </summary>
	Public Sub SetLimitByAgeFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LimitByAgeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByAge field.
	''' </summary>
	Public Sub SetLimitByAgeFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LimitByAgeColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PositionsAvail field.
	''' </summary>
	Public Function GetPositionsAvailValue() As ColumnValue
		Return Me.GetValue(TableUtils.PositionsAvailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PositionsAvail field.
	''' </summary>
	Public Function GetPositionsAvailFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PositionsAvailColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PositionsAvail field.
	''' </summary>
	Public Sub SetPositionsAvailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PositionsAvailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PositionsAvail field.
	''' </summary>
	Public Sub SetPositionsAvailFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PositionsAvailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PositionsAvail field.
	''' </summary>
	Public Sub SetPositionsAvailFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PositionsAvailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PositionsAvail field.
	''' </summary>
	Public Sub SetPositionsAvailFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PositionsAvailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PositionsAvail field.
	''' </summary>
	Public Sub SetPositionsAvailFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PositionsAvailColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MinAge field.
	''' </summary>
	Public Function GetMinAgeValue() As ColumnValue
		Return Me.GetValue(TableUtils.MinAgeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MinAge field.
	''' </summary>
	Public Function GetMinAgeFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MinAgeColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinAge field.
	''' </summary>
	Public Sub SetMinAgeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MinAgeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinAge field.
	''' </summary>
	Public Sub SetMinAgeFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MinAgeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinAge field.
	''' </summary>
	Public Sub SetMinAgeFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinAgeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinAge field.
	''' </summary>
	Public Sub SetMinAgeFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinAgeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinAge field.
	''' </summary>
	Public Sub SetMinAgeFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinAgeColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.HideAd field.
	''' </summary>
	Public Function GetHideAdValue() As ColumnValue
		Return Me.GetValue(TableUtils.HideAdColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.HideAd field.
	''' </summary>
	Public Function GetHideAdFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.HideAdColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.HideAd field.
	''' </summary>
	Public Sub SetHideAdFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HideAdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.HideAd field.
	''' </summary>
	Public Sub SetHideAdFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HideAdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.HideAd field.
	''' </summary>
	Public Sub SetHideAdFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HideAdColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MapThumbnail field.
	''' </summary>
	Public Function GetMapThumbnailValue() As ColumnValue
		Return Me.GetValue(TableUtils.MapThumbnailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MapThumbnail field.
	''' </summary>
	Public Function GetMapThumbnailFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.MapThumbnailColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MapThumbnail field.
	''' </summary>
	Public Sub SetMapThumbnailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MapThumbnailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MapThumbnail field.
	''' </summary>
	Public Sub SetMapThumbnailFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MapThumbnailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MapThumbnail field.
	''' </summary>
	Public Sub SetMapThumbnailFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MapThumbnailColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PSPMaximum field.
	''' </summary>
	Public Function GetPSPMaximumValue() As ColumnValue
		Return Me.GetValue(TableUtils.PSPMaximumColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PSPMaximum field.
	''' </summary>
	Public Function GetPSPMaximumFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PSPMaximumColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PSPMaximum field.
	''' </summary>
	Public Sub SetPSPMaximumFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PSPMaximumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PSPMaximum field.
	''' </summary>
	Public Sub SetPSPMaximumFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PSPMaximumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PSPMaximum field.
	''' </summary>
	Public Sub SetPSPMaximumFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PSPMaximumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PSPMaximum field.
	''' </summary>
	Public Sub SetPSPMaximumFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PSPMaximumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PSPMaximum field.
	''' </summary>
	Public Sub SetPSPMaximumFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PSPMaximumColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByMajorAccidents field.
	''' </summary>
	Public Function GetLimitByMajorAccidentsValue() As ColumnValue
		Return Me.GetValue(TableUtils.LimitByMajorAccidentsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByMajorAccidents field.
	''' </summary>
	Public Function GetLimitByMajorAccidentsFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.LimitByMajorAccidentsColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByMajorAccidents field.
	''' </summary>
	Public Sub SetLimitByMajorAccidentsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LimitByMajorAccidentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByMajorAccidents field.
	''' </summary>
	Public Sub SetLimitByMajorAccidentsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LimitByMajorAccidentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByMajorAccidents field.
	''' </summary>
	Public Sub SetLimitByMajorAccidentsFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LimitByMajorAccidentsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MajorByID field.
	''' </summary>
	Public Function GetMajorByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.MajorByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MajorByID field.
	''' </summary>
	Public Function GetMajorByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MajorByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorByID field.
	''' </summary>
	Public Sub SetMajorByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MajorByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorByID field.
	''' </summary>
	Public Sub SetMajorByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MajorByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorByID field.
	''' </summary>
	Public Sub SetMajorByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MajorByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorByID field.
	''' </summary>
	Public Sub SetMajorByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MajorByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorByID field.
	''' </summary>
	Public Sub SetMajorByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MajorByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MajorCountID field.
	''' </summary>
	Public Function GetMajorCountIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.MajorCountIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MajorCountID field.
	''' </summary>
	Public Function GetMajorCountIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MajorCountIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorCountID field.
	''' </summary>
	Public Sub SetMajorCountIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MajorCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorCountID field.
	''' </summary>
	Public Sub SetMajorCountIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MajorCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorCountID field.
	''' </summary>
	Public Sub SetMajorCountIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MajorCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorCountID field.
	''' </summary>
	Public Sub SetMajorCountIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MajorCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorCountID field.
	''' </summary>
	Public Sub SetMajorCountIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MajorCountIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MajorMilesID field.
	''' </summary>
	Public Function GetMajorMilesIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.MajorMilesIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MajorMilesID field.
	''' </summary>
	Public Function GetMajorMilesIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MajorMilesIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorMilesID field.
	''' </summary>
	Public Sub SetMajorMilesIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MajorMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorMilesID field.
	''' </summary>
	Public Sub SetMajorMilesIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MajorMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorMilesID field.
	''' </summary>
	Public Sub SetMajorMilesIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MajorMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorMilesID field.
	''' </summary>
	Public Sub SetMajorMilesIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MajorMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorMilesID field.
	''' </summary>
	Public Sub SetMajorMilesIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MajorMilesIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MajorYearsID field.
	''' </summary>
	Public Function GetMajorYearsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.MajorYearsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MajorYearsID field.
	''' </summary>
	Public Function GetMajorYearsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MajorYearsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorYearsID field.
	''' </summary>
	Public Sub SetMajorYearsIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MajorYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorYearsID field.
	''' </summary>
	Public Sub SetMajorYearsIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MajorYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorYearsID field.
	''' </summary>
	Public Sub SetMajorYearsIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MajorYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorYearsID field.
	''' </summary>
	Public Sub SetMajorYearsIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MajorYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MajorYearsID field.
	''' </summary>
	Public Sub SetMajorYearsIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MajorYearsIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByMinorAccidents field.
	''' </summary>
	Public Function GetLimitByMinorAccidentsValue() As ColumnValue
		Return Me.GetValue(TableUtils.LimitByMinorAccidentsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByMinorAccidents field.
	''' </summary>
	Public Function GetLimitByMinorAccidentsFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.LimitByMinorAccidentsColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByMinorAccidents field.
	''' </summary>
	Public Sub SetLimitByMinorAccidentsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LimitByMinorAccidentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByMinorAccidents field.
	''' </summary>
	Public Sub SetLimitByMinorAccidentsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LimitByMinorAccidentsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByMinorAccidents field.
	''' </summary>
	Public Sub SetLimitByMinorAccidentsFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LimitByMinorAccidentsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MinorByID field.
	''' </summary>
	Public Function GetMinorByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.MinorByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MinorByID field.
	''' </summary>
	Public Function GetMinorByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MinorByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorByID field.
	''' </summary>
	Public Sub SetMinorByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MinorByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorByID field.
	''' </summary>
	Public Sub SetMinorByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MinorByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorByID field.
	''' </summary>
	Public Sub SetMinorByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinorByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorByID field.
	''' </summary>
	Public Sub SetMinorByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinorByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorByID field.
	''' </summary>
	Public Sub SetMinorByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinorByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MinorCountID field.
	''' </summary>
	Public Function GetMinorCountIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.MinorCountIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MinorCountID field.
	''' </summary>
	Public Function GetMinorCountIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MinorCountIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorCountID field.
	''' </summary>
	Public Sub SetMinorCountIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MinorCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorCountID field.
	''' </summary>
	Public Sub SetMinorCountIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MinorCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorCountID field.
	''' </summary>
	Public Sub SetMinorCountIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinorCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorCountID field.
	''' </summary>
	Public Sub SetMinorCountIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinorCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorCountID field.
	''' </summary>
	Public Sub SetMinorCountIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinorCountIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MinorMilesID field.
	''' </summary>
	Public Function GetMinorMilesIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.MinorMilesIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MinorMilesID field.
	''' </summary>
	Public Function GetMinorMilesIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MinorMilesIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorMilesID field.
	''' </summary>
	Public Sub SetMinorMilesIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MinorMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorMilesID field.
	''' </summary>
	Public Sub SetMinorMilesIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MinorMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorMilesID field.
	''' </summary>
	Public Sub SetMinorMilesIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinorMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorMilesID field.
	''' </summary>
	Public Sub SetMinorMilesIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinorMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorMilesID field.
	''' </summary>
	Public Sub SetMinorMilesIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinorMilesIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MinorYearsID field.
	''' </summary>
	Public Function GetMinorYearsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.MinorYearsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.MinorYearsID field.
	''' </summary>
	Public Function GetMinorYearsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MinorYearsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorYearsID field.
	''' </summary>
	Public Sub SetMinorYearsIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MinorYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorYearsID field.
	''' </summary>
	Public Sub SetMinorYearsIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MinorYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorYearsID field.
	''' </summary>
	Public Sub SetMinorYearsIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinorYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorYearsID field.
	''' </summary>
	Public Sub SetMinorYearsIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinorYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.MinorYearsID field.
	''' </summary>
	Public Sub SetMinorYearsIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinorYearsIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByTickets field.
	''' </summary>
	Public Function GetLimitByTicketsValue() As ColumnValue
		Return Me.GetValue(TableUtils.LimitByTicketsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByTickets field.
	''' </summary>
	Public Function GetLimitByTicketsFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.LimitByTicketsColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByTickets field.
	''' </summary>
	Public Sub SetLimitByTicketsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LimitByTicketsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByTickets field.
	''' </summary>
	Public Sub SetLimitByTicketsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LimitByTicketsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByTickets field.
	''' </summary>
	Public Sub SetLimitByTicketsFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LimitByTicketsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.TicketsByID field.
	''' </summary>
	Public Function GetTicketsByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TicketsByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.TicketsByID field.
	''' </summary>
	Public Function GetTicketsByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TicketsByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketsByID field.
	''' </summary>
	Public Sub SetTicketsByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TicketsByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketsByID field.
	''' </summary>
	Public Sub SetTicketsByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TicketsByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketsByID field.
	''' </summary>
	Public Sub SetTicketsByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketsByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketsByID field.
	''' </summary>
	Public Sub SetTicketsByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketsByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketsByID field.
	''' </summary>
	Public Sub SetTicketsByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketsByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.TicketCountID field.
	''' </summary>
	Public Function GetTicketCountIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TicketCountIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.TicketCountID field.
	''' </summary>
	Public Function GetTicketCountIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TicketCountIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketCountID field.
	''' </summary>
	Public Sub SetTicketCountIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TicketCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketCountID field.
	''' </summary>
	Public Sub SetTicketCountIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TicketCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketCountID field.
	''' </summary>
	Public Sub SetTicketCountIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketCountID field.
	''' </summary>
	Public Sub SetTicketCountIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketCountID field.
	''' </summary>
	Public Sub SetTicketCountIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketCountIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.TicketMilesID field.
	''' </summary>
	Public Function GetTicketMilesIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TicketMilesIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.TicketMilesID field.
	''' </summary>
	Public Function GetTicketMilesIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TicketMilesIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketMilesID field.
	''' </summary>
	Public Sub SetTicketMilesIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TicketMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketMilesID field.
	''' </summary>
	Public Sub SetTicketMilesIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TicketMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketMilesID field.
	''' </summary>
	Public Sub SetTicketMilesIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketMilesID field.
	''' </summary>
	Public Sub SetTicketMilesIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketMilesID field.
	''' </summary>
	Public Sub SetTicketMilesIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketMilesIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.TicketYearsID field.
	''' </summary>
	Public Function GetTicketYearsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.TicketYearsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.TicketYearsID field.
	''' </summary>
	Public Function GetTicketYearsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TicketYearsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketYearsID field.
	''' </summary>
	Public Sub SetTicketYearsIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TicketYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketYearsID field.
	''' </summary>
	Public Sub SetTicketYearsIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TicketYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketYearsID field.
	''' </summary>
	Public Sub SetTicketYearsIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketYearsID field.
	''' </summary>
	Public Sub SetTicketYearsIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.TicketYearsID field.
	''' </summary>
	Public Sub SetTicketYearsIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TicketYearsIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitBySeriousTickets field.
	''' </summary>
	Public Function GetLimitBySeriousTicketsValue() As ColumnValue
		Return Me.GetValue(TableUtils.LimitBySeriousTicketsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitBySeriousTickets field.
	''' </summary>
	Public Function GetLimitBySeriousTicketsFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.LimitBySeriousTicketsColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitBySeriousTickets field.
	''' </summary>
	Public Sub SetLimitBySeriousTicketsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LimitBySeriousTicketsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitBySeriousTickets field.
	''' </summary>
	Public Sub SetLimitBySeriousTicketsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LimitBySeriousTicketsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitBySeriousTickets field.
	''' </summary>
	Public Sub SetLimitBySeriousTicketsFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LimitBySeriousTicketsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.SeriousByID field.
	''' </summary>
	Public Function GetSeriousByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeriousByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.SeriousByID field.
	''' </summary>
	Public Function GetSeriousByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SeriousByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousByID field.
	''' </summary>
	Public Sub SetSeriousByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeriousByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousByID field.
	''' </summary>
	Public Sub SetSeriousByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SeriousByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousByID field.
	''' </summary>
	Public Sub SetSeriousByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeriousByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousByID field.
	''' </summary>
	Public Sub SetSeriousByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeriousByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousByID field.
	''' </summary>
	Public Sub SetSeriousByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeriousByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.SeriousCountID field.
	''' </summary>
	Public Function GetSeriousCountIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeriousCountIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.SeriousCountID field.
	''' </summary>
	Public Function GetSeriousCountIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SeriousCountIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousCountID field.
	''' </summary>
	Public Sub SetSeriousCountIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeriousCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousCountID field.
	''' </summary>
	Public Sub SetSeriousCountIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SeriousCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousCountID field.
	''' </summary>
	Public Sub SetSeriousCountIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeriousCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousCountID field.
	''' </summary>
	Public Sub SetSeriousCountIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeriousCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousCountID field.
	''' </summary>
	Public Sub SetSeriousCountIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeriousCountIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.SeriousMilesID field.
	''' </summary>
	Public Function GetSeriousMilesIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeriousMilesIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.SeriousMilesID field.
	''' </summary>
	Public Function GetSeriousMilesIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SeriousMilesIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousMilesID field.
	''' </summary>
	Public Sub SetSeriousMilesIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeriousMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousMilesID field.
	''' </summary>
	Public Sub SetSeriousMilesIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SeriousMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousMilesID field.
	''' </summary>
	Public Sub SetSeriousMilesIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeriousMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousMilesID field.
	''' </summary>
	Public Sub SetSeriousMilesIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeriousMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousMilesID field.
	''' </summary>
	Public Sub SetSeriousMilesIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeriousMilesIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.SeriousYearsID field.
	''' </summary>
	Public Function GetSeriousYearsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SeriousYearsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.SeriousYearsID field.
	''' </summary>
	Public Function GetSeriousYearsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SeriousYearsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousYearsID field.
	''' </summary>
	Public Sub SetSeriousYearsIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SeriousYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousYearsID field.
	''' </summary>
	Public Sub SetSeriousYearsIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SeriousYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousYearsID field.
	''' </summary>
	Public Sub SetSeriousYearsIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeriousYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousYearsID field.
	''' </summary>
	Public Sub SetSeriousYearsIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeriousYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.SeriousYearsID field.
	''' </summary>
	Public Sub SetSeriousYearsIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SeriousYearsIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByFelonies field.
	''' </summary>
	Public Function GetLimitByFeloniesValue() As ColumnValue
		Return Me.GetValue(TableUtils.LimitByFeloniesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByFelonies field.
	''' </summary>
	Public Function GetLimitByFeloniesFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.LimitByFeloniesColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByFelonies field.
	''' </summary>
	Public Sub SetLimitByFeloniesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LimitByFeloniesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByFelonies field.
	''' </summary>
	Public Sub SetLimitByFeloniesFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LimitByFeloniesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByFelonies field.
	''' </summary>
	Public Sub SetLimitByFeloniesFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LimitByFeloniesColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FeloniesByID field.
	''' </summary>
	Public Function GetFeloniesByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FeloniesByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FeloniesByID field.
	''' </summary>
	Public Function GetFeloniesByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FeloniesByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FeloniesByID field.
	''' </summary>
	Public Sub SetFeloniesByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FeloniesByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FeloniesByID field.
	''' </summary>
	Public Sub SetFeloniesByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FeloniesByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FeloniesByID field.
	''' </summary>
	Public Sub SetFeloniesByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FeloniesByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FeloniesByID field.
	''' </summary>
	Public Sub SetFeloniesByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FeloniesByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FeloniesByID field.
	''' </summary>
	Public Sub SetFeloniesByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FeloniesByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FelonyCountID field.
	''' </summary>
	Public Function GetFelonyCountIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FelonyCountIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FelonyCountID field.
	''' </summary>
	Public Function GetFelonyCountIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FelonyCountIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyCountID field.
	''' </summary>
	Public Sub SetFelonyCountIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FelonyCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyCountID field.
	''' </summary>
	Public Sub SetFelonyCountIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FelonyCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyCountID field.
	''' </summary>
	Public Sub SetFelonyCountIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FelonyCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyCountID field.
	''' </summary>
	Public Sub SetFelonyCountIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FelonyCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyCountID field.
	''' </summary>
	Public Sub SetFelonyCountIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FelonyCountIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FelonyMilesID field.
	''' </summary>
	Public Function GetFelonyMilesIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FelonyMilesIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FelonyMilesID field.
	''' </summary>
	Public Function GetFelonyMilesIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FelonyMilesIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyMilesID field.
	''' </summary>
	Public Sub SetFelonyMilesIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FelonyMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyMilesID field.
	''' </summary>
	Public Sub SetFelonyMilesIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FelonyMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyMilesID field.
	''' </summary>
	Public Sub SetFelonyMilesIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FelonyMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyMilesID field.
	''' </summary>
	Public Sub SetFelonyMilesIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FelonyMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyMilesID field.
	''' </summary>
	Public Sub SetFelonyMilesIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FelonyMilesIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FelonyYearsID field.
	''' </summary>
	Public Function GetFelonyYearsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FelonyYearsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FelonyYearsID field.
	''' </summary>
	Public Function GetFelonyYearsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FelonyYearsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyYearsID field.
	''' </summary>
	Public Sub SetFelonyYearsIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FelonyYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyYearsID field.
	''' </summary>
	Public Sub SetFelonyYearsIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FelonyYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyYearsID field.
	''' </summary>
	Public Sub SetFelonyYearsIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FelonyYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyYearsID field.
	''' </summary>
	Public Sub SetFelonyYearsIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FelonyYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FelonyYearsID field.
	''' </summary>
	Public Sub SetFelonyYearsIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FelonyYearsIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByDrugConvictions field.
	''' </summary>
	Public Function GetLimitByDrugConvictionsValue() As ColumnValue
		Return Me.GetValue(TableUtils.LimitByDrugConvictionsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByDrugConvictions field.
	''' </summary>
	Public Function GetLimitByDrugConvictionsFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.LimitByDrugConvictionsColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByDrugConvictions field.
	''' </summary>
	Public Sub SetLimitByDrugConvictionsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LimitByDrugConvictionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByDrugConvictions field.
	''' </summary>
	Public Sub SetLimitByDrugConvictionsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LimitByDrugConvictionsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByDrugConvictions field.
	''' </summary>
	Public Sub SetLimitByDrugConvictionsFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LimitByDrugConvictionsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.DrugConvictionsByID field.
	''' </summary>
	Public Function GetDrugConvictionsByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DrugConvictionsByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.DrugConvictionsByID field.
	''' </summary>
	Public Function GetDrugConvictionsByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DrugConvictionsByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugConvictionsByID field.
	''' </summary>
	Public Sub SetDrugConvictionsByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DrugConvictionsByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugConvictionsByID field.
	''' </summary>
	Public Sub SetDrugConvictionsByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DrugConvictionsByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugConvictionsByID field.
	''' </summary>
	Public Sub SetDrugConvictionsByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DrugConvictionsByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugConvictionsByID field.
	''' </summary>
	Public Sub SetDrugConvictionsByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DrugConvictionsByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugConvictionsByID field.
	''' </summary>
	Public Sub SetDrugConvictionsByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DrugConvictionsByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.DrugCountID field.
	''' </summary>
	Public Function GetDrugCountIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DrugCountIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.DrugCountID field.
	''' </summary>
	Public Function GetDrugCountIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DrugCountIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugCountID field.
	''' </summary>
	Public Sub SetDrugCountIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DrugCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugCountID field.
	''' </summary>
	Public Sub SetDrugCountIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DrugCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugCountID field.
	''' </summary>
	Public Sub SetDrugCountIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DrugCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugCountID field.
	''' </summary>
	Public Sub SetDrugCountIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DrugCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugCountID field.
	''' </summary>
	Public Sub SetDrugCountIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DrugCountIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.DrugConvictionMilesID field.
	''' </summary>
	Public Function GetDrugConvictionMilesIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DrugConvictionMilesIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.DrugConvictionMilesID field.
	''' </summary>
	Public Function GetDrugConvictionMilesIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DrugConvictionMilesIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugConvictionMilesID field.
	''' </summary>
	Public Sub SetDrugConvictionMilesIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DrugConvictionMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugConvictionMilesID field.
	''' </summary>
	Public Sub SetDrugConvictionMilesIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DrugConvictionMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugConvictionMilesID field.
	''' </summary>
	Public Sub SetDrugConvictionMilesIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DrugConvictionMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugConvictionMilesID field.
	''' </summary>
	Public Sub SetDrugConvictionMilesIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DrugConvictionMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugConvictionMilesID field.
	''' </summary>
	Public Sub SetDrugConvictionMilesIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DrugConvictionMilesIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.DrugYearsID field.
	''' </summary>
	Public Function GetDrugYearsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DrugYearsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.DrugYearsID field.
	''' </summary>
	Public Function GetDrugYearsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DrugYearsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugYearsID field.
	''' </summary>
	Public Sub SetDrugYearsIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DrugYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugYearsID field.
	''' </summary>
	Public Sub SetDrugYearsIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DrugYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugYearsID field.
	''' </summary>
	Public Sub SetDrugYearsIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DrugYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugYearsID field.
	''' </summary>
	Public Sub SetDrugYearsIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DrugYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.DrugYearsID field.
	''' </summary>
	Public Sub SetDrugYearsIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DrugYearsIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByFailedTest field.
	''' </summary>
	Public Function GetLimitByFailedTestValue() As ColumnValue
		Return Me.GetValue(TableUtils.LimitByFailedTestColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByFailedTest field.
	''' </summary>
	Public Function GetLimitByFailedTestFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.LimitByFailedTestColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByFailedTest field.
	''' </summary>
	Public Sub SetLimitByFailedTestFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LimitByFailedTestColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByFailedTest field.
	''' </summary>
	Public Sub SetLimitByFailedTestFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LimitByFailedTestColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByFailedTest field.
	''' </summary>
	Public Sub SetLimitByFailedTestFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LimitByFailedTestColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FailedByID field.
	''' </summary>
	Public Function GetFailedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FailedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FailedByID field.
	''' </summary>
	Public Function GetFailedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FailedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedByID field.
	''' </summary>
	Public Sub SetFailedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FailedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedByID field.
	''' </summary>
	Public Sub SetFailedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FailedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedByID field.
	''' </summary>
	Public Sub SetFailedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FailedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedByID field.
	''' </summary>
	Public Sub SetFailedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FailedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedByID field.
	''' </summary>
	Public Sub SetFailedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FailedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FailedCountID field.
	''' </summary>
	Public Function GetFailedCountIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FailedCountIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FailedCountID field.
	''' </summary>
	Public Function GetFailedCountIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FailedCountIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedCountID field.
	''' </summary>
	Public Sub SetFailedCountIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FailedCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedCountID field.
	''' </summary>
	Public Sub SetFailedCountIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FailedCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedCountID field.
	''' </summary>
	Public Sub SetFailedCountIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FailedCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedCountID field.
	''' </summary>
	Public Sub SetFailedCountIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FailedCountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedCountID field.
	''' </summary>
	Public Sub SetFailedCountIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FailedCountIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FailedMilesID field.
	''' </summary>
	Public Function GetFailedMilesIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FailedMilesIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FailedMilesID field.
	''' </summary>
	Public Function GetFailedMilesIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FailedMilesIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedMilesID field.
	''' </summary>
	Public Sub SetFailedMilesIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FailedMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedMilesID field.
	''' </summary>
	Public Sub SetFailedMilesIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FailedMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedMilesID field.
	''' </summary>
	Public Sub SetFailedMilesIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FailedMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedMilesID field.
	''' </summary>
	Public Sub SetFailedMilesIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FailedMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedMilesID field.
	''' </summary>
	Public Sub SetFailedMilesIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FailedMilesIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FailedYearsID field.
	''' </summary>
	Public Function GetFailedYearsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FailedYearsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FailedYearsID field.
	''' </summary>
	Public Function GetFailedYearsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FailedYearsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedYearsID field.
	''' </summary>
	Public Sub SetFailedYearsIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FailedYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedYearsID field.
	''' </summary>
	Public Sub SetFailedYearsIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FailedYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedYearsID field.
	''' </summary>
	Public Sub SetFailedYearsIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FailedYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedYearsID field.
	''' </summary>
	Public Sub SetFailedYearsIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FailedYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FailedYearsID field.
	''' </summary>
	Public Sub SetFailedYearsIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FailedYearsIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByDUICommercial field.
	''' </summary>
	Public Function GetLimitByDUICommercialValue() As ColumnValue
		Return Me.GetValue(TableUtils.LimitByDUICommercialColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByDUICommercial field.
	''' </summary>
	Public Function GetLimitByDUICommercialFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.LimitByDUICommercialColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByDUICommercial field.
	''' </summary>
	Public Sub SetLimitByDUICommercialFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LimitByDUICommercialColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByDUICommercial field.
	''' </summary>
	Public Sub SetLimitByDUICommercialFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LimitByDUICommercialColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByDUICommercial field.
	''' </summary>
	Public Sub SetLimitByDUICommercialFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LimitByDUICommercialColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.CommDUIByID field.
	''' </summary>
	Public Function GetCommDUIByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CommDUIByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.CommDUIByID field.
	''' </summary>
	Public Function GetCommDUIByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CommDUIByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIByID field.
	''' </summary>
	Public Sub SetCommDUIByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CommDUIByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIByID field.
	''' </summary>
	Public Sub SetCommDUIByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CommDUIByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIByID field.
	''' </summary>
	Public Sub SetCommDUIByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CommDUIByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIByID field.
	''' </summary>
	Public Sub SetCommDUIByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CommDUIByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIByID field.
	''' </summary>
	Public Sub SetCommDUIByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CommDUIByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.CommDUICountID field.
	''' </summary>
	Public Function GetCommDUICountIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CommDUICountIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.CommDUICountID field.
	''' </summary>
	Public Function GetCommDUICountIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CommDUICountIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUICountID field.
	''' </summary>
	Public Sub SetCommDUICountIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CommDUICountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUICountID field.
	''' </summary>
	Public Sub SetCommDUICountIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CommDUICountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUICountID field.
	''' </summary>
	Public Sub SetCommDUICountIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CommDUICountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUICountID field.
	''' </summary>
	Public Sub SetCommDUICountIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CommDUICountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUICountID field.
	''' </summary>
	Public Sub SetCommDUICountIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CommDUICountIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.CommDUIMilesID field.
	''' </summary>
	Public Function GetCommDUIMilesIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CommDUIMilesIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.CommDUIMilesID field.
	''' </summary>
	Public Function GetCommDUIMilesIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CommDUIMilesIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIMilesID field.
	''' </summary>
	Public Sub SetCommDUIMilesIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CommDUIMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIMilesID field.
	''' </summary>
	Public Sub SetCommDUIMilesIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CommDUIMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIMilesID field.
	''' </summary>
	Public Sub SetCommDUIMilesIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CommDUIMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIMilesID field.
	''' </summary>
	Public Sub SetCommDUIMilesIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CommDUIMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIMilesID field.
	''' </summary>
	Public Sub SetCommDUIMilesIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CommDUIMilesIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.CommDUIYearsID field.
	''' </summary>
	Public Function GetCommDUIYearsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CommDUIYearsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.CommDUIYearsID field.
	''' </summary>
	Public Function GetCommDUIYearsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CommDUIYearsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIYearsID field.
	''' </summary>
	Public Sub SetCommDUIYearsIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CommDUIYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIYearsID field.
	''' </summary>
	Public Sub SetCommDUIYearsIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CommDUIYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIYearsID field.
	''' </summary>
	Public Sub SetCommDUIYearsIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CommDUIYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIYearsID field.
	''' </summary>
	Public Sub SetCommDUIYearsIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CommDUIYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.CommDUIYearsID field.
	''' </summary>
	Public Sub SetCommDUIYearsIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CommDUIYearsIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByDUIPersonal field.
	''' </summary>
	Public Function GetLimitByDUIPersonalValue() As ColumnValue
		Return Me.GetValue(TableUtils.LimitByDUIPersonalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LimitByDUIPersonal field.
	''' </summary>
	Public Function GetLimitByDUIPersonalFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.LimitByDUIPersonalColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByDUIPersonal field.
	''' </summary>
	Public Sub SetLimitByDUIPersonalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LimitByDUIPersonalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByDUIPersonal field.
	''' </summary>
	Public Sub SetLimitByDUIPersonalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LimitByDUIPersonalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LimitByDUIPersonal field.
	''' </summary>
	Public Sub SetLimitByDUIPersonalFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LimitByDUIPersonalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PersonalDUIByID field.
	''' </summary>
	Public Function GetPersonalDUIByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PersonalDUIByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PersonalDUIByID field.
	''' </summary>
	Public Function GetPersonalDUIByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PersonalDUIByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIByID field.
	''' </summary>
	Public Sub SetPersonalDUIByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PersonalDUIByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIByID field.
	''' </summary>
	Public Sub SetPersonalDUIByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PersonalDUIByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIByID field.
	''' </summary>
	Public Sub SetPersonalDUIByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PersonalDUIByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIByID field.
	''' </summary>
	Public Sub SetPersonalDUIByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PersonalDUIByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIByID field.
	''' </summary>
	Public Sub SetPersonalDUIByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PersonalDUIByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PersonalDUICountID field.
	''' </summary>
	Public Function GetPersonalDUICountIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PersonalDUICountIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PersonalDUICountID field.
	''' </summary>
	Public Function GetPersonalDUICountIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PersonalDUICountIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUICountID field.
	''' </summary>
	Public Sub SetPersonalDUICountIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PersonalDUICountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUICountID field.
	''' </summary>
	Public Sub SetPersonalDUICountIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PersonalDUICountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUICountID field.
	''' </summary>
	Public Sub SetPersonalDUICountIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PersonalDUICountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUICountID field.
	''' </summary>
	Public Sub SetPersonalDUICountIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PersonalDUICountIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUICountID field.
	''' </summary>
	Public Sub SetPersonalDUICountIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PersonalDUICountIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PersonalDUIMilesID field.
	''' </summary>
	Public Function GetPersonalDUIMilesIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PersonalDUIMilesIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PersonalDUIMilesID field.
	''' </summary>
	Public Function GetPersonalDUIMilesIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PersonalDUIMilesIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIMilesID field.
	''' </summary>
	Public Sub SetPersonalDUIMilesIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PersonalDUIMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIMilesID field.
	''' </summary>
	Public Sub SetPersonalDUIMilesIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PersonalDUIMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIMilesID field.
	''' </summary>
	Public Sub SetPersonalDUIMilesIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PersonalDUIMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIMilesID field.
	''' </summary>
	Public Sub SetPersonalDUIMilesIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PersonalDUIMilesIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIMilesID field.
	''' </summary>
	Public Sub SetPersonalDUIMilesIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PersonalDUIMilesIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PersonalDUIYearsID field.
	''' </summary>
	Public Function GetPersonalDUIYearsIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PersonalDUIYearsIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PersonalDUIYearsID field.
	''' </summary>
	Public Function GetPersonalDUIYearsIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PersonalDUIYearsIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIYearsID field.
	''' </summary>
	Public Sub SetPersonalDUIYearsIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PersonalDUIYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIYearsID field.
	''' </summary>
	Public Sub SetPersonalDUIYearsIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PersonalDUIYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIYearsID field.
	''' </summary>
	Public Sub SetPersonalDUIYearsIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PersonalDUIYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIYearsID field.
	''' </summary>
	Public Sub SetPersonalDUIYearsIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PersonalDUIYearsIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PersonalDUIYearsID field.
	''' </summary>
	Public Sub SetPersonalDUIYearsIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PersonalDUIYearsIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PayTypeID field.
	''' </summary>
	Public Function GetPayTypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PayTypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PayTypeID field.
	''' </summary>
	Public Function GetPayTypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PayTypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PayTypeID field.
	''' </summary>
	Public Sub SetPayTypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PayTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PayTypeID field.
	''' </summary>
	Public Sub SetPayTypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PayTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PayTypeID field.
	''' </summary>
	Public Sub SetPayTypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PayTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PayTypeID field.
	''' </summary>
	Public Sub SetPayTypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PayTypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PayTypeID field.
	''' </summary>
	Public Sub SetPayTypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PayTypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LineHaulPerc field.
	''' </summary>
	Public Function GetLineHaulPercValue() As ColumnValue
		Return Me.GetValue(TableUtils.LineHaulPercColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LineHaulPerc field.
	''' </summary>
	Public Function GetLineHaulPercFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.LineHaulPercColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LineHaulPerc field.
	''' </summary>
	Public Sub SetLineHaulPercFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LineHaulPercColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LineHaulPerc field.
	''' </summary>
	Public Sub SetLineHaulPercFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LineHaulPercColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LineHaulPerc field.
	''' </summary>
	Public Sub SetLineHaulPercFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LineHaulPercColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LineHaulPerc field.
	''' </summary>
	Public Sub SetLineHaulPercFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LineHaulPercColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LineHaulPerc field.
	''' </summary>
	Public Sub SetLineHaulPercFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LineHaulPercColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LoadedPerMile field.
	''' </summary>
	Public Function GetLoadedPerMileValue() As ColumnValue
		Return Me.GetValue(TableUtils.LoadedPerMileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LoadedPerMile field.
	''' </summary>
	Public Function GetLoadedPerMileFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.LoadedPerMileColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LoadedPerMile field.
	''' </summary>
	Public Sub SetLoadedPerMileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LoadedPerMileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LoadedPerMile field.
	''' </summary>
	Public Sub SetLoadedPerMileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LoadedPerMileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LoadedPerMile field.
	''' </summary>
	Public Sub SetLoadedPerMileFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LoadedPerMileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LoadedPerMile field.
	''' </summary>
	Public Sub SetLoadedPerMileFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LoadedPerMileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LoadedPerMile field.
	''' </summary>
	Public Sub SetLoadedPerMileFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LoadedPerMileColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.EmptyPerMile field.
	''' </summary>
	Public Function GetEmptyPerMileValue() As ColumnValue
		Return Me.GetValue(TableUtils.EmptyPerMileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.EmptyPerMile field.
	''' </summary>
	Public Function GetEmptyPerMileFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.EmptyPerMileColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.EmptyPerMile field.
	''' </summary>
	Public Sub SetEmptyPerMileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EmptyPerMileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.EmptyPerMile field.
	''' </summary>
	Public Sub SetEmptyPerMileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EmptyPerMileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.EmptyPerMile field.
	''' </summary>
	Public Sub SetEmptyPerMileFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmptyPerMileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.EmptyPerMile field.
	''' </summary>
	Public Sub SetEmptyPerMileFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmptyPerMileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.EmptyPerMile field.
	''' </summary>
	Public Sub SetEmptyPerMileFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EmptyPerMileColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.HourlyRate field.
	''' </summary>
	Public Function GetHourlyRateValue() As ColumnValue
		Return Me.GetValue(TableUtils.HourlyRateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.HourlyRate field.
	''' </summary>
	Public Function GetHourlyRateFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.HourlyRateColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.HourlyRate field.
	''' </summary>
	Public Sub SetHourlyRateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HourlyRateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.HourlyRate field.
	''' </summary>
	Public Sub SetHourlyRateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HourlyRateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.HourlyRate field.
	''' </summary>
	Public Sub SetHourlyRateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HourlyRateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.HourlyRate field.
	''' </summary>
	Public Sub SetHourlyRateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HourlyRateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.HourlyRate field.
	''' </summary>
	Public Sub SetHourlyRateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HourlyRateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.AvgPayPerWeek field.
	''' </summary>
	Public Function GetAvgPayPerWeekValue() As ColumnValue
		Return Me.GetValue(TableUtils.AvgPayPerWeekColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.AvgPayPerWeek field.
	''' </summary>
	Public Function GetAvgPayPerWeekFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.AvgPayPerWeekColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.AvgPayPerWeek field.
	''' </summary>
	Public Sub SetAvgPayPerWeekFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AvgPayPerWeekColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.AvgPayPerWeek field.
	''' </summary>
	Public Sub SetAvgPayPerWeekFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AvgPayPerWeekColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.AvgPayPerWeek field.
	''' </summary>
	Public Sub SetAvgPayPerWeekFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AvgPayPerWeekColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.AvgPayPerWeek field.
	''' </summary>
	Public Sub SetAvgPayPerWeekFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AvgPayPerWeekColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.AvgPayPerWeek field.
	''' </summary>
	Public Sub SetAvgPayPerWeekFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AvgPayPerWeekColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PayGuaranty field.
	''' </summary>
	Public Function GetPayGuarantyValue() As ColumnValue
		Return Me.GetValue(TableUtils.PayGuarantyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PayGuaranty field.
	''' </summary>
	Public Function GetPayGuarantyFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.PayGuarantyColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PayGuaranty field.
	''' </summary>
	Public Sub SetPayGuarantyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PayGuarantyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PayGuaranty field.
	''' </summary>
	Public Sub SetPayGuarantyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PayGuarantyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PayGuaranty field.
	''' </summary>
	Public Sub SetPayGuarantyFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PayGuarantyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FuelReimbursed field.
	''' </summary>
	Public Function GetFuelReimbursedValue() As ColumnValue
		Return Me.GetValue(TableUtils.FuelReimbursedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FuelReimbursed field.
	''' </summary>
	Public Function GetFuelReimbursedFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FuelReimbursedColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FuelReimbursed field.
	''' </summary>
	Public Sub SetFuelReimbursedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FuelReimbursedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FuelReimbursed field.
	''' </summary>
	Public Sub SetFuelReimbursedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FuelReimbursedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FuelReimbursed field.
	''' </summary>
	Public Sub SetFuelReimbursedFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FuelReimbursedColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.AllFuel field.
	''' </summary>
	Public Function GetAllFuelValue() As ColumnValue
		Return Me.GetValue(TableUtils.AllFuelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.AllFuel field.
	''' </summary>
	Public Function GetAllFuelFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.AllFuelColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.AllFuel field.
	''' </summary>
	Public Sub SetAllFuelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AllFuelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.AllFuel field.
	''' </summary>
	Public Sub SetAllFuelFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AllFuelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.AllFuel field.
	''' </summary>
	Public Sub SetAllFuelFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AllFuelColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FuelGuaranty field.
	''' </summary>
	Public Function GetFuelGuarantyValue() As ColumnValue
		Return Me.GetValue(TableUtils.FuelGuarantyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.FuelGuaranty field.
	''' </summary>
	Public Function GetFuelGuarantyFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FuelGuarantyColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FuelGuaranty field.
	''' </summary>
	Public Sub SetFuelGuarantyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FuelGuarantyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FuelGuaranty field.
	''' </summary>
	Public Sub SetFuelGuarantyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FuelGuarantyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.FuelGuaranty field.
	''' </summary>
	Public Sub SetFuelGuarantyFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FuelGuarantyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PayNotes field.
	''' </summary>
	Public Function GetPayNotesValue() As ColumnValue
		Return Me.GetValue(TableUtils.PayNotesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.PayNotes field.
	''' </summary>
	Public Function GetPayNotesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PayNotesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PayNotes field.
	''' </summary>
	Public Sub SetPayNotesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PayNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.PayNotes field.
	''' </summary>
	Public Sub SetPayNotesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PayNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.OtherRequirements field.
	''' </summary>
	Public Function GetOtherRequirementsValue() As ColumnValue
		Return Me.GetValue(TableUtils.OtherRequirementsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.OtherRequirements field.
	''' </summary>
	Public Function GetOtherRequirementsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.OtherRequirementsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.OtherRequirements field.
	''' </summary>
	Public Sub SetOtherRequirementsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OtherRequirementsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.OtherRequirements field.
	''' </summary>
	Public Sub SetOtherRequirementsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OtherRequirementsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LinksToOtherPostings field.
	''' </summary>
	Public Function GetLinksToOtherPostingsValue() As ColumnValue
		Return Me.GetValue(TableUtils.LinksToOtherPostingsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.LinksToOtherPostings field.
	''' </summary>
	Public Function GetLinksToOtherPostingsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.LinksToOtherPostingsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LinksToOtherPostings field.
	''' </summary>
	Public Sub SetLinksToOtherPostingsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LinksToOtherPostingsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.LinksToOtherPostings field.
	''' </summary>
	Public Sub SetLinksToOtherPostingsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LinksToOtherPostingsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.NoAd field.
	''' </summary>
	Public Function GetNoAdValue() As ColumnValue
		Return Me.GetValue(TableUtils.NoAdColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAd_.NoAd field.
	''' </summary>
	Public Function GetNoAdFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.NoAdColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.NoAd field.
	''' </summary>
	Public Sub SetNoAdFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NoAdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.NoAd field.
	''' </summary>
	Public Sub SetNoAdFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.NoAdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAd_.NoAd field.
	''' </summary>
	Public Sub SetNoAdFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NoAdColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.AdID field.
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
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.CarrierID field.
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
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.AdTemplate field.
	''' </summary>
	Public Property AdTemplate() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.AdTemplateColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AdTemplateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdTemplateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdTemplateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdTemplateDefault() As String
        Get
            Return TableUtils.AdTemplateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.AdName field.
	''' </summary>
	Public Property AdName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.AdNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.AdNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdNameDefault() As String
        Get
            Return TableUtils.AdNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.TruckerTypeID field.
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
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.ShortDescription field.
	''' </summary>
	Public Property ShortDescription() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ShortDescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ShortDescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ShortDescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ShortDescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ShortDescriptionDefault() As String
        Get
            Return TableUtils.ShortDescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.LongDescription field.
	''' </summary>
	Public Property LongDescription() As String
		Get 
			Return CType(Me.GetValue(TableUtils.LongDescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.LongDescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LongDescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LongDescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LongDescriptionDefault() As String
        Get
            Return TableUtils.LongDescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.RunOn field.
	''' </summary>
	Public Property RunOn() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.RunOnColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RunOnColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RunOnSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RunOnColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RunOnDefault() As String
        Get
            Return TableUtils.RunOnColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.ExpireOn field.
	''' </summary>
	Public Property ExpireOn() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.ExpireOnColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExpireOnColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExpireOnSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExpireOnColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExpireOnDefault() As String
        Get
            Return TableUtils.ExpireOnColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.LimitByAge field.
	''' </summary>
	Public Property LimitByAge() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.LimitByAgeColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LimitByAgeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LimitByAgeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LimitByAgeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LimitByAgeDefault() As String
        Get
            Return TableUtils.LimitByAgeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.PositionsAvail field.
	''' </summary>
	Public Property PositionsAvail() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PositionsAvailColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PositionsAvailColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PositionsAvailSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PositionsAvailColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PositionsAvailDefault() As String
        Get
            Return TableUtils.PositionsAvailColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.MinAge field.
	''' </summary>
	Public Property MinAge() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MinAgeColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MinAgeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MinAgeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MinAgeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MinAgeDefault() As String
        Get
            Return TableUtils.MinAgeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.HideAd field.
	''' </summary>
	Public Property HideAd() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.HideAdColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HideAdColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HideAdSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HideAdColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HideAdDefault() As String
        Get
            Return TableUtils.HideAdColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.MapThumbnail field.
	''' </summary>
	Public Property MapThumbnail() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.MapThumbnailColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MapThumbnailColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MapThumbnailSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MapThumbnailColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MapThumbnailDefault() As String
        Get
            Return TableUtils.MapThumbnailColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.PSPMaximum field.
	''' </summary>
	Public Property PSPMaximum() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PSPMaximumColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PSPMaximumColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PSPMaximumSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PSPMaximumColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PSPMaximumDefault() As String
        Get
            Return TableUtils.PSPMaximumColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.LimitByMajorAccidents field.
	''' </summary>
	Public Property LimitByMajorAccidents() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.LimitByMajorAccidentsColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LimitByMajorAccidentsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LimitByMajorAccidentsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LimitByMajorAccidentsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LimitByMajorAccidentsDefault() As String
        Get
            Return TableUtils.LimitByMajorAccidentsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.MajorByID field.
	''' </summary>
	Public Property MajorByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MajorByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MajorByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MajorByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MajorByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MajorByIDDefault() As String
        Get
            Return TableUtils.MajorByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.MajorCountID field.
	''' </summary>
	Public Property MajorCountID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MajorCountIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MajorCountIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MajorCountIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MajorCountIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MajorCountIDDefault() As String
        Get
            Return TableUtils.MajorCountIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.MajorMilesID field.
	''' </summary>
	Public Property MajorMilesID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MajorMilesIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MajorMilesIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MajorMilesIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MajorMilesIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MajorMilesIDDefault() As String
        Get
            Return TableUtils.MajorMilesIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.MajorYearsID field.
	''' </summary>
	Public Property MajorYearsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MajorYearsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MajorYearsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MajorYearsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MajorYearsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MajorYearsIDDefault() As String
        Get
            Return TableUtils.MajorYearsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.LimitByMinorAccidents field.
	''' </summary>
	Public Property LimitByMinorAccidents() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.LimitByMinorAccidentsColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LimitByMinorAccidentsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LimitByMinorAccidentsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LimitByMinorAccidentsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LimitByMinorAccidentsDefault() As String
        Get
            Return TableUtils.LimitByMinorAccidentsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.MinorByID field.
	''' </summary>
	Public Property MinorByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MinorByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MinorByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MinorByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MinorByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MinorByIDDefault() As String
        Get
            Return TableUtils.MinorByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.MinorCountID field.
	''' </summary>
	Public Property MinorCountID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MinorCountIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MinorCountIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MinorCountIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MinorCountIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MinorCountIDDefault() As String
        Get
            Return TableUtils.MinorCountIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.MinorMilesID field.
	''' </summary>
	Public Property MinorMilesID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MinorMilesIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MinorMilesIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MinorMilesIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MinorMilesIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MinorMilesIDDefault() As String
        Get
            Return TableUtils.MinorMilesIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.MinorYearsID field.
	''' </summary>
	Public Property MinorYearsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MinorYearsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MinorYearsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MinorYearsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MinorYearsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MinorYearsIDDefault() As String
        Get
            Return TableUtils.MinorYearsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.LimitByTickets field.
	''' </summary>
	Public Property LimitByTickets() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.LimitByTicketsColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LimitByTicketsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LimitByTicketsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LimitByTicketsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LimitByTicketsDefault() As String
        Get
            Return TableUtils.LimitByTicketsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.TicketsByID field.
	''' </summary>
	Public Property TicketsByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TicketsByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TicketsByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TicketsByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TicketsByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TicketsByIDDefault() As String
        Get
            Return TableUtils.TicketsByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.TicketCountID field.
	''' </summary>
	Public Property TicketCountID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TicketCountIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TicketCountIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TicketCountIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TicketCountIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TicketCountIDDefault() As String
        Get
            Return TableUtils.TicketCountIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.TicketMilesID field.
	''' </summary>
	Public Property TicketMilesID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TicketMilesIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TicketMilesIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TicketMilesIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TicketMilesIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TicketMilesIDDefault() As String
        Get
            Return TableUtils.TicketMilesIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.TicketYearsID field.
	''' </summary>
	Public Property TicketYearsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TicketYearsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TicketYearsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TicketYearsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TicketYearsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TicketYearsIDDefault() As String
        Get
            Return TableUtils.TicketYearsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.LimitBySeriousTickets field.
	''' </summary>
	Public Property LimitBySeriousTickets() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.LimitBySeriousTicketsColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LimitBySeriousTicketsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LimitBySeriousTicketsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LimitBySeriousTicketsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LimitBySeriousTicketsDefault() As String
        Get
            Return TableUtils.LimitBySeriousTicketsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.SeriousByID field.
	''' </summary>
	Public Property SeriousByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SeriousByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SeriousByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeriousByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeriousByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeriousByIDDefault() As String
        Get
            Return TableUtils.SeriousByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.SeriousCountID field.
	''' </summary>
	Public Property SeriousCountID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SeriousCountIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SeriousCountIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeriousCountIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeriousCountIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeriousCountIDDefault() As String
        Get
            Return TableUtils.SeriousCountIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.SeriousMilesID field.
	''' </summary>
	Public Property SeriousMilesID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SeriousMilesIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SeriousMilesIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeriousMilesIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeriousMilesIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeriousMilesIDDefault() As String
        Get
            Return TableUtils.SeriousMilesIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.SeriousYearsID field.
	''' </summary>
	Public Property SeriousYearsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SeriousYearsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SeriousYearsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SeriousYearsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SeriousYearsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SeriousYearsIDDefault() As String
        Get
            Return TableUtils.SeriousYearsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.LimitByFelonies field.
	''' </summary>
	Public Property LimitByFelonies() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.LimitByFeloniesColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LimitByFeloniesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LimitByFeloniesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LimitByFeloniesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LimitByFeloniesDefault() As String
        Get
            Return TableUtils.LimitByFeloniesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.FeloniesByID field.
	''' </summary>
	Public Property FeloniesByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FeloniesByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FeloniesByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FeloniesByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FeloniesByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FeloniesByIDDefault() As String
        Get
            Return TableUtils.FeloniesByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.FelonyCountID field.
	''' </summary>
	Public Property FelonyCountID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FelonyCountIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FelonyCountIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FelonyCountIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FelonyCountIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FelonyCountIDDefault() As String
        Get
            Return TableUtils.FelonyCountIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.FelonyMilesID field.
	''' </summary>
	Public Property FelonyMilesID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FelonyMilesIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FelonyMilesIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FelonyMilesIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FelonyMilesIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FelonyMilesIDDefault() As String
        Get
            Return TableUtils.FelonyMilesIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.FelonyYearsID field.
	''' </summary>
	Public Property FelonyYearsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FelonyYearsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FelonyYearsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FelonyYearsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FelonyYearsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FelonyYearsIDDefault() As String
        Get
            Return TableUtils.FelonyYearsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.LimitByDrugConvictions field.
	''' </summary>
	Public Property LimitByDrugConvictions() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.LimitByDrugConvictionsColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LimitByDrugConvictionsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LimitByDrugConvictionsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LimitByDrugConvictionsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LimitByDrugConvictionsDefault() As String
        Get
            Return TableUtils.LimitByDrugConvictionsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.DrugConvictionsByID field.
	''' </summary>
	Public Property DrugConvictionsByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DrugConvictionsByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DrugConvictionsByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DrugConvictionsByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DrugConvictionsByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DrugConvictionsByIDDefault() As String
        Get
            Return TableUtils.DrugConvictionsByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.DrugCountID field.
	''' </summary>
	Public Property DrugCountID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DrugCountIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DrugCountIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DrugCountIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DrugCountIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DrugCountIDDefault() As String
        Get
            Return TableUtils.DrugCountIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.DrugConvictionMilesID field.
	''' </summary>
	Public Property DrugConvictionMilesID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DrugConvictionMilesIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DrugConvictionMilesIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DrugConvictionMilesIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DrugConvictionMilesIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DrugConvictionMilesIDDefault() As String
        Get
            Return TableUtils.DrugConvictionMilesIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.DrugYearsID field.
	''' </summary>
	Public Property DrugYearsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DrugYearsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DrugYearsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DrugYearsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DrugYearsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DrugYearsIDDefault() As String
        Get
            Return TableUtils.DrugYearsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.LimitByFailedTest field.
	''' </summary>
	Public Property LimitByFailedTest() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.LimitByFailedTestColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LimitByFailedTestColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LimitByFailedTestSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LimitByFailedTestColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LimitByFailedTestDefault() As String
        Get
            Return TableUtils.LimitByFailedTestColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.FailedByID field.
	''' </summary>
	Public Property FailedByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FailedByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FailedByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FailedByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FailedByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FailedByIDDefault() As String
        Get
            Return TableUtils.FailedByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.FailedCountID field.
	''' </summary>
	Public Property FailedCountID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FailedCountIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FailedCountIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FailedCountIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FailedCountIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FailedCountIDDefault() As String
        Get
            Return TableUtils.FailedCountIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.FailedMilesID field.
	''' </summary>
	Public Property FailedMilesID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FailedMilesIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FailedMilesIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FailedMilesIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FailedMilesIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FailedMilesIDDefault() As String
        Get
            Return TableUtils.FailedMilesIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.FailedYearsID field.
	''' </summary>
	Public Property FailedYearsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FailedYearsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FailedYearsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FailedYearsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FailedYearsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FailedYearsIDDefault() As String
        Get
            Return TableUtils.FailedYearsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.LimitByDUICommercial field.
	''' </summary>
	Public Property LimitByDUICommercial() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.LimitByDUICommercialColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LimitByDUICommercialColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LimitByDUICommercialSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LimitByDUICommercialColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LimitByDUICommercialDefault() As String
        Get
            Return TableUtils.LimitByDUICommercialColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.CommDUIByID field.
	''' </summary>
	Public Property CommDUIByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CommDUIByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CommDUIByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CommDUIByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CommDUIByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CommDUIByIDDefault() As String
        Get
            Return TableUtils.CommDUIByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.CommDUICountID field.
	''' </summary>
	Public Property CommDUICountID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CommDUICountIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CommDUICountIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CommDUICountIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CommDUICountIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CommDUICountIDDefault() As String
        Get
            Return TableUtils.CommDUICountIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.CommDUIMilesID field.
	''' </summary>
	Public Property CommDUIMilesID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CommDUIMilesIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CommDUIMilesIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CommDUIMilesIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CommDUIMilesIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CommDUIMilesIDDefault() As String
        Get
            Return TableUtils.CommDUIMilesIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.CommDUIYearsID field.
	''' </summary>
	Public Property CommDUIYearsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CommDUIYearsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CommDUIYearsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CommDUIYearsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CommDUIYearsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CommDUIYearsIDDefault() As String
        Get
            Return TableUtils.CommDUIYearsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.LimitByDUIPersonal field.
	''' </summary>
	Public Property LimitByDUIPersonal() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.LimitByDUIPersonalColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LimitByDUIPersonalColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LimitByDUIPersonalSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LimitByDUIPersonalColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LimitByDUIPersonalDefault() As String
        Get
            Return TableUtils.LimitByDUIPersonalColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.PersonalDUIByID field.
	''' </summary>
	Public Property PersonalDUIByID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PersonalDUIByIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PersonalDUIByIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PersonalDUIByIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PersonalDUIByIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PersonalDUIByIDDefault() As String
        Get
            Return TableUtils.PersonalDUIByIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.PersonalDUICountID field.
	''' </summary>
	Public Property PersonalDUICountID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PersonalDUICountIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PersonalDUICountIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PersonalDUICountIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PersonalDUICountIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PersonalDUICountIDDefault() As String
        Get
            Return TableUtils.PersonalDUICountIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.PersonalDUIMilesID field.
	''' </summary>
	Public Property PersonalDUIMilesID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PersonalDUIMilesIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PersonalDUIMilesIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PersonalDUIMilesIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PersonalDUIMilesIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PersonalDUIMilesIDDefault() As String
        Get
            Return TableUtils.PersonalDUIMilesIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.PersonalDUIYearsID field.
	''' </summary>
	Public Property PersonalDUIYearsID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PersonalDUIYearsIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PersonalDUIYearsIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PersonalDUIYearsIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PersonalDUIYearsIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PersonalDUIYearsIDDefault() As String
        Get
            Return TableUtils.PersonalDUIYearsIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.PayTypeID field.
	''' </summary>
	Public Property PayTypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PayTypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PayTypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PayTypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PayTypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PayTypeIDDefault() As String
        Get
            Return TableUtils.PayTypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.LineHaulPerc field.
	''' </summary>
	Public Property LineHaulPerc() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.LineHaulPercColumn).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LineHaulPercColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LineHaulPercSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LineHaulPercColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LineHaulPercDefault() As String
        Get
            Return TableUtils.LineHaulPercColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.LoadedPerMile field.
	''' </summary>
	Public Property LoadedPerMile() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.LoadedPerMileColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LoadedPerMileColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LoadedPerMileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LoadedPerMileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LoadedPerMileDefault() As String
        Get
            Return TableUtils.LoadedPerMileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.EmptyPerMile field.
	''' </summary>
	Public Property EmptyPerMile() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.EmptyPerMileColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EmptyPerMileColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EmptyPerMileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EmptyPerMileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EmptyPerMileDefault() As String
        Get
            Return TableUtils.EmptyPerMileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.HourlyRate field.
	''' </summary>
	Public Property HourlyRate() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.HourlyRateColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HourlyRateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HourlyRateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HourlyRateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HourlyRateDefault() As String
        Get
            Return TableUtils.HourlyRateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.AvgPayPerWeek field.
	''' </summary>
	Public Property AvgPayPerWeek() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.AvgPayPerWeekColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AvgPayPerWeekColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AvgPayPerWeekSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AvgPayPerWeekColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AvgPayPerWeekDefault() As String
        Get
            Return TableUtils.AvgPayPerWeekColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.PayGuaranty field.
	''' </summary>
	Public Property PayGuaranty() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.PayGuarantyColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PayGuarantyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PayGuarantySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PayGuarantyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PayGuarantyDefault() As String
        Get
            Return TableUtils.PayGuarantyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.FuelReimbursed field.
	''' </summary>
	Public Property FuelReimbursed() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FuelReimbursedColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FuelReimbursedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FuelReimbursedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FuelReimbursedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FuelReimbursedDefault() As String
        Get
            Return TableUtils.FuelReimbursedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.AllFuel field.
	''' </summary>
	Public Property AllFuel() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.AllFuelColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AllFuelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AllFuelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AllFuelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AllFuelDefault() As String
        Get
            Return TableUtils.AllFuelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.FuelGuaranty field.
	''' </summary>
	Public Property FuelGuaranty() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FuelGuarantyColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FuelGuarantyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FuelGuarantySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FuelGuarantyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FuelGuarantyDefault() As String
        Get
            Return TableUtils.FuelGuarantyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.PayNotes field.
	''' </summary>
	Public Property PayNotes() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PayNotesColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PayNotesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PayNotesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PayNotesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PayNotesDefault() As String
        Get
            Return TableUtils.PayNotesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.OtherRequirements field.
	''' </summary>
	Public Property OtherRequirements() As String
		Get 
			Return CType(Me.GetValue(TableUtils.OtherRequirementsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.OtherRequirementsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OtherRequirementsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OtherRequirementsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OtherRequirementsDefault() As String
        Get
            Return TableUtils.OtherRequirementsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.LinksToOtherPostings field.
	''' </summary>
	Public Property LinksToOtherPostings() As String
		Get 
			Return CType(Me.GetValue(TableUtils.LinksToOtherPostingsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.LinksToOtherPostingsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LinksToOtherPostingsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LinksToOtherPostingsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LinksToOtherPostingsDefault() As String
        Get
            Return TableUtils.LinksToOtherPostingsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAd_.NoAd field.
	''' </summary>
	Public Property NoAd() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.NoAdColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.NoAdColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NoAdSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NoAdColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NoAdDefault() As String
        Get
            Return TableUtils.NoAdColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
