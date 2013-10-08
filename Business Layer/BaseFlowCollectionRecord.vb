' This class is "generated" and will be overwritten.
' Your customizations should be made in FlowCollectionRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="FlowCollectionRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="FlowCollectionTable"></see> class.
''' </remarks>
''' <seealso cref="FlowCollectionTable"></seealso>
''' <seealso cref="FlowCollectionRecord"></seealso>

<Serializable()> Public Class BaseFlowCollectionRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As FlowCollectionTable = FlowCollectionTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub FlowCollectionRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim FlowCollectionRec As FlowCollectionRecord = CType(sender,FlowCollectionRecord)
        Validate_Inserting()
        If Not FlowCollectionRec Is Nothing AndAlso Not FlowCollectionRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub FlowCollectionRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim FlowCollectionRec As FlowCollectionRecord = CType(sender,FlowCollectionRecord)
        Validate_Updating()
        If Not FlowCollectionRec Is Nothing AndAlso Not FlowCollectionRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub FlowCollectionRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim FlowCollectionRec As FlowCollectionRecord = CType(sender,FlowCollectionRecord)
        If Not FlowCollectionRec Is Nothing AndAlso Not FlowCollectionRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.FlowCollectionID field.
	''' </summary>
	Public Function GetFlowCollectionIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowCollectionIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.FlowCollectionID field.
	''' </summary>
	Public Function GetFlowCollectionIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowCollectionIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.FlowID field.
	''' </summary>
	Public Function GetFlowIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FlowIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.FlowID field.
	''' </summary>
	Public Function GetFlowIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FlowIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.FlowID field.
	''' </summary>
	Public Sub SetFlowIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FlowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.FlowID field.
	''' </summary>
	Public Sub SetFlowIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FlowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.FlowID field.
	''' </summary>
	Public Sub SetFlowIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.FlowID field.
	''' </summary>
	Public Sub SetFlowIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.FlowID field.
	''' </summary>
	Public Sub SetFlowIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FlowIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.CollectionName field.
	''' </summary>
	Public Function GetCollectionNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.CollectionNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.CollectionName field.
	''' </summary>
	Public Function GetCollectionNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CollectionNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CollectionName field.
	''' </summary>
	Public Sub SetCollectionNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CollectionNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CollectionName field.
	''' </summary>
	Public Sub SetCollectionNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CollectionNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.CollectionRank field.
	''' </summary>
	Public Function GetCollectionRankValue() As ColumnValue
		Return Me.GetValue(TableUtils.CollectionRankColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.CollectionRank field.
	''' </summary>
	Public Function GetCollectionRankFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CollectionRankColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CollectionRank field.
	''' </summary>
	Public Sub SetCollectionRankFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CollectionRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CollectionRank field.
	''' </summary>
	Public Sub SetCollectionRankFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CollectionRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CollectionRank field.
	''' </summary>
	Public Sub SetCollectionRankFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CollectionRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CollectionRank field.
	''' </summary>
	Public Sub SetCollectionRankFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CollectionRankColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CollectionRank field.
	''' </summary>
	Public Sub SetCollectionRankFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CollectionRankColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.DefaultURLParams field.
	''' </summary>
	Public Function GetDefaultURLParamsValue() As ColumnValue
		Return Me.GetValue(TableUtils.DefaultURLParamsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.DefaultURLParams field.
	''' </summary>
	Public Function GetDefaultURLParamsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DefaultURLParamsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.DefaultURLParams field.
	''' </summary>
	Public Sub SetDefaultURLParamsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DefaultURLParamsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.DefaultURLParams field.
	''' </summary>
	Public Sub SetDefaultURLParamsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DefaultURLParamsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.GoAction field.
	''' </summary>
	Public Function GetGoActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.GoActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.GoAction field.
	''' </summary>
	Public Function GetGoActionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.GoActionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.GoAction field.
	''' </summary>
	Public Sub SetGoActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GoActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.GoAction field.
	''' </summary>
	Public Sub SetGoActionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GoActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.StartingStepID field.
	''' </summary>
	Public Function GetStartingStepIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.StartingStepIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.StartingStepID field.
	''' </summary>
	Public Function GetStartingStepIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.StartingStepIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.StartingStepID field.
	''' </summary>
	Public Sub SetStartingStepIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StartingStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.StartingStepID field.
	''' </summary>
	Public Sub SetStartingStepIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.StartingStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.StartingStepID field.
	''' </summary>
	Public Sub SetStartingStepIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StartingStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.StartingStepID field.
	''' </summary>
	Public Sub SetStartingStepIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StartingStepIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.StartingStepID field.
	''' </summary>
	Public Sub SetStartingStepIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StartingStepIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.ThreadID field.
	''' </summary>
	Public Function GetThreadIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ThreadIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.ThreadID field.
	''' </summary>
	Public Function GetThreadIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ThreadIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.ThreadID field.
	''' </summary>
	Public Sub SetThreadIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ThreadIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.ThreadID field.
	''' </summary>
	Public Sub SetThreadIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ThreadIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.ThreadID field.
	''' </summary>
	Public Sub SetThreadIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.ThreadID field.
	''' </summary>
	Public Sub SetThreadIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.ThreadID field.
	''' </summary>
	Public Sub SetThreadIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ThreadIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.CollectionDescription field.
	''' </summary>
	Public Function GetCollectionDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.CollectionDescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.CollectionDescription field.
	''' </summary>
	Public Function GetCollectionDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CollectionDescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CollectionDescription field.
	''' </summary>
	Public Sub SetCollectionDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CollectionDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CollectionDescription field.
	''' </summary>
	Public Sub SetCollectionDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CollectionDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.CollectionImage field.
	''' </summary>
	Public Function GetCollectionImageValue() As ColumnValue
		Return Me.GetValue(TableUtils.CollectionImageColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.CollectionImage field.
	''' </summary>
	Public Function GetCollectionImageFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.CollectionImageColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CollectionImage field.
	''' </summary>
	Public Sub SetCollectionImageFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CollectionImageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CollectionImage field.
	''' </summary>
	Public Sub SetCollectionImageFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CollectionImageColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CollectionImage field.
	''' </summary>
	Public Sub SetCollectionImageFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CollectionImageColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.CopyFlowCollectionID field.
	''' </summary>
	Public Function GetCopyFlowCollectionIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CopyFlowCollectionIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.CopyFlowCollectionID field.
	''' </summary>
	Public Function GetCopyFlowCollectionIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CopyFlowCollectionIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CopyFlowCollectionID field.
	''' </summary>
	Public Sub SetCopyFlowCollectionIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CopyFlowCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CopyFlowCollectionID field.
	''' </summary>
	Public Sub SetCopyFlowCollectionIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CopyFlowCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CopyFlowCollectionID field.
	''' </summary>
	Public Sub SetCopyFlowCollectionIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CopyFlowCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CopyFlowCollectionID field.
	''' </summary>
	Public Sub SetCopyFlowCollectionIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CopyFlowCollectionIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.CopyFlowCollectionID field.
	''' </summary>
	Public Sub SetCopyFlowCollectionIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CopyFlowCollectionIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.RelatedToID field.
	''' </summary>
	Public Function GetRelatedToIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.RelatedToIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's FlowCollection_.RelatedToID field.
	''' </summary>
	Public Function GetRelatedToIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RelatedToIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.RelatedToID field.
	''' </summary>
	Public Sub SetRelatedToIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RelatedToIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.RelatedToID field.
	''' </summary>
	Public Sub SetRelatedToIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RelatedToIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.RelatedToID field.
	''' </summary>
	Public Sub SetRelatedToIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RelatedToIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.RelatedToID field.
	''' </summary>
	Public Sub SetRelatedToIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RelatedToIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's FlowCollection_.RelatedToID field.
	''' </summary>
	Public Sub SetRelatedToIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RelatedToIDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowCollection_.FlowCollectionID field.
	''' </summary>
	Public Property FlowCollectionID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FlowCollectionIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FlowCollectionIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FlowCollectionIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FlowCollectionIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FlowCollectionIDDefault() As String
        Get
            Return TableUtils.FlowCollectionIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowCollection_.FlowID field.
	''' </summary>
	Public Property FlowID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FlowIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FlowIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FlowIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FlowIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FlowIDDefault() As String
        Get
            Return TableUtils.FlowIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowCollection_.CollectionName field.
	''' </summary>
	Public Property CollectionName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CollectionNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CollectionNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CollectionNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CollectionNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CollectionNameDefault() As String
        Get
            Return TableUtils.CollectionNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowCollection_.CollectionRank field.
	''' </summary>
	Public Property CollectionRank() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CollectionRankColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CollectionRankColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CollectionRankSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CollectionRankColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CollectionRankDefault() As String
        Get
            Return TableUtils.CollectionRankColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowCollection_.DefaultURLParams field.
	''' </summary>
	Public Property DefaultURLParams() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DefaultURLParamsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DefaultURLParamsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DefaultURLParamsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DefaultURLParamsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DefaultURLParamsDefault() As String
        Get
            Return TableUtils.DefaultURLParamsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowCollection_.GoAction field.
	''' </summary>
	Public Property GoAction() As String
		Get 
			Return CType(Me.GetValue(TableUtils.GoActionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.GoActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GoActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GoActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GoActionDefault() As String
        Get
            Return TableUtils.GoActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowCollection_.StartingStepID field.
	''' </summary>
	Public Property StartingStepID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.StartingStepIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.StartingStepIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property StartingStepIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.StartingStepIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property StartingStepIDDefault() As String
        Get
            Return TableUtils.StartingStepIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowCollection_.ThreadID field.
	''' </summary>
	Public Property ThreadID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ThreadIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ThreadIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ThreadIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ThreadIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ThreadIDDefault() As String
        Get
            Return TableUtils.ThreadIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowCollection_.CollectionDescription field.
	''' </summary>
	Public Property CollectionDescription() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CollectionDescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CollectionDescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CollectionDescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CollectionDescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CollectionDescriptionDefault() As String
        Get
            Return TableUtils.CollectionDescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowCollection_.CollectionImage field.
	''' </summary>
	Public Property CollectionImage() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.CollectionImageColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CollectionImageColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CollectionImageSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CollectionImageColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CollectionImageDefault() As String
        Get
            Return TableUtils.CollectionImageColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowCollection_.CopyFlowCollectionID field.
	''' </summary>
	Public Property CopyFlowCollectionID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CopyFlowCollectionIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CopyFlowCollectionIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CopyFlowCollectionIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CopyFlowCollectionIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CopyFlowCollectionIDDefault() As String
        Get
            Return TableUtils.CopyFlowCollectionIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's FlowCollection_.RelatedToID field.
	''' </summary>
	Public Property RelatedToID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RelatedToIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RelatedToIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RelatedToIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RelatedToIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RelatedToIDDefault() As String
        Get
            Return TableUtils.RelatedToIDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
