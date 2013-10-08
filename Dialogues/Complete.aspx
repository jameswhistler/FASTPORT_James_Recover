<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="Complete.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.Complete" %>

<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<asp:Content ID="PageSection" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
    <script type="text/javascript">

        var blockresize = false;

        window.onload = function () {

            if (blockresize == false) {

                var oWin = GetRadWindow();
                var height = 300;
                var width = 650;

                var title = document.getElementById("ctl00_PageContent_HiddenTB_PageTitle").value;

                if (!title) {

                    title = "Finished";

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
    <table cellpadding="0" cellspacing="0" border="0">
        <tr>
            <td class="dfv" style="width: 400px">
                <br />
                <asp:Literal runat="server" ID="InstructionsLiteral" Text="Instructions">	</asp:Literal>
            </td>
        </tr>
        <tr>
            <td class="dfv" style="width: 400px">
                <br />
                <br />
                <center>
                    <table>
                        <tr>
                            <td>
                                <FASTPORT:ThemeButton runat="server" id="CloseButton" button-causesvalidation="False"
                                    button-commandname="Redirect" button-text="Close" button-tooltip="Click to close this window.">
                                </FASTPORT:ThemeButton>
                            </td>
                            <td>
                                <asp:ImageButton runat="server" ID="DashboardButton" CausesValidation="False" CommandName="Redirect"
                                    ImageUrl="../Images/Custom/blank.png" Visible="True"></asp:ImageButton>
                            </td>
                        </tr>
                    </table>
                </center>
            </td>
        </tr>
    </table>
    <asp:TextBox ID="HiddenTB_PageTitle" runat="server" Text="Finished" Style="display: none">
    </asp:TextBox>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();"
        onmouseover="clearTimeout(gPopupTimer);">
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="false"
        runat="server"></asp:ValidationSummary>
</asp:Content>
