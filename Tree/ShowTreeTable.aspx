<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="ShowTreeTable.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="FASTPORT.UI.ShowTreeTable" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<asp:Content ID="PageSection" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
    </telerik:RadStyleSheetManager>
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <style>
            body 
            {
                overflow: auto
            }
        </style>
        <script type="text/javascript">

			function onComboKeyPressing(sender, args) {
                if (!sender.get_dropDownVisible())
				    sender.showDropDown();
			}

            function OnContextClick(sender, args) {
                var selectedItem = args.get_node().get_value();
                var selectedText = args.get_node().get_text();
                var selectedMenuOption = args.get_menuItem();
                switch (selectedMenuOption.get_text()) {
                    case "INSIDE This Level":
                        {
                            //Paul -- Step 2:  Callback function triggered.
                            SendCallBack("01-" + selectedItem, "OpenRadWindow")
                            break;
                        }
                    case "EDIT This Item":
                        {
                            //Paul -- Step 2:  Callback function triggered.
                            SendCallBack("02-" + selectedItem, "OpenRadWindow")
                            break;
                        }
                    case "EDIT Item IMAGE":
                        {
                            //Paul -- Step 2:  Callback function triggered.
                            SendCallBack("02b" + selectedItem, "OpenRadWindowDialogue")
                            break;
                        }
                    case "DELETE This Item":
                        {
                            //Paul -- Step 2:  Callback function triggered.
                            SendCallBack("03-" + selectedItem, "OpenRadWindowDialogue")
                            break;
                        }
                    case "AT This Level":
                        {
                            //Paul -- Step 2:  Callback function triggered.
                            SendCallBack("04-" + selectedItem, "OpenRadWindow")
                            break;
                        }
                    case "PRUNE This Branch":
                        {
                            //Paul -- Step 2:  Callback function triggered.
                            SendCallBack("05-" + selectedItem, "OpenRadWindowDialogue")
                            break;
                        }
                }
            }
            function SendCallBack(arg,myRadWin) {
                try { 
                    switch (myRadWin) {
                        case "OpenRadWindow":
                            {
                            //Paul -- Step 3: GetCallbackEventReference thing launched (Go to code behind.).
                            <%=Page.ClientScript.GetCallbackEventReference(Me, "arg", "OpenRadWindow", "null") %>
                            //Paul -- Step 7: After the result is returned from the server, the call back event must go to another funciton (I think.).  In this case, OpenRadWindowAuto.
                            break;
                            }
                        case "OpenRadWindowDialogue":
                            {
                            //Paul -- Step 3: GetCallbackEventReference thing launched (Go to code behind.).
                            <%=Page.ClientScript.GetCallbackEventReference(Me, "arg", "OpenRadWindowDialogue", "null") %>
                            //Paul -- Step 7: After the result is returned from the server, the call back event must go to another funciton (I think.).  In this case, OpenRadWindowAuto.
                            break;
                            }
                    }
                }
                catch (e) {
                }
            }

            function OpenRadWindow(myURL) {
                var oWnd = $find("<%=RadWindow1.ClientID%>")
                oWnd.setUrl(myURL);
                oWnd.show();
            }
			function OpenRadWindowDialogue(myURL) {
                var oWnd = $find("<%=RadWindowDialogue.ClientID%>")
                oWnd.setUrl(myURL);
                oWnd.show();
            }	
			function refreshGrid(arg)
                {
                    if (!arg)
                    {
                        $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Rebind");
                    }
                    else
                    {
                        $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("RebindAndNavigate");
                    }
              	}	
        </script>
    </telerik:RadCodeBlock>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="SearchComboBox" />
                    <telerik:AjaxUpdatedControl ControlID="PruneLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="UnPruneButton" />
                    <telerik:AjaxUpdatedControl ControlID="RadTreeView1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="SearchComboBox">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadTreeView1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="HiddenComboBox">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="SearchComboBox" />
                    <telerik:AjaxUpdatedControl ControlID="RadTreeView1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="AdminOnlyComboBox">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="SearchComboBox" />
                    <telerik:AjaxUpdatedControl ControlID="RadTreeView1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="UnPruneButton">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="SearchComboBox" />
                    <telerik:AjaxUpdatedControl ControlID="PruneLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="UnPruneButton" />
                    <telerik:AjaxUpdatedControl ControlID="RadTreeView1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadTreeView1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadTreeView1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True" MinHeight="350px"
        MinWidth="550px" Modal="True" ShowContentDuringLoad="False" VisibleStatusbar="False" Behaviors="Close,Move,Resize" Skin="BlackMetroTouch">
        <Windows>
            <telerik:RadWindow ID="RadWindow1" runat="server" Modal="true">
            </telerik:RadWindow>
            <telerik:RadWindow ID="RadWindowDialogue" runat="server" MinHeight="100px" Modal="True"
                Width="450" ShowContentDuringLoad="False" VisibleStatusbar="False">
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
    <table cellpadding="0" cellspacing="0" border="0">
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="NoPadding" style="width: 400px">
                <table class="dv" cellpadding="0" cellspacing="0" border="0">
                    <tr>
                        <td class="dh">
                            <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                <tr>
                                    <td class="dhel">
                                        <img src="../Images/space.gif" alt="" />
                                    </td>
                                    <td class="dheci" valign="middle">
                                        <asp:CollapsiblePanelExtender ID="TreeFramePanelExtender" runat="server" TargetControlID="TreeFrameCollapsibleRegion"
                                            ExpandControlID="TreeFrameIcon" CollapseControlID="TreeFrameIcon" ImageControlID="TreeFrameIcon"
                                            ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif"
                                            SuppressPostBack="true" Collapsed="True" />
                                        <asp:ImageButton ID="TreeFrameIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;"
                                            CausesValidation="False" ImageUrl="../images/icon_panelcollapse.gif" />
                                    </td>
                                    <td class="dhb">
                                        <table cellpadding="0" cellspacing="0" border="0">
                                            <tr>
                                                <td class="dht" valign="middle">
                                                    System Lists (Expand to Search)
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="dher">
                                        <img src="../Images/space.gif" alt="" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="TreeFrameCollapsibleRegion" runat="server">
                                <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                    <tr>
                                        <td class="tre">
                                            <table cellpadding="0" cellspacing="0" border="0">
                                                <tr>
                                                    <td style="text-align: right;" class="fls">
                                                        <asp:Label runat="server" ID="SearchLabel" Text="SEARCH">	</asp:Label>
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadComboBox ID="SearchComboBox" runat="server" AllowCustomText="True" DataSourceID="TreeDatasource"
                                                            DataTextField="TreeFull" DataValueField="TreeID" Filter="Contains" Height="150px"
                                                            MarkFirstMatch="True" MaxLength="255" Width="275px" AutoPostBack="True" OnClientKeyPressing="onComboKeyPressing">
                                                        </telerik:RadComboBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: right;" class="fls">
                                                        <asp:Label runat="server" ID="ActiveLabel" Text="SHOW Active?">	</asp:Label>
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadComboBox ID="HiddenComboBox" runat="server" AutoPostBack="True" Width="150px">
                                                            <Items>
                                                                <telerik:RadComboBoxItem runat="server" Text="Active" Value="False" />
                                                                <telerik:RadComboBoxItem runat="server" Text="Hidden" Value="True" />
                                                            </Items>
                                                        </telerik:RadComboBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: right;" class="fls">
                                                        <asp:Label runat="server" ID="AdminLabel" Text="Admin ONLY?">	</asp:Label>
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadComboBox ID="AdminOnlyComboBox" runat="server" AutoPostBack="True" Width="150px">
                                                            <Items>
                                                                <telerik:RadComboBoxItem runat="server" Text="Both" Value="Both" />
                                                                <telerik:RadComboBoxItem runat="server" Text="Admin Only" Value="Admin" />
                                                                <telerik:RadComboBoxItem runat="server" Text="Non-Admin Only" Value="NonAdmin" />
                                                            </Items>
                                                        </telerik:RadComboBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <telerik:RadTreeView ID="RadTreeView1" runat="server" DataFieldID="TreeID" DataFieldParentID="TreeParentID"
                                OnClientContextMenuItemClicked="OnContextClick" EnableDragAndDrop="true" OnNodeDrop="RadTreeView1_NodeDrop"
                                OnNodeExpand="RadTreeView1_NodeExpand" EnableDragAndDropBetweenNodes="False">
                                <ContextMenus>
                                    <telerik:RadTreeViewContextMenu ID="RadTreeViewContextMenu1" runat="server">
                                        <Items>
                                            <telerik:RadMenuItem runat="server" Text="ADD Item . . .">
                                                <Items>
                                                    <telerik:RadMenuItem runat="server" Text="AT This Level">
                                                    </telerik:RadMenuItem>
                                                    <telerik:RadMenuItem runat="server" Text="INSIDE This Level">
                                                    </telerik:RadMenuItem>
                                                </Items>
                                            </telerik:RadMenuItem>
                                            <telerik:RadMenuItem runat="server" Text="EDIT This Item">
                                                <Items>
                                                    <telerik:RadMenuItem runat="server" Text="EDIT Item IMAGE">
                                                    </telerik:RadMenuItem>
                                                </Items>
                                            </telerik:RadMenuItem>
                                            <telerik:RadMenuItem runat="server" Text="DELETE This Item">
                                            </telerik:RadMenuItem>
                                        </Items>
                                    </telerik:RadTreeViewContextMenu>
                                </ContextMenus>
                            </telerik:RadTreeView>
                            <asp:SqlDataSource ID="TreeDatasource" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                SelectCommand="usp_TreeRollUp" SelectCommandType="StoredProcedure">
                                <SelectParameters>
                                    <asp:SessionParameter Name="Prune" SessionField="PruneTreeID" Type="Int32" DefaultValue="0" />
                                    <asp:SessionParameter Name="CIX" SessionField="ParentPartyID" Type="Int32" DefaultValue="0" />
                                    <asp:SessionParameter Name="Hide" SessionField="TreeHidden" Type="Boolean" DefaultValue="False" />
                                    <asp:SessionParameter Name="AdminOnly" SessionField="TreeAdminOnly" Type="String"
                                        DefaultValue="Both" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();"
        onmouseover="clearTimeout(gPopupTimer);">
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="false"
        runat="server"></asp:ValidationSummary>
</asp:Content>
