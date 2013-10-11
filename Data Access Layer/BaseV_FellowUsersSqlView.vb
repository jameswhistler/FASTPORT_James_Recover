' This class is "generated" and will be overwritten.
' Your customizations should be made in V_FellowUsersSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace FASTPORT.Data

''' <summary>
''' The generated superclass for the <see cref="V_FellowUsersSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_FellowUsersView"></see> class.
''' </remarks>
''' <seealso cref="V_FellowUsersView"></seealso>
''' <seealso cref="V_FellowUsersSqlView"></seealso>

Public Class BaseV_FellowUsersSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
