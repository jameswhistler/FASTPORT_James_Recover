<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ForgotUserFP.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/Security.master" Inherits="FASTPORT.UI.ForgotUserFP" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><%@ Register TagPrefix="asp" Namespace="Recaptcha" Assembly="Recaptcha" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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


        </script>
    </telerik:RadCodeBlock>
		
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
<table cellpadding="0" cellspacing="0" border="0" class="dvSecurity"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelL"></td><td class="pcCSecurity"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SendButton")) %><table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td class="securityForm"><table><tr><td style="height: 50px;">&nbsp;</td></tr><tr><td style="padding-bottom: 10px;"><asp:Label runat="server" id="ForgotUserInfoLabel" Text="Retrieve user name and password">	</asp:Label> 
<asp:Label runat="server" id="ForgotUserErrorLabel" visible="False">	</asp:Label></td></tr><tr><td style="height: 50px;">&nbsp;</td></tr><tr><td class="flSecurity"><table><tr><td class="flSecurity" colspan="2"><nobr></nobr><asp:Label runat="server" id="EnterEmailLabel" Text="Enter your email address or mobile number">	</asp:Label> 
<br /><br /></td></tr><tr><td class="flSecurity"><asp:TextBox runat="server" id="Emailaddress" columns="36" visible="False">	</asp:TextBox>
<telerik:RadTextBox ID="EmailRTB" runat="server" Width="167px" TabIndex="1" class="flSecurity">
</telerik:RadTextBox>
<telerik:RadMaskedTextBox ID="MobileRTB" runat="server" Mask="###-###-####" Width="167px" TabIndex="6" class="flSecurity">
</telerik:RadMaskedTextBox>
<asp:RegularExpressionValidator ID="emailValidator" runat="server" Display="Dynamic" ErrorMessage="Please enter valid e-mail." ValidationExpression="^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$" ControlToValidate="EmailRTB" Font-Size="14pt">
</asp:RegularExpressionValidator></td><td class="flSecurity"><telerik:RadButton ID="EmailRadButton" runat="server" ToggleType="Radio" ButtonType="ToggleButton" Checked="true" Text="Email address" GroupName="StandardButton" AutoPostBack="false" OnClientClicked="OnEmailClicked">
                                            </telerik:RadButton>
                                            <br />
                                            <telerik:RadButton ID="MobileRadButton" runat="server" ToggleType="Radio" Text="Mobile number" GroupName="StandardButton" ButtonType="ToggleButton" AutoPostBack="false" OnClientClicked="OnMobilePhoneClicked">
                                            </telerik:RadButton></td></tr></table>
</td></tr><tr><td style="height: 50px;">&nbsp;</td></tr><tr><td class="flSecurity"><asp:Label runat="server" id="FillRecaptchaLabel" Text="&lt;%# GetResourceValue(&quot;Txt:EnterCaptcha&quot;, &quot;FASTPORT&quot;) %>">	</asp:Label> 
<br /><br />
<asp:RecaptchaControl ID="recaptcha" runat="server" theme="clean" PublicKey="6LckPegSAAAAABPJZiTW9LpLIIFtsYJyKIU4Wvor" PrivateKey="6LckPegSAAAAADtngg-CyXAC0qJoyuaSM4MLA1hN" /></td></tr><tr><td style="padding-top:10px;padding-bottom:10px;text-align:center;"><table border="0" cellpadding="0" cellspacin="0" style="width: 100%;"><tr><td style="width: 40%;">&nbsp;</td><td><FASTPORT:ThemeButton runat="server" id="SendButton" button-causesvalidation="True" button-commandname="ResetData" button-text="&lt;%# GetResourceValue(&quot;Btn:Send&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Send&quot;, &quot;FASTPORT&quot;) %>" commandname="EmailLinkButton_Command"></FASTPORT:ThemeButton></td><td style="width: 40%;">&nbsp;</td></tr></table>
</td></tr></table>
</td></tr></table>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SendButton")) %></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table></ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>