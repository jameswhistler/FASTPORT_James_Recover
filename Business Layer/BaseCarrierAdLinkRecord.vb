' This class is "generated" and will be overwritten.
' Your customizations should be made in CarrierAdLinkRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="CarrierAdLinkRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="CarrierAdLinkTable"></see> class.
''' </remarks>
''' <seealso cref="CarrierAdLinkTable"></seealso>
''' <seealso cref="CarrierAdLinkRecord"></seealso>

<Serializable()> Public Class BaseCarrierAdLinkRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As CarrierAdLinkTable = CarrierAdLinkTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub CarrierAdLinkRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim CarrierAdLinkRec As CarrierAdLinkRecord = CType(sender,CarrierAdLinkRecord)
        Validate_Inserting()
        If Not CarrierAdLinkRec Is Nothing AndAlso Not CarrierAdLinkRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub CarrierAdLinkRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim CarrierAdLinkRec As CarrierAdLinkRecord = CType(sender,CarrierAdLinkRecord)
        Validate_Updating()
        If Not CarrierAdLinkRec Is Nothing AndAlso Not CarrierAdLinkRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub CarrierAdLinkRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim CarrierAdLinkRec As CarrierAdLinkRecord = CType(sender,CarrierAdLinkRecord)
        If Not CarrierAdLinkRec Is Nothing AndAlso Not CarrierAdLinkRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.LinkID field.
	''' </summary>
	Public Function GetLinkIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.LinkIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.LinkID field.
	''' </summary>
	Public Function GetLinkIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.LinkIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.AdID field.
	''' </summary>
	Public Function GetAdIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.AdID field.
	''' </summary>
	Public Function GetAdIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.AdID field.
	''' </summary>
	Public Sub SetAdIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AdIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.LinkName field.
	''' </summary>
	Public Function GetLinkNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.LinkNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.LinkName field.
	''' </summary>
	Public Function GetLinkNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.LinkNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.LinkName field.
	''' </summary>
	Public Sub SetLinkNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LinkNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.LinkName field.
	''' </summary>
	Public Sub SetLinkNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LinkNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.LinkNotes field.
	''' </summary>
	Public Function GetLinkNotesValue() As ColumnValue
		Return Me.GetValue(TableUtils.LinkNotesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.LinkNotes field.
	''' </summary>
	Public Function GetLinkNotesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.LinkNotesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.LinkNotes field.
	''' </summary>
	Public Sub SetLinkNotesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LinkNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.LinkNotes field.
	''' </summary>
	Public Sub SetLinkNotesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LinkNotesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.OrangeButton field.
	''' </summary>
	Public Function GetOrangeButtonValue() As ColumnValue
		Return Me.GetValue(TableUtils.OrangeButtonColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.OrangeButton field.
	''' </summary>
	Public Function GetOrangeButtonFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.OrangeButtonColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.OrangeButton field.
	''' </summary>
	Public Sub SetOrangeButtonFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OrangeButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.OrangeButton field.
	''' </summary>
	Public Sub SetOrangeButtonFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OrangeButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.OrangeButton field.
	''' </summary>
	Public Sub SetOrangeButtonFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OrangeButtonColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.BlueButton field.
	''' </summary>
	Public Function GetBlueButtonValue() As ColumnValue
		Return Me.GetValue(TableUtils.BlueButtonColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.BlueButton field.
	''' </summary>
	Public Function GetBlueButtonFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.BlueButtonColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.BlueButton field.
	''' </summary>
	Public Sub SetBlueButtonFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.BlueButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.BlueButton field.
	''' </summary>
	Public Sub SetBlueButtonFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.BlueButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.BlueButton field.
	''' </summary>
	Public Sub SetBlueButtonFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BlueButtonColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.LinkButton field.
	''' </summary>
	Public Function GetLinkButtonValue() As ColumnValue
		Return Me.GetValue(TableUtils.LinkButtonColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.LinkButton field.
	''' </summary>
	Public Function GetLinkButtonFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.LinkButtonColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.LinkButton field.
	''' </summary>
	Public Sub SetLinkButtonFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LinkButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.LinkButton field.
	''' </summary>
	Public Sub SetLinkButtonFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LinkButtonColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.LinkButton field.
	''' </summary>
	Public Sub SetLinkButtonFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LinkButtonColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.FullLink field.
	''' </summary>
	Public Function GetFullLinkValue() As ColumnValue
		Return Me.GetValue(TableUtils.FullLinkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.FullLink field.
	''' </summary>
	Public Function GetFullLinkFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FullLinkColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.FullLink field.
	''' </summary>
	Public Sub SetFullLinkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FullLinkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.FullLink field.
	''' </summary>
	Public Sub SetFullLinkFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FullLinkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.FullLink field.
	''' </summary>
	Public Sub SetFullLinkFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FullLinkColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.LinksHTML field.
	''' </summary>
	Public Function GetLinksHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.LinksHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.LinksHTML field.
	''' </summary>
	Public Function GetLinksHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.LinksHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.LinksHTML field.
	''' </summary>
	Public Sub SetLinksHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LinksHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.LinksHTML field.
	''' </summary>
	Public Sub SetLinksHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LinksHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.CreatedByID field.
	''' </summary>
	Public Function GetCreatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.CreatedByID field.
	''' </summary>
	Public Sub SetCreatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.CreatedAt field.
	''' </summary>
	Public Function GetCreatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CreatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.CreatedAt field.
	''' </summary>
	Public Sub SetCreatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedByIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.UpdatedByID field.
	''' </summary>
	Public Function GetUpdatedByIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UpdatedByIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.UpdatedByID field.
	''' </summary>
	Public Sub SetUpdatedByIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedByIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtValue() As ColumnValue
		Return Me.GetValue(TableUtils.UpdatedAtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CarrierAdLink_.UpdatedAt field.
	''' </summary>
	Public Function GetUpdatedAtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.UpdatedAtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UpdatedAtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CarrierAdLink_.UpdatedAt field.
	''' </summary>
	Public Sub SetUpdatedAtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UpdatedAtColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdLink_.LinkID field.
	''' </summary>
	Public Property LinkID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.LinkIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LinkIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LinkIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LinkIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LinkIDDefault() As String
        Get
            Return TableUtils.LinkIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdLink_.AdID field.
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
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdLink_.LinkName field.
	''' </summary>
	Public Property LinkName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.LinkNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.LinkNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LinkNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LinkNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LinkNameDefault() As String
        Get
            Return TableUtils.LinkNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdLink_.LinkNotes field.
	''' </summary>
	Public Property LinkNotes() As String
		Get 
			Return CType(Me.GetValue(TableUtils.LinkNotesColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.LinkNotesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LinkNotesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LinkNotesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LinkNotesDefault() As String
        Get
            Return TableUtils.LinkNotesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdLink_.OrangeButton field.
	''' </summary>
	Public Property OrangeButton() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.OrangeButtonColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OrangeButtonColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OrangeButtonSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OrangeButtonColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OrangeButtonDefault() As String
        Get
            Return TableUtils.OrangeButtonColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdLink_.BlueButton field.
	''' </summary>
	Public Property BlueButton() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.BlueButtonColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.BlueButtonColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property BlueButtonSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.BlueButtonColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property BlueButtonDefault() As String
        Get
            Return TableUtils.BlueButtonColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdLink_.LinkButton field.
	''' </summary>
	Public Property LinkButton() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.LinkButtonColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LinkButtonColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LinkButtonSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LinkButtonColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LinkButtonDefault() As String
        Get
            Return TableUtils.LinkButtonColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdLink_.FullLink field.
	''' </summary>
	Public Property FullLink() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FullLinkColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FullLinkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FullLinkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FullLinkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FullLinkDefault() As String
        Get
            Return TableUtils.FullLinkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdLink_.LinksHTML field.
	''' </summary>
	Public Property LinksHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.LinksHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.LinksHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LinksHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LinksHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LinksHTMLDefault() As String
        Get
            Return TableUtils.LinksHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdLink_.CreatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdLink_.CreatedAt field.
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
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdLink_.UpdatedByID field.
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
	''' This is a convenience property that provides direct access to the value of the record's CarrierAdLink_.UpdatedAt field.
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
