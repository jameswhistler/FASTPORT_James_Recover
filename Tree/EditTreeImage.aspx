<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="EditTreeImage.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.EditTreeImage" %>

<%@ Register TagPrefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
<%@ Register TagPrefix="FASTPORT" Namespace="FASTPORT.UI.Controls.EditTreeImage"
    Assembly="FASTPORT" %>
<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<asp:Content ID="PageSection" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
    </telerik:RadStyleSheetManager>
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
                                                    <tr visible="False">
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
                                                            <span style="white-space: nowrap;">
                                                                <asp:TextBox runat="server" ID="ItemName" MaxLength="100" Columns="60" CssClass="field_input"
                                                                    Rows="2" TextMode="MultiLine" Visible="False"></asp:TextBox>&nbsp;
                                                                <asp:RequiredFieldValidator runat="server" ID="ItemNameRequiredFieldValidator" ControlToValidate="ItemName"
                                                                    ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Item Name&quot;) %>"
                                                                    Enabled="True" Text="*"></asp:RequiredFieldValidator>&nbsp;
                                                                <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="ItemNameTextBoxMaxLengthValidator"
                                                                    ControlToValidate="ItemName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Item Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                            <span style="white-space: nowrap;">
                                                                <asp:TextBox runat="server" ID="ImageGlowPath" MaxLength="255" Columns="60" CssClass="field_input"
                                                                    Rows="5" TextMode="MultiLine" Visible="False"></asp:TextBox>&nbsp;
                                                                <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="ImageGlowPathTextBoxMaxLengthValidator"
                                                                    ControlToValidate="ImageGlowPath" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Image Glow Path&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                            <span style="white-space: nowrap;">
                                                                <asp:TextBox runat="server" ID="ImageGrayPath" MaxLength="255" Columns="60" CssClass="field_input"
                                                                    Rows="5" TextMode="MultiLine" Visible="False"></asp:TextBox>&nbsp;
                                                                <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="ImageGrayPathTextBoxMaxLengthValidator"
                                                                    ControlToValidate="ImageGrayPath" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Image Gray Path&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                            <span style="white-space: nowrap;">
                                                                <asp:TextBox runat="server" ID="ImageLowResPath" MaxLength="255" Columns="60" CssClass="field_input"
                                                                    Rows="5" TextMode="MultiLine" Visible="False"></asp:TextBox>&nbsp;
                                                                <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="ImageLowResPathTextBoxMaxLengthValidator"
                                                                    ControlToValidate="ImageLowResPath" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Image Low RES Path&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                            <span style="white-space: nowrap;">
                                                                <asp:TextBox runat="server" ID="ImagePath" MaxLength="255" Columns="60" CssClass="field_input"
                                                                    Rows="5" TextMode="MultiLine" Visible="False"></asp:TextBox>&nbsp;
                                                                <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="ImagePathTextBoxMaxLengthValidator"
                                                                    ControlToValidate="ImagePath" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Image Path&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="ItemImageLabel" Text="Item Image">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv" colspan="3">
                                                            <telerik:RadUpload ID="RadUpload1" runat="server" AllowedFileExtensions=".jpg,.jpeg,.gif,.png"
                                                                ControlObjectsVisibility="None">
                                                            </telerik:RadUpload>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="ImageLabel" Text="Base Image">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv">
                                                            <telerik:RadBinaryImage ID="ItemRadBinaryImage" runat="server" />
                                                        </td>
                                                        <td class="dfv">
                                                            <FASTPORT:ThemeButton runat="server" ID="UploadButton" Button-CausesValidation="False"
                                                                Button-CommandName="Redirect" Button-Text="Upload" Button-ToolTip="Click to upload the selected file.">
                                                            </FASTPORT:ThemeButton>
                                                        </td>
                                                        <td class="dfv" style="text-align: left;">
                                                            <asp:ImageButton runat="server" ID="DeleteImageButton" CausesValidation="False" CommandName="Redirect"
                                                                ImageUrl="../Images/icon_delete.gif"></asp:ImageButton>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="GlowLabel" Text="Image Glowing">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv">
                                                            <telerik:RadBinaryImage ID="ItemGlowRadBinaryImage" runat="server" />
                                                        </td>
                                                        <td class="dfv">
                                                            <FASTPORT:ThemeButton runat="server" ID="UploadGlowButton" Button-CausesValidation="False"
                                                                Button-CommandName="Redirect" Button-Text="Upload" Button-ToolTip="Click to upload the selected file.">
                                                            </FASTPORT:ThemeButton>
                                                        </td>
                                                        <td class="dfv" style="text-align: left;">
                                                            <asp:ImageButton runat="server" ID="DeleteGlowButton" CausesValidation="False" CommandName="Redirect"
                                                                ImageUrl="../Images/icon_delete.gif"></asp:ImageButton>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="GrayLabel" Text="Image Gray">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv">
                                                            <telerik:RadBinaryImage ID="ItemGrayRadBinaryImage" runat="server" />
                                                        </td>
                                                        <td class="dfv">
                                                            <FASTPORT:ThemeButton runat="server" ID="UploadGrayButton" Button-CausesValidation="False"
                                                                Button-CommandName="Redirect" Button-Text="Upload" Button-ToolTip="Click to upload the selected file.">
                                                            </FASTPORT:ThemeButton>
                                                        </td>
                                                        <td class="dfv" style="text-align: left;">
                                                            <asp:ImageButton runat="server" ID="DeleteGrayButton" CausesValidation="False" CommandName="Redirect"
                                                                ImageUrl="../Images/icon_delete.gif"></asp:ImageButton>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="LowResLabel" Text="Low Res">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv">
                                                            <telerik:RadBinaryImage ID="ItemLowResRadBinaryImage" runat="server" />
                                                        </td>
                                                        <td class="dfv">
                                                            <FASTPORT:ThemeButton runat="server" ID="UploadLowResButton" Button-CausesValidation="False"
                                                                Button-CommandName="Redirect" Button-Text="Upload" Button-ToolTip="Click to upload the selected file.">
                                                            </FASTPORT:ThemeButton>
                                                        </td>
                                                        <td class="dfv" style="text-align: left;">
                                                            <asp:ImageButton runat="server" ID="DeleteLowResButton" CausesValidation="False"
                                                                CommandName="Redirect" ImageUrl="../Images/icon_delete.gif"></asp:ImageButton>
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
                            <FASTPORT:ThemeButton runat="server" ID="CancelButton" Button-CausesValidation="False"
                                Button-CommandName="Redirect" Button-Text="Back" Button-ToolTip="Click to return to the previous page."
                                postback="False"></FASTPORT:ThemeButton>
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
