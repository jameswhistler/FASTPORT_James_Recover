<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="AddDriverAdmin.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.AddDriverAdmin" %>

<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<asp:Content ID="PageSection" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
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
    </telerik:RadCodeBlock>
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
                <tr>
                    <td>
                        <br />
                        <center>
                            <table>
                                <tr>
                                    <td class="fls">
                                        <asp:Label runat="server" ID="EmailLabel" Text="Email">	</asp:Label>
                                    </td>
                                    <td class="dfv" style="text-align: left;">
                                        <telerik:RadTextBox ID="EmailRTB" runat="server" Width="125px">
                                        </telerik:RadTextBox>
                                        <asp:RegularExpressionValidator ID="emailValidator" runat="server" Display="Dynamic"
                                            ErrorMessage="Please enter valid e-mail." ValidationExpression="^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$"
                                            ControlToValidate="EmailRTB">
                                        </asp:RegularExpressionValidator>
                                        <asp:RequiredFieldValidator ID="emailValidator2" runat="server" Display="Dynamic"
                                            ControlToValidate="EmailRTB" ErrorMessage="An email is required">
                                        </asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        <asp:Label runat="server" ID="PasswordLabel" Text="Password">	</asp:Label>
                                    </td>
                                    <td class="dfv" style="text-align: left;">
                                        <telerik:RadTextBox ID="PasswordRTB" runat="server" Width="125px">
                                        </telerik:RadTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                    </td>
                                    <td class="dfv">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        <asp:Label runat="server" ID="NameLabel" Text="Name">	</asp:Label>
                                    </td>
                                    <td class="dfv" style="text-align: left;">
                                        <telerik:RadTextBox ID="NameRTB" runat="server" Width="125px">
                                        </telerik:RadTextBox>
                                        <asp:RequiredFieldValidator ID="NameValidator" runat="server" Display="Dynamic" ControlToValidate="NameRTB"
                                            ErrorMessage="A name is required">
                                        </asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        <asp:Label runat="server" ID="HandleLabel" Text="Handle">	</asp:Label>
                                    </td>
                                    <td class="dfv" style="text-align: left;">
                                        <telerik:RadTextBox ID="HandleRTB" runat="server" Width="125px">
                                        </telerik:RadTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        <asp:Label runat="server" ID="DirectDialLabel" Text="Landline">	</asp:Label>
                                    </td>
                                    <td class="fls" style="text-align: left;">
                                        <telerik:RadMaskedTextBox ID="DirectDialRadTB" runat="server" Mask="###-###-#### #####"
                                            Width="125px">
                                        </telerik:RadMaskedTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        <asp:Label runat="server" ID="MobileLabel" Text="Mobile">	</asp:Label>
                                    </td>
                                    <td class="fls" style="text-align: left;">
                                        <telerik:RadMaskedTextBox ID="MobileRadTB" runat="server" Mask="###-###-####" Width="125px">
                                        </telerik:RadMaskedTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        <asp:Label runat="server" ID="OtherLabel" Text="Other Number">	</asp:Label>
                                    </td>
                                    <td class="fls" style="text-align: left;">
                                        <telerik:RadMaskedTextBox ID="OtherRadTB" runat="server" Mask="###-###-#### #####"
                                            Width="125px">
                                        </telerik:RadMaskedTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        <asp:Label runat="server" ID="FaxLabel" Text="Fax">	</asp:Label>
                                    </td>
                                    <td class="fls" style="text-align: left;">
                                        <telerik:RadMaskedTextBox ID="FaxRadTB" runat="server" Mask="###-###-####" Width="125px">
                                        </telerik:RadMaskedTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        &nbsp;
                                    </td>
                                    <td class="fls" style="text-align: left;">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        <asp:Label runat="server" ID="CarrierLbl" Text="Carrier">	</asp:Label>
                                    </td>
                                    <td class="fls" style="text-align: left;">
                                        <telerik:RadComboBox ID="CarrierRCB" runat="server" DataSourceID="CarriersDS" DataTextField="Carrier"
                                            DataValueField="PartyID" EmptyMessage="Filter by Carrier" MarkFirstMatch="True"
                                            Width="150px" ShowToggleImage="True" 
                                            HighlightTemplatedItems="True" Filter="Contains" AutoPostBack="true">
                                        </telerik:RadComboBox>
                                        <asp:SqlDataSource ID="CarriersDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                            SelectCommand="usp_CarriersMine" SelectCommandType="StoredProcedure">
                                            <SelectParameters>
                                                <asp:SessionParameter Name="CarrierChildID" SessionField="PartyID" Type="Int32" />
                                            </SelectParameters>
                                        </asp:SqlDataSource>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        <asp:Label runat="server" ID="JobLbl" Text="Job">	</asp:Label>
                                    </td>
                                    <td class="fls" style="text-align: left;">
                                        <telerik:RadComboBox ID="JobRCB" runat="server" DataSourceID="JobsDS" DataTextField="AdName"
                                            DataValueField="AdID"  EmptyMessage="Filter by Job"
                                            MarkFirstMatch="True" Width="150px" ShowToggleImage="True" HighlightTemplatedItems="True"
                                            Filter="Contains">
                                        </telerik:RadComboBox>
                                        <asp:SqlDataSource ID="JobsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                            SelectCommand="usp_AdByCarrier" SelectCommandType="StoredProcedure">
                                            <SelectParameters>
                                                <asp:SessionParameter Name="ChildID" SessionField="PartyID" Type="Int32" />
                                                <asp:ControlParameter ControlID="CarrierRCB" Name="PartyID" PropertyName="SelectedValue"
                                                    Type="Int32" DefaultValue="0" />
                                            </SelectParameters>
                                        </asp:SqlDataSource>
                                    </td>
                                </tr>
                            </table>
                        </center>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <center>
                            <table>
                                <tr>
                                    <td>
                                        <FASTPORT:ThemeButton runat="server" ID="SaveButton" Button-CausesValidation="True"
                                            Button-CommandName="Redirect" Button-Text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>"
                                            Button-ToolTip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>"
                                            postback="True"></FASTPORT:ThemeButton>
                                    </td>
                                    <td>
                                        <FASTPORT:ThemeButton runat="server" ID="CancelButton" Button-CausesValidation="False"
                                            Button-CommandName="Redirect" Button-Text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;FASTPORT&quot;) %>"
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
