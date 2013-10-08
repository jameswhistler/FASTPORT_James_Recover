' This class is "generated" and will be overwritten.
' Your customizations should be made in FlowButtonRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="FlowButtonTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named FlowButton.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="FlowButtonTable.Instance">FlowButtonTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="FlowButtonTable"></seealso>

<Serializable()> Public Class BaseFlowButtonTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = FlowButtonDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.FlowButtonTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.FlowButtonRecord")
        Me.ApplicationName = "FASTPORT"
        Me.DataAdapter = New FlowButtonSqlTable()
        Directcast(Me.DataAdapter, FlowButtonSqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, FlowButtonSqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        ButtonIDColumn.CodeName = "ButtonID"
        FlowStepIDColumn.CodeName = "FlowStepID"
        ButtonRankColumn.CodeName = "ButtonRank"
        RefNameColumn.CodeName = "RefName"
        ButtonTextColumn.CodeName = "ButtonText"
        HideButtonColumn.CodeName = "HideButton"
        ButtonToolTipColumn.CodeName = "ButtonToolTip"
        ImportantCSSColumn.CodeName = "ImportantCSS"
        RedirectColumn.CodeName = "Redirect"
        RedirectURLColumn.CodeName = "RedirectURL"
        GoToCompletionColumn.CodeName = "GoToCompletion"
        CompletionMessageColumn.CodeName = "CompletionMessage"
        SendMessageColumn.CodeName = "SendMessage"
        MessageSubjectColumn.CodeName = "MessageSubject"
        MessageActionColumn.CodeName = "MessageAction"
        MessageButtonTextColumn.CodeName = "MessageButtonText"
        ActionURLColumn.CodeName = "ActionURL"
        ExcludeParamsColumn.CodeName = "ExcludeParams"
        NoRadWindowColumn.CodeName = "NoRadWindow"
        GoActionColumn.CodeName = "GoAction"
        MessageBodyColumn.CodeName = "MessageBody"
        AutoMessageColumn.CodeName = "AutoMessage"
        CopySenderColumn.CodeName = "CopySender"
        IncludeAttachmentColumn.CodeName = "IncludeAttachment"
        FirstButtonActionColumn.CodeName = "FirstButtonAction"
        SecondButtonActionColumn.CodeName = "SecondButtonAction"
        ThirdButtonActionColumn.CodeName = "ThirdButtonAction"
        FourthButtonActionColumn.CodeName = "FourthButtonAction"
        FifthButtonActionColumn.CodeName = "FifthButtonAction"
        SixthButtonActionColumn.CodeName = "SixthButtonAction"
        SeventhButtonActionColumn.CodeName = "SeventhButtonAction"
        EighthButtonActionColumn.CodeName = "EighthButtonAction"
        NinthButtonActionColumn.CodeName = "NinthButtonAction"
        TenthButtonActionColumn.CodeName = "TenthButtonAction"
        CreatedByIDColumn.CodeName = "CreatedByID"
        CreatedAtColumn.CodeName = "CreatedAt"
        UpdatedByIDColumn.CodeName = "UpdatedByID"
        UpdatedAtColumn.CodeName = "UpdatedAt"
        CopyButtonIDColumn.CodeName = "CopyButtonID"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ButtonID column object.
    ''' </summary>
    Public ReadOnly Property ButtonIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ButtonID column object.
    ''' </summary>
    Public Shared ReadOnly Property ButtonID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowButtonTable.Instance.ButtonIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.FlowStepID column object.
    ''' </summary>
    Public ReadOnly Property FlowStepIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.FlowStepID column object.
    ''' </summary>
    Public Shared ReadOnly Property FlowStepID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowButtonTable.Instance.FlowStepIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ButtonRank column object.
    ''' </summary>
    Public ReadOnly Property ButtonRankColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ButtonRank column object.
    ''' </summary>
    Public Shared ReadOnly Property ButtonRank() As BaseClasses.Data.NumberColumn
        Get
            Return FlowButtonTable.Instance.ButtonRankColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.RefName column object.
    ''' </summary>
    Public ReadOnly Property RefNameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.RefName column object.
    ''' </summary>
    Public Shared ReadOnly Property RefName() As BaseClasses.Data.StringColumn
        Get
            Return FlowButtonTable.Instance.RefNameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ButtonText column object.
    ''' </summary>
    Public ReadOnly Property ButtonTextColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ButtonText column object.
    ''' </summary>
    Public Shared ReadOnly Property ButtonText() As BaseClasses.Data.StringColumn
        Get
            Return FlowButtonTable.Instance.ButtonTextColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.HideButton column object.
    ''' </summary>
    Public ReadOnly Property HideButtonColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.HideButton column object.
    ''' </summary>
    Public Shared ReadOnly Property HideButton() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.HideButtonColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ButtonToolTip column object.
    ''' </summary>
    Public ReadOnly Property ButtonToolTipColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ButtonToolTip column object.
    ''' </summary>
    Public Shared ReadOnly Property ButtonToolTip() As BaseClasses.Data.StringColumn
        Get
            Return FlowButtonTable.Instance.ButtonToolTipColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ImportantCSS column object.
    ''' </summary>
    Public ReadOnly Property ImportantCSSColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ImportantCSS column object.
    ''' </summary>
    Public Shared ReadOnly Property ImportantCSS() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.ImportantCSSColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.Redirect column object.
    ''' </summary>
    Public ReadOnly Property RedirectColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.Redirect column object.
    ''' </summary>
    Public Shared ReadOnly Property Redirect() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.RedirectColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.RedirectURL column object.
    ''' </summary>
    Public ReadOnly Property RedirectURLColumn() As BaseClasses.Data.UrlColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.UrlColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.RedirectURL column object.
    ''' </summary>
    Public Shared ReadOnly Property RedirectURL() As BaseClasses.Data.UrlColumn
        Get
            Return FlowButtonTable.Instance.RedirectURLColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.GoToCompletion column object.
    ''' </summary>
    Public ReadOnly Property GoToCompletionColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.GoToCompletion column object.
    ''' </summary>
    Public Shared ReadOnly Property GoToCompletion() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.GoToCompletionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.CompletionMessage column object.
    ''' </summary>
    Public ReadOnly Property CompletionMessageColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.CompletionMessage column object.
    ''' </summary>
    Public Shared ReadOnly Property CompletionMessage() As BaseClasses.Data.StringColumn
        Get
            Return FlowButtonTable.Instance.CompletionMessageColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.SendMessage column object.
    ''' </summary>
    Public ReadOnly Property SendMessageColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.SendMessage column object.
    ''' </summary>
    Public Shared ReadOnly Property SendMessage() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.SendMessageColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.MessageSubject column object.
    ''' </summary>
    Public ReadOnly Property MessageSubjectColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.MessageSubject column object.
    ''' </summary>
    Public Shared ReadOnly Property MessageSubject() As BaseClasses.Data.StringColumn
        Get
            Return FlowButtonTable.Instance.MessageSubjectColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.MessageAction column object.
    ''' </summary>
    Public ReadOnly Property MessageActionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.MessageAction column object.
    ''' </summary>
    Public Shared ReadOnly Property MessageAction() As BaseClasses.Data.StringColumn
        Get
            Return FlowButtonTable.Instance.MessageActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.MessageButtonText column object.
    ''' </summary>
    Public ReadOnly Property MessageButtonTextColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.MessageButtonText column object.
    ''' </summary>
    Public Shared ReadOnly Property MessageButtonText() As BaseClasses.Data.StringColumn
        Get
            Return FlowButtonTable.Instance.MessageButtonTextColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ActionURL column object.
    ''' </summary>
    Public ReadOnly Property ActionURLColumn() As BaseClasses.Data.UrlColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.UrlColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ActionURL column object.
    ''' </summary>
    Public Shared ReadOnly Property ActionURL() As BaseClasses.Data.UrlColumn
        Get
            Return FlowButtonTable.Instance.ActionURLColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ExcludeParams column object.
    ''' </summary>
    Public ReadOnly Property ExcludeParamsColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ExcludeParams column object.
    ''' </summary>
    Public Shared ReadOnly Property ExcludeParams() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.ExcludeParamsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.NoRadWindow column object.
    ''' </summary>
    Public ReadOnly Property NoRadWindowColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.NoRadWindow column object.
    ''' </summary>
    Public Shared ReadOnly Property NoRadWindow() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.NoRadWindowColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.GoAction column object.
    ''' </summary>
    Public ReadOnly Property GoActionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.GoAction column object.
    ''' </summary>
    Public Shared ReadOnly Property GoAction() As BaseClasses.Data.StringColumn
        Get
            Return FlowButtonTable.Instance.GoActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.MessageBody column object.
    ''' </summary>
    Public ReadOnly Property MessageBodyColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.MessageBody column object.
    ''' </summary>
    Public Shared ReadOnly Property MessageBody() As BaseClasses.Data.StringColumn
        Get
            Return FlowButtonTable.Instance.MessageBodyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.AutoMessage column object.
    ''' </summary>
    Public ReadOnly Property AutoMessageColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.AutoMessage column object.
    ''' </summary>
    Public Shared ReadOnly Property AutoMessage() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.AutoMessageColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.CopySender column object.
    ''' </summary>
    Public ReadOnly Property CopySenderColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.CopySender column object.
    ''' </summary>
    Public Shared ReadOnly Property CopySender() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.CopySenderColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.IncludeAttachment column object.
    ''' </summary>
    Public ReadOnly Property IncludeAttachmentColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.IncludeAttachment column object.
    ''' </summary>
    Public Shared ReadOnly Property IncludeAttachment() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.IncludeAttachmentColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.FirstButtonAction column object.
    ''' </summary>
    Public ReadOnly Property FirstButtonActionColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.FirstButtonAction column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstButtonAction() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.FirstButtonActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.SecondButtonAction column object.
    ''' </summary>
    Public ReadOnly Property SecondButtonActionColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.SecondButtonAction column object.
    ''' </summary>
    Public Shared ReadOnly Property SecondButtonAction() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.SecondButtonActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ThirdButtonAction column object.
    ''' </summary>
    Public ReadOnly Property ThirdButtonActionColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.ThirdButtonAction column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirdButtonAction() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.ThirdButtonActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.FourthButtonAction column object.
    ''' </summary>
    Public ReadOnly Property FourthButtonActionColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.FourthButtonAction column object.
    ''' </summary>
    Public Shared ReadOnly Property FourthButtonAction() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.FourthButtonActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.FifthButtonAction column object.
    ''' </summary>
    Public ReadOnly Property FifthButtonActionColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.FifthButtonAction column object.
    ''' </summary>
    Public Shared ReadOnly Property FifthButtonAction() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.FifthButtonActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.SixthButtonAction column object.
    ''' </summary>
    Public ReadOnly Property SixthButtonActionColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.SixthButtonAction column object.
    ''' </summary>
    Public Shared ReadOnly Property SixthButtonAction() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.SixthButtonActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.SeventhButtonAction column object.
    ''' </summary>
    Public ReadOnly Property SeventhButtonActionColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.SeventhButtonAction column object.
    ''' </summary>
    Public Shared ReadOnly Property SeventhButtonAction() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.SeventhButtonActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.EighthButtonAction column object.
    ''' </summary>
    Public ReadOnly Property EighthButtonActionColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.EighthButtonAction column object.
    ''' </summary>
    Public Shared ReadOnly Property EighthButtonAction() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.EighthButtonActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.NinthButtonAction column object.
    ''' </summary>
    Public ReadOnly Property NinthButtonActionColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(32), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.NinthButtonAction column object.
    ''' </summary>
    Public Shared ReadOnly Property NinthButtonAction() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.NinthButtonActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.TenthButtonAction column object.
    ''' </summary>
    Public ReadOnly Property TenthButtonActionColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(33), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.TenthButtonAction column object.
    ''' </summary>
    Public Shared ReadOnly Property TenthButtonAction() As BaseClasses.Data.BooleanColumn
        Get
            Return FlowButtonTable.Instance.TenthButtonActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.CreatedByID column object.
    ''' </summary>
    Public ReadOnly Property CreatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(34), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.CreatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowButtonTable.Instance.CreatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.CreatedAt column object.
    ''' </summary>
    Public ReadOnly Property CreatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(35), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.CreatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedAt() As BaseClasses.Data.DateColumn
        Get
            Return FlowButtonTable.Instance.CreatedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.UpdatedByID column object.
    ''' </summary>
    Public ReadOnly Property UpdatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(36), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.UpdatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowButtonTable.Instance.UpdatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.UpdatedAt column object.
    ''' </summary>
    Public ReadOnly Property UpdatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(37), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.UpdatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedAt() As BaseClasses.Data.DateColumn
        Get
            Return FlowButtonTable.Instance.UpdatedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.CopyButtonID column object.
    ''' </summary>
    Public ReadOnly Property CopyButtonIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(38), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's FlowButton_.CopyButtonID column object.
    ''' </summary>
    Public Shared ReadOnly Property CopyButtonID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowButtonTable.Instance.CopyButtonIDColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowButtonRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As FlowButtonRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowButtonRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As FlowButtonRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowButtonRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As FlowButtonRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowButtonRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As FlowButtonRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowButtonRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As FlowButtonRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  FlowButtonTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowButtonRecord)), FlowButtonRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowButtonRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As FlowButtonRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  FlowButtonTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowButtonRecord)), FlowButtonRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As FlowButtonRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = FlowButtonTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowButtonRecord)), FlowButtonRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As FlowButtonRecord()

        Dim recList As ArrayList = FlowButtonTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowButtonRecord)), FlowButtonRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As FlowButtonRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = FlowButtonTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowButtonRecord)), FlowButtonRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As FlowButtonRecord()

        Dim recList As ArrayList = FlowButtonTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowButtonRecord)), FlowButtonRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(FlowButtonTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(FlowButtonTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(FlowButtonTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(FlowButtonTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a FlowButtonRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As FlowButtonRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a FlowButtonRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As FlowButtonRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a FlowButtonRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As FlowButtonRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = FlowButtonTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As FlowButtonRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), FlowButtonRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a FlowButtonRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As FlowButtonRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = FlowButtonTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As FlowButtonRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), FlowButtonRecord)
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

        Return FlowButtonTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return FlowButtonTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As FlowButtonRecord = GetRecords(where)
        Return FlowButtonTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As FlowButtonRecord = GetRecords(join, where)
        Return FlowButtonTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As FlowButtonRecord = GetRecords(where, orderBy)
        Return FlowButtonTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As FlowButtonRecord = GetRecords(join, where, orderBy)
        Return FlowButtonTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As FlowButtonRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return FlowButtonTable.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As FlowButtonRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return FlowButtonTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        FlowButtonTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return FlowButtonTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return FlowButtonTable.Instance.ExportRecordData(whereFilter)
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

        Return FlowButtonTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return FlowButtonTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return FlowButtonTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return FlowButtonTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return FlowButtonTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return FlowButtonTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return FlowButtonTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return FlowButtonTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = FlowButtonTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As FlowButtonRecord
        Return CType(FlowButtonTable.Instance.GetRecordData(id, bMutable), FlowButtonRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As FlowButtonRecord
        Return CType(FlowButtonTable.Instance.GetRecordData(id, bMutable), FlowButtonRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal FlowStepIDValue As String, _
        ByVal ButtonRankValue As String, _
        ByVal RefNameValue As String, _
        ByVal ButtonTextValue As String, _
        ByVal HideButtonValue As String, _
        ByVal ButtonToolTipValue As String, _
        ByVal ImportantCSSValue As String, _
        ByVal RedirectValue As String, _
        ByVal RedirectURLValue As String, _
        ByVal GoToCompletionValue As String, _
        ByVal CompletionMessageValue As String, _
        ByVal SendMessageValue As String, _
        ByVal MessageSubjectValue As String, _
        ByVal MessageActionValue As String, _
        ByVal MessageButtonTextValue As String, _
        ByVal ActionURLValue As String, _
        ByVal ExcludeParamsValue As String, _
        ByVal NoRadWindowValue As String, _
        ByVal GoActionValue As String, _
        ByVal MessageBodyValue As String, _
        ByVal AutoMessageValue As String, _
        ByVal CopySenderValue As String, _
        ByVal IncludeAttachmentValue As String, _
        ByVal FirstButtonActionValue As String, _
        ByVal SecondButtonActionValue As String, _
        ByVal ThirdButtonActionValue As String, _
        ByVal FourthButtonActionValue As String, _
        ByVal FifthButtonActionValue As String, _
        ByVal SixthButtonActionValue As String, _
        ByVal SeventhButtonActionValue As String, _
        ByVal EighthButtonActionValue As String, _
        ByVal NinthButtonActionValue As String, _
        ByVal TenthButtonActionValue As String, _
        ByVal CreatedByIDValue As String, _
        ByVal CreatedAtValue As String, _
        ByVal UpdatedByIDValue As String, _
        ByVal UpdatedAtValue As String, _
        ByVal CopyButtonIDValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(FlowStepIDValue, FlowStepIDColumn)
        rec.SetString(ButtonRankValue, ButtonRankColumn)
        rec.SetString(RefNameValue, RefNameColumn)
        rec.SetString(ButtonTextValue, ButtonTextColumn)
        rec.SetString(HideButtonValue, HideButtonColumn)
        rec.SetString(ButtonToolTipValue, ButtonToolTipColumn)
        rec.SetString(ImportantCSSValue, ImportantCSSColumn)
        rec.SetString(RedirectValue, RedirectColumn)
        rec.SetString(RedirectURLValue, RedirectURLColumn)
        rec.SetString(GoToCompletionValue, GoToCompletionColumn)
        rec.SetString(CompletionMessageValue, CompletionMessageColumn)
        rec.SetString(SendMessageValue, SendMessageColumn)
        rec.SetString(MessageSubjectValue, MessageSubjectColumn)
        rec.SetString(MessageActionValue, MessageActionColumn)
        rec.SetString(MessageButtonTextValue, MessageButtonTextColumn)
        rec.SetString(ActionURLValue, ActionURLColumn)
        rec.SetString(ExcludeParamsValue, ExcludeParamsColumn)
        rec.SetString(NoRadWindowValue, NoRadWindowColumn)
        rec.SetString(GoActionValue, GoActionColumn)
        rec.SetString(MessageBodyValue, MessageBodyColumn)
        rec.SetString(AutoMessageValue, AutoMessageColumn)
        rec.SetString(CopySenderValue, CopySenderColumn)
        rec.SetString(IncludeAttachmentValue, IncludeAttachmentColumn)
        rec.SetString(FirstButtonActionValue, FirstButtonActionColumn)
        rec.SetString(SecondButtonActionValue, SecondButtonActionColumn)
        rec.SetString(ThirdButtonActionValue, ThirdButtonActionColumn)
        rec.SetString(FourthButtonActionValue, FourthButtonActionColumn)
        rec.SetString(FifthButtonActionValue, FifthButtonActionColumn)
        rec.SetString(SixthButtonActionValue, SixthButtonActionColumn)
        rec.SetString(SeventhButtonActionValue, SeventhButtonActionColumn)
        rec.SetString(EighthButtonActionValue, EighthButtonActionColumn)
        rec.SetString(NinthButtonActionValue, NinthButtonActionColumn)
        rec.SetString(TenthButtonActionValue, TenthButtonActionColumn)
        rec.SetString(CreatedByIDValue, CreatedByIDColumn)
        rec.SetString(CreatedAtValue, CreatedAtColumn)
        rec.SetString(UpdatedByIDValue, UpdatedByIDColumn)
        rec.SetString(UpdatedAtValue, UpdatedAtColumn)
        rec.SetString(CopyButtonIDValue, CopyButtonIDColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        FlowButtonTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            FlowButtonTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(FlowButtonTable.Instance.TableDefinition.PrimaryKey)) Then
            Return FlowButtonTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(FlowButtonTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = FlowButtonTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = FlowButtonTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (FlowButtonTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = FlowButtonTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = FlowButtonTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = FlowButtonTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
