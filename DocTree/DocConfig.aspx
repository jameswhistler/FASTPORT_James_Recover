<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="DocConfig.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="FASTPORT.UI.DocConfig" %>

<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<asp:Content ID="PageSection" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="DocConfigRTV" />
                    <telerik:AjaxUpdatedControl ControlID="SearchDocsRCB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="DocConfigRTV">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="DocConfigRTV" />
                    <telerik:AjaxUpdatedControl ControlID="SearchDocsRCB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <style type="text/css">
        body
        {
            height: 100%;
            margin: 0;
            padding: 0;
            overflow: auto;
        }
        
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
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type="text/javascript">


            function onDocTreeNodeClicked(sender, eventArgs) {

                var node = eventArgs.get_node();
				node.toggle();

			}

			function ParentCloseAndRedirect(arg)
			{
				if (!arg)
				{
					$find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Close");
				}
				else
				{
					$find("<%= RadAjaxManager1.ClientID %>").ajaxRequest(arg);
				}
			}

            function OnContextClick(sender, args) {
                var selectedItem = args.get_node().get_value();
                var selectedMenuOption = args.get_menuItem();
                
                switch (selectedMenuOption.get_text()) {
                    case "NEW Folder . . .":
                        {
                            SendCallBack("addFolder," + selectedItem, "OpenRadWindowDialogue")
                            break;
                        }
                    case "INSIDE This Level":
                        {
                            SendCallBack("addFolder," + selectedItem, "OpenRadWindowDialogue")
                            break;
                        }
                    case "AT This Level":
                        {
                            SendCallBack("addFolderParent," + selectedItem, "OpenRadWindowDialogue")
                            break;
                        }
                    case "NEW Document":
                        {
                            SendCallBack("newDoc," + selectedItem, "OpenRadWindowDialogue")
                            break;
                        }
                    case "NEW SIGNABLE Document":
                        {
                            SendCallBack("newSignableDoc," + selectedItem, "OpenRadWindowDialogue")
                            break;
                        }
                    case "EDIT Folder":
                        {
                            SendCallBack("editFolder," + selectedItem, "OpenRadWindowDialogue")
                            break;
                        }
                    case "DELETE Folder":
                        {
                            confirmCall("deleteFolder", selectedItem, "Folder")
                            break;
                        }
                    case "COPY This Doc":
                        {
                            confirmCall("copyDoc",selectedItem,"Document")
                            break;
                        }
                    case "VIEW":
                        {
                            SendCallBack("viewDoc," + selectedItem, "OpenRadWindowDialogue")
                            break;
                        }
                    case "EDIT":
                        {
                            SendCallBack("editDoc," + selectedItem, "OpenRadWindowDialogue")
                            break;
                        }
                    case "DELETE":
                        {
                            confirmCall("deleteAll",selectedItem,"Document")
                            break;
                        }
                    case "CUSTOMIZE This Standard Doc":
                        {
                            confirmCall("customizeDoc",selectedItem,"Document")
                            break;
                        }
                    case "REVERT to Standard Doc":
                        {
                            confirmCall("revertDoc",selectedItem,"Document")
                            break;
                        }
                }
            }

            function SendCallBack(arg,myRadWin) {
                try { 
                    switch (myRadWin) {
                        case "OpenRadWindow":
                            {
                            <%=Page.ClientScript.GetCallbackEventReference(Me, "arg", "OpenRadWindow", "null") %>
                            break;
                            }
                        case "OpenRadWindowDialogue":
                            {
                            <%=Page.ClientScript.GetCallbackEventReference(Me, "arg", "OpenRadWindowDialogue", "null") %>
                            break;
                            }
                    }
                }
                catch (e) {
                }
            }

            
            //**********************
            //Rad alert functions
            //**********************

            //Info: global variables.  confirmType tells what you are doing like 'deleteExp'  confirmID holds the record that you are going to manipulate.
            var confirmType;
            var confirmID;

            //Step 1:  Call this funtion from JS.
            function confirmCall(callType, callID, callName)
            {
                confirmType = callType;
                confirmID = callID;
                var confirmMess;
                var confirmTitle;

                
                //Step 2:  Configure your messsage types here.

                
                if (callType=="deleteFolder") {

                    confirmMess = "Are you sure that you want to <span style='color: #ff0000;'><em>permanently</em></span> DELETE this folder and <span style='color: #ff0000;'><em>everything</em></span> inside it?";
                    confirmTitle = "DELETE " & callName & " ?"
                    launchRadConfirm(confirmMess, confirmTitle);

                }

                if (callType=="copyDoc") {

                    confirmMess = "Are you sure that you want to COPY this document?";
                    confirmTitle = "COPY " & callName & " ?"
                    launchRadConfirm(confirmMess, confirmTitle);

                }
                
                if (callType=="deleteAll") {

                    confirmMess = "Are you sure that you want to <span style='color: #ff0000;'><em>permanently</em></span> DELETE this document?";
                    confirmTitle = "DELETE " & callName & " ?"
                    launchRadConfirm(confirmMess, confirmTitle);

                }
                
                if (callType=="customizeDoc") {

                    confirmMess = "Are you sure that you want to CUSTOMIZE this standard document?";
                    confirmTitle = "CUSTOMIZE Standard " & callName & " ?"
                    launchRadConfirm(confirmMess, confirmTitle);

                }

                if (callType=="revertDoc") {

                    confirmMess = "Are you sure that you want to <span style='color: #ff0000;'><em>permanently</em></span> delete your customizations and REVERT back to the standard document?";
                    confirmTitle = "REVERT Back to Standard " & callName & " ?"
                    launchRadConfirm(confirmMess, confirmTitle);

                }
            }

            //Info:  Needed to get the parent window when calling alerts from a child RadWindow.
            function GetRadWindow()
            {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow;
                else if (window.frameElement && window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
                return oWindow;
            }


            //Info:  Function to launch the RadConfirm.
            function launchRadConfirm(confirmMess, confirmTitle) {

                var oWnd = GetRadWindow();
                if (oWnd != null)
                {
                    setTimeout(function ()
                    {
                        GetRadWindow().BrowserWindow.radconfirm(confirmMess,confirmCallBackFn,400,115,null,confirmTitle,"/Images/Custom/DeleteLowRes.png");
                    }, 0);
                }
                //Info: Used to launch from a parent page.
                else
                {
                    radconfirm(confirmMess,confirmCallBackFn,400,115,null,confirmTitle,"/Images/Custom/DeleteLowRes.png");
                }

            }
            
            //Info:  Function that the RadConfirm calls back to process the users response.
            function confirmCallBackFn(arg) {

                //Step 3:  Config different callbacks if required.  If you have only 2 parameters, these will do.
                if (arg==true) {

                    var sendArg = confirmType + "," + confirmID;
                    <%=Page.ClientScript.GetCallbackEventReference(Me, "sendArg", "Finish", "null") %>

                }

            }

            //Info
            function launchRadAlert(alertMess,alertTitle) {

                var oWnd = GetRadWindow();
                if (oWnd != null)
                {
                    setTimeout(function ()
                    {
                        GetRadWindow().BrowserWindow.radalert(alertMess,400,115,alertTitle,null,"/Images/Custom/OkayLowRes.png");
                    }, 0);
                }
                //Info: Used to launch from a parent page.
                else
                {
                    radalert(alertMess,400,115,alertTitle,null,"/Images/Custom/OkayLowRes.png");
                }

            }
				
            
            function Finish(arg) {
                
                //Step 5:  Launch alert if there is a problem with the procedure called by the launchRadConfirm function.
                if (arg != "Nothing") {

                    var messTitle = "FASTPORT Message";

                    
                    if (confirmType=="deleteFolder"||confirmType=="hideDoc") {
                        messTitle = "WARNING: Delete Failed"
                    }

                    if (confirmType=="copyDoc") {
                        messTitle = "WARNING: Failed to Copy Document"
                    }
                    
                    if (confirmType=="deleteAll") {
                        messTitle = "WARNING: Delete Failed"
                    }

                    if (confirmType=="customizeDoc") {
                        messTitle = "WARNING: Customization Failed";
                    }

                    if (confirmType=="revertDoc") {
                        messTitle = "WARNING: Failed to Revert Document";
                    }

                    launchRadAlert(arg,messTitle);

                }
                
				$find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("RebindDocConfig");

            }

            //**********************
            //END:  Rad alert functions
            //**********************

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
            		
			function refreshTree()
			{
				$find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("RebindDocConfig");
			}
			
            function searchTree(sender, args) {

                var item = args.get_item();
                var id = item.get_value();
                
                var sendArg = "searchTree," + id;
                <%=Page.ClientScript.GetCallbackEventReference(Me, "sendArg", "searchFinish", "null") %>

			}

            function searchFinish(args) {

                refreshTree();

            }

		    function onComboKeyPressing(sender, args) {
			    if (!sender.get_dropDownVisible())
				    sender.showDropDown();
		    }
					
        </script>
    </telerik:RadCodeBlock>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True" Modal="True"
        ShowContentDuringLoad="False" VisibleStatusbar="False" Behaviors="Close,Move,Resize" Skin="BlackMetroTouch">
        <Windows>
            <telerik:RadWindow ID="RadWindow1" runat="server" Left="150px" Modal="true">
            </telerik:RadWindow>
            <telerik:RadWindow ID="RadWindowDialogue" runat="server" OnClientClose="refreshTree"
                MinHeight="75px" Modal="True" MinWidth="450" ShowContentDuringLoad="False" VisibleStatusbar="False"
                VisibleTitlebar="True">
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
    <table cellpadding="0" cellspacing="0" border="0" style="background: white; width: 100%;
        height: 100%;">
        <tr>
            <td>
                <center>
                    <table>
                        <tr>
                            <td style="vertical-align: top;">
                                &nbsp;
                            </td>
                            <td style="vertical-align: top;">
                            </td>
                            <td style="vertical-align: top;">
                            </td>
                        </tr>
                        <tr>
                            <td style="vertical-align: top;">
                            </td>
                            <td class="header_cust" style="width: 500px" colspan="2">
                                <asp:Label runat="server" ID="CustomizedLbl" Text="Customize Documents">	</asp:Label>
                            </td>
                        </tr>
                        <tr id="InstructionsRow" runat="Server">
                            <td style="vertical-align: top;">
                            </td>
                            <td style="text-align: left; vertical-align: top; width: 500px;" class="dfv">
                                <br />
                                <asp:Literal runat="server" ID="InstructionsStandard" Text="918">	</asp:Literal>
                                <br />
                                <br />
                            </td>
                            <td style="vertical-align: top;">
                                <br />
                                <telerik:RadComboBox ID="PartiesRCB" runat="server" DataSourceID="PartiesDS" DataTextField="PartyName"
                                    DataValueField="PartyID" MarkFirstMatch="True" Width="175px" ShowToggleImage="True"
                                    HighlightTemplatedItems="True" Filter="Contains" OnClientSelectedIndexChanged="refreshTree"
                                    OnClientKeyPressing="onComboKeyPressing">
                                    <ItemTemplate>
                                        <%# DataBinder.Eval(Container.DataItem, "PartyHTML")%>
                                    </ItemTemplate>
                                </telerik:RadComboBox>
                                <asp:SqlDataSource ID="PartiesDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                    SelectCommand="usp_PartiesMine" SelectCommandType="StoredProcedure">
                                    <SelectParameters>
                                        <asp:SessionParameter Name="ChildID" SessionField="PartyID" Type="Int32" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                                <br />
                                <telerik:RadComboBox ID="GeneralRolesRCB" runat="server" DataSourceID="GeneralRolesDS"
                                    DataTextField="Role" DataValueField="RoleID" MarkFirstMatch="True" Width="175px"
                                    ShowToggleImage="True" HighlightTemplatedItems="True" Filter="Contains" OnClientSelectedIndexChanged="refreshTree"
                                    OnClientKeyPressing="onComboKeyPressing">
                                </telerik:RadComboBox>
                                <asp:SqlDataSource ID="GeneralRolesDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                    SelectCommand="SELECT * FROM dbo.v_RolesGeneral"></asp:SqlDataSource>
                                <br />
                                <telerik:RadComboBox ID="SearchDocsRCB" runat="server" DataSourceID="DocConfigDS"
                                    DataTextField="DocName" DataValueField="DocTreeID" AllowCustomText="True" MarkFirstMatch="True"
                                    Width="175px" ShowToggleImage="True" HighlightTemplatedItems="True" Filter="Contains"
                                    OnClientSelectedIndexChanged="searchTree" OnClientKeyPressing="onComboKeyPressing">
                                </telerik:RadComboBox>
                                <br />
                                <telerik:RadTreeView ID="DocConfigRTV" runat="server" DataFieldID="DocTreeID" DataFieldParentID="DocTreeParentID"
                                    DataSourceID="DocConfigDS" DataValueField="DocTreeID" OnClientContextMenuItemClicked="OnContextClick"
                                    OnClientNodeClicked="onDocTreeNodeClicked" EnableDragAndDrop="true" EnableDragAndDropBetweenNodes="True"
                                    OnNodeDrop="DocConfigRTV_NodeDrop" OnNodeDataBound="DocConfigRTV_NodeDataBound"
                                    Skin="MetroTouch">
                                    <ContextMenus>
                                        <telerik:RadTreeViewContextMenu ID="FolderRCM" runat="server">
                                            <Items>
                                                <telerik:RadMenuItem runat="server" Text="NEW Folder . . .">
                                                    <Items>
                                                        <telerik:RadMenuItem runat="server" Text="INSIDE This Level">
                                                        </telerik:RadMenuItem>
                                                        <telerik:RadMenuItem runat="server" Text="AT This Level">
                                                        </telerik:RadMenuItem>
                                                    </Items>
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" IsSeparator="True" Text="|" />
                                                <telerik:RadMenuItem runat="server" Text="NEW Document">
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" Text="NEW SIGNABLE Document">
                                                </telerik:RadMenuItem>
                                            </Items>
                                        </telerik:RadTreeViewContextMenu>
                                        <telerik:RadTreeViewContextMenu ID="FolderCIXRCM" runat="server">
                                            <Items>
                                                <telerik:RadMenuItem runat="server" Text="NEW Folder . . .">
                                                    <Items>
                                                        <telerik:RadMenuItem runat="server" Text="INSIDE This Level">
                                                        </telerik:RadMenuItem>
                                                        <telerik:RadMenuItem runat="server" Text="AT This Level">
                                                        </telerik:RadMenuItem>
                                                    </Items>
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" Text="NEW Document">
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" Text="NEW SIGNABLE Document">
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" IsSeparator="True" Text="|" />
                                                <telerik:RadMenuItem runat="server" Text="EDIT Folder">
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" Text="DELETE Folder">
                                                </telerik:RadMenuItem>
                                            </Items>
                                        </telerik:RadTreeViewContextMenu>
                                        <telerik:RadTreeViewContextMenu ID="DocRCM" runat="server">
                                            <Items>
                                                <telerik:RadMenuItem runat="server" Text="COPY This Doc">
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" Text="VIEW">
                                                </telerik:RadMenuItem>
                                            </Items>
                                        </telerik:RadTreeViewContextMenu>
                                        <telerik:RadTreeViewContextMenu ID="DocCIXRCM" runat="server">
                                            <Items>
                                                <telerik:RadMenuItem runat="server" Text="COPY This Doc">
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" Text="VIEW">
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" Text="EDIT">
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" Text="DELETE">
                                                </telerik:RadMenuItem>
                                            </Items>
                                        </telerik:RadTreeViewContextMenu>
                                        <telerik:RadTreeViewContextMenu ID="DocAgreeRCM" runat="server">
                                            <Items>
                                                <telerik:RadMenuItem runat="server" Text="CUSTOMIZE This Standard Doc">
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" Text="COPY This Doc">
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" Text="VIEW">
                                                </telerik:RadMenuItem>
                                            </Items>
                                        </telerik:RadTreeViewContextMenu>
                                        <telerik:RadTreeViewContextMenu ID="DocAgreeCIXRCM_Revert" runat="server">
                                            <Items>
                                                <telerik:RadMenuItem runat="server" Text="REVERT to Standard Doc">
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" Text="COPY This Doc">
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" IsSeparator="True" Text="|" />
                                                <telerik:RadMenuItem runat="server" Text="VIEW">
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" Text="EDIT">
                                                </telerik:RadMenuItem>
                                                <telerik:RadMenuItem runat="server" Text="DELETE">
                                                </telerik:RadMenuItem>
                                            </Items>
                                        </telerik:RadTreeViewContextMenu>
                                    </ContextMenus>
                                    <NodeTemplate>
                                        <%# Eval("DocConfigHTML") %>
                                    </NodeTemplate>
                                </telerik:RadTreeView>
                                <asp:SqlDataSource ID="DocConfigDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                    SelectCommand="usp_DocConfig" SelectCommandType="StoredProcedure">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="PartiesRCB" PropertyName="SelectedValue" Type="String"
                                            Name="DocConfig_CIX" />
                                        <asp:ControlParameter ControlID="GeneralRolesRCB" PropertyName="SelectedValue" Type="String"
                                            Name="DocConfig_GeneralRoleID" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                        </tr>
                    </table>
                </center>
            </td>
        </tr>
    </table>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();"
        onmouseover="clearTimeout(gPopupTimer);">
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="false"
        runat="server"></asp:ValidationSummary>
</asp:Content>
