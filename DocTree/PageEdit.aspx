<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="PageEdit.aspx.vb" Inherits=".PageEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<style>
    .rieContentArea
    {
        overflow: auto !important;
    }
    body, html
    {
        width: 800px;
        height: 550px;
        margin: 0px;
        overflow: hidden;
    }
    #DocIE_ToolGroup3
    {
        width: 470px;
    }
</style>
<head runat="server">
    <title></title>
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

        window.onload = function () {
            var imageeditor = $find("<%=DocIE.ClientID %>");
            imageeditor.zoomBestFit();
        }

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

        function onDocIESaved(sender, args) {

            ChildCloseAndRedirect('rebindDocPageRLV');

        }

        function onDocIE_ImageChanged(sender, args) {
            sender.zoomBestFit();
        }

        Telerik.Web.UI.ImageEditor.CommandList["customSave"] = function (imageEditor, commandName, args) {
            imageEditor.saveImageOnServer("", true);
        }
    </script>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
    <div>
        <telerik:RadImageEditor ID="DocIE" runat="server" CanvasMode="Yes" UpperZoomBound="200"
            Width="765" Height="540" ImageCacheStorageLocation="Cache" OnClientSaved="onDocIESaved"
            StatusBarMode="Hidden" OnImageSaving="DocIE_ImageSaving" OnClientImageChanged="onDocIE_ImageChanged">
            <Tools>
                <telerik:ImageEditorToolGroup>
                    <telerik:ImageEditorTool Text="customSave" CommandName="customSave" ImageUrl="/Images/Custom/save-icon.png"
                        ToolTip="Save" />
                    <telerik:ImageEditorTool Text="InsertImage" CommandName="InsertImage" ToolTip="Insert Image" />
                    <telerik:ImageEditorTool Text="Print" CommandName="Print" ToolTip="Print" />
                </telerik:ImageEditorToolGroup>
                <telerik:ImageEditorToolGroup>
                    <telerik:ImageEditorToolStrip Text="Undo" CommandName="Undo" ToolTip="Undo" />
                    <telerik:ImageEditorToolStrip Text="Redo" CommandName="Redo" ToolTip="Redo" />
                    <telerik:ImageEditorTool Text="Reset" CommandName="Reset" ToolTip="Redo" />
                </telerik:ImageEditorToolGroup>
                <telerik:ImageEditorToolGroup>
                    <telerik:ImageEditorTool Text="Crop" CommandName="Crop" IsToggleButton="true" ToolTip="Crop" />
                    <telerik:ImageEditorTool Text="Zoom" CommandName="Zoom" ToolTip="Zoom" />
                    <telerik:ImageEditorTool Text="ZoomIn" CommandName="ZoomIn" ToolTip="Zoom In" />
                    <telerik:ImageEditorTool Text="ZoomOut" CommandName="ZoomOut" ToolTip="Zoom Out" />
                    <telerik:ImageEditorTool Text="RotateRight" CommandName="RotateRight" ToolTip="Rotate Right" />
                    <telerik:ImageEditorTool Text="RotateLeft" CommandName="RotateLeft" ToolTip="Rotate Left" />
                    <telerik:ImageEditorTool Text="FlipVertical" CommandName="FlipVertical" ToolTip="Flip Vertical" />
                    <telerik:ImageEditorTool Text="FlipHorizontal" CommandName="FlipHorizontal" ToolTip="Flip Horizontal" />
                    <telerik:ImageEditorTool Text="AddText" CommandName="AddText" IsToggleButton="true"
                        ToolTip="Add Text" />
                    <telerik:ImageEditorTool Text="Pencil" CommandName="Pencil" ToolTip="Drawing" />
                </telerik:ImageEditorToolGroup>
            </Tools>
        </telerik:RadImageEditor>
        <br />
        PageID:
        <asp:TextBox ID="HiddenTB_PageID" runat="server" Text="0" Style="display: none"></asp:TextBox><br />
        Image Byte:
        <asp:TextBox ID="HiddenTB_ImageByteArray" runat="server" Text="0" Style="display: none"></asp:TextBox>
    </div>
    </form>
</body>
</html>
