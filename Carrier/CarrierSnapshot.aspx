<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="CarrierSnapshot.aspx.vb"
    Inherits=".CarrierSnapshot" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Carrier Snapshot</title>
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
    <telerik:RadScriptBlock runat="Server" ID="RadScriptBlock1">
        <style type="text/css">
            div.RemoveBorders .rgHeader, div.RemoveBorders th.rgResizeCol, div.RemoveBorders .rgFilterRow td
            {
                border-width: 0 0 1px 0; /*top right bottom left*/
            }
            
            div.RemoveBorders .rgRow td, div.RemoveBorders .rgAltRow td, div.RemoveBorders .rgEditRow td, div.RemoveBorders .rgFooter td
            {
                border-width: 0;
                padding-left: 7px; /*needed for row hovering and selection*/
            }
            
            div.RemoveBorders .rgGroupHeader td, div.RemoveBorders .rgFooter td
            {
                padding-left: 7px;
            }
            html
            {
                overflow: hidden;
            }
            .rpSlide
            {
                height: 430px !important;
                overflow: auto !important;
            }
            .blurbs
            {
                display: none !important;
            }
            .RadWindow .rwPinButton, .RadWindow .rwMinimizeButton, .RadWindow .rwMaximizeButton
            {
                display: none !important;
            }
            
            .RadPanelBar_BlackMetroTouch .rpItem
            {
                background-color: #d9d9d9;
                font-size: 15px;
            }
        </style>
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

            function ChildClose(args) {
                GetRadWindow().close();
            }

            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow; //Will work in Moz in all cases, including clasic dialog
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow; //IE (and Moz as well)

                return oWindow;
            }

            function onRowMouseOver(sender, eventArgs) {

                var ExperienceParentID = eventArgs.getDataKeyValue("ExperienceParentID");
                var ExperienceID = eventArgs.getDataKeyValue("ExperienceID");
                var YearValue = eventArgs.getDataKeyValue("YearValue");
                document.getElementById("<%=HiddenTB_ExperienceParentID.ClientID %>").value = ExperienceParentID;
                document.getElementById("<%=HiddenTB_ExperienceID.ClientID %>").value = ExperienceID;
                document.getElementById("<%=HiddenTB_YearValue.ClientID %>").value = YearValue;
            }

            function onThumbsUpRB_Clicked(sender, args) {
                
                var AdID = document.getElementById("<%=HiddenTB_AdID.ClientID %>").value;
                var ExperienceParentID = document.getElementById("<%=HiddenTB_ExperienceParentID.ClientID%>").value;
                var ExperienceID = document.getElementById("<%=HiddenTB_ExperienceID.ClientID%>").value;
                var ThumbValue = sender.get_selectedToggleStateIndex();
                SendCallBack("SaveExp," + AdID + "," + ExperienceParentID + "," + ExperienceID + "," + ThumbValue, "SaveExp");
            }

            function onThumbsUpRB_Clicked_back(arg) {

            }

            var targettype;

            function onCarrierReviewButtons_Clicked(sender) {
                
                targettype = "Carrier";
                var senderid = sender.get_id();
                var CheckInType = senderid.substring(18, senderid.length - 2);
                var ReviewedPartyID = document.getElementById("<%=HiddenTB_PartyID.ClientID%>").value;
                SendCallBack("SaveReviews," + targettype + "," + CheckInType + "," + ReviewedPartyID, "SaveReviews");
            }

            function onAdReviewButtons_Clicked(sender) {
                
                targettype = "Ad";
                var senderid = sender.get_id();
                var CheckInType = senderid.substring(13, senderid.length - 2);
                var ReviewedAdID = document.getElementById("<%=HiddenTB_AdID.ClientID%>").value;
                SendCallBack("SaveReviews," + targettype + "," + CheckInType + "," + ReviewedAdID, "SaveReviews");
            }

            function onPayReviewButtons_Clicked(sender) {
                
                targettype = "Pay";
                var CheckInType = "Thumbs$";
                var ReviewedAdID = document.getElementById("<%=HiddenTB_AdID.ClientID%>").value;
                SendCallBack("SaveReviews," + targettype + "," + CheckInType + "," + ReviewedAdID, "SaveReviews");
            }

            function onReviewButtons_Clicked_back(arg) {

            }

            function onAdReqThumbsRB_Clicked(sender, args) {

                var AdID = document.getElementById("<%=HiddenTB_AdID.ClientID %>").value;
                var ExperienceParentID = document.getElementById("<%=HiddenTB_ExperienceParentID.ClientID %>").value;
                var ExperienceID = document.getElementById("<%=HiddenTB_ExperienceID.ClientID %>").value;
                var ThumbValue = sender.get_selectedToggleStateIndex();
                SendCallBack("SaveReq," + AdID + "," + ExperienceParentID + "," + ExperienceID + "," + ThumbValue, "SaveReq");

            }

            function onAdIncidentsRG_RowMouseOver(sender, eventArgs) {
                
                var CheckInType = eventArgs.getDataKeyValue("ReqType");
                document.getElementById("<%=HiddenTB_Req.ClientID %>").value = CheckInType;
            }

            function onIncidentThumbsUpRB_Clicked() {
                
                var CheckInType = document.getElementById("<%=HiddenTB_Req.ClientID %>").value;
                var ReviewedAdID = document.getElementById("<%=HiddenTB_AdID.ClientID%>").value;
                SendCallBack("SaveIncidents," + targettype + "," + CheckInType + "," + ReviewedAdID, "SaveIncidents");

            }

            function SendCallBack(arg, myAction) {

                try {
                    switch (myAction) {
                        case "SaveExp":
                            { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onThumbsUpRB_Clicked_back", "null") %>
                                break;
                            }
                        case "SaveReq":
                            { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onThumbsUpRB_Clicked_back", "null") %>
                                break;
                            }
                        case "SaveReviews":
                            { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onReviewButtons_Clicked_back", "null") %>
                                break;
                            }
                        case "SaveIncidents":
                            { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onReviewButtons_Clicked_back", "null") %>
                                break;
                            }
                    }
                } catch (e) {}
            }
				
        </script>
    </telerik:RadScriptBlock>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
    <div>
        <table cellpadding="0" cellspacing="0" border="0">
            <tr>
                <td colspan="3" style="vertical-align: top; padding: 0px">
                    <telerik:RadTabStrip ID="RadTabStrip1" runat="server" MultiPageID="RadMultiPage1"
                        Width="100%" SelectedIndex="0" Skin="BlackMetroTouch">
                        <Tabs>
                            <telerik:RadTab runat="server" Text="Current Ad" PageViewID="PageView1" Width="235px">
                            </telerik:RadTab>
                            <telerik:RadTab runat="server" Text="Offices/Terminals" PageViewID="PageView2" Width="235px">
                            </telerik:RadTab>
                            <telerik:RadTab runat="server" Text="Reviews" PageViewID="PageView3" Width="235px">
                            </telerik:RadTab>
                            <telerik:RadTab runat="server" Text="All Job Postings" PageViewID="PageView4" Width="235px">
                            </telerik:RadTab>
                        </Tabs>
                    </telerik:RadTabStrip>
                    <telerik:RadMultiPage ID="RadMultiPage1" runat="server" SelectedIndex="0">
                        <telerik:RadPageView ID="PageView1" runat="server">
                            <asp:Panel ID="AdScrollPanel" runat="server" Height="700px" ScrollBars="None">
                                <table>
                                    <tr>
                                        <td class="dfv" style="vertical-align: top;">
                                            <telerik:RadPanelBar runat="server" ID="ToDoRPB" Width="100%" Height="100%" Skin="BlackMetroTouch"
                                                ExpandMode="FullExpandedItem">
                                                <Items>
                                                    <telerik:RadPanelItem Expanded="true" Text="General Info" Font-Size="Medium">
                                                        <ContentTemplate>
                                                            <div style="background-color: #d9d9d9; line-height: 16px; color: Black; height: 100%">
                                                                <table style="border-color: White">
                                                                    <tr>
                                                                        <td class="dfv" style="width: 415px; vertical-align: top;">
                                                                            <telerik:RadBinaryImage ID="LogoRBI" runat="server" Width="150px" Height="150px"
                                                                                ResizeMode="Fit" />
                                                                            <telerik:RadButton ID="CarrierThumbsRB" runat="server" AutoPostBack="false" ToolTip="Like"
                                                                                ToggleType="CustomToggle" OnClientClicked="onCarrierReviewButtons_Clicked">
                                                                                <ToggleStates>
                                                                                    <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup0-small.png" Height="20px"
                                                                                        Width="20px" Value="0" />
                                                                                    <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup-small.png" Height="20px"
                                                                                        Width="20px" Value="1" />
                                                                                </ToggleStates>
                                                                            </telerik:RadButton>
                                                                            <telerik:RadButton ID="CarrierFavoriteRB" runat="server" ToggleType="CustomToggle"
                                                                                ToolTip="Favorite" AutoPostBack="false" OnClientClicked="onCarrierReviewButtons_Clicked">
                                                                                <ToggleStates>
                                                                                    <telerik:RadButtonToggleState ImageUrl="../Images/Custom/favorite.png" Height="20px"
                                                                                        Width="20px" Value="0" />
                                                                                    <telerik:RadButtonToggleState ImageUrl="../Images/Custom/favorite-clicked.png" Height="20px"
                                                                                        Width="20px" Value="1" />
                                                                                </ToggleStates>
                                                                            </telerik:RadButton>
                                                                            <telerik:RadButton ID="CarrierHideRB" runat="server" ToggleType="CustomToggle" ToolTip="Show/Hide"
                                                                                AutoPostBack="false" OnClientClicked="onCarrierReviewButtons_Clicked">
                                                                                <ToggleStates>
                                                                                    <telerik:RadButtonToggleState ImageUrl="../Images/Custom/hide.png" Height="20px"
                                                                                        Width="20px" Value="0" />
                                                                                    <telerik:RadButtonToggleState ImageUrl="../Images/Custom/show.png" Height="20px"
                                                                                        Width="20px" Value="1" />
                                                                                </ToggleStates>
                                                                            </telerik:RadButton>
                                                                            <br />
                                                                            <asp:Literal ID="CarrierDetailsLiteral" runat="server"></asp:Literal>
                                                                        </td>
                                                                        <td class="dfv" style="width: 600px; vertical-align: top;">
                                                                            <asp:Literal ID="AdSummaryLiteral" runat="server" Text=""></asp:Literal><br />
                                                                            <telerik:RadButton ID="AdThumbsRB" runat="server" AutoPostBack="false" ToolTip="Like"
                                                                                ToggleType="CustomToggle" OnClientClicked="onAdReviewButtons_Clicked">
                                                                                <ToggleStates>
                                                                                    <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup0-small.png" Height="20px"
                                                                                        Width="20px" Value="0" />
                                                                                    <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup-small.png" Height="20px"
                                                                                        Width="20px" Value="1" />
                                                                                </ToggleStates>
                                                                            </telerik:RadButton>
                                                                            <telerik:RadButton ID="AdFavoriteRB" runat="server" ToggleType="CustomToggle" ToolTip="Favorite"
                                                                                AutoPostBack="false" OnClientClicked="onAdReviewButtons_Clicked">
                                                                                <ToggleStates>
                                                                                    <telerik:RadButtonToggleState ImageUrl="../Images/Custom/favorite.png" Height="20px"
                                                                                        Width="20px" Value="0" />
                                                                                    <telerik:RadButtonToggleState ImageUrl="../Images/Custom/favorite-clicked.png" Height="20px"
                                                                                        Width="20px" Value="1" />
                                                                                </ToggleStates>
                                                                            </telerik:RadButton>
                                                                            <telerik:RadButton ID="AdHideRB" runat="server" ToggleType="CustomToggle" ToolTip="Show/Hide"
                                                                                AutoPostBack="false" OnClientClicked="onAdReviewButtons_Clicked">
                                                                                <ToggleStates>
                                                                                    <telerik:RadButtonToggleState ImageUrl="../Images/Custom/hide.png" Height="20px"
                                                                                        Width="20px" Value="0" />
                                                                                    <telerik:RadButtonToggleState ImageUrl="../Images/Custom/show.png" Height="20px"
                                                                                        Width="20px" Value="1" />
                                                                                </ToggleStates>
                                                                            </telerik:RadButton>
                                                                            <asp:Literal ID="AdPayLiteral" runat="server"></asp:Literal>
                                                                            <telerik:RadButton ID="PayThumbsRB" runat="server" ToggleType="CustomToggle" AutoPostBack="false"
                                                                                ToolTip="Like" OnClientClicked="onPayReviewButtons_Clicked">
                                                                                <ToggleStates>
                                                                                    <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup0-small.png" Height="20px"
                                                                                        Width="20px" Value="0" />
                                                                                    <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup-small.png" Height="20px"
                                                                                        Width="20px" Value="1" />
                                                                                </ToggleStates>
                                                                            </telerik:RadButton>
                                                                            <br />
                                                                            <asp:Literal ID="AdDetailsLiteral" runat="server"></asp:Literal>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </div>
                                                        </ContentTemplate>
                                                    </telerik:RadPanelItem>
                                                    <telerik:RadPanelItem Text="Experience Wanted" Expanded="false" Font-Size="Medium">
                                                        <ContentTemplate>
                                                            <div style="background-color: #d9d9d9; line-height: 16px; color: Black; height: 100%">
                                                                <table style="border-color: White">
                                                                    <tr>
                                                                        <td class="dfv" style="width: 500px; vertical-align: top;">
                                                                            <telerik:RadGrid ID="AdGeneralRG" runat="server" GridLines="None" ShowHeader="true"
                                                                                CellSpacing="0" AutoGenerateColumns="False" DataSourceID="AdGeneralDS" Skin="Silk"
                                                                                OnItemDataBound="GridItemDataBound">
                                                                                <ClientSettings>
                                                                                    <ClientEvents OnRowMouseOver="onRowMouseOver" />
                                                                                </ClientSettings>
                                                                                <MasterTableView ClientDataKeyNames="ExperienceParentID, ExperienceID" DataKeyNames="Thumbs">
                                                                                    <Columns>
                                                                                        <telerik:GridBoundColumn DataField="ExpName" UniqueName="AdGeneralDetails" HeaderText="General Experience">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridTemplateColumn UniqueName="ThumbsUpColumn">
                                                                                            <ItemTemplate>
                                                                                                <telerik:RadButton ID="ThumbsUpRB" runat="server" AutoPostBack="false" ToolTip="Like"
                                                                                                    OnClientClicked="onThumbsUpRB_Clicked" ToggleType="CustomToggle" ButtonType="ToggleButton">
                                                                                                    <ToggleStates>
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup0-small.png" Width="20px"
                                                                                                            Height="20px" Value="0" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup1-small.png" Width="20px"
                                                                                                            Height="20px" Value="1" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup2-small.png" Width="50px"
                                                                                                            Height="20px" Value="2" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup3-small.png" Width="50px"
                                                                                                            Height="20px" Value="3" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup4-small.png" Width="50px"
                                                                                                            Height="20px" Value="4" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup5-small.png" Width="50px"
                                                                                                            Height="20px" Value="5" />
                                                                                                    </ToggleStates>
                                                                                                </telerik:RadButton>
                                                                                            </ItemTemplate>
                                                                                        </telerik:GridTemplateColumn>
                                                                                    </Columns>
                                                                                </MasterTableView>
                                                                            </telerik:RadGrid>
                                                                            <asp:SqlDataSource ID="AdGeneralDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                SelectCommand="usp_SnapshotThumbs" SelectCommandType="StoredProcedure">
                                                                                <SelectParameters>
                                                                                    <asp:ControlParameter ControlID="HiddenTB_AdID" Name="AdID" PropertyName="Text" Type="Int32" />
                                                                                    <asp:SessionParameter Name="PartyID" SessionField="PartyID" Type="Int32" />
                                                                                    <asp:Parameter Name="ExpParentIDs" DefaultValue="743" Type="String" />
                                                                                </SelectParameters>
                                                                            </asp:SqlDataSource>
                                                                            <telerik:RadGrid ID="AdCargoRG" runat="server" GridLines="None" ShowHeader="true"
                                                                                CellSpacing="0" AutoGenerateColumns="False" DataSourceID="AdCargoDS" Skin="Silk"
                                                                                OnItemDataBound="GridItemDataBound">
                                                                                <ClientSettings>
                                                                                    <ClientEvents OnRowMouseOver="onRowMouseOver" />
                                                                                </ClientSettings>
                                                                                <MasterTableView ClientDataKeyNames="ExperienceParentID, ExperienceID" DataKeyNames="Thumbs">
                                                                                    <Columns>
                                                                                        <telerik:GridBoundColumn DataField="ExpName" UniqueName="AdCargoDetails" HeaderText="Commodity Experience">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridTemplateColumn UniqueName="ThumbsUpColumn">
                                                                                            <ItemTemplate>
                                                                                                <telerik:RadButton ID="ThumbsUpRB" runat="server" AutoPostBack="false" ToolTip="Like"
                                                                                                    OnClientClicked="onThumbsUpRB_Clicked" ToggleType="CustomToggle" ButtonType="ToggleButton">
                                                                                                    <ToggleStates>
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup0-small.png" Width="20px"
                                                                                                            Height="20px" Value="0" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup1-small.png" Width="20px"
                                                                                                            Height="20px" Value="1" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup2-small.png" Width="50px"
                                                                                                            Height="20px" Value="2" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup3-small.png" Width="50px"
                                                                                                            Height="20px" Value="3" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup4-small.png" Width="50px"
                                                                                                            Height="20px" Value="4" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup5-small.png" Width="50px"
                                                                                                            Height="20px" Value="5" />
                                                                                                    </ToggleStates>
                                                                                                </telerik:RadButton>
                                                                                            </ItemTemplate>
                                                                                        </telerik:GridTemplateColumn>
                                                                                    </Columns>
                                                                                </MasterTableView>
                                                                            </telerik:RadGrid>
                                                                            <asp:SqlDataSource ID="AdCargoDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                SelectCommand="usp_SnapshotThumbs" SelectCommandType="StoredProcedure">
                                                                                <SelectParameters>
                                                                                    <asp:ControlParameter ControlID="HiddenTB_AdID" Name="AdID" PropertyName="Text" Type="Int32" />
                                                                                    <asp:SessionParameter Name="PartyID" SessionField="PartyID" Type="Int32" />
                                                                                    <asp:Parameter Name="ExpParentIDs" DefaultValue="666" Type="String" />
                                                                                </SelectParameters>
                                                                            </asp:SqlDataSource>
                                                                        </td>
                                                                        <td class="dfv" style="width: 515px; vertical-align: top;">
                                                                            <telerik:RadGrid ID="AdEquipRG" runat="server" GridLines="None" ShowHeader="true"
                                                                                CellSpacing="0" AutoGenerateColumns="False" DataSourceID="AdEquipDS" Skin="Silk"
                                                                                OnItemDataBound="GridItemDataBound">
                                                                                <ClientSettings>
                                                                                    <ClientEvents OnRowMouseOver="onRowMouseOver" />
                                                                                </ClientSettings>
                                                                                <MasterTableView ClientDataKeyNames="ExperienceParentID, ExperienceID" DataKeyNames="Thumbs">
                                                                                    <Columns>
                                                                                        <telerik:GridBoundColumn DataField="ExpName" UniqueName="AdEquipDetails" HeaderText="Equipment Experience">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridTemplateColumn UniqueName="ThumbsUpColumn">
                                                                                            <ItemTemplate>
                                                                                                <telerik:RadButton ID="ThumbsUpRB" runat="server" AutoPostBack="false" ToolTip="Like"
                                                                                                    OnClientClicked="onThumbsUpRB_Clicked" ToggleType="CustomToggle" ButtonType="ToggleButton">
                                                                                                    <ToggleStates>
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup0-small.png" Width="20px"
                                                                                                            Height="20px" Value="0" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup1-small.png" Width="20px"
                                                                                                            Height="20px" Value="1" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup2-small.png" Width="50px"
                                                                                                            Height="20px" Value="2" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup3-small.png" Width="50px"
                                                                                                            Height="20px" Value="3" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup4-small.png" Width="50px"
                                                                                                            Height="20px" Value="4" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup5-small.png" Width="50px"
                                                                                                            Height="20px" Value="5" />
                                                                                                    </ToggleStates>
                                                                                                </telerik:RadButton>
                                                                                            </ItemTemplate>
                                                                                        </telerik:GridTemplateColumn>
                                                                                    </Columns>
                                                                                </MasterTableView>
                                                                            </telerik:RadGrid>
                                                                            <asp:SqlDataSource ID="AdEquipDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                SelectCommand="usp_SnapshotThumbs" SelectCommandType="StoredProcedure">
                                                                                <SelectParameters>
                                                                                    <asp:ControlParameter ControlID="HiddenTB_AdID" Name="AdID" PropertyName="Text" Type="Int32" />
                                                                                    <asp:SessionParameter Name="PartyID" SessionField="PartyID" Type="Int32" />
                                                                                    <asp:Parameter Name="ExpParentIDs" DefaultValue="389" Type="String" />
                                                                                </SelectParameters>
                                                                            </asp:SqlDataSource>
                                                                            <telerik:RadGrid ID="AdRegionsRG" runat="server" GridLines="None" ShowHeader="true"
                                                                                CellSpacing="0" AutoGenerateColumns="False" DataSourceID="AdRegionsDS" Skin="Silk"
                                                                                OnItemDataBound="GridItemDataBound">
                                                                                <ClientSettings>
                                                                                    <ClientEvents OnRowMouseOver="onRowMouseOver" />
                                                                                </ClientSettings>
                                                                                <MasterTableView ClientDataKeyNames="ExperienceParentID, ExperienceID" DataKeyNames="Thumbs">
                                                                                    <Columns>
                                                                                        <telerik:GridBoundColumn DataField="ExpName" UniqueName="AdRegionsDetails" HeaderText="Regions">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridTemplateColumn UniqueName="ThumbsUpColumn">
                                                                                            <ItemTemplate>
                                                                                                <telerik:RadButton ID="ThumbsUpRB" runat="server" AutoPostBack="false" ToolTip="Like"
                                                                                                    OnClientClicked="onThumbsUpRB_Clicked" ToggleType="CustomToggle" ButtonType="ToggleButton">
                                                                                                    <ToggleStates>
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup0-small.png" Width="20px"
                                                                                                            Height="20px" Value="0" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup1-small.png" Width="20px"
                                                                                                            Height="20px" Value="1" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup2-small.png" Width="50px"
                                                                                                            Height="20px" Value="2" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup3-small.png" Width="50px"
                                                                                                            Height="20px" Value="3" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup4-small.png" Width="50px"
                                                                                                            Height="20px" Value="4" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/thumbsup5-small.png" Width="50px"
                                                                                                            Height="20px" Value="5" />
                                                                                                    </ToggleStates>
                                                                                                </telerik:RadButton>
                                                                                            </ItemTemplate>
                                                                                        </telerik:GridTemplateColumn>
                                                                                    </Columns>
                                                                                </MasterTableView>
                                                                            </telerik:RadGrid>
                                                                            <asp:SqlDataSource ID="AdRegionsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                SelectCommand="usp_SnapshotThumbs" SelectCommandType="StoredProcedure">
                                                                                <SelectParameters>
                                                                                    <asp:ControlParameter ControlID="HiddenTB_AdID" Name="AdID" PropertyName="Text" Type="Int32" />
                                                                                    <asp:SessionParameter Name="PartyID" SessionField="PartyID" Type="Int32" />
                                                                                    <asp:Parameter Name="ExpParentIDs" DefaultValue="741" Type="String" />
                                                                                </SelectParameters>
                                                                            </asp:SqlDataSource>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </div>
                                                        </ContentTemplate>
                                                    </telerik:RadPanelItem>
                                                    <telerik:RadPanelItem Text="Minimum Requirements" Expanded="false" Font-Size="Medium">
                                                        <ContentTemplate>
                                                            <div style="background-color: #d9d9d9; line-height: 16px; color: Black; height: 100%">
                                                                <table>
                                                                    <tr>
                                                                        <td class="dfv" style="width: 500px; vertical-align: top;">
                                                                            <telerik:RadGrid ID="AdReqRG" runat="server" GridLines="None" ShowHeader="true" CellSpacing="0"
                                                                                AutoGenerateColumns="False" DataSourceID="AdReqDS" Skin="Silk">
                                                                                <ClientSettings>
                                                                                    <ClientEvents OnRowMouseOver="onRowMouseOver" />
                                                                                </ClientSettings>
                                                                                <MasterTableView ClientDataKeyNames="ExperienceParentID, ExperienceID, YearValue" DataKeyNames="YearStatus">
                                                                                    <Columns>
                                                                                        <telerik:GridBoundColumn DataField="ExpName" UniqueName="AdGeneralDetails" HeaderText="Requirements">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridTemplateColumn UniqueName="ThumbsUpColumn">
                                                                                            <ItemTemplate>
                                                                                                <telerik:RadButton ID="AdReqThumbsUpRB" runat="server" AutoPostBack="false" ToolTip="Rank"
                                                                                                    OnClientClicked="onAdReqThumbsRB_Clicked" ToggleType="CustomToggle" ButtonType="ToggleButton">
                                                                                                    <ToggleStates>
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/checkmark-gray.png" Width="20px"
                                                                                                            Height="20px" Value="0" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/checkmark-green.png" Width="20px"
                                                                                                            Height="20px" Value="1" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/delete_small.png" Width="20px"
                                                                                                            Height="20px" Value="2" />
                                                                                                    </ToggleStates>
                                                                                                </telerik:RadButton>
                                                                                            </ItemTemplate>
                                                                                        </telerik:GridTemplateColumn>
                                                                                    </Columns>
                                                                                </MasterTableView>
                                                                            </telerik:RadGrid>
                                                                            <asp:SqlDataSource ID="AdReqDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                SelectCommand="usp_SnapshotThumbs" SelectCommandType="StoredProcedure">
                                                                                <SelectParameters>
                                                                                    <asp:ControlParameter ControlID="HiddenTB_AdID" Name="AdID" PropertyName="Text" Type="Int32" />
                                                                                    <asp:SessionParameter Name="PartyID" SessionField="PartyID" Type="Int32" />
                                                                                    <asp:Parameter Name="ExpParentIDs" DefaultValue="743, 741, 666, 389" Type="String" />
                                                                                    <asp:Parameter Name="ByYearYesNo" DefaultValue="Yes" Type="String" />
                                                                                </SelectParameters>
                                                                            </asp:SqlDataSource>
                                                                            <telerik:RadGrid ID="AdIncidentsRG" runat="server" GridLines="None" ShowHeader="true"
                                                                                CellSpacing="0" AutoGenerateColumns="False" DataSourceID="AdIncidentsDS" Skin="Silk">
                                                                                <ClientSettings>
                                                                                    <ClientEvents OnRowMouseOver="onAdIncidentsRG_RowMouseOver" />
                                                                                </ClientSettings>
                                                                                <MasterTableView ClientDataKeyNames="ReqType" DataKeyNames="CheckStatus">
                                                                                    <Columns>
                                                                                        <telerik:GridBoundColumn DataField="Req" UniqueName="AdIncidents" HeaderText="Accidents, Tickets, Incidents, etc">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridTemplateColumn UniqueName="ThumbsUpColumn">
                                                                                            <ItemTemplate>
                                                                                                <telerik:RadButton ID="AdIncidentThumbsUpRB" runat="server" AutoPostBack="false" ToolTip="Like"
                                                                                                    ToggleType="CustomToggle" ButtonType="ToggleButton" OnClientClicked="onIncidentThumbsUpRB_Clicked">
                                                                                                    <ToggleStates>
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/checkmark-gray.png" Width="20px"
                                                                                                            Height="20px" Value="0" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/checkmark-green.png" Width="20px"
                                                                                                            Height="20px" Value="1" />
                                                                                                        <telerik:RadButtonToggleState ImageUrl="../Images/Custom/delete_small.png" Width="20px"
                                                                                                            Height="20px" Value="2" />
                                                                                                    </ToggleStates>
                                                                                                </telerik:RadButton>
                                                                                            </ItemTemplate>
                                                                                        </telerik:GridTemplateColumn>
                                                                                    </Columns>
                                                                                </MasterTableView>
                                                                            </telerik:RadGrid>
                                                                            <asp:SqlDataSource ID="AdIncidentsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                SelectCommand="usp_SnapshotReqs" SelectCommandType="StoredProcedure">
                                                                                <SelectParameters>
                                                                                    <asp:ControlParameter ControlID="HiddenTB_AdID" Name="AdID" PropertyName="Text" Type="Int32" />
                                                                                    <asp:SessionParameter Name="PartyID" SessionField="PartyID" Type="Int32" />
                                                                                </SelectParameters>
                                                                            </asp:SqlDataSource>
                                                                        </td>
                                                                        <td class="dfv" style="width: 515px; vertical-align: top;">
                                                                            <asp:Literal ID="AdReqProblemsLiteral" runat="server"></asp:Literal>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </div>
                                                        </ContentTemplate>
                                                    </telerik:RadPanelItem>
                                                </Items>
                                            </telerik:RadPanelBar>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="PageView2" runat="server">
                            <table>
                                <tr>
                                    <td>
                                        <telerik:RadGrid ID="TermRadGrid" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                                            CellSpacing="0" DataSourceID="TermDS" CssClass="RemoveBorders" GridLines="None"
                                            ShowHeader="False" PageSize="10" Width="550px" Height="620px">
                                            <ClientSettings EnableRowHoverStyle="True" EnablePostBackOnRowClick="True">
                                                <Selecting AllowRowSelect="true" />
                                                <Scrolling AllowScroll="true" ScrollHeight="355px" UseStaticHeaders="true" />
                                            </ClientSettings>
                                            <MasterTableView DataKeyNames="AddrID" ClientDataKeyNames="AddrID" DataSourceID="TermDS">
                                                <Columns>
                                                    <telerik:GridBoundColumn DataField="AddrID" DataType="System.Int32" UniqueName="AddrID"
                                                        Visible="False">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="PartyID" DataType="System.Int32" UniqueName="PartyID"
                                                        Visible="False">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridHTMLEditorColumn DataField="TermHTML" UniqueName="TermHTML">
                                                    </telerik:GridHTMLEditorColumn>
                                                </Columns>
                                            </MasterTableView>
                                        </telerik:RadGrid>
                                        <asp:SqlDataSource ID="TermDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                            SelectCommand="SELECT * FROM [v_Addr] WHERE [PartyID] = @TermPartyID ORDER BY [Headquarters] Desc, AddrName, CitySTZip">
                                            <SelectParameters>
                                                <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="TermPartyID" PropertyName="Text"
                                                    Type="Int32" />
                                            </SelectParameters>
                                        </asp:SqlDataSource>
                                    </td>
                                </tr>
                            </table>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="PageView3" runat="server">
                            <table>
                                <tr>
                                    <td>
                                        <telerik:RadGrid ID="ReviewsRadGrid" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                                            CellSpacing="0" DataSourceID="ReviewsDS" GridLines="None" ShowHeader="False"
                                            PageSize="10" Width="930px" Height="620px">
                                            <ClientSettings EnableRowHoverStyle="True">
                                                <Scrolling AllowScroll="true" ScrollHeight="355px" UseStaticHeaders="true" />
                                            </ClientSettings>
                                            <MasterTableView DataKeyNames="CheckInID" ClientDataKeyNames="CheckInID" DataSourceID="ReviewsDS">
                                                <Columns>
                                                    <telerik:GridBoundColumn DataField="CheckInID" DataType="System.Int32" UniqueName="CheckInID"
                                                        Visible="False">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBinaryImageColumn DataField="FromPic" UniqueName="FromPic" ImageHeight="50"
                                                        ImageWidth="50" ResizeMode="Fit">
                                                        <HeaderStyle Width="75px" />
                                                    </telerik:GridBinaryImageColumn>
                                                    <telerik:GridHTMLEditorColumn DataField="CheckInHTML" UniqueName="CheckInHTML" ItemStyle-Width="350">
                                                    </telerik:GridHTMLEditorColumn>
                                                </Columns>
                                            </MasterTableView>
                                        </telerik:RadGrid>
                                        <asp:SqlDataSource ID="ReviewsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                            SelectCommand="SELECT * FROM [v_CheckIn] WHERE (([ReviewedPartyID] = @ReviewedPartyID)) ORDER BY [CreatedAt] Desc">
                                            <SelectParameters>
                                                <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="ReviewedPartyID" PropertyName="Text"
                                                    Type="Int32" />
                                            </SelectParameters>
                                        </asp:SqlDataSource>
                                    </td>
                                </tr>
                            </table>
                        </telerik:RadPageView>
                        <telerik:RadPageView ID="PageView4" runat="server">
                            <table>
                                <tr>
                                    <td>
                                        <telerik:RadGrid ID="JobsRadGrid" runat="server" DataSourceID="JobsDS" ShowHeader="False"
                                            CssClass="RemoveBorders" Skin="Silk" Width="930px" Height="620px">
                                            <ClientSettings EnableRowHoverStyle="True">
                                                <Selecting AllowRowSelect="true" />
                                                <Scrolling AllowScroll="true" ScrollHeight="355px" />
                                            </ClientSettings>
                                            <MasterTableView AutoGenerateColumns="False" DataSourceID="JobsDS" DataKeyNames="AdID"
                                                ClientDataKeyNames="AdID">
                                                <NoRecordsTemplate>
                                                    <div>
                                                    </div>
                                                </NoRecordsTemplate>
                                                <Columns>
                                                    <telerik:GridBoundColumn DataField="AdID" Visible="False" UniqueName="AdID">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="PartyID" Visible="False" UniqueName="PartyID">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="AdHTML" UniqueName="AdHTML">
                                                        <HeaderStyle Width="150px" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="FocusesStacked" UniqueName="FocusesStacked">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="PayHTML" UniqueName="PayHTML">
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="Warnings" UniqueName="Warnings">
                                                        <HeaderStyle Width="150px" />
                                                    </telerik:GridBoundColumn>
                                                </Columns>
                                            </MasterTableView>
                                        </telerik:RadGrid>
                                        <asp:SqlDataSource ID="JobsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                            SelectCommand="usp_Ad_CarrierSnapshot" SelectCommandType="StoredProcedure">
                                            <SelectParameters>
                                                <asp:ControlParameter ControlID="HiddenTB_CarrierID" Name="CarrierID" PropertyName="Text"
                                                    Type="Int32" />
                                                <asp:SessionParameter Name="TruckerID" SessionField="PartyID" Type="Int32" />
                                                <asp:Parameter Name="Snippet" DefaultValue="255" />
                                            </SelectParameters>
                                        </asp:SqlDataSource>
                                    </td>
                                </tr>
                            </table>
                        </telerik:RadPageView>
                    </telerik:RadMultiPage>
                </td>
            </tr>
        </table>
        <div id="HiddenTBs">
            <asp:TextBox ID="HiddenTB_PartyID" runat="server" Style="display: none"></asp:TextBox>
            <asp:TextBox ID="HiddenTB_CarrierID" runat="server" Style="display: none"></asp:TextBox>
            <asp:TextBox ID="HiddenTB_AdID" runat="server" Style="display: none"></asp:TextBox>
            <asp:TextBox ID="HiddenTB_ExperienceParentID" runat="server" Style="display: none"></asp:TextBox>
            <asp:TextBox ID="HiddenTB_ExperienceID" runat="server" Style="display: none"></asp:TextBox>
            <asp:TextBox ID="HiddenTB_YearValue" runat="server" Style="display: none"></asp:TextBox>
            <asp:TextBox ID="HiddenTB_Req" runat="server" Style="display: none"></asp:TextBox>
            <asp:TextBox ID="HiddenTB_PosLat" Text="0" runat="server" Style="display: none"></asp:TextBox>
            <asp:TextBox ID="HiddenTB_PosLong" Text="0" runat="server" Style="display: none"></asp:TextBox>
        </div>
    </div>
    </form>
</body>
</html>
