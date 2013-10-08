<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="Truckers.aspx.vb" Inherits=".Truckers" %>

<%@ Register TagPrefix="FASTPORT" TagName="Menu" Src="../Menu Panels/Menu.ascx" %>
<%@ Register TagPrefix="FASTPORT" TagName="Header" Src="../Header and Footer/Header.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FASTPORT > Truckers</title>
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

            function addTrucker() {

                OpenRadWindow("../Driver/AddDriverAdmin.aspx")

            }

            function onGridCreated(sender, args) {
                
                var windowheight = $(window).height();
                var gridheight = windowheight - 200;
                $("#TruckersRadGrid_GridData").css("height", gridheight);

            }
        
			function refreshGrid(sender, args) {
	
				$find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("refreshGrid");
	
			}			
		
			function flipSRC(mybuttonname, mySRC) {
			
				var mybutton = document.getElementById(mybuttonname);
				mybutton.src = mySRC;
			
			}
			
			function clickToDo(myaction,myid) {
	
				SendCallBack("OpenRadWindowDialogue", myaction + "," + myid);
	
			}
					
			function openHelpVideo() {
	
				SendCallBack("OpenRadWindowDialogue", "openHelpVideo");
	
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
		
    		function SendCallBack(myAction, arg) {
                try { 
                    switch (myAction) {
                        case "OpenRadWindowDialogue":
                            {
                            <%=Page.ClientScript.GetCallbackEventReference(Me, "arg", "OpenRadWindowDialogue", "null") %>
                            break;
                            }
                        case "OpenprofileRadWindow":
                            {
                            <%=Page.ClientScript.GetCallbackEventReference(Me, "arg", "OpenprofileRadWindow", "null") %>
                            break;
                            }
                        case "ToFinish":
                            {
                            <%=Page.ClientScript.GetCallbackEventReference(Me, "arg", "Finish", "null") %>
                            break;
                            }
                    }
                }
                catch (e) {
                }
            }


            function Finish(arg) {
                
				/*only here to finish out call back*/
                
                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest(arg); 

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
				
			function OpenprofileRadWindow(myURL) {
				
				var oWnd = $find("<%=profileRadWindow.ClientID%>")
				oWnd.setUrl(myURL);
				oWnd.show();
			
			}

        </script>
    </telerik:RadScriptBlock>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadAjaxManager1" />
                    <telerik:AjaxUpdatedControl ControlID="TruckersRadGrid" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True" MinHeight="350px"
        MinWidth="550px" Modal="True" ShowContentDuringLoad="False" VisibleStatusbar="False"
        Skin="BlackMetroTouch">
        <Windows>
            <telerik:RadWindow ID="RadWindow1" runat="server" Modal="true">
            </telerik:RadWindow>
            <telerik:RadWindow ID="RadWindowDialogue" runat="server" MinHeight="125px" Modal="True"
                MinWidth="400" ShowContentDuringLoad="False" Style="display: none;" VisibleStatusbar="False"
                VisibleTitlebar="False">
            </telerik:RadWindow>
            <telerik:RadWindow ID="profileRadWindow" runat="server" MinHeight="710px" Modal="True"
                MinWidth="860" ShowContentDuringLoad="False" Style="display: none;" VisibleStatusbar="False"
                VisibleTitlebar="False">
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
    <div>
        <table width="100%" class="pcmL">
            <tr>
                <td width="155px" align="Right" style="padding-left: 20px;">
                    <asp:Image ID="LogoImage" runat="server" ImageUrl="../Images/Custom/FPWhiteLogo.png">
                    </asp:Image>
                </td>
                <td>
                    <FASTPORT:Menu runat="server" ID="_Menu"></FASTPORT:Menu>
                </td>
                <td width="100%" align="Right">
                    <FASTPORT:Header runat="server" ID="_PageHeader"></FASTPORT:Header>
                </td>
            </tr>
        </table>
        <br />
        <telerik:RadButton ID="TruckerAddRB" runat="server" Text="Add a New Trucker" ToolTip="Click to get started with a new trucker."
            AutoPostBack="false" OnClientClicked="addTrucker">
        </telerik:RadButton>
        <br />
        <br />
        <telerik:RadComboBox ID="CarrierRCB" runat="server" DataSourceID="CarriersDS" DataTextField="Carrier"
            DataValueField="PartyID" EmptyMessage="Filter by Carrier" MarkFirstMatch="True"
            Width="150px" ShowToggleImage="True" OnClientSelectedIndexChanged="refreshGrid"
            HighlightTemplatedItems="True" Filter="Contains">
        </telerik:RadComboBox>
        <asp:SqlDataSource ID="CarriersDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
            SelectCommand="usp_CarriersMine" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="CarrierChildID" SessionField="PartyID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <telerik:RadComboBox ID="InProgressRCB" runat="server" Width="150px" EmptyMessage="Filter by In Progress"
            OnClientSelectedIndexChanged="refreshGrid">
            <Items>
                <telerik:RadComboBoxItem runat="server" Text="In Progress" Value="1" />
                <telerik:RadComboBoxItem runat="server" Text="Completed" Value="2" />
                <telerik:RadComboBoxItem runat="server" Text="All" Value="0" />
            </Items>
        </telerik:RadComboBox>
        <br />
        <br />
        <telerik:RadGrid ID="TruckersRadGrid" runat="server" DataSourceID="TruckersDS" ShowHeader="True"
            OnItemDataBound="TruckersRadGrid_ItemDataBound" AllowFilteringByColumn="False"
            AllowPaging="False" AllowSorting="False" ShowGroupPanel="False" CssClass="RemoveBorders">
            <GroupingSettings CaseSensitive="false" />
            <ClientSettings EnableRowHoverStyle="True" AllowDragToGroup="False">
                <Selecting AllowRowSelect="true" />
                <Scrolling AllowScroll="true" SaveScrollPosition="true" />
                <ClientEvents OnGridCreated="onGridCreated" />
            </ClientSettings>
            <MasterTableView AutoGenerateColumns="False" DataSourceID="TruckersDS" DataKeyNames="AdActivityID, PartyID, FlowStepID"
                ClientDataKeyNames="AdActivityID">
                <NoRecordsTemplate>
                    <div>
                    </div>
                </NoRecordsTemplate>
                <Columns>
                    <telerik:GridBinaryImageColumn DataField="Gauge" UniqueName="Gauge" ImageHeight="75"
                        ImageWidth="47" ResizeMode="Fit" AllowFiltering="False" AllowSorting="False"
                        Groupable="False">
                    </telerik:GridBinaryImageColumn>
                    <telerik:GridBinaryImageColumn DataField="FromPic" UniqueName="FromPic" ImageHeight="60"
                        ImageWidth="60" ResizeMode="Fit" AllowFiltering="False" AllowSorting="False"
                        Groupable="False">
                    </telerik:GridBinaryImageColumn>
                    <telerik:GridBoundColumn DataField="NameHTML" UniqueName="NameHTML" HeaderText="Trucker"
                        AutoPostBackOnFilter="true" CurrentFilterFunction="Contains" ShowFilterIcon="false"
                        Groupable="False">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="Overview" UniqueName="Overview" HeaderText="Stage"
                        AutoPostBackOnFilter="true" CurrentFilterFunction="Contains" ShowFilterIcon="false">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="Timing" UniqueName="Timing" HeaderText="Timing"
                        AutoPostBackOnFilter="true" CurrentFilterFunction="Contains" ShowFilterIcon="false"
                        Groupable="False">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="Verification" UniqueName="Verification" HeaderText="Verification"
                        AutoPostBackOnFilter="true" CurrentFilterFunction="Contains" ShowFilterIcon="false">
                    </telerik:GridBoundColumn>
                    <telerik:GridButtonColumn ButtonType="ImageButton" UniqueName="EditButton">
                    </telerik:GridButtonColumn>
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
        <asp:SqlDataSource ID="TruckersDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
            SelectCommand="usp_TruckersManage" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="PartyID" SessionField="PartyID" Type="Int32" />
                <asp:ControlParameter ControlID="CarrierRCB" Name="CarrierID" PropertyName="SelectedValue"
                    Type="Int32" DefaultValue="0" />
                <asp:ControlParameter ControlID="InProgressRCB" Name="InProgress" PropertyName="SelectedValue"
                    Type="Int32" DefaultValue="1" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
