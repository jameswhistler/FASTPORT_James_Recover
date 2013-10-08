' This class is "generated" and will be overwritten.
' Your customizations should be made in CheckInRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="CheckInRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="CheckInTable"></see> class.
''' </remarks>
''' <seealso cref="CheckInTable"></seealso>
''' <seealso cref="CheckInRecord"></seealso>

<Serializable()> Public Class BaseCheckInRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As CheckInTable = CheckInTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub CheckInRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim CheckInRec As CheckInRecord = CType(sender,CheckInRecord)
        Validate_Inserting()
        If Not CheckInRec Is Nothing AndAlso Not CheckInRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub CheckInRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim CheckInRec As CheckInRecord = CType(sender,CheckInRecord)
        Validate_Updating()
        If Not CheckInRec Is Nothing AndAlso Not CheckInRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub CheckInRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim CheckInRec As CheckInRecord = CType(sender,CheckInRecord)
        If Not CheckInRec Is Nothing AndAlso Not CheckInRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.CheckInID field.
	''' </summary>
	Public Function GetCheckInIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CheckInIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.CheckInID field.
	''' </summary>
	Public Function GetCheckInIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CheckInIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.CheckInCatID field.
	''' </summary>
	Public Function GetCheckInCatIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CheckInCatIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.CheckInCatID field.
	''' </summary>
	Public Function GetCheckInCatIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CheckInCatIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CheckInCatID field.
	''' </summary>
	Public Sub SetCheckInCatIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CheckInCatIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CheckInCatID field.
	''' </summary>
	Public Sub SetCheckInCatIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CheckInCatIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CheckInCatID field.
	''' </summary>
	Public Sub SetCheckInCatIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CheckInCatIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CheckInCatID field.
	''' </summary>
	Public Sub SetCheckInCatIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CheckInCatIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CheckInCatID field.
	''' </summary>
	Public Sub SetCheckInCatIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CheckInCatIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.CityID field.
	''' </summary>
	Public Function GetCityIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CityIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.CityID field.
	''' </summary>
	Public Function GetCityIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CityIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CityID field.
	''' </summary>
	Public Sub SetCityIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CityID field.
	''' </summary>
	Public Sub SetCityIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CityID field.
	''' </summary>
	Public Sub SetCityIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CityID field.
	''' </summary>
	Public Sub SetCityIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CityIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CityID field.
	''' </summary>
	Public Sub SetCityIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CityIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.PointID field.
	''' </summary>
	Public Function GetPointIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PointIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.PointID field.
	''' </summary>
	Public Function GetPointIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PointIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PointID field.
	''' </summary>
	Public Sub SetPointIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PointIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PointID field.
	''' </summary>
	Public Sub SetPointIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PointIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PointID field.
	''' </summary>
	Public Sub SetPointIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PointIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PointID field.
	''' </summary>
	Public Sub SetPointIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PointIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PointID field.
	''' </summary>
	Public Sub SetPointIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PointIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.ReviewedPartyID field.
	''' </summary>
	Public Function GetReviewedPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReviewedPartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.ReviewedPartyID field.
	''' </summary>
	Public Function GetReviewedPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ReviewedPartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedPartyID field.
	''' </summary>
	Public Sub SetReviewedPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReviewedPartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedPartyID field.
	''' </summary>
	Public Sub SetReviewedPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ReviewedPartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedPartyID field.
	''' </summary>
	Public Sub SetReviewedPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReviewedPartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedPartyID field.
	''' </summary>
	Public Sub SetReviewedPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReviewedPartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedPartyID field.
	''' </summary>
	Public Sub SetReviewedPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReviewedPartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.ReviewedAdID field.
	''' </summary>
	Public Function GetReviewedAdIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReviewedAdIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.ReviewedAdID field.
	''' </summary>
	Public Function GetReviewedAdIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ReviewedAdIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedAdID field.
	''' </summary>
	Public Sub SetReviewedAdIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReviewedAdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedAdID field.
	''' </summary>
	Public Sub SetReviewedAdIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ReviewedAdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedAdID field.
	''' </summary>
	Public Sub SetReviewedAdIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReviewedAdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedAdID field.
	''' </summary>
	Public Sub SetReviewedAdIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReviewedAdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedAdID field.
	''' </summary>
	Public Sub SetReviewedAdIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReviewedAdIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.ReviewedPartyExperienceID field.
	''' </summary>
	Public Function GetReviewedPartyExperienceIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReviewedPartyExperienceIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.ReviewedPartyExperienceID field.
	''' </summary>
	Public Function GetReviewedPartyExperienceIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ReviewedPartyExperienceIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedPartyExperienceID field.
	''' </summary>
	Public Sub SetReviewedPartyExperienceIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReviewedPartyExperienceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedPartyExperienceID field.
	''' </summary>
	Public Sub SetReviewedPartyExperienceIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ReviewedPartyExperienceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedPartyExperienceID field.
	''' </summary>
	Public Sub SetReviewedPartyExperienceIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReviewedPartyExperienceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedPartyExperienceID field.
	''' </summary>
	Public Sub SetReviewedPartyExperienceIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReviewedPartyExperienceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewedPartyExperienceID field.
	''' </summary>
	Public Sub SetReviewedPartyExperienceIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReviewedPartyExperienceIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.StatusSlider field.
	''' </summary>
	Public Function GetStatusSliderValue() As ColumnValue
		Return Me.GetValue(TableUtils.StatusSliderColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.StatusSlider field.
	''' </summary>
	Public Function GetStatusSliderFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.StatusSliderColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.StatusSlider field.
	''' </summary>
	Public Sub SetStatusSliderFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StatusSliderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.StatusSlider field.
	''' </summary>
	Public Sub SetStatusSliderFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.StatusSliderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.StatusSlider field.
	''' </summary>
	Public Sub SetStatusSliderFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StatusSliderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.StatusSlider field.
	''' </summary>
	Public Sub SetStatusSliderFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StatusSliderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.StatusSlider field.
	''' </summary>
	Public Sub SetStatusSliderFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StatusSliderColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.FavoriteItem field.
	''' </summary>
	Public Function GetFavoriteItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FavoriteItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.FavoriteItem field.
	''' </summary>
	Public Function GetFavoriteItemFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FavoriteItemColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.FavoriteItem field.
	''' </summary>
	Public Sub SetFavoriteItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FavoriteItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.FavoriteItem field.
	''' </summary>
	Public Sub SetFavoriteItemFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FavoriteItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.FavoriteItem field.
	''' </summary>
	Public Sub SetFavoriteItemFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FavoriteItemColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.HideItem field.
	''' </summary>
	Public Function GetHideItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.HideItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.HideItem field.
	''' </summary>
	Public Function GetHideItemFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.HideItemColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.HideItem field.
	''' </summary>
	Public Sub SetHideItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HideItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.HideItem field.
	''' </summary>
	Public Sub SetHideItemFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HideItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.HideItem field.
	''' </summary>
	Public Sub SetHideItemFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HideItemColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.ThumbsUp field.
	''' </summary>
	Public Function GetThumbsUpValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThumbsUpColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.ThumbsUp field.
	''' </summary>
	Public Function GetThumbsUpFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.ThumbsUpColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ThumbsUp field.
	''' </summary>
	Public Sub SetThumbsUpFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThumbsUpColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ThumbsUp field.
	''' </summary>
	Public Sub SetThumbsUpFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThumbsUpColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ThumbsUp field.
	''' </summary>
	Public Sub SetThumbsUpFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThumbsUpColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.ThumbHits field.
	''' </summary>
	Public Function GetThumbHitsValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThumbHitsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.ThumbHits field.
	''' </summary>
	Public Function GetThumbHitsFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ThumbHitsColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ThumbHits field.
	''' </summary>
	Public Sub SetThumbHitsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThumbHitsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ThumbHits field.
	''' </summary>
	Public Sub SetThumbHitsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThumbHitsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ThumbHits field.
	''' </summary>
	Public Sub SetThumbHitsFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThumbHitsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ThumbHits field.
	''' </summary>
	Public Sub SetThumbHitsFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThumbHitsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ThumbHits field.
	''' </summary>
	Public Sub SetThumbHitsFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThumbHitsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.ReviewStars field.
	''' </summary>
	Public Function GetReviewStarsValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReviewStarsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.ReviewStars field.
	''' </summary>
	Public Function GetReviewStarsFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.ReviewStarsColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewStars field.
	''' </summary>
	Public Sub SetReviewStarsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReviewStarsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewStars field.
	''' </summary>
	Public Sub SetReviewStarsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ReviewStarsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewStars field.
	''' </summary>
	Public Sub SetReviewStarsFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReviewStarsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewStars field.
	''' </summary>
	Public Sub SetReviewStarsFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReviewStarsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.ReviewStars field.
	''' </summary>
	Public Sub SetReviewStarsFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReviewStarsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.IdleAIR field.
	''' </summary>
	Public Function GetIdleAIRValue() As ColumnValue
		Return Me.GetValue(TableUtils.IdleAIRColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.IdleAIR field.
	''' </summary>
	Public Function GetIdleAIRFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.IdleAIRColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.IdleAIR field.
	''' </summary>
	Public Sub SetIdleAIRFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IdleAIRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.IdleAIR field.
	''' </summary>
	Public Sub SetIdleAIRFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IdleAIRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.IdleAIR field.
	''' </summary>
	Public Sub SetIdleAIRFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IdleAIRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.IdleAIR field.
	''' </summary>
	Public Sub SetIdleAIRFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IdleAIRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.IdleAIR field.
	''' </summary>
	Public Sub SetIdleAIRFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IdleAIRColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.CompleteAt field.
	''' </summary>
	Public Function GetCompleteAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CompleteAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.CompleteAt field.
	''' </summary>
	Public Function GetCompleteAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CompleteAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CompleteAt field.
	''' </summary>
	Public Sub SetCompleteAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CompleteAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CompleteAt field.
	''' </summary>
	Public Sub SetCompleteAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CompleteAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CompleteAt field.
	''' </summary>
	Public Sub SetCompleteAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompleteAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.CheckInNotes field.
	''' </summary>
	Public Function GetCheckInNotesValue() As ColumnValue
		Return Me.GetValue(TableUtils.CheckInNotesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.CheckInNotes field.
	''' </summary>
	Public Function GetCheckInNotesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CheckInNotesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CheckInNotes field.
	''' </summary>
	Public Sub SetCheckInNotesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CheckInNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CheckInNotes field.
	''' </summary>
	Public Sub SetCheckInNotesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CheckInNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.InstanceID field.
	''' </summary>
	Public Function GetInstanceIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.InstanceIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.InstanceID field.
	''' </summary>
	Public Function GetInstanceIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.InstanceIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.InstanceID field.
	''' </summary>
	Public Sub SetInstanceIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.InstanceIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.PosLat field.
	''' </summary>
	Public Function GetPosLatValue() As ColumnValue
		Return Me.GetValue(TableUtils.PosLatColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.PosLat field.
	''' </summary>
	Public Function GetPosLatFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.PosLatColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PosLat field.
	''' </summary>
	Public Sub SetPosLatFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PosLatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PosLat field.
	''' </summary>
	Public Sub SetPosLatFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PosLatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PosLat field.
	''' </summary>
	Public Sub SetPosLatFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PosLatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PosLat field.
	''' </summary>
	Public Sub SetPosLatFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PosLatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PosLat field.
	''' </summary>
	Public Sub SetPosLatFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PosLatColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.PosLong field.
	''' </summary>
	Public Function GetPosLongValue() As ColumnValue
		Return Me.GetValue(TableUtils.PosLongColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.PosLong field.
	''' </summary>
	Public Function GetPosLongFieldValue() As Double
		Return CType(Me.GetValue(TableUtils.PosLongColumn).ToDouble(), Double)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PosLong field.
	''' </summary>
	Public Sub SetPosLongFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PosLongColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PosLong field.
	''' </summary>
	Public Sub SetPosLongFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PosLongColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PosLong field.
	''' </summary>
	Public Sub SetPosLongFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PosLongColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PosLong field.
	''' </summary>
	Public Sub SetPosLongFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PosLongColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.PosLong field.
	''' </summary>
	Public Sub SetPosLongFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PosLongColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CheckIn_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CheckIn_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.CheckInID field.
	''' </summary>
	Public Property CheckInID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CheckInIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CheckInIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CheckInIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CheckInIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CheckInIDDefault() As String
        Get
            Return TableUtils.CheckInIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.CheckInCatID field.
	''' </summary>
	Public Property CheckInCatID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CheckInCatIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CheckInCatIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CheckInCatIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CheckInCatIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CheckInCatIDDefault() As String
        Get
            Return TableUtils.CheckInCatIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.CityID field.
	''' </summary>
	Public Property CityID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CityIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CityIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CityIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CityIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CityIDDefault() As String
        Get
            Return TableUtils.CityIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.PointID field.
	''' </summary>
	Public Property PointID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PointIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PointIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PointIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PointIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PointIDDefault() As String
        Get
            Return TableUtils.PointIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.ReviewedPartyID field.
	''' </summary>
	Public Property ReviewedPartyID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ReviewedPartyIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ReviewedPartyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReviewedPartyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReviewedPartyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReviewedPartyIDDefault() As String
        Get
            Return TableUtils.ReviewedPartyIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.ReviewedAdID field.
	''' </summary>
	Public Property ReviewedAdID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ReviewedAdIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ReviewedAdIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReviewedAdIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReviewedAdIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReviewedAdIDDefault() As String
        Get
            Return TableUtils.ReviewedAdIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.ReviewedPartyExperienceID field.
	''' </summary>
	Public Property ReviewedPartyExperienceID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ReviewedPartyExperienceIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ReviewedPartyExperienceIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReviewedPartyExperienceIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReviewedPartyExperienceIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReviewedPartyExperienceIDDefault() As String
        Get
            Return TableUtils.ReviewedPartyExperienceIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.StatusSlider field.
	''' </summary>
	Public Property StatusSlider() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.StatusSliderColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.StatusSliderColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property StatusSliderSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.StatusSliderColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property StatusSliderDefault() As String
        Get
            Return TableUtils.StatusSliderColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.FavoriteItem field.
	''' </summary>
	Public Property FavoriteItem() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FavoriteItemColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FavoriteItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FavoriteItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FavoriteItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FavoriteItemDefault() As String
        Get
            Return TableUtils.FavoriteItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.HideItem field.
	''' </summary>
	Public Property HideItem() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.HideItemColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HideItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HideItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HideItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HideItemDefault() As String
        Get
            Return TableUtils.HideItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.ThumbsUp field.
	''' </summary>
	Public Property ThumbsUp() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.ThumbsUpColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThumbsUpColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThumbsUpSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThumbsUpColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThumbsUpDefault() As String
        Get
            Return TableUtils.ThumbsUpColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.ThumbHits field.
	''' </summary>
	Public Property ThumbHits() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ThumbHitsColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThumbHitsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThumbHitsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThumbHitsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThumbHitsDefault() As String
        Get
            Return TableUtils.ThumbHitsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.ReviewStars field.
	''' </summary>
	Public Property ReviewStars() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.ReviewStarsColumn).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ReviewStarsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReviewStarsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReviewStarsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReviewStarsDefault() As String
        Get
            Return TableUtils.ReviewStarsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.IdleAIR field.
	''' </summary>
	Public Property IdleAIR() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.IdleAIRColumn).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IdleAIRColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IdleAIRSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IdleAIRColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IdleAIRDefault() As String
        Get
            Return TableUtils.IdleAIRColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.CompleteAt field.
	''' </summary>
	Public Property CompleteAt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.CompleteAtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CompleteAtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CompleteAtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CompleteAtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CompleteAtDefault() As String
        Get
            Return TableUtils.CompleteAtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.CheckInNotes field.
	''' </summary>
	Public Property CheckInNotes() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CheckInNotesColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CheckInNotesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CheckInNotesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CheckInNotesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CheckInNotesDefault() As String
        Get
            Return TableUtils.CheckInNotesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.InstanceID field.
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
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.PosLat field.
	''' </summary>
	Public Property PosLat() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.PosLatColumn).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PosLatColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PosLatSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PosLatColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PosLatDefault() As String
        Get
            Return TableUtils.PosLatColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.PosLong field.
	''' </summary>
	Public Property PosLong() As Double
		Get 
			Return CType(Me.GetValue(TableUtils.PosLongColumn).ToDouble(), Double)
		End Get
		Set (ByVal val As Double) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PosLongColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PosLongSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PosLongColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PosLongDefault() As String
        Get
            Return TableUtils.PosLongColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's CheckIn_.UpdatedAt field.
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
