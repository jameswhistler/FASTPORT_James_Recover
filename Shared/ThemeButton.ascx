<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="ThemeButton.ascx.vb" Inherits="FASTPORT.UI.ThemeButton" %>
<%@ Register Tagprefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><table class="buttonPadding" cellspacing="0" cellpadding="0" border="0" onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);"><tr><td><div class="themeButton"><asp:LinkButton CommandName="Redirect" runat="server" id="_Button" cssclass="button_link">		
	</asp:LinkButton></div></td></tr></table>