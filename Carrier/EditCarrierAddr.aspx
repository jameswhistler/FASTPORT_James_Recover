<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="EditCarrierAddr.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.EditCarrierAddr" %>

<%@ Register TagPrefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="FASTPORT" Namespace="FASTPORT.UI.Controls.EditCarrierAddr"
    Assembly="FASTPORT" %>
<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<asp:Content ID="PageSection" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
    </telerik:RadStyleSheetManager>
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
            <table cellpadding="0" cellspacing="0" border="0">
                <tr id="InstructionsRow" runat="server" visible="false">
                    <td>
                        <table>
                            <tr id="InstructionsRow1" runat="server" visible="false">
                                <td style="text-align: left;" class="dfv">
                                    <br />
                                    <asp:Literal runat="server" ID="InstructionsStandard" Text="428">	</asp:Literal>
                                    <br />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
                        <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
                        <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
                        <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
                        <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
                        <FASTPORT:PartyAddrRecordControl runat="server" ID="PartyAddrRecordControl">
                            <table class="dv" cellpadding="0" cellspacing="0" border="0">
                                <tr>
                                    <td>
                                        <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                            <tr>
                                                <td style="vertical-align: top;">
                                                    <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="Server">
                                                        <table>
                                                            <tr>
                                                                <td style="vertical-align: top;">
                                                                    <table>
                                                                        <tr>
                                                                            <td>
                                                                                &nbsp;
                                                                            </td>
                                                                            <td>
                                                                            </td>
                                                                            <td>
                                                                            </td>
                                                                            <td>
                                                                            </td>
                                                                            <td>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="panel_header_cust" colspan="2">
                                                                                <asp:Label runat="server" ID="AddressHeaderLabel" Text="Address Info">	</asp:Label>
                                                                            </td>
                                                                            <td class="dfv" style="width: 125px">
                                                                                &nbsp;
                                                                            </td>
                                                                            <td class="panel_header_cust" colspan="2">
                                                                                <asp:Label runat="server" ID="ContactInfoLabel" Text="Contact Info for Terminal/Office">	</asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="fls">
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                            <td class="fls">
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="fls">
                                                                                <asp:Literal runat="server" ID="AddrNameLabel" Text="Office Name (Optional)">	</asp:Literal>
                                                                            </td>
                                                                            <td class="dfv">
                                                                                <span style="white-space: nowrap;">
                                                                                    <asp:TextBox runat="server" ID="AddrName" Columns="40" MaxLength="150" CssClass="field_input"
                                                                                        TabIndex="1" Width="200px"></asp:TextBox>&nbsp;
                                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="AddrNameTextBoxMaxLengthValidator"
                                                                                        ControlToValidate="AddrName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Address Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                            <td class="fls">
                                                                                <asp:Literal runat="server" ID="EmailLabel" Text="Office Email">	</asp:Literal>
                                                                            </td>
                                                                            <td class="dfv">
                                                                                <telerik:RadTextBox ID="EmailTB" runat="server" TabIndex="7">
                                                                                </telerik:RadTextBox>
                                                                                <br />
                                                                                <asp:RegularExpressionValidator ID="emailValidator" runat="server" Display="Dynamic"
                                                                                    ErrorMessage="Please enter valid e-mail." ValidationExpression="^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$"
                                                                                    ControlToValidate="EmailTB">
                                                                                </asp:RegularExpressionValidator>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="fls">
                                                                                <asp:Literal runat="server" ID="AddrLabel" Text="Address">	</asp:Literal>
                                                                            </td>
                                                                            <td class="dfv">
                                                                                <span style="white-space: nowrap;">
                                                                                    <asp:TextBox runat="server" ID="Addr" Columns="40" MaxLength="500" AutoPostBack="False"
                                                                                        CssClass="field_input" TabIndex="2" Width="200px"></asp:TextBox>&nbsp;
                                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="AddrTextBoxMaxLengthValidator"
                                                                                        ControlToValidate="Addr" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Address&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                            <td class="fls">
                                                                                <asp:Literal runat="server" ID="DirectDailLabel" Text="Office Phone">	</asp:Literal>
                                                                            </td>
                                                                            <td class="dfv">
                                                                                <telerik:RadMaskedTextBox ID="PhoneTB" runat="server" Mask="###-###-#### #####" Width="125px"
                                                                                    TabIndex="8">
                                                                                </telerik:RadMaskedTextBox>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="fls">
                                                                            </td>
                                                                            <td class="dfv">
                                                                                <span style="white-space: nowrap;">
                                                                                    <asp:TextBox runat="server" ID="Addr1" Columns="40" MaxLength="500" CssClass="field_input"
                                                                                        TabIndex="3" Width="200px"></asp:TextBox>&nbsp;
                                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="Addr1TextBoxMaxLengthValidator"
                                                                                        ControlToValidate="Addr1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Address 2&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                            <td class="fls">
                                                                                <asp:Literal runat="server" ID="FaxLabel" Text="Office Fax">	</asp:Literal>
                                                                            </td>
                                                                            <td class="dfv">
                                                                                <telerik:RadMaskedTextBox ID="FaxTB" runat="server" Mask="###-###-####" Width="125px"
                                                                                    TabIndex="9">
                                                                                </telerik:RadMaskedTextBox>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="fls">
                                                                            </td>
                                                                            <td class="dfv">
                                                                                <telerik:RadComboBox ID="ZipCombo" runat="server" Width="200px" EmptyMessage="For 'W Chicago, IL,' enter 'W Ch,IL' or 601"
                                                                                    EnableLoadOnDemand="True" OnItemsRequested="s_ZipCombo_ItemsRequested" ShowToggleImage="False"
                                                                                    TabIndex="3">
                                                                                </telerik:RadComboBox>
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="fls">
                                                                            </td>
                                                                            <td class="dfv">
                                                                                <span style="white-space: nowrap;">
                                                                                    <asp:DropDownList runat="server" ID="CountryID" AutoPostBack="True" CssClass="field_input"
                                                                                        onkeypress="dropDownListTypeAhead(this,false)" TabIndex="4">
                                                                                    </asp:DropDownList>
                                                                                    <Selectors:FvLlsHyperLink runat="server" ID="CountryIDFvLlsHyperLink" ControlToUpdate="CountryID"
                                                                                        Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>"
                                                                                        MinListItems="100" Table="v_GeoCountry" Field="V_GeoCountry_.CountryID" DisplayField="%3d+V_GeoCountry.Country"></Selectors:FvLlsHyperLink></span>
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="fls">
                                                                                <asp:Literal runat="server" ID="HeadquartersLabel" Text="Headquarters">	</asp:Literal>
                                                                            </td>
                                                                            <td class="dfv">
                                                                                <asp:CheckBox runat="server" ID="Headquarters" TabIndex="5"></asp:CheckBox>
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="fls">
                                                                                <asp:Literal runat="server" ID="MovedOutLabel" Text="Check if Moved-Out">	</asp:Literal>
                                                                            </td>
                                                                            <td class="dfv">
                                                                                <asp:CheckBox runat="server" ID="MovedOut" TabIndex="6"></asp:CheckBox>
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                            <td class="dfv">
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </telerik:RadAjaxPanel>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div runat="Server" visible="false">
                                                        <table>
                                                            <tr>
                                                                <td>
                                                                    <span style="white-space: nowrap;">
                                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                                            <tr>
                                                                                <td style="padding-right: 5px; vertical-align: top">
                                                                                    <asp:TextBox runat="server" ID="PartyID" Columns="14" MaxLength="14" CssClass="field_input"
                                                                                        minlistitems="Default"></asp:TextBox>
                                                                                </td>
                                                                                <td>
                                                                                    &nbsp;
                                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="PartyIDTextBoxMaxLengthValidator"
                                                                                        ControlToValidate="PartyID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Party&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </span>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td>
                                                                    <span style="white-space: nowrap;">
                                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                                            <tr>
                                                                                <td style="padding-right: 5px; vertical-align: top">
                                                                                    <asp:TextBox runat="server" ID="AddrZipID" Columns="14" MaxLength="14" CssClass="field_input"></asp:TextBox>
                                                                                </td>
                                                                                <td>
                                                                                    &nbsp;
                                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="AddrZipIDTextBoxMaxLengthValidator"
                                                                                        ControlToValidate="AddrZipID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Address ZIP&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </span>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="dfv">
                                                                    <span style="white-space: nowrap;">
                                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                                            <tr>
                                                                                <td style="padding-right: 5px; vertical-align: top">
                                                                                    <asp:TextBox runat="server" ID="Lat" Columns="20" MaxLength="70" CssClass="field_input"></asp:TextBox>
                                                                                </td>
                                                                                <td>
                                                                                    &nbsp;
                                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="LatTextBoxMaxLengthValidator"
                                                                                        ControlToValidate="Lat" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Lat&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </span>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="dfv">
                                                                    <span style="white-space: nowrap;">
                                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                                            <tr>
                                                                                <td style="padding-right: 5px; vertical-align: top">
                                                                                    <asp:TextBox runat="server" ID="Long1" Columns="20" MaxLength="70" CssClass="field_input"></asp:TextBox>
                                                                                </td>
                                                                                <td>
                                                                                    &nbsp;
                                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="Long1TextBoxMaxLengthValidator"
                                                                                        ControlToValidate="Long1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Long&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </span>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="dfv" style="text-align: left;">
                                                                    <span style="white-space: nowrap;">
                                                                        <asp:TextBox runat="server" ID="Email" Columns="40" MaxLength="100" CssClass="field_input"></asp:TextBox>&nbsp;
                                                                        <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="EmailTextBoxMaxLengthValidator"
                                                                            ControlToValidate="Email" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Email&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="dfv" style="text-align: left;">
                                                                    <span style="white-space: nowrap;">
                                                                        <asp:TextBox runat="server" ID="DirectDail" Columns="40" MaxLength="50" CssClass="field_input"></asp:TextBox>&nbsp;
                                                                        <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="DirectDailTextBoxMaxLengthValidator"
                                                                            ControlToValidate="DirectDail" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Direct Dail&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="dfv" style="text-align: left;">
                                                                    <span style="white-space: nowrap;">
                                                                        <asp:TextBox runat="server" ID="Fax" Columns="40" MaxLength="50" CssClass="field_input"></asp:TextBox>&nbsp;
                                                                        <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="FaxTextBoxMaxLengthValidator"
                                                                            ControlToValidate="Fax" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fax&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </FASTPORT:PartyAddrRecordControl>
                        <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
                        <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
                        <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
                        <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
                        <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
                    </td>
                </tr>
                <tr>
                    <td style="width: 850px">
                        <center>
                            <table>
                                <tr>
                                    <td>
                                        <FASTPORT:ThemeButton runat="server" ID="SaveButton" Button-CausesValidation="True"
                                            Button-CommandName="UpdateData" button-redirectargument="UpdateData" Button-TabIndex="10"
                                            Button-Text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>"
                                            Button-ToolTip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>"
                                            postback="True">
                                         </FASTPORT:ThemeButton>
                                    </td>
                                    <td>
                                        <FASTPORT:ThemeButton runat="server" ID="CancelButton" Button-CausesValidation="False"
                                            Button-CommandName="Redirect" Button-TabIndex="11" Button-Text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;FASTPORT&quot;) %>"
                                            Button-ToolTip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;FASTPORT&quot;) %>">
                                        </FASTPORT:ThemeButton>
                                    </td>
                                </tr>
                            </table>
                        </center>
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
