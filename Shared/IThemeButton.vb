﻿
Imports Microsoft.VisualBasic
Imports BaseClasses.Utils.DbUtils
  
Namespace FASTPORT.UI

  

    Public Interface IThemeButton

#Region "Interface Properties"
        
        ReadOnly Property Button() As System.Web.UI.WebControls.LinkButton
      Property Visible() as Boolean
         

#End Region

    End Interface

  
End Namespace
  