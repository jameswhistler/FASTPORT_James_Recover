' This class is "generated" and will be overwritten.
' Your customizations should be made in V_PartyByUserRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_PartyByUserRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_PartyByUserView"></see> class.
''' </remarks>
''' <seealso cref="V_PartyByUserView"></seealso>
''' <seealso cref="V_PartyByUserRecord"></seealso>

<Serializable()> Public Class BaseV_PartyByUserRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_PartyByUserView = V_PartyByUserView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_PartyByUserRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_PartyByUserRec As V_PartyByUserRecord = CType(sender,V_PartyByUserRecord)
        If Not V_PartyByUserRec Is Nothing AndAlso Not V_PartyByUserRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_PartyByUserRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_PartyByUserRec As V_PartyByUserRecord = CType(sender,V_PartyByUserRecord)
        Validate_Inserting()
        If Not V_PartyByUserRec Is Nothing AndAlso Not V_PartyByUserRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_PartyByUser_.PartyID field.
	''' </summary>
	Public Function GetPartyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PartyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyByUser_.PartyID field.
	''' </summary>
	Public Function GetPartyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PartyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.PartyID field.
	''' </summary>
	Public Sub SetPartyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PartyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyByUser_.Name field.
	''' </summary>
	Public Function GetNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyByUser_.Name field.
	''' </summary>
	Public Function GetNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyByUser_.Logo field.
	''' </summary>
	Public Function GetLogoValue() As ColumnValue
		Return Me.GetValue(TableUtils.LogoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyByUser_.Logo field.
	''' </summary>
	Public Function GetLogoFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.LogoColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.Logo field.
	''' </summary>
	Public Sub SetLogoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LogoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.Logo field.
	''' </summary>
	Public Sub SetLogoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LogoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.Logo field.
	''' </summary>
	Public Sub SetLogoFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LogoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyByUser_.ProfilePicture field.
	''' </summary>
	Public Function GetProfilePictureValue() As ColumnValue
		Return Me.GetValue(TableUtils.ProfilePictureColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyByUser_.ProfilePicture field.
	''' </summary>
	Public Function GetProfilePictureFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.ProfilePictureColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.ProfilePicture field.
	''' </summary>
	Public Sub SetProfilePictureFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ProfilePictureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.ProfilePicture field.
	''' </summary>
	Public Sub SetProfilePictureFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ProfilePictureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.ProfilePicture field.
	''' </summary>
	Public Sub SetProfilePictureFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ProfilePictureColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyByUser_.Handle field.
	''' </summary>
	Public Function GetHandleValue() As ColumnValue
		Return Me.GetValue(TableUtils.HandleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyByUser_.Handle field.
	''' </summary>
	Public Function GetHandleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.HandleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.Handle field.
	''' </summary>
	Public Sub SetHandleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HandleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.Handle field.
	''' </summary>
	Public Sub SetHandleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HandleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyByUser_.UserID field.
	''' </summary>
	Public Function GetUserId0Value() As ColumnValue
		Return Me.GetValue(TableUtils.UserId0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_PartyByUser_.UserID field.
	''' </summary>
	Public Function GetUserId0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UserId0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.UserID field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.UserID field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.UserID field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.UserID field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_PartyByUser_.UserID field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserId0Column)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_PartyByUser_.PartyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PartyByUser_.Name field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PartyByUser_.Logo field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PartyByUser_.ProfilePicture field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PartyByUser_.Handle field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_PartyByUser_.UserID field.
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



#End Region

End Class
End Namespace
