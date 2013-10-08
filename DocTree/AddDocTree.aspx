<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="AddDocTree.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.AddDocTree" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="FASTPORT" Namespace="FASTPORT.UI.Controls.AddDocTree" Assembly="FASTPORT" %>

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
		</telerik:RadCodeBlock><table cellpadding="0" cellspacing="0" border="0"><tr id="InstructionsRow" runat="server" visible="false"><td><table><tr><td style="text-align:left;" class="dfv"><br />
<asp:Literal runat="server" id="InstructionsStandard" Text="889">	</asp:Literal>
<br /></td></tr></table>
</td></tr><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <FASTPORT:DocTreeRecordControl runat="server" id="DocTreeRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="DocTreeRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls" style="vertical-align:top;"><asp:Literal runat="server" id="RoleIDLabel" Text="Only For">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="RoleID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="RoleIDFvLlsHyperLink" ControlToUpdate="RoleID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="Role" Field="Role_.RoleID" DisplayField="Role_.Role" Formula="%3d+Role.Role"></Selectors:FvLlsHyperLink></span>
</td></tr><tr><td class="fls" style="vertical-align:top;"><asp:Literal runat="server" id="DocNameLabel" Text="Document Name">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="DocName" MaxLength="100" columns="60" cssclass="field_input" rows="2" textmode="SingleLine" width="175px"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="DocNameRequiredFieldValidator" ControlToValidate="DocName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Name&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DocNameTextBoxMaxLengthValidator" ControlToValidate="DocName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="fls" style="vertical-align:top;"></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="DocTreeParentID" Columns="14" MaxLength="14" cssclass="field_input" minlistitems="Default" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DocTreeParentIDTextBoxMaxLengthValidator" ControlToValidate="DocTreeParentID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Tree Parent&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<asp:CheckBox runat="server" id="Folder" visible="False"></asp:CheckBox> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="CIX" Columns="14" MaxLength="14" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CIXTextBoxMaxLengthValidator" ControlToValidate="CIX" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;CIX&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="DocTypeID" Columns="14" MaxLength="14" cssclass="field_input" minlistitems="Default" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DocTypeIDTextBoxMaxLengthValidator" ControlToValidate="DocTypeID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Type&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr></table></asp:panel>
</td></tr></table>
</td></tr></table>
</FASTPORT:DocTreeRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><center><table cellpadding="0" cellspacing="0" border="0"><tr><td><FASTPORT:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>" postback="True"></FASTPORT:ThemeButton> 
<FASTPORT:ThemeButton runat="server" id="ConfigureButton" button-causesvalidation="False" button-commandname="Redirect" button-text="Save and Configure" button-tooltip="Click to save and configure this document."></FASTPORT:ThemeButton></td><td><FASTPORT:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;FASTPORT&quot;) %>" postback="False"></FASTPORT:ThemeButton></td></tr></table>
</center></td></tr></table></ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>