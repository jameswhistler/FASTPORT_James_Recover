<%@ Page Language="VB" AutoEventWireup="false" CodeBehind="FastportConfig.aspx.vb"
    Inherits=".FastportConfig" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>FASTPORT > Configure</title>
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
        .RadListView_Default
        {
            border: 0px !important;
        }
        
        .RadListView_Default td.rlvI, .RadListView_Default td.rlvA, .RadListView_Default td.rlvISel, .RadListView_Default td.rlvIEmpty
        {
            border-right: 0px !important;
        }
        
        .RadListView td.rlvI, .RadListView td.rlvA, .RadListView td.rlvISel, .RadListView td.rlvIEmpty, .RadListView td.rlvIEdit
        {
            padding: 0px !important;
            border: 0px;
        }
        
        .RadWindow_BlackMetroTouch .rwTable .rwTitlebarControls em
        {
            font-size: 18px;
            padding: 8px 0 0 3px;
        }
        
        .RadSearchBox_Metro .rsbInput, .radPreventDecorate, .rsbEmptyMessage
        {
            width: 140px;
        }
        
        .rtsUL
        {
            width: 105%;
        }
        
        
        div.CustomRSB .rsbInput, .rsbEmptyMessage
        {
            width: 87%;
        }
        
        
        .RadWindow, .RadWindow_BlackMetroTouch, .rwNormalWindow, .rwTransparentWindow, .rwNoTitleBar
        {
            height: auto;
        }
        
        .rlvI div span div div
        {
            border: 0px solid #FF0000 !important;
        }
        
        .RadGrid_Default
        {
            border: 0px !important;
        }
        
        #ExpDiv
        {
            position: absolute;
            top: 50px;
            bottom: 0px;
            left: 0px;
            right: 0px;
        }
        
        #IncidentsDiv
        {
            position: absolute;
            top: 50px;
            bottom: 0px;
            left: 0px;
            right: 0px;
        }
        
        
        #ToDoDiv
        {
            position: absolute;
            top: 50px;
            bottom: 0px;
            left: 0px;
            right: 0px;
        }
        
        div.RemoveBorders1 .rgHeader, div.RemoveBorders1 th.rgResizeCol, div.RemoveBorders1 .rgFilterRow td, div.RemoveBorders1 .rgNoRecords td
        {
            border-width: 0 0 0px 0;
        }
        
        div.RemoveBorders1 .rgRow td, div.RemoveBorders1 .rgAltRow td, div.RemoveBorders1 .rgEditRow td, div.RemoveBorders1 .rgFooter td
        {
            border-width: 0;
            padding-left: 7px;
        }
        
        html .rsbSlide, html .rsbDropDownSlide
        {
            z-index: 50001;
        }
        
        body
        {
            margin: 0px;
        }
        
        .RadPanelBar_BlackMetroTouch .rpItem
        {
            font-size: 15px;
            background-color: White;
        }
    </style>
    <telerik:RadScriptBlock ID="RadScriptBlock1" runat="server">
        <script src="https://maps.googleapis.com/maps/api/js?sensor=true" type="text/javascript">
        </script>
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

        window.onload = function() {

            $find("<%=ToDoRS.ClientID %>").repaint();

//            var Tab = document.getElementById("HiddenTB_Tab").value;

//            if (Tab!="0") {
//                var tabStrip= $find("<%= FastportRTS.ClientID %>");
//                var tab = tabStrip.findTabByValue(Tab);
//                tab.set_selected(true);
//            }
        };


        function onFastportRTSSelected(sender, args) {
        
                var ToDoDiv = document.getElementById("ToDoDiv");
                var GeneralDiv = document.getElementById("GeneralDiv");
                var HistoryDiv = document.getElementById("HistoryDiv");
                var ExpDiv = document.getElementById("ExpDiv");
                var IncidentsDiv = document.getElementById("IncidentsDiv");
                var DocsDiv = document.getElementById("DocsDiv");
                var EquipDiv = document.getElementById("EquipDiv");

                var tab = args.get_tab();
                var tabid = tab.get_text();
                tabid = parseInt(tabid)

				hideAllRTT();

                if (tabid == 1) {
                    ToDoDiv.style.display = "";
                    GeneralDiv.style.display = "none";
                    HistoryDiv.style.display = "none";
                    ExpDiv.style.display = "none";
                    IncidentsDiv.style.display = "none";
                    DocsDiv.style.display = "none";
                    EquipDiv.style.display = "none";
                    $find("<%=ToDoRS.ClientID %>").repaint();
                } else if (tabid == 2) {
                    ToDoDiv.style.display = "none";
                    GeneralDiv.style.display = "";
                    HistoryDiv.style.display = "none";
                    ExpDiv.style.display = "none";
                    IncidentsDiv.style.display = "none";
                    DocsDiv.style.display = "none";
                    EquipDiv.style.display = "none";
                    RepaintAddrSlider();
                    if (document.getElementById("HiddenTB_InfoRun").value == "No") {
                        document.getElementById("HiddenTB_InfoRun").value = "Yes";
                        $find("<%=RadAjaxManager1.ClientID %>").ajaxRequest("rebindInfo");
                    }
                } else if (tabid == 3) {
                    ToDoDiv.style.display = "none";
                    GeneralDiv.style.display = "none";
                    HistoryDiv.style.display = "";
                    ExpDiv.style.display = "none";
                    IncidentsDiv.style.display = "none";
                    DocsDiv.style.display = "none";
                    EquipDiv.style.display = "none";
                    $find("<%=YearsRadSlider.ClientID %>").repaint();
                    getWindowWidth();
                    if (document.getElementById("HiddenTB_HistRun").value == "No") {
                        document.getElementById("HiddenTB_HistRun").value = "Yes";
                        $find("<%=RadAjaxManager1.ClientID %>").ajaxRequest("rebindHist");
                    }
                } else if (tabid == 4) {
                    ToDoDiv.style.display = "none";
                    GeneralDiv.style.display = "none";
                    HistoryDiv.style.display = "none";
                    ExpDiv.style.display = "";
                    IncidentsDiv.style.display = "none";
                    DocsDiv.style.display = "none";
                    EquipDiv.style.display = "none";
                    $find("<%=ExpRS.ClientID %>").repaint();
                    if (document.getElementById("HiddenTB_ExpRun").value == "No") {
                        document.getElementById("HiddenTB_ExpRun").value = "Yes";
                        $find("<%=RadAjaxManager1.ClientID %>").ajaxRequest("rebindExp");
                    }
                } else if (tabid == 5) {
                    ToDoDiv.style.display = "none";
                    GeneralDiv.style.display = "none";
                    HistoryDiv.style.display = "none";
                    ExpDiv.style.display = "none";
                    IncidentsDiv.style.display = "";
                    DocsDiv.style.display = "none";
                    EquipDiv.style.display = "none";
                    $find("<%=IncidentsRS.ClientID %>").repaint();
                    if (document.getElementById("HiddenTB_IncidentsRun").value == "No") {
                        document.getElementById("HiddenTB_IncidentsRun").value = "Yes";
                        $find("<%=RadAjaxManager1.ClientID %>").ajaxRequest("rebindIncidents");
                    }
                } else if (tabid == 6) {
                    ToDoDiv.style.display = "none";
                    GeneralDiv.style.display = "none";
                    HistoryDiv.style.display = "none";
                    ExpDiv.style.display = "none";
                    IncidentsDiv.style.display = "none";
                    DocsDiv.style.display = "";
                    EquipDiv.style.display = "none";
                } else if (tabid == 7) {
                    ToDoDiv.style.display = "none";
                    GeneralDiv.style.display = "none";
                    HistoryDiv.style.display = "none";
                    ExpDiv.style.display = "none";
                    IncidentsDiv.style.display = "none";
                    DocsDiv.style.display = "none";
                    EquipDiv.style.display = "";
                }

            }

            function flipSRC(mybuttonname, mySRC) {

                var mybutton = document.getElementById(mybuttonname);
                mybutton.src = mySRC;

            }

            function onInstClick(mytarget, arg) {

                var InstRTT = $find("<%=InstRTT.ClientID %>");
                var mybutton = document.getElementById(mytarget);

                InstRTT.set_targetControl(mybutton);
                SendCallBack("onInstClick," + arg, "onInstClick");

            }

            function afterInstClick(arg) {

                var InstRTT = $find("<%=InstRTT.ClientID %>");
                InstRTT.set_text(arg);
                InstRTT.show();

            }

            function onPrefRTT_DelIBClick(index) {

                var grid = $find("<%=PrefRG.ClientID %>");
                var MasterTable = grid.get_masterTableView();
                var row = MasterTable.get_dataItems()[index];
                var partyexperienceid = row.getDataKeyValue("PartyExperienceID");
                var itemname = row.getDataKeyValue("ItemName");
                confirmCall("deletePrefItem", partyexperienceid, itemname);

            }

            function CallRadWindow(myID, myAction) {

                cancelTips = false;

                switch (myAction) {
                case "editIncident":
                    {
                        SendCallBack("editIncident," + myID, "OpenRadWindow")
                        break;
                    }
                }
            }

            function SendCallBack(arg, myAction) {

                try {
                    switch (myAction) {
                    case "OpenRadWindow":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "OpenRadWindow", "null") %>
                            break;
                        }
                    case "OpenRadWindowDialogue":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "OpenRadWindowDialogue", "null") %>
                            break;
                        }
                    case "onInstClick":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "afterInstClick", "null") %>
                            break;
                        }
                        //General Tab.
                    case "AddrEdit":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "loadAddrRW", "null") %>
                            break;
                        }
                    case "updateExpSlider":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "Finish", "null") %>
                            break;
                        }
                        //History Tab.
                    case "CarrierValues":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "set_carriervalues_back", "null") %>
                            break;
                        }
                    case "HistValues":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "set_values_back", "null") %>
                            break;
                        }
                    case "FinishHist":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "FinishHist", "null") %>
                            break;
                        }
                    case "DateWarning1":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onHiredChanged_back", "null") %>
                            break;
                        }
                    case "DateWarning":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onQuitChanged_back", "null") %>
                            break;
                        }
                    case "MCNumberDup":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onMCNumberChanged_back", "null") %>
                            break;
                        }
                    case "DOTNumberDup":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onDOTNumberChanged_back", "null") %>
                            break;
                        }
                    case "ToCheck":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "Check", "null") %>
                            break;
                        }
                    case "updateExperienceNotes":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onExperienceNotesSave_back", "null") %>
                            break;
                        }
                    case "loadExperienceNotes":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "openExperienceNotes_back", "null") %>
                            break;
                        }
                    case "onLockIncidentRBClicked":
                        { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "onLockIncidentRBClicked_back", "null") %>
                            break;
                        }                    
                    }
                } catch (e) {}
            }


            function Finish(arg) {

                if (arg != "Nothing") {

                    launchRadAlert(arg, "FASTPORT Error");

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

            function ParentCloseAndRedirect(arg) {

                var myString = arg;
                var mySplit = myString.split(",", 2);

                var myArg = mySplit[0] || "";
                var myID = mySplit[1] || "";

                if (myArg == "DocAll") {

                };

                if (!arg) {
                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Close");
                } else {
                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest(arg);
                }
            }


            function onComboKeyPressing(sender, args) {
                if (!sender.get_dropDownVisible()) sender.showDropDown();
            }


            function cancelToolTip(sender, args) {

                args.set_cancel(cancelTips);
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


            function itemaddRCB(combo, value, text, clearyesno) {

                if (clearyesno == "yes") {
                    combo.get_items().clear();
                }

                var comboItem = new Telerik.Web.UI.RadComboBoxItem();
                comboItem.set_value(value);
                comboItem.set_text(text);
                combo.trackChanges();
                combo.get_items().add(comboItem);
                combo.commitChanges();

            }

            function itemselectRCB(combo, value) {

                var item = combo.findItemByValue(value);
                if (item) {
                    item.select();
                }

            }

            function onRWBeforeShow() {

                block_OnChangedEvents = true;

            }

            function onRWShow() {

                block_OnChangedEvents = false;

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
                if (callType == "deleteDoc") {

                    confirmMess = "Are you certain that you wish to <span style='color: #ff0000;'>permanently</span> delete this doc?";
                    confirmTitle = "Delete " & callName & " ?"
                    launchRadConfirm(confirmMess, confirmTitle);

                } else if (callType == "deleteAddr") {

                    confirmMess = "Are you certain that you wish to <span style='color: #ff0000;'>permanently</span> delete this address?";
                    confirmTitle = "Delete " & callName & " ?"
                    launchRadConfirm(confirmMess, confirmTitle);

                } else if (callType == "CarrierDel") {

                    confirmMess = "Are you certain that you wish to <span style='color: #ff0000;'>remove</span> this carrier?";
                    confirmTitle = callName & " ?"
                    launchRadConfirm(confirmMess, confirmTitle);

                } else if (callType == "HistDel") {

                    confirmMess = "Are you certain that you wish to <span style='color: #ff0000;'>permanently</span> delete this job or unemployment period?";
                    confirmTitle = callName & " ?"
                    launchRadConfirm(confirmMess, confirmTitle);

                } else if (callType == "deleteExpItem") {

                    confirmMess = "Are you certain that you wish to <span style='color: #ff0000;'>permanently</span> delete the experience named: " + callName + "?";
                    confirmTitle = "Delete " & callName & " ?";
                    launchRadConfirm(confirmMess, confirmTitle);

                } else if (callType == "deleteIncidentItem") {

                    confirmMess = "Are you certain that you wish to <span style='color: #ff0000;'>permanently</span> delete the experience named: " + callName + "?";
                    confirmTitle = "Delete " & callName & " ?";
                    launchRadConfirm(confirmMess, confirmTitle);
                } else if (callType == "deletePrefItem") {

                    confirmMess = "Are you certain that you wish to <span style='color: #ff0000;'>permanently</span> delete the experience named: " + callName + "?";
                    confirmTitle = "Delete " & callName & " ?";
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

                    if (confirmType == "deleteDoc") {

                        var sendArg = confirmType; <%= Page.ClientScript.GetCallbackEventReference(Me, "sendArg", "Finish_DocTreeNodeClicked", "null") %>

                    } else if (confirmType == "deleteAddr") {

                        var sendArg = confirmType + "," + confirmID; <%= Page.ClientScript.GetCallbackEventReference(Me, "sendArg", "FinishAlert", "null") %>

                    } else if (confirmType == "deleteExpItem") {

                        $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest(confirmType + "," + confirmID);
                        
                    } else if (confirmType == "HistDel") {

                        var sendArg = confirmType + "," + confirmID; <%= Page.ClientScript.GetCallbackEventReference(Me, "sendArg", "FinishAlert", "null") %>

                    } else if (confirmType == "deleteIncidentItem") {

                        var sendArg = confirmType + "," + confirmID; <%= Page.ClientScript.GetCallbackEventReference(Me, "sendArg", "FinishAlert", "null") %>

                    } else if (confirmType == "CarrierDel") {

                        clearsearchvalues("yes");
                        set_carriervalues("0");
                        document.getElementById("HiddenTB_CarrierAdminYesNo").value = "0";
                        v_carriereditrb("no");

                        var positiontype = $find("<%=PositionTypeRCB.ClientID %>").get_selectedItem().get_value();
                        v_employer(positiontype, "0");
                
                    } else if (confirmType == "deletePrefItem") {

                        $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest(confirmType + "," + confirmID);

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

                //Step 5:  Launch alert if there is a problem with the procedure called by the launchRadConfirm function.
                if (arg != "Nothing") {

                    var messTitle
                    var mess

                    if (confirmType == "deleteAddr") {

                        messTitle = "Delete Failed"
                        mess = "<span style='color: #ff0000;'>WARNING:</span> The system failed to delete this item. Usually, this is because this address is referenced in other places in FASTPORT, and thus, it cannot be deleted.  The technical details for this error are as follows: " + arg

                    } else if (confirmType == "HistDel") {

                        messTitle = "Delete Failed"
                        mess = "<span style='color: #ff0000;'>WARNING:</span> The system failed to delete this job or unemployment period. If this problem continues, please contact FASTPORT support.  The technical details for this error are as follows: " + arg

                    }

                    launchRadAlert(mess, messTitle)

                } else {
                    if (confirmType == "deleteAddr") {

                        $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindAddr");

                    } else if (confirmType == "HistDel") {

                        $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindHist");

                    } else if (confirmType == "deleteIncidentItem") {

                        $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindIncidents");

                    }
                }

            }

            //**********************
            //END:  Rad alert functions
            //**********************


            //**********************
            //Start:  Section 2 -- General Tab.
            //**********************


            function RepaintAddrSlider() {
                var slider = $find("<%= AddrRadSlider.ClientID %>");
                slider.repaint();
            }

            function addrclientclicked() {

                setTimeout(RepaintAddrSlider, 75);

            }


            function loadAddrRW(arg) {

                var myString = arg;
                var mySplit = myString.split("<|>", 7);

                var addr = mySplit[0] || "";
                var addr2 = mySplit[1] || "";
                var zipid = mySplit[2] || "";
                var citystzip = mySplit[3] || "";
                var movedin = mySplit[4] || "";
                var movedout = mySplit[5] || "";
                var movedouton = mySplit[6] || "";

                $find("<%=AddrRTB.ClientID%>").set_value(addr);
                $find("<%=Addr2RTB.ClientID%>").set_value(addr2);
                $find("<%=AddrZipRCB.ClientID%>").set_value(zipid);
                document.getElementById("<%= HiddenTB_AddrZipID.ClientID %>").value = zipid;
                $find("<%=AddrZipRCB.ClientID%>").set_text(citystzip);
                $find("<%=MovedInRDP.ClientID%>").set_selectedDate(getDateFromString(movedin));

                if (movedout == "true" || movedout == "True") {
                    document.getElementById("AddrRW_C_MovedOutCB").checked = true;
                    onMovedOutChecked(true);
                } else {
                    document.getElementById("AddrRW_C_MovedOutCB").checked = false;
                    onMovedOutChecked(false);
                }

                $find("<%=MovedOutRDP.ClientID%>").set_selectedDate(getDateFromString(movedouton));

                var oWnd = $find("<%=AddrRW.ClientID%>");
                oWnd.show();

            }

            function onMovedOutChecked(args) {

                var MovedOutLblDiv = document.getElementById("MovedOutLblDiv");
                var MovedOutDiv = document.getElementById("MovedOutDiv");

                if (args == true) {
                    MovedOutLblDiv.style.display = "block";
                    MovedOutDiv.style.display = "block";
                } else {
                    MovedOutLblDiv.style.display = "none";
                    MovedOutDiv.style.display = "none";
                }

            }

            function onAddrAddClick() {

                document.getElementById("<%= HiddenTB_AddrID.ClientID %>").value = "0";
                document.getElementById("<%= HiddenTB_AddrZipID.ClientID %>").value = "0";
                $find("<%=AddrRTB.ClientID%>").set_value("");
                $find("<%=Addr2RTB.ClientID%>").set_value("");
                $find("<%=AddrZipRCB.ClientID%>").set_value("");
                $find("<%=AddrZipRCB.ClientID%>").set_text("");
                $find("<%=MovedInRDP.ClientID%>").set_selectedDate("");
                document.getElementById("AddrRW_C_MovedOutCB").checked = false;
                onMovedOutChecked(false);
                $find("<%=MovedOutRDP.ClientID%>").set_selectedDate("");
                var oWnd = $find("<%=AddrRW.ClientID%>");
                oWnd.show();

            }

            function onAddrRGRowClick(sender, eventArgs) {

                var addrid = eventArgs.getDataKeyValue("AddrID");

                if (addrid != "") {
                    document.getElementById("<%= HiddenTB_AddrID.ClientID %>").value = addrid;
                    SendCallBack("AddrEdit," + addrid, "AddrEdit");
                } else {
                    var movedin = eventArgs.getDataKeyValue("MovedIn");
                    var movedouton = eventArgs.getDataKeyValue("MovedOutOn");

                    document.getElementById("<%= HiddenTB_AddrID.ClientID %>").value = "0";
                    document.getElementById("<%= HiddenTB_AddrZipID.ClientID %>").value = "0";

                    $find("<%=AddrRTB.ClientID%>").set_value("");
                    $find("<%=Addr2RTB.ClientID%>").set_value("");
                    $find("<%=AddrZipRCB.ClientID%>").set_value("");
                    $find("<%=AddrZipRCB.ClientID%>").set_text("");

                    $find("<%=MovedInRDP.ClientID%>").set_selectedDate(getDateFromString(movedin));

                    if (movedouton != "") {
                        document.getElementById("AddrRW_C_MovedOutCB").checked = true;
                        onMovedOutChecked(true);
                    } else {
                        document.getElementById("AddrRW_C_MovedOutCB").checked = false;
                        onMovedOutChecked(false);
                    }

                    $find("<%=MovedOutRDP.ClientID%>").set_selectedDate(getDateFromString(movedouton));

                    var oWnd = $find("<%=AddrRW.ClientID%>");
                    oWnd.show();

                }

            }

            function closeAddrRW() {

                var oWnd = $find("<%=AddrRW.ClientID%>");
                oWnd.close();

            }

            function onAddrDeleteClick(index) {

                var grid = $find("<%=AddrRadGrid.ClientID %>");
                var MasterTable = grid.get_masterTableView();
                var row = MasterTable.get_dataItems()[index];
                var addrid = row.getDataKeyValue("AddrID");
                confirmCall("deleteAddr", addrid, "Address")

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

            function showPrefRTT(mybutton, myprefparentids) {

                document.getElementById("<%= HiddenTB_PrefParentID.ClientID %>").value = myprefparentids;

                var PrefRTT = $find("<%=PrefRTT.ClientID %>");

                var mytargetname;
                switch (mybutton) {
                case "Pref_GeneralRB":
                    {
                        mytargetname = "Pref_GeneralRACPanel";
                        break;
                    }
                case "Pref_EquipRB":
                    {
                        mytargetname = "Pref_EquipRACPanel";
                        break;
                    }
                case "Pref_CommodityRB":
                    {
                        mytargetname = "Pref_CommodityRACPanel";
                        break;
                    }
                case "Pref_RegionsRB":
                    {
                        mytargetname = "Pref_RegionsRACPanel";
                        break;
                    }
                case "Pref_OtherRB":
                    {
                        mytargetname = "Pref_OtherRACPanel";
                        break;
                    }
                }

                var mytarget = document.getElementById(mytargetname);
                PrefRTT.set_targetControl(mytarget);
                setTimeout(function () {
                    PrefRTT.show();
                }, 2000);              
                

            }


            function getExpID(sender, eventArgs) {
                var rowID = eventArgs.getDataKeyValue("PartyExperienceID");
                document.getElementById("<%= HiddenTB_MouseOverID.ClientID %>").value = rowID;
            }

            var issliding = false;

            function slideStart() {

                issliding = true;

            }

            var slidervalue;

            function sliderChanged(sender, args) {

                slidervalue = args.get_newValue();
                if (issliding == false) {
                    updateSlider(slidervalue);
                }

            }

            function slideEnd() {

                issliding = false;
                updateSlider(slidervalue);

            }


            function updateSlider(slidervalue) {

                var expid = document.getElementById("<%= HiddenTB_MouseOverID.ClientID %>").value;
                SendCallBack("updateExpSlider," + expid + "," + slidervalue, "updateExpSlider");

            }

            function closePrefRTT() {

                var tooltip = $find("<%=PrefRTT.ClientID %>");
                tooltip.set_targetControl(null);
                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindPrefs");

            }

            //**********************
            //End:  Section 2 -- General Tab.
            //**********************

            ////////////////////////////////
            //History: Control events
            ////////////////////////////////

            var block_v_employer = false;
            var block_OnChangedEvents = true;

            function onPositionTypeChanged(sender, args) {

                if (block_OnChangedEvents == false) {

                    document.getElementById("<%= HiddenTB_CarrierID.ClientID %>").value = null;

                    var positiontype = sender.get_selectedItem().get_value();

                    block_v_employer = true;
                    v_currentpast(positiontype);
                    block_v_employer = false;

                    set_currentpastvalue(positiontype, "0");

                    var carrierid = document.getElementById("<%= HiddenTB_CarrierID.ClientID %>").value;
                    v_employer(positiontype, carrierid);
                    v_hiredquitdates(positiontype, "0");

                }

            }

            function onCurrentPastChanged(sender, args) {

                if (block_v_employer == false && block_OnChangedEvents == false) {

                    var positiontype = $find("<%=PositionTypeRCB.ClientID %>").get_selectedItem().get_value();
                    var currentpastvalue = sender.get_selectedItem().get_value();
                    v_hiredquitdates(positiontype, currentpastvalue);

                    var carrierid = document.getElementById("<%= HiddenTB_CarrierID.ClientID %>").value;
                    v_employer(positiontype, carrierid, currentpastvalue);
                    if (positiontype=="2") {
                        set_carriervalues_disable("no", positiontype);
                    }
                }

            }

            function onCarrierDelClicked() {

                var carrierid = document.getElementById("<%= HiddenTB_CarrierID.ClientID %>").value;
                var carrierdatastatus = document.getElementById("<%= HiddenTB_CarrierDataStatus.ClientID %>").value;

                if (carrierdatastatus == "Edit") {

                    var EditWarningRTT = $find("<%=EditWarningRTT.ClientID %>");
                    var EditCurrentJobWarningRTT = $find("<%=EditCurrentJobWarningRTT.ClientID %>");

                    SendCallBack("CarrierValues," + carrierid, "CarrierValues");
                    set_carriervalues_disable("yes", "1");
                    $find("<%=CarrierEditRB.ClientID %>").set_text("Edit");
                    document.getElementById("<%=CarrierInfoLbl.ClientID %>").innerHTML = "Carrier Info";
                    EditWarningRTT.hide();
                    EditCurrentJobWarningRTT.hide();
                    document.getElementById("HiddenTB_CarrierDataStatus").value = "Selected";

                } else {

                    confirmCall("CarrierDel", carrierid, "Remove Carrier");

                }

            }

            function onCarrierEditClicked(sender, args) {

                var EditWarningRTT = $find("<%=EditWarningRTT.ClientID %>");
                var EditCurrentJobWarningRTT = $find("<%=EditCurrentJobWarningRTT.ClientID %>");

                var button = sender;
                var buttontext = sender.get_text();
                var carrierdatastatus = document.getElementById("<%= HiddenTB_CarrierDataStatus.ClientID %>");

                if (buttontext == "Edit") {

                    var carriername = document.getElementById("<%=CarrierNameRTB.ClientID%>").value;
                    if (carriername == null) {
                        carriername = "Carrier"
                    }
                    if (carrierdatastatus.value != "Add") {
                        carrierdatastatus.value = "Edit"
                    }
                    document.getElementById("JobRW_C_CarrierInfoLbl").innerHTML = '<font color="red">Editing</font> ' + carriername;

                    var myMessage = 'You are currently <font color="red">editing</font> ' + carriername + ', click the "X" above to cancel your changes.';

                    if ($find("<%=CurrentPastRCB.ClientID %>").get_value() == "2") {
                        EditCurrentJobWarningRTT.set_content(myMessage);
                        setTimeout(function () {
                            EditCurrentJobWarningRTT.show();
                        }, 100);
                    } else {
                        EditWarningRTT.set_content(myMessage);
                        setTimeout(function () {
                            EditWarningRTT.show();
                        }, 100);
                    }
                    sender.set_text("Save");
                    set_carriervalues_disable("no", "1");

                } else {

                    sender.set_text("Edit");
                    document.getElementById("JobRW_C_CarrierInfoLbl").innerHTML = "Carrier Info";
                    if (carrierdatastatus.value != "Add") {
                        carrierdatastatus.value = "Selected";
                    }
                    EditCurrentJobWarningRTT.hide();
                    EditWarningRTT.hide();
                    get_LatLong();
                    set_carriervalues_disable("yes", "1");

                }

            }

            function onJobSaveClicked(sender, args) {

                //var carrierdatastatus = document.getElementById("<%= HiddenTB_CarrierDataStatus.ClientID %>").value;
                if ($find("<%=CarrierEditRB.ClientID %>").get_text() == "Save") {

                    var tooltip1 = $find("<%=SaveWarningRTT.ClientID%>");
                    var message = "<span style='color: #FF0000;'><strong>WARNING:</span></strong> Before saving and closing this job, please save your changes to this carrier.";
                    tooltip1.set_content(message);
                    tooltip1.show();
                    sender.set_autoPostBack(false);

                } else {
                    
                    var positiontype = $find("<%=PositionTypeRCB.ClientID %>").get_value();
                    sender.set_autoPostBack(true);
                }

            }

            function onCarrierAddClicked() {

                set_carriervalues("0");
                document.getElementById("<%= HiddenTB_CarrierDataStatus.ClientID %>").value = "Add";
                set_carriervalues_disable("no", "1");
                v_employer("1", "0", "1");
                var carriereditrb = $find("<%=CarrierEditRB.ClientID %>");
                carriereditrb.set_text("Add");
            }

            function onComplete(checked) {

                if (checked) {
                    alert("Add verification on checked.")
                }

            }

            function onVerifyClicked(sender, args) {

                var toggleindex = sender.get_selectedToggleStateIndex();
                v_VerifyLabels(toggleindex);

            }

            function onLockClicked(sender, args) {

                var toggleindex = sender.get_selectedToggleStateIndex();

                var positiontype = $find("<%=PositionTypeRCB.ClientID %>").get_value();
                var miles = $find("<%=MilesRTB.ClientID%>").get_value();
                var carriername = $find("<%=CarrierNameRTB.ClientID%>").get_value();
                var unemployednotes = $find("<%=UnemployedNotesRE.ClientID%>").get_html(true);
                var currentpastvalue = $find("<%=CurrentPastRCB.ClientID %>").get_value();
                var reasonleft = $find("<%=ReasonLeftRCB.ClientID%>").get_value();

                var message;
                var carrierwarning = "<span style='color: #FF0000;'><strong>WARNING:</span></strong> Before marking this item as complete, you must enter your employeer's name, at a minimum.  If you worked for this company within the the past three years, also please enter at least a phone number or email address so that your employment can be verified.";
                var mileswarning = "<span style='color: #FF0000;'><strong>WARNING:</span></strong> Estimating miles is critical to creating a strong FASTPORT.  Please estimate miles before marking this item as complete (click the 'Demo Video' button above to learn more).";
                var reasonleftwarning = "<span style='color: #FF0000;'><strong>WARNING:</span></strong> Before marking this item as complete, you must provide the reason(s) for leaving this job.";
                var unemployednoteswarning = "<span style='color: #FF0000;'><strong>WARNING:</span></strong> Before marking this item as complete, you must provide the reason(s) for unemployment.";

                if (toggleindex == 1) {

                if (positiontype == "1") {

                        if ((carriername == null || carriername == "") && (miles == "0" || miles == null || miles == "") && (reasonleft == null || reasonleft == "0" || reasonleft == "") && (currentpastvalue == "1")) {

                            message = carrierwarning + "<br />" + mileswarning + "<br />" + reasonleftwarning;
                            showLockRTT($find("<%=CarrierNameRTB.ClientID%>"), message);

                        } else if ((carriername == null || carriername == "") && (miles == "0" || miles == null || miles == "")) {

                            message = carrierwarning + "<br />" + mileswarning;
                            showLockRTT($find("<%=MilesRTB.ClientID%>"), message);

                        } else if ((miles == "0" || miles == null || miles == "") && (reasonleft == null || reasonleft == "0" || reasonleft == "") && (currentpastvalue == "1")) {

                            message = mileswarning + "<br />" + reasonleftwarning;
                            showLockRTT($find("<%=MilesRTB.ClientID%>"), message);

                        } else if ((carriername == null || carriername == "") && (reasonleft == null || reasonleft == "0" || reasonleft == "") && (currentpastvalue == "1")) {

                            message = carrierwarning + "<br />" + reasonleftwarning;
                            showLockRTT($find("<%=CarrierNameRTB.ClientID%>"), message);

                        } else if (carriername == null || carriername == "") {

                            message = carrierwarning;
                            showLockRTT($find("<%=CarrierNameRTB.ClientID%>"), message);

                        } else if (miles == "0" || miles == null || miles == "") {

                            message = mileswarning;
                            showLockRTT($find("<%=MilesRTB.ClientID%>"), message);

                        } else if ((reasonleft == null || reasonleft == "0" || reasonleft == "") && (currentpastvalue == "1")) {

                            message = reasonleftwarning;
                            showLockRTT($find("<%=ReasonLeftRCB.ClientID%>"), message);

                        } else {
                            set_all_disable("yes");
                        }

                    } else if (positiontype == "2") {

                        if (carriername == null || carriername == "") {

                            message = carrierwarning;
                            showLockRTT($find("<%=CarrierNameRTB.ClientID%>"), message);

                        } else {

                            set_all_disable("yes");
                        }

                    } else if (positiontype == "3") {

                        if (unemployednotes == null || unemployednotes == "") {

                            message = unemployednoteswarning;
                            showLockRTT($find("<%=UnemployedNotesRE.ClientID%>"), message);
                        } else {

                            set_all_disable("yes");
                        }

                    }

                } else {

                    set_all_disable("no");
                }

                //If you are on tab 1, and the error is on tab 2, need to (1) move to tab two using the exisiting function and (2) point to the right wrong field.
                //If more than 1 thing is wrong, list both problems, but point to the "first" field with a problem.
                //Looks like most of your logic is in the "back" function below.

            }

            var geocoder;
//            var map;

//            function initialize() {
//                geocoder = new google.maps.Geocoder();
//                var latlng = new google.maps.LatLng(-34.397, 150.644);
//                var mapOptions = {
//                    zoom: 8,
//                    center: latlng,
//                    mapTypeId: google.maps.MapTypeId.ROADMAP
//                }
//                map = new google.maps.Map(document.getElementById("map-canvas"), mapOptions);
//            }

            function get_LatLong() {
                
                geocoder = new google.maps.Geocoder();
                var street = $find("<%=CarrierAddrRTB.ClientID%>").get_value();
                var zip = $find("<%=CarrierZipRCB.ClientID %>").get_text();
                var address = street + ", " + zip;

                geocoder.geocode( { 'address': address}, function(results, status) {
                    if (status == google.maps.GeocoderStatus.OK) {
                        document.getElementById("HiddenTB_CarrierLat").value = results[0].geometry.location.ob;
                        document.getElementById("HiddenTB_CarrierLong").value = results[0].geometry.location.pb;
                    } else {
                        alert("Geocode was not successful for the following reason: " + status);
                    }
                });

            }


            ////////////////////////////////
            //HISTORY Set control values.
            ////////////////////////////////

            function set_currentpastvalue(positiontype, currentpastvalue) {

                var CurrentPastRCB = $find("<%=CurrentPastRCB.ClientID %>");
                itemselectRCB(CurrentPastRCB, currentpastvalue);

            }


            function set_values(historyid) {

                var HiddenTB_HistoryID = document.getElementById("<%= HiddenTB_HistoryID.ClientID %>");

                set_all_disable("no");
                if (historyid == "0") {

                    var PositionTypeRCB = $find("<%=PositionTypeRCB.ClientID %>");
                    var CurrentPastRCB = $find("<%=CurrentPastRCB.ClientID %>");
                    var HiredRDP = $find("<%=HiredRDP.ClientID %>");
                    var QuitRDP = $find("<%=QuitRDP.ClientID %>");
                    var CommVechCB = document.getElementById("JobRW_C_CommVechCB");
                    var DrugProgramCB = document.getElementById("JobRW_C_DrugProgramCB");
                    var VerifyRB = $find("<%=VerifyRB.ClientID%>");
                    var CarrierZipRCB = $find("<%=CarrierZipRCB.ClientID%>");
                    var ReasonLeftRCB = $find("<%=ReasonLeftRCB.ClientID%>");
                    var LockRB = $find("<%=LockRB.ClientID%>");
                    var FirstJobRB = $find("<%=FirstJobRB.ClientID %>");

                    HiddenTB_HistoryID.value = "0";
                    PositionTypeRCB.clearSelection();
                    itemselectRCB(PositionTypeRCB, "0");
                    CurrentPastRCB.clearSelection();
                    itemselectRCB(CurrentPastRCB, "0");
                    HiredRDP.clear();
                    QuitRDP.clear();
                    document.getElementById("<%= HiddenTB_CarrierID.ClientID %>").value = "0";
                    $find("<%=CarrierNameRTB.ClientID%>").set_value("");
                    $find("<%=CarrierAddrRTB.ClientID%>").set_value("");
                    CarrierZipRCB.set_value("");
                    CarrierZipRCB.set_text("");
                    $find("<%=CarrierCountryRCB.ClientID%>").set_value("");
                    $find("<%=CarrierCountryRCB.ClientID%>").set_text("");
                    $find("<%=CarrierEmailRTB.ClientID%>").set_value("");
                    $find("<%=CarrierPhoneRTB.ClientID%>").set_value("");
                    $find("<%=CarrierFaxRTB.ClientID%>").set_value("");
                    $find("<%=ContactRTB.ClientID%>").set_value("");
                    document.getElementById("<%= HiddenTB_CarrierDataStatus.ClientID %>").value = "0";
                    $find("<%=MilesRTB.ClientID%>").set_value("0");
                    ReasonLeftRCB.set_value("0");
                    ReasonLeftRCB.set_text("**Please Select**");
                    CommVechCB.checked = true;
                    DrugProgramCB.checked = true;
                    VerifyRB.set_selectedToggleStateIndex(0);
                    v_VerifyLabels("0");
                    FirstJobRB.set_selectedToggleStateIndex(0);
                    LockRB.set_selectedToggleStateIndex(0);

                    var reasonleftre = $find("<%=ReasonLeftRE.ClientID%>");
                    reasonleftre.set_html("");

                    var unemployednotesre = $find("<%=UnemployedNotesRE.ClientID%>");
                    unemployednotesre.set_html("");

                    var employmentnotesre = $find("<%=EmploymentNotesRE.ClientID%>");
                    employmentnotesre.set_html("");

                    set_carriervalues("0");
                    v_currentpast("0");
                    v_hiredquitdates("0", "0");
                    v_employer("0", "0", "0");

                } else {

                    HiddenTB_HistoryID.value = historyid
                    SendCallBack("HistValues," + historyid, "HistValues");

                }
            }

            function set_values_back(arg) {

                var myString = arg;
                var mySplit = myString.split("<||>", 2);

                var histvalues = mySplit[0] || "";
                var carriervalues = mySplit[1] || "";

                block_OnChangedEvents = true;
                set_values_back_hist(histvalues, carriervalues);
                block_OnChangedEvents = false;

            }

            function set_values_back_hist(arg, carriervalues) {

                var myString = arg;
                var mySplit = myString.split("<|>", 26);

                var StartMonth = mySplit[0] || "";
                var EndMonth = mySplit[1] || "";
                var PositionTypeID = mySplit[2] || "";
                var CurrentPastID = mySplit[3] || "";
                var CarrierID = mySplit[4] || "";
                var EmployerCompany = mySplit[5] || "";
                var EmployerAddr = mySplit[6] || "";
                var EmployerZipID = mySplit[7] || "";
                var EmployerCitySTZip = mySplit[8] || "";
                var EmployerCountryID = mySplit[9] || "";
                var EmployerCountry = mySplit[10] || "";
                var EmployerEmail = mySplit[11] || "";
                var EmployerPhone = mySplit[12] || "";
                var EmployerFax = mySplit[13] || "";
                var EmployerContact = mySplit[14] || "";
                var MilesPerWeek = mySplit[15] || "";
                var ReasonForLeavingID = mySplit[16] || "";
                var ReasonForLeaving = mySplit[17] || "";
                var ReasonForLeavingNotes = mySplit[18] || "";
                var OperatedCommercialMotorVechicle = mySplit[19] || "";
                var HadDrugTestingProgram = mySplit[20] || "";
                var Notes = mySplit[21] || "";
                var MayWeContact = mySplit[22] || "";
                var FirstJob = mySplit[23] || "";
                var ShowFirstJob = mySplit[24] || "";
                var Finished = mySplit[25] || "";

                document.getElementById("HiddenTB_CarrierAddr").value = EmployerAddr;
                document.getElementById("HiddenTB_CarrierZipID").value = EmployerZipID;
                document.getElementById("HiddenTB_CarrierCitySTZip").value = EmployerCitySTZip;
                document.getElementById("HiddenTB_CarrierCountryID").value = EmployerCountryID;
                document.getElementById("HiddenTB_CarrierCountry").value = EmployerCountry.substr(0,13);

                var LockRB = $find("<%=LockRB.ClientID%>");
                if (LockRB.get_selectedToggleState() == 1) {
                    set_all_disable("no");
                }

                var PositionTypeRCB = $find("<%=PositionTypeRCB.ClientID %>");
                itemselectRCB(PositionTypeRCB, PositionTypeID);

                v_currentpast(PositionTypeID);

                var CurrentPastRCB = $find("<%=CurrentPastRCB.ClientID %>");
                itemselectRCB(CurrentPastRCB, CurrentPastID);

                var HiredRDP = $find("<%=HiredRDP.ClientID%>");
                var QuitRDP = $find("<%=QuitRDP.ClientID%>");

                if (StartMonth) {
                    HiredRDP.set_selectedDate(getDateFromString(StartMonth));
                }

                if (EndMonth) {
                    QuitRDP.set_selectedDate(getDateFromString(EndMonth));
                }

                if (CarrierID == "0") {
                    document.getElementById("<%= HiddenTB_CarrierID.ClientID %>").value = "0";
                    $find("<%=CarrierNameRTB.ClientID%>").set_value(EmployerCompany);
                    $find("<%=CarrierAddrRTB.ClientID%>").set_value(EmployerAddr);
                    var CarrierZipRCB = $find("<%=CarrierZipRCB.ClientID%>");
                    if (EmployerZipID != "0") {
                        CarrierZipRCB.set_value(EmployerZipID);
                        CarrierZipRCB.set_text(EmployerCitySTZip);
//                        document.getElementById("HiddenTB_CarrierZipID").value = EmployerZipID;
//                        document.getElementById("HiddenTB_CarrierCitySTZip").value = EmployerCitySTZip;
                    } else {
                        CarrierZipRCB.set_value(document.getElementById("HiddenTB_CarrierZipID").value);
                        CarrierZipRCB.set_text(document.getElementById("HiddenTB_CarrierCitySTZip").value);
                    }
                    var CarrierCountryRCB = $find("<%=CarrierCountryRCB.ClientID%>")
                    itemselectRCB(CarrierCountryRCB, EmployerCountryID);
                    $find("<%=CarrierEmailRTB.ClientID%>").set_value(EmployerEmail);
                    $find("<%=CarrierPhoneRTB.ClientID%>").set_value(EmployerPhone);
                    $find("<%=CarrierFaxRTB.ClientID%>").set_value(EmployerFax);
                    $find("<%=ContactRTB.ClientID%>").set_value(EmployerContact);
                    document.getElementById("<%= HiddenTB_CarrierDataStatus.ClientID %>").value = "0";
                } else {
                    document.getElementById("<%= HiddenTB_CarrierID.ClientID %>").value = CarrierID;
                    set_carriervalues_back(carriervalues);
                    set_carriervalues_disable("yes", PositionTypeID);
                }

                $find("<%=MilesRTB.ClientID%>").set_value(MilesPerWeek);

                var ReasonLeftRCB = $find("<%=ReasonLeftRCB.ClientID%>");
                itemselectRCB(ReasonLeftRCB, ReasonForLeavingID);

                var ReasonLeftRE = $find("<%=ReasonLeftRE.ClientID%>");
                ReasonLeftRE.set_html(ReasonForLeavingNotes);

                var CommVechCB = document.getElementById("JobRW_C_CommVechCB");
                if (OperatedCommercialMotorVechicle == "True" || OperatedCommercialMotorVechicle == "true") {
                    CommVechCB.checked = true
                } else {
                    CommVechCB.checked = false
                }

                var DrugProgramCB = document.getElementById("JobRW_C_DrugProgramCB");
                if (HadDrugTestingProgram == "True" || HadDrugTestingProgram == "true") {
                    DrugProgramCB.checked = true
                } else {
                    DrugProgramCB.checked = false
                }

                var UnemployedNotesRE = $find("<%=UnemployedNotesRE.ClientID%>");
                var EmploymentNotesRE = $find("<%=EmploymentNotesRE.ClientID%>");
                if (PositionTypeID != "3") {
                    UnemployedNotesRE.set_html("");
                    EmploymentNotesRE.set_html(Notes);
                } else {
                    UnemployedNotesRE.set_html(Notes);
                    EmploymentNotesRE.set_html("");
                }

                var VerifyRB = $find("<%=VerifyRB.ClientID%>");
                if (MayWeContact == "True" || MayWeContact == "true") {
                    VerifyRB.set_selectedToggleStateIndex(1);
                    v_VerifyLabels("1");
                } else {
                    VerifyRB.set_selectedToggleStateIndex(0);
                    v_VerifyLabels("0");
                }

                var FirstJobRB = $find("<%=FirstJobRB.ClientID %>");
                if (FirstJob == "True" || FirstJob == "true") {
                    FirstJobRB.set_selectedToggleStateIndex(1);
                } else {
                    FirstJobRB.set_selectedToggleStateIndex(0);
                }
                v_firstjob(ShowFirstJob);
                v_hiredquitdates(PositionTypeID, CurrentPastID);
                v_employer(PositionTypeID, CarrierID, CurrentPastID);

                if (Finished == "True" || Finished == "true") {
                    LockRB.set_selectedToggleStateIndex(1);
                    set_all_disable("yes");
                } else {
                    LockRB.set_selectedToggleStateIndex(0);
                    set_all_disable("no");
                    PositionTypeRCB.get_inputDomElement().focus();
                }
            }

            function set_carriervalues(carrierid) {

                var HiddenTB_CarrierID = document.getElementById("<%= HiddenTB_CarrierID.ClientID %>");

                if (carrierid != "0") {
                    HiddenTB_CarrierID.value = carrierid;
                    SendCallBack("CarrierValues," + carrierid, "CarrierValues");
                } else {
                    HiddenTB_CarrierID.value = "0";
                    $find("<%=CarrierNameRTB.ClientID%>").set_value("");
                    $find("<%=CarrierAddrRTB.ClientID%>").set_value("");
                    var CarrierZipRCB = $find("<%=CarrierZipRCB.ClientID%>");
                    CarrierZipRCB.set_value("");
                    CarrierZipRCB.set_text("");
                    var CarrierCountryRCB = $find("<%=CarrierCountryRCB.ClientID%>")
                    itemselectRCB(CarrierCountryRCB, "3");
                    $find("<%=CarrierEmailRTB.ClientID%>").set_value("");
                    $find("<%=CarrierPhoneRTB.ClientID%>").set_value("");
                    $find("<%=CarrierFaxRTB.ClientID%>").set_value("");
                    $find("<%=ContactRTB.ClientID%>").set_value("");
                    $find("<%=DOTNumberRTB.ClientID%>").set_value("");
                    $find("<%=MCNumberRTB.ClientID%>").set_value("");
                    document.getElementById("<%= HiddenTB_CarrierDataStatus.ClientID %>").value = "0";
                }

            }

            function set_carriervalues_back(arg) {


                var myString = arg;
                var mySplit = myString.split("<|>", 13);

                var name = mySplit[0] || "";
                var addr = mySplit[1] || "";
                var addr2 = mySplit[2] || "";
                var zipid = mySplit[3] || "";
                var citystzip = mySplit[4] || "";
                var countryid = mySplit[5] || "";
                var country = mySplit[6] || "";
                var email = mySplit[7] || "";
                var phone = mySplit[8] || "";
                var fax = mySplit[8] || "";
                var dot = mySplit[10] || "";
                var mc = mySplit[11] || "";
                var admin = mySplit[12] || "";

                if (zipid == "" || citystzip == "" || countryid == "") {
                    addr = document.getElementById("HiddenTB_CarrierAddr").value;
                    zipid = document.getElementById("HiddenTB_CarrierZipID").value;
                    citystzip = document.getElementById("HiddenTB_CarrierCitySTZip").value;
                    countryid = document.getElementById("HiddenTB_CarrierCountryID").value;
                    country = document.getElementById("HiddenTB_CarrierCountry").value;
                }
                $find("<%=CarrierNameRTB.ClientID%>").set_value(name);
                $find("<%=CarrierAddrRTB.ClientID%>").set_value(addr);
                var CarrierZipRCB = $find("<%=CarrierZipRCB.ClientID%>");
                CarrierZipRCB.set_value(zipid);
                CarrierZipRCB.set_text(citystzip);
                itemselectRCB($find("<%=CarrierCountryRCB.ClientID%>"), countryid);
                $find("<%=CarrierCountryRCB.ClientID%>").set_text(country);
                $find("<%=CarrierEmailRTB.ClientID%>").set_value(email);
                $find("<%=CarrierPhoneRTB.ClientID%>").set_value(phone);
                $find("<%=CarrierFaxRTB.ClientID%>").set_value(fax);
                $find("<%=DOTNumberRTB.ClientID%>").set_value(dot);
                $find("<%=MCNumberRTB.ClientID%>").set_value(mc);
                document.getElementById("HiddenTB_CarrierAdminYesNo").value = admin

                v_carriereditrb(admin);

            }

            function set_all_disable(disableyesno) {

                var postiontype = 0;
                var postiontypeselected = $find("<%=PositionTypeRCB.ClientID %>").get_selectedItem()
                if (postiontypeselected) {
                    var positiontype = postiontypeselected.get_value();
                }

                if (disableyesno == "yes") {

                    $find("<%=PositionTypeRCB.ClientID%>").disable();
                    $find("<%=CurrentPastRCB.ClientID%>").disable();
                    $find("<%=HiredRDP.ClientID%>").set_enabled(false);
                    $find("<%=QuitRDP.ClientID%>").set_enabled(false);
                    $find("<%=CarrierEditRB.ClientID%>").set_enabled(false);
                    $find("<%=CarrierDelRB.ClientID %>").set_enabled(false);
                    $find("<%=MilesRTB.ClientID%>").disable();
                    $find("<%=ReasonLeftRCB.ClientID%>").disable();
                    $find("<%=ReasonLeftRE.ClientID%>").set_mode(4);
                    document.getElementById("JobRW_C_CommVechCB").disabled = true;
                    document.getElementById("JobRW_C_DrugProgramCB").disabled = true;
                    $find("<%=UnemployedNotesRE.ClientID%>").set_mode(4);
                    $find("<%=EmploymentNotesRE.ClientID%>").set_mode(4);
                    $find("<%=VerifyRB.ClientID%>").set_enabled(false);
                    $find("<%=FirstJobRB.ClientID %>").set_enabled(false);
                    v_JobLockLabels(1);
                    //Passing "1" as positiontype to lock all fields when everything is locked.
                    set_carriervalues_disable("yes", "1");

                } else {

                    $find("<%=PositionTypeRCB.ClientID%>").enable();
                    $find("<%=CurrentPastRCB.ClientID%>").enable();
                    $find("<%=HiredRDP.ClientID%>").set_enabled(true);
                    $find("<%=QuitRDP.ClientID%>").set_enabled(true);
                    var carrieradminyesno = document.getElementById("HiddenTB_CarrierAdminYesNo").value;
                    v_carriereditrb(carrieradminyesno);
                    $find("<%=CarrierDelRB.ClientID %>").set_enabled(true);
                    $find("<%=MilesRTB.ClientID%>").enable();
                    $find("<%=ReasonLeftRCB.ClientID%>").enable();
                    $find("<%=ReasonLeftRE.ClientID%>").set_mode(1);
                    document.getElementById("JobRW_C_CommVechCB").disabled = false;
                    document.getElementById("JobRW_C_DrugProgramCB").disabled = false;
                    $find("<%=UnemployedNotesRE.ClientID%>").set_mode(1);
                    $find("<%=EmploymentNotesRE.ClientID%>").set_mode(1);
                    $find("<%=VerifyRB.ClientID%>").set_enabled(true);
                    $find("<%=FirstJobRB.ClientID %>").set_enabled(true);
                    v_JobLockLabels(0);
                    set_carriervalues_disable("yes", positiontype);
                }

            }

            function set_carriervalues_disable(disableyesno, positiontype) {

                if (disableyesno == "yes" && positiontype == "1") {

                    $find("<%=CarrierNameRTB.ClientID%>").disable();
                    $find("<%=CarrierAddrRTB.ClientID%>").disable();
                    $find("<%=CarrierZipRCB.ClientID%>").disable();
                    $find("<%=CarrierCountryRCB.ClientID%>").disable();
                    $find("<%=CarrierCountryRCB.ClientID%>").disable();
                    $find("<%=CarrierEmailRTB.ClientID%>").disable();
                    $find("<%=CarrierPhoneRTB.ClientID%>").disable();
                    $find("<%=CarrierFaxRTB.ClientID%>").disable();
                    $find("<%=ContactRTB.ClientID%>").disable();
                    $find("<%=DOTNumberRTB.ClientID%>").disable();
                    $find("<%=MCNumberRTB.ClientID%>").disable();

                } else {

                    $find("<%=CarrierNameRTB.ClientID%>").enable();
                    $find("<%=CarrierAddrRTB.ClientID%>").enable();
                    $find("<%=CarrierZipRCB.ClientID%>").enable();
                    $find("<%=CarrierCountryRCB.ClientID%>").enable();
                    $find("<%=CarrierCountryRCB.ClientID%>").enable();
                    $find("<%=CarrierEmailRTB.ClientID%>").enable();
                    $find("<%=CarrierPhoneRTB.ClientID%>").enable();
                    $find("<%=CarrierFaxRTB.ClientID%>").enable();
                    $find("<%=ContactRTB.ClientID%>").enable();
                    $find("<%=DOTNumberRTB.ClientID%>").enable();
                    $find("<%=MCNumberRTB.ClientID%>").enable();
                }

            }

            function onHiredChanged(sender, args) {

                if (block_OnChangedEvents == false) {

                    var histid = document.getElementById("<%= HiddenTB_HistoryID.ClientID %>").value;
                    var partyid = document.getElementById("<%= HiddenTB_PartyID.ClientID %>").value;
                    var currentpastid = $find("<%=CurrentPastRCB.ClientID %>").get_value();
                    var startmonthselecteddate = sender.get_selectedDate()
                    var startmonth = "Null"
                    if (startmonthselecteddate) {
                        startmonth = startmonthselecteddate.toLocaleDateString();
                    }
                    var endmonthselecteddate = $find("<%=QuitRDP.ClientID %>").get_selectedDate()
                    var endmonth = "Null"
                    if (endmonthselecteddate) {
                        endmonth = endmonthselecteddate.toLocaleDateString();
                    }
                    SendCallBack("DateWarning1," + histid + "," + currentpastid + "," + partyid + "," + startmonth + "," + endmonth, "DateWarning1");
                }
            }

            function onHiredChanged_back(arg) {

                var myString = arg;
                var mySplit = myString.split("<||>", 2);

                v_firstjob(mySplit[0] || "");

                w_dates(mySplit[1] || "");
            }


            function onQuitChanged(sender, args) {


                if (block_OnChangedEvents == false) {

                    var histid = document.getElementById("<%= HiddenTB_HistoryID.ClientID %>").value;
                    var currentpastid = $find("<%=CurrentPastRCB.ClientID %>").get_value();
                    var startmonth = $find("<%=HiredRDP.ClientID %>").get_selectedDate().toLocaleDateString();
                    var endmonth = sender.get_selectedDate().toLocaleDateString();
                    SendCallBack("DateWarning," + histid + "," + currentpastid + "," + startmonth + "," + endmonth, "DateWarning");

                }

            }

            function onQuitChanged_back(arg) {

                var myString = arg;
                var mySplit = myString.split("<|>", 3);

                var myReturn = mySplit[0] || "";
                var myTabIndex = mySplit[1] || "";
                var myAction = mySplit[2] || "";

                if (myReturn == "Yes") {

                    //Switch tabs if necessary.
                    if (myTabIndex != "No") {

                        switchJobRWTab(myTabIndex);

                    }

                    //Display RTT.
                    if (myAction != null && myAction != "") {

                        var tooltip = $find("<%=QuitRTT.ClientID %>");
                        tooltip.set_content(myAction);
                        tooltip.show();

                    }

                }

            }

            function onMCNumberChanged(sender, args) {

                if (block_OnChangedEvents == false && sender.get_value().length >= 5) {

                    var employerid = document.getElementById("<%= HiddenTB_CarrierID.ClientID %>").value
                    var mcnumber = sender.get_value();
                    SendCallBack("MCNumberDup," + mcnumber + "," + employerid, "MCNumberDup");
                }
            }

            function onMCNumberChanged_back(arg) {

                var myString = arg;
                var mySplit = myString.split("<|>", 2);

                var myReturn = mySplit[0] || "";
                var myWarning = mySplit[1] || "";

                if (myReturn == "Yes") {

                    var tooltip = $find("<%=MCDupRTT.ClientID %>");
                    tooltip.set_content(myWarning);
                    tooltip.show();
                }
            }

            function onDOTNumberChanged(sender, args) {

                if (block_OnChangedEvents == false) {

                    var employerid = document.getElementById("<%= HiddenTB_CarrierID.ClientID %>").value
                    var dotnumber = sender.get_value();
                    SendCallBack("DOTNumberDup," + dotnumber + "," + employerid, "DOTNumberDup")

                }
            }

            function onDOTNumberChanged_back(arg) {

                var myString = arg;
                var mySplit = myString.split("<|>", 2);

                var myReturn = mySplit[0] || "";
                var myWarning = mySplit[1] || "";

                if (myReturn == "Yes") {

                    var tooltip = $find("<%=DOTDupRTT.ClientID %>");
                    tooltip.set_content(myWarning);
                    tooltip.show();

                    var dotnumber = $find("<%= DOTNumberRTB.ClientID %>");
                    dotnumber.set_value("");
                }
            }


            ////////////////////////////////
            //Visibility funtions
            ////////////////////////////////

            function v_currentpast(positiontype) {

                var CurrentPastRow = document.getElementById("CurrentPastRow");

                if (positiontype == "0") {
                    CurrentPastRow.style.display = "none";
                } else {
                    CurrentPastRow.style.display = "";
                    v_currentpastitems(positiontype);
                }

            }

            function v_currentpastitems(positiontype) {

                var CurrentPastRCB = $find("<%=CurrentPastRCB.ClientID %>");
                CurrentPastRCB.get_items().clear();

                if (positiontype == "1" || positiontype == "2") {
                    itemaddRCB(CurrentPastRCB, "0", "**Please Select**");
                    itemaddRCB(CurrentPastRCB, "1", "Past Job");
                    itemaddRCB(CurrentPastRCB, "2", "Current Job");
                } else if (positiontype == "3") {
                    itemaddRCB(CurrentPastRCB, "0", "**Please Select**");
                    itemaddRCB(CurrentPastRCB, "1", "Past Situation");
                    itemaddRCB(CurrentPastRCB, "2", "Current Situation");
                }

            }


            function v_hiredquitdates(positiontype, currentpastvalue) {

                var hiredlbl = document.getElementById("JobRW_C_HiredLbl");
                var quitlbl = document.getElementById("JobRW_C_QuitLbl");
                var QuitRow = document.getElementById("QuitRow");

                if (positiontype == "0" || positiontype == "1" || positiontype == "2") {
                    hiredlbl.innerHTML = "Hired";
                    quitlbl.innerHTML = "Quit";
                } else {
                    hiredlbl.innerHTML = "Start";
                    quitlbl.innerHTML = "End";
                }

                if (currentpastvalue == "1") {
                    QuitRow.style.display = "";
                } else {
                    QuitRow.style.display = "none";
                }

            }

            function v_employer(positiontype, carrierid, currentpastvalue) {

                try {
                    if (currentpastvalue == null || currentpastvalue == "") {
                        var CurrentPastRCB = $find("<%=CurrentPastRCB.ClientID %>");
                        currentpastvalue = CurrentPastRCB.get_value();
                    }
                } catch (err) {
                    currentpastvalue = "0";
                }

                var PickCarrierRow = document.getElementById("PickCarrierRow");
                var EmployerRow = document.getElementById("EmployerRow");
                var name = document.getElementById("JobRW_C_CarrierNameLbl");
                var addr = document.getElementById("JobRW_C_CarrierAddrLbl");
                var email = document.getElementById("JobRW_C_CarrierEmailLbl");
                var phone = document.getElementById("JobRW_C_CarrierPhoneLbl");
                var fax = document.getElementById("JobRW_C_CarrierFaxLbl");
                var DOTNumberRow = document.getElementById("DOTNumberRow");
                var MCNumberRow = document.getElementById("MCNumberRow");
                var carrierinfolbl = document.getElementById("JobRW_C_CarrierInfoLbl");
                var carriereditrb = $find("<%=CarrierEditRB.ClientID %>");
                var carrierdelrb = $find("<%=CarrierDelRB.ClientID %>");
                var contactlbl = document.getElementById("JobRW_C_ContactLbl");
                var ContactRTB = $find("<%=ContactRTB.ClientID %>");
                var carrierdatastatus = document.getElementById("<%= HiddenTB_CarrierDataStatus.ClientID %>").value;
                var UnemployedRow = document.getElementById("UnemployedRow");

                if (currentpastvalue == "0" || currentpastvalue == "") {
                    PickCarrierRow.style.display = "none";
                    EmployerRow.style.display = "none";
                    UnemployedRow.style.display = "none";
                } else if (positiontype == "3") {
                    PickCarrierRow.style.display = "none";
                    EmployerRow.style.display = "none";
                    UnemployedRow.style.display = "";
                } else if (positiontype == "1" && carrierid == "0" && carrierdatastatus != "Add") {
                    PickCarrierRow.style.display = "";
                    EmployerRow.style.display = "none";
                    UnemployedRow.style.display = "none";
                } else {
                    PickCarrierRow.style.display = "none";
                    EmployerRow.style.display = "";
                    UnemployedRow.style.display = "none";
                    if (carrierid != "0" || carrierdatastatus == "Add") {
                        carrierinfolbl.innerHTML = "Carrier Info"
                        name.innerHTML = "Carrier Name";
                        addr.innerHTML = "HQ Address";
                        email.innerHTML = "Safety Email";
                        phone.innerHTML = "Safety Phone";
                        fax.innerHTML = "Safety Fax";
                        contactlbl.innerHTML = "";
                        ContactRTB.set_visible(false);
                        DOTNumberRow.style.display = "";
                        MCNumberRow.style.display = "";
                        carriereditrb.set_visible(true);
                        carrierdelrb.set_visible(true);
                    } else {
                        carrierinfolbl.innerHTML = "Employer Info"
                        name.innerHTML = "Company Name";
                        addr.innerHTML = "Address";
                        email.innerHTML = "Email";
                        phone.innerHTML = "Phone";
                        fax.innerHTML = "Fax";
                        contactlbl.innerHTML = "Contact Info";
                        ContactRTB.set_visible(true);
                        DOTNumberRow.style.display = "none";
                        MCNumberRow.style.display = "none";
                        carriereditrb.set_visible(false);
                        carrierdelrb.set_visible(false);
                    }
                }

                if (positiontype == "1") {

                    var ReasonLeftRow = document.getElementById("ReasonLeftRow");
                    var ReasonLeftNotesRow = document.getElementById("ReasonLeftNotesRow");
                    if (currentpastvalue == "1") {
                        ReasonLeftRow.style.display = "";
                        ReasonLeftNotesRow.style.display = "";
                    } else {
                        ReasonLeftRow.style.display = "none";
                        ReasonLeftNotesRow.style.display = "none";
                    }
                }

                v_JobRTS(positiontype);

            }


            function v_carriereditrb(adminyesno) {

                var carriereditrb = $find("<%=CarrierEditRB.ClientID %>");
                carriereditrb.set_text("Edit");

                if (adminyesno == "Yes") {

                    carriereditrb.set_enabled(false);
                    carriereditrb.set_toolTip("This carrier is an active FASTPORT carrier, and thus, you cannot edit this carriers details.");

                } else {

                    carriereditrb.set_enabled(true);
                    carriereditrb.set_toolTip("Click to edit the details for this carrier.");

                }

            }

            function v_JobRTS(positiontype) {

                var JobRTS = $find("<%=JobRTS.ClientID %>");
                var moretab = JobRTS.get_tabs().getTab(1);
                var finishtab = JobRTS.get_tabs().getTab(2);

                if (positiontype == "0" || positiontype == "1") {

                    moretab.set_visible(true);
                    finishtab.set_visible(true);

                } else if (positiontype == "2") {

                    moretab.set_visible(false);
                    finishtab.set_visible(true);

                } else {

                    moretab.set_visible(false);
                    finishtab.set_visible(false);

                }

            }

            function v_VerifyLabels(toggleindex) {

                var stopverifylbl = document.getElementById("JobRW_C_StopVerifyLbl");
                var goverifylbl = document.getElementById("JobRW_C_GoVerifyLbl");


                if (toggleindex == 0) {
                    stopverifylbl.style.display = "";
                    goverifylbl.style.display = "none";
                } else {
                    stopverifylbl.style.display = "none";
                    goverifylbl.style.display = "";
                }


            }

            function v_firstjob(showfirstjob) {

                var FirstJobRow = document.getElementById("FirstJobRow");

                if (showfirstjob == "Yes") {
                    FirstJobRow.style.display = "";
                } else {
                    FirstJobRow.style.display = "none";
                }
            }

            function w_dates(arg) {

                var mystring = arg;
                var mysplit = mystring.split("<|>", 3);

                var myreturn = mysplit[0] || "";
                var mytabindex = mysplit[1] || "";
                var myaction = mysplit[2] || "";

                if (myreturn == "Yes") {

                    //Switch tabs if necessary.                       

                    if (mytabindex != "No") {

                        switchJobRWTab(mytabindex);

                    }

                    //Display RTT.
                    if (myaction != null && myaction != "") {

                        var tooltip = $find("<%=HiredRTT.ClientID %>");
                        tooltip.set_content(myaction);
                        tooltip.show();

                    }
                }
            }

            function v_JobLockLabels(toggleindex) {

                var lockedlbl = document.getElementById("JobRW_C_LockedLbl");
                var unlockedlbl = document.getElementById("JobRW_C_UnlockedLbl");

                if (toggleindex == 0) {
                    unlockedlbl.style.display = "";
                    lockedlbl.style.display = "none";
                } else {
                    unlockedlbl.style.display = "none";
                    lockedlbl.style.display = "";
                }

            }

            //////////////////////////////////
            //HISOTRY stuff continued
            //////////////////////////////////

            var SplitTargetId;

            function histmouseover(sender) {

                var gridid = sender.lastElementChild.id;
                SplitTargetId = gridid.substring(0, 12);

                if (itemdragging == false) {
                    v_histdiv(sender, "");
                }

            }
            /*Added By Princy-28.5.2013*/


            function histmouseout(sender) {
                v_histdiv(sender, "none");

            }


            function v_histdiv(sender, displaytype) {

                var divindex = null;
                var senderid = sender.id;
                if (senderid > 100) {
                    divindex = 0;
                } else if ((senderid > -1 && senderid < 101) || ((senderid < -1 && senderid > -5) && senderid != -3)) {
                    divindex = 1;
                } else if (senderid != "-9999") {
                    divindex = 2;
                }

                if (divindex != null) {
                    sender.getElementsByTagName("div")[divindex].style.display = displaytype;
                }

            }

            function showGeneralRTT() {

                var tooltip = $find("<%=GeneralRTT.ClientID %>");
                tooltip.show();

            }

            function showLockRTT(target, message) {

                var tooltip;
                var carriertooltip;
                if (document.getElementById("PickCarrierRow").style.display == "none") {
                    carriertooltip = $find("<%=CarrierWarningRTT.ClientID %>");
                } else {
                    carriertooltip = $find("<%=PickCarrierWarningRTT.ClientID %>");
                }
                var milestooltip = $find("<%=MilesWarningRTT.ClientID %>");
                var reasonlefttooltip = $find("<%=ReasonLeftWarningRTT.ClientID %>");
                var unemployednotestooltip = $find("<%=UnemployedNotesWarningRTT.ClientID %>");
                if (target == $find("<%=CarrierNameRTB.ClientID%>")) {
                    tooltip = carriertooltip;
                } else if (target == $find("<%=MilesRTB.ClientID %>")) {
                    tooltip = milestooltip;
                } else if (target == $find("<%=ReasonLeftRCB.ClientID%>")) {
                    tooltip = reasonlefttooltip;
                } else {
                    tooltip = unemployednotestooltip;
                }
                tooltip.set_content(message);

                setTimeout(function () {
                    tooltip.show();
                }, 50);

                var tab;
                $find("<%=LockRB.ClientID%>").set_selectedToggleStateIndex(0);
                set_all_disable("no");
                if (target == $find("<%=CarrierNameRTB.ClientID%>") || target == $find("<%=UnemployedNotesRE.ClientID %>")) {
                    set_carriervalues_disable("no", "1");
                    $find("<%=CarrierEditRB.ClientID %>").set_text("Save");
                    tab = $find("<%=JobRTS.ClientID%>").findTabByValue("0");
                } else {
                    tab = $find("<%=JobRTS.ClientID%>").findTabByValue("1");
                }
                if (tab != null) {
                    tab.set_selected(true);
                    if (target == $find("<%=UnemployedNotesRE.ClientID %>")) {
                        target.setFocus();
                    } else if (target == $find("<%=ReasonLeftRCB.ClientID%>")) {
                        target.get_inputDomElement().focus();
                    } else {
                        target.focus();
                    }

                }

            }

            function hideAllRTT() {

                $find("<%=InstRTT.ClientID %>").hide();
                $find("<%=InfoRTT.ClientID %>").hide();
                $find("<%=PrefRTT.ClientID %>").hide();
                $find("<%=Col1RTT.ClientID %>").hide();
                $find("<%=GeneralRTT.ClientID %>").hide();
                $find("<%=HiredRTT.ClientID %>").hide();
                $find("<%=QuitRTT.ClientID %>").hide();
                $find("<%=DOTDupRTT.ClientID %>").hide();
                $find("<%=MCDupRTT.ClientID %>").hide();
                $find("<%=CarrierWarningRTT.ClientID %>").hide();
                $find("<%=PickCarrierWarningRTT.ClientID %>").hide();
                $find("<%=MilesWarningRTT.ClientID %>").hide();
                $find("<%=ReasonLeftWarningRTT.ClientID %>").hide();
                $find("<%=UnemployedNotesWarningRTT.ClientID %>").hide();
                $find("<%=EditWarningRTT.ClientID %>").hide();
                $find("<%=EditCurrentJobWarningRTT.ClientID %>").hide();
                $find("<%=SaveWarningRTT.ClientID %>").hide();
                $find("<%=RadiusRTT.ClientID %>").hide();
                $find("<%=ExpRTT.ClientID %>").hide();
            }

            function onTabSwitch() {

                var EditWarningRTT = $find("<%=EditWarningRTT.ClientID %>");
                EditWarningRTT.hide();

                var carrierdatastatus = document.getElementById("HiddenTB_CarrierDataStatus").value;
                if (carrierdatastatus == "Edit") {

                    set_carriervalues_disable("yes", "1");
                    $find("<%=CarrierEditRB.ClientID %>").set_text("Edit");
                    document.getElementById("<%=CarrierInfoLbl.ClientID %>").innerHTML = "Carrier Info";
                    document.getElementById("HiddenTB_CarrierDataStatus").value = "Selected";
                }               
                
            }

            /*Added By Princy-28.5.2013*/
            var historyID;
            var itemdragging = false;

            function itemDragStarted(sender, args) {
                itemdragging = true
            }

            function itemDragging(sender, args) {

            }

            function trackDropping(sender, args) {

                itemdragging = false;

                var senderid = sender.get_id();
                senderid = senderid.replace("ctl00_PageContent_", "");

                if (senderid == "R1HistoryRLV") {
                    if (SplitTargetId == "R2HistoryRLV") {
                        SendCallBack("dropJob," + historyID + ",2", "FinishHist");
                        args.set_cancel(true);
                    } else if (SplitTargetId == "R3HistoryRLV") {
                        SendCallBack("dropJob," + historyID + ",3", "FinishHist");
                        args.set_cancel(true);
                    } else {
                        alert("To move this job, drag it to one of the columns to the row below, or to reorder it, move it within this column.");
                        args.set_cancel(true);
                    }
                }

                if (senderid == "R2HistoryRLV") {
                    if (SplitTargetId == "R1HistoryRLV") {
                        SendCallBack("dropJob," + historyID + ",1", "FinishHist");
                        args.set_cancel(true);
                    } else if (SplitTargetId == "R3HistoryRLV") {
                        SendCallBack("dropJob," + historyID + ",3", "FinishHist");
                        args.set_cancel(true);
                    } else {
                        alert("To move this job, drag it to one of the columns to the row below, or to reorder it, move it within this column.");
                        args.set_cancel(true);
                    }
                }

                if (senderid == "R3HistoryRLV") {
                    if (SplitTargetId == "R1HistoryRLV") {
                        SendCallBack("dropJob," + historyID + ",1", "FinishHist");
                        args.set_cancel(true);
                    } else if (SplitTargetId == "R2HistoryRLV") {
                        SendCallBack("dropJob," + historyID + ",2", "FinishHist");
                        args.set_cancel(true);
                    } else {
                        alert("To move this job, drag it to one of the columns to the row below, or to reorder it, move it within this column.");
                        args.set_cancel(true);
                    }
                }

            }

            function FinishHist(args) {

                if (args != "Success") {

                    launchRadAlert(args, "Error");

                } else {

                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindHist");

                }

            }

            function onJobYesNoChecked(args) {

                alert(args);

            }

            function getWindowWidth() {

                var windowwidth = window.innerWidth;
                document.getElementById("HiddenTB_WindowWidth").value = windowwidth;
            }

            function openJobRWNew() {

                document.getElementById("<%= HiddenTB_HistoryID.ClientID %>").value = "0";
                openJobRW("0");
                $find("<%=PositionTypeRCB.ClientID %>").get_inputDomElement().focus();
                v_firstjob("no");

            }

            function openJobRW(histid) {

                if (histid == null) {
                    histid = "0";
                }

                clearsearchvalues("no");
                set_values(histid);

                var oWnd = $find("<%=JobRW.ClientID%>");
                oWnd.show();
                switchJobRWTab(0);

            }

            function openJobRW_wDates(startdate, enddate) {

                set_values("0");
                set_carriervalues("0");
                clearsearchvalues("no");
                v_currentpast("0");
                v_hiredquitdates("0", "0");
                v_employer("0");

                var HiredRDP = $find("<%=HiredRDP.ClientID%>");
                var QuitRDP = $find("<%=QuitRDP.ClientID%>");

                if (startdate) {
                    HiredRDP.set_selectedDate(getDateFromString(startdate));
                }

                if (enddate) {
                    QuitRDP.set_selectedDate(getDateFromString(enddate));
                }

                var oWnd = $find("<%=JobRW.ClientID%>");
                oWnd.show();
                switchJobRWTab(0);
            }


            function closeJobRW() {

                var oWnd = $find("<%=JobRW.ClientID%>");
                oWnd.close();

            }

            function onJobRWClose() {

                document.getElementById("<%= HiddenTB_HistoryID.ClientID %>").value = "0";
                clearsearchvalues("yes");

                $find("<%=PositionTypeRCB.ClientID %>").hideDropDown();
                $find("<%=CurrentPastRCB.ClientID %>").hideDropDown();
                $find("<%=ReasonLeftRCB.ClientID %>").hideDropDown();

                hideAllRTT();

            }

            function switchJobRWTab(tabindex) {

                var tabStrip = $find("<%= JobRTS.ClientID %>");
                var selectedTab = tabStrip.get_selectedTab()
                var selectedTabValue = selectedTab.get_index()

                if (selectedTabValue != tabindex) {

                    var tab = tabStrip.findTabByValue(tabindex);
                    if (tab) {
                        tab.select();
                    }

                }

                $find("<%=EditWarningRTT.ClientID %>").hide();

            }


            //////////////////////////////////////
            //Carrier search stuff.
            /////////////////////////////////////

            function clearsearchvalues(fromRWyesno) {

                document.getElementById("<%= HiddenTB_SearchPartyID.ClientID %>").value = "0";
                document.getElementById("<%= HiddenTB_SearchFree.ClientID %>").value = "0";
                document.getElementById("<%= HiddenTB_SearchRadius.ClientID %>").value = "0";
                document.getElementById("<%= HiddenTB_SearchCityID.ClientID %>").value = "0";
                var PickCarrierRSB = $find("<%= PickCarrierRSB.ClientID %>");
                PickCarrierRSB.get_inputElement().value = "";
                var CityRCB = $find("<%=CityRCB.ClientID%>");
                CityRCB.get_items().clear();
                CityRCB.set_value("");
                CityRCB.set_text("");

                if (fromRWyesno == "yes") {

                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindPickCarrierRG");

                }

            }

            function onCarrierSearch(sender, eventArgs) {

                var searchid = eventArgs.get_value();
                var searchtext = eventArgs.get_text();

                if (searchid == null || searchid == "") {
                    searchid = "0"
                }

                if (searchtext == null || searchtext == "") {
                    searchtext = "0"
                }

                document.getElementById("<%= HiddenTB_SearchPartyID.ClientID %>").value = searchid;
                document.getElementById("<%= HiddenTB_SearchFree.ClientID %>").value = searchtext;

                sender.clear();

                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindPickCarrierRG");

            }


            function onCarrierSearchDataReq(sender, eventArgs) {

                var searchtext = eventArgs.get_text();

                if (searchtext == null || searchtext == "") {
                    searchtext = "0"
                }
                var HiddenTB_SearchFree = document.getElementById("<%= HiddenTB_SearchFree.ClientID %>").value;

                if (HiddenTB_SearchFree != null || HiddenTB_SearchFree != "0") {
                    document.getElementById("<%= HiddenTB_SearchPartyID.ClientID %>").value = "0";
                }
                HiddenTB_SearchFree = searchtext;
            }

            function onCarrierSearchButtonCommand(sender, args) {

                var theCommandButton;
                var commandname = args.get_commandName()

                if (commandname == "CarrierAdd") {
                    onCarrierAddClicked();
                } else if (commandname == "RadiusSearch") {
                    theCommandButton = sender.get_buttons().getButton(1);
                    var RadiusRTT = $find("<%= RadiusRTT.ClientID %>");
                    RadiusRTT.set_targetControl(theCommandButton.get_element());
                    setTimeout(function () {
                        RadiusRTT.show();
                    }, 20);
                }

            }


            function searchRadiusRB() {

                var radius = $find("<%= RadiusRCB.ClientID %>").get_selectedItem().get_value();
                document.getElementById("<%= HiddenTB_SearchRadius.ClientID %>").value = radius;

                var cityid

                try {
                    cityid = $find("<%= CityRCB.ClientID %>").get_selectedItem().get_value();
                } catch (err) {
                    cityid = "0";
                }

                document.getElementById("<%= HiddenTB_SearchCityID.ClientID %>").value = cityid;

                var searchtext = $find("<%= PickCarrierRSB.ClientID %>").get_text();

                if (searchtext == "" || searchtext == null) {
                    searchtext = "0"
                }
                document.getElementById("<%= HiddenTB_SearchFree.ClientID %>").value = searchtext;

                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindPickCarrierRG");

            }

            function onPickCarrierSelected(sender, args) {

                $find("<%= RadiusRTT.ClientID %>").hide();

                var carrierid = args.getDataKeyValue("PartyID");
                document.getElementById("<%= HiddenTB_CarrierID.ClientID %>").value = carrierid;

                set_carriervalues(carrierid);
                document.getElementById("<%= HiddenTB_CarrierDataStatus.ClientID %>").value = "Selected";

                var positiontype = $find("<%=PositionTypeRCB.ClientID %>").get_selectedItem().get_value();
                v_employer(positiontype, carrierid);

                set_carriervalues_disable("yes", positiontype);

            }


            //**********************
            //Section 4 -- Exp Tab
            //**********************

            function onExpRGMouseOver(sender, eventArgs) {

                var rowID = eventArgs.getDataKeyValue("HistoryID");
                document.getElementById("<%= HiddenTB_HistoryHoverID.ClientID %>").value = rowID;

            }

            function set_ForExpRTT(experienceid) {

                document.getElementById("<%= HiddenTB_ExperienceID.ClientID %>").value = experienceid;
                document.getElementById("<%= HiddenTB_HistoryID_ForExpRTT.ClientID %>").value = document.getElementById("<%= HiddenTB_HistoryHoverID.ClientID %>").value;

            }

            function onExp_GenRBClicked(sender, args) {
                ischanging = true;
                set_ForExpRTT("743");
            }

            function onExp_EquipRBClicked(sender, args) {
                ischanging = true;
                set_ForExpRTT("389");
            }

            function onExp_CargoRBClicked(sender, args) {
                ischanging = true;
                set_ForExpRTT("666");
            }

            function onExp_RegionsRBClicked(sender, args) {
                ischanging = true;
                set_ForExpRTT("741");
            }


            var exprgid = "<%= ExpRG.ClientID %>";

            function onNodeDragging(sender, args) {

                var target = args.get_htmlElement();

                if (!target) return;

                var grid = isMouseOverGrid(target)
                if (grid) {
                    grid.style.cursor = "hand";
                } else if (target.tagName == "DropIncidentHere") {
                    target.style.cursor = "hand";
                }
            }

            function isMouseOverGrid(target) {
                parentNode = target;
                while (parentNode != null) {
                    if (parentNode.id == exprgid) {
                        return parentNode;
                    }
                    parentNode = parentNode.parentNode;
                }

                return null;
            }

            function onNodeDropping(sender, args) {

                var elem = args.get_htmlElement();
                var id = elem.id;
                var id9 = id.substring(0, 9);
                var id5 = id.substring(0, 5);

                if (id == "DropExpImg" || id9 == "ItemImage" || id5 == "ExpRG" || id == "DropIncidentImage") {
                    //Go to code behind.
                } else {

                    var row = Telerik.Web.UI.Grid.GetFirstParentByTagName(elem, "tr");
                    var ownerTableViewId = row.id.split("__")[0];
                    var ownerTableView = $find(ownerTableViewId);
                    if (ownerTableView) {
                        if (ownerTableView.get_name() == "ExpTable") {

                            while (elem) {
                                if (elem.id == exprgid) {
                                    args.set_htmlElement(elem);
                                    return;
                                }
                                elem = elem.parentNode;
                            }
                            args.set_cancel(true);
                        }
                    } else {
                        args.set_cancel(true);
                        var mymessage = "<span style='color: #ff0000;'>WARNING:</span> You cannot drop an item here.  INSTEAD, please drop your item on (1) the 'Drop Here' image, to add an item to every record OR (2) on the record itself, to add an item to that specific record."
                        launchRadAlert(mymessage, "Cannot Drop Here")
                        return;
                    }
                }

            }

            function onNodeDropped(sender, eventArgs) {

                var nodes = eventArgs.get_sourceNodes();
                for (var i = 0; i < nodes.length; i++) {
                    nodes[i].set_selected(false);
                }

            }

            function onExpRTT_RGMouseOver(sender, eventArgs) {

                var rowID = eventArgs.getDataKeyValue("PartyExperienceID");
                document.getElementById("<%= HiddenTB_PartyExperienceID.ClientID %>").value = rowID;

            }

            function onExpRTT_LockRBClicked(sender, args) {

                var Locked;
                var togglestate = sender.get_selectedToggleStateIndex();
                if (togglestate == 0) {
                    Locked = "false"
                } else {
                    Locked = "true"
                }

                var rowID = document.getElementById("HiddenTB_PartyExperienceID").value;

                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("updateLock," + rowID + "," + Locked);
            }

            var ischanging = false;

            function onExpRTT_RSStart() {

                ischanging = true;

            }

            function onExpRTT_RSChanging(sender, args) {

                var slidervalue = args.get_newValue()
                document.getElementById("<%= HiddenTB_Slider.ClientID %>").value = slidervalue

            }

            function onExpRTT_RSValueChanged(sender, args) {
                
                if (ischanging == false) {
                    
                    ischanging = true;
                    var sliderValue = args.get_newValue();
                    var rowID = document.getElementById("HiddenTB_PartyExperienceID").value;
                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("updateSlider," + rowID + "," + sliderValue);
                    setTimeout(function () {
                        ischanging = false;
                    }, 3000);     
                }
            }

            function onExpRTT_RSSlideEnd(sender, args) {

                var rowID = document.getElementById("HiddenTB_PartyExperienceID").value;
                var sliderValue = document.getElementById("<%= HiddenTB_Slider.ClientID %>").value;
                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("updateSlider," + rowID + "," + sliderValue);
                setTimeout(function () {
                    ischanging = false;
                }, 3000);     

            }

            function Check(arg) {

            }


            function closeExpRTT() {

                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindExpRG");

            }

            function onExpRTTShow() {

                ischanging = false;

            }

            function onExpRTT_DelIBClick(index) {

                var grid = $find("<%=ExpRTT_RG.ClientID %>");
                var MasterTable = grid.get_masterTableView();
                var row = MasterTable.get_dataItems()[index];
                var partyexperienceid = row.getDataKeyValue("PartyExperienceID");
                var itemname = row.getDataKeyValue("ItemName");
                confirmCall("deleteExpItem", partyexperienceid, itemname)

            }

            function onNodeClicked(sender, eventArgs) {

                var node = eventArgs.get_node();
                node.toggle();
                var nodetext = node.get_text();
                if (nodetext == "True") {
                    node.set_selected(false);
                }

            }

            function onExpLockRB_Load() {
                var toggleindex = $find("<%=ExpLockRB.ClientID %>").get_selectedToggleStateIndex();
                v_ExpLockLabels(toggleindex);
            }


            function onExpLockRB_Clicked(sender) {
                var toggleindex = sender.get_selectedToggleStateIndex();
                v_ExpLockLabels(toggleindex);
            }

            function v_ExpLockLabels(toggleindex) {

                var lockedlbl = document.getElementById("ExpLockedLbl");
                var unlockedlbl = document.getElementById("ExpUnlockedLbl");

                if (toggleindex == 0) {
                    unlockedlbl.style.display = "";
                    lockedlbl.style.display = "none";
                } else {
                    unlockedlbl.style.display = "none";
                    lockedlbl.style.display = "";
                }

            }

            function openExperienceNotes() {

                $find("<%=ExpRTT_RG.ClientID %>").set_visible(false);
                $find("<%=ExperienceNotesRE.ClientID %>").set_visible(true);
                document.getElementById("ExpRTT_SaveCancelDiv").style.display = "";

                var rowID = document.getElementById("<%= HiddenTB_PartyExperienceID.ClientID %>").value;
                SendCallBack("loadExperienceNotes," + rowID, "loadExperienceNotes");

            }

            function openExperienceNotes_back(arg) {

                $find("<%=ExperienceNotesRE.ClientID %>").set_html(arg);

            }

            function onExperienceNotesSave() {

                var ExperienceNotes = $find("<%=ExperienceNotesRE.ClientID %>").get_html(true);
                var rowID = document.getElementById("<%= HiddenTB_PartyExperienceID.ClientID %>").value;
                var ExperienceNotes_parsed = ExperienceNotes.replace(/,/g, "<|>");
                SendCallBack("updateExperienceNotes," + rowID + "," + ExperienceNotes_parsed, "updateExperienceNotes");


            }

            function onExperienceNotesSave_back(arg) {

                //LP-NF: Error handling.
                if (arg == "Nothing") {
                    $find("<%=ExpRTT_RG.ClientID %>").set_visible(true);
                    $find("<%=ExperienceNotesRE.ClientID %>").set_visible(false);
                    document.getElementById("ExpRTT_SaveCancelDiv").style.display = "none";
                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindExpRTT_RG");
                } else {
                    launchRadAlert(arg, "Failed to Save Notes to Experience Item")
                }

            }

            function onExperienceNotesCancel() {

                $find("<%=ExpRTT_RG.ClientID %>").set_visible(true);
                $find("<%=ExperienceNotesRE.ClientID %>").set_visible(false);
                document.getElementById("ExpRTT_SaveCancelDiv").style.display = "none";

            }

            ////////////////////////////////
            //Incidents
            ////////////////////////////////

            
            function onIncidentsMouseOver(sender, eventArgs) {

                var rowID = eventArgs.getDataKeyValue("IncidentID");
                document.getElementById("<%= HiddenTB_IncidentID.ClientID %>").value = rowID;

            }
            
            function onLockIncidentRBClicked(sender, args) {

                var Locked;
                var togglestate = sender.get_selectedToggleStateIndex();
                if (togglestate == 0) {
                    Locked = "false"
                } else {
                    Locked = "true"
                }

                var rowID = document.getElementById("<%= HiddenTB_IncidentID.ClientID %>").value;
                SendCallBack("onLockIncidentRBClicked," + rowID + "," + Locked, "onLockIncidentRBClicked");

            }

            function onLockIncidentRBClicked_back(args) {
                        
            }

            
            function onIncidentsDelIBClick(index,gridname) {

                var grid;
                
                if (gridname == "accidents") {
                    grid = $find("<%=AccidentsRadGrid.ClientID %>");
                } else if (gridname == "incidents") {
                    grid = $find("<%=IncidentsRadGrid.ClientID %>");
                } else if (gridname == "honorsawards") {
                    grid = $find("<%=HonorsAwardsRadGrid.ClientID %>");
                }
                
                var MasterTable = grid.get_masterTableView();
                var row = MasterTable.get_dataItems()[index];
                var incidentid = row.getDataKeyValue("IncidentID");
                confirmCall("deleteIncidentItem", incidentid, "Delete Accident, Event, Other")

            }

            function onIncidentLockRB_Load() {
                var toggleindex = $find("<%=IncidentLockRB.ClientID %>").get_selectedToggleStateIndex();
                v_IncidentLockLabels(toggleindex);
            }


            function onIncidentLockRB_Clicked(sender) {
                var toggleindex = sender.get_selectedToggleStateIndex();
                v_IncidentLockLabels(toggleindex);
            }

            function v_IncidentLockLabels(toggleindex) {

                var lockedlbl = document.getElementById("IncidentLockedLbl");
                var unlockedlbl = document.getElementById("IncidentUnlockedLbl");

                if (toggleindex == 0) {
                    unlockedlbl.style.display = "";
                    lockedlbl.style.display = "none";
                } else {
                    unlockedlbl.style.display = "none";
                    lockedlbl.style.display = "";
                }

            }

            
            function onIncidentsRowClick(sender, eventArgs) {

                var incidentID = eventArgs.getDataKeyValue("IncidentID");
                var incidentcategoryID = eventArgs.getDataKeyValue("IncidentCategoryID");
                CallRadWindow(incidentID + "," + incidentcategoryID,"editIncident");

            }

        </script>
    </telerik:RadScriptBlock>
    <telerik:RadAjaxManager ID="RadAjaxManager1" EnablePageHeadUpdate="false" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadAjaxManager1" />
                    <telerik:AjaxUpdatedControl ControlID="AddrRadSlider" />
                    <telerik:AjaxUpdatedControl ControlID="AddrRadGrid" />
                    <telerik:AjaxUpdatedControl ControlID="PrefRG" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_GeneralRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_EquipRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_CommodityRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_RegionsRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_OtherRAC" />
                    <telerik:AjaxUpdatedControl ControlID="PickCarrierRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="R1Panel" />
                    <telerik:AjaxUpdatedControl ControlID="YearsRadSlider" />
                    <telerik:AjaxUpdatedControl ControlID="HistWarningLtl" />
                    <telerik:AjaxUpdatedControl ControlID="ExpRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="ExpRTT_RG" />
                    <telerik:AjaxUpdatedControl ControlID="ExpLockRB" />
                    <telerik:AjaxUpdatedControl ControlID="AccidentsRadGrid" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="IncidentsRadGrid" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="HonorsAwardsRadGrid" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="FastportRTS">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="MenuRadGrid" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="GaugeImage" />
                    <telerik:AjaxUpdatedControl ControlID="FastportRTS" />
                    <telerik:AjaxUpdatedControl ControlID="MustActRG" />
                    <telerik:AjaxUpdatedControl ControlID="WaitingRG" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="NameRadButton">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="NameRadButton" />
                    <telerik:AjaxUpdatedControl ControlID="EmailTB" />
                    <telerik:AjaxUpdatedControl ControlID="NameTB" />
                    <telerik:AjaxUpdatedControl ControlID="HandleTB" />
                    <telerik:AjaxUpdatedControl ControlID="TruckerTypeRCB" />
                    <telerik:AjaxUpdatedControl ControlID="DirectDialRadTB" />
                    <telerik:AjaxUpdatedControl ControlID="MobileRadTB" />
                    <telerik:AjaxUpdatedControl ControlID="OtherRadTB" />
                    <telerik:AjaxUpdatedControl ControlID="FaxRadTB" />
                    <telerik:AjaxUpdatedControl ControlID="FastportRTS" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="PersonalRadButton">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PersonalRadButton" />
                    <telerik:AjaxUpdatedControl ControlID="DOBRadTB" />
                    <telerik:AjaxUpdatedControl ControlID="SSNRadTB" />
                    <telerik:AjaxUpdatedControl ControlID="DirectDialRadTB" />
                    <telerik:AjaxUpdatedControl ControlID="USCitizenCB" />
                    <telerik:AjaxUpdatedControl ControlID="AuthAlienCB" />
                    <telerik:AjaxUpdatedControl ControlID="AuthTypeRadCombo" />
                    <telerik:AjaxUpdatedControl ControlID="VisaTB" />
                    <telerik:AjaxUpdatedControl ControlID="AuthorizedAlienLabel" />
                    <telerik:AjaxUpdatedControl ControlID="AuthTypeLabel" />
                    <telerik:AjaxUpdatedControl ControlID="VisaLabel" />
                    <telerik:AjaxUpdatedControl ControlID="VisaTB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ProfileRadButton">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ProfileRadButton" />
                    <telerik:AjaxUpdatedControl ControlID="ProfileRadEditor" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="USCitizenCB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="AuthorizedAlienLabel" />
                    <telerik:AjaxUpdatedControl ControlID="AuthAlienCB" />
                    <telerik:AjaxUpdatedControl ControlID="AuthTypeLabel" />
                    <telerik:AjaxUpdatedControl ControlID="AuthTypeRadCombo" />
                    <telerik:AjaxUpdatedControl ControlID="VisaLabel" />
                    <telerik:AjaxUpdatedControl ControlID="VisaTB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="AuthAlienCB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="AuthTypeLabel" />
                    <telerik:AjaxUpdatedControl ControlID="AuthTypeRadCombo" />
                    <telerik:AjaxUpdatedControl ControlID="VisaLabel" />
                    <telerik:AjaxUpdatedControl ControlID="VisaTB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="AddrSaveRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="AddrRadSlider" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="AddrRadGrid" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Pref_EditRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Pref_EditRB" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_GeneralRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_GeneralRB" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_EquipRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_EquipRB" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_CommodityRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_CommodityRB" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_RegionsRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_RegionsRB" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_OtherRAC" />
                    <telerik:AjaxUpdatedControl ControlID="Pref_OtherRB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Pref_GeneralRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PrefRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Pref_EquipRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PrefRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Pref_CommodityRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PrefRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Pref_RegionsRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PrefRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="Pref_OtherRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PrefRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="R1HistoryRLV">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="GeneralRTT" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="R2HistoryRLV">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="GeneralRTT" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="R3HistoryRLV">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="GeneralRTT" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="HistSaveRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="R1Panel" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="QuitRTT" />
                    <telerik:AjaxUpdatedControl ControlID="YearsRadSlider" />
                    <telerik:AjaxUpdatedControl ControlID="HistWarningLtl" />
                    <telerik:AjaxUpdatedControl ControlID="ExpRG" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="CarrierEditRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="CarrierEditRB" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenTB_CarrierDataStatus" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="CarrierZipRCB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="CarrierZipRCB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ExpRTT_RG">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ExpRTT_RG" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ExpRSB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ExpRTV" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="ExpRSB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ExpRTV">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ExpRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="ExpLockRB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ExpRG">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ExpRTT" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ExpLockRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ExpRG" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ExpRTT_LockRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ExpLockRB" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="IncidentsRTV">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="AccidentsRadGrid" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="IncidentsRadGrid" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="HonorsAwardsRadGrid" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="IncidentLockRB">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="AccidentsRadGrid" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="IncidentsRadGrid" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="HonorsAwardsRadGrid" LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="BlackMetroTouch">
    </telerik:RadAjaxLoadingPanel>
    <telerik:RadToolTip runat="server" ID="InstRTT" HideEvent="ManualClose" RelativeTo="Element"
        Width="375px" Skin="BlackMetroTouch" Text="Instructions have not yet been configured for this item."
        Style="margin-top: 5px">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="InfoRTT" HideEvent="LeaveTargetAndToolTip"
        RelativeTo="Element" Width="375px" Skin="BlackMetroTouch">
        <div style="padding-top: 5px">
            <asp:Label ID="InfoLbl" runat="server" Text="Information has not yet been configured for this item." />
        </div>
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="PrefRTT" HideEvent="ManualClose" RelativeTo="Element"
        Width="430px" Skin="BlackMetroTouch" OnClientHide="closePrefRTT">
        <telerik:RadGrid ID="PrefRG" runat="server" DataSourceID="PrefDS" GridLines="None"
            ShowHeader="False" CellSpacing="0" AutoGenerateColumns="False">
            <ClientSettings>
                <ClientEvents OnRowMouseOver="getExpID" />
            </ClientSettings>
            <MasterTableView DataKeyNames="PartyExperienceID, Importance" ClientDataKeyNames="PartyExperienceID, ItemName"
                DataSourceID="PrefDS">
                <NoRecordsTemplate>
                    <div style="padding: 25px;">
                        You have not yet entered stuff you want for this category. Please close this tool
                        tip, click the "Edit" button below, and enter the stuff you want.
                    </div>
                </NoRecordsTemplate>
                <Columns>
                    <telerik:GridBoundColumn DataField="ItemImage" UniqueName="ItemImage">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="ItemName" UniqueName="ItemName">
                    </telerik:GridBoundColumn>
                    <telerik:GridTemplateColumn HeaderText="Importance" UniqueName="ImportanceColumn">
                        <ItemTemplate>
                            <telerik:RadSlider ID="PrefRS" runat="server" ItemType="item" CssClass="ItemsSlider"
                                OnClientValueChanged="sliderChanged" OnClientSlideStart="slideStart" OnClientSlideEnd="slideEnd"
                                ShowDecreaseHandle="false" ShowIncreaseHandle="false" Height="75px" Width="225px"
                                Skin="Metro">
                                <Items>
                                    <telerik:RadSliderItem Text="Low" Value="0" />
                                    <telerik:RadSliderItem Text="" Value="1" />
                                    <telerik:RadSliderItem Text="Medium" Value="2" />
                                    <telerik:RadSliderItem Text="" Value="3" />
                                    <telerik:RadSliderItem Text="Critical" Value="4" />
                                </Items>
                            </telerik:RadSlider>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridTemplateColumn UniqueName="PrefRTT_PrefDelIBColumn">
                        <ItemTemplate>
                            <asp:ImageButton ID="PrefRTT_PrefDelIB" runat="server" ImageUrl="/Images/Custom/XOut_Small.png" />
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                </Columns>
                <PagerStyle PageSizeControlType="RadComboBox"></PagerStyle>
            </MasterTableView>
            <PagerStyle PageSizeControlType="RadComboBox"></PagerStyle>
        </telerik:RadGrid>
        <asp:SqlDataSource ID="PrefDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
            SelectCommand="usp_PrefSliders_ByTrucker" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="PrefPartyID" PropertyName="Text"
                    Type="Int32" />
                <asp:ControlParameter ControlID="HiddenTB_PrefParentID" Name="PrefParentIDs" PropertyName="Text"
                    Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="Col1RTT" Width="250px" Height="70px" OnClientBeforeShow="cancelToolTip"
        ShowCallout="false" Position="Center" HideEvent="ManualClose" Modal="true">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="GeneralRTT" HideEvent="ManualClose" RelativeTo="BrowserWindow"
        Position="Center" Modal="true" Width="375px" Skin="BlackMetroTouch">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="HiredRTT" HideEvent="ManualClose" RelativeTo="Element"
        Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode" Position="TopLeft"
        TargetControlID="HiredRDP">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="QuitRTT" HideEvent="ManualClose" RelativeTo="Element"
        Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode" Position="TopLeft"
        TargetControlID="QuitRDP">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="DOTDupRTT" HideEvent="ManualClose" RelativeTo="Element"
        Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode" Position="TopLeft"
        TargetControlID="DOTNumberRTB">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="MCDupRTT" HideEvent="ManualClose" RelativeTo="Element"
        Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode" Position="TopLeft"
        TargetControlID="MCNumberRTB">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="CarrierWarningRTT" HideEvent="ManualClose"
        RelativeTo="Element" Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode"
        Position="BottomLeft" TargetControlID="CarrierNameRTB">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="PickCarrierWarningRTT" HideEvent="ManualClose"
        RelativeTo="Element" Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode"
        Position="BottomLeft" TargetControlID="LockRB">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="MilesWarningRTT" HideEvent="ManualClose" RelativeTo="Element"
        Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode" Position="BottomLeft"
        TargetControlID="MilesRTB">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="ReasonLeftWarningRTT" HideEvent="ManualClose"
        RelativeTo="Element" Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode"
        Position="BottomLeft" TargetControlID="ReasonLeftRCB">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="UnemployedNotesWarningRTT" HideEvent="ManualClose"
        RelativeTo="Element" Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode"
        Position="BottomLeft" TargetControlID="UnemployedNotesRE">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="EditWarningRTT" HideEvent="ManualClose" RelativeTo="Mouse"
        Width="240px" Skin="Default" Position="Center" BackColor="White" OffsetX="180"
        OffsetY="20" BorderStyle="None" ForeColor="White">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="EditCurrentJobWarningRTT" HideEvent="ManualClose"
        RelativeTo="Mouse" Width="240px" Skin="Default" Position="Center" BackColor="White"
        OffsetX="180" OffsetY="-30" BorderStyle="None" ForeColor="White">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="SaveWarningRTT" HideEvent="ManualClose" RelativeTo="Element"
        Width="375px" Skin="BlackMetroTouch" ShowEvent="FromCode" Position="BottomCenter"
        TargetControlID="HistSaveRB">
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="RadiusRTT" HideEvent="ManualClose" RelativeTo="Element"
        Position="TopCenter" Skin="BlackMetroTouch">
        <table>
            <tbody>
                <tr>
                    <td class="fls">
                        <asp:Label runat="server" ID="RadiusLbl" Text="Radius" Visible="True"></asp:Label>
                    </td>
                    <td class="dfv">
                        <telerik:RadComboBox ID="RadiusRCB" runat="server" Width="100px" ZIndex="50001">
                            <Items>
                                <telerik:RadComboBoxItem runat="server" Text="5 Miles" Value="5" />
                                <telerik:RadComboBoxItem runat="server" Text="10 Miles" Value="10" />
                                <telerik:RadComboBoxItem runat="server" Text="25 Miles" Value="25" />
                                <telerik:RadComboBoxItem runat="server" Text="50 Miles" Value="50" />
                            </Items>
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td class="fls">
                        <asp:Label runat="server" ID="ByCityLbl" Text="From"></asp:Label>
                    </td>
                    <td class="dfv">
                        <telerik:RadComboBox ID="CityRCB" runat="server" Width="150px" EmptyMessage="Type City, ST"
                            EnableLoadOnDemand="True" OnItemsRequested="s_CityRCB_ItemsRequested" ZIndex="50001">
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td class="fls">
                    </td>
                    <td class="dfv">
                        <telerik:RadComboBox ID="SearchCountryRCB" runat="server" Width="100px" ZIndex="50001">
                            <Items>
                                <telerik:RadComboBoxItem runat="server" Text="United States" Value="3" />
                                <telerik:RadComboBoxItem runat="server" Text="Canada" Value="2" />
                                <telerik:RadComboBoxItem runat="server" Text="Mexico" Value="1" />
                            </Items>
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <telerik:RadButton ID="RadiusRB" runat="server" Text="Search by Radius" ToolTip="Click to search carriers from the radius and city shown above."
                            AutoPostBack="false" OnClientClicked="searchRadiusRB">
                        </telerik:RadButton>
                    </td>
                </tr>
            </tbody>
        </table>
    </telerik:RadToolTip>
    <telerik:RadToolTip runat="server" ID="ExpRTT" HideEvent="ManualClose" Width="580px"
        Modal="true" Skin="BlackMetroTouch" OnClientHide="closeExpRTT" RelativeTo="Element"
        OnClientShow="onExpRTTShow">
        <telerik:RadGrid ID="ExpRTT_RG" runat="server" DataSourceID="ExpRTT_DS" OnItemDataBound="ExpRTT_RG_ItemDataBound"
            GridLines="None" ShowHeader="False" CellSpacing="0" AutoGenerateColumns="False">
            <ClientSettings>
                <ClientEvents OnRowMouseOver="onExpRTT_RGMouseOver" />
            </ClientSettings>
            <MasterTableView DataKeyNames="PartyExperienceID, FocusedOn, LockFocus, NoSlide"
                ClientDataKeyNames="PartyExperienceID, ItemName" DataSourceID="ExpRTT_DS">
                <NoRecordsTemplate>
                    <div style="padding: 25px;">
                        You have not yet added items to this category for this job. Please drag and drop
                        experience items to this job.
                    </div>
                </NoRecordsTemplate>
                <Columns>
                    <telerik:GridBoundColumn DataField="ItemImage" UniqueName="ItemImage">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="ItemName_Perc" UniqueName="ItemName_Perc">
                    </telerik:GridBoundColumn>
                    <telerik:GridTemplateColumn UniqueName="ExpRTT_RS_TemplateColumn" HeaderText="% of Focus">
                        <ItemTemplate>
                            <telerik:RadSlider ID="ExpRTT_RS" runat="server" MinimumValue="0" MaximumValue="100"
                                SmallChange="5" LargeChange="25" OnClientSlideStart="onExpRTT_RSStart" OnClientSlideEnd="onExpRTT_RSSlideEnd"
                                OnClientValueChanged="onExpRTT_RSValueChanged" OnClientValueChanging="onExpRTT_RSChanging"
                                ShowDecreaseHandle="true" ShowIncreaseHandle="true" Width="270px" Height="35px"
                                Skin="Metro" ItemType="Tick" TrackPosition="BottomRight">
                            </telerik:RadSlider>
                            <asp:Literal ID="NoSlideLiteral" runat="server"></asp:Literal>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridTemplateColumn UniqueName="ExperienceNotes_TemplateColumn">
                        <ItemTemplate>
                            <telerik:RadButton ID="ExperienceNotesRB" runat="server" Height="20px" Width="20px"
                                AutoPostBack="false" OnClientClicked="openExperienceNotes">
                                <Image EnableImageButton="true" ImageUrl="/Images/Custom/edit.png"></Image>
                            </telerik:RadButton>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridTemplateColumn HeaderText="Lock" UniqueName="LockSlider_TemplateColumn">
                        <ItemTemplate>
                            <telerik:RadButton ID="ExpRTT_LockRB" runat="server" ButtonType="ToggleButton" ToggleType="CustomToggle"
                                AutoPostBack="false" OnClientClicked="onExpRTT_LockRBClicked" Height="20px" Width="20px"
                                TabIndex="30" ToolTip="Unlock to enable Edit and Delete buttons.">
                                <ToggleStates>
                                    <telerik:RadButtonToggleState ImageUrl="/Images/Custom/un_lock_blk.png" HoveredImageUrl="/Images/Custom/un_lock_glow_blk.png"
                                        Text="" Selected="true" Value="False"></telerik:RadButtonToggleState>
                                    <telerik:RadButtonToggleState ImageUrl="/Images/Custom/lock_blk.png" Text="" HoveredImageUrl="/Images/Custom/lock_glow_blk.png"
                                        Value="True"></telerik:RadButtonToggleState>
                                </ToggleStates>
                            </telerik:RadButton>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridTemplateColumn UniqueName="ExpRTT_ExpDelIB_TemplateColumn">
                        <ItemTemplate>
                            <asp:ImageButton ID="ExpRTT_ExpDelIB" runat="server" ImageUrl="/Images/Custom/XOut_Small.png" />
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                </Columns>
                <PagerStyle PageSizeControlType="RadComboBox"></PagerStyle>
            </MasterTableView>
            <PagerStyle PageSizeControlType="RadComboBox"></PagerStyle>
        </telerik:RadGrid>
        <asp:SqlDataSource ID="ExpRTT_DS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
            SelectCommand="SELECT * FROM [v_PartyExperience] WHERE ([HistoryID] = @ExpHistoryID AND [ExperienceParentID] = @ExpParentID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="HiddenTB_HistoryID_ForExpRTT" Name="ExpHistoryID"
                    PropertyName="Text" Type="Int32" />
                <asp:ControlParameter ControlID="HiddenTB_ExperienceID" Name="ExpParentID" PropertyName="Text"
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <telerik:RadEditor ID="ExperienceNotesRE" runat="server" Style="display: none; width: 550px;
            height: auto" AutoResizeHeight="True" ToolsFile="~/ToolsFileSmall.xml" EditModes="Design"
            Height="80px">
        </telerik:RadEditor>
        <div id="ExpRTT_SaveCancelDiv" runat="server" style="display: none">
            <telerik:RadButton ID="ExperienceNotesSaveRB" runat="server" Text="Save" OnClientClicked="onExperienceNotesSave"
                AutoPostBack="false" Style="margin-top: 12px; margin-right: 2px" Value="">
            </telerik:RadButton>
            <telerik:RadButton ID="ExperienceNotesCancelRB" runat="server" Text="Cancel" Style="margin-top: 12px;
                margin-left: 3px" AutoPostBack="false" OnClientClicked="onExperienceNotesCancel"
                Value="">
            </telerik:RadButton>
        </div>
    </telerik:RadToolTip>
    <telerik:RadWindowManager ID="RadWindowManager2" runat="server" AutoSize="False"
        Modal="True" ShowContentDuringLoad="False" VisibleStatusbar="False" OnClientShow="onRWShow"
        Skin="Black" Style="z-index: 10000;">
    </telerik:RadWindowManager>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="False"
        Modal="True" ShowContentDuringLoad="False" Behaviors="Close,Move,Resize" VisibleStatusbar="False"
        OnClientBeforeShow="onRWBeforeShow" OnClientShow="onRWShow" Skin="BlackMetroTouch">
        <Windows>
            <telerik:RadWindow ID="RadWindow1" runat="server" Modal="true" Width="545" Height="630"
                Title="" Style="z-index: 7000; padding: 0px; background-color: White;" CssClass="CustomRW">
            </telerik:RadWindow>
            <telerik:RadWindow ID="RadWindowDialogue" runat="server" MinHeight="100px" Modal="True"
                MinWidth="400" Style="display: none; z-index: 7000" VisibleTitlebar="False">
            </telerik:RadWindow>
            <telerik:RadWindow ID="AddrRW" runat="server" Modal="true" Title="Add/Edit Address"
                Width="450px" Height="460px" Style="z-index: 9000;">
                <ContentTemplate>
                    <div class="RadWindow_Background_Cust" style="height: 350px;">
                        <table>
                            <tbody>
                                <tr>
                                    <td class="fls">
                                        <asp:Label ID="AddrLbl" runat="server" Text="Street"></asp:Label>
                                    </td>
                                    <td class="dfv">
                                        <telerik:RadTextBox ID="AddrRTB" runat="server" Width="200px">
                                        </telerik:RadTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        &nbsp;
                                    </td>
                                    <td class="dfv">
                                        <telerik:RadTextBox ID="Addr2RTB" runat="server" Width="200px">
                                        </telerik:RadTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        <asp:Label ID="CitySTZipLbl" runat="server" Text="City, ST Zip"></asp:Label>
                                    </td>
                                    <td class="dfv">
                                        <telerik:RadComboBox ID="AddrZipRCB" runat="server" Width="200px" EmptyMessage="For 'W Chicago, IL,' enter 'W Ch,IL' or 601"
                                            EnableLoadOnDemand="True" OnItemsRequested="s_AddrZipRCB_ItemsRequested" ShowToggleImage="False"
                                            ZIndex="50001">
                                        </telerik:RadComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        &nbsp;
                                    </td>
                                    <td class="dfv">
                                        <telerik:RadComboBox ID="AddrCountryRCB" runat="server" DataSourceID="CountryDS"
                                            DataTextField="Country" DataValueField="CountryID" MarkFirstMatch="True" Width="200px"
                                            ShowToggleImage="True" ZIndex="50001">
                                        </telerik:RadComboBox>
                                        <asp:SqlDataSource ID="CountryDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                            SelectCommand="SELECT CountryID, Country
		                                FROM
			                                dbo.v_GeoCountry
		                                ORDER BY
			                                CountryID Desc"></asp:SqlDataSource>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="fls">
                                        &nbsp;
                                    </td>
                                    <td class="dfv">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="header_cust" colspan="2">
                                        <asp:Label ID="DatesAtLabel" runat="server" CssClass="" Text="Dates at Address"></asp:Label>
                                    </td>
                                    <tr>
                                        <td class="fls">
                                            <asp:Label ID="MovedInLbl" runat="server" Text="Moved In"></asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <telerik:RadMonthYearPicker ID="MovedInRDP" runat="server" MinDate="1920-01-01" Width="130px"
                                                ZIndex="10000">
                                            </telerik:RadMonthYearPicker>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="fls">
                                            <asp:Label ID="MovedOutChkLbl" runat="server" Text="Moved Out?"></asp:Label>
                                        </td>
                                        <td class="dfv">
                                            <asp:CheckBox ID="MovedOutCB" runat="server" OnClick="onMovedOutChecked(this.checked);" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="fls">
                                            <div id="MovedOutLblDiv" style="display: none">
                                                <asp:Label ID="MovedOutLbl" runat="server" Text="Moved Out"></asp:Label>
                                            </div>
                                        </td>
                                        <td class="dfv">
                                            <div id="MovedOutDiv" style="display: none">
                                                <telerik:RadMonthYearPicker ID="MovedOutRDP" runat="server" MinDate="1920-01-01"
                                                    Width="130px" ZIndex="10000">
                                                </telerik:RadMonthYearPicker>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="dfv" colspan="2">
                                            <center>
                                                <table>
                                                    <tbody>
                                                        <tr>
                                                            <td class="dfv">
                                                                <telerik:RadButton ID="AddrSaveRB" runat="server" AutoPostBack="true" Text="Save"
                                                                    ToolTip="Click to save the changes to this address.">
                                                                </telerik:RadButton>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadButton ID="AddrCancelRB" runat="server" Text="Cancel" ToolTip="Click to CANCEL the changes to this address."
                                                                    AutoPostBack="false" OnClientClicked="closeAddrRW">
                                                                </telerik:RadButton>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </center>
                                        </td>
                                    </tr>
                            </tbody>
                        </table>
                    </div>
                </ContentTemplate>
            </telerik:RadWindow>
            <telerik:RadWindow ID="JobRW" runat="server" Modal="true" Title="Job or Unemployment Period"
                Width="650px" Height="675px" OnClientClose="onJobRWClose" Style="z-index: 7000;">
                <ContentTemplate>
                    <div style="width: 100%">
                        <telerik:RadTabStrip ID="JobRTS" SelectedIndex="0" runat="server" MultiPageID="JobRMP"
                            Skin="BlackMetroTouch" OnClientTabSelected="onTabSwitch">
                            <Tabs>
                                <telerik:RadTab runat="server" Text="General Info" PageViewID="PageView1" Value="0"
                                    Width="216px">
                                </telerik:RadTab>
                                <telerik:RadTab runat="server" Text="More Details" PageViewID="PageView2" Value="1"
                                    Width="217px">
                                </telerik:RadTab>
                                <telerik:RadTab runat="server" Text="Finish" PageViewID="PageView3" Value="2" Width="217px">
                                </telerik:RadTab>
                            </Tabs>
                        </telerik:RadTabStrip>
                        <telerik:RadMultiPage ID="JobRMP" runat="server" SelectedIndex="0" Style="background: white;
                            padding: 20px;" Height="480px">
                            <telerik:RadPageView ID="PageView1" runat="server">
                                <table>
                                    <tbody style="width: 100%">
                                        <tr id="JobNotRow">
                                            <td class="fls" style="width: 115px; position: inherit;">
                                                <asp:Label ID="PositionTypeLbl" runat="server" Text="I Want to Enter A(n)"></asp:Label>
                                            </td>
                                            <td class="dfv" style="width: 430px;">
                                                <telerik:RadComboBox ID="PositionTypeRCB" runat="server" OnClientSelectedIndexChanged="onPositionTypeChanged"
                                                    TabIndex="1" ZIndex="50001">
                                                    <Items>
                                                        <telerik:RadComboBoxItem runat="server" Text="**Please Select**" Value="0" />
                                                        <telerik:RadComboBoxItem runat="server" Text="Trucking Job" Value="1" />
                                                        <telerik:RadComboBoxItem runat="server" Text="Non-Trucking Position" Value="2" />
                                                        <telerik:RadComboBoxItem runat="server" Text="Unemployed Period" Value="3" />
                                                    </Items>
                                                </telerik:RadComboBox>
                                            </td>
                                        </tr>
                                        <tr id="CurrentPastRow" style="display: none;">
                                            <td class="fls">
                                                <asp:Label ID="CurrentPastLbl" runat="server" Text="This Is My"></asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <telerik:RadComboBox ID="CurrentPastRCB" runat="server" OnClientSelectedIndexChanged="onCurrentPastChanged"
                                                    TabIndex="2" ZIndex="50001">
                                                </telerik:RadComboBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls">
                                                <asp:Label ID="HiredLbl" runat="server" Text="Hired On"></asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <telerik:RadMonthYearPicker ID="HiredRDP" runat="server" MinDate="1920-01-01" Width="130px"
                                                    TabIndex="3" ZIndex="8000">
                                                    <ClientEvents OnDateSelected="onHiredChanged" />
                                                </telerik:RadMonthYearPicker>
                                            </td>
                                        </tr>
                                        <tr id="QuitRow" style="display: none;">
                                            <td class="fls">
                                                <asp:Label ID="QuitLbl" runat="server" Text="Quit"></asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <telerik:RadMonthYearPicker ID="QuitRDP" runat="server" MinDate="1920-01-01" Width="130px"
                                                    TabIndex="4" ZIndex="8000">
                                                    <ClientEvents OnDateSelected="onQuitChanged" />
                                                </telerik:RadMonthYearPicker>
                                                <div id="quitrdpdiv">
                                                    Test
                                                </div>
                                            </td>
                                        </tr>
                                        <tr id="PickCarrierRow" style="display: none;">
                                            <td colspan="2" style="padding-left: 75px">
                                                <table>
                                                    <tbody>
                                                        <tr>
                                                            <td class="header_cust" style="width: 375px;">
                                                                <table>
                                                                    <tbody style="width: 100%">
                                                                        <tr>
                                                                            <td style="width: 35%;">
                                                                                <asp:Label ID="CarrierSearchLbl" runat="server" Text="Carrier Search"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 50%; float: right">
                                                                                <telerik:RadSearchBox runat="server" ID="PickCarrierRSB" DataSourceID="CarrierRSB_DS"
                                                                                    DataValueField="PartyID" DataTextField="CarrierFullName" EmptyMessage="Part of Name, MC, or DOT"
                                                                                    Width="208px" MaxResultCount="15" MinFilterLength="3" DropDownSettings-Height="240"
                                                                                    OnClientSearch="onCarrierSearch" OnClientDataRequesting="onCarrierSearchDataReq"
                                                                                    OnClientButtonCommand="onCarrierSearchButtonCommand" Skin="Metro" TabIndex="5">
                                                                                    <Buttons>
                                                                                        <telerik:SearchBoxButton ImageUrl="../Images/Custom/icon_new.png" CommandName="CarrierAdd"
                                                                                            CommandArgument="CarrierAdd" Position="Left" AlternateText="Add New Carrier" />
                                                                                        <telerik:SearchBoxButton ImageUrl="../Images/Custom/icon_globe.png" CommandName="RadiusSearch"
                                                                                            CommandArgument="RadiusSearch" Position="Right" AlternateText="Radius Serach" />
                                                                                    </Buttons>
                                                                                    <DropDownSettings Width="300" />
                                                                                </telerik:RadSearchBox>
                                                                                <asp:SqlDataSource ID="CarrierRSB_DS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                                    SelectCommand="SELECT [PartyID], [CarrierFullName] FROM [v_CarrierSuperShort]">
                                                                                </asp:SqlDataSource>
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <telerik:RadGrid ID="PickCarrierRG" runat="server" DataSourceID="PickCarrierDS" ShowHeader="False"
                                                                    Width="445px" Height="275px" AutoGenerateColumns="False" CellSpacing="0" GridLines="None">
                                                                    <ClientSettings Selecting-AllowRowSelect="True">
                                                                        <Scrolling AllowScroll="true" />
                                                                        <ClientEvents OnRowSelected="onPickCarrierSelected" />
                                                                    </ClientSettings>
                                                                    <MasterTableView DataSourceID="PickCarrierDS" DataKeyNames="PartyID" ClientDataKeyNames="PartyID"
                                                                        EnableNoRecordsTemplate="true">
                                                                        <NoRecordsTemplate>
                                                                            <div style="padding: 25px;">
                                                                                Please search carefully for your carrier by name, DOT, or MC. If that doesn't work,
                                                                                try clicking the "filter" button for a more detailed search. If the carrier is not
                                                                                in the database, please click:<br />
                                                                                <br />
                                                                                <center>
                                                                                    <telerik:RadButton ID="CarrierAddTemplateRB" runat="server" Text="Add Carrier by Hand"
                                                                                        ToolTip="Click here to add a carrier from scratch." AutoPostBack="false" OnClientClicked="onCarrierAddClicked"
                                                                                        TabIndex="6">
                                                                                    </telerik:RadButton>
                                                                                </center>
                                                                            </div>
                                                                        </NoRecordsTemplate>
                                                                        <Columns>
                                                                            <telerik:GridBoundColumn DataField="CarrierHTML" UniqueName="CarrierHTML">
                                                                            </telerik:GridBoundColumn>
                                                                            <telerik:GridBoundColumn DataField="CarrierNos" UniqueName="CarrierNos">
                                                                            </telerik:GridBoundColumn>
                                                                        </Columns>
                                                                    </MasterTableView>
                                                                </telerik:RadGrid>
                                                                <asp:SqlDataSource ID="PickCarrierDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                    SelectCommand="usp_CarrierPick" SelectCommandType="StoredProcedure">
                                                                    <SelectParameters>
                                                                        <asp:Parameter DefaultValue="0" Name="MyPartyID" Type="Int32" />
                                                                        <asp:ControlParameter ControlID="HiddenTB_SearchPartyID" DefaultValue="0" Name="SearchPartyID"
                                                                            PropertyName="Text" Type="String" />
                                                                        <asp:ControlParameter ControlID="HiddenTB_SearchFree" DefaultValue="" Name="Search"
                                                                            PropertyName="Text" Type="String" />
                                                                        <asp:ControlParameter ControlID="HiddenTB_SearchCityID" DefaultValue="0" Name="CityID"
                                                                            PropertyName="Text" Type="String" />
                                                                        <asp:ControlParameter ControlID="HiddenTB_SearchRadius" DefaultValue="10" Name="Radius"
                                                                            PropertyName="Text" Type="String" />
                                                                    </SelectParameters>
                                                                </asp:SqlDataSource>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr id="EmployerRow" style="display: none;">
                                            <td colspan="2">
                                                <table>
                                                    <tbody>
                                                        <tr id="CarrierHeaderRow">
                                                            <td class="header_cust" style="width: 100%;" colspan="5">
                                                                <table>
                                                                    <tbody>
                                                                        <tr>
                                                                            <td style="width: 465px;">
                                                                                <asp:Label ID="CarrierInfoLbl" runat="server" Text="Carrier Info"></asp:Label>
                                                                            </td>
                                                                            <td style="text-align: right;">
                                                                                <table>
                                                                                    <tbody>
                                                                                        <tr>
                                                                                            <td>
                                                                                                <telerik:RadButton ID="CarrierEditRB" runat="server" Text="Edit" ToolTip="Click to edit this carriers details."
                                                                                                    CommandName="CarrierEdit" OnClientClicked="onCarrierEditClicked" OnClick="CarrierEditRB_OnClick"
                                                                                                    AutoPostBack="true" TabIndex="6">
                                                                                                </telerik:RadButton>
                                                                                            </td>
                                                                                            <td style="width: 545px">
                                                                                                <telerik:RadButton ID="CarrierDelRB" runat="server" Text="" ToolTip="Click to remove this carrier from this item."
                                                                                                    CommandName="CarrierDel" AutoPostBack="false" OnClientClicked="onCarrierDelClicked"
                                                                                                    TabIndex="7">
                                                                                                    <Icon PrimaryIconCssClass="rbRemove" PrimaryIconLeft="4" PrimaryIconTop="4"></Icon>
                                                                                                </telerik:RadButton>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </tbody>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr id="DOTNumberRow">
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="DOTNumberLbl" Text="DOT"></asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadMaskedTextBox ID="DOTNumberRTB" runat="server" Mask="#######" Width="175px"
                                                                    TabIndex="8">
                                                                    <ClientEvents OnValueChanged="onDOTNumberChanged" />
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                            <td width="30px">
                                                                &nsbp;
                                                            </td>
                                                            <td class="fls">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr id="MCNumberRow">
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="MCNumberLbl" Text="MC Number"></asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadMaskedTextBox ID="MCNumberRTB" runat="server" Mask="<MC|MX|P|FF>-######l"
                                                                    Width="175px" TabIndex="9">
                                                                    <ClientEvents OnValueChanged="onMCNumberChanged" />
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                            <td width="30px">
                                                                &nsbp;
                                                            </td>
                                                            <td class="fls">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr id="CarrierNameRow">
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="CarrierNameLbl" Text="Carrier Name"></asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadTextBox ID="CarrierNameRTB" runat="server" Width="175px" TabIndex="10">
                                                                </telerik:RadTextBox>
                                                            </td>
                                                            <td width="30px">
                                                                &nsbp;
                                                            </td>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="CarrierEmailLbl" Text="Safety Email"></asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadTextBox ID="CarrierEmailRTB" runat="server" Width="150px" TabIndex="14">
                                                                </telerik:RadTextBox>
                                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic"
                                                                    ErrorMessage="Please enter valid e-mail." ValidationExpression="^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$"
                                                                    ControlToValidate="CarrierEmailRTB">
                                                                </asp:RegularExpressionValidator>
                                                            </td>
                                                        </tr>
                                                        <tr id="CarrierAddrRow">
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="CarrierAddrLbl" Text="HQ Address">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadTextBox ID="CarrierAddrRTB" runat="server" Width="175px" TabIndex="11">
                                                                </telerik:RadTextBox>
                                                            </td>
                                                            <td width="30px">
                                                                &nsbp;
                                                            </td>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="CarrierPhoneLbl" Text="Safety Phone"></asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadMaskedTextBox ID="CarrierPhoneRTB" runat="server" Mask="###-###-#### #####"
                                                                    Width="150px" TabIndex="15">
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                        </tr>
                                                        <tr id="CarrierCityRow">
                                                            <td class="fls">
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadComboBox ID="CarrierZipRCB" runat="server" Width="175px" EmptyMessage="City/ST or Zip"
                                                                    EnableLoadOnDemand="True" OnItemsRequested="s_CarrierZipRCB_ItemsRequested" ShowToggleImage="False"
                                                                    TabIndex="12" ZIndex="50001">
                                                                </telerik:RadComboBox>
                                                            </td>
                                                            <td width="30px">
                                                                &nsbp;
                                                            </td>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="CarrierFaxLbl" Text="Safety Fax"></asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadMaskedTextBox ID="CarrierFaxRTB" runat="server" Mask="###-###-####" Width="150px"
                                                                    TabIndex="16">
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                        </tr>
                                                        <tr id="CarrierCountryRow">
                                                            <td class="fls">
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadComboBox ID="CarrierCountryRCB" runat="server" Width="175px" TabIndex="13"
                                                                    ZIndex="50001" AutoPostBack="false">
                                                                    <Items>
                                                                        <telerik:RadComboBoxItem runat="server" Text="United States" Value="3" Selected="true" />
                                                                        <telerik:RadComboBoxItem runat="server" Text="Canada" Value="2" />
                                                                        <telerik:RadComboBoxItem runat="server" Text="Mexico" Value="1" />
                                                                    </Items>
                                                                </telerik:RadComboBox>
                                                            </td>
                                                            <td width="30px">
                                                                &nsbp;
                                                            </td>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="ContactLbl" Text="Contact Info"></asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadTextBox ID="ContactRTB" runat="server" Width="150px">
                                                                </telerik:RadTextBox>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr id="UnemployedRow" style="display: none">
                                            <td colspan="2">
                                                <center>
                                                    <table>
                                                        <tbody>
                                                            <tr>
                                                                <td colspan="2" class="header_cust" height="35px" style="vertical-align: middle;">
                                                                    <asp:Label ID="UnemployedHeaderLbl" runat="server" Text="Reason for Unemployed Period"></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="2">
                                                                    <telerik:RadEditor ID="UnemployedNotesRE" runat="server" Height="200px" Width="450px"
                                                                        ToolsFile="~/ToolsFileMedium.xml" EditModes="Design">
                                                                    </telerik:RadEditor>
                                                                </td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </center>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </telerik:RadPageView>
                            <telerik:RadPageView ID="PageView2" runat="server">
                                <table>
                                    <tbody>
                                        <tr>
                                            <td class="fls">
                                                <asp:Label ID="MilesLbl" runat="server" Text="Average Miles Per Week"></asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <telerik:RadTextBox ID="MilesRTB" Text="0" runat="server" Width="50px" TabIndex="20">
                                                </telerik:RadTextBox>
                                            </td>
                                        </tr>
                                        <tr id="ReasonLeftRow">
                                            <td class="fls">
                                                <asp:Label ID="ReasonLeftLbl" runat="server" Text="Reason You Left Carrier"></asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <telerik:RadComboBox ID="ReasonLeftRCB" runat="server" DataSourceID="ReasonLeftDS"
                                                    DataValueField="TreeID" DataTextField="ItemName" Width="300px" TabIndex="21"
                                                    ZIndex="50001">
                                                </telerik:RadComboBox>
                                                <asp:SqlDataSource ID="ReasonLeftDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                    SelectCommand="SELECT t.*
                                                    FROM
                                                        (SELECT TreeID = 0, ItemName = '**Please Select**', ItemRank = -1
                                                        UNION
                                                        SELECT [TreeID], [ItemName], ItemRank FROM [Tree] WHERE ([TreeParentID] = @TreeParentID)) t
                                                    ORDER BY ItemRank, ItemName">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="1919" Name="TreeParentID" Type="Int32" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                            </td>
                                        </tr>
                                        <tr id="ReasonLeftNotesRow">
                                            <td class="fls">
                                                <asp:Label ID="ReasonLeftNotes" runat="server" Text="Notes on the Reason You Left"></asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <telerik:RadEditor ID="ReasonLeftRE" runat="server" ToolsFile="~/ToolsFileSmall.xml"
                                                    Height="100" Width="300" EditModes="Design" TabIndex="22">
                                                </telerik:RadEditor>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls">
                                                <asp:Label ID="CommVechLbl" runat="server" Text="Operated Commercial Motor Vechicle"></asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <asp:CheckBox ID="CommVechCB" runat="server" TabIndex="23" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls">
                                                <asp:Label ID="DrugProgramLbl" runat="server" Text="Participated in a Drug Testing Program"></asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <asp:CheckBox ID="DrugProgramCB" runat="server" TabIndex="24" />
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </telerik:RadPageView>
                            <telerik:RadPageView ID="PageView3" runat="server">
                                <table>
                                    <tbody>
                                        <tr>
                                            <td colspan="2" class="header_cust" style="height: 35px; vertical-align: middle;">
                                                <asp:Label ID="EmploymentNoteLbl" runat="server" Text="Other Notes About Employment (Duties, Specialties, Etc.)"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <telerik:RadEditor ID="EmploymentNotesRE" runat="server" Height="200px" Width="450px"
                                                    ToolsFile="~/ToolsFileMedium.xml" EditModes="Design" TabIndex="25">
                                                </telerik:RadEditor>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="fls" style="width: 200px; white-space: normal;">
                                                <asp:Label ID="StopVerifyLbl" runat="server" Style="color: red;" Text="IMPORTANT: Click here if you are okay with this employer <strong>being contacted</strong> to verify your employment."></asp:Label>
                                                <asp:Label ID="GoVerifyLbl" runat="server" Style="color: Green; display: none;" Text="You've indicated that it <em>is</em> okay to contact this employer to verify your employment."></asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <telerik:RadButton ID="VerifyRB" runat="server" ButtonType="ToggleButton" ToggleType="CustomToggle"
                                                    AutoPostBack="false" OnClientClicked="onVerifyClicked" Height="35px" Width="35px"
                                                    TabIndex="26">
                                                    <ToggleStates>
                                                        <telerik:RadButtonToggleState ImageUrl="/Images/Custom/stopicon.png" HoveredImageUrl="/Images/Custom/stopiconglow.png"
                                                            Text="" Selected="true" Value="False"></telerik:RadButtonToggleState>
                                                        <telerik:RadButtonToggleState ImageUrl="/Images/Custom/goicon.png" Text="" HoveredImageUrl="/Images/Custom/goiconglow.png"
                                                            Value="True"></telerik:RadButtonToggleState>
                                                    </ToggleStates>
                                                </telerik:RadButton>
                                            </td>
                                        </tr>
                                        <tr id="FirstJobRow" style="display: none">
                                            <td class="fls">
                                                <asp:Label ID="FirstJobLbl" runat="server" Text="Is/Was This Your First Job?"></asp:Label>
                                            </td>
                                            <td class="dfv">
                                                <div>
                                                    <telerik:RadButton ID="FirstJobRB" runat="server" ToggleType="CheckBox" ButtonType="LinkButton"
                                                        AutoPostBack="false" BorderWidth="0px" BackColor="White">
                                                        <ToggleStates>
                                                            <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckbox" Selected="true">
                                                            </telerik:RadButtonToggleState>
                                                            <telerik:RadButtonToggleState PrimaryIconCssClass="rbToggleCheckboxChecked"></telerik:RadButtonToggleState>
                                                        </ToggleStates>
                                                    </telerik:RadButton>
                                                </div>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </telerik:RadPageView>
                        </telerik:RadMultiPage>
                        <table>
                            <tbody>
                                <tr>
                                    <td>
                                        <telerik:RadButton ID="HistSaveRB" runat="server" Text="Save" ToolTip="Click to save the changes to this job or unemployment period."
                                            AutoPostBack="true" TabIndex="28" OnClientClicked="onJobSaveClicked">
                                        </telerik:RadButton>
                                    </td>
                                    <td>
                                        <telerik:RadButton ID="HistCancelRB" runat="server" Text="Cancel" ToolTip="Click to cancel changes and/or close this form."
                                            AutoPostBack="false" OnClientClicked="closeJobRW" TabIndex="29">
                                        </telerik:RadButton>
                                    </td>
                                    <td width="475px" style="font-size: 12px; text-align: right; color: White; vertical-align: middle;
                                        padding-top: 12px;">
                                        <asp:Label ID="UnlockedLbl" runat="server" Text="Click to LOCK >>>" Style="display: none;"></asp:Label>
                                        <asp:Label ID="LockedLbl" runat="server" Text='Click to "UN"lock >>>' Style="display: none;"></asp:Label>
                                    </td>
                                    <td>
                                        <telerik:RadButton ID="LockRB" runat="server" ButtonType="ToggleButton" ToggleType="CustomToggle"
                                            OnClientClicked="onLockClicked" Height="35px" Width="35px" TabIndex="30" AutoPostBack="false">
                                            <ToggleStates>
                                                <telerik:RadButtonToggleState ImageUrl="/Images/Custom/un_lock.png" HoveredImageUrl="/Images/Custom/un_lock_glow.png"
                                                    Text="" Selected="true" Value="False"></telerik:RadButtonToggleState>
                                                <telerik:RadButtonToggleState ImageUrl="/Images/Custom/lock.png" Text="" HoveredImageUrl="/Images/Custom/lock_glow.png"
                                                    Value="True"></telerik:RadButtonToggleState>
                                            </ToggleStates>
                                        </telerik:RadButton>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </ContentTemplate>
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
    <div>
        <telerik:RadTabStrip ID="FastportRTS" runat="server" SelectedIndex="0" Skin="BlackMetroTouch"
            Align="Justify" OnClientTabSelected="onFastportRTSSelected">
        </telerik:RadTabStrip>
        <div id="ToDoDiv" style="">
            <telerik:RadSplitter ID="ToDoRS" runat="server" Height="100%" Width="100%" Orientation="Vertical"
                Skin="BlackMetroTouch">
                <telerik:RadPane ID="ToDoItemsRP" runat="server" Width="275" MinWidth="150" MaxWidth="450">
                    <telerik:RadPanelBar runat="server" ID="ToDoRPB" Width="100%" Height="100%" Skin="BlackMetroTouch"
                        ExpandMode="FullExpandedItem">
                        <Items>
                            <telerik:RadPanelItem Expanded="true" Text="FASTPORT To Dos">
                                <ContentTemplate>
                                    <center>
                                        <asp:Image ID="GaugeImage" runat="server"></asp:Image>
                                        <br />
                                        <telerik:RadGrid ID="MenuRadGrid" runat="server" Width="245px" AutoGenerateColumns="False"
                                            CellSpacing="0" DataSourceID="MenuDS" GridLines="None" ShowHeader="False">
                                            <ClientSettings>
                                                <Selecting AllowRowSelect="True" />
                                            </ClientSettings>
                                            <MasterTableView DataKeyNames="TreeID" DataSourceID="MenuDS">
                                                <Columns>
                                                    <telerik:GridBinaryImageColumn DataField="ItemImage" FilterControlAltText="Filter ItemImage column"
                                                        ImageHeight="" ImageWidth="" UniqueName="ItemImage">
                                                    </telerik:GridBinaryImageColumn>
                                                    <telerik:GridBoundColumn DataField="ItemHTML" HeaderStyle-Width="275px" UniqueName="ItemHTML">
                                                    </telerik:GridBoundColumn>
                                                </Columns>
                                            </MasterTableView>
                                        </telerik:RadGrid>
                                        <asp:SqlDataSource ID="MenuDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                            SelectCommand="usp_MenuConfig" SelectCommandType="StoredProcedure">
                                            <SelectParameters>
                                                <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="MenuPartyID" PropertyName="Text"
                                                    Type="Int32" />
                                            </SelectParameters>
                                        </asp:SqlDataSource>
                                    </center>
                                </ContentTemplate>
                            </telerik:RadPanelItem>
                            <telerik:RadPanelItem Text="Documents to Provide" Expanded="false">
                                <ContentTemplate>
                                    <telerik:RadGrid ID="MustActRG" runat="server" Width="245px" AutoGenerateColumns="False"
                                        CellSpacing="0" DataSourceID="MustActDS" GridLines="None" ShowHeader="False">
                                        <ClientSettings>
                                            <Selecting AllowRowSelect="True" />
                                        </ClientSettings>
                                        <MasterTableView DataKeyNames="DocTreeID,DocStatus,KeyID" DataSourceID="MustActDS">
                                            <Columns>
                                                <telerik:GridBoundColumn DataField="DocNodeHTML" HeaderStyle-Width="275px" UniqueName="DocNodeHTML">
                                                </telerik:GridBoundColumn>
                                            </Columns>
                                        </MasterTableView>
                                    </telerik:RadGrid>
                                    <asp:SqlDataSource ID="MustActDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                        SelectCommand="usp_ToDos" SelectCommandType="StoredProcedure">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="RecipientID" PropertyName="Text"
                                                Type="Int32" />
                                            <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="RecipientSignerID" PropertyName="Text"
                                                Type="Int32" />
                                            <asp:ControlParameter ControlID="HiddenTB_MeID" Name="MeID" PropertyName="Text" Type="Int32" />
                                            <asp:Parameter Name="MustAct" DefaultValue="Yes" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                </ContentTemplate>
                            </telerik:RadPanelItem>
                            <telerik:RadPanelItem Text="Other To Dos" Expanded="false">
                                <ContentTemplate>
                                </ContentTemplate>
                            </telerik:RadPanelItem>
                            <telerik:RadPanelItem Text="Things I'm Waiting For" Expanded="false">
                                <ContentTemplate>
                                    <telerik:RadGrid ID="WaitingRG" runat="server" Width="245px" AutoGenerateColumns="False"
                                        CellSpacing="0" DataSourceID="WaitingDS" GridLines="None" ShowHeader="False">
                                        <ClientSettings>
                                            <Selecting AllowRowSelect="True" />
                                        </ClientSettings>
                                        <MasterTableView DataKeyNames="DocTreeID,DocStatus,KeyID" DataSourceID="WaitingDS">
                                            <Columns>
                                                <telerik:GridBoundColumn DataField="DocNodeHTML" HeaderStyle-Width="275px" UniqueName="DocNodeHTML">
                                                </telerik:GridBoundColumn>
                                            </Columns>
                                        </MasterTableView>
                                    </telerik:RadGrid>
                                    <asp:SqlDataSource ID="WaitingDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                        SelectCommand="usp_ToDos" SelectCommandType="StoredProcedure">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="RecipientID" PropertyName="Text"
                                                Type="Int32" />
                                            <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="RecipientSignerID" PropertyName="Text"
                                                Type="Int32" />
                                            <asp:ControlParameter ControlID="HiddenTB_MeID" Name="MeID" PropertyName="Text" Type="Int32" />
                                            <asp:Parameter Name="MustAct" DefaultValue="No" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                </ContentTemplate>
                            </telerik:RadPanelItem>
                        </Items>
                    </telerik:RadPanelBar>
                </telerik:RadPane>
                <telerik:RadSplitBar ID="ToDoRSB" runat="server" CollapseMode="Forward" />
                <telerik:RadPane ID="ToDoBodyRP" runat="server">
                    <div style="padding: 20%;">
                        <table>
                            <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td class="dfv" style="font-size: 14pt; text-align: left;">
                                                <asp:Literal ID="FPHeaderLiteral" runat="server" Text="Text for literal goes here"></asp:Literal>
                                            </td>
                                            <td class="dfv" style="font-size: 14pt; vertical-align: middle;">
                                                <div align="Right">
                                                    <telerik:RadBinaryImage ID="MiniProfileRadBinaryImage" runat="server" Width="100px"
                                                        Height="100px" ResizeMode="Fit" /></div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" class="dfv" style="max-width: 800px;">
                                                <br />
                                                <asp:Literal ID="GeneralInstructionsLiteral" runat="server" Text="Text for literal goes here"></asp:Literal>
                                                <br />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <center>
                                        <div id="GenDiv" runat="server">
                                            <div id="TruckerDiv" runat="Server">
                                                <table>
                                                    <tr>
                                                        <td class="dfv">
                                                            <center>
                                                                <telerik:RadButton ID="GetHelpRB" runat="server" AutoPostBack="false" Text="Get Paid Help from FASTPORT"
                                                                    ToolTip="Click to get help from FASTPORT's staff so that they can complete your FASTPORT for you.">
                                                                </telerik:RadButton>
                                                                <telerik:RadButton ID="ApplyRB" runat="server" AutoPostBack="false" Text="NEXT STEP to Apply >>>"
                                                                    ToolTip="Click to go to the next step required to apply to this carrier (or to cancel your interest in this postition).">
                                                                </telerik:RadButton>
                                                            </center>
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
                                                                <telerik:RadButton ID="SendAppRB" runat="server" AutoPostBack="false" Text="Send Application to Any Carrier"
                                                                    Visible="False" ToolTip="Click to send your FASTPORT application to any carrier.">
                                                                </telerik:RadButton>
                                                            </center>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <div id="CarrierDiv" runat="Server">
                                                <table>
                                                    <tr>
                                                        <td>
                                                            <center>
                                                                <telerik:RadButton ID="GetAppRD" runat="server" AutoPostBack="false" Text="NEXT STEP to Hire Driver >>>"
                                                                    ToolTip="Click to go to the next step required to get an executed application from this driver.">
                                                                </telerik:RadButton>
                                                            </center>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </div>
                                    </center>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="HiddenTB_ApplyURL" runat="server" Style="display: none"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </div>
                </telerik:RadPane>
            </telerik:RadSplitter>
        </div>
        <div id="GeneralDiv" style="display: none;">
            <table>
                <tr>
                    <td style="width: 5%">
                        &nbsp;
                    </td>
                    <td width="40%">
                    </td>
                    <td width="10%">
                    </td>
                    <td width="40%">
                    </td>
                    <td width="5%">
                    </td>
                </tr>
                <tr>
                    <td style="width: 5%">
                        &nbsp;
                    </td>
                    <td width="40%" style="vertical-align: top;">
                        <table class="dv" cellpadding="0" cellspacing="0" border="0">
                            <tr>
                                <td class="panelTL">
                                    <img src="../Images/space.gif" class="panelTLSpace" alt="" />
                                </td>
                                <td class="panelT">
                                </td>
                                <td class="panelTR">
                                    <img src="../Images/space.gif" class="panelTRSpace" alt="" />
                                </td>
                            </tr>
                            <tr>
                                <td class="panelHeaderL">
                                </td>
                                <td class="dh">
                                    <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                        <tr>
                                            <td class="dhel">
                                                <img src="../Images/space.gif" alt="" />
                                            </td>
                                            <td class="dheci" valign="middle">
                                            </td>
                                            <td class="dhb">
                                                <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                                    <tr>
                                                        <td class="dht" valign="middle">
                                                            1.1 - General Info
                                                        </td>
                                                        <td align="right">
                                                            <img id="GenInstImg" alt="" src="../Images/Custom/HelpBlack.png" onclick="return onInstClick('GenInstImg','546');"
                                                                onmouseover="return flipSRC('GenInstImg','../Images/Custom/HelpBlackGlow.png');"
                                                                onmouseout="return flipSRC('GenInstImg','../Images/Custom/HelpBlack.png');" />
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
                                <td class="panelHeaderR">
                                </td>
                            </tr>
                            <tr>
                                <td class="panelL">
                                </td>
                                <td>
                                    <asp:Panel ID="BasicFrameCollapsibleRegion" runat="server">
                                        <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                            <tr>
                                                <td class="tre">
                                                    <table cellpadding="0" cellspacing="0" border="0">
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="EmailLabel" Text="Email">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadTextBox ID="EmailTB" runat="server" Width="167px" TabIndex="1">
                                                                </telerik:RadTextBox>
                                                                <asp:RegularExpressionValidator ID="emailValidator" runat="server" Display="Dynamic"
                                                                    ErrorMessage="Please enter valid e-mail." ValidationExpression="^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$"
                                                                    ControlToValidate="EmailTB">
                                                                </asp:RegularExpressionValidator>
                                                            </td>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="DirectDialLabel" Text="Landline">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadMaskedTextBox ID="DirectDialRadTB" runat="server" Mask="###-###-#### #####"
                                                                    Width="167px" TabIndex="5">
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="NameLabel" Text="Name">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadTextBox ID="NameTB" runat="server" Width="167px" TabIndex="2">
                                                                </telerik:RadTextBox>
                                                            </td>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="MobileLabel" Text="Mobile">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadMaskedTextBox ID="MobileRadTB" runat="server" Mask="###-###-####" Width="167px"
                                                                    TabIndex="6">
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="HandleLabel" Text="Handle">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadTextBox ID="HandleTB" runat="server" Width="167px" TabIndex="3">
                                                                </telerik:RadTextBox>
                                                            </td>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="OtherLabel" Text="Other">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadMaskedTextBox ID="OtherRadTB" runat="server" Mask="###-###-#### #####"
                                                                    Width="167px" TabIndex="7">
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="TruckerTypeLabel" Text="I Am A">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadComboBox ID="TruckerTypeRCB" runat="server" DataSourceID="TruckerTypeDS"
                                                                    DataTextField="ItemName" DataValueField="TreeID" MarkFirstMatch="True" ShowToggleImage="True"
                                                                    TabIndex="4" Width="167px" ZIndex="50001">
                                                                </telerik:RadComboBox>
                                                                <asp:SqlDataSource ID="TruckerTypeDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                    SelectCommand="SELECT tt.* FROM (SELECT TreeID = '0', ItemName = '**Please Select**', ItemRank = -1 UNION SELECT TreeID, ItemName, ItemRank FROM dbo.Tree WHERE TreeParentID = 2527) tt ORDER BY tt.ItemRank">
                                                                </asp:SqlDataSource>
                                                            </td>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="FaxLabel" Text="Fax">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadMaskedTextBox ID="FaxRadTB" runat="server" Mask="###-###-####" Width="167px"
                                                                    TabIndex="8">
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="fls">
                                                            </td>
                                                            <td class="dfv" style="vertical-align: bottom;">
                                                                <telerik:RadButton ID="NameRadButton" runat="server" Text="Edit" ToolTip="Click here to edit the fields shown above."
                                                                    AutoPostBack="true">
                                                                </telerik:RadButton>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                                <td class="panelR">
                                </td>
                            </tr>
                            <tr>
                                <td class="panelBL">
                                    <img src="../Images/space.gif" class="panelBLSpace" alt="" />
                                </td>
                                <td class="panelB">
                                </td>
                                <td class="panelBR">
                                    <img src="../Images/space.gif" class="panelBRSpace" alt="" />
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td width="10%">
                        &nbsp;
                    </td>
                    <td width="40%" style="vertical-align: top;">
                        <table class="dv" cellpadding="0" cellspacing="0" border="0">
                            <tr>
                                <td class="panelTL">
                                    <img src="../Images/space.gif" class="panelTLSpace" alt="" />
                                </td>
                                <td class="panelT">
                                </td>
                                <td class="panelTR">
                                    <img src="../Images/space.gif" class="panelTRSpace" alt="" />
                                </td>
                            </tr>
                            <tr>
                                <td class="panelHeaderL">
                                </td>
                                <td class="dh">
                                    <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                        <tr>
                                            <td class="dhel">
                                                <img src="../Images/space.gif" alt="" />
                                            </td>
                                            <td class="dheci" valign="middle">
                                            </td>
                                            <td class="dhb">
                                                <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                                    <tr>
                                                        <td class="dht" valign="middle">
                                                            1.2 - Personal Info
                                                        </td>
                                                        <td align="right">
                                                            <img id="PersonalInstImg" alt="" src="../Images/Custom/HelpBlack.png" onclick="return onInstClick('PersonalInstImg','549');"
                                                                onmouseover="return flipSRC('PersonalInstImg','../Images/Custom/HelpBlackGlow.png');"
                                                                onmouseout="return flipSRC('PersonalInstImg','../Images/Custom/HelpBlack.png');" />
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
                                <td class="panelHeaderR">
                                </td>
                            </tr>
                            <tr>
                                <td class="panelL">
                                </td>
                                <td>
                                    <asp:Panel ID="PersonalFrameCollapsibleRegion1" runat="server">
                                        <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                            <tr>
                                                <td class="tre">
                                                    <table cellpadding="0" cellspacing="0" border="0">
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="DOBLabel" Text="Date of Birth">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadMaskedTextBox ID="DOBRadTB" runat="server" Mask="##/##/####" Width="130px">
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="SSNLabel" Text="Social Security No.">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadMaskedTextBox ID="SSNRadTB" runat="server" Mask="###-##-####" Width="130px">
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="USCitizenLabel" Text="US Citizen?">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <asp:CheckBox CssClass="field_input" ID="USCitizenCB" runat="server" AutoPostBack="True"
                                                                    BorderColor="White"></asp:CheckBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="AuthorizedAlienLabel" Text="Authorized Alien?">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <asp:CheckBox CssClass="field_input" ID="AuthAlienCB" runat="server" AutoPostBack="True">
                                                                </asp:CheckBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="AuthTypeLabel" Text="Alien Type">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadComboBox ID="AuthTypeRadCombo" runat="server" AllowCustomText="True"
                                                                    DataSourceID="AuthTypeDS" DataTextField="ItemName" DataValueField="TreeID" Filter="Contains"
                                                                    MarkFirstMatch="True" MaxLength="255" Width="130px" EmptyMessage="Choose Type"
                                                                    ZIndex="50001">
                                                                </telerik:RadComboBox>
                                                                <asp:SqlDataSource ID="AuthTypeDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                    SelectCommand="SELECT * FROM [Tree] WHERE ([TreeParentID] = @AuthTypeParentID)">
                                                                    <SelectParameters>
                                                                        <asp:Parameter DefaultValue="1981" Name="AuthTypeParentID" Type="Int32" />
                                                                    </SelectParameters>
                                                                </asp:SqlDataSource>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="VisaLabel" Text="Visa Number">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <asp:TextBox ID="VisaTB" runat="server" CssClass="field_input" Width="130px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                            </td>
                                                            <td>
                                                                <telerik:RadButton ID="PersonalRadButton" runat="server" Text="Edit" ToolTip="Click here to edit the fields shown above.">
                                                                </telerik:RadButton>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                                <td class="panelR">
                                </td>
                            </tr>
                            <tr>
                                <td class="panelBL">
                                    <img src="../Images/space.gif" class="panelBLSpace" alt="" />
                                </td>
                                <td class="panelB">
                                </td>
                                <td class="panelBR">
                                    <img src="../Images/space.gif" class="panelBRSpace" alt="" />
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td width="5%">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td style="vertical-align: top;">
                        <table class="dv" cellpadding="0" cellspacing="0" border="0">
                            <tr>
                                <td class="panelTL">
                                    <img src="../Images/space.gif" class="panelTLSpace" alt="" />
                                </td>
                                <td class="panelT">
                                </td>
                                <td class="panelTR">
                                    <img src="../Images/space.gif" class="panelTRSpace" alt="" />
                                </td>
                            </tr>
                            <tr>
                                <td class="panelHeaderL">
                                </td>
                                <td class="dh">
                                    <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                        <tr>
                                            <td class="dhel">
                                                <img src="../Images/space.gif" alt="" />
                                            </td>
                                            <td class="dheci" valign="middle">
                                            </td>
                                            <td class="dhb">
                                                <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                                    <tr>
                                                        <td class="dht" valign="middle">
                                                            1.3 - Addresses
                                                        </td>
                                                        <td align="right">
                                                            <img id="AddrInstImg" alt="" src="../Images/Custom/HelpBlack.png" onclick="return onInstClick('AddrInstImg','548');"
                                                                onmouseover="return flipSRC('AddrInstImg','../Images/Custom/HelpBlackGlow.png');"
                                                                onmouseout="return flipSRC('AddrInstImg','../Images/Custom/HelpBlack.png');" />
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
                                <td class="panelHeaderR">
                                </td>
                            </tr>
                            <tr>
                                <td class="panelL">
                                </td>
                                <td>
                                    <asp:Panel ID="AddrFrameCollapsibleRegion2" runat="server">
                                        <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                            <tr>
                                                <td class="tre">
                                                    <center>
                                                        <table cellpadding="0" cellspacing="0" border="0">
                                                            <tr>
                                                                <td>
                                                                    <center>
                                                                        <table>
                                                                            <tr>
                                                                                <td class="fls" style="width: 35px; vertical-align: middle; text-align: center;">
                                                                                    <asp:Label runat="server" ID="AddrSliderLabel" Text="Required Years">	</asp:Label>
                                                                                </td>
                                                                                <td style="vertical-align: middle;">
                                                                                    <telerik:RadSlider ID="AddrRadSlider" runat="server" AnimationDuration="400" Height="50px"
                                                                                        ItemType="tick" LargeChange="1" MaximumValue="3" MinimumValue="0" SmallChange=".5"
                                                                                        ThumbsInteractionMode="Free" TrackPosition="BottomRight" ShowDecreaseHandle="false"
                                                                                        ShowIncreaseHandle="false" Skin="Metro">
                                                                                    </telerik:RadSlider>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </center>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="dfv">
                                                                    <br />
                                                                    <telerik:RadButton ID="AddrAddRB" runat="server" Text="Add New Address" AutoPostBack="false"
                                                                        ToolTip="Click to add a new address." OnClientClicked="onAddrAddClick">
                                                                    </telerik:RadButton>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td>
                                                                    <telerik:RadGrid ID="AddrRadGrid" runat="server" AutoGenerateColumns="False" CellSpacing="0"
                                                                        DataSourceID="AddrDS" GridLines="None" ShowHeader="False" CssClass="RemoveBorders">
                                                                        <ClientSettings EnableRowHoverStyle="True">
                                                                            <ClientEvents OnRowClick="onAddrRGRowClick" />
                                                                        </ClientSettings>
                                                                        <MasterTableView ClientDataKeyNames="AddrID,MovedIn,MovedOutOn" DataKeyNames="AddrID"
                                                                            DataSourceID="AddrDS" Name="AddrTable">
                                                                            <NoRecordsTemplate>
                                                                                <div style="padding: 25px;">
                                                                                    No addresses entered yet. Please click the "Add Address" button above.
                                                                                </div>
                                                                            </NoRecordsTemplate>
                                                                            <Columns>
                                                                                <telerik:GridBoundColumn DataField="AddrHTML" HeaderStyle-Width="190px" UniqueName="AddrHTML">
                                                                                    <HeaderStyle Width="190px" />
                                                                                </telerik:GridBoundColumn>
                                                                                <telerik:GridBoundColumn DataField="Dates" UniqueName="Dates">
                                                                                    <HeaderStyle />
                                                                                </telerik:GridBoundColumn>
                                                                                <telerik:GridTemplateColumn UniqueName="AddrDeleteCol">
                                                                                    <ItemTemplate>
                                                                                        <asp:ImageButton ID="AddrDeleteIB" runat="server" ImageUrl="/Images/Custom/XOut_Small.png" />
                                                                                    </ItemTemplate>
                                                                                </telerik:GridTemplateColumn>
                                                                            </Columns>
                                                                            <PagerStyle PageSizeControlType="RadComboBox" />
                                                                        </MasterTableView>
                                                                        <PagerStyle PageSizeControlType="RadComboBox" />
                                                                    </telerik:RadGrid>
                                                                    <asp:SqlDataSource ID="AddrDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                        SelectCommand="usp_Addr" SelectCommandType="StoredProcedure">
                                                                        <SelectParameters>
                                                                            <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="AddrPartyID" PropertyName="Text"
                                                                                Type="Int32" />
                                                                            <asp:ControlParameter ControlID="HiddenTB_InfoRun" Name="AddrRun" PropertyName="Text"
                                                                                Type="String" />
                                                                        </SelectParameters>
                                                                    </asp:SqlDataSource>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </center>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                                <td class="panelR">
                                </td>
                            </tr>
                            <tr>
                                <td class="panelBL">
                                    <img src="../Images/space.gif" class="panelBLSpace" alt="" />
                                </td>
                                <td class="panelB">
                                </td>
                                <td class="panelBR">
                                    <img src="../Images/space.gif" class="panelBRSpace" alt="" />
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                    </td>
                    <td style="vertical-align: top;">
                        <table class="dv" cellpadding="0" cellspacing="0" border="0">
                            <tr>
                                <td class="panelTL">
                                    <img src="../Images/space.gif" class="panelTLSpace" alt="" />
                                </td>
                                <td class="panelT">
                                </td>
                                <td class="panelTR">
                                    <img src="../Images/space.gif" class="panelTRSpace" alt="" />
                                </td>
                            </tr>
                            <tr>
                                <td class="panelHeaderL">
                                </td>
                                <td class="dh">
                                    <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                        <tr>
                                            <td class="dhel">
                                                <img src="../Images/space.gif" alt="" />
                                            </td>
                                            <td class="dheci" valign="middle">
                                            </td>
                                            <td class="dhb">
                                                <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                                    <tr>
                                                        <td class="dht" valign="middle">
                                                            1.4 - Stuff You Want
                                                        </td>
                                                        <td align="right">
                                                            <img id="PrefsInstImg" alt="" src="../Images/Custom/HelpBlack.png" onclick="return onInstClick('PrefsInstImg','550');"
                                                                onmouseover="return flipSRC('PrefsInstImg','../Images/Custom/HelpBlackGlow.png');"
                                                                onmouseout="return flipSRC('PrefsInstImg','../Images/Custom/HelpBlack.png');" />
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
                                <td class="panelHeaderR">
                                </td>
                            </tr>
                            <tr>
                                <td class="panelL">
                                </td>
                                <td>
                                    <asp:Panel ID="PrefsFrameCollapsibleRegion3" runat="server">
                                        <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                            <tr>
                                                <td class="tre">
                                                    <table>
                                                        <tr class="dfv">
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="Pref_GeneralLbl" Text="CDL Type, Etc.">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadAutoCompleteBox ID="Pref_GeneralRAC" runat="server" Filter="Contains"
                                                                    DataSourceID="Pref_GeneralDS" DataValueField="TreeID" DataTextField="TreeFull"
                                                                    InputType="Token" DropDownWidth="300px" Width="275px">
                                                                    <DropDownItemTemplate>
                                                                        <%# DataBinder.Eval(Container.DataItem, "TreeFullHTML")%>
                                                                    </DropDownItemTemplate>
                                                                </telerik:RadAutoCompleteBox>
                                                                <asp:SqlDataSource ID="Pref_GeneralDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                    SelectCommand="usp_Pref_GeneralRollUp" SelectCommandType="StoredProcedure">
                                                                    <SelectParameters>
                                                                        <asp:Parameter DefaultValue="743" Name="Pref_GeneralPrune" Type="String" />
                                                                    </SelectParameters>
                                                                </asp:SqlDataSource>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadButton ID="Pref_GeneralRB" runat="server" Text="+/-" OnClientClicked="function (button,args){showPrefRTT('Pref_GeneralRB','743');}">
                                                                </telerik:RadButton>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="Pref_EquipLbl" Text="Equipment">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadAutoCompleteBox ID="Pref_EquipRAC" runat="server" Filter="Contains" DataSourceID="Pref_EquipDS"
                                                                    DataValueField="TreeID" DataTextField="TreeFull" InputType="Token" DropDownWidth="300px"
                                                                    Width="275px">
                                                                    <DropDownItemTemplate>
                                                                        <%# DataBinder.Eval(Container.DataItem, "TreeFullHTML")%>
                                                                    </DropDownItemTemplate>
                                                                </telerik:RadAutoCompleteBox>
                                                                <asp:SqlDataSource ID="Pref_EquipDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                    SelectCommand="usp_Pref_EquipRollUp" SelectCommandType="StoredProcedure">
                                                                    <SelectParameters>
                                                                        <asp:Parameter DefaultValue="389" Name="Pref_EquipPrune" Type="String" />
                                                                    </SelectParameters>
                                                                </asp:SqlDataSource>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadButton ID="Pref_EquipRB" runat="server" Text="+/-" OnClientClicked="function (button,args){showPrefRTT('Pref_EquipRB','389');}">
                                                                </telerik:RadButton>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="Pref_CommodityLbl" Text="Cargo">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadAutoCompleteBox ID="Pref_CommodityRAC" runat="server" Filter="Contains"
                                                                    DataSourceID="Pref_CommodityDS" DataValueField="TreeID" DataTextField="TreeFull"
                                                                    InputType="Token" DropDownWidth="300px" Width="275px">
                                                                    <DropDownItemTemplate>
                                                                        <%# DataBinder.Eval(Container.DataItem, "TreeFullHTML")%>
                                                                    </DropDownItemTemplate>
                                                                </telerik:RadAutoCompleteBox>
                                                                <asp:SqlDataSource ID="Pref_CommodityDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                    SelectCommand="usp_Pref_CommodityRollUp" SelectCommandType="StoredProcedure">
                                                                    <SelectParameters>
                                                                        <asp:Parameter DefaultValue="666" Name="Pref_CommodityPrune" Type="String" />
                                                                    </SelectParameters>
                                                                </asp:SqlDataSource>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadButton ID="Pref_CommodityRB" runat="server" Text="+/-" OnClientClicked="function (button,args){showPrefRTT('Pref_CommodityRB','666');}">
                                                                </telerik:RadButton>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="Pref_RegionsLbl" Text="Regions">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadAutoCompleteBox ID="Pref_RegionsRAC" runat="server" Filter="Contains"
                                                                    DataSourceID="Pref_RegionsDS" DataValueField="TreeID" DataTextField="TreeFull"
                                                                    InputType="Token" DropDownWidth="300px" Width="275px">
                                                                    <DropDownItemTemplate>
                                                                        <%# DataBinder.Eval(Container.DataItem, "TreeFullHTML")%>
                                                                    </DropDownItemTemplate>
                                                                </telerik:RadAutoCompleteBox>
                                                                <asp:SqlDataSource ID="Pref_RegionsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                    SelectCommand="usp_Pref_RegionsRollUp" SelectCommandType="StoredProcedure">
                                                                    <SelectParameters>
                                                                        <asp:Parameter DefaultValue="741" Name="Pref_RegionsPrune" Type="String" />
                                                                    </SelectParameters>
                                                                </asp:SqlDataSource>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadButton ID="Pref_RegionsRB" runat="server" Text="+/-" OnClientClicked="function (button,args){showPrefRTT('Pref_RegionsRB','741');}">
                                                                </telerik:RadButton>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Label runat="server" ID="Pref_OtherLbl" Text="Other Items">	</asp:Label>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadAutoCompleteBox ID="Pref_OtherRAC" runat="server" Filter="Contains" DataSourceID="Pref_OtherDS"
                                                                    DataValueField="TreeID" DataTextField="TreeFull" InputType="Token" DropDownWidth="300px"
                                                                    Width="275px">
                                                                    <DropDownItemTemplate>
                                                                        <%# DataBinder.Eval(Container.DataItem, "TreeFullHTML")%>
                                                                    </DropDownItemTemplate>
                                                                </telerik:RadAutoCompleteBox>
                                                                <asp:SqlDataSource ID="Pref_OtherDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                    SelectCommand="usp_Pref_OtherRollUp" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadButton ID="Pref_OtherRB" runat="server" Text="+/-" OnClientClicked="function (button,args){showPrefRTT('Pref_OtherRB','851,852,853');}">
                                                                </telerik:RadButton>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadButton ID="Pref_EditRB" runat="server" Text="Edit" ToolTip="Click to modify the 'Stuff You Want'.">
                                                                </telerik:RadButton>
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                                <td class="panelR">
                                </td>
                            </tr>
                            <tr>
                                <td class="panelBL">
                                    <img src="../Images/space.gif" class="panelBLSpace" alt="" />
                                </td>
                                <td class="panelB">
                                </td>
                                <td class="panelBR">
                                    <img src="../Images/space.gif" class="panelBRSpace" alt="" />
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
        </div>
        <div id="HistoryDiv" style="display: none;">
            <table style="border: 8px solid #D9D9D9; border-radius: 5px; margin-bottom: 20px;
                margin-top: 20px" frame="border" align="center">
                <tr>
                    <td style="padding-left: 15px">
                        Required Years
                    </td>
                    <td style="padding: 15px">
                        <telerik:RadSlider ID="YearsRadSlider" runat="server" AnimationDuration="400" Height="50px"
                            ItemType="tick" LargeChange="1" MaximumValue="10" MinimumValue="0" SmallChange=".5"
                            ThumbsInteractionMode="Free" Width="350px" TrackPosition="BottomRight" ShowDecreaseHandle="false"
                            ShowIncreaseHandle="false" Skin="Metro">
                        </telerik:RadSlider>
                    </td>
                </tr>
            </table>
            <table style="border-style: none; border-radius: 10px; background-color: #D9D9D9;
                width: 100%">
                <tbody>
                    <tr>
                        <td style="padding-left: 10px">
                            <telerik:RadButton ID="HistAddScratchButton" runat="server" Text="Add Job or Unemployment Period"
                                ToolTip="Click to add a new job or unemployment period." CommandName="HistOpenTip"
                                AutoPostBack="false" OnClientClicked="openJobRWNew" BorderColor="White">
                            </telerik:RadButton>
                        </td>
                        <td align="right" width="inherit" style="margin-right: 10px">
                            <span style="font-size: 12pt; color: Red; margin-right: 10px;">
                                <asp:Literal ID="HistWarningLtl" runat="server" Text=""></asp:Literal>
                            </span>
                        </td>
                    </tr>
                </tbody>
            </table>
            <br />
            <center>
                <telerik:RadListView ID="YrRLV" runat="server" ClientDataKeyNames="YrID" DataKeyNames="YrID"
                    DataSourceID="YrDS" PageSize="12" BorderStyle="None" EnableEmbeddedSkins="False"
                    Skin="BlackMetroTouch">
                    <LayoutTemplate>
                        <div class="RadListView RadListView_Default">
                            <table cellspacing="0">
                                <tr>
                                    <td id="itemPlaceholder" runat="server">
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <td class="rlvI">
                            <asp:Label ID="YrImage" runat="server" Text='<%# Eval("YrImage") %>' />
                        </td>
                    </ItemTemplate>
                    <SelectedItemTemplate>
                        <td class="rlvISel">
                        </td>
                    </SelectedItemTemplate>
                </telerik:RadListView>
                <asp:SqlDataSource ID="YrDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                    SelectCommand="usp_Years_H" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="0" Name="CurrentDate" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                <asp:Panel ID="R1Panel" runat="server">
                    <telerik:RadListView ID="R1HistoryRLV" runat="server" ClientDataKeyNames="HistoryID"
                        DataKeyNames="HistoryID, HistoryToolTipHTML, StartDate, EndDate" DataSourceID="R1HistoryDS"
                        PageSize="13" Height="120px">
                        <ClientSettings AllowItemsDragDrop="true">
                            <ClientEvents OnItemDragStarted="itemDragStarted" OnItemDragging="itemDragging" OnItemDropping="trackDropping">
                            </ClientEvents>
                        </ClientSettings>
                        <LayoutTemplate>
                            <div class="RadListView RadListView_Default">
                                <table cellspacing="0">
                                    <tr>
                                        <td id="itemPlaceholder" runat="server">
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <td class="rlvI">
                                <div id="<%# Eval("HistoryID") %>" style="float: left; margin: 0px; padding: 0px;
                                    min-height: 100px; position: relative;" onmouseover="histmouseover(this)" onmouseout="histmouseout(this)">
                                    <div style="z-index: 100; margin-top: 70px; margin-left: 5px; position: absolute;
                                        width: 235px; display: none;" class="fp_button_wrapper">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <telerik:RadListViewItemDragHandle ID="HistDragDH" runat="server" ToolTip="Use this 'drag handle' to drag and drop this item to a different row.">
                                                        </telerik:RadListViewItemDragHandle>
                                                    </td>
                                                    <td>
                                                        <telerik:RadButton ID="HistOpenTipRB" runat="server" Text="More Info" ToolTip="Click to view the details of the item."
                                                            CommandName="HistOpenTip">
                                                        </telerik:RadButton>
                                                    </td>
                                                    <td>
                                                        <telerik:RadButton ID="HistEditRB" runat="server" Text="Edit" ToolTip="Click to edit this entry."
                                                            CommandName="HistEdit">
                                                        </telerik:RadButton>
                                                    </td>
                                                    <td>
                                                        <telerik:RadButton ID="HistDelRB" runat="server" Text="Delete" ToolTip="Click to delete this entry."
                                                            CommandName="HistDel">
                                                            <Icon PrimaryIconCssClass="rbRemove" PrimaryIconLeft="4" PrimaryIconTop="4"></Icon>
                                                        </telerik:RadButton>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                    <div style="z-index: 1000; padding: 2px; margin-top: 70px; margin-left: 5px; position: absolute;
                                        width: 204px; display: none;" class="fp_button_wrapper">
                                        <telerik:RadButton ID="HistAddRB" runat="server" Text="Add Job or Unemployment Period"
                                            ToolTip="Click to add a job or unemployment period here." CommandName="HistAdd">
                                        </telerik:RadButton>
                                    </div>
                                    <div style="z-index: 1000; padding: 2px; margin-top: 70px; margin-left: 5px; position: absolute;
                                        width: 77px; display: none;" class="fp_button_wrapper">
                                        <telerik:RadButton ID="HistMoreInfoRB" runat="server" Text="More Info" ToolTip="Click to view the details of the item."
                                            CommandName="HistOpenTip">
                                        </telerik:RadButton>
                                    </div>
                                    <asp:Label ID="HistoryPodHTML" runat="server" Text='<%# Eval("HistoryPodHTML") %>' />
                            </td>
                        </ItemTemplate>
                        <SelectedItemTemplate>
                            <td class="rlvISel">
                            </td>
                        </SelectedItemTemplate>
                    </telerik:RadListView>
                    <asp:SqlDataSource ID="R1HistoryDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                        SelectCommand="usp_HistoryPods_H" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="PodsPartyID" PropertyName="Text"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="HiddenTB_HistRun" Name="HistPodRun" PropertyName="Text"
                                Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <br />
                    <telerik:RadListView ID="R2HistoryRLV" runat="server" ClientDataKeyNames="HistoryID"
                        DataKeyNames="HistoryID, HistoryToolTipHTML" DataSourceID="R2HistoryDS" PageSize="13"
                        Height="120px">
                        <ClientSettings AllowItemsDragDrop="true">
                            <ClientEvents OnItemDragStarted="itemDragStarted" OnItemDragging="itemDragging" OnItemDropping="trackDropping">
                            </ClientEvents>
                        </ClientSettings>
                        <LayoutTemplate>
                            <div class="RadListView RadListView_Default">
                                <table cellspacing="0">
                                    <tr>
                                        <td id="itemPlaceholder" runat="server">
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <td class="rlvI">
                                <div id="<%# Eval("HistoryID") %>" style="float: left; margin: 0px; padding: 0px;
                                    min-height: 100px; position: relative;" onmouseover="histmouseover(this)" onmouseout="histmouseout(this)">
                                    <div style="z-index: 100; margin-top: 70px; margin-left: 5px; position: absolute;
                                        width: 235px; display: none;" class="fp_button_wrapper">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <telerik:RadListViewItemDragHandle ID="HistDragDH2" runat="server" ToolTip="Use this 'drag handle' to drag and drop this item to a different row.">
                                                        </telerik:RadListViewItemDragHandle>
                                                    </td>
                                                    <td>
                                                        <telerik:RadButton ID="HistOpenTipRB2" runat="server" Text="More Info" ToolTip="Click to view the details of the item."
                                                            CommandName="HistOpenTip">
                                                        </telerik:RadButton>
                                                    </td>
                                                    <td>
                                                        <telerik:RadButton ID="HistEditRB2" runat="server" Text="Edit" ToolTip="Click to edit this entry."
                                                            CommandName="HistEdit">
                                                        </telerik:RadButton>
                                                    </td>
                                                    <td>
                                                        <telerik:RadButton ID="HistDelRB2" runat="server" Text="Delete" ToolTip="Click to delete this entry."
                                                            CommandName="HistDel">
                                                            <Icon PrimaryIconCssClass="rbRemove" PrimaryIconLeft="4" PrimaryIconTop="4"></Icon>
                                                        </telerik:RadButton>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                    <div style="z-index: 1000; padding: 2px; margin-top: 70px; margin-left: 5px; position: absolute;
                                        width: 204px; display: none;" class="fp_button_wrapper">
                                        <telerik:RadButton ID="HistAddRB2" runat="server" Text="Add Job or Unemployment Period"
                                            ToolTip="Click to add a job or unemployment period here." CommandName="HistAdd">
                                        </telerik:RadButton>
                                    </div>
                                    <div style="z-index: 1000; padding: 2px; margin-top: 70px; margin-left: 5px; position: absolute;
                                        width: 77px; display: none;" class="fp_button_wrapper">
                                        <telerik:RadButton ID="HistMoreInfoRB2" runat="server" Text="More Info" ToolTip="Click to view the details of the item."
                                            CommandName="HistOpenTip">
                                        </telerik:RadButton>
                                    </div>
                                    <asp:Label ID="HistoryPodHTML2" runat="server" Text='<%# Eval("HistoryPodHTML") %>' />
                            </td>
                        </ItemTemplate>
                        <SelectedItemTemplate>
                            <td class="rlvISel">
                            </td>
                        </SelectedItemTemplate>
                    </telerik:RadListView>
                    <asp:SqlDataSource ID="R2HistoryDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                        SelectCommand="usp_HistoryPods_H_Overlap2" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="PodsPartyID_Overlap2" PropertyName="Text"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="HiddenTB_HistRun" Name="HistPod2Run" PropertyName="Text"
                                Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <br />
                    <telerik:RadListView ID="R3HistoryRLV" runat="server" ClientDataKeyNames="HistoryID"
                        DataKeyNames="HistoryID, HistoryToolTipHTML" DataSourceID="R3HistoryDS" PageSize="13"
                        Height="120px">
                        <ClientSettings AllowItemsDragDrop="true">
                            <ClientEvents OnItemDragStarted="itemDragStarted" OnItemDragging="itemDragging" OnItemDropping="trackDropping">
                            </ClientEvents>
                        </ClientSettings>
                        <LayoutTemplate>
                            <div class="RadListView RadListView_Default">
                                <table cellspacing="0">
                                    <tr>
                                        <td id="itemPlaceholder" runat="server">
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <td class="rlvI">
                                <div id="<%# Eval("HistoryID") %>" style="float: left; margin: 0px; padding: 0px;
                                    min-height: 100px; position: relative;" onmouseover="histmouseover(this)" onmouseout="histmouseout(this)">
                                    <div style="z-index: 100; margin-top: 70px; margin-left: 5px; position: absolute;
                                        width: 235px; display: none;" class="fp_button_wrapper">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <telerik:RadListViewItemDragHandle ID="HistDragDH3" runat="server" ToolTip="Use this 'drag handle' to drag and drop this item to a different row.">
                                                        </telerik:RadListViewItemDragHandle>
                                                    </td>
                                                    <td>
                                                        <telerik:RadButton ID="HistOpenTipRB3" runat="server" Text="More Info" ToolTip="Click to view the details of the item."
                                                            CommandName="HistOpenTip">
                                                        </telerik:RadButton>
                                                    </td>
                                                    <td>
                                                        <telerik:RadButton ID="HistEditRB3" runat="server" Text="Edit" ToolTip="Click to edit this entry."
                                                            CommandName="HistEdit">
                                                        </telerik:RadButton>
                                                    </td>
                                                    <td>
                                                        <telerik:RadButton ID="HistDelRB3" runat="server" Text="Delete" ToolTip="Click to delete this entry."
                                                            CommandName="HistDel">
                                                            <Icon PrimaryIconCssClass="rbRemove" PrimaryIconLeft="4" PrimaryIconTop="4"></Icon>
                                                        </telerik:RadButton>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                    <div style="z-index: 1000; padding: 2px; margin-top: 70px; margin-left: 5px; position: absolute;
                                        width: 204px; display: none;" class="fp_button_wrapper">
                                        <telerik:RadButton ID="HistAddRB3" runat="server" Text="Add Job or Unemployment Period"
                                            ToolTip="Click to add a job or unemployment period here." CommandName="HistAdd">
                                        </telerik:RadButton>
                                    </div>
                                    <div style="z-index: 1000; padding: 2px; margin-top: 70px; margin-left: 5px; position: absolute;
                                        width: 77px; display: none;" class="fp_button_wrapper">
                                        <telerik:RadButton ID="HistMoreInfoRB3" runat="server" Text="More Info" ToolTip="Click to view the details of the item."
                                            CommandName="HistOpenTip">
                                        </telerik:RadButton>
                                    </div>
                                    <asp:Label ID="HistoryPodHTML3" runat="server" Text='<%# Eval("HistoryPodHTML") %>' />
                            </td>
                        </ItemTemplate>
                        <SelectedItemTemplate>
                            <td class="rlvISel">
                            </td>
                        </SelectedItemTemplate>
                    </telerik:RadListView>
                </asp:Panel>
            </center>
            <asp:SqlDataSource ID="R3HistoryDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                SelectCommand="usp_HistoryPods_H_Overlap3" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="PodsPartyID_Overlap3" PropertyName="Text"
                        Type="Int32" />
                    <asp:ControlParameter ControlID="HiddenTB_HistRun" Name="HistPod3Run" PropertyName="Text"
                        Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
        <div id="ExpDiv" style="display: none;">
            <telerik:RadSplitter ID="ExpRS" runat="server" Height="100%" Width="100%" Orientation="Vertical"
                Skin="BlackMetroTouch">
                <telerik:RadPane ID="ExpTreeRP" runat="server" Width="300" MinWidth="150" MaxWidth="450">
                    <div>
                        <telerik:RadSearchBox ID="ExpRSB" runat="server" DataSourceID="ExpRTV_DS" DataValueField="TreeID"
                            DataTextField="TreeFull" EmptyMessage="Search Items Below Here" Width="225px"
                            MaxResultCount="15" MinFilterLength="2" DropDownSettings-Height="240" Skin="Metro"
                            OnSearch="ExpRSB_Search" Style="margin: 10px" CssClass="CustomRSB">
                        </telerik:RadSearchBox>
                    </div>
                    <telerik:RadTreeView ID="ExpRTV" runat="server" DataFieldID="TreeID" DataFieldParentID="TreeParentID"
                        DataSourceID="ExpRTV_DS" DataTextField="FolderOnly" DataValueField="TreeID" EnableDragAndDrop="true"
                        OnNodeDataBound="NodeDataBound" OnNodeDrop="ExpRTV_HandleDrop" OnClientNodeDragging="onNodeDragging"
                        OnClientNodeDropping="onNodeDropping" OnClientNodeDropped="onNodeDropped" MultipleSelect="true"
                        EnableDragAndDropBetweenNodes="False" Skin="MetroTouch" OnClientNodeClicked="onNodeClicked">
                        <NodeTemplate>
                            <%# Eval("ItemHTML")%>
                        </NodeTemplate>
                    </telerik:RadTreeView>
                    <asp:SqlDataSource ID="ExpRTV_DS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                        SelectCommand="usp_TRU_ExpRTV" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                </telerik:RadPane>
                <telerik:RadSplitBar ID="VerticalSplitBar" runat="server" CollapseMode="Forward" />
                <telerik:RadPane ID="ExpRP" runat="server">
                    <br />
                    <center>
                        <asp:Image ID="DropExpImg" runat="server" Width="225" Length="77"></asp:Image><br />
                    </center>
                    <div align="right">
                        <table>
                            <tbody>
                                <tr>
                                    <td width="475px" style="font-size: 16px; text-align: right; color: Black; vertical-align: middle;
                                        padding-top: 12px;">
                                        <asp:Label ID="ExpUnlockedLbl" runat="server" Text="Click to LOCK All >>>" Style=""></asp:Label>
                                        <asp:Label ID="ExpLockedLbl" runat="server" Text="Click to UNLOCK All >>>" Style="display: none;"></asp:Label>
                                    </td>
                                    <td>
                                        <telerik:RadButton ID="ExpLockRB" runat="server" ButtonType="ToggleButton" ToggleType="CustomToggle"
                                            AutoPostBack="true" Height="35px" Width="35px" TabIndex="30" OnClientClicked="onExpLockRB_Clicked"
                                            OnClientLoad="onExpLockRB_Load">
                                            <ToggleStates>
                                                <telerik:RadButtonToggleState ImageUrl="/Images/Custom/un_lock_blk_large.png" HoveredImageUrl="/Images/Custom/un_lock_glow_blk_large.png"
                                                    Text="" Selected="true" Value="False"></telerik:RadButtonToggleState>
                                                <telerik:RadButtonToggleState ImageUrl="/Images/Custom/lock_blk_large.png" Text=""
                                                    HoveredImageUrl="/Images/Custom/lock_glow_blk_large.png" Value="True"></telerik:RadButtonToggleState>
                                            </ToggleStates>
                                        </telerik:RadButton>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <br />
                    <telerik:RadGrid ID="ExpRG" runat="server" AutoGenerateColumns="False" CellSpacing="0"
                        DataSourceID="ExpDS" OnItemDataBound="ExpRG_ItemDataBound" GridLines="None" ShowHeader="true"
                        CssClass="RemoveBorders" Skin="Silk">
                        <ClientSettings EnableAlternatingItems="false">
                            <ClientEvents OnRowMouseOver="onExpRGMouseOver" />
                        </ClientSettings>
                        <MasterTableView ClientDataKeyNames="HistoryID" DataKeyNames="HistoryID" DataSourceID="ExpDS"
                            Name="ExpTable">
                            <NoRecordsTemplate>
                                <div style="padding: 25px;">
                                    No trucking jobs entered yet. Please go to "3. History" to enter trucking jobs.
                                </div>
                            </NoRecordsTemplate>
                            <CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>
                            <RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
                            </RowIndicatorColumn>
                            <ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
                            </ExpandCollapseColumn>
                            <Columns>
                                <telerik:GridBoundColumn DataField="ExpHTML" UniqueName="ExpHTML" HeaderText="Carrier">
                                    <HeaderStyle Width="225px" />
                                </telerik:GridBoundColumn>
                                <telerik:GridTemplateColumn UniqueName="SpaceColumn">
                                    <ItemTemplate>
                                        <div style="width: 25px">
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="GenExpTemplateCol" HeaderText="1. General">
                                    <ItemTemplate>
                                        <telerik:RadGrid ID="GenExpRG" runat="server" AutoGenerateColumns="False" CellSpacing="0"
                                            GridLines="None" ShowHeader="False" CssClass="RemoveBorders1" Skin="Default">
                                            <ClientSettings EnableAlternatingItems="false">
                                            </ClientSettings>
                                            <MasterTableView ClientDataKeyNames="PartyExperienceID,HistoryID" DataKeyNames="PartyExperienceID,HistoryID">
                                                <NoRecordsTemplate>
                                                    <div>
                                                    </div>
                                                </NoRecordsTemplate>
                                                <Columns>
                                                    <telerik:GridBoundColumn DataField="ItemImage" UniqueName="ItemImage">
                                                        <HeaderStyle Width="30px" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="ItemName_Perc" UniqueName="ItemName_Perc">
                                                        <HeaderStyle Width="135px" />
                                                    </telerik:GridBoundColumn>
                                                </Columns>
                                            </MasterTableView>
                                        </telerik:RadGrid>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="Exp_GenRBColumn">
                                    <ItemTemplate>
                                        <telerik:RadButton ID="Exp_GenRB" runat="server" Text="+/-" AutoPostBack="true" CommandName="Exp_GenRB"
                                            OnClientClicked="onExp_GenRBClicked">
                                        </telerik:RadButton>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="EquipExpTemplateCol" HeaderText="2. Experience">
                                    <ItemTemplate>
                                        <telerik:RadGrid ID="EquipExpRG" runat="server" AutoGenerateColumns="False" CellSpacing="0"
                                            GridLines="None" ShowHeader="False" CssClass="RemoveBorders1" Skin="Default">
                                            <ClientSettings EnableAlternatingItems="false">
                                            </ClientSettings>
                                            <MasterTableView ClientDataKeyNames="PartyExperienceID,HistoryID" DataKeyNames="PartyExperienceID,HistoryID">
                                                <NoRecordsTemplate>
                                                    <div>
                                                    </div>
                                                </NoRecordsTemplate>
                                                <Columns>
                                                    <telerik:GridBoundColumn DataField="ItemImage" UniqueName="ItemImage">
                                                        <HeaderStyle Width="30px" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="ItemName_Perc" UniqueName="ItemName_Perc">
                                                        <HeaderStyle Width="135px" />
                                                    </telerik:GridBoundColumn>
                                                </Columns>
                                            </MasterTableView>
                                        </telerik:RadGrid>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="Exp_EquipRBColumn">
                                    <ItemTemplate>
                                        <telerik:RadButton ID="Exp_EquipRB" runat="server" Text="+/-" AutoPostBack="true"
                                            CommandName="Exp_EquipRB" OnClientClicked="onExp_EquipRBClicked">
                                        </telerik:RadButton>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="CargoExpTemplateCol" HeaderText="3. Cargo">
                                    <ItemTemplate>
                                        <telerik:RadGrid ID="CargoExpRG" runat="server" AutoGenerateColumns="False" CellSpacing="0"
                                            GridLines="None" ShowHeader="False" CssClass="RemoveBorders1" Skin="Default">
                                            <ClientSettings EnableAlternatingItems="false">
                                            </ClientSettings>
                                            <MasterTableView ClientDataKeyNames="PartyExperienceID,HistoryID" DataKeyNames="PartyExperienceID,HistoryID">
                                                <NoRecordsTemplate>
                                                    <div>
                                                    </div>
                                                </NoRecordsTemplate>
                                                <Columns>
                                                    <telerik:GridBoundColumn DataField="ItemImage" UniqueName="ItemImage">
                                                        <HeaderStyle Width="30px" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="ItemName_Perc" UniqueName="ItemName_Perc">
                                                        <HeaderStyle Width="135px" />
                                                    </telerik:GridBoundColumn>
                                                </Columns>
                                            </MasterTableView>
                                        </telerik:RadGrid>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="Exp_CargoRBColumn">
                                    <ItemTemplate>
                                        <telerik:RadButton ID="Exp_CargoRB" runat="server" Text="+/-" AutoPostBack="true"
                                            CommandName="Exp_CargoRB" OnClientClicked="onExp_CargoRBClicked">
                                        </telerik:RadButton>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="RegionsExpTemplateCol" HeaderText="4. Regions">
                                    <ItemTemplate>
                                        <telerik:RadGrid ID="RegionsExpRG" runat="server" AutoGenerateColumns="False" CellSpacing="0"
                                            GridLines="None" ShowHeader="False" CssClass="RemoveBorders1" Skin="Default">
                                            <ClientSettings EnableAlternatingItems="false">
                                            </ClientSettings>
                                            <MasterTableView ClientDataKeyNames="PartyExperienceID,HistoryID" DataKeyNames="PartyExperienceID,HistoryID">
                                                <NoRecordsTemplate>
                                                    <div>
                                                    </div>
                                                </NoRecordsTemplate>
                                                <Columns>
                                                    <telerik:GridBoundColumn DataField="ItemImage" UniqueName="ItemImage">
                                                        <HeaderStyle Width="30px" />
                                                    </telerik:GridBoundColumn>
                                                    <telerik:GridBoundColumn DataField="ItemName_Perc" UniqueName="ItemName_Perc">
                                                        <HeaderStyle Width="135px" />
                                                    </telerik:GridBoundColumn>
                                                </Columns>
                                            </MasterTableView>
                                        </telerik:RadGrid>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="Exp_RegionsRBColumn">
                                    <ItemTemplate>
                                        <telerik:RadButton ID="Exp_RegionsRB" runat="server" Text="+/-" AutoPostBack="true"
                                            CommandName="Exp_RegionsRB" OnClientClicked="onExp_RegionsRBClicked">
                                        </telerik:RadButton>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                            </Columns>
                            <PagerStyle PageSizeControlType="RadComboBox" />
                        </MasterTableView>
                        <PagerStyle PageSizeControlType="RadComboBox" />
                    </telerik:RadGrid>
                    <asp:SqlDataSource ID="ExpDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                        SelectCommand="SELECT * FROM [v_HistoryForExp] WHERE @ExpRun = 'Yes' AND [PartyID] = @HistPartyID AND EmployerID IS NOT NULL ORDER BY dbo.f_CalDate(StartMonthID) Desc">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="HistPartyID" PropertyName="Text"
                                Type="Int32" />
                            <asp:ControlParameter ControlID="HiddenTB_ExpRun" Name="ExpRun" PropertyName="Text"
                                Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </telerik:RadPane>
            </telerik:RadSplitter>
        </div>
        <div id="IncidentsDiv" style="display: none;">
            <telerik:RadSplitter ID="IncidentsRS" runat="server" Height="100%" Width="100%" Orientation="Vertical"
                Skin="BlackMetroTouch">
                <telerik:RadPane ID="IncidentsTreeRP" runat="server" Width="300" MinWidth="150" MaxWidth="450">
                    <telerik:RadTreeView ID="IncidentsRTV" runat="server" DataFieldID="TreeID" DataFieldParentID="TreeParentID"
                        DataSourceID="IncidentsDS" DataTextField="FolderOnly" DataValueField="TreeID"
                        EnableDragAndDrop="true" OnNodeDataBound="NodeDataBound" OnClientNodeDragging="onNodeDragging"
                        OnClientNodeDropping="onNodeDropping" OnClientNodeDropped="onNodeDropped" OnClientNodeClicked="onNodeClicked"
                        OnNodeDrop="IncidentsRTV_HandleDrop" MultipleSelect="true" EnableDragAndDropBetweenNodes="False"
                        Skin="MetroTouch">
                        <NodeTemplate>
                            <%# Eval("ItemHTML")%>
                        </NodeTemplate>
                    </telerik:RadTreeView>
                    <asp:SqlDataSource ID="IncidentsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                        SelectCommand="usp_TRU_Incidents" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                </telerik:RadPane>
                <telerik:RadSplitBar ID="RadSplitBar1" runat="server" CollapseMode="Forward" />
                <telerik:RadPane ID="IncidentsRP" runat="server">
                    <br />
                    <br />
                    <center>
                        <asp:Image ID="DropIncidentImage" runat="server" Width="225" Length="77"></asp:Image>
                    </center>
                    <br />
                    <div align="right">
                        <table>
                            <tbody>
                                <tr>
                                    <td width="475px" style="font-size: 16px; text-align: right; color: Black; vertical-align: middle;
                                        padding-top: 12px;">
                                        <asp:Label ID="IncidentUnlockedLbl" runat="server" Text="Click to LOCK All >>>" Style=""></asp:Label>
                                        <asp:Label ID="IncidentLockedLbl" runat="server" Text="Click to UNLOCK All >>>" Style="display: none;"></asp:Label>
                                    </td>
                                    <td>
                                        <telerik:RadButton ID="IncidentLockRB" runat="server" ButtonType="ToggleButton" ToggleType="CustomToggle"
                                            AutoPostBack="true" Height="35px" Width="35px" TabIndex="30" OnClientClicked="onIncidentLockRB_Clicked"
                                            OnClientLoad="onIncidentLockRB_Load">
                                            <ToggleStates>
                                                <telerik:RadButtonToggleState ImageUrl="/Images/Custom/un_lock_blk_large.png" HoveredImageUrl="/Images/Custom/un_lock_glow_blk_large.png"
                                                    Text="" Selected="true" Value="False"></telerik:RadButtonToggleState>
                                                <telerik:RadButtonToggleState ImageUrl="/Images/Custom/lock_blk_large.png" Text=""
                                                    HoveredImageUrl="/Images/Custom/lock_glow_blk_large.png" Value="True"></telerik:RadButtonToggleState>
                                            </ToggleStates>
                                        </telerik:RadButton>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                        <br />
                    </div>
                    <table style="width: 100%">
                        <tbody>
                            <tr>
                                <td>
                                    &nbsp;
                                </td>
                                <td class="header_cust">
                                    1. Accidents
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                                <td class="header_cust">
                                    2. Tickets / Legal / Other
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                                <td class="header_cust">
                                    3. Honors / Awards
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                </td>
                                <td style="width: 32%; vertical-align: top;">
                                    <telerik:RadGrid ID="AccidentsRadGrid" runat="server" AutoGenerateColumns="False"
                                        CellSpacing="0" DataSourceID="AccidentsGridDS" GridLines="None" ShowHeader="False"
                                        CssClass="RemoveBorders">
                                        <ClientSettings EnableRowHoverStyle="True">
                                            <ClientEvents OnRowMouseOver="onIncidentsMouseOver" />
                                            <ClientEvents OnRowClick="onIncidentsRowClick" />
                                        </ClientSettings>
                                        <MasterTableView ClientDataKeyNames="IncidentID,IncidentCategoryID,LockIncident"
                                            DataKeyNames="IncidentID,IncidentCategoryID,LockIncident" DataSourceID="AccidentsGridDS">
                                            <Columns>
                                                <telerik:GridBinaryImageColumn DataField="IncidentImage" UniqueName="IncidentImage">
                                                </telerik:GridBinaryImageColumn>
                                                <telerik:GridBoundColumn DataField="IncidentHTML" UniqueName="IncidentHTML">
                                                    <HeaderStyle Width="150px" />
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="DetailsHTML" UniqueName="DetailsHTML">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridTemplateColumn HeaderText="Lock" UniqueName="LockDel_TemplateColumn">
                                                    <ItemTemplate>
                                                        <telerik:RadButton ID="LockIncidentRB" runat="server" ButtonType="ToggleButton" ToggleType="CustomToggle"
                                                            AutoPostBack="false" OnClientClicked="onLockIncidentRBClicked" Height="20px"
                                                            Width="20px" TabIndex="30">
                                                            <ToggleStates>
                                                                <telerik:RadButtonToggleState ImageUrl="/Images/Custom/un_lock_blk.png" HoveredImageUrl="/Images/Custom/un_lock_glow_blk.png"
                                                                    Text="" Selected="true" Value="False"></telerik:RadButtonToggleState>
                                                                <telerik:RadButtonToggleState ImageUrl="/Images/Custom/lock_blk.png" Text="" HoveredImageUrl="/Images/Custom/lock_glow_blk.png"
                                                                    Value="True"></telerik:RadButtonToggleState>
                                                            </ToggleStates>
                                                        </telerik:RadButton>
                                                        <br />
                                                        <asp:ImageButton ID="IncidentsDelIB" runat="server" ImageUrl="/Images/Custom/XOut_Small.png" />
                                                    </ItemTemplate>
                                                </telerik:GridTemplateColumn>
                                            </Columns>
                                        </MasterTableView>
                                    </telerik:RadGrid>
                                    <asp:SqlDataSource ID="AccidentsGridDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                        SelectCommand="usp_IncidentsAccidents" SelectCommandType="StoredProcedure">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="AccidentsPartyID" PropertyName="Text"
                                                Type="Int32" />
                                            <asp:Parameter DefaultValue="823" Name="AccidentsGrandID" Type="Int32" />
                                            <asp:ControlParameter ControlID="HiddenTB_IncidentsRun" Name="AccidentsRun" PropertyName="Text"
                                                Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                                <td style="width: 32%; vertical-align: top;">
                                    <telerik:RadGrid ID="IncidentsRadGrid" runat="server" AutoGenerateColumns="False"
                                        CellSpacing="0" DataSourceID="IncidentsGridDS" GridLines="None" ShowHeader="False"
                                        CssClass="RemoveBorders">
                                        <ClientSettings EnableRowHoverStyle="True">
                                            <ClientEvents OnRowMouseOver="onIncidentsMouseOver" />
                                            <ClientEvents OnRowClick="onIncidentsRowClick" />
                                        </ClientSettings>
                                        <MasterTableView ClientDataKeyNames="IncidentID,IncidentCategoryID,LockIncident"
                                            DataKeyNames="IncidentID,IncidentCategoryID,LockIncident" DataSourceID="IncidentsGridDS">
                                            <Columns>
                                                <telerik:GridBinaryImageColumn DataField="IncidentImage" UniqueName="IncidentImage">
                                                </telerik:GridBinaryImageColumn>
                                                <telerik:GridBoundColumn DataField="IncidentHTML" UniqueName="IncidentHTML">
                                                    <HeaderStyle Width="150px" />
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="DetailsHTML" UniqueName="DetailsHTML">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridTemplateColumn HeaderText="Lock" UniqueName="LockDel_TemplateColumn">
                                                    <ItemTemplate>
                                                        <telerik:RadButton ID="LockIncidentRB" runat="server" ButtonType="ToggleButton" ToggleType="CustomToggle"
                                                            AutoPostBack="false" OnClientClicked="onLockIncidentRBClicked" Height="20px"
                                                            Width="20px" TabIndex="30">
                                                            <ToggleStates>
                                                                <telerik:RadButtonToggleState ImageUrl="/Images/Custom/un_lock_blk.png" HoveredImageUrl="/Images/Custom/un_lock_glow_blk.png"
                                                                    Text="" Selected="true" Value="False"></telerik:RadButtonToggleState>
                                                                <telerik:RadButtonToggleState ImageUrl="/Images/Custom/lock_blk.png" Text="" HoveredImageUrl="/Images/Custom/lock_glow_blk.png"
                                                                    Value="True"></telerik:RadButtonToggleState>
                                                            </ToggleStates>
                                                        </telerik:RadButton>
                                                        <br />
                                                        <asp:ImageButton ID="IncidentsDelIB" runat="server" ImageUrl="/Images/Custom/XOut_Small.png" />
                                                    </ItemTemplate>
                                                </telerik:GridTemplateColumn>
                                            </Columns>
                                        </MasterTableView>
                                    </telerik:RadGrid><asp:SqlDataSource ID="IncidentsGridDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                        SelectCommand="usp_IncidentsEvents" SelectCommandType="StoredProcedure">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="EventsPartyID" PropertyName="Text"
                                                Type="Int32" />
                                            <asp:ControlParameter ControlID="HiddenTB_IncidentsRun" Name="EventsRun" PropertyName="Text"
                                                Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                                <td style="width: 32%; vertical-align: top;">
                                    <telerik:RadGrid ID="HonorsAwardsRadGrid" runat="server" AutoGenerateColumns="False"
                                        CellSpacing="0" DataSourceID="HonorsAwardsDS" GridLines="None" ShowHeader="False"
                                        CssClass="RemoveBorders">
                                        <ClientSettings EnableRowHoverStyle="True">
                                            <ClientEvents OnRowMouseOver="onIncidentsMouseOver" />
                                            <ClientEvents OnRowClick="onIncidentsRowClick" />
                                        </ClientSettings>
                                        <MasterTableView ClientDataKeyNames="IncidentID,IncidentCategoryID,LockIncident"
                                            DataKeyNames="IncidentID,IncidentCategoryID,LockIncident" DataSourceID="HonorsAwardsDS">
                                            <Columns>
                                                <telerik:GridBinaryImageColumn DataField="IncidentImage" UniqueName="IncidentImage">
                                                </telerik:GridBinaryImageColumn>
                                                <telerik:GridBoundColumn DataField="IncidentHTML" UniqueName="IncidentHTML">
                                                    <HeaderStyle Width="150px" />
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="DetailsHTML" UniqueName="DetailsHTML">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridTemplateColumn HeaderText="Lock" UniqueName="LockDel_TemplateColumn">
                                                    <ItemTemplate>
                                                        <telerik:RadButton ID="LockIncidentRB" runat="server" ButtonType="ToggleButton" ToggleType="CustomToggle"
                                                            AutoPostBack="false" OnClientClicked="onLockIncidentRBClicked" Height="20px"
                                                            Width="20px" TabIndex="30">
                                                            <ToggleStates>
                                                                <telerik:RadButtonToggleState ImageUrl="/Images/Custom/un_lock_blk.png" HoveredImageUrl="/Images/Custom/un_lock_glow_blk.png"
                                                                    Text="" Selected="true" Value="False"></telerik:RadButtonToggleState>
                                                                <telerik:RadButtonToggleState ImageUrl="/Images/Custom/lock_blk.png" Text="" HoveredImageUrl="/Images/Custom/lock_glow_blk.png"
                                                                    Value="True"></telerik:RadButtonToggleState>
                                                            </ToggleStates>
                                                        </telerik:RadButton>
                                                        <br />
                                                        <asp:ImageButton ID="IncidentsDelIB" runat="server" ImageUrl="/Images/Custom/XOut_Small.png" />
                                                    </ItemTemplate>
                                                </telerik:GridTemplateColumn>
                                            </Columns>
                                        </MasterTableView>
                                    </telerik:RadGrid>
                                    <asp:SqlDataSource ID="HonorsAwardsDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                        SelectCommand="usp_IncidentsHonors" SelectCommandType="StoredProcedure">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="HonorsPartyID" PropertyName="Text"
                                                Type="Int32" />
                                            <asp:Parameter DefaultValue="747" Name="HonorsGrandID" Type="Int32" />
                                            <asp:ControlParameter ControlID="HiddenTB_IncidentsRun" Name="HonorsRun" PropertyName="Text"
                                                Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </telerik:RadPane>
            </telerik:RadSplitter>
        </div>
        <div id="DocsDiv" style="display: none;">
        </div>
        <div id="EquipDiv" style="display: none;">
        </div>
        <div id="HiddenDiv" style="display: none;">
            PartyID:
            <asp:TextBox ID="HiddenTB_PartyID" runat="server"></asp:TextBox><br />
            MeID:
            <asp:TextBox ID="HiddenTB_MeID" runat="server"></asp:TextBox><br />
            DriverID:
            <asp:TextBox ID="HiddenTB_DriverID" runat="server"></asp:TextBox><br />
            AddrID:
            <asp:TextBox ID="HiddenTB_AddrID" runat="server" Text="0"></asp:TextBox><br />
            AddrZipID:
            <asp:TextBox ID="HiddenTB_AddrZipID" runat="server" Text="0"></asp:TextBox><br />
            PrefParentID:
            <asp:TextBox ID="HiddenTB_PrefParentID" runat="server" Text="0"></asp:TextBox><br />
            MouseOverID:
            <asp:TextBox ID="HiddenTB_MouseOverID" runat="server"></asp:TextBox><br />
            HistoryID:
            <asp:TextBox ID="HiddenTB_HistoryID" runat="server" Text="0"></asp:TextBox><br />
            SearchPartyID:
            <asp:TextBox ID="HiddenTB_SearchPartyID" runat="server" Text="0"></asp:TextBox><br />
            SearchFree:
            <asp:TextBox ID="HiddenTB_SearchFree" runat="server" Text="0"></asp:TextBox><br />
            SearchCity:
            <asp:TextBox ID="HiddenTB_SearchCityID" runat="server" Text="0"></asp:TextBox><br />
            SearchRadius:
            <asp:TextBox ID="HiddenTB_SearchRadius" runat="server" Text="5"></asp:TextBox><br />
            CarrierID:
            <asp:TextBox ID="HiddenTB_CarrierID" runat="server" Text="0"></asp:TextBox><br />
            CarrierAddr:
            <asp:TextBox ID="HiddenTB_CarrierAddr" runat="server" Text="0"></asp:TextBox><br />
            CarrierZipID:
            <asp:TextBox ID="HiddenTB_CarrierZipID" runat="server" Text="0"></asp:TextBox><br />
            CarrierCitySTZip:
            <asp:TextBox ID="HiddenTB_CarrierCitySTZip" runat="server" Text="0"></asp:TextBox><br />
            CarrierCountryID:
            <asp:TextBox ID="HiddenTB_CarrierCountryID" runat="server" Text="0"></asp:TextBox><br />
            CarrierCountry:
            <asp:TextBox ID="HiddenTB_CarrierCountry" runat="server" Text="0"></asp:TextBox><br />
            CarrierDataStatus:
            <asp:TextBox ID="HiddenTB_CarrierDataStatus" runat="server" Text="0"></asp:TextBox><br />
            CarrierLat:
            <asp:TextBox ID="HiddenTB_CarrierLat" runat="server" Text="0"></asp:TextBox><br />
            CarrierLong:
            <asp:TextBox ID="HiddenTB_CarrierLong" runat="server" Text="0"></asp:TextBox>
            CarrierAdmin:
            <asp:TextBox ID="HiddenTB_CarrierAdminYesNo" runat="server" Text="0"></asp:TextBox>
            WindowWidth:
            <asp:TextBox ID="HiddenTB_WindowWidth" runat="server" Text="0"></asp:TextBox>
            HistoryHoverID:
            <asp:TextBox ID="HiddenTB_HistoryHoverID" runat="server" Text="0"></asp:TextBox><br />
            HistoryID_ForExpRTT:
            <asp:TextBox ID="HiddenTB_HistoryID_ForExpRTT" runat="server" Text="0"></asp:TextBox><br />
            ExperienceID:
            <asp:TextBox ID="HiddenTB_ExperienceID" runat="server" Text="0"></asp:TextBox><br />
            PartyExperienceID:
            <asp:TextBox ID="HiddenTB_PartyExperienceID" runat="server" Text="0"></asp:TextBox><br />
            Slider:
            <asp:TextBox ID="HiddenTB_Slider" runat="server" Text="0"></asp:TextBox><br />
            IncidentID:
            <asp:TextBox ID="HiddenTB_IncidentID" runat="server" Text="0"></asp:TextBox><br />
            InfoRun:
            <asp:TextBox ID="HiddenTB_InfoRun" runat="server" Text="No"></asp:TextBox><br />
            HistRun:
            <asp:TextBox ID="HiddenTB_HistRun" runat="server" Text="No"></asp:TextBox><br />
            ExpRun:
            <asp:TextBox ID="HiddenTB_ExpRun" runat="server" Text="No"></asp:TextBox><br />
            IncidentsRun:
            <asp:TextBox ID="HiddenTB_IncidentsRun" runat="server" Text="No"></asp:TextBox><br />
            Tab:
            <asp:TextBox ID="HiddenTB_Tab" runat="server" Text="No"></asp:TextBox><br />
        </div>
    </div>
    </form>
</body>
</html>
