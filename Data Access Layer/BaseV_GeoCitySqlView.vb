' This class is "generated" and will be overwritten.
' Your customizations should be made in V_GeoCitySqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace FASTPORT.Data

''' <summary>
''' The generated superclass for the <see cref="V_GeoCitySqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_GeoCityView"></see> class.
''' </remarks>
''' <seealso cref="V_GeoCityView"></seealso>
''' <seealso cref="V_GeoCitySqlView"></seealso>

Public Class BaseV_GeoCitySqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
