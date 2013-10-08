' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyIncidentRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PartyIncidentTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named PartyIncident.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="PartyIncidentTable.Instance">PartyIncidentTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="PartyIncidentTable"></seealso>

<Serializable()> Public Class BasePartyIncidentTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = PartyIncidentDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.PartyIncidentTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.PartyIncidentRecord")
        Me.ApplicationName = "FASTPORT"
        Me.DataAdapter = New PartyIncidentSqlTable()
        Directcast(Me.DataAdapter, PartyIncidentSqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, PartyIncidentSqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        IncidentIDColumn.CodeName = "IncidentID"
        PartyIDColumn.CodeName = "PartyID"
        IncidentCategoryIDColumn.CodeName = "IncidentCategoryID"
        ShortDescriptionColumn.CodeName = "ShortDescription"
        DetailedDescriptionColumn.CodeName = "DetailedDescription"
        OccurredOnColumn.CodeName = "OccurredOn"
        AccidentLocationIDColumn.CodeName = "AccidentLocationID"
        IWasAtFaultColumn.CodeName = "IWasAtFault"
        EstimatedCostColumn.CodeName = "EstimatedCost"
        FileClosedColumn.CodeName = "FileClosed"
        TowAWayAccidentColumn.CodeName = "TowAWayAccident"
        FatalitiesOccuredColumn.CodeName = "FatalitiesOccured"
        InjuriesOccuredColumn.CodeName = "InjuriesOccured"
        TestedAfterAccidentColumn.CodeName = "TestedAfterAccident"
        PositiveForDrugsColumn.CodeName = "PositiveForDrugs"
        PositiveForAlcoholColumn.CodeName = "PositiveForAlcohol"
        EqiupTypeIDColumn.CodeName = "EqiupTypeID"
        CargoTypeIDColumn.CodeName = "CargoTypeID"
        TicketedColumn.CodeName = "Ticketed"
        RuledAsRecklessDrivingColumn.CodeName = "RuledAsRecklessDriving"
        FelonyIssuedColumn.CodeName = "FelonyIssued"
        LicenseSuspendedColumn.CodeName = "LicenseSuspended"
        ReinstatedOnColumn.CodeName = "ReinstatedOn"
        SAPReleaseColumn.CodeName = "SAPRelease"
        SAPReleaseDateColumn.CodeName = "SAPReleaseDate"
        PhysicalLimitationExpirationColumn.CodeName = "PhysicalLimitationExpiration"
        PhysicalObsoleteColumn.CodeName = "PhysicalObsolete"
        IncidentExpirationColumn.CodeName = "IncidentExpiration"
        CreatedByIDColumn.CodeName = "CreatedByID"
        CreatedAtColumn.CodeName = "CreatedAt"
        UpdatedByIDColumn.CodeName = "UpdatedByID"
        UpdatedAtColumn.CodeName = "UpdatedAt"
        LockIncidentColumn.CodeName = "LockIncident"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.IncidentID column object.
    ''' </summary>
    Public ReadOnly Property IncidentIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.IncidentID column object.
    ''' </summary>
    Public Shared ReadOnly Property IncidentID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyIncidentTable.Instance.IncidentIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.PartyID column object.
    ''' </summary>
    Public ReadOnly Property PartyIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.PartyID column object.
    ''' </summary>
    Public Shared ReadOnly Property PartyID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyIncidentTable.Instance.PartyIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.IncidentCategoryID column object.
    ''' </summary>
    Public ReadOnly Property IncidentCategoryIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.IncidentCategoryID column object.
    ''' </summary>
    Public Shared ReadOnly Property IncidentCategoryID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyIncidentTable.Instance.IncidentCategoryIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.ShortDescription column object.
    ''' </summary>
    Public ReadOnly Property ShortDescriptionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.ShortDescription column object.
    ''' </summary>
    Public Shared ReadOnly Property ShortDescription() As BaseClasses.Data.StringColumn
        Get
            Return PartyIncidentTable.Instance.ShortDescriptionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.DetailedDescription column object.
    ''' </summary>
    Public ReadOnly Property DetailedDescriptionColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.DetailedDescription column object.
    ''' </summary>
    Public Shared ReadOnly Property DetailedDescription() As BaseClasses.Data.ClobColumn
        Get
            Return PartyIncidentTable.Instance.DetailedDescriptionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.OccurredOn column object.
    ''' </summary>
    Public ReadOnly Property OccurredOnColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.OccurredOn column object.
    ''' </summary>
    Public Shared ReadOnly Property OccurredOn() As BaseClasses.Data.DateColumn
        Get
            Return PartyIncidentTable.Instance.OccurredOnColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.AccidentLocationID column object.
    ''' </summary>
    Public ReadOnly Property AccidentLocationIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.AccidentLocationID column object.
    ''' </summary>
    Public Shared ReadOnly Property AccidentLocationID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyIncidentTable.Instance.AccidentLocationIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.IWasAtFault column object.
    ''' </summary>
    Public ReadOnly Property IWasAtFaultColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.IWasAtFault column object.
    ''' </summary>
    Public Shared ReadOnly Property IWasAtFault() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.IWasAtFaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.EstimatedCost column object.
    ''' </summary>
    Public ReadOnly Property EstimatedCostColumn() As BaseClasses.Data.CurrencyColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.CurrencyColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.EstimatedCost column object.
    ''' </summary>
    Public Shared ReadOnly Property EstimatedCost() As BaseClasses.Data.CurrencyColumn
        Get
            Return PartyIncidentTable.Instance.EstimatedCostColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.FileClosed column object.
    ''' </summary>
    Public ReadOnly Property FileClosedColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.FileClosed column object.
    ''' </summary>
    Public Shared ReadOnly Property FileClosed() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.FileClosedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.TowAWayAccident column object.
    ''' </summary>
    Public ReadOnly Property TowAWayAccidentColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.TowAWayAccident column object.
    ''' </summary>
    Public Shared ReadOnly Property TowAWayAccident() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.TowAWayAccidentColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.FatalitiesOccured column object.
    ''' </summary>
    Public ReadOnly Property FatalitiesOccuredColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.FatalitiesOccured column object.
    ''' </summary>
    Public Shared ReadOnly Property FatalitiesOccured() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.FatalitiesOccuredColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.InjuriesOccured column object.
    ''' </summary>
    Public ReadOnly Property InjuriesOccuredColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.InjuriesOccured column object.
    ''' </summary>
    Public Shared ReadOnly Property InjuriesOccured() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.InjuriesOccuredColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.TestedAfterAccident column object.
    ''' </summary>
    Public ReadOnly Property TestedAfterAccidentColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.TestedAfterAccident column object.
    ''' </summary>
    Public Shared ReadOnly Property TestedAfterAccident() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.TestedAfterAccidentColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.PositiveForDrugs column object.
    ''' </summary>
    Public ReadOnly Property PositiveForDrugsColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.PositiveForDrugs column object.
    ''' </summary>
    Public Shared ReadOnly Property PositiveForDrugs() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.PositiveForDrugsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.PositiveForAlcohol column object.
    ''' </summary>
    Public ReadOnly Property PositiveForAlcoholColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.PositiveForAlcohol column object.
    ''' </summary>
    Public Shared ReadOnly Property PositiveForAlcohol() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.PositiveForAlcoholColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.EqiupTypeID column object.
    ''' </summary>
    Public ReadOnly Property EqiupTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.EqiupTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property EqiupTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyIncidentTable.Instance.EqiupTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.CargoTypeID column object.
    ''' </summary>
    Public ReadOnly Property CargoTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.CargoTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property CargoTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyIncidentTable.Instance.CargoTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.Ticketed column object.
    ''' </summary>
    Public ReadOnly Property TicketedColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.Ticketed column object.
    ''' </summary>
    Public Shared ReadOnly Property Ticketed() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.TicketedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.RuledAsRecklessDriving column object.
    ''' </summary>
    Public ReadOnly Property RuledAsRecklessDrivingColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.RuledAsRecklessDriving column object.
    ''' </summary>
    Public Shared ReadOnly Property RuledAsRecklessDriving() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.RuledAsRecklessDrivingColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.FelonyIssued column object.
    ''' </summary>
    Public ReadOnly Property FelonyIssuedColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.FelonyIssued column object.
    ''' </summary>
    Public Shared ReadOnly Property FelonyIssued() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.FelonyIssuedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.LicenseSuspended column object.
    ''' </summary>
    Public ReadOnly Property LicenseSuspendedColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.LicenseSuspended column object.
    ''' </summary>
    Public Shared ReadOnly Property LicenseSuspended() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.LicenseSuspendedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.ReinstatedOn column object.
    ''' </summary>
    Public ReadOnly Property ReinstatedOnColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.ReinstatedOn column object.
    ''' </summary>
    Public Shared ReadOnly Property ReinstatedOn() As BaseClasses.Data.DateColumn
        Get
            Return PartyIncidentTable.Instance.ReinstatedOnColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.SAPRelease column object.
    ''' </summary>
    Public ReadOnly Property SAPReleaseColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.SAPRelease column object.
    ''' </summary>
    Public Shared ReadOnly Property SAPRelease() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.SAPReleaseColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.SAPReleaseDate column object.
    ''' </summary>
    Public ReadOnly Property SAPReleaseDateColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.SAPReleaseDate column object.
    ''' </summary>
    Public Shared ReadOnly Property SAPReleaseDate() As BaseClasses.Data.DateColumn
        Get
            Return PartyIncidentTable.Instance.SAPReleaseDateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.PhysicalLimitationExpiration column object.
    ''' </summary>
    Public ReadOnly Property PhysicalLimitationExpirationColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.PhysicalLimitationExpiration column object.
    ''' </summary>
    Public Shared ReadOnly Property PhysicalLimitationExpiration() As BaseClasses.Data.DateColumn
        Get
            Return PartyIncidentTable.Instance.PhysicalLimitationExpirationColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.PhysicalObsolete column object.
    ''' </summary>
    Public ReadOnly Property PhysicalObsoleteColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.PhysicalObsolete column object.
    ''' </summary>
    Public Shared ReadOnly Property PhysicalObsolete() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.PhysicalObsoleteColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.IncidentExpiration column object.
    ''' </summary>
    Public ReadOnly Property IncidentExpirationColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.IncidentExpiration column object.
    ''' </summary>
    Public Shared ReadOnly Property IncidentExpiration() As BaseClasses.Data.DateColumn
        Get
            Return PartyIncidentTable.Instance.IncidentExpirationColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.CreatedByID column object.
    ''' </summary>
    Public ReadOnly Property CreatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.CreatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyIncidentTable.Instance.CreatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.CreatedAt column object.
    ''' </summary>
    Public ReadOnly Property CreatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.CreatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedAt() As BaseClasses.Data.DateColumn
        Get
            Return PartyIncidentTable.Instance.CreatedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.UpdatedByID column object.
    ''' </summary>
    Public ReadOnly Property UpdatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.UpdatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyIncidentTable.Instance.UpdatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.UpdatedAt column object.
    ''' </summary>
    Public ReadOnly Property UpdatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.UpdatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedAt() As BaseClasses.Data.DateColumn
        Get
            Return PartyIncidentTable.Instance.UpdatedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.LockIncident column object.
    ''' </summary>
    Public ReadOnly Property LockIncidentColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(32), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyIncident_.LockIncident column object.
    ''' </summary>
    Public Shared ReadOnly Property LockIncident() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyIncidentTable.Instance.LockIncidentColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyIncidentRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As PartyIncidentRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyIncidentRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As PartyIncidentRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyIncidentRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyIncidentRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyIncidentRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyIncidentRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyIncidentRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyIncidentRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  PartyIncidentTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyIncidentRecord)), PartyIncidentRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyIncidentRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyIncidentRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  PartyIncidentTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyIncidentRecord)), PartyIncidentRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyIncidentRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = PartyIncidentTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyIncidentRecord)), PartyIncidentRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyIncidentRecord()

        Dim recList As ArrayList = PartyIncidentTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyIncidentRecord)), PartyIncidentRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As PartyIncidentRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = PartyIncidentTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyIncidentRecord)), PartyIncidentRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As PartyIncidentRecord()

        Dim recList As ArrayList = PartyIncidentTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyIncidentRecord)), PartyIncidentRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(PartyIncidentTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(PartyIncidentTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(PartyIncidentTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(PartyIncidentTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyIncidentRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As PartyIncidentRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyIncidentRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As PartyIncidentRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyIncidentRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyIncidentRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = PartyIncidentTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As PartyIncidentRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), PartyIncidentRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyIncidentRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyIncidentRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = PartyIncidentTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As PartyIncidentRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), PartyIncidentRecord)
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

        Return PartyIncidentTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return PartyIncidentTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As PartyIncidentRecord = GetRecords(where)
        Return PartyIncidentTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As PartyIncidentRecord = GetRecords(join, where)
        Return PartyIncidentTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As PartyIncidentRecord = GetRecords(where, orderBy)
        Return PartyIncidentTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As PartyIncidentRecord = GetRecords(join, where, orderBy)
        Return PartyIncidentTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As PartyIncidentRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return PartyIncidentTable.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As PartyIncidentRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return PartyIncidentTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        PartyIncidentTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return PartyIncidentTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return PartyIncidentTable.Instance.ExportRecordData(whereFilter)
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

        Return PartyIncidentTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return PartyIncidentTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return PartyIncidentTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return PartyIncidentTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return PartyIncidentTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return PartyIncidentTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return PartyIncidentTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return PartyIncidentTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = PartyIncidentTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As PartyIncidentRecord
        Return CType(PartyIncidentTable.Instance.GetRecordData(id, bMutable), PartyIncidentRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As PartyIncidentRecord
        Return CType(PartyIncidentTable.Instance.GetRecordData(id, bMutable), PartyIncidentRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal PartyIDValue As String, _
        ByVal IncidentCategoryIDValue As String, _
        ByVal ShortDescriptionValue As String, _
        ByVal DetailedDescriptionValue As String, _
        ByVal OccurredOnValue As String, _
        ByVal AccidentLocationIDValue As String, _
        ByVal IWasAtFaultValue As String, _
        ByVal EstimatedCostValue As String, _
        ByVal FileClosedValue As String, _
        ByVal TowAWayAccidentValue As String, _
        ByVal FatalitiesOccuredValue As String, _
        ByVal InjuriesOccuredValue As String, _
        ByVal TestedAfterAccidentValue As String, _
        ByVal PositiveForDrugsValue As String, _
        ByVal PositiveForAlcoholValue As String, _
        ByVal EqiupTypeIDValue As String, _
        ByVal CargoTypeIDValue As String, _
        ByVal TicketedValue As String, _
        ByVal RuledAsRecklessDrivingValue As String, _
        ByVal FelonyIssuedValue As String, _
        ByVal LicenseSuspendedValue As String, _
        ByVal ReinstatedOnValue As String, _
        ByVal SAPReleaseValue As String, _
        ByVal SAPReleaseDateValue As String, _
        ByVal PhysicalLimitationExpirationValue As String, _
        ByVal PhysicalObsoleteValue As String, _
        ByVal IncidentExpirationValue As String, _
        ByVal CreatedByIDValue As String, _
        ByVal CreatedAtValue As String, _
        ByVal UpdatedByIDValue As String, _
        ByVal UpdatedAtValue As String, _
        ByVal LockIncidentValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(PartyIDValue, PartyIDColumn)
        rec.SetString(IncidentCategoryIDValue, IncidentCategoryIDColumn)
        rec.SetString(ShortDescriptionValue, ShortDescriptionColumn)
        rec.SetString(DetailedDescriptionValue, DetailedDescriptionColumn)
        rec.SetString(OccurredOnValue, OccurredOnColumn)
        rec.SetString(AccidentLocationIDValue, AccidentLocationIDColumn)
        rec.SetString(IWasAtFaultValue, IWasAtFaultColumn)
        rec.SetString(EstimatedCostValue, EstimatedCostColumn)
        rec.SetString(FileClosedValue, FileClosedColumn)
        rec.SetString(TowAWayAccidentValue, TowAWayAccidentColumn)
        rec.SetString(FatalitiesOccuredValue, FatalitiesOccuredColumn)
        rec.SetString(InjuriesOccuredValue, InjuriesOccuredColumn)
        rec.SetString(TestedAfterAccidentValue, TestedAfterAccidentColumn)
        rec.SetString(PositiveForDrugsValue, PositiveForDrugsColumn)
        rec.SetString(PositiveForAlcoholValue, PositiveForAlcoholColumn)
        rec.SetString(EqiupTypeIDValue, EqiupTypeIDColumn)
        rec.SetString(CargoTypeIDValue, CargoTypeIDColumn)
        rec.SetString(TicketedValue, TicketedColumn)
        rec.SetString(RuledAsRecklessDrivingValue, RuledAsRecklessDrivingColumn)
        rec.SetString(FelonyIssuedValue, FelonyIssuedColumn)
        rec.SetString(LicenseSuspendedValue, LicenseSuspendedColumn)
        rec.SetString(ReinstatedOnValue, ReinstatedOnColumn)
        rec.SetString(SAPReleaseValue, SAPReleaseColumn)
        rec.SetString(SAPReleaseDateValue, SAPReleaseDateColumn)
        rec.SetString(PhysicalLimitationExpirationValue, PhysicalLimitationExpirationColumn)
        rec.SetString(PhysicalObsoleteValue, PhysicalObsoleteColumn)
        rec.SetString(IncidentExpirationValue, IncidentExpirationColumn)
        rec.SetString(CreatedByIDValue, CreatedByIDColumn)
        rec.SetString(CreatedAtValue, CreatedAtColumn)
        rec.SetString(UpdatedByIDValue, UpdatedByIDColumn)
        rec.SetString(UpdatedAtValue, UpdatedAtColumn)
        rec.SetString(LockIncidentValue, LockIncidentColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        PartyIncidentTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            PartyIncidentTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(PartyIncidentTable.Instance.TableDefinition.PrimaryKey)) Then
            Return PartyIncidentTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(PartyIncidentTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = PartyIncidentTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = PartyIncidentTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (PartyIncidentTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = PartyIncidentTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = PartyIncidentTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = PartyIncidentTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
