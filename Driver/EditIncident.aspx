<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
<%@ Register TagPrefix="FASTPORT" Namespace="FASTPORT.UI.Controls.EditIncident" Assembly="FASTPORT" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="EditIncident.aspx.vb"
    Culture="en-US" Inherits="FASTPORT.UI.EditIncident" %>

<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<style>
    body
    {
        width:530px;
        margin: 0px;
        margin-top: 0px;
        height:93%
    }
    div.CustomRAC .racTokenList 
    {
        height:40px;
        overflow:auto;
        white-space:nowrap;
    }
</style>
<head id="Head1" runat="server">
    <title>FASTPORT > Configure</title>
</head>
<body>
    <form id="form1" runat="server" style="margin-bottom:0px">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
        </Scripts>
    </telerik:RadScriptManager>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
    </telerik:RadStyleSheetManager>
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

        function ChildCloseAndRedirect(args) {
            GetRadWindow().BrowserWindow.ParentCloseAndRedirect(args);
            GetRadWindow().close();
        }


        function ChildClose() {
            GetRadWindow().close();
        }

        function GetRadWindow() {
            var oWindow = null;
            if (window.radWindow) oWindow = window.radWindow; //Will work in Moz in all cases, including clasic dialog
            else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow; //IE (and Moz as well)

            return oWindow;
        }

        function onRTTClicked() {

            var DescInstructionsRTT = $find("<%=DescInstructionsRTT.ClientID %>");
            var DescInstructionsImg = document.getElementById("DescInstructionsImg");

            DescInstructionsRTT.set_targetControl(DescInstructionsImg);
            setTimeout(function () {
                DescInstructionsRTT.show();
            }, 100);

        }

        function flipSRC(mySRC) {

            var DescInstructionsImg = document.getElementById("DescInstructionsImg");
            DescInstructionsImg.src = mySRC;

        }

    </script>
    <div>
        <table cellpadding="0" cellspacing="0" border="0" style="width:100%;">
            <tr>
                <td>
                    <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
                    <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
                    <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
                    <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
                    <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
                    <fastport:partyincidentrecordcontrol runat="server" id="PartyIncidentRecordControl">
                        <table cellpadding="0" cellspacing="0" border="0" style="background-color:White; width:100%;">
                            <tr>
                                <td>
                                    <asp:Panel ID="PartyIncidentRecordControlCollapsibleRegion" runat="server">
                                        <table cellpadding="0" cellspacing="0" border="0" style="width:100%;">
                                            <tr>
                                                <td>
                                                    <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="Server">
                                                        <asp:Panel ID="PartyIncidentRecordControlPanel" runat="server">
                                                            <table cellpadding="0" cellspacing="0" border="0" style="width:100%">
                                                                <tr>
                                                                    <td>
                                                                        <tr runat="server">
                                                                            <td>
                                                                                <asp:Panel ID="MainScrollPanel" runat="server" ScrollBars="None" Style="height: 355px; width: 100%;">
                                                                                    <telerik:RadToolTip ID="DescInstructionsRTT" runat="server" ManualClose="true" Skin="BlackMetroTouch" Position="BottomLeft" RelativeTo="Element" ShowEvent="FromCode" Width="250px">
                                                                                                <asp:Literal runat="server" ID="DescInstructionsLiteral" Text="Please record the details of this entry below"></asp:Literal>
                                                                                    </telerik:RadToolTip>
                                                                                    <telerik:RadTabStrip ID="IncidentRTS" runat="server" MultiPageID="IncidentRMP" Skin="BlackMetroTouch" Width="530">
                                                                                        <Tabs>
                                                                                            <telerik:RadTab runat="server" Text="General Info" PageViewID="PageView1" Width="265px"
                                                                                                Selected="true" />
                                                                                            <telerik:RadTab runat="server" Text="Accident Info" PageViewID="PageView2" Width="265px" />
                                                                                        </Tabs>
                                                                                    </telerik:RadTabStrip>
                                                                                    <telerik:RadMultiPage ID="IncidentRMP" runat="server" SelectedIndex="0" Height="350">
                                                                                        <telerik:RadPageView ID="PageView1" runat="server">
                                                                                            <div style="float: left; width: 505px; margin: 5px;">
                                                                                                <table cellpadding="0" cellspacing="0" border="0">
                                                                                                    <col width="200px" />
                                                                                                    <col width="315px" />
                                                                                                    <tr id="OccuredOnRow" runat="server">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="OccurredOnLabel" Text="Occurred On">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <telerik:RadMaskedTextBox ID="OccurredOnTB" runat="server" Mask="##/##/####" Width="75px">
                                                                                                            </telerik:RadMaskedTextBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr id="AccidentLocationRow" runat="server">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="AccidentLocationIDLabel" Text="Accident Location">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <telerik:RadComboBox ID="AccidentLocationRadCombo" runat="server" Width="200px" EmptyMessage="For 'W Chicago, IL' enter 'W Ch,IL'"
                                                                                                                EnableLoadOnDemand="True" OnItemsRequested="s_CityRadCombo_ItemsRequested" ShowToggleImage="False">
                                                                                                            </telerik:RadComboBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr runat="server" id="AtFaultRow">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="IWasAtFaultLabel" Text="I was Found to Be At Fault">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <asp:CheckBox runat="server" ID="IWasAtFault"></asp:CheckBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr runat="server" id="EquipRow">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="EqiupTypeIDLabel" Text="My Equipment Type">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <telerik:RadComboBox ID="EquipCombobox" runat="server" AllowCustomText="True" DataSourceID="EquipDS"
                                                                                                                EmptyMessage="Enter equipment, like: 'Flatbed'" DataTextField="TreeFull" DataValueField="TreeID"
                                                                                                                Filter="Contains" Height="150px" MarkFirstMatch="True" MaxLength="255" Width="270px"
                                                                                                                AutoPostBack="True" Skin="Default" EnableAutomaticLoadOnDemand="true" ShowToggleImage="False">
                                                                                                            </telerik:RadComboBox>
                                                                                                            <asp:SqlDataSource ID="EquipDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                                                SelectCommand="usp_TreeRollUp" SelectCommandType="StoredProcedure">
                                                                                                                <SelectParameters>
                                                                                                                    <asp:Parameter DefaultValue="389" Name="Prune" Type="Int32" />
                                                                                                                </SelectParameters>
                                                                                                            </asp:SqlDataSource>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr runat="server" id="TicketedRow">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="TicketedLabel" Text="Ticketed">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <asp:CheckBox runat="server" ID="Ticketed" AutoPostBack="True"></asp:CheckBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr id="TicketedForRow" runat="server">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="TicketedForLabel" Text="Ticketed For">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <telerik:RadAutoCompleteBox ID="TicketedForRAC" runat="server" Filter="Contains" CssClass="CustomRAC"
                                                                                                                DataSourceID="TicketedForDS" DataValueField="TreeID" DataTextField="ItemName"
                                                                                                                InputType="Token" DropDownWidth="300px" DropDownHeight="250px" Width="300px" AllowCustomEntry="false">
                                                                                                            </telerik:RadAutoCompleteBox>
                                                                                                            <asp:SqlDataSource ID="TicketedForDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                                                SelectCommand="SELECT [TreeID], [ItemName] FROM [Tree] WHERE ([TreeParentID] = @TreeParentID)">
                                                                                                                <SelectParameters>
                                                                                                                    <asp:Parameter DefaultValue="2021" Name="TreeParentID" Type="Int32" />
                                                                                                                </SelectParameters>
                                                                                                            </asp:SqlDataSource>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr id="FelonyIssuedRow" runat="server">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="FelonyIssuedLabel" Text="Felony Issued in Connection with Accident or Ticket">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <asp:CheckBox runat="server" ID="FelonyIssued" AutoPostBack="True"></asp:CheckBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr runat="server" id="RecklessDrivingRow">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="RuledAsRecklessDrivingLabel" Text="Ruled As Reckless Driving">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <asp:CheckBox runat="server" ID="RuledAsRecklessDriving"></asp:CheckBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr runat="server" id="LicenseSuspendedRow">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="LicenseSuspendedLabel" Text="License Suspended">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <asp:CheckBox runat="server" ID="LicenseSuspended" AutoPostBack="True"></asp:CheckBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr id="ReinstatedOnRow" runat="server">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="ReinstatedOnLabel" Text="Reinstated On">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <telerik:RadMaskedTextBox ID="ReinstatedOnTB" runat="server" Mask="##/##/####" Width="75px">
                                                                                                            </telerik:RadMaskedTextBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr runat="server" id="SAPReleaseRow">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="SAPReleaseLabel" Text="I Received a Release from a SAP (&quot;Substance Abuse Professional&quot;)">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <asp:CheckBox runat="server" ID="SAPRelease" AutoPostBack="True"></asp:CheckBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr id="PhysicalObsoleteRow" runat="server">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="PhysicalObsoleteLabel" Text="This Physical was Overruled by a Later Physical">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <asp:CheckBox runat="server" ID="PhysicalObsolete" AutoPostBack="True"></asp:CheckBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                </table>
                                                                                            </div>
                                                                                        </telerik:RadPageView>
                                                                                        <telerik:RadPageView ID="PageView2" runat="server">
                                                                                            <div style="float: left; width: 505px; padding-left: 5px; margin-right: 5px">
                                                                                                <table cellpadding="0" cellspacing="0" border="0">
                                                                                                    <col width="300px" />
                                                                                                    <col width="180px" />
                                                                                                    <tr runat="server" id="EstimatedCostRow">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="EstimatedCostLabel" Text="Estimated Cost of Damage (1) to Property, (2) to Cargo, and (3) for Personal Injuries.">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <span style="white-space: nowrap;">
                                                                                                                <table border="0" cellpadding="0" cellspacing="0">
                                                                                                                    <tr>
                                                                                                                        <td style="padding-right: 5px; vertical-align: top">
                                                                                                                            <asp:TextBox runat="server" ID="EstimatedCost" Columns="20" MaxLength="31" CssClass="field_input"
                                                                                                                                Width="90px"></asp:TextBox>
                                                                                                                        </td>
                                                                                                                        <td>
                                                                                                                            &nbsp;
                                                                                                                            <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="EstimatedCostTextBoxMaxLengthValidator"
                                                                                                                                ControlToValidate="EstimatedCost" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Estimated Cost&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                </table>
                                                                                                            </span>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr id="FileClosedRow" runat="server">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="FileClosedLabel" Text="All Parties Reimbursed and Insurance File Closed">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <asp:CheckBox runat="server" ID="FileClosed"></asp:CheckBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr id="TowAwayAccidentRow" runat="server">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="TowAWayAccidentLabel" Text="At Least One Vehicle was Towed as a Result of Damage Caused by the Accident">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <asp:CheckBox runat="server" ID="TowAWayAccident"></asp:CheckBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr id="FatalitiesOccuredRow" runat="server">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="FatalitiesOccuredLabel" Text="Fatalities Occured as as Result of the Accident">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <asp:CheckBox runat="server" ID="FatalitiesOccured" AutoPostBack="False"></asp:CheckBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr id="InjuriesOccuredRow" runat="server">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="InjuriesOccuredLabel" Text="At Least One Person Needed Medical Care within 24 Hours of the Accident">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <asp:CheckBox runat="server" ID="InjuriesOccured" AutoPostBack="False"></asp:CheckBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr id="CargoRow" runat="server">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="CargoTypeIDLabel" Text="The Type of Cargo Damaged">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <telerik:RadComboBox ID="CargoCombobox" runat="server" AllowCustomText="True" DataSourceID="CargoDS"
                                                                                                                EmptyMessage="Enter cargo, like: 'Coil'" DataTextField="TreeFull" DataValueField="TreeID"
                                                                                                                Filter="Contains" Height="150px" MarkFirstMatch="True" MaxLength="255" Width="270px"
                                                                                                                AutoPostBack="True" Skin="Default" EnableAutomaticLoadOnDemand="true" ShowToggleImage="False">
                                                                                                            </telerik:RadComboBox>
                                                                                                            <asp:SqlDataSource ID="CargoDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                                                SelectCommand="usp_TRU_Cargo" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr runat="server" id="PhysicalLimitationExpirationRow">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="PhysicalLimitationExpirationLabel" Text="The Limitation Listed on My Physical Expires On">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <telerik:RadMaskedTextBox ID="PhysicalLimitationExpirationTB" runat="server" Mask="##/##/####"
                                                                                                                Width="75px">
                                                                                                            </telerik:RadMaskedTextBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr id="SAPReleaseDateRow" runat="server">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="SAPReleaseDateLabel" Text="SAP Release Date">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <telerik:RadMaskedTextBox ID="SAPReleaseDateTB" runat="server" Mask="##/##/####"
                                                                                                                Width="75px">
                                                                                                            </telerik:RadMaskedTextBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr id="IncidentExpirationRow" runat="server">
                                                                                                        <td class="fls">
                                                                                                            <asp:Literal runat="server" ID="IncidentExpirationLabel" Text="Date of Overruling Physical">	</asp:Literal>
                                                                                                        </td>
                                                                                                        <td class="dfv" style="text-align: left;">
                                                                                                            <telerik:RadMaskedTextBox ID="IncidentExpirationTB" runat="server" Mask="##/##/####"
                                                                                                                Width="75px">
                                                                                                            </telerik:RadMaskedTextBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                </table>
                                                                                            </div>
                                                                                        </telerik:RadPageView>
                                                                                    </telerik:RadMultiPage>
                                                                                </asp:Panel>
                                                                                <div style="margin-left: 5px;">
                                                                                    <table cellpadding="0" cellspacing="0" border="0">
                                                                                        <col width="185px" />
                                                                                        <col width="315px" />
                                                                                        <tr>
                                                                                            <td class="header_cust" colspan="2">
                                                                                                <div>
                                                                                                    <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                                                                                            <tr>
                                                                                                                <td class="dht" style="font-size:medium">
                                                                                                                    Notes
                                                                                                                </td>
                                                                                                                <td align="right">
                                                                                                                    <img id="DescInstructionsImg" alt="" src="../Images/Custom/HelpBlack.png" onclick="return onRTTClicked();"
                                                                                                                        onmouseover="return flipSRC('../Images/Custom/HelpBlackGlow.png');"
                                                                                                                        onmouseout="return flipSRC('../Images/Custom/HelpBlack.png');" />
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                    </table>
                                                                                                </div>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td class="fls"></td>
                                                                                            <td class="dfv"></td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td class="dfv" colspan="2">
                                                                                                <telerik:RadEditor ID="DescriptionRadEditor" runat="server" Height="120" Width="500"
                                                                                                    ContentAreaMode="Div" EditModes="Design" Skin="Default" ToolsFile="~/ToolsFileMedium.xml"
                                                                                                    EnableResize="False" Style="font-family:Arial, Verdana, Georgia, Sans-Serif;font-size:11pt; color:#bbbbbb">
                                                                                                </telerik:RadEditor>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </div>
                                                                            </td>
                                                                        </tr>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="dfv" style="display: none">
                                                                        <asp:Literal runat="server" ID="IncidentID"></asp:Literal>
                                                                        <asp:TextBox runat="server" ID="PartyID" Columns="14" MaxLength="14" CssClass="field_input"
                                                                            minlistitems="Default"></asp:TextBox>
                                                                        <asp:TextBox runat="server" ID="IncidentCategoryID" Columns="14" MaxLength="14" CssClass="field_input"
                                                                            minlistitems="Default"></asp:TextBox>
                                                                        <asp:TextBox runat="server" ID="OccurredOn" Columns="20" MaxLength="20" CssClass="field_input"></asp:TextBox>
                                                                        <asp:TextBox runat="server" ID="DetailedDescription" Columns="40" MaxLength="2147483647"
                                                                            CssClass="field_input"></asp:TextBox>
                                                                        <asp:TextBox runat="server" ID="AccidentLocationID" Columns="14" MaxLength="14" CssClass="field_input"></asp:TextBox>
                                                                        <asp:TextBox runat="server" ID="ReinstatedOn" Columns="20" MaxLength="20" CssClass="field_input"></asp:TextBox>
                                                                        <asp:TextBox runat="server" ID="EqiupTypeID" Columns="14" MaxLength="14" CssClass="field_input"
                                                                            minlistitems="Default" Visible="False"></asp:TextBox>
                                                                        <asp:TextBox runat="server" ID="CargoTypeID" Columns="14" MaxLength="14" CssClass="field_input"
                                                                            minlistitems="Default" Visible="False"></asp:TextBox>
                                                                        <asp:TextBox runat="server" ID="SAPReleaseDate" Columns="20" MaxLength="20" CssClass="field_input"
                                                                            Visible="False" Wrap="False"></asp:TextBox>
                                                                        <asp:TextBox runat="server" ID="IncidentExpiration" Columns="20" MaxLength="20" CssClass="field_input"
                                                                            Visible="False"></asp:TextBox>
                                                                        <asp:TextBox runat="server" ID="PhysicalLimitationExpiration" Columns="20" MaxLength="20"
                                                                            CssClass="field_input" Visible="False"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </telerik:RadAjaxPanel>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                            </tr>
                        </table>
                    </fastport:partyincidentrecordcontrol>
                    <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
                    <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
                    <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
                    <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
                    <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    <table>
                        <tr>
                            <td>
                                <fastport:themebutton runat="server" id="SaveIncidentButton" button-causesvalidation="True"
                                    button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>"
                                    button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>"
                                    postback="True"></fastport:themebutton>
                            </td>
                            <td>
                                <fastport:themebutton runat="server" id="CancelIncidentButton" button-causesvalidation="True"
                                    postback="true" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;FASTPORT&quot;) %>">
                                </fastport:themebutton>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();"
            onmouseover="clearTimeout(gPopupTimer);" style="display: none">
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="false"
            runat="server" Style="display: none"></asp:ValidationSummary>
    </div>
    </form>
</body>
</html>
