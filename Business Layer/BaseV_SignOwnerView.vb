' This class is "generated" and will be overwritten.
' Your customizations should be made in V_SignOwnerRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_SignOwnerView"></see> class.
''' Provides access to the schema information and record data of a database table or view named v_SignOwner.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="V_SignOwnerView.Instance">V_SignOwnerView.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="V_SignOwnerView"></seealso>

<Serializable()> Public Class BaseV_SignOwnerView
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = V_SignOwnerDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.V_SignOwnerView")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.V_SignOwnerRecord")
        Me.ApplicationName = "FASTPORT"
        Me.DataAdapter = New V_SignOwnerSqlView()
        Directcast(Me.DataAdapter, V_SignOwnerSqlView).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, V_SignOwnerSqlView).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        PartyIDColumn.CodeName = "PartyID"
        O_NameColumn.CodeName = "O_Name"
        O_DBAColumn.CodeName = "O_DBA"
        O_DBAOrNameColumn.CodeName = "O_DBAOrName"
        O_AddrHTMLColumn.CodeName = "O_AddrHTML"
        O_AddrColumn.CodeName = "O_Addr"
        O_CitySTZipColumn.CodeName = "O_CitySTZip"
        O_CityColumn.CodeName = "O_City"
        O_STColumn.CodeName = "O_ST"
        O_ZipColumn.CodeName = "O_Zip"
        O_CountryColumn.CodeName = "O_Country"
        O_SSNorEINColumn.CodeName = "O_SSNorEIN"
        O_SSNColumn.CodeName = "O_SSN"
        O_EINColumn.CodeName = "O_EIN"
        O_EntityColumn.CodeName = "O_Entity"
        O_EntitySoleColumn.CodeName = "O_EntitySole"
        O_EntityCCorpColumn.CodeName = "O_EntityCCorp"
        O_EntitySCorpColumn.CodeName = "O_EntitySCorp"
        O_EntityPartnerColumn.CodeName = "O_EntityPartner"
        O_EntityTrustEstateColumn.CodeName = "O_EntityTrustEstate"
        O_EntityLLCColumn.CodeName = "O_EntityLLC"
        O_EntityOtherColumn.CodeName = "O_EntityOther"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.PartyID column object.
    ''' </summary>
    Public ReadOnly Property PartyIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.PartyID column object.
    ''' </summary>
    Public Shared ReadOnly Property PartyID() As BaseClasses.Data.NumberColumn
        Get
            Return V_SignOwnerView.Instance.PartyIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_Name column object.
    ''' </summary>
    Public ReadOnly Property O_NameColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_Name column object.
    ''' </summary>
    Public Shared ReadOnly Property O_Name() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_NameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_DBA column object.
    ''' </summary>
    Public ReadOnly Property O_DBAColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_DBA column object.
    ''' </summary>
    Public Shared ReadOnly Property O_DBA() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_DBAColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_DBAOrName column object.
    ''' </summary>
    Public ReadOnly Property O_DBAOrNameColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_DBAOrName column object.
    ''' </summary>
    Public Shared ReadOnly Property O_DBAOrName() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_DBAOrNameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_AddrHTML column object.
    ''' </summary>
    Public ReadOnly Property O_AddrHTMLColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_AddrHTML column object.
    ''' </summary>
    Public Shared ReadOnly Property O_AddrHTML() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_AddrHTMLColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_Addr column object.
    ''' </summary>
    Public ReadOnly Property O_AddrColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_Addr column object.
    ''' </summary>
    Public Shared ReadOnly Property O_Addr() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_AddrColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_CitySTZip column object.
    ''' </summary>
    Public ReadOnly Property O_CitySTZipColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_CitySTZip column object.
    ''' </summary>
    Public Shared ReadOnly Property O_CitySTZip() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_CitySTZipColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_City column object.
    ''' </summary>
    Public ReadOnly Property O_CityColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_City column object.
    ''' </summary>
    Public Shared ReadOnly Property O_City() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_CityColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_ST column object.
    ''' </summary>
    Public ReadOnly Property O_STColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_ST column object.
    ''' </summary>
    Public Shared ReadOnly Property O_ST() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_STColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_Zip column object.
    ''' </summary>
    Public ReadOnly Property O_ZipColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_Zip column object.
    ''' </summary>
    Public Shared ReadOnly Property O_Zip() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_ZipColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_Country column object.
    ''' </summary>
    Public ReadOnly Property O_CountryColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_Country column object.
    ''' </summary>
    Public Shared ReadOnly Property O_Country() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_CountryColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_SSNorEIN column object.
    ''' </summary>
    Public ReadOnly Property O_SSNorEINColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_SSNorEIN column object.
    ''' </summary>
    Public Shared ReadOnly Property O_SSNorEIN() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_SSNorEINColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_SSN column object.
    ''' </summary>
    Public ReadOnly Property O_SSNColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_SSN column object.
    ''' </summary>
    Public Shared ReadOnly Property O_SSN() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_SSNColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EIN column object.
    ''' </summary>
    Public ReadOnly Property O_EINColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EIN column object.
    ''' </summary>
    Public Shared ReadOnly Property O_EIN() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_EINColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_Entity column object.
    ''' </summary>
    Public ReadOnly Property O_EntityColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_Entity column object.
    ''' </summary>
    Public Shared ReadOnly Property O_Entity() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_EntityColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EntitySole column object.
    ''' </summary>
    Public ReadOnly Property O_EntitySoleColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EntitySole column object.
    ''' </summary>
    Public Shared ReadOnly Property O_EntitySole() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_EntitySoleColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EntityCCorp column object.
    ''' </summary>
    Public ReadOnly Property O_EntityCCorpColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EntityCCorp column object.
    ''' </summary>
    Public Shared ReadOnly Property O_EntityCCorp() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_EntityCCorpColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EntitySCorp column object.
    ''' </summary>
    Public ReadOnly Property O_EntitySCorpColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EntitySCorp column object.
    ''' </summary>
    Public Shared ReadOnly Property O_EntitySCorp() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_EntitySCorpColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EntityPartner column object.
    ''' </summary>
    Public ReadOnly Property O_EntityPartnerColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EntityPartner column object.
    ''' </summary>
    Public Shared ReadOnly Property O_EntityPartner() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_EntityPartnerColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EntityTrustEstate column object.
    ''' </summary>
    Public ReadOnly Property O_EntityTrustEstateColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EntityTrustEstate column object.
    ''' </summary>
    Public Shared ReadOnly Property O_EntityTrustEstate() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_EntityTrustEstateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EntityLLC column object.
    ''' </summary>
    Public ReadOnly Property O_EntityLLCColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EntityLLC column object.
    ''' </summary>
    Public Shared ReadOnly Property O_EntityLLC() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_EntityLLCColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EntityOther column object.
    ''' </summary>
    Public ReadOnly Property O_EntityOtherColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_SignOwner_.O_EntityOther column object.
    ''' </summary>
    Public Shared ReadOnly Property O_EntityOther() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignOwnerView.Instance.O_EntityOtherColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_SignOwnerRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As V_SignOwnerRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_SignOwnerRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As V_SignOwnerRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_SignOwnerRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_SignOwnerRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_SignOwnerRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_SignOwnerRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_SignOwnerRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_SignOwnerRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  V_SignOwnerView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_SignOwnerRecord)), V_SignOwnerRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_SignOwnerRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_SignOwnerRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  V_SignOwnerView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_SignOwnerRecord)), V_SignOwnerRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_SignOwnerRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = V_SignOwnerView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_SignOwnerRecord)), V_SignOwnerRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_SignOwnerRecord()

        Dim recList As ArrayList = V_SignOwnerView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_SignOwnerRecord)), V_SignOwnerRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As V_SignOwnerRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = V_SignOwnerView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_SignOwnerRecord)), V_SignOwnerRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As V_SignOwnerRecord()

        Dim recList As ArrayList = V_SignOwnerView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_SignOwnerRecord)), V_SignOwnerRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(V_SignOwnerView.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(V_SignOwnerView.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(V_SignOwnerView.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(V_SignOwnerView.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_SignOwnerRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As V_SignOwnerRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_SignOwnerRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As V_SignOwnerRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_SignOwnerRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_SignOwnerRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = V_SignOwnerView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As V_SignOwnerRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), V_SignOwnerRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_SignOwnerRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_SignOwnerRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = V_SignOwnerView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As V_SignOwnerRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), V_SignOwnerRecord)
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

        Return V_SignOwnerView.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return V_SignOwnerView.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As V_SignOwnerRecord = GetRecords(where)
        Return V_SignOwnerView.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As V_SignOwnerRecord = GetRecords(join, where)
        Return V_SignOwnerView.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As V_SignOwnerRecord = GetRecords(where, orderBy)
        Return V_SignOwnerView.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As V_SignOwnerRecord = GetRecords(join, where, orderBy)
        Return V_SignOwnerView.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As V_SignOwnerRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return V_SignOwnerView.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As V_SignOwnerRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return V_SignOwnerView.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        V_SignOwnerView.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return V_SignOwnerView.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return V_SignOwnerView.Instance.ExportRecordData(whereFilter)
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

        Return V_SignOwnerView.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return V_SignOwnerView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return V_SignOwnerView.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return V_SignOwnerView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return V_SignOwnerView.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return V_SignOwnerView.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return V_SignOwnerView.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return V_SignOwnerView.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = V_SignOwnerView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As V_SignOwnerRecord
        Return CType(V_SignOwnerView.Instance.GetRecordData(id, bMutable), V_SignOwnerRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As V_SignOwnerRecord
        Return CType(V_SignOwnerView.Instance.GetRecordData(id, bMutable), V_SignOwnerRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal PartyIDValue As String, _
        ByVal O_NameValue As String, _
        ByVal O_DBAValue As String, _
        ByVal O_DBAOrNameValue As String, _
        ByVal O_AddrHTMLValue As String, _
        ByVal O_AddrValue As String, _
        ByVal O_CitySTZipValue As String, _
        ByVal O_CityValue As String, _
        ByVal O_STValue As String, _
        ByVal O_ZipValue As String, _
        ByVal O_CountryValue As String, _
        ByVal O_SSNorEINValue As String, _
        ByVal O_SSNValue As String, _
        ByVal O_EINValue As String, _
        ByVal O_EntityValue As String, _
        ByVal O_EntitySoleValue As String, _
        ByVal O_EntityCCorpValue As String, _
        ByVal O_EntitySCorpValue As String, _
        ByVal O_EntityPartnerValue As String, _
        ByVal O_EntityTrustEstateValue As String, _
        ByVal O_EntityLLCValue As String, _
        ByVal O_EntityOtherValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(PartyIDValue, PartyIDColumn)
        rec.SetString(O_NameValue, O_NameColumn)
        rec.SetString(O_DBAValue, O_DBAColumn)
        rec.SetString(O_DBAOrNameValue, O_DBAOrNameColumn)
        rec.SetString(O_AddrHTMLValue, O_AddrHTMLColumn)
        rec.SetString(O_AddrValue, O_AddrColumn)
        rec.SetString(O_CitySTZipValue, O_CitySTZipColumn)
        rec.SetString(O_CityValue, O_CityColumn)
        rec.SetString(O_STValue, O_STColumn)
        rec.SetString(O_ZipValue, O_ZipColumn)
        rec.SetString(O_CountryValue, O_CountryColumn)
        rec.SetString(O_SSNorEINValue, O_SSNorEINColumn)
        rec.SetString(O_SSNValue, O_SSNColumn)
        rec.SetString(O_EINValue, O_EINColumn)
        rec.SetString(O_EntityValue, O_EntityColumn)
        rec.SetString(O_EntitySoleValue, O_EntitySoleColumn)
        rec.SetString(O_EntityCCorpValue, O_EntityCCorpColumn)
        rec.SetString(O_EntitySCorpValue, O_EntitySCorpColumn)
        rec.SetString(O_EntityPartnerValue, O_EntityPartnerColumn)
        rec.SetString(O_EntityTrustEstateValue, O_EntityTrustEstateColumn)
        rec.SetString(O_EntityLLCValue, O_EntityLLCColumn)
        rec.SetString(O_EntityOtherValue, O_EntityOtherColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        V_SignOwnerView.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            V_SignOwnerView.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(V_SignOwnerView.Instance.TableDefinition.PrimaryKey)) Then
            Return V_SignOwnerView.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(V_SignOwnerView.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = V_SignOwnerView.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = V_SignOwnerView.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (V_SignOwnerView.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = V_SignOwnerView.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = V_SignOwnerView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = V_SignOwnerView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
