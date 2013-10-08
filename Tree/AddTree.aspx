<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="FASTPORT" Namespace="FASTPORT.UI.Controls.AddTree" Assembly="FASTPORT" %>
<%@ Register TagPrefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="AddTree.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.AddTree" %>

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
    <asp:UpdateProgress runat="server" ID="UpdatePanel1_UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1">
        <ProgressTemplate>
            <div class="ajaxUpdatePanel">
            </div>
            <div style="position: absolute; padding: 30px;">
                <img src="../Images/updating.gif" alt="Updating" />
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:UpdatePanel runat="server" ID="UpdatePanel1" UpdateMode="Conditional">
        <ContentTemplate>
            <input type="hidden" id="_clientSideIsPostBack" name="clientSideIsPostBack" runat="server" />
            <table cellpadding="0" cellspacing="0" border="0" class="rw_PaddingFix_Cust">
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
                                                                                <asp:Literal runat="server" ID="AdminOnlyLabel" Text="Administrator Only">	</asp:Literal>
                                                                            </td>
                                                                            <td class="dfv">
                                                                                <asp:CheckBox runat="server" ID="AdminOnly"></asp:CheckBox>
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
                                    <center>
                                        <table cellpadding="0" cellspacing="0" border="0">
                                            <tr>
                                                <td>
                                                    <FASTPORT:ThemeButton runat="server" ID="SaveButton" Button-CausesValidation="True"
                                                        Button-CommandName="UpdateData" Button-Text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>"
                                                        Button-ToolTip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>"
                                                        postback="True"></FASTPORT:ThemeButton>
                                                </td>
                                                <td>
                                                    <FASTPORT:ThemeButton runat="server" ID="SaveAndNewButton" Button-CausesValidation="True"
                                                        Button-CommandName="UpdateData" Button-Text="&lt;%# GetResourceValue(&quot;Btn:SaveNNew&quot;, &quot;FASTPORT&quot;) %>"
                                                        Button-ToolTip="&lt;%# GetResourceValue(&quot;Btn:SaveNNew&quot;, &quot;FASTPORT&quot;) %>"
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
                                    </center>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();"
        onmouseover="clearTimeout(gPopupTimer);">
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="false"
        runat="server"></asp:ValidationSummary>
</asp:Content>
