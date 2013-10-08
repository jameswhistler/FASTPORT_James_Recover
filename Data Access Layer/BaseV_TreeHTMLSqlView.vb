' This class is "generated" and will be overwritten.
' Your customizations should be made in V_TreeHTMLSqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace FASTPORT.Data

''' <summary>
''' The generated superclass for the <see cref="V_TreeHTMLSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_TreeHTMLView"></see> class.
''' </remarks>
''' <seealso cref="V_TreeHTMLView"></seealso>
''' <seealso cref="V_TreeHTMLSqlView"></seealso>

Public Class BaseV_TreeHTMLSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
