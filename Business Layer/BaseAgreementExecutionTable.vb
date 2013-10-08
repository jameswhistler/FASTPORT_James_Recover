' This class is "generated" and will be overwritten.
' Your customizations should be made in AgreementExecutionRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="AgreementExecutionTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named AgreementExecution.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="AgreementExecutionTable.Instance">AgreementExecutionTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="AgreementExecutionTable"></seealso>

<Serializable()> Public Class BaseAgreementExecutionTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = AgreementExecutionDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.AgreementExecutionTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.AgreementExecutionRecord")
        Me.ApplicationName = "FASTPORT"
        Me.DataAdapter = New AgreementExecutionSqlTable()
        Directcast(Me.DataAdapter, AgreementExecutionSqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, AgreementExecutionSqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        ExecutionIDColumn.CodeName = "ExecutionID"
        CIXColumn.CodeName = "CIX"
        OIXColumn.CodeName = "OIX"
        AgreementIDColumn.CodeName = "AgreementID"
        SenderAddrIDColumn.CodeName = "SenderAddrID"
        SenderSignerIDColumn.CodeName = "SenderSignerID"
        RecipientAddrIDColumn.CodeName = "RecipientAddrID"
        RecipientSignerIDColumn.CodeName = "RecipientSignerID"
        SignedOnColumn.CodeName = "SignedOn"
        ExpiresOnColumn.CodeName = "ExpiresOn"
        UseOutsideTemplateColumn.CodeName = "UseOutsideTemplate"
        UseOutsidePdfColumn.CodeName = "UseOutsidePdf"
        AgreementFileDocColumn.CodeName = "AgreementFileDoc"
        AgreementFilePdfColumn.CodeName = "AgreementFilePdf"
        SenderSignatureColumn.CodeName = "SenderSignature"
        SenderInitialsColumn.CodeName = "SenderInitials"
        SenderSignedAtColumn.CodeName = "SenderSignedAt"
        SenderSignedFromColumn.CodeName = "SenderSignedFrom"
        RecipientSignatureColumn.CodeName = "RecipientSignature"
        RecipientInitialsColumn.CodeName = "RecipientInitials"
        RecipientSignedAtColumn.CodeName = "RecipientSignedAt"
        RecipientSignedFromColumn.CodeName = "RecipientSignedFrom"
        AddSignaturePageColumn.CodeName = "AddSignaturePage"
        FlowStepIDColumn.CodeName = "FlowStepID"
        InstanceIDColumn.CodeName = "InstanceID"
        FirstItemColumn.CodeName = "FirstItem"
        SecondItemColumn.CodeName = "SecondItem"
        ThirdItemColumn.CodeName = "ThirdItem"
        FourthItemColumn.CodeName = "FourthItem"
        FifthItemColumn.CodeName = "FifthItem"
        SixthItemColumn.CodeName = "SixthItem"
        SeventhItemColumn.CodeName = "SeventhItem"
        EighthItemColumn.CodeName = "EighthItem"
        NinthItemColumn.CodeName = "NinthItem"
        TenthItemColumn.CodeName = "TenthItem"
        EleventhItemColumn.CodeName = "EleventhItem"
        TwelfthItemColumn.CodeName = "TwelfthItem"
        ThirteenthItemColumn.CodeName = "ThirteenthItem"
        FourteenthItemColumn.CodeName = "FourteenthItem"
        FifteenthItemColumn.CodeName = "FifteenthItem"
        BarCodeColumn.CodeName = "BarCode"
        CreatedByIDColumn.CodeName = "CreatedByID"
        CreatedAtColumn.CodeName = "CreatedAt"
        UpdatedByIDColumn.CodeName = "UpdatedByID"
        UpdatedAtColumn.CodeName = "UpdatedAt"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.ExecutionID column object.
    ''' </summary>
    Public ReadOnly Property ExecutionIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.ExecutionID column object.
    ''' </summary>
    Public Shared ReadOnly Property ExecutionID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementExecutionTable.Instance.ExecutionIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.CIX column object.
    ''' </summary>
    Public ReadOnly Property CIXColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.CIX column object.
    ''' </summary>
    Public Shared ReadOnly Property CIX() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementExecutionTable.Instance.CIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.OIX column object.
    ''' </summary>
    Public ReadOnly Property OIXColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.OIX column object.
    ''' </summary>
    Public Shared ReadOnly Property OIX() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementExecutionTable.Instance.OIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.AgreementID column object.
    ''' </summary>
    Public ReadOnly Property AgreementIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.AgreementID column object.
    ''' </summary>
    Public Shared ReadOnly Property AgreementID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementExecutionTable.Instance.AgreementIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SenderAddrID column object.
    ''' </summary>
    Public ReadOnly Property SenderAddrIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SenderAddrID column object.
    ''' </summary>
    Public Shared ReadOnly Property SenderAddrID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementExecutionTable.Instance.SenderAddrIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SenderSignerID column object.
    ''' </summary>
    Public ReadOnly Property SenderSignerIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SenderSignerID column object.
    ''' </summary>
    Public Shared ReadOnly Property SenderSignerID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementExecutionTable.Instance.SenderSignerIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.RecipientAddrID column object.
    ''' </summary>
    Public ReadOnly Property RecipientAddrIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.RecipientAddrID column object.
    ''' </summary>
    Public Shared ReadOnly Property RecipientAddrID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementExecutionTable.Instance.RecipientAddrIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.RecipientSignerID column object.
    ''' </summary>
    Public ReadOnly Property RecipientSignerIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.RecipientSignerID column object.
    ''' </summary>
    Public Shared ReadOnly Property RecipientSignerID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementExecutionTable.Instance.RecipientSignerIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SignedOn column object.
    ''' </summary>
    Public ReadOnly Property SignedOnColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SignedOn column object.
    ''' </summary>
    Public Shared ReadOnly Property SignedOn() As BaseClasses.Data.DateColumn
        Get
            Return AgreementExecutionTable.Instance.SignedOnColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.ExpiresOn column object.
    ''' </summary>
    Public ReadOnly Property ExpiresOnColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.ExpiresOn column object.
    ''' </summary>
    Public Shared ReadOnly Property ExpiresOn() As BaseClasses.Data.DateColumn
        Get
            Return AgreementExecutionTable.Instance.ExpiresOnColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.UseOutsideTemplate column object.
    ''' </summary>
    Public ReadOnly Property UseOutsideTemplateColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.UseOutsideTemplate column object.
    ''' </summary>
    Public Shared ReadOnly Property UseOutsideTemplate() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementExecutionTable.Instance.UseOutsideTemplateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.UseOutsidePdf column object.
    ''' </summary>
    Public ReadOnly Property UseOutsidePdfColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.UseOutsidePdf column object.
    ''' </summary>
    Public Shared ReadOnly Property UseOutsidePdf() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementExecutionTable.Instance.UseOutsidePdfColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.AgreementFileDoc column object.
    ''' </summary>
    Public ReadOnly Property AgreementFileDocColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.AgreementFileDoc column object.
    ''' </summary>
    Public Shared ReadOnly Property AgreementFileDoc() As BaseClasses.Data.ImageColumn
        Get
            Return AgreementExecutionTable.Instance.AgreementFileDocColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.AgreementFilePdf column object.
    ''' </summary>
    Public ReadOnly Property AgreementFilePdfColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.AgreementFilePdf column object.
    ''' </summary>
    Public Shared ReadOnly Property AgreementFilePdf() As BaseClasses.Data.ImageColumn
        Get
            Return AgreementExecutionTable.Instance.AgreementFilePdfColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SenderSignature column object.
    ''' </summary>
    Public ReadOnly Property SenderSignatureColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SenderSignature column object.
    ''' </summary>
    Public Shared ReadOnly Property SenderSignature() As BaseClasses.Data.ImageColumn
        Get
            Return AgreementExecutionTable.Instance.SenderSignatureColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SenderInitials column object.
    ''' </summary>
    Public ReadOnly Property SenderInitialsColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SenderInitials column object.
    ''' </summary>
    Public Shared ReadOnly Property SenderInitials() As BaseClasses.Data.ImageColumn
        Get
            Return AgreementExecutionTable.Instance.SenderInitialsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SenderSignedAt column object.
    ''' </summary>
    Public ReadOnly Property SenderSignedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SenderSignedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property SenderSignedAt() As BaseClasses.Data.DateColumn
        Get
            Return AgreementExecutionTable.Instance.SenderSignedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SenderSignedFrom column object.
    ''' </summary>
    Public ReadOnly Property SenderSignedFromColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SenderSignedFrom column object.
    ''' </summary>
    Public Shared ReadOnly Property SenderSignedFrom() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.SenderSignedFromColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.RecipientSignature column object.
    ''' </summary>
    Public ReadOnly Property RecipientSignatureColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.RecipientSignature column object.
    ''' </summary>
    Public Shared ReadOnly Property RecipientSignature() As BaseClasses.Data.ImageColumn
        Get
            Return AgreementExecutionTable.Instance.RecipientSignatureColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.RecipientInitials column object.
    ''' </summary>
    Public ReadOnly Property RecipientInitialsColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.RecipientInitials column object.
    ''' </summary>
    Public Shared ReadOnly Property RecipientInitials() As BaseClasses.Data.ImageColumn
        Get
            Return AgreementExecutionTable.Instance.RecipientInitialsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.RecipientSignedAt column object.
    ''' </summary>
    Public ReadOnly Property RecipientSignedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.RecipientSignedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property RecipientSignedAt() As BaseClasses.Data.DateColumn
        Get
            Return AgreementExecutionTable.Instance.RecipientSignedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.RecipientSignedFrom column object.
    ''' </summary>
    Public ReadOnly Property RecipientSignedFromColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.RecipientSignedFrom column object.
    ''' </summary>
    Public Shared ReadOnly Property RecipientSignedFrom() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.RecipientSignedFromColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.AddSignaturePage column object.
    ''' </summary>
    Public ReadOnly Property AddSignaturePageColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.AddSignaturePage column object.
    ''' </summary>
    Public Shared ReadOnly Property AddSignaturePage() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementExecutionTable.Instance.AddSignaturePageColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.FlowStepID column object.
    ''' </summary>
    Public ReadOnly Property FlowStepIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.FlowStepID column object.
    ''' </summary>
    Public Shared ReadOnly Property FlowStepID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementExecutionTable.Instance.FlowStepIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.InstanceID column object.
    ''' </summary>
    Public ReadOnly Property InstanceIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.InstanceID column object.
    ''' </summary>
    Public Shared ReadOnly Property InstanceID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementExecutionTable.Instance.InstanceIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.FirstItem column object.
    ''' </summary>
    Public ReadOnly Property FirstItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.FirstItem column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.FirstItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SecondItem column object.
    ''' </summary>
    Public ReadOnly Property SecondItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SecondItem column object.
    ''' </summary>
    Public Shared ReadOnly Property SecondItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.SecondItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.ThirdItem column object.
    ''' </summary>
    Public ReadOnly Property ThirdItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.ThirdItem column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirdItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.ThirdItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.FourthItem column object.
    ''' </summary>
    Public ReadOnly Property FourthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.FourthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property FourthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.FourthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.FifthItem column object.
    ''' </summary>
    Public ReadOnly Property FifthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.FifthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property FifthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.FifthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SixthItem column object.
    ''' </summary>
    Public ReadOnly Property SixthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SixthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property SixthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.SixthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SeventhItem column object.
    ''' </summary>
    Public ReadOnly Property SeventhItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.SeventhItem column object.
    ''' </summary>
    Public Shared ReadOnly Property SeventhItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.SeventhItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.EighthItem column object.
    ''' </summary>
    Public ReadOnly Property EighthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(32), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.EighthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property EighthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.EighthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.NinthItem column object.
    ''' </summary>
    Public ReadOnly Property NinthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(33), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.NinthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property NinthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.NinthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.TenthItem column object.
    ''' </summary>
    Public ReadOnly Property TenthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(34), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.TenthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property TenthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.TenthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.EleventhItem column object.
    ''' </summary>
    Public ReadOnly Property EleventhItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(35), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.EleventhItem column object.
    ''' </summary>
    Public Shared ReadOnly Property EleventhItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.EleventhItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.TwelfthItem column object.
    ''' </summary>
    Public ReadOnly Property TwelfthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(36), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.TwelfthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property TwelfthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.TwelfthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.ThirteenthItem column object.
    ''' </summary>
    Public ReadOnly Property ThirteenthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(37), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.ThirteenthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirteenthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.ThirteenthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.FourteenthItem column object.
    ''' </summary>
    Public ReadOnly Property FourteenthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(38), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.FourteenthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property FourteenthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.FourteenthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.FifteenthItem column object.
    ''' </summary>
    Public ReadOnly Property FifteenthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(39), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.FifteenthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property FifteenthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementExecutionTable.Instance.FifteenthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.BarCode column object.
    ''' </summary>
    Public ReadOnly Property BarCodeColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(40), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.BarCode column object.
    ''' </summary>
    Public Shared ReadOnly Property BarCode() As BaseClasses.Data.ImageColumn
        Get
            Return AgreementExecutionTable.Instance.BarCodeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.CreatedByID column object.
    ''' </summary>
    Public ReadOnly Property CreatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(41), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.CreatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementExecutionTable.Instance.CreatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.CreatedAt column object.
    ''' </summary>
    Public ReadOnly Property CreatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(42), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.CreatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedAt() As BaseClasses.Data.DateColumn
        Get
            Return AgreementExecutionTable.Instance.CreatedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.UpdatedByID column object.
    ''' </summary>
    Public ReadOnly Property UpdatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(43), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.UpdatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementExecutionTable.Instance.UpdatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.UpdatedAt column object.
    ''' </summary>
    Public ReadOnly Property UpdatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(44), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's AgreementExecution_.UpdatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedAt() As BaseClasses.Data.DateColumn
        Get
            Return AgreementExecutionTable.Instance.UpdatedAtColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of AgreementExecutionRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As AgreementExecutionRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of AgreementExecutionRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As AgreementExecutionRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of AgreementExecutionRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As AgreementExecutionRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of AgreementExecutionRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As AgreementExecutionRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of AgreementExecutionRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As AgreementExecutionRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  AgreementExecutionTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.AgreementExecutionRecord)), AgreementExecutionRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of AgreementExecutionRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As AgreementExecutionRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  AgreementExecutionTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.AgreementExecutionRecord)), AgreementExecutionRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As AgreementExecutionRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = AgreementExecutionTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.AgreementExecutionRecord)), AgreementExecutionRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As AgreementExecutionRecord()

        Dim recList As ArrayList = AgreementExecutionTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.AgreementExecutionRecord)), AgreementExecutionRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As AgreementExecutionRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = AgreementExecutionTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.AgreementExecutionRecord)), AgreementExecutionRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As AgreementExecutionRecord()

        Dim recList As ArrayList = AgreementExecutionTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.AgreementExecutionRecord)), AgreementExecutionRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(AgreementExecutionTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(AgreementExecutionTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(AgreementExecutionTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(AgreementExecutionTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a AgreementExecutionRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As AgreementExecutionRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a AgreementExecutionRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As AgreementExecutionRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a AgreementExecutionRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As AgreementExecutionRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = AgreementExecutionTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As AgreementExecutionRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), AgreementExecutionRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a AgreementExecutionRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As AgreementExecutionRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = AgreementExecutionTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As AgreementExecutionRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), AgreementExecutionRecord)
        End If

        Return rec
    End Function


    Public Shared Function GetValues( _
        ByVal col As BaseColumn, _
         ByVal where As WhereClause, _
         ByVal orderBy As OrderBy, _
         ByVal maxItems As Integer) As String()

        ' Create the filter list.
        Dim retCol As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, True)
        retCol.AddColumn(col)

        Return AgreementExecutionTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function

    Public Shared Function GetValues( _
         ByVal col As BaseColumn, _
         ByVal join As BaseFilter, _
         ByVal where As WhereClause, _
         ByVal orderBy As OrderBy, _
         ByVal maxItems As Integer) As String()

        ' Create the filter list.
        Dim retCol As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, True)
        retCol.AddColumn(col)

        Return AgreementExecutionTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As AgreementExecutionRecord = GetRecords(where)
        Return AgreementExecutionTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As AgreementExecutionRecord = GetRecords(join, where)
        Return AgreementExecutionTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As AgreementExecutionRecord = GetRecords(where, orderBy)
        Return AgreementExecutionTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As AgreementExecutionRecord = GetRecords(join, where, orderBy)
        Return AgreementExecutionTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As AgreementExecutionRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return AgreementExecutionTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal join As BaseFilter, _    
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As AgreementExecutionRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return AgreementExecutionTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        AgreementExecutionTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return AgreementExecutionTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return AgreementExecutionTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function GetSum( _
        ByVal col As BaseColumn, _
        ByVal where As WhereClause, _
        ByVal orderBy As OrderBy, _
        ByVal pageIndex As Integer, _
        ByVal pageSize As Integer) _
        As String

        Dim colSel As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, False)
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum)

        Return AgreementExecutionTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function

    Public Shared Function GetSum( _
        ByVal col As BaseColumn, _
        ByVal join As BaseFilter, _        
        ByVal where As WhereClause, _
        ByVal orderBy As OrderBy, _
        ByVal pageIndex As Integer, _
        ByVal pageSize As Integer) _
        As String

        Dim colSel As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, False)
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum)

        Return AgreementExecutionTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function

    
    Public Shared Function GetCount( _
        ByVal col As BaseColumn, _
        ByVal where As WhereClause, _
        ByVal orderBy As OrderBy, _
        ByVal pageIndex As Integer, _
        ByVal pageSize As Integer) _
        As String

        Dim colSel As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, False)
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count)

        Return AgreementExecutionTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function
    
    Public Shared Function GetCount( _
        ByVal col As BaseColumn, _
        ByVal join As BaseFilter, _         
        ByVal where As WhereClause, _
        ByVal orderBy As OrderBy, _
        ByVal pageIndex As Integer, _
        ByVal pageSize As Integer) _
        As String

        Dim colSel As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, False)
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count)

        Return AgreementExecutionTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return AgreementExecutionTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return AgreementExecutionTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return AgreementExecutionTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return AgreementExecutionTable.Instance.CreateRecord(tempId)
    End Function

    ''' <summary>
    ''' This method checks if column is editable.
    ''' </summary>
    ''' <param name="columnName">Name of the column to check.</param>
    Public Shared Function isReadOnlyColumn(ByVal columnName As String) As Boolean
        Dim column As BaseColumn = GetColumn(columnName)
        If (Not IsNothing(column)) Then
            Return column.IsValuesReadOnly
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="uniqueColumnName">Unique name of the column to fetch.</param>
    Public Shared Function GetColumn(ByVal uniqueColumnName As String) As BaseColumn
        Dim column As BaseColumn = AgreementExecutionTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As AgreementExecutionRecord
        Return CType(AgreementExecutionTable.Instance.GetRecordData(id, bMutable), AgreementExecutionRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As AgreementExecutionRecord
        Return CType(AgreementExecutionTable.Instance.GetRecordData(id, bMutable), AgreementExecutionRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal CIXValue As String, _
        ByVal OIXValue As String, _
        ByVal AgreementIDValue As String, _
        ByVal SenderAddrIDValue As String, _
        ByVal SenderSignerIDValue As String, _
        ByVal RecipientAddrIDValue As String, _
        ByVal RecipientSignerIDValue As String, _
        ByVal SignedOnValue As String, _
        ByVal ExpiresOnValue As String, _
        ByVal UseOutsideTemplateValue As String, _
        ByVal UseOutsidePdfValue As String, _
        ByVal AgreementFileDocValue As String, _
        ByVal AgreementFilePdfValue As String, _
        ByVal SenderSignatureValue As String, _
        ByVal SenderInitialsValue As String, _
        ByVal SenderSignedAtValue As String, _
        ByVal SenderSignedFromValue As String, _
        ByVal RecipientSignatureValue As String, _
        ByVal RecipientInitialsValue As String, _
        ByVal RecipientSignedAtValue As String, _
        ByVal RecipientSignedFromValue As String, _
        ByVal AddSignaturePageValue As String, _
        ByVal FlowStepIDValue As String, _
        ByVal InstanceIDValue As String, _
        ByVal FirstItemValue As String, _
        ByVal SecondItemValue As String, _
        ByVal ThirdItemValue As String, _
        ByVal FourthItemValue As String, _
        ByVal FifthItemValue As String, _
        ByVal SixthItemValue As String, _
        ByVal SeventhItemValue As String, _
        ByVal EighthItemValue As String, _
        ByVal NinthItemValue As String, _
        ByVal TenthItemValue As String, _
        ByVal EleventhItemValue As String, _
        ByVal TwelfthItemValue As String, _
        ByVal ThirteenthItemValue As String, _
        ByVal FourteenthItemValue As String, _
        ByVal FifteenthItemValue As String, _
        ByVal BarCodeValue As String, _
        ByVal CreatedByIDValue As String, _
        ByVal CreatedAtValue As String, _
        ByVal UpdatedByIDValue As String, _
        ByVal UpdatedAtValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(CIXValue, CIXColumn)
        rec.SetString(OIXValue, OIXColumn)
        rec.SetString(AgreementIDValue, AgreementIDColumn)
        rec.SetString(SenderAddrIDValue, SenderAddrIDColumn)
        rec.SetString(SenderSignerIDValue, SenderSignerIDColumn)
        rec.SetString(RecipientAddrIDValue, RecipientAddrIDColumn)
        rec.SetString(RecipientSignerIDValue, RecipientSignerIDColumn)
        rec.SetString(SignedOnValue, SignedOnColumn)
        rec.SetString(ExpiresOnValue, ExpiresOnColumn)
        rec.SetString(UseOutsideTemplateValue, UseOutsideTemplateColumn)
        rec.SetString(UseOutsidePdfValue, UseOutsidePdfColumn)
        rec.SetString(AgreementFileDocValue, AgreementFileDocColumn)
        rec.SetString(AgreementFilePdfValue, AgreementFilePdfColumn)
        rec.SetString(SenderSignatureValue, SenderSignatureColumn)
        rec.SetString(SenderInitialsValue, SenderInitialsColumn)
        rec.SetString(SenderSignedAtValue, SenderSignedAtColumn)
        rec.SetString(SenderSignedFromValue, SenderSignedFromColumn)
        rec.SetString(RecipientSignatureValue, RecipientSignatureColumn)
        rec.SetString(RecipientInitialsValue, RecipientInitialsColumn)
        rec.SetString(RecipientSignedAtValue, RecipientSignedAtColumn)
        rec.SetString(RecipientSignedFromValue, RecipientSignedFromColumn)
        rec.SetString(AddSignaturePageValue, AddSignaturePageColumn)
        rec.SetString(FlowStepIDValue, FlowStepIDColumn)
        rec.SetString(InstanceIDValue, InstanceIDColumn)
        rec.SetString(FirstItemValue, FirstItemColumn)
        rec.SetString(SecondItemValue, SecondItemColumn)
        rec.SetString(ThirdItemValue, ThirdItemColumn)
        rec.SetString(FourthItemValue, FourthItemColumn)
        rec.SetString(FifthItemValue, FifthItemColumn)
        rec.SetString(SixthItemValue, SixthItemColumn)
        rec.SetString(SeventhItemValue, SeventhItemColumn)
        rec.SetString(EighthItemValue, EighthItemColumn)
        rec.SetString(NinthItemValue, NinthItemColumn)
        rec.SetString(TenthItemValue, TenthItemColumn)
        rec.SetString(EleventhItemValue, EleventhItemColumn)
        rec.SetString(TwelfthItemValue, TwelfthItemColumn)
        rec.SetString(ThirteenthItemValue, ThirteenthItemColumn)
        rec.SetString(FourteenthItemValue, FourteenthItemColumn)
        rec.SetString(FifteenthItemValue, FifteenthItemColumn)
        rec.SetString(BarCodeValue, BarCodeColumn)
        rec.SetString(CreatedByIDValue, CreatedByIDColumn)
        rec.SetString(CreatedAtValue, CreatedAtColumn)
        rec.SetString(UpdatedByIDValue, UpdatedByIDColumn)
        rec.SetString(UpdatedAtValue, UpdatedAtColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        AgreementExecutionTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            AgreementExecutionTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(AgreementExecutionTable.Instance.TableDefinition.PrimaryKey)) Then
            Return AgreementExecutionTable.Instance.TableDefinition.PrimaryKey.Columns
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' This method takes a key and returns a keyvalue.
    ''' </summary>
    ''' <param name="key">key could be array of primary key values in case of composite primary key or a string containing single primary key value in case of non-composite primary key.</param>
    Public Shared Function GetKeyValue(ByVal key As Object) As KeyValue
        Dim kv As KeyValue = Nothing

        If (Not (IsNothing(AgreementExecutionTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = AgreementExecutionTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = AgreementExecutionTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (AgreementExecutionTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = AgreementExecutionTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = AgreementExecutionTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
	    If fkColumn Is Nothing Then
 			Return Nothing
		End If
        Dim _DFKA As String = fkColumn.PrimaryKeyDisplayColumns
        If (_DFKA.Trim().StartsWith("=")) Then
            ' if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
            Dim tableCodeName As String = fkColumn.PrimaryKeyTableDefinition.TableCodeName
            Dim column As String = _DFKA.Trim("="c).Trim()
            If column.StartsWith(tableCodeName & ".", StringComparison.InvariantCultureIgnoreCase) Then
                column = column.Substring(tableCodeName.Length + 1)
            End If

            For Each c As BaseColumn In fkColumn.PrimaryKeyTableDefinition.Columns
                If column = c.CodeName Then
                    Return rec.Format(c)
                End If
            Next        
			Dim tableName As String = fkColumn.PrimaryKeyTableDefinition.TableCodeName
			Return EvaluateFormula(_DFKA, rec, Nothing, tableName)
		Else
            Return Nothing
        End If
    End Function

	''' <summary>
    ''' This method takes a keyValue and a Column and returns an evaluated value of DFKA formula.
    ''' </summary>
	Public Shared Function GetDFKA(ByVal keyValue As String, ByVal col As BaseColumn, ByVal formatPattern as String) As String
	    If keyValue Is Nothing Then
 			Return Nothing
		End If
	    Dim fkColumn As ForeignKey = AgreementExecutionTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
	    If fkColumn Is Nothing Then
 			Return Nothing
		End If
        Dim _DFKA As String = fkColumn.PrimaryKeyDisplayColumns
        If (_DFKA.Trim().StartsWith("=")) Then
			Dim tableName As String = fkColumn.PrimaryKeyTableDefinition.TableCodeName
			Dim t As PrimaryKeyTable = CType(DatabaseObjects.GetTableObject(tableName), PrimaryKeyTable)
			Dim rec As BaseRecord = Nothing
			If Not t Is Nothing Then
				Try
					rec = CType(t.GetRecordData(keyValue, False), BaseRecord)
				Catch 
					rec = Nothing
				End Try
			End If
			If rec Is Nothing Then
				Return ""
			End If
			
            ' if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
            Dim tableCodeName As String = fkColumn.PrimaryKeyTableDefinition.TableCodeName
            Dim column As String = _DFKA.Trim("="c).Trim()
            If column.StartsWith(tableCodeName & ".", StringComparison.InvariantCultureIgnoreCase) Then
                column = column.Substring(tableCodeName.Length + 1)
            End If

            For Each c As BaseColumn In fkColumn.PrimaryKeyTableDefinition.Columns
                If column = c.CodeName Then
                    Return rec.Format(c)
                End If
            Next			
			Return EvaluateFormula(_DFKA, rec, Nothing, tableName)
		Else
            Return Nothing
        End If
    End Function

	''' <summary>
    ''' Evaluates the formula
    ''' </summary>
	Public Shared Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format As String = Nothing, Optional ByVal name As String = "") As String
		Dim e As BaseFormulaEvaluator = New BaseFormulaEvaluator()
		If Not dataSourceForEvaluate Is Nothing Then
			e.Evaluator.Variables.Add(name, dataSourceForEvaluate)
        end if
        e.DataSource = dataSourceForEvaluate

        Dim resultObj As Object = e.Evaluate(formula)
        If resultObj Is Nothing Then
	        Return ""
        End If
        If Not String.IsNullOrEmpty(format) Then
            Return BaseFormulaUtils.Format(resultObj, format)
        Else
            Return resultObj.ToString()
        End If
    End Function


#End Region 

End Class
End Namespace
