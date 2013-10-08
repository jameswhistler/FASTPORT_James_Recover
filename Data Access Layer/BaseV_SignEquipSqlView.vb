' This class is "generated" and will be overwritten.
' Your customizations should be made in V_SignEquipSqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace FASTPORT.Data

''' <summary>
''' The generated superclass for the <see cref="V_SignEquipSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_SignEquipView"></see> class.
''' </remarks>
''' <seealso cref="V_SignEquipView"></seealso>
''' <seealso cref="V_SignEquipSqlView"></seealso>

Public Class BaseV_SignEquipSqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
