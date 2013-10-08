' This class is "generated" and will be overwritten.
' Your customizations should be made in V_PersonSnapshotRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_PersonSnapshotRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_PersonSnapshotView"></see> class.
''' </remarks>
''' <seealso cref="V_PersonSnapshotView"></seealso>
''' <seealso cref="V_PersonSnapshotRecord"></seealso>

<Serializable()> Public Class BaseV_PersonSnapshotRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_PersonSnapshotView = V_PersonSnapshotView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_PersonSnapshotRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_PersonSnapshotRec As V_PersonSnapshotRecord = CType(sender,V_PersonSnapshotRecord)
        Validate_Inserting()
        If Not V_PersonSnapshotRec Is Nothing AndAlso Not V_PersonSnapshotRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub V_PersonSnapshotRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim V_PersonSnapshotRec As V_PersonSnapshotRecord = CType(sender,V_PersonSnapshotRecord)
        Validate_Updating()
        If Not V_PersonSnapshotRec Is Nothing AndAlso Not V_PersonSnapshotRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_PersonSnapshotRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_PersonSnapshotRec As V_PersonSnapshotRecord = CType(sender,V_PersonSnapshotRecord)
        If Not V_PersonSnapshotRec Is Nothing AndAlso Not V_PersonSnapshotRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.FromPic field.
	''' </summary>
	Public Function GetFromPicValue() As ColumnValue
		Return Me.GetValue(TableUtils.FromPicColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.FromPic field.
	''' </summary>
	Public Function GetFromPicFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.FromPicColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.FromPic field.
	''' </summary>
	Public Sub SetFromPicFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FromPicColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.FromPic field.
	''' </summary>
	Public Sub SetFromPicFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FromPicColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.FromPic field.
	''' </summary>
	Public Sub SetFromPicFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FromPicColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.NameHTML field.
	''' </summary>
	Public Function GetNameHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.NameHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.NameHTML field.
	''' </summary>
	Public Function GetNameHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NameHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.NameHTML field.
	''' </summary>
	Public Sub SetNameHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NameHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.NameHTML field.
	''' </summary>
	Public Sub SetNameHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NameHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.MoreHTML field.
	''' </summary>
	Public Function GetMoreHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.MoreHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.MoreHTML field.
	''' </summary>
	Public Function GetMoreHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MoreHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.MoreHTML field.
	''' </summary>
	Public Sub SetMoreHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MoreHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.MoreHTML field.
	''' </summary>
	Public Sub SetMoreHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MoreHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.Details field.
	''' </summary>
	Public Function GetDetailsValue() As ColumnValue
		Return Me.GetValue(TableUtils.DetailsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.Details field.
	''' </summary>
	Public Function GetDetailsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DetailsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.Details field.
	''' </summary>
	Public Sub SetDetailsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DetailsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.Details field.
	''' </summary>
	Public Sub SetDetailsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DetailsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.ProfileSnippet field.
	''' </summary>
	Public Function GetProfileSnippetValue() As ColumnValue
		Return Me.GetValue(TableUtils.ProfileSnippetColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.ProfileSnippet field.
	''' </summary>
	Public Function GetProfileSnippetFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ProfileSnippetColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.ProfileSnippet field.
	''' </summary>
	Public Sub SetProfileSnippetFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ProfileSnippetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.ProfileSnippet field.
	''' </summary>
	Public Sub SetProfileSnippetFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProfileSnippetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.FullProfile field.
	''' </summary>
	Public Function GetFullProfileValue() As ColumnValue
		Return Me.GetValue(TableUtils.FullProfileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.FullProfile field.
	''' </summary>
	Public Function GetFullProfileFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FullProfileColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.FullProfile field.
	''' </summary>
	Public Sub SetFullProfileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FullProfileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.FullProfile field.
	''' </summary>
	Public Sub SetFullProfileFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FullProfileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.MajorStickers field.
	''' </summary>
	Public Function GetMajorStickersValue() As ColumnValue
		Return Me.GetValue(TableUtils.MajorStickersColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.MajorStickers field.
	''' </summary>
	Public Function GetMajorStickersFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MajorStickersColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.MajorStickers field.
	''' </summary>
	Public Sub SetMajorStickersFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MajorStickersColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.MajorStickers field.
	''' </summary>
	Public Sub SetMajorStickersFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MajorStickersColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.MinorStickers field.
	''' </summary>
	Public Function GetMinorStickersValue() As ColumnValue
		Return Me.GetValue(TableUtils.MinorStickersColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.MinorStickers field.
	''' </summary>
	Public Function GetMinorStickersFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MinorStickersColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.MinorStickers field.
	''' </summary>
	Public Sub SetMinorStickersFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MinorStickersColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.MinorStickers field.
	''' </summary>
	Public Sub SetMinorStickersFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MinorStickersColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.GeneralStats field.
	''' </summary>
	Public Function GetGeneralStatsValue() As ColumnValue
		Return Me.GetValue(TableUtils.GeneralStatsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.GeneralStats field.
	''' </summary>
	Public Function GetGeneralStatsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.GeneralStatsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.GeneralStats field.
	''' </summary>
	Public Sub SetGeneralStatsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GeneralStatsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.GeneralStats field.
	''' </summary>
	Public Sub SetGeneralStatsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GeneralStatsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.SocialStatus field.
	''' </summary>
	Public Function GetSocialStatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.SocialStatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PersonSnapshot_.SocialStatus field.
	''' </summary>
	Public Function GetSocialStatusFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SocialStatusColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.SocialStatus field.
	''' </summary>
	Public Sub SetSocialStatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SocialStatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PersonSnapshot_.SocialStatus field.
	''' </summary>
	Public Sub SetSocialStatusFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SocialStatusColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PersonSnapshot_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PersonSnapshot_.FromPic field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PersonSnapshot_.NameHTML field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PersonSnapshot_.MoreHTML field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PersonSnapshot_.Details field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PersonSnapshot_.ProfileSnippet field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PersonSnapshot_.FullProfile field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PersonSnapshot_.MajorStickers field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PersonSnapshot_.MinorStickers field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PersonSnapshot_.GeneralStats field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PersonSnapshot_.SocialStatus field.
	''' </summary>
	Public Property SocialStatus() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SocialStatusColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SocialStatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SocialStatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SocialStatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SocialStatusDefault() As String
        Get
            Return TableUtils.SocialStatusColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
