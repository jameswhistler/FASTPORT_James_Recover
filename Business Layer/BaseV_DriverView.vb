' This class is "generated" and will be overwritten.
' Your customizations should be made in V_DriverRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_DriverView"></see> class.
''' Provides access to the schema information and record data of a database table or view named v_Driver.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="V_DriverView.Instance">V_DriverView.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="V_DriverView"></seealso>

<Serializable()> Public Class BaseV_DriverView
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = V_DriverDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.V_DriverView")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.V_DriverRecord")
        Me.ApplicationName = "FASTPORT"
        Me.DataAdapter = New V_DriverSqlView()
        Directcast(Me.DataAdapter, V_DriverSqlView).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, V_DriverSqlView).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        PartyIDColumn.CodeName = "PartyID"
        FromPicColumn.CodeName = "FromPic"
        NameHTMLColumn.CodeName = "NameHTML"
        MoreHTMLColumn.CodeName = "MoreHTML"
        AdminHTMLColumn.CodeName = "AdminHTML"
        DetailsColumn.CodeName = "Details"
        ProfileSnippetColumn.CodeName = "ProfileSnippet"
        FullProfileColumn.CodeName = "FullProfile"
        MajorStickersColumn.CodeName = "MajorStickers"
        MinorStickersColumn.CodeName = "MinorStickers"
        GeneralStatsColumn.CodeName = "GeneralStats"
        YearsTruckingColumn.CodeName = "YearsTrucking"
        SocialStatusColumn.CodeName = "SocialStatus"
        GeneralExperienceColumn.CodeName = "GeneralExperience"
        EquipExperienceColumn.CodeName = "EquipExperience"
        CargoExperienceColumn.CodeName = "CargoExperience"
        RegionalExperienceColumn.CodeName = "RegionalExperience"
        AccidentsColumn.CodeName = "Accidents"
        OtherRecordsColumn.CodeName = "OtherRecords"
        WarningsColumn.CodeName = "Warnings"
        AllRecordsColumn.CodeName = "AllRecords"
        GaugeIDColumn.CodeName = "GaugeID"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.PartyID column object.
    ''' </summary>
    Public ReadOnly Property PartyIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.PartyID column object.
    ''' </summary>
    Public Shared ReadOnly Property PartyID() As BaseClasses.Data.NumberColumn
        Get
            Return V_DriverView.Instance.PartyIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.FromPic column object.
    ''' </summary>
    Public ReadOnly Property FromPicColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.FromPic column object.
    ''' </summary>
    Public Shared ReadOnly Property FromPic() As BaseClasses.Data.ImageColumn
        Get
            Return V_DriverView.Instance.FromPicColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.NameHTML column object.
    ''' </summary>
    Public ReadOnly Property NameHTMLColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.NameHTML column object.
    ''' </summary>
    Public Shared ReadOnly Property NameHTML() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.NameHTMLColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.MoreHTML column object.
    ''' </summary>
    Public ReadOnly Property MoreHTMLColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.MoreHTML column object.
    ''' </summary>
    Public Shared ReadOnly Property MoreHTML() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.MoreHTMLColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.AdminHTML column object.
    ''' </summary>
    Public ReadOnly Property AdminHTMLColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.AdminHTML column object.
    ''' </summary>
    Public Shared ReadOnly Property AdminHTML() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.AdminHTMLColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.Details column object.
    ''' </summary>
    Public ReadOnly Property DetailsColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.Details column object.
    ''' </summary>
    Public Shared ReadOnly Property Details() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.DetailsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.ProfileSnippet column object.
    ''' </summary>
    Public ReadOnly Property ProfileSnippetColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.ProfileSnippet column object.
    ''' </summary>
    Public Shared ReadOnly Property ProfileSnippet() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.ProfileSnippetColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.FullProfile column object.
    ''' </summary>
    Public ReadOnly Property FullProfileColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.FullProfile column object.
    ''' </summary>
    Public Shared ReadOnly Property FullProfile() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.FullProfileColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.MajorStickers column object.
    ''' </summary>
    Public ReadOnly Property MajorStickersColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.MajorStickers column object.
    ''' </summary>
    Public Shared ReadOnly Property MajorStickers() As BaseClasses.Data.StringColumn
        Get
            Return V_DriverView.Instance.MajorStickersColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.MinorStickers column object.
    ''' </summary>
    Public ReadOnly Property MinorStickersColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.MinorStickers column object.
    ''' </summary>
    Public Shared ReadOnly Property MinorStickers() As BaseClasses.Data.StringColumn
        Get
            Return V_DriverView.Instance.MinorStickersColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.GeneralStats column object.
    ''' </summary>
    Public ReadOnly Property GeneralStatsColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.GeneralStats column object.
    ''' </summary>
    Public Shared ReadOnly Property GeneralStats() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.GeneralStatsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.YearsTrucking column object.
    ''' </summary>
    Public ReadOnly Property YearsTruckingColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.YearsTrucking column object.
    ''' </summary>
    Public Shared ReadOnly Property YearsTrucking() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.YearsTruckingColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.SocialStatus column object.
    ''' </summary>
    Public ReadOnly Property SocialStatusColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.SocialStatus column object.
    ''' </summary>
    Public Shared ReadOnly Property SocialStatus() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.SocialStatusColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.GeneralExperience column object.
    ''' </summary>
    Public ReadOnly Property GeneralExperienceColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.GeneralExperience column object.
    ''' </summary>
    Public Shared ReadOnly Property GeneralExperience() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.GeneralExperienceColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.EquipExperience column object.
    ''' </summary>
    Public ReadOnly Property EquipExperienceColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.EquipExperience column object.
    ''' </summary>
    Public Shared ReadOnly Property EquipExperience() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.EquipExperienceColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.CargoExperience column object.
    ''' </summary>
    Public ReadOnly Property CargoExperienceColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.CargoExperience column object.
    ''' </summary>
    Public Shared ReadOnly Property CargoExperience() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.CargoExperienceColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.RegionalExperience column object.
    ''' </summary>
    Public ReadOnly Property RegionalExperienceColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.RegionalExperience column object.
    ''' </summary>
    Public Shared ReadOnly Property RegionalExperience() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.RegionalExperienceColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.Accidents column object.
    ''' </summary>
    Public ReadOnly Property AccidentsColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.Accidents column object.
    ''' </summary>
    Public Shared ReadOnly Property Accidents() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.AccidentsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.OtherRecords column object.
    ''' </summary>
    Public ReadOnly Property OtherRecordsColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.OtherRecords column object.
    ''' </summary>
    Public Shared ReadOnly Property OtherRecords() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.OtherRecordsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.Warnings column object.
    ''' </summary>
    Public ReadOnly Property WarningsColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.Warnings column object.
    ''' </summary>
    Public Shared ReadOnly Property Warnings() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.WarningsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.AllRecords column object.
    ''' </summary>
    Public ReadOnly Property AllRecordsColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.AllRecords column object.
    ''' </summary>
    Public Shared ReadOnly Property AllRecords() As BaseClasses.Data.ClobColumn
        Get
            Return V_DriverView.Instance.AllRecordsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.GaugeID column object.
    ''' </summary>
    Public ReadOnly Property GaugeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Driver_.GaugeID column object.
    ''' </summary>
    Public Shared ReadOnly Property GaugeID() As BaseClasses.Data.NumberColumn
        Get
            Return V_DriverView.Instance.GaugeIDColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_DriverRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As V_DriverRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_DriverRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As V_DriverRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_DriverRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_DriverRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_DriverRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_DriverRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_DriverRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_DriverRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  V_DriverView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_DriverRecord)), V_DriverRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_DriverRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_DriverRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  V_DriverView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_DriverRecord)), V_DriverRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_DriverRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = V_DriverView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_DriverRecord)), V_DriverRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_DriverRecord()

        Dim recList As ArrayList = V_DriverView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_DriverRecord)), V_DriverRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As V_DriverRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = V_DriverView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_DriverRecord)), V_DriverRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As V_DriverRecord()

        Dim recList As ArrayList = V_DriverView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_DriverRecord)), V_DriverRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(V_DriverView.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(V_DriverView.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(V_DriverView.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(V_DriverView.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_DriverRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As V_DriverRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_DriverRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As V_DriverRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_DriverRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_DriverRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = V_DriverView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As V_DriverRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), V_DriverRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_DriverRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_DriverRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = V_DriverView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As V_DriverRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), V_DriverRecord)
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

        Return V_DriverView.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return V_DriverView.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As V_DriverRecord = GetRecords(where)
        Return V_DriverView.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As V_DriverRecord = GetRecords(join, where)
        Return V_DriverView.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As V_DriverRecord = GetRecords(where, orderBy)
        Return V_DriverView.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As V_DriverRecord = GetRecords(join, where, orderBy)
        Return V_DriverView.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As V_DriverRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return V_DriverView.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As V_DriverRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return V_DriverView.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        V_DriverView.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return V_DriverView.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return V_DriverView.Instance.ExportRecordData(whereFilter)
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

        Return V_DriverView.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return V_DriverView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return V_DriverView.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return V_DriverView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return V_DriverView.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return V_DriverView.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return V_DriverView.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return V_DriverView.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = V_DriverView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As V_DriverRecord
        Return CType(V_DriverView.Instance.GetRecordData(id, bMutable), V_DriverRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As V_DriverRecord
        Return CType(V_DriverView.Instance.GetRecordData(id, bMutable), V_DriverRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal PartyIDValue As String, _
        ByVal FromPicValue As String, _
        ByVal NameHTMLValue As String, _
        ByVal MoreHTMLValue As String, _
        ByVal AdminHTMLValue As String, _
        ByVal DetailsValue As String, _
        ByVal ProfileSnippetValue As String, _
        ByVal FullProfileValue As String, _
        ByVal MajorStickersValue As String, _
        ByVal MinorStickersValue As String, _
        ByVal GeneralStatsValue As String, _
        ByVal YearsTruckingValue As String, _
        ByVal SocialStatusValue As String, _
        ByVal GeneralExperienceValue As String, _
        ByVal EquipExperienceValue As String, _
        ByVal CargoExperienceValue As String, _
        ByVal RegionalExperienceValue As String, _
        ByVal AccidentsValue As String, _
        ByVal OtherRecordsValue As String, _
        ByVal WarningsValue As String, _
        ByVal AllRecordsValue As String, _
        ByVal GaugeIDValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(PartyIDValue, PartyIDColumn)
        rec.SetString(FromPicValue, FromPicColumn)
        rec.SetString(NameHTMLValue, NameHTMLColumn)
        rec.SetString(MoreHTMLValue, MoreHTMLColumn)
        rec.SetString(AdminHTMLValue, AdminHTMLColumn)
        rec.SetString(DetailsValue, DetailsColumn)
        rec.SetString(ProfileSnippetValue, ProfileSnippetColumn)
        rec.SetString(FullProfileValue, FullProfileColumn)
        rec.SetString(MajorStickersValue, MajorStickersColumn)
        rec.SetString(MinorStickersValue, MinorStickersColumn)
        rec.SetString(GeneralStatsValue, GeneralStatsColumn)
        rec.SetString(YearsTruckingValue, YearsTruckingColumn)
        rec.SetString(SocialStatusValue, SocialStatusColumn)
        rec.SetString(GeneralExperienceValue, GeneralExperienceColumn)
        rec.SetString(EquipExperienceValue, EquipExperienceColumn)
        rec.SetString(CargoExperienceValue, CargoExperienceColumn)
        rec.SetString(RegionalExperienceValue, RegionalExperienceColumn)
        rec.SetString(AccidentsValue, AccidentsColumn)
        rec.SetString(OtherRecordsValue, OtherRecordsColumn)
        rec.SetString(WarningsValue, WarningsColumn)
        rec.SetString(AllRecordsValue, AllRecordsColumn)
        rec.SetString(GaugeIDValue, GaugeIDColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        V_DriverView.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            V_DriverView.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(V_DriverView.Instance.TableDefinition.PrimaryKey)) Then
            Return V_DriverView.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(V_DriverView.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = V_DriverView.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = V_DriverView.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (V_DriverView.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = V_DriverView.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = V_DriverView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = V_DriverView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
