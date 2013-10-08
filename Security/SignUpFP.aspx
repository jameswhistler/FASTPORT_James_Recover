<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="SignUpFP.aspx.vb" Inherits=".SignUpFP" %>

<%@ Register TagPrefix="FASTPORT" TagName="MarketingMenu" Src="../Menu Panels/MarketingMenu.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FASTPORT > Sign-Up</title>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server" />
</head>
<body>
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
        </Scripts>
    </telerik:RadScriptManager>
    <style type="text/css">
        .RadPanelBar .rpSlide
        {
            height: auto !important;
        }
    </style>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadAjaxManager1" />
                    <telerik:AjaxUpdatedControl ControlID="PickCarrierRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="TruckerRadButton">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="SignUpRTT" />
                    <telerik:AjaxUpdatedControl ControlID="TruckerRadButton" />
                    <telerik:AjaxUpdatedControl ControlID="TruckerRPB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="CarrierRadButton">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="CarrierRadButton" />
                    <telerik:AjaxUpdatedControl ControlID="TruckerRPB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="CarrierEditRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="CarrierEditRB" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_CarrierDataStatus" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="CarrierZipRCB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="CarrierZipRCB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="BlackMetroTouch">
    </telerik:RadAjaxLoadingPanel>
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type="text/javascript">

            var block_OnChangedEvents = true;

            window.onload = function InitialisePage() {
                var MobileRTB = $find("<%=MobileRTB.ClientID %>");
                MobileRTB.set_visible(false);
            }

            function onRTThide(sender, args) {
                sender.set_targetControlID("");
            }

            function ActivateContactRadPanel() {
                var TruckerRPB = $find("<%=TruckerRPB.ClientID %>");
                var UserRP = TruckerRPB.findItemByText("Username and password");
                var ContactRP = TruckerRPB.findItemByText("Contact information");
                ContactRP.set_enabled(true);
                ContactRP.expand();
                UserRP.set_enabled(false);

            }

            function ExpandCarrierRadPanel() {
                var TruckerRPB = $find("<%=TruckerRPB.ClientID %>");
                var CarrierRP = TruckerRPB.findItemByText("Carrier information");
                CarrierRP.expand;
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

            function onCarrierAddClicked() {

                set_carriervalues("0");
                document.getElementById("<%= HiddenTB_CarrierDataStatus.ClientID %>").value = "Add";
                set_carriervalues_disable("no", "1");
                //v_employer("1", "0", "1");
                var carriereditrb = $find("<%=CarrierEditRB.ClientID %>");
                carriereditrb.set_text("Add");
            }

            function set_carriervalues_disable(disableyesno, positiontype) {

                if (disableyesno == "yes" && positiontype == "1") {

                    $find("<%=CarrierNameRTB.ClientID%>").disable();
                    $find("<%=CarrierAddrRTB.ClientID%>").disable();
                    $find("<%=CarrierZipRCB.ClientID%>").disable();
                    $find("<%=CarrierCountryRCB.ClientID%>").disable();
                    $find("<%=CarrierCountryRCB.ClientID%>").disable();
                    $find("<%=CarrierEmailRTB.ClientID%>").disable();
                    $find("<%=CarrierPhoneRTB.ClientID%>").disable();
                    $find("<%=CarrierFaxRTB.ClientID%>").disable();
                    $find("<%=ContactRTB.ClientID%>").disable();
                    $find("<%=DOTNumberRTB.ClientID%>").disable();
                    $find("<%=MCNumberRTB.ClientID%>").disable();

                } else {

                    $find("<%=CarrierNameRTB.ClientID%>").enable();
                    $find("<%=CarrierAddrRTB.ClientID%>").enable();
                    $find("<%=CarrierZipRCB.ClientID%>").enable();
                    $find("<%=CarrierCountryRCB.ClientID%>").enable();
                    $find("<%=CarrierCountryRCB.ClientID%>").enable();
                    $find("<%=CarrierEmailRTB.ClientID%>").enable();
                    $find("<%=CarrierPhoneRTB.ClientID%>").enable();
                    $find("<%=CarrierFaxRTB.ClientID%>").enable();
                    $find("<%=ContactRTB.ClientID%>").enable();
                    $find("<%=DOTNumberRTB.ClientID%>").enable();
                    $find("<%=MCNumberRTB.ClientID%>").enable();
                }

            }

            function set_carriervalues(carrierid) {

                var HiddenTB_CarrierID = document.getElementById("<%= HiddenTB_CarrierID.ClientID %>");

                if (carrierid != "0") {
                    HiddenTB_CarrierID.value = carrierid;
                    SendCallBack("CarrierValues," + carrierid, "CarrierValues");
                } else {
                    HiddenTB_CarrierID.value = "0";
                    $find("<%=CarrierNameRTB.ClientID%>").set_value("");
                    $find("<%=CarrierAddrRTB.ClientID%>").set_value("");
                    var CarrierZipRCB = $find("<%=CarrierZipRCB.ClientID%>");
                    CarrierZipRCB.set_value("");
                    CarrierZipRCB.set_text("");
                    var CarrierCountryRCB = $find("<%=CarrierCountryRCB.ClientID%>")
                    itemselectRCB(CarrierCountryRCB, "3");
                    $find("<%=CarrierEmailRTB.ClientID%>").set_value("");
                    $find("<%=CarrierPhoneRTB.ClientID%>").set_value("");
                    $find("<%=CarrierFaxRTB.ClientID%>").set_value("");
                    $find("<%=ContactRTB.ClientID%>").set_value("");
                    $find("<%=DOTNumberRTB.ClientID%>").set_value("");
                    $find("<%=MCNumberRTB.ClientID%>").set_value("");
                    document.getElementById("<%= HiddenTB_CarrierDataStatus.ClientID %>").value = "0";
                }

            }

            function onPickCarrierSelected(sender, args) {

                $find("<%= RadiusRTT.ClientID %>").hide();

                var carrierid = args.getDataKeyValue("PartyID");
                document.getElementById("<%= HiddenTB_CarrierID.ClientID %>").value = carrierid;

                set_carriervalues(carrierid);
                document.getElementById("<%= HiddenTB_CarrierDataStatus.ClientID %>").value = "Selected";

                set_carriervalues_disable("yes", positiontype);

            }

            function searchRadiusRB() {

                var radius = $find("<%= RadiusRCB.ClientID %>").get_selectedItem().get_value();
                document.getElementById("<%= HiddenTB_SearchRadius.ClientID %>").value = radius;

                var cityid

                try {
                    cityid = $find("<%= CityRCB.ClientID %>").get_selectedItem().get_value();
                } catch (err) {
                    cityid = "0";
                }

                document.getElementById("<%= HiddenTB_SearchCityID.ClientID %>").value = cityid;

                var searchtext = $find("<%= PickCarrierRSB.ClientID %>").get_text();

                if (searchtext == "" || searchtext == null) {
                    searchtext = "0"
                }
                document.getElementById("<%= HiddenTB_SearchFree.ClientID %>").value = searchtext;

                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindPickCarrierRG");

            }

            function onCarrierSearchButtonCommand(sender, args) {

                var theCommandButton;
                var commandname = args.get_commandName()

                if (commandname == "CarrierAdd") {
                    onCarrierAddClicked();
                } else if (commandname == "RadiusSearch") {
                    theCommandButton = sender.get_buttons().getButton(1);
                    var RadiusRTT = $find("<%= RadiusRTT.ClientID %>");
                    RadiusRTT.set_targetControl(theCommandButton.get_element());
                    setTimeout(function () {
                        RadiusRTT.show();
                    }, 20);
                }

            }

            function onCarrierSearch(sender, eventArgs) {

                var searchid = eventArgs.get_value();
                var searchtext = eventArgs.get_text();

                if (searchid == null || searchid == "") {
                    searchid = "0"
                }

                if (searchtext == null || searchtext == "") {
                    searchtext = "0"
                }

                document.getElementById("<%= HiddenTB_SearchPartyID.ClientID %>").value = searchid;
                document.getElementById("<%= HiddenTB_SearchFree.ClientID %>").value = searchtext;

                sender.clear();

                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindPickCarrierRG");

            }

            function onCarrierEditClicked(sender, args) {

                var EditWarningRTT = $find("<%=EditWarningRTT.ClientID %>");
                var EditCurrentJobWarningRTT = $find("<%=EditCurrentJobWarningRTT.ClientID %>");

                var button = sender;
                var buttontext = sender.get_text();
                var carrierdatastatus = document.getElementById("<%= HiddenTB_CarrierDataStatus.ClientID %>");

                if (buttontext == "Edit") {

                    var carriername = document.getElementById("<%=CarrierNameRTB.ClientID%>").value;
                    if (carriername == null) {
                        carriername = "Carrier"
                    }
                    if (carrierdatastatus.value != "Add") {
                        carrierdatastatus.value = "Edit"
                    }
                    document.getElementById("JobRW_C_CarrierInfoLbl").innerHTML = '<font color="red">Editing</font> ' + carriername;

                    var myMessage = 'You are currently <font color="red">editing</font> ' + carriername + ', click the "X" above to cancel your changes.';

                    sender.set_text("Save");
                    set_carriervalues_disable("no", "1");

                } else {

                    sender.set_text("Edit");
                    document.getElementById("JobRW_C_CarrierInfoLbl").innerHTML = "Carrier Info";
                    if (carrierdatastatus.value != "Add") {
                        carrierdatastatus.value = "Selected";
                    }
                    EditCurrentJobWarningRTT.hide();
                    EditWarningRTT.hide();
                    get_LatLong();
                    set_carriervalues_disable("yes", "1");

                }

            }

            function onCarrierDelClicked() {

                var carrierid = document.getElementById("<%= HiddenTB_CarrierID.ClientID %>").value;
                var carrierdatastatus = document.getElementById("<%= HiddenTB_CarrierDataStatus.ClientID %>").value;

                if (carrierdatastatus == "Edit") {

                    var EditWarningRTT = $find("<%=EditWarningRTT.ClientID %>");
                    var EditCurrentJobWarningRTT = $find("<%=EditCurrentJobWarningRTT.ClientID %>");

                    SendCallBack("CarrierValues," + carrierid, "CarrierValues");
                    set_carriervalues_disable("yes", "1");
                    $find("<%=CarrierEditRB.ClientID %>").set_text("Edit");
                    document.getElementById("<%=CarrierInfoLbl.ClientID %>").innerHTML = "Carrier Info";
                    EditWarningRTT.hide();
                    EditCurrentJobWarningRTT.hide();
                    document.getElementById("HiddenTB_CarrierDataStatus").value = "Selected";

                } else {

                    confirmCall("CarrierDel", carrierid, "Remove Carrier");

                }

            }

            function onMCNumberChanged(sender, args) {

                if (block_OnChangedEvents == false && sender.get_value().length >= 5) {

                    var employerid = document.getElementById("<%= HiddenTB_CarrierID.ClientID %>").value
                    var mcnumber = sender.get_value();
                    SendCallBack("MCNumberDup," + mcnumber + "," + employerid, "MCNumberDup");
                }
            }

            function onMCNumberChanged_back(arg) {

                var myString = arg;
                var mySplit = myString.split("<|>", 2);

                var myReturn = mySplit[0] || "";
                var myWarning = mySplit[1] || "";

                if (myReturn == "Yes") {

                    var tooltip = $find("<%=MCDupRTT.ClientID %>");
                    tooltip.set_content(myWarning);
                    tooltip.show();
                }
            }

            function onDOTNumberChanged(sender, args) {

                if (block_OnChangedEvents == false) {

                    var employerid = document.getElementById("<%= HiddenTB_CarrierID.ClientID %>").value
                    var dotnumber = sender.get_value();
                    SendCallBack("DOTNumberDup," + dotnumber + "," + employerid, "DOTNumberDup")

                }
            }

            function onDOTNumberChanged_back(arg) {

                var myString = arg;
                var mySplit = myString.split("<|>", 2);

                var myReturn = mySplit[0] || "";
                var myWarning = mySplit[1] || "";

                if (myReturn == "Yes") {

                    var tooltip = $find("<%=DOTDupRTT.ClientID %>");
                    tooltip.set_content(myWarning);
                    tooltip.show();

                    var dotnumber = $find("<%= DOTNumberRTB.ClientID %>");
                    dotnumber.set_value("");
                }
            }

            function hideAllRTT() {

                $find("<%=EditWarningRTT.ClientID %>").hide();
                $find("<%=EditCurrentJobWarningRTT.ClientID %>").hide();
                $find("<%=SaveWarningRTT.ClientID %>").hide();
                $find("<%=RadiusRTT.ClientID %>").hide();
                $find("<%=SignUpRTT.ClientID %>").hide();

            }

            function itemaddRCB(combo, value, text, clearyesno) {

                if (clearyesno == "yes") {
                    combo.get_items().clear();
                }

                var comboItem = new Telerik.Web.UI.RadComboBoxItem();
                comboItem.set_value(value);
                comboItem.set_text(text);
                combo.trackChanges();
                combo.get_items().add(comboItem);
                combo.commitChanges();

            }

            function itemselectRCB(combo, value) {

                var item = combo.findItemByValue(value);
                if (item) {
                    item.select();
                }

            }

            function clearsearchvalues(fromRWyesno) {

                document.getElementById("<%= HiddenTB_SearchPartyID.ClientID %>").value = "0";
                document.getElementById("<%= HiddenTB_SearchFree.ClientID %>").value = "0";
                document.getElementById("<%= HiddenTB_SearchRadius.ClientID %>").value = "0";
                document.getElementById("<%= HiddenTB_SearchCityID.ClientID %>").value = "0";
                var PickCarrierRSB = $find("<%= PickCarrierRSB.ClientID %>");
                PickCarrierRSB.get_inputElement().value = "";
                var CityRCB = $find("<%=CityRCB.ClientID%>");
                CityRCB.get_items().clear();
                CityRCB.set_value("");
                CityRCB.set_text("");

                if (fromRWyesno == "yes") {

                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindPickCarrierRG");

                }

            }

        </script>
    </telerik:RadCodeBlock>
    <telerik:RadToolTip runat="server" ID="SignUpRTT" HideEvent="ManualClose" RelativeTo="Element"
        Position="MiddleRight" Width="375px" Skin="BlackMetroTouch" OnClientHide="onRTThide">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="RadiusRTT" HideEvent="ManualClose" RelativeTo="Element"
        Position="TopCenter" Skin="BlackMetroTouch">
        <table>
            <tbody>
                <tr>
                    <td class="fls">
                        <asp:Label runat="server" ID="RadiusLbl" Text="Radius" Visible="True"></asp:Label>
                    </td>
                    <td class="dfv">
                        <telerik:RadComboBox ID="RadiusRCB" runat="server" Width="100px" ZIndex="50001">
                            <Items>
                                <telerik:RadComboBoxItem runat="server" Text="5 Miles" Value="5" />
                                <telerik:RadComboBoxItem runat="server" Text="10 Miles" Value="10" />
                                <telerik:RadComboBoxItem runat="server" Text="25 Miles" Value="25" />
                                <telerik:RadComboBoxItem runat="server" Text="50 Miles" Value="50" />
                            </Items>
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td class="fls">
                        <asp:Label runat="server" ID="ByCityLbl" Text="From"></asp:Label>
                    </td>
                    <td class="dfv">
                        <telerik:RadComboBox ID="CityRCB" runat="server" Width="150px" EmptyMessage="Type City, ST"
                            EnableLoadOnDemand="True" OnItemsRequested="s_CityRCB_ItemsRequested" ZIndex="50001">
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td class="fls">
                    </td>
                    <td class="dfv">
                        <telerik:RadComboBox ID="SearchCountryRCB" runat="server" Width="100px" ZIndex="50001">
                            <Items>
                                <telerik:RadComboBoxItem runat="server" Text="United States" Value="3" />
                                <telerik:RadComboBoxItem runat="server" Text="Canada" Value="2" />
                                <telerik:RadComboBoxItem runat="server" Text="Mexico" Value="1" />
                            </Items>
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <telerik:RadButton ID="RadiusRB" runat="server" Text="Search by Radius" ToolTip="Click to search carriers from the radius and city shown above."
                            AutoPostBack="false" OnClientClicked="searchRadiusRB">
                        </telerik:RadButton>
                    </td>
                </tr>
            </tbody>
        </table>
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="EditWarningRTT" HideEvent="ManualClose" RelativeTo="Mouse"
        Width="240px" Skin="Default" Position="Center" BackColor="White" OffsetX="180"
        OffsetY="20" BorderStyle="None" ForeColor="White">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="EditCurrentJobWarningRTT" HideEvent="ManualClose"
        RelativeTo="Mouse" Width="240px" Skin="Default" Position="Center" BackColor="White"
        OffsetX="180" OffsetY="-30" BorderStyle="None" ForeColor="White">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="SaveWarningRTT" HideEvent="ManualClose" RelativeTo="Element"
        Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode" Position="BottomCenter">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="DOTDupRTT" HideEvent="ManualClose" RelativeTo="Element"
        Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode" Position="TopLeft">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="MCDupRTT" HideEvent="ManualClose" RelativeTo="Element"
        Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode" Position="TopLeft">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="CarrierWarningRTT" HideEvent="ManualClose"
        RelativeTo="Element" Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode"
        Position="BottomLeft">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="PickCarrierWarningRTT" HideEvent="ManualClose"
        RelativeTo="Element" Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode"
        Position="BottomLeft">
    </telerik:RadToolTip>
    <div>
        <table cellpadding="0" cellspacing="0" border="0" class="pWrapper">
            <tr>
                <td colspan="3">
                    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%;">
                        <tr>
                            <td class="pageTL">
                                <img src="../Images/space.gif" class="pageTLSpace" alt="" />
                            </td>
                            <td class="pageT">
                                <img src="../Images/space.gif" class="pageTSpace" alt="" />
                            </td>
                            <td class="pageTR">
                                <img src="../Images/space.gif" class="pageTRSpace" alt="" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="3" class="pcmLSecurity">
                    <table>
                        <tr>
                            <td width="155px" align="Right">
                                <asp:Image ID="LogoImage1" runat="server" ImageUrl="../Images/Custom/FPWhiteLogo.png">
                                </asp:Image>
                            </td>
                            <td>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="pageL">
                    <img src="../Images/space.gif" class="pageLSpace" alt="" />
                </td>
                <td class="pageC">
                    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%" class="pBackSecurity">
                        <tr>
                            <td class="pcCSecurity">
                                <center>
                                    <asp:Panel runat="server" ID="Panel1">
                                        <table class="pcCSecuritySignUp">
                                            <tr>
                                                <td>
                                                    <telerik:RadPanelBar runat="server" ID="TruckerRPB" Width="1000px" Height="800px"
                                                        Skin="BlackMetroTouch" ExpandMode="FullExpandedItem">
                                                        <Items>
                                                            <telerik:RadPanelItem Expanded="true" Text="Username and password" Font-Size="Medium"
                                                                runat="server" id="UserRPI">
                                                                <ContentTemplate>
                                                                    <table style="line-height: 20px; background: white; color: Black; width: 100%; padding: 20px;">
                                                                        <tr>
                                                                            <td style="height: 50px;" colspan="2">
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td colspan="2">
                                                                                Sign in here
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="height: 50px;">
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="flSecurity" colspan="2">
                                                                                You can create an account using either your email address or mobile phone number
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="height: 50px;">
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                <telerik:RadTextBox ID="EmailRTB" runat="server" Width="167px" TabIndex="1" class="flSecurity">
                                                                                </telerik:RadTextBox>
                                                                                <telerik:RadMaskedTextBox ID="MobileRTB" runat="server" Mask="###-###-####" Width="167px"
                                                                                    TabIndex="6" class="flSecurity">
                                                                                </telerik:RadMaskedTextBox>
                                                                                <telerik:RadButton ID="EmailRadButton" runat="server" ToggleType="Radio" ButtonType="ToggleButton"
                                                                                    Checked="true" Text="Email address" GroupName="StandardButton" AutoPostBack="false"
                                                                                    OnClientClicked="OnEmailClicked" CssClass="flSecurity">
                                                                                </telerik:RadButton>
                                                                                <telerik:RadButton ID="MobileRadButton" runat="server" ToggleType="Radio" Text="Mobile number"
                                                                                    GroupName="StandardButton" ButtonType="ToggleButton" AutoPostBack="false" OnClientClicked="OnMobilePhoneClicked"
                                                                                    CssClass="flSecurity">
                                                                                </telerik:RadButton>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="flSecurity" colspan="2">
                                                                                <asp:Label runat="server" ID="PasswordLabel" Text="&lt;%# GetResourceValue(&quot;Txt:Password&quot;, &quot;FASTPORT&quot;) %>">	</asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td colspan="2">
                                                                                <telerik:RadTextBox ID="PasswordRTB" runat="server" Width="167px" TabIndex="1" class="flSecurity"
                                                                                    TextMode="Password">
                                                                                </telerik:RadTextBox>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="flSecurity" colspan="2">
                                                                                <asp:Label runat="server" ID="RetypePasswordLabel" Text="Retype password">	</asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td colspan="2">
                                                                                <telerik:RadTextBox ID="RetypePasswordRTB" runat="server" Width="167px" TabIndex="1"
                                                                                    class="flSecurity" TextMode="Password">
                                                                                </telerik:RadTextBox>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td width="500px;">
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="flSecurity" colspan="2">
                                                                                <table>
                                                                                    <tr>
                                                                                        <td>
                                                                                            <telerik:RadButton ID="TruckerRadButton" runat="server" Text="I am a trucker" ToolTip="Click to create a driver Fastport account."
                                                                                                AutoPostBack="true">
                                                                                            </telerik:RadButton>
                                                                                        </td>
                                                                                        <td>
                                                                                            <telerik:RadButton ID="CarrierRadButton" runat="server" Text="I am a carrier" ToolTip="Click to create a carrier Fastport account."
                                                                                                AutoPostBack="true">
                                                                                            </telerik:RadButton>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </ContentTemplate>
                                                            </telerik:RadPanelItem>
                                                            <telerik:RadPanelItem Text="Contact information" Expanded="false" Font-Size="Medium"
                                                                runat="server" id="ContactRPI">
                                                                <ContentTemplate>
                                                                    <table style="line-height: 20px; background: white; color: Black; width: 100%; padding: 20px;">
                                                                        <tr>
                                                                            <td style="height: 50px;" colspan="2">
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td colspan="2">
                                                                                Please enter your contact details
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="height: 50px;">
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="flSecurity" colspan="2">
                                                                                You don't need to complete them all
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="height: 50px;">
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="flSecurity">
                                                                                <asp:Label runat="server" ID="NameLabel" Text="Full name">	</asp:Label>
                                                                            </td>
                                                                            <td>
                                                                                <telerik:RadTextBox ID="NameRTB" runat="server" Width="167px" TabIndex="1" class="flSecurity">
                                                                                </telerik:RadTextBox>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="flSecurity">
                                                                                <asp:Label runat="server" ID="HandleLabel" Text="Handle">	</asp:Label>
                                                                            </td>
                                                                            <td>
                                                                                <telerik:RadTextBox ID="HandleRTB" runat="server" Width="167px" TabIndex="1" class="flSecurity">
                                                                                </telerik:RadTextBox>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="flSecurity">
                                                                                <asp:Label runat="server" ID="DirectDialLabel" Text="Direct dial">	</asp:Label>
                                                                            </td>
                                                                            <td>
                                                                                <telerik:RadTextBox ID="DirectDialRTB" runat="server" Width="167px" TabIndex="1"
                                                                                    class="flSecurity">
                                                                                </telerik:RadTextBox>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="flSecurity">
                                                                                <asp:Label runat="server" ID="MobileLabel" Text="Mobile">	</asp:Label>
                                                                            </td>
                                                                            <td>
                                                                                <telerik:RadTextBox ID="MobileRTB1" runat="server" Width="167px" TabIndex="1" class="flSecurity">
                                                                                </telerik:RadTextBox>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="flSecurity">
                                                                                <asp:Label runat="server" ID="OtherPhoneLabel" Text="Other phone">	</asp:Label>
                                                                            </td>
                                                                            <td>
                                                                                <telerik:RadTextBox ID="OtherPhoneRTB" runat="server" Width="167px" TabIndex="1"
                                                                                    class="flSecurity">
                                                                                </telerik:RadTextBox>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="flSecurity">
                                                                                <asp:Label runat="server" ID="FaxLabel" Text="Fax">	</asp:Label>
                                                                            </td>
                                                                            <td>
                                                                                <telerik:RadTextBox ID="FaxRTB" runat="server" Width="167px" TabIndex="1" class="flSecurity">
                                                                                </telerik:RadTextBox>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="flSecurity">
                                                                                <asp:Label runat="server" ID="EmailLabe1" Text="Email">	</asp:Label>
                                                                            </td>
                                                                            <td>
                                                                                <telerik:RadTextBox ID="EmailRTB1" runat="server" Width="167px" TabIndex="1" class="flSecurity">
                                                                                </telerik:RadTextBox>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </ContentTemplate>
                                                            </telerik:RadPanelItem>
                                                            <telerik:RadPanelItem Text="Carrier information" Expanded="false" Font-Size="Medium"
                                                                runat="server" id="CarrierRPI">
                                                                <ContentTemplate>
                                                                    <table style="line-height: 20px; background: white; color: Black; width: 100%; padding: 20px;">
                                                                        <tr id="EmployerRow" style="display: none;">
                                                                            <td colspan="2">
                                                                                <table>
                                                                                    <tbody>
                                                                                        <tr id="CarrierHeaderRow">
                                                                                            <td class="header_cust" style="width: 100%;" colspan="5">
                                                                                                <table>
                                                                                                    <tbody>
                                                                                                        <tr>
                                                                                                            <td style="width: 465px;">
                                                                                                                <asp:Label ID="CarrierInfoLbl" runat="server" Text="Carrier Info"></asp:Label>
                                                                                                            </td>
                                                                                                            <td style="text-align: right;">
                                                                                                                <table>
                                                                                                                    <tbody>
                                                                                                                        <tr>
                                                                                                                            <td>
                                                                                                                                <telerik:RadButton ID="CarrierEditRB" runat="server" Text="Edit" ToolTip="Click to edit this carriers details."
                                                                                                                                    CommandName="CarrierEdit" OnClientClicked="onCarrierEditClicked" OnClick="CarrierEditRB_OnClick"
                                                                                                                                    AutoPostBack="true" TabIndex="6">
                                                                                                                                </telerik:RadButton>
                                                                                                                            </td>
                                                                                                                            <td style="width: 545px">
                                                                                                                                <telerik:RadButton ID="CarrierDelRB" runat="server" Text="" ToolTip="Click to remove this carrier from this item."
                                                                                                                                    CommandName="CarrierDel" AutoPostBack="false" OnClientClicked="onCarrierDelClicked"
                                                                                                                                    TabIndex="7">
                                                                                                                                    <Icon PrimaryIconCssClass="rbRemove" PrimaryIconLeft="4" PrimaryIconTop="4"></Icon>
                                                                                                                                </telerik:RadButton>
                                                                                                                            </td>
                                                                                                                        </tr>
                                                                                                                    </tbody>
                                                                                                                </table>
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                    </tbody>
                                                                                                </table>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr id="DOTNumberRow">
                                                                                            <td class="fls">
                                                                                                <asp:Label runat="server" ID="DOTNumberLbl" Text="DOT"></asp:Label>
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadMaskedTextBox ID="DOTNumberRTB" runat="server" Mask="#######" Width="175px"
                                                                                                    TabIndex="8">
                                                                                                    <ClientEvents OnValueChanged="onDOTNumberChanged" />
                                                                                                </telerik:RadMaskedTextBox>
                                                                                            </td>
                                                                                            <td width="30px">
                                                                                                &nsbp;
                                                                                            </td>
                                                                                            <td class="fls">
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr id="MCNumberRow">
                                                                                            <td class="fls">
                                                                                                <asp:Label runat="server" ID="MCNumberLbl" Text="MC Number"></asp:Label>
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadMaskedTextBox ID="MCNumberRTB" runat="server" Mask="<MC|MX|P|FF>-######l"
                                                                                                    Width="175px" TabIndex="9">
                                                                                                    <ClientEvents OnValueChanged="onMCNumberChanged" />
                                                                                                </telerik:RadMaskedTextBox>
                                                                                            </td>
                                                                                            <td width="30px">
                                                                                                &nsbp;
                                                                                            </td>
                                                                                            <td class="fls">
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr id="CarrierNameRow">
                                                                                            <td class="fls">
                                                                                                <asp:Label runat="server" ID="CarrierNameLbl" Text="Carrier Name"></asp:Label>
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadTextBox ID="CarrierNameRTB" runat="server" Width="175px" TabIndex="10">
                                                                                                </telerik:RadTextBox>
                                                                                            </td>
                                                                                            <td width="30px">
                                                                                                &nsbp;
                                                                                            </td>
                                                                                            <td class="fls">
                                                                                                <asp:Label runat="server" ID="CarrierEmailLbl" Text="Safety Email"></asp:Label>
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadTextBox ID="CarrierEmailRTB" runat="server" Width="150px" TabIndex="14">
                                                                                                </telerik:RadTextBox>
                                                                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic"
                                                                                                    ErrorMessage="Please enter valid e-mail." ValidationExpression="^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$"
                                                                                                    ControlToValidate="CarrierEmailRTB">
                                                                                                </asp:RegularExpressionValidator>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr id="CarrierAddrRow">
                                                                                            <td class="fls">
                                                                                                <asp:Label runat="server" ID="CarrierAddrLbl" Text="HQ Address">	</asp:Label>
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadTextBox ID="CarrierAddrRTB" runat="server" Width="175px" TabIndex="11">
                                                                                                </telerik:RadTextBox>
                                                                                            </td>
                                                                                            <td width="30px">
                                                                                                &nsbp;
                                                                                            </td>
                                                                                            <td class="fls">
                                                                                                <asp:Label runat="server" ID="CarrierPhoneLbl" Text="Safety Phone"></asp:Label>
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadMaskedTextBox ID="CarrierPhoneRTB" runat="server" Mask="###-###-#### #####"
                                                                                                    Width="150px" TabIndex="15">
                                                                                                </telerik:RadMaskedTextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr id="CarrierCityRow">
                                                                                            <td class="fls">
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadComboBox ID="CarrierZipRCB" runat="server" Width="175px" EmptyMessage="City/ST or Zip"
                                                                                                    EnableLoadOnDemand="True" OnItemsRequested="s_CarrierZipRCB_ItemsRequested" ShowToggleImage="False"
                                                                                                    TabIndex="12" ZIndex="50001">
                                                                                                </telerik:RadComboBox>
                                                                                            </td>
                                                                                            <td width="30px">
                                                                                                &nsbp;
                                                                                            </td>
                                                                                            <td class="fls">
                                                                                                <asp:Label runat="server" ID="CarrierFaxLbl" Text="Safety Fax"></asp:Label>
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadMaskedTextBox ID="CarrierFaxRTB" runat="server" Mask="###-###-####" Width="150px"
                                                                                                    TabIndex="16">
                                                                                                </telerik:RadMaskedTextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr id="CarrierCountryRow">
                                                                                            <td class="fls">
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadComboBox ID="CarrierCountryRCB" runat="server" Width="175px" TabIndex="13"
                                                                                                    ZIndex="50001" AutoPostBack="false">
                                                                                                    <Items>
                                                                                                        <telerik:RadComboBoxItem runat="server" Text="United States" Value="3" Selected="true" />
                                                                                                        <telerik:RadComboBoxItem runat="server" Text="Canada" Value="2" />
                                                                                                        <telerik:RadComboBoxItem runat="server" Text="Mexico" Value="1" />
                                                                                                    </Items>
                                                                                                </telerik:RadComboBox>
                                                                                            </td>
                                                                                            <td width="30px">
                                                                                                &nsbp;
                                                                                            </td>
                                                                                            <td class="fls">
                                                                                                <asp:Label runat="server" ID="ContactLbl" Text="Contact Info"></asp:Label>
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadTextBox ID="ContactRTB" runat="server" Width="150px">
                                                                                                </telerik:RadTextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </tbody>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
    <div>
        <table style="line-height: 20px; background: white; color: Black; width: 100%; padding: 20px;">
            <tbody>
                <tr>
                    <td class="header_cust" style="width: 375px;">
                        <table>
                            <tbody style="width: 100%">
                                <tr>
                                    <td style="width: 35%;">
                                        <asp:Label ID="CarrierSearchLbl" runat="server" Text="Carrier Search"></asp:Label>
                                    </td>
                                    <td style="width: 50%; float: right">
                                        <telerik:RadSearchBox runat="server" ID="PickCarrierRSB" EmptyMessage="Part of Name, MC, or DOT"
                                            Width="208px" MaxResultCount="15" MinFilterLength="3" DropDownSettings-Height="240"
                                            EnableAutoComplete="false" OnClientSearch="onCarrierSearch" Skin="Metro" TabIndex="5">
                                            <DropDownSettings Width="300" />
                                        </telerik:RadSearchBox>
                                        <telerik:RadGrid ID="PickCarrierRG" runat="server" DataSourceID="PickCarrierDS" ShowHeader="False"
                                            Width="445px" Height="275px" AutoGenerateColumns="False" CellSpacing="0" GridLines="None">
                                            <ClientSettings Selecting-AllowRowSelect="True">
                                                <Scrolling AllowScroll="true" />
                                                <ClientEvents />
                                            </ClientSettings>
                                            <MasterTableView DataSourceID="PickCarrierDS" DataKeyNames="PartyID" ClientDataKeyNames="PartyID"
                                                EnableNoRecordsTemplate="true">
                                                <NoRecordsTemplate>
                                                    <div style="padding: 25px;">
                                                        Please search carefully for your carrier by name, DOT, or MC. If that doesn't work,
                                                        try clicking the "filter" button for a more detailed search. If the carrier is not
                                                        in the database, please click:<br />
                                                        <br />
                                                        <center>
                                                        </center>
                                                    </div>
                                                </NoRecordsTemplate>
                                                <Columns>
                                                    <telerik:GridBoundColumn DataField="CarrierHTML" UniqueName="CarrierHTML">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="CarrierNos" UniqueName="CarrierNos">
                                                    </telerik:GridBoundColumn>
                                                </Columns>
                                            </MasterTableView>
                                        </telerik:RadGrid>
                                        <asp:SqlDataSource ID="PickCarrierDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                            SelectCommand="usp_CarrierPick" SelectCommandType="StoredProcedure">
                                            <SelectParameters>
                                                <asp:Parameter DefaultValue="253" Name="MyPartyID" />
                                                <asp:ControlParameter ControlID="HiddenTB_SearchPartyID" DefaultValue="0" Name="SearchPartyID"
                                                    PropertyName="Text" Type="String" />
                                                <asp:ControlParameter ControlID="HiddenTB_SearchFree" DefaultValue="" Name="Search"
                                                    PropertyName="Text" Type="String" />
                                                <asp:ControlParameter ControlID="HiddenTB_SearchCityID" DefaultValue="0" Name="CityID"
                                                    PropertyName="Text" Type="String" />
                                                <asp:ControlParameter ControlID="HiddenTB_SearchRadius" DefaultValue="10" Name="Radius"
                                                    PropertyName="Text" Type="String" />
                                            </SelectParameters>
                                        </asp:SqlDataSource>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                </tr>
            </tbody>
        </table>
        HistoryID:
        <asp:TextBox ID="HiddenTB_HistoryID" runat="server" Text="0"></asp:TextBox><br />
        SearchPartyID:
        <asp:TextBox ID="HiddenTB_SearchPartyID" runat="server" Text="0"></asp:TextBox><br />
        SearchFree:
        <asp:TextBox ID="HiddenTB_SearchFree" runat="server" Text="0"></asp:TextBox><br />
        SearchCity:
        <asp:TextBox ID="HiddenTB_SearchCityID" runat="server" Text="0"></asp:TextBox><br />
        SearchRadius:
        <asp:TextBox ID="HiddenTB_SearchRadius" runat="server" Text="5"></asp:TextBox><br />
    </div>
                                                                </ContentTemplate>
                                                            </telerik:RadPanelItem>
                                                        </Items>
                                                    </telerik:RadPanelBar>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </center>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="pageR">
                    <img src="../Images/space.gif" class="pageRSpace" alt="" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <table cellpadding="0" cellspacing="0" border="0">
                        <tr>
                            <td class="pageBL">
                                <img src="../Images/space.gif" class="pageBLSpace" alt="" />
                            </td>
                            <td class="pageB">
                                <img src="../Images/space.gif" class="pageBSpace" alt="" />
                            </td>
                            <td class="pageBR">
                                <img src="../Images/space.gif" class="pageBRSpace" alt="" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <div id="HiddenDiv" style="display: none;">
            PartyID:
            <asp:TextBox ID="HiddenTB_PartyID" runat="server"></asp:TextBox><br />
            MeID:
            <asp:TextBox ID="HiddenTB_MeID" runat="server"></asp:TextBox><br />
            DriverID:
            <asp:TextBox ID="HiddenTB_DriverID" runat="server"></asp:TextBox><br />
            AddrID:
            <asp:TextBox ID="HiddenTB_AddrID" runat="server" Text="0"></asp:TextBox><br />
            AddrZipID:
            <asp:TextBox ID="HiddenTB_AddrZipID" runat="server" Text="0"></asp:TextBox><br />
            PrefParentID:
            <asp:TextBox ID="HiddenTB_PrefParentID" runat="server" Text="0"></asp:TextBox><br />
            MouseOverID:
            <asp:TextBox ID="HiddenTB_MouseOverID" runat="server"></asp:TextBox><br />
            CarrierID:
            <asp:TextBox ID="HiddenTB_CarrierID" runat="server" Text="0"></asp:TextBox><br />
            CarrierAddr:
            <asp:TextBox ID="HiddenTB_CarrierAddr" runat="server" Text="0"></asp:TextBox><br />
            CarrierZipID:
            <asp:TextBox ID="HiddenTB_CarrierZipID" runat="server" Text="0"></asp:TextBox><br />
            CarrierCitySTZip:
            <asp:TextBox ID="HiddenTB_CarrierCitySTZip" runat="server" Text="0"></asp:TextBox><br />
            CarrierCountryID:
            <asp:TextBox ID="HiddenTB_CarrierCountryID" runat="server" Text="0"></asp:TextBox><br />
            CarrierCountry:
            <asp:TextBox ID="HiddenTB_CarrierCountry" runat="server" Text="0"></asp:TextBox><br />
            CarrierDataStatus:
            <asp:TextBox ID="HiddenTB_CarrierDataStatus" runat="server" Text="0"></asp:TextBox><br />
            CarrierLat:
            <asp:TextBox ID="HiddenTB_CarrierLat" runat="server" Text="0"></asp:TextBox><br />
            CarrierLong:
            <asp:TextBox ID="HiddenTB_CarrierLong" runat="server" Text="0"></asp:TextBox>
            CarrierAdmin:
            <asp:TextBox ID="HiddenTB_CarrierAdminYesNo" runat="server" Text="0"></asp:TextBox>
            WindowWidth:
            <asp:TextBox ID="HiddenTB_WindowWidth" runat="server" Text="0"></asp:TextBox>
            HistoryHoverID:
            <asp:TextBox ID="HiddenTB_HistoryHoverID" runat="server" Text="0"></asp:TextBox><br />
            HistoryID_ForExpRTT:
            <asp:TextBox ID="HiddenTB_HistoryID_ForExpRTT" runat="server" Text="0"></asp:TextBox><br />
            ExperienceID:
            <asp:TextBox ID="HiddenTB_ExperienceID" runat="server" Text="0"></asp:TextBox><br />
            PartyExperienceID:
            <asp:TextBox ID="HiddenTB_PartyExperienceID" runat="server" Text="0"></asp:TextBox><br />
            Slider:
            <asp:TextBox ID="HiddenTB_Slider" runat="server" Text="0"></asp:TextBox><br />
            IncidentID:
            <asp:TextBox ID="HiddenTB_IncidentID" runat="server" Text="0"></asp:TextBox><br />
            InfoRun:
            <asp:TextBox ID="HiddenTB_InfoRun" runat="server" Text="No"></asp:TextBox><br />
            HistRun:
            <asp:TextBox ID="HiddenTB_HistRun" runat="server" Text="No"></asp:TextBox><br />
            ExpRun:
            <asp:TextBox ID="HiddenTB_ExpRun" runat="server" Text="No"></asp:TextBox><br />
            IncidentsRun:
            <asp:TextBox ID="HiddenTB_IncidentsRun" runat="server" Text="No"></asp:TextBox><br />
            Tab:
            <asp:TextBox ID="HiddenTB_Tab" runat="server" Text="No"></asp:TextBox><br />
        </div>
    </div>
    </form>
</body>
</html>
