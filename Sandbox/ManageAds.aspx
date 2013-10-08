<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="ManageAds.aspx.vb" Inherits=".TelerikWebForm1" %>
<%@ Register TagPrefix="FASTPORT" TagName="Menu" Src="../Menu Panels/Menu.ascx" %>
<%@ Register TagPrefix="FASTPORT" TagName="Header" Src="../Header and Footer/Header.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<style>
    table
    {
        border-spacing: 0px;
    }
</style>
<head runat="server">
    <title></title>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server" />
</head>
<body>
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
        </Scripts>
    </telerik:RadScriptManager>
    <telerik:RadScriptBlock ID="RadScriptBlock1" runat="server">
        <style>
            body 
            {
                overflow: auto
            }
        </style>
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
            
            function onPartiesRCBIndexChanged(sender, args) {
            
                var partyid = args.get_item().get_value();
                document.getElementById("<%= HiddenTB_PartyID.ClientID %>").value = partyid;
                rebindCarrierAdsRG();

            }

            function rebindCarrierAdsRG() {

                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("RebindJobs");

            }

            function onGridRowSelected(sender, eventArgs) {

                var AdID = eventArgs.getDataKeyValue("AdID");
                document.getElementById("HiddenTB_AdID").value = AdID;
                var PartyID = eventArgs.getDataKeyValue("PartyID");
                SendCallBack("OpenRadWindowDialogue," + AdID + "," + PartyID, "OpenRadWindowDialogue");

            }

            function OpenRadWindowDialogue(myURL) {

                var oWnd = $find("<%=RadWindowDialogue.ClientID%>")
                oWnd.setUrl(myURL);
                oWnd.show();

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

            //SendCallBack function

            function SendCallBack(arg, myAction) {

                try {
                    switch (myAction) {
                    case "OpenRadWindowDialogue":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "OpenRadWindowDialogue", "null") %>
                            break;
                        }
                    case "CarrierAddEdit":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onCarrierSearchButtonCommand_back", "null") %>
                            break;
                        }
                    case "onPostingAddRBClicked":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onPostingAddRBClicked_back", "null") %>
                            break;
                        }
                    }
                } catch (e) {}
            }

            
            function onCarrierSearch(sender, eventArgs) {

                var searchid = eventArgs.get_value();

                if (searchid == null || searchid == "") {
                    searchid = "0"
                }

                document.getElementById("<%= HiddenTB_PartyID.ClientID %>").value = searchid;
                
                rebindCarrierAdsRG();

            }
            
            function onCarrierSearchButtonCommand(sender, args) {
                
                var searchid = document.getElementById("<%= HiddenTB_PartyID.ClientID %>").value;
                var commandname = args.get_commandName();

                SendCallBack(commandname + "," + searchid, "CarrierAddEdit");

            }
            
            function onCarrierSearchButtonCommand_back(args) {
                
                OpenRadWindowDialogue(args);

            }
            
//            function onRWLoaded(oWnd, type, height, width, title) {

//                height = Number(document.getElementById("HiddenTB_WindowHeight").value);
//                width = Number(document.getElementById("HiddenTB_WindowWidth").value);
//                height = height * .96;
//                width = width * .96;
//                
//                oWnd.set_height(height);
//                oWnd.set_width(width);
//                oWnd.set_title(title);
//                oWnd.center();

