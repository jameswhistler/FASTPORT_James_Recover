<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="DocListDemo.aspx.vb" Inherits=".DocRLV" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    <style type="text/css">
        
        div.RadListView
        {
            float: left;
            border: none;
            width: 100%;
            background-color: Transparent;
        }
        
        
        #DocPageContainerDiv
        {
            border: none;
            border-top: 1px solid #E6E6E6;
            border-left: 1px solid #E6E6E6;
            width: 100%;
            float: left;
        }
        
        div.RadListView div.track
        {
            float: left;
            border-right: 1px solid #E6E6E6;
            border-bottom: 1px solid #E6E6E6;
            padding: 0;
            margin: 0;
        }
        
    </style>
    <script type="text/javascript">


        function docmouseover(sender) {

            var pageid = sender.id;
            document.getElementById("HiddenTB_PageID").value = pageid;
            v_docdiv(sender, "");


        }

        function docmouseout(sender) {

            v_docdiv(sender, "none");

        }

        function v_docdiv(sender, displaytype) {

            var divindex = null;
            divindex = 0

            if (divindex != null) {
                sender.getElementsByTagName("div")[divindex].style.display = displaytype;
            }

        }

        var DocPageRLV;

        function pageLoad() {
            DocPageRLV = $find('<%= DocPageRLV.ClientID %>');
        }


        function docclick(sender) {

            var currentbackground = sender.style.background;
            var addordel;
            if (currentbackground == "rgb(217, 217, 217)") {
                sender.style.background = "rgb(0, 130, 204)";
                addordel = "add";
            } else {
                sender.style.background = "rgb(217, 217, 217)";
                addordel = "del";
            }

            var pageid = sender.id;
            docselection(pageid, addordel);

        }

        function docselection(pageid, addordel) {

            var ctl_pagesselected = document.getElementById("HiddenTB_PagesSelected");
            var ctl_pagesselectedcount = document.getElementById("HiddenTB_PagesSelectedCount");
            var pagesselected = ctl_pagesselected.value;
            var pagesselectedcount = Number(ctl_pagesselectedcount.value);

            if (!pagesselected) {
                pagesselected = ""
            }

            if (addordel == "add") {
                pagesselected = pagesselected + pageid + ","
                pagesselectedcount = pagesselectedcount + 1
            } else {
                pagesselected = pagesselected.replace(pageid + ",", "")
                pagesselectedcount = pagesselectedcount - 1
            }

            ctl_pagesselected.value = pagesselected;
            ctl_pagesselectedcount.value = pagesselectedcount;
        }

        function onDocPageRLVDataBinding() {

            document.getElementById("HiddenTB_PageID").value = "0"
            document.getElementById("HiddenTB_PagesSelected").value = ""
            document.getElementById("HiddenTB_PagesSelectedCount").value = "0"

        }

        function docmousedown(sender) {

            $("body").css("cursor", "progress");

        }

    </script>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
    <div>
        <div id="HiddenDiv" style="">
            PartyID:
            <asp:TextBox ID="HiddenTB_PartyID" runat="server" Text="253"></asp:TextBox><br />
            PageID:
            <asp:TextBox ID="HiddenTB_PageID" runat="server" Text="0"></asp:TextBox><br />
            PagesSelected:
            <asp:TextBox ID="HiddenTB_PagesSelected" runat="server" Text=""></asp:TextBox><br />
            PagesSelectedCount:
            <asp:TextBox ID="HiddenTB_PagesSelectedCount" runat="server" Text="0"></asp:TextBox><br />
        </div>
        <br />
        <br />
        <div id="DocPageContainerDiv">
            <telerik:RadListView ID="DocPageRLV" runat="server" ItemPlaceholderID="DocPageContainer"
                DataKeyNames="PageID" ClientDataKeyNames="PageID" DataSourceID="DocPageDS">
                <ClientSettings AllowItemsDragDrop="true">
                    <ClientEvents></ClientEvents>
                </ClientSettings>
                <LayoutTemplate>
                    <div>
                        <telerik:RadSlider runat="server" ID="DocPageRS" MaximumValue="11" MinimumValue="1"
                            Value="5" LiveDrag="false" SmallChange="1" AutoPostBack="true" OnValueChanged="DocPageRS_ValueChanged"
                            Width="150px" CausesValidation="false" />
                    </div>
                    <div class="RadListView RadListView_<%# Container.Skin %>">
                        <asp:PlaceHolder ID="DocPageContainer" runat="server"></asp:PlaceHolder>
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <div id="<%# Eval("PageID") %>" class="track rlvI" style="float: left; margin: 5px;
                        padding: 8px; position: relative; background: rgb(217, 217, 217);" onmouseover="docmouseover(this)"
                        onmouseout="docmouseout(this)" onclick="docclick(this)" onmousedown="docmousedown(this);">
                        <div style="z-index: 100; margin-top: 7px; margin-left: 5px; position: absolute;
                            width: 235px; display: none;" class="fp_button_wrapper">
                            <table>
                                <tbody>
                                    <tr>
                                        <td>
                                            <telerik:RadListViewItemDragHandle ID="DocPageDH" runat="server" ToolTip="Drag to organize">
                                            </telerik:RadListViewItemDragHandle>
                                        </td>
                                        <td>
                                            <telerik:RadButton ID="RotateRB" runat="server" Text="Rotate" ToolTip="Click to rotate."
                                                CommandName="HistOpenTip">
                                            </telerik:RadButton>
                                        </td>
                                        <td>
                                            <telerik:RadButton ID="EditRB" runat="server" Text="Edit" ToolTip="Click to edit image."
                                                CommandName="HistEdit">
                                            </telerik:RadButton>
                                        </td>
                                        <td>
                                            <telerik:RadButton ID="HistDelRB" runat="server" Text="Delete" ToolTip="Click to delete page."
                                                CommandName="HistDel">
                                                <Icon PrimaryIconCssClass="rbRemove" PrimaryIconLeft="4" PrimaryIconTop="4"></Icon>
                                            </telerik:RadButton>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class="info">
                            <telerik:RadBinaryImage Style="cursor: pointer; display: block;" runat="server" ID="DocFileRBI"
                                DataValue='<%#Eval("DocFile") %>' Height='<%#ImageHeight %>' Width="<%#ImageWidth %>"
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
        </div>
        <asp:SqlDataSource ID="DocPageDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
            SelectCommand="SELECT dp.* FROM JOIN dbo.DocPage dp
                            WHERE
	                            d.CIX = 253
                            ORDER BY 
	                            1">
            <SelectParameters>
                <asp:Parameter DefaultValue="188" Name="DocID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
