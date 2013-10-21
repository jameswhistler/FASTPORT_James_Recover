<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="SignInFP.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/Security.master" Inherits="FASTPORT.UI.SignInFP" %>

<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<asp:Content ID="Content" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
    </telerik:RadStyleSheetManager>
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type="text/javascript">

            window.onload = function () {

                var MobileRTB = $find("<%=MobileRTB.ClientID %>");
                MobileRTB.set_visible(false);
            }

            function OnEmailClicked(sender, args) {

                var toggleindex = sender.get_selectedToggleStateIndex();
                var EmailRTB = $find("<%=EmailRTB.ClientID %>");
                EmailRTB.set_visible(true);
                var MobileRTB = $find("<%=MobileRTB.ClientID %>");
                MobileRTB.set_visible(false);

            }

            function OnMobilePhoneClicked(sender, args) {

                var toggleindex = sender.get_selectedToggleStateIndex();
                var EmailRTB = $find("<%=EmailRTB.ClientID %>");
                EmailRTB.set_visible(false);
                var MobileRTB = $find("<%=MobileRTB.ClientID %>");
                MobileRTB.set_visible(true);
            }

            function OnKeyPress(sender, args) {

                if (args.get_keyCode() == 13) {

                    $find("<%=OKRadButton.ClientID %>").click();

                }

            }


        </script>
    </telerik:RadCodeBlock>
    <table cellpadding="0" cellspacing="0" border="0" width="1000px;" height="1080px;">
        <tr>
            <td class="panelL">
            </td>
            <td class="dvSecurity" style="vertical-align: top;">
                <asp:Panel ID="SignInCollapsibleRegion" runat="server" DefaultButton="OKRadButton">
                    <table cellpadding="0" cellspacing="0" border="0" style="width: 100%">
                        <tr>
                            <td class="securityForm">
                                <table cellpadding="1" cellspacing="1" border="0">
                                    <tr>
                                        <td style="height: 50px;" colspan="2">
                                        </td>
                                        <td style="height: 50px;">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            Join up here
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="height: 50px;">
                                        </td>
                                        <td style="height: 5px;">
                                        </td>
                                        <td style="height: 5px;">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="flSecurity" colspan="3">
                                            Text goes here explaining why to sign up
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="height: 50px;">
                                        </td>
                                        <td style="height: 5px;">
                                        </td>
                                        <td style="height: 5px;">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="flSecurity" colspan="3">
                                            <telerik:RadButton ID="SignUpRB" runat="server" Text="Sign up" ToolTip="Click to create a Fastport account."
                                                AutoPostBack="true">
                                            </telerik:RadButton>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td class="securityForm">
                                <table cellpadding="1" cellspacing="1" border="0">
                                    <tr>
                                        <td style="height: 50px;" colspan="2">
                                        </td>
                                        <td style="height: 50px;">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            Sign in here
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="height: 50px;">
                                        </td>
                                        <td style="height: 5px;">
                                        </td>
                                        <td style="height: 5px;">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="flSecurity" colspan="3">
                                            You can sign in using either your email address or mobile phone number
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <telerik:RadTextBox ID="EmailRTB" runat="server" Width="167px" TabIndex="1" class="flSecurity">
                                            </telerik:RadTextBox>
                                            <telerik:RadMaskedTextBox ID="MobileRTB" runat="server" Mask="###-###-####" Width="167px"
                                                TabIndex="6" class="flSecurity">
                                            </telerik:RadMaskedTextBox>
                                            <asp:RegularExpressionValidator ID="emailValidator" runat="server" Display="Dynamic"
                                                ErrorMessage="Please enter valid e-mail." ValidationExpression="^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$"
                                                ControlToValidate="EmailRTB" Font-Size="14pt">
                                            </asp:RegularExpressionValidator>
                                        </td>
                                        <td style="text-align: left;">
                                            <telerik:RadButton ID="EmailRadButton" runat="server" ToggleType="Radio" ButtonType="ToggleButton"
                                                Checked="true" Text="Email address" GroupName="StandardButton" AutoPostBack="false"
                                                OnClientClicked="OnEmailClicked" CssClass="flSecurity">
                                            </telerik:RadButton>
                                            <br />
                                            <telerik:RadButton ID="MobileRadButton" runat="server" ToggleType="Radio" Text="Mobile number"
                                                GroupName="StandardButton" ButtonType="ToggleButton" AutoPostBack="false" OnClientClicked="OnMobilePhoneClicked" CssClass="flSecurity">
                                            </telerik:RadButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="flSecurity" colspan="3">
                                            <asp:Label runat="server" ID="PasswordLabel" Text="&lt;%# GetResourceValue(&quot;Txt:Password&quot;, &quot;FASTPORT&quot;) %>">	</asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            <asp:TextBox runat="server" ID="Password" Columns="36" commandname="TextBoxPassword_Command"
                                                CssClass="fiSecurity" TextMode="Password" Visible="False">	</asp:TextBox>
                                            <telerik:RadTextBox ID="PasswordRTB" runat="server" Width="167px" TabIndex="1" class="flSecurity"
                                                TextMode="Password">
                                            </telerik:RadTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="tableCellSelectCheckbox">
                                            <asp:CheckBox runat="server" ID="RememberUserName" commandname="CheckBoxUN_Command"
                                                postback="True"></asp:CheckBox>
                                        </td>
                                        <td class="flSecurity" colspan="2">
                                            Remember user name
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="tableCellSelectCheckbox">
                                            <asp:CheckBox runat="server" ID="RememberPassword" commandname="CheckBoxPass_Command"
                                                postback="True"></asp:CheckBox>
                                        </td>
                                        <td class="flSecurity" colspan="2">
                                            Remember password
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="tableCellSelectCheckbox">
                                            <asp:CheckBox runat="server" ID="AutomaticallySignIn" commandname="CheckBoxAutoLogin_Command"
                                                postback="True"></asp:CheckBox>
                                        </td>
                                        <td class="flSecurity" colspan="2">
                                            Sign in automatically
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="height: 5px;">
                                        </td>
                                        <td style="text-align: center;">
                                        </td>
                                        <td style="text-align: center;">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            <table cellpadding="0" cellspacing="0" border="0" style="padding-top: 10px; padding-bottom: 5px;"
                                                align="center">
                                                <tr>
                                                    <td>
                                                        <telerik:RadButton ID="OKRadButton" runat="server" Text="Sign in" ToolTip="Click to sign into Fastport."
                                                            AutoPostBack="true">
                                                        </telerik:RadButton>
                                                    </td>
                                                    <td>
                                                        <telerik:RadButton ID="CancelRadButton" runat="server" Text="Cancel" ToolTip="Click to cancel."
                                                            AutoPostBack="true">
                                                        </telerik:RadButton>
                                                    </td>
                                                    <td>
                                                        <telerik:RadButton ID="ForgotPasswordRadButton" runat="server" Text="I've forgotten my password"
                                                            ToolTip="Click to receive a password reminder." AutoPostBack="true">
                                                        </telerik:RadButton>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            <asp:Label runat="server" ID="PasswordMessage">	</asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();"
        onmouseover="clearTimeout(gPopupTimer);">
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="false"
        runat="server"></asp:ValidationSummary>
</asp:Content>
