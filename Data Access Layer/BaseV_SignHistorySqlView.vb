' This class is "generated" and will be overwritten.
' Your customizations should be made in V_SignHistorySqlView.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace FASTPORT.Data

''' <summary>
''' The generated superclass for the <see cref="V_SignHistorySqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_SignHistoryView"></see> class.
''' </remarks>
''' <seealso cref="V_SignHistoryView"></seealso>
''' <seealso cref="V_SignHistorySqlView"></seealso>

Public Class BaseV_SignHistorySqlView
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
