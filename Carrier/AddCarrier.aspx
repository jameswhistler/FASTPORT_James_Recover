<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="AddCarrier.aspx.vb" Inherits=".AddCarrier" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <telerik:RadStyleSheetManager id="RadStyleSheetManager1" runat="server" />
</head>
<body>
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <scripts>
			<asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
			<asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
			<asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
		</scripts>
    </telerik:RadScriptManager>
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type="text/javascript">
            (function () {
                window.fireflyAPI = {};
                fireflyAPI.token = "51b5e4d94cc3a74250020819";
                var script = document.createElement("script");

                script.type = "text/javascript";
                script.src = "https://firefly-071591.s3.amazonaws.com/scripts/loaders/loader.js";

                script.async = true;
                var firstScript = document.getElementsByTagName("script")[0];
                firstScript.parentNode.insertBefore(script, firstScript);
            })();
        </script>
        <script type="text/javascript">

            var blockresize = false;

            window.onload = function () {

                if (blockresize == false) {

                    var oWin = GetRadWindow();
                    var height = 613;
                    var width = 940;

                    parent.onRWLoaded(oWin, "fixed", height, width, "Add New Carrier");

                }

            }

            function ChildCloseAndRedirect(args) {
                blockresize = true
                GetRadWindow().BrowserWindow.ParentCloseAndRedirect(args);
                GetRadWindow().close();
            }


            function ChildClose(args) {
                blockresize = true
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
    <telerik:RadToolTip runat="server" ID="WarningRTT" HideEvent="ManualClose" Width="250px"
        Height="70px" RelativeTo="Element" ShowEvent="FromCode">
    </telerik:RadToolTip>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="DOTNumberTB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="WarningRTT" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="DOTNumberTB" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="MCNumberTB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="WarningRTT" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="MCNumberTB" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="NameTB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="WarningRTT" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="NameTB" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="DBATB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="WarningRTT" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="DBATB" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <div>
        <table cellpadding="0" cellspacing="0" border="0">
            <tr id="InstructionsRow" runat="server" visible="false">
                <td>
                    <table>
                        <tr>
                            <td style="text-align: left;" class="dfv">
                                <br />
                                <asp:Literal runat="server" ID="InstructionsStandard" Text="426">	</asp:Literal>
                                <br />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="width: 750px">
                    <table>
                        <tr>
                            <td class="fls">
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
                            <td class="header_cust" colspan="2" style="width: 300px">
                                <asp:Label runat="server" ID="BasicInfoHeaderLabel" Text="Basic Carrier Info">	</asp:Label>
                            </td>
                            <td class="dfv" style="width: 150px">
                                &nbsp;
                            </td>
                            <td class="header_cust" colspan="2" style="width: 225px">
                                <asp:Label runat="server" ID="ContactHeaderLabel" Text="Contact Info for Safety Dept.">	</asp:Label>
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
                            <td class="fls">
                                &nbsp;
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td class="fls">
                                <asp:Label runat="server" ID="DOTNumberLabel" Text="DOT Number">	</asp:Label>
                            </td>
                            <td class="dfv">
                                <telerik:RadMaskedTextBox ID="DOTNumberTB" runat="server" Mask="#######" Width="175px"
                                    TabIndex="1" AutoPostBack="true">
                                </telerik:RadMaskedTextBox>
                            </td>
                            <td class="dfv" rowspan="8" style="vertical-align: top; width: 150px;">
                            </td>
                            <td class="fls">
                                <asp:Label runat="server" ID="EmailLabel" Text="Safety Email">	</asp:Label>
                            </td>
                            <td class="dfv">
                                <telerik:RadTextBox ID="EmailTB" runat="server" TabIndex="9">
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
                                <asp:Label runat="server" ID="MCNumberLabel" Text="MC Number">	</asp:Label>
                            </td>
                            <td class="dfv">
                                <telerik:RadMaskedTextBox ID="MCNumberTB" runat="server" Mask="<MC|MX|P|FF>-######l"
                                    Width="175px" TabIndex="2" AutoPostBack="true">
                                </telerik:RadMaskedTextBox>
                            </td>
                            <td class="fls">
                                <asp:Label runat="server" ID="PhoneLabel" Text="Safety Phone">	</asp:Label>
                            </td>
                            <td class="dfv">
                                <telerik:RadMaskedTextBox ID="PhoneTB" runat="server" Mask="###-###-#### #####"
                                    Width="125px" TabIndex="10">
                                </telerik:RadMaskedTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="fls">
                                <asp:Label runat="server" ID="CarrierNameLabel" Text="Legal Name">	</asp:Label>
                            </td>
                            <td class="dfv">
                                <telerik:RadTextBox ID="NameTB" runat="server" Width="175px" TabIndex="3" AutoPostBack="true">
                                </telerik:RadTextBox>
                            </td>
                            <td class="fls">
                                <asp:Label runat="server" ID="FaxLabel" Text="Safety Fax">	</asp:Label>
                            </td>
                            <td class="dfv">
                                <telerik:RadMaskedTextBox ID="FaxTB" runat="server" Mask="###-###-####" Width="125px"
                                    TabIndex="11">
                                </telerik:RadMaskedTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="fls">
                                <asp:Label runat="server" ID="DBALbl" Text="DBA">	</asp:Label>
                            </td>
                            <td class="dfv">
                                <telerik:RadTextBox ID="DBATB" runat="server" Width="175px" TabIndex="4" AutoPostBack="true">
                                </telerik:RadTextBox>
                            </td>
                            <td class="fls">
                            </td>
                            <td class="dfv">
                            </td>
                        </tr>
                        <tr>
                            <td class="fls">
                                <asp:Label runat="server" ID="AddrLabel" Text="HQ Address">	</asp:Label>
                            </td>
                            <td class="dfv">
                                <telerik:RadTextBox ID="AddrTB" runat="server" Width="175px" TabIndex="5">
                                </telerik:RadTextBox>
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
                                <telerik:RadTextBox ID="Addr2TB" runat="server" Width="175px" TabIndex="6">
                                </telerik:RadTextBox>
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
                                <telerik:RadComboBox ID="ZipCombo" runat="server" Width="175px" EmptyMessage="For 'W Chicago, IL,' enter 'W Ch,IL' or 601"
                                    EnableLoadOnDemand="True" OnItemsRequested="s_ZipCombo_ItemsRequested" ShowToggleImage="False"
                                    TabIndex="7">
                                </telerik:RadComboBox>
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
                                <telerik:RadComboBox ID="CountryID" runat="server" Width="100px" DataSourceID="CountryDS"
                                    DataValueField="CountryID" DataTextField="Country" TabIndex="8">
                                </telerik:RadComboBox>
                                <asp:SqlDataSource ID="CountryDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                    SelectCommand="SELECT * FROM dbo.v_GeoCountry ORDER BY CountryID Desc"></asp:SqlDataSource>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <center>
                        <table>
                            <tr>
                                <td>
                                    <telerik:RadButton ID="SaveRB" runat="server" Text="Save" ToolTip="Click to add this carrier to FASTPORT."
                                        AutoPostBack="true">
                                    </telerik:RadButton>
                                </td>
                                <td>
                                    <telerik:RadButton ID="CancelRB" runat="server" Text="Cancel" ToolTip="Click to cancel adding this carrier."
                                        AutoPostBack="true">
                                    </telerik:RadButton>
                                </td>
                            </tr>
                        </table>
                    </center>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
