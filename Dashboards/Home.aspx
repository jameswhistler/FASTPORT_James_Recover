<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="Home.aspx.vb" Inherits=".Home" %>

<%@ Register TagPrefix="FASTPORT" TagName="Menu" Src="../Menu Panels/Menu.ascx" %>
<%@ Register TagPrefix="FASTPORT" TagName="Header" Src="../Header and Footer/Header.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FASTPORT</title>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server" />
</head>
<body>
    <style>
        body
        {
            height: 100%;
            margin: 0;
            padding: 0;
            overflow: hidden;
        }
        
        #ParentDivElement
        {
            position: absolute;
            top: 45px;
            bottom: 0;
            width: 100%;
        }
        
        #map
        {
            position: relative;
            width: 100%;
            height: 100%;
        }
        .leaflet-popup-content
        {
            width: 350px !important;
            font-family: Arial, Helvetica, Sans-Serif;
        }
        .leaflet-popup-content-wrapper
        {
            border-radius: 10px;
        }
        
        #PointRW_C
        {
            width: 100% !important;
            height: 100% !important;
            overflow: hidden !important;
        }
        
        .RadGrid_Silk .rgHeader:first-child, .RadGrid_Silk th.rgResizeCol:first-child, .RadGrid_Silk .rgFilterRow > td:first-child, .RadGrid_Silk .rgRow > td:first-child, .RadGrid_Silk .rgAltRow > td:first-child
        {
            padding: 0px;
        }
        
        .RadGrid_Silk .rgRow td, .RadGrid_Silk .rgAltRow td, .RadGrid_Silk .rgEditRow td
        {
            border-style: none;
            border-bottom: 0px;
            border-width: 0 0 0px !important;
        }
        
        .RadGrid .rgRow td, .RadGrid .rgAltRow td, .RadGrid .rgEditRow td, .RadGrid .rgFooter td
        {
            padding: 0px;
        }
        #RAD_SPLITTER_PANE_CONTENT_resultsPane
        {
            overflow: hidden !important;
        }
        #DashboardRG_ctl00
        {
            margin-top: 0px !important;
        }
        .rmpHiddenView
        {
            display: block;
        }
        #RadSliderWrapper_StatusRadSlider
        {
            width: 450px !important;
        }
        .rwTitlebarControls td
        {
            vertical-align: middle !important;
        }
        .rwTopResize
        {
            display: none !important;
        }
        
        .RadPanelBar_BlackMetroTouch .rpItem
        {
            font-size: 15px;
            background: white;
        }
        
        .dfv
        {
            padding-bottom: 15px;
        }
    </style>
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
        </Scripts>
    </telerik:RadScriptManager>
    <script src='/mapbox.js' type="text/jscript"></script>
    <link href='/mapbox.css' rel='stylesheet' type="text/css" />
    <!--[if lte IE 8]>
        <link href='/mapbox.ie.css' rel='stylesheet' >
      <![endif]-->
    <script src="http://code.jquery.com/jquery-1.10.1.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="/heatmap.js"></script>
    <script type="text/javascript" src="/heatmap-leaflet.js"></script>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ReviewsRG" />
                    <telerik:AjaxUpdatedControl ControlID="DashboardRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="PrefRG" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_GeneralRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_EquipRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_CommodityRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_RegionsRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_OtherRAC" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="DashboardRG">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="DashboardRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="SearchForTruckerRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="EmailRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SearchMobileRTB" />
                    <telerik:AjaxUpdatedControl ControlID="NameRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SearchForTruckerRB" />
                    <telerik:AjaxUpdatedControl ControlID="PickTruckerRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="PickTruckerRG">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="EmailRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="NameRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="HandleRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="TruckerTypeRCB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="MobileRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="DirectDialRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="FaxRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="SaveTruckerRB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="GaugeP1Img" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="SaveTruckerRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="EmailRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="PasswordRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="NameRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="HandleRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="TruckerTypeRCB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="MobileRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="DirectDialRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="FaxRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="SaveTruckerRB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="GaugeP1Img" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="SaveRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="SaveRB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Pref_EditRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Pref_EditRB" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_GeneralRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_GeneralRB" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_EquipRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_EquipRB" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_CommodityRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_CommodityRB" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_RegionsRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_RegionsRB" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_OtherRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_OtherRB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Pref_GeneralRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PrefRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Pref_EquipRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PrefRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Pref_CommodityRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PrefRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Pref_RegionsRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PrefRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Pref_OtherRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PrefRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server">
    </telerik:RadAjaxLoadingPanel>
    <telerik:RadToolTip runat="server" ID="ViewSourceRTT" HideEvent="ManualClose" RelativeTo="Element"
        Width="375px" Skin="BlackMetroTouch">
        <div>
            <table cellpadding="0" cellspacing="0" border="0px">
                <col width="100px" />
                <col width="275px" />
                <tr style="height: 60px; vertical-align: top">
                    <td>
                        <asp:Label ID="JobFoundOnLbl" runat="server" Text="Job Found On"></asp:Label>
                    </td>
                    <td>
                        <telerik:RadAutoCompleteBox ID="JobFoundRAC" runat="server" Width="250px" DataSourceID="JobFoundDS"
                            DataTextField="ItemName" DataValueField="TreeID" InputType="Token" DropDownHeight="200"
                            DropDownWidth="250" Filter="Contains" ZIndex="500001">
                        </telerik:RadAutoCompleteBox>
                        <asp:SqlDataSource ID="JobFoundDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                            SelectCommand="SELECT TreeID, ItemName FROM dbo.Tree WHERE TreeParentID = 2366">
                        </asp:SqlDataSource>
                    </td>
                </tr>
                <tr style="height: 60px; vertical-align: top">
                    <td>
                        <asp:Label ID="PostingCitiesLbl" runat="server" Text="Posting Cities"></asp:Label>
                    </td>
                    <td>
                        <telerik:RadAutoCompleteBox ID="PostingCitiesRAC" runat="server" Filter="Contains"
                            InputType="Token" DropDownHeight="75" Width="250px" DataSourceID="PostingCitiesDS"
                            DataTextField="Info" DataValueField="PK" OnClientEntryAdding="onAutoCompleteBoxEntryAdding"
                            OnDataSourceSelect="PostingCitiesRAC_DataSourceSelect">
                        </telerik:RadAutoCompleteBox>
                        <asp:SqlDataSource ID="PostingCitiesDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>">
                        </asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td>
                        <telerik:RadButton ID="SaveRB" runat="server" Text="Save">
                        </telerik:RadButton>
                    </td>
                </tr>
            </table>
        </div>
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="PrefRTT" HideEvent="ManualClose" RelativeTo="Element"
        Width="430px" Skin="BlackMetroTouch" OnClientHide="closePrefRTT">
        <telerik:RadGrid ID="PrefRG" runat="server" DataSourceID="PrefDS" GridLines="None"
            ShowHeader="False" CellSpacing="0" AutoGenerateColumns="False">
            <ClientSettings>
                <ClientEvents OnRowMouseOver="getExpID" />
            </ClientSettings>
            <MasterTableView DataKeyNames="PartyExperienceID, Importance" ClientDataKeyNames="PartyExperienceID, ItemName"
                DataSourceID="PrefDS">
                <NoRecordsTemplate>
                    <div style="padding: 25px;">
                        You have not yet entered stuff you want for this category. Please close this tool
                        tip, click the "Edit" button below, and enter the stuff you want.
                    </div>
                </NoRecordsTemplate>
                <Columns>
                    <telerik:GridBoundColumn DataField="ItemImage" UniqueName="ItemImage">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="ItemName" UniqueName="ItemName">
                    </telerik:GridBoundColumn>
                    <telerik:GridTemplateColumn HeaderText="Importance" UniqueName="ImportanceColumn">
                        <ItemTemplate>
                            <telerik:RadSlider ID="PrefRS" runat="server" ItemType="item" CssClass="ItemsSlider"
                                OnClientValueChanged="sliderChanged" OnClientSlideStart="slideStart" OnClientSlideEnd="slideEnd"
                                ShowDecreaseHandle="false" ShowIncreaseHandle="false" Height="75px" Width="225px"
                                Skin="Metro">
                                <Items>
                                    <telerik:RadSliderItem Text="Low" Value="0" />
                                    <telerik:RadSliderItem Text="" Value="1" />
                                    <telerik:RadSliderItem Text="Medium" Value="2" />
                                    <telerik:RadSliderItem Text="" Value="3" />
                                    <telerik:RadSliderItem Text="Critical" Value="4" />
                                </Items>
                            </telerik:RadSlider>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridTemplateColumn UniqueName="PrefRTT_PrefDelIBColumn">
                        <ItemTemplate>
                            <asp:ImageButton ID="PrefRTT_PrefDelIB" runat="server" ImageUrl="/Images/Custom/XOut_Small.png" />
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                </Columns>
                <PagerStyle PageSizeControlType="RadComboBox"></PagerStyle>
            </MasterTableView>
            <PagerStyle PageSizeControlType="RadComboBox"></PagerStyle>
        </telerik:RadGrid>
        <asp:SqlDataSource ID="PrefDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
            SelectCommand="usp_PrefSliders_ByTrucker" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="PrefPartyID" PropertyName="Text"
                    Type="Int32" />
                <asp:ControlParameter ControlID="HiddenTB_PrefParentID" Name="PrefParentIDs" PropertyName="Text"
                    Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </telerik:RadToolTip>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True" Modal="True"
        ShowContentDuringLoad="False" VisibleStatusbar="False" Behaviors="Close,Move,Resize">
        <Windows>
            <telerik:RadWindow ID="PointRW" runat="server" Modal="True" ShowContentDuringLoad="False"
                Style="display: none" VisibleStatusbar="False" Skin="BlackMetroTouch" Title="Details">
                <ContentTemplate>
                    <table class="dv" cellpadding="0" cellspacing="0" border="0" style="height: 98%;
                        padding-bottom: 0px; margin-top: 5px">
                        <tr>
                            <td>
                                <asp:Panel ID="V_PartyOrgRecordControlCollapsibleRegion" runat="server">
                                    <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="400px">
                                        <tr>
                                            <td>
                                                <asp:Panel ID="V_PartyOrgRecordControlPanel" runat="server">
                                                    <table cellpadding="0" cellspacing="0" border="0">
                                                        <tr>
                                                            <td style="vertical-align: top; width: 300px">
                                                                <center>
                                                                    <table>
                                                                        <tr>
                                                                            <td class="dfv">
                                                                                <asp:Label runat="server" ID="POILbl"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="dfv">
                                                                                <asp:Label runat="server" ID="ContactInfoLbl"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                <table>
                                                                                    <tr>
                                                                                        <col width="100px" />
                                                                                        <col width="100px" />
                                                                                        <td>
                                                                                            <asp:ImageButton runat="server" ID="ThumbsDownButton" CausesValidation="False" CommandName="Redirect"
                                                                                                ImageUrl="../Images/ButtonBarNew.gif"></asp:ImageButton>
                                                                                        </td>
                                                                                        <td>
                                                                                            <asp:ImageButton runat="server" ID="ThumbsUpButton" CausesValidation="False" CommandName="Redirect"
                                                                                                ImageUrl="../Images/ButtonBarNew.gif"></asp:ImageButton>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="dfv" style="vertical-align: bottom;">
                                                                                <table>
                                                                                    <tr>
                                                                                        <td class="panel_cust">
                                                                                            <asp:Label runat="server" ID="AmenitiesLbl" Text="Amenities"></asp:Label>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td class="dfv" style="width: 350px">
                                                                                            <asp:Label runat="server" ID="PinsLbl"></asp:Label>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </center>
                                                            </td>
                                                            <td class="dfv" style="vertical-align: top;">
                                                                <center>
                                                                    <table>
                                                                        <tr>
                                                                            <td style="vertical-align: top;">
                                                                                <asp:Label runat="server" ID="PointStatsLbl"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="dfv" style="width: 350px">
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </center>
                                                            </td>
                                                            <td class="dfv" style="vertical-align: top; width: 50px;">
                                                            </td>
                                                            <td style="vertical-align: top; width: 350px;">
                                                                <table>
                                                                    <tr>
                                                                        <td class="panel_cust">
                                                                            <asp:Label runat="server" ID="HistoryLbl" Text="Activity">	</asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <telerik:RadGrid ID="ReviewsRG" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                                                                                CellSpacing="0" DataSourceID="ReviewsDS" GridLines="None" ShowHeader="False"
                                                                                PageSize="5">
                                                                                <MasterTableView DataKeyNames="CheckInID" ClientDataKeyNames="CheckInID" DataSourceID="ReviewsDS">
                                                                                    <NoRecordsTemplate>
                                                                                        No activity for this location yet.
                                                                                    </NoRecordsTemplate>
                                                                                    <Columns>
                                                                                        <telerik:GridBoundColumn DataField="CheckInID" DataType="System.Int32" UniqueName="CheckInID"
                                                                                            Visible="False">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBinaryImageColumn DataField="FromPic" UniqueName="FromPic" ImageHeight="50"
                                                                                            ImageWidth="50" ResizeMode="Fit">
                                                                                        </telerik:GridBinaryImageColumn>
                                                                                        <telerik:GridHTMLEditorColumn DataField="CheckInHTML" UniqueName="CheckInHTML" ItemStyle-Width="350">
                                                                                        </telerik:GridHTMLEditorColumn>
                                                                                    </Columns>
                                                                                </MasterTableView>
                                                                            </telerik:RadGrid>
                                                                            <asp:SqlDataSource ID="ReviewsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                SelectCommand="SELECT * FROM [v_CheckIn] WHERE (([PointID] = @ReviewPointID)) ORDER BY [CreatedAt] Desc">
                                                                                <SelectParameters>
                                                                                    <asp:ControlParameter ControlID="HiddenTB_PointID" Name="ReviewPointID" PropertyName="Text"
                                                                                        Type="Int32" />
                                                                                </SelectParameters>
                                                                            </asp:SqlDataSource>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
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
                                </asp:Panel>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </telerik:RadWindow>
            <telerik:RadWindow ID="JobRadWindow" runat="server" Modal="True" ShowContentDuringLoad="False"
                Style="display: none;" VisibleStatusbar="False" Skin="BlackMetroTouch" Width="960px"
                Height="700px" AutoSize="false">
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
    <table width="100%" class="pcmL">
        <tr>
            <td width="155px" align="right" style="padding-left: 20px;">
                <asp:Image ID="LogoImage" runat="server" ImageUrl="../Images/Custom/FPWhiteLogo.png">
                </asp:Image>
            </td>
            <td>
                <FASTPORT:Menu runat="server" ID="_Menu"></FASTPORT:Menu>
            </td>
            <td width="100%" align="right">
                <FASTPORT:Header runat="server" ID="_PageHeader"></FASTPORT:Header>
            </td>
        </tr>
    </table>
    <div id="ParentDivElement">
        <telerik:RadSplitter ID="MapSplitter" runat="server" Height="100%" Width="100%" Orientation="Vertical"
            Skin="BlackMetroTouch">
            <telerik:RadPane ID="resultsPane" runat="server" Width="385" MinWidth="150" MaxWidth="400">
                <telerik:RadTabStrip ID="DashboardRTS" runat="server" Skin="BlackMetroTouch" SelectedIndex="0"
                    OnClientTabSelected="onRTSTabSelected" Align="Justify">
                    <Tabs>
                        <telerik:RadTab runat="server" Text="All" Value="0">
                        </telerik:RadTab>
                        <telerik:RadTab runat="server" Text="Stops" Value="1">
                        </telerik:RadTab>
                        <telerik:RadTab runat="server" Text="Jobs" Value="2">
                        </telerik:RadTab>
                        <telerik:RadTab runat="server" Text="CB" Value="3">
                        </telerik:RadTab>
                    </Tabs>
                </telerik:RadTabStrip>
                <telerik:RadGrid ID="DashboardRG" runat="server" AutoGenerateColumns="False" DataSourceID="DashboardDS"
                    ShowHeader="False" Skin="Silk" AllowPaging="true" PageSize="100">
                    <ClientSettings Selecting-AllowRowSelect="true">
                        <ClientEvents OnRowSelected="onAdGeoRGRowSelected" OnGridCreated="onAdGeoRGCreated" />
                        <Scrolling AllowScroll="True" UseStaticHeaders="true"></Scrolling>
                    </ClientSettings>
                    <MasterTableView ClientDataKeyNames="PK, POICat, PointOfInterest, Lat, Long, PointInfo, AllDetails, ReturnID"
                        DataKeyNames="PK, POICat" DataSourceID="DashboardDS">
                        <NoRecordsTemplate>
                            No records.
                        </NoRecordsTemplate>
                        <Columns>
                            <telerik:GridTemplateColumn UniqueName="ResultsColumn">
                                <ItemTemplate>
                                    <div id='<%# Eval("PK")%>' title='<%# Eval("AllDetails") %>' dir='<%# Eval("ReturnID") %>'
                                        onmouseover="onDivMouseOver(this)">
                                        <table width="100%" style="border-width: 0px; padding-left: 6px; padding-right: 6px;
                                            padding-top: 3px; padding-bottom: 3px; border-spacing: 0px !important;">
                                            <tr>
                                                <td style="background-color: black; color: #ffffff; width: 325px; border-top-left-radius: 3px;
                                                    border-top-right-radius: 3px; padding: 6px">
                                                    <table cellpadding="0" cellspacing="0" border="0px" width="100%">
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="HeaderLbl" runat="server" Text='<%# Eval("Header")%>'></asp:Label>
                                                            </td>
                                                            <td align="right">
                                                                <telerik:RadButton ID="ViewSourceRB" runat="server" AutoPostBack="false" Height="20px"
                                                                    Width="20px" OnClientClicked="onViewSourceRB_Clicked">
                                                                    <Image EnableImageButton="true" ImageUrl="/Images/Custom/viewsource.png" />
                                                                </telerik:RadButton>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="background-color: #e4e4e4; font-size: 12px; width: 325px; min-height: 50px;
                                                    padding: 2px;">
                                                    <div onclick="return onImageClick();">
                                                        <telerik:RadBinaryImage ID="ThumbnailRBI" runat="server" ResizeMode="Fit" DataValue='<%# Eval("Thumbnail")%>' />
                                                    </div>
                                                    <table width="100%">
                                                        <tr>
                                                            <td width="60%">
                                                                <asp:Label ID="PointOfInterestLbl" runat="server" Text='<%# Eval("PointOfInterest")%>'></asp:Label>
                                                            </td>
                                                            <td width="40%" style="text-align: right">
                                                                <asp:Label ID="PointInfoLbl" runat="server" Text='<%# Eval("PointInfo")%>'></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="background-color: #e4e4e4; color: #ffffff; width: 325px; vertical-align: middle;">
                                                    <asp:Label ID="FooterLbl" runat="server" Text='<%# Eval("Footer")%>'></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                        </Columns>
                    </MasterTableView>
                </telerik:RadGrid>
                <asp:SqlDataSource ID="DashboardDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                    SelectCommand="usp_GeoPlotResults" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="HiddenTB_TopLeftLat" Name="TopLeftLat" PropertyName="Text"
                            Type="Double" />
                        <asp:ControlParameter ControlID="HiddenTB_TopLeftLong" Name="TopLeftLong" PropertyName="Text"
                            Type="Double" />
                        <asp:ControlParameter ControlID="HiddenTB_BottomRightLat" Name="BottomRightLat" PropertyName="Text"
                            Type="Double" />
                        <asp:ControlParameter ControlID="HiddenTB_BottomRightLong" Name="BottomRightLong"
                            PropertyName="Text" Type="Double" />
                        <asp:Parameter Name="PinList" DefaultValue="0" Type="String" />
                        <asp:SessionParameter Name="UserID" SessionField="PartyID" Type="Int32" />
                        <asp:ControlParameter ControlID="HiddenTB_TabName" Name="TabName" PropertyName="Text"
                            Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </telerik:RadPane>
            <telerik:RadSplitBar ID="VerticalSplitBar" runat="server" CollapseMode="Forward" />
            <telerik:RadPane ID="mapPane" runat="server">
                <div id='mapResults'>
                </div>
                <div id='map'>
                </div>
                <div class='mylegend' style="text-align: center; position: absolute; bottom: 25px;
                    right: 25px; border-radius: 5px; -moz-border-radius: 5px; -webkit-border-radius: 5px;
                    border: 1px solid #d9d9d9; background-color: rgba(255,255,255,0.5);">
                    <div id='jobdetails' style='display: none; width: 250px'>
                        <asp:Label ID="JobDetailsLbl" runat="server"></asp:Label>
                        <br />
                        <telerik:RadButton ID="ViewDetailsRB" runat="server" Text="View" OnClientClicked="OpenJobRadWindow"
                            AutoPostBack="false">
                            <Icon PrimaryIconUrl="/Images/Custom/view.png" PrimaryIconHeight="20px" PrimaryIconWidth="20px" />
                        </telerik:RadButton>
                        <telerik:RadButton ID="ApplyRB" runat="server" Text="Apply" AutoPostBack="false"
                            OnClientClicked="onApplyRB_Clicked">
                            <Icon PrimaryIconUrl="/Images/Custom/apply.png" PrimaryIconHeight="20px" PrimaryIconWidth="20px" />
                        </telerik:RadButton>
                        <telerik:RadButton ID="CloseRB" runat="server" Text="Close" AutoPostBack="false"
                            OnClientClicked="onCloseRB_Clicked">
                            <Icon PrimaryIconUrl="/Images/Custom/close.png" PrimaryIconHeight="20px" PrimaryIconWidth="20px" />
                        </telerik:RadButton>
                    </div>
                    <div>
                        <table width="100%">
                            <tr>
                                <td align="center" style="vertical-align: middle">
                                    <asp:Image ID="TruckerImg" runat="server" />
                                    <asp:Image ID="GaugeImage" runat="server" />
                                    <br />
                                    <asp:Label ID="TruckerInfoLbl" runat="server"></asp:Label>
                                    <telerik:RadButton ID="TruckerPaneRB" runat="server" Text="Add New Trucker" ToolTip="Click to add or find a new trucker."
                                        AutoPostBack="false" OnClientClicked="onTruckerPaneRBClicked" Visible="false">
                                    </telerik:RadButton>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
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
                        fireflyAPI.ready = function (x) {
                            if (typeof x == "function") x = [x];
                            fireflyAPI.onLoaded = fireflyAPI.onLoaded || [];
                            if (fireflyAPI.isLoaded) x.forEach(function (i) {
                                i()
                            });
                            else x.forEach(function (i) {
                                fireflyAPI.onLoaded.push(i)
                            })
                        };
                    </script>
                    <script type='text/javascript'>

                        var map = L.mapbox.map('map', 'fastport.map-zle7kuhd').setView([39.8282, -98.5795], 4);
                        map.addControl(L.mapbox.geocoderControl('fastport.map-zle7kuhd'));

                        map.markerLayer.on('click', function(e) {
                            var marker = e.layer,
                                feature = marker.feature;
                            markernotes = feature.properties.notes;
                            document.getElementById("HiddenTB_OriginLat").value = feature.geometry.coordinates[1];
                            document.getElementById("HiddenTB_OriginLong").value = feature.geometry.coordinates[0];
                        });

                        map.markerLayer.on('layeradd', function(e) {
                            var marker = e.layer,
                                feature = marker.feature;
                            marker.setIcon(L.icon(feature.properties.icon));
                            marker.bindPopup(feature.properties.notes);
                        });

                        var originlat;
                        var originlong;
                        var popupcontent;
                        var MeMarker;
                    
                        window.onload = function () {

                            v_TruckerPanel_All("Search");

                            if (document.getElementById("HiddenTB_HaveRole").value == "Trucker") {
                                var GaugeImageUrl = document.getElementById("HiddenTB_GaugeImageUrl").value;
                                document.getElementById("<%=GaugeImage.ClientID%>").src = GaugeImageUrl;
                                document.getElementById("<%=GaugeP2Img.ClientID%>").src = GaugeImageUrl;
                            }

                            originlat = document.getElementById("<%=HiddenTB_OriginLat.ClientID %>").value;
                            originlong = document.getElementById("<%=HiddenTB_OriginLong.ClientID %>").value;
            
                            if (originlat == "0" && originlong == "0") {
                                originlat = 39.8282;
                                originlong = -98.5795;
                                popupcontent = '<center>Welcome to FASTPORT! Here are some quick tips to get started:<br /><br />To explore the map for stops, jobs, and CB chatter, either type a city name in the search field or click the <strong><font color="red">CB Check-In</font></strong> button.<br /><br />Also, click <strong><font color="red">My FASTPORT</font></strong> to improve your FASTPORT and career.<br /><br />Happy trucking and click <strong><font color="red">Contact Us</font></strong> with any questions at all.<br /><br /><img src="../Images/Custom/button.png" onclick="return GetUserLocation();" />';
                            
                                MeMarker = "{'type':'Feature','geometry':{'type': 'Point','coordinates':[" + originlong + "," + originlat + "]},'properties': {'title': 'MePin','notes':'" + popupcontent + "','icon': {'iconUrl': '../Images/Custom/SavedFromApp/Tree/1876-Me.png','iconSize': [37, 37],'iconAnchor': [14, 37],'popupAnchor': [2, -32]}}}";
                    
                                var MePin = eval('[' + MeMarker + ']');
                                map.markerLayer.setGeoJSON(MePin);
                                map.invalidateSize();
                            } else {
                                 onCheckIn();
                            }
                            CreateHeatMap();
                            fireflyAPI.set('theme', 'black');
                            fireflyAPI.set('message', 'Please call 855-660-1770 and give the code above to your support representative');
                            fireflyAPI.set('whitelabel', true);
                        }
        
                        function v_TruckerPanel_All(mode) {

                            var role = document.getElementById("<%=HiddenTB_HaveRole.ClientID %>").value;

                            var GaugeP2Row = document.getElementById("GaugeP2Row");
                            var FastportP2RBRow = document.getElementById("FastportP2RBRow");

                            if (role=="Trucker") {
                                GaugeP2Row.style.display = "";
                                FastportP2RBRow.style.display = "";
                            } else {
                                GaugeP2Row.style.display = "none";
                                FastportP2RBRow.style.display = "none";
                                v_TruckerPanel_First("search");
                            }

                        }

                        function onDashboardRGCreated(sender) {
                            var tabs = sender.get_tabs();
                            if (document.getElementById("HiddenTB_HaveRole").value != "Trucker") {
                                tabs.getTab(0).set_text("Jobs");
                                tabs.getTab(1).set_text("Recruits");
                                tabs.getTab(2).set_text("Active");
                            }
                        }

                        function v_TruckerPanel_First(mode) {
    
                        var PasswordRow = document.getElementById("PasswordRow");
                        var SearchMobileRow = document.getElementById("SearchMobileRow");
                        var NameRow = document.getElementById("NameRow");
                        var SearchRBRow = document.getElementById("SearchRBRow");
                        var SearchRGRow = document.getElementById("SearchRGRow");
                        var HandleRow = document.getElementById("HandleRow");
                        var TruckerTypeRow = document.getElementById("TruckerTypeRow");
                        var MobileRow = document.getElementById("MobileRow");
                        var DirectDialRow = document.getElementById("DirectDialRow");
                        var MobileRow = document.getElementById("MobileRow");
                        var FaxRow = document.getElementById("FaxRow");
                        var SaveTruckerRow = document.getElementById("SaveTruckerRow");
                        var GaugeP1Row = document.getElementById("GaugeP1Row");
                        var FastportR1RBRow = document.getElementById("FastportR1RBRow");

                            if (mode == "search") {
                            
                                PasswordRow.style.display = "none";
                                SearchMobileRow.style.display = "";
                                SearchRBRow.style.display = "";
                                SearchRGRow.style.display = "";
                                HandleRow.style.display = "none";
                                TruckerTypeRow.style.display = "none";
                                MobileRow.style.display = "none";
                                DirectDialRow.style.display = "none";
                                MobileRow.style.display = "none";
                                FaxRow.style.display = "none";
                                SaveTruckerRow.style.display = "none";
                                GaugeP1Row.style.display = "none";
                                FastportR1RBRow.style.display = "none";

                            } else {
                        
                                SearchRBRow.style.display = "none";
                                SearchRGRow.style.display = "none";
                                HandleRow.style.display = "";
                                TruckerTypeRow.style.display = "";
                                MobileRow.style.display = "";
                                DirectDialRow.style.display = "";
                                MobileRow.style.display = "";
                                FaxRow.style.display = "";
                                SaveTruckerRow.style.display = "";

                                if (mode=="add") {
                                
                                    PasswordRow.style.display = "";
                                    GaugeP1Row.style.display = "none";
                                    FastportR1RBRow.style.display = "none";

                                } else {
                            
                                    PasswordRow.style.display = "none";
                                    GaugeP1Row.style.display = "";
                                    FastportR1RBRow.style.display = "";

                                }

                            }

                        }

                        function onCheckIn() {

                            map.invalidateSize();
        
                            if (!navigator.geolocation) {
                                alert("Your browser does not support geolocation.")
                            } else {
                                map.locate();
                            }
                        
                            map.on('locationfound', function (e) {
                        
                                popupcontent = '<center>Hi there!<br /><br />Do not forget to check in near hear by clicking the CB Check-In button.<br /><br /><img src="../Images/Custom/button.png" onclick="return GetUserLocation();" /></center>';
                                MeMarker = "{'type':'Feature','geometry':{'type': 'Point','coordinates':[" + e.latlng.lng + "," + e.latlng.lat + "]},'properties': {'title': 'MePin','notes':'" + popupcontent + "','icon': {'iconUrl': '../Images/Custom/SavedFromApp/Tree/1876-Me.png','iconSize': [37, 37],'iconAnchor': [14, 37],'popupAnchor': [2, -32]}}}";
                    
                                document.getElementById("HiddenTB_OriginLat").value = e.latlng.lat;
                                document.getElementById("HiddenTB_OriginLong").value = e.latlng.lng;
                                document.getElementById("HiddenTB_CenterLat").value = e.latlng.lat;
                                document.getElementById("HiddenTB_CenterLong").value = e.latlng.lng;

                                var MePin = eval('[' + MeMarker + ']');
                                map.markerLayer.setGeoJSON(MePin);
                                map.setView(e.latlng, 8);

                                L.popup({ offset: [2, -32] }).setLatLng(e.latlng).setContent(popupcontent).openOn(map);
                            });

                            map.on('locationerror', function () {

                                popupcontent = '<center>Hi there!<br /><br />FASTPORT was unable to determine your location, so your past location is being displayed. Click the CB Check-In to update your current location and move the map.<br /><br /><img src="../Images/Custom/button.png" onclick="return onCheckIn();" /></center>';
                                MeMarker = "{'type':'Feature','geometry':{'type': 'Point','coordinates':[" + originlong + "," + originlat + "]},'properties': {'title': 'MePin','notes':'" + popupcontent + "','icon': {'iconUrl': '../Images/Custom/SavedFromApp/Tree/1876-Me.png','iconSize': [37, 37],'iconAnchor': [14, 37],'popupAnchor': [2, -32]}}}";
                            
                                var MePin = eval('[' + MeMarker + ']');
                                map.markerLayer.setGeoJSON(MePin);
                            
                                map.setView([originlat,originlong], 8);

                                L.popup({ offset: [2, -32] }).setLatLng([originlat,originlong]).setContent(popupcontent).openOn(map);
                            });
                        }

                        function GetUserLocation() {

                            map.markerLayer.clearLayers();
                            map.invalidateSize();

                            originlat = document.getElementById("HiddenTB_OriginLat").value;
                            originlong = document.getElementById("HiddenTB_OriginLong").value;
                            document.getElementById("HiddenTB_CenterLat").value = originlat;
                            document.getElementById("HiddenTB_CenterLong").value = originlong;

                            setTimeout(function() {
                                map.setView([originlat, originlong], 8);
                            }, 100);
                        }

                        setTimeout(function() {
                            map.on('zoomend', function() {
                                map.closePopup();
                                LoadMarkers();
                            });
                        }, 50);

                        setTimeout(function() {
                            map.on('dragend', function() {
                                map.closePopup();
				                LoadMarkers();
                            });
                        }, 50);

                        var AllLayers = new L.FeatureGroup();
                        var geoJson;
                        var markernotes;

                        function LoadMarkers() {
                        
                            map.markerLayer.clearLayers();
                            map.invalidateSize();

                            document.getElementById("HiddenTB_TopLeftLat").value = map.getBounds().getNorthWest().lat;
				            document.getElementById("HiddenTB_TopLeftLong").value = map.getBounds().getNorthWest().lng;
				            document.getElementById("HiddenTB_BottomRightLat").value = map.getBounds().getSouthEast().lat;
				            document.getElementById("HiddenTB_BottomRightLong").value = map.getBounds().getSouthEast().lng;
                            document.getElementById("HiddenTB_CenterLat").value = map.getCenter().lat;
                            document.getElementById("HiddenTB_CenterLong").value = map.getCenter().lng;

                            if (map.getZoom() >= 8 && POICat != "Job") {
                            
                                var TopLeftLat = document.getElementById("HiddenTB_TopLeftLat").value;
                                var TopLeftLong = document.getElementById("HiddenTB_TopLeftLong").value;
                                var BottomRightLat = document.getElementById("HiddenTB_BottomRightLat").value;
                                var BottomRightLong = document.getElementById("HiddenTB_BottomRightLong").value;
                                var selectedTab = document.getElementById("HiddenTB_TabName").value;
                                var truckerid = document.getElementById("HiddenTB_TruckerID").value;

                                SendCallBack("LoadGeoJson," + TopLeftLat + "," + TopLeftLong + "," + BottomRightLat + "," + BottomRightLong + "," + selectedTab+ "," + truckerid, "LoadGeoJson");

                            } else {
                            
                                map.closePopup();

                            }
                        }

                        function LoadMarkers_back(arg) {
                        
                            var centerlat = document.getElementById("HiddenTB_CenterLat").value;
                            var centerlong = document.getElementById("HiddenTB_CenterLong").value;
                            originlat = document.getElementById("HiddenTB_OriginLat").value;
                            originlong = document.getElementById("HiddenTB_OriginLong").value;

                            MeMarker = "{'type':'Feature','geometry':{'type': 'Point','coordinates':[" + originlong + "," + originlat + "]},'properties': {'title': 'MePin','notes':'" + popupcontent + "','icon': {'iconUrl': '../Images/Custom/SavedFromApp/Tree/1876-Me.png','iconSize': [37, 37],'iconAnchor': [14, 37],'popupAnchor': [2, -32]}}}";
                        
                            var string;
                            //if (centerlat == originlat && centerlong == originlong) {
                                string = "[" + arg + "," + MeMarker + "]";
    //                        } else {
    //                            string = "[" + arg + "]";
    //                        }
                            geoJson = eval(string);
                            map.markerLayer.setGeoJSON(geoJson);
                            map.setView([centerlat, centerlong], map.getZoom());
                            $find("<%=DashboardRG.ClientID %>").get_masterTableView().rebind();
                            if (popupcontent != markernotes && markernotes != null && centerlat == originlat && centerlong == originlong) {
                                L.popup({ offset: [2, -32] }).setLatLng([centerlat, centerlong]).setContent(markernotes).openOn(map);
                            }
                        }

                        function onEachFeature(feature, layer) {
                            layer.on('click', function (e) {
                                if (feature.properties.color == "#0000ff") {
                                    var notes = feature.properties.notes;
                                    var array = notes.split(' !?| ');
                                    notes = '<strong><span style="text-decoration: underline;">' + array[0] + '</span></strong><br /><br />' + array[1];
                                    layer.bindPopup(notes).openPopup();
                                }
                            });
                        }

                        var heatmapLayer;

                        function CreateHeatMap() {
                            heatmapLayer = L.TileLayer.heatMap({
                                radius: 20,
                                opacity: 1,
                                gradient: {
                                    0.45: "rgb(0,0,255)",
                                    0.55: "rgb(0,255,255)",
                                    0.65: "rgb(0,255,0)",
                                    0.95: "yellow",
                                    1.0: "rgb(255,0,0)"
                                }
                            });

                            var testData = document.getElementById("<%=HiddenTB_HeatMapData.ClientID %>").value;
                            testData = eval("[" + testData + "]");
                            heatmapLayer.addData(testData);
                            setTimeout(function () {
                                heatmapLayer.addTo(map);
                            }, 0);
                        }

                        //telerik stuffs

                        function onRTSTabSelected(sender,args) {

                            var selectedTab = $find("<%=DashboardRTS.ClientID %>").get_selectedTab().get_text();
                            document.getElementById("jobdetails").style.display = "none";
                            var TopLeftLat = document.getElementById("HiddenTB_TopLeftLat").value;
                            var TopLeftLong = document.getElementById("HiddenTB_TopLeftLong").value;
                            var BottomRightLat = document.getElementById("HiddenTB_BottomRightLat").value;
                            var BottomRightLong = document.getElementById("HiddenTB_BottomRightLong").value;
                            document.getElementById("HiddenTB_TabName").value = selectedTab;
                        
                            AllLayers.clearLayers();
                            SendCallBack("LoadSelection," + TopLeftLat + "," + TopLeftLong + "," + BottomRightLat + "," + BottomRightLong + "," + selectedTab, "LoadSelection");
                        
                        }

                        function onRTSTabSelected_back(arg) {
                        
                            map.markerLayer.clearLayers();
                            var centerlat = document.getElementById("HiddenTB_CenterLat").value;
                            var centerlong = document.getElementById("HiddenTB_CenterLong").value;
                            var geodata = arg;

                            geoJson = eval('[' + geodata + ',' + MeMarker + ']');
                            map.markerLayer.setGeoJSON(geoJson);
                            map.setView([centerlat, centerlong], map.getZoom());
                            $find("<%=DashboardRG.ClientID %>").get_masterTableView().rebind();
            
                        }

                        function onAdGeoRGCreated(sender,args) {
                        
                            var gridheight = document.getElementById("RAD_SPLITTER_PANE_CONTENT_resultsPane").style.height;
                            var griddataheight = gridheight.replace('px','') - 50;
                            $("#DashboardRG_GridData").css("height", griddataheight);

                        }

                        function onImageClick() {
                        
                            AllLayers.clearLayers();
                            var AdID = document.getElementById("HiddenTB_PK").value;
                            SendCallBack("LoadJobs," + AdID, "LoadJobs");
                            document.getElementById("<%=JobDetailsLbl.ClientID %>").innerHTML = markernotes;
                            document.getElementById("jobdetails").style.display = "";
                            document.getElementById("<%=GaugeImage.ClientID%>").style.display = "none";
                        }

                        var POICat;

                        function onAdGeoRGRowSelected(sender, eventArgs) {
                        
                            var PK = eventArgs.getDataKeyValue("PK");
                            POICat = eventArgs.getDataKeyValue("POICat");
                            var Lat = eventArgs.getDataKeyValue("Lat");
                            var Long = eventArgs.getDataKeyValue("Long");
                            var PointInfo = eventArgs.getDataKeyValue("PointInfo");
                            var PointID = eventArgs.getDataKeyValue("ReturnID");
                            markernotes = eventArgs.getDataKeyValue("AllDetails");

                            var selectedTab = $find("<%=DashboardRTS.ClientID %>").get_selectedTab().get_text();
                            document.getElementById("HiddenTB_PointID").value = PointID;
                            document.getElementById("HiddenTB_PK").value = PK;
                        
                            AllLayers.clearLayers();
                            if (POICat == "Job") {
                                SendCallBack("LoadJobs," + PK, "LoadJobs");
                                document.getElementById("<%=JobDetailsLbl.ClientID %>").innerHTML = markernotes;
                                document.getElementById("jobdetails").style.display = "";
                                document.getElementById("<%=GaugeImage.ClientID%>").style.display = "none";
                            } else {
                                var coords = [Lat, Long];
                                map.setView(coords, 8);
                                LoadMarkers();
                                document.getElementById("jobdetails").style.display = "none";
                                document.getElementById("<%=GaugeImage.ClientID%>").style.display = "";
                                map.addLayer(heatmapLayer);
                            }
                        }

                        function onAdGeoRGRowSelected_back(arg) {
                        
                            map.removeLayer(heatmapLayer);
                            document.getElementById("HiddenTB_PastLat").value = map.getCenter().lat;
                            document.getElementById("HiddenTB_PastLong").value = map.getCenter().lng;
                            document.getElementById("HiddenTB_MapZoomLevel").value = map.getZoom();
                            map.markerLayer.clearLayers();

                            var geodata = arg;
                            var mySplit = geodata.split("<|>", 3);

                            var geolanes = mySplit[0] || "";
                            var georegions = mySplit[1] || "";
                            var georadii = mySplit[2] || "";
                
                            map.closePopup();

                            if (geolanes != "0") {
                                geolanes = eval('[{"type":"FeatureCollection","features":[' + geolanes + ']}]');
                                AllLayers.addLayer(L.geoJson(geolanes, {
                                    style: function (feature) {
                                        return {color: feature.properties.color};
                                    },
                                    onEachFeature: onEachFeature
                                }));
                            }

                            if (georegions != "0") {
                                georegions = eval('[{"type":"FeatureCollection","features":[' + georegions + ']}]');
                                AllLayers.addLayer(L.geoJson(georegions, {
                                    style: function (feature) {
                                        return {color: feature.properties.color};
                                    },
                                    onEachFeature: onEachFeature
                                }));
                            }

                            if (georadii != "0") {
                                georadii = eval('[' + georadii + ']');
                                for (var i = 0; i < georadii.length; i++) {
                                    var circle_i = georadii[i];
                                    var circle = L.circle(circle_i[0], circle_i[1], circle_i[2]);
                                    if (circle_i[2] != null) {
                                        var notes = circle_i[2].notes;
                                        var array = notes.split(' !?| ');
                                        notes = '<strong><span style="text-decoration: underline;">' + array[0] + '</span></strong><br /><br />' + array[1];
                                        circle.bindPopup(notes);
                                    }
                                    AllLayers.addLayer(circle);
                                }
                            }
                            AllLayers.addTo(map);
                            var bounds = AllLayers.getBounds();
                            map.fitBounds(bounds);
                        }

                        function onTruckerAddRBClicked() {

                            alert("Add Trucker");

                        }

                        function onTruckerPaneRBClicked() {

                            alert("Clicked");

                        }

                        function onEmailRTBChanged(sender, eventArgs) {

                            var newvalue = eventArgs.get_newValue()
                            var mytextbox = document.getElementById("<%=HiddenTB_SearchEmail.ClientID %>")
                        
                            if (newvalue) {
                                mytextbox.value = newvalue;
                            } else {
                                mytextbox.value = "0";
                            }
                        }
                    
                        function onSearchMobileRTBChanged(sender, eventArgs) {
                    
                            var newvalue = eventArgs.get_newValue()
                            var mytextbox = document.getElementById("<%=HiddenTB_SearchMobile.ClientID %>")
                            var MobileRTB = $find("<%=MobileRTB.ClientID %>")
                        
                            if (newvalue) {
                                mytextbox.value = newvalue;
                                MobileRTB.set_value(newvalue);
                            } else {
                                mytextbox.value = "0";
                                MobileRTB.set_value("");
                            }
                        }
                    
                        function onNameRTBChanged(sender, eventArgs) {
                    
                            var newvalue = eventArgs.get_newValue()
                            var mytextbox = document.getElementById("<%=HiddenTB_SearchName.ClientID %>")
                        
                            if (newvalue) {
                                mytextbox.value = newvalue;
                            } else {
                                mytextbox.value = "0";
                            }

                        }

                        function onRightRPExpanded(sender) {
                            var width = sender.get_width() + 30;
                            $(".mylegend").css("right", width);
                        }

                        function onRightRPCollapsed() {
                            $(".mylegend").css("right", 25);
                        }

                        function OpenRadWindow(arg) {
                        
                            var myString = arg;
                            var mySplit = myString.split("<|>", 5);

                            var POI = mySplit[0] || "";
                            var ContactInfo = mySplit[1] || "";
                            var Pins = mySplit[2] || "";
                            var PointStats = mySplit[3] || "";

                            document.getElementById("<%=POILbl.ClientID %>").innerHTML = POI;
                            document.getElementById("PointRW_C_ContactInfoLbl").innerHTML = ContactInfo;
                            document.getElementById("PointRW_C_PinsLbl").innerHTML = Pins;
                            document.getElementById("PointRW_C_PointStatsLbl").innerHTML = PointStats;
                            $find("<%=RadAjaxManager1.ClientID %>").ajaxRequest("rebindReviewsRG");
                            $find("<%=PointRW.ClientID %>").show();

                        }

                        function OpenJobRadWindow() {
                        
                            var myID = document.getElementById("HiddenTB_PointID").value;
			                var myAdID = document.getElementById("HiddenTB_PK"). value;
                            var myLat = document.getElementById("HiddenTB_PastLat").value;
                            var myLong = document.getElementById("HiddenTB_PastLong").value;
						    myID = "LoadJobData," + myID + "," + myAdID + "," + myLat + "," + myLong
                            CallRadWindow(myID, "ViewJob");

                        }

                        function OpenJobRadWindow_back(arg) {

                            var JobRadWindow = $find("<%=JobRadWindow.ClientID %>");

                            var myURL = arg;
                            JobRadWindow.setUrl(myURL);
                            JobRadWindow.show();

                        }

                        function onApplyRB_Clicked() {
                            alert('Clicked');
                        }

                        function onCloseRB_Clicked() {
                            var pastlat = document.getElementById("HiddenTB_PastLat").value;
                            var pastlong = document.getElementById("HiddenTB_PastLong").value;
                            var pastzoomlevel = document.getElementById("HiddenTB_MapZoomLevel").value;

                            document.getElementById("jobdetails").style.display = "none";
                            document.getElementById("<%=GaugeImage.ClientID%>").style.display = "";
                            POICat = "Amenity";
                            AllLayers.clearLayers();
                            map.setView([pastlat, pastlong], pastzoomlevel);
                            map.addLayer(heatmapLayer);
                        }

                        function onViewSourceRB_Clicked(sender) {
                            var targetcontrolid = sender.get_id();
                            var TruckerID = document.getElementById("HiddenTB_TruckerID").value;
                            if (TruckerID == "0") {
                                launchRadAlert("Please select a trucker using the right hand pane before trying to show where the trucker 'saw' a this job posting.", "No Trucker Selected");
                            } else {
                                var ViewSourceRTT = $find("<%=ViewSourceRTT.ClientID %>");
                                var targetID = ViewSourceRTT.get_targetControlID();
                                ViewSourceRTT.set_targetControlID(targetcontrolid);
                                setTimeout(function(){
                                    ViewSourceRTT.show();
                                }, 50);
                            }
                        }

                        function onAutoCompleteBoxEntryAdding(sender, eventArgs) {
                            var entries = sender.get_entries(),
                                count = entries.get_count();
                            if (count == 1) {
                                eventArgs.set_cancel(true);
                            }
                        }

                        function onSaveRB_Clicked() {
                            $find("<%=JobFoundRAC.ClientID %>").get_entries().clear();
                            $find("<%=PostingCitiesRAC.ClientID %>").get_entries().clear();
                            $find("<%=ViewSourceRTT.ClientID %>").hide();
                        }

                        function onDivMouseOver(sender) {
                            var AdID = sender.id;
                            var PointID = sender.dir;
                            markernotes = sender.title;
                            document.getElementById("HiddenTB_PK").value = AdID;
                            document.getElementById("HiddenTB_PointID").value = PointID;
                        }

                        function showPrefRTT(mybutton, myprefparentids) {

                            document.getElementById("<%= HiddenTB_PrefParentID.ClientID %>").value = myprefparentids;

                            var PrefRTT = $find("<%=PrefRTT.ClientID %>");

                            var mytargetname;
                            switch (mybutton) {
                            case "Pref_GeneralRB":
                                {
                                    mytargetname = "TruckerRPB_i1_Pref_GeneralRACPanel";
                                    break;
                                }
                            case "Pref_EquipRB":
                                {
                                    mytargetname = "TruckerRPB_i1_Pref_EquipRACPanel";
                                    break;
                                }
                            case "Pref_CommodityRB":
                                {
                                    mytargetname = "TruckerRPB_i1_Pref_CommodityRACPanel";
                                    break;
                                }
                            case "Pref_RegionsRB":
                                {
                                    mytargetname = "TruckerRPB_i1_Pref_RegionsRACPanel";
                                    break;
                                }
                            case "Pref_OtherRB":
                                {
                                    mytargetname = "TruckerRPB_i1_Pref_OtherRACPanel";
                                    break;
                                }
                            }

                            var mytarget = document.getElementById(mytargetname);
                            PrefRTT.set_targetControl(mytarget);
                            setTimeout(function () {
                                PrefRTT.show();
                            }, 2000);
                        }

                        function getExpID(sender, eventArgs) {
                            var rowID = eventArgs.getDataKeyValue("PartyExperienceID");
                            document.getElementById("<%= HiddenTB_MouseOverID.ClientID %>").value = rowID;
                        }

                        var issliding = false;

                        function slideStart() {
                            issliding = true;
                        }

                        var slidervalue;

                        function sliderChanged(sender, args) {

                            slidervalue = args.get_newValue();
                            if (issliding == false) {
                                updateSlider(slidervalue);
                            }
                        }

                        function slideEnd() {

                            issliding = false;
                            updateSlider(slidervalue);

                        }

                        function updateSlider(slidervalue) {

                            var expid = document.getElementById("<%= HiddenTB_MouseOverID.ClientID %>").value;
                            SendCallBack("updateExpSlider," + expid + "," + slidervalue, "updateExpSlider");

                        }

                        function closePrefRTT() {

                            var tooltip = $find("<%=PrefRTT.ClientID %>");
                            tooltip.set_targetControl(null);
                            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindPrefs");

                        }

                        function onPrefRTT_DelIBClick(index) {

                            var grid = $find("<%=PrefRG.ClientID %>");
                            var MasterTable = grid.get_masterTableView();
                            var row = MasterTable.get_dataItems()[index];
                            var partyexperienceid = row.getDataKeyValue("PartyExperienceID");
                            var itemname = row.getDataKeyValue("ItemName");
                            confirmCall("deletePrefItem", partyexperienceid, itemname);

                        }

                        //RadAlert
                        function GetRadWindow() {
                            var oWindow = null;
                            if (window.radWindow) oWindow = window.radWindow;
                            else if (window.frameElement && window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
                            return oWindow;
                        }

                        function launchRadAlert(alertMess, alertTitle) {

                            var oWnd = GetRadWindow();
                            if (oWnd != null) {
                                setTimeout(function () {
                                    GetRadWindow().BrowserWindow.radalert(alertMess, 400, 115, alertTitle, null, "/Images/Custom/OkayLowRes.png");
                                }, 0);
                            }
                            //Info: Used to launch from a parent page.
                            else {
                                radalert(alertMess, 400, 115, alertTitle, null, "/Images/Custom/OkayLowRes.png");
                            }

                        }

                        //SendCallBack function
                        function confirmCall(callType, callID, callName) {
                            confirmType = callType;
                            confirmID = callID;
                            var confirmMess;
                            var confirmTitle;


                            //Step 2:  Configure your messsage types here.
                            if (callType == "deletePrefItem") {

                                confirmMess = "Are you certain that you wish to <span style='color: #ff0000;'>permanently</span> delete the experience named: " + callName + "?";
                                confirmTitle = "Delete " & callName & " ?";
                                launchRadConfirm(confirmMess, confirmTitle);

                            }
                        }

                        function confirmCallBackFn(arg) {

                            //Step 3:  Config different callbacks if required.  If you have only 2 parameters, these will do.
                            if (arg == true) {

                                if (confirmType == "deletePrefItem") {

                                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest(confirmType + "," + confirmID);

                                }
                            }
                        }

                        function CallRadWindow(myID, myAction) {
                            switch (myAction) {
                                case "ViewPoint":
                                    {
                                        document.getElementById("HiddenTB_PointID").value = myID;
                                        SendCallBack("LoadMarkerData," + myID, "LoadMarkerData");
                                        break;
                                    }
                                case "ViewJob":
                                    {
                                        SendCallBack(myID, "LoadJobData");
                                        break;
                                    }
                            }
                        }

                        function SendCallBack(arg, myAction) {

                            try {
                                switch (myAction) {
                                    case "LoadGeoJson":
                                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "LoadMarkers_back", "null") %>
                                            break;
                                        }
                                    case "LoadTabSelected":
                                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onRTSTabSelected_back", "null") %>
                                            break;
                                        }
                                    case "LoadSelection":
                                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onRTSTabSelected_back", "null") %>
                                            break;
                                        }
                                    case "LoadJobs":
                                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onAdGeoRGRowSelected_back", "null") %>
                                            break;
                                        }
                                    case "LoadMarkerData":
                                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "OpenRadWindow", "null") %>
                                            break;
                                        }
                                    case "LoadJobData":
                                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "OpenJobRadWindow_back", "null") %>
                                            break;
                                        }
                                }
                            } catch (e) {}
                        }
                    </script>
                </telerik:RadCodeBlock>
            </telerik:RadPane>
            <telerik:RadSplitBar ID="RightRSB" runat="server" CollapseMode="Backward">
            </telerik:RadSplitBar>
            <telerik:RadPane ID="RightRP" runat="server" Collapsed="true" Width="375px" OnClientExpanded="onRightRPExpanded"
                OnClientCollapsed="onRightRPCollapsed">
                <telerik:RadPanelBar runat="server" ID="TruckerRPB" Width="100%" Height="100%" Skin="BlackMetroTouch"
                    ExpandMode="FullExpandedItem">
                    <Items>
                        <telerik:RadPanelItem Expanded="true" Text="Trucker Info" Font-Size="Medium">
                            <ContentTemplate>
                                <table style="line-height: 20px; background: white; color: Black;">
                                    <tr id="GeneralInstructionsRow">
                                        <td colspan="2" class="dfv" style="padding: 6px;">
                                            <asp:Label ID="GeneralInstructionsLbl" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr id="EmailRow">
                                        <td class="fls">
                                            <asp:Label runat="server" ID="EmailLabel" Text="SEARCH by Email"></asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadTextBox ID="EmailRTB" runat="server" Width="167px" TabIndex="1">
                                                <ClientEvents OnValueChanged="onEmailRTBChanged" />
                                            </telerik:RadTextBox>
                                            <asp:RegularExpressionValidator ID="emailValidator" runat="server" Display="Dynamic"
                                                ErrorMessage="Please enter valid e-mail." ValidationExpression="^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$"
                                                ControlToValidate="EmailRTB">
                                            </asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr id="PasswordRow">
                                        <td class="fls">
                                            <asp:Label runat="server" ID="PasswordLbl" Text="Password"></asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadTextBox ID="PasswordRTB" runat="server" Width="167px" TabIndex="1">
                                            </telerik:RadTextBox>
                                        </td>
                                    </tr>
                                    <tr id="SearchMobileRow">
                                        <td class="fls">
                                            <asp:Label runat="server" ID="SearchMobileLabel" Text="OR Mobile"></asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadMaskedTextBox ID="SearchMobileRTB" runat="server" Mask="###-###-####"
                                                Width="167px" TabIndex="6">
                                                <ClientEvents OnValueChanged="onSearchMobileRTBChanged" />
                                            </telerik:RadMaskedTextBox>
                                        </td>
                                    </tr>
                                    <tr id="NameRow">
                                        <td class="fls">
                                            <asp:Label runat="server" ID="NameLabel" Text="OR Name"></asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadTextBox ID="NameRTB" runat="server" Width="167px" TabIndex="2">
                                                <ClientEvents OnValueChanged="onNameRTBChanged" />
                                            </telerik:RadTextBox>
                                        </td>
                                    </tr>
                                    <tr id="SearchRBRow">
                                        <td colspan="2">
                                            <br />
                                            <center>
                                                <telerik:RadButton ID="SearchForTruckerRB" runat="server" Text="SEARCH for Trucker"
                                                    ToolTip="Click here to SEARCH for the trucker by email, mobile, or name." AutoPostBack="true">
                                                </telerik:RadButton>
                                            </center>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr id="SearchRGRow">
                                        <td colspan="2">
                                            <center>
                                                <telerik:RadGrid ID="PickTruckerRG" runat="server" DataSourceID="PickTruckerDS" ShowHeader="False"
                                                    Width="200px" Height="225px" AutoGenerateColumns="False" CellSpacing="0" GridLines="None">
                                                    <ClientSettings Selecting-AllowRowSelect="True">
                                                        <Scrolling AllowScroll="true" />
                                                    </ClientSettings>
                                                    <MasterTableView DataSourceID="PickTruckerDS" DataKeyNames="PartyID" ClientDataKeyNames="PartyID"
                                                        EnableNoRecordsTemplate="true">
                                                        <NoRecordsTemplate>
                                                            <div style="padding: 25px;">
                                                                Please search carefully for your trucker by email, mobile number, or name. If you
                                                                are certain that the trucker is not in the FASTPORT, please add the trucker by clicking:<br />
                                                                <br />
                                                                <center>
                                                                    <telerik:RadButton ID="TruckerAddRB" runat="server" Text="ADD New Trucker" ToolTip="Click here to add your trucker from scratch."
                                                                        AutoPostBack="false" OnClientClicked="onTruckerAddRBClicked" TabIndex="6">
                                                                    </telerik:RadButton>
                                                                </center>
                                                            </div>
                                                        </NoRecordsTemplate>
                                                        <Columns>
                                                            <telerik:GridBoundColumn DataField="PartyInfo" UniqueName="PartyInfo">
                                                            </telerik:GridBoundColumn>
                                                        </Columns>
                                                    </MasterTableView>
                                                </telerik:RadGrid>
                                                <asp:SqlDataSource ID="PickTruckerDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                    SelectCommand="usp_PersonFind" SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="HiddenTB_SearchEmail" DefaultValue="0" Name="Email"
                                                            PropertyName="Text" Type="String" />
                                                        <asp:ControlParameter ControlID="HiddenTB_SearchMobile" DefaultValue="0" Name="Mobile"
                                                            PropertyName="Text" Type="String" />
                                                        <asp:ControlParameter ControlID="HiddenTB_SearchName" DefaultValue="0" Name="Name"
                                                            PropertyName="Text" Type="String" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                            </center>
                                        </td>
                                    </tr>
                                    <tr id="HandleRow">
                                        <td class="fls">
                                            <asp:Label runat="server" ID="HandleLabel" Text="Handle">	</asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadTextBox ID="HandleRTB" runat="server" Width="167px" TabIndex="3">
                                            </telerik:RadTextBox>
                                        </td>
                                    </tr>
                                    <tr id="TruckerTypeRow">
                                        <td class="fls">
                                            <asp:Label runat="server" ID="TruckerTypeLabel" Text="I Am A">	</asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadComboBox ID="TruckerTypeRCB" runat="server" DataSourceID="TruckerTypeDS"
                                                DataTextField="ItemName" DataValueField="TreeID" MarkFirstMatch="True" ShowToggleImage="True"
                                                TabIndex="4" Width="167px" ZIndex="50001">
                                            </telerik:RadComboBox>
                                            <asp:SqlDataSource ID="TruckerTypeDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                SelectCommand="SELECT tt.* FROM (SELECT TreeID = '0', ItemName = '**Please Select**', ItemRank = -1 UNION SELECT TreeID, ItemName, ItemRank FROM dbo.Tree WHERE TreeParentID = 2527) tt ORDER BY tt.ItemRank">
                                            </asp:SqlDataSource>
                                        </td>
                                    </tr>
                                    <tr id="MobileRow">
                                        <td class="fls">
                                            <asp:Label runat="server" ID="MobileLbl" Text="Mobile">	</asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadMaskedTextBox ID="MobileRTB" runat="server" Mask="###-###-####" Width="167px"
                                                TabIndex="6">
                                            </telerik:RadMaskedTextBox>
                                        </td>
                                    </tr>
                                    <tr id="DirectDialRow">
                                        <td class="fls">
                                            <asp:Label runat="server" ID="DirectDialLabel" Text="Landline">	</asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadMaskedTextBox ID="DirectDialRTB" runat="server" Mask="###-###-#### #####"
                                                Width="167px" TabIndex="5">
                                            </telerik:RadMaskedTextBox>
                                        </td>
                                    </tr>
                                    <tr id="FaxRow">
                                        <td class="fls">
                                            <asp:Label runat="server" ID="FaxLabel" Text="Fax">	</asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadMaskedTextBox ID="FaxRTB" runat="server" Mask="###-###-####" Width="167px"
                                                TabIndex="8">
                                            </telerik:RadMaskedTextBox>
                                        </td>
                                    </tr>
                                    <tr id="SaveTruckerRow">
                                        <td colspan="2">
                                            <center>
                                                <telerik:RadButton ID="SaveTruckerRB" runat="server" Text="Save" ToolTip="Click here to save this trucker."
                                                    AutoPostBack="true">
                                                </telerik:RadButton>
                                            </center>
                                        </td>
                                    </tr>
                                    <tr id="GaugeP1Row">
                                        <td colspan="2">
                                            <asp:Image ID="GaugeP1Img" runat="server" Width="110px" Height="175px" />
                                        </td>
                                    </tr>
                                    <tr id="FastportR1RBRow">
                                        <td colspan="2">
                                            <center>
                                                <telerik:RadButton ID="FastportP1RB" runat="server" Text="Save" ToolTip="Click here to edit this trucker's FASTPORT."
                                                    AutoPostBack="true">
                                                </telerik:RadButton>
                                            </center>
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </telerik:RadPanelItem>
                        <telerik:RadPanelItem Text="Trucker 'Wants'" Expanded="false" Font-Size="Medium">
                            <ContentTemplate>
                                <table style="line-height: 20px; background: white; color: Black;">
                                    <tr>
                                        <td colspan="2" class="dfv">
                                            <asp:Label ID="PrefsInstructionsLbl" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr id="GaugeP2Row">
                                        <td colspan="2">
                                            <center>
                                                <asp:Image ID="GaugeP2Img" runat="server" Width="110px" Height="175px" />
                                            </center>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr id="FastportP2RBRow">
                                        <td colspan="2">
                                            <center>
                                                <telerik:RadButton ID="FastportP2RB" runat="server" Text="My FASTPORT" ToolTip="Click here to improve your FASTPORT."
                                                    AutoPostBack="true">
                                                </telerik:RadButton>
                                            </center>
                                        </td>
                                    </tr>
                                    <tr class="dfv">
                                        <td class="fls">
                                            <asp:Label runat="server" ID="Pref_GeneralLbl" Text="CDL, Etc.">	</asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadAutoCompleteBox ID="Pref_GeneralRAC" runat="server" Filter="Contains"
                                                DataSourceID="Pref_GeneralDS" DataValueField="TreeID" DataTextField="TreeFull"
                                                InputType="Token" DropDownWidth="250px" Width="230px">
                                                <DropDownItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem, "TreeFullHTML")%>
                                                </DropDownItemTemplate>
                                            </telerik:RadAutoCompleteBox>
                                            <asp:SqlDataSource ID="Pref_GeneralDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                SelectCommand="usp_Pref_GeneralRollUp" SelectCommandType="StoredProcedure">
                                                <SelectParameters>
                                                    <asp:Parameter DefaultValue="743" Name="Pref_GeneralPrune" Type="String" />
                                                </SelectParameters>
                                            </asp:SqlDataSource>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadButton ID="Pref_GeneralRB" runat="server" Text="+/-" OnClientClicked="function (button,args){showPrefRTT('Pref_GeneralRB','743');}">
                                            </telerik:RadButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="fls">
                                            <asp:Label runat="server" ID="Pref_EquipLbl" Text="Equipment">	</asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadAutoCompleteBox ID="Pref_EquipRAC" runat="server" Filter="Contains" DataSourceID="Pref_EquipDS"
                                                DataValueField="TreeID" DataTextField="TreeFull" InputType="Token" DropDownWidth="250px"
                                                Width="230px">
                                                <DropDownItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem, "TreeFullHTML")%>
                                                </DropDownItemTemplate>
                                            </telerik:RadAutoCompleteBox>
                                            <asp:SqlDataSource ID="Pref_EquipDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                SelectCommand="usp_Pref_EquipRollUp" SelectCommandType="StoredProcedure">
                                                <SelectParameters>
                                                    <asp:Parameter DefaultValue="389" Name="Pref_EquipPrune" Type="String" />
                                                </SelectParameters>
                                            </asp:SqlDataSource>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadButton ID="Pref_EquipRB" runat="server" Text="+/-" OnClientClicked="function (button,args){showPrefRTT('Pref_EquipRB','389');}">
                                            </telerik:RadButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="fls">
                                            <asp:Label runat="server" ID="Pref_CommodityLbl" Text="Cargo">	</asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadAutoCompleteBox ID="Pref_CommodityRAC" runat="server" Filter="Contains"
                                                DataSourceID="Pref_CommodityDS" DataValueField="TreeID" DataTextField="TreeFull"
                                                InputType="Token" DropDownWidth="250px" Width="230px">
                                                <DropDownItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem, "TreeFullHTML")%>
                                                </DropDownItemTemplate>
                                            </telerik:RadAutoCompleteBox>
                                            <asp:SqlDataSource ID="Pref_CommodityDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                SelectCommand="usp_Pref_CommodityRollUp" SelectCommandType="StoredProcedure">
                                                <SelectParameters>
                                                    <asp:Parameter DefaultValue="666" Name="Pref_CommodityPrune" Type="String" />
                                                </SelectParameters>
                                            </asp:SqlDataSource>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadButton ID="Pref_CommodityRB" runat="server" Text="+/-" OnClientClicked="function (button,args){showPrefRTT('Pref_CommodityRB','666');}">
                                            </telerik:RadButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="fls">
                                            <asp:Label runat="server" ID="Pref_RegionsLbl" Text="Regions">	</asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadAutoCompleteBox ID="Pref_RegionsRAC" runat="server" Filter="Contains"
                                                DataSourceID="Pref_RegionsDS" DataValueField="TreeID" DataTextField="TreeFull"
                                                InputType="Token" DropDownWidth="250px" Width="230px">
                                                <DropDownItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem, "TreeFullHTML")%>
                                                </DropDownItemTemplate>
                                            </telerik:RadAutoCompleteBox>
                                            <asp:SqlDataSource ID="Pref_RegionsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                SelectCommand="usp_Pref_RegionsRollUp" SelectCommandType="StoredProcedure">
                                                <SelectParameters>
                                                    <asp:Parameter DefaultValue="741" Name="Pref_RegionsPrune" Type="String" />
                                                </SelectParameters>
                                            </asp:SqlDataSource>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadButton ID="Pref_RegionsRB" runat="server" Text="+/-" OnClientClicked="function (button,args){showPrefRTT('Pref_RegionsRB','741');}">
                                            </telerik:RadButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="fls">
                                            <asp:Label runat="server" ID="Pref_OtherLbl" Text="Other Items">	</asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadAutoCompleteBox ID="Pref_OtherRAC" runat="server" Filter="Contains" DataSourceID="Pref_OtherDS"
                                                DataValueField="TreeID" DataTextField="TreeFull" InputType="Token" DropDownWidth="250px"
                                                Width="230px">
                                                <DropDownItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem, "TreeFullHTML")%>
                                                </DropDownItemTemplate>
                                            </telerik:RadAutoCompleteBox>
                                            <asp:SqlDataSource ID="Pref_OtherDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                SelectCommand="usp_Pref_OtherRollUp" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadButton ID="Pref_OtherRB" runat="server" Text="+/-" OnClientClicked="function (button,args){showPrefRTT('Pref_OtherRB','851,852,853');}">
                                            </telerik:RadButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="fls">
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadButton ID="Pref_EditRB" runat="server" Text="Edit" ToolTip="Click to modify the 'Stuff You Want'.">
                                            </telerik:RadButton>
                                        </td>
                                        <td class="dfv">
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </telerik:RadPanelItem>
                        <telerik:RadPanelItem Text="Records" Expanded="false" Font-Size="Medium">
                            <ContentTemplate>
                                <table style="line-height: 20px; background: white; color: Black;">
                                    <tr>
                                        <td colspan="2" class="fls" style="text-align: left;">
                                            <asp:Label ID="RecordsInstructionsLbl" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="fls">
                                            <asp:Label runat="server" ID="EstAccidentsLbl" Text="Est Accidents (Last <strong>3 years</strong>)">	</asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadComboBox ID="EstAccidentsRCB" runat="server" DataSourceID="IncidentsDS"
                                                DataTextField="ListName" DataValueField="ListID" MarkFirstMatch="True" ShowToggleImage="True"
                                                Width="167px" ZIndex="50001">
                                            </telerik:RadComboBox>
                                            <asp:SqlDataSource ID="IncidentsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                SelectCommand="SELECT * FROM dbo.List WHERE ListType = 'Count' ORDER BY ListRank">
                                            </asp:SqlDataSource>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="fls">
                                            <asp:Label runat="server" ID="EstTicketsLbl" Text="Est Tickets (Last <strong>3 years</strong>)">	</asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadComboBox ID="EstTicketsRCB" runat="server" DataSourceID="IncidentsDS"
                                                DataTextField="ListName" DataValueField="ListID" MarkFirstMatch="True" ShowToggleImage="True"
                                                Width="167px" ZIndex="50001">
                                            </telerik:RadComboBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="fls">
                                            <asp:Label runat="server" ID="EstTestsLbl" Text="Est Failed/Refused Drug/Alcohol Tests (Last <strong>5 years</strong>)">	</asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadComboBox ID="EstTestsRCB" runat="server" DataSourceID="IncidentsDS" DataTextField="ListName"
                                                DataValueField="ListID" MarkFirstMatch="True" ShowToggleImage="True" Width="167px"
                                                ZIndex="50001">
                                            </telerik:RadComboBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="fls">
                                            <asp:Label runat="server" ID="EstFeloniesLbl" Text="Est Felonies (Last <strong>5 years</strong>)">	</asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadComboBox ID="EstFeloniesRCB" runat="server" DataSourceID="IncidentsDS"
                                                DataTextField="ListName" DataValueField="ListID" MarkFirstMatch="True" ShowToggleImage="True"
                                                Width="167px" ZIndex="50001">
                                            </telerik:RadComboBox>
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </telerik:RadPanelItem>
                    </Items>
                </telerik:RadPanelBar>
            </telerik:RadPane>
        </telerik:RadSplitter>
        <div id="HiddenTBs" style="display: none">
            PartyID:
            <asp:TextBox ID="HiddenTB_PartyID" runat="server" Text="0"></asp:TextBox><br />
            TruckerID:
            <asp:TextBox ID="HiddenTB_TruckerID" runat="server" Text="0"></asp:TextBox><br />
            TopLeftLat:
            <asp:TextBox ID="HiddenTB_TopLeftLat" runat="server" Text="0"></asp:TextBox>
            <br />
            TopLeftLong:
            <asp:TextBox ID="HiddenTB_TopLeftLong" runat="server" Text="0">
            </asp:TextBox><br />
            BottomRightLat:
            <asp:TextBox ID="HiddenTB_BottomRightLat" runat="server" Text="0"></asp:TextBox>
            <br />
            BottomRightLong:
            <asp:TextBox ID="HiddenTB_BottomRightLong" runat="server" Text="0"></asp:TextBox>
            <br />
            OriginLat:
            <asp:TextBox ID="HiddenTB_OriginLat" runat="server" Text="0"></asp:TextBox>
            <br />
            OriginLong:
            <asp:TextBox ID="HiddenTB_OriginLong" runat="server" Text="0"></asp:TextBox>
            <br />
            TabName:
            <asp:TextBox ID="HiddenTB_TabName" runat="server" Text="All"></asp:TextBox>
            <br />
            CenterLat:
            <asp:TextBox ID="HiddenTB_CenterLat" runat="server" Text="0"></asp:TextBox>
            <br />
            CenterLong:
            <asp:TextBox ID="HiddenTB_CenterLong" runat="server" Text="0"></asp:TextBox>
            <br />
            PointID:
            <asp:TextBox ID="HiddenTB_PointID" runat="server" Text="0"></asp:TextBox>
            <br />
            PK:
            <asp:TextBox ID="HiddenTB_PK" runat="server" Text="0"></asp:TextBox>
            <br />
            HaveRole:
            <asp:TextBox ID="HiddenTB_HaveRole" runat="server" Text="0"></asp:TextBox>
            <br />
            GaugeImageUrl:
            <asp:TextBox ID="HiddenTB_GaugeImageUrl" runat="server" Text="0"></asp:TextBox><br />
            RowIndex:
            <asp:TextBox ID="HiddenTB_RowIndex" runat="server" Text="0"></asp:TextBox><br />
            SearchEmail:
            <asp:TextBox ID="HiddenTB_SearchEmail" runat="server" Text="0"></asp:TextBox><br />
            SearchPhone:
            <asp:TextBox ID="HiddenTB_SearchMobile" runat="server" Text="0"></asp:TextBox><br />
            SearchName:
            <asp:TextBox ID="HiddenTB_SearchName" runat="server" Text="0"></asp:TextBox><br />
            HeatMapData:
            <asp:TextBox ID="HiddenTB_HeatMapData" runat="server" Text="0"></asp:TextBox><br />
            MapZoomLevel:
            <asp:TextBox ID="HiddenTB_MapZoomLevel" runat="server" Text="0"></asp:TextBox><br />
            PastLat:
            <asp:TextBox ID="HiddenTB_PastLat" runat="server" Text="0"></asp:TextBox><br />
            PastLong:
            <asp:TextBox ID="HiddenTB_PastLong" runat="server" Text="0"></asp:TextBox><br />
            AdID:
            <asp:TextBox ID="HiddenTB_AdID" runat="server" Text="0"></asp:TextBox><br />
            PrefParentID:
            <asp:TextBox ID="HiddenTB_PrefParentID" runat="server" Text="0"></asp:TextBox><br />
            MouseOverID:
            <asp:TextBox ID="HiddenTB_MouseOverID" runat="server"></asp:TextBox><br />
        </div>
    </div>
    </form>
</body>
</html>
