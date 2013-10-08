<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="InstructionsSecured.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.InstructionsSecured" %>

<%@ Register TagPrefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<asp:Content ID="PageSection" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
    <script type="text/javascript">
    
        var blockresize = false;

        window.onload = function () {

            if (blockresize == false) {

                var oWin = GetRadWindow();
                var height = 230;
                var width = 500;

                var title = document.getElementById("ctl00_PageContent_HiddenTB_PageTitle").value;

                if (!title) {
                    title = "FASTPORT"
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
            <td class="panel_simplepadding_cust">
                <table>
                    <tr id="SliderRow" runat="server" visible="false">
                        <td>
                            <center>
                                <table>
                                    <tr>
                                        <td>
                                            <div class="roundedcornr_box_300330">
                                                <div class="roundedcornr_top_300330">
                                                    <div>
                                                    </div>
                                                </div>
                                                <div class="roundedcornr_content_300330">
                                                    <p>
                                                        <telerik:RadSlider ID="ProgressRadSlider" runat="server" ItemType="item" CssClass="ItemsSlider"
                                                            ShowDecreaseHandle="false" ShowIncreaseHandle="false" Height="50">
                                                        </telerik:RadSlider>
                                                    </p>
                                                </div>
                                                <div class="roundedcornr_bottom_300330">
                                                    <div>
                                                    </div>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;
                                        </td>
                                    </tr>
                                </table>
                            </center>
                        </td>
                    </tr>
                    <tr>
                        <td class="dfv" style="width: 400px">
                            <asp:Literal runat="server" ID="InstructionsLiteral" Text="MyLiteral">	</asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <center>
                                <table>
                                    <tr>
                                        <td>
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
                                        <td>
                                            <FASTPORT:ThemeButton runat="server" ID="Next1Button" Button-CausesValidation="False"
                                                Button-CommandName="Redirect" Button-Text="Next Step >>>" Button-ToolTip="Click to move to the next step."
                                                Visible="False"></FASTPORT:ThemeButton>
                                        </td>
                                        <td>
                                            <FASTPORT:ThemeButton runat="server" ID="Next2Button" Button-CausesValidation="False"
                                                Button-CommandName="Redirect" Button-Text="Next Step >>>" Button-ToolTip="Click to move to the next step."
                                                Visible="False"></FASTPORT:ThemeButton>
                                        </td>
                                        <td>
                                            <FASTPORT:ThemeButton runat="server" ID="Next3Button" Button-CausesValidation="False"
                                                Button-CommandName="Redirect" Button-Text="Next Step >>>" Button-ToolTip="Click to move to the next step."
                                                Visible="False"></FASTPORT:ThemeButton>
                                        </td>
                                        <td>
                                            <FASTPORT:ThemeButton runat="server" ID="Next4Button" Button-CausesValidation="False"
                                                Button-CommandName="Redirect" Button-Text="Next Step >>>" Button-ToolTip="Click to move to the next step."
                                                Visible="False"></FASTPORT:ThemeButton>
                                        </td>
                                        <td>
                                            <div align="Right">
                                                <table>
                                                    <tr>
                                                        <td style="padding: 5px">
                                                            <asp:ImageButton runat="server" ID="RewindButton" CausesValidation="False" CommandName="Redirect"
                                                                ImageUrl="../Images/Custom/blank.png" Visible="False"></asp:ImageButton>
                                                        </td>
                                                        <td style="padding: 5px">
                                                            <asp:ImageButton runat="server" ID="MessageButton" CausesValidation="False" CommandName="Redirect"
                                                                ImageUrl="../Images/Custom/blank.png" Visible="False"></asp:ImageButton>
                                                        </td>
                                                        <td style="padding: 5px">
                                                            <asp:ImageButton runat="server" ID="DashboardButton" CausesValidation="False" CommandName="Redirect"
                                                                ImageUrl="../Images/Custom/blank.png" Visible="False"></asp:ImageButton>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </center>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <asp:TextBox ID="HiddenTB_PageTitle" runat="server" Text="0" Style="display: none">
    </asp:TextBox>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();"
        onmouseover="clearTimeout(gPopupTimer);">
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="false"
        runat="server"></asp:ValidationSummary>
</asp:Content>
