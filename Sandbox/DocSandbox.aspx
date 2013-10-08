<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="DocSandbox.aspx.vb" Inherits=".DocSandbox" %>

<%@ Register TagPrefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
<%@ Register Assembly="SuperSignature" Namespace="SuperSignature" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FASTPORT > Config</title>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server" />
    <style type="text/css">
        body
        {
            margin: 0px;
            overflow: hidden;
        }
        .RadGrid_Default
        {
            border: 0px !important;
        }
        
        #DocDiv
        {
            position: absolute;
            top: 48px;
            bottom: 0px;
            width: 100%;
        }
        
        div.RadListView
        {
            float: left;
            border: none;
            width: 100%;
            background-color: Transparent;
        }
        
        #DocShowDiv
        {
            border: none;
            width: 100%;
            float: left;
        }
        
        div.RadListView div.track
        {
            float: left;
            padding: 0;
            margin: 0;
        }
        
        #DocDetailsContentDiv
        {
            background-color: White !important;
        }
        
        .rwPinButton, .rwMinimizeButton, .rwMaximizeButton
        {
            display: none !important;
        }
        
        .rwControlButtons li
        {
            float: right !important;
        }
        
        #DocDetailsRW_C
        {
            overflow: hidden !important;
        }
        
        .RadWindow_BlackMetroTouch .rwTable .rwTitlebarControls em
        {
            font-size: 18px;
            padding: 8px 0 0 3px;
        }
        
        .RadWindow, .RadWindow_BlackMetroTouch, .rwNormalWindow, .rwTransparentWindow, .rwNoTitleBar
        {
            height: auto;
        }
        
        .RadButton .rbPrimary
        {
            padding-left: 35px !important;
        }
        
        .RadSplitter, .RadSplitter .rspSlideZone, .RadSplitter .rspSlideContainer, .RadSplitter .rspPaneTabContainer, .RadSplitter .rspPane, .RadSplitter .rspResizeBar, .RadSplitter .rspSlideContainerResize, .RadSplitter .rspPaneHorizontal, .RadSplitter .rspResizeBarHorizontal, .RadSplitter .rspSlideContainerResizeHorizontal
        {
            border-top-width: 0px;
        }
    </style>
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
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type="text/javascript">

        window.onload = function () {

            getWindowDims();
            
            var tree = $find("<%= DocRadTreeView.ClientID %>");
            var node = tree.findNodeByValue("0");
            node.select();
        };

        window.onresize = function () {

            getWindowDims();

        };

        function getWindowDims() {

            var windowheight = window.innerHeight;
            document.getElementById("HiddenTB_WindowHeight").value = windowheight;
            
            var windowwidth = window.innerWidth;
            document.getElementById("HiddenTB_WindowWidth").value = windowwidth;
        }


        //Step 1: Node clicked.
        function onDocTreeNodeClicked(sender, eventArgs) {

            var node = eventArgs.get_node();
            var nodevalue = node.get_value();
            var nodetext = node.get_text();
            
            //To Step 2
            setLastClicked(nodevalue, nodetext);

            //To Step 3
            v_PagePanel(nodetext);
            
            //To Step 4
            var myString = nodetext;
            var mySplit = myString.split(",", 6);
            var docaction = mySplit[0] || "";
            var docsplitid = mySplit[1] || "";
            setvaluesforpages(docaction, docsplitid);

            //Only when actually clicking.
            if (docaction == "f") {
                node.toggle();
            } else if (docaction != "ae" && docaction!="as" ) {
                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindDocPageRLV");
            }

        }

        //Step 1b: Node Searched.        
        function afterNodeSearch(nodevalue) {

            var tree = $find("<%= DocRadTreeView.ClientID %>");
            var node = tree.findNodeByValue(nodevalue);

            if (node) {
                var nodetext = node.get_text();

                //To Step 2 (like above).
                setLastClicked(nodevalue,nodetext);

                //To Step 3 (like above).
                v_PagePanel(nodetext);

                //To stpe 4 (like above).
                var myString = nodetext;
                var mySplit = myString.split(",", 6);
                var docaction = mySplit[0] || "";
                var docsplitid = mySplit[1] || "";
                setvaluesforpages(docaction, docsplitid);

                //Simulate mouseover
                document.getElementById("<%= HiddenTB_NodeID.ClientID %>").value = nodevalue;
                document.getElementById("<%= HiddenTB_NodeText.ClientID %>").value = nodetext;
            }
            
        }

        //Step 2: Set last clicked.
        function setLastClicked(nodevalue, nodetext) {
        
            document.getElementById("<%= HiddenTB_NodeIDLastClicked.ClientID %>").value = nodevalue;
            document.getElementById("<%= HiddenTB_NodeTextLastClicked.ClientID %>").value = nodetext;

        }

        //Step 3: Proper controls made visible.
        function v_PagePanel(nodetext) {

            var myString = nodetext;
            var mySplit = myString.split(",", 6);

            var docaction = mySplit[0] || "";
            var docsplitid = mySplit[1] || "";
            var docco = mySplit[4] || "";

            document.getElementById("<%= HiddenTB_DocAction.ClientID %>").value = docaction;
            document.getElementById("<%= HiddenTB_CIX.ClientID %>").value = docco;

            if (docaction != "f") {
                if (docaction == "du" || docaction == "dn" || docaction == "aa") {
                    v_DocStuff("UploadSignDiv");
                    var DocUploadRow = document.getElementById("DocUploadRow");
                    var DocSignRow = document.getElementById("DocSignRow");
                    if (docaction != "aa" && docaction != "ae") {
                        DocUploadRow.style.display = "";
                        DocSignRow.style.display = "none";
                        document.getElementById("<%= UploadSignHeaderLbl.ClientID %>").innerHTML = "SIGN Document."
                        document.getElementById("<%= UploadSignLbl.ClientID %>").innerHTML = "You have three options to load your document into FASTPORT: (1) upload the document directly into the system, (2) fax the document into the system, or (3) email the document into the system.  <em><strong>Please click</em></strong> the button that is most convenient for you."
                    } else {
                        DocUploadRow.style.display = "none";
                        DocSignRow.style.display = "";
                        document.getElementById("<%= UploadSignHeaderLbl.ClientID %>").innerHTML = "Upoad/Fax/Email Document."
                        document.getElementById("<%= UploadSignLbl.ClientID %>").innerHTML = "The EASIEST way to sign this document is to <em><strong>click the 'SIGN Document ONLINE' button.</strong></em>  The next easiest ways to upload the documents are to click the (1) upload, (2) fax, or (3) email into FASTPORT buttons.  Please click the button that is most convenient for you."
                    }
                } else if (docaction == "ds"|| docaction == "ae" || docaction == "as") {
                    v_DocStuff("DocShowDiv");
                    if (docaction == "ds") {
                        var completestatus = mySplit[5] || "";
                        v_docdetails(completestatus);
                    }
                } else {
                    v_DocStuff("none");
                }
            } else {
                v_DocStuff("FolderDiv");
            }
        }

        //Step 4: Set DocID or ExecutionID, depending on context.
        function setvaluesforpages(docaction,docsplitid) {
    
            if (docaction == "dn" || docaction == "du" || docaction == "ds") {
                document.getElementById("<%= HiddenTB_DocID.ClientID %>").value = docsplitid;
                document.getElementById("<%= HiddenTB_ExecutionID.ClientID %>").value = "0";
                //document.getElementById("HiddenTB_PageTitle").value = nodetext;
            } else if (docaction == "aa" || docaction == "ae" || docaction == "as") {
                document.getElementById("<%= HiddenTB_DocID.ClientID %>").value = "0";
                document.getElementById("<%= HiddenTB_ExecutionID.ClientID %>").value = docsplitid;
            }

        }

        //Step 5: Deal with mousing over nodes (tells us "where" drops are "headed."
        function onDocRadTreeViewMouseOver(sender, eventArgs) {
            var node = eventArgs.get_node();
            var nodeid = node.get_value();
            var nodetext = node.get_text();
            document.getElementById("<%= HiddenTB_NodeID.ClientID %>").value = nodeid;
            document.getElementById("<%= HiddenTB_NodeText.ClientID %>").value = nodetext;
        }

                
        var itemdragging = false;

        //Step 6: Start drag show tooltip, etc.
        function onDocPageRLVItemDragStarted() {

            itemdragging = true;
            pageid = document.getElementById("HiddenTB_PageID").value;
            docselection(pageid, "add");

            var DragDropRTT = $find("<%=DragDropRTT.ClientID %>");
            var HiddenTB_PagesSelectedCount = document.getElementById("HiddenTB_PagesSelectedCount").value;
            var DragDropRTT_Text = "<center><span style='text-decoration: underline;'><Strong>DRAGGING " + HiddenTB_PagesSelectedCount + " PAGE(s)</strong></span></center><br /><br />" + "1. To MOVE, please DROP on a document to the left.<br />" + "2. To RE-ORDER pages, please DROP on page to insert in FRONT of it.<br /><br />"
            DragDropRTT.set_text(DragDropRTT_Text);
            DragDropRTT.show();

        }

        var droppartyid;
        var droppagesselected;
        var dropaction;
        var dropsplitid;
        var dropname;
        var droptype;
        var dropco;
        var dropkey;

        //Step 7: Start drop.
        function onDocPageRLVItemDropping(sender, args) {
        
            var DragDropRTT = $find("<%=DragDropRTT.ClientID %>");
            DragDropRTT.hide();
            itemdragging = false;

            var dropdest = args.get_destinationElement().id

            droppartyid = document.getElementById("HiddenTB_PartyID").value;
            droppagesselected = document.getElementById("HiddenTB_PagesSelected").value;
            droppagesselected = droppagesselected.replace(/,/g, "<|>")

            if (dropdest.indexOf("DocI") != -1 || dropdest.indexOf("DocN") != -1) {

                //Must have "received" from mouse over!!!
                var nodetext = document.getElementById("HiddenTB_NodeText").value;

                var myString = nodetext;
                var mySplit = myString.split(",", 6);

                dropaction = mySplit[0] || "";
                dropsplitid = mySplit[1] || "";
                dropname = mySplit[2] || "";
                droptype = mySplit[3] || "";
                dropco = mySplit[4] || "";
                dropkey = mySplit[5] || "";

                //Variables set above used in page actions.
                pageactions();

            } else if (dropdest.indexOf("DocPageRLV") != -1) {

                var pageid = document.getElementById("HiddenTB_PageID").value;
                SendCallBack("dropDocReorder," + pageid + "," + droppagesselected, "dropDoc");

            }

            docselectionclear();

            args.set_cancel(true);

        }

        //Seems like this panel should just be removed from the page.
        $('#DocPagePnl').ajaxStart(function() {
            $(this).hide();
        }).ajaxStop(function() {
            $(this).hide();
        });
        
        //Step 8: Execute a drop on the tree.
        function pageactions() {
            
                document.getElementById("<%= HiddenTB_CIX.ClientID %>").value = dropco;

                if (dropaction == "dn" || dropsplitid=="133" || dropsplitid=="134") {
                    SendCallBack("dropDocNew," + droppartyid + "," + dropco + "," + dropsplitid + "," + dropname + "," + droppagesselected, "dropDoc");
                } else if (dropaction == "du" || dropaction == "ds") {
                    SendCallBack("dropDocExisting," + dropsplitid + "," + droppagesselected, "dropDoc");
                } else if (dropaction == "aa") {
                    confirmCall("dropAENew", "", "File Document as Signed")
                } else if (dropaction == "ae") {
                    var oWnd = $find("<%=DropExistingAERW.ClientID%>")
                    oWnd.show();
                } else if (dropaction == "as") {
                    confirmCall("dropAS","","Add Pages to FILED Document")
                } else if (dropaction == "f") {
                    document.getElementById("<%= HiddenTB_DocTreeParent.ClientID %>").value = dropsplitid;
                    var oWnd = $find("<%=ToFolderRW.ClientID%>")
                    oWnd.show();
                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ToFolderDocRG");
                } else {
                    //Warn
                }

        }

        //Step 9: wrap-up callback after drop.
        function dropDoc_back(arg) {

            var droprebind;
            var myString = arg;
            var mySplit = myString.split(",", 4);

            var success = mySplit[0] || "";
            var returnid = mySplit[1] || "";
            var nodeid = mySplit[2] || "";
            var sourcepages = mySplit[3] || "";
            var sourcenodeid = document.getElementById("HiddenTB_NodeIDLastClicked").value
            var docaction = success.substr(-2);
            
            if (success == "existing_ds") {
                var nodeid = document.getElementById("HiddenTB_NodeID").value;
                droprebind = "rebindDocRTV," + nodeid + "," + sourcenodeid + "," + sourcepages;
                if (sourcepages=="0") {
                    setvaluesforpages(docaction,returnid);
                }
            } else if (success == "reorder_ds") {
                droprebind = "rebindDocPageRLV"
            } else if (success == "new_ds") {
                droprebind = "rebindDocRTV," + nodeid + "," + sourcenodeid + "," + sourcepages;
                if (sourcepages=="0") {
                    setvaluesforpages(docaction,returnid);
                }
            } else if (success == "new_ae") {
                droprebind = "rebindDocRTV," + nodeid + "," + sourcenodeid + "," + sourcepages;
                if (sourcepages=="0") {
                    setvaluesforpages(docaction,returnid);
                }
            } else {

            }

            //Even though hidden fields are being set in afterNodeSearch, they DocID/ExecutionID needs to be set here.
             

            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest(droprebind);
            

        }


        function v_docdetails(arg) {

            var DocDetailsRB = $find("<%=DocDetailsRB.ClientID %>");
            var tocompletelbl = document.getElementById("<%= DocDetailsToCompleteLbl.ClientID %>");
            var completelbl = document.getElementById("<%= DocDetailsCompleteLbl.ClientID %>");

            if (arg == "Hide") {
                DocDetailsRB.set_visible(false);
                tocompletelbl.style.display = "none";
                completelbl.style.display = "none";
            } else {
                DocDetailsRB.set_visible(true);
                if (arg == "Complete") {
                    tocompletelbl.style.display = "none";
                    completelbl.style.display = "";
                } else {
                    tocompletelbl.style.display = "";
                    completelbl.style.display = "none";
                }
            }

        }

        function v_DocStuff(docaction) {

            var SummaryDiv = document.getElementById("SummaryDiv");
            var UploadSignDiv = document.getElementById("UploadSignDiv");
            var DocShowDiv = document.getElementById("DocShowDiv");
            var SignShowDiv = document.getElementById("SignShowDiv");
            var FolderDiv = document.getElementById("FolderDiv");
            var SliderDiv = document.getElementById("SliderDiv");

            if (docaction == "SummaryDiv") {
                SummaryDiv.style.display = "";
                UploadSignDiv.style.display = "none";
                DocShowDiv.style.display = "none";
                SliderDiv.style.display = "none";
                SignShowDiv.style.display = "none"
                FolderDiv.style.display = "none";
            } else if (docaction == "UploadSignDiv") {
                SummaryDiv.style.display = "none";
                UploadSignDiv.style.display = "";
                DocShowDiv.style.display = "none";
                SliderDiv.style.display = "none";
                SignShowDiv.style.display = "none"
                FolderDiv.style.display = "none";
            } else if (docaction == "DocShowDiv") {
                SummaryDiv.style.display = "none";
                UploadSignDiv.style.display = "none";
                DocShowDiv.style.display = "";
                SliderDiv.style.display = "";
                SignShowDiv.style.display = "none";
                FolderDiv.style.display = "none";
                $find("<%=DocPageRS.ClientID %>").repaint();
            } else if (docaction == "SignShowDiv") {
                SummaryDiv.style.display = "none";
                UploadSignDiv.style.display = "none";
                DocShowDiv.style.display = "none";
                SliderDiv.style.display = "none";
                SignShowDiv.style.display = "";
                FolderDiv.style.display = "none";
            } else if (docaction == "FolderDiv") {
                SummaryDiv.style.display = "none";
                UploadSignDiv.style.display = "none";
                DocShowDiv.style.display = "none";
                SliderDiv.style.display = "none";
                SignShowDiv.style.display = "none";
                FolderDiv.style.display = "";
            } else {
                SummaryDiv.style.display = "";
                UploadSignDiv.style.display = "none";
                DocShowDiv.style.display = "none";
                SliderDiv.style.display = "none";
                SignShowDiv.style.display = "none";
                FolderDiv.style.display = "none";
            }

        }

        function onDocRBClicked() {
        
            var docnodevalue = document.getElementById("<%= HiddenTB_NodeIDLastClicked.ClientID %>").value;
            var docnodetext = document.getElementById("<%= HiddenTB_NodeTextLastClicked.ClientID %>").value;
            SendCallBack("onDocRBClicked," + docnodevalue + ',' + docnodetext, "onDocRBClicked");

        }

        function onDocRBClick_Back(args) {

            var docaction = document.getElementById("<%= HiddenTB_DocAction.ClientID %>").value;

            if (docaction == "du" || docaction == "dn" || docaction == "ds") {
                OpenRadWindowDialogue(args);
            }

        }

        function docmouseover(sender) {

            var pageid = sender.id;
            document.getElementById("HiddenTB_PageID").value = pageid;
            if (itemdragging == false) {
                v_docdiv(sender, "");
            }

            var currentbackground = sender.style.background;
            var addordel;
            if (currentbackground == "rgb(217, 217, 217)") {
                sender.style.background = "rgb(102, 102, 102)";
            } else if (currentbackground == "rgb(0, 130, 204)") {
                sender.style.background = "rgb(102, 204, 255)";
            } else {
                sender.style.background = "rgb(217, 217, 217)";
            }
        }

        function docmouseout(sender) {

            v_docdiv(sender, "none");

            var currentbackground = sender.style.background;
            if (currentbackground == "rgb(102, 204, 255)") {
                sender.style.background = "rgb(0, 130, 204)";
            } else if (currentbackground == "rgb(0, 130, 204)") {
                sender.style.background = "rgb(0, 130, 204)";
            } else {
                sender.style.background = "rgb(217, 217, 217)";
            }
        }

        function v_docdiv(sender, displaytype) {

            var divindex = null;
            divindex = 0

            if (divindex != null) {
                sender.getElementsByTagName("div")[divindex].style.display = displaytype;
            }

        }

        function docclick(sender) {

            var currentbackground = sender.style.background;
            var addordel;
            if (currentbackground == "rgb(217, 217, 217)" || currentbackground == "rgb(102, 102, 102)") {
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
                if (pagesselected.indexOf(pageid) == -1) {
                    pagesselected = pagesselected + pageid + ","
                    pagesselectedcount = pagesselectedcount + 1
                }
            } else {
                pagesselected = pagesselected.replace(pageid + ",", "")
                pagesselectedcount = pagesselectedcount - 1
            }

            ctl_pagesselected.value = pagesselected;
            ctl_pagesselectedcount.value = pagesselectedcount;
        }


        var skipdocselection = false;

        function docselectionclear() {

            skipdocselection = true;
            document.getElementById("HiddenTB_PageID").value = "0"
            document.getElementById("HiddenTB_PagesSelected").value = ""
            document.getElementById("HiddenTB_PagesSelectedCount").value = "0"
            $find("<%=SelectAllRB.ClientID %>").set_selectedToggleStateIndex(1);
            skipdocselection = false;

        }

        function onDocPageRLVCreated() {

            docselectionclear();

        }


        function onAERWClicked(action) {
        
            var DropExistingAERW = $find("<%=DropExistingAERW.ClientID %>");
            DropExistingAERW.close();

            if ( action == "Replace") {
                SendCallBack("dropAEExisting," + dropco + "," + dropsplitid + ",No," + droppagesselected, "dropDoc");
            } else if (action=="Append") { 
                SendCallBack("dropAEExisting," + dropco + "," + dropsplitid + ",Yes," + droppagesselected, "dropDoc");
            }
        }

        function onToFolderRB(action) {
            
            if (action == "Existing") {

                var grid = $find("<%=ToFolderDocRG.ClientID %>");
                var MasterTable = grid.get_masterTableView();
                var selectedRows = MasterTable.get_selectedItems();
                var existingcount = 0;
                for (var i = 0; i < selectedRows.length; i++) {

                    var row = selectedRows[i];
                    var nodetext = row.getDataKeyValue("DocStatusWID");
                    
                    var ToFolderRW = $find("<%=ToFolderRW.ClientID %>");
                    ToFolderRW.close();
                        
                    var myString = nodetext;
                    var mySplit = myString.split(",", 6);

                    dropaction = mySplit[0] || "";
                    dropsplitid = mySplit[1] || "";
                    dropname = mySplit[2] || "";
                    droptype = mySplit[3] || "";
                    dropco = mySplit[4] || "";
                    dropkey = mySplit[5] || "";

                    pageactions();
                    existingcount = 1

                }

                if (existingcount == 0) {

                   launchRadAlert("<span style='color: #ff0000;'>WARNING:</span> To tie these pages to an EXISTING document, you must CLICK ON one of the existing documents above.","Document Not Selected")

                } 

            } else if (action=="New") {

                var nodetext = document.getElementById("<%= HiddenTB_NodeText.ClientID %>").value

                var myString = nodetext;
                var mySplit = myString.split(",", 6);

                dropaction = mySplit[0] || "";
                docparent = mySplit[1] || ""; //usually docsplitid.
                dropname = mySplit[2] || "";
                droptype = mySplit[3] || "";
                dropco = mySplit[4] || "";
                dropkey = mySplit[5] || "";

                var docname = $find("<%=ToFolderNameRTB.ClientID %>").get_textBoxValue();
                var docrequired = $find("<%=ToFolderDocReqRB.ClientID %>").get_selectedToggleStateIndex();
                var docdetails = $find("<%=ToFolderRecordDetailsRB.ClientID %>").get_selectedToggleStateIndex();
                var docprivate = $find("<%=ToFolderPrivateRB.ClientID %>").get_selectedToggleStateIndex();
                var newdocdetails = docparent + "<|>" + docname.replace(/,/g,"<||>") + "<|>" + docrequired + "<|>" + docdetails + "<|>" + docprivate

                SendCallBack("newDocToPages," + dropco + "," + droppagesselected + "," + newdocdetails, "dropDoc");

                var ToFolderRW = $find("<%=ToFolderRW.ClientID %>");
                ToFolderRW.close()

            }

        }

        function docmousedown(sender) {

            $("body").css("cursor", "progress");

        }

        function onDocDetailsRBClicked() {

            var DocDetailsRW = $find("<%=DocDetailsRW.ClientID%>");
            DocDetailsRW.show();
            var title = document.getElementById("HiddenTB_PageTitle").value;
            DocDetailsRW.set_title(title);

        }

        function numProps(obj) {

            var c = 0;
            for (var key in obj) {
                if (obj.hasOwnProperty(key))++c;
            }
            return c;

        }

        function onSelectAllRBClicked(sender) {

            if (skipdocselection==false) {
                var items = $find("<%=DocPageRLV.ClientID %>").get_clientDataKeyValue();
                var itemslength = numProps(items);
                var togglestateindex = sender.get_selectedToggleStateIndex();
                if (togglestateindex == 0) {
                    for (var i = 0; i < itemslength; i++) {

                        var myPageID = items[i]["PageID"];
                        docselection(myPageID, "add");
                        document.getElementById(myPageID).style.background = "rgb(0, 130, 204)";

                    }
                } else {

                    for (var i = 0; i < itemslength; i++) {

                        var myPageID = items[i]["PageID"];
                        docselection(myPageID, "del");
                        document.getElementById(myPageID).style.background = "rgb(217, 217, 217)";

                    }
                }
            }

        }

        function onCopySelectedRBClicked() {

            var PagesSelected = document.getElementById("HiddenTB_PagesSelected").value;
            if (PagesSelected != "") {
                PagesSelected = PagesSelected.replace(/,/g, "<|>");
                confirmCall("CopySelected", PagesSelected);
            } else {
                launchRadAlert("<span style='color: #ff0000;'>WARNING:</span> To proceed, you must select at least one page in this document.","Document Not Selected")
            }

        }

        function onDeleteAllRBClicked() {

            var PagesSelected = document.getElementById("HiddenTB_PagesSelected").value;
            if (PagesSelected != "") {
                PagesSelected = PagesSelected.replace(/,/g, "<|>");
                confirmCall("DeleteAllSelected", PagesSelected, "Delete Selected Page(s)");
            } else {
                launchRadAlert("<span style='color: #ff0000;'>WARNING:</span> To proceed, you must select at least one page in this document.","Document Not Selected")
            }

        }

        function onPrintRBClicking(sender,args) {
            var DocID = document.getElementById("HiddenTB_DocID").value;
            var NodeTextLastClicked = document.getElementById("HiddenTB_NodeTextLastClicked").value;
            var DocName = NodeTextLastClicked.split(",", 6)[2] || "";
            sender.set_navigateUrl("../AgreementExecution/PDFFull.aspx?Doc=" + DocID + "&DocName=" + DocName);
        }

        function onPrintAllRBClicking(sender,args) {
            var NodeTextLastClicked = document.getElementById("HiddenTB_NodeTextLastClicked").value;
            var mySplit = NodeTextLastClicked.split(",", 6);
            
            var SenderID = mySplit[4] || "";
            var RecipientID = document.getElementById("HiddenTB_PartyID").value;
            var MeID = document.getElementById("HiddenTB_MeID").value;
            var PruneID = mySplit[1] || "";

            sender.set_navigateUrl("../AgreementExecution/PDFFull.aspx?Doc=0&Sender=" + SenderID + "&Recipient=" + RecipientID + "&User=" + MeID + "&Prune=" + PruneID)
        }

        function set_DocDetailsValues() {

            var myDocID = document.getElementById("HiddenTB_DocID").value;
            SendCallBack("DocDetailsValues," + myDocID, "DocDetailsValues");

        }

        function set_DocDetailsValues_back(arg) {

            var myString = arg;
            var mySplit = myString.split("<|>", 7);

            var myDocNumber = mySplit[0] || "";
            var myIssued = mySplit[1] || "";
            var myExpires = mySplit[2] || "";
            var myNotOriginalIssue = mySplit[3] || "";
            var myEndorsements = mySplit[4] || "";
            var myDetails = mySplit[5] || "";
            var myMarkComplete = mySplit[6] || "";

            $find("<%=DocNumberRTB.ClientID %>").set_value(myDocNumber);
            $find("<%=IssuedRDP.ClientID %>").clear();
            if (myIssued != "1/1/0001") {
                $find("<%=IssuedRDP.ClientID %>").set_selectedDate(getDateFromString(myIssued));
            }
            $find("<%=ExpiresRDP.ClientID %>").clear();
            if (myExpires != "1/1/0001") {
                $find("<%=ExpiresRDP.ClientID %>").set_selectedDate(getDateFromString(myExpires));
            }
            if (myNotOriginalIssue == "true" || myNotOriginalIssue == "True") {
                $find("<%=NotOriginalIssueRB.ClientID %>").set_selectedToggleStateIndex(1);
            } else {
                $find("<%=NotOriginalIssueRB.ClientID %>").set_selectedToggleStateIndex(0);
            }
            $find("<%=EndorsementsRTB.ClientID %>").set_value(myEndorsements);
            $find("<%=DetailsRTB.ClientID %>").set_value(myDetails);
            if (myMarkComplete == "True") {
                $find("<%=CompleteLockRB.ClientID %>").set_selectedToggleStateIndex(1);
                set_disableDocDetails("Saved");
            } else {
                $find("<%=CompleteLockRB.ClientID %>").set_selectedToggleStateIndex(0);
                set_disableDocDetails("Edit");
            }
            v_LockLabels(myMarkComplete);

        }

        function getDateFromString(arg) {
            // str1 format should be dd/mm/yyyy.

            var myString = arg;
            var mySplit = myString.split("/", 3);

            var month = mySplit[0] || "";
            var day = mySplit[1] || "";
            var year = mySplit[2] || "";

            year = year.substring(0, 4)

            var datereturn

            if (year > 1900) {
                datereturn = new Date(year, month - 1, day);
            } else {
                datereturn = null
            }

            return datereturn;
        }

        function set_disableDocDetails(docdetailsstatus) {

            if (docdetailsstatus == "Saved") {
                $find("<%=DocNumberRTB.ClientID %>").disable();
                $find("<%=IssuedRDP.ClientID %>").set_enabled(false);
                $find("<%=ExpiresRDP.ClientID %>").set_enabled(false);
                $find("<%=NotOriginalIssueRB.ClientID %>").set_enabled(false);
                $find("<%=EndorsementsRTB.ClientID %>").disable();
                $find("<%=DetailsRTB.ClientID %>").disable();
            } else {
                $find("<%=DocNumberRTB.ClientID %>").enable();
                $find("<%=IssuedRDP.ClientID %>").set_enabled(true);
                $find("<%=ExpiresRDP.ClientID %>").set_enabled(true);
                $find("<%=NotOriginalIssueRB.ClientID %>").set_enabled(true);
                $find("<%=EndorsementsRTB.ClientID %>").enable();
                $find("<%=DetailsRTB.ClientID %>").enable();
            }
        }

        function onDocDetailsRWLoad() {

            set_DocDetailsValues();
            set_disableDocDetails("Edit");

        }

        function onDocDetailsCancelRBClicked() {

            $find("<%=DocDetailsRW.ClientID%>").close();
            set_disableDocDetails("Saved");
        }

        function v_LockLabels(togglestatus) {

            var lockedlbl = document.getElementById("DocDetailsRW_C_LockedLbl");
            var unlockedlbl = document.getElementById("DocDetailsRW_C_UnlockedLbl");

            if (togglestatus == "true" || togglestatus == "True") {
                unlockedlbl.style.display = "none";
                lockedlbl.style.display = "";
            } else {
                unlockedlbl.style.display = "";
                lockedlbl.style.display = "none";
            }

        }

        function onCompleteLockRBClicked(sender, args) {

            var toggleindex = sender.get_selectedToggleStateIndex();
            if (toggleindex == 1) {
                set_disableDocDetails("Saved");
                v_LockLabels("true");
                v_docdetails("Complete");
            } else {
                set_disableDocDetails("Edit");
                v_LockLabels("false");
                v_docdetails("To Complete");
            }

        }


        function requestDocs() {

            confirmCall("requestDocs", "", "Request Document(s)")

        }

        function requestDocs_AjaxBack(arg) {
        
            var oWnd = $find("<%=ProgressRW.ClientID%>")
            oWnd.close();

            var leftStr = String(arg).substring(0, 4)

            if (leftStr != "WARN") {
                OpenRadWindowDialogue(arg);
            } else {
                launchRadAlert(arg, "WARNING: Problem Requesting Checked Docs");
            }

        }


        function onRTVNodeChecked(sender, eventArgs) {
            var childNodes = eventArgs.get_node().get_nodes();
            var isChecked = eventArgs.get_node().get_checked();
            updateRTVChildren(childNodes, isChecked);
        }

        function updateRTVChildren(nodes, checked) {
            var i;
            var test;
            for (i = 0; i < nodes.get_count(); i++) {
                if (checked) {
                    nodes.getNode(i).check();
                } else {
                    nodes.getNode(i).set_checked(false);
                }

                if (nodes.getNode(i).get_nodes().get_count() > 0) {
                    UpdateChildren(nodes.getNode(i).get_nodes(), checked);
                }
            }
        }


        function onSignOnlineRBClicked() {

            var executionid = document.getElementById("HiddenTB_ExecutionID").value;
            SendCallBack("onSignOnlineRBClicked," + executionid, "onSignOnlineRBClicked");

        }


        function onPartiesRDDLItemSelected(sender, args) {
    
            var item = args.get_item();
            var partyid = item.get_value();            
            document.getElementById("<%= HiddenTB_ParentPartyID.ClientID %>").value = partyid;
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindDocRTV");

        }


        function onCarrierSearch(sender, eventArgs) {

            var searchid = eventArgs.get_value();

            if (searchid == null || searchid == "") {
                searchid = "0"
            }

            document.getElementById("<%= HiddenTB_ParentPartyID.ClientID %>").value = searchid;

            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindDocRTV");

        }

        function onCarrierSearchButtonCommand(sender, args) {

            var searchid = document.getElementById("<%= HiddenTB_ParentPartyID.ClientID %>").value;
            var commandname = args.get_commandName();

            SendCallBack(commandname + "," + searchid, "CarrierAddEdit");

        }

        function onCarrierSearchButtonCommand_back(args) {

            OpenRadWindowDialogue(args);

        }

        ///////////////////////////////////////
        //To re-intigrate
        //////////////////////////////////////


        function OpenRadWindowDialogue(myURL) {
            var oWnd = $find("<%=RadWindowDialogue.ClientID%>")
            oWnd.setUrl(myURL);
            oWnd.show();
        }


        function onRWLoaded(oWnd, type, height, width, title) {


            if (type == "percent") {

                height = Number(document.getElementById("HiddenTB_WindowHeight").value);
                width = Number(document.getElementById("HiddenTB_WindowWidth").value);
                height = height * .96
                width = width * .96

            }

            oWnd.set_height(height);
            oWnd.set_width(width);
            oWnd.set_title(title);
            oWnd.center()

        }

        function openSignRW(arg) {

            var oWnd = $find("<%=SignRW.ClientID%>")
            oWnd.setUrl(arg);
            oWnd.show();

        }

        function onDocPageRSValueChanged(sender, args) {
            var slidervalue = sender.get_value()
            document.getElementById("HiddenTB_SliderValue").value = slidervalue;
        }

        function SendCallBack(arg, myAction) {

            try {
                switch (myAction) {
                case "onDocRBClicked":
                    { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onDocRBClick_Back", "null") %>
                        break;
                    }
                case "DocDetailsValues":
                    { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "set_DocDetailsValues_back", "null") %>
                        break;
                    }
                case "onSignOnlineRBClicked":
                    { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "openSignRW", "null") %>
                        break;
                    }
                case "docdetails":
                    { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "docdetails_back", "null") %>
                        break;
                    }
                case "CarrierAddEdit":
                    { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onCarrierSearchButtonCommand_back", "null") %>
                        break;
                    }
                case "dropDoc":
                    { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "dropDoc_back", "null") %>
                        break;
                    }
                }
            } catch (e) {}
        }

        function ParentCloseAndRedirect(arg) {

            var myString = arg;
            var mySplit = myString.split(",", 3);

            var myArg = mySplit[0] || "";
            var myID = mySplit[1] || "";
            var mycompletestatus = mySplit[2] || "";

            if (myArg == "rebindDocRTV") {
                
                v_DocStuff("DocShowDiv");
                v_docdetails(mycompletestatus);

                document.getElementById("<%= HiddenTB_DocID.ClientID %>").value = myID;
                var nodeid = myID
                if (myID != "133" && myID != "134") {
                    nodeid = "-" + myID + "888"
                    var docco = document.getElementById("<%= HiddenTB_CIX.ClientID %>").value
                    if (docco && docco!="0") {
                        nodeid = nodeid + docco + "333";
                    }
                    arg = arg.replace(myID, nodeid)
                }
                document.getElementById("<%= HiddenTB_NodeID.ClientID %>").value = nodeid;
            };

            if (!arg) {
                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Close");
            } else {
                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest(arg);
            }
        }


        function OpenRadWindow(myURL) {
            var oWnd = $find("<%=RadWindow1.ClientID%>")
            oWnd.setUrl(myURL);
            oWnd.show();
        }

        //**********************
        //Rad alert functions
        //**********************

        //Info: global variables.  confirmType tells what you are doing like 'deleteExp'  confirmID holds the record that you are going to manipulate.
        var confirmType;
        var confirmID;

        //Step 1:  Call this funtion from JS.

        function confirmCall(callType, callID, callName) {
            confirmType = callType;
            confirmID = callID;
            var confirmMess;
            var confirmTitle;

            //Step 2:  Configure your messsage types here.
            if (callType == "DocPageDel") {

                confirmMess = "Are you certain that you wish to <span style='color: #ff0000;'>permanently</span> delete this page?";
                confirmTitle = "Delete " & callName & " ?";
                launchRadConfirm(confirmMess, confirmTitle);

            } else if (callType == "DeleteAllSelected") {

                confirmMess = "Are you certain that you wish to <span style='color: #ff0000;'>permanently</span> delete the selected page(s)?";
                confirmTitle = "Delete " & callName & " ?";
                launchRadConfirm(confirmMess, confirmTitle);

            } else if (callType == "CopySelected") {

                confirmMess = "Are you certain that you wish to <span style='color: #ff0000;'>copy</span> the selected page(s)?";
                confirmTitle = "Copy" & callName & " ?";
                launchRadConfirm(confirmMess, confirmTitle);

            } else if (callType == "requestDocs") {

                confirmMess = "Are you certain that you want to request all of the documents checked below?";
                confirmTitle = callName & "?"
                launchRadConfirm(confirmMess, confirmTitle);

            } else if (callType == "dropAENew") {

                confirmMess = "<span style='color: #ff0000;'>IMPORTANT:</span> Click 'Okay' to file this document as SIGNED and SEND a copy of the signed copy to the other party.  CLICK 'Cancel' if you need to review or change the document before filing as signed."
                confirmTitle = callName & "?"
                launchRadConfirm(confirmMess, confirmTitle);

            } else if (callType == "dropAS") {
            
                confirmMess = "<span style='color: #ff0000;'>IMPORTANT:</span> Click 'Okay' to add these pages to this fully-executed document (Please note: to ensure documents are not tampered with, you cannot delete or replace pages in a fully-executed document. You can only add pages.)"
                confirmTitle = callName & "?"
                launchRadConfirm(confirmMess, confirmTitle);

            }
        }

        //Info:  Needed to get the parent window when calling alerts from a child RadWindow.

        function GetRadWindow() {
            var oWindow = null;
            if (window.radWindow) oWindow = window.radWindow;
            else if (window.frameElement && window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
            return oWindow;
        }


        //Info:  Function to launch the RadConfirm.

        function launchRadConfirm(confirmMess, confirmTitle) {

            var oWnd = GetRadWindow();
            if (oWnd != null) {
                setTimeout(function () {
                    GetRadWindow().BrowserWindow.radconfirm(confirmMess, confirmCallBackFn, 400, 115, null, confirmTitle, "/Images/Custom/DeleteLowRes.png");
                }, 0);
            }
            //Info: Used to launch from a parent page.
            else {
                radconfirm(confirmMess, confirmCallBackFn, 400, 115, null, confirmTitle, "/Images/Custom/DeleteLowRes.png");
            }

        }

        //Info:  Function that the RadConfirm calls back to process the users response.

        function confirmCallBackFn(arg) {

            //Step 3:  Config different callbacks if required.  If you have only 2 parameters, these will do.
            if (arg == true) {

                if (confirmType == "DocPageDel" || confirmType == "DeleteAllSelected") {

                    var nodetext = document.getElementById("HiddenTB_NodeTextLastClicked").value;
                    var myString = nodetext;
                    var mySplit = myString.split(",", 5);
                    dropco = mySplit[4] || "";

                    var sendArg = confirmType + "," + confirmID + "," + dropco; 
                    <%= Page.ClientScript.GetCallbackEventReference(Me, "sendArg", "FinishAlert", "null") %>

                } else if (confirmType == "CopySelected") {

                    //$find("<%= RadAjaxManager1.ClientID %>").ajaxRequest(confirmType + "," + confirmID);
                    var sendArg = confirmType + "," + confirmID; 
                    <%= Page.ClientScript.GetCallbackEventReference(Me, "sendArg", "FinishAlert", "null") %>

                } else if (confirmType == "requestDocs") {

                    var oWnd = $find("<%=ProgressRW.ClientID%>")
                    oWnd.show();
                    getRadProgressManager().startProgressPolling();
                    
                    var sendArg = confirmType;
                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest(sendArg);
                    

                } else if (confirmType == "dropAENew") {

                    SendCallBack("dropAENew," + droppartyid + "," + dropco + "," + dropsplitid + "," + dropname + "," + droppagesselected, "dropDoc");

                } else if (confirmType == "dropAS") {

                    SendCallBack("dropAEExisting," + dropco + "," + dropsplitid + ",Yes," + droppagesselected, "dropDoc");

                }
            }

        }

        //Info

        function launchRadAlert(alertMess, alertTitle) {

            var oWnd = GetRadWindow();
            if (oWnd != null) {
                setTimeout(function () {
                    GetRadWindow().BrowserWindow.radalert(alertMess, 400, 115, alertTitle, null, "/Images/Custom/OkayLowRes.png");
                }, 0);
            }
            //Info: Used to launch from a parent page.
            else {
                radalert(alertMess, 400, 115, alertTitle, null, "/Images/Custom/OkayLowRes.png");
            }

        }


        function FinishAlert(arg) {

            var myString = arg;
            var mySplit = myString.split("<|>", 3);

            var returnaction = mySplit[0] || "";
            var returnid = mySplit[1] || "";
            var returncount = mySplit[2] || "";

            //Step 5:  Launch alert if there is a problem with the procedure called by the launchRadConfirm function.
             
            if (returnaction == "DocPageDel" || returnaction == "DeleteAllSelected" || "CopySelected") {
                
                //Here for Hidden fields.

                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindDocRTV," + returnid);
                if (returnid=="0") {
                    v_DocStuff("SummaryDiv");
                }

            } else if (returnaction != "Nothing") {

                var messTitle;
                var mess;

                launchRadAlert(mess, messTitle);

            }

        }

        //**********************
        //END:  Rad alert functions
        //**********************
        </script>
    </telerik:RadCodeBlock>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ToFolderDocRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="DocRadTreeView" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="DocPageRLV" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="DocDetailsEditRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="DocNumberRTB" />
                    <telerik:AjaxUpdatedControl ControlID="IssuedRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ExpiresRDP" />
                    <telerik:AjaxUpdatedControl ControlID="EndorsementsRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="DetailsRTB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="CompleteLockRB" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="DocRadTreeView" LoadingPanelID="RadAjaxLoadingPanel1"
                        UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RequestCheckedDocsRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RequestCheckedDocsRB" />
                    <telerik:AjaxUpdatedControl ControlID="DocRadTreeView" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="DocRadTreeView">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_ExecutionID" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_FlowStepEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_RowOwnerCIXEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_RowOIXEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="DocPageRLV" />
                    <telerik:AjaxUpdatedControl ControlID="Next1Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next2Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next3Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next4Button" />
                    <telerik:AjaxUpdatedControl ControlID="RewindButton" />
                    <telerik:AjaxUpdatedControl ControlID="NoDocsDiv" />
                    <telerik:AjaxUpdatedControl ControlID="SignedOnLbl" />
                    <telerik:AjaxUpdatedControl ControlID="SignedOnRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ExpiresOnLbl" />
                    <telerik:AjaxUpdatedControl ControlID="ExpiresOnRDP" />
                    <telerik:AjaxUpdatedControl ControlID="InstructionsLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="InstructionsLiteral1" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="InitialsTable" />
                    <telerik:AjaxUpdatedControl ControlID="UploadTemplateButton" />
                    <telerik:AjaxUpdatedControl ControlID="UploadPDFButton" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Next1Button">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_ExecutionID" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_FlowStepEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_RowOwnerCIXEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_RowOIXEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="DocPageRLV" />
                    <telerik:AjaxUpdatedControl ControlID="Next1Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next2Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next3Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next4Button" />
                    <telerik:AjaxUpdatedControl ControlID="RewindButton" />
                    <telerik:AjaxUpdatedControl ControlID="NoDocsDiv" />
                    <telerik:AjaxUpdatedControl ControlID="SignedOnLbl" />
                    <telerik:AjaxUpdatedControl ControlID="SignedOnRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ExpiresOnLbl" />
                    <telerik:AjaxUpdatedControl ControlID="ExpiresOnRDP" />
                    <telerik:AjaxUpdatedControl ControlID="InstructionsLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="InstructionsLiteral1" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="InitialsTable" />
                    <telerik:AjaxUpdatedControl ControlID="UploadTemplateButton" />
                    <telerik:AjaxUpdatedControl ControlID="UploadPDFButton" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Next2Button">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_ExecutionID" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_FlowStepEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_RowOwnerCIXEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_RowOIXEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="DocPageRLV" />
                    <telerik:AjaxUpdatedControl ControlID="Next1Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next2Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next3Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next4Button" />
                    <telerik:AjaxUpdatedControl ControlID="RewindButton" />
                    <telerik:AjaxUpdatedControl ControlID="NoDocsDiv" />
                    <telerik:AjaxUpdatedControl ControlID="SignedOnLbl" />
                    <telerik:AjaxUpdatedControl ControlID="SignedOnRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ExpiresOnLbl" />
                    <telerik:AjaxUpdatedControl ControlID="ExpiresOnRDP" />
                    <telerik:AjaxUpdatedControl ControlID="InstructionsLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="InstructionsLiteral1" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="InitialsTable" />
                    <telerik:AjaxUpdatedControl ControlID="UploadTemplateButton" />
                    <telerik:AjaxUpdatedControl ControlID="UploadPDFButton" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Next3Button">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_ExecutionID" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_FlowStepEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_RowOwnerCIXEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_RowOIXEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="DocPageRLV" />
                    <telerik:AjaxUpdatedControl ControlID="Next1Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next2Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next3Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next4Button" />
                    <telerik:AjaxUpdatedControl ControlID="RewindButton" />
                    <telerik:AjaxUpdatedControl ControlID="NoDocsDiv" />
                    <telerik:AjaxUpdatedControl ControlID="SignedOnLbl" />
                    <telerik:AjaxUpdatedControl ControlID="SignedOnRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ExpiresOnLbl" />
                    <telerik:AjaxUpdatedControl ControlID="ExpiresOnRDP" />
                    <telerik:AjaxUpdatedControl ControlID="InstructionsLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="InstructionsLiteral1" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="InitialsTable" />
                    <telerik:AjaxUpdatedControl ControlID="UploadTemplateButton" />
                    <telerik:AjaxUpdatedControl ControlID="UploadPDFButton" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Next4Button">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_ExecutionID" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_FlowStepEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_RowOwnerCIXEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_RowOIXEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="DocPageRLV" />
                    <telerik:AjaxUpdatedControl ControlID="Next1Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next2Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next3Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next4Button" />
                    <telerik:AjaxUpdatedControl ControlID="RewindButton" />
                    <telerik:AjaxUpdatedControl ControlID="NoDocsDiv" />
                    <telerik:AjaxUpdatedControl ControlID="SignedOnLbl" />
                    <telerik:AjaxUpdatedControl ControlID="SignedOnRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ExpiresOnLbl" />
                    <telerik:AjaxUpdatedControl ControlID="ExpiresOnRDP" />
                    <telerik:AjaxUpdatedControl ControlID="InstructionsLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="InstructionsLiteral1" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="InitialsTable" />
                    <telerik:AjaxUpdatedControl ControlID="UploadTemplateButton" />
                    <telerik:AjaxUpdatedControl ControlID="UploadPDFButton" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RewindButton">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_ExecutionID" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_FlowStepEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_RowOwnerCIXEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_RowOIXEncrypt" />
                    <telerik:AjaxUpdatedControl ControlID="DocPageRLV" />
                    <telerik:AjaxUpdatedControl ControlID="Next1Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next2Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next3Button" />
                    <telerik:AjaxUpdatedControl ControlID="Next4Button" />
                    <telerik:AjaxUpdatedControl ControlID="RewindButton" />
                    <telerik:AjaxUpdatedControl ControlID="NoDocsDiv" />
                    <telerik:AjaxUpdatedControl ControlID="SignedOnLbl" />
                    <telerik:AjaxUpdatedControl ControlID="SignedOnRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ExpiresOnLbl" />
                    <telerik:AjaxUpdatedControl ControlID="ExpiresOnRDP" />
                    <telerik:AjaxUpdatedControl ControlID="InstructionsLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="InstructionsLiteral1" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FirstItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SecondItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ThirdItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FourthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FifthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SixthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="SeventhItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="EighthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="NinthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="TenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="EleventhItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="TwelfthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="ThirteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FourteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemLiteral" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRTB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRCB" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRDP" />
                    <telerik:AjaxUpdatedControl ControlID="FifteenthItemRE" />
                    <telerik:AjaxUpdatedControl ControlID="InitialsTable" />
                    <telerik:AjaxUpdatedControl ControlID="UploadTemplateButton" />
                    <telerik:AjaxUpdatedControl ControlID="UploadPDFButton" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="DocDetailsRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="DocDetailsRB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="DocPageRS">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="DocPageRS" />
                    <telerik:AjaxUpdatedControl ControlID="DocPagePnl" LoadingPanelID="RadAjaxLoadingPanel1"
                        UpdatePanelHeight="100%" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Rotate90RB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Rotate90RB" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_PagesSelected" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_PagesSelectedCount" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="DocPagePnl" LoadingPanelID="RadAjaxLoadingPanel1"
                        UpdatePanelHeight="100%" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Rotate180RB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Rotate180RB" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_PagesSelected" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_PagesSelectedCount" />
                    <telerik:AjaxUpdatedControl ControlID="Rotate180RB" />
                    <telerik:AjaxUpdatedControl ControlID="DocPagePnl" LoadingPanelID="RadAjaxLoadingPanel1"
                        UpdatePanelCssClass="" UpdatePanelHeight="100%" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ShowDataRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="DocPageRLV" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="ShowDataRB" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ShowSigRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="DocPageRLV" />
                    <telerik:AjaxUpdatedControl ControlID="ShowSigRB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="BlackMetroTouch">
    </telerik:RadAjaxLoadingPanel>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Modal="True" ShowContentDuringLoad="False"
        VisibleStatusbar="False" VisibleTitlebar="True" Behaviors="Close,Move,Resize"
        Skin="BlackMetroTouch">
        <Windows>
            <telerik:RadWindow ID="RadWindow1" runat="server" Height="600" Modal="True" Width="800"
                VisibleStatusbar="False" VisibleTitlebar="True" CssClass="CustomRW" Behaviors="Close, Move">
            </telerik:RadWindow>
            <telerik:RadWindow ID="RadWindowDialogue" runat="server" Modal="True" VisibleStatusbar="False"
                VisibleTitlebar="True" CssClass="CustomRW">
            </telerik:RadWindow>
            <telerik:RadWindow ID="SignRW" runat="server" Modal="True" VisibleStatusbar="False"
                VisibleTitlebar="True">
            </telerik:RadWindow>
            <telerik:RadWindow ID="ProgressRW" runat="server" Modal="True" Width="450" Height="245"
                VisibleStatusbar="False" VisibleTitlebar="False" CssClass="CustomRW">
                <ContentTemplate>
                    <div style="padding-top: 5px">
                        <telerik:RadProgressArea ID="RadProgressArea1" runat="server" Skin="BlackMetroTouch" />
                    </div>
                </ContentTemplate>
            </telerik:RadWindow>
            <telerik:RadWindow ID="DropExistingAERW" runat="server" VisibleStatusbar="false"
                Width="620px" Height="265px" VisibleTitlebar="true" Title="Dropping Pages onto Document">
                <ContentTemplate>
                    <div style="padding: 15px; background: white; color: Black;">
                        <table>
                            <tr>
                                <td colspan="3" class="dfv">
                                    <span style='color: #ff0000;'>IMPORTANT:</span> You are dropping these pages onto
                                    an existing document. Please select the correction action below:
                                </td>
                            </tr>
                            <tr>
                                <td class="dfv">
                                    CLICK below to entirely REPLACE the existing document with these pages. This is
                                    the best option when EACH page is entirely filled-out and signed by you.
                                </td>
                                <td style="width: 50px; vertical-align: middle; text-align: center; font-size: 15px"
                                    class="fls">
                                    <strong>- OR -</strong>
                                </td>
                                <td class="dfv">
                                    CLICK below to ADD THE DRAGGED PAGES to the END of this document. This option is
                                    best when you want to ADD signature pages to the end of a document.
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div style="padding: 5px">
                        <table style="width: 100%; height: 35px;">
                            <tr>
                                <td style="width: 50%">
                                    <center>
                                        <telerik:RadButton ID="ReplaceAERB" runat="server" AutoPostBack="false" Text="REPLACE Existing Pages"
                                            ToolTip="CLICK to REPLACE all existing pages for this document." OnClientClicked="function (button,args){onAERWClicked('Replace');}">
                                        </telerik:RadButton>
                                    </center>
                                </td>
                                <td style="width: 50%">
                                    <center>
                                        <telerik:RadButton ID="AppendAERB" runat="server" AutoPostBack="false" Text="ADD Existing Pages"
                                            ToolTip="CLICK to ADD pages to the END of this document." OnClientClicked="function (button,args){onAERWClicked('Append');}">
                                        </telerik:RadButton>
                                    </center>
                                </td>
                            </tr>
                        </table>
                    </div>
                </ContentTemplate>
            </telerik:RadWindow>
            <telerik:RadWindow ID="ToFolderRW" runat="server" VisibleStatusbar="false" Width="755px"
                Height="600px" VisibleTitlebar="true" Title="Dropping on Folder">
                <ContentTemplate>
                    <div style="padding: 18px; background: white; color: Black;">
                        <table>
                            <tr>
                                <td colspan="3" class="dfv">
                                    <span style='color: #ff0000;'>IMPORTANT:</span> You are dropping these pages into
                                    a FOLDER. Please select the correction action below:
                                </td>
                            </tr>
                            <tr>
                                <td class="dfv">
                                    If this document is <strong>SHOWN</strong> on the list below, please <strong>SELECT
                                        IT</strong> and then CLICK "File as EXISTING" button.<br />
                                </td>
                                <td rowspan="2" style="width: 100px; vertical-align: middle; text-align: center;
                                    font-size: 18px" class="fls">
                                    <strong>- OR -</strong>
                                </td>
                                <td colspan="2" class="dfv">
                                    If this document does <strong>NOT</strong> exist on the list to the <strong>LEFT</strong>,
                                    you may file it as a new document by (1) choosing it's type from the list below
                                    or (2) creating a entirely NEW type. Do (1) or (2) the click "File as NEW" button.<br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <telerik:RadGrid ID="ToFolderDocRG" runat="server" AutoGenerateColumns="False" CellSpacing="0"
                                        DataSourceID="ToFolderDocDS" GridLines="None" ShowHeader="False" Width="300px">
                                        <ClientSettings EnableRowHoverStyle="True">
                                            <Selecting AllowRowSelect="True"></Selecting>
                                            <Scrolling AllowScroll="True" UseStaticHeaders="True" ScrollHeight="325px"></Scrolling>
                                        </ClientSettings>
                                        <MasterTableView ClientDataKeyNames="DocTreeID,DocStatusWID" DataKeyNames="DocTreeID,DocStatusWID"
                                            DataSourceID="ToFolderDocDS" Name="ToFolderDocRG">
                                            <NoRecordsTemplate>
                                                <div style="padding: 15px;">
                                                    No documents in this Folder.
                                                </div>
                                            </NoRecordsTemplate>
                                            <Columns>
                                                <telerik:GridBoundColumn DataField="DocNodeHTML" HeaderStyle-Width="150px" UniqueName="DocNodeHTML"
                                                    FilterControlAltText="Filter column column">
                                                </telerik:GridBoundColumn>
                                            </Columns>
                                        </MasterTableView>
                                    </telerik:RadGrid>
                                    <asp:SqlDataSource ID="ToFolderDocDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                        SelectCommand="usp_DocTree_PruneDocs" SelectCommandType="StoredProcedure">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="HiddenTB_CIX" Name="SenderID" PropertyName="Text"
                                                DefaultValue="0" Type="Int32" />
                                            <asp:ControlParameter ControlID="HiddenTB_PartyID" PropertyName="Text" Type="String"
                                                Name="RecipientID" />
                                            <asp:ControlParameter ControlID="HiddenTB_MeID" PropertyName="Text" Type="String"
                                                Name="MeID" />
                                            <asp:ControlParameter ControlID="HiddenTB_DocTreeParent" Name="PruneID" PropertyName="Text"
                                                DefaultValue="0" Type="Int32" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                </td>
                                <td style="vertical-align: top; border-top: 1px solid gray">
                                    <table>
                                        <tr>
                                            <td class="fls">
                                                Name Doc
                                            </td>
                                            <td>
                                                <telerik:RadTextBox ID="ToFolderNameRTB" runat="server" Width="125">
                                                </telerik:RadTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls">
                                                Make Required
                                            </td>
                                            <td>
                                                <telerik:RadButton ID="ToFolderDocReqRB" runat="server" ToggleType="CheckBox" ButtonType="LinkButton"
                                                    AutoPostBack="false" BorderWidth="0px" BackColor="White">
                                                    <ToggleStates>
                                                        <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Value="2511">
                                                        </telerik:RadButtonToggleState>
                                                        <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked" Selected="true"
                                                            Value="2315"></telerik:RadButtonToggleState>
                                                    </ToggleStates>
                                                </telerik:RadButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls">
                                                Record Details
                                            </td>
                                            <td>
                                                <telerik:RadButton ID="ToFolderRecordDetailsRB" runat="server" ToggleType="CheckBox"
                                                    ButtonType="LinkButton" AutoPostBack="false" BorderWidth="0px" BackColor="White">
                                                    <ToggleStates>
                                                        <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Value="1"></telerik:RadButtonToggleState>
                                                        <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked" Value="0"
                                                            Selected="true"></telerik:RadButtonToggleState>
                                                    </ToggleStates>
                                                </telerik:RadButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls">
                                                Make Private
                                            </td>
                                            <td>
                                                <telerik:RadButton ID="ToFolderPrivateRB" runat="server" ToggleType="CheckBox" ButtonType="LinkButton"
                                                    AutoPostBack="false" BorderWidth="0px" BackColor="White">
                                                    <ToggleStates>
                                                        <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Value="1"></telerik:RadButtonToggleState>
                                                        <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked" Value="0"
                                                            Selected="true"></telerik:RadButtonToggleState>
                                                    </ToggleStates>
                                                </telerik:RadButton>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    &nbsp;
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div style="padding: 10px">
                        <table style="width: 100%; height: 35px;">
                            <tr>
                                <td style="width: 50%">
                                    <center>
                                        <telerik:RadButton ID="ToFolderExistingRB" runat="server" AutoPostBack="false" Text="File as EXISTING"
                                            ToolTip="CLICK to file these pages as an EXISTING document type." OnClientClicked="function (button,args){onToFolderRB('Existing');}">
                                        </telerik:RadButton>
                                    </center>
                                </td>
                                <td style="width: 50%">
                                    <center>
                                        <telerik:RadButton ID="ToFolderNewRB" runat="server" AutoPostBack="false" Text="File as NEW"
                                            ToolTip="CLICK to file these pages as a NEW document type." OnClientClicked="function (button,args){onToFolderRB('New');}">
                                        </telerik:RadButton>
                                    </center>
                                </td>
                            </tr>
                        </table>
                    </div>
                </ContentTemplate>
            </telerik:RadWindow>
            <telerik:RadWindow ID="DocDetailsRW" runat="server" VisibleStatusbar="false" Width="620px"
                Height="220px" OnClientShow="onDocDetailsRWLoad" VisibleTitlebar="true">
                <ContentTemplate>
                    <div id="DocDetailsContentDiv" style="background-color: White; overflow: hidden">
                        <div>
                            <table style="float: left">
                                <col width="120px" />
                                <col width="150px" />
                                <tr>
                                    <td class="fls">
                                        <asp:Label ID="DocNumberLbl" runat="server" Text="Doc Number"></asp:Label>
                                    </td>
                                    <td class="dfv">
                                        <telerik:RadTextBox ID="DocNumberRTB" runat="server" Text="">
                                        </telerik:RadTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        <asp:Label ID="IssuedLbl" runat="server" Text="Issued"></asp:Label>
                                    </td>
                                    <td class="dfv">
                                        <telerik:RadDatePicker ID="IssuedRDP" runat="server">
                                        </telerik:RadDatePicker>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        <asp:Label ID="ExpiresLbl" runat="server" Text="Expires"></asp:Label>
                                    </td>
                                    <td class="dfv">
                                        <telerik:RadDatePicker ID="ExpiresRDP" runat="server">
                                        </telerik:RadDatePicker>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div>
                            <table style="float: left">
                                <col width="120px" />
                                <col width="150px" />
                                <tr>
                                    <td class="fls">
                                        <asp:Label ID="NotOriginalIssueLbl" runat="server" Text="Not Original Issue"></asp:Label>
                                    </td>
                                    <td class="dfv">
                                        <telerik:RadButton ID="NotOriginalIssueRB" runat="server" ToggleType="CheckBox" ButtonType="LinkButton"
                                            AutoPostBack="false" BorderWidth="0px" BackColor="White">
                                            <ToggleStates>
                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Value="False">
                                                </telerik:RadButtonToggleState>
                                                <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked" Value="true">
                                                </telerik:RadButtonToggleState>
                                            </ToggleStates>
                                        </telerik:RadButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        <asp:Label ID="EndorsementsLbl" runat="server" Text="Endorsements"></asp:Label>
                                    </td>
                                    <td class="dfv">
                                        <telerik:RadTextBox ID="EndorsementsRTB" runat="server">
                                        </telerik:RadTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        <asp:Label ID="DetailsLbl" runat="server" Text="Details"></asp:Label>
                                    </td>
                                    <td class="dfv">
                                        <telerik:RadTextBox ID="DetailsRTB" runat="server" TextMode="MultiLine">
                                        </telerik:RadTextBox>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <table style="width: 100%; float: right">
                        <tr>
                            <td style="height: 30px">
                                <telerik:RadButton ID="DocDetailsEditRB" runat="server" Text="Save" Font-Size="12px"
                                    Style="text-align: center; vertical-align: middle;">
                                </telerik:RadButton>
                                <telerik:RadButton ID="DocDetailsCancelRB" runat="server" Text="Cancel" Font-Size="12px"
                                    AutoPostBack="false" OnClientClicked="onDocDetailsCancelRBClicked" Style="text-align: center;
                                    vertical-align: middle">
                                </telerik:RadButton>
                            </td>
                            <td width="330px" style="text-align: right; color: White; vertical-align: middle;
                                padding-top: 12px;">
                                <asp:Label ID="UnlockedLbl" runat="server" Text="Click to LOCK >>>" Style="display: none"></asp:Label>
                                <asp:Label ID="LockedLbl" runat="server" Text="Click to UNlock >>>" Style="display: none"></asp:Label>
                            </td>
                            <td width="45px">
                                <telerik:RadButton ID="CompleteLockRB" runat="server" ButtonType="ToggleButton" ToggleType="CustomToggle"
                                    Height="35px" Width="35px" AutoPostBack="false" OnClientClicked="onCompleteLockRBClicked">
                                    <ToggleStates>
                                        <telerik:RadButtonToggleState ImageUrl="/Images/Custom/un_lock.png" HoveredImageUrl="/Images/Custom/un_lock_glow.png"
                                            Text="" Selected="true" Value="False"></telerik:RadButtonToggleState>
                                        <telerik:RadButtonToggleState ImageUrl="/Images/Custom/lock.png" Text="" HoveredImageUrl="/Images/Custom/lock_glow.png"
                                            Value="True"></telerik:RadButtonToggleState>
                                    </ToggleStates>
                                </telerik:RadButton>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
    <telerik:RadProgressManager ID="RadProgressManager1" runat="server" />
    <telerik:RadToolTip ID="DragDropRTT" runat="server" HideEvent="FromCode" ShowCallout="true"
        Skin="BlackMetroTouch" Width="350px" Position="TopCenter" Text="">
    </telerik:RadToolTip>
    <telerik:RadTabStrip ID="FastportRTS" runat="server" SelectedIndex="0" Skin="BlackMetroTouch"
        Align="Justify" Width="100%">
    </telerik:RadTabStrip>
    <div id="DocDiv">
        <telerik:RadSplitter ID="DocRS" runat="server" Height="100%" Width="100%" Orientation="Vertical"
            Skin="BlackMetroTouch">
            <telerik:RadPane ID="DocTreeRP" runat="server" Width="320" MinWidth="150" MaxWidth="650">
                <table>
                    <tbody>
                        <tr id="CoRow" runat="server">
                            <td class="fls">
                                <asp:Label runat="server" Text="File Cabinet"></asp:Label>
                            </td>
                            <td>
                                <telerik:RadDropDownList ID="PartiesRDDL" runat="server" DataSourceID="PartiesDS" DataTextField="CarrierName"
                                    DataValueField="PartyID" Width="175px" ShowToggleImage="True"
                                    OnClientItemSelected="onPartiesRDDLItemSelected">
                                </telerik:RadDropDownList>
                                <asp:SqlDataSource ID="PartiesDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                    SelectCommand="usp_Doc_FilingCabinets" SelectCommandType="StoredProcedure">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="HiddenTB_PartyID" PropertyName="Text" Type="String"
                                            Name="TruckerID" />
                                        <asp:SessionParameter Name="MeID" SessionField="PartyID" Type="Int32" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                                <telerik:RadSearchBox runat="server" ID="PickCarrierRSB" DataSourceID="CarrierRSB_DS"
                                    DataValueField="PartyID" DataTextField="CarrierFullName" EmptyMessage="Part of Name, MC, or DOT"
                                    Width="275px" MaxResultCount="15" MinFilterLength="3" DropDownSettings-Height="240"
                                    OnClientSearch="onCarrierSearch" OnClientButtonCommand="onCarrierSearchButtonCommand"
                                    Skin="Metro" TabIndex="5">
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
                        </tr>
                        <tr id="ReqDocRow" runat="server" visible="false">
                            <td colspan="2">
                                <table>
                                    <tr>
                                        <td>
                                            <telerik:RadButton ID="RequestCheckedDocsRB" runat="server" AutoPostBack="True" Text="Request Checked Docs"
                                                ToolTip="Click here to request all of the documents checked below." OnClientClicked="requestDocs">
                                            </telerik:RadButton>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <telerik:RadTreeView ID="DocRadTreeView" runat="server" DataFieldID="DocTreeID" DataFieldParentID="DocTreeParentID"
                                    DataSourceID="DocTreeSigDS" DataValueField="DocTreeID" DataTextField="DocStatusWID"
                                    OnClientNodeClicked="onDocTreeNodeClicked" OnNodeDataBound="DocRadTreeView_NodeDataBound"
                                    OnClientNodeChecked="onRTVNodeChecked" OnClientMouseOver="onDocRadTreeViewMouseOver"
                                    CheckBoxes="true" Skin="MetroTouch">
                                    <NodeTemplate>
                                        <%# Eval("DocNodeHTML") %>
                                    </NodeTemplate>
                                </telerik:RadTreeView>
                                <asp:SqlDataSource ID="DocTreeSigDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                    SelectCommand="usp_DocTreeInFP" SelectCommandType="StoredProcedure">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="HiddenTB_ParentPartyID" PropertyName="Text" Type="String"
                                            Name="SenderID" />
                                        <asp:ControlParameter ControlID="HiddenTB_PartyID" PropertyName="Text" Type="String"
                                            Name="RecipientID" />
                                        <asp:ControlParameter ControlID="HiddenTB_MeID" PropertyName="Text" Type="String"
                                            Name="MeID" />
                                        <asp:ControlParameter ControlID="HiddenTB_ActiveOnly" PropertyName="Text" Type="String"
                                            Name="ActiveOnly" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </telerik:RadPane>
            <telerik:RadSplitBar ID="VerticalSplitBar" runat="server" CollapseMode="Forward" />
            <telerik:RadPane ID="DocRP" runat="server">
                DocID:
                <asp:TextBox ID="HiddenTB_DocID" runat="server" Text="0"></asp:TextBox><br />
                <div style="display: none;">
                    NodeIDLastClicked:
                    <asp:TextBox ID="HiddenTB_NodeIDLastClicked" runat="server" Text="0"></asp:TextBox><br />
                    NodeTextLastClicked:
                    <asp:TextBox ID="HiddenTB_NodeTextLastClicked" runat="server" Text="0"></asp:TextBox><br />
                    NodeID:
                    <asp:TextBox ID="HiddenTB_NodeID" runat="server" Text="0"></asp:TextBox><br />
                    NodeText:
                    <asp:TextBox ID="HiddenTB_NodeText" runat="server" Text="0"></asp:TextBox><br />
                    CIX:
                    <asp:TextBox ID="HiddenTB_CIX" runat="server" Text="0"></asp:TextBox><br />
                    PagesSelected:
                    <asp:TextBox ID="HiddenTB_PagesSelected" runat="server" Text=""></asp:TextBox><br />
                    PagesSelectedCount:
                    <asp:TextBox ID="HiddenTB_PagesSelectedCount" runat="server" Text="0"></asp:TextBox><br />
                    ExecutionID:
                    <asp:TextBox ID="HiddenTB_ExecutionID" runat="server" Text="0"></asp:TextBox><br />
                    DocTreeParent:
                    <asp:TextBox ID="HiddenTB_DocTreeParent" runat="server" Text="0"></asp:TextBox><br />
                    Review:
                    <asp:TextBox ID="HiddenTB_Review" runat="server" Text="0" Style="display: none">
                    </asp:TextBox>
                    Review:
                    <asp:TextBox ID="HiddenTB_FlowStepEncrypt" runat="server" Text="0" Style="display: none">
                    </asp:TextBox>
                    Review:
                    <asp:TextBox ID="HiddenTB_RowOwnerCIXEncrypt" runat="server" Text="0" Style="display: none">
                    </asp:TextBox>
                    Review:
                    <asp:TextBox ID="HiddenTB_RowOIXEncrypt" runat="server" Text="0" Style="display: none">
                    </asp:TextBox>
                </div>
                <div id="SummaryDiv" style="height: 100%; width: 100%; vertical-align: middle; text-align: center;">
                    Summary info here.
                </div>
                <div id="UploadSignDiv" style="height: 100%; width: 100%; display: none; vertical-align: middle;
                    text-align: center;">
                    <table>
                        <tbody>
                            <tr>
                                <td colspan="2" class="header_cust" style="width: 400px;">
                                    <asp:Label ID="UploadSignHeaderLbl" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <br />
                                    <br />
                                    <asp:Label ID="UploadSignLbl" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <br />
                                    <br />
                                    <br />
                                </td>
                            </tr>
                            <tr id="DocUploadRow">
                                <td>
                                    <telerik:RadButton ID="DocUploadRB" runat="server" Text="UPLOAD into FASTPORT" Height="40px"
                                        OnClientClicked="onDocRBClicked" AutoPostBack="false">
                                        <Icon PrimaryIconUrl="/Images/Custom/upload.png" PrimaryIconLeft="2" PrimaryIconTop="2"
                                            PrimaryIconHeight="35px" PrimaryIconWidth="35px"></Icon>
                                    </telerik:RadButton>
                                </td>
                                <td>
                                    <telerik:RadButton ID="DocFaxRB" runat="server" Text="FAX into FASTPORT" Height="40px"
                                        AutoPostBack="false">
                                        <Icon PrimaryIconUrl="/Images/Custom/fax.png" PrimaryIconLeft="2" PrimaryIconTop="2"
                                            PrimaryIconHeight="35px" PrimaryIconWidth="35px"></Icon>
                                    </telerik:RadButton>
                                    <br />
                                    <br />
                                    <telerik:RadButton ID="DocEmailRB" runat="server" Text="EMAIL into FASTPORT" Height="40px"
                                        AutoPostBack="false">
                                        <Icon PrimaryIconUrl="/Images/Custom/email.png" PrimaryIconLeft="2" PrimaryIconTop="2"
                                            PrimaryIconHeight="35px" PrimaryIconWidth="35px"></Icon>
                                    </telerik:RadButton>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <br />
                                    <br />
                                    <br />
                                </td>
                            </tr>
                            <tr id="DocSignRow">
                                <td>
                                    <telerik:RadButton ID="SignOnlineRB" runat="server" Text="SIGN Document ONLINE" Height="40px"
                                        AutoPostBack="false" OnClientClicked="onSignOnlineRBClicked">
                                        <Icon PrimaryIconUrl="/Images/Custom/sign.png" PrimaryIconLeft="2" PrimaryIconTop="2"
                                            PrimaryIconHeight="35px" PrimaryIconWidth="35px"></Icon>
                                    </telerik:RadButton>
                                </td>
                                <td>
                                    <telerik:RadButton ID="SignUploadRB" runat="server" Text="UPLOAD into FASTPORT" Height="40px"
                                        AutoPostBack="false">
                                        <Icon PrimaryIconUrl="/Images/Custom/upload.png" PrimaryIconLeft="2" PrimaryIconTop="2"
                                            PrimaryIconHeight="35px" PrimaryIconWidth="35px"></Icon>
                                    </telerik:RadButton>
                                    <br />
                                    <br />
                                    <telerik:RadButton ID="SignFaxRB" runat="server" Text="FAX into FASTPORT" Height="40px"
                                        AutoPostBack="false">
                                        <Icon PrimaryIconUrl="/Images/Custom/fax.png" PrimaryIconLeft="2" PrimaryIconTop="2"
                                            PrimaryIconHeight="35px" PrimaryIconWidth="35px"></Icon>
                                    </telerik:RadButton>
                                    <br />
                                    <br />
                                    <telerik:RadButton ID="SignEmailRB" runat="server" Text="EMAIL into FASTPORT" Height="40px"
                                        AutoPostBack="false">
                                        <Icon PrimaryIconUrl="/Images/Custom/email.png" PrimaryIconLeft="2" PrimaryIconTop="2"
                                            PrimaryIconHeight="35px" PrimaryIconWidth="35px"></Icon>
                                    </telerik:RadButton>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div id="SignDiv" style="display: none;">
                    Signature Code
                </div>
                <div id="SliderDiv" style="display: none; border-bottom: 3px solid #cfcfcf">
                    <table width="100%" style="height: 40px; background-color: #d9d9d9;">
                        <tr>
                            <td align="left" style="width: 260px;">
                                <table>
                                    <tr>
                                        <td>
                                            <telerik:RadButton ID="DocDetailsRB" runat="server" AutoPostBack="false" Text="Show Doc Details"
                                                OnClientClicked="onDocDetailsRBClicked">
                                            </telerik:RadButton>
                                        </td>
                                        <td class="dfv" style="vertical-align: middle; padding-bottom: 4px">
                                            <asp:Label ID="DocDetailsToCompleteLbl" runat="server" Text="Please Complete/Lock"
                                                ForeColor="Red"></asp:Label>
                                            <asp:Label ID="DocDetailsCompleteLbl" runat="server" Text="Complete" ForeColor="Green"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>
                                <center>
                                    <telerik:RadSlider runat="server" ID="DocPageRS" MaximumValue="11" MinimumValue="1"
                                        Value="5" LiveDrag="false" SmallChange="1" AutoPostBack="true" OnValueChanged="DocPageRS_ValueChanged"
                                        Width="150px" CausesValidation="false" Visible="true" OnClientValueChanged="onDocPageRSValueChanged" />
                                </center>
                            </td>
                            <td align="right" style="width: 260px;">
                                <table style="float: right">
                                    <tr>
                                        <td style="padding-right: 5px">
                                            <telerik:RadButton ID="UploadRB" runat="server" Height="20px" Width="20px" ToolTip="Upload Page(s)"
                                                AutoPostBack="false" OnClientClicked="onDocRBClicked">
                                                <Image EnableImageButton="true" ImageUrl="/Images/Custom/upload-small.png"></Image>
                                            </telerik:RadButton>
                                        </td>
                                        <td style="padding-right: 5px">
                                            <telerik:RadButton ID="PrintSelectedRB" runat="server" Height="20px" Width="20px"
                                                OnClientClicking="onPrintRBClicking" ToolTip="Print Selected Page(s)" AutoPostBack="false"
                                                ButtonType="LinkButton" Target="_blank">
                                                <Image EnableImageButton="true" ImageUrl="/Images/Custom/print.png"></Image>
                                            </telerik:RadButton>
                                        </td>
                                        <td style="padding-right: 5px">
                                            <telerik:RadButton ID="Rotate90RB" runat="server" Height="20px" Width="20px" ToolTip="Rotate 90 degrees"
                                                AutoPostBack="true">
                                                <Image EnableImageButton="true" ImageUrl="/Images/Custom/rotate90.png"></Image>
                                            </telerik:RadButton>
                                        </td>
                                        <td style="padding-right: 5px">
                                            <telerik:RadButton ID="Rotate180RB" runat="server" Height="20px" Width="20px" ToolTip="Rotate 180 degrees"
                                                AutoPostBack="true">
                                                <Image EnableImageButton="true" ImageUrl="/Images/Custom/rotate180.png"></Image>
                                            </telerik:RadButton>
                                        </td>
                                        <td style="padding-right: 5px">
                                            <telerik:RadButton ID="CopySelectedRB" runat="server" Height="20px" Width="20px"
                                                ToolTip="Copy Selected" AutoPostBack="false" OnClientClicked="onCopySelectedRBClicked">
                                                <Image EnableImageButton="true" ImageUrl="/Images/Custom/copy.png"></Image>
                                            </telerik:RadButton>
                                        </td>
                                        <td style="padding-right: 5px">
                                            <telerik:RadButton ID="SelectAllRB" runat="server" ButtonType="ToggleButton" ToggleType="CustomToggle"
                                                Height="20px" Width="20px" ToolTip="Select/Unselect All" AutoPostBack="false"
                                                OnClientToggleStateChanged="onSelectAllRBClicked">
                                                <ToggleStates>
                                                    <telerik:RadButtonToggleState ImageUrl="/Images/Custom/select_all.png" Text="" Selected="true"
                                                        Value="True" />
                                                    <telerik:RadButtonToggleState ImageUrl="/Images/Custom/unselect_all.png" Text=""
                                                        Selected="true" Value="False" />
                                                </ToggleStates>
                                            </telerik:RadButton>
                                        </td>
                                        <td style="padding-right: 5px">
                                            <telerik:RadButton ID="DeleteAllRB" runat="server" Height="20px" Width="20px" ToolTip="Delete Selected"
                                                OnClientClicked="onDeleteAllRBClicked" AutoPostBack="false">
                                                <Image EnableImageButton="true" ImageUrl="/Images/Custom/delete_all.png"></Image>
                                            </telerik:RadButton>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
                <div id="DocShowDiv" style="display: none;">
                    <asp:Panel ID="DocPagePnl" runat="server">
                        <telerik:RadListView ID="DocPageRLV" runat="server" ItemPlaceholderID="DocPageContainer"
                            DataKeyNames="PageID" ClientDataKeyNames="PageID" DataSourceID="DocPageDS">
                            <ClientSettings AllowItemsDragDrop="true">
                                <ClientEvents OnItemDragStarted="onDocPageRLVItemDragStarted" OnItemDropping="onDocPageRLVItemDropping"
                                    OnListViewCreated="onDocPageRLVCreated"></ClientEvents>
                            </ClientSettings>
                            <LayoutTemplate>
                                <div class="RadListView RadListView_<%# Container.Skin %>">
                                    <asp:PlaceHolder ID="DocPageContainer" runat="server"></asp:PlaceHolder>
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <div id="<%# Eval("PageID") %>" class="track rlvI" style="float: left; margin: 5px;
                                    padding: 8px; position: relative; background: rgb(217, 217, 217);" onmouseover="docmouseover(this)"
                                    onmouseout="docmouseout(this)" onclick="docclick(this)" onmousedown="docmousedown(this);">
                                    <div style="z-index: 100; margin-top: 7px; margin-left: 5px; position: absolute;
                                        width: 170px; display: none;" class="fp_button_wrapper">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <telerik:RadListViewItemDragHandle ID="DocPageDH" runat="server" ToolTip="Drag to organize">
                                                        </telerik:RadListViewItemDragHandle>
                                                    </td>
                                                    <td>
                                                        <telerik:RadButton ID="EditRB" runat="server" Text="Edit" ToolTip="Click to edit image."
                                                            CommandName="DocEdit">
                                                            <Icon PrimaryIconUrl="/Images/Custom/edit_hover.png" PrimaryIconLeft="4" PrimaryIconTop="4">
                                                            </Icon>
                                                        </telerik:RadButton>
                                                    </td>
                                                    <td>
                                                        <telerik:RadButton ID="DocPageDelRB" runat="server" Text="Delete" ToolTip="Click to delete this page only."
                                                            CommandName="DocPageDel">
                                                            <Icon PrimaryIconCssClass="rbRemove" PrimaryIconLeft="4" PrimaryIconTop="4"></Icon>
                                                        </telerik:RadButton>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
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
                    </asp:Panel>
                    <asp:SqlDataSource ID="DocPageDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                        SelectCommand="usp_DocPages" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="HiddenTB_DocID" PropertyName="Text" Type="String"
                                Name="DocID" />
                            <asp:ControlParameter ControlID="HiddenTB_ExecutionID" PropertyName="Text" Type="String"
                                Name="ExecutionID" />
                            <asp:SessionParameter Name="MeID" SessionField="PartyID" Type="Int32" />
                            <asp:ControlParameter ControlID="HiddenTB_SliderValue" PropertyName="Text" Type="Int32" Name="SliderValue" />
                            <asp:ControlParameter ControlID="HiddenTB_PartyID" PropertyName="Text" Type="Int32" Name="TruckerID" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
                <div id="NoDocsDiv" runat="server" visible="false" style="background-color: White;
                    border-radius: 5px; -moz-border-radius: 5px; -webkit-border-radius: 5px; min-height: 215px;">
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
                <div id="SignShowDiv" style="display: none;">
                    Doc show
                </div>
                <div id="FolderDiv" style="display: none;">
                    <telerik:RadButton ID="PrintAllRB" runat="server" Text="Print All Docs in Folder" Height="40px"
                        AutoPostBack="false" ButtonType="LinkButton" Target="_blank" OnClientClicking="onPrintAllRBClicking">
                        <Icon PrimaryIconUrl="/Images/Custom/email.png" PrimaryIconLeft="2" PrimaryIconTop="2"
                            PrimaryIconHeight="35px" PrimaryIconWidth="35px"></Icon>
                    </telerik:RadButton>
                </div>
                <div class="fp_button_wrapper" style="position: fixed; bottom: 150px; left: 70%;">
                    <center>
                        <table>
                            <tr>
                                <td>
                                    <telerik:RadButton ID="Next1Button" runat="server" AutoPostBack="true" Text="Next Step 1"
                                        ToolTip="Click to move to the next step." Visible="false">
                                    </telerik:RadButton>
                                </td>
                                <td>
                                    <telerik:RadButton ID="Next2Button" runat="server" AutoPostBack="true" Text="Next Step 2"
                                        ToolTip="Click to move to the next step." Visible="false">
                                    </telerik:RadButton>
                                </td>
                                <td>
                                    <telerik:RadButton ID="Next3Button" runat="server" AutoPostBack="true" Text="Next Step 3"
                                        ToolTip="Click to move to the next step." Visible="false">
                                    </telerik:RadButton>
                                </td>
                                <td>
                                    <telerik:RadButton ID="Next4Button" runat="server" AutoPostBack="true" Text="Next Step 4"
                                        ToolTip="Click to move to the next step." Visible="false">
                                    </telerik:RadButton>
                                </td>
                                <td>
                                    <asp:ImageButton runat="server" ID="RewindButton" CausesValidation="False" CommandName="Redirect"
                                        ImageUrl="../Images/Custom/blank.png" TabIndex="18" Visible="False"></asp:ImageButton>
                                </td>
                            </tr>
                        </table>
                    </center>
                </div>
                <div style="display: none;">
                    PartyID:
                    <asp:TextBox ID="HiddenTB_PartyID" runat="server" Text="0"></asp:TextBox><br />
                    ParentPartyID:
                    <asp:TextBox ID="HiddenTB_ParentPartyID" runat="server" Text="0"></asp:TextBox><br />
                    SenderID:
                    <asp:TextBox ID="HiddenTB_SenderID" runat="server" Text="0"></asp:TextBox><br />
                    DocAction:
                    <asp:TextBox ID="HiddenTB_DocAction" runat="server" Text="0"></asp:TextBox><br />
                    PageID:
                    <asp:TextBox ID="HiddenTB_PageID" runat="server" Text="0"></asp:TextBox><br />
                    Me:
                    <asp:TextBox ID="HiddenTB_MeID" runat="server" Text="0"></asp:TextBox><br />
                    ActiveOnly:
                    <asp:TextBox ID="HiddenTB_ActiveOnly" runat="server" Text="1"></asp:TextBox><br />
                    PageHeight:
                    <asp:TextBox ID="HiddenTB_WindowHeight" runat="server" Text="1"></asp:TextBox><br />
                    PageWidth:
                    <asp:TextBox ID="HiddenTB_WindowWidth" runat="server" Text="1"></asp:TextBox><br />
                    PageTitle:
                    <asp:TextBox ID="HiddenTB_PageTitle" runat="server" Text="Show Doc Details"></asp:TextBox><br />
                    SliderValue:
                    <asp:TextBox ID="HiddenTB_SliderValue" runat="server" Text="6"></asp:TextBox>
                </div>
            </telerik:RadPane>
            <telerik:RadSplitBar ID="RightRSB" runat="server">
            </telerik:RadSplitBar>
            <telerik:RadPane ID="RightRP" runat="server" Width="22px" Scrolling="none">
                <telerik:RadSlidingZone ID="SlidingZone1" runat="server" Width="22px" SkinID="BlackMetroTouch"
                    SlideDirection="Left">
                    <telerik:RadSlidingPane ID="InstructionsRSP" Title="&nbsp;&nbsp;&nbsp;Instructions&nbsp;&nbsp;&nbsp;"
                        runat="server" Width="425px" MinWidth="100">
                        <div class="dfv">
                            <asp:Literal ID="InstructionsLiteral" runat="server"></asp:Literal>
                            <asp:Literal ID="InstructionsLiteral1" runat="server"></asp:Literal>
                        </div>
                    </telerik:RadSlidingPane>
                    <telerik:RadSlidingPane ID="DataRSP" Title="&nbsp;&nbsp;&nbsp;Fill Out&nbsp;&nbsp;&nbsp;"
                        runat="server" Width="425px" MinWidth="100">
                        <table id="DataRSPTable" runat="server">
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
        </telerik:RadSplitter>
    </div>
    </form>
</body>
</html>
