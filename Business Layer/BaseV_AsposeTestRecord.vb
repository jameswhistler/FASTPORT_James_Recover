' This class is "generated" and will be overwritten.
' Your customizations should be made in V_AsposeTestRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_AsposeTestRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_AsposeTestView"></see> class.
''' </remarks>
''' <seealso cref="V_AsposeTestView"></seealso>
''' <seealso cref="V_AsposeTestRecord"></seealso>

<Serializable()> Public Class BaseV_AsposeTestRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_AsposeTestView = V_AsposeTestView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_AsposeTestRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_AsposeTestRec As V_AsposeTestRecord = CType(sender,V_AsposeTestRecord)
        If Not V_AsposeTestRec Is Nothing AndAlso Not V_AsposeTestRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_AsposeTestRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_AsposeTestRec As V_AsposeTestRecord = CType(sender,V_AsposeTestRecord)
        Validate_Inserting()
        If Not V_AsposeTestRec Is Nothing AndAlso Not V_AsposeTestRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTest_.ExecutionID field.
	''' </summary>
	Public Function GetExecutionIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExecutionIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTest_.ExecutionID field.
	''' </summary>
	Public Function GetExecutionIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ExecutionIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.ExecutionID field.
	''' </summary>
	Public Sub SetExecutionIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTest_.SenderID field.
	''' </summary>
	Public Function GetSenderIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTest_.SenderID field.
	''' </summary>
	Public Function GetSenderIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SenderIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SenderIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTest_.SenderPic field.
	''' </summary>
	Public Function GetSenderPicValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderPicColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTest_.SenderPic field.
	''' </summary>
	Public Function GetSenderPicFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.SenderPicColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.SenderPic field.
	''' </summary>
	Public Sub SetSenderPicFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderPicColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.SenderPic field.
	''' </summary>
	Public Sub SetSenderPicFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SenderPicColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.SenderPic field.
	''' </summary>
	Public Sub SetSenderPicFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderPicColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTest_.SenderName field.
	''' </summary>
	Public Function GetSenderNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTest_.SenderName field.
	''' </summary>
	Public Function GetSenderNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SenderNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.SenderName field.
	''' </summary>
	Public Sub SetSenderNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.SenderName field.
	''' </summary>
	Public Sub SetSenderNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTest_.RecipientName field.
	''' </summary>
	Public Function GetRecipientNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.RecipientNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTest_.RecipientName field.
	''' </summary>
	Public Function GetRecipientNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.RecipientNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.RecipientName field.
	''' </summary>
	Public Sub SetRecipientNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RecipientNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.RecipientName field.
	''' </summary>
	Public Sub SetRecipientNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTest_.RecipientSignature field.
	''' </summary>
	Public Function GetRecipientSignatureValue() As ColumnValue
		Return Me.GetValue(TableUtils.RecipientSignatureColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTest_.RecipientSignature field.
	''' </summary>
	Public Function GetRecipientSignatureFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.RecipientSignatureColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.RecipientSignature field.
	''' </summary>
	Public Sub SetRecipientSignatureFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RecipientSignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.RecipientSignature field.
	''' </summary>
	Public Sub SetRecipientSignatureFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RecipientSignatureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.RecipientSignature field.
	''' </summary>
	Public Sub SetRecipientSignatureFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RecipientSignatureColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTest_.TestHTML field.
	''' </summary>
	Public Function GetTestHTMLValue() As ColumnValue
		Return Me.GetValue(TableUtils.TestHTMLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTest_.TestHTML field.
	''' </summary>
	Public Function GetTestHTMLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TestHTMLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.TestHTML field.
	''' </summary>
	Public Sub SetTestHTMLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TestHTMLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTest_.TestHTML field.
	''' </summary>
	Public Sub SetTestHTMLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TestHTMLColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AsposeTest_.ExecutionID field.
	''' </summary>
	Public Property ExecutionID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ExecutionIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExecutionIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExecutionIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExecutionIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExecutionIDDefault() As String
        Get
            Return TableUtils.ExecutionIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AsposeTest_.SenderID field.
	''' </summary>
	Public Property SenderID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SenderIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SenderIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SenderIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SenderIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SenderIDDefault() As String
        Get
            Return TableUtils.SenderIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AsposeTest_.SenderPic field.
	''' </summary>
	Public Property SenderPic() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.SenderPicColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SenderPicColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SenderPicSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SenderPicColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SenderPicDefault() As String
        Get
            Return TableUtils.SenderPicColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AsposeTest_.SenderName field.
	''' </summary>
	Public Property SenderName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SenderNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SenderNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SenderNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SenderNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SenderNameDefault() As String
        Get
            Return TableUtils.SenderNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AsposeTest_.RecipientName field.
	''' </summary>
	Public Property RecipientName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.RecipientNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.RecipientNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RecipientNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RecipientNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RecipientNameDefault() As String
        Get
            Return TableUtils.RecipientNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AsposeTest_.RecipientSignature field.
	''' </summary>
	Public Property RecipientSignature() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.RecipientSignatureColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RecipientSignatureColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RecipientSignatureSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RecipientSignatureColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RecipientSignatureDefault() As String
        Get
            Return TableUtils.RecipientSignatureColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AsposeTest_.TestHTML field.
	''' </summary>
	Public Property TestHTML() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TestHTMLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TestHTMLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TestHTMLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TestHTMLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TestHTMLDefault() As String
        Get
            Return TableUtils.TestHTMLColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
