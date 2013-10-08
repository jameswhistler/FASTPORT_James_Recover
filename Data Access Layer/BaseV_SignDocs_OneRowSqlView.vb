' This class is "generated" and will be overwritten.
' Your customizations should be made in V_SignDocs_OneRowSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace FASTPORT.Data

''' <summary>
''' The generated superclass for the <see cref="V_SignDocs_OneRowSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_SignDocs_OneRowView"></see> class.
''' </remarks>
''' <seealso cref="V_SignDocs_OneRowView"></seealso>
''' <seealso cref="V_SignDocs_OneRowSqlView"></seealso>

Public Class BaseV_SignDocs_OneRowSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
