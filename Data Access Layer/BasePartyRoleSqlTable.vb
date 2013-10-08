' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyRoleSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace FASTPORT.Data

''' <summary>
''' The generated superclass for the <see cref="PartyRoleSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="PartyRoleTable"></see> class.
''' </remarks>
''' <seealso cref="PartyRoleTable"></seealso>
''' <seealso cref="PartyRoleSqlTable"></seealso>

Public Class BasePartyRoleSqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
