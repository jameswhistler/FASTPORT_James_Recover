' This class is "generated" and will be overwritten.
' Your customizations should be made in FlowConfigRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="FlowConfigTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named FlowConfig.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="FlowConfigTable.Instance">FlowConfigTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="FlowConfigTable"></seealso>

<Serializable()> Public Class BaseFlowConfigTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = FlowConfigDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.FlowConfigTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.FlowConfigRecord")
        Me.ApplicationName = "FASTPORT"
        Me.DataAdapter = New FlowConfigSqlTable()
        Directcast(Me.DataAdapter, FlowConfigSqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, FlowConfigSqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        ConfigIDColumn.CodeName = "ConfigID"
        FlowStepIDColumn.CodeName = "FlowStepID"
        ConfigRankColumn.CodeName = "ConfigRank"
        IntendedForIDColumn.CodeName = "IntendedForID"
        RoleIDColumn.CodeName = "RoleID"
        MustActColumn.CodeName = "MustAct"
        SkipJumpColumn.CodeName = "SkipJump"
        SendMessageColumn.CodeName = "SendMessage"
        DashboardColumn.CodeName = "Dashboard"
        PageTitle0Column.CodeName = "PageTitle0"
        InstructionsColumn.CodeName = "Instructions"
        LandingRedirectColumn.CodeName = "LandingRedirect"
        GoActionColumn.CodeName = "GoAction"
        VideoURLColumn.CodeName = "VideoURL"
        VideoDescriptionColumn.CodeName = "VideoDescription"
        FlowStepOneIDColumn.CodeName = "FlowStepOneID"
        ButtonOneIDColumn.CodeName = "ButtonOneID"
        FlowStepTwoIDColumn.CodeName = "FlowStepTwoID"
        ButtonTwoIDColumn.CodeName = "ButtonTwoID"
        FlowStepThreeIDColumn.CodeName = "FlowStepThreeID"
        ButtonThreeIDColumn.CodeName = "ButtonThreeID"
        FlowStepFourIDColumn.CodeName = "FlowStepFourID"
        ButtonFourIDColumn.CodeName = "ButtonFourID"
        RewindIDColumn.CodeName = "RewindID"
        FirstElementColumn.CodeName = "FirstElement"
        SecondElementColumn.CodeName = "SecondElement"
        ThirdElementColumn.CodeName = "ThirdElement"
        FourthElementColumn.CodeName = "FourthElement"
        FifthElementColumn.CodeName = "FifthElement"
        SixthElementColumn.CodeName = "SixthElement"
        SeventhElementColumn.CodeName = "SeventhElement"
        EighthElementColumn.CodeName = "EighthElement"
        NinthElementColumn.CodeName = "NinthElement"
        TenthElementColumn.CodeName = "TenthElement"
        EleventhElementColumn.CodeName = "EleventhElement"
        TwelfthElementColumn.CodeName = "TwelfthElement"
        ThirteenthElementColumn.CodeName = "ThirteenthElement"
        FourteenthElementColumn.CodeName = "FourteenthElement"
        FifteenthElementColumn.CodeName = "FifteenthElement"
        CreatedByIDColumn.CodeName = "CreatedByID"
        CreatedAtColumn.CodeName = "CreatedAt"
        UpdatedByIDColumn.CodeName = "UpdatedByID"
        UpdatedAtColumn.CodeName = "UpdatedAt"
        CopyConfigIDColumn.CodeName = "CopyConfigID"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ConfigID column object.
    ''' </summary>
    Public ReadOnly Property ConfigIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ConfigID column object.
    ''' </summary>
    Public Shared ReadOnly Property ConfigID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.ConfigIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FlowStepID column object.
    ''' </summary>
    Public ReadOnly Property FlowStepIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FlowStepID column object.
    ''' </summary>
    Public Shared ReadOnly Property FlowStepID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.FlowStepIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ConfigRank column object.
    ''' </summary>
    Public ReadOnly Property ConfigRankColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ConfigRank column object.
    ''' </summary>
    Public Shared ReadOnly Property ConfigRank() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.ConfigRankColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.IntendedForID column object.
    ''' </summary>
    Public ReadOnly Property IntendedForIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.IntendedForID column object.
    ''' </summary>
    Public Shared ReadOnly Property IntendedForID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.IntendedForIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.RoleID column object.
    ''' </summary>
    Public ReadOnly Property RoleIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.RoleID column object.
    ''' </summary>
    Public Shared ReadOnly Property RoleID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.RoleIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.MustAct column object.
    ''' </summary>
    Public ReadOnly Property MustActColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.MustAct column object.
    ''' </summary>
    Public Shared ReadOnly Property MustAct() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.MustActColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.SkipJump column object.
    ''' </summary>
    Public ReadOnly Property SkipJumpColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.SkipJump column object.
    ''' </summary>
    Public Shared ReadOnly Property SkipJump() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.SkipJumpColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.SendMessage column object.
    ''' </summary>
    Public ReadOnly Property SendMessageColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.SendMessage column object.
    ''' </summary>
    Public Shared ReadOnly Property SendMessage() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.SendMessageColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.Dashboard column object.
    ''' </summary>
    Public ReadOnly Property DashboardColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.Dashboard column object.
    ''' </summary>
    Public Shared ReadOnly Property Dashboard() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.DashboardColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.PageTitle column object.
    ''' </summary>
    Public ReadOnly Property PageTitle0Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.PageTitle column object.
    ''' </summary>
    Public Shared ReadOnly Property PageTitle0() As BaseClasses.Data.StringColumn
        Get
            Return FlowConfigTable.Instance.PageTitle0Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.Instructions column object.
    ''' </summary>
    Public ReadOnly Property InstructionsColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.Instructions column object.
    ''' </summary>
    Public Shared ReadOnly Property Instructions() As BaseClasses.Data.StringColumn
        Get
            Return FlowConfigTable.Instance.InstructionsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.LandingRedirect column object.
    ''' </summary>
    Public ReadOnly Property LandingRedirectColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.LandingRedirect column object.
    ''' </summary>
    Public Shared ReadOnly Property LandingRedirect() As BaseClasses.Data.StringColumn
        Get
            Return FlowConfigTable.Instance.LandingRedirectColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.GoAction column object.
    ''' </summary>
    Public ReadOnly Property GoActionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.GoAction column object.
    ''' </summary>
    Public Shared ReadOnly Property GoAction() As BaseClasses.Data.StringColumn
        Get
            Return FlowConfigTable.Instance.GoActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.VideoURL column object.
    ''' </summary>
    Public ReadOnly Property VideoURLColumn() As BaseClasses.Data.UrlColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.UrlColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.VideoURL column object.
    ''' </summary>
    Public Shared ReadOnly Property VideoURL() As BaseClasses.Data.UrlColumn
        Get
            Return FlowConfigTable.Instance.VideoURLColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.VideoDescription column object.
    ''' </summary>
    Public ReadOnly Property VideoDescriptionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.VideoDescription column object.
    ''' </summary>
    Public Shared ReadOnly Property VideoDescription() As BaseClasses.Data.StringColumn
        Get
            Return FlowConfigTable.Instance.VideoDescriptionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FlowStepOneID column object.
    ''' </summary>
    Public ReadOnly Property FlowStepOneIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FlowStepOneID column object.
    ''' </summary>
    Public Shared ReadOnly Property FlowStepOneID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.FlowStepOneIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ButtonOneID column object.
    ''' </summary>
    Public ReadOnly Property ButtonOneIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ButtonOneID column object.
    ''' </summary>
    Public Shared ReadOnly Property ButtonOneID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.ButtonOneIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FlowStepTwoID column object.
    ''' </summary>
    Public ReadOnly Property FlowStepTwoIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FlowStepTwoID column object.
    ''' </summary>
    Public Shared ReadOnly Property FlowStepTwoID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.FlowStepTwoIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ButtonTwoID column object.
    ''' </summary>
    Public ReadOnly Property ButtonTwoIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ButtonTwoID column object.
    ''' </summary>
    Public Shared ReadOnly Property ButtonTwoID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.ButtonTwoIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FlowStepThreeID column object.
    ''' </summary>
    Public ReadOnly Property FlowStepThreeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FlowStepThreeID column object.
    ''' </summary>
    Public Shared ReadOnly Property FlowStepThreeID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.FlowStepThreeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ButtonThreeID column object.
    ''' </summary>
    Public ReadOnly Property ButtonThreeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ButtonThreeID column object.
    ''' </summary>
    Public Shared ReadOnly Property ButtonThreeID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.ButtonThreeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FlowStepFourID column object.
    ''' </summary>
    Public ReadOnly Property FlowStepFourIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FlowStepFourID column object.
    ''' </summary>
    Public Shared ReadOnly Property FlowStepFourID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.FlowStepFourIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ButtonFourID column object.
    ''' </summary>
    Public ReadOnly Property ButtonFourIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ButtonFourID column object.
    ''' </summary>
    Public Shared ReadOnly Property ButtonFourID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.ButtonFourIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.RewindID column object.
    ''' </summary>
    Public ReadOnly Property RewindIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.RewindID column object.
    ''' </summary>
    Public Shared ReadOnly Property RewindID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.RewindIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FirstElement column object.
    ''' </summary>
    Public ReadOnly Property FirstElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FirstElement column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.FirstElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.SecondElement column object.
    ''' </summary>
    Public ReadOnly Property SecondElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.SecondElement column object.
    ''' </summary>
    Public Shared ReadOnly Property SecondElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.SecondElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ThirdElement column object.
    ''' </summary>
    Public ReadOnly Property ThirdElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ThirdElement column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirdElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.ThirdElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FourthElement column object.
    ''' </summary>
    Public ReadOnly Property FourthElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FourthElement column object.
    ''' </summary>
    Public Shared ReadOnly Property FourthElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.FourthElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FifthElement column object.
    ''' </summary>
    Public ReadOnly Property FifthElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FifthElement column object.
    ''' </summary>
    Public Shared ReadOnly Property FifthElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.FifthElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.SixthElement column object.
    ''' </summary>
    Public ReadOnly Property SixthElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.SixthElement column object.
    ''' </summary>
    Public Shared ReadOnly Property SixthElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.SixthElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.SeventhElement column object.
    ''' </summary>
    Public ReadOnly Property SeventhElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.SeventhElement column object.
    ''' </summary>
    Public Shared ReadOnly Property SeventhElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.SeventhElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.EighthElement column object.
    ''' </summary>
    Public ReadOnly Property EighthElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.EighthElement column object.
    ''' </summary>
    Public Shared ReadOnly Property EighthElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.EighthElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.NinthElement column object.
    ''' </summary>
    Public ReadOnly Property NinthElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(32), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.NinthElement column object.
    ''' </summary>
    Public Shared ReadOnly Property NinthElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.NinthElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.TenthElement column object.
    ''' </summary>
    Public ReadOnly Property TenthElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(33), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.TenthElement column object.
    ''' </summary>
    Public Shared ReadOnly Property TenthElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.TenthElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.EleventhElement column object.
    ''' </summary>
    Public ReadOnly Property EleventhElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(34), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.EleventhElement column object.
    ''' </summary>
    Public Shared ReadOnly Property EleventhElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.EleventhElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.TwelfthElement column object.
    ''' </summary>
    Public ReadOnly Property TwelfthElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(35), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.TwelfthElement column object.
    ''' </summary>
    Public Shared ReadOnly Property TwelfthElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.TwelfthElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ThirteenthElement column object.
    ''' </summary>
    Public ReadOnly Property ThirteenthElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(36), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.ThirteenthElement column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirteenthElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.ThirteenthElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FourteenthElement column object.
    ''' </summary>
    Public ReadOnly Property FourteenthElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(37), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FourteenthElement column object.
    ''' </summary>
    Public Shared ReadOnly Property FourteenthElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.FourteenthElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FifteenthElement column object.
    ''' </summary>
    Public ReadOnly Property FifteenthElementColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(38), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.FifteenthElement column object.
    ''' </summary>
    Public Shared ReadOnly Property FifteenthElement() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowConfigTable.Instance.FifteenthElementColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.CreatedByID column object.
    ''' </summary>
    Public ReadOnly Property CreatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(39), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.CreatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.CreatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.CreatedAt column object.
    ''' </summary>
    Public ReadOnly Property CreatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(40), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.CreatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedAt() As BaseClasses.Data.DateColumn
        Get
            Return FlowConfigTable.Instance.CreatedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.UpdatedByID column object.
    ''' </summary>
    Public ReadOnly Property UpdatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(41), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.UpdatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.UpdatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.UpdatedAt column object.
    ''' </summary>
    Public ReadOnly Property UpdatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(42), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.UpdatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedAt() As BaseClasses.Data.DateColumn
        Get
            Return FlowConfigTable.Instance.UpdatedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.CopyConfigID column object.
    ''' </summary>
    Public ReadOnly Property CopyConfigIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(43), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowConfig_.CopyConfigID column object.
    ''' </summary>
    Public Shared ReadOnly Property CopyConfigID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowConfigTable.Instance.CopyConfigIDColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowConfigRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As FlowConfigRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowConfigRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As FlowConfigRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowConfigRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As FlowConfigRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowConfigRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As FlowConfigRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowConfigRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As FlowConfigRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  FlowConfigTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowConfigRecord)), FlowConfigRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowConfigRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As FlowConfigRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  FlowConfigTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowConfigRecord)), FlowConfigRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As FlowConfigRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = FlowConfigTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowConfigRecord)), FlowConfigRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As FlowConfigRecord()

        Dim recList As ArrayList = FlowConfigTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowConfigRecord)), FlowConfigRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As FlowConfigRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = FlowConfigTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowConfigRecord)), FlowConfigRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As FlowConfigRecord()

        Dim recList As ArrayList = FlowConfigTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowConfigRecord)), FlowConfigRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(FlowConfigTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(FlowConfigTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(FlowConfigTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(FlowConfigTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a FlowConfigRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As FlowConfigRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a FlowConfigRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As FlowConfigRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a FlowConfigRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As FlowConfigRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = FlowConfigTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As FlowConfigRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), FlowConfigRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a FlowConfigRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As FlowConfigRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = FlowConfigTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As FlowConfigRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), FlowConfigRecord)
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

        Return FlowConfigTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return FlowConfigTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As FlowConfigRecord = GetRecords(where)
        Return FlowConfigTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As FlowConfigRecord = GetRecords(join, where)
        Return FlowConfigTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As FlowConfigRecord = GetRecords(where, orderBy)
        Return FlowConfigTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As FlowConfigRecord = GetRecords(join, where, orderBy)
        Return FlowConfigTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As FlowConfigRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return FlowConfigTable.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As FlowConfigRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return FlowConfigTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        FlowConfigTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return FlowConfigTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return FlowConfigTable.Instance.ExportRecordData(whereFilter)
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

        Return FlowConfigTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return FlowConfigTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return FlowConfigTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return FlowConfigTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return FlowConfigTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return FlowConfigTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return FlowConfigTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return FlowConfigTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = FlowConfigTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As FlowConfigRecord
        Return CType(FlowConfigTable.Instance.GetRecordData(id, bMutable), FlowConfigRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As FlowConfigRecord
        Return CType(FlowConfigTable.Instance.GetRecordData(id, bMutable), FlowConfigRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal FlowStepIDValue As String, _
        ByVal ConfigRankValue As String, _
        ByVal IntendedForIDValue As String, _
        ByVal RoleIDValue As String, _
        ByVal MustActValue As String, _
        ByVal SkipJumpValue As String, _
        ByVal SendMessageValue As String, _
        ByVal DashboardValue As String, _
        ByVal PageTitle0Value As String, _
        ByVal InstructionsValue As String, _
        ByVal LandingRedirectValue As String, _
        ByVal GoActionValue As String, _
        ByVal VideoURLValue As String, _
        ByVal VideoDescriptionValue As String, _
        ByVal FlowStepOneIDValue As String, _
        ByVal ButtonOneIDValue As String, _
        ByVal FlowStepTwoIDValue As String, _
        ByVal ButtonTwoIDValue As String, _
        ByVal FlowStepThreeIDValue As String, _
        ByVal ButtonThreeIDValue As String, _
        ByVal FlowStepFourIDValue As String, _
        ByVal ButtonFourIDValue As String, _
        ByVal RewindIDValue As String, _
        ByVal FirstElementValue As String, _
        ByVal SecondElementValue As String, _
        ByVal ThirdElementValue As String, _
        ByVal FourthElementValue As String, _
        ByVal FifthElementValue As String, _
        ByVal SixthElementValue As String, _
        ByVal SeventhElementValue As String, _
        ByVal EighthElementValue As String, _
        ByVal NinthElementValue As String, _
        ByVal TenthElementValue As String, _
        ByVal EleventhElementValue As String, _
        ByVal TwelfthElementValue As String, _
        ByVal ThirteenthElementValue As String, _
        ByVal FourteenthElementValue As String, _
        ByVal FifteenthElementValue As String, _
        ByVal CreatedByIDValue As String, _
        ByVal CreatedAtValue As String, _
        ByVal UpdatedByIDValue As String, _
        ByVal UpdatedAtValue As String, _
        ByVal CopyConfigIDValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(FlowStepIDValue, FlowStepIDColumn)
        rec.SetString(ConfigRankValue, ConfigRankColumn)
        rec.SetString(IntendedForIDValue, IntendedForIDColumn)
        rec.SetString(RoleIDValue, RoleIDColumn)
        rec.SetString(MustActValue, MustActColumn)
        rec.SetString(SkipJumpValue, SkipJumpColumn)
        rec.SetString(SendMessageValue, SendMessageColumn)
        rec.SetString(DashboardValue, DashboardColumn)
        rec.SetString(PageTitle0Value, PageTitle0Column)
        rec.SetString(InstructionsValue, InstructionsColumn)
        rec.SetString(LandingRedirectValue, LandingRedirectColumn)
        rec.SetString(GoActionValue, GoActionColumn)
        rec.SetString(VideoURLValue, VideoURLColumn)
        rec.SetString(VideoDescriptionValue, VideoDescriptionColumn)
        rec.SetString(FlowStepOneIDValue, FlowStepOneIDColumn)
        rec.SetString(ButtonOneIDValue, ButtonOneIDColumn)
        rec.SetString(FlowStepTwoIDValue, FlowStepTwoIDColumn)
        rec.SetString(ButtonTwoIDValue, ButtonTwoIDColumn)
        rec.SetString(FlowStepThreeIDValue, FlowStepThreeIDColumn)
        rec.SetString(ButtonThreeIDValue, ButtonThreeIDColumn)
        rec.SetString(FlowStepFourIDValue, FlowStepFourIDColumn)
        rec.SetString(ButtonFourIDValue, ButtonFourIDColumn)
        rec.SetString(RewindIDValue, RewindIDColumn)
        rec.SetString(FirstElementValue, FirstElementColumn)
        rec.SetString(SecondElementValue, SecondElementColumn)
        rec.SetString(ThirdElementValue, ThirdElementColumn)
        rec.SetString(FourthElementValue, FourthElementColumn)
        rec.SetString(FifthElementValue, FifthElementColumn)
        rec.SetString(SixthElementValue, SixthElementColumn)
        rec.SetString(SeventhElementValue, SeventhElementColumn)
        rec.SetString(EighthElementValue, EighthElementColumn)
        rec.SetString(NinthElementValue, NinthElementColumn)
        rec.SetString(TenthElementValue, TenthElementColumn)
        rec.SetString(EleventhElementValue, EleventhElementColumn)
        rec.SetString(TwelfthElementValue, TwelfthElementColumn)
        rec.SetString(ThirteenthElementValue, ThirteenthElementColumn)
        rec.SetString(FourteenthElementValue, FourteenthElementColumn)
        rec.SetString(FifteenthElementValue, FifteenthElementColumn)
        rec.SetString(CreatedByIDValue, CreatedByIDColumn)
        rec.SetString(CreatedAtValue, CreatedAtColumn)
        rec.SetString(UpdatedByIDValue, UpdatedByIDColumn)
        rec.SetString(UpdatedAtValue, UpdatedAtColumn)
        rec.SetString(CopyConfigIDValue, CopyConfigIDColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        FlowConfigTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            FlowConfigTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(FlowConfigTable.Instance.TableDefinition.PrimaryKey)) Then
            Return FlowConfigTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(FlowConfigTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = FlowConfigTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = FlowConfigTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (FlowConfigTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = FlowConfigTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = FlowConfigTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = FlowConfigTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
