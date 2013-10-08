<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="UploadSignedDoc.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.UploadSignedDoc" %>
<%@ Register Tagprefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
	<telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
	</telerik:RadAjaxManager>

	<telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
    </telerik:RadStyleSheetManager>	
	
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

        </script><table cellpadding="0" cellspacing="0" border="0"><tr><td style="width:850px"><table><tr><td class="dfv"><asp:Panel runat="Server" Width="450px" Height="350px" ScrollBar="Auto">
<br />
To upload a signed document for this agreement, please (1) click the select button, (2) select the file you want to upload, and then click the "Upload and Save" button.  
<br />
<br />
<telerik:RadProgressManager id="RadProgressManager1" runat="server" />
<telerik:RadUpload id="RadUpload1" runat="server" AllowedFileExtensions=".pdf,.jpg,.jpeg,.tif,.tiff" controlobjectsvisibility="RemoveButtons,AddButton" />
<telerik:RadProgressArea runat="server" ID="RadProgressArea1"></telerik:RadProgressArea>
</asp:Panel></td></tr><tr><td><center><FASTPORT:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="Redirect" button-redirectargument="UpdateData" button-text="Upload and Save" button-tooltip="Click here to save the documents shown above to your FASTPORT." postback="True"></FASTPORT:ThemeButton></center></td></tr></table>

</td></tr></table><div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>