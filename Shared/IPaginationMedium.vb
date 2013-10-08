﻿
Imports Microsoft.VisualBasic
Imports BaseClasses.Utils.DbUtils
  
Namespace FASTPORT.UI

  

    Public Interface IPaginationMedium

#Region "Interface Properties"
        
        ReadOnly Property CurrentPage() As System.Web.UI.WebControls.TextBox
        ReadOnly Property FirstPage() As System.Web.UI.WebControls.ImageButton
        ReadOnly Property LastPage() As System.Web.UI.WebControls.ImageButton
        ReadOnly Property NextPage() As System.Web.UI.WebControls.ImageButton
        ReadOnly Property PageSize() As System.Web.UI.WebControls.TextBox
        ReadOnly Property PageSizeButton() As System.Web.UI.WebControls.LinkButton
        ReadOnly Property PreviousPage() As System.Web.UI.WebControls.ImageButton
        ReadOnly Property TotalPages() As System.Web.UI.WebControls.Label
      Property Visible() as Boolean
         

#End Region

    End Interface

  
End Namespace
  