<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="EditCarrier.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.EditCarrier" %>

<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<asp:Content ID="PageSection" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
    </telerik:RadStyleSheetManager>
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <style type="text/css">
            div.RemoveBorders .rgHeader, div.RemoveBorders th.rgResizeCol, div.RemoveBorders .rgFilterRow td
            {
                border-width: 0 0 1px 0; /*top right bottom left*/
            }
            
            div.RemoveBorders .rgRow td, div.RemoveBorders .rgAltRow td, div.RemoveBorders .rgEditRow td, div.RemoveBorders .rgFooter td
            {
                border-width: 0;
                padding-left: 7px; /*needed for row hovering and selection*/
            }
            
            div.RemoveBorders .rgGroupHeader td, div.RemoveBorders .rgFooter td
            {
                padding-left: 7px;
            }
        </style>
        <script type="text/javascript">

            var blockresize = false;

            window.onload = function () {

                if (blockresize == false) {

                    var oWin = GetRadWindow();
                    var height = 790;
                    var width = 971;

                    parent.onRWLoaded(oWin, "fixed", height, width, "Edit Carrier");

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
    </telerik:RadCodeBlock>
    <asp:UpdateProgress runat="server" ID="UpdatePanel1_UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1">
        <ProgressTemplate>
            <div class="ajaxUpdatePanel">
            </div>
            <div style="position: absolute; padding: 30px;">
                <img src="../Images/updating.gif" alt="Updating" />
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:UpdatePanel runat="server" ID="UpdatePanel1" UpdateMode="Conditional">
        <ContentTemplate>
            <input type="hidden" id="_clientSideIsPostBack" name="clientSideIsPostBack" runat="server" />
            <telerik:RadToolTip runat="server" ID="WarningRTT" HideEvent="ManualClose" Width="250px"
                Height="70px" RelativeTo="Element" ShowEvent="FromCode">
            </telerik:RadToolTip>
            <table cellpadding="0" cellspacing="0" border="0">
                <tr>
                    <td>
                        <telerik:RadTabStrip ID="RadTabStrip1" runat="server" MultiPageID="RadMultiPage1"
                            SelectedIndex="0" Width="828px">
                            <Tabs>
                                <telerik:RadTab runat="server" Text="General Carrier Info" Style="font-size: 4;"
                                    PageViewID="PageView1">
                                </telerik:RadTab>
                                <telerik:RadTab runat="server" Text="Terminals and Office Workers" PageViewID="PageView2">
                                </telerik:RadTab>
                            </Tabs>
                        </telerik:RadTabStrip>
                        <br />
                        <telerik:RadMultiPage ID="RadMultiPage1" runat="server" SelectedIndex="0">
                            <telerik:RadPageView ID="PageView1" runat="server" CssClass="nested_panel_cust">
                                <center>
                                    <table>
                                        <tr id="InstructionsRow" runat="server" visible="false">
                                            <td colspan="4">
                                                <table>
                                                    <tr id="InstructionsRow1" runat="server" visible="false">
                                                        <td style="text-align: left;" class="dfv">
                                                            <br />
                                                            <asp:Literal runat="server" ID="InstructionsStandard" Text="427">	</asp:Literal>
                                                            <br />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                            <td class="header_cust" colspan="2">
                                                <asp:Label runat="server" ID="ContactHeaderLabel" Text="Contact Info for Safety Dept.">	</asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                            <td class="fls">
                                                &nbsp;
                                            </td>
                                            <td>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td rowspan="7" colspan="2" style="vertical-align: middle; width: 350px;">
                                                <center>
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <center>
                                                                    <telerik:RadBinaryImage ID="LogoRadBinaryImage" runat="server" />
                                                                    <br />
                                                                    <br />
                                                                    <telerik:RadButton ID="UpdateLogoRadButton" runat="server" Text="Upload Logo" ToolTip="Click here to update your company logo."
                                                                        AutoPostBack="True">
                                                                    </telerik:RadButton>
                                                                </center>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </center>
                                            </td>
                                            <td class="fls">
                                                <asp:Label runat="server" ID="DOTNumberLabel" Text="DOT Number">	</asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <telerik:RadMaskedTextBox ID="DOTNumberTB" runat="server" Mask="#######" Width="175px"
                                                    TabIndex="1" AutoPostBack="true">
                                                </telerik:RadMaskedTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls">
                                                <asp:Label runat="server" ID="MCNumberLabel" Text="MC Number">	</asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <telerik:RadMaskedTextBox ID="MCNumberTB" runat="server" Mask="<MC|MX|P|FF>-######l"
                                                    Width="175px" TabIndex="2" AutoPostBack="true">
                                                </telerik:RadMaskedTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls">
                                                <asp:Label runat="server" ID="CarrierNameLabel" Text="Full Legal Name">	</asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <telerik:RadTextBox ID="NameTB" runat="server" Width="175px" TabIndex="3" AutoPostBack="true">
                                                </telerik:RadTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls">
                                                <asp:Label runat="server" ID="DBALbl" Text="DBA">	</asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <telerik:RadTextBox ID="DBATB" runat="server" Width="175px" TabIndex="4" AutoPostBack="true">
                                                </telerik:RadTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls">
                                                <asp:Label runat="server" ID="EmailLabel" Text="Safety Email">	</asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <telerik:RadTextBox ID="EmailTB" runat="server" TabIndex="5">
                                                </telerik:RadTextBox>
                                                <br />
                                                <asp:RegularExpressionValidator ID="emailValidator" runat="server" Display="Dynamic"
                                                    ErrorMessage="Please enter valid e-mail." ValidationExpression="^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$"
                                                    ControlToValidate="EmailTB">
                                                </asp:RegularExpressionValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls">
                                                <asp:Label runat="server" ID="PhoneLabel" Text="Safety Phone">	</asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <telerik:RadMaskedTextBox ID="PhoneTB" runat="server" Mask="###-###-#### #####" Width="125px"
                                                    TabIndex="6">
                                                </telerik:RadMaskedTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls">
                                                <asp:Label runat="server" ID="FaxLabel" Text="Safety Fax">	</asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <telerik:RadMaskedTextBox ID="FaxTB" runat="server" Mask="###-###-####" Width="125px"
                                                    TabIndex="7">
                                                </telerik:RadMaskedTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls">
                                                &nbsp;
                                            </td>
                                            <td class="dfv">
                                            </td>
                                            <td class="fls">
                                            </td>
                                            <td class="dfv">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="header_cust" colspan="4">
                                                <asp:Label runat="server" ID="ProfileHeaderLabel" Text="Full Profile">	</asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="dfv" colspan="4">
                                                <center>
                                                    <table>
                                                        <tr>
                                                            <td class="dfv">
                                                                <telerik:RadEditor ID="ProfileRadEditor" runat="server" Height="105" Width="750"
                                                                    ToolsFile="~/ToolsFileMedium.xml" EditModes="Design">
                                                                </telerik:RadEditor>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </center>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls">
                                                &nbsp;
                                            </td>
                                            <td class="fls">
                                            </td>
                                            <td class="fls">
                                            </td>
                                            <td class="fls">
                                                <telerik:RadButton ID="EditRadButton" runat="server" Text="Edit" ToolTip="Click here to edit the fields shown above.">
                                                </telerik:RadButton>
                                            </td>
                                        </tr>
                                    </table>
                                </center>
                            </telerik:RadPageView>
                            <telerik:RadPageView ID="PageView2" runat="server" CssClass="nested_panel_cust">
                                <center>
                                    <table>
                                        <tr id="InstructionsRow2" runat="server" visible="false">
                                            <td colspan="3">
                                                <table>
                                                    <tr>
                                                        <td style="text-align: left;" class="dfv">
                                                            <br />
                                                            <asp:Literal runat="server" ID="InstructionsStandard1" Text="431">	</asp:Literal>
                                                            <br />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="header_cust">
                                                <asp:Label runat="server" ID="TerminalsHeaderLabel" Text="Terminals and Offices">	</asp:Label>
                                            </td>
                                            <td class="dfv" style="width: 75px">
                                                &nbsp;
                                            </td>
                                            <td class="header_cust">
                                                <asp:Label runat="server" ID="PeopleHeaderLabel" Text="Office Workers for Carrier">	</asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="dfv">
                                                &nbsp;
                                            </td>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="dfv">
                                                <table>
                                                    <tr>
                                                        <td class="dfv">
                                                            <FASTPORT:ThemeButton runat="server" ID="AddAddrButton" Button-CausesValidation="False"
                                                                Button-CommandName="Redirect" Button-TabIndex="9" Button-Text="Add >>>" Button-ToolTip="Click to add a new terminal or office to your carrier.">
                                                            </FASTPORT:ThemeButton>
                                                        </td>
                                                        <td style="text-align: right;">
                                                            <div align="Right">
                                                                <asp:LinkButton runat="server" ID="UnselectAddrButton" CausesValidation="False" CommandName="Redirect"
                                                                    consumers="page" TabIndex="10" Text="Unselect Rows" Visible="False">		
                                                                </asp:LinkButton></div>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td>
                                            </td>
                                            <td class="dfv">
                                                <FASTPORT:ThemeButton runat="server" ID="AddWorkerButton" Button-CausesValidation="False"
                                                    Button-CommandName="Redirect" Button-TabIndex="11" Button-Text="Add >>>" Button-ToolTip="Click to add a new officer worker to your carrier.">
                                                </FASTPORT:ThemeButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="dfv">
                                                <telerik:RadGrid ID="TermRadGrid" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                                                    CellSpacing="0" DataSourceID="TermDS" OnItemDataBound="TermRadGrid_ItemDataBound"
                                                    CssClass="RemoveBorders" GridLines="None" ShowHeader="False" PageSize="10" Width="300px">
                                                    <ClientSettings EnableRowHoverStyle="True" EnablePostBackOnRowClick="True">
                                                        <Selecting AllowRowSelect="true" />
                                                        <Scrolling AllowScroll="true" ScrollHeight="325px" UseStaticHeaders="true" />
                                                    </ClientSettings>
                                                    <MasterTableView DataKeyNames="PartyID, AddrID" ClientDataKeyNames="AddrID, PartyID"
                                                        DataSourceID="TermDS">
                                                        <Columns>
                                                            <telerik:GridHTMLEditorColumn DataField="TermHTML" UniqueName="TermHTML">
                                                            </telerik:GridHTMLEditorColumn>
                                                            <telerik:GridButtonColumn ButtonType="ImageButton" UniqueName="EditButton">
                                                                <HeaderStyle Width="75" />
                                                            </telerik:GridButtonColumn>
                                                        </Columns>
                                                    </MasterTableView>
                                                </telerik:RadGrid>
                                                <asp:SqlDataSource ID="TermDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                    SelectCommand="SELECT * FROM [v_Addr] WHERE (([PartyID] = @TermPartyID) AND [MovedOut] = @MovedOut) ORDER BY [Headquarters] Desc, AddrName, CitySTZip">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="TermPartyID" PropertyName="Text"
                                                            Type="Int32" />
                                                        <asp:ControlParameter ControlID="MovedOutCheckbox" Name="MovedOut" PropertyName="Checked"
                                                            Type="Boolean" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                                <asp:TextBox ID="HiddenTB_PartyID" runat="server" Style="display: none"></asp:TextBox>
                                                <asp:TextBox ID="HiddenTB_AddrID" runat="server" Style="display: none" Text="0"></asp:TextBox>
                                            </td>
                                            <td>
                                            </td>
                                            <td>
                                                <telerik:RadGrid ID="PeopleRadGrid" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                                                    CellSpacing="0" DataSourceID="PeopleDS" OnItemDataBound="PeopleRadGrid_ItemDataBound"
                                                    CssClass="RemoveBorders" GridLines="None" ShowHeader="False" PageSize="10" Width="400px">
                                                    <ClientSettings EnableRowHoverStyle="True">
                                                        <Selecting AllowRowSelect="true" />
                                                        <Scrolling AllowScroll="true" ScrollHeight="325px" UseStaticHeaders="true" />
                                                    </ClientSettings>
                                                    <MasterTableView DataKeyNames="PartyID, ParentID" ClientDataKeyNames="PartyID" DataSourceID="PeopleDS">
                                                        <Columns>
                                                            <telerik:GridBinaryImageColumn DataField="FromPic" UniqueName="FromPic" ImageHeight="35"
                                                                ImageWidth="35" ResizeMode="Fit">
                                                            </telerik:GridBinaryImageColumn>
                                                            <telerik:GridHTMLEditorColumn DataField="PersonHTML" UniqueName="PersonHTML">
                                                                <HeaderStyle Width="168" />
                                                            </telerik:GridHTMLEditorColumn>
                                                            <telerik:GridHTMLEditorColumn DataField="RolesHTML" UniqueName="RolesHTML">
                                                            </telerik:GridHTMLEditorColumn>
                                                            <telerik:GridBoundColumn DataField="EditImage" UniqueName="EditImage" Visible="False">
                                                            </telerik:GridBoundColumn>
                                                            <telerik:GridButtonColumn ButtonType="ImageButton" UniqueName="EditButton">
                                                            </telerik:GridButtonColumn>
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
                                                        <asp:ControlParameter ControlID="FormerWorkersCheckbox" Name="PeopleInactive" PropertyName="Checked"
                                                            Type="Boolean" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="dfv">
                                                <asp:CheckBox ID="MovedOutCheckbox" runat="server" Text="Show Old Offices" AutoPostBack="True">
                                                </asp:CheckBox>
                                            </td>
                                            <td>
                                            </td>
                                            <td class="dfv">
                                                <asp:CheckBox ID="FormerWorkersCheckbox" runat="server" Text="Show Old Workers" AutoPostBack="True">
                                                </asp:CheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                </center>
                            </telerik:RadPageView>
                        </telerik:RadMultiPage>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        <center>
                            <FASTPORT:ThemeButton runat="server" ID="BackButton" Button-CausesValidation="False"
                                Button-CommandName="Redirect" Button-TabIndex="12" Button-Text="&lt;&lt;&lt; Back"
                                Button-ToolTip="Click to go back.">
                            </FASTPORT:ThemeButton>
                        </center>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();"
        onmouseover="clearTimeout(gPopupTimer);">
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="false"
        runat="server"></asp:ValidationSummary>
</asp:Content>
