<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
<%@ Register TagPrefix="FASTPORT" Namespace="FASTPORT.UI.Controls.EditTree" Assembly="FASTPORT" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="EditTree.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.EditTree" %>

<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<asp:Content ID="PageSection" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
    <script type="text/javascript">
        function CloseAndRedirect(sender, args) {
            GetRadWindow().BrowserWindow.refreshGrid();
            GetRadWindow().close();       //closes the window       
        }
        function GetRadWindow()   //Get reference to window    
        {
            var oWindow = null;
            if (window.radWindow)
                oWindow = window.radWindow;
            else if (window.frameElement.radWindow)
                oWindow = window.frameElement.radWindow;
            return oWindow;
        }       
    </script>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
    <table cellpadding="0" cellspacing="0" border="0">
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
                            <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
                            <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
                            <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
                            <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
                            <FASTPORT:TreeRecordControl runat="server" id="TreeRecordControl">
                                <table class="dv" cellpadding="0" cellspacing="0" border="0">
                                    <tr>
                                        <td>
                                            <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                                <tr>
                                                    <td>
                                                        <asp:Panel ID="TreeRecordControlPanel" runat="server">
                                                            <table cellpadding="0" cellspacing="0" border="0">
                                                                <tr>
                                                                    <td class="fls">
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <span style="white-space: nowrap;">
                                                                            <asp:Literal runat="server" ID="TreeID" Visible="False"></asp:Literal></span>
                                                                        <span style="white-space: nowrap;">
                                                                            <table border="0" cellpadding="0" cellspacing="0">
                                                                                <tr>
                                                                                    <td style="padding-right: 5px; vertical-align: top">
                                                                                        <asp:TextBox runat="server" ID="TreeParentID" Columns="14" MaxLength="14" CssClass="field_input"
                                                                                            minlistitems="Default" Visible="False"></asp:TextBox>
                                                                                    </td>
                                                                                    <td>
                                                                                        &nbsp;
                                                                                        <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="TreeParentIDTextBoxMaxLengthValidator"
                                                                                            ControlToValidate="TreeParentID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Tree Parent&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </span>
                                                                        <asp:CheckBox runat="server" ID="Hide" Visible="False"></asp:CheckBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="ItemNameLabel" Text="Item Name">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <span style="white-space: nowrap;">
                                                                            <asp:TextBox runat="server" ID="ItemName" MaxLength="100" Columns="60" CssClass="field_input"
                                                                                Rows="2" TextMode="SingleLine"></asp:TextBox>&nbsp;
                                                                            <asp:RequiredFieldValidator runat="server" ID="ItemNameRequiredFieldValidator" ControlToValidate="ItemName"
                                                                                ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Item Name&quot;) %>"
                                                                                Enabled="True" Text="*"></asp:RequiredFieldValidator>&nbsp;
                                                                            <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="ItemNameTextBoxMaxLengthValidator"
                                                                                ControlToValidate="ItemName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Item Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="DescriptionLabel" Text="Description">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <span style="white-space: nowrap;">
                                                                            <asp:TextBox runat="server" ID="Description" MaxLength="255" Columns="60" CssClass="field_input"
                                                                                Rows="5" TextMode="MultiLine"></asp:TextBox>&nbsp;
                                                                            <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="DescriptionTextBoxMaxLengthValidator"
                                                                                ControlToValidate="Description" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="FolderOnlyLabel" Text="Folder Only">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <asp:CheckBox runat="server" ID="FolderOnly"></asp:CheckBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="AdminOnlyLabel" Text="Administrator Only">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <asp:CheckBox runat="server" ID="AdminOnly"></asp:CheckBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="ItemRankLabel" Text="Item Rank">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <span style="white-space: nowrap;">
                                                                            <table border="0" cellpadding="0" cellspacing="0">
                                                                                <tr>
                                                                                    <td style="padding-right: 5px; vertical-align: top">
                                                                                        <asp:TextBox runat="server" ID="ItemRank" Columns="14" MaxLength="14" onkeyup="adjustInteger(this, event.keyCode)"
                                                                                            CssClass="field_input" Width="35px"></asp:TextBox>
                                                                                    </td>
                                                                                    <td style="padding-right: 5px; white-space: nowrap;">
                                                                                        <%# SystemUtils.GenerateIncrementDecrementButtons(false, FindControlRecursively("ItemRank"),"NumberTextBox","","","") %>
                                                                                    </td>
                                                                                    <td>
                                                                                        &nbsp;
                                                                                        <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="ItemRankTextBoxMaxLengthValidator"
                                                                                            ControlToValidate="ItemRank" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Item Rank&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </span>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </FASTPORT:TreeRecordControl>
                            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
                            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
                            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
                            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
                            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
                        </td>
                    </tr>
                    <tr>
                        <td class="recordPanelButtonsAlignment">
                            <table cellpadding="0" cellspacing="0" border="0">
                                <tr>
                                    <td>
                                        <FASTPORT:ThemeButton runat="server" ID="SaveButton" Button-CausesValidation="True"
                                            Button-CommandName="UpdateData" Button-Text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>"
                                            Button-ToolTip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>"
                                            postback="True"></FASTPORT:ThemeButton>
                                    </td>
                                    <td>
                                        <FASTPORT:ThemeButton runat="server" ID="CancelButton" Button-CausesValidation="False"
                                            Button-CommandName="Redirect" Button-Text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;FASTPORT&quot;) %>"
                                            Button-ToolTip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;FASTPORT&quot;) %>"
                                            postback="False"></FASTPORT:ThemeButton>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();"
        onmouseover="clearTimeout(gPopupTimer);">
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="false"
        runat="server"></asp:ValidationSummary>
</asp:Content>
