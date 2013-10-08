' This class is "generated" and will be overwritten.
' Your customizations should be made in ThreadInstanceMessageRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="ThreadInstanceMessageTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named ThreadInstanceMessage.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="ThreadInstanceMessageTable.Instance">ThreadInstanceMessageTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="ThreadInstanceMessageTable"></seealso>

<Serializable()> Public Class BaseThreadInstanceMessageTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = ThreadInstanceMessageDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.ThreadInstanceMessageTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.ThreadInstanceMessageRecord")
        Me.ApplicationName = "FASTPORT"
        Me.DataAdapter = New ThreadInstanceMessageSqlTable()
        Directcast(Me.DataAdapter, ThreadInstanceMessageSqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, ThreadInstanceMessageSqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        MessageIDColumn.CodeName = "MessageID"
        InstanceIDColumn.CodeName = "InstanceID"
        SenderIDColumn.CodeName = "SenderID"
        MessageActionColumn.CodeName = "MessageAction"
        MessageButtonTextColumn.CodeName = "MessageButtonText"
        MessageSubjectColumn.CodeName = "MessageSubject"
        MessageBodyColumn.CodeName = "MessageBody"
        ButtonIDColumn.CodeName = "ButtonID"
        QueuedColumn.CodeName = "Queued"
        CreatedByIDColumn.CodeName = "CreatedByID"
        CreatedAtColumn.CodeName = "CreatedAt"
        UpdatedByIDColumn.CodeName = "UpdatedByID"
        UpdatedAtColumn.CodeName = "UpdatedAt"
        ActionCollectionIDColumn.CodeName = "ActionCollectionID"
        LeftPartURLColumn.CodeName = "LeftPartURL"
        ActionURLColumn.CodeName = "ActionURL"
        ExcludeParamsColumn.CodeName = "ExcludeParams"
        NoRadWindowColumn.CodeName = "NoRadWindow"
        GoActionColumn.CodeName = "GoAction"
        ActionColumn.CodeName = "Action"
        CloseActionColumn.CodeName = "CloseAction"
        SliderValueColumn.CodeName = "SliderValue"
        RowOwnerCIXColumn.CodeName = "RowOwnerCIX"
        RowOIXColumn.CodeName = "RowOIX"
        FlowStepColumn.CodeName = "FlowStep"
        PartyColumn.CodeName = "Party"
        UserSystemColumn.CodeName = "UserSystem"
        MessageColumn.CodeName = "Message"
        Instance0Column.CodeName = "Instance0"
        FleetCircleColumn.CodeName = "FleetCircle"
        ExecutionColumn.CodeName = "Execution"
        AdColumn.CodeName = "Ad"
        AdActivityColumn.CodeName = "AdActivity"
        CheckInColumn.CodeName = "CheckIn"
        DocFiledColumn.CodeName = "DocFiled"
        OrdColumn.CodeName = "Ord"
        PaymentColumn.CodeName = "Payment"
        CarrierColumn.CodeName = "Carrier"
        DriverColumn.CodeName = "Driver"
        AddrColumn.CodeName = "Addr"
        RoleColumn.CodeName = "Role"
        HistoryColumn.CodeName = "History"
        Parent0Column.CodeName = "Parent0"
        EmailColumn.CodeName = "Email"
        PasswordColumn.CodeName = "Password"
        ButtonColumn.CodeName = "Button"
        VerificationColumn.CodeName = "Verification"
        DocColumn.CodeName = "Doc"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.MessageID column object.
    ''' </summary>
    Public ReadOnly Property MessageIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.MessageID column object.
    ''' </summary>
    Public Shared ReadOnly Property MessageID() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.MessageIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.InstanceID column object.
    ''' </summary>
    Public ReadOnly Property InstanceIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.InstanceID column object.
    ''' </summary>
    Public Shared ReadOnly Property InstanceID() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.InstanceIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.SenderID column object.
    ''' </summary>
    Public ReadOnly Property SenderIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.SenderID column object.
    ''' </summary>
    Public Shared ReadOnly Property SenderID() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.SenderIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.MessageAction column object.
    ''' </summary>
    Public ReadOnly Property MessageActionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.MessageAction column object.
    ''' </summary>
    Public Shared ReadOnly Property MessageAction() As BaseClasses.Data.StringColumn
        Get
            Return ThreadInstanceMessageTable.Instance.MessageActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.MessageButtonText column object.
    ''' </summary>
    Public ReadOnly Property MessageButtonTextColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.MessageButtonText column object.
    ''' </summary>
    Public Shared ReadOnly Property MessageButtonText() As BaseClasses.Data.StringColumn
        Get
            Return ThreadInstanceMessageTable.Instance.MessageButtonTextColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.MessageSubject column object.
    ''' </summary>
    Public ReadOnly Property MessageSubjectColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.MessageSubject column object.
    ''' </summary>
    Public Shared ReadOnly Property MessageSubject() As BaseClasses.Data.StringColumn
        Get
            Return ThreadInstanceMessageTable.Instance.MessageSubjectColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.MessageBody column object.
    ''' </summary>
    Public ReadOnly Property MessageBodyColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.MessageBody column object.
    ''' </summary>
    Public Shared ReadOnly Property MessageBody() As BaseClasses.Data.ClobColumn
        Get
            Return ThreadInstanceMessageTable.Instance.MessageBodyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.ButtonID column object.
    ''' </summary>
    Public ReadOnly Property ButtonIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.ButtonID column object.
    ''' </summary>
    Public Shared ReadOnly Property ButtonID() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.ButtonIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Queued column object.
    ''' </summary>
    Public ReadOnly Property QueuedColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Queued column object.
    ''' </summary>
    Public Shared ReadOnly Property Queued() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.QueuedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.CreatedByID column object.
    ''' </summary>
    Public ReadOnly Property CreatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.CreatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.CreatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.CreatedAt column object.
    ''' </summary>
    Public ReadOnly Property CreatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.CreatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedAt() As BaseClasses.Data.DateColumn
        Get
            Return ThreadInstanceMessageTable.Instance.CreatedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.UpdatedByID column object.
    ''' </summary>
    Public ReadOnly Property UpdatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.UpdatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.UpdatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.UpdatedAt column object.
    ''' </summary>
    Public ReadOnly Property UpdatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.UpdatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedAt() As BaseClasses.Data.DateColumn
        Get
            Return ThreadInstanceMessageTable.Instance.UpdatedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.ActionCollectionID column object.
    ''' </summary>
    Public ReadOnly Property ActionCollectionIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.ActionCollectionID column object.
    ''' </summary>
    Public Shared ReadOnly Property ActionCollectionID() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.ActionCollectionIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.LeftPartURL column object.
    ''' </summary>
    Public ReadOnly Property LeftPartURLColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.LeftPartURL column object.
    ''' </summary>
    Public Shared ReadOnly Property LeftPartURL() As BaseClasses.Data.StringColumn
        Get
            Return ThreadInstanceMessageTable.Instance.LeftPartURLColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.ActionURL column object.
    ''' </summary>
    Public ReadOnly Property ActionURLColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.ActionURL column object.
    ''' </summary>
    Public Shared ReadOnly Property ActionURL() As BaseClasses.Data.StringColumn
        Get
            Return ThreadInstanceMessageTable.Instance.ActionURLColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.ExcludeParams column object.
    ''' </summary>
    Public ReadOnly Property ExcludeParamsColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.ExcludeParams column object.
    ''' </summary>
    Public Shared ReadOnly Property ExcludeParams() As BaseClasses.Data.BooleanColumn
        Get
            Return ThreadInstanceMessageTable.Instance.ExcludeParamsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.NoRadWindow column object.
    ''' </summary>
    Public ReadOnly Property NoRadWindowColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.NoRadWindow column object.
    ''' </summary>
    Public Shared ReadOnly Property NoRadWindow() As BaseClasses.Data.BooleanColumn
        Get
            Return ThreadInstanceMessageTable.Instance.NoRadWindowColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.GoAction column object.
    ''' </summary>
    Public ReadOnly Property GoActionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.GoAction column object.
    ''' </summary>
    Public Shared ReadOnly Property GoAction() As BaseClasses.Data.StringColumn
        Get
            Return ThreadInstanceMessageTable.Instance.GoActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Action column object.
    ''' </summary>
    Public ReadOnly Property ActionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Action column object.
    ''' </summary>
    Public Shared ReadOnly Property Action() As BaseClasses.Data.StringColumn
        Get
            Return ThreadInstanceMessageTable.Instance.ActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.CloseAction column object.
    ''' </summary>
    Public ReadOnly Property CloseActionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.CloseAction column object.
    ''' </summary>
    Public Shared ReadOnly Property CloseAction() As BaseClasses.Data.StringColumn
        Get
            Return ThreadInstanceMessageTable.Instance.CloseActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.SliderValue column object.
    ''' </summary>
    Public ReadOnly Property SliderValueColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.SliderValue column object.
    ''' </summary>
    Public Shared ReadOnly Property SliderValue() As BaseClasses.Data.StringColumn
        Get
            Return ThreadInstanceMessageTable.Instance.SliderValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.RowOwnerCIX column object.
    ''' </summary>
    Public ReadOnly Property RowOwnerCIXColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.RowOwnerCIX column object.
    ''' </summary>
    Public Shared ReadOnly Property RowOwnerCIX() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.RowOwnerCIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.RowOIX column object.
    ''' </summary>
    Public ReadOnly Property RowOIXColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.RowOIX column object.
    ''' </summary>
    Public Shared ReadOnly Property RowOIX() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.RowOIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.FlowStep column object.
    ''' </summary>
    Public ReadOnly Property FlowStepColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.FlowStep column object.
    ''' </summary>
    Public Shared ReadOnly Property FlowStep() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.FlowStepColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Party column object.
    ''' </summary>
    Public ReadOnly Property PartyColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Party column object.
    ''' </summary>
    Public Shared ReadOnly Property Party() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.PartyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.UserSystem column object.
    ''' </summary>
    Public ReadOnly Property UserSystemColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.UserSystem column object.
    ''' </summary>
    Public Shared ReadOnly Property UserSystem() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.UserSystemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Message column object.
    ''' </summary>
    Public ReadOnly Property MessageColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Message column object.
    ''' </summary>
    Public Shared ReadOnly Property Message() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.MessageColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Instance column object.
    ''' </summary>
    Public ReadOnly Property Instance0Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Instance column object.
    ''' </summary>
    Public Shared ReadOnly Property Instance0() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.Instance0Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.FleetCircle column object.
    ''' </summary>
    Public ReadOnly Property FleetCircleColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.FleetCircle column object.
    ''' </summary>
    Public Shared ReadOnly Property FleetCircle() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.FleetCircleColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Execution column object.
    ''' </summary>
    Public ReadOnly Property ExecutionColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Execution column object.
    ''' </summary>
    Public Shared ReadOnly Property Execution() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.ExecutionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Ad column object.
    ''' </summary>
    Public ReadOnly Property AdColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Ad column object.
    ''' </summary>
    Public Shared ReadOnly Property Ad() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.AdColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.AdActivity column object.
    ''' </summary>
    Public ReadOnly Property AdActivityColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(32), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.AdActivity column object.
    ''' </summary>
    Public Shared ReadOnly Property AdActivity() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.AdActivityColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.CheckIn column object.
    ''' </summary>
    Public ReadOnly Property CheckInColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(33), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.CheckIn column object.
    ''' </summary>
    Public Shared ReadOnly Property CheckIn() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.CheckInColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.DocFiled column object.
    ''' </summary>
    Public ReadOnly Property DocFiledColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(34), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.DocFiled column object.
    ''' </summary>
    Public Shared ReadOnly Property DocFiled() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.DocFiledColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Ord column object.
    ''' </summary>
    Public ReadOnly Property OrdColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(35), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Ord column object.
    ''' </summary>
    Public Shared ReadOnly Property Ord() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.OrdColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Payment column object.
    ''' </summary>
    Public ReadOnly Property PaymentColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(36), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Payment column object.
    ''' </summary>
    Public Shared ReadOnly Property Payment() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.PaymentColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Carrier column object.
    ''' </summary>
    Public ReadOnly Property CarrierColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(37), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Carrier column object.
    ''' </summary>
    Public Shared ReadOnly Property Carrier() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.CarrierColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Driver column object.
    ''' </summary>
    Public ReadOnly Property DriverColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(38), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Driver column object.
    ''' </summary>
    Public Shared ReadOnly Property Driver() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.DriverColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Addr column object.
    ''' </summary>
    Public ReadOnly Property AddrColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(39), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Addr column object.
    ''' </summary>
    Public Shared ReadOnly Property Addr() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.AddrColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Role column object.
    ''' </summary>
    Public ReadOnly Property RoleColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(40), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Role column object.
    ''' </summary>
    Public Shared ReadOnly Property Role() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.RoleColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.History column object.
    ''' </summary>
    Public ReadOnly Property HistoryColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(41), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.History column object.
    ''' </summary>
    Public Shared ReadOnly Property History() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.HistoryColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Parent column object.
    ''' </summary>
    Public ReadOnly Property Parent0Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(42), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Parent column object.
    ''' </summary>
    Public Shared ReadOnly Property Parent0() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.Parent0Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Email column object.
    ''' </summary>
    Public ReadOnly Property EmailColumn() As BaseClasses.Data.EmailColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(43), BaseClasses.Data.EmailColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Email column object.
    ''' </summary>
    Public Shared ReadOnly Property Email() As BaseClasses.Data.EmailColumn
        Get
            Return ThreadInstanceMessageTable.Instance.EmailColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Password column object.
    ''' </summary>
    Public ReadOnly Property PasswordColumn() As BaseClasses.Data.PasswordColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(44), BaseClasses.Data.PasswordColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Password column object.
    ''' </summary>
    Public Shared ReadOnly Property Password() As BaseClasses.Data.PasswordColumn
        Get
            Return ThreadInstanceMessageTable.Instance.PasswordColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Button column object.
    ''' </summary>
    Public ReadOnly Property ButtonColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(45), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Button column object.
    ''' </summary>
    Public Shared ReadOnly Property Button() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.ButtonColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Verification column object.
    ''' </summary>
    Public ReadOnly Property VerificationColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(46), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Verification column object.
    ''' </summary>
    Public Shared ReadOnly Property Verification() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.VerificationColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Doc column object.
    ''' </summary>
    Public ReadOnly Property DocColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(47), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's ThreadInstanceMessage_.Doc column object.
    ''' </summary>
    Public Shared ReadOnly Property Doc() As BaseClasses.Data.NumberColumn
        Get
            Return ThreadInstanceMessageTable.Instance.DocColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of ThreadInstanceMessageRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As ThreadInstanceMessageRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of ThreadInstanceMessageRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As ThreadInstanceMessageRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of ThreadInstanceMessageRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As ThreadInstanceMessageRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of ThreadInstanceMessageRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As ThreadInstanceMessageRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of ThreadInstanceMessageRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As ThreadInstanceMessageRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  ThreadInstanceMessageTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.ThreadInstanceMessageRecord)), ThreadInstanceMessageRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of ThreadInstanceMessageRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As ThreadInstanceMessageRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  ThreadInstanceMessageTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.ThreadInstanceMessageRecord)), ThreadInstanceMessageRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As ThreadInstanceMessageRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = ThreadInstanceMessageTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.ThreadInstanceMessageRecord)), ThreadInstanceMessageRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As ThreadInstanceMessageRecord()

        Dim recList As ArrayList = ThreadInstanceMessageTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.ThreadInstanceMessageRecord)), ThreadInstanceMessageRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As ThreadInstanceMessageRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = ThreadInstanceMessageTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.ThreadInstanceMessageRecord)), ThreadInstanceMessageRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As ThreadInstanceMessageRecord()

        Dim recList As ArrayList = ThreadInstanceMessageTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.ThreadInstanceMessageRecord)), ThreadInstanceMessageRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(ThreadInstanceMessageTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(ThreadInstanceMessageTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(ThreadInstanceMessageTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(ThreadInstanceMessageTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a ThreadInstanceMessageRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As ThreadInstanceMessageRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a ThreadInstanceMessageRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As ThreadInstanceMessageRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a ThreadInstanceMessageRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As ThreadInstanceMessageRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = ThreadInstanceMessageTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As ThreadInstanceMessageRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), ThreadInstanceMessageRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a ThreadInstanceMessageRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As ThreadInstanceMessageRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = ThreadInstanceMessageTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As ThreadInstanceMessageRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), ThreadInstanceMessageRecord)
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

        Return ThreadInstanceMessageTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return ThreadInstanceMessageTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As ThreadInstanceMessageRecord = GetRecords(where)
        Return ThreadInstanceMessageTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As ThreadInstanceMessageRecord = GetRecords(join, where)
        Return ThreadInstanceMessageTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As ThreadInstanceMessageRecord = GetRecords(where, orderBy)
        Return ThreadInstanceMessageTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As ThreadInstanceMessageRecord = GetRecords(join, where, orderBy)
        Return ThreadInstanceMessageTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As ThreadInstanceMessageRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return ThreadInstanceMessageTable.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As ThreadInstanceMessageRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return ThreadInstanceMessageTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        ThreadInstanceMessageTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return ThreadInstanceMessageTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return ThreadInstanceMessageTable.Instance.ExportRecordData(whereFilter)
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

        Return ThreadInstanceMessageTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return ThreadInstanceMessageTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return ThreadInstanceMessageTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return ThreadInstanceMessageTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return ThreadInstanceMessageTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return ThreadInstanceMessageTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return ThreadInstanceMessageTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return ThreadInstanceMessageTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = ThreadInstanceMessageTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As ThreadInstanceMessageRecord
        Return CType(ThreadInstanceMessageTable.Instance.GetRecordData(id, bMutable), ThreadInstanceMessageRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As ThreadInstanceMessageRecord
        Return CType(ThreadInstanceMessageTable.Instance.GetRecordData(id, bMutable), ThreadInstanceMessageRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal InstanceIDValue As String, _
        ByVal SenderIDValue As String, _
        ByVal MessageActionValue As String, _
        ByVal MessageButtonTextValue As String, _
        ByVal MessageSubjectValue As String, _
        ByVal MessageBodyValue As String, _
        ByVal ButtonIDValue As String, _
        ByVal QueuedValue As String, _
        ByVal CreatedByIDValue As String, _
        ByVal CreatedAtValue As String, _
        ByVal UpdatedByIDValue As String, _
        ByVal UpdatedAtValue As String, _
        ByVal ActionCollectionIDValue As String, _
        ByVal LeftPartURLValue As String, _
        ByVal ActionURLValue As String, _
        ByVal ExcludeParamsValue As String, _
        ByVal NoRadWindowValue As String, _
        ByVal GoActionValue As String, _
        ByVal ActionValue As String, _
        ByVal CloseActionValue As String, _
        ByVal SliderValueValue As String, _
        ByVal RowOwnerCIXValue As String, _
        ByVal RowOIXValue As String, _
        ByVal FlowStepValue As String, _
        ByVal PartyValue As String, _
        ByVal UserSystemValue As String, _
        ByVal MessageValue As String, _
        ByVal Instance0Value As String, _
        ByVal FleetCircleValue As String, _
        ByVal ExecutionValue As String, _
        ByVal AdValue As String, _
        ByVal AdActivityValue As String, _
        ByVal CheckInValue As String, _
        ByVal DocFiledValue As String, _
        ByVal OrdValue As String, _
        ByVal PaymentValue As String, _
        ByVal CarrierValue As String, _
        ByVal DriverValue As String, _
        ByVal AddrValue As String, _
        ByVal RoleValue As String, _
        ByVal HistoryValue As String, _
        ByVal Parent0Value As String, _
        ByVal EmailValue As String, _
        ByVal PasswordValue As String, _
        ByVal ButtonValue As String, _
        ByVal VerificationValue As String, _
        ByVal DocValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(InstanceIDValue, InstanceIDColumn)
        rec.SetString(SenderIDValue, SenderIDColumn)
        rec.SetString(MessageActionValue, MessageActionColumn)
        rec.SetString(MessageButtonTextValue, MessageButtonTextColumn)
        rec.SetString(MessageSubjectValue, MessageSubjectColumn)
        rec.SetString(MessageBodyValue, MessageBodyColumn)
        rec.SetString(ButtonIDValue, ButtonIDColumn)
        rec.SetString(QueuedValue, QueuedColumn)
        rec.SetString(CreatedByIDValue, CreatedByIDColumn)
        rec.SetString(CreatedAtValue, CreatedAtColumn)
        rec.SetString(UpdatedByIDValue, UpdatedByIDColumn)
        rec.SetString(UpdatedAtValue, UpdatedAtColumn)
        rec.SetString(ActionCollectionIDValue, ActionCollectionIDColumn)
        rec.SetString(LeftPartURLValue, LeftPartURLColumn)
        rec.SetString(ActionURLValue, ActionURLColumn)
        rec.SetString(ExcludeParamsValue, ExcludeParamsColumn)
        rec.SetString(NoRadWindowValue, NoRadWindowColumn)
        rec.SetString(GoActionValue, GoActionColumn)
        rec.SetString(ActionValue, ActionColumn)
        rec.SetString(CloseActionValue, CloseActionColumn)
        rec.SetString(SliderValueValue, SliderValueColumn)
        rec.SetString(RowOwnerCIXValue, RowOwnerCIXColumn)
        rec.SetString(RowOIXValue, RowOIXColumn)
        rec.SetString(FlowStepValue, FlowStepColumn)
        rec.SetString(PartyValue, PartyColumn)
        rec.SetString(UserSystemValue, UserSystemColumn)
        rec.SetString(MessageValue, MessageColumn)
        rec.SetString(Instance0Value, Instance0Column)
        rec.SetString(FleetCircleValue, FleetCircleColumn)
        rec.SetString(ExecutionValue, ExecutionColumn)
        rec.SetString(AdValue, AdColumn)
        rec.SetString(AdActivityValue, AdActivityColumn)
        rec.SetString(CheckInValue, CheckInColumn)
        rec.SetString(DocFiledValue, DocFiledColumn)
        rec.SetString(OrdValue, OrdColumn)
        rec.SetString(PaymentValue, PaymentColumn)
        rec.SetString(CarrierValue, CarrierColumn)
        rec.SetString(DriverValue, DriverColumn)
        rec.SetString(AddrValue, AddrColumn)
        rec.SetString(RoleValue, RoleColumn)
        rec.SetString(HistoryValue, HistoryColumn)
        rec.SetString(Parent0Value, Parent0Column)
        rec.SetString(EmailValue, EmailColumn)
        rec.SetString(PasswordValue, PasswordColumn)
        rec.SetString(ButtonValue, ButtonColumn)
        rec.SetString(VerificationValue, VerificationColumn)
        rec.SetString(DocValue, DocColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        ThreadInstanceMessageTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            ThreadInstanceMessageTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(ThreadInstanceMessageTable.Instance.TableDefinition.PrimaryKey)) Then
            Return ThreadInstanceMessageTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(ThreadInstanceMessageTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = ThreadInstanceMessageTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = ThreadInstanceMessageTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (ThreadInstanceMessageTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = ThreadInstanceMessageTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = ThreadInstanceMessageTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = ThreadInstanceMessageTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
