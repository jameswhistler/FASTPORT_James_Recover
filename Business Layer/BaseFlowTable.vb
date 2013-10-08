' This class is "generated" and will be overwritten.
' Your customizations should be made in FlowRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="FlowTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named Flow.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="FlowTable.Instance">FlowTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="FlowTable"></seealso>

<Serializable()> Public Class BaseFlowTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = FlowDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.FlowTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.FlowRecord")
        Me.ApplicationName = "FASTPORT"
        Me.DataAdapter = New FlowSqlTable()
        Directcast(Me.DataAdapter, FlowSqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, FlowSqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        FlowIDColumn.CodeName = "FlowID"
        FlowPageColumn.CodeName = "FlowPage"
        FirstElementDescColumn.CodeName = "FirstElementDesc"
        SecondElementDescColumn.CodeName = "SecondElementDesc"
        ThirdElementDescColumn.CodeName = "ThirdElementDesc"
        FourthElementDescColumn.CodeName = "FourthElementDesc"
        FifthElementDescColumn.CodeName = "FifthElementDesc"
        SixthElementDescColumn.CodeName = "SixthElementDesc"
        SeventhElementDescColumn.CodeName = "SeventhElementDesc"
        EighthElementDescColumn.CodeName = "EighthElementDesc"
        NinthElementDescColumn.CodeName = "NinthElementDesc"
        TenthElementDescColumn.CodeName = "TenthElementDesc"
        EleventhElementDescColumn.CodeName = "EleventhElementDesc"
        TwelfthElementDescColumn.CodeName = "TwelfthElementDesc"
        ThirteenthElementDescColumn.CodeName = "ThirteenthElementDesc"
        FourteenthElementDescColumn.CodeName = "FourteenthElementDesc"
        FifteenthElementDescColumn.CodeName = "FifteenthElementDesc"
        FirstButtonDescColumn.CodeName = "FirstButtonDesc"
        SecondButtonDescColumn.CodeName = "SecondButtonDesc"
        ThirdButtonDescColumn.CodeName = "ThirdButtonDesc"
        FourthButtonDescColumn.CodeName = "FourthButtonDesc"
        FifthButtonDescColumn.CodeName = "FifthButtonDesc"
        SixthButtonDescColumn.CodeName = "SixthButtonDesc"
        SeventhButtonDescColumn.CodeName = "SeventhButtonDesc"
        EighthButtonDescColumn.CodeName = "EighthButtonDesc"
        NinthButtonDescColumn.CodeName = "NinthButtonDesc"
        TenthButtonDescColumn.CodeName = "TenthButtonDesc"
        RelatedToIDColumn.CodeName = "RelatedToID"
        CreatedByIDColumn.CodeName = "CreatedByID"
        CreatedAtColumn.CodeName = "CreatedAt"
        UpdatedByIDColumn.CodeName = "UpdatedByID"
        UpdatedAtColumn.CodeName = "UpdatedAt"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FlowID column object.
    ''' </summary>
    Public ReadOnly Property FlowIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FlowID column object.
    ''' </summary>
    Public Shared ReadOnly Property FlowID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowTable.Instance.FlowIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FlowPage column object.
    ''' </summary>
    Public ReadOnly Property FlowPageColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FlowPage column object.
    ''' </summary>
    Public Shared ReadOnly Property FlowPage() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.FlowPageColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FirstElementDesc column object.
    ''' </summary>
    Public ReadOnly Property FirstElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FirstElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.FirstElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.SecondElementDesc column object.
    ''' </summary>
    Public ReadOnly Property SecondElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.SecondElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property SecondElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.SecondElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.ThirdElementDesc column object.
    ''' </summary>
    Public ReadOnly Property ThirdElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.ThirdElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirdElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.ThirdElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FourthElementDesc column object.
    ''' </summary>
    Public ReadOnly Property FourthElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FourthElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property FourthElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.FourthElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FifthElementDesc column object.
    ''' </summary>
    Public ReadOnly Property FifthElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FifthElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property FifthElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.FifthElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.SixthElementDesc column object.
    ''' </summary>
    Public ReadOnly Property SixthElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.SixthElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property SixthElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.SixthElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.SeventhElementDesc column object.
    ''' </summary>
    Public ReadOnly Property SeventhElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.SeventhElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property SeventhElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.SeventhElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.EighthElementDesc column object.
    ''' </summary>
    Public ReadOnly Property EighthElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.EighthElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property EighthElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.EighthElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.NinthElementDesc column object.
    ''' </summary>
    Public ReadOnly Property NinthElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.NinthElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property NinthElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.NinthElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.TenthElementDesc column object.
    ''' </summary>
    Public ReadOnly Property TenthElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.TenthElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property TenthElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.TenthElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.EleventhElementDesc column object.
    ''' </summary>
    Public ReadOnly Property EleventhElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.EleventhElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property EleventhElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.EleventhElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.TwelfthElementDesc column object.
    ''' </summary>
    Public ReadOnly Property TwelfthElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.TwelfthElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property TwelfthElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.TwelfthElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.ThirteenthElementDesc column object.
    ''' </summary>
    Public ReadOnly Property ThirteenthElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.ThirteenthElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirteenthElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.ThirteenthElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FourteenthElementDesc column object.
    ''' </summary>
    Public ReadOnly Property FourteenthElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FourteenthElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property FourteenthElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.FourteenthElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FifteenthElementDesc column object.
    ''' </summary>
    Public ReadOnly Property FifteenthElementDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FifteenthElementDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property FifteenthElementDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.FifteenthElementDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FirstButtonDesc column object.
    ''' </summary>
    Public ReadOnly Property FirstButtonDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FirstButtonDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstButtonDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.FirstButtonDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.SecondButtonDesc column object.
    ''' </summary>
    Public ReadOnly Property SecondButtonDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.SecondButtonDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property SecondButtonDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.SecondButtonDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.ThirdButtonDesc column object.
    ''' </summary>
    Public ReadOnly Property ThirdButtonDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.ThirdButtonDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirdButtonDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.ThirdButtonDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FourthButtonDesc column object.
    ''' </summary>
    Public ReadOnly Property FourthButtonDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FourthButtonDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property FourthButtonDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.FourthButtonDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FifthButtonDesc column object.
    ''' </summary>
    Public ReadOnly Property FifthButtonDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.FifthButtonDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property FifthButtonDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.FifthButtonDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.SixthButtonDesc column object.
    ''' </summary>
    Public ReadOnly Property SixthButtonDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.SixthButtonDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property SixthButtonDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.SixthButtonDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.SeventhButtonDesc column object.
    ''' </summary>
    Public ReadOnly Property SeventhButtonDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.SeventhButtonDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property SeventhButtonDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.SeventhButtonDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.EighthButtonDesc column object.
    ''' </summary>
    Public ReadOnly Property EighthButtonDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.EighthButtonDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property EighthButtonDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.EighthButtonDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.NinthButtonDesc column object.
    ''' </summary>
    Public ReadOnly Property NinthButtonDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.NinthButtonDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property NinthButtonDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.NinthButtonDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.TenthButtonDesc column object.
    ''' </summary>
    Public ReadOnly Property TenthButtonDescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.TenthButtonDesc column object.
    ''' </summary>
    Public Shared ReadOnly Property TenthButtonDesc() As BaseClasses.Data.StringColumn
        Get
            Return FlowTable.Instance.TenthButtonDescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.RelatedToID column object.
    ''' </summary>
    Public ReadOnly Property RelatedToIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.RelatedToID column object.
    ''' </summary>
    Public Shared ReadOnly Property RelatedToID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowTable.Instance.RelatedToIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.CreatedByID column object.
    ''' </summary>
    Public ReadOnly Property CreatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.CreatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowTable.Instance.CreatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.CreatedAt column object.
    ''' </summary>
    Public ReadOnly Property CreatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.CreatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedAt() As BaseClasses.Data.DateColumn
        Get
            Return FlowTable.Instance.CreatedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.UpdatedByID column object.
    ''' </summary>
    Public ReadOnly Property UpdatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.UpdatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return FlowTable.Instance.UpdatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.UpdatedAt column object.
    ''' </summary>
    Public ReadOnly Property UpdatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Flow_.UpdatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedAt() As BaseClasses.Data.DateColumn
        Get
            Return FlowTable.Instance.UpdatedAtColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As FlowRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As FlowRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As FlowRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As FlowRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As FlowRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  FlowTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowRecord)), FlowRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of FlowRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As FlowRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  FlowTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowRecord)), FlowRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As FlowRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = FlowTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowRecord)), FlowRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As FlowRecord()

        Dim recList As ArrayList = FlowTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowRecord)), FlowRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As FlowRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = FlowTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowRecord)), FlowRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As FlowRecord()

        Dim recList As ArrayList = FlowTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.FlowRecord)), FlowRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(FlowTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(FlowTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(FlowTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(FlowTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a FlowRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As FlowRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a FlowRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As FlowRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a FlowRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As FlowRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = FlowTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As FlowRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), FlowRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a FlowRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As FlowRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = FlowTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As FlowRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), FlowRecord)
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

        Return FlowTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return FlowTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As FlowRecord = GetRecords(where)
        Return FlowTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As FlowRecord = GetRecords(join, where)
        Return FlowTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As FlowRecord = GetRecords(where, orderBy)
        Return FlowTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As FlowRecord = GetRecords(join, where, orderBy)
        Return FlowTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As FlowRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return FlowTable.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As FlowRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return FlowTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        FlowTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return FlowTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return FlowTable.Instance.ExportRecordData(whereFilter)
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

        Return FlowTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return FlowTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return FlowTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return FlowTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return FlowTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return FlowTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return FlowTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return FlowTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = FlowTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As FlowRecord
        Return CType(FlowTable.Instance.GetRecordData(id, bMutable), FlowRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As FlowRecord
        Return CType(FlowTable.Instance.GetRecordData(id, bMutable), FlowRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal FlowPageValue As String, _
        ByVal FirstElementDescValue As String, _
        ByVal SecondElementDescValue As String, _
        ByVal ThirdElementDescValue As String, _
        ByVal FourthElementDescValue As String, _
        ByVal FifthElementDescValue As String, _
        ByVal SixthElementDescValue As String, _
        ByVal SeventhElementDescValue As String, _
        ByVal EighthElementDescValue As String, _
        ByVal NinthElementDescValue As String, _
        ByVal TenthElementDescValue As String, _
        ByVal EleventhElementDescValue As String, _
        ByVal TwelfthElementDescValue As String, _
        ByVal ThirteenthElementDescValue As String, _
        ByVal FourteenthElementDescValue As String, _
        ByVal FifteenthElementDescValue As String, _
        ByVal FirstButtonDescValue As String, _
        ByVal SecondButtonDescValue As String, _
        ByVal ThirdButtonDescValue As String, _
        ByVal FourthButtonDescValue As String, _
        ByVal FifthButtonDescValue As String, _
        ByVal SixthButtonDescValue As String, _
        ByVal SeventhButtonDescValue As String, _
        ByVal EighthButtonDescValue As String, _
        ByVal NinthButtonDescValue As String, _
        ByVal TenthButtonDescValue As String, _
        ByVal RelatedToIDValue As String, _
        ByVal CreatedByIDValue As String, _
        ByVal CreatedAtValue As String, _
        ByVal UpdatedByIDValue As String, _
        ByVal UpdatedAtValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(FlowPageValue, FlowPageColumn)
        rec.SetString(FirstElementDescValue, FirstElementDescColumn)
        rec.SetString(SecondElementDescValue, SecondElementDescColumn)
        rec.SetString(ThirdElementDescValue, ThirdElementDescColumn)
        rec.SetString(FourthElementDescValue, FourthElementDescColumn)
        rec.SetString(FifthElementDescValue, FifthElementDescColumn)
        rec.SetString(SixthElementDescValue, SixthElementDescColumn)
        rec.SetString(SeventhElementDescValue, SeventhElementDescColumn)
        rec.SetString(EighthElementDescValue, EighthElementDescColumn)
        rec.SetString(NinthElementDescValue, NinthElementDescColumn)
        rec.SetString(TenthElementDescValue, TenthElementDescColumn)
        rec.SetString(EleventhElementDescValue, EleventhElementDescColumn)
        rec.SetString(TwelfthElementDescValue, TwelfthElementDescColumn)
        rec.SetString(ThirteenthElementDescValue, ThirteenthElementDescColumn)
        rec.SetString(FourteenthElementDescValue, FourteenthElementDescColumn)
        rec.SetString(FifteenthElementDescValue, FifteenthElementDescColumn)
        rec.SetString(FirstButtonDescValue, FirstButtonDescColumn)
        rec.SetString(SecondButtonDescValue, SecondButtonDescColumn)
        rec.SetString(ThirdButtonDescValue, ThirdButtonDescColumn)
        rec.SetString(FourthButtonDescValue, FourthButtonDescColumn)
        rec.SetString(FifthButtonDescValue, FifthButtonDescColumn)
        rec.SetString(SixthButtonDescValue, SixthButtonDescColumn)
        rec.SetString(SeventhButtonDescValue, SeventhButtonDescColumn)
        rec.SetString(EighthButtonDescValue, EighthButtonDescColumn)
        rec.SetString(NinthButtonDescValue, NinthButtonDescColumn)
        rec.SetString(TenthButtonDescValue, TenthButtonDescColumn)
        rec.SetString(RelatedToIDValue, RelatedToIDColumn)
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
        FlowTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            FlowTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(FlowTable.Instance.TableDefinition.PrimaryKey)) Then
            Return FlowTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(FlowTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = FlowTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = FlowTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (FlowTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = FlowTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = FlowTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = FlowTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
