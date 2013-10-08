<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="SignDocument.aspx.vb"
    Inherits=".Sign" %>

<%@ Register TagPrefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
<%@ Register Assembly="SuperSignature" Namespace="SuperSignature" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server" />
</head>
<body>
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>
    <style type="text/css">
        .RadSplitter_BlackMetroTouch .rspSlideContent
        {
            background-color: white;
            color: black;
        }
        
        html
        {
            /*added to prevent scroll bars in radwindow*/
            overflow: hidden;
        }
        
        .RadSplitter, .RadSplitter .rspSlideZone, .RadSplitter .rspSlideContainer, .RadSplitter .rspPaneTabContainer, .RadSplitter .rspPane, .RadSplitter .rspResizeBar, .RadSplitter .rspSlideContainerResize, .RadSplitter .rspPaneHorizontal, .RadSplitter .rspResizeBarHorizontal, .RadSplitter .rspSlideContainerResizeHorizontal
        {
            border-top-width: 0px;
        }
    </style>
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
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

            var blockresize = false;

            window.onload = function () {

                if (blockresize == false) {

                    var oWin = GetRadWindow();
                    var reviewtype = document.getElementById("HiddenTB_Review").value;
                    var type = "fixed";
                    var height;
                    var width;

                    if (reviewtype == "Yes") {

                        type = "percent"
                        height = height * .96
                        width = width * .96

                    } else if (reviewtype == "With Config") {

                        height = 550
                        width = 880

                    } else {

                        height = 350
                        width = 880
                    }

                    var title = document.getElementById("HiddenTB_PageTitle").value;

                    if (!title) {

                        title = "FASTPORT"

                    }

                    parent.onRWLoaded(oWin, type, height, width, title);
                }

                var DocID = document.getElementById("HiddenTB_DocID").value;
                $find("<%=PrintRB.ClientID %>").set_navigateUrl("../AgreementExecution/PDFFull.aspx?Doc=" + DocID + "&DocName=ViewDoc");

            }

            var rwheight;
            var rwwidth;

            function onSignRSLoaded(sender) {

                setTimeout(function () {

                    var SignRW = GetRadWindow();
                    rwheight = Number(SignRW.get_height());
                    rwwidth = Number(SignRW.get_width());

                    var height = (rwheight * .95) - 100;
                    var width = rwwidth * .94;

                    sender.set_height(height);
                    sender.set_width(width);

                    setPagePnlSize(height, width);

                }, 500);

            }

            function setPagePnlSize(height, width) {

                var pagepnl = document.getElementById("PagePnl");
                pagepnl.style.height = (height - 25) + 'px'
                pagepnl.style.width = width + 'px'

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
                if (window.radWindow) oWindow = window.radWindow;
                //Will work in Moz in all cases, including clasic dialog
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
                //IE (and Moz as well)

                return oWindow;
            }

            function onRequestStart(sender, args) {

                setPagePnlSize(rwheight, rwwidth);


                if (args.get_eventTarget() == "<%= ShowDataRB.UniqueID %>" || args.get_eventTarget() == "<%= ShowSigRB.UniqueID %>") {

                    var slidingzone = $find("<%=SlidingZone1.ClientID %>");

                    if (args.get_eventTarget() == "<%= ShowDataRB.UniqueID %>") {
                        var datarsp = $find("<%=DataRSP.ClientID %>");
                        if (datarsp.get_expanded()) {
                            slidingzone.collapsePane(datarsp.get_id());
                        }
                    } else if (args.get_eventTarget() == "<%= ShowSigRB.UniqueID %>") {
                        var signrsp = $find("<%=SignRSP.ClientID %>");
                        if (signrsp.get_expanded()) {
                            slidingzone.collapsePane(signrsp.get_id());
                        }
                    }
                }

            }

        </script>
    </telerik:RadCodeBlock>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadAjaxManager1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="DocPageRS">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="SignRS" />
                    <telerik:AjaxUpdatedControl ControlID="PagePnl" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="DocPageRLV" />
                    <telerik:AjaxUpdatedControl ControlID="DocPageRS" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ShowDataRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PagePnl" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="DocPageRLV" />
                    <telerik:AjaxUpdatedControl ControlID="ShowDataRB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ShowSigRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PagePnl" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="DocPageRLV" />
                    <telerik:AjaxUpdatedControl ControlID="ShowSigRB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
        <ClientEvents OnRequestStart="onRequestStart" />
    </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="BlackMetroTouch"
        MinDisplayTime="100">
    </telerik:RadAjaxLoadingPanel>
    <div>
        <div id="NoDocsDiv" runat="server" style="background-color: White; border-radius: 5px;
            -moz-border-radius: 5px; -webkit-border-radius: 5px; min-height: 215px;">
            <div id="InstructionsDiv" runat="server" class="dfv" style="padding: 15px; width: 770px;">
                <asp:Literal ID="TopInstructionsLiteral" runat="server"></asp:Literal>
            </div>
            <div id="ConfigDocDiv" runat="server">
                <table>
                    <tbody>
                        <tr>
                            <td class="fls">
                                <asp:Label runat="server" ID="SenderLbl" Text="Sender Party"></asp:Label>
                            </td>
                            <td class="dfv">
                                <telerik:RadComboBox ID="SenderRCB" runat="server" DataSourceID="SenderDS" DataValueField="PartyID"
                                    DataTextField="PartyName" TabIndex="1" AutoPostBack="true" OnSelectedIndexChanged="SenderRCB_SelectedIndexChanged"
                                    EmptyMessage="Sender Company" MarkFirstMatch="True" Width="175px" ShowToggleImage="True"
                                    Filter="Contains">
                                </telerik:RadComboBox>
                                <asp:SqlDataSource ID="SenderDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                    SelectCommand="usp_PartiesMine" SelectCommandType="StoredProcedure">
                                    <SelectParameters>
                                        <asp:SessionParameter Name="ChildID" SessionField="PartyID" Type="Int32" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                            <td style="width: 50px">
                                &nbsp;
                            </td>
                            <td class="fls">
                                <asp:Label runat="server" ID="RecipientLbl" Text="Recipient Company/Person"></asp:Label>
                            </td>
                            <td class="dfv">
                                <telerik:RadComboBox ID="RecipientRCB" runat="server" DataSourceID="RecipientDS"
                                    DataValueField="PartyID" DataTextField="Person" AutoPostBack="true" TabIndex="4"
                                    OnSelectedIndexChanged="RecipientRCB_SelectedIndexChanged" EmptyMessage="Recipient Company/Party"
                                    MarkFirstMatch="True" Width="175px" ShowToggleImage="True" HighlightTemplatedItems="True"
                                    Filter="Contains">
                                    <ItemTemplate>
                                        <%# DataBinder.Eval(Container.DataItem, "PersonShortHTML")%>
                                    </ItemTemplate>
                                </telerik:RadComboBox>
                                <asp:SqlDataSource ID="RecipientDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                    SelectCommand="usp_PartiesRelatedToMine" SelectCommandType="StoredProcedure">
                                    <SelectParameters>
                                        <asp:SessionParameter Name="RelatedUserID" SessionField="PartyID" Type="Int32" />
                                        <asp:ControlParameter ControlID="FormerRCB" Name="FormerRelated" PropertyName="SelectedValue"
                                            Type="String" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                            <td class="dfv">
                                <telerik:RadComboBox ID="FormerRCB" runat="server" Width="75px" AutoPostBack="true"
                                    OnSelectedIndexChanged="FormerRCB_SelectedIndexChanged" TabIndex="5">
                                    <Items>
                                        <telerik:RadComboBoxItem runat="server" Text="Current" Value="0" />
                                        <telerik:RadComboBoxItem runat="server" Text="Former" Value="1" />
                                        <telerik:RadComboBoxItem runat="server" Text="All" Value="2" />
                                    </Items>
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr id="SenderRecipientWarningRow" runat="server" visible="false">
                            <td class="fls">
                            </td>
                            <td class="dfv" style="width: 50px">
                                <span style="color: Red">
                                    <asp:Literal runat="server" ID="SenderWarning"></asp:Literal>
                                </span>
                            </td>
                            <td class="dfv">
                            </td>
                            <td class="fls">
                            </td>
                            <td class="dfv">
                                <span style="color: Red">
                                    <asp:Literal runat="server" ID="RecipientWarning"></asp:Literal>
                                </span>
                            </td>
                            <td class="dfv">
                            </td>
                        </tr>
                        <tr>
                            <td class="fls">
                                <asp:Label runat="server" ID="SenderAddrLbl" Text="Sender Address"></asp:Label>
                            </td>
                            <td class="dfv">
                                <telerik:RadComboBox ID="SenderAddrRCB" runat="server" DataSourceID="SenderAddrDS"
                                    DataValueField="AddrID" DataTextField="OneLine" TabIndex="2" EmptyMessage="Sender Address"
                                    MarkFirstMatch="True" Width="175px" ShowToggleImage="True" HighlightTemplatedItems="True"
                                    Filter="Contains">
                                    <ItemTemplate>
                                        <%# DataBinder.Eval(Container.DataItem, "AddrHTML")%>
                                    </ItemTemplate>
                                </telerik:RadComboBox>
                                <asp:SqlDataSource ID="SenderAddrDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                    SelectCommand="SELECT * FROM [v_Addr] WHERE [PartyID] = @SenderPartyID_ForAddr AND [MovedOut] = 0">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="SenderRCB" Name="SenderPartyID_ForAddr" PropertyName="SelectedValue"
                                            Type="String" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                            <td class="dfv">
                            </td>
                            <td class="fls">
                                <asp:Label runat="server" ID="RecipientAddrLbl" Text="Recipient Address"></asp:Label>
                            </td>
                            <td class="dfv">
                                <telerik:RadComboBox ID="RecipientAddrRCB" runat="server" DataSourceID="RecipientAddrDS"
                                    DataValueField="AddrID" DataTextField="OneLine" TabIndex="6" EmptyMessage="Recipient Address"
                                    MarkFirstMatch="True" Width="175px" ShowToggleImage="True" HighlightTemplatedItems="True"
                                    Filter="Contains">
                                    <ItemTemplate>
                                        <%# DataBinder.Eval(Container.DataItem, "AddrHTML")%>
                                    </ItemTemplate>
                                </telerik:RadComboBox>
                                <asp:SqlDataSource ID="RecipientAddrDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                    SelectCommand="SELECT * FROM [v_Addr] WHERE [PartyID] = @RecipientPartyID_ForAddr AND [MovedOut] = 0">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="RecipientRCB" Name="RecipientPartyID_ForAddr" PropertyName="SelectedValue"
                                            Type="String" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                            <td class="dfv">
                            </td>
                        </tr>
                        <tr>
                            <td class="fls" style="width: 110px">
                                <asp:Label runat="server" ID="SenderSignerLbl" Text="Signer for Sender"></asp:Label>
                            </td>
                            <td class="dfv">
                                <telerik:RadComboBox ID="SenderSignerRCB" runat="server" AllowCustomText="True" DataSourceID="SenderSignerDS"
                                    DataValueField="PartyID" DataTextField="Person" TabIndex="3" HighlightTemplatedItems="True"
                                    Width="175px" MarkFirstMatch="True" EmptyMessage="Signer for Sender">
                                    <ItemTemplate>
                                        <%# DataBinder.Eval(Container.DataItem, "PersonShortHTML")%>
                                    </ItemTemplate>
                                </telerik:RadComboBox>
                                <asp:SqlDataSource ID="SenderSignerDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                    SelectCommand="SELECT * FROM [v_PersonAllWithParty] WHERE ([ParentID] = @SenderPartyID_ForSigner AND ([PartyStatus] = 'Administrator' OR [PartyStatus] = 'Active')) OR [PartyID] = @SenderPartyID_ForSigner">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="SenderRCB" Name="SenderPartyID_ForSigner" PropertyName="SelectedValue"
                                            Type="String" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                            <td class="dfv" style="width: 50px">
                            </td>
                            <td class="fls" style="width: 125px">
                                <asp:Label runat="server" ID="RecipientSignerLbl" Text="Signer for Recipient"></asp:Label>
                            </td>
                            <td class="dfv">
                                <telerik:RadComboBox ID="RecipientSignerRCB" runat="server" AllowCustomText="True"
                                    DataSourceID="RecipientSignerDS" DataValueField="PartyID" DataTextField="Person"
                                    TabIndex="7" HighlightTemplatedItems="True" Width="175px" Filter="Contains" MarkFirstMatch="True"
                                    EmptyMessage="Signer for Recipient">
                                    <ItemTemplate>
                                        <%# DataBinder.Eval(Container.DataItem, "PersonShortHTML")%>
                                    </ItemTemplate>
                                </telerik:RadComboBox>
                                <asp:SqlDataSource ID="RecipientSignerDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                    SelectCommand="SELECT * FROM [v_PersonAllWithParty] WHERE ([ParentID] = @RecipientPartyID_ForSigner AND ([PartyStatus] = 'Administrator' OR [PartyStatus] = 'Active')) OR [PartyID] = @RecipientPartyID_ForSigner">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="RecipientRCB" Name="RecipientPartyID_ForSigner"
                                            PropertyName="SelectedValue" Type="String" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                            <td class="dfv">
                            </td>
                        </tr>
                        <tr>
                            <td class="fls">
                                &nbsp;
                            </td>
                            <td class="dfv">
                                <span style="color: Red">
                                    <asp:Literal runat="server" ID="SenderSignerWarning"></asp:Literal>
                                </span>
                            </td>
                            <td class="dfv">
                            </td>
                            <td class="dfv">
                            </td>
                            <td class="dfv">
                                <span style="color: Red">
                                    <asp:Literal runat="server" ID="RecipientSignerWarning"></asp:Literal>
                                </span>
                            </td>
                            <td class="dfv">
                            </td>
                        </tr>
                        <tr id="DatesRow" runat="server">
                            <td class="fls" colspan="5">
                                <center>
                                    <table>
                                        <tr id="SignedOnRow" runat="server">
                                            <td class="fls">
                                                <asp:Label runat="server" ID="SignedOnLbl" Text="Document Date"></asp:Label>
                                            </td>
                                            <td class="fls">
                                                <telerik:RadDatePicker ID="SignedOnRDP" runat="server" Width="100px" TabIndex="8">
                                                </telerik:RadDatePicker>
                                            </td>
                                        </tr>
                                        <tr id="ExpiresOnRow" runat="server">
                                            <td class="fls">
                                                <asp:Label runat="server" ID="ExpiresOnLbl" Text="Expiration Date"></asp:Label>
                                            </td>
                                            <td class="fls">
                                                <telerik:RadDatePicker ID="ExpiresOnRDP" runat="server" Width="100px" TabIndex="9">
                                                </telerik:RadDatePicker>
                                            </td>
                                        </tr>
                                    </table>
                                </center>
                            </td>
                            <td class="fls">
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <div id="SignDiv">
            <telerik:RadSplitter ID="SignRS" runat="server" Skin="BlackMetroTouch" OnClientLoaded="onSignRSLoaded">
                <telerik:RadPane ID="LeftPane" runat="server" Width="22px" Scrolling="none">
                    <telerik:RadSlidingZone ID="SlidingZone1" runat="server" Width="22px" SkinID="BlackMetroTouch">
                        <telerik:RadSlidingPane ID="InstructionsRSP" Title="&nbsp;&nbsp;&nbsp;Instructions&nbsp;&nbsp;&nbsp;"
                            runat="server" Width="425px" MinWidth="100">
                            <div class="dfv">
                                <asp:Literal ID="InstructionsLiteral" runat="server"></asp:Literal>
                                <asp:Literal ID="InstructionsLiteral1" runat="server"></asp:Literal>
                            </div>
                        </telerik:RadSlidingPane>
                        <telerik:RadSlidingPane ID="DataRSP" Title="&nbsp;&nbsp;&nbsp;Fill Out&nbsp;&nbsp;&nbsp;"
                            runat="server" Width="425px" MinWidth="100">
                            <table>
                                <tr id="FirstItemRow" runat="Server">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="FirstItemCell"
                                        runat="server">
                                        <asp:Literal ID="FirstItemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="FirstInputCell" runat="server" style="vertical-align: top; text-align: left;">
                                        <telerik:RadTextBox ID="FirstItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="FirstItemCB" runat="server" Height="15px"
                                            Width="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="FirstItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="FirstItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="FirstItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                                <tr id="SecondItemRow" runat="server">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="SecondItemCell"
                                        runat="server">
                                        <asp:Literal ID="SecondItemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="SecondInputCell" runat="server" style="vertical-align: top; text-align: left;">
                                        <telerik:RadTextBox ID="SecondItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="SecondItemCB" runat="server" Height="15px"
                                            Width="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="SecondItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="SecondItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="SecondItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                                <tr id="ThirdItemRow" runat="server">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="ThirdItemCell"
                                        runat="server">
                                        <asp:Literal ID="ThirdItemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="ThirdInputCell" runat="server" style="vertical-align: top; text-align: left;">
                                        <telerik:RadTextBox ID="ThirdItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="ThirdItemCB" runat="server" Width="15px"
                                            Height="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="ThirdItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="ThirdItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="ThirdItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                                <tr id="Fourthitemrow" runat="server">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="FourthItemCell"
                                        runat="server">
                                        <asp:Literal ID="FourthItemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="FourthInputCell" runat="server" style="vertical-align: top; text-align: left;">
                                        <telerik:RadTextBox ID="FourthItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="FourthItemCB" runat="server" Height="15px"
                                            Width="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="FourthItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="FourthItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="FourthItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                                <tr id="FifthItemRow" runat="server">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="FifthItemCell"
                                        runat="server">
                                        <asp:Literal ID="FifthItemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="FifthInputCell" runat="server" style="vertical-align: top; text-align: left;">
                                        <telerik:RadTextBox ID="FifthItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="FifthItemCB" runat="server" Height="15px"
                                            Width="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="FifthItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="FifthItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="FifthItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                                <tr id="SixthItemRow" runat="server">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="SixthItemCell"
                                        runat="server">
                                        <asp:Literal ID="SixthItemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="SixthInputCell" runat="server" style="vertical-align: top; text-align: left;">
                                        <telerik:RadTextBox ID="SixthItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="SixthItemCB" runat="server" Height="15px"
                                            Width="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="SixthItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="SixthItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="SixthItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                                <tr id="SeventhItemRow" runat="server">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="SeventhItemCell"
                                        runat="server">
                                        <asp:Literal ID="SeventhItemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="SeventhInputCell" runat="server" style="vertical-align: top;
                                        text-align: left;">
                                        <telerik:RadTextBox ID="SeventhItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="SeventhItemCB" runat="server" Height="15px"
                                            Width="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="SeventhItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="SeventhItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="SeventhItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                                <tr id="EighthItemRow" runat="server">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="EighthItemCell"
                                        runat="server">
                                        <asp:Literal ID="EighthItemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="EighthInputCell" runat="server" style="vertical-align: top; text-align: left;">
                                        <telerik:RadTextBox ID="EighthItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="EighthItemCB" runat="server" Height="15px"
                                            Width="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="EighthItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="EighthItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="EighthItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                                <tr id="NinthItemRow" runat="server">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="NinthItemCell"
                                        runat="server">
                                        <asp:Literal ID="NinthitemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="NinthInputCell" runat="server" style="vertical-align: top; text-align: left;">
                                        <telerik:RadTextBox ID="NinthItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="NinthItemCB" runat="server" Height="15px"
                                            Width="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="NinthItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="NinthItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="NinthItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                                <tr id="TenthItemRow" runat="server">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="TenthItemCell"
                                        runat="server">
                                        <asp:Literal ID="TenthItemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="TenthInputCell" runat="server" style="vertical-align: top; text-align: left;">
                                        <telerik:RadTextBox ID="TenthItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="TenthItemCB" runat="server" Height="15px"
                                            Width="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="TenthItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="TenthItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="TenthItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                                <tr runat="server" id="EleventhItemRow">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="EleventhItemCell"
                                        runat="server">
                                        <asp:Literal ID="EleventhItemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="EleventhInputCell" runat="server" style="vertical-align: top;
                                        text-align: left;">
                                        <telerik:RadTextBox ID="EleventhItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="EleventhItemCB" runat="server" Height="15px"
                                            Width="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="EleventhItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="EleventhItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="EleventhItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                                <tr runat="server" id="TwelfthItemRow">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="TwelfthItemCell"
                                        runat="server">
                                        <asp:Literal ID="TwelfthItemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="TwelfthInputCell" runat="server" style="vertical-align: top;
                                        text-align: left;">
                                        <telerik:RadTextBox ID="TwelfthItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="TwelfthItemCB" runat="server" Height="15px"
                                            Width="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="TwelfthItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="TwelfthItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="TwelfthItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                                <tr runat="server" id="ThirteenthItemRow">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="ThirteenthItemCell"
                                        runat="server">
                                        <asp:Literal ID="ThirteenthItemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="ThirteenthInputCell" runat="server" style="vertical-align: top;
                                        text-align: left;">
                                        <telerik:RadTextBox ID="ThirteenthItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="ThirteenthItemCB" runat="server" Height="15px"
                                            Width="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="ThirteenthItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="ThirteenthItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="ThirteenthItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                                <tr runat="server" id="FourteenthItemRow">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="FourteenthItemCell"
                                        runat="server">
                                        <asp:Literal ID="FourteenthItemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="FourteenthInputCell" runat="server" style="vertical-align: top;
                                        text-align: left;">
                                        <telerik:RadTextBox ID="FourteenthItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="FourteenthItemCB" runat="server" Height="15px"
                                            Width="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="FourteenthItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="FourteenthItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="FourteenthItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                                <tr runat="server" id="FifteenthItemRow">
                                    <td class="fls" style="text-align: left; vertical-align: top;" id="FifteenthItemCell"
                                        runat="server">
                                        <asp:Literal ID="FifteenthItemLiteral" runat="server"></asp:Literal>
                                    </td>
                                    <td class="dfv" id="FifteenthInputCell" runat="server" style="vertical-align: top;
                                        text-align: left;">
                                        <telerik:RadTextBox ID="FifteenthItemRTB" runat="server" Width="175px">
                                        </telerik:RadTextBox>
                                        <asp:CheckBox CssClass="field_input" ID="FifteenthItemCB" runat="server" Height="15px"
                                            Width="15px"></asp:CheckBox>
                                        <telerik:RadComboBox ID="FifteenthItemRCB" runat="server" Width="175px">
                                        </telerik:RadComboBox>
                                        <telerik:RadDatePicker ID="FifteenthItemRDP" runat="server" Width="100px">
                                        </telerik:RadDatePicker>
                                        <telerik:RadEditor ID="FifteenthItemRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                            Height="125" Width="400" EditModes="Design">
                                        </telerik:RadEditor>
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <br />
                            <center>
                                <table>
                                    <tr>
                                        <td>
                                            <telerik:RadButton ID="ShowDataRB" runat="server" AutoPostBack="True" Text="Show Data on Doc"
                                                ToolTip="Click here to show the data entered above on your document.">
                                            </telerik:RadButton>
                                        </td>
                                        <td class="dfv" style="padding: 10px; width: 225px; font-size: 10px;">
                                            <em>(Optional: you may also click the buttons below to save your signature.)</em>
                                        </td>
                                    </tr>
                                </table>
                            </center>
                        </telerik:RadSlidingPane>
                        <telerik:RadSlidingPane ID="SignRSP" Title="&nbsp;&nbsp;&nbsp;Sign Here&nbsp;&nbsp;&nbsp;"
                            runat="server" Width="560px" MinWidth="100">
                            <div>
                                <div class="dfv" style="padding: 10px">
                                    Please carefully review all of the terms and conditions for the document shown below.
                                    If you agree with all of these terms and conditions, please use your mouse (or finger
                                    on mobile devices) to sign in the box provided below. <span style="font-weight: bold;">
                                        NOTE: SIGNING BELOW CONSTITUTES A LEGALLY BINDING SIGNATURE THAT HOLDS THE SAME
                                        LEGAL WEIGHT AS IF YOU SIGNED A TRADITIONAL PAPER DOCUMENT WITH A PEN.</span></div>
                                <cc1:MouseSignature ID="ctlSignature" runat="server" SignPenColor="Black" SignRequired="false"
                                    SignHeight="160" SignWidth="524" />
                                <br />
                                <table id="InitialsTable" runat="server">
                                    <tr>
                                        <td>
                                            <cc1:MouseSignature ID="ctlInitials" runat="server" SignPenColor="Black" SignRequiredPoints="20"
                                                SignRequired="false" SignHeight="95" SignWidth="95" />
                                        </td>
                                        <td class="dfv" style="padding: 10px">
                                            Please use or mouse (of finger) to place you signature in the box to the right.
                                            This will insert your initials into each place where initials are required in this
                                            document.
                                        </td>
                                    </tr>
                                </table>
                                <br />
                                <br />
                                <center>
                                    <table>
                                        <tr>
                                            <td>
                                                <telerik:RadButton ID="ShowSigRB" runat="server" AutoPostBack="True" Text="Show Signature on Doc"
                                                    ToolTip="Click here to show your signature (and initials if required) on your document.">
                                                </telerik:RadButton>
                                            </td>
                                            <td class="dfv" style="padding: 10px; width: 225px; font-size: 10px;">
                                                <em>(Optional, you may also click the buttons below to save your signature.)</em>
                                            </td>
                                        </tr>
                                    </table>
                                </center>
                            </div>
                        </telerik:RadSlidingPane>
                        <telerik:RadSlidingPane ID="OtherRSP" Title="&nbsp;&nbsp;&nbsp;Other Options&nbsp;&nbsp;&nbsp;"
                            runat="server" Width="150px" MinWidth="100">
                            <table>
                                <tbody>
                                    <tr id="OutsideDocsRow" runat="server">
                                        <td>
                                            <FASTPORT:ThemeButton runat="server" ID="UploadTemplateButton" Button-CausesValidation="False"
                                                Button-CommandName="Redirect" Button-TabIndex="10" Button-Text="Upload New Template"
                                                Button-ToolTip="Click here to upload a new merge template for this work flow.">
                                            </FASTPORT:ThemeButton>
                                            <br />
                                            <FASTPORT:ThemeButton runat="server" ID="UploadPDFButton" Button-CausesValidation="False"
                                                Button-CommandName="Redirect" Button-TabIndex="11" Button-Text="Upload Signed Doc"
                                                Button-ToolTip="Click here to upload a document that you have already signed.">
                                            </FASTPORT:ThemeButton>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </telerik:RadSlidingPane>
                    </telerik:RadSlidingZone>
                </telerik:RadPane>
                <telerik:RadSplitBar ID="Radsplitbar1" runat="server">
                </telerik:RadSplitBar>
                <telerik:RadPane ID="DocRP" runat="server" Scrolling="None">
                    <div style="background-color: White; width: 100%; height: 100%;">
                        <div style="background-color: #d9d9d9">
                            <center>
                                <telerik:RadSlider runat="server" ID="DocPageRS" MaximumValue="11" MinimumValue="1"
                                    Value="5" LiveDrag="false" SmallChange="1" AutoPostBack="true" OnValueChanged="DocPageRS_ValueChanged"
                                    Width="150px" CausesValidation="false" Visible="true" />
                                <telerik:RadButton ID="PrintRB" runat="server" Image-EnableImageButton="true" Image-ImageUrl="/Images/Custom/print.png"
                                    Width="20px" Height="20px" Visible="true" ButtonType="LinkButton" Target="_blank" AutoPostBack="false">
                                </telerik:RadButton>
                            </center>
                        </div>
                        <asp:Panel ID="PagePnl" runat="server" style="overflow:auto">
                            <telerik:RadListView ID="DocPageRLV" runat="server" ItemPlaceholderID="DocPageContainer"
                                DataKeyNames="PageID" ClientDataKeyNames="PageID" DataSourceID="DocPageDS">
                                <LayoutTemplate>
                                    <div class="RadListView RadListView_<%# Container.Skin %>">
                                        <asp:PlaceHolder ID="DocPageContainer" runat="server"></asp:PlaceHolder>
                                    </div>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <div id="<%# Eval("PageID") %>" class="track rlvI" style="float: left; margin: 5px;
                                        padding: 8px; position: relative; background: rgb(217, 217, 217);">
                                        <div class="info">
                                            <telerik:RadBinaryImage Style="cursor: pointer; display: block;" runat="server" ID="DocFileRBI"
                                                DataValue='<%# Eval("DocFile") %>' Height='<%#ImageHeight %>' Width="<%#ImageWidth %>"
                                                ResizeMode="Fit" />
                                        </div>
                                    </div>
                                </ItemTemplate>
                                <EmptyDataTemplate>
                                    <div class="noTracks">
                                        No tracks in this section
                                    </div>
                                </EmptyDataTemplate>
                            </telerik:RadListView>
                            <asp:SqlDataSource ID="DocPageDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                SelectCommand="SELECT dp.* FROM dbo.DocPage dp JOIN dbo.Doc d ON d.DocID = dp.DocID WHERE d.ExecutionID = @ExecutionID">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="HiddenTB_ExecutionID" PropertyName="Text" Type="String"
                                        Name="ExecutionID" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                        </asp:Panel>
                    </div>
                </telerik:RadPane>
            </telerik:RadSplitter>
        </div>
        <div>
            <center>
                <table>
                    <tr>
                        <td>
                            <FASTPORT:ThemeButton runat="server" ID="Next1Button" Button-CausesValidation="False"
                                Button-CommandName="Redirect" Button-TabIndex="14" Button-ToolTip="Click to move to the next step."
                                Visible="False"></FASTPORT:ThemeButton>
                        </td>
                        <td>
                            <FASTPORT:ThemeButton runat="server" ID="Next2Button" Button-CausesValidation="False"
                                Button-CommandName="Redirect" Button-TabIndex="15" Button-ToolTip="Click to move to the next step."
                                Visible="False"></FASTPORT:ThemeButton>
                        </td>
                        <td>
                            <FASTPORT:ThemeButton runat="server" ID="Next3Button" Button-CausesValidation="False"
                                Button-CommandName="Redirect" Button-TabIndex="16" Button-ToolTip="Click to move to the next step."
                                Visible="False"></FASTPORT:ThemeButton>
                        </td>
                        <td>
                            <FASTPORT:ThemeButton runat="server" ID="Next4Button" Button-CausesValidation="False"
                                Button-CommandName="Redirect" Button-TabIndex="17" Button-ToolTip="Click to move to the next step."
                                Visible="False"></FASTPORT:ThemeButton>
                        </td>
                        <td>
                            <div>
                                <table>
                                    <tr>
                                        <td style="padding: 5px">
                                            <asp:ImageButton runat="server" ID="RewindButton" CausesValidation="False" CommandName="Redirect"
                                                ImageUrl="../Images/Custom/blank.png" TabIndex="18" Visible="False"></asp:ImageButton>
                                        </td>
                                        <td style="padding: 5px">
                                            <asp:ImageButton runat="server" ID="MessageButton" CausesValidation="False" CommandName="Redirect"
                                                ImageUrl="../Images/Custom/blank.png" TabIndex="19" Visible="False"></asp:ImageButton>
                                        </td>
                                        <td style="padding: 5px">
                                            <asp:ImageButton runat="server" ID="DashboardButton" CausesValidation="False" CommandName="Redirect"
                                                ImageUrl="../Images/Custom/blank.png" TabIndex="20" Visible="False"></asp:ImageButton>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
                </table>
            </center>
        </div>
        <asp:TextBox ID="HiddenTB_ExecutionID" runat="server" Text="0" Style="display: none">
        </asp:TextBox>
        <asp:TextBox ID="HiddenTB_PartyID" runat="server" Text="0" Style="display: none">
        </asp:TextBox>
        <asp:TextBox ID="HiddenTB_Review" runat="server" Text="0" Style="display: none">
        </asp:TextBox>
        <asp:TextBox ID="HiddenTB_PageTitle" runat="server" Text="0" Style="display: none">
        </asp:TextBox>
        <asp:TextBox ID="HiddenTB_DocID" runat="server" Text="0" Style="display: none"></asp:TextBox>
    </div>
    </form>
</body>
</html>
