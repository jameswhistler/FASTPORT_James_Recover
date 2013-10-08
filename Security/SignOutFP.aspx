﻿<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="SignOutFP.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/Security.master" Inherits="FASTPORT.UI.SignOutFP" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="Content" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
          <table class="dvSecurity" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelL"></td><td class="pcCSecurity"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("ForgetSignInButton")) %><asp:panel id="SignOutCollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" style="width:100%;"><tr><td class="securityForm"><table><tr><td style="height: 50px;">&nbsp;</td></tr><tr><td><asp:Label runat="server" id="SignOutMessage" Text="You have successfully signed out">	</asp:Label><br /><br /></td></tr><tr><td style="height: 50px;">&nbsp;</td></tr><tr><td align="center"><FASTPORT:ThemeButton runat="server" id="ForgetSignInButton" button-causesvalidation="False" button-commandname="ForgetSignInInformation" button-text="&lt;%# GetResourceValue(&quot;Btn:ForgetSignInButton&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Txt:ForgetSignInButton&quot;, &quot;FASTPORT&quot;) %>"></FASTPORT:ThemeButton></td></tr><tr><td style="height: 50px;">&nbsp;</td></tr><tr><td class="flSecurity"><asp:Label id="CloseWindowMessage" runat="server" Text="<%# GetResourceValue(&quot;Txt:CloseWindowMessage&quot;, &quot;FASTPORT&quot;) %>" />&nbsp;</td></tr></table>
</td></tr></table></asp:panel>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("ForgetSignInButton")) %></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table><div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
          <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
          