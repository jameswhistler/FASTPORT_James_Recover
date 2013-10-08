' This class is "generated" and will be overwritten.
' Your customizations should be made in AgreementRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="AgreementTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named Agreement.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="AgreementTable.Instance">AgreementTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="AgreementTable"></seealso>

<Serializable()> Public Class BaseAgreementTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = AgreementDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.AgreementTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.AgreementRecord")
        Me.ApplicationName = "FASTPORT"
        Me.DataAdapter = New AgreementSqlTable()
        Directcast(Me.DataAdapter, AgreementSqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, AgreementSqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        AgreementIDColumn.CodeName = "AgreementID"
        CIXColumn.CodeName = "CIX"
        DocTreeParentIDColumn.CodeName = "DocTreeParentID"
        RoleIDColumn.CodeName = "RoleID"
        CustomIDColumn.CodeName = "CustomID"
        DocIndexColumn.CodeName = "DocIndex"
        DocSortColumn.CodeName = "DocSort"
        AgreementColumn.CodeName = "Agreement"
        DescriptionColumn.CodeName = "Description"
        RequiredDocColumn.CodeName = "RequiredDoc"
        DocRankColumn.CodeName = "DocRank"
        HideColumn.CodeName = "Hide"
        AgreementFileColumn.CodeName = "AgreementFile"
        AgreementFileNameColumn.CodeName = "AgreementFileName"
        FlowCollectionIDColumn.CodeName = "FlowCollectionID"
        UseStoredSignatureColumn.CodeName = "UseStoredSignature"
        ShowSignatureDateColumn.CodeName = "ShowSignatureDate"
        ShowExpirationDateColumn.CodeName = "ShowExpirationDate"
        InitialsInDocumentColumn.CodeName = "InitialsInDocument"
        DocHasCustomFieldsColumn.CodeName = "DocHasCustomFields"
        ExecuteFromBoardColumn.CodeName = "ExecuteFromBoard"
        SenderInstructionsColumn.CodeName = "SenderInstructions"
        RecipientInstructionsColumn.CodeName = "RecipientInstructions"
        OtherInstructionsColumn.CodeName = "OtherInstructions"
        FirstItemColumn.CodeName = "FirstItem"
        FirstTypeIDColumn.CodeName = "FirstTypeID"
        FirstDefaultColumn.CodeName = "FirstDefault"
        FirstByCIXColumn.CodeName = "FirstByCIX"
        FirstByOIXColumn.CodeName = "FirstByOIX"
        SecondItemColumn.CodeName = "SecondItem"
        SecondTypeIDColumn.CodeName = "SecondTypeID"
        SecondDefaultColumn.CodeName = "SecondDefault"
        SecondByCIXColumn.CodeName = "SecondByCIX"
        SecondByOIXColumn.CodeName = "SecondByOIX"
        ThirdItemColumn.CodeName = "ThirdItem"
        ThirdTypeIDColumn.CodeName = "ThirdTypeID"
        ThirdDefaultColumn.CodeName = "ThirdDefault"
        ThirdByCIXColumn.CodeName = "ThirdByCIX"
        ThirdByOIXColumn.CodeName = "ThirdByOIX"
        FourthItemColumn.CodeName = "FourthItem"
        FourthTypeIDColumn.CodeName = "FourthTypeID"
        FourthDefaultColumn.CodeName = "FourthDefault"
        FourthByCIXColumn.CodeName = "FourthByCIX"
        FourthByOIXColumn.CodeName = "FourthByOIX"
        FifthItemColumn.CodeName = "FifthItem"
        FifthTypeIDColumn.CodeName = "FifthTypeID"
        FifthDefaultColumn.CodeName = "FifthDefault"
        FifthByCIXColumn.CodeName = "FifthByCIX"
        FifthByOIXColumn.CodeName = "FifthByOIX"
        SixthItemColumn.CodeName = "SixthItem"
        SixthTypeIDColumn.CodeName = "SixthTypeID"
        SixthDefaultColumn.CodeName = "SixthDefault"
        SixthByCIXColumn.CodeName = "SixthByCIX"
        SixthByOIXColumn.CodeName = "SixthByOIX"
        SeventhItemColumn.CodeName = "SeventhItem"
        SeventhTypeIDColumn.CodeName = "SeventhTypeID"
        SeventhDefaultColumn.CodeName = "SeventhDefault"
        SeventhByCIXColumn.CodeName = "SeventhByCIX"
        SeventhByOIXColumn.CodeName = "SeventhByOIX"
        EighthItemColumn.CodeName = "EighthItem"
        EighthTypeIDColumn.CodeName = "EighthTypeID"
        EighthDefaultColumn.CodeName = "EighthDefault"
        EighthByCIXColumn.CodeName = "EighthByCIX"
        EighthByOIXColumn.CodeName = "EighthByOIX"
        NinthItemColumn.CodeName = "NinthItem"
        NinthTypeIDColumn.CodeName = "NinthTypeID"
        NinthDefaultColumn.CodeName = "NinthDefault"
        NinthByCIXColumn.CodeName = "NinthByCIX"
        NinthByOIXColumn.CodeName = "NinthByOIX"
        TenthItemColumn.CodeName = "TenthItem"
        TenthTypeIDColumn.CodeName = "TenthTypeID"
        TenthDefaultColumn.CodeName = "TenthDefault"
        TenthByCIXColumn.CodeName = "TenthByCIX"
        TenthByOIXColumn.CodeName = "TenthByOIX"
        EleventhItemColumn.CodeName = "EleventhItem"
        EleventhTypeIDColumn.CodeName = "EleventhTypeID"
        EleventhDefaultColumn.CodeName = "EleventhDefault"
        EleventhByCIXColumn.CodeName = "EleventhByCIX"
        EleventhByOIXColumn.CodeName = "EleventhByOIX"
        TwelfthItemColumn.CodeName = "TwelfthItem"
        TwelfthTypeIDColumn.CodeName = "TwelfthTypeID"
        TwelfthDefaultColumn.CodeName = "TwelfthDefault"
        TwelfthByCIXColumn.CodeName = "TwelfthByCIX"
        TwelfthByOIXColumn.CodeName = "TwelfthByOIX"
        ThirteenthItemColumn.CodeName = "ThirteenthItem"
        ThirteenthTypeIDColumn.CodeName = "ThirteenthTypeID"
        ThirteenthDefaultColumn.CodeName = "ThirteenthDefault"
        ThirteenthByCIXColumn.CodeName = "ThirteenthByCIX"
        ThirteenthByOIXColumn.CodeName = "ThirteenthByOIX"
        FourteenthItemColumn.CodeName = "FourteenthItem"
        FourteenthTypeIDColumn.CodeName = "FourteenthTypeID"
        FourteenthDefaultColumn.CodeName = "FourteenthDefault"
        FourteenthByCIXColumn.CodeName = "FourteenthByCIX"
        FourteenthByOIXColumn.CodeName = "FourteenthByOIX"
        FifteenthItemColumn.CodeName = "FifteenthItem"
        FifteenthTypeIDColumn.CodeName = "FifteenthTypeID"
        FifteenthDefaultColumn.CodeName = "FifteenthDefault"
        FifteenthByCIXColumn.CodeName = "FifteenthByCIX"
        FifteenthByOIXColumn.CodeName = "FifteenthByOIX"
        CreatedByIDColumn.CodeName = "CreatedByID"
        CreatedAtColumn.CodeName = "CreatedAt"
        UpdatedByIDColumn.CodeName = "UpdatedByID"
        UpdatedAtColumn.CodeName = "UpdatedAt"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.AgreementID column object.
    ''' </summary>
    Public ReadOnly Property AgreementIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.AgreementID column object.
    ''' </summary>
    Public Shared ReadOnly Property AgreementID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.AgreementIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.CIX column object.
    ''' </summary>
    Public ReadOnly Property CIXColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.CIX column object.
    ''' </summary>
    Public Shared ReadOnly Property CIX() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.CIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.DocTreeParentID column object.
    ''' </summary>
    Public ReadOnly Property DocTreeParentIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.DocTreeParentID column object.
    ''' </summary>
    Public Shared ReadOnly Property DocTreeParentID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.DocTreeParentIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.RoleID column object.
    ''' </summary>
    Public ReadOnly Property RoleIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.RoleID column object.
    ''' </summary>
    Public Shared ReadOnly Property RoleID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.RoleIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.CustomID column object.
    ''' </summary>
    Public ReadOnly Property CustomIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.CustomID column object.
    ''' </summary>
    Public Shared ReadOnly Property CustomID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.CustomIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.DocIndex column object.
    ''' </summary>
    Public ReadOnly Property DocIndexColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.DocIndex column object.
    ''' </summary>
    Public Shared ReadOnly Property DocIndex() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.DocIndexColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.DocSort column object.
    ''' </summary>
    Public ReadOnly Property DocSortColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.DocSort column object.
    ''' </summary>
    Public Shared ReadOnly Property DocSort() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.DocSortColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.Agreement column object.
    ''' </summary>
    Public ReadOnly Property AgreementColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.Agreement column object.
    ''' </summary>
    Public Shared ReadOnly Property Agreement() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.AgreementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.Description column object.
    ''' </summary>
    Public ReadOnly Property DescriptionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.Description column object.
    ''' </summary>
    Public Shared ReadOnly Property Description() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.DescriptionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.RequiredDoc column object.
    ''' </summary>
    Public ReadOnly Property RequiredDocColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.RequiredDoc column object.
    ''' </summary>
    Public Shared ReadOnly Property RequiredDoc() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.RequiredDocColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.DocRank column object.
    ''' </summary>
    Public ReadOnly Property DocRankColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.DocRank column object.
    ''' </summary>
    Public Shared ReadOnly Property DocRank() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.DocRankColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.Hide column object.
    ''' </summary>
    Public ReadOnly Property HideColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.Hide column object.
    ''' </summary>
    Public Shared ReadOnly Property Hide() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.HideColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.AgreementFile column object.
    ''' </summary>
    Public ReadOnly Property AgreementFileColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.AgreementFile column object.
    ''' </summary>
    Public Shared ReadOnly Property AgreementFile() As BaseClasses.Data.ImageColumn
        Get
            Return AgreementTable.Instance.AgreementFileColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.AgreementFileName column object.
    ''' </summary>
    Public ReadOnly Property AgreementFileNameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.AgreementFileName column object.
    ''' </summary>
    Public Shared ReadOnly Property AgreementFileName() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.AgreementFileNameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FlowCollectionID column object.
    ''' </summary>
    Public ReadOnly Property FlowCollectionIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FlowCollectionID column object.
    ''' </summary>
    Public Shared ReadOnly Property FlowCollectionID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.FlowCollectionIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.UseStoredSignature column object.
    ''' </summary>
    Public ReadOnly Property UseStoredSignatureColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.UseStoredSignature column object.
    ''' </summary>
    Public Shared ReadOnly Property UseStoredSignature() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.UseStoredSignatureColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ShowSignatureDate column object.
    ''' </summary>
    Public ReadOnly Property ShowSignatureDateColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ShowSignatureDate column object.
    ''' </summary>
    Public Shared ReadOnly Property ShowSignatureDate() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.ShowSignatureDateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ShowExpirationDate column object.
    ''' </summary>
    Public ReadOnly Property ShowExpirationDateColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ShowExpirationDate column object.
    ''' </summary>
    Public Shared ReadOnly Property ShowExpirationDate() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.ShowExpirationDateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.InitialsInDocument column object.
    ''' </summary>
    Public ReadOnly Property InitialsInDocumentColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.InitialsInDocument column object.
    ''' </summary>
    Public Shared ReadOnly Property InitialsInDocument() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.InitialsInDocumentColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.DocHasCustomFields column object.
    ''' </summary>
    Public ReadOnly Property DocHasCustomFieldsColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.DocHasCustomFields column object.
    ''' </summary>
    Public Shared ReadOnly Property DocHasCustomFields() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.DocHasCustomFieldsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ExecuteFromBoard column object.
    ''' </summary>
    Public ReadOnly Property ExecuteFromBoardColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ExecuteFromBoard column object.
    ''' </summary>
    Public Shared ReadOnly Property ExecuteFromBoard() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.ExecuteFromBoardColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SenderInstructions column object.
    ''' </summary>
    Public ReadOnly Property SenderInstructionsColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SenderInstructions column object.
    ''' </summary>
    Public Shared ReadOnly Property SenderInstructions() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.SenderInstructionsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.RecipientInstructions column object.
    ''' </summary>
    Public ReadOnly Property RecipientInstructionsColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.RecipientInstructions column object.
    ''' </summary>
    Public Shared ReadOnly Property RecipientInstructions() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.RecipientInstructionsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.OtherInstructions column object.
    ''' </summary>
    Public ReadOnly Property OtherInstructionsColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.OtherInstructions column object.
    ''' </summary>
    Public Shared ReadOnly Property OtherInstructions() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.OtherInstructionsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FirstItem column object.
    ''' </summary>
    Public ReadOnly Property FirstItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FirstItem column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.FirstItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FirstTypeID column object.
    ''' </summary>
    Public ReadOnly Property FirstTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FirstTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.FirstTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FirstDefault column object.
    ''' </summary>
    Public ReadOnly Property FirstDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FirstDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.FirstDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FirstByCIX column object.
    ''' </summary>
    Public ReadOnly Property FirstByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FirstByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.FirstByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FirstByOIX column object.
    ''' </summary>
    Public ReadOnly Property FirstByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FirstByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.FirstByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SecondItem column object.
    ''' </summary>
    Public ReadOnly Property SecondItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SecondItem column object.
    ''' </summary>
    Public Shared ReadOnly Property SecondItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.SecondItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SecondTypeID column object.
    ''' </summary>
    Public ReadOnly Property SecondTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SecondTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property SecondTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.SecondTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SecondDefault column object.
    ''' </summary>
    Public ReadOnly Property SecondDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SecondDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property SecondDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.SecondDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SecondByCIX column object.
    ''' </summary>
    Public ReadOnly Property SecondByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(32), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SecondByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property SecondByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.SecondByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SecondByOIX column object.
    ''' </summary>
    Public ReadOnly Property SecondByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(33), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SecondByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property SecondByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.SecondByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirdItem column object.
    ''' </summary>
    Public ReadOnly Property ThirdItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(34), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirdItem column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirdItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.ThirdItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirdTypeID column object.
    ''' </summary>
    Public ReadOnly Property ThirdTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(35), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirdTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirdTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.ThirdTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirdDefault column object.
    ''' </summary>
    Public ReadOnly Property ThirdDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(36), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirdDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirdDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.ThirdDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirdByCIX column object.
    ''' </summary>
    Public ReadOnly Property ThirdByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(37), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirdByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirdByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.ThirdByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirdByOIX column object.
    ''' </summary>
    Public ReadOnly Property ThirdByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(38), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirdByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirdByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.ThirdByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourthItem column object.
    ''' </summary>
    Public ReadOnly Property FourthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(39), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property FourthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.FourthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourthTypeID column object.
    ''' </summary>
    Public ReadOnly Property FourthTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(40), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourthTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property FourthTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.FourthTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourthDefault column object.
    ''' </summary>
    Public ReadOnly Property FourthDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(41), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourthDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property FourthDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.FourthDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourthByCIX column object.
    ''' </summary>
    Public ReadOnly Property FourthByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(42), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourthByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property FourthByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.FourthByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourthByOIX column object.
    ''' </summary>
    Public ReadOnly Property FourthByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(43), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourthByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property FourthByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.FourthByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifthItem column object.
    ''' </summary>
    Public ReadOnly Property FifthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(44), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property FifthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.FifthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifthTypeID column object.
    ''' </summary>
    Public ReadOnly Property FifthTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(45), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifthTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property FifthTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.FifthTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifthDefault column object.
    ''' </summary>
    Public ReadOnly Property FifthDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(46), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifthDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property FifthDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.FifthDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifthByCIX column object.
    ''' </summary>
    Public ReadOnly Property FifthByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(47), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifthByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property FifthByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.FifthByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifthByOIX column object.
    ''' </summary>
    Public ReadOnly Property FifthByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(48), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifthByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property FifthByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.FifthByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SixthItem column object.
    ''' </summary>
    Public ReadOnly Property SixthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(49), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SixthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property SixthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.SixthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SixthTypeID column object.
    ''' </summary>
    Public ReadOnly Property SixthTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(50), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SixthTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property SixthTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.SixthTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SixthDefault column object.
    ''' </summary>
    Public ReadOnly Property SixthDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(51), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SixthDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property SixthDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.SixthDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SixthByCIX column object.
    ''' </summary>
    Public ReadOnly Property SixthByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(52), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SixthByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property SixthByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.SixthByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SixthByOIX column object.
    ''' </summary>
    Public ReadOnly Property SixthByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(53), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SixthByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property SixthByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.SixthByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SeventhItem column object.
    ''' </summary>
    Public ReadOnly Property SeventhItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(54), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SeventhItem column object.
    ''' </summary>
    Public Shared ReadOnly Property SeventhItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.SeventhItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SeventhTypeID column object.
    ''' </summary>
    Public ReadOnly Property SeventhTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(55), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SeventhTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property SeventhTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.SeventhTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SeventhDefault column object.
    ''' </summary>
    Public ReadOnly Property SeventhDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(56), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SeventhDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property SeventhDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.SeventhDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SeventhByCIX column object.
    ''' </summary>
    Public ReadOnly Property SeventhByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(57), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SeventhByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property SeventhByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.SeventhByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SeventhByOIX column object.
    ''' </summary>
    Public ReadOnly Property SeventhByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(58), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.SeventhByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property SeventhByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.SeventhByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EighthItem column object.
    ''' </summary>
    Public ReadOnly Property EighthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(59), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EighthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property EighthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.EighthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EighthTypeID column object.
    ''' </summary>
    Public ReadOnly Property EighthTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(60), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EighthTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property EighthTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.EighthTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EighthDefault column object.
    ''' </summary>
    Public ReadOnly Property EighthDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(61), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EighthDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property EighthDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.EighthDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EighthByCIX column object.
    ''' </summary>
    Public ReadOnly Property EighthByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(62), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EighthByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property EighthByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.EighthByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EighthByOIX column object.
    ''' </summary>
    Public ReadOnly Property EighthByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(63), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EighthByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property EighthByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.EighthByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.NinthItem column object.
    ''' </summary>
    Public ReadOnly Property NinthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(64), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.NinthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property NinthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.NinthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.NinthTypeID column object.
    ''' </summary>
    Public ReadOnly Property NinthTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(65), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.NinthTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property NinthTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.NinthTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.NinthDefault column object.
    ''' </summary>
    Public ReadOnly Property NinthDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(66), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.NinthDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property NinthDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.NinthDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.NinthByCIX column object.
    ''' </summary>
    Public ReadOnly Property NinthByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(67), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.NinthByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property NinthByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.NinthByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.NinthByOIX column object.
    ''' </summary>
    Public ReadOnly Property NinthByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(68), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.NinthByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property NinthByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.NinthByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TenthItem column object.
    ''' </summary>
    Public ReadOnly Property TenthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(69), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TenthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property TenthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.TenthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TenthTypeID column object.
    ''' </summary>
    Public ReadOnly Property TenthTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(70), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TenthTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property TenthTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.TenthTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TenthDefault column object.
    ''' </summary>
    Public ReadOnly Property TenthDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(71), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TenthDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property TenthDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.TenthDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TenthByCIX column object.
    ''' </summary>
    Public ReadOnly Property TenthByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(72), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TenthByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property TenthByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.TenthByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TenthByOIX column object.
    ''' </summary>
    Public ReadOnly Property TenthByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(73), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TenthByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property TenthByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.TenthByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EleventhItem column object.
    ''' </summary>
    Public ReadOnly Property EleventhItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(74), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EleventhItem column object.
    ''' </summary>
    Public Shared ReadOnly Property EleventhItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.EleventhItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EleventhTypeID column object.
    ''' </summary>
    Public ReadOnly Property EleventhTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(75), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EleventhTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property EleventhTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.EleventhTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EleventhDefault column object.
    ''' </summary>
    Public ReadOnly Property EleventhDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(76), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EleventhDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property EleventhDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.EleventhDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EleventhByCIX column object.
    ''' </summary>
    Public ReadOnly Property EleventhByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(77), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EleventhByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property EleventhByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.EleventhByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EleventhByOIX column object.
    ''' </summary>
    Public ReadOnly Property EleventhByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(78), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.EleventhByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property EleventhByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.EleventhByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TwelfthItem column object.
    ''' </summary>
    Public ReadOnly Property TwelfthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(79), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TwelfthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property TwelfthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.TwelfthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TwelfthTypeID column object.
    ''' </summary>
    Public ReadOnly Property TwelfthTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(80), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TwelfthTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property TwelfthTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.TwelfthTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TwelfthDefault column object.
    ''' </summary>
    Public ReadOnly Property TwelfthDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(81), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TwelfthDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property TwelfthDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.TwelfthDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TwelfthByCIX column object.
    ''' </summary>
    Public ReadOnly Property TwelfthByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(82), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TwelfthByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property TwelfthByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.TwelfthByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TwelfthByOIX column object.
    ''' </summary>
    Public ReadOnly Property TwelfthByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(83), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.TwelfthByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property TwelfthByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.TwelfthByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirteenthItem column object.
    ''' </summary>
    Public ReadOnly Property ThirteenthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(84), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirteenthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirteenthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.ThirteenthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirteenthTypeID column object.
    ''' </summary>
    Public ReadOnly Property ThirteenthTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(85), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirteenthTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirteenthTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.ThirteenthTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirteenthDefault column object.
    ''' </summary>
    Public ReadOnly Property ThirteenthDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(86), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirteenthDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirteenthDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.ThirteenthDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirteenthByCIX column object.
    ''' </summary>
    Public ReadOnly Property ThirteenthByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(87), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirteenthByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirteenthByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.ThirteenthByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirteenthByOIX column object.
    ''' </summary>
    Public ReadOnly Property ThirteenthByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(88), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.ThirteenthByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirteenthByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.ThirteenthByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourteenthItem column object.
    ''' </summary>
    Public ReadOnly Property FourteenthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(89), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourteenthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property FourteenthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.FourteenthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourteenthTypeID column object.
    ''' </summary>
    Public ReadOnly Property FourteenthTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(90), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourteenthTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property FourteenthTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.FourteenthTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourteenthDefault column object.
    ''' </summary>
    Public ReadOnly Property FourteenthDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(91), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourteenthDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property FourteenthDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.FourteenthDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourteenthByCIX column object.
    ''' </summary>
    Public ReadOnly Property FourteenthByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(92), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourteenthByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property FourteenthByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.FourteenthByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourteenthByOIX column object.
    ''' </summary>
    Public ReadOnly Property FourteenthByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(93), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FourteenthByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property FourteenthByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.FourteenthByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifteenthItem column object.
    ''' </summary>
    Public ReadOnly Property FifteenthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(94), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifteenthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property FifteenthItem() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.FifteenthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifteenthTypeID column object.
    ''' </summary>
    Public ReadOnly Property FifteenthTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(95), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifteenthTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property FifteenthTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.FifteenthTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifteenthDefault column object.
    ''' </summary>
    Public ReadOnly Property FifteenthDefaultColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(96), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifteenthDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property FifteenthDefault() As BaseClasses.Data.StringColumn
        Get
            Return AgreementTable.Instance.FifteenthDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifteenthByCIX column object.
    ''' </summary>
    Public ReadOnly Property FifteenthByCIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(97), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifteenthByCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property FifteenthByCIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.FifteenthByCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifteenthByOIX column object.
    ''' </summary>
    Public ReadOnly Property FifteenthByOIXColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(98), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.FifteenthByOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property FifteenthByOIX() As BaseClasses.Data.BooleanColumn
        Get
            Return AgreementTable.Instance.FifteenthByOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.CreatedByID column object.
    ''' </summary>
    Public ReadOnly Property CreatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(99), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.CreatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.CreatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.CreatedAt column object.
    ''' </summary>
    Public ReadOnly Property CreatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(100), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.CreatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedAt() As BaseClasses.Data.DateColumn
        Get
            Return AgreementTable.Instance.CreatedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.UpdatedByID column object.
    ''' </summary>
    Public ReadOnly Property UpdatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(101), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.UpdatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return AgreementTable.Instance.UpdatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.UpdatedAt column object.
    ''' </summary>
    Public ReadOnly Property UpdatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(102), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Agreement_.UpdatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedAt() As BaseClasses.Data.DateColumn
        Get
            Return AgreementTable.Instance.UpdatedAtColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of AgreementRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As AgreementRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of AgreementRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As AgreementRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of AgreementRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As AgreementRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of AgreementRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As AgreementRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of AgreementRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As AgreementRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  AgreementTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.AgreementRecord)), AgreementRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of AgreementRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As AgreementRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  AgreementTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.AgreementRecord)), AgreementRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As AgreementRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = AgreementTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.AgreementRecord)), AgreementRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As AgreementRecord()

        Dim recList As ArrayList = AgreementTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.AgreementRecord)), AgreementRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As AgreementRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = AgreementTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.AgreementRecord)), AgreementRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As AgreementRecord()

        Dim recList As ArrayList = AgreementTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.AgreementRecord)), AgreementRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(AgreementTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(AgreementTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(AgreementTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(AgreementTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a AgreementRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As AgreementRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a AgreementRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As AgreementRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a AgreementRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As AgreementRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = AgreementTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As AgreementRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), AgreementRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a AgreementRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As AgreementRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = AgreementTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As AgreementRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), AgreementRecord)
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

        Return AgreementTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return AgreementTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As AgreementRecord = GetRecords(where)
        Return AgreementTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As AgreementRecord = GetRecords(join, where)
        Return AgreementTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As AgreementRecord = GetRecords(where, orderBy)
        Return AgreementTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As AgreementRecord = GetRecords(join, where, orderBy)
        Return AgreementTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As AgreementRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return AgreementTable.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As AgreementRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return AgreementTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        AgreementTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return AgreementTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return AgreementTable.Instance.ExportRecordData(whereFilter)
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

        Return AgreementTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return AgreementTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return AgreementTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return AgreementTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return AgreementTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return AgreementTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return AgreementTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return AgreementTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = AgreementTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As AgreementRecord
        Return CType(AgreementTable.Instance.GetRecordData(id, bMutable), AgreementRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As AgreementRecord
        Return CType(AgreementTable.Instance.GetRecordData(id, bMutable), AgreementRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal CIXValue As String, _
        ByVal DocTreeParentIDValue As String, _
        ByVal RoleIDValue As String, _
        ByVal CustomIDValue As String, _
        ByVal DocIndexValue As String, _
        ByVal DocSortValue As String, _
        ByVal AgreementValue As String, _
        ByVal DescriptionValue As String, _
        ByVal RequiredDocValue As String, _
        ByVal DocRankValue As String, _
        ByVal HideValue As String, _
        ByVal AgreementFileValue As String, _
        ByVal AgreementFileNameValue As String, _
        ByVal FlowCollectionIDValue As String, _
        ByVal UseStoredSignatureValue As String, _
        ByVal ShowSignatureDateValue As String, _
        ByVal ShowExpirationDateValue As String, _
        ByVal InitialsInDocumentValue As String, _
        ByVal DocHasCustomFieldsValue As String, _
        ByVal ExecuteFromBoardValue As String, _
        ByVal SenderInstructionsValue As String, _
        ByVal RecipientInstructionsValue As String, _
        ByVal OtherInstructionsValue As String, _
        ByVal FirstItemValue As String, _
        ByVal FirstTypeIDValue As String, _
        ByVal FirstDefaultValue As String, _
        ByVal FirstByCIXValue As String, _
        ByVal FirstByOIXValue As String, _
        ByVal SecondItemValue As String, _
        ByVal SecondTypeIDValue As String, _
        ByVal SecondDefaultValue As String, _
        ByVal SecondByCIXValue As String, _
        ByVal SecondByOIXValue As String, _
        ByVal ThirdItemValue As String, _
        ByVal ThirdTypeIDValue As String, _
        ByVal ThirdDefaultValue As String, _
        ByVal ThirdByCIXValue As String, _
        ByVal ThirdByOIXValue As String, _
        ByVal FourthItemValue As String, _
        ByVal FourthTypeIDValue As String, _
        ByVal FourthDefaultValue As String, _
        ByVal FourthByCIXValue As String, _
        ByVal FourthByOIXValue As String, _
        ByVal FifthItemValue As String, _
        ByVal FifthTypeIDValue As String, _
        ByVal FifthDefaultValue As String, _
        ByVal FifthByCIXValue As String, _
        ByVal FifthByOIXValue As String, _
        ByVal SixthItemValue As String, _
        ByVal SixthTypeIDValue As String, _
        ByVal SixthDefaultValue As String, _
        ByVal SixthByCIXValue As String, _
        ByVal SixthByOIXValue As String, _
        ByVal SeventhItemValue As String, _
        ByVal SeventhTypeIDValue As String, _
        ByVal SeventhDefaultValue As String, _
        ByVal SeventhByCIXValue As String, _
        ByVal SeventhByOIXValue As String, _
        ByVal EighthItemValue As String, _
        ByVal EighthTypeIDValue As String, _
        ByVal EighthDefaultValue As String, _
        ByVal EighthByCIXValue As String, _
        ByVal EighthByOIXValue As String, _
        ByVal NinthItemValue As String, _
        ByVal NinthTypeIDValue As String, _
        ByVal NinthDefaultValue As String, _
        ByVal NinthByCIXValue As String, _
        ByVal NinthByOIXValue As String, _
        ByVal TenthItemValue As String, _
        ByVal TenthTypeIDValue As String, _
        ByVal TenthDefaultValue As String, _
        ByVal TenthByCIXValue As String, _
        ByVal TenthByOIXValue As String, _
        ByVal EleventhItemValue As String, _
        ByVal EleventhTypeIDValue As String, _
        ByVal EleventhDefaultValue As String, _
        ByVal EleventhByCIXValue As String, _
        ByVal EleventhByOIXValue As String, _
        ByVal TwelfthItemValue As String, _
        ByVal TwelfthTypeIDValue As String, _
        ByVal TwelfthDefaultValue As String, _
        ByVal TwelfthByCIXValue As String, _
        ByVal TwelfthByOIXValue As String, _
        ByVal ThirteenthItemValue As String, _
        ByVal ThirteenthTypeIDValue As String, _
        ByVal ThirteenthDefaultValue As String, _
        ByVal ThirteenthByCIXValue As String, _
        ByVal ThirteenthByOIXValue As String, _
        ByVal FourteenthItemValue As String, _
        ByVal FourteenthTypeIDValue As String, _
        ByVal FourteenthDefaultValue As String, _
        ByVal FourteenthByCIXValue As String, _
        ByVal FourteenthByOIXValue As String, _
        ByVal FifteenthItemValue As String, _
        ByVal FifteenthTypeIDValue As String, _
        ByVal FifteenthDefaultValue As String, _
        ByVal FifteenthByCIXValue As String, _
        ByVal FifteenthByOIXValue As String, _
        ByVal CreatedByIDValue As String, _
        ByVal CreatedAtValue As String, _
        ByVal UpdatedByIDValue As String, _
        ByVal UpdatedAtValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(CIXValue, CIXColumn)
        rec.SetString(DocTreeParentIDValue, DocTreeParentIDColumn)
        rec.SetString(RoleIDValue, RoleIDColumn)
        rec.SetString(CustomIDValue, CustomIDColumn)
        rec.SetString(DocIndexValue, DocIndexColumn)
        rec.SetString(DocSortValue, DocSortColumn)
        rec.SetString(AgreementValue, AgreementColumn)
        rec.SetString(DescriptionValue, DescriptionColumn)
        rec.SetString(RequiredDocValue, RequiredDocColumn)
        rec.SetString(DocRankValue, DocRankColumn)
        rec.SetString(HideValue, HideColumn)
        rec.SetString(AgreementFileValue, AgreementFileColumn)
        rec.SetString(AgreementFileNameValue, AgreementFileNameColumn)
        rec.SetString(FlowCollectionIDValue, FlowCollectionIDColumn)
        rec.SetString(UseStoredSignatureValue, UseStoredSignatureColumn)
        rec.SetString(ShowSignatureDateValue, ShowSignatureDateColumn)
        rec.SetString(ShowExpirationDateValue, ShowExpirationDateColumn)
        rec.SetString(InitialsInDocumentValue, InitialsInDocumentColumn)
        rec.SetString(DocHasCustomFieldsValue, DocHasCustomFieldsColumn)
        rec.SetString(ExecuteFromBoardValue, ExecuteFromBoardColumn)
        rec.SetString(SenderInstructionsValue, SenderInstructionsColumn)
        rec.SetString(RecipientInstructionsValue, RecipientInstructionsColumn)
        rec.SetString(OtherInstructionsValue, OtherInstructionsColumn)
        rec.SetString(FirstItemValue, FirstItemColumn)
        rec.SetString(FirstTypeIDValue, FirstTypeIDColumn)
        rec.SetString(FirstDefaultValue, FirstDefaultColumn)
        rec.SetString(FirstByCIXValue, FirstByCIXColumn)
        rec.SetString(FirstByOIXValue, FirstByOIXColumn)
        rec.SetString(SecondItemValue, SecondItemColumn)
        rec.SetString(SecondTypeIDValue, SecondTypeIDColumn)
        rec.SetString(SecondDefaultValue, SecondDefaultColumn)
        rec.SetString(SecondByCIXValue, SecondByCIXColumn)
        rec.SetString(SecondByOIXValue, SecondByOIXColumn)
        rec.SetString(ThirdItemValue, ThirdItemColumn)
        rec.SetString(ThirdTypeIDValue, ThirdTypeIDColumn)
        rec.SetString(ThirdDefaultValue, ThirdDefaultColumn)
        rec.SetString(ThirdByCIXValue, ThirdByCIXColumn)
        rec.SetString(ThirdByOIXValue, ThirdByOIXColumn)
        rec.SetString(FourthItemValue, FourthItemColumn)
        rec.SetString(FourthTypeIDValue, FourthTypeIDColumn)
        rec.SetString(FourthDefaultValue, FourthDefaultColumn)
        rec.SetString(FourthByCIXValue, FourthByCIXColumn)
        rec.SetString(FourthByOIXValue, FourthByOIXColumn)
        rec.SetString(FifthItemValue, FifthItemColumn)
        rec.SetString(FifthTypeIDValue, FifthTypeIDColumn)
        rec.SetString(FifthDefaultValue, FifthDefaultColumn)
        rec.SetString(FifthByCIXValue, FifthByCIXColumn)
        rec.SetString(FifthByOIXValue, FifthByOIXColumn)
        rec.SetString(SixthItemValue, SixthItemColumn)
        rec.SetString(SixthTypeIDValue, SixthTypeIDColumn)
        rec.SetString(SixthDefaultValue, SixthDefaultColumn)
        rec.SetString(SixthByCIXValue, SixthByCIXColumn)
        rec.SetString(SixthByOIXValue, SixthByOIXColumn)
        rec.SetString(SeventhItemValue, SeventhItemColumn)
        rec.SetString(SeventhTypeIDValue, SeventhTypeIDColumn)
        rec.SetString(SeventhDefaultValue, SeventhDefaultColumn)
        rec.SetString(SeventhByCIXValue, SeventhByCIXColumn)
        rec.SetString(SeventhByOIXValue, SeventhByOIXColumn)
        rec.SetString(EighthItemValue, EighthItemColumn)
        rec.SetString(EighthTypeIDValue, EighthTypeIDColumn)
        rec.SetString(EighthDefaultValue, EighthDefaultColumn)
        rec.SetString(EighthByCIXValue, EighthByCIXColumn)
        rec.SetString(EighthByOIXValue, EighthByOIXColumn)
        rec.SetString(NinthItemValue, NinthItemColumn)
        rec.SetString(NinthTypeIDValue, NinthTypeIDColumn)
        rec.SetString(NinthDefaultValue, NinthDefaultColumn)
        rec.SetString(NinthByCIXValue, NinthByCIXColumn)
        rec.SetString(NinthByOIXValue, NinthByOIXColumn)
        rec.SetString(TenthItemValue, TenthItemColumn)
        rec.SetString(TenthTypeIDValue, TenthTypeIDColumn)
        rec.SetString(TenthDefaultValue, TenthDefaultColumn)
        rec.SetString(TenthByCIXValue, TenthByCIXColumn)
        rec.SetString(TenthByOIXValue, TenthByOIXColumn)
        rec.SetString(EleventhItemValue, EleventhItemColumn)
        rec.SetString(EleventhTypeIDValue, EleventhTypeIDColumn)
        rec.SetString(EleventhDefaultValue, EleventhDefaultColumn)
        rec.SetString(EleventhByCIXValue, EleventhByCIXColumn)
        rec.SetString(EleventhByOIXValue, EleventhByOIXColumn)
        rec.SetString(TwelfthItemValue, TwelfthItemColumn)
        rec.SetString(TwelfthTypeIDValue, TwelfthTypeIDColumn)
        rec.SetString(TwelfthDefaultValue, TwelfthDefaultColumn)
        rec.SetString(TwelfthByCIXValue, TwelfthByCIXColumn)
        rec.SetString(TwelfthByOIXValue, TwelfthByOIXColumn)
        rec.SetString(ThirteenthItemValue, ThirteenthItemColumn)
        rec.SetString(ThirteenthTypeIDValue, ThirteenthTypeIDColumn)
        rec.SetString(ThirteenthDefaultValue, ThirteenthDefaultColumn)
        rec.SetString(ThirteenthByCIXValue, ThirteenthByCIXColumn)
        rec.SetString(ThirteenthByOIXValue, ThirteenthByOIXColumn)
        rec.SetString(FourteenthItemValue, FourteenthItemColumn)
        rec.SetString(FourteenthTypeIDValue, FourteenthTypeIDColumn)
        rec.SetString(FourteenthDefaultValue, FourteenthDefaultColumn)
        rec.SetString(FourteenthByCIXValue, FourteenthByCIXColumn)
        rec.SetString(FourteenthByOIXValue, FourteenthByOIXColumn)
        rec.SetString(FifteenthItemValue, FifteenthItemColumn)
        rec.SetString(FifteenthTypeIDValue, FifteenthTypeIDColumn)
        rec.SetString(FifteenthDefaultValue, FifteenthDefaultColumn)
        rec.SetString(FifteenthByCIXValue, FifteenthByCIXColumn)
        rec.SetString(FifteenthByOIXValue, FifteenthByOIXColumn)
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
        AgreementTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            AgreementTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(AgreementTable.Instance.TableDefinition.PrimaryKey)) Then
            Return AgreementTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(AgreementTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = AgreementTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = AgreementTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (AgreementTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = AgreementTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = AgreementTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = AgreementTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
