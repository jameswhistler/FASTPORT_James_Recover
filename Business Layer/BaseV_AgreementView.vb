' This class is "generated" and will be overwritten.
' Your customizations should be made in V_AgreementView.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports FASTPORT.Data

Namespace FASTPORT.Business

''' <summary>
''' The generated superclass for the <see cref="V_AgreementView"></see> class.
''' Provides access to the schema information and record data of a database table or view named v_Agreement.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="V_AgreementView.Instance">V_AgreementView.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="V_AgreementView"></seealso>

<Serializable()> Public Class BaseV_AgreementView
	Inherits KeylessTable
	

	Private ReadOnly TableDefinitionString As String = V_AgreementDefinition.GetXMLString()







	Protected Sub New()
		MyBase.New()
		Me.Initialize()
	End Sub

	Protected Overridable Sub Initialize()
		Dim def As New XmlTableDefinition(TableDefinitionString)
		Me.TableDefinition = New TableDefinition()
		Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.V_AgreementView")
		def.InitializeTableDefinition(Me.TableDefinition)
		Me.ConnectionName = def.GetConnectionName()
		Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("FASTPORT.Business", "FASTPORT.Business.V_AgreementRecord")
		Me.ApplicationName = "FASTPORT"
		Me.DataAdapter = New V_AgreementSqlView()
		Directcast(Me.DataAdapter, V_AgreementSqlView).ConnectionName = Me.ConnectionName
		Directcast(Me.DataAdapter, V_AgreementSqlView).ApplicationName = Me.ApplicationName
		Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        ExecutionIDColumn.CodeName = "ExecutionID"
        AgreementIDColumn.CodeName = "AgreementID"
        CIXColumn.CodeName = "CIX"
        OIXColumn.CodeName = "OIX"
        DateToExecuteColumn.CodeName = "DateToExecute"
        MakerAddrIDColumn.CodeName = "MakerAddrID"
        MakerNameColumn.CodeName = "MakerName"
        MakerLogoColumn.CodeName = "MakerLogo"
        MakerAddrColumn.CodeName = "MakerAddr"
        MakerCitySTColumn.CodeName = "MakerCityST"
        MakerCountryColumn.CodeName = "MakerCountry"
        MakerSignerIDColumn.CodeName = "MakerSignerID"
        MakerSignerColumn.CodeName = "MakerSigner"
        MakerSignerTitleColumn.CodeName = "MakerSignerTitle"
        MakerSignatureColumn.CodeName = "MakerSignature"
        OffereeAddrIDColumn.CodeName = "OffereeAddrID"
        OffereeNameColumn.CodeName = "OffereeName"
        OffereeAddrColumn.CodeName = "OffereeAddr"
        OffereeCitySTColumn.CodeName = "OffereeCityST"
        OffereeCountryColumn.CodeName = "OffereeCountry"
        OffereeSignerIDColumn.CodeName = "OffereeSignerID"
        OffereeSignerColumn.CodeName = "OffereeSigner"
        OffereeSignerTitleColumn.CodeName = "OffereeSignerTitle"
        OffereeSignatureColumn.CodeName = "OffereeSignature"
        FirstItemLabelColumn.CodeName = "FirstItemLabel"
        FirstItemColumn.CodeName = "FirstItem"
        SecondItemLabelColumn.CodeName = "SecondItemLabel"
        SecondItemColumn.CodeName = "SecondItem"
        ThirdItemLabelColumn.CodeName = "ThirdItemLabel"
        ThirdItemColumn.CodeName = "ThirdItem"
        FourthItemLabelColumn.CodeName = "FourthItemLabel"
        FourthItemColumn.CodeName = "FourthItem"
        FifthItemLabelColumn.CodeName = "FifthItemLabel"
        FifthItemColumn.CodeName = "FifthItem"
        SixthItemLabelColumn.CodeName = "SixthItemLabel"
        SixthItemColumn.CodeName = "SixthItem"
        SeventhItemLabelColumn.CodeName = "SeventhItemLabel"
        SeventhItemColumn.CodeName = "SeventhItem"
        EightItemLabelColumn.CodeName = "EightItemLabel"
        EighthItemColumn.CodeName = "EighthItem"
        NinthItemLabelColumn.CodeName = "NinthItemLabel"
        NinthItemColumn.CodeName = "NinthItem"
        TenthItemLabelColumn.CodeName = "TenthItemLabel"
        TenthItemColumn.CodeName = "TenthItem"
		
	End Sub
	
#Region "Overriden methods"
    
#End Region
	
#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.ExecutionID column object.
    ''' </summary>
    Public ReadOnly Property ExecutionIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.ExecutionID column object.
    ''' </summary>
    Public Shared ReadOnly Property ExecutionID() As BaseClasses.Data.NumberColumn
        Get
            Return V_AgreementView.Instance.ExecutionIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.AgreementID column object.
    ''' </summary>
    Public ReadOnly Property AgreementIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.AgreementID column object.
    ''' </summary>
    Public Shared ReadOnly Property AgreementID() As BaseClasses.Data.NumberColumn
        Get
            Return V_AgreementView.Instance.AgreementIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.CIX column object.
    ''' </summary>
    Public ReadOnly Property CIXColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.CIX column object.
    ''' </summary>
    Public Shared ReadOnly Property CIX() As BaseClasses.Data.NumberColumn
        Get
            Return V_AgreementView.Instance.CIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OIX column object.
    ''' </summary>
    Public ReadOnly Property OIXColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OIX column object.
    ''' </summary>
    Public Shared ReadOnly Property OIX() As BaseClasses.Data.NumberColumn
        Get
            Return V_AgreementView.Instance.OIXColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.DateToExecute column object.
    ''' </summary>
    Public ReadOnly Property DateToExecuteColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.DateToExecute column object.
    ''' </summary>
    Public Shared ReadOnly Property DateToExecute() As BaseClasses.Data.DateColumn
        Get
            Return V_AgreementView.Instance.DateToExecuteColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerAddrID column object.
    ''' </summary>
    Public ReadOnly Property MakerAddrIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerAddrID column object.
    ''' </summary>
    Public Shared ReadOnly Property MakerAddrID() As BaseClasses.Data.NumberColumn
        Get
            Return V_AgreementView.Instance.MakerAddrIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerName column object.
    ''' </summary>
    Public ReadOnly Property MakerNameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerName column object.
    ''' </summary>
    Public Shared ReadOnly Property MakerName() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.MakerNameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerLogo column object.
    ''' </summary>
    Public ReadOnly Property MakerLogoColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerLogo column object.
    ''' </summary>
    Public Shared ReadOnly Property MakerLogo() As BaseClasses.Data.ImageColumn
        Get
            Return V_AgreementView.Instance.MakerLogoColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerAddr column object.
    ''' </summary>
    Public ReadOnly Property MakerAddrColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerAddr column object.
    ''' </summary>
    Public Shared ReadOnly Property MakerAddr() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.MakerAddrColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerCityST column object.
    ''' </summary>
    Public ReadOnly Property MakerCitySTColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerCityST column object.
    ''' </summary>
    Public Shared ReadOnly Property MakerCityST() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.MakerCitySTColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerCountry column object.
    ''' </summary>
    Public ReadOnly Property MakerCountryColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerCountry column object.
    ''' </summary>
    Public Shared ReadOnly Property MakerCountry() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.MakerCountryColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerSignerID column object.
    ''' </summary>
    Public ReadOnly Property MakerSignerIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerSignerID column object.
    ''' </summary>
    Public Shared ReadOnly Property MakerSignerID() As BaseClasses.Data.NumberColumn
        Get
            Return V_AgreementView.Instance.MakerSignerIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerSigner column object.
    ''' </summary>
    Public ReadOnly Property MakerSignerColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerSigner column object.
    ''' </summary>
    Public Shared ReadOnly Property MakerSigner() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.MakerSignerColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerSignerTitle column object.
    ''' </summary>
    Public ReadOnly Property MakerSignerTitleColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerSignerTitle column object.
    ''' </summary>
    Public Shared ReadOnly Property MakerSignerTitle() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.MakerSignerTitleColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerSignature column object.
    ''' </summary>
    Public ReadOnly Property MakerSignatureColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.MakerSignature column object.
    ''' </summary>
    Public Shared ReadOnly Property MakerSignature() As BaseClasses.Data.ImageColumn
        Get
            Return V_AgreementView.Instance.MakerSignatureColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeAddrID column object.
    ''' </summary>
    Public ReadOnly Property OffereeAddrIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeAddrID column object.
    ''' </summary>
    Public Shared ReadOnly Property OffereeAddrID() As BaseClasses.Data.NumberColumn
        Get
            Return V_AgreementView.Instance.OffereeAddrIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeName column object.
    ''' </summary>
    Public ReadOnly Property OffereeNameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeName column object.
    ''' </summary>
    Public Shared ReadOnly Property OffereeName() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.OffereeNameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeAddr column object.
    ''' </summary>
    Public ReadOnly Property OffereeAddrColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeAddr column object.
    ''' </summary>
    Public Shared ReadOnly Property OffereeAddr() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.OffereeAddrColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeCityST column object.
    ''' </summary>
    Public ReadOnly Property OffereeCitySTColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeCityST column object.
    ''' </summary>
    Public Shared ReadOnly Property OffereeCityST() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.OffereeCitySTColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeCountry column object.
    ''' </summary>
    Public ReadOnly Property OffereeCountryColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeCountry column object.
    ''' </summary>
    Public Shared ReadOnly Property OffereeCountry() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.OffereeCountryColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeSignerID column object.
    ''' </summary>
    Public ReadOnly Property OffereeSignerIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeSignerID column object.
    ''' </summary>
    Public Shared ReadOnly Property OffereeSignerID() As BaseClasses.Data.NumberColumn
        Get
            Return V_AgreementView.Instance.OffereeSignerIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeSigner column object.
    ''' </summary>
    Public ReadOnly Property OffereeSignerColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeSigner column object.
    ''' </summary>
    Public Shared ReadOnly Property OffereeSigner() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.OffereeSignerColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeSignerTitle column object.
    ''' </summary>
    Public ReadOnly Property OffereeSignerTitleColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeSignerTitle column object.
    ''' </summary>
    Public Shared ReadOnly Property OffereeSignerTitle() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.OffereeSignerTitleColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeSignature column object.
    ''' </summary>
    Public ReadOnly Property OffereeSignatureColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.OffereeSignature column object.
    ''' </summary>
    Public Shared ReadOnly Property OffereeSignature() As BaseClasses.Data.ImageColumn
        Get
            Return V_AgreementView.Instance.OffereeSignatureColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.FirstItemLabel column object.
    ''' </summary>
    Public ReadOnly Property FirstItemLabelColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.FirstItemLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstItemLabel() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.FirstItemLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.FirstItem column object.
    ''' </summary>
    Public ReadOnly Property FirstItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.FirstItem column object.
    ''' </summary>
    Public Shared ReadOnly Property FirstItem() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.FirstItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.SecondItemLabel column object.
    ''' </summary>
    Public ReadOnly Property SecondItemLabelColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.SecondItemLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property SecondItemLabel() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.SecondItemLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.SecondItem column object.
    ''' </summary>
    Public ReadOnly Property SecondItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.SecondItem column object.
    ''' </summary>
    Public Shared ReadOnly Property SecondItem() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.SecondItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.ThirdItemLabel column object.
    ''' </summary>
    Public ReadOnly Property ThirdItemLabelColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.ThirdItemLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirdItemLabel() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.ThirdItemLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.ThirdItem column object.
    ''' </summary>
    Public ReadOnly Property ThirdItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.ThirdItem column object.
    ''' </summary>
    Public Shared ReadOnly Property ThirdItem() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.ThirdItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.FourthItemLabel column object.
    ''' </summary>
    Public ReadOnly Property FourthItemLabelColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.FourthItemLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property FourthItemLabel() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.FourthItemLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.FourthItem column object.
    ''' </summary>
    Public ReadOnly Property FourthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.FourthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property FourthItem() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.FourthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.FifthItemLabel column object.
    ''' </summary>
    Public ReadOnly Property FifthItemLabelColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(32), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.FifthItemLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property FifthItemLabel() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.FifthItemLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.FifthItem column object.
    ''' </summary>
    Public ReadOnly Property FifthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(33), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.FifthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property FifthItem() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.FifthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.SixthItemLabel column object.
    ''' </summary>
    Public ReadOnly Property SixthItemLabelColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(34), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.SixthItemLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property SixthItemLabel() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.SixthItemLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.SixthItem column object.
    ''' </summary>
    Public ReadOnly Property SixthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(35), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.SixthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property SixthItem() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.SixthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.SeventhItemLabel column object.
    ''' </summary>
    Public ReadOnly Property SeventhItemLabelColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(36), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.SeventhItemLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property SeventhItemLabel() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.SeventhItemLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.SeventhItem column object.
    ''' </summary>
    Public ReadOnly Property SeventhItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(37), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.SeventhItem column object.
    ''' </summary>
    Public Shared ReadOnly Property SeventhItem() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.SeventhItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.EightItemLabel column object.
    ''' </summary>
    Public ReadOnly Property EightItemLabelColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(38), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.EightItemLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property EightItemLabel() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.EightItemLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.EighthItem column object.
    ''' </summary>
    Public ReadOnly Property EighthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(39), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.EighthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property EighthItem() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.EighthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.NinthItemLabel column object.
    ''' </summary>
    Public ReadOnly Property NinthItemLabelColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(40), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.NinthItemLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property NinthItemLabel() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.NinthItemLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.NinthItem column object.
    ''' </summary>
    Public ReadOnly Property NinthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(41), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.NinthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property NinthItem() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.NinthItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.TenthItemLabel column object.
    ''' </summary>
    Public ReadOnly Property TenthItemLabelColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(42), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.TenthItemLabel column object.
    ''' </summary>
    Public Shared ReadOnly Property TenthItemLabel() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.TenthItemLabelColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.TenthItem column object.
    ''' </summary>
    Public ReadOnly Property TenthItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(43), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_Agreement_.TenthItem column object.
    ''' </summary>
    Public Shared ReadOnly Property TenthItem() As BaseClasses.Data.StringColumn
        Get
            Return V_AgreementView.Instance.TenthItemColumn
        End Get
    End Property


#End Region

#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_AgreementRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As V_AgreementRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_AgreementRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As V_AgreementRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_AgreementRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_AgreementRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_AgreementRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_AgreementRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_AgreementRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_AgreementRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  V_AgreementView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_AgreementRecord)), V_AgreementRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_AgreementRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_AgreementRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  V_AgreementView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_AgreementRecord)), V_AgreementRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_AgreementRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = V_AgreementView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_AgreementRecord)), V_AgreementRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_AgreementRecord()

        Dim recList As ArrayList = V_AgreementView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_AgreementRecord)), V_AgreementRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As V_AgreementRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = V_AgreementView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_AgreementRecord)), V_AgreementRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As V_AgreementRecord()

        Dim recList As ArrayList = V_AgreementView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(FASTPORT.Business.V_AgreementRecord)), V_AgreementRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(V_AgreementView.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(V_AgreementView.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(V_AgreementView.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(V_AgreementView.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_AgreementRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As V_AgreementRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_AgreementRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As V_AgreementRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_AgreementRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_AgreementRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = V_AgreementView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As V_AgreementRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), V_AgreementRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_AgreementRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_AgreementRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = V_AgreementView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As V_AgreementRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), V_AgreementRecord)
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

        Return V_AgreementView.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return V_AgreementView.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As V_AgreementRecord = GetRecords(where)
        Return V_AgreementView.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As V_AgreementRecord = GetRecords(join, where)
        Return V_AgreementView.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As V_AgreementRecord = GetRecords(where, orderBy)
        Return V_AgreementView.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As V_AgreementRecord = GetRecords(join, where, orderBy)
        Return V_AgreementView.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As V_AgreementRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return V_AgreementView.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As V_AgreementRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return V_AgreementView.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        V_AgreementView.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return V_AgreementView.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return V_AgreementView.Instance.ExportRecordData(whereFilter)
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

        Return V_AgreementView.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return V_AgreementView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return V_AgreementView.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return V_AgreementView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return V_AgreementView.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return V_AgreementView.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return V_AgreementView.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return V_AgreementView.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = V_AgreementView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = V_AgreementView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = V_AgreementView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
