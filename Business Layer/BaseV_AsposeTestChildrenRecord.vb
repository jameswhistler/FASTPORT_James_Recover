' This class is "generated" and will be overwritten.
' Your customizations should be made in V_AsposeTestChildrenRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_AsposeTestChildrenRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_AsposeTestChildrenView"></see> class.
''' </remarks>
''' <seealso cref="V_AsposeTestChildrenView"></seealso>
''' <seealso cref="V_AsposeTestChildrenRecord"></seealso>

<Serializable()> Public Class BaseV_AsposeTestChildrenRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_AsposeTestChildrenView = V_AsposeTestChildrenView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub V_AsposeTestChildrenRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim V_AsposeTestChildrenRec As V_AsposeTestChildrenRecord = CType(sender,V_AsposeTestChildrenRecord)
        If Not V_AsposeTestChildrenRec Is Nothing AndAlso Not V_AsposeTestChildrenRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub V_AsposeTestChildrenRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim V_AsposeTestChildrenRec As V_AsposeTestChildrenRecord = CType(sender,V_AsposeTestChildrenRecord)
        Validate_Inserting()
        If Not V_AsposeTestChildrenRec Is Nothing AndAlso Not V_AsposeTestChildrenRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTestChildren_.SenderID field.
	''' </summary>
	Public Function GetSenderIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SenderIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTestChildren_.SenderID field.
	''' </summary>
	Public Function GetSenderIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SenderIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTestChildren_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SenderIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTestChildren_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SenderIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTestChildren_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTestChildren_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTestChildren_.SenderID field.
	''' </summary>
	Public Sub SetSenderIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SenderIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTestChildren_.ItemImage field.
	''' </summary>
	Public Function GetItemImageValue() As ColumnValue
		Return Me.GetValue(TableUtils.ItemImageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTestChildren_.ItemImage field.
	''' </summary>
	Public Function GetItemImageFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.ItemImageColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTestChildren_.ItemImage field.
	''' </summary>
	Public Sub SetItemImageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ItemImageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTestChildren_.ItemImage field.
	''' </summary>
	Public Sub SetItemImageFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ItemImageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTestChildren_.ItemImage field.
	''' </summary>
	Public Sub SetItemImageFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemImageColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTestChildren_.ItemName field.
	''' </summary>
	Public Function GetItemNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ItemNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_AsposeTestChildren_.ItemName field.
	''' </summary>
	Public Function GetItemNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ItemNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTestChildren_.ItemName field.
	''' </summary>
	Public Sub SetItemNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ItemNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_AsposeTestChildren_.ItemName field.
	''' </summary>
	Public Sub SetItemNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemNameColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AsposeTestChildren_.SenderID field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_AsposeTestChildren_.ItemImage field.
	''' </summary>
	Public Property ItemImage() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.ItemImageColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ItemImageColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ItemImageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ItemImageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ItemImageDefault() As String
        Get
            Return TableUtils.ItemImageColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_AsposeTestChildren_.ItemName field.
	''' </summary>
	Public Property ItemName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ItemNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ItemNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ItemNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ItemNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ItemNameDefault() As String
        Get
            Return TableUtils.ItemNameColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
