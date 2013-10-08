
Imports Microsoft.VisualBasic
Imports BaseClasses.Utils.DbUtils
  
Namespace FASTPORT.UI

  

    Public Interface IMenu

#Region "Interface Properties"
        
        ReadOnly Property MultiLevelMenu() As System.Web.UI.WebControls.Menu
      Property Visible() as Boolean
         

#End Region

    End Interface

  
End Namespace
  