//            }

            function onPostingAddRBClicked() {
            
                //hard code, protected agains invalid carrier ids.

                var searchid = document.getElementById("<%= HiddenTB_PartyID.ClientID %>").value;

                if (searchid != "0" && searchid != "") {
                    SendCallBack("onPostingAddRBClicked," + searchid, "CarrierAddEdit");
                } else {
                    alert("Please select a carrier before continuing.")
                }
            }

            function onPostingAddRBClicked_back(arg) {

                OpenRadWindowDialogue(args);
                
            }

        </script>
    </telerik:RadScriptBlock>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="CarrierAdsRG" LoadingPanelID="LoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="LoadingPanel1" runat="server" Skin="BlackMetroTouch">
    </telerik:RadAjaxLoadingPanel>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Modal="True" ShowContentDuringLoad="False"
        Behaviors="Close,Move,Resize" VisibleStatusbar="False" Skin="BlackMetroTouch" >
        <Windows>
            <telerik:RadWindow ID="RadWindowDialogue" runat="server" Modal="True"
                VisibleTitlebar="True" AutoSize="false" Width="1000px" Height="685px">
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
        <table width="100%">
            <tr style="float: left">
                <td>
                    <telerik:RadComboBox ID="PartiesRCB" runat="server" DataSourceID="PartiesDS" DataTextField="PartyName"
                        DataValueField="PartyID" MarkFirstMatch="True" Width="175px" ShowToggleImage="True"
                        HighlightTemplatedItems="True" Filter="Contains" OnClientSelectedIndexChanged="onPartiesRCBIndexChanged">
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "PartyHTML")%>
                        </ItemTemplate>
                    </telerik:RadComboBox>
                    <asp:SqlDataSource ID="PartiesDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                        SelectCommand="usp_PartiesMine" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:SessionParameter Name="ChildID" SessionField="PartyID" Type="Int32" />
                            <asp:Parameter Name="ChildIDAlt" DefaultValue="1" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <telerik:RadSearchBox runat="server" ID="PickCarrierRSB" DataSourceID="CarrierRSB_DS"
                        DataValueField="PartyID" DataTextField="CarrierFullName" EmptyMessage="Part of Name, MC, or DOT"
                        Width="275px" MaxResultCount="15" MinFilterLength="3" DropDownSettings-Height="240"
                        OnClientSearch="onCarrierSearch" OnClientButtonCommand="onCarrierSearchButtonCommand" Skin="Metro" TabIndex="5">
                        <Buttons>
                            <telerik:SearchBoxButton ImageUrl="../Images/Custom/icon_new.png" CommandName="CarrierAdd"
                                CommandArgument="CarrierAdd" Position="Left" AlternateText="Add New Carrier" />
                            <telerik:SearchBoxButton ImageUrl="../Images/Custom/icon_edit.gif" CommandName="CarrierEdit"
                                CommandArgument="CarrierEdit" Position="Left" AlternateText="Edit Carrier" />
                        </Buttons>
                        <DropDownSettings Width="300" />
                    </telerik:RadSearchBox>
                    <asp:SqlDataSource ID="CarrierRSB_DS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                        SelectCommand="SELECT [PartyID], [CarrierFullName] FROM [v_CarrierSuperShort]">
                    </asp:SqlDataSource>
                </td>
                <td>
                    <telerik:RadButton ID="PostingAddRB" runat="server" Text="Add New Job Posting" ToolTip="Click here to add a new job posting."
                        AutoPostBack="false" OnClientClicked="onPostingAddRBClicked">
                    </telerik:RadButton>
                </td>
                <td>
                    &nbsp;
                </td>
                <td style="text-align: right;">
                    <telerik:RadComboBox ID="HiddenRCB" runat="server" Width="50px" OnClientSelectedIndexChanged="rebindCarrierAdsRG">
                        <Items>
                            <telerik:RadComboBoxItem runat="server" Text="No" Value="0" />
                            <telerik:RadComboBoxItem runat="server" Text="Yes" Value="1" />
                        </Items>
                    </telerik:RadComboBox>
                </td>
            </tr>
        </table>
        <telerik:RadGrid ID="CarrierAdsRG" runat="server" DataSourceID="CarrierAdsDS" ShowHeader="True"
            Skin="Silk" GridLines="None">
            <ClientSettings Selecting-AllowRowSelect="true">
                <ClientEvents OnRowSelected="onGridRowSelected" />
            </ClientSettings>
            <MasterTableView AutoGenerateColumns="False" DataSourceID="CarrierAdsDS" DataKeyNames="AdID, PartyID"
                ClientDataKeyNames="AdID, PartyID">
                <NoRecordsTemplate>
                    <div>
                        <div style="padding: 75px 100px;">
                            <div style="text-align: center;">
                                <span style="font-size: 20px; color: #f79646;"><strong>YOUR JOB POSTINGS</strong></span></div>
                            <br />
                            After you have created your carriers above, please click the "New Job" button to
                            create your job posting.</div>
                    </div>
                </NoRecordsTemplate>
                <Columns>
                    <telerik:GridBoundColumn DataField="AdID" Visible="False" UniqueName="AdID">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="PartyID" Visible="False" UniqueName="PartyID">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="PreCarrierHTML" UniqueName="PreCarrierHTML">
                        <HeaderStyle Width="75px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="AdHTML" UniqueName="AdHTML" HeaderText="Advertisement">
                        <HeaderStyle Width="150px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="CarrierHTML" UniqueName="CarrierHTML" HeaderText="Carrier">
                        <HeaderStyle Width="150px" />
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="FocusesStacked" UniqueName="FocusesStacked" HeaderText="Focuses">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="PayHTML" UniqueName="PayHTML" HeaderText="Payment">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="AdStats" UniqueName="AdStats" HeaderText="Statistics">
                        <HeaderStyle Width="150px" />
                    </telerik:GridBoundColumn>
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
        <asp:SqlDataSource ID="CarrierAdsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
            SelectCommand="usp_AdByCarrier" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="ChildID" SessionField="PartyID" Type="Int32" />
                <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="PartyID" PropertyName="Text"
                    Type="Int32" />
                <asp:ControlParameter ControlID="HiddenRCB" Name="ShowHidden" DefaultValue="0" PropertyName="SelectedValue"
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:TextBox ID="HiddenTB_PartyID" runat="server" Text="0" style="display: none;" >
        </asp:TextBox>
        <asp:TextBox ID="HiddenTB_WindowHeight" runat="server" Text="0" style="display: none;" >
        </asp:TextBox>
        <asp:TextBox ID="HiddenTB_WindowWidth" runat="server" Text="0" style="display: none;" >
        </asp:TextBox>
        <asp:TextBox ID="HiddenTB_AdID" runat="server" Text="0" style="display: none"></asp:TextBox>
    </div>
    </form>
</body>
</html>
