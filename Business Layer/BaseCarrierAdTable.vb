' This class is "generated" and will be overwritten.
' Your customizations should be made in CarrierAdRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="CarrierAdTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named CarrierAd.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="CarrierAdTable.Instance">CarrierAdTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="CarrierAdTable"></seealso>

<Serializable()> Public Class BaseCarrierAdTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = CarrierAdDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.CarrierAdTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.CarrierAdRecord")
        Me.ApplicationName = "FASTPORT"
        Me.DataAdapter = New CarrierAdSqlTable()
        Directcast(Me.DataAdapter, CarrierAdSqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, CarrierAdSqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        AdIDColumn.CodeName = "AdID"
        CarrierIDColumn.CodeName = "CarrierID"
        AdTemplateColumn.CodeName = "AdTemplate"
        AdNameColumn.CodeName = "AdName"
        TruckerTypeIDColumn.CodeName = "TruckerTypeID"
        ShortDescriptionColumn.CodeName = "ShortDescription"
        LongDescriptionColumn.CodeName = "LongDescription"
        RunOnColumn.CodeName = "RunOn"
        ExpireOnColumn.CodeName = "ExpireOn"
        LimitByAgeColumn.CodeName = "LimitByAge"
        PositionsAvailColumn.CodeName = "PositionsAvail"
        MinAgeColumn.CodeName = "MinAge"
        HideAdColumn.CodeName = "HideAd"
        MapThumbnailColumn.CodeName = "MapThumbnail"
        PSPMaximumColumn.CodeName = "PSPMaximum"
        LimitByMajorAccidentsColumn.CodeName = "LimitByMajorAccidents"
        MajorByIDColumn.CodeName = "MajorByID"
        MajorCountIDColumn.CodeName = "MajorCountID"
        MajorMilesIDColumn.CodeName = "MajorMilesID"
        MajorYearsIDColumn.CodeName = "MajorYearsID"
        LimitByMinorAccidentsColumn.CodeName = "LimitByMinorAccidents"
        MinorByIDColumn.CodeName = "MinorByID"
        MinorCountIDColumn.CodeName = "MinorCountID"
        MinorMilesIDColumn.CodeName = "MinorMilesID"
        MinorYearsIDColumn.CodeName = "MinorYearsID"
        LimitByTicketsColumn.CodeName = "LimitByTickets"
        TicketsByIDColumn.CodeName = "TicketsByID"
        TicketCountIDColumn.CodeName = "TicketCountID"
        TicketMilesIDColumn.CodeName = "TicketMilesID"
        TicketYearsIDColumn.CodeName = "TicketYearsID"
        LimitBySeriousTicketsColumn.CodeName = "LimitBySeriousTickets"
        SeriousByIDColumn.CodeName = "SeriousByID"
        SeriousCountIDColumn.CodeName = "SeriousCountID"
        SeriousMilesIDColumn.CodeName = "SeriousMilesID"
        SeriousYearsIDColumn.CodeName = "SeriousYearsID"
        LimitByFeloniesColumn.CodeName = "LimitByFelonies"
        FeloniesByIDColumn.CodeName = "FeloniesByID"
        FelonyCountIDColumn.CodeName = "FelonyCountID"
        FelonyMilesIDColumn.CodeName = "FelonyMilesID"
        FelonyYearsIDColumn.CodeName = "FelonyYearsID"
        LimitByDrugConvictionsColumn.CodeName = "LimitByDrugConvictions"
        DrugConvictionsByIDColumn.CodeName = "DrugConvictionsByID"
        DrugCountIDColumn.CodeName = "DrugCountID"
        DrugConvictionMilesIDColumn.CodeName = "DrugConvictionMilesID"
        DrugYearsIDColumn.CodeName = "DrugYearsID"
        LimitByFailedTestColumn.CodeName = "LimitByFailedTest"
        FailedByIDColumn.CodeName = "FailedByID"
        FailedCountIDColumn.CodeName = "FailedCountID"
        FailedMilesIDColumn.CodeName = "FailedMilesID"
        FailedYearsIDColumn.CodeName = "FailedYearsID"
        LimitByDUICommercialColumn.CodeName = "LimitByDUICommercial"
        CommDUIByIDColumn.CodeName = "CommDUIByID"
        CommDUICountIDColumn.CodeName = "CommDUICountID"
        CommDUIMilesIDColumn.CodeName = "CommDUIMilesID"
        CommDUIYearsIDColumn.CodeName = "CommDUIYearsID"
        LimitByDUIPersonalColumn.CodeName = "LimitByDUIPersonal"
        PersonalDUIByIDColumn.CodeName = "PersonalDUIByID"
        PersonalDUICountIDColumn.CodeName = "PersonalDUICountID"
        PersonalDUIMilesIDColumn.CodeName = "PersonalDUIMilesID"
        PersonalDUIYearsIDColumn.CodeName = "PersonalDUIYearsID"
        PayTypeIDColumn.CodeName = "PayTypeID"
        LineHaulPercColumn.CodeName = "LineHaulPerc"
        LoadedPerMileColumn.CodeName = "LoadedPerMile"
        EmptyPerMileColumn.CodeName = "EmptyPerMile"
        HourlyRateColumn.CodeName = "HourlyRate"
        AvgPayPerWeekColumn.CodeName = "AvgPayPerWeek"
        PayGuarantyColumn.CodeName = "PayGuaranty"
        FuelReimbursedColumn.CodeName = "FuelReimbursed"
        AllFuelColumn.CodeName = "AllFuel"
        FuelGuarantyColumn.CodeName = "FuelGuaranty"
        PayNotesColumn.CodeName = "PayNotes"
        OtherRequirementsColumn.CodeName = "OtherRequirements"
        LinksToOtherPostingsColumn.CodeName = "LinksToOtherPostings"
        NoAdColumn.CodeName = "NoAd"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.AdID column object.
    ''' </summary>
    Public ReadOnly Property AdIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.AdID column object.
    ''' </summary>
    Public Shared ReadOnly Property AdID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.AdIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.CarrierID column object.
    ''' </summary>
    Public ReadOnly Property CarrierIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.CarrierID column object.
    ''' </summary>
    Public Shared ReadOnly Property CarrierID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.CarrierIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.AdTemplate column object.
    ''' </summary>
    Public ReadOnly Property AdTemplateColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.AdTemplate column object.
    ''' </summary>
    Public Shared ReadOnly Property AdTemplate() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.AdTemplateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.AdName column object.
    ''' </summary>
    Public ReadOnly Property AdNameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.AdName column object.
    ''' </summary>
    Public Shared ReadOnly Property AdName() As BaseClasses.Data.StringColumn
        Get
            Return CarrierAdTable.Instance.AdNameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.TruckerTypeID column object.
    ''' </summary>
    Public ReadOnly Property TruckerTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.TruckerTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property TruckerTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.TruckerTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.ShortDescription column object.
    ''' </summary>
    Public ReadOnly Property ShortDescriptionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.ShortDescription column object.
    ''' </summary>
    Public Shared ReadOnly Property ShortDescription() As BaseClasses.Data.StringColumn
        Get
            Return CarrierAdTable.Instance.ShortDescriptionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LongDescription column object.
    ''' </summary>
    Public ReadOnly Property LongDescriptionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LongDescription column object.
    ''' </summary>
    Public Shared ReadOnly Property LongDescription() As BaseClasses.Data.StringColumn
        Get
            Return CarrierAdTable.Instance.LongDescriptionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.RunOn column object.
    ''' </summary>
    Public ReadOnly Property RunOnColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.RunOn column object.
    ''' </summary>
    Public Shared ReadOnly Property RunOn() As BaseClasses.Data.DateColumn
        Get
            Return CarrierAdTable.Instance.RunOnColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.ExpireOn column object.
    ''' </summary>
    Public ReadOnly Property ExpireOnColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.ExpireOn column object.
    ''' </summary>
    Public Shared ReadOnly Property ExpireOn() As BaseClasses.Data.DateColumn
        Get
            Return CarrierAdTable.Instance.ExpireOnColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByAge column object.
    ''' </summary>
    Public ReadOnly Property LimitByAgeColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByAge column object.
    ''' </summary>
    Public Shared ReadOnly Property LimitByAge() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.LimitByAgeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PositionsAvail column object.
    ''' </summary>
    Public ReadOnly Property PositionsAvailColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PositionsAvail column object.
    ''' </summary>
    Public Shared ReadOnly Property PositionsAvail() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.PositionsAvailColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MinAge column object.
    ''' </summary>
    Public ReadOnly Property MinAgeColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MinAge column object.
    ''' </summary>
    Public Shared ReadOnly Property MinAge() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.MinAgeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.HideAd column object.
    ''' </summary>
    Public ReadOnly Property HideAdColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.HideAd column object.
    ''' </summary>
    Public Shared ReadOnly Property HideAd() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.HideAdColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MapThumbnail column object.
    ''' </summary>
    Public ReadOnly Property MapThumbnailColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MapThumbnail column object.
    ''' </summary>
    Public Shared ReadOnly Property MapThumbnail() As BaseClasses.Data.ImageColumn
        Get
            Return CarrierAdTable.Instance.MapThumbnailColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PSPMaximum column object.
    ''' </summary>
    Public ReadOnly Property PSPMaximumColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PSPMaximum column object.
    ''' </summary>
    Public Shared ReadOnly Property PSPMaximum() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.PSPMaximumColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByMajorAccidents column object.
    ''' </summary>
    Public ReadOnly Property LimitByMajorAccidentsColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByMajorAccidents column object.
    ''' </summary>
    Public Shared ReadOnly Property LimitByMajorAccidents() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.LimitByMajorAccidentsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MajorByID column object.
    ''' </summary>
    Public ReadOnly Property MajorByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MajorByID column object.
    ''' </summary>
    Public Shared ReadOnly Property MajorByID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.MajorByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MajorCountID column object.
    ''' </summary>
    Public ReadOnly Property MajorCountIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MajorCountID column object.
    ''' </summary>
    Public Shared ReadOnly Property MajorCountID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.MajorCountIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MajorMilesID column object.
    ''' </summary>
    Public ReadOnly Property MajorMilesIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MajorMilesID column object.
    ''' </summary>
    Public Shared ReadOnly Property MajorMilesID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.MajorMilesIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MajorYearsID column object.
    ''' </summary>
    Public ReadOnly Property MajorYearsIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MajorYearsID column object.
    ''' </summary>
    Public Shared ReadOnly Property MajorYearsID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.MajorYearsIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByMinorAccidents column object.
    ''' </summary>
    Public ReadOnly Property LimitByMinorAccidentsColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByMinorAccidents column object.
    ''' </summary>
    Public Shared ReadOnly Property LimitByMinorAccidents() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.LimitByMinorAccidentsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MinorByID column object.
    ''' </summary>
    Public ReadOnly Property MinorByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MinorByID column object.
    ''' </summary>
    Public Shared ReadOnly Property MinorByID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.MinorByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MinorCountID column object.
    ''' </summary>
    Public ReadOnly Property MinorCountIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MinorCountID column object.
    ''' </summary>
    Public Shared ReadOnly Property MinorCountID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.MinorCountIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MinorMilesID column object.
    ''' </summary>
    Public ReadOnly Property MinorMilesIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MinorMilesID column object.
    ''' </summary>
    Public Shared ReadOnly Property MinorMilesID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.MinorMilesIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MinorYearsID column object.
    ''' </summary>
    Public ReadOnly Property MinorYearsIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.MinorYearsID column object.
    ''' </summary>
    Public Shared ReadOnly Property MinorYearsID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.MinorYearsIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByTickets column object.
    ''' </summary>
    Public ReadOnly Property LimitByTicketsColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByTickets column object.
    ''' </summary>
    Public Shared ReadOnly Property LimitByTickets() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.LimitByTicketsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.TicketsByID column object.
    ''' </summary>
    Public ReadOnly Property TicketsByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.TicketsByID column object.
    ''' </summary>
    Public Shared ReadOnly Property TicketsByID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.TicketsByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.TicketCountID column object.
    ''' </summary>
    Public ReadOnly Property TicketCountIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.TicketCountID column object.
    ''' </summary>
    Public Shared ReadOnly Property TicketCountID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.TicketCountIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.TicketMilesID column object.
    ''' </summary>
    Public ReadOnly Property TicketMilesIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.TicketMilesID column object.
    ''' </summary>
    Public Shared ReadOnly Property TicketMilesID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.TicketMilesIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.TicketYearsID column object.
    ''' </summary>
    Public ReadOnly Property TicketYearsIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.TicketYearsID column object.
    ''' </summary>
    Public Shared ReadOnly Property TicketYearsID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.TicketYearsIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitBySeriousTickets column object.
    ''' </summary>
    Public ReadOnly Property LimitBySeriousTicketsColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitBySeriousTickets column object.
    ''' </summary>
    Public Shared ReadOnly Property LimitBySeriousTickets() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.LimitBySeriousTicketsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.SeriousByID column object.
    ''' </summary>
    Public ReadOnly Property SeriousByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.SeriousByID column object.
    ''' </summary>
    Public Shared ReadOnly Property SeriousByID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.SeriousByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.SeriousCountID column object.
    ''' </summary>
    Public ReadOnly Property SeriousCountIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(32), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.SeriousCountID column object.
    ''' </summary>
    Public Shared ReadOnly Property SeriousCountID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.SeriousCountIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.SeriousMilesID column object.
    ''' </summary>
    Public ReadOnly Property SeriousMilesIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(33), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.SeriousMilesID column object.
    ''' </summary>
    Public Shared ReadOnly Property SeriousMilesID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.SeriousMilesIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.SeriousYearsID column object.
    ''' </summary>
    Public ReadOnly Property SeriousYearsIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(34), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.SeriousYearsID column object.
    ''' </summary>
    Public Shared ReadOnly Property SeriousYearsID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.SeriousYearsIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByFelonies column object.
    ''' </summary>
    Public ReadOnly Property LimitByFeloniesColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(35), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByFelonies column object.
    ''' </summary>
    Public Shared ReadOnly Property LimitByFelonies() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.LimitByFeloniesColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FeloniesByID column object.
    ''' </summary>
    Public ReadOnly Property FeloniesByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(36), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FeloniesByID column object.
    ''' </summary>
    Public Shared ReadOnly Property FeloniesByID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.FeloniesByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FelonyCountID column object.
    ''' </summary>
    Public ReadOnly Property FelonyCountIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(37), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FelonyCountID column object.
    ''' </summary>
    Public Shared ReadOnly Property FelonyCountID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.FelonyCountIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FelonyMilesID column object.
    ''' </summary>
    Public ReadOnly Property FelonyMilesIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(38), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FelonyMilesID column object.
    ''' </summary>
    Public Shared ReadOnly Property FelonyMilesID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.FelonyMilesIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FelonyYearsID column object.
    ''' </summary>
    Public ReadOnly Property FelonyYearsIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(39), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FelonyYearsID column object.
    ''' </summary>
    Public Shared ReadOnly Property FelonyYearsID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.FelonyYearsIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByDrugConvictions column object.
    ''' </summary>
    Public ReadOnly Property LimitByDrugConvictionsColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(40), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByDrugConvictions column object.
    ''' </summary>
    Public Shared ReadOnly Property LimitByDrugConvictions() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.LimitByDrugConvictionsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.DrugConvictionsByID column object.
    ''' </summary>
    Public ReadOnly Property DrugConvictionsByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(41), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.DrugConvictionsByID column object.
    ''' </summary>
    Public Shared ReadOnly Property DrugConvictionsByID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.DrugConvictionsByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.DrugCountID column object.
    ''' </summary>
    Public ReadOnly Property DrugCountIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(42), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.DrugCountID column object.
    ''' </summary>
    Public Shared ReadOnly Property DrugCountID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.DrugCountIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.DrugConvictionMilesID column object.
    ''' </summary>
    Public ReadOnly Property DrugConvictionMilesIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(43), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.DrugConvictionMilesID column object.
    ''' </summary>
    Public Shared ReadOnly Property DrugConvictionMilesID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.DrugConvictionMilesIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.DrugYearsID column object.
    ''' </summary>
    Public ReadOnly Property DrugYearsIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(44), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.DrugYearsID column object.
    ''' </summary>
    Public Shared ReadOnly Property DrugYearsID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.DrugYearsIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByFailedTest column object.
    ''' </summary>
    Public ReadOnly Property LimitByFailedTestColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(45), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByFailedTest column object.
    ''' </summary>
    Public Shared ReadOnly Property LimitByFailedTest() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.LimitByFailedTestColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FailedByID column object.
    ''' </summary>
    Public ReadOnly Property FailedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(46), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FailedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property FailedByID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.FailedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FailedCountID column object.
    ''' </summary>
    Public ReadOnly Property FailedCountIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(47), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FailedCountID column object.
    ''' </summary>
    Public Shared ReadOnly Property FailedCountID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.FailedCountIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FailedMilesID column object.
    ''' </summary>
    Public ReadOnly Property FailedMilesIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(48), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FailedMilesID column object.
    ''' </summary>
    Public Shared ReadOnly Property FailedMilesID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.FailedMilesIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FailedYearsID column object.
    ''' </summary>
    Public ReadOnly Property FailedYearsIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(49), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FailedYearsID column object.
    ''' </summary>
    Public Shared ReadOnly Property FailedYearsID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.FailedYearsIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByDUICommercial column object.
    ''' </summary>
    Public ReadOnly Property LimitByDUICommercialColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(50), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByDUICommercial column object.
    ''' </summary>
    Public Shared ReadOnly Property LimitByDUICommercial() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.LimitByDUICommercialColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.CommDUIByID column object.
    ''' </summary>
    Public ReadOnly Property CommDUIByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(51), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.CommDUIByID column object.
    ''' </summary>
    Public Shared ReadOnly Property CommDUIByID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.CommDUIByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.CommDUICountID column object.
    ''' </summary>
    Public ReadOnly Property CommDUICountIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(52), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.CommDUICountID column object.
    ''' </summary>
    Public Shared ReadOnly Property CommDUICountID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.CommDUICountIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.CommDUIMilesID column object.
    ''' </summary>
    Public ReadOnly Property CommDUIMilesIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(53), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.CommDUIMilesID column object.
    ''' </summary>
    Public Shared ReadOnly Property CommDUIMilesID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.CommDUIMilesIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.CommDUIYearsID column object.
    ''' </summary>
    Public ReadOnly Property CommDUIYearsIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(54), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.CommDUIYearsID column object.
    ''' </summary>
    Public Shared ReadOnly Property CommDUIYearsID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.CommDUIYearsIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByDUIPersonal column object.
    ''' </summary>
    Public ReadOnly Property LimitByDUIPersonalColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(55), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LimitByDUIPersonal column object.
    ''' </summary>
    Public Shared ReadOnly Property LimitByDUIPersonal() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.LimitByDUIPersonalColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PersonalDUIByID column object.
    ''' </summary>
    Public ReadOnly Property PersonalDUIByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(56), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PersonalDUIByID column object.
    ''' </summary>
    Public Shared ReadOnly Property PersonalDUIByID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.PersonalDUIByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PersonalDUICountID column object.
    ''' </summary>
    Public ReadOnly Property PersonalDUICountIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(57), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PersonalDUICountID column object.
    ''' </summary>
    Public Shared ReadOnly Property PersonalDUICountID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.PersonalDUICountIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PersonalDUIMilesID column object.
    ''' </summary>
    Public ReadOnly Property PersonalDUIMilesIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(58), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PersonalDUIMilesID column object.
    ''' </summary>
    Public Shared ReadOnly Property PersonalDUIMilesID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.PersonalDUIMilesIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PersonalDUIYearsID column object.
    ''' </summary>
    Public ReadOnly Property PersonalDUIYearsIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(59), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PersonalDUIYearsID column object.
    ''' </summary>
    Public Shared ReadOnly Property PersonalDUIYearsID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.PersonalDUIYearsIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PayTypeID column object.
    ''' </summary>
    Public ReadOnly Property PayTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(60), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PayTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property PayTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.PayTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LineHaulPerc column object.
    ''' </summary>
    Public ReadOnly Property LineHaulPercColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(61), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LineHaulPerc column object.
    ''' </summary>
    Public Shared ReadOnly Property LineHaulPerc() As BaseClasses.Data.NumberColumn
        Get
            Return CarrierAdTable.Instance.LineHaulPercColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LoadedPerMile column object.
    ''' </summary>
    Public ReadOnly Property LoadedPerMileColumn() As BaseClasses.Data.CurrencyColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(62), BaseClasses.Data.CurrencyColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LoadedPerMile column object.
    ''' </summary>
    Public Shared ReadOnly Property LoadedPerMile() As BaseClasses.Data.CurrencyColumn
        Get
            Return CarrierAdTable.Instance.LoadedPerMileColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.EmptyPerMile column object.
    ''' </summary>
    Public ReadOnly Property EmptyPerMileColumn() As BaseClasses.Data.CurrencyColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(63), BaseClasses.Data.CurrencyColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.EmptyPerMile column object.
    ''' </summary>
    Public Shared ReadOnly Property EmptyPerMile() As BaseClasses.Data.CurrencyColumn
        Get
            Return CarrierAdTable.Instance.EmptyPerMileColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.HourlyRate column object.
    ''' </summary>
    Public ReadOnly Property HourlyRateColumn() As BaseClasses.Data.CurrencyColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(64), BaseClasses.Data.CurrencyColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.HourlyRate column object.
    ''' </summary>
    Public Shared ReadOnly Property HourlyRate() As BaseClasses.Data.CurrencyColumn
        Get
            Return CarrierAdTable.Instance.HourlyRateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.AvgPayPerWeek column object.
    ''' </summary>
    Public ReadOnly Property AvgPayPerWeekColumn() As BaseClasses.Data.CurrencyColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(65), BaseClasses.Data.CurrencyColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.AvgPayPerWeek column object.
    ''' </summary>
    Public Shared ReadOnly Property AvgPayPerWeek() As BaseClasses.Data.CurrencyColumn
        Get
            Return CarrierAdTable.Instance.AvgPayPerWeekColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PayGuaranty column object.
    ''' </summary>
    Public ReadOnly Property PayGuarantyColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(66), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PayGuaranty column object.
    ''' </summary>
    Public Shared ReadOnly Property PayGuaranty() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.PayGuarantyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FuelReimbursed column object.
    ''' </summary>
    Public ReadOnly Property FuelReimbursedColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(67), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FuelReimbursed column object.
    ''' </summary>
    Public Shared ReadOnly Property FuelReimbursed() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.FuelReimbursedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.AllFuel column object.
    ''' </summary>
    Public ReadOnly Property AllFuelColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(68), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.AllFuel column object.
    ''' </summary>
    Public Shared ReadOnly Property AllFuel() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.AllFuelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FuelGuaranty column object.
    ''' </summary>
    Public ReadOnly Property FuelGuarantyColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(69), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.FuelGuaranty column object.
    ''' </summary>
    Public Shared ReadOnly Property FuelGuaranty() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.FuelGuarantyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PayNotes column object.
    ''' </summary>
    Public ReadOnly Property PayNotesColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(70), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.PayNotes column object.
    ''' </summary>
    Public Shared ReadOnly Property PayNotes() As BaseClasses.Data.StringColumn
        Get
            Return CarrierAdTable.Instance.PayNotesColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.OtherRequirements column object.
    ''' </summary>
    Public ReadOnly Property OtherRequirementsColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(71), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.OtherRequirements column object.
    ''' </summary>
    Public Shared ReadOnly Property OtherRequirements() As BaseClasses.Data.StringColumn
        Get
            Return CarrierAdTable.Instance.OtherRequirementsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LinksToOtherPostings column object.
    ''' </summary>
    Public ReadOnly Property LinksToOtherPostingsColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(72), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.LinksToOtherPostings column object.
    ''' </summary>
    Public Shared ReadOnly Property LinksToOtherPostings() As BaseClasses.Data.StringColumn
        Get
            Return CarrierAdTable.Instance.LinksToOtherPostingsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.NoAd column object.
    ''' </summary>
    Public ReadOnly Property NoAdColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(73), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's CarrierAd_.NoAd column object.
    ''' </summary>
    Public Shared ReadOnly Property NoAd() As BaseClasses.Data.BooleanColumn
        Get
            Return CarrierAdTable.Instance.NoAdColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of CarrierAdRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As CarrierAdRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of CarrierAdRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As CarrierAdRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of CarrierAdRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As CarrierAdRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of CarrierAdRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As CarrierAdRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of CarrierAdRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As CarrierAdRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  CarrierAdTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.CarrierAdRecord)), CarrierAdRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of CarrierAdRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As CarrierAdRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  CarrierAdTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.CarrierAdRecord)), CarrierAdRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As CarrierAdRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = CarrierAdTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.CarrierAdRecord)), CarrierAdRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As CarrierAdRecord()

        Dim recList As ArrayList = CarrierAdTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.CarrierAdRecord)), CarrierAdRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As CarrierAdRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = CarrierAdTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.CarrierAdRecord)), CarrierAdRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As CarrierAdRecord()

        Dim recList As ArrayList = CarrierAdTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.CarrierAdRecord)), CarrierAdRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(CarrierAdTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(CarrierAdTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(CarrierAdTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(CarrierAdTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a CarrierAdRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As CarrierAdRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a CarrierAdRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As CarrierAdRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a CarrierAdRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As CarrierAdRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = CarrierAdTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As CarrierAdRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), CarrierAdRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a CarrierAdRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As CarrierAdRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = CarrierAdTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As CarrierAdRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), CarrierAdRecord)
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

        Return CarrierAdTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return CarrierAdTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As CarrierAdRecord = GetRecords(where)
        Return CarrierAdTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As CarrierAdRecord = GetRecords(join, where)
        Return CarrierAdTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As CarrierAdRecord = GetRecords(where, orderBy)
        Return CarrierAdTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As CarrierAdRecord = GetRecords(join, where, orderBy)
        Return CarrierAdTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As CarrierAdRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return CarrierAdTable.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As CarrierAdRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return CarrierAdTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        CarrierAdTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CarrierAdTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return CarrierAdTable.Instance.ExportRecordData(whereFilter)
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

        Return CarrierAdTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return CarrierAdTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return CarrierAdTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return CarrierAdTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return CarrierAdTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return CarrierAdTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return CarrierAdTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return CarrierAdTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = CarrierAdTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As CarrierAdRecord
        Return CType(CarrierAdTable.Instance.GetRecordData(id, bMutable), CarrierAdRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As CarrierAdRecord
        Return CType(CarrierAdTable.Instance.GetRecordData(id, bMutable), CarrierAdRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal CarrierIDValue As String, _
        ByVal AdTemplateValue As String, _
        ByVal AdNameValue As String, _
        ByVal TruckerTypeIDValue As String, _
        ByVal ShortDescriptionValue As String, _
        ByVal LongDescriptionValue As String, _
        ByVal RunOnValue As String, _
        ByVal ExpireOnValue As String, _
        ByVal LimitByAgeValue As String, _
        ByVal PositionsAvailValue As String, _
        ByVal MinAgeValue As String, _
        ByVal HideAdValue As String, _
        ByVal MapThumbnailValue As String, _
        ByVal PSPMaximumValue As String, _
        ByVal LimitByMajorAccidentsValue As String, _
        ByVal MajorByIDValue As String, _
        ByVal MajorCountIDValue As String, _
        ByVal MajorMilesIDValue As String, _
        ByVal MajorYearsIDValue As String, _
        ByVal LimitByMinorAccidentsValue As String, _
        ByVal MinorByIDValue As String, _
        ByVal MinorCountIDValue As String, _
        ByVal MinorMilesIDValue As String, _
        ByVal MinorYearsIDValue As String, _
        ByVal LimitByTicketsValue As String, _
        ByVal TicketsByIDValue As String, _
        ByVal TicketCountIDValue As String, _
        ByVal TicketMilesIDValue As String, _
        ByVal TicketYearsIDValue As String, _
        ByVal LimitBySeriousTicketsValue As String, _
        ByVal SeriousByIDValue As String, _
        ByVal SeriousCountIDValue As String, _
        ByVal SeriousMilesIDValue As String, _
        ByVal SeriousYearsIDValue As String, _
        ByVal LimitByFeloniesValue As String, _
        ByVal FeloniesByIDValue As String, _
        ByVal FelonyCountIDValue As String, _
        ByVal FelonyMilesIDValue As String, _
        ByVal FelonyYearsIDValue As String, _
        ByVal LimitByDrugConvictionsValue As String, _
        ByVal DrugConvictionsByIDValue As String, _
        ByVal DrugCountIDValue As String, _
        ByVal DrugConvictionMilesIDValue As String, _
        ByVal DrugYearsIDValue As String, _
        ByVal LimitByFailedTestValue As String, _
        ByVal FailedByIDValue As String, _
        ByVal FailedCountIDValue As String, _
        ByVal FailedMilesIDValue As String, _
        ByVal FailedYearsIDValue As String, _
        ByVal LimitByDUICommercialValue As String, _
        ByVal CommDUIByIDValue As String, _
        ByVal CommDUICountIDValue As String, _
        ByVal CommDUIMilesIDValue As String, _
        ByVal CommDUIYearsIDValue As String, _
        ByVal LimitByDUIPersonalValue As String, _
        ByVal PersonalDUIByIDValue As String, _
        ByVal PersonalDUICountIDValue As String, _
        ByVal PersonalDUIMilesIDValue As String, _
        ByVal PersonalDUIYearsIDValue As String, _
        ByVal PayTypeIDValue As String, _
        ByVal LineHaulPercValue As String, _
        ByVal LoadedPerMileValue As String, _
        ByVal EmptyPerMileValue As String, _
        ByVal HourlyRateValue As String, _
        ByVal AvgPayPerWeekValue As String, _
        ByVal PayGuarantyValue As String, _
        ByVal FuelReimbursedValue As String, _
        ByVal AllFuelValue As String, _
        ByVal FuelGuarantyValue As String, _
        ByVal PayNotesValue As String, _
        ByVal OtherRequirementsValue As String, _
        ByVal LinksToOtherPostingsValue As String, _
        ByVal NoAdValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(CarrierIDValue, CarrierIDColumn)
        rec.SetString(AdTemplateValue, AdTemplateColumn)
        rec.SetString(AdNameValue, AdNameColumn)
        rec.SetString(TruckerTypeIDValue, TruckerTypeIDColumn)
        rec.SetString(ShortDescriptionValue, ShortDescriptionColumn)
        rec.SetString(LongDescriptionValue, LongDescriptionColumn)
        rec.SetString(RunOnValue, RunOnColumn)
        rec.SetString(ExpireOnValue, ExpireOnColumn)
        rec.SetString(LimitByAgeValue, LimitByAgeColumn)
        rec.SetString(PositionsAvailValue, PositionsAvailColumn)
        rec.SetString(MinAgeValue, MinAgeColumn)
        rec.SetString(HideAdValue, HideAdColumn)
        rec.SetString(MapThumbnailValue, MapThumbnailColumn)
        rec.SetString(PSPMaximumValue, PSPMaximumColumn)
        rec.SetString(LimitByMajorAccidentsValue, LimitByMajorAccidentsColumn)
        rec.SetString(MajorByIDValue, MajorByIDColumn)
        rec.SetString(MajorCountIDValue, MajorCountIDColumn)
        rec.SetString(MajorMilesIDValue, MajorMilesIDColumn)
        rec.SetString(MajorYearsIDValue, MajorYearsIDColumn)
        rec.SetString(LimitByMinorAccidentsValue, LimitByMinorAccidentsColumn)
        rec.SetString(MinorByIDValue, MinorByIDColumn)
        rec.SetString(MinorCountIDValue, MinorCountIDColumn)
        rec.SetString(MinorMilesIDValue, MinorMilesIDColumn)
        rec.SetString(MinorYearsIDValue, MinorYearsIDColumn)
        rec.SetString(LimitByTicketsValue, LimitByTicketsColumn)
        rec.SetString(TicketsByIDValue, TicketsByIDColumn)
        rec.SetString(TicketCountIDValue, TicketCountIDColumn)
        rec.SetString(TicketMilesIDValue, TicketMilesIDColumn)
        rec.SetString(TicketYearsIDValue, TicketYearsIDColumn)
        rec.SetString(LimitBySeriousTicketsValue, LimitBySeriousTicketsColumn)
        rec.SetString(SeriousByIDValue, SeriousByIDColumn)
        rec.SetString(SeriousCountIDValue, SeriousCountIDColumn)
        rec.SetString(SeriousMilesIDValue, SeriousMilesIDColumn)
        rec.SetString(SeriousYearsIDValue, SeriousYearsIDColumn)
        rec.SetString(LimitByFeloniesValue, LimitByFeloniesColumn)
        rec.SetString(FeloniesByIDValue, FeloniesByIDColumn)
        rec.SetString(FelonyCountIDValue, FelonyCountIDColumn)
        rec.SetString(FelonyMilesIDValue, FelonyMilesIDColumn)
        rec.SetString(FelonyYearsIDValue, FelonyYearsIDColumn)
        rec.SetString(LimitByDrugConvictionsValue, LimitByDrugConvictionsColumn)
        rec.SetString(DrugConvictionsByIDValue, DrugConvictionsByIDColumn)
        rec.SetString(DrugCountIDValue, DrugCountIDColumn)
        rec.SetString(DrugConvictionMilesIDValue, DrugConvictionMilesIDColumn)
        rec.SetString(DrugYearsIDValue, DrugYearsIDColumn)
        rec.SetString(LimitByFailedTestValue, LimitByFailedTestColumn)
        rec.SetString(FailedByIDValue, FailedByIDColumn)
        rec.SetString(FailedCountIDValue, FailedCountIDColumn)
        rec.SetString(FailedMilesIDValue, FailedMilesIDColumn)
        rec.SetString(FailedYearsIDValue, FailedYearsIDColumn)
        rec.SetString(LimitByDUICommercialValue, LimitByDUICommercialColumn)
        rec.SetString(CommDUIByIDValue, CommDUIByIDColumn)
        rec.SetString(CommDUICountIDValue, CommDUICountIDColumn)
        rec.SetString(CommDUIMilesIDValue, CommDUIMilesIDColumn)
        rec.SetString(CommDUIYearsIDValue, CommDUIYearsIDColumn)
        rec.SetString(LimitByDUIPersonalValue, LimitByDUIPersonalColumn)
        rec.SetString(PersonalDUIByIDValue, PersonalDUIByIDColumn)
        rec.SetString(PersonalDUICountIDValue, PersonalDUICountIDColumn)
        rec.SetString(PersonalDUIMilesIDValue, PersonalDUIMilesIDColumn)
        rec.SetString(PersonalDUIYearsIDValue, PersonalDUIYearsIDColumn)
        rec.SetString(PayTypeIDValue, PayTypeIDColumn)
        rec.SetString(LineHaulPercValue, LineHaulPercColumn)
        rec.SetString(LoadedPerMileValue, LoadedPerMileColumn)
        rec.SetString(EmptyPerMileValue, EmptyPerMileColumn)
        rec.SetString(HourlyRateValue, HourlyRateColumn)
        rec.SetString(AvgPayPerWeekValue, AvgPayPerWeekColumn)
        rec.SetString(PayGuarantyValue, PayGuarantyColumn)
        rec.SetString(FuelReimbursedValue, FuelReimbursedColumn)
        rec.SetString(AllFuelValue, AllFuelColumn)
        rec.SetString(FuelGuarantyValue, FuelGuarantyColumn)
        rec.SetString(PayNotesValue, PayNotesColumn)
        rec.SetString(OtherRequirementsValue, OtherRequirementsColumn)
        rec.SetString(LinksToOtherPostingsValue, LinksToOtherPostingsColumn)
        rec.SetString(NoAdValue, NoAdColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        CarrierAdTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            CarrierAdTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(CarrierAdTable.Instance.TableDefinition.PrimaryKey)) Then
            Return CarrierAdTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(CarrierAdTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = CarrierAdTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = CarrierAdTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (CarrierAdTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = CarrierAdTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = CarrierAdTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = CarrierAdTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
