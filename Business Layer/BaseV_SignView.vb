' This class is "generated" and will be overwritten.
' Your customizations should be made in V_SignRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_SignView"></see> class.
''' Provides access to the schema information and record data of a database table or view named v_Sign.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="V_SignView.Instance">V_SignView.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="V_SignView"></seealso>

<Serializable()> Public Class BaseV_SignView
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = V_SignDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.V_SignView")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.V_SignRecord")
        Me.ApplicationName = "FASTPORT"
        Me.DataAdapter = New V_SignSqlView()
        Directcast(Me.DataAdapter, V_SignSqlView).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, V_SignSqlView).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        ExecutionIDColumn.CodeName = "ExecutionID"
        SignedOnColumn.CodeName = "SignedOn"
        ExpiresOnColumn.CodeName = "ExpiresOn"
        BarCodeColumn.CodeName = "BarCode"
        C_LogoColumn.CodeName = "C_Logo"
        C_LogoSmallColumn.CodeName = "C_LogoSmall"
        C_NameColumn.CodeName = "C_Name"
        C_DBAColumn.CodeName = "C_DBA"
        C_DBAOrNameColumn.CodeName = "C_DBAOrName"
        C_AddrHTMLColumn.CodeName = "C_AddrHTML"
        C_AddrColumn.CodeName = "C_Addr"
        C_CitySTZipColumn.CodeName = "C_CitySTZip"
        C_CityColumn.CodeName = "C_City"
        C_STColumn.CodeName = "C_ST"
        C_ZipColumn.CodeName = "C_Zip"
        C_CountryColumn.CodeName = "C_Country"
        C_SignerColumn.CodeName = "C_Signer"
        C_SignerTitleColumn.CodeName = "C_SignerTitle"
        C_SignerContactInfoColumn.CodeName = "C_SignerContactInfo"
        C_PhoneColumn.CodeName = "C_Phone"
        C_MobileColumn.CodeName = "C_Mobile"
        C_OtherPhoneColumn.CodeName = "C_OtherPhone"
        C_FaxColumn.CodeName = "C_Fax"
        C_EmailColumn.CodeName = "C_Email"
        C_SignatureColumn.CodeName = "C_Signature"
        C_SignatureSmallColumn.CodeName = "C_SignatureSmall"
        C_InitialsColumn.CodeName = "C_Initials"
        C_DOTColumn.CodeName = "C_DOT"
        C_MCColumn.CodeName = "C_MC"
        C_EINColumn.CodeName = "C_EIN"
        C_EIN1Column.CodeName = "C_EIN1"
        C_EIN2Column.CodeName = "C_EIN2"
        C_EIN3Column.CodeName = "C_EIN3"
        C_EIN4Column.CodeName = "C_EIN4"
        C_EIN5Column.CodeName = "C_EIN5"
        C_EIN6Column.CodeName = "C_EIN6"
        C_EIN7Column.CodeName = "C_EIN7"
        C_EIN8Column.CodeName = "C_EIN8"
        C_EIN9Column.CodeName = "C_EIN9"
        D_ProfilePicColumn.CodeName = "D_ProfilePic"
        D_NameColumn.CodeName = "D_Name"
        D_ContactInfoColumn.CodeName = "D_ContactInfo"
        D_PhoneColumn.CodeName = "D_Phone"
        D_MobileColumn.CodeName = "D_Mobile"
        D_OtherPhoneColumn.CodeName = "D_OtherPhone"
        D_FaxColumn.CodeName = "D_Fax"
        D_EmailColumn.CodeName = "D_Email"
        D_SignatureColumn.CodeName = "D_Signature"
        D_SignatureSmallColumn.CodeName = "D_SignatureSmall"
        D_InitialsColumn.CodeName = "D_Initials"
        D_OverviewColumn.CodeName = "D_Overview"
        D_IncidentsColumn.CodeName = "D_Incidents"
        D_ExpGeneralColumn.CodeName = "D_ExpGeneral"
        D_ExpEquipmentColumn.CodeName = "D_ExpEquipment"
        D_ExpCargoColumn.CodeName = "D_ExpCargo"
        D_ExpRegionsColumn.CodeName = "D_ExpRegions"
        D_GaugeColumn.CodeName = "D_Gauge"
        D_AddrHTMLColumn.CodeName = "D_AddrHTML"
        D_AddrColumn.CodeName = "D_Addr"
        D_CitySTZipColumn.CodeName = "D_CitySTZip"
        D_CityColumn.CodeName = "D_City"
        D_STColumn.CodeName = "D_ST"
        D_ZipColumn.CodeName = "D_Zip"
        D_CountryColumn.CodeName = "D_Country"
        D_DOBColumn.CodeName = "D_DOB"
        D_CDLInfoColumn.CodeName = "D_CDLInfo"
        D_CDLShortColumn.CodeName = "D_CDLShort"
        D_CDLOnlyColumn.CodeName = "D_CDLOnly"
        D_CDLStateColumn.CodeName = "D_CDLState"
        D_USCitizenColumn.CodeName = "D_USCitizen"
        D_PersonalInfoColumn.CodeName = "D_PersonalInfo"
        D_SSNColumn.CodeName = "D_SSN"
        D_SSX4Column.CodeName = "D_SSX4"
        D_SS1Column.CodeName = "D_SS1"
        D_SS2Column.CodeName = "D_SS2"
        D_SS3Column.CodeName = "D_SS3"
        D_SS4Column.CodeName = "D_SS4"
        D_SS5Column.CodeName = "D_SS5"
        D_SS6Column.CodeName = "D_SS6"
        D_SS7Column.CodeName = "D_SS7"
        D_SS8Column.CodeName = "D_SS8"
        D_SS9Column.CodeName = "D_SS9"
        D_PRAColumn.CodeName = "D_PRA"
        D_PRANumberColumn.CodeName = "D_PRANumber"
        D_PassportColumn.CodeName = "D_Passport"
        D_PassportExpirationColumn.CodeName = "D_PassportExpiration"
        D_TerminalAssignedColumn.CodeName = "D_TerminalAssigned"
        D_I9OtherAlienColumn.CodeName = "D_I9OtherAlien"
        D_I9aColumn.CodeName = "D_I9a"
        D_I9bColumn.CodeName = "D_I9b"
        D_I9cColumn.CodeName = "D_I9c"
        FirstLabelColumn.CodeName = "FirstLabel"
        FirstValueColumn.CodeName = "FirstValue"
        SecondLabelColumn.CodeName = "SecondLabel"
        SecondValueColumn.CodeName = "SecondValue"
        ThirdLabelColumn.CodeName = "ThirdLabel"
        ThirdValueColumn.CodeName = "ThirdValue"
        FourthLabelColumn.CodeName = "FourthLabel"
        FourthValueColumn.CodeName = "FourthValue"
        FifthLabelColumn.CodeName = "FifthLabel"
        FifthValueColumn.CodeName = "FifthValue"
        SixthLabelColumn.CodeName = "SixthLabel"
        SixthValueColumn.CodeName = "SixthValue"
        SeventhLabelColumn.CodeName = "SeventhLabel"
        SeventhValueColumn.CodeName = "SeventhValue"
        EighthLabelColumn.CodeName = "EighthLabel"
        EighthValueColumn.CodeName = "EighthValue"
        NinthLabelColumn.CodeName = "NinthLabel"
        NinthValueColumn.CodeName = "NinthValue"
        TenthLabelColumn.CodeName = "TenthLabel"
        TenthValueColumn.CodeName = "TenthValue"
        EleventhLabelColumn.CodeName = "EleventhLabel"
        EleventhValueColumn.CodeName = "EleventhValue"
        TwelfthLabelColumn.CodeName = "TwelfthLabel"
        TwelfthValueColumn.CodeName = "TwelfthValue"
        ThirteenthLabelColumn.CodeName = "ThirteenthLabel"
        ThirteenthValueColumn.CodeName = "ThirteenthValue"
        FourteenthLabelColumn.CodeName = "FourteenthLabel"
        FourteenthValueColumn.CodeName = "FourteenthValue"
        FifteenthLabelColumn.CodeName = "FifteenthLabel"
        FifteenthValueColumn.CodeName = "FifteenthValue"
        Cust_Plus1Column.CodeName = "Cust_Plus1"
        Cust_Plus2Column.CodeName = "Cust_Plus2"
        Cust_Plus3Column.CodeName = "Cust_Plus3"
        Cust_Plus4Column.CodeName = "Cust_Plus4"
        Cust_Plus5Column.CodeName = "Cust_Plus5"
        Cust_Plus6Column.CodeName = "Cust_Plus6"
        Cust_HrsTtlColumn.CodeName = "Cust_HrsTtl"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.ExecutionID column object.
    ''' </summary>
    Public ReadOnly Property ExecutionIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.ExecutionID column object.
    ''' </summary>
    Public Shared ReadOnly Property ExecutionID() As BaseClasses.Data.NumberColumn
        Get
            Return V_SignView.Instance.ExecutionIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.SignedOn column object.
    ''' </summary>
    Public ReadOnly Property SignedOnColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.SignedOn column object.
    ''' </summary>
    Public Shared ReadOnly Property SignedOn() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.SignedOnColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.ExpiresOn column object.
    ''' </summary>
    Public ReadOnly Property ExpiresOnColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.ExpiresOn column object.
    ''' </summary>
    Public Shared ReadOnly Property ExpiresOn() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.ExpiresOnColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.BarCode column object.
    ''' </summary>
    Public ReadOnly Property BarCodeColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.BarCode column object.
    ''' </summary>
    Public Shared ReadOnly Property BarCode() As BaseClasses.Data.ImageColumn
        Get
            Return V_SignView.Instance.BarCodeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Logo column object.
    ''' </summary>
    Public ReadOnly Property C_LogoColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Logo column object.
    ''' </summary>
    Public Shared ReadOnly Property C_Logo() As BaseClasses.Data.ImageColumn
        Get
            Return V_SignView.Instance.C_LogoColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_LogoSmall column object.
    ''' </summary>
    Public ReadOnly Property C_LogoSmallColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_LogoSmall column object.
    ''' </summary>
    Public Shared ReadOnly Property C_LogoSmall() As BaseClasses.Data.ImageColumn
        Get
            Return V_SignView.Instance.C_LogoSmallColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Name column object.
    ''' </summary>
    Public ReadOnly Property C_NameColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Name column object.
    ''' </summary>
    Public Shared ReadOnly Property C_Name() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_NameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_DBA column object.
    ''' </summary>
    Public ReadOnly Property C_DBAColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_DBA column object.
    ''' </summary>
    Public Shared ReadOnly Property C_DBA() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_DBAColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_DBAOrName column object.
    ''' </summary>
    Public ReadOnly Property C_DBAOrNameColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_DBAOrName column object.
    ''' </summary>
    Public Shared ReadOnly Property C_DBAOrName() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_DBAOrNameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_AddrHTML column object.
    ''' </summary>
    Public ReadOnly Property C_AddrHTMLColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_AddrHTML column object.
    ''' </summary>
    Public Shared ReadOnly Property C_AddrHTML() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_AddrHTMLColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Addr column object.
    ''' </summary>
    Public ReadOnly Property C_AddrColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Addr column object.
    ''' </summary>
    Public Shared ReadOnly Property C_Addr() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_AddrColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_CitySTZip column object.
    ''' </summary>
    Public ReadOnly Property C_CitySTZipColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_CitySTZip column object.
    ''' </summary>
    Public Shared ReadOnly Property C_CitySTZip() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_CitySTZipColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_City column object.
    ''' </summary>
    Public ReadOnly Property C_CityColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_City column object.
    ''' </summary>
    Public Shared ReadOnly Property C_City() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_CityColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_ST column object.
    ''' </summary>
    Public ReadOnly Property C_STColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_ST column object.
    ''' </summary>
    Public Shared ReadOnly Property C_ST() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_STColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Zip column object.
    ''' </summary>
    Public ReadOnly Property C_ZipColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Zip column object.
    ''' </summary>
    Public Shared ReadOnly Property C_Zip() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_ZipColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Country column object.
    ''' </summary>
    Public ReadOnly Property C_CountryColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Country column object.
    ''' </summary>
    Public Shared ReadOnly Property C_Country() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_CountryColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Signer column object.
    ''' </summary>
    Public ReadOnly Property C_SignerColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Signer column object.
    ''' </summary>
    Public Shared ReadOnly Property C_Signer() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_SignerColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_SignerTitle column object.
    ''' </summary>
    Public ReadOnly Property C_SignerTitleColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_SignerTitle column object.
    ''' </summary>
    Public Shared ReadOnly Property C_SignerTitle() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_SignerTitleColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_SignerContactInfo column object.
    ''' </summary>
    Public ReadOnly Property C_SignerContactInfoColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_SignerContactInfo column object.
    ''' </summary>
    Public Shared ReadOnly Property C_SignerContactInfo() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_SignerContactInfoColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Phone column object.
    ''' </summary>
    Public ReadOnly Property C_PhoneColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Phone column object.
    ''' </summary>
    Public Shared ReadOnly Property C_Phone() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_PhoneColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Mobile column object.
    ''' </summary>
    Public ReadOnly Property C_MobileColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Mobile column object.
    ''' </summary>
    Public Shared ReadOnly Property C_Mobile() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_MobileColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_OtherPhone column object.
    ''' </summary>
    Public ReadOnly Property C_OtherPhoneColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_OtherPhone column object.
    ''' </summary>
    Public Shared ReadOnly Property C_OtherPhone() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_OtherPhoneColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Fax column object.
    ''' </summary>
    Public ReadOnly Property C_FaxColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Fax column object.
    ''' </summary>
    Public Shared ReadOnly Property C_Fax() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_FaxColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Email column object.
    ''' </summary>
    Public ReadOnly Property C_EmailColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Email column object.
    ''' </summary>
    Public Shared ReadOnly Property C_Email() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_EmailColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Signature column object.
    ''' </summary>
    Public ReadOnly Property C_SignatureColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Signature column object.
    ''' </summary>
    Public Shared ReadOnly Property C_Signature() As BaseClasses.Data.ImageColumn
        Get
            Return V_SignView.Instance.C_SignatureColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_SignatureSmall column object.
    ''' </summary>
    Public ReadOnly Property C_SignatureSmallColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_SignatureSmall column object.
    ''' </summary>
    Public Shared ReadOnly Property C_SignatureSmall() As BaseClasses.Data.ImageColumn
        Get
            Return V_SignView.Instance.C_SignatureSmallColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Initials column object.
    ''' </summary>
    Public ReadOnly Property C_InitialsColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_Initials column object.
    ''' </summary>
    Public Shared ReadOnly Property C_Initials() As BaseClasses.Data.ImageColumn
        Get
            Return V_SignView.Instance.C_InitialsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_DOT column object.
    ''' </summary>
    Public ReadOnly Property C_DOTColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_DOT column object.
    ''' </summary>
    Public Shared ReadOnly Property C_DOT() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_DOTColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_MC column object.
    ''' </summary>
    Public ReadOnly Property C_MCColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_MC column object.
    ''' </summary>
    Public Shared ReadOnly Property C_MC() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_MCColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN column object.
    ''' </summary>
    Public ReadOnly Property C_EINColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN column object.
    ''' </summary>
    Public Shared ReadOnly Property C_EIN() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_EINColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN1 column object.
    ''' </summary>
    Public ReadOnly Property C_EIN1Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN1 column object.
    ''' </summary>
    Public Shared ReadOnly Property C_EIN1() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_EIN1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN2 column object.
    ''' </summary>
    Public ReadOnly Property C_EIN2Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN2 column object.
    ''' </summary>
    Public Shared ReadOnly Property C_EIN2() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_EIN2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN3 column object.
    ''' </summary>
    Public ReadOnly Property C_EIN3Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(32), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN3 column object.
    ''' </summary>
    Public Shared ReadOnly Property C_EIN3() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_EIN3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN4 column object.
    ''' </summary>
    Public ReadOnly Property C_EIN4Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(33), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN4 column object.
    ''' </summary>
    Public Shared ReadOnly Property C_EIN4() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_EIN4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN5 column object.
    ''' </summary>
    Public ReadOnly Property C_EIN5Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(34), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN5 column object.
    ''' </summary>
    Public Shared ReadOnly Property C_EIN5() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_EIN5Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN6 column object.
    ''' </summary>
    Public ReadOnly Property C_EIN6Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(35), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN6 column object.
    ''' </summary>
    Public Shared ReadOnly Property C_EIN6() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_EIN6Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN7 column object.
    ''' </summary>
    Public ReadOnly Property C_EIN7Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(36), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN7 column object.
    ''' </summary>
    Public Shared ReadOnly Property C_EIN7() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_EIN7Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN8 column object.
    ''' </summary>
    Public ReadOnly Property C_EIN8Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(37), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN8 column object.
    ''' </summary>
    Public Shared ReadOnly Property C_EIN8() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_EIN8Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN9 column object.
    ''' </summary>
    Public ReadOnly Property C_EIN9Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(38), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.C_EIN9 column object.
    ''' </summary>
    Public Shared ReadOnly Property C_EIN9() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.C_EIN9Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_ProfilePic column object.
    ''' </summary>
    Public ReadOnly Property D_ProfilePicColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(39), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_ProfilePic column object.
    ''' </summary>
    Public Shared ReadOnly Property D_ProfilePic() As BaseClasses.Data.ImageColumn
        Get
            Return V_SignView.Instance.D_ProfilePicColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Name column object.
    ''' </summary>
    Public ReadOnly Property D_NameColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(40), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Name column object.
    ''' </summary>
    Public Shared ReadOnly Property D_Name() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_NameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_ContactInfo column object.
    ''' </summary>
    Public ReadOnly Property D_ContactInfoColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(41), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_ContactInfo column object.
    ''' </summary>
    Public Shared ReadOnly Property D_ContactInfo() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_ContactInfoColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Phone column object.
    ''' </summary>
    Public ReadOnly Property D_PhoneColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(42), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Phone column object.
    ''' </summary>
    Public Shared ReadOnly Property D_Phone() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_PhoneColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Mobile column object.
    ''' </summary>
    Public ReadOnly Property D_MobileColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(43), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Mobile column object.
    ''' </summary>
    Public Shared ReadOnly Property D_Mobile() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_MobileColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_OtherPhone column object.
    ''' </summary>
    Public ReadOnly Property D_OtherPhoneColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(44), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_OtherPhone column object.
    ''' </summary>
    Public Shared ReadOnly Property D_OtherPhone() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_OtherPhoneColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Fax column object.
    ''' </summary>
    Public ReadOnly Property D_FaxColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(45), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Fax column object.
    ''' </summary>
    Public Shared ReadOnly Property D_Fax() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_FaxColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Email column object.
    ''' </summary>
    Public ReadOnly Property D_EmailColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(46), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Email column object.
    ''' </summary>
    Public Shared ReadOnly Property D_Email() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_EmailColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Signature column object.
    ''' </summary>
    Public ReadOnly Property D_SignatureColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(47), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Signature column object.
    ''' </summary>
    Public Shared ReadOnly Property D_Signature() As BaseClasses.Data.ImageColumn
        Get
            Return V_SignView.Instance.D_SignatureColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SignatureSmall column object.
    ''' </summary>
    Public ReadOnly Property D_SignatureSmallColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(48), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SignatureSmall column object.
    ''' </summary>
    Public Shared ReadOnly Property D_SignatureSmall() As BaseClasses.Data.ImageColumn
        Get
            Return V_SignView.Instance.D_SignatureSmallColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Initials column object.
    ''' </summary>
    Public ReadOnly Property D_InitialsColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(49), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Initials column object.
    ''' </summary>
    Public Shared ReadOnly Property D_Initials() As BaseClasses.Data.ImageColumn
        Get
            Return V_SignView.Instance.D_InitialsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Overview column object.
    ''' </summary>
    Public ReadOnly Property D_OverviewColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(50), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Overview column object.
    ''' </summary>
    Public Shared ReadOnly Property D_Overview() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_OverviewColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Incidents column object.
    ''' </summary>
    Public ReadOnly Property D_IncidentsColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(51), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Incidents column object.
    ''' </summary>
    Public Shared ReadOnly Property D_Incidents() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_IncidentsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_ExpGeneral column object.
    ''' </summary>
    Public ReadOnly Property D_ExpGeneralColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(52), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_ExpGeneral column object.
    ''' </summary>
    Public Shared ReadOnly Property D_ExpGeneral() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_ExpGeneralColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_ExpEquipment column object.
    ''' </summary>
    Public ReadOnly Property D_ExpEquipmentColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(53), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_ExpEquipment column object.
    ''' </summary>
    Public Shared ReadOnly Property D_ExpEquipment() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_ExpEquipmentColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_ExpCargo column object.
    ''' </summary>
    Public ReadOnly Property D_ExpCargoColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(54), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_ExpCargo column object.
    ''' </summary>
    Public Shared ReadOnly Property D_ExpCargo() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_ExpCargoColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_ExpRegions column object.
    ''' </summary>
    Public ReadOnly Property D_ExpRegionsColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(55), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_ExpRegions column object.
    ''' </summary>
    Public Shared ReadOnly Property D_ExpRegions() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_ExpRegionsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Gauge column object.
    ''' </summary>
    Public ReadOnly Property D_GaugeColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(56), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Gauge column object.
    ''' </summary>
    Public Shared ReadOnly Property D_Gauge() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_GaugeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_AddrHTML column object.
    ''' </summary>
    Public ReadOnly Property D_AddrHTMLColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(57), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_AddrHTML column object.
    ''' </summary>
    Public Shared ReadOnly Property D_AddrHTML() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_AddrHTMLColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Addr column object.
    ''' </summary>
    Public ReadOnly Property D_AddrColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(58), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Addr column object.
    ''' </summary>
    Public Shared ReadOnly Property D_Addr() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_AddrColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_CitySTZip column object.
    ''' </summary>
    Public ReadOnly Property D_CitySTZipColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(59), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_CitySTZip column object.
    ''' </summary>
    Public Shared ReadOnly Property D_CitySTZip() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_CitySTZipColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_City column object.
    ''' </summary>
    Public ReadOnly Property D_CityColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(60), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_City column object.
    ''' </summary>
    Public Shared ReadOnly Property D_City() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_CityColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_ST column object.
    ''' </summary>
    Public ReadOnly Property D_STColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(61), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_ST column object.
    ''' </summary>
    Public Shared ReadOnly Property D_ST() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_STColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Zip column object.
    ''' </summary>
    Public ReadOnly Property D_ZipColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(62), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Zip column object.
    ''' </summary>
    Public Shared ReadOnly Property D_Zip() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_ZipColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Country column object.
    ''' </summary>
    Public ReadOnly Property D_CountryColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(63), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Country column object.
    ''' </summary>
    Public Shared ReadOnly Property D_Country() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_CountryColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_DOB column object.
    ''' </summary>
    Public ReadOnly Property D_DOBColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(64), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_DOB column object.
    ''' </summary>
    Public Shared ReadOnly Property D_DOB() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_DOBColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_CDLInfo column object.
    ''' </summary>
    Public ReadOnly Property D_CDLInfoColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(65), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_CDLInfo column object.
    ''' </summary>
    Public Shared ReadOnly Property D_CDLInfo() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_CDLInfoColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_CDLShort column object.
    ''' </summary>
    Public ReadOnly Property D_CDLShortColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(66), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_CDLShort column object.
    ''' </summary>
    Public Shared ReadOnly Property D_CDLShort() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_CDLShortColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_CDLOnly column object.
    ''' </summary>
    Public ReadOnly Property D_CDLOnlyColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(67), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_CDLOnly column object.
    ''' </summary>
    Public Shared ReadOnly Property D_CDLOnly() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_CDLOnlyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_CDLState column object.
    ''' </summary>
    Public ReadOnly Property D_CDLStateColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(68), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_CDLState column object.
    ''' </summary>
    Public Shared ReadOnly Property D_CDLState() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_CDLStateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_USCitizen column object.
    ''' </summary>
    Public ReadOnly Property D_USCitizenColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(69), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_USCitizen column object.
    ''' </summary>
    Public Shared ReadOnly Property D_USCitizen() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_USCitizenColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_PersonalInfo column object.
    ''' </summary>
    Public ReadOnly Property D_PersonalInfoColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(70), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_PersonalInfo column object.
    ''' </summary>
    Public Shared ReadOnly Property D_PersonalInfo() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_PersonalInfoColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SSN column object.
    ''' </summary>
    Public ReadOnly Property D_SSNColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(71), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SSN column object.
    ''' </summary>
    Public Shared ReadOnly Property D_SSN() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_SSNColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SSX4 column object.
    ''' </summary>
    Public ReadOnly Property D_SSX4Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(72), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SSX4 column object.
    ''' </summary>
    Public Shared ReadOnly Property D_SSX4() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_SSX4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS1 column object.
    ''' </summary>
    Public ReadOnly Property D_SS1Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(73), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS1 column object.
    ''' </summary>
    Public Shared ReadOnly Property D_SS1() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_SS1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS2 column object.
    ''' </summary>
    Public ReadOnly Property D_SS2Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(74), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS2 column object.
    ''' </summary>
    Public Shared ReadOnly Property D_SS2() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_SS2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS3 column object.
    ''' </summary>
    Public ReadOnly Property D_SS3Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(75), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS3 column object.
    ''' </summary>
    Public Shared ReadOnly Property D_SS3() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_SS3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS4 column object.
    ''' </summary>
    Public ReadOnly Property D_SS4Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(76), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS4 column object.
    ''' </summary>
    Public Shared ReadOnly Property D_SS4() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_SS4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS5 column object.
    ''' </summary>
    Public ReadOnly Property D_SS5Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(77), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS5 column object.
    ''' </summary>
    Public Shared ReadOnly Property D_SS5() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_SS5Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS6 column object.
    ''' </summary>
    Public ReadOnly Property D_SS6Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(78), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS6 column object.
    ''' </summary>
    Public Shared ReadOnly Property D_SS6() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_SS6Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS7 column object.
    ''' </summary>
    Public ReadOnly Property D_SS7Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(79), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS7 column object.
    ''' </summary>
    Public Shared ReadOnly Property D_SS7() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_SS7Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS8 column object.
    ''' </summary>
    Public ReadOnly Property D_SS8Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(80), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS8 column object.
    ''' </summary>
    Public Shared ReadOnly Property D_SS8() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_SS8Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS9 column object.
    ''' </summary>
    Public ReadOnly Property D_SS9Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(81), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_SS9 column object.
    ''' </summary>
    Public Shared ReadOnly Property D_SS9() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_SS9Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_PRA column object.
    ''' </summary>
    Public ReadOnly Property D_PRAColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(82), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_PRA column object.
    ''' </summary>
    Public Shared ReadOnly Property D_PRA() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_PRAColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_PRANumber column object.
    ''' </summary>
    Public ReadOnly Property D_PRANumberColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(83), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_PRANumber column object.
    ''' </summary>
    Public Shared ReadOnly Property D_PRANumber() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_PRANumberColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Passport column object.
    ''' </summary>
    Public ReadOnly Property D_PassportColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(84), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_Passport column object.
    ''' </summary>
    Public Shared ReadOnly Property D_Passport() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_PassportColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_PassportExpiration column object.
    ''' </summary>
    Public ReadOnly Property D_PassportExpirationColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(85), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_PassportExpiration column object.
    ''' </summary>
    Public Shared ReadOnly Property D_PassportExpiration() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_PassportExpirationColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_TerminalAssigned column object.
    ''' </summary>
    Public ReadOnly Property D_TerminalAssignedColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(86), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_TerminalAssigned column object.
    ''' </summary>
    Public Shared ReadOnly Property D_TerminalAssigned() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_TerminalAssignedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_I9OtherAlien column object.
    ''' </summary>
    Public ReadOnly Property D_I9OtherAlienColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(87), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_I9OtherAlien column object.
    ''' </summary>
    Public Shared ReadOnly Property D_I9OtherAlien() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.D_I9OtherAlienColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_I9a column object.
    ''' </summary>
    Public ReadOnly Property D_I9aColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(88), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_I9a column object.
    ''' </summary>
    Public Shared ReadOnly Property D_I9a() As BaseClasses.Data.StringColumn
        Get
            Return V_SignView.Instance.D_I9aColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_I9b column object.
    ''' </summary>
    Public ReadOnly Property D_I9bColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(89), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_I9b column object.
    ''' </summary>
    Public Shared ReadOnly Property D_I9b() As BaseClasses.Data.StringColumn
        Get
            Return V_SignView.Instance.D_I9bColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_I9c column object.
    ''' </summary>
    Public ReadOnly Property D_I9cColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(90), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.D_I9c column object.
    ''' </summary>
    Public Shared ReadOnly Property D_I9c() As BaseClasses.Data.StringColumn
        Get
            Return V_SignView.Instance.D_I9cColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FirstLabel column object.
    ''' </summary>
    Public ReadOnly Property FirstLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(91), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FirstLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.FirstLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FirstValue column object.
    ''' </summary>
    Public ReadOnly Property FirstValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(92), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FirstValue column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.FirstValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.SecondLabel column object.
    ''' </summary>
    Public ReadOnly Property SecondLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(93), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.SecondLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property SecondLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.SecondLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.SecondValue column object.
    ''' </summary>
    Public ReadOnly Property SecondValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(94), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.SecondValue column object.
    ''' </summary>
    Public Shared ReadOnly Property SecondValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.SecondValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.ThirdLabel column object.
    ''' </summary>
    Public ReadOnly Property ThirdLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(95), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.ThirdLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirdLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.ThirdLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.ThirdValue column object.
    ''' </summary>
    Public ReadOnly Property ThirdValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(96), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.ThirdValue column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirdValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.ThirdValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FourthLabel column object.
    ''' </summary>
    Public ReadOnly Property FourthLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(97), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FourthLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property FourthLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.FourthLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FourthValue column object.
    ''' </summary>
    Public ReadOnly Property FourthValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(98), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FourthValue column object.
    ''' </summary>
    Public Shared ReadOnly Property FourthValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.FourthValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FifthLabel column object.
    ''' </summary>
    Public ReadOnly Property FifthLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(99), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FifthLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property FifthLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.FifthLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FifthValue column object.
    ''' </summary>
    Public ReadOnly Property FifthValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(100), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FifthValue column object.
    ''' </summary>
    Public Shared ReadOnly Property FifthValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.FifthValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.SixthLabel column object.
    ''' </summary>
    Public ReadOnly Property SixthLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(101), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.SixthLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property SixthLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.SixthLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.SixthValue column object.
    ''' </summary>
    Public ReadOnly Property SixthValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(102), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.SixthValue column object.
    ''' </summary>
    Public Shared ReadOnly Property SixthValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.SixthValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.SeventhLabel column object.
    ''' </summary>
    Public ReadOnly Property SeventhLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(103), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.SeventhLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property SeventhLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.SeventhLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.SeventhValue column object.
    ''' </summary>
    Public ReadOnly Property SeventhValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(104), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.SeventhValue column object.
    ''' </summary>
    Public Shared ReadOnly Property SeventhValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.SeventhValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.EighthLabel column object.
    ''' </summary>
    Public ReadOnly Property EighthLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(105), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.EighthLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property EighthLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.EighthLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.EighthValue column object.
    ''' </summary>
    Public ReadOnly Property EighthValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(106), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.EighthValue column object.
    ''' </summary>
    Public Shared ReadOnly Property EighthValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.EighthValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.NinthLabel column object.
    ''' </summary>
    Public ReadOnly Property NinthLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(107), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.NinthLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property NinthLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.NinthLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.NinthValue column object.
    ''' </summary>
    Public ReadOnly Property NinthValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(108), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.NinthValue column object.
    ''' </summary>
    Public Shared ReadOnly Property NinthValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.NinthValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.TenthLabel column object.
    ''' </summary>
    Public ReadOnly Property TenthLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(109), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.TenthLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property TenthLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.TenthLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.TenthValue column object.
    ''' </summary>
    Public ReadOnly Property TenthValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(110), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.TenthValue column object.
    ''' </summary>
    Public Shared ReadOnly Property TenthValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.TenthValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.EleventhLabel column object.
    ''' </summary>
    Public ReadOnly Property EleventhLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(111), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.EleventhLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property EleventhLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.EleventhLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.EleventhValue column object.
    ''' </summary>
    Public ReadOnly Property EleventhValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(112), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.EleventhValue column object.
    ''' </summary>
    Public Shared ReadOnly Property EleventhValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.EleventhValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.TwelfthLabel column object.
    ''' </summary>
    Public ReadOnly Property TwelfthLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(113), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.TwelfthLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property TwelfthLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.TwelfthLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.TwelfthValue column object.
    ''' </summary>
    Public ReadOnly Property TwelfthValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(114), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.TwelfthValue column object.
    ''' </summary>
    Public Shared ReadOnly Property TwelfthValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.TwelfthValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.ThirteenthLabel column object.
    ''' </summary>
    Public ReadOnly Property ThirteenthLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(115), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.ThirteenthLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirteenthLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.ThirteenthLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.ThirteenthValue column object.
    ''' </summary>
    Public ReadOnly Property ThirteenthValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(116), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.ThirteenthValue column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirteenthValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.ThirteenthValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FourteenthLabel column object.
    ''' </summary>
    Public ReadOnly Property FourteenthLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(117), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FourteenthLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property FourteenthLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.FourteenthLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FourteenthValue column object.
    ''' </summary>
    Public ReadOnly Property FourteenthValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(118), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FourteenthValue column object.
    ''' </summary>
    Public Shared ReadOnly Property FourteenthValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.FourteenthValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FifteenthLabel column object.
    ''' </summary>
    Public ReadOnly Property FifteenthLabelColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(119), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FifteenthLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property FifteenthLabel() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.FifteenthLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FifteenthValue column object.
    ''' </summary>
    Public ReadOnly Property FifteenthValueColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(120), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.FifteenthValue column object.
    ''' </summary>
    Public Shared ReadOnly Property FifteenthValue() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.FifteenthValueColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.Cust_Plus1 column object.
    ''' </summary>
    Public ReadOnly Property Cust_Plus1Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(121), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.Cust_Plus1 column object.
    ''' </summary>
    Public Shared ReadOnly Property Cust_Plus1() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.Cust_Plus1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.Cust_Plus2 column object.
    ''' </summary>
    Public ReadOnly Property Cust_Plus2Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(122), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.Cust_Plus2 column object.
    ''' </summary>
    Public Shared ReadOnly Property Cust_Plus2() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.Cust_Plus2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.Cust_Plus3 column object.
    ''' </summary>
    Public ReadOnly Property Cust_Plus3Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(123), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.Cust_Plus3 column object.
    ''' </summary>
    Public Shared ReadOnly Property Cust_Plus3() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.Cust_Plus3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.Cust_Plus4 column object.
    ''' </summary>
    Public ReadOnly Property Cust_Plus4Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(124), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.Cust_Plus4 column object.
    ''' </summary>
    Public Shared ReadOnly Property Cust_Plus4() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.Cust_Plus4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.Cust_Plus5 column object.
    ''' </summary>
    Public ReadOnly Property Cust_Plus5Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(125), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.Cust_Plus5 column object.
    ''' </summary>
    Public Shared ReadOnly Property Cust_Plus5() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.Cust_Plus5Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.Cust_Plus6 column object.
    ''' </summary>
    Public ReadOnly Property Cust_Plus6Column() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(126), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.Cust_Plus6 column object.
    ''' </summary>
    Public Shared ReadOnly Property Cust_Plus6() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.Cust_Plus6Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.Cust_HrsTtl column object.
    ''' </summary>
    Public ReadOnly Property Cust_HrsTtlColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(127), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Sign_.Cust_HrsTtl column object.
    ''' </summary>
    Public Shared ReadOnly Property Cust_HrsTtl() As BaseClasses.Data.ClobColumn
        Get
            Return V_SignView.Instance.Cust_HrsTtlColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_SignRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As V_SignRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_SignRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As V_SignRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_SignRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_SignRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_SignRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_SignRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_SignRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_SignRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  V_SignView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_SignRecord)), V_SignRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_SignRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_SignRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  V_SignView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_SignRecord)), V_SignRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_SignRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = V_SignView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_SignRecord)), V_SignRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_SignRecord()

        Dim recList As ArrayList = V_SignView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_SignRecord)), V_SignRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As V_SignRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = V_SignView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_SignRecord)), V_SignRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As V_SignRecord()

        Dim recList As ArrayList = V_SignView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_SignRecord)), V_SignRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(V_SignView.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(V_SignView.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(V_SignView.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(V_SignView.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_SignRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As V_SignRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_SignRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As V_SignRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_SignRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_SignRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = V_SignView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As V_SignRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), V_SignRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_SignRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_SignRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = V_SignView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As V_SignRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), V_SignRecord)
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

        Return V_SignView.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return V_SignView.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As V_SignRecord = GetRecords(where)
        Return V_SignView.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As V_SignRecord = GetRecords(join, where)
        Return V_SignView.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As V_SignRecord = GetRecords(where, orderBy)
        Return V_SignView.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As V_SignRecord = GetRecords(join, where, orderBy)
        Return V_SignView.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As V_SignRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return V_SignView.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As V_SignRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return V_SignView.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        V_SignView.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return V_SignView.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return V_SignView.Instance.ExportRecordData(whereFilter)
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

        Return V_SignView.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return V_SignView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return V_SignView.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return V_SignView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return V_SignView.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return V_SignView.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return V_SignView.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return V_SignView.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = V_SignView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As V_SignRecord
        Return CType(V_SignView.Instance.GetRecordData(id, bMutable), V_SignRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As V_SignRecord
        Return CType(V_SignView.Instance.GetRecordData(id, bMutable), V_SignRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal ExecutionIDValue As String, _
        ByVal SignedOnValue As String, _
        ByVal ExpiresOnValue As String, _
        ByVal BarCodeValue As String, _
        ByVal C_LogoValue As String, _
        ByVal C_LogoSmallValue As String, _
        ByVal C_NameValue As String, _
        ByVal C_DBAValue As String, _
        ByVal C_DBAOrNameValue As String, _
        ByVal C_AddrHTMLValue As String, _
        ByVal C_AddrValue As String, _
        ByVal C_CitySTZipValue As String, _
        ByVal C_CityValue As String, _
        ByVal C_STValue As String, _
        ByVal C_ZipValue As String, _
        ByVal C_CountryValue As String, _
        ByVal C_SignerValue As String, _
        ByVal C_SignerTitleValue As String, _
        ByVal C_SignerContactInfoValue As String, _
        ByVal C_PhoneValue As String, _
        ByVal C_MobileValue As String, _
        ByVal C_OtherPhoneValue As String, _
        ByVal C_FaxValue As String, _
        ByVal C_EmailValue As String, _
        ByVal C_SignatureValue As String, _
        ByVal C_SignatureSmallValue As String, _
        ByVal C_InitialsValue As String, _
        ByVal C_DOTValue As String, _
        ByVal C_MCValue As String, _
        ByVal C_EINValue As String, _
        ByVal C_EIN1Value As String, _
        ByVal C_EIN2Value As String, _
        ByVal C_EIN3Value As String, _
        ByVal C_EIN4Value As String, _
        ByVal C_EIN5Value As String, _
        ByVal C_EIN6Value As String, _
        ByVal C_EIN7Value As String, _
        ByVal C_EIN8Value As String, _
        ByVal C_EIN9Value As String, _
        ByVal D_ProfilePicValue As String, _
        ByVal D_NameValue As String, _
        ByVal D_ContactInfoValue As String, _
        ByVal D_PhoneValue As String, _
        ByVal D_MobileValue As String, _
        ByVal D_OtherPhoneValue As String, _
        ByVal D_FaxValue As String, _
        ByVal D_EmailValue As String, _
        ByVal D_SignatureValue As String, _
        ByVal D_SignatureSmallValue As String, _
        ByVal D_InitialsValue As String, _
        ByVal D_OverviewValue As String, _
        ByVal D_IncidentsValue As String, _
        ByVal D_ExpGeneralValue As String, _
        ByVal D_ExpEquipmentValue As String, _
        ByVal D_ExpCargoValue As String, _
        ByVal D_ExpRegionsValue As String, _
        ByVal D_GaugeValue As String, _
        ByVal D_AddrHTMLValue As String, _
        ByVal D_AddrValue As String, _
        ByVal D_CitySTZipValue As String, _
        ByVal D_CityValue As String, _
        ByVal D_STValue As String, _
        ByVal D_ZipValue As String, _
        ByVal D_CountryValue As String, _
        ByVal D_DOBValue As String, _
        ByVal D_CDLInfoValue As String, _
        ByVal D_CDLShortValue As String, _
        ByVal D_CDLOnlyValue As String, _
        ByVal D_CDLStateValue As String, _
        ByVal D_USCitizenValue As String, _
        ByVal D_PersonalInfoValue As String, _
        ByVal D_SSNValue As String, _
        ByVal D_SSX4Value As String, _
        ByVal D_SS1Value As String, _
        ByVal D_SS2Value As String, _
        ByVal D_SS3Value As String, _
        ByVal D_SS4Value As String, _
        ByVal D_SS5Value As String, _
        ByVal D_SS6Value As String, _
        ByVal D_SS7Value As String, _
        ByVal D_SS8Value As String, _
        ByVal D_SS9Value As String, _
        ByVal D_PRAValue As String, _
        ByVal D_PRANumberValue As String, _
        ByVal D_PassportValue As String, _
        ByVal D_PassportExpirationValue As String, _
        ByVal D_TerminalAssignedValue As String, _
        ByVal D_I9OtherAlienValue As String, _
        ByVal D_I9aValue As String, _
        ByVal D_I9bValue As String, _
        ByVal D_I9cValue As String, _
        ByVal FirstLabelValue As String, _
        ByVal FirstValueValue As String, _
        ByVal SecondLabelValue As String, _
        ByVal SecondValueValue As String, _
        ByVal ThirdLabelValue As String, _
        ByVal ThirdValueValue As String, _
        ByVal FourthLabelValue As String, _
        ByVal FourthValueValue As String, _
        ByVal FifthLabelValue As String, _
        ByVal FifthValueValue As String, _
        ByVal SixthLabelValue As String, _
        ByVal SixthValueValue As String, _
        ByVal SeventhLabelValue As String, _
        ByVal SeventhValueValue As String, _
        ByVal EighthLabelValue As String, _
        ByVal EighthValueValue As String, _
        ByVal NinthLabelValue As String, _
        ByVal NinthValueValue As String, _
        ByVal TenthLabelValue As String, _
        ByVal TenthValueValue As String, _
        ByVal EleventhLabelValue As String, _
        ByVal EleventhValueValue As String, _
        ByVal TwelfthLabelValue As String, _
        ByVal TwelfthValueValue As String, _
        ByVal ThirteenthLabelValue As String, _
        ByVal ThirteenthValueValue As String, _
        ByVal FourteenthLabelValue As String, _
        ByVal FourteenthValueValue As String, _
        ByVal FifteenthLabelValue As String, _
        ByVal FifteenthValueValue As String, _
        ByVal Cust_Plus1Value As String, _
        ByVal Cust_Plus2Value As String, _
        ByVal Cust_Plus3Value As String, _
        ByVal Cust_Plus4Value As String, _
        ByVal Cust_Plus5Value As String, _
        ByVal Cust_Plus6Value As String, _
        ByVal Cust_HrsTtlValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(ExecutionIDValue, ExecutionIDColumn)
        rec.SetString(SignedOnValue, SignedOnColumn)
        rec.SetString(ExpiresOnValue, ExpiresOnColumn)
        rec.SetString(BarCodeValue, BarCodeColumn)
        rec.SetString(C_LogoValue, C_LogoColumn)
        rec.SetString(C_LogoSmallValue, C_LogoSmallColumn)
        rec.SetString(C_NameValue, C_NameColumn)
        rec.SetString(C_DBAValue, C_DBAColumn)
        rec.SetString(C_DBAOrNameValue, C_DBAOrNameColumn)
        rec.SetString(C_AddrHTMLValue, C_AddrHTMLColumn)
        rec.SetString(C_AddrValue, C_AddrColumn)
        rec.SetString(C_CitySTZipValue, C_CitySTZipColumn)
        rec.SetString(C_CityValue, C_CityColumn)
        rec.SetString(C_STValue, C_STColumn)
        rec.SetString(C_ZipValue, C_ZipColumn)
        rec.SetString(C_CountryValue, C_CountryColumn)
        rec.SetString(C_SignerValue, C_SignerColumn)
        rec.SetString(C_SignerTitleValue, C_SignerTitleColumn)
        rec.SetString(C_SignerContactInfoValue, C_SignerContactInfoColumn)
        rec.SetString(C_PhoneValue, C_PhoneColumn)
        rec.SetString(C_MobileValue, C_MobileColumn)
        rec.SetString(C_OtherPhoneValue, C_OtherPhoneColumn)
        rec.SetString(C_FaxValue, C_FaxColumn)
        rec.SetString(C_EmailValue, C_EmailColumn)
        rec.SetString(C_SignatureValue, C_SignatureColumn)
        rec.SetString(C_SignatureSmallValue, C_SignatureSmallColumn)
        rec.SetString(C_InitialsValue, C_InitialsColumn)
        rec.SetString(C_DOTValue, C_DOTColumn)
        rec.SetString(C_MCValue, C_MCColumn)
        rec.SetString(C_EINValue, C_EINColumn)
        rec.SetString(C_EIN1Value, C_EIN1Column)
        rec.SetString(C_EIN2Value, C_EIN2Column)
        rec.SetString(C_EIN3Value, C_EIN3Column)
        rec.SetString(C_EIN4Value, C_EIN4Column)
        rec.SetString(C_EIN5Value, C_EIN5Column)
        rec.SetString(C_EIN6Value, C_EIN6Column)
        rec.SetString(C_EIN7Value, C_EIN7Column)
        rec.SetString(C_EIN8Value, C_EIN8Column)
        rec.SetString(C_EIN9Value, C_EIN9Column)
        rec.SetString(D_ProfilePicValue, D_ProfilePicColumn)
        rec.SetString(D_NameValue, D_NameColumn)
        rec.SetString(D_ContactInfoValue, D_ContactInfoColumn)
        rec.SetString(D_PhoneValue, D_PhoneColumn)
        rec.SetString(D_MobileValue, D_MobileColumn)
        rec.SetString(D_OtherPhoneValue, D_OtherPhoneColumn)
        rec.SetString(D_FaxValue, D_FaxColumn)
        rec.SetString(D_EmailValue, D_EmailColumn)
        rec.SetString(D_SignatureValue, D_SignatureColumn)
        rec.SetString(D_SignatureSmallValue, D_SignatureSmallColumn)
        rec.SetString(D_InitialsValue, D_InitialsColumn)
        rec.SetString(D_OverviewValue, D_OverviewColumn)
        rec.SetString(D_IncidentsValue, D_IncidentsColumn)
        rec.SetString(D_ExpGeneralValue, D_ExpGeneralColumn)
        rec.SetString(D_ExpEquipmentValue, D_ExpEquipmentColumn)
        rec.SetString(D_ExpCargoValue, D_ExpCargoColumn)
        rec.SetString(D_ExpRegionsValue, D_ExpRegionsColumn)
        rec.SetString(D_GaugeValue, D_GaugeColumn)
        rec.SetString(D_AddrHTMLValue, D_AddrHTMLColumn)
        rec.SetString(D_AddrValue, D_AddrColumn)
        rec.SetString(D_CitySTZipValue, D_CitySTZipColumn)
        rec.SetString(D_CityValue, D_CityColumn)
        rec.SetString(D_STValue, D_STColumn)
        rec.SetString(D_ZipValue, D_ZipColumn)
        rec.SetString(D_CountryValue, D_CountryColumn)
        rec.SetString(D_DOBValue, D_DOBColumn)
        rec.SetString(D_CDLInfoValue, D_CDLInfoColumn)
        rec.SetString(D_CDLShortValue, D_CDLShortColumn)
        rec.SetString(D_CDLOnlyValue, D_CDLOnlyColumn)
        rec.SetString(D_CDLStateValue, D_CDLStateColumn)
        rec.SetString(D_USCitizenValue, D_USCitizenColumn)
        rec.SetString(D_PersonalInfoValue, D_PersonalInfoColumn)
        rec.SetString(D_SSNValue, D_SSNColumn)
        rec.SetString(D_SSX4Value, D_SSX4Column)
        rec.SetString(D_SS1Value, D_SS1Column)
        rec.SetString(D_SS2Value, D_SS2Column)
        rec.SetString(D_SS3Value, D_SS3Column)
        rec.SetString(D_SS4Value, D_SS4Column)
        rec.SetString(D_SS5Value, D_SS5Column)
        rec.SetString(D_SS6Value, D_SS6Column)
        rec.SetString(D_SS7Value, D_SS7Column)
        rec.SetString(D_SS8Value, D_SS8Column)
        rec.SetString(D_SS9Value, D_SS9Column)
        rec.SetString(D_PRAValue, D_PRAColumn)
        rec.SetString(D_PRANumberValue, D_PRANumberColumn)
        rec.SetString(D_PassportValue, D_PassportColumn)
        rec.SetString(D_PassportExpirationValue, D_PassportExpirationColumn)
        rec.SetString(D_TerminalAssignedValue, D_TerminalAssignedColumn)
        rec.SetString(D_I9OtherAlienValue, D_I9OtherAlienColumn)
        rec.SetString(D_I9aValue, D_I9aColumn)
        rec.SetString(D_I9bValue, D_I9bColumn)
        rec.SetString(D_I9cValue, D_I9cColumn)
        rec.SetString(FirstLabelValue, FirstLabelColumn)
        rec.SetString(FirstValueValue, FirstValueColumn)
        rec.SetString(SecondLabelValue, SecondLabelColumn)
        rec.SetString(SecondValueValue, SecondValueColumn)
        rec.SetString(ThirdLabelValue, ThirdLabelColumn)
        rec.SetString(ThirdValueValue, ThirdValueColumn)
        rec.SetString(FourthLabelValue, FourthLabelColumn)
        rec.SetString(FourthValueValue, FourthValueColumn)
        rec.SetString(FifthLabelValue, FifthLabelColumn)
        rec.SetString(FifthValueValue, FifthValueColumn)
        rec.SetString(SixthLabelValue, SixthLabelColumn)
        rec.SetString(SixthValueValue, SixthValueColumn)
        rec.SetString(SeventhLabelValue, SeventhLabelColumn)
        rec.SetString(SeventhValueValue, SeventhValueColumn)
        rec.SetString(EighthLabelValue, EighthLabelColumn)
        rec.SetString(EighthValueValue, EighthValueColumn)
        rec.SetString(NinthLabelValue, NinthLabelColumn)
        rec.SetString(NinthValueValue, NinthValueColumn)
        rec.SetString(TenthLabelValue, TenthLabelColumn)
        rec.SetString(TenthValueValue, TenthValueColumn)
        rec.SetString(EleventhLabelValue, EleventhLabelColumn)
        rec.SetString(EleventhValueValue, EleventhValueColumn)
        rec.SetString(TwelfthLabelValue, TwelfthLabelColumn)
        rec.SetString(TwelfthValueValue, TwelfthValueColumn)
        rec.SetString(ThirteenthLabelValue, ThirteenthLabelColumn)
        rec.SetString(ThirteenthValueValue, ThirteenthValueColumn)
        rec.SetString(FourteenthLabelValue, FourteenthLabelColumn)
        rec.SetString(FourteenthValueValue, FourteenthValueColumn)
        rec.SetString(FifteenthLabelValue, FifteenthLabelColumn)
        rec.SetString(FifteenthValueValue, FifteenthValueColumn)
        rec.SetString(Cust_Plus1Value, Cust_Plus1Column)
        rec.SetString(Cust_Plus2Value, Cust_Plus2Column)
        rec.SetString(Cust_Plus3Value, Cust_Plus3Column)
        rec.SetString(Cust_Plus4Value, Cust_Plus4Column)
        rec.SetString(Cust_Plus5Value, Cust_Plus5Column)
        rec.SetString(Cust_Plus6Value, Cust_Plus6Column)
        rec.SetString(Cust_HrsTtlValue, Cust_HrsTtlColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        V_SignView.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            V_SignView.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(V_SignView.Instance.TableDefinition.PrimaryKey)) Then
            Return V_SignView.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(V_SignView.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = V_SignView.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = V_SignView.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (V_SignView.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = V_SignView.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = V_SignView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = V_SignView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
