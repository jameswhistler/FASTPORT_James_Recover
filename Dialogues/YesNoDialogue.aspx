<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="YesNoDialogue.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.YesNoDialogue" %>

<%@ Register TagPrefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<asp:Content ID="PageSection" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
    <script type="text/javascript">

        function ChildCloseAndRedirect(args) {
            GetRadWindow().BrowserWindow.ParentCloseAndRedirect(args);
            GetRadWindow().close();
        }


        function ChildClose(args) {
            GetRadWindow().close();
        }

        function CloseAndRedirect(sender, args) {
            GetRadWindow().BrowserWindow.refreshGrid();
            GetRadWindow().close();       //closes the window       
        }
        function GetRadWindow()   //Get reference to window    
        {
            var oWindow = null;
            if (window.radWindow)
                oWindow = window.radWindow;
            else if (window.frameElement.radWindow)
                oWindow = window.frameElement.radWindow;
            return oWindow;
        }       
    </script>
    <table cellpadding="0" cellspacing="0" border="0">
        <tr>
            <td class="dfv" rowspan="2">
                <asp:ImageButton runat="server" ID="ImageButton" CausesValidation="False" CommandName="Redirect"
                    ImageUrl="../Images/Custom/Okay.png"></asp:ImageButton>
            </td>
            <td class="dfv" rowspan="2" style="width: 25px">
            </td>
            <td colspan="2" class="dfv">
                <br>
                <br>
                <b>
                    <asp:Literal runat="server" ID="MessageLiteral" Text="Are you certain that you wish to proceed?"
                        Mode="PassThrough">	</asp:Literal></b>
                <br>
                <br>
                <br>
            </td>
        </tr>
        <tr>
            <td class="dfv">
                <FASTPORT:ThemeButton runat="server" ID="YesButton" Button-CausesValidation="False"
                    Button-CommandName="Redirect" Button-Text="Yes, Proceed" Button-ToolTip="Click to proceed.">
                </FASTPORT:ThemeButton>
            </td>
            <td class="dfv">
                <FASTPORT:ThemeButton runat="server" ID="NoButton" Button-CausesValidation="False"
                    Button-CommandName="Redirect" Button-Text="No, Go Back" Button-ToolTip="Click if you wish to cancel this action and go back.">
                </FASTPORT:ThemeButton>
            </td>
        </tr>
    </table>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();"
        onmouseover="clearTimeout(gPopupTimer);">
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="false"
        runat="server"></asp:ValidationSummary>
</asp:Content>
