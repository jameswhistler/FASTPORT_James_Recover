' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyWorkHistoryRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PartyWorkHistoryTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named PartyWorkHistory.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="PartyWorkHistoryTable.Instance">PartyWorkHistoryTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="PartyWorkHistoryTable"></seealso>

<Serializable()> Public Class BasePartyWorkHistoryTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = PartyWorkHistoryDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.PartyWorkHistoryTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.PartyWorkHistoryRecord")
        Me.ApplicationName = "FASTPORT"
        Me.DataAdapter = New PartyWorkHistorySqlTable()
        Directcast(Me.DataAdapter, PartyWorkHistorySqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, PartyWorkHistorySqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        HistoryIDColumn.CodeName = "HistoryID"
        PartyIDColumn.CodeName = "PartyID"
        StartMonthIDColumn.CodeName = "StartMonthID"
        EndMonthIDColumn.CodeName = "EndMonthID"
        EmployedColumn.CodeName = "Employed"
        DrivingPositionColumn.CodeName = "DrivingPosition"
        EmployerIDColumn.CodeName = "EmployerID"
        EmployerCompanyColumn.CodeName = "EmployerCompany"
        EmployerAddrColumn.CodeName = "EmployerAddr"
        EmployerZipIDColumn.CodeName = "EmployerZipID"
        EmployerCountryIDColumn.CodeName = "EmployerCountryID"
        EmployerContactColumn.CodeName = "EmployerContact"
        EmployerEmailColumn.CodeName = "EmployerEmail"
        EmployerPhoneColumn.CodeName = "EmployerPhone"
        EmployerFaxColumn.CodeName = "EmployerFax"
        ReasonForLeavingIDColumn.CodeName = "ReasonForLeavingID"
        ReasonForLeavingNotesColumn.CodeName = "ReasonForLeavingNotes"
        MilesPerWeekColumn.CodeName = "MilesPerWeek"
        OperatedCommercialMotorVechicleColumn.CodeName = "OperatedCommercialMotorVechicle"
        HadDrugTestingProgramColumn.CodeName = "HadDrugTestingProgram"
        MayWeContactColumn.CodeName = "MayWeContact"
        FirstJobColumn.CodeName = "FirstJob"
        FinishedColumn.CodeName = "Finished"
        FinishedExpColumn.CodeName = "FinishedExp"
        NotesColumn.CodeName = "Notes"
        TerminalIDColumn.CodeName = "TerminalID"
        HireDateColumn.CodeName = "HireDate"
        TermDateColumn.CodeName = "TermDate"
        OverlapColumn.CodeName = "Overlap"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.HistoryID column object.
    ''' </summary>
    Public ReadOnly Property HistoryIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.HistoryID column object.
    ''' </summary>
    Public Shared ReadOnly Property HistoryID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyWorkHistoryTable.Instance.HistoryIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.PartyID column object.
    ''' </summary>
    Public ReadOnly Property PartyIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.PartyID column object.
    ''' </summary>
    Public Shared ReadOnly Property PartyID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyWorkHistoryTable.Instance.PartyIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.StartMonthID column object.
    ''' </summary>
    Public ReadOnly Property StartMonthIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.StartMonthID column object.
    ''' </summary>
    Public Shared ReadOnly Property StartMonthID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyWorkHistoryTable.Instance.StartMonthIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EndMonthID column object.
    ''' </summary>
    Public ReadOnly Property EndMonthIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EndMonthID column object.
    ''' </summary>
    Public Shared ReadOnly Property EndMonthID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyWorkHistoryTable.Instance.EndMonthIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.Employed column object.
    ''' </summary>
    Public ReadOnly Property EmployedColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.Employed column object.
    ''' </summary>
    Public Shared ReadOnly Property Employed() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyWorkHistoryTable.Instance.EmployedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.DrivingPosition column object.
    ''' </summary>
    Public ReadOnly Property DrivingPositionColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.DrivingPosition column object.
    ''' </summary>
    Public Shared ReadOnly Property DrivingPosition() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyWorkHistoryTable.Instance.DrivingPositionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerID column object.
    ''' </summary>
    Public ReadOnly Property EmployerIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerID column object.
    ''' </summary>
    Public Shared ReadOnly Property EmployerID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyWorkHistoryTable.Instance.EmployerIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerCompany column object.
    ''' </summary>
    Public ReadOnly Property EmployerCompanyColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerCompany column object.
    ''' </summary>
    Public Shared ReadOnly Property EmployerCompany() As BaseClasses.Data.StringColumn
        Get
            Return PartyWorkHistoryTable.Instance.EmployerCompanyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerAddr column object.
    ''' </summary>
    Public ReadOnly Property EmployerAddrColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerAddr column object.
    ''' </summary>
    Public Shared ReadOnly Property EmployerAddr() As BaseClasses.Data.StringColumn
        Get
            Return PartyWorkHistoryTable.Instance.EmployerAddrColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerZipID column object.
    ''' </summary>
    Public ReadOnly Property EmployerZipIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerZipID column object.
    ''' </summary>
    Public Shared ReadOnly Property EmployerZipID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyWorkHistoryTable.Instance.EmployerZipIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerCountryID column object.
    ''' </summary>
    Public ReadOnly Property EmployerCountryIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerCountryID column object.
    ''' </summary>
    Public Shared ReadOnly Property EmployerCountryID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyWorkHistoryTable.Instance.EmployerCountryIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerContact column object.
    ''' </summary>
    Public ReadOnly Property EmployerContactColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerContact column object.
    ''' </summary>
    Public Shared ReadOnly Property EmployerContact() As BaseClasses.Data.StringColumn
        Get
            Return PartyWorkHistoryTable.Instance.EmployerContactColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerEmail column object.
    ''' </summary>
    Public ReadOnly Property EmployerEmailColumn() As BaseClasses.Data.EmailColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.EmailColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerEmail column object.
    ''' </summary>
    Public Shared ReadOnly Property EmployerEmail() As BaseClasses.Data.EmailColumn
        Get
            Return PartyWorkHistoryTable.Instance.EmployerEmailColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerPhone column object.
    ''' </summary>
    Public ReadOnly Property EmployerPhoneColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerPhone column object.
    ''' </summary>
    Public Shared ReadOnly Property EmployerPhone() As BaseClasses.Data.StringColumn
        Get
            Return PartyWorkHistoryTable.Instance.EmployerPhoneColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerFax column object.
    ''' </summary>
    Public ReadOnly Property EmployerFaxColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.EmployerFax column object.
    ''' </summary>
    Public Shared ReadOnly Property EmployerFax() As BaseClasses.Data.StringColumn
        Get
            Return PartyWorkHistoryTable.Instance.EmployerFaxColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.ReasonForLeavingID column object.
    ''' </summary>
    Public ReadOnly Property ReasonForLeavingIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.ReasonForLeavingID column object.
    ''' </summary>
    Public Shared ReadOnly Property ReasonForLeavingID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyWorkHistoryTable.Instance.ReasonForLeavingIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.ReasonForLeavingNotes column object.
    ''' </summary>
    Public ReadOnly Property ReasonForLeavingNotesColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.ReasonForLeavingNotes column object.
    ''' </summary>
    Public Shared ReadOnly Property ReasonForLeavingNotes() As BaseClasses.Data.StringColumn
        Get
            Return PartyWorkHistoryTable.Instance.ReasonForLeavingNotesColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.MilesPerWeek column object.
    ''' </summary>
    Public ReadOnly Property MilesPerWeekColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.MilesPerWeek column object.
    ''' </summary>
    Public Shared ReadOnly Property MilesPerWeek() As BaseClasses.Data.NumberColumn
        Get
            Return PartyWorkHistoryTable.Instance.MilesPerWeekColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.OperatedCommercialMotorVechicle column object.
    ''' </summary>
    Public ReadOnly Property OperatedCommercialMotorVechicleColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.OperatedCommercialMotorVechicle column object.
    ''' </summary>
    Public Shared ReadOnly Property OperatedCommercialMotorVechicle() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyWorkHistoryTable.Instance.OperatedCommercialMotorVechicleColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.HadDrugTestingProgram column object.
    ''' </summary>
    Public ReadOnly Property HadDrugTestingProgramColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.HadDrugTestingProgram column object.
    ''' </summary>
    Public Shared ReadOnly Property HadDrugTestingProgram() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyWorkHistoryTable.Instance.HadDrugTestingProgramColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.MayWeContact column object.
    ''' </summary>
    Public ReadOnly Property MayWeContactColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.MayWeContact column object.
    ''' </summary>
    Public Shared ReadOnly Property MayWeContact() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyWorkHistoryTable.Instance.MayWeContactColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.FirstJob column object.
    ''' </summary>
    Public ReadOnly Property FirstJobColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.FirstJob column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstJob() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyWorkHistoryTable.Instance.FirstJobColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.Finished column object.
    ''' </summary>
    Public ReadOnly Property FinishedColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.Finished column object.
    ''' </summary>
    Public Shared ReadOnly Property Finished() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyWorkHistoryTable.Instance.FinishedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.FinishedExp column object.
    ''' </summary>
    Public ReadOnly Property FinishedExpColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.FinishedExp column object.
    ''' </summary>
    Public Shared ReadOnly Property FinishedExp() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyWorkHistoryTable.Instance.FinishedExpColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.Notes column object.
    ''' </summary>
    Public ReadOnly Property NotesColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.Notes column object.
    ''' </summary>
    Public Shared ReadOnly Property Notes() As BaseClasses.Data.StringColumn
        Get
            Return PartyWorkHistoryTable.Instance.NotesColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.TerminalID column object.
    ''' </summary>
    Public ReadOnly Property TerminalIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.TerminalID column object.
    ''' </summary>
    Public Shared ReadOnly Property TerminalID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyWorkHistoryTable.Instance.TerminalIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.HireDate column object.
    ''' </summary>
    Public ReadOnly Property HireDateColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.HireDate column object.
    ''' </summary>
    Public Shared ReadOnly Property HireDate() As BaseClasses.Data.DateColumn
        Get
            Return PartyWorkHistoryTable.Instance.HireDateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.TermDate column object.
    ''' </summary>
    Public ReadOnly Property TermDateColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.TermDate column object.
    ''' </summary>
    Public Shared ReadOnly Property TermDate() As BaseClasses.Data.DateColumn
        Get
            Return PartyWorkHistoryTable.Instance.TermDateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.Overlap column object.
    ''' </summary>
    Public ReadOnly Property OverlapColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyWorkHistory_.Overlap column object.
    ''' </summary>
    Public Shared ReadOnly Property Overlap() As BaseClasses.Data.NumberColumn
        Get
            Return PartyWorkHistoryTable.Instance.OverlapColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyWorkHistoryRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As PartyWorkHistoryRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyWorkHistoryRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As PartyWorkHistoryRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyWorkHistoryRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyWorkHistoryRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyWorkHistoryRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyWorkHistoryRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyWorkHistoryRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyWorkHistoryRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  PartyWorkHistoryTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyWorkHistoryRecord)), PartyWorkHistoryRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyWorkHistoryRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyWorkHistoryRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  PartyWorkHistoryTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyWorkHistoryRecord)), PartyWorkHistoryRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyWorkHistoryRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = PartyWorkHistoryTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyWorkHistoryRecord)), PartyWorkHistoryRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyWorkHistoryRecord()

        Dim recList As ArrayList = PartyWorkHistoryTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyWorkHistoryRecord)), PartyWorkHistoryRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As PartyWorkHistoryRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = PartyWorkHistoryTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyWorkHistoryRecord)), PartyWorkHistoryRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As PartyWorkHistoryRecord()

        Dim recList As ArrayList = PartyWorkHistoryTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyWorkHistoryRecord)), PartyWorkHistoryRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(PartyWorkHistoryTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(PartyWorkHistoryTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(PartyWorkHistoryTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(PartyWorkHistoryTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyWorkHistoryRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As PartyWorkHistoryRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyWorkHistoryRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As PartyWorkHistoryRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyWorkHistoryRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyWorkHistoryRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = PartyWorkHistoryTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As PartyWorkHistoryRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), PartyWorkHistoryRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyWorkHistoryRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyWorkHistoryRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = PartyWorkHistoryTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As PartyWorkHistoryRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), PartyWorkHistoryRecord)
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

        Return PartyWorkHistoryTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return PartyWorkHistoryTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As PartyWorkHistoryRecord = GetRecords(where)
        Return PartyWorkHistoryTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As PartyWorkHistoryRecord = GetRecords(join, where)
        Return PartyWorkHistoryTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As PartyWorkHistoryRecord = GetRecords(where, orderBy)
        Return PartyWorkHistoryTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As PartyWorkHistoryRecord = GetRecords(join, where, orderBy)
        Return PartyWorkHistoryTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As PartyWorkHistoryRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return PartyWorkHistoryTable.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As PartyWorkHistoryRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return PartyWorkHistoryTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        PartyWorkHistoryTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return PartyWorkHistoryTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return PartyWorkHistoryTable.Instance.ExportRecordData(whereFilter)
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

        Return PartyWorkHistoryTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return PartyWorkHistoryTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return PartyWorkHistoryTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return PartyWorkHistoryTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return PartyWorkHistoryTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return PartyWorkHistoryTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return PartyWorkHistoryTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return PartyWorkHistoryTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = PartyWorkHistoryTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As PartyWorkHistoryRecord
        Return CType(PartyWorkHistoryTable.Instance.GetRecordData(id, bMutable), PartyWorkHistoryRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As PartyWorkHistoryRecord
        Return CType(PartyWorkHistoryTable.Instance.GetRecordData(id, bMutable), PartyWorkHistoryRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal PartyIDValue As String, _
        ByVal StartMonthIDValue As String, _
        ByVal EndMonthIDValue As String, _
        ByVal EmployedValue As String, _
        ByVal DrivingPositionValue As String, _
        ByVal EmployerIDValue As String, _
        ByVal EmployerCompanyValue As String, _
        ByVal EmployerAddrValue As String, _
        ByVal EmployerZipIDValue As String, _
        ByVal EmployerCountryIDValue As String, _
        ByVal EmployerContactValue As String, _
        ByVal EmployerEmailValue As String, _
        ByVal EmployerPhoneValue As String, _
        ByVal EmployerFaxValue As String, _
        ByVal ReasonForLeavingIDValue As String, _
        ByVal ReasonForLeavingNotesValue As String, _
        ByVal MilesPerWeekValue As String, _
        ByVal OperatedCommercialMotorVechicleValue As String, _
        ByVal HadDrugTestingProgramValue As String, _
        ByVal MayWeContactValue As String, _
        ByVal FirstJobValue As String, _
        ByVal FinishedValue As String, _
        ByVal FinishedExpValue As String, _
        ByVal NotesValue As String, _
        ByVal TerminalIDValue As String, _
        ByVal HireDateValue As String, _
        ByVal TermDateValue As String, _
        ByVal OverlapValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(PartyIDValue, PartyIDColumn)
        rec.SetString(StartMonthIDValue, StartMonthIDColumn)
        rec.SetString(EndMonthIDValue, EndMonthIDColumn)
        rec.SetString(EmployedValue, EmployedColumn)
        rec.SetString(DrivingPositionValue, DrivingPositionColumn)
        rec.SetString(EmployerIDValue, EmployerIDColumn)
        rec.SetString(EmployerCompanyValue, EmployerCompanyColumn)
        rec.SetString(EmployerAddrValue, EmployerAddrColumn)
        rec.SetString(EmployerZipIDValue, EmployerZipIDColumn)
        rec.SetString(EmployerCountryIDValue, EmployerCountryIDColumn)
        rec.SetString(EmployerContactValue, EmployerContactColumn)
        rec.SetString(EmployerEmailValue, EmployerEmailColumn)
        rec.SetString(EmployerPhoneValue, EmployerPhoneColumn)
        rec.SetString(EmployerFaxValue, EmployerFaxColumn)
        rec.SetString(ReasonForLeavingIDValue, ReasonForLeavingIDColumn)
        rec.SetString(ReasonForLeavingNotesValue, ReasonForLeavingNotesColumn)
        rec.SetString(MilesPerWeekValue, MilesPerWeekColumn)
        rec.SetString(OperatedCommercialMotorVechicleValue, OperatedCommercialMotorVechicleColumn)
        rec.SetString(HadDrugTestingProgramValue, HadDrugTestingProgramColumn)
        rec.SetString(MayWeContactValue, MayWeContactColumn)
        rec.SetString(FirstJobValue, FirstJobColumn)
        rec.SetString(FinishedValue, FinishedColumn)
        rec.SetString(FinishedExpValue, FinishedExpColumn)
        rec.SetString(NotesValue, NotesColumn)
        rec.SetString(TerminalIDValue, TerminalIDColumn)
        rec.SetString(HireDateValue, HireDateColumn)
        rec.SetString(TermDateValue, TermDateColumn)
        rec.SetString(OverlapValue, OverlapColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        PartyWorkHistoryTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            PartyWorkHistoryTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(PartyWorkHistoryTable.Instance.TableDefinition.PrimaryKey)) Then
            Return PartyWorkHistoryTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(PartyWorkHistoryTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = PartyWorkHistoryTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = PartyWorkHistoryTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (PartyWorkHistoryTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = PartyWorkHistoryTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = PartyWorkHistoryTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = PartyWorkHistoryTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
