' This class is "generated" and will be overwritten.
' Your customizations should be made in V_CarrierSimpleRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_CarrierSimpleRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_CarrierSimpleView"></see> class.
''' </remarks>
''' <seealso cref="V_CarrierSimpleView"></seealso>
''' <seealso cref="V_CarrierSimpleRecord"></seealso>

<Serializable()> Public Class BaseV_CarrierSimpleRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_CarrierSimpleView = V_CarrierSimpleView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_CarrierSimpleRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_CarrierSimpleRec As V_CarrierSimpleRecord = CType(sender,V_CarrierSimpleRecord)
        Validate_Inserting()
        If Not V_CarrierSimpleRec Is Nothing AndAlso Not V_CarrierSimpleRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_CarrierSimpleRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_CarrierSimpleRec As V_CarrierSimpleRecord = CType(sender,V_CarrierSimpleRecord)
        Validate_Updating()
        If Not V_CarrierSimpleRec Is Nothing AndAlso Not V_CarrierSimpleRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_CarrierSimpleRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_CarrierSimpleRec As V_CarrierSimpleRecord = CType(sender,V_CarrierSimpleRecord)
        If Not V_CarrierSimpleRec Is Nothing AndAlso Not V_CarrierSimpleRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.CarrierID field.
	''' </summary>
	Public Function GetCarrierIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.CarrierID field.
	''' </summary>
	Public Function GetCarrierIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CarrierIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.CarrierID field.
	''' </summary>
	Public Sub SetCarrierIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.Logo field.
	''' </summary>
	Public Function GetLogoValue() As ColumnValue
		Return Me.GetValue(TableUtils.LogoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.Logo field.
	''' </summary>
	Public Function GetLogoFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.LogoColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.Logo field.
	''' </summary>
	Public Sub SetLogoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LogoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.Logo field.
	''' </summary>
	Public Sub SetLogoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LogoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.Logo field.
	''' </summary>
	Public Sub SetLogoFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LogoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.MajorStickers field.
	''' </summary>
	Public Function GetMajorStickersValue() As ColumnValue
		Return Me.GetValue(TableUtils.MajorStickersColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.MajorStickers field.
	''' </summary>
	Public Function GetMajorStickersFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MajorStickersColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.MajorStickers field.
	''' </summary>
	Public Sub SetMajorStickersFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MajorStickersColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.MajorStickers field.
	''' </summary>
	Public Sub SetMajorStickersFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MajorStickersColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.MinorStickers field.
	''' </summary>
	Public Function GetMinorStickersValue() As ColumnValue
		Return Me.GetValue(TableUtils.MinorStickersColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.MinorStickers field.
	''' </summary>
	Public Function GetMinorStickersFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MinorStickersColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.MinorStickers field.
	''' </summary>
	Public Sub SetMinorStickersFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MinorStickersColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.MinorStickers field.
	''' </summary>
	Public Sub SetMinorStickersFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinorStickersColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.Carrier field.
	''' </summary>
	Public Function GetCarrierValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.Carrier field.
	''' </summary>
	Public Function GetCarrierFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CarrierColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.Carrier field.
	''' </summary>
	Public Sub SetCarrierFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CarrierColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.Carrier field.
	''' </summary>
	Public Sub SetCarrierFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.CarrierHTML field.
	''' </summary>
	Public Function GetCarrierHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.CarrierHTML field.
	''' </summary>
	Public Function GetCarrierHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CarrierHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.CarrierHTML field.
	''' </summary>
	Public Sub SetCarrierHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CarrierHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.CarrierHTML field.
	''' </summary>
	Public Sub SetCarrierHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.CarrierProfile field.
	''' </summary>
	Public Function GetCarrierProfileValue() As ColumnValue
		Return Me.GetValue(TableUtils.CarrierProfileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.CarrierProfile field.
	''' </summary>
	Public Function GetCarrierProfileFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CarrierProfileColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.CarrierProfile field.
	''' </summary>
	Public Sub SetCarrierProfileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CarrierProfileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.CarrierProfile field.
	''' </summary>
	Public Sub SetCarrierProfileFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CarrierProfileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.ShortStats field.
	''' </summary>
	Public Function GetShortStatsValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShortStatsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.ShortStats field.
	''' </summary>
	Public Function GetShortStatsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ShortStatsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.ShortStats field.
	''' </summary>
	Public Sub SetShortStatsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShortStatsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.ShortStats field.
	''' </summary>
	Public Sub SetShortStatsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShortStatsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.GeneralStats field.
	''' </summary>
	Public Function GetGeneralStatsValue() As ColumnValue
		Return Me.GetValue(TableUtils.GeneralStatsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.GeneralStats field.
	''' </summary>
	Public Function GetGeneralStatsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.GeneralStatsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.GeneralStats field.
	''' </summary>
	Public Sub SetGeneralStatsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GeneralStatsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.GeneralStats field.
	''' </summary>
	Public Sub SetGeneralStatsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GeneralStatsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.Name field.
	''' </summary>
	Public Function GetNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.Name field.
	''' </summary>
	Public Function GetNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.MCNumber field.
	''' </summary>
	Public Function GetMCNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.MCNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.MCNumber field.
	''' </summary>
	Public Function GetMCNumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MCNumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.MCNumber field.
	''' </summary>
	Public Sub SetMCNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MCNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.MCNumber field.
	''' </summary>
	Public Sub SetMCNumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MCNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.DOTNumber field.
	''' </summary>
	Public Function GetDOTNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.DOTNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.DOTNumber field.
	''' </summary>
	Public Function GetDOTNumberFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DOTNumberColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.DOTNumber field.
	''' </summary>
	Public Sub SetDOTNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DOTNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.DOTNumber field.
	''' </summary>
	Public Sub SetDOTNumberFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DOTNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.StripSearch field.
	''' </summary>
	Public Function GetStripSearchValue() As ColumnValue
		Return Me.GetValue(TableUtils.StripSearchColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_CarrierSimple_.StripSearch field.
	''' </summary>
	Public Function GetStripSearchFieldValue() As String
		Return CType(Me.GetValue(TableUtils.StripSearchColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.StripSearch field.
	''' </summary>
	Public Sub SetStripSearchFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StripSearchColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_CarrierSimple_.StripSearch field.
	''' </summary>
	Public Sub SetStripSearchFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StripSearchColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierSimple_.CarrierID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierSimple_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierSimple_.Logo field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierSimple_.MajorStickers field.
	''' </summary>
	Public Property MajorStickers() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MajorStickersColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MajorStickersColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MajorStickersSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MajorStickersColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MajorStickersDefault() As String
        Get
            Return TableUtils.MajorStickersColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierSimple_.MinorStickers field.
	''' </summary>
	Public Property MinorStickers() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MinorStickersColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MinorStickersColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MinorStickersSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MinorStickersColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MinorStickersDefault() As String
        Get
            Return TableUtils.MinorStickersColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierSimple_.Carrier field.
	''' </summary>
	Public Property Carrier() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CarrierColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CarrierColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CarrierSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CarrierColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CarrierDefault() As String
        Get
            Return TableUtils.CarrierColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierSimple_.CarrierHTML field.
	''' </summary>
	Public Property CarrierHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CarrierHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CarrierHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CarrierHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CarrierHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CarrierHTMLDefault() As String
        Get
            Return TableUtils.CarrierHTMLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierSimple_.CarrierProfile field.
	''' </summary>
	Public Property CarrierProfile() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CarrierProfileColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CarrierProfileColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CarrierProfileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CarrierProfileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CarrierProfileDefault() As String
        Get
            Return TableUtils.CarrierProfileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierSimple_.ShortStats field.
	''' </summary>
	Public Property ShortStats() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ShortStatsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ShortStatsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ShortStatsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ShortStatsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ShortStatsDefault() As String
        Get
            Return TableUtils.ShortStatsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierSimple_.GeneralStats field.
	''' </summary>
	Public Property GeneralStats() As String
		Get 
			Return CType(Me.GetValue(TableUtils.GeneralStatsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.GeneralStatsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GeneralStatsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GeneralStatsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GeneralStatsDefault() As String
        Get
            Return TableUtils.GeneralStatsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierSimple_.Name field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierSimple_.MCNumber field.
	''' </summary>
	Public Property MCNumber() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MCNumberColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MCNumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MCNumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MCNumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MCNumberDefault() As String
        Get
            Return TableUtils.MCNumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierSimple_.DOTNumber field.
	''' </summary>
	Public Property DOTNumber() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DOTNumberColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DOTNumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DOTNumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DOTNumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DOTNumberDefault() As String
        Get
            Return TableUtils.DOTNumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_CarrierSimple_.StripSearch field.
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



#End Region

End Class
End Namespace
