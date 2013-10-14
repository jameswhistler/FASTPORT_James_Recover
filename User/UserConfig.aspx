<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="UserConfig.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.UserConfig" %>

<%@ Register TagPrefix="FASTPORT" Namespace="FASTPORT.UI.Controls.UserConfig" Assembly="FASTPORT" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<asp:Content ID="PageSection" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
    <style type="text/css">
        .RadListBox
        {
            margin: 0 auto !important;
        }
    </style>
    <telerik:RadScriptBlock ID="RadScriptBlock1" runat="server">
        <script type="text/javascript">
        function SendCallBack(arg, myAction) {

                    try {
                        switch (myAction) {
                        case "onPersonClick":
                            { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onPersonClick", "null") %>
                                break;
                            }               
                        }
                    } catch (e) {}
                }

        function onPersonClick(sender, arg) {

                        alert("Click");
                        var attributes = sender.get_attributes();
                        alert(attributes);
                        var PersonID = attributes.getAttribute("PersonID");
                        alert(PersonID);

                        SendCallBack("onPersonClick," + arg, "onPersonClick");

                    }

        function OnClientItemCheckedHandler(sender, eventArgs) {
            var item = eventArgs.get_item();
            item.set_selected(item.get_checked());
        }


        function onPersonClick_Back(arg) {

                        alert("Im back");
                    }
        </script>
    </telerik:RadScriptBlock>
    <table cellpadding="0" cellspacing="0" border="0" style="width: 100%">
        <tr>
            <td>
                <FASTPORT:PartyRecordControl runat="server" ID="PartyRecordControl">
                    <table class="dv" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                            <td>
                                <asp:Panel ID="PartyRecordControlCollapsibleRegion" runat="server">
                                    <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                        <tr>
                                            <td>
                                                <asp:Panel ID="PartyRecordControlPanel" runat="server">
                                                    <table cellpadding="0" cellspacing="0" border="0">
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Literal runat="server" ID="PasswordLabel" Text="Password">	</asp:Literal>
                                                            </td>
                                                            <td class="dfv">
                                                                <span style="white-space: nowrap;">
                                                                    <asp:TextBox runat="server" ID="Password" Columns="40" MaxLength="50" CssClass="field_input"
                                                                        TextMode="Password" Visible="False"></asp:TextBox>&nbsp;
                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="PasswordTextBoxMaxLengthValidator"
                                                                        ControlToValidate="Password" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Password&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                <telerik:RadTextBox ID="PasswordRTB" runat="server" Width="167px" TabIndex="1" class="flSecurity"
                                                                    TextMode="Password">
                                                                </telerik:RadTextBox>
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                &nbsp;
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
                                                                <asp:Literal runat="server" ID="NameLabel" Text="Name">	</asp:Literal>
                                                            </td>
                                                            <td class="dfv">
                                                                <span style="white-space: nowrap;">
                                                                    <asp:TextBox runat="server" ID="Name" MaxLength="1000" Columns="120" CssClass="field_input"
                                                                        Rows="6" TextMode="MultiLine" Visible="False"></asp:TextBox>&nbsp;
                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="NameTextBoxMaxLengthValidator"
                                                                        ControlToValidate="Name" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                <telerik:RadTextBox ID="NameRTB" runat="server" Width="167px" TabIndex="2">
                                                                </telerik:RadTextBox>
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Literal runat="server" ID="EmailLabel" Text="Email">	</asp:Literal>
                                                            </td>
                                                            <td class="dfv">
                                                                <span style="white-space: nowrap;">
                                                                    <asp:TextBox runat="server" ID="Email" Columns="40" MaxLength="100" CssClass="field_input"
                                                                        Visible="False"></asp:TextBox>&nbsp;
                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="EmailTextBoxMaxLengthValidator"
                                                                        ControlToValidate="Email" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Email&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                <telerik:RadTextBox ID="EmailRTB" runat="server" Width="167px" TabIndex="1">
                                                                </telerik:RadTextBox>
                                                                <asp:RegularExpressionValidator ID="emailValidator" runat="server" Display="Dynamic"
                                                                    ErrorMessage="Please enter valid e-mail." ValidationExpression="^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$"
                                                                    ControlToValidate="EmailRTB">
                                                                </asp:RegularExpressionValidator>
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Literal runat="server" ID="MobileLabel" Text="Mobile">	</asp:Literal>
                                                            </td>
                                                            <td class="dfv">
                                                                <span style="white-space: nowrap;">
                                                                    <asp:TextBox runat="server" ID="Mobile" Columns="40" MaxLength="50" CssClass="field_input"
                                                                        Visible="False"></asp:TextBox>&nbsp;
                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="MobileTextBoxMaxLengthValidator"
                                                                        ControlToValidate="Mobile" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Mobile&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                <telerik:RadMaskedTextBox ID="MobileRTB" runat="server" Mask="###-###-####" Width="167px"
                                                                    TabIndex="6">
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Literal runat="server" ID="DirectDialLabel" Text="Direct Dial">	</asp:Literal>
                                                            </td>
                                                            <td class="dfv">
                                                                <span style="white-space: nowrap;">
                                                                    <asp:TextBox runat="server" ID="DirectDial" Columns="40" MaxLength="50" CssClass="field_input"
                                                                        Visible="False"></asp:TextBox>&nbsp;
                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="DirectDialTextBoxMaxLengthValidator"
                                                                        ControlToValidate="DirectDial" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Direct Dial&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                <telerik:RadMaskedTextBox ID="DirectDialRTB" runat="server" Mask="###-###-#### #####"
                                                                    Width="167px" TabIndex="5">
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Literal runat="server" ID="FaxLabel" Text="Fax">	</asp:Literal>
                                                            </td>
                                                            <td class="dfv">
                                                                <span style="white-space: nowrap;">
                                                                    <asp:TextBox runat="server" ID="Fax" Columns="40" MaxLength="50" CssClass="field_input"
                                                                        Visible="False"></asp:TextBox>&nbsp;
                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="FaxTextBoxMaxLengthValidator"
                                                                        ControlToValidate="Fax" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fax&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                <telerik:RadMaskedTextBox ID="FaxRTB" runat="server" Mask="###-###-####" Width="167px"
                                                                    TabIndex="8">
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                &nbsp;
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </asp:Panel>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                    </table>
                </FASTPORT:PartyRecordControl>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="PaymentMethodRadGrid" runat="server" AutoGenerateColumns="False"
                    CellSpacing="0" DataSourceID="PaymentMethodDS" GridLines="None" ShowHeader="True"
                    CssClass="RemoveBorders" OnItemCommand="PaymentMethodRadGrid_ItemCommand" OnSelectedIndexChanged="PaymentMethodRadGrid_SelectedIndexChanged">
                    <ClientSettings EnableRowHoverStyle="True" EnablePostBackOnRowClick="True">
                    </ClientSettings>
                    <MasterTableView DataKeyNames="PaymentMethodID, PaymentMethodType" DataSourceID="PaymentMethodDS"
                        Name="PaymentMethodTable">
                        <NoRecordsTemplate>
                            <div style="padding: 25px;">
                                No credit cards or bank accounts entered yet. Please click the "Add Payment Method"
                                button above.
                            </div>
                        </NoRecordsTemplate>
                        <Columns>
                            <telerik:GridBoundColumn DataField="PaymentMethodHTML" HeaderStyle-Width="190px"
                                HeaderText="Card / Account" UniqueName="PaymentMethodHTML">
                                <HeaderStyle Width="190px" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="PreferredHTML" HeaderStyle-Width="190px" HeaderText="Preferred"
                                UniqueName="PreferredHTML">
                                <HeaderStyle Width="20px" />
                            </telerik:GridBoundColumn>
                            <telerik:GridTemplateColumn UniqueName="PaymentMethodDeleteCol">
                                <ItemTemplate>
                                    <asp:ImageButton ID="PaymentMethodDeleteIB" runat="server" ImageUrl="/Images/Custom/XOut_Small.png" />
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                        </Columns>
                        <PagerStyle PageSizeControlType="RadComboBox" />
                    </MasterTableView>
                    <PagerStyle PageSizeControlType="RadComboBox" />
                </telerik:RadGrid>
                <asp:SqlDataSource ID="PaymentMethodDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                    SelectCommand="SELECT * FROM [v_PaymentMethod] WHERE [PartyID] = @PaymentMethodPartyID">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="PaymentMethodPartyID" PropertyName="Text"
                            Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <table class="dv" cellpadding="0" cellspacing="0" border="0">
                    <tr>
                        <td>
                            <asp:Panel ID="CreditCardPanel" runat="server">
                                <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                    <tr>
                                        <td>
                                            <asp:Panel runat="server">
                                                <table cellpadding="0" cellspacing="0" border="0">
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="CreditCardTypeLabel" Text="Credit Card Type">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv">
                                                            <asp:SqlDataSource ID="CreditCardTypeDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                SelectCommand="SELECT * FROM [List] WHERE ListType = 'Credit Card'"></asp:SqlDataSource>
                                                            <telerik:RadDropDownList ID="CreditCardTypeRDDL" runat="server" DataTextField="ListName"
                                                                DataValueField="ListID" DataSourceID="CreditCardTypeDS">
                                                            </telerik:RadDropDownList>
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="CreditCardNumberLabel" Text="Credit Card #">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv">
                                                            <telerik:RadTextBox ID="CreditCardNumberRTB" runat="server" Width="167px" TabIndex="1"
                                                                class="flSecurity">
                                                            </telerik:RadTextBox>
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="CreditCardNameLabel" Text="Name On Card">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv">
                                                            <telerik:RadTextBox ID="CreditCardNameRTB" runat="server" Width="167px" TabIndex="1"
                                                                class="flSecurity">
                                                            </telerik:RadTextBox>
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="StartDateLabel" Text="Start Date">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv">
                                                            <telerik:RadMaskedTextBox ID="StartDateRTB" Mask="##/##" runat="server" Width="50px"
                                                                TabIndex="1" class="flSecurity">
                                                            </telerik:RadMaskedTextBox>
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="EndDateLabel" Text="End Date">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv">
                                                            <telerik:RadMaskedTextBox ID="EndDateRTB" Mask="##/##" runat="server" Width="50px"
                                                                TabIndex="1" class="flSecurity">
                                                            </telerik:RadMaskedTextBox>
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="CVVLabel" Text="CCV">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv">
                                                            <telerik:RadTextBox ID="CVVRTB" runat="server" Width="50px" TabIndex="1" class="flSecurity">
                                                            </telerik:RadTextBox>
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="BankAccountPanel" runat="server">
                                <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                    <tr>
                                        <td>
                                            <asp:Panel ID="Panel3" runat="server">
                                                <table cellpadding="0" cellspacing="0" border="0">
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="BankAccountNumberLabel" Text="Bank Account Number">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv">
                                                            <telerik:RadTextBox ID="BankAccountNumberRTB" runat="server" Width="167px" TabIndex="1"
                                                                class="flSecurity">
                                                            </telerik:RadTextBox>
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="BankSortCodeLabel" Text="Sort Code">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv">
                                                            <telerik:RadTextBox ID="BankSortCodeRTB" runat="server" Width="167px" TabIndex="1"
                                                                class="flSecurity">
                                                            </telerik:RadTextBox>
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="BankAccountNameLabel" Text="Account Name">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv">
                                                            <telerik:RadTextBox ID="BankAccountNameRTB" runat="server" Width="167px" TabIndex="1"
                                                                class="flSecurity">
                                                            </telerik:RadTextBox>
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="fls">
                                                            <asp:Literal runat="server" ID="BankPaymentReferenceLabel" Text="Payment Reference">	</asp:Literal>
                                                        </td>
                                                        <td class="dfv">
                                                            <telerik:RadTextBox ID="BankPaymentReferenceRTB" runat="server" Width="167px" TabIndex="1"
                                                                class="flSecurity">
                                                            </telerik:RadTextBox>
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                        <td class="dfv">
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="CompanyPanel" runat="server">
                                <div class="list-panel">
                                    <telerik:RadGrid ID="CompanyRG" runat="server" AutoGenerateColumns="False" CellSpacing="0"
                                        DataSourceID="CompanyDS" GridLines="None" ShowHeader="False" CssClass="RemoveBorders"
                                        OnItemCommand="CompanyRG_ItemCommand">
                                        <ClientSettings EnableRowHoverStyle="True" EnablePostBackOnRowClick="True">
                                        </ClientSettings>
                                        <MasterTableView DataKeyNames="PartyID" DataSourceID="CompanyDS" Name="PaymentMethodTable">
                                            <NoRecordsTemplate>
                                                <div style="padding: 25px;">
                                                    No companies are associated with your user account.
                                                </div>
                                            </NoRecordsTemplate>
                                            <Columns>
                                                <telerik:GridBoundColumn DataField="PartyHTML" HeaderStyle-Width="190px" UniqueName="PartyHTML">
                                                    <HeaderStyle Width="190px" />
                                                </telerik:GridBoundColumn>
                                            </Columns>
                                            <PagerStyle PageSizeControlType="RadComboBox" />
                                        </MasterTableView>
                                        <PagerStyle PageSizeControlType="RadComboBox" />
                                    </telerik:RadGrid>
                                    <asp:SqlDataSource ID="CompanyDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                        SelectCommand="usp_PaymentMethod_Companies" SelectCommandType="StoredProcedure">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="MeID" PropertyName="Text"
                                                Type="Int32" />
                                            <asp:ControlParameter ControlID="HiddenTB_PaymentMethodID" Name="PaymentMethodID"
                                                PropertyName="Text" Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                </div>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="PeoplePanel" runat="server">
                                <div class="list-panel">
                                    <telerik:RadListBox ID="PeopleRLB" runat="server" CheckBoxes="true" Width="220px"
                                        Height="300px" DataSourceID="PeopleDS" DataKeyField="PersonID" DataTextField="PersonRoleHTML"
                                        OnItemDataBound="PeopleRLB_ItemDataBound" OnClientItemChecked="onPersonClick">
                                        <ItemTemplate>
                                            <div>
                                                <span style="display: inline" id="PersonHTML">
                                                    <%# DataBinder.Eval(Container.DataItem, "PersonRoleHTML")%>
                                                </span>
                                            </div>
                                            <div>
                                                <span style="display: none" id="PersonID">
                                                    <%# DataBinder.Eval(Container.DataItem, "PersonID")%>
                                                </span>
                                            </div>
                                            <div>
                                                <span style="display: none" id="RoleID">
                                                    <%# DataBinder.Eval(Container.DataItem, "RoleID")%>
                                                </span>
                                            </div>
                                        </ItemTemplate>
                                    </telerik:RadListBox>
                                    <asp:SqlDataSource ID="PeopleDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                        SelectCommand="usp_PaymentMethod_AvailTo" SelectCommandType="StoredProcedure">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="MeID" PropertyName="Text"
                                                Type="Int32" />
                                            <asp:ControlParameter ControlID="HiddenTB_PaymentMethodID" Name="PaymentMethodID"
                                                PropertyName="Text" Type="String" />
                                            <asp:ControlParameter ControlID="HiddenTB_PeopleParentID" Name="PeopleParentID" PropertyName="Text"
                                                Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                </div>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <div id="HiddenDiv" style="display: none;">
                    PartyID:
                    <asp:TextBox ID="HiddenTB_PartyID" runat="server"></asp:TextBox><br />
                    PeopleParentID:
                    <asp:TextBox ID="HiddenTB_PeopleParentID" runat="server"></asp:TextBox><br />
                    PaymentMethodID:
                    <asp:TextBox ID="HiddenTB_PaymentMethodID" runat="server"></asp:TextBox><br />
                </div>
            </td>
        </tr>
    </table>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();"
        onmouseover="clearTimeout(gPopupTimer);">
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="false"
        runat="server"></asp:ValidationSummary>
</asp:Content>
