<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="MapImage.aspx.vb" Inherits=".MapImage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server" />
    <meta http-equiv='content-type' content='text/html; charset=utf-8' />
    <meta name='viewport' content='initial-scale=1.0 maximum-scale=1.0'>
    <script>        window.L_PREFER_CANVAS = true;</script>
    <link href='http://api.tiles.mapbox.com/mapbox.js/v1.3.1/mapbox.css' rel='stylesheet' />
    <!--[if lte IE 8]>
          <link href='//api.tiles.mapbox.com/mapbox.js/v1.3.1/mapbox.ie.css' rel='stylesheet' />
        <![endif]-->
    <script src='http://api.tiles.mapbox.com/mapbox.js/v1.3.1/mapbox.js'></script>
    <style>
        html
        {
            overflow: hidden;
            background-color: White;
            margin-top: 1000px;
        }
        #map
        {
            width: 800px;
            height: 343px;
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
            <telerik:AjaxSetting AjaxControlID="SaveImageRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="SaveImageRB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="LoadingPanel1" runat="server">
    </telerik:RadAjaxLoadingPanel>
    <asp:Panel ID="MapImagePnl" runat="server">
        <div>
            <div id="map">
            </div>
            <telerik:RadBinaryImage ID="OutputRBI" runat="server" />
            <div style="display: none">
                <telerik:RadButton ID="SaveImageRB" runat="server" Text="Save" Style="margin-top: 10px"
                    OnClientClicking="onSaveImageRBClicking">
                </telerik:RadButton>
            </div>
            <script src="/queue.js" type="text/javascript"></script>
            <script src="/leaflet-image.js" type="text/javascript"></script>
            <telerik:RadCodeBlock runat="server">
                <script type="text/javascript">

            function ChildCloseAndRedirect(args) {
                GetRadWindow().close();
                GetRadWindow().BrowserWindow.ParentCloseAndRedirect(args);
            }


            function ChildClose(args) {
                GetRadWindow().close();
            }

            function CloseAndRedirect(sender, args) {
                GetRadWindow().BrowserWindow.refreshGrid();
                GetRadWindow().close(); //closes the window
            }

            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow; //Will work in Moz in all cases, including clasic dialog
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow; //IE (and Moz as well)

                return oWindow;
            }

            var map = L.mapbox.map('map', 'http://a.tiles.mapbox.com/v3/fastport.map-zle7kuhd.jsonp', {
                tileLayer: {
                    detectRetina: true
                }
            }).setView([38.89399, -77.03659], 5);

            var AllLayers = new L.FeatureGroup();

            window.onload = function LoadGeoData() {
                
                $find("<%=LoadingPanel1.ClientID %>").show("<%=MapImagePnl.ClientID %>");
                var AdID = document.getElementById("HiddenTB_AdID").value;
                SendCallBack("LoadGeoData," + AdID, "LoadGeoData");

            }

            function LoadGeoData_back(arg) {

                AllLayers.clearLayers();
                var myString = arg;
                var mySplit = myString.split("<|>", 3);

                var geolanes = mySplit[0] || "";
                var georegions = mySplit[1] || "";
                var georadii = mySplit[2] || "";

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
                AllLayers.addTo(map);
                var bounds = AllLayers.getBounds();
                map.fitBounds(bounds);
                setTimeout(function() {
                    runOutputImage();
                }, 500);
                setTimeout(function() {
                    $find("<%=SaveImageRB.ClientID %>").click(true);
                    ChildCloseAndRedirect('RebindJobs');
                }, 3500);

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

            function runOutputImage() {
                
                leafletImage(map, doImage);


            }

            function doImage(err, canvas) {
                
                var img = $get("<%= OutputRBI.ClientID %>");
                img.src = canvas.toDataURL();

            }

            function onSaveImageRBClicking() {
                
                var base64string = document.getElementById("OutputRBI").src;
                base64string = base64string.replace("data:image/png;base64,", "");
                SendCallBack("SaveThumbnail," + base64string, "SaveThumbnail");

            }

            function onSaveImageRBClicking_back(arg) {

            }

            function SendCallBack(arg, myAction) {

                try {
                    switch (myAction) {
                        case "LoadGeoData":
                            { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "LoadGeoData_back", "null") %>
                                break;
                            }
                        case "SaveThumbnail":
                            { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onSaveImageRBClicking_back", "null") %>
                                break;
                            }
                    }
                } catch (e) {}
            }
                </script>
            </telerik:RadCodeBlock>
        </div>
    </asp:Panel>
    <div id="HiddenTBs" style="display: none">
        AdID:
        <asp:TextBox ID="HiddenTB_AdID" runat="server" Style="display: none"></asp:TextBox>
        <br />
        HiddenTB_LayerID:
        <asp:TextBox ID="HiddenTB_LayerID" runat="server" Text="" Style="display: none">
        </asp:TextBox>
        <br />
        HiddenTB_LayerName:
        <asp:TextBox ID="HiddenTB_LayerName" runat="server" Text="" Style="display: none">
        </asp:TextBox>
        <br />
        HiddenTB_LayerColor:
        <asp:TextBox ID="HiddenTB_LayerColor" runat="server" Text="" Style="display: none">
        </asp:TextBox>
        <br />
        HiddenTB_LayerType:
        <asp:TextBox ID="HiddenTB_LayerType" runat="server" Text="" Style="display: none">
        </asp:TextBox>
        <br />
        HiddenTB_LayerCoords:
        <asp:TextBox ID="HiddenTB_LayerCoords" runat="server" Text="" Style="display: none">
        </asp:TextBox>
        <br />
        Base64String:
        <asp:TextBox ID="HiddenTB_Base64String" runat="server" Text="" Style="display: none"></asp:TextBox>
    </div>
    </form>
</body>
</html>
