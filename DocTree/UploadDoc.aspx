<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="UploadDoc.aspx.vb" Inherits=".UploadDoc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
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
    <telerik:RadScriptBlock ID="RadScriptBlock1" runat="server">
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
                    var height = 580;
                    var width = 585;

                    var title = document.getElementById("HiddenTB_PageTitle").value;

                    if (!title) {
                        title = "FASTPORT"
                    } else {
                        title = "Upload: " + title
                    }

                    parent.onRWLoaded(oWin, "fixed", height, width, title);

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
    </telerik:RadScriptBlock>
    <div style="padding: 20px">
        <span class="dfv" style="padding-left: 0px;">To upload documents, please (1) drag files from your computer and drop them in the center of the section below or (2) click the select button. If you choose the second option, hold
            your "control" key (for PCs) or your "command" key (for Macs) to select multiple files at once. </span>
        <br />
        <br />
        <fieldset style="overflow: auto; max-height: 350px; width: 450px; background: d9d9d9;
            border-radius: 5px; -moz-border-radius: 5px; -webkit-border-radius: 5px; border: 2px solid #d9d9d9;">
            <legend><span style="font-size: 12px" class="dfv">(1) DROP Files Below -- or -- (2) CLICK "Select"</span></legend>
            <div style="padding: 10px;">
                <telerik:RadAsyncUpload runat="server" MultipleFileSelection="Automatic" ID="RadAsyncUpload1"
                    AllowedFileExtensions="jpg,jpeg,pdf,tiff,tif,bmp" />
            </div>
        </fieldset>
        <br />
        <div style="vertical-align: bottom; text-align: center;">
            <table>
                <tr>
                    <td>
                        <telerik:RadButton ID="UploadDocRB" runat="server" Text="Upload Docs" />
                    </td>
                    <td class="dfv">
                        <telerik:RadButton ID="ProcessBarCodesRB" runat="server" ToggleType="CheckBox" ButtonType="LinkButton"
                            AutoPostBack="false" BorderWidth="0px" BackColor="White" Text="Ignore Bar Codes">
                            <ToggleStates>
                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox"></telerik:RadButtonToggleState>
                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked"></telerik:RadButtonToggleState>
                            </ToggleStates>
                        </telerik:RadButton>
                    </td>
                </tr>
            </table>
        </div>
        <asp:TextBox ID="HiddenTB_PageTitle" runat="server" Text="0" Style="display: none;">
        </asp:TextBox>
    </div>
    </form>
</body>
</html>
