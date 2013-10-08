<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="SendUserInfoFP.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/Email.master" Inherits="FASTPORT.UI.SendUserInfoFP" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    
                <table cellpadding="20" cellspacing="0" border="0"><tr><td colspan="2" style="color: #555555; font-family: Verdana, Arial, Georgia, sans-serif; font-size: 12px; padding-bottom: 0px; padding-left: 4px; padding-right: 4px; padding-top: 8px; text-align: left; vertical-align: top;"><asp:Label runat="server" id="InformationLabel" Text="&lt;%# GetResourceValue(&quot;Txt:HereisSignin&quot;, &quot;FASTPORT&quot;) %>">	</asp:Label></td></tr><tr><td><asp:Literal runat="server" id="MyLoginInfo" Text="Username Password">	</asp:Literal></td><td class="dfv"></td></tr></table>
    
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                