' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyDriverRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PartyDriverTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named PartyDriver.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="PartyDriverTable.Instance">PartyDriverTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="PartyDriverTable"></seealso>

<Serializable()> Public Class BasePartyDriverTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = PartyDriverDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.PartyDriverTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.PartyDriverRecord")
        Me.ApplicationName = "FASTPORT"
        Me.DataAdapter = New PartyDriverSqlTable()
        Directcast(Me.DataAdapter, PartyDriverSqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, PartyDriverSqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        DriverIDColumn.CodeName = "DriverID"
        PartyIDColumn.CodeName = "PartyID"
        TruckerTypeIDColumn.CodeName = "TruckerTypeID"
        DateOfBirthColumn.CodeName = "DateOfBirth"
        SocialSecurityNumberColumn.CodeName = "SocialSecurityNumber"
        USCitizenColumn.CodeName = "USCitizen"
        AuthorizedAlienColumn.CodeName = "AuthorizedAlien"
        AuthorizationTypeIDColumn.CodeName = "AuthorizationTypeID"
        VisaNumberColumn.CodeName = "VisaNumber"
        CertifiedBrakeInspectorColumn.CodeName = "CertifiedBrakeInspector"
        MoreThanOneLicenseColumn.CodeName = "MoreThanOneLicense"
        PromiseToNotifyIn24HoursColumn.CodeName = "PromiseToNotifyIn24Hours"
        PromiseNeverSuspendedColumn.CodeName = "PromiseNeverSuspended"
        DrugTestedWithLastCarrierColumn.CodeName = "DrugTestedWithLastCarrier"
        PromisedNeverPostiveOnDrugTestColumn.CodeName = "PromisedNeverPostiveOnDrugTest"
        ReturnedToDutyColumn.CodeName = "ReturnedToDuty"
        ContactInfoCompleteColumn.CodeName = "ContactInfoComplete"
        PersonalInfoCompleteColumn.CodeName = "PersonalInfoComplete"
        RepresentationsCompleteColumn.CodeName = "RepresentationsComplete"
        EstAccidentsIDColumn.CodeName = "EstAccidentsID"
        EstTicketsIDColumn.CodeName = "EstTicketsID"
        EstFailedTestsIDColumn.CodeName = "EstFailedTestsID"
        EstFeloniesIDColumn.CodeName = "EstFeloniesID"
        ProgBasicColumn.CodeName = "ProgBasic"
        ProgHistoryColumn.CodeName = "ProgHistory"
        ProgExperienceColumn.CodeName = "ProgExperience"
        ProgIncidentsColumn.CodeName = "ProgIncidents"
        ProgDocColumn.CodeName = "ProgDoc"
        ProgeeEquipColumn.CodeName = "ProgeeEquip"
        GaugeIDColumn.CodeName = "GaugeID"
        CreatedByIDColumn.CodeName = "CreatedByID"
        CreatedAtColumn.CodeName = "CreatedAt"
        UpdatedByIDColumn.CodeName = "UpdatedByID"
        UpdatedAtColumn.CodeName = "UpdatedAt"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.DriverID column object.
    ''' </summary>
    Public ReadOnly Property DriverIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.DriverID column object.
    ''' </summary>
    Public Shared ReadOnly Property DriverID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.DriverIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.PartyID column object.
    ''' </summary>
    Public ReadOnly Property PartyIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.PartyID column object.
    ''' </summary>
    Public Shared ReadOnly Property PartyID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.PartyIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.TruckerTypeID column object.
    ''' </summary>
    Public ReadOnly Property TruckerTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.TruckerTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property TruckerTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.TruckerTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.DateOfBirth column object.
    ''' </summary>
    Public ReadOnly Property DateOfBirthColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.DateOfBirth column object.
    ''' </summary>
    Public Shared ReadOnly Property DateOfBirth() As BaseClasses.Data.DateColumn
        Get
            Return PartyDriverTable.Instance.DateOfBirthColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.SocialSecurityNumber column object.
    ''' </summary>
    Public ReadOnly Property SocialSecurityNumberColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.SocialSecurityNumber column object.
    ''' </summary>
    Public Shared ReadOnly Property SocialSecurityNumber() As BaseClasses.Data.StringColumn
        Get
            Return PartyDriverTable.Instance.SocialSecurityNumberColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.USCitizen column object.
    ''' </summary>
    Public ReadOnly Property USCitizenColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.USCitizen column object.
    ''' </summary>
    Public Shared ReadOnly Property USCitizen() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyDriverTable.Instance.USCitizenColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.AuthorizedAlien column object.
    ''' </summary>
    Public ReadOnly Property AuthorizedAlienColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.AuthorizedAlien column object.
    ''' </summary>
    Public Shared ReadOnly Property AuthorizedAlien() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyDriverTable.Instance.AuthorizedAlienColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.AuthorizationTypeID column object.
    ''' </summary>
    Public ReadOnly Property AuthorizationTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.AuthorizationTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property AuthorizationTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.AuthorizationTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.VisaNumber column object.
    ''' </summary>
    Public ReadOnly Property VisaNumberColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.VisaNumber column object.
    ''' </summary>
    Public Shared ReadOnly Property VisaNumber() As BaseClasses.Data.StringColumn
        Get
            Return PartyDriverTable.Instance.VisaNumberColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.CertifiedBrakeInspector column object.
    ''' </summary>
    Public ReadOnly Property CertifiedBrakeInspectorColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.CertifiedBrakeInspector column object.
    ''' </summary>
    Public Shared ReadOnly Property CertifiedBrakeInspector() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyDriverTable.Instance.CertifiedBrakeInspectorColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.MoreThanOneLicense column object.
    ''' </summary>
    Public ReadOnly Property MoreThanOneLicenseColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.MoreThanOneLicense column object.
    ''' </summary>
    Public Shared ReadOnly Property MoreThanOneLicense() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyDriverTable.Instance.MoreThanOneLicenseColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.PromiseToNotifyIn24Hours column object.
    ''' </summary>
    Public ReadOnly Property PromiseToNotifyIn24HoursColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.PromiseToNotifyIn24Hours column object.
    ''' </summary>
    Public Shared ReadOnly Property PromiseToNotifyIn24Hours() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyDriverTable.Instance.PromiseToNotifyIn24HoursColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.PromiseNeverSuspended column object.
    ''' </summary>
    Public ReadOnly Property PromiseNeverSuspendedColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.PromiseNeverSuspended column object.
    ''' </summary>
    Public Shared ReadOnly Property PromiseNeverSuspended() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyDriverTable.Instance.PromiseNeverSuspendedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.DrugTestedWithLastCarrier column object.
    ''' </summary>
    Public ReadOnly Property DrugTestedWithLastCarrierColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.DrugTestedWithLastCarrier column object.
    ''' </summary>
    Public Shared ReadOnly Property DrugTestedWithLastCarrier() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyDriverTable.Instance.DrugTestedWithLastCarrierColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.PromisedNeverPostiveOnDrugTest column object.
    ''' </summary>
    Public ReadOnly Property PromisedNeverPostiveOnDrugTestColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.PromisedNeverPostiveOnDrugTest column object.
    ''' </summary>
    Public Shared ReadOnly Property PromisedNeverPostiveOnDrugTest() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyDriverTable.Instance.PromisedNeverPostiveOnDrugTestColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ReturnedToDuty column object.
    ''' </summary>
    Public ReadOnly Property ReturnedToDutyColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ReturnedToDuty column object.
    ''' </summary>
    Public Shared ReadOnly Property ReturnedToDuty() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyDriverTable.Instance.ReturnedToDutyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ContactInfoComplete column object.
    ''' </summary>
    Public ReadOnly Property ContactInfoCompleteColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ContactInfoComplete column object.
    ''' </summary>
    Public Shared ReadOnly Property ContactInfoComplete() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyDriverTable.Instance.ContactInfoCompleteColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.PersonalInfoComplete column object.
    ''' </summary>
    Public ReadOnly Property PersonalInfoCompleteColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.PersonalInfoComplete column object.
    ''' </summary>
    Public Shared ReadOnly Property PersonalInfoComplete() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyDriverTable.Instance.PersonalInfoCompleteColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.RepresentationsComplete column object.
    ''' </summary>
    Public ReadOnly Property RepresentationsCompleteColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.RepresentationsComplete column object.
    ''' </summary>
    Public Shared ReadOnly Property RepresentationsComplete() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyDriverTable.Instance.RepresentationsCompleteColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.EstAccidentsID column object.
    ''' </summary>
    Public ReadOnly Property EstAccidentsIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.EstAccidentsID column object.
    ''' </summary>
    Public Shared ReadOnly Property EstAccidentsID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.EstAccidentsIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.EstTicketsID column object.
    ''' </summary>
    Public ReadOnly Property EstTicketsIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.EstTicketsID column object.
    ''' </summary>
    Public Shared ReadOnly Property EstTicketsID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.EstTicketsIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.EstFailedTestsID column object.
    ''' </summary>
    Public ReadOnly Property EstFailedTestsIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.EstFailedTestsID column object.
    ''' </summary>
    Public Shared ReadOnly Property EstFailedTestsID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.EstFailedTestsIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.EstFeloniesID column object.
    ''' </summary>
    Public ReadOnly Property EstFeloniesIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.EstFeloniesID column object.
    ''' </summary>
    Public Shared ReadOnly Property EstFeloniesID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.EstFeloniesIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ProgBasic column object.
    ''' </summary>
    Public ReadOnly Property ProgBasicColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ProgBasic column object.
    ''' </summary>
    Public Shared ReadOnly Property ProgBasic() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.ProgBasicColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ProgHistory column object.
    ''' </summary>
    Public ReadOnly Property ProgHistoryColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ProgHistory column object.
    ''' </summary>
    Public Shared ReadOnly Property ProgHistory() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.ProgHistoryColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ProgExperience column object.
    ''' </summary>
    Public ReadOnly Property ProgExperienceColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ProgExperience column object.
    ''' </summary>
    Public Shared ReadOnly Property ProgExperience() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.ProgExperienceColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ProgIncidents column object.
    ''' </summary>
    Public ReadOnly Property ProgIncidentsColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ProgIncidents column object.
    ''' </summary>
    Public Shared ReadOnly Property ProgIncidents() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.ProgIncidentsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ProgDoc column object.
    ''' </summary>
    Public ReadOnly Property ProgDocColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ProgDoc column object.
    ''' </summary>
    Public Shared ReadOnly Property ProgDoc() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.ProgDocColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ProgeeEquip column object.
    ''' </summary>
    Public ReadOnly Property ProgeeEquipColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.ProgeeEquip column object.
    ''' </summary>
    Public Shared ReadOnly Property ProgeeEquip() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.ProgeeEquipColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.GaugeID column object.
    ''' </summary>
    Public ReadOnly Property GaugeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.GaugeID column object.
    ''' </summary>
    Public Shared ReadOnly Property GaugeID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.GaugeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.CreatedByID column object.
    ''' </summary>
    Public ReadOnly Property CreatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.CreatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.CreatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.CreatedAt column object.
    ''' </summary>
    Public ReadOnly Property CreatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.CreatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedAt() As BaseClasses.Data.DateColumn
        Get
            Return PartyDriverTable.Instance.CreatedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.UpdatedByID column object.
    ''' </summary>
    Public ReadOnly Property UpdatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(32), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.UpdatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyDriverTable.Instance.UpdatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.UpdatedAt column object.
    ''' </summary>
    Public ReadOnly Property UpdatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(33), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's PartyDriver_.UpdatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedAt() As BaseClasses.Data.DateColumn
        Get
            Return PartyDriverTable.Instance.UpdatedAtColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyDriverRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As PartyDriverRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyDriverRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As PartyDriverRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyDriverRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyDriverRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyDriverRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyDriverRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyDriverRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyDriverRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  PartyDriverTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyDriverRecord)), PartyDriverRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyDriverRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyDriverRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  PartyDriverTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyDriverRecord)), PartyDriverRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyDriverRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = PartyDriverTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyDriverRecord)), PartyDriverRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyDriverRecord()

        Dim recList As ArrayList = PartyDriverTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyDriverRecord)), PartyDriverRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As PartyDriverRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = PartyDriverTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyDriverRecord)), PartyDriverRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As PartyDriverRecord()

        Dim recList As ArrayList = PartyDriverTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyDriverRecord)), PartyDriverRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(PartyDriverTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(PartyDriverTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(PartyDriverTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(PartyDriverTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyDriverRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As PartyDriverRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyDriverRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As PartyDriverRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyDriverRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyDriverRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = PartyDriverTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As PartyDriverRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), PartyDriverRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyDriverRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyDriverRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = PartyDriverTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As PartyDriverRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), PartyDriverRecord)
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

        Return PartyDriverTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return PartyDriverTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As PartyDriverRecord = GetRecords(where)
        Return PartyDriverTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As PartyDriverRecord = GetRecords(join, where)
        Return PartyDriverTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As PartyDriverRecord = GetRecords(where, orderBy)
        Return PartyDriverTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As PartyDriverRecord = GetRecords(join, where, orderBy)
        Return PartyDriverTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As PartyDriverRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return PartyDriverTable.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As PartyDriverRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return PartyDriverTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        PartyDriverTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return PartyDriverTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return PartyDriverTable.Instance.ExportRecordData(whereFilter)
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

        Return PartyDriverTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return PartyDriverTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return PartyDriverTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return PartyDriverTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return PartyDriverTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return PartyDriverTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return PartyDriverTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return PartyDriverTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = PartyDriverTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As PartyDriverRecord
        Return CType(PartyDriverTable.Instance.GetRecordData(id, bMutable), PartyDriverRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As PartyDriverRecord
        Return CType(PartyDriverTable.Instance.GetRecordData(id, bMutable), PartyDriverRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal PartyIDValue As String, _
        ByVal TruckerTypeIDValue As String, _
        ByVal DateOfBirthValue As String, _
        ByVal SocialSecurityNumberValue As String, _
        ByVal USCitizenValue As String, _
        ByVal AuthorizedAlienValue As String, _
        ByVal AuthorizationTypeIDValue As String, _
        ByVal VisaNumberValue As String, _
        ByVal CertifiedBrakeInspectorValue As String, _
        ByVal MoreThanOneLicenseValue As String, _
        ByVal PromiseToNotifyIn24HoursValue As String, _
        ByVal PromiseNeverSuspendedValue As String, _
        ByVal DrugTestedWithLastCarrierValue As String, _
        ByVal PromisedNeverPostiveOnDrugTestValue As String, _
        ByVal ReturnedToDutyValue As String, _
        ByVal ContactInfoCompleteValue As String, _
        ByVal PersonalInfoCompleteValue As String, _
        ByVal RepresentationsCompleteValue As String, _
        ByVal EstAccidentsIDValue As String, _
        ByVal EstTicketsIDValue As String, _
        ByVal EstFailedTestsIDValue As String, _
        ByVal EstFeloniesIDValue As String, _
        ByVal ProgBasicValue As String, _
        ByVal ProgHistoryValue As String, _
        ByVal ProgExperienceValue As String, _
        ByVal ProgIncidentsValue As String, _
        ByVal ProgDocValue As String, _
        ByVal ProgeeEquipValue As String, _
        ByVal GaugeIDValue As String, _
        ByVal CreatedByIDValue As String, _
        ByVal CreatedAtValue As String, _
        ByVal UpdatedByIDValue As String, _
        ByVal UpdatedAtValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(PartyIDValue, PartyIDColumn)
        rec.SetString(TruckerTypeIDValue, TruckerTypeIDColumn)
        rec.SetString(DateOfBirthValue, DateOfBirthColumn)
        rec.SetString(SocialSecurityNumberValue, SocialSecurityNumberColumn)
        rec.SetString(USCitizenValue, USCitizenColumn)
        rec.SetString(AuthorizedAlienValue, AuthorizedAlienColumn)
        rec.SetString(AuthorizationTypeIDValue, AuthorizationTypeIDColumn)
        rec.SetString(VisaNumberValue, VisaNumberColumn)
        rec.SetString(CertifiedBrakeInspectorValue, CertifiedBrakeInspectorColumn)
        rec.SetString(MoreThanOneLicenseValue, MoreThanOneLicenseColumn)
        rec.SetString(PromiseToNotifyIn24HoursValue, PromiseToNotifyIn24HoursColumn)
        rec.SetString(PromiseNeverSuspendedValue, PromiseNeverSuspendedColumn)
        rec.SetString(DrugTestedWithLastCarrierValue, DrugTestedWithLastCarrierColumn)
        rec.SetString(PromisedNeverPostiveOnDrugTestValue, PromisedNeverPostiveOnDrugTestColumn)
        rec.SetString(ReturnedToDutyValue, ReturnedToDutyColumn)
        rec.SetString(ContactInfoCompleteValue, ContactInfoCompleteColumn)
        rec.SetString(PersonalInfoCompleteValue, PersonalInfoCompleteColumn)
        rec.SetString(RepresentationsCompleteValue, RepresentationsCompleteColumn)
        rec.SetString(EstAccidentsIDValue, EstAccidentsIDColumn)
        rec.SetString(EstTicketsIDValue, EstTicketsIDColumn)
        rec.SetString(EstFailedTestsIDValue, EstFailedTestsIDColumn)
        rec.SetString(EstFeloniesIDValue, EstFeloniesIDColumn)
        rec.SetString(ProgBasicValue, ProgBasicColumn)
        rec.SetString(ProgHistoryValue, ProgHistoryColumn)
        rec.SetString(ProgExperienceValue, ProgExperienceColumn)
        rec.SetString(ProgIncidentsValue, ProgIncidentsColumn)
        rec.SetString(ProgDocValue, ProgDocColumn)
        rec.SetString(ProgeeEquipValue, ProgeeEquipColumn)
        rec.SetString(GaugeIDValue, GaugeIDColumn)
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
        PartyDriverTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            PartyDriverTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(PartyDriverTable.Instance.TableDefinition.PrimaryKey)) Then
            Return PartyDriverTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(PartyDriverTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = PartyDriverTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = PartyDriverTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (PartyDriverTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = PartyDriverTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = PartyDriverTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = PartyDriverTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
