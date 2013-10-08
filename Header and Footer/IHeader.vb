
Imports Microsoft.VisualBasic
Imports BaseClasses.Utils.DbUtils
  
Namespace FASTPORT.UI

  

    Public Interface IHeader

#Region "Interface Properties"
        
        ReadOnly Property HeaderSettings() As System.Web.UI.WebControls.ImageButton
        ReadOnly Property SignIn() As System.Web.UI.WebControls.LinkButton
      Property Visible() as Boolean
         

#End Region

    End Interface

  
End Namespace
  