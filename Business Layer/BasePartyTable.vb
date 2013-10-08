' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="PartyTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named Party.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="PartyTable.Instance">PartyTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="PartyTable"></seealso>

<Serializable()> Public Class BasePartyTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = PartyDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.PartyTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.PartyRecord")
        Me.ApplicationName = "FASTPORT"
        Me.DataAdapter = New PartySqlTable()
        Directcast(Me.DataAdapter, PartySqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, PartySqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        PartyIDColumn.CodeName = "PartyID"
        PartyTypeIDColumn.CodeName = "PartyTypeID"
        LogoColumn.CodeName = "Logo"
        ProfilePictureColumn.CodeName = "ProfilePicture"
        NameColumn.CodeName = "Name"
        DBAColumn.CodeName = "DBA"
        TitleColumn.CodeName = "Title"
        HandleColumn.CodeName = "Handle"
        EmailColumn.CodeName = "Email"
        PasswordColumn.CodeName = "Password"
        ContactColumn.CodeName = "Contact"
        DirectDialColumn.CodeName = "DirectDial"
        MobileColumn.CodeName = "Mobile"
        FaxColumn.CodeName = "Fax"
        OtherPhoneColumn.CodeName = "OtherPhone"
        ShareWithFriendsColumn.CodeName = "ShareWithFriends"
        ShareWithDriversColumn.CodeName = "ShareWithDrivers"
        ShareWithCarrierColumn.CodeName = "ShareWithCarrier"
        ShareWithCloseByColumn.CodeName = "ShareWithCloseBy"
        ShareWithLikeMeColumn.CodeName = "ShareWithLikeMe"
        AllowInvitationsColumn.CodeName = "AllowInvitations"
        ThreadEmailColumn.CodeName = "ThreadEmail"
        ThreadMobileTextColumn.CodeName = "ThreadMobileText"
        ThreadFaxColumn.CodeName = "ThreadFax"
        ThreadInstantMessageColumn.CodeName = "ThreadInstantMessage"
        ThreadBoardOnlyColumn.CodeName = "ThreadBoardOnly"
        FullProfileColumn.CodeName = "FullProfile"
        SignatureFileColumn.CodeName = "SignatureFile"
        InitialsFileColumn.CodeName = "InitialsFile"
        EntityIDColumn.CodeName = "EntityID"
        SocialSecurityNumberColumn.CodeName = "SocialSecurityNumber"
        EINNumberColumn.CodeName = "EINNumber"
        SMTPPortColumn.CodeName = "SMTPPort"
        SMTPServerColumn.CodeName = "SMTPServer"
        SMTPPasswordColumn.CodeName = "SMTPPassword"
        EnableSSLYNColumn.CodeName = "EnableSSLYN"
        FaxCredentialsColumn.CodeName = "FaxCredentials"
        FaxAccountColumn.CodeName = "FaxAccount"
        FaxPasswordColumn.CodeName = "FaxPassword"
        FaxSMTPPortColumn.CodeName = "FaxSMTPPort"
        FaxSMTPServerColumn.CodeName = "FaxSMTPServer"
        FaxEnableSSLYNColumn.CodeName = "FaxEnableSSLYN"
        RegisteredUserSinceColumn.CodeName = "RegisteredUserSince"
        AccountFlowStepIDColumn.CodeName = "AccountFlowStepID"
        PayPalTokenColumn.CodeName = "PayPalToken"
        StripSearchColumn.CodeName = "StripSearch"
        StripSearchDBAColumn.CodeName = "StripSearchDBA"
        OutsideIDColumn.CodeName = "OutsideID"
        CreatedByIDColumn.CodeName = "CreatedByID"
        CreatedAtColumn.CodeName = "CreatedAt"
        UpdatedByIDColumn.CodeName = "UpdatedByID"
        UpdatedAtColumn.CodeName = "UpdatedAt"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.PartyID column object.
    ''' </summary>
    Public ReadOnly Property PartyIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.PartyID column object.
    ''' </summary>
    Public Shared ReadOnly Property PartyID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyTable.Instance.PartyIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.PartyTypeID column object.
    ''' </summary>
    Public ReadOnly Property PartyTypeIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.PartyTypeID column object.
    ''' </summary>
    Public Shared ReadOnly Property PartyTypeID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyTable.Instance.PartyTypeIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Logo column object.
    ''' </summary>
    Public ReadOnly Property LogoColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Logo column object.
    ''' </summary>
    Public Shared ReadOnly Property Logo() As BaseClasses.Data.ImageColumn
        Get
            Return PartyTable.Instance.LogoColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ProfilePicture column object.
    ''' </summary>
    Public ReadOnly Property ProfilePictureColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ProfilePicture column object.
    ''' </summary>
    Public Shared ReadOnly Property ProfilePicture() As BaseClasses.Data.ImageColumn
        Get
            Return PartyTable.Instance.ProfilePictureColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Name column object.
    ''' </summary>
    Public ReadOnly Property NameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Name column object.
    ''' </summary>
    Public Shared ReadOnly Property Name() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.NameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.DBA column object.
    ''' </summary>
    Public ReadOnly Property DBAColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.DBA column object.
    ''' </summary>
    Public Shared ReadOnly Property DBA() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.DBAColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Title column object.
    ''' </summary>
    Public ReadOnly Property TitleColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Title column object.
    ''' </summary>
    Public Shared ReadOnly Property Title() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.TitleColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Handle column object.
    ''' </summary>
    Public ReadOnly Property HandleColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Handle column object.
    ''' </summary>
    Public Shared ReadOnly Property Handle() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.HandleColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Email column object.
    ''' </summary>
    Public ReadOnly Property EmailColumn() As BaseClasses.Data.EmailColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.EmailColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Email column object.
    ''' </summary>
    Public Shared ReadOnly Property Email() As BaseClasses.Data.EmailColumn
        Get
            Return PartyTable.Instance.EmailColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Password column object.
    ''' </summary>
    Public ReadOnly Property PasswordColumn() As BaseClasses.Data.PasswordColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.PasswordColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Password column object.
    ''' </summary>
    Public Shared ReadOnly Property Password() As BaseClasses.Data.PasswordColumn
        Get
            Return PartyTable.Instance.PasswordColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Contact column object.
    ''' </summary>
    Public ReadOnly Property ContactColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Contact column object.
    ''' </summary>
    Public Shared ReadOnly Property Contact() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.ContactColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.DirectDial column object.
    ''' </summary>
    Public ReadOnly Property DirectDialColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.DirectDial column object.
    ''' </summary>
    Public Shared ReadOnly Property DirectDial() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.DirectDialColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Mobile column object.
    ''' </summary>
    Public ReadOnly Property MobileColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Mobile column object.
    ''' </summary>
    Public Shared ReadOnly Property Mobile() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.MobileColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Fax column object.
    ''' </summary>
    Public ReadOnly Property FaxColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.Fax column object.
    ''' </summary>
    Public Shared ReadOnly Property Fax() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.FaxColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.OtherPhone column object.
    ''' </summary>
    Public ReadOnly Property OtherPhoneColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.OtherPhone column object.
    ''' </summary>
    Public Shared ReadOnly Property OtherPhone() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.OtherPhoneColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ShareWithFriends column object.
    ''' </summary>
    Public ReadOnly Property ShareWithFriendsColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ShareWithFriends column object.
    ''' </summary>
    Public Shared ReadOnly Property ShareWithFriends() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyTable.Instance.ShareWithFriendsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ShareWithDrivers column object.
    ''' </summary>
    Public ReadOnly Property ShareWithDriversColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ShareWithDrivers column object.
    ''' </summary>
    Public Shared ReadOnly Property ShareWithDrivers() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyTable.Instance.ShareWithDriversColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ShareWithCarrier column object.
    ''' </summary>
    Public ReadOnly Property ShareWithCarrierColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ShareWithCarrier column object.
    ''' </summary>
    Public Shared ReadOnly Property ShareWithCarrier() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyTable.Instance.ShareWithCarrierColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ShareWithCloseBy column object.
    ''' </summary>
    Public ReadOnly Property ShareWithCloseByColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ShareWithCloseBy column object.
    ''' </summary>
    Public Shared ReadOnly Property ShareWithCloseBy() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyTable.Instance.ShareWithCloseByColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ShareWithLikeMe column object.
    ''' </summary>
    Public ReadOnly Property ShareWithLikeMeColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ShareWithLikeMe column object.
    ''' </summary>
    Public Shared ReadOnly Property ShareWithLikeMe() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyTable.Instance.ShareWithLikeMeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.AllowInvitations column object.
    ''' </summary>
    Public ReadOnly Property AllowInvitationsColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.AllowInvitations column object.
    ''' </summary>
    Public Shared ReadOnly Property AllowInvitations() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyTable.Instance.AllowInvitationsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ThreadEmail column object.
    ''' </summary>
    Public ReadOnly Property ThreadEmailColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ThreadEmail column object.
    ''' </summary>
    Public Shared ReadOnly Property ThreadEmail() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyTable.Instance.ThreadEmailColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ThreadMobileText column object.
    ''' </summary>
    Public ReadOnly Property ThreadMobileTextColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ThreadMobileText column object.
    ''' </summary>
    Public Shared ReadOnly Property ThreadMobileText() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyTable.Instance.ThreadMobileTextColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ThreadFax column object.
    ''' </summary>
    Public ReadOnly Property ThreadFaxColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ThreadFax column object.
    ''' </summary>
    Public Shared ReadOnly Property ThreadFax() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyTable.Instance.ThreadFaxColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ThreadInstantMessage column object.
    ''' </summary>
    Public ReadOnly Property ThreadInstantMessageColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ThreadInstantMessage column object.
    ''' </summary>
    Public Shared ReadOnly Property ThreadInstantMessage() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyTable.Instance.ThreadInstantMessageColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ThreadBoardOnly column object.
    ''' </summary>
    Public ReadOnly Property ThreadBoardOnlyColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ThreadBoardOnly column object.
    ''' </summary>
    Public Shared ReadOnly Property ThreadBoardOnly() As BaseClasses.Data.BooleanColumn
        Get
            Return PartyTable.Instance.ThreadBoardOnlyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.FullProfile column object.
    ''' </summary>
    Public ReadOnly Property FullProfileColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.FullProfile column object.
    ''' </summary>
    Public Shared ReadOnly Property FullProfile() As BaseClasses.Data.ClobColumn
        Get
            Return PartyTable.Instance.FullProfileColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.SignatureFile column object.
    ''' </summary>
    Public ReadOnly Property SignatureFileColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.SignatureFile column object.
    ''' </summary>
    Public Shared ReadOnly Property SignatureFile() As BaseClasses.Data.ImageColumn
        Get
            Return PartyTable.Instance.SignatureFileColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.InitialsFile column object.
    ''' </summary>
    Public ReadOnly Property InitialsFileColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.InitialsFile column object.
    ''' </summary>
    Public Shared ReadOnly Property InitialsFile() As BaseClasses.Data.ImageColumn
        Get
            Return PartyTable.Instance.InitialsFileColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.EntityID column object.
    ''' </summary>
    Public ReadOnly Property EntityIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.EntityID column object.
    ''' </summary>
    Public Shared ReadOnly Property EntityID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyTable.Instance.EntityIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.SocialSecurityNumber column object.
    ''' </summary>
    Public ReadOnly Property SocialSecurityNumberColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.SocialSecurityNumber column object.
    ''' </summary>
    Public Shared ReadOnly Property SocialSecurityNumber() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.SocialSecurityNumberColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.EINNumber column object.
    ''' </summary>
    Public ReadOnly Property EINNumberColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.EINNumber column object.
    ''' </summary>
    Public Shared ReadOnly Property EINNumber() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.EINNumberColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.SMTPPort column object.
    ''' </summary>
    Public ReadOnly Property SMTPPortColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(32), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.SMTPPort column object.
    ''' </summary>
    Public Shared ReadOnly Property SMTPPort() As BaseClasses.Data.NumberColumn
        Get
            Return PartyTable.Instance.SMTPPortColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.SMTPServer column object.
    ''' </summary>
    Public ReadOnly Property SMTPServerColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(33), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.SMTPServer column object.
    ''' </summary>
    Public Shared ReadOnly Property SMTPServer() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.SMTPServerColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.SMTPPassword column object.
    ''' </summary>
    Public ReadOnly Property SMTPPasswordColumn() As BaseClasses.Data.PasswordColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(34), BaseClasses.Data.PasswordColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.SMTPPassword column object.
    ''' </summary>
    Public Shared ReadOnly Property SMTPPassword() As BaseClasses.Data.PasswordColumn
        Get
            Return PartyTable.Instance.SMTPPasswordColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.EnableSSLYN column object.
    ''' </summary>
    Public ReadOnly Property EnableSSLYNColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(35), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.EnableSSLYN column object.
    ''' </summary>
    Public Shared ReadOnly Property EnableSSLYN() As BaseClasses.Data.NumberColumn
        Get
            Return PartyTable.Instance.EnableSSLYNColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.FaxCredentials column object.
    ''' </summary>
    Public ReadOnly Property FaxCredentialsColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(36), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.FaxCredentials column object.
    ''' </summary>
    Public Shared ReadOnly Property FaxCredentials() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.FaxCredentialsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.FaxAccount column object.
    ''' </summary>
    Public ReadOnly Property FaxAccountColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(37), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.FaxAccount column object.
    ''' </summary>
    Public Shared ReadOnly Property FaxAccount() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.FaxAccountColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.FaxPassword column object.
    ''' </summary>
    Public ReadOnly Property FaxPasswordColumn() As BaseClasses.Data.PasswordColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(38), BaseClasses.Data.PasswordColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.FaxPassword column object.
    ''' </summary>
    Public Shared ReadOnly Property FaxPassword() As BaseClasses.Data.PasswordColumn
        Get
            Return PartyTable.Instance.FaxPasswordColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.FaxSMTPPort column object.
    ''' </summary>
    Public ReadOnly Property FaxSMTPPortColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(39), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.FaxSMTPPort column object.
    ''' </summary>
    Public Shared ReadOnly Property FaxSMTPPort() As BaseClasses.Data.NumberColumn
        Get
            Return PartyTable.Instance.FaxSMTPPortColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.FaxSMTPServer column object.
    ''' </summary>
    Public ReadOnly Property FaxSMTPServerColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(40), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.FaxSMTPServer column object.
    ''' </summary>
    Public Shared ReadOnly Property FaxSMTPServer() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.FaxSMTPServerColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.FaxEnableSSLYN column object.
    ''' </summary>
    Public ReadOnly Property FaxEnableSSLYNColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(41), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.FaxEnableSSLYN column object.
    ''' </summary>
    Public Shared ReadOnly Property FaxEnableSSLYN() As BaseClasses.Data.NumberColumn
        Get
            Return PartyTable.Instance.FaxEnableSSLYNColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.RegisteredUserSince column object.
    ''' </summary>
    Public ReadOnly Property RegisteredUserSinceColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(42), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.RegisteredUserSince column object.
    ''' </summary>
    Public Shared ReadOnly Property RegisteredUserSince() As BaseClasses.Data.DateColumn
        Get
            Return PartyTable.Instance.RegisteredUserSinceColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.AccountFlowStepID column object.
    ''' </summary>
    Public ReadOnly Property AccountFlowStepIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(43), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.AccountFlowStepID column object.
    ''' </summary>
    Public Shared ReadOnly Property AccountFlowStepID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyTable.Instance.AccountFlowStepIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.PayPalToken column object.
    ''' </summary>
    Public ReadOnly Property PayPalTokenColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(44), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.PayPalToken column object.
    ''' </summary>
    Public Shared ReadOnly Property PayPalToken() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.PayPalTokenColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.StripSearch column object.
    ''' </summary>
    Public ReadOnly Property StripSearchColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(45), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.StripSearch column object.
    ''' </summary>
    Public Shared ReadOnly Property StripSearch() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.StripSearchColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.StripSearchDBA column object.
    ''' </summary>
    Public ReadOnly Property StripSearchDBAColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(46), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.StripSearchDBA column object.
    ''' </summary>
    Public Shared ReadOnly Property StripSearchDBA() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.StripSearchDBAColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.OutsideID column object.
    ''' </summary>
    Public ReadOnly Property OutsideIDColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(47), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.OutsideID column object.
    ''' </summary>
    Public Shared ReadOnly Property OutsideID() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.OutsideIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.CreatedByID column object.
    ''' </summary>
    Public ReadOnly Property CreatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(48), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.CreatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyTable.Instance.CreatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.CreatedAt column object.
    ''' </summary>
    Public ReadOnly Property CreatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(49), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.CreatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property CreatedAt() As BaseClasses.Data.DateColumn
        Get
            Return PartyTable.Instance.CreatedAtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.UpdatedByID column object.
    ''' </summary>
    Public ReadOnly Property UpdatedByIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(50), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.UpdatedByID column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedByID() As BaseClasses.Data.NumberColumn
        Get
            Return PartyTable.Instance.UpdatedByIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.UpdatedAt column object.
    ''' </summary>
    Public ReadOnly Property UpdatedAtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(51), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.UpdatedAt column object.
    ''' </summary>
    Public Shared ReadOnly Property UpdatedAt() As BaseClasses.Data.DateColumn
        Get
            Return PartyTable.Instance.UpdatedAtColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As PartyRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As PartyRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  PartyTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyRecord)), PartyRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  PartyTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyRecord)), PartyRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = PartyTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyRecord)), PartyRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyRecord()

        Dim recList As ArrayList = PartyTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyRecord)), PartyRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As PartyRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = PartyTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyRecord)), PartyRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As PartyRecord()

        Dim recList As ArrayList = PartyTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.PartyRecord)), PartyRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(PartyTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(PartyTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(PartyTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(PartyTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As PartyRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As PartyRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = PartyTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As PartyRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), PartyRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = PartyTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As PartyRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), PartyRecord)
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

        Return PartyTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return PartyTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As PartyRecord = GetRecords(where)
        Return PartyTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As PartyRecord = GetRecords(join, where)
        Return PartyTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As PartyRecord = GetRecords(where, orderBy)
        Return PartyTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As PartyRecord = GetRecords(join, where, orderBy)
        Return PartyTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As PartyRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return PartyTable.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As PartyRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return PartyTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        PartyTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return PartyTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return PartyTable.Instance.ExportRecordData(whereFilter)
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

        Return PartyTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return PartyTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return PartyTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return PartyTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return PartyTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return PartyTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return PartyTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return PartyTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = PartyTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As PartyRecord
        Return CType(PartyTable.Instance.GetRecordData(id, bMutable), PartyRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As PartyRecord
        Return CType(PartyTable.Instance.GetRecordData(id, bMutable), PartyRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal PartyTypeIDValue As String, _
        ByVal LogoValue As String, _
        ByVal ProfilePictureValue As String, _
        ByVal NameValue As String, _
        ByVal DBAValue As String, _
        ByVal TitleValue As String, _
        ByVal HandleValue As String, _
        ByVal EmailValue As String, _
        ByVal PasswordValue As String, _
        ByVal ContactValue As String, _
        ByVal DirectDialValue As String, _
        ByVal MobileValue As String, _
        ByVal FaxValue As String, _
        ByVal OtherPhoneValue As String, _
        ByVal ShareWithFriendsValue As String, _
        ByVal ShareWithDriversValue As String, _
        ByVal ShareWithCarrierValue As String, _
        ByVal ShareWithCloseByValue As String, _
        ByVal ShareWithLikeMeValue As String, _
        ByVal AllowInvitationsValue As String, _
        ByVal ThreadEmailValue As String, _
        ByVal ThreadMobileTextValue As String, _
        ByVal ThreadFaxValue As String, _
        ByVal ThreadInstantMessageValue As String, _
        ByVal ThreadBoardOnlyValue As String, _
        ByVal FullProfileValue As String, _
        ByVal SignatureFileValue As String, _
        ByVal InitialsFileValue As String, _
        ByVal EntityIDValue As String, _
        ByVal SocialSecurityNumberValue As String, _
        ByVal EINNumberValue As String, _
        ByVal SMTPPortValue As String, _
        ByVal SMTPServerValue As String, _
        ByVal SMTPPasswordValue As String, _
        ByVal EnableSSLYNValue As String, _
        ByVal FaxCredentialsValue As String, _
        ByVal FaxAccountValue As String, _
        ByVal FaxPasswordValue As String, _
        ByVal FaxSMTPPortValue As String, _
        ByVal FaxSMTPServerValue As String, _
        ByVal FaxEnableSSLYNValue As String, _
        ByVal RegisteredUserSinceValue As String, _
        ByVal AccountFlowStepIDValue As String, _
        ByVal PayPalTokenValue As String, _
        ByVal StripSearchValue As String, _
        ByVal StripSearchDBAValue As String, _
        ByVal OutsideIDValue As String, _
        ByVal CreatedByIDValue As String, _
        ByVal CreatedAtValue As String, _
        ByVal UpdatedByIDValue As String, _
        ByVal UpdatedAtValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(PartyTypeIDValue, PartyTypeIDColumn)
        rec.SetString(LogoValue, LogoColumn)
        rec.SetString(ProfilePictureValue, ProfilePictureColumn)
        rec.SetString(NameValue, NameColumn)
        rec.SetString(DBAValue, DBAColumn)
        rec.SetString(TitleValue, TitleColumn)
        rec.SetString(HandleValue, HandleColumn)
        rec.SetString(EmailValue, EmailColumn)
        rec.SetString(PasswordValue, PasswordColumn)
        rec.SetString(ContactValue, ContactColumn)
        rec.SetString(DirectDialValue, DirectDialColumn)
        rec.SetString(MobileValue, MobileColumn)
        rec.SetString(FaxValue, FaxColumn)
        rec.SetString(OtherPhoneValue, OtherPhoneColumn)
        rec.SetString(ShareWithFriendsValue, ShareWithFriendsColumn)
        rec.SetString(ShareWithDriversValue, ShareWithDriversColumn)
        rec.SetString(ShareWithCarrierValue, ShareWithCarrierColumn)
        rec.SetString(ShareWithCloseByValue, ShareWithCloseByColumn)
        rec.SetString(ShareWithLikeMeValue, ShareWithLikeMeColumn)
        rec.SetString(AllowInvitationsValue, AllowInvitationsColumn)
        rec.SetString(ThreadEmailValue, ThreadEmailColumn)
        rec.SetString(ThreadMobileTextValue, ThreadMobileTextColumn)
        rec.SetString(ThreadFaxValue, ThreadFaxColumn)
        rec.SetString(ThreadInstantMessageValue, ThreadInstantMessageColumn)
        rec.SetString(ThreadBoardOnlyValue, ThreadBoardOnlyColumn)
        rec.SetString(FullProfileValue, FullProfileColumn)
        rec.SetString(SignatureFileValue, SignatureFileColumn)
        rec.SetString(InitialsFileValue, InitialsFileColumn)
        rec.SetString(EntityIDValue, EntityIDColumn)
        rec.SetString(SocialSecurityNumberValue, SocialSecurityNumberColumn)
        rec.SetString(EINNumberValue, EINNumberColumn)
        rec.SetString(SMTPPortValue, SMTPPortColumn)
        rec.SetString(SMTPServerValue, SMTPServerColumn)
        rec.SetString(SMTPPasswordValue, SMTPPasswordColumn)
        rec.SetString(EnableSSLYNValue, EnableSSLYNColumn)
        rec.SetString(FaxCredentialsValue, FaxCredentialsColumn)
        rec.SetString(FaxAccountValue, FaxAccountColumn)
        rec.SetString(FaxPasswordValue, FaxPasswordColumn)
        rec.SetString(FaxSMTPPortValue, FaxSMTPPortColumn)
        rec.SetString(FaxSMTPServerValue, FaxSMTPServerColumn)
        rec.SetString(FaxEnableSSLYNValue, FaxEnableSSLYNColumn)
        rec.SetString(RegisteredUserSinceValue, RegisteredUserSinceColumn)
        rec.SetString(AccountFlowStepIDValue, AccountFlowStepIDColumn)
        rec.SetString(PayPalTokenValue, PayPalTokenColumn)
        rec.SetString(StripSearchValue, StripSearchColumn)
        rec.SetString(StripSearchDBAValue, StripSearchDBAColumn)
        rec.SetString(OutsideIDValue, OutsideIDColumn)
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
        PartyTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            PartyTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(PartyTable.Instance.TableDefinition.PrimaryKey)) Then
            Return PartyTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(PartyTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = PartyTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = PartyTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (PartyTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = PartyTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = PartyTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = PartyTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
