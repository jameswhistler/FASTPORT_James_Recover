' This class is "generated" and will be overwritten.
' Your customizations should be made in Audit_CarrierAdActivitySqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace FASTPORT.Data

''' <summary>
''' The generated superclass for the <see cref="Audit_CarrierAdActivitySqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Audit_CarrierAdActivityTable"></see> class.
''' </remarks>
''' <seealso cref="Audit_CarrierAdActivityTable"></seealso>
''' <seealso cref="Audit_CarrierAdActivitySqlTable"></seealso>

Public Class BaseAudit_CarrierAdActivitySqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
