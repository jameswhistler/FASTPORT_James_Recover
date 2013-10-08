<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="EditCarrierAd.aspx.vb"
    Inherits=".EditCarrierAd_aspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Job Posting</title>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server" />
    <style>
        body
        {
            margin: 0px;
            padding: 0px;
            border: 0px;
            overflow: hidden;
        }
        table, tr, td, tbody
        {
            border-spacing: 0px !important;
            border: 0px;
        }
        #map
        {
            position: absolute;
            top: 46px;
            bottom: 0;
            width: 956px;
            height: 538px;
            left: 24px;
            z-index: 500;
        }
        .popup
        {
            text-align: center;
        }
        .RadSplitter_BlackMetroTouch, .RadSplitter_BlackMetroTouch .rspPane
        {
            border-color: transparent !important;
            border-left-width: 0px !important;
            border-top-width: 0px !important;
        }
        .RadSplitter_BlackMetroTouch
        {
            position: absolute;
        }
        #RAD_SLIDING_PANE_TAB_AdGeoSlidingPane
        {
            height: 585px !important;
            border-spacing: 0px;
        }
        #RAD_SLIDING_PANE_CONTENT__AdGeoSlidingPane
        {
            height: 490px !important;
        }
        #RAD_SPLITTER_PANE_CONTENT_AdGeoRP
        {
            height: 537px !important;
        }
    </style>
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
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadAjaxManager1" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="AdGeoRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="PrefRG" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_GeneralRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_EquipRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_CommodityRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_OtherRAC" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="AdGeoAddRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="AdGeoAddRB" />
                    <telerik:AjaxUpdatedControl ControlID="AdGeoRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_AdGeoStatus" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="AdGeoSaveRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="AdGeoSaveRB" />
                    <telerik:AjaxUpdatedControl ControlID="AdGeoRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_AdGeoStatus" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="AdGeoRG">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="AdGeoTypeRCB" />
                    <telerik:AjaxUpdatedControl ControlID="OriginCityRCB" />
                    <telerik:AjaxUpdatedControl ControlID="RegionsRAC" />
                    <telerik:AjaxUpdatedControl ControlID="StatesRAC" />
                    <telerik:AjaxUpdatedControl ControlID="DestCityRAC" />
                    <telerik:AjaxUpdatedControl ControlID="OrigRadiusRCB" />
                    <telerik:AjaxUpdatedControl ControlID="DestRadiusRCB" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_AdGeoID" />
                    <telerik:AjaxUpdatedControl ControlID="AdGeoAddRB" />
                    <telerik:AjaxUpdatedControl ControlID="AdGeoSaveRB" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_AdGeoStatus" />
                    <telerik:AjaxUpdatedControl ControlID="AdGeoNotesRE" />
                    <telerik:AjaxUpdatedControl ControlID="PointsRAC" />
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
                    <telerik:AjaxUpdatedControl ControlID="Pref_OtherRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_OtherRB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadWindowManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_AdID" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ThumbnailRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ThumbnailRBI" />
                    <telerik:AjaxUpdatedControl ControlID="ThumbnailRAU" />
                    <telerik:AjaxUpdatedControl ControlID="ThumbnailRB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <script src="http://code.jquery.com/jquery-2.0.3.js"></script>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <link href="http://api.tiles.mapbox.com/mapbox.js/v1.3.1/mapbox.css" rel="stylesheet" />
    <script src="http://api.tiles.mapbox.com/mapbox.js/v1.3.1/mapbox.js" type="text/javascript"></script>
    <script src="/leaflet-pip.js" type="text/javascript"></script>
    <div id="map" style="display: none">
    </div>
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type="text/javascript">

            var blockresize = false;

            function ChildCloseAndRedirect(args) {
                blockresize = true
                GetRadWindow().close();
                GetRadWindow().BrowserWindow.ParentCloseAndRedirect(args);
            }

            function ChildClose(args) {
                blockresize = true
                GetRadWindow().close();
            }

            function CloseAndRedirect(sender, args) {
                blockresize = true
                GetRadWindow().BrowserWindow.refreshGrid();
                GetRadWindow().close(); //closes the window
            }

            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow; //Will work in Moz in all cases, including clasic dialog
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow; //IE (and Moz as well)

                return oWindow;
            }

            function openVideo(myurl) {

                window.location.href = myurl;

            }

            window.onload = function () {
                onLimitByAgeRBCheckChanged();
                onLimitByMajorAccidentsRBCheckChanged();
                onLimitByMinorAccidentsRBCheckChanged();
                onLimitBySeriousTicketsRBCheckChanged();
                onLimitByTicketsRBCheckChanged();
                onLimitByFeloniesRBCheckChanged();
                onLimitByDrugConvictionsRBCheckChanged();
                onLimitByFailedTestRBCheckChanged();
                onLimitByDUICommercialRBCheckChanged();
                onLimitByDUIPersonalRBCheckChanged();
                onPayTypeRCBSelectedIndexChanged();
                onAdTemplateRBCheckChanged();
            }

            function v_EditCarrierRTS(sender, args) {

                var selectedTab = sender.get_selectedTab().get_text();
                if (selectedTab == "2. Posting Map") {
                    document.getElementById("map").style.display = "";
                    map.invalidateSize();
                    if (geolanes != "0" || georegions != "0" || georadii != "0") {
                        var bounds = AllLayers.getBounds();
                        map.fitBounds(bounds);
                    }
                } else {
                    document.getElementById("map").style.display = "none";
                }
            }

            function showPrefRTT(args) {

                document.getElementById("HiddenTB_PrefParentID").value = args;
                var PrefRTT = $find("<%=PrefRTT.ClientID%>");
                $find("<%=RadAjaxManager1.ClientID %>").ajaxRequest("rebindPrefRG");
                setTimeout(function () {
                    PrefRTT.show();
                }, 2000);
            }

            function closePrefRTT() {

                var tooltip = $find("<%=PrefRTT.ClientID %>");
                tooltip.hide();
                $find("<%=RadAjaxManager1.ClientID%>").ajaxRequest("rebindPrefs");

            }

            function onPrefRTT_DelIBClick(index) {

                var grid = $find("<%=PrefRG.ClientID %>");
                var MasterTable = grid.get_masterTableView();
                var row = MasterTable.get_dataItems()[index];
                var partyexperienceid = row.getDataKeyValue("PartyExperienceID");
                var itemname = row.getDataKeyValue("ItemName");
                confirmCall("deletePrefItem", partyexperienceid, itemname)

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

            var map = L.mapbox.map('map', 'http://a.tiles.mapbox.com/v3/fastport.map-zle7kuhd.jsonp', {
                tileLayer: {
                    detectRetina: true
                }
            }).setView([45.908, -78.525], 4);

            function v_AdGeoTypeRCBValue() {

                document.getElementById("AdGeoAddRow").style.display = "";
                document.getElementById("NewAdGeoAddRow").style.display = "none";
                document.getElementById("AdGeoAddSaveRow").style.display = "";
                document.getElementById("AdGeoNotesRow").style.display = "";
                document.getElementById("AdGeoDiv").style.display = "";

                var LaneRegionValue = $find("<%=AdGeoTypeRCB.ClientID %>").get_value();
                if (LaneRegionValue == "2590") {
                    setTimeout(function () {
                        $find("<%=NewAdGeoAddRB.ClientID %>").set_visible(false);
                        $find("<%=OriginCityRCB.ClientID %>").set_visible(false);
                        $find("<%=RegionsRAC.ClientID %>").set_visible(true);
                        $find("<%=StatesRAC.ClientID %>").set_visible(false);
                        $find("<%=OrigRadiusRCB.ClientID %>").set_visible(false);
                        $find("<%=DestCityRAC.ClientID %>").set_visible(false);
                        $find("<%=DestRadiusRCB.ClientID %>").set_visible(false);
                        $find("<%=PointsRAC.ClientID %>").set_visible(false);
                        $find("<%=AdGeoNotesRE.ClientID %>").set_visible(true);
                        $find("<%=AdGeoRTS.ClientID %>").set_visible(true);
                    }, 0);
                } else if (LaneRegionValue == "2591") {
                    setTimeout(function () {
                        $find("<%=NewAdGeoAddRB.ClientID %>").set_visible(false);
                        $find("<%=OriginCityRCB.ClientID %>").set_visible(false);
                        $find("<%=RegionsRAC.ClientID %>").set_visible(false);
                        $find("<%=StatesRAC.ClientID %>").set_visible(true);
                        $find("<%=OrigRadiusRCB.ClientID %>").set_visible(false);
                        $find("<%=DestCityRAC.ClientID %>").set_visible(false);
                        $find("<%=DestRadiusRCB.ClientID %>").set_visible(false);
                        $find("<%=PointsRAC.ClientID %>").set_visible(false);
                        $find("<%=AdGeoNotesRE.ClientID %>").set_visible(true);
                        $find("<%=AdGeoRTS.ClientID %>").set_visible(true);
                        document.getElementById("Temp").style.display = "none";
                    }, 0);
                } else if (LaneRegionValue == "2589") {
                    setTimeout(function () {
                        $find("<%=NewAdGeoAddRB.ClientID %>").set_visible(false);
                        $find("<%=OriginCityRCB.ClientID %>").set_visible(true);
                        $find("<%=RegionsRAC.ClientID %>").set_visible(false);
                        $find("<%=StatesRAC.ClientID %>").set_visible(false);
                        $find("<%=OrigRadiusRCB.ClientID %>").set_visible(true);
                        $find("<%=DestCityRAC.ClientID %>").set_visible(true);
                        $find("<%=DestRadiusRCB.ClientID %>").set_visible(true);
                        $find("<%=PointsRAC.ClientID %>").set_visible(false);
                        $find("<%=AdGeoNotesRE.ClientID %>").set_visible(true);
                        $find("<%=AdGeoRTS.ClientID %>").set_visible(true);
                        document.getElementById("Temp").style.display = "";
                    }, 0);
                } else if (LaneRegionValue == "2592") {
                    setTimeout(function () {
                        $find("<%=NewAdGeoAddRB.ClientID %>").set_visible(false);
                        $find("<%=OriginCityRCB.ClientID %>").set_visible(false);
                        $find("<%=RegionsRAC.ClientID %>").set_visible(false);
                        $find("<%=StatesRAC.ClientID %>").set_visible(false);
                        $find("<%=OrigRadiusRCB.ClientID %>").set_visible(false);
                        $find("<%=DestCityRAC.ClientID %>").set_visible(false);
                        $find("<%=DestRadiusRCB.ClientID %>").set_visible(true);
                        $find("<%=PointsRAC.ClientID %>").set_visible(true);
                        $find("<%=AdGeoNotesRE.ClientID %>").set_visible(true);
                        $find("<%=AdGeoRTS.ClientID %>").set_visible(true);
                        document.getElementById("Temp").style.display = "none";
                    }, 0);
                } else {
                    setTimeout(function () {
                        $find("<%=NewAdGeoAddRB.ClientID %>").set_visible(true);
                        $find("<%=OriginCityRCB.ClientID %>").set_visible(false);
                        $find("<%=RegionsRAC.ClientID %>").set_visible(false);
                        $find("<%=StatesRAC.ClientID %>").set_visible(false);
                        $find("<%=OrigRadiusRCB.ClientID %>").set_visible(false);
                        $find("<%=DestCityRAC.ClientID %>").set_visible(false);
                        $find("<%=DestRadiusRCB.ClientID %>").set_visible(false);
                        $find("<%=PointsRAC.ClientID %>").set_visible(false);
                        $find("<%=AdGeoNotesRE.ClientID %>").set_visible(true);
                        $find("<%=AdGeoRTS.ClientID %>").set_visible(false);
                    }, 0);

                    document.getElementById("AdGeoAddRow").style.display = "none";
                    document.getElementById("NewAdGeoAddRow").style.display = "";
                    document.getElementById("AdGeoAddSaveRow").style.display = "none";
                    document.getElementById("AdGeoNotesRow").style.display = "none";
                    document.getElementById("AdGeoDiv").style.display = "none";
                    document.getElementById("Temp").style.display = "none";
                }
            }

            function v_clearAdGeoFields() {

                $find("<%=AdGeoTypeRCB.ClientID %>").clearSelection();
                $find("<%=AdGeoTypeRCB.ClientID %>").set_emptyMessage("Pick Feature");
                $find("<%=OriginCityRCB.ClientID %>").clearSelection();
                $find("<%=RegionsRAC.ClientID %>").get_entries().clear();
                $find("<%=StatesRAC.ClientID %>").get_entries().clear();
                $find("<%=DestCityRAC.ClientID %>").get_entries().clear();
                $find("<%=PointsRAC.ClientID %>").get_entries().clear();
                $find("<%=AdGeoNotesRE.ClientID %>").set_html("");
                $find("<%=OrigRadiusRCB.ClientID %>").clearSelection();
                $find("<%=OrigRadiusRCB.ClientID %>").set_value("1");
                $find("<%=DestRadiusRCB.ClientID %>").clearSelection();
                $find("<%=DestRadiusRCB.ClientID %>").set_value("1");

            }

            function v_AdGeoLoad() {

                v_AdGeoTypeRCBValue();

            }

            function v_AdGeoSelectionIndexChanged() {

                v_AdGeoTypeRCBValue();

            }

            function v_AdGeoDisplay() {

                $find("<%=AdGeoSaveRB.ClientID %>").set_visible(true);
                $find("<%=AdGeoAddRB.ClientID %>").set_visible(false);

            }

            function onNewAdGeoAddRBClicked() {

                document.getElementById("AdGeoAddRow").style.display = "";
                document.getElementById("NewAdGeoAddRow").style.display = "none";
                document.getElementById("AdGeoAddSaveRow").style.display = "";
                document.getElementById("AdGeoNotesRow").style.display = "";
                document.getElementById("AdGeoDiv").style.display = "";
                $find("<%=AdGeoSaveRB.ClientID %>").set_visible(false);
                $find("<%=AdGeoAddRB.ClientID %>").set_visible(true);
                $find("<%=AdGeoRTS.ClientID %>").set_visible(true);
                document.getElementById("HiddenTB_AdGeoStatus").value = "Add";
                $find("<%=OrigRadiusRCB.ClientID %>").findItemByValue(10).select();
                $find("<%=DestRadiusRCB.ClientID %>").findItemByValue(10).select();
                $find("<%=AdGeoRTS.ClientID %>").get_tabs().getTab(0).set_selected(true);

            }

            function onLayerDelIBClicked(index) {

                var grid = $find("<%=AdGeoRG.ClientID %>");
                var MasterTable = grid.get_masterTableView();
                var row = MasterTable.get_dataItems()[index];
                var AdGeoID = row.getDataKeyValue("AdGeoID");
                confirmCall("deleteLayer", AdGeoID, "Delete Layer");
                onMapModify();
                var datarsp = $find("<%=AdGeoSlidingPane.ClientID %>");
                if (datarsp.get_expanded()) {
                    $find("<%=AdGeoSlidingZone.ClientID %>").collapsePane(datarsp.get_id());
                }
            }

            function onAdGeoCancelRB_Clicked() {

                document.getElementById("AdGeoAddRow").style.display = "none";
                document.getElementById("AdGeoNotesRow").style.display = "none";
                document.getElementById("AdGeoAddSaveRow").style.display = "none";
                document.getElementById("NewAdGeoAddRow").style.display = "";
                document.getElementById("AdGeoDiv").style.display = "none";
                setTimeout(function () {
                    $find("<%=AdGeoSaveRB.ClientID %>").set_visible(true);
                }, 0);
                v_clearAdGeoFields();
                v_AdGeoTypeRCBValue();
                document.getElementById("HiddenTB_AdGeoStatus").value = "Saved";
                var AdID = document.getElementById("HiddenTB_AdID").value;
                SendCallBack("LoadAllGeoJson," + AdID, "LoadAllGeoJson");

            }

            function onAutoCompleteBoxEntryAdding(sender, eventArgs) {
                var entries = sender.get_entries(),
                    count = entries.get_count();

                for (var i = 0; i < count; i++) {
                    if (entries.getEntry(i).get_value() == eventArgs.get_entry().get_value()) {
                        eventArgs.set_cancel(true);
                    }
                }
            }

            //map + grid

            var AllLayers = new L.FeatureGroup();

            function onAdGeoRGCreated() {

                var AdID = document.getElementById("HiddenTB_AdID").value;
                SendCallBack("LoadAllGeoJson," + AdID, "LoadAllGeoJson");

            }

            var geolanes;
            var georegions;
            var georadii;

            function onAdGeoRGCreated_back(arg) {

                AllLayers.clearLayers();
                var myString = arg;
                var mySplit = myString.split("<|>", 3);

                geolanes = mySplit[0] || "";
                georegions = mySplit[1] || "";
                georadii = mySplit[2] || "";

                if (geolanes != "0") {
                    geolanes = eval('[{"type":"FeatureCollection","features":[' + geolanes + ']}]');
                    AllLayers.addLayer(L.geoJson(geolanes, {
                        style: function (feature) {
                            return {
                                color: feature.properties.color
                            };
                        },
                        onEachFeature: onEachFeature
                    }));
                }

                if (georegions != "0") {
                    georegions = eval('[{"type":"FeatureCollection","features":[' + georegions + ']}]');
                    AllLayers.addLayer(L.geoJson(georegions, {
                        style: function (feature) {
                            return {
                                color: feature.properties.color
                            };
                        },
                        onEachFeature: onEachFeature
                    }));
                }

                if (georadii != "0") {
                    georadii = eval('[' + georadii + ']');
                    for (var i = 0; i < georadii.length; i++) {
                        var circle_i = georadii[i];
                        var circle = L.circle(circle_i[0], circle_i[1], circle_i[2]);
                        circle.on('click', function (e) {
                            document.getElementById("HiddenTB_LayerID").value = circle_i[2].id;
                            document.getElementById("HiddenTB_LayerName").value = circle_i[2].name;
                            document.getElementById("HiddenTB_LayerColor").value = circle_i[2].color;
                            document.getElementById("HiddenTB_LayerType").value = "Circle";
                            document.getElementById("HiddenTB_LayerCoords").value = circle_i[0];

                        });
                        if (circle_i[2] != null) {
                            var notes = circle_i[2].notes;
                            var array = notes.split(' !?| ');
                            notes = '<strong><span style="text-decoration: underline;">' + array[0] + '</span></strong><br /><br />' + array[1];
                            circle.bindPopup(notes);
                        }
                        AllLayers.addLayer(circle);
                    }
                }
                if (geolanes != "0" || georegions != "0" || georadii != "0") {
                    AllLayers.addTo(map);
                    var bounds = AllLayers.getBounds();
                    map.fitBounds(bounds);
                }
                map.invalidateSize();

                var selectedTab = $find("<%=EditCarrierRTS.ClientID %>").get_selectedTab().get_text();
                if (selectedTab == "2. Posting Map") {
                    var datarsp = $find("<%=AdGeoSlidingPane.ClientID %>");
                    if (datarsp.get_expanded()) {
                        $find("<%=AdGeoSlidingZone.ClientID %>").collapsePane(datarsp.get_id());
                    }
                }
            }

            function onLayerClick(feature) {

                layer.on('click', function (e) {
                    var layercolor = feature.properties.color;
                    if (layercolor == '#8f8f8f') {
                        return {
                            color: '#0000ff'
                        };
                    } else {
                        return {
                            color: '#8f8f8f'
                        };
                    }
                });
            }

            function onEachFeature(feature, layer) {
                layer.on('click', function (e) {
                    document.getElementById("HiddenTB_LayerID").value = feature.id;
                    document.getElementById("HiddenTB_LayerName").value = feature.properties.name;
                    document.getElementById("HiddenTB_LayerColor").value = feature.properties.color;
                    document.getElementById("HiddenTB_LayerType").value = feature.geometry.type;
                    document.getElementById("HiddenTB_LayerCoords").value = feature.geometry.coordinates;
                    if (feature.properties.color == "#0000ff") {
                        var notes = feature.properties.notes;
                        var array = notes.split(' !?| ');
                        notes = '<strong><span style="text-decoration: underline;">' + array[0] + '</span></strong><br /><br />' + array[1];
                        layer.bindPopup(notes);
                    }
                });
            }

            var isselected = false;

            function onAdGeoRGRowClicked(sender, eventArgs) {

                if (isselected == true) {

                    $('.rgSelectedRow').css('background', 'transparent');
                    onAdGeoRGCreated();
                    sender.clearSelectedItems();
                    isselected = false;

                } else {
                    $('.rgSelectedRow').css('background', '#fff1cc');
                    var AdGeoID = eventArgs.getDataKeyValue("AdGeoID");
                    var AdGeoTypeID = eventArgs.getDataKeyValue("AdGeoTypeID");
                    var AdGeoStatus = document.getElementById("HiddenTB_AdGeoStatus").value;
                    document.getElementById("HiddenTB_AdGeoTypeID").value = AdGeoTypeID;
                    if (AdGeoTypeID == "2590" || AdGeoTypeID == "2591") {
                        SendCallBack("GeoJsonRegionST," + AdGeoID + "," + AdGeoStatus, "GeoJsonRegionST");
                    } else if (AdGeoTypeID == "2589") {
                        SendCallBack("GeoJsonLaneHub," + AdGeoID + "," + AdGeoStatus, "GeoJsonLaneHub");
                    } else if (AdGeoTypeID == "2592") {
                        SendCallBack("GeoJsonRadius," + AdGeoID + "," + AdGeoStatus, "GeoJsonRadius");
                    }
                    isselected = true;
                }
            }

            function onAdGeoRGRowClicked_back(arg) {

                AllLayers.clearLayers();
                var AdGeoTypeID = document.getElementById("HiddenTB_AdGeoTypeID").value;
                var regiondata = arg;
                if (AdGeoTypeID == "2592") {
                    regiondata = eval('[' + regiondata + ']');
                    for (var i = 0; i < regiondata.length; i++) {
                        var circle_i = regiondata[i];
                        var circle = L.circle(circle_i[0], circle_i[1], circle_i[2]);
                        circle.on('click', function (e) {
                            document.getElementById("HiddenTB_LayerID").value = circle_i[2].id;
                            document.getElementById("HiddenTB_LayerName").value = circle_i[2].name;
                            document.getElementById("HiddenTB_LayerColor").value = circle_i[2].color;
                            document.getElementById("HiddenTB_LayerType").value = "Circle";
                            document.getElementById("HiddenTB_LayerCoords").value = circle_i[0];

                        });
                        var notes = circle_i[2].notes;
                        var array = notes.split(' !?| ');
                        notes = '<strong><span style="text-decoration: underline;">' + array[0] + '</span></strong><br /><br />' + array[1];
                        circle.bindPopup(notes);
                        AllLayers.addLayer(circle);
                    }
                } else if (AdGeoTypeID == "2589") {

                    var mySplit = regiondata.split("<|>", 2);

                    var lanes = mySplit[0] || "";
                    var circles = mySplit[1] || "";

                    lanes = eval('[{"type":"FeatureCollection","features":[' + lanes + ']}]');
                    AllLayers.addLayer(L.geoJson(lanes, {
                        style: function (feature) {
                            return {
                                color: feature.properties.color
                            };
                        },
                        onEachFeature: onEachFeature
                    }));

                    circles = eval('[' + circles + ']');
                    for (var i = 0; i < circles.length; i++) {
                        var circle_i = circles[i];
                        var circle = L.circle(circle_i[0], circle_i[1], circle_i[2]);
                        circle.on('click', function (e) {
                            document.getElementById("HiddenTB_LayerID").value = circle_i[2].id;
                            document.getElementById("HiddenTB_LayerName").value = circle_i[2].name;
                            document.getElementById("HiddenTB_LayerColor").value = circle_i[2].color;
                            document.getElementById("HiddenTB_LayerType").value = "Circle";
                            document.getElementById("HiddenTB_LayerCoords").value = circle_i[0];
                        });
                        var notes = circle_i[2].notes;
                        var array = notes.split(' !?| ');
                        notes = '<strong><span style="text-decoration: underline;">' + array[0] + '</span></strong><br /><br />' + array[1];
                        circle.bindPopup(notes);
                        AllLayers.addLayer(circle);
                    }

                } else {
                    regiondata = eval('[{"type":"FeatureCollection","features":[' + regiondata + ']}]');
                    AllLayers.addLayer(L.geoJson(regiondata, {
                        style: function (feature) {
                            return {
                                color: feature.properties.color
                            };
                        },
                        onEachFeature: onEachFeature
                    }));
                }
                AllLayers.addTo(map);

            }

            function onMapModify() {

                document.getElementById("HiddenTB_MapModifyStatus").value = "Modified";

            }

            function onLimitByAgeRBCheckChanged() {
                var toggleindex = $find("<%=LimitByAgeRB.ClientID %>").get_selectedToggleStateIndex();
                if (toggleindex == 1) {
                    document.getElementById("<%=MinAgerow.ClientID %>").style.display = "";
                } else {
                    document.getElementById("<%=MinAgerow.ClientID %>").style.display = "none";
                }
            }

            function onLimitByMajorAccidentsRBCheckChanged() {
                var toggleindex = $find("<%=LimitByMajorAccidentsRB.ClientID %>").get_selectedToggleStateIndex();
                var MajorByID = $find("<%=MajorByCB.ClientID %>").get_selectedItem().get_value();
                if (toggleindex == 1) {
                    document.getElementById("<%=MajorPanelCell.ClientID %>").style.display = "";
                    if (MajorByID != "11") {
                        if (MajorByID == "9" || MajorByID == "10") {
                            document.getElementById("<%=MajorMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=MajorYearsRow.ClientID %>").style.display = "";
                        } else if (MajorByID == "7") {
                            document.getElementById("<%=MajorMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=MajorYearsRow.ClientID %>").style.display = "none";
                        } else if (MajorByID == "8") {
                            document.getElementById("<%=MajorMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=MajorYearsRow.ClientID %>").style.display = "";
                        } else {
                            document.getElementById("<%=MajorMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=MajorYearsRow.ClientID %>").style.display = "none";
                        }
                        document.getElementById("<%=MajorCountRow.ClientID %>").style.display = "";
                    } else {
                        document.getElementById("<%=MajorMilesRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=MajorYearsRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=MajorCountRow.ClientID %>").style.display = "none";
                    }
                } else {
                    document.getElementById("<%=MajorPanelCell.ClientID %>").style.display = "none";
                }
            }

            function onLimitByMinorAccidentsRBCheckChanged() {
                var toggleindex = $find("<%=LimitByMinorAccidentsRB.ClientID %>").get_selectedToggleStateIndex();
                var MinorByID = $find("<%=MinorByCB.ClientID %>").get_selectedItem().get_value();
                if (toggleindex == 1) {
                    document.getElementById("<%=MinorPanelCell.ClientID %>").style.display = "";
                    if (MinorByID != "11") {
                        if (MinorByID == "9" || MinorByID == "10") {
                            document.getElementById("<%=MinorMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=MinorYearsRow.ClientID %>").style.display = "";
                        } else if (MinorByID == "7") {
                            document.getElementById("<%=MinorMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=MinorYearsRow.ClientID %>").style.display = "none";
                        } else if (MinorByID == "8") {
                            document.getElementById("<%=MinorMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=MinorYearsRow.ClientID %>").style.display = "";
                        } else {
                            document.getElementById("<%=MinorMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=MinorYearsRow.ClientID %>").style.display = "none";
                        }
                        document.getElementById("<%=MinorCountRow.ClientID %>").style.display = "";
                    } else {
                        document.getElementById("<%=MinorMilesRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=MinorYearsRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=MinorCountRow.ClientID %>").style.display = "none";
                    }
                } else {
                    document.getElementById("<%=MinorPanelCell.ClientID %>").style.display = "none";
                }
            }

            function onLimitBySeriousTicketsRBCheckChanged() {
                var toggleindex = $find("<%=LimitBySeriousTicketsRB.ClientID %>").get_selectedToggleStateIndex();
                var SeriousByID = $find("<%=SeriousByCB.ClientID %>").get_selectedItem().get_value();
                if (toggleindex == 1) {
                    document.getElementById("<%=SeriousPanelCell.ClientID %>").style.display = "";
                    if (SeriousByID != "11") {
                        if (SeriousByID == "9" || SeriousByID == "10") {
                            document.getElementById("<%=SeriousMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=SeriousYearsRow.ClientID %>").style.display = "";
                        } else if (SeriousByID == "7") {
                            document.getElementById("<%=SeriousMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=SeriousYearsRow.ClientID %>").style.display = "none";
                        } else if (SeriousByID == "8") {
                            document.getElementById("<%=SeriousMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=SeriousYearsRow.ClientID %>").style.display = "";
                        } else {
                            document.getElementById("<%=SeriousMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=SeriousYearsRow.ClientID %>").style.display = "none";
                        }
                        document.getElementById("<%=SeriousCountRow.ClientID %>").style.display = "";
                    } else {
                        document.getElementById("<%=SeriousMilesRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=SeriousYearsRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=SeriousCountRow.ClientID %>").style.display = "none";
                    }
                } else {
                    document.getElementById("<%=SeriousPanelCell.ClientID %>").style.display = "none";
                }
            }

            function onLimitByTicketsRBCheckChanged() {
                var toggleindex = $find("<%=LimitByTicketsRB.ClientID %>").get_selectedToggleStateIndex();
                var TicketByID = $find("<%=TicketsByCB.ClientID %>").get_selectedItem().get_value();
                if (toggleindex == 1) {
                    document.getElementById("<%=TicketsPanelCell.ClientID %>").style.display = "";
                    if (TicketByID != "11") {
                        if (TicketByID == "9" || TicketByID == "10") {
                            document.getElementById("<%=TicketMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=TicketYearsRow.ClientID %>").style.display = "";
                        } else if (TicketByID == "7") {
                            document.getElementById("<%=TicketMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=TicketYearsRow.ClientID %>").style.display = "none";
                        } else if (TicketByID == "8") {
                            document.getElementById("<%=TicketMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=TicketYearsRow.ClientID %>").style.display = "";
                        } else {
                            document.getElementById("<%=TicketMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=TicketYearsRow.ClientID %>").style.display = "none";
                        }
                        document.getElementById("<%=TicketCountRow.ClientID %>").style.display = "";
                    } else {
                        document.getElementById("<%=TicketMilesRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=TicketYearsRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=TicketCountRow.ClientID %>").style.display = "none";
                    }
                } else {
                    document.getElementById("<%=TicketsPanelCell.ClientID %>").style.display = "none";
                }
            }

            function onLimitByFeloniesRBCheckChanged() {
                var toggleindex = $find("<%=LimitByFeloniesRB.ClientID %>").get_selectedToggleStateIndex();
                var FeloniesByID = $find("<%=FeloniesByCB.ClientID %>").get_selectedItem().get_value();
                if (toggleindex == 1) {
                    document.getElementById("<%=FeloniesPanelCell.ClientID %>").style.display = "";
                    if (FeloniesByID != "11") {
                        if (FeloniesByID == "9" || FeloniesByID == "10") {
                            document.getElementById("<%=FeloniesMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=FeloniesYearsRow.ClientID %>").style.display = "";
                        } else if (FeloniesByID == "7") {
                            document.getElementById("<%=FeloniesMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=FeloniesYearsRow.ClientID %>").style.display = "none";
                        } else if (FeloniesByID == "8") {
                            document.getElementById("<%=FeloniesMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=FeloniesYearsRow.ClientID %>").style.display = "";
                        } else {
                            document.getElementById("<%=FeloniesMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=FeloniesYearsRow.ClientID %>").style.display = "none";
                        }
                        document.getElementById("<%=FeloniesCountRow.ClientID %>").style.display = "";
                    } else {
                        document.getElementById("<%=FeloniesMilesRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=FeloniesYearsRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=FeloniesCountRow.ClientID %>").style.display = "none";
                    }
                } else {
                    document.getElementById("<%=FeloniesPanelCell.ClientID %>").style.display = "none";
                }
            }

            function onLimitByDrugConvictionsRBCheckChanged() {
                var toggleindex = $find("<%=LimitByDrugConvictionsRB.ClientID %>").get_selectedToggleStateIndex();
                var DrugConvictionsByID = $find("<%=DrugConvictionsByCB.ClientID %>").get_selectedItem().get_value();
                if (toggleindex == 1) {
                    document.getElementById("<%=DrugConvictionsPanelCell.ClientID %>").style.display = "";
                    if (DrugConvictionsByID != "11") {
                        if (DrugConvictionsByID == "9" || DrugConvictionsByID == "10") {
                            document.getElementById("<%=DrugConvictionsMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=DrugConvictionsYearsRow.ClientID %>").style.display = "";
                        } else if (DrugConvictionsByID == "7") {
                            document.getElementById("<%=DrugConvictionsMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=DrugConvictionsYearsRow.ClientID %>").style.display = "none";
                        } else if (DrugConvictionsByID == "8") {
                            document.getElementById("<%=DrugConvictionsMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=DrugConvictionsYearsRow.ClientID %>").style.display = "";
                        } else {
                            document.getElementById("<%=DrugConvictionsMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=DrugConvictionsYearsRow.ClientID %>").style.display = "none";
                        }
                        document.getElementById("<%=DrugConvictionsCountRow.ClientID %>").style.display = "";
                    } else {
                        document.getElementById("<%=DrugConvictionsMilesRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=DrugConvictionsYearsRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=DrugConvictionsCountRow.ClientID %>").style.display = "none";
                    }
                } else {
                    document.getElementById("<%=DrugConvictionsPanelCell.ClientID %>").style.display = "none";
                }
            }

            function onLimitByFailedTestRBCheckChanged() {
                var toggleindex = $find("<%=LimitByFailedTestRB.ClientID %>").get_selectedToggleStateIndex();
                var FailedByID = $find("<%=FailedByCB.ClientID %>").get_selectedItem().get_value();
                if (toggleindex == 1) {
                    document.getElementById("<%=FailedPanelCell.ClientID %>").style.display = "";
                    if (FailedByID != "11") {
                        if (FailedByID == "9" || FailedByID == "10") {
                            document.getElementById("<%=FailedMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=FailedYearsRow.ClientID %>").style.display = "";
                        } else if (FailedByID == "7") {
                            document.getElementById("<%=FailedMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=FailedYearsRow.ClientID %>").style.display = "none";
                        } else if (FailedByID == "8") {
                            document.getElementById("<%=FailedMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=FailedYearsRow.ClientID %>").style.display = "";
                        } else {
                            document.getElementById("<%=FailedMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=FailedYearsRow.ClientID %>").style.display = "none";
                        }
                        document.getElementById("<%=FailedCountRow.ClientID %>").style.display = "";
                    } else {
                        document.getElementById("<%=FailedMilesRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=FailedYearsRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=FailedCountRow.ClientID %>").style.display = "none";
                    }
                } else {
                    document.getElementById("<%=FailedPanelCell.ClientID %>").style.display = "none";
                }
            }

            function onLimitByDUICommercialRBCheckChanged() {
                var toggleindex = $find("<%=LimitByDUICommercialRB.ClientID %>").get_selectedToggleStateIndex();
                var DUICommercialByID = $find("<%=CommDUIByCB.ClientID %>").get_selectedItem().get_value();
                if (toggleindex == 1) {
                    document.getElementById("<%=DUICommercialPanelCell.ClientID %>").style.display = "";
                    if (CommDUIByID != "11") {
                        if (CommDUIByID == "9" || CommDUIByID == "10") {
                            document.getElementById("<%=CommDUIMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=CommDUIYearsRow.ClientID %>").style.display = "";
                        } else if (CommDUIByID == "7") {
                            document.getElementById("<%=CommDUIMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=CommDUIYearsRow.ClientID %>").style.display = "none";
                        } else if (CommDUIByID == "8") {
                            document.getElementById("<%=CommDUIMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=CommDUIYearsRow.ClientID %>").style.display = "";
                        } else {
                            document.getElementById("<%=CommDUIMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=CommDUIYearsRow.ClientID %>").style.display = "none";
                        }
                        document.getElementById("<%=CommDUICountRow.ClientID %>").style.display = "";
                    } else {
                        document.getElementById("<%=CommDUIMilesRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=CommDUIYearsRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=CommDUICountRow.ClientID %>").style.display = "none";
                    }
                } else {
                    document.getElementById("<%=DUICommercialPanelCell.ClientID %>").style.display = "none";
                }
            }

            function onLimitByDUIPersonalRBCheckChanged() {
                var toggleindex = $find("<%=LimitByDUIPersonalRB.ClientID %>").get_selectedToggleStateIndex();
                var DUIPersonalByID = $find("<%=PersonalDUIByCB.ClientID %>").get_selectedItem().get_value();
                if (toggleindex == 1) {
                    document.getElementById("<%=DUIPersonalPanelCell.ClientID %>").style.display = "";
                    if (PersonalDUIByID != "11") {
                        if (PersonalDUIByID == "9" || PersonalDUIByID == "10") {
                            document.getElementById("<%=PersonalDUIMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=PersonalDUIYearsRow.ClientID %>").style.display = "";
                        } else if (PersonalDUIByID == "7") {
                            document.getElementById("<%=PersonalDUIMilesRow.ClientID %>").style.display = "";
                            document.getElementById("<%=PersonalDUIYearsRow.ClientID %>").style.display = "none";
                        } else if (PersonalDUIByID == "8") {
                            document.getElementById("<%=PersonalDUIMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=PersonalDUIYearsRow.ClientID %>").style.display = "";
                        } else {
                            document.getElementById("<%=PersonalDUIMilesRow.ClientID %>").style.display = "none";
                            document.getElementById("<%=PersonalDUIYearsRow.ClientID %>").style.display = "none";
                        }
                        document.getElementById("<%=PersonalDUICountRow.ClientID %>").style.display = "";
                    } else {
                        document.getElementById("<%=PersonalDUIMilesRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=PersonalDUIYearsRow.ClientID %>").style.display = "none";
                        document.getElementById("<%=PersonalDUICountRow.ClientID %>").style.display = "none";
                    }
                } else {
                    document.getElementById("<%=DUIPersonalPanelCell.ClientID %>").style.display = "none";
                }
            }

            function onFuelReimbursedRBCheckChanged(sender) {
                var toggleindex = sender.get_selectedToggleStateIndex();
                if (toggleindex == 1) {
                    document.getElementById("<%=AllFuelRow.ClientID %>").style.display = "";
                } else {
                    document.getElementById("<%=AllFuelRow.ClientID %>").style.display = "none";
                }
            }

            function onCancelRBClicked() {
                ChildCloseAndRedirect('Close');
            }

            function onPayTypeRCBSelectedIndexChanged() {
                var PartyTypeID = $find("<%=PayTypeRCB.ClientID %>").get_selectedItem().get_value();
                if (PartyTypeID == "2288") {
                    document.getElementById("LineHaulPercRow").style.display = "";
                    document.getElementById("LoadedPerMileRow").style.display = "none";
                    document.getElementById("EmptyPerMileRow").style.display = "none";
                    document.getElementById("HourlyRateRow").style.display = "none";
                } else if (PartyTypeID == "2289") {
                    document.getElementById("LineHaulPercRow").style.display = "none";
                    document.getElementById("LoadedPerMileRow").style.display = "";
                    document.getElementById("EmptyPerMileRow").style.display = "";
                    document.getElementById("HourlyRateRow").style.display = "none";
                } else if (PartyTypeID == "2290") {
                    document.getElementById("LineHaulPercRow").style.display = "none";
                    document.getElementById("LoadedPerMileRow").style.display = "none";
                    document.getElementById("EmptyPerMileRow").style.display = "none";
                    document.getElementById("HourlyRateRow").style.display = "";
                } else {
                    document.getElementById("LineHaulPercRow").style.display = "none";
                    document.getElementById("LoadedPerMileRow").style.display = "none";
                    document.getElementById("EmptyPerMileRow").style.display = "none";
                    document.getElementById("HourlyRateRow").style.display = "none";
                }
            }

            function onAdTemplateRBCheckChanged() {
                var toggleindex = $find("<%=AdTemplateRB.ClientID %>").get_selectedToggleStateIndex();
                if (toggleindex == 0) {
                    document.getElementById("RunOnRow").style.display = "";
                    document.getElementById("ExpireOnRow").style.display = "";
                } else {
                    document.getElementById("RunOnRow").style.display = "none";
                    document.getElementById("ExpireOnRow").style.display = "none";
                }
            }

            //SendCallBack function

            function SendCallBack(arg, myAction) {

                try {
                    switch (myAction) {
                    case "GeoJsonRegionST":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onAdGeoRGRowClicked_back", "null") %>
                            break;
                        }
                    case "GeoJsonLaneHub":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onAdGeoRGRowClicked_back", "null") %>
                            break;
                        }
                    case "GeoJsonRadius":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onAdGeoRGRowClicked_back", "null") %>
                            break;
                        }
                    case "LoadAllGeoJson":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onAdGeoRGCreated_back", "null") %>
                            break;
                        }
                    case "updateExpSlider":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "Finish", "null") %>
                            break;
                        }
                    }
                } catch (e) {}
            }

            //**********************
            //Rad alert functions
            //**********************

            var confirmType;
            var confirmID;

            function confirmCall(callType, callID, callName) {
                confirmType = callType;
                confirmID = callID;
                var confirmMess;
                var confirmTitle;

                if (callType == "deleteLayer") {

                    confirmMess = "Are you certain that you wish to <span style='color: #ff0000;'>permanently</span> delete this layer?";
                    confirmTitle = "Delete " & callName & " ?"
                    launchRadConfirm(confirmMess, confirmTitle);

                } else if (callType == "deletePrefItem") {

                    confirmMess = "Are you certain that you wish to <span style='color: #ff0000;'>permanently</span> delete the experience named: " + callName + "?";
                    confirmTitle = "Delete " & callName & " ?";
                    launchRadConfirm(confirmMess, confirmTitle);

                }
            }

            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow;
                else if (window.frameElement && window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
                return oWindow;
            }

            function launchRadConfirm(confirmMess, confirmTitle) {

                var oWnd = GetRadWindow();
                if (oWnd != null) {
                    setTimeout(function () {
                        GetRadWindow().BrowserWindow.radconfirm(confirmMess, confirmCallBackFn, 400, 115, null, confirmTitle, "/Images/Custom/DeleteLowRes.png");
                    }, 0);
                }
                //Info: Used to launch from a parent page.
                else {
                    radconfirm(confirmMess, confirmCallBackFn, 400, 115, null, confirmTitle, "/Images/Custom/DeleteLowRes.png");
                }

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

            function confirmCallBackFn(arg) {

                //Step 3:  Config different callbacks if required.  If you have only 2 parameters, these will do.
                if (arg == true) {

                    if (confirmType == "deleteLayer") {

                        var sendArg = confirmType + "," + confirmID; <%= Page.ClientScript.GetCallbackEventReference(Me, "sendArg", "FinishAlert", "null") %>

                    } else if (confirmType == "deletePrefItem") {

                        $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest(confirmType + "," + confirmID);

                    }

                }

            }

            function FinishAlert(arg) {

                //Step 5:  Launch alert if there is a problem with the procedure called by the launchRadConfirm function.
                if (arg != "Nothing") {

                    var messTitle
                    var mess

                    if (confirmType == "deleteLayer") {

                        messTitle = "Delete Failed"
                        mess = "<span style='color: #ff0000;'>WARNING:</span> The system failed to delete this layer. Usually, this is because this address is referenced in other places in FASTPORT, and thus cannot be deleted.  The technical details for this error are as follows: " + arg
                        
                        onAdGeoRGCreated();
                    }

                    launchRadAlert(mess, messTitle);

                } else {

                    if (confirmType == "deleteLayer") {

                        $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindAdGeoRG");
                        document.getElementById("HiddenTB_AdGeoStatus").value = "Saved";
                    }
                }

            }

            function Finish(arg) {

                if (arg != "Nothing") {

                    launchRadAlert(arg, "FASTPORT Error");

                }

            }
        </script>
    </telerik:RadCodeBlock>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="BlackMetroTouch"
        OnClientShowing="v_clearAdGeoFields" OnClientHiding="v_AdGeoTypeRCBValue">
    </telerik:RadAjaxLoadingPanel>
    <telerik:RadToolTip runat="server" ID="PrefRTT" HideEvent="ManualClose" RelativeTo="BrowserWindow"
        Modal="true" Width="430px" Skin="BlackMetroTouch" OnClientHide="closePrefRTT"
        Position="Center">
        <telerik:RadGrid ID="PrefRG" runat="server" DataSourceID="PrefDS" GridLines="None"
            ShowHeader="False" CellSpacing="0" AutoGenerateColumns="False">
            <ClientSettings>
                <ClientEvents OnRowMouseOver="getExpID" />
            </ClientSettings>
            <MasterTableView DataKeyNames="PartyExperienceID, Importance, ItemName, YearSlider"
                ClientDataKeyNames="PartyExperienceID, ItemName" DataSourceID="PrefDS">
                <NoRecordsTemplate>
                    <div style="padding: 25px;">
                        You have not yet entered stuff you want for this category. Please close this tool
                        tip and enter the stuff you want.
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
            </MasterTableView>
        </telerik:RadGrid>
        <asp:SqlDataSource ID="PrefDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
            SelectCommand="usp_PrefSliders_ByAd" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="HiddenTB_AdID" Name="PrefAdID" PropertyName="Text"
                    Type="Int32" />
                <asp:ControlParameter ControlID="HiddenTB_PrefParentID" Name="PrefParentIDs" PropertyName="Text"
                    Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </telerik:RadToolTip>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" EnableShadow="true">
    </telerik:RadWindowManager>
    <div>
        <table cellpadding="0" cellspacing="0" border="0">
            <tr>
                <td>
                    <asp:Panel ID="SizePanel" runat="server" Width="981px" Height="620px">
                        <table>
                            <tr>
                                <td>
                                    <table class="dv" cellpadding="0" cellspacing="0" border="0">
                                        <tr>
                                            <td>
                                                <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server">
                                                    <table>
                                                        <tr>
                                                            <td class="dfv" style="padding: 0px">
                                                                <telerik:RadTabStrip ID="EditCarrierRTS" runat="server" MultiPageID="EditCarrierRMP"
                                                                    SelectedIndex="0" Width="100%" Skin="BlackMetroTouch" OnClientTabSelected="v_EditCarrierRTS"
                                                                    OnClientLoad="v_EditCarrierRTS" Align="Justify">
                                                                    <Tabs>
                                                                        <telerik:RadTab runat="server" Text="1. Basic Info" PageViewID="PageView1">
                                                                        </telerik:RadTab>
                                                                        <telerik:RadTab runat="server" Text="2. Posting Map" PageViewID="PageView2">
                                                                        </telerik:RadTab>
                                                                        <telerik:RadTab runat="server" Text="3. NOT Wanted" PageViewID="PageView3">
                                                                        </telerik:RadTab>
                                                                        <telerik:RadTab runat="server" Text="4. Pay" PageViewID="PageView4">
                                                                        </telerik:RadTab>
                                                                        <telerik:RadTab runat="server" Text="5. More Details" PageViewID="PageView5">
                                                                        </telerik:RadTab>
                                                                        <telerik:RadTab runat="server" Text="6. Offices/Contacts" PageViewID="PageView6">
                                                                        </telerik:RadTab>
                                                                        <telerik:RadTab runat="server" Text="7. Post/Upgrade" PageViewID="PageView7">
                                                                        </telerik:RadTab>
                                                                    </Tabs>
                                                                </telerik:RadTabStrip>
                                                                <telerik:RadMultiPage ID="EditCarrierRMP" runat="server" SelectedIndex="0" Height="510px">
                                                                    <telerik:RadPageView ID="PageView1" runat="server" CssClass="nested_panel_cust">
                                                                        <center>
                                                                            <table>
                                                                                <tr>
                                                                                    <td colspan="2">
                                                                                        <table>
                                                                                            <tr id="InstructionsRow" runat="server" visible="false">
                                                                                                <td style="text-align: left;" class="dfv">
                                                                                                    <br />
                                                                                                    <asp:Literal runat="server" ID="InstructionsStandard" Text="438">	</asp:Literal>
                                                                                                    <br />
                                                                                                    <br />
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td style="vertical-align: top;">
                                                                                        <table style="float: left">
                                                                                            <col width="120px" />
                                                                                            <col width="300px" />
                                                                                            <tr>
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="AdNameLabel" Text="Job Title">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <span style="white-space: nowrap;">
                                                                                                        <asp:TextBox runat="server" ID="AdName" Columns="50" MaxLength="1000" CssClass="field_input"
                                                                                                            Width="300px" TabIndex="1"></asp:TextBox>
                                                                                                    </span>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="fls" style="vertical-align: middle">
                                                                                                    <asp:Label runat="server" ID="TruckerTypeLbl" Text="Trucker Type"></asp:Label>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="TruckerTypeRCB" runat="server" DataSourceID="TruckerTypeDS"
                                                                                                        DataTextField="ItemName" DataValueField="TreeID" MarkFirstMatch="True" ShowToggleImage="True"
                                                                                                        Width="167px" ZIndex="50001" TabIndex="2">
                                                                                                    </telerik:RadComboBox>
                                                                                                    <asp:SqlDataSource ID="TruckerTypeDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                                        SelectCommand="SELECT TreeID, ItemName, ItemRank FROM dbo.Tree WHERE TreeParentID = 2527 ORDER BY ItemRank">
                                                                                                    </asp:SqlDataSource>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="fls" style="vertical-align: middle">
                                                                                                    <asp:Label runat="server" ID="PositionsAvailableLtl" Text="Positions Available"></asp:Label>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadTextBox ID="PositionsAvailableRTB" runat="server" Width="50px" TabIndex="3">
                                                                                                    </telerik:RadTextBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="fls" style="vertical-align: middle">
                                                                                                    <asp:Literal runat="server" ID="LimitByAgeLabel" Text="Limit By Age"></asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <asp:CheckBox runat="server" ID="LimitByAge" AutoPostBack="false" TabIndex="8" Visible="false">
                                                                                                    </asp:CheckBox>
                                                                                                    <telerik:RadButton ID="LimitByAgeRB" runat="server" ToggleType="CheckBox" ButtonType="LinkButton"
                                                                                                        AutoPostBack="false" BorderWidth="0px" BackColor="White" TabIndex="4" OnClientClicked="onLimitByAgeRBCheckChanged">
                                                                                                        <ToggleStates>
                                                                                                            <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Value="1"></telerik:RadButtonToggleState>
                                                                                                            <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked" Value="0">
                                                                                                            </telerik:RadButtonToggleState>
                                                                                                        </ToggleStates>
                                                                                                    </telerik:RadButton>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="MinAgeRow" runat="server">
                                                                                                <td class="fls" style="vertical-align: middle">
                                                                                                    <asp:Literal runat="server" ID="MinAgeLabel" Text="Minimum Age">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <span style="white-space: nowrap;">
                                                                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                                                                            <tr>
                                                                                                                <td style="padding-right: 5px; vertical-align: top">
                                                                                                                    <asp:TextBox runat="server" ID="MinAge" Columns="14" MaxLength="14" CssClass="field_input"
                                                                                                                        Width="35px" TabIndex="5"></asp:TextBox>
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                        </table>
                                                                                                    </span>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                        <table style="float: left">
                                                                                            <col width="100px" />
                                                                                            <col width="300px" />
                                                                                            <col width="50px" />
                                                                                            <tr>
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="ShortDescriptionLabel" Text="Short Description">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <span style="white-space: nowrap;">
                                                                                                        <asp:TextBox runat="server" ID="ShortDescription" Columns="50" MaxLength="2000" CssClass="field_input"
                                                                                                            Height="75px" TextMode="MultiLine" Width="300px" TabIndex="6"></asp:TextBox>
                                                                                                    </span>
                                                                                                </td>
                                                                                                <td class="dfv" style="float: right">
                                                                                                    <asp:Image ID="DescVideoButton" runat="server"></asp:Image>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td colspan="3">
                                                                                                    <table style="padding-left: 10px; padding-top: 20px; padding-bottom: 20px; border: 1px solid #cccccc;
                                                                                                        border-radius: 10px">
                                                                                                        <tr>
                                                                                                            <td class="fls">
                                                                                                                <asp:Label runat="server" ID="Pref_GeneralLbl" Text="CDL Type, Etc.">	</asp:Label>
                                                                                                            </td>
                                                                                                            <td class="dfv">
                                                                                                                <telerik:RadAutoCompleteBox ID="Pref_GeneralRAC" runat="server" Filter="Contains"
                                                                                                                    DataSourceID="Pref_GeneralDS" DataValueField="TreeID" DataTextField="TreeFull"
                                                                                                                    InputType="Token" DropDownWidth="300px" Width="310px" TabIndex="7">
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
                                                                                                            <td class="dfv" style="float: right">
                                                                                                                <telerik:RadButton ID="Pref_GeneralRB" runat="server" Text="+/-" TabIndex="8" AutoPostBack="false"
                                                                                                                    OnClientClicked="function (args){showPrefRTT('743');}">
                                                                                                                </telerik:RadButton>
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                        <tr>
                                                                                                            <td class="fls">
                                                                                                                <asp:Label runat="server" ID="Pref_EquipLbl" Text="Equipment">	</asp:Label>
                                                                                                            </td>
                                                                                                            <td class="dfv">
                                                                                                                <telerik:RadAutoCompleteBox ID="Pref_EquipRAC" runat="server" Filter="Contains" DataSourceID="Pref_EquipDS"
                                                                                                                    DataValueField="TreeID" DataTextField="TreeFull" InputType="Token" DropDownWidth="300px"
                                                                                                                    Width="300px" TabIndex="9">
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
                                                                                                                <telerik:RadButton ID="Pref_EquipRB" runat="server" Text="+/-" TabIndex="10" AutoPostBack="false"
                                                                                                                    OnClientClicked="function (args){showPrefRTT('389');}">
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
                                                                                                                    InputType="Token" DropDownWidth="300px" Width="300px" TabIndex="11">
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
                                                                                                                <telerik:RadButton ID="Pref_CommodityRB" runat="server" Text="+/-" TabIndex="12"
                                                                                                                    AutoPostBack="false" OnClientClicked="function (args){showPrefRTT('666');}">
                                                                                                                </telerik:RadButton>
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                        <tr>
                                                                                                            <td class="fls">
                                                                                                                <asp:Label runat="server" ID="Pref_OtherLbl" Text="Other Items">	</asp:Label>
                                                                                                            </td>
                                                                                                            <td class="dfv">
                                                                                                                <telerik:RadAutoCompleteBox ID="Pref_OtherRAC" runat="server" Filter="Contains" DataSourceID="Pref_OtherDS"
                                                                                                                    DataValueField="TreeID" DataTextField="TreeFull" InputType="Token" DropDownWidth="300px"
                                                                                                                    Width="310px" TabIndex="13">
                                                                                                                    <DropDownItemTemplate>
                                                                                                                        <%# DataBinder.Eval(Container.DataItem, "TreeFullHTML")%>
                                                                                                                    </DropDownItemTemplate>
                                                                                                                </telerik:RadAutoCompleteBox>
                                                                                                                <asp:SqlDataSource ID="Pref_OtherDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                                                    SelectCommand="usp_Pref_OtherRollUp" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                                                                                                            </td>
                                                                                                            <td class="dfv" style="float: right">
                                                                                                                <telerik:RadButton ID="Pref_OtherRB" runat="server" Text="+/-" TabIndex="14" AutoPostBack="false"
                                                                                                                    OnClientClicked="function (args){showPrefRTT('851,852,853');}">
                                                                                                                </telerik:RadButton>
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                        <tr>
                                                                                                            <td class="fls">
                                                                                                            </td>
                                                                                                            <td class="dfv">
                                                                                                                <telerik:RadButton ID="Pref_EditRB" runat="server" Text="Edit" ToolTip="Click to modify the 'Stuff You Want'."
                                                                                                                    TabIndex="15">
                                                                                                                </telerik:RadButton>
                                                                                                            </td>
                                                                                                            <td class="dfv">
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                    </table>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </center>
                                                                    </telerik:RadPageView>
                                                                    <telerik:RadPageView ID="PageView2" runat="server" CssClass="nested_panel_cust">
                                                                        <telerik:RadSplitter ID="EditCarrierRS" runat="server" Skin="BlackMetroTouch" Orientation="Vertical"
                                                                            Width="100%" Height="525">
                                                                            <telerik:RadPane ID="AdGeoRP" runat="server" Width="480" MinWidth="100" MaxWidth="500">
                                                                                <telerik:RadSlidingZone ID="AdGeoSlidingZone" runat="server" Width="22">
                                                                                    <telerik:RadSlidingPane ID="AdGeoSlidingPane" runat="server" Title="Add Feature(s)"
                                                                                        Width="500px" Height="530px">
                                                                                        <div style="width: 475px; padding-left: 5px">
                                                                                            <table cellpadding="0" cellspacing="0" style="border: 1px solid #cfcfcf">
                                                                                                <col width="475px" />
                                                                                                <tr id="NewAdGeoAddRow" style="height: 275px; padding-top: 10px; background-color: #f4f4f4;">
                                                                                                    <td align="center" style="height: 30px">
                                                                                                        <telerik:RadButton ID="NewAdGeoAddRB" runat="server" Text="Add Feature(s) to Map"
                                                                                                            AutoPostBack="false" Font-Size="Medium" Height="25px" OnClientClicked="onNewAdGeoAddRBClicked">
                                                                                                        </telerik:RadButton>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </div>
                                                                                        <div id="AdGeoDiv" style="display: none; padding-left: 5px">
                                                                                            <telerik:RadTabStrip ID="AdGeoRTS" runat="server" SelectedIndex="0" MultiPageID="AdGeoRMP"
                                                                                                Skin="BlackMetroTouch" Width="475px">
                                                                                                <Tabs>
                                                                                                    <telerik:RadTab PageViewID="Feature" runat="server" Text="Feature Info" Value="0"
                                                                                                        Width="235px" Selected="true">
                                                                                                    </telerik:RadTab>
                                                                                                    <telerik:RadTab PageViewID="Notes" runat="server" Text="Feature Notes" Value="1"
                                                                                                        Width="240px">
                                                                                                    </telerik:RadTab>
                                                                                                </Tabs>
                                                                                            </telerik:RadTabStrip>
                                                                                            <telerik:RadMultiPage ID="AdGeoRMP" runat="server" SelectedIndex="0">
                                                                                                <telerik:RadPageView ID="Feature" runat="server">
                                                                                                    <table cellpadding="0" cellspacing="0" style="border: 1px solid #cfcfcf; border-bottom: 0px;
                                                                                                        width: 475px; background-color: #f4f4f4; padding-left: 5px; padding-right: 5px">
                                                                                                        <col width="100px" />
                                                                                                        <col width="260px" />
                                                                                                        <col width="110px" />
                                                                                                        <tr>
                                                                                                            <td colspan="3">
                                                                                                                <br />
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                        <tr id="AdGeoAddRow" style="display: none; vertical-align: top !important; height: 180px">
                                                                                                            <td>
                                                                                                                <telerik:RadComboBox ID="AdGeoTypeRCB" runat="server" EmptyMessage="Pick Feature"
                                                                                                                    DropDownAutoWidth="Enabled" Width="90px" OnClientSelectedIndexChanged="v_AdGeoLoad"
                                                                                                                    OnClientLoad="v_AdGeoSelectionIndexChanged" DataSourceID="AdGeoTypeRCB_DS" DataTextField="ItemName"
                                                                                                                    DataValueField="TreeID" TabIndex="1">
                                                                                                                </telerik:RadComboBox>
                                                                                                                <asp:SqlDataSource ID="AdGeoTypeRCB_DS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                                                    SelectCommand="SELECT TreeID, ItemName
                                                                                                                   FROM dbo.Tree
                                                                                                                   WHERE TreeParentID = '2588'"></asp:SqlDataSource>
                                                                                                            </td>
                                                                                                            <td>
                                                                                                                <telerik:RadComboBox ID="OriginCityRCB" runat="server" EmptyMessage="Origin City"
                                                                                                                    TabIndex="2" EnableLoadOnDemand="true" Width="250px" OnItemsRequested="s_OriginCityRCB_ItemsRequested">
                                                                                                                </telerik:RadComboBox>
                                                                                                                <telerik:RadAutoCompleteBox ID="RegionsRAC" runat="server" EmptyMessage="Region(s)"
                                                                                                                    InputType="Token" Width="250px" Filter="Contains" DataSourceID="RegionsDS" DataTextField="ItemName"
                                                                                                                    DataValueField="TreeID" OnClientEntryAdding="onAutoCompleteBoxEntryAdding" TabIndex="3">
                                                                                                                </telerik:RadAutoCompleteBox>
                                                                                                                <asp:SqlDataSource ID="RegionsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                                                    SelectCommand="SELECT TreeID, ItemName
                                                                                                                                    FROM dbo.Tree
                                                                                                                                    WHERE TreeParentID = '2499'"></asp:SqlDataSource>
                                                                                                                <telerik:RadAutoCompleteBox ID="StatesRAC" runat="server" EmptyMessage="State(s)"
                                                                                                                    Width="250px" DataSourceID="StatesDS" DataTextField="ItemName" DataValueField="TreeID"
                                                                                                                    OnClientEntryAdding="onAutoCompleteBoxEntryAdding" TabIndex="4">
                                                                                                                </telerik:RadAutoCompleteBox>
                                                                                                                <asp:SqlDataSource ID="StatesDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                                                    SelectCommand="SELECT TreeID, ItemName FROM dbo.Tree WHERE TreeParentID = '755'">
                                                                                                                </asp:SqlDataSource>
                                                                                                                <telerik:RadAutoCompleteBox ID="PointsRAC" runat="server" Filter="Contains" InputType="Token"
                                                                                                                    DropDownHeight="75" Width="250px" DataSourceID="PointsDS" DataTextField="Info"
                                                                                                                    TabIndex="5" DataValueField="PK" EmptyMessage="Point(s)" OnClientEntryAdding="onAutoCompleteBoxEntryAdding">
                                                                                                                </telerik:RadAutoCompleteBox>
                                                                                                                <asp:SqlDataSource ID="PointsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>">
                                                                                                                </asp:SqlDataSource>
                                                                                                                <br />
                                                                                                                <telerik:RadAutoCompleteBox ID="DestCityRAC" runat="server" Filter="Contains" InputType="Token"
                                                                                                                    DropDownHeight="75" Width="250px" DataSourceID="DestCityDS" DataTextField="Info"
                                                                                                                    TabIndex="7" DataValueField="PK" EmptyMessage="Destination City / Cities" OnClientEntryAdding="onAutoCompleteBoxEntryAdding">
                                                                                                                </telerik:RadAutoCompleteBox>
                                                                                                                <asp:SqlDataSource ID="DestCityDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>">
                                                                                                                </asp:SqlDataSource>
                                                                                                            </td>
                                                                                                            <td>
                                                                                                                <telerik:RadComboBox ID="OrigRadiusRCB" runat="server" Width="90px" MarkFirstMatch="true"
                                                                                                                    TabIndex="6">
                                                                                                                    <Items>
                                                                                                                        <telerik:RadComboBoxItem runat="server" Text="10 Miles" Value="10" Selected="true" />
                                                                                                                        <telerik:RadComboBoxItem runat="server" Text="25 Miles" Value="25" />
                                                                                                                        <telerik:RadComboBoxItem runat="server" Text="50 Miles" Value="50" />
                                                                                                                        <telerik:RadComboBoxItem runat="server" Text="100 Miles" Value="100" />
                                                                                                                        <telerik:RadComboBoxItem runat="server" Text="150 Miles" Value="150" />
                                                                                                                        <telerik:RadComboBoxItem runat="server" Text="200 Miles" Value="200" />
                                                                                                                    </Items>
                                                                                                                </telerik:RadComboBox>
                                                                                                                <br id="Temp" />
                                                                                                                <telerik:RadComboBox ID="DestRadiusRCB" runat="server" Width="90px" MarkFirstMatch="true"
                                                                                                                    TabIndex="8">
                                                                                                                    <Items>
                                                                                                                        <telerik:RadComboBoxItem runat="server" Text="10 Miles" Value="10" Selected="true" />
                                                                                                                        <telerik:RadComboBoxItem runat="server" Text="25 Miles" Value="25" />
                                                                                                                        <telerik:RadComboBoxItem runat="server" Text="50 Miles" Value="50" />
                                                                                                                        <telerik:RadComboBoxItem runat="server" Text="100 Miles" Value="100" />
                                                                                                                        <telerik:RadComboBoxItem runat="server" Text="150 Miles" Value="150" />
                                                                                                                        <telerik:RadComboBoxItem runat="server" Text="200 Miles" Value="200" />
                                                                                                                    </Items>
                                                                                                                </telerik:RadComboBox>
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                    </table>
                                                                                                </telerik:RadPageView>
                                                                                                <telerik:RadPageView ID="Notes" runat="server">
                                                                                                    <table style="border-spacing: 0px">
                                                                                                        <tr id="AdGeoNotesRow" style="height: 200px; display: none; vertical-align: top;
                                                                                                            border-spacing: 0px; padding-left: 0px; margin-left: 0px; background-color: #f4f4f4">
                                                                                                            <td colspan="3">
                                                                                                                <telerik:RadEditor ID="AdGeoNotesRE" runat="server" Height="196px" Width="469px"
                                                                                                                    EditModes="Design" ToolsFile="~/ToolsFileSmall.xml" TabIndex="9">
                                                                                                                </telerik:RadEditor>
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                    </table>
                                                                                                </telerik:RadPageView>
                                                                                            </telerik:RadMultiPage>
                                                                                            <table cellpadding="0" cellspacing="0" style="background-color: #f4f4f4; padding-left: 5px;
                                                                                                width: 475px; border: 1px solid #cfcfcf; border-top: 0px; height: 30px">
                                                                                                <col width="55px" />
                                                                                                <col width="415px" />
                                                                                                <tr id="AdGeoAddSaveRow" style="display: none; width: 475px">
                                                                                                    <td>
                                                                                                        <telerik:RadButton ID="AdGeoAddRB" runat="server" Text="Add" OnClientClicked="onMapModify">
                                                                                                        </telerik:RadButton>
                                                                                                        <telerik:RadButton ID="AdGeoSaveRB" runat="server" Text="Save" OnClientClicked="onMapModify">
                                                                                                        </telerik:RadButton>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                        <telerik:RadButton ID="AdGeoAddCancelRB" runat="server" Text="Cancel" AutoPostBack="false"
                                                                                                            OnClientClicked="onAdGeoCancelRB_Clicked">
                                                                                                        </telerik:RadButton>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </div>
                                                                                        <div style="width: 475px; padding-top: 15px; padding-left: 4px">
                                                                                            <table>
                                                                                                <col width="100px" />
                                                                                                <col width="380px" />
                                                                                                <tr>
                                                                                                    <td colspan="2">
                                                                                                        <telerik:RadGrid ID="AdGeoRG" runat="server" AutoGenerateColumns="false" DataSourceID="AdGeoDS"
                                                                                                            ShowHeader="true" Skin="Silk">
                                                                                                            <ClientSettings Selecting-AllowRowSelect="true">
                                                                                                                <ClientEvents OnRowSelected="onAdGeoRGRowClicked" OnGridCreated="onAdGeoRGCreated" />
                                                                                                            </ClientSettings>
                                                                                                            <MasterTableView ClientDataKeyNames="AdID, AdGeoID, AdGeoTypeID" DataKeyNames="AdID, AdGeoID, AdGeoTypeID"
                                                                                                                DataSourceID="AdGeoDS">
                                                                                                                <NoRecordsTemplate>
                                                                                                                </NoRecordsTemplate>
                                                                                                                <Columns>
                                                                                                                    <telerik:GridBoundColumn UniqueName="Feature" DataField="LayerHTML" HeaderStyle-Width="100px"
                                                                                                                        HeaderText="Feature">
                                                                                                                    </telerik:GridBoundColumn>
                                                                                                                    <telerik:GridBoundColumn UniqueName="Details" DataField="InfoHTML" HeaderStyle-Width="340px"
                                                                                                                        HeaderText="Details">
                                                                                                                    </telerik:GridBoundColumn>
                                                                                                                    <telerik:GridButtonColumn HeaderText="Edit" ButtonType="ImageButton" UniqueName="LayerEditIB"
                                                                                                                        ImageUrl="/Images/Custom/edit.png">
                                                                                                                    </telerik:GridButtonColumn>
                                                                                                                    <telerik:GridTemplateColumn HeaderText="Delete" UniqueName="DelLayer_TemplateColumn">
                                                                                                                        <ItemTemplate>
                                                                                                                            <asp:ImageButton ID="LayerDelIB" runat="server" ImageUrl="/Images/Custom/XOut_Small.png" />
                                                                                                                        </ItemTemplate>
                                                                                                                    </telerik:GridTemplateColumn>
                                                                                                                </Columns>
                                                                                                            </MasterTableView>
                                                                                                        </telerik:RadGrid>
                                                                                                        <asp:SqlDataSource ID="AdGeoDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                                            SelectCommand="usp_CarrierAdGeo" SelectCommandType="StoredProcedure">
                                                                                                            <SelectParameters>
                                                                                                                <asp:ControlParameter ControlID="HiddenTB_AdID" Name="AdID" PropertyName="Text" Type="Int32" />
                                                                                                            </SelectParameters>
                                                                                                        </asp:SqlDataSource>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </div>
                                                                                    </telerik:RadSlidingPane>
                                                                                </telerik:RadSlidingZone>
                                                                            </telerik:RadPane>
                                                                            <telerik:RadPane ID="MapRP" runat="server">
                                                                                <div id="HiddenTB" style="display: none">
                                                                                    AdGeoID:
                                                                                    <asp:TextBox ID="HiddenTB_AdGeoID" runat="server" Text="" Style="display: none">
                                                                                    </asp:TextBox>
                                                                                    <br />
                                                                                    AdGeoTypeID:
                                                                                    <asp:TextBox ID="HiddenTB_AdGeoTypeID" runat="server" Text="" Style="display: none">
                                                                                    </asp:TextBox>
                                                                                    <br />
                                                                                    AdGeoStatus:
                                                                                    <asp:TextBox ID="HiddenTB_AdGeoStatus" runat="server" Text="" Style="display: none">
                                                                                    </asp:TextBox>
                                                                                    <br />
                                                                                    LayerID:
                                                                                    <asp:TextBox ID="HiddenTB_LayerID" runat="server" Text="" Style="display: none">
                                                                                    </asp:TextBox>
                                                                                    <br />
                                                                                    LayerName:
                                                                                    <asp:TextBox ID="HiddenTB_LayerName" runat="server" Text="" Style="display: none">
                                                                                    </asp:TextBox>
                                                                                    <br />
                                                                                    LayerColor:
                                                                                    <asp:TextBox ID="HiddenTB_LayerColor" runat="server" Text="" Style="display: none">
                                                                                    </asp:TextBox>
                                                                                    <br />
                                                                                    LayerType:
                                                                                    <asp:TextBox ID="HiddenTB_LayerType" runat="server" Text="" Style="display: none">
                                                                                    </asp:TextBox>
                                                                                    <br />
                                                                                    LayerCoords:
                                                                                    <asp:TextBox ID="HiddenTB_LayerCoords" runat="server" Text="" Style="display: none">
                                                                                    </asp:TextBox>
                                                                                    MapModifyStatus:
                                                                                    <asp:TextBox ID="HiddenTB_MapModifyStatus" runat="server" Text="Saved" Style="display: none">
                                                                                    </asp:TextBox>
                                                                                </div>
                                                                            </telerik:RadPane>
                                                                        </telerik:RadSplitter>
                                                                    </telerik:RadPageView>
                                                                    <telerik:RadPageView ID="PageView3" runat="server" CssClass="nested_panel_cust">
                                                                        <asp:Panel ID="ReqScrollPanel1" runat="server" Height="525px" ScrollBars="Auto">
                                                                            <table>
                                                                                <tr>
                                                                                    <td style="display: none;">
                                                                                        <asp:SqlDataSource ID="LimitByDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                            SelectCommand="SELECT * FROM dbo.List WHERE ListType = 'Limit By' ORDER BY ListRank">
                                                                                        </asp:SqlDataSource>
                                                                                        <asp:SqlDataSource ID="YearsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                            SelectCommand="SELECT * FROM dbo.List WHERE ListType = 'Years' And ListID <> 41 ORDER BY ListRank">
                                                                                        </asp:SqlDataSource>
                                                                                        <asp:SqlDataSource ID="CountDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                            SelectCommand="SELECT * FROM dbo.List WHERE ListType = 'Count' ORDER BY ListRank">
                                                                                        </asp:SqlDataSource>
                                                                                        <asp:SqlDataSource ID="MilesDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                            SelectCommand="SELECT * FROM dbo.List WHERE ListType = 'Miles' ORDER BY ListRank">
                                                                                        </asp:SqlDataSource>
                                                                                        <span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="MajorByID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="MajorYearsID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="MinorByID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="MinorYearsID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="TicketsByID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="TicketYearsID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="SeriousByID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="SeriousYearsID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="FeloniesByID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="FelonyYearsID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="DrugConvictionsByID" CssClass="field_input"
                                                                                                onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="DrugYearsID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="FailedByID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="FailedYearsID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="CommDUIByID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="CommDUIYearsID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="PersonalDUIByID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="PersonalDUIYearsID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="MajorCountID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="MajorMilesID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="MinorCountID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="MinorMilesID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="TicketCountID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="TicketMilesID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="SeriousCountID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="SeriousMilesID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="FelonyCountID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="FelonyMilesID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="DrugCountID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="DrugConvictionMilesID" CssClass="field_input"
                                                                                                onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="FailedCountID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="FailedMilesID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="CommDUICountID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="CommDUIMilesID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="PersonalDUICountID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span><span style="white-space: nowrap;">
                                                                                            <asp:DropDownList runat="server" ID="PersonalDUIMilesID" CssClass="field_input" onkeypress="dropDownListTypeAhead(this,false)">
                                                                                            </asp:DropDownList>
                                                                                        </span>
                                                                                    </td>
                                                                                    <td class="dfv">
                                                                                    </td>
                                                                                    <td class="dfv">
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td colspan="4">
                                                                                        <table>
                                                                                            <tr id="InstructionsRow2" runat="server" visible="false">
                                                                                                <td style="text-align: left;" class="dfv">
                                                                                                    <br />
                                                                                                    <asp:Literal runat="server" ID="InstructionsStandard2" Text="440">	</asp:Literal>
                                                                                                    <br />
                                                                                                    <br />
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="fls" style="vertical-align: top; width: 150px;">
                                                                                        <asp:Literal runat="server" ID="PSPPointMaxLtl" Text="Maximum PSP Point">	</asp:Literal>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                        <telerik:RadTextBox ID="PSPPointMaxRTB" runat="server" Width="50px" AutoPostBack="false">
                                                                                        </telerik:RadTextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="fls" style="vertical-align: top; width: 150px;">
                                                                                        <asp:Literal runat="server" ID="LimitByMajorAccidentsLabel" Text="Major Accidents (More Than $2,500)">	</asp:Literal>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                        <telerik:RadButton ID="LimitByMajorAccidentsRB" runat="server" ToggleType="CheckBox"
                                                                                            ButtonType="LinkButton" AutoPostBack="false" BorderWidth="0px" BackColor="White"
                                                                                            OnClientClicked="onLimitByMajorAccidentsRBCheckChanged">
                                                                                            <ToggleStates>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Value="1"></telerik:RadButtonToggleState>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked" Value="0">
                                                                                                </telerik:RadButtonToggleState>
                                                                                            </ToggleStates>
                                                                                        </telerik:RadButton>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top; width: 75px;">
                                                                                        &nbsp;
                                                                                    </td>
                                                                                    <td id="MajorPanelCell" runat="server" style="vertical-align: top;" class="nested_panel_cust">
                                                                                        <table>
                                                                                            <tr runat="server" id="MajorMethodRow">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="MajorMethodLabel" Text="Limit by Method">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="MajorByCB" runat="server" Width="125px" DataSourceID="LimitByDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName" AutoPostBack="false" OnClientSelectedIndexChanged="onLimitByMajorAccidentsRBCheckChanged">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="MajorCountRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="CountLabel" Text="No More Than">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="MajorCountCB" runat="server" Width="125px" DataSourceID="CountDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="MajorMilesRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="MilesLabel" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="MajorMilesCB" runat="server" Width="125px" DataSourceID="MilesDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="MajorYearsRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="MajorYearsIDLabel" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="MajorYearsCB" runat="server" Width="125px" DataSourceID="YearsDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="fls" style="vertical-align: top;">
                                                                                        <asp:Literal runat="server" ID="LimitByMinorAccidentsLabel" Text="Minor Accidents (Less Than $2,500)">	</asp:Literal>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                        <telerik:RadButton ID="LimitByMinorAccidentsRB" runat="server" ToggleType="CheckBox"
                                                                                            ButtonType="LinkButton" AutoPostBack="false" BorderWidth="0px" BackColor="White"
                                                                                            OnClientCheckedChanged="onLimitByMinorAccidentsRBCheckChanged">
                                                                                            <ToggleStates>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Value="1"></telerik:RadButtonToggleState>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked" Value="0">
                                                                                                </telerik:RadButtonToggleState>
                                                                                            </ToggleStates>
                                                                                        </telerik:RadButton>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                    </td>
                                                                                    <td id="MinorPanelCell" runat="server" style="vertical-align: top;" class="nested_panel_cust">
                                                                                        <table>
                                                                                            <tr runat="server" id="MajorMethodRow1">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="MinorMethodLabel" Text="Limit by Method">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="MinorByCB" runat="server" Width="125px" DataSourceID="LimitByDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName" AutoPostBack="false" OnClientSelectedIndexChanged="onLimitByMinorAccidentsRBCheckChanged">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="MinorCountRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="CountLabel1" Text="No More Than">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="MinorCountCB" runat="server" Width="125px" DataSourceID="CountDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="MinorMilesRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="MilesLabel1" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="MinorMilesCB" runat="server" Width="125px" DataSourceID="MilesDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="MinorYearsRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="MinorYearsIDLabel" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="MinorYearsCB" runat="server" Width="85px" DataSourceID="YearsDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="fls" style="vertical-align: top;">
                                                                                        <asp:Literal runat="server" ID="LimitBySeriousTicketsLabel" Text="Serious Tickets (Reckless, 15 over limit, etc.) ">	</asp:Literal>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                        <telerik:RadButton ID="LimitBySeriousTicketsRB" runat="server" ToggleType="CheckBox"
                                                                                            ButtonType="LinkButton" AutoPostBack="false" BorderWidth="0px" BackColor="White"
                                                                                            OnClientCheckedChanged="onLimitBySeriousTicketsRBCheckChanged">
                                                                                            <ToggleStates>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Value="1"></telerik:RadButtonToggleState>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked" Value="0">
                                                                                                </telerik:RadButtonToggleState>
                                                                                            </ToggleStates>
                                                                                        </telerik:RadButton>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                    </td>
                                                                                    <td id="SeriousPanelCell" runat="server" style="vertical-align: top;" class="nested_panel_cust">
                                                                                        <table>
                                                                                            <tr runat="server" id="MajorMethodRow9">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="SeriousMethodLabel" Text="Limit by Method">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="SeriousByCB" runat="server" Width="125px" DataSourceID="LimitByDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName" AutoPostBack="false" OnClientSelectedIndexChanged="onLimitBySeriousTicketsRBCheckChanged">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="SeriousCountRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="CountLabel2" Text="No More Than">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="SeriousCountCB" runat="server" Width="125px" DataSourceID="CountDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="SeriousMilesRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="MilesLabel2" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="SeriousMilesCB" runat="server" Width="125px" DataSourceID="MilesDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="SeriousYearsRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="SeriousYearsIDLabel" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="SeriousYearsCB" runat="server" Width="85px" DataSourceID="YearsDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="fls" style="vertical-align: top;">
                                                                                        <asp:Literal runat="server" ID="LimitByTicketsLabel" Text="Other Tickets">	</asp:Literal>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                        <telerik:RadButton ID="LimitByTicketsRB" runat="server" ToggleType="CheckBox" ButtonType="LinkButton"
                                                                                            AutoPostBack="false" BorderWidth="0px" BackColor="White" OnClientCheckedChanged="onLimitByTicketsRBCheckChanged">
                                                                                            <ToggleStates>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Value="1"></telerik:RadButtonToggleState>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked" Value="0">
                                                                                                </telerik:RadButtonToggleState>
                                                                                            </ToggleStates>
                                                                                        </telerik:RadButton>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                    </td>
                                                                                    <td id="TicketsPanelCell" runat="server" style="vertical-align: top;" class="nested_panel_cust">
                                                                                        <table>
                                                                                            <tr runat="server" id="MajorMethodRow2">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="TicketMethodLabel" Text="Limit by Method">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="TicketsByCB" runat="server" Width="125px" DataSourceID="LimitByDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName" AutoPostBack="false" OnClientSelectedIndexChanged="onLimitByTicketsRBCheckChanged">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="TicketCountRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="CountLabel3" Text="No More Than">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="TicketCountCB" runat="server" Width="125px" DataSourceID="CountDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="TicketMilesRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="MilesLabel3" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="TicketMilesCB" runat="server" Width="125px" DataSourceID="MilesDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="TicketYearsRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="TicketYearsIDLabel" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="TicketYearsCB" runat="server" Width="85px" DataSourceID="YearsDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="fls" style="vertical-align: top;">
                                                                                        <asp:Literal runat="server" ID="LimitByFeloniesLabel" Text="Felonies">	</asp:Literal>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                        <telerik:RadButton ID="LimitByFeloniesRB" runat="server" ToggleType="CheckBox" ButtonType="LinkButton"
                                                                                            AutoPostBack="false" BorderWidth="0px" BackColor="White" OnClientCheckedChanged="onLimitByFeloniesRBCheckChanged">
                                                                                            <ToggleStates>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Value="1"></telerik:RadButtonToggleState>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked" Value="0">
                                                                                                </telerik:RadButtonToggleState>
                                                                                            </ToggleStates>
                                                                                        </telerik:RadButton>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                    </td>
                                                                                    <td id="FeloniesPanelCell" runat="server" style="vertical-align: top;" class="nested_panel_cust">
                                                                                        <table>
                                                                                            <tr runat="server" id="MajorMethodRow4">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="FeloniesMethodLabel" Text="Limit by Method">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="FeloniesByCB" runat="server" Width="125px" DataSourceID="LimitByDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName" AutoPostBack="false" OnClientSelectedIndexChanged="onLimitByFeloniesRBCheckChanged">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="FeloniesCountRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="CountLabel4" Text="No More Than">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="FeloniesCountCB" runat="server" Width="125px" DataSourceID="CountDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="FeloniesMilesRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="MilesLabel4" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="FeloniesMilesCB" runat="server" Width="125px" DataSourceID="MilesDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="FeloniesYearsRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="FeloniesYearsIDLabel" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="FeloniesYearsCB" runat="server" Width="85px" DataSourceID="YearsDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="fls" style="vertical-align: top;">
                                                                                        <asp:Literal runat="server" ID="LimitByDrugConvictionsLabel" Text="Drug Convictions">	</asp:Literal>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                        <telerik:RadButton ID="LimitByDrugConvictionsRB" runat="server" ToggleType="CheckBox"
                                                                                            ButtonType="LinkButton" AutoPostBack="false" BorderWidth="0px" BackColor="White"
                                                                                            OnClientCheckedChanged="onLimitByDrugConvictionsRBCheckChanged">
                                                                                            <ToggleStates>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Value="1"></telerik:RadButtonToggleState>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked" Value="0">
                                                                                                </telerik:RadButtonToggleState>
                                                                                            </ToggleStates>
                                                                                        </telerik:RadButton>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                    </td>
                                                                                    <td id="DrugConvictionsPanelCell" runat="server" style="vertical-align: top;" class="nested_panel_cust">
                                                                                        <table>
                                                                                            <tr runat="server" id="MajorMethodRow5">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="DrugConvictionsMethodLabel" Text="Limit by Method">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="DrugConvictionsByCB" runat="server" Width="125px" DataSourceID="LimitByDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName" AutoPostBack="false" OnClientSelectedIndexChanged="onLimitByDrugConvictionsRBCheckChanged">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="DrugConvictionsCountRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="CountLabel5" Text="No More Than">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="DrugCountCB" runat="server" Width="125px" DataSourceID="CountDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="DrugConvictionsMilesRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="MilesLabel5" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="DrugMilesCB" runat="server" Width="125px" DataSourceID="MilesDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="DrugConvictionsYearsRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="DrugConvictionsYearsIDLabel" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="DrugConvictionsYearsCB" runat="server" Width="85px" DataSourceID="YearsDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="fls" style="vertical-align: top;">
                                                                                        <asp:Literal runat="server" ID="LimitByFailedTestLabel" Text="Failed/Refused Drug/Alcohol Test">	</asp:Literal>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                        <telerik:RadButton ID="LimitByFailedTestRB" runat="server" ToggleType="CheckBox"
                                                                                            ButtonType="LinkButton" AutoPostBack="false" BorderWidth="0px" BackColor="White"
                                                                                            OnClientCheckedChanged="onLimitByFailedTestRBCheckChanged">
                                                                                            <ToggleStates>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Value="1"></telerik:RadButtonToggleState>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked" Value="0">
                                                                                                </telerik:RadButtonToggleState>
                                                                                            </ToggleStates>
                                                                                        </telerik:RadButton>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                    </td>
                                                                                    <td id="FailedPanelCell" runat="server" style="vertical-align: top;" class="nested_panel_cust">
                                                                                        <table>
                                                                                            <tr runat="server" id="MajorMethodRow6">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="FailedMethodLabel" Text="Limit by Method">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="FailedByCB" runat="server" Width="125px" DataSourceID="LimitByDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName" AutoPostBack="false" OnClientSelectedIndexChanged="onLimitByFailedTestRBCheckChanged">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="FailedCountRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="CountLabel6" Text="No More Than">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="FailedCountCB" runat="server" Width="125px" DataSourceID="CountDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="FailedMilesRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="MilesLabel6" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="FailedMilesCB" runat="server" Width="125px" DataSourceID="MilesDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="FailedYearsRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="FailedYearsIDLabel" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="FailedYearsCB" runat="server" Width="85px" DataSourceID="YearsDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="fls" style="vertical-align: top;">
                                                                                        <asp:Literal runat="server" ID="LimitByDUICommericialLabel" Text="Commercial DUI/DWI">	</asp:Literal>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                        <telerik:RadButton ID="LimitByDUICommercialRB" runat="server" ToggleType="CheckBox"
                                                                                            ButtonType="LinkButton" AutoPostBack="false" BorderWidth="0px" BackColor="White"
                                                                                            OnClientCheckedChanged="onLimitByDUICommercialRBCheckChanged">
                                                                                            <ToggleStates>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Value="1"></telerik:RadButtonToggleState>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked" Value="0">
                                                                                                </telerik:RadButtonToggleState>
                                                                                            </ToggleStates>
                                                                                        </telerik:RadButton>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                    </td>
                                                                                    <td id="DUICommercialPanelCell" runat="server" style="vertical-align: top;" class="nested_panel_cust">
                                                                                        <table>
                                                                                            <tr runat="server" id="MajorMethodRow7">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="CommDUIMethodLabel" Text="Limit by Method">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="CommDUIByCB" runat="server" Width="125px" DataSourceID="LimitByDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName" AutoPostBack="false" OnClientSelectedIndexChanged="onLimitByDUICommercialRBCheckChanged">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="CommDUICountRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="CountLabel7" Text="No More Than"></asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="CommDUICountCB" runat="server" Width="125px" DataSourceID="CountDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="CommDUIMilesRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="MilesLabel7" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="CommDUIMilesCB" runat="server" Width="125px" DataSourceID="MilesDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="CommDUIYearsRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="CommDUIYearsIDLabel" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="CommDUIYearsCB" runat="server" Width="85px" DataSourceID="YearsDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="fls" style="vertical-align: top;">
                                                                                        <asp:Literal runat="server" ID="LimitByDUIPersonalLabel" Text="Personal DUI/DWI">	</asp:Literal>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                        <telerik:RadButton ID="LimitByDUIPersonalRB" runat="server" ToggleType="CheckBox"
                                                                                            ButtonType="LinkButton" AutoPostBack="false" BorderWidth="0px" BackColor="White"
                                                                                            OnClientCheckedChanged="onLimitByDUIPersonalRBCheckChanged">
                                                                                            <ToggleStates>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Value="1"></telerik:RadButtonToggleState>
                                                                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked" Value="0">
                                                                                                </telerik:RadButtonToggleState>
                                                                                            </ToggleStates>
                                                                                        </telerik:RadButton>
                                                                                    </td>
                                                                                    <td class="dfv" style="vertical-align: top;">
                                                                                    </td>
                                                                                    <td id="DUIPersonalPanelCell" runat="server" style="vertical-align: top;" class="nested_panel_cust">
                                                                                        <table>
                                                                                            <tr runat="server" id="MajorMethodRow8">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="DUIPersonalMethodLabel" Text="Limit by Method">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="PersonalDUIByCB" runat="server" Width="125px" DataSourceID="LimitByDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName" AutoPostBack="false" OnClientSelectedIndexChanged="onLimitByDUIPersonalRBCheckChanged">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="PersonalDUICountRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="CountLabel8" Text="No More Than">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="PersonalDUICountCB" runat="server" Width="125px" DataSourceID="CountDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="PersonalDUIMilesRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="MilesLabel8" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="PersonalDUIMilesCB" runat="server" Width="125px" DataSourceID="MilesDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="PersonalDUIYearsRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="DUIPersonalYearsIDLabel" Text="Within">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <telerik:RadComboBox ID="PersonalDUIYearsCB" runat="server" Width="85px" DataSourceID="YearsDS"
                                                                                                        DataValueField="ListID" DataTextField="ListName">
                                                                                                    </telerik:RadComboBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </asp:Panel>
                                                                    </telerik:RadPageView>
                                                                    <telerik:RadPageView ID="PageView4" runat="server" CssClass="nested_panel_cust">
                                                                        <center>
                                                                            <table>
                                                                                <tr>
                                                                                    <td class="fls" style="display: none;">
                                                                                        <span style="white-space: nowrap;">
                                                                                            <asp:TextBox runat="server" ID="PayNotes" MaxLength="2000" Columns="60" CssClass="field_input"
                                                                                                Rows="6" TextMode="MultiLine">
                                                                                            </asp:TextBox>
                                                                                        </span>
                                                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                                                            <tr>
                                                                                                <td style="padding-right: 5px; vertical-align: top">
                                                                                                    <asp:TextBox runat="server" ID="LineHaulPerc" Columns="20" MaxLength="70" CssClass="field_input"></asp:TextBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td class="dfv">
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td colspan="2">
                                                                                        <table>
                                                                                            <tr id="InstructionsRow3" runat="server" visible="false">
                                                                                                <td style="text-align: left;" class="dfv">
                                                                                                    <br />
                                                                                                    <asp:Literal runat="server" ID="InstructionsStandard3" Text="441">	</asp:Literal>
                                                                                                    <br />
                                                                                                    <br />
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="dfv">
                                                                                        <table>
                                                                                            <tr>
                                                                                                <td class="fls" style="width: 125px">
                                                                                                    <asp:Literal runat="server" ID="PayTypeIDLabel" Text="Pay Type">	</asp:Literal>
                                                                                                </td>
                                                                                                <td class="dfv">
                                                                                                    <span style="white-space: nowrap;">
                                                                                                        <telerik:RadComboBox ID="PayTypeRCB" runat="server" AutoPostBack="false" OnClientSelectedIndexChanged="onPayTypeRCBSelectedIndexChanged">
                                                                                                            <Items>
                                                                                                                <telerik:RadComboBoxItem Text="Line Haul %" Value="2288" />
                                                                                                                <telerik:RadComboBoxItem Text="Per Mile" Value="2289" />
                                                                                                                <telerik:RadComboBoxItem Text="Hourly" Value="2290" />
                                                                                                            </Items>
                                                                                                        </telerik:RadComboBox>
                                                                                                    </span>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="LineHaulPercRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="LineHaulPercLabel" Text="% of Line Haul">	</asp:Literal>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <telerik:RadMaskedTextBox ID="LineHaulPercTB" runat="server" Mask="##%" Width="45px">
                                                                                                    </telerik:RadMaskedTextBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="LoadedPerMileRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="LoadedPerMileLabel" Text="Loaded Per Mile">	</asp:Literal>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <span style="white-space: nowrap;">
                                                                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                                                                            <tr>
                                                                                                                <td style="padding-right: 5px; vertical-align: top">
                                                                                                                    <asp:TextBox runat="server" ID="LoadedPerMile" Columns="20" MaxLength="31" CssClass="field_input"
                                                                                                                        Width="45px"></asp:TextBox>
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                        </table>
                                                                                                    </span>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="EmptyPerMileRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="EmptyPerMileLabel" Text="Empty Per Mile">	</asp:Literal>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <table border="0" cellpadding="0" cellspacing="0">
                                                                                                        <tr>
                                                                                                            <td style="padding-right: 5px; vertical-align: top">
                                                                                                                <asp:TextBox runat="server" ID="EmptyPerMile" Columns="20" MaxLength="31" CssClass="field_input"
                                                                                                                    Width="45px"></asp:TextBox>
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                    </table>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="HourlyRateRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="HourlyRateLabel" Text="Hourly Rate">	</asp:Literal>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <table border="0" cellpadding="0" cellspacing="0">
                                                                                                        <tr>
                                                                                                            <td style="padding-right: 5px; vertical-align: top">
                                                                                                                <asp:TextBox runat="server" ID="HourlyRate" Columns="20" MaxLength="31" CssClass="field_input"
                                                                                                                    Width="45px"></asp:TextBox>
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                    </table>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="FuelReimbursedLabel" Text="Fuel Reimbursed">	</asp:Literal>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <telerik:RadButton ID="FuelReimbursedRB" runat="server" ToggleType="CheckBox" ButtonType="LinkButton"
                                                                                                        AutoPostBack="false" BorderWidth="0px" BackColor="White" TabIndex="4" OnClientCheckedChanged="onFuelReimbursedRBCheckChanged">
                                                                                                        <ToggleStates>
                                                                                                            <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox"></telerik:RadButtonToggleState>
                                                                                                            <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked"></telerik:RadButtonToggleState>
                                                                                                        </ToggleStates>
                                                                                                    </telerik:RadButton>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr id="AllFuelRow" runat="server">
                                                                                                <td class="fls">
                                                                                                    <asp:Literal runat="server" ID="AllFuelLabel" Text="We Pass 100% of All Fuel Charge Fees Billed">	</asp:Literal>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <asp:CheckBox runat="server" ID="AllFuel"></asp:CheckBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td class="dfv">
                                                                                        <table>
                                                                                            <tr>
                                                                                                <td class="fls" style="color: Red; font-weight: bold; width: 125px">
                                                                                                    <asp:Literal runat="server" ID="AvgPayPerWeekLabel" Text="Average Pay for Full Week of Work">	</asp:Literal>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <table>
                                                                                                        <tr>
                                                                                                            <td>
                                                                                                                <table border="0" cellpadding="0" cellspacing="0">
                                                                                                                    <tr>
                                                                                                                        <td style="padding-right: 5px; vertical-align: top">
                                                                                                                            <asp:TextBox runat="server" ID="AvgPayPerWeek" Columns="20" MaxLength="31" CssClass="field_input"
                                                                                                                                Width="80px"></asp:TextBox>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                </table>
                                                                                                            </td>
                                                                                                            <td>
                                                                                                                <asp:Image ID="AvgPayVideoButton" runat="server"></asp:Image>
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                    </table>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="fls">
                                                                                                    <span style="color: #10498C">
                                                                                                        <asp:Literal runat="server" ID="PayGuarantyLabel" Text="We Stand Behind Average Pay Estimation">	</asp:Literal></span>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <asp:CheckBox runat="server" ID="PayGuaranty"></asp:CheckBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="dfv" colspan="2">
                                                                                        <center>
                                                                                            <table>
                                                                                                <tr>
                                                                                                    <td class="header_cust">
                                                                                                        <asp:Literal runat="server" ID="PayNotesLabel" Text="Other Payment Details">	</asp:Literal>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="dfv">
                                                                                                        <telerik:RadEditor ID="PayNotesRadEditor" runat="server" Height="150" Width="450"
                                                                                                            ToolsFile="~/ToolsFileMedium.xml" EditModes="Design">
                                                                                                        </telerik:RadEditor>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </center>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </center>
                                                                    </telerik:RadPageView>
                                                                    <telerik:RadPageView ID="PageView5" runat="server" CssClass="nested_panel_cust">
                                                                        <center>
                                                                            <table>
                                                                                <tr style="display: none;">
                                                                                    <td class="dfv" colspan="2">
                                                                                        <span style="white-space: nowrap;">
                                                                                            <asp:TextBox runat="server" ID="LongDescription" MaxLength="4000" Columns="60" CssClass="field_input"
                                                                                                Rows="6" TextMode="MultiLine" Visible="False"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td colspan="2">
                                                                                        <table>
                                                                                            <tr id="InstructionsRow4" runat="server" visible="false">
                                                                                                <td style="text-align: left;" class="dfv">
                                                                                                    <br />
                                                                                                    <asp:Literal runat="server" ID="InstructionsStandard4" Text="442">	</asp:Literal>
                                                                                                    <br />
                                                                                                    <br />
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="fls">
                                                                                        <asp:Literal ID="LongDescriptionLtl" runat="server" Text="Other Notes"></asp:Literal>
                                                                                    </td>
                                                                                    <td class="dfv">
                                                                                        <center>
                                                                                            <telerik:RadEditor ID="LongDescriptionRadEditor" runat="server" Height="300" Width="625"
                                                                                                ToolsFile="~/ToolsFileMedium.xml" EditModes="Design">
                                                                                            </telerik:RadEditor>
                                                                                            <br />
                                                                                        </center>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="fls">
                                                                                        <asp:Literal ID="LinksToJobPostingsLtl" runat="server" Text="Links to Other Postings"></asp:Literal>
                                                                                    </td>
                                                                                    <td class="dfv">
                                                                                        <center>
                                                                                            <telerik:RadEditor ID="LinksToJobPostingsRE" runat="server" Height="100" Width="625"
                                                                                                ToolsFile="~/ToolsFileMedium.xml" EditModes="Design">
                                                                                            </telerik:RadEditor>
                                                                                        </center>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </center>
                                                                    </telerik:RadPageView>
                                                                    <telerik:RadPageView ID="PageView6" runat="server" CssClass="nested_panel_cust">
                                                                        <center>
                                                                            <table>
                                                                                <tr>
                                                                                    <td colspan="3">
                                                                                        <table>
                                                                                            <tr id="InstructionsRow5" runat="server" visible="false">
                                                                                                <td style="text-align: left;" class="dfv">
                                                                                                    <br />
                                                                                                    <asp:Literal runat="server" ID="InstructionsStandard5" Text="444">	</asp:Literal>
                                                                                                    <br />
                                                                                                    <br />
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="dfv">
                                                                                        <telerik:RadGrid ID="TermRadGrid" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                                                                                            CellSpacing="0" DataSourceID="TermDS" OnItemDataBound="TermRadGrid_ItemDataBound"
                                                                                            CssClass="RemoveBorders" GridLines="None" ShowHeader="False" PageSize="10">
                                                                                            <ClientSettings EnableRowHoverStyle="True" EnablePostBackOnRowClick="True">
                                                                                                <Selecting AllowRowSelect="true" />
                                                                                                <Scrolling AllowScroll="true" ScrollHeight="400px" UseStaticHeaders="true" />
                                                                                            </ClientSettings>
                                                                                            <MasterTableView DataKeyNames="AddrID" ClientDataKeyNames="AddrID, PartyID" DataSourceID="TermDS">
                                                                                                <Columns>
                                                                                                    <telerik:GridTemplateColumn UniqueName="TemplateColumn1">
                                                                                                        <ItemTemplate>
                                                                                                            <asp:CheckBox ID="TermCk" runat="server" />
                                                                                                        </ItemTemplate>
                                                                                                        <HeaderStyle Width="30" />
                                                                                                    </telerik:GridTemplateColumn>
                                                                                                    <telerik:GridHTMLEditorColumn DataField="TermHTML" UniqueName="TermHTML">
                                                                                                        <HeaderStyle Width="150" />
                                                                                                    </telerik:GridHTMLEditorColumn>
                                                                                                </Columns>
                                                                                            </MasterTableView>
                                                                                        </telerik:RadGrid>
                                                                                        <asp:SqlDataSource ID="TermDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                            SelectCommand="SELECT * FROM [v_Addr] WHERE (([PartyID] = @TermPartyID) AND [MovedOut] = 0) ORDER BY [Headquarters] Desc, AddrName, CitySTZip">
                                                                                            <SelectParameters>
                                                                                                <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="TermPartyID" PropertyName="Text"
                                                                                                    Type="Int32" />
                                                                                            </SelectParameters>
                                                                                        </asp:SqlDataSource>
                                                                                        <asp:TextBox ID="HiddenTB_PartyID" runat="server" Style="display: none"></asp:TextBox>
                                                                                        <asp:TextBox ID="HiddenTB_AddrID" runat="server" Style="display: none" Text="0"></asp:TextBox>
                                                                                    </td>
                                                                                    <td style="width: 150px">
                                                                                    </td>
                                                                                    <td>
                                                                                        <telerik:RadGrid ID="PeopleRadGrid" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                                                                                            CellSpacing="0" DataSourceID="PeopleDS" OnItemDataBound="PeopleRadGrid_ItemDataBound"
                                                                                            CssClass="RemoveBorders" GridLines="None" ShowHeader="False" PageSize="10">
                                                                                            <ClientSettings EnableRowHoverStyle="True">
                                                                                                <Selecting AllowRowSelect="true" />
                                                                                                <Scrolling AllowScroll="true" ScrollHeight="400px" UseStaticHeaders="true" />
                                                                                            </ClientSettings>
                                                                                            <MasterTableView DataKeyNames="PartyID" ClientDataKeyNames="PartyID, ParentID" DataSourceID="PeopleDS">
                                                                                                <Columns>
                                                                                                    <telerik:GridTemplateColumn UniqueName="TemplateColumn1">
                                                                                                        <ItemTemplate>
                                                                                                            <asp:CheckBox ID="PeopleCk" runat="server" />
                                                                                                        </ItemTemplate>
                                                                                                        <HeaderStyle Width="30" />
                                                                                                    </telerik:GridTemplateColumn>
                                                                                                    <telerik:GridBinaryImageColumn DataField="FromPic" UniqueName="FromPic" ImageHeight="35"
                                                                                                        ImageWidth="35" ResizeMode="Fit">
                                                                                                        <HeaderStyle Width="50" />
                                                                                                    </telerik:GridBinaryImageColumn>
                                                                                                    <telerik:GridHTMLEditorColumn DataField="PersonHTML" UniqueName="PersonHTML">
                                                                                                        <HeaderStyle Width="150" />
                                                                                                    </telerik:GridHTMLEditorColumn>
                                                                                                </Columns>
                                                                                            </MasterTableView>
                                                                                        </telerik:RadGrid>
                                                                                        <asp:SqlDataSource ID="PeopleDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                            SelectCommand="usp_PeopleAtParty" SelectCommandType="StoredProcedure">
                                                                                            <SelectParameters>
                                                                                                <asp:ControlParameter ControlID="HiddenTB_PartyID" DefaultValue="" Name="PeopleParentID"
                                                                                                    PropertyName="Text" Type="String" />
                                                                                                <asp:ControlParameter ControlID="HiddenTB_AddrID" DefaultValue="" Name="PeopleAddrID"
                                                                                                    PropertyName="Text" Type="String" />
                                                                                                <asp:Parameter DefaultValue="1" Name="IncludeRoles" Type="String" />
                                                                                            </SelectParameters>
                                                                                        </asp:SqlDataSource>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td style="text-align: right;">
                                                                                        <asp:LinkButton runat="server" ID="UnselectAddrButton" CausesValidation="False" CommandName="Redirect"
                                                                                            consumers="page" Text="Unselect Rows" Visible="false">		
                                                                                        </asp:LinkButton>
                                                                                    </td>
                                                                                    <td style="width: 50px">
                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </center>
                                                                    </telerik:RadPageView>
                                                                    <telerik:RadPageView ID="PageView7" runat="server" CssClass="nested_panel_cust">
                                                                        <table style="padding: 20px;">
                                                                            <tr>
                                                                                <td>
                                                                                    <table>
                                                                                        <tr>
                                                                                            <td colspan="2" class="header_cust">
                                                                                                Job Posting Visibility
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr id="Tr1" runat="server">
                                                                                            <td class="fls" style="vertical-align: middle">
                                                                                                <asp:Literal runat="server" ID="AdTemplateLabel" Text="Template Only">	</asp:Literal>
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadButton ID="AdTemplateRB" runat="server" ToggleType="CheckBox" ButtonType="LinkButton"
                                                                                                    AutoPostBack="false" BorderWidth="0px" BackColor="White" TabIndex="4" OnClientCheckedChanged="onAdTemplateRBCheckChanged">
                                                                                                    <ToggleStates>
                                                                                                        <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox"></telerik:RadButtonToggleState>
                                                                                                        <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked"></telerik:RadButtonToggleState>
                                                                                                    </ToggleStates>
                                                                                                </telerik:RadButton>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr id="RunOnRow" runat="server">
                                                                                            <td class="fls" style="vertical-align: middle">
                                                                                                <asp:Literal runat="server" ID="RunOnLabel" Text="Run On">
                                                                                                </asp:Literal>
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadDatePicker ID="RunOnDatePicker" runat="server" Width="100px" TabIndex="6"
                                                                                                    SkipMinMaxDateValidationOnServer="true">
                                                                                                </telerik:RadDatePicker>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr id="ExpireOnRow" runat="server">
                                                                                            <td class="fls" style="vertical-align: middle">
                                                                                                <asp:Literal runat="server" ID="ExpireOnLabel" Text="Expire On">	</asp:Literal>
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadDatePicker ID="ExpireOnDatePicker" runat="server" Width="100px" TabIndex="7"
                                                                                                    SkipMinMaxDateValidationOnServer="true">
                                                                                                </telerik:RadDatePicker>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr id="Tr2" runat="server">
                                                                                            <td class="fls">
                                                                                                <asp:Literal runat="server" ID="HideAdLabel" Text="Mark Hidden">	</asp:Literal>
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <asp:CheckBox runat="server" ID="HideAd" TabIndex="10"></asp:CheckBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td colspan="2">
                                                                                                &nbsp;
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td colspan="2" class="header_cust">
                                                                                                Change Thumbnail (Optional)
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td class="fls">
                                                                                                &nbsp;
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadBinaryImage ID="ThumbnailRBI" runat="server" ResizeMode="Fit" />
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td class="fls">
                                                                                                <asp:Literal runat="server" ID="ThumbmnailRAULtl" Text="1. Select Thumbnail"></asp:Literal>
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadAsyncUpload runat="server" ID="ThumbnailRAU" MultipleFileSelection="Disabled"
                                                                                                    MaxFileInputsCount="1" />
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td class="fls">
                                                                                                <asp:Literal runat="server" ID="ThumbnailRBLtl" Text="2. Click Upload"></asp:Literal>
                                                                                            </td>
                                                                                            <td class="dfv">
                                                                                                <telerik:RadButton ID="ThumbnailRB" runat="server" Text="Upload Now" ToolTip="Click here to upload a custom thumbnail for this job posting."
                                                                                                    AutoPostBack="true">
                                                                                                </telerik:RadButton>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                                <td>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </telerik:RadPageView>
                                                                </telerik:RadMultiPage>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="dfv">
                                                                <asp:TextBox ID="HiddenTB_ConfigID" runat="server" Style="display: none" Text="359"></asp:TextBox>
                                                                <asp:TextBox ID="HiddenTB_AdID" runat="server" Text="0" Style="display: none"></asp:TextBox>
                                                                <asp:TextBox ID="HiddenTB_PrefParentID" runat="server" Text="0" Style="display: none"></asp:TextBox><br />
                                                                <asp:TextBox ID="HiddenTB_MouseOverID" runat="server" Text="0" Style="display: none"></asp:TextBox>
                                                                <asp:TextBox ID="HiddenTB_PageTitle" runat="server" Text="0" Style="display: none"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </telerik:RadAjaxPanel>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <center>
                                        <table cellpadding="0" cellspacing="0" border="0">
                                            <tr>
                                                <td style="padding-right: 5px">
                                                    <telerik:RadButton ID="SaveRB" runat="server" Text="Save" TabIndex="50">
                                                    </telerik:RadButton>
                                                </td>
                                                <td style="padding-left: 5px">
                                                    <telerik:RadButton ID="CancelRB" runat="server" Text="Cancel" TabIndex="51" AutoPostBack="false"
                                                        OnClientClicked="onCancelRBClicked">
                                                    </telerik:RadButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </center>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
