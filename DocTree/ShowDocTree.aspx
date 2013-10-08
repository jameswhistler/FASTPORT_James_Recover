<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="FASTPORT" Namespace="FASTPORT.UI.Controls.ShowDocTree" Assembly="FASTPORT" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ShowDocTree.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.ShowDocTree" %>
<%@ Register Tagprefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <asp:UpdateProgress runat="server" id="UpdatePanel1_UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1">
			<ProgressTemplate>
				<div class="ajaxUpdatePanel">
				</div>
				<div style=" position:absolute; padding:30px;">
					<img src="../Images/updating.gif" alt="Updating" />
				</div>
			</ProgressTemplate>
		</asp:UpdateProgress>
		<asp:UpdatePanel runat="server" id="UpdatePanel1" UpdateMode="Conditional">
			<ContentTemplate>
				<input type="hidden" id="_clientSideIsPostBack" name="clientSideIsPostBack" runat="server" />

                 
		<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type="text/javascript">
	
            function ChildCloseAndRedirect(args) {
                GetRadWindow().BrowserWindow.ParentCloseAndRedirect(args);
                GetRadWindow().close();
            }


            function ChildClose(args) {
                GetRadWindow().close();
            }			

            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow; //Will work in Moz in all cases, including clasic dialog
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow; //IE (and Moz as well)

                return oWindow;
            }

        </script>
		</telerik:RadCodeBlock><table cellpadding="0" cellspacing="0" border="0"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <FASTPORT:DocTreeRecordControl runat="server" id="DocTreeRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="DocTreeRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="DocTreeParentIDLabel" Text="Folder">	</asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="DocTreeParentID"></asp:Literal></span>
 </td></tr><tr><td class="fls"><asp:Literal runat="server" id="RoleIDLabel" Text="Only For">	</asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RoleID"></asp:Literal></span>
</td></tr><tr><td class="fls"><asp:Literal runat="server" id="DocNameLabel" Text="Document Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="DocName"></asp:Literal> </td></tr><tr><td class="fls"></td><td class="dfv"> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="DocTypeIDLabel" Text="Document Type">	</asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="DocTypeID"></asp:Literal></span>
</td></tr><tr><td class="fls"><asp:Literal runat="server" id="RecordDocDetailsLabel" Text="Record Document Details">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="RecordDocDetails"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</td></tr></table>
</FASTPORT:DocTreeRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0"><tr><td><FASTPORT:ThemeButton runat="server" id="OKButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;FASTPORT&quot;) %>" postback="False"></FASTPORT:ThemeButton></td></tr></table>
</td></tr></table></ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>