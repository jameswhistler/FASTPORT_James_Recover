<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="ThreadAdd.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.ThreadAdd" %>

<%@ Register TagPrefix="FASTPORT" Namespace="FASTPORT.UI.Controls.ThreadAdd" Assembly="FASTPORT" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<asp:Content ID="PageSection" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
    <telerik:RadScriptBlock runat="Server" ID="RadScriptBlock1">
        <script type="text/javascript">


            var blockresize = false;

            window.onload = function () {

                if (blockresize == false) {

                    var oWin = GetRadWindow();
                    var height = 750;
                    var width = 800;

                    parent.onRWLoaded(oWin, "fixed", height, width, "Send Message");

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

            /*Added By Princy-11.1.2012*/
            function OnREClientLoad(editor, args) {
                var buttonsHolder = $get(editor.get_id() + "Top");
                var buttons = buttonsHolder.getElementsByTagName("A");
                for (var i = 0; i < buttons.length; i++) {
                    var a = buttons[i];
                    a.tabIndex = -1;
                    a.tabStop = false;
                }
                editor.attachEventHandler("onkeydown", function (e) {
                    if (e.keyCode == '9') {
                        $("#ctl00_PageContent_SendButton__Button").focus();
                        e.preventDefault();
                        e.preventBubble();
                        e.stopPropagation();
                    }
                });
            }


            $ = $telerik.$;
            function OnUpldAdded(upld, args) {

                upld._addButton.tabIndex = -1;
                var $fileInput = $(args._fileInputField);

                var $fakeInput = $fileInput.nextAll("input[class='ruFakeInput']");
                var $selectButton = $fileInput.nextAll("input[class='ruButton ruBrowse']");

                $fakeInput.attr("tabindex", "-1");
                $selectButton.attr("tabindex", "-1");
                $(".ruRemove").attr("tabindex", "-1")

            }

            function setTabIndexAttribute() {

                var upload = $find("<%= RadUpload1.ClientID %>");
                var tabIndexCounter = 10;
                var inputs = upload.getFileInputs();

                for (var i = 0; i < inputs.length; i++) {
                    inputs[i].tabIndex = tabIndexCounter;
                    tabIndexCounter++;
                }

            }
            Sys.Application.add_load(setTabIndexAttribute);

            /*Added By Princy-11.1.2012*/

        </script>
    </telerik:RadScriptBlock>
    <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server">
        <table cellpadding="0" cellspacing="0" border="0">
            <tr>
                <td>
                    <table>
                        <tr>
                            <td>
                                <table>
                                    <tr id="ExistingAddressesRow" runat="server">
                                        <td class="fls">
                                            <asp:Literal runat="server" ID="ExistingAddressesLiteral" Text="Recipients">	</asp:Literal>
                                        </td>
                                        <td class="dfv" style="width: 630px">
                                            <asp:Literal ID="ExistingAddresses" runat="server" Text=""></asp:Literal>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="fls" style="width: 100px">
                                            <asp:Literal runat="server" ID="AddAddressesLiteral" Text="Add Recipients">	</asp:Literal>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadAutoCompleteBox ID="ToRAC" runat="server" Width="630px" Filter="Contains"
                                                DataSourceID="ToDS" DataValueField="PK" DataTextField="EmailFull" InputType="Token"
                                                TabIndex="99" AllowCustomEntry="true" DropDownWidth="350px" EmptyMessage="Choose Email or SMS contacts, or Type Fax Numbers (i.e. 855-277-4669)">
                                                <DropDownItemTemplate>
                                                    <%# DataBinder.Eval(Container.DataItem, "EmailHTML")%>
                                                </DropDownItemTemplate>
                                            </telerik:RadAutoCompleteBox>
                                            <asp:SqlDataSource ID="ToDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                SelectCommand="usp_EmailContacts" SelectCommandType="StoredProcedure">
                                                <SelectParameters>
                                                    <asp:SessionParameter Name="myUserID" SessionField="PartyID" Type="Int32" />
                                                </SelectParameters>
                                            </asp:SqlDataSource>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="fls">
                                            <asp:Literal runat="server" ID="SubjectLiteral" Text="Subject">	</asp:Literal>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadTextBox ID="MessageSubject" runat="server" Width="630px" AutoPostBack="true">
                                            </telerik:RadTextBox>
                                        </td>
                                    </tr>
                                    <tr id="CurrentAttachmentsRow" runat="server" visible="false">
                                        <td class="fls" style="vertical-align: top;">
                                            <asp:Literal runat="server" ID="CurrentAttachmentsLiteral" Text="Already Attached">	</asp:Literal>
                                        </td>
                                        <td>
                                            <FASTPORT:ThreadInstanceMessageAttachmentsTableControl runat="server" ID="ThreadInstanceMessageAttachmentsTableControl">
                                                <table class="dv" cellpadding="0" cellspacing="0" border="0">
                                                    <tr>
                                                        <td>
                                                            <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                                                <tr>
                                                                    <td class="tre">
                                                                        <table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)">
                                                                            <asp:Repeater runat="server" ID="ThreadInstanceMessageAttachmentsTableControlRepeater">
                                                                                <ItemTemplate>
                                                                                    <FASTPORT:ThreadInstanceMessageAttachmentsTableControlRow runat="server" ID="ThreadInstanceMessageAttachmentsTableControlRow">
                                                                                        <tr>
                                                                                            <td class="ttc">
                                                                                                <asp:LinkButton runat="server" ID="Attachment" CommandName="Redirect" filenamefield="FileName"></asp:LinkButton>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </FASTPORT:ThreadInstanceMessageAttachmentsTableControlRow>
                                                                                </ItemTemplate>
                                                                            </asp:Repeater>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </FASTPORT:ThreadInstanceMessageAttachmentsTableControl>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="fls" style="vertical-align: top;">
                                            <asp:Literal runat="server" ID="AttachmentsLiteral" Text="Attach Files">	</asp:Literal>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadProgressManager ID="RadProgressManager1" runat="server" />
                                            <telerik:RadUpload ID="RadUpload1" runat="server" ControlObjectsVisibility="RemoveButtons,AddButton" />
                                            <telerik:RadProgressArea runat="server" ID="RadProgressArea1" EnableEmbeddedSkins="false">
                                            </telerik:RadProgressArea>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="dfv" colspan="2">
                                            <br />
                                            <telerik:RadEditor ID="ThreadRE" runat="server" Height="350" Width="735" OnClientLoad="OnREClientLoad"
                                                ToolsFile="~/ToolsFileMedium.xml" EditModes="Design" TabIndex="3">
                                            </telerik:RadEditor>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="fls">
                    <center>
                        <table>
                            <tr>
                                <td>
                                    <FASTPORT:ThemeButton runat="server" ID="SendButton" Button-CausesValidation="False"
                                        Button-CommandName="Redirect" Button-TabIndex="4" Button-Text="Send Message"
                                        Button-ToolTip="Click to send this message."></FASTPORT:ThemeButton>
                                </td>
                                <td>
                                    <FASTPORT:ThemeButton runat="server" ID="CancelButton" Button-CausesValidation="False"
                                        Button-CommandName="Redirect" Button-TabIndex="5" Button-Text="Cancel" Button-ToolTip="Click to cancel this message.">
                                    </FASTPORT:ThemeButton>
                                </td>
                            </tr>
                        </table>
                    </center>
                </td>
            </tr>
        </table>
    </telerik:RadAjaxPanel>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();"
        onmouseover="clearTimeout(gPopupTimer);">
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="false"
        runat="server"></asp:ValidationSummary>
</asp:Content>
