<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="UserConfig.aspx.vb"
    Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.UserConfig" %>

<%@ Register TagPrefix="FASTPORT" Namespace="FASTPORT.UI.Controls.UserConfig" Assembly="FASTPORT" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<%@ Register TagPrefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<asp:Content ID="PageSection" ContentPlaceHolderID="PageContent" runat="server">
    <a id="StartOfPageContent"></a>
    <style type="text/css">
        .RadListBox
        {
            margin: 0 auto !important;
        }
    </style>
    <telerik:RadScriptBlock ID="RadScriptBlock1" runat="server">
        <script type="text/javascript">

        function SendCallBack(arg, myAction) {

                    try {
                        switch (myAction) {
                        case "onPersonClick":
                            { <%= Page.ClientScript.GetCallbackEventReference(Me, "arg", "null", "null") %>
                                break;
                            }               
                        }
                    } catch (e) {}
                }

        function onPaymentMethodDeleteClick(index) {

            var grid = $find("<%=PaymentMethodRadGrid.ClientID %>");
            var MasterTable = grid.get_masterTableView();
            var row = MasterTable.get_dataItems()[index];
            var paymentmethodid = row.getDataKeyValue("PaymentMethodID");
            confirmCall("deletePayment", paymentmethodid, "Payment method")

        }

        function onPaymentMethodRowClick(row, args)  
           {  
             var e = args.get_domEvent();     
             var targetElement = e.srcElement || e.target;                 
             if(targetElement.tagName.toLowerCase() != "input" && (!targetElement.type || targetElement.type.toLowerCase() != "imagebutton"))// && currentClickEvent)   
                 {    
                     __doPostBack('<%=PaymentMethodRadGrid.UniqueID %>', args);   
                       
                 }   
             else   
                 {   
                      alert("Clicked on imagebutton");                         
                 }   
                
            }  

        function OnClientItemCheckingHandler(sender, eventArgs) {
	        var item = eventArgs.get_item();
            SendCallBack("onPersonClick," + item.get_value(), "onPersonClick");
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
            if (callType == "deletePayment") {

                confirmMess = "Are you certain that you wish to <span style='color: #ff0000;'>permanently</span> delete this payment method?";
                confirmTitle = "Delete " & callName & " ?"
                launchRadConfirm(confirmMess, confirmTitle);

            }

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

        function CallRadWindow(myID, myAction) {

            cancelTips = false;

            switch (myAction) {
            case "addCreditCard":
                {
                    SendCallBack("addCreditCard," + myID, "OpenRadWindow")
                    break;
                }
            case "addBankAccount":
                {
                    SendCallBack("addBankAccount," + myID, "OpenRadWindow")
                    break;
                }
            }
        }

        //Info:  Function that the RadConfirm calls back to process the users response.

        function confirmCallBackFn(arg) {

            //Step 3:  Config different callbacks if required.  If you have only 2 parameters, these will do.
            if (arg == true) {

                if (confirmType == "deletePayment") {

                    var sendArg = confirmType + "," + confirmID; <%= Page.ClientScript.GetCallbackEventReference(Me, "sendArg", "FinishAlert", "null") %>

                } 
            }
        }

        //Info:  Needed to get the parent window when calling alerts from a child RadWindow.

        function GetRadWindow() {
            var oWindow = null;
            if (window.radWindow) oWindow = window.radWindow;
            else if (window.frameElement && window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
            return oWindow;
        }

        function showAddCreditCardRadWindow()
               {
                    var wnd = $find("<%=AddCreditCardRW.ClientID %>");
                    wnd.show();
               }

        function showAddBankAccountRadWindow()
            {
                var wnd = $find("<%=AddBankAccountRW.ClientID %>");
                wnd.show();
            }

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

                if (confirmType == "deletePayment") {

                    messTitle = "Delete Failed"
                    mess = "<span style='color: #ff0000;'>WARNING:</span> The system failed to delete this item. Usually, this is because this payment method is referenced in other places in FASTPORT, and thus, it cannot be deleted.  The technical details for this error are as follows: " + arg

                } 

                launchRadAlert(mess, messTitle)

            } else {
                if (confirmType == "deletePayment") {

                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("rebindPaymentMethod");

                } 
            }

        }

        function onRTThide(sender, args) {
                sender.set_targetControlID("");
            }

        </script>
    </telerik:RadScriptBlock>
    <telerik:RadToolTip runat="server" ID="UserConfigRTT" HideEvent="ManualClose" RelativeTo="Element"
        Position="MiddleRight" Width="375px" Skin="BlackMetroTouch" OnClientHide="onRTThide">
    </telerik:RadToolTip>
    <telerik:RadAjaxManager ID="RadAjaxManager1" EnablePageHeadUpdate="false" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadAjaxManager1" />
                    <telerik:AjaxUpdatedControl ControlID="PaymentMethodRadGrid" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenPanel" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="PaymentMethodRadGrid">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PaymentMethodRadGrid" />
                    <telerik:AjaxUpdatedControl ControlID="CreditCardPanel" />
                    <telerik:AjaxUpdatedControl ControlID="BankAccountPanel" />
                    <telerik:AjaxUpdatedControl ControlID="CompanyPanel" />
                    <telerik:AjaxUpdatedControl ControlID="PeoplePanel" />
                    <telerik:AjaxUpdatedControl ControlID="PeopleRLB" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenPanel" />
                    <telerik:AjaxUpdatedControl ControlID="UserConfigRTT" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="CompanyRG">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="CompanyRG" />
                    <telerik:AjaxUpdatedControl ControlID="PeoplePanel" />
                    <telerik:AjaxUpdatedControl ControlID="PeopleRLB" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenPanel" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="False"
        Modal="True" ShowContentDuringLoad="False" VisibleStatusbar="False" Skin="Black"
        Style="z-index: 10000;">
    </telerik:RadWindowManager>
    <telerik:RadWindow ID="AddCreditCardRW" runat="server" Width="460px" Height="360px"
        Modal="true" Skin="Black" VisibleStatusbar="false" VisibleTitlebar="false" ShowContentDuringLoad="false"
        Style="z-index: 10000;">
        <ContentTemplate>
            <table class="dv" cellpadding="0" cellspacing="0" border="0">
                <tr>
                    <td>
                        <asp:Panel ID="AddCreditCardPanel" runat="server">
                            <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                <tr>
                                    <td>
                                        <asp:Panel ID="Panel4" runat="server">
                                            <table cellpadding="0" cellspacing="0" border="0">
                                                <tr>
                                                    <td class="fls">
                                                        <asp:Literal runat="server" ID="AddCreditCardTypeLiteral" Text="Credit Card Type">	</asp:Literal>
                                                    </td>
                                                    <td class="dfv">
                                                        <asp:SqlDataSource ID="AddCreditCardTypeDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                            SelectCommand="SELECT * FROM [List] WHERE ListType = 'Credit Card'"></asp:SqlDataSource>
                                                        <telerik:RadDropDownList ID="AddCreditCardTypeRDDL" runat="server" DataTextField="ListName"
                                                            DataValueField="ListID" DataSourceID="AddCreditCardTypeDS">
                                                        </telerik:RadDropDownList>
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="fls">
                                                        <asp:Literal runat="server" ID="AddCreditCardNumberLiteral" Text="Credit Card #">	</asp:Literal>
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadTextBox ID="AddCreditCardNumberRTB" runat="server" Width="167px" TabIndex="1"
                                                            class="flSecurity">
                                                        </telerik:RadTextBox>
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="fls">
                                                        <asp:Literal runat="server" ID="AddNameOnCardLiteral" Text="Name On Card">	</asp:Literal>
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadTextBox ID="AddNameOnCardRTB" runat="server" Width="167px" TabIndex="1"
                                                            class="flSecurity">
                                                        </telerik:RadTextBox>
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="fls">
                                                        <asp:Literal runat="server" ID="AddStartDateLiteral" Text="Start Date">	</asp:Literal>
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadMaskedTextBox ID="AddStartDateRTB" Mask="##/##" runat="server" Width="50px"
                                                            TabIndex="1" class="flSecurity">
                                                        </telerik:RadMaskedTextBox>
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="fls">
                                                        <asp:Literal runat="server" ID="AddEndDateLiteral" Text="End Date">	</asp:Literal>
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadMaskedTextBox ID="AddEndDateRTB" Mask="##/##" runat="server" Width="50px"
                                                            TabIndex="1" class="flSecurity">
                                                        </telerik:RadMaskedTextBox>
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="fls">
                                                        <asp:Literal runat="server" ID="AddCVVLiteral" Text="CCV">	</asp:Literal>
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadTextBox ID="AddCVVRTB" runat="server" Width="50px" TabIndex="1" class="flSecurity">
                                                        </telerik:RadTextBox>
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="fls">
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadButton ID="AddPreferredRB" runat="server" ToggleType="CheckBox" ButtonType="StandardButton"
                                                            AutoPostBack="false">
                                                            <ToggleStates>
                                                                <telerik:RadButtonToggleState Text="Preferred" PrimaryIconCssClass="rbToggleCheckboxChecked">
                                                                </telerik:RadButtonToggleState>
                                                                <telerik:RadButtonToggleState Text="Not preferred" PrimaryIconCssClass="rbToggleCheckbox">
                                                                </telerik:RadButtonToggleState>
                                                            </ToggleStates>
                                                        </telerik:RadButton>
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="dfv">
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadButton ID="SaveNewCreditCardRB" runat="server" Text="Save" AutoPostBack="true"
                                                            ToolTip="Click to save this credit card.">
                                                        </telerik:RadButton>
                                                        <telerik:RadButton ID="CancelNewCreditCardRB" runat="server" Text="Cancel" AutoPostBack="true"
                                                            ToolTip="Click to cancel.">
                                                        </telerik:RadButton>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </telerik:RadWindow>
    <telerik:RadWindow ID="AddBankAccountRW" runat="server" Width="560px" Height="360px"
        Modal="true" Skin="Black" VisibleStatusbar="false" VisibleTitlebar="false" ShowContentDuringLoad="false"
        Style="z-index: 10000;">
        <ContentTemplate>
            <table class="dv" cellpadding="0" cellspacing="0" border="0">
                <tr>
                    <td>
                        <asp:Panel ID="Panel2" runat="server">
                            <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                <tr>
                                    <td>
                                        <asp:Panel ID="Panel6" runat="server">
                                            <table cellpadding="0" cellspacing="0" border="0">
                                                <tr>
                                                    <td class="fls">
                                                        <asp:Literal runat="server" ID="AddBankAccountNumberLiteral" Text="Bank Account Number">	</asp:Literal>
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadTextBox ID="AddBankAccountNumberRTB" runat="server" Width="167px" TabIndex="1"
                                                            class="flSecurity">
                                                        </telerik:RadTextBox>
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="fls">
                                                        <asp:Literal runat="server" ID="AddBankAccountSortCodeLiteral" Text="Sort Code">	</asp:Literal>
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadTextBox ID="AddBankAccountSortCodeRTB" runat="server" Width="167px" TabIndex="1"
                                                            class="flSecurity">
                                                        </telerik:RadTextBox>
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="fls">
                                                        <asp:Literal runat="server" ID="AddBankAccountNameLiteral" Text="Account Name">	</asp:Literal>
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadTextBox ID="AddBankAccountNameRTB" runat="server" Width="167px" TabIndex="1"
                                                            class="flSecurity">
                                                        </telerik:RadTextBox>
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="fls">
                                                        <asp:Literal runat="server" ID="AddBankAccountPaymentReferenceLiteral" Text="Payment Reference">	</asp:Literal>
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadTextBox ID="AddBankAccountPaymentReferenceRTB" runat="server" Width="167px"
                                                            TabIndex="1" class="flSecurity">
                                                        </telerik:RadTextBox>
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="fls">
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadButton ID="AddPreferredBankAccountRB" runat="server" ToggleType="CheckBox"
                                                            ButtonType="StandardButton" AutoPostBack="false">
                                                            <ToggleStates>
                                                                <telerik:RadButtonToggleState Text="Preferred" PrimaryIconCssClass="rbToggleCheckboxChecked">
                                                                </telerik:RadButtonToggleState>
                                                                <telerik:RadButtonToggleState Text="Not preferred" PrimaryIconCssClass="rbToggleCheckbox">
                                                                </telerik:RadButtonToggleState>
                                                            </ToggleStates>
                                                        </telerik:RadButton>
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                    <td class="dfv">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="dfv">
                                                    </td>
                                                    <td class="dfv">
                                                        <telerik:RadButton ID="SaveNewBankAccountRB" runat="server" Text="Save" AutoPostBack="true"
                                                            ToolTip="Click to save this bank account.">
                                                        </telerik:RadButton>
                                                        <telerik:RadButton ID="CancelNewBankAccountRB" runat="server" Text="Cancel" AutoPostBack="true"
                                                            ToolTip="Click to cancel.">
                                                        </telerik:RadButton>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </telerik:RadWindow>
    <style type="text/css">
        .RadWindow_BlackMetroTouch .rwTable .rwTitlebarControls em
        {
            font-size: 18px;
            padding: 8px 0 0 3px;
        }
        
        .RadWindow, .RadWindow_BlackMetroTouch, .rwNormalWindow, .rwTransparentWindow, .rwNoTitleBar
        {
            height: auto;
        }
    </style>
    <table cellpadding="0" cellspacing="0" border="0" style="width: 100%">
        <tr>
            <td id="UserCell" rowspan="2" valign="top">
                <FASTPORT:PartyRecordControl runat="server" ID="PartyRecordControl">
                    <table class="dv" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                            <td>
                                <asp:Panel ID="PartyRecordControlCollapsibleRegion" runat="server">
                                    <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                        <tr>
                                            <td>
                                                <asp:Panel ID="PartyRecordControlPanel" runat="server">
                                                    <table cellpadding="0" cellspacing="0" border="0">
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Literal runat="server" ID="PasswordLabel" Text="Password">	</asp:Literal>
                                                            </td>
                                                            <td class="dfv">
                                                                <span style="white-space: nowrap;">
                                                                    <asp:TextBox runat="server" ID="Password" Columns="40" MaxLength="50" CssClass="field_input"
                                                                        TextMode="Password" Visible="False"></asp:TextBox>&nbsp;
                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="PasswordTextBoxMaxLengthValidator"
                                                                        ControlToValidate="Password" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Password&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                <telerik:RadTextBox ID="PasswordRTB" runat="server" Width="167px" TabIndex="1" class="flSecurity"
                                                                    TextMode="Password">
                                                                </telerik:RadTextBox>
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                &nbsp;
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Literal runat="server" ID="NameLabel" Text="Name">	</asp:Literal>
                                                            </td>
                                                            <td class="dfv">
                                                                <span style="white-space: nowrap;">
                                                                    <asp:TextBox runat="server" ID="Name" MaxLength="1000" Columns="120" CssClass="field_input"
                                                                        Rows="6" TextMode="MultiLine" Visible="False"></asp:TextBox>&nbsp;
                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="NameTextBoxMaxLengthValidator"
                                                                        ControlToValidate="Name" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                <telerik:RadTextBox ID="NameRTB" runat="server" Width="167px" TabIndex="2">
                                                                </telerik:RadTextBox>
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Literal runat="server" ID="EmailLabel" Text="Email">	</asp:Literal>
                                                            </td>
                                                            <td class="dfv">
                                                                <span style="white-space: nowrap;">
                                                                    <asp:TextBox runat="server" ID="Email" Columns="40" MaxLength="100" CssClass="field_input"
                                                                        Visible="False"></asp:TextBox>&nbsp;
                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="EmailTextBoxMaxLengthValidator"
                                                                        ControlToValidate="Email" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Email&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                <telerik:RadTextBox ID="EmailRTB" runat="server" Width="167px" TabIndex="1">
                                                                </telerik:RadTextBox>
                                                                <asp:RegularExpressionValidator ID="emailValidator" runat="server" Display="Dynamic"
                                                                    ErrorMessage="Please enter valid e-mail." ValidationExpression="^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$"
                                                                    ControlToValidate="EmailRTB">
                                                                </asp:RegularExpressionValidator>
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Literal runat="server" ID="MobileLabel" Text="Mobile">	</asp:Literal>
                                                            </td>
                                                            <td class="dfv">
                                                                <span style="white-space: nowrap;">
                                                                    <asp:TextBox runat="server" ID="Mobile" Columns="40" MaxLength="50" CssClass="field_input"
                                                                        Visible="False"></asp:TextBox>&nbsp;
                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="MobileTextBoxMaxLengthValidator"
                                                                        ControlToValidate="Mobile" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Mobile&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                <telerik:RadMaskedTextBox ID="MobileRTB" runat="server" Mask="###-###-####" Width="167px"
                                                                    TabIndex="6">
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Literal runat="server" ID="DirectDialLabel" Text="Direct Dial">	</asp:Literal>
                                                            </td>
                                                            <td class="dfv">
                                                                <span style="white-space: nowrap;">
                                                                    <asp:TextBox runat="server" ID="DirectDial" Columns="40" MaxLength="50" CssClass="field_input"
                                                                        Visible="False"></asp:TextBox>&nbsp;
                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="DirectDialTextBoxMaxLengthValidator"
                                                                        ControlToValidate="DirectDial" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Direct Dial&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                <telerik:RadMaskedTextBox ID="DirectDialRTB" runat="server" Mask="###-###-#### #####"
                                                                    Width="167px" TabIndex="5">
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="fls">
                                                                <asp:Literal runat="server" ID="FaxLabel" Text="Fax">	</asp:Literal>
                                                            </td>
                                                            <td class="dfv">
                                                                <span style="white-space: nowrap;">
                                                                    <asp:TextBox runat="server" ID="Fax" Columns="40" MaxLength="50" CssClass="field_input"
                                                                        Visible="False"></asp:TextBox>&nbsp;
                                                                    <BaseClasses:TextBoxMaxLengthValidator runat="server" ID="FaxTextBoxMaxLengthValidator"
                                                                        ControlToValidate="Fax" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fax&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
                                                                <telerik:RadMaskedTextBox ID="FaxRTB" runat="server" Mask="###-###-####" Width="167px"
                                                                    TabIndex="8">
                                                                </telerik:RadMaskedTextBox>
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="dfv">
                                                            </td>
                                                            <td class="dfv">
                                                                <telerik:RadButton ID="SaveUserRB" runat="server" Text="Save" AutoPostBack="true"
                                                                    ToolTip="Click to save changes.">
                                                                </telerik:RadButton>
                                                                <telerik:RadButton ID="CancelUserRB" runat="server" Text="Cancel" AutoPostBack="true"
                                                                    ToolTip="Click to cancel.">
                                                                </telerik:RadButton>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </asp:Panel>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                    </table>
                </FASTPORT:PartyRecordControl>
            </td>
            <td>
                <table>
                    <tr>
                        <td class="dfv">
                            <telerik:RadButton ID="AddCreditCardRB" runat="server" Text="Add New Credit Card"
                                AutoPostBack="true" ToolTip="Click to add a new credit card.">
                            </telerik:RadButton>
                            <telerik:RadButton ID="AddBankAccountRB" runat="server" Text="Add New Bank Account"
                                AutoPostBack="true" ToolTip="Click to add a new bank account.">
                            </telerik:RadButton>
                        </td>
                    </tr>
                    <tr>
                        <td id="PaymentMethodGridCell" colspan="2">
                            <telerik:RadGrid ID="PaymentMethodRadGrid" runat="server" AutoGenerateColumns="False"
                                CellSpacing="0" DataSourceID="PaymentMethodDS" GridLines="None" ShowHeader="True"
                                CssClass="RemoveBorders" OnItemCommand="PaymentMethodRadGrid_ItemCommand">
                                <ClientSettings EnablePostBackOnRowClick="true" EnableRowHoverStyle="True">
                                </ClientSettings>
                                <MasterTableView ClientDataKeyNames="PaymentMethodID" DataKeyNames="PaymentMethodID, PaymentMethodType"
                                    DataSourceID="PaymentMethodDS" Name="PaymentMethodTable">
                                    <NoRecordsTemplate>
                                        <div style="padding: 25px;">
                                            No credit cards or bank accounts entered yet. Please click the "Add Payment Method"
                                            button above.
                                        </div>
                                    </NoRecordsTemplate>
                                    <Columns>
                                        <telerik:GridBoundColumn DataField="PaymentMethodHTML" HeaderStyle-Width="190px"
                                            HeaderText="Card / Account" UniqueName="PaymentMethodHTML">
                                            <HeaderStyle Width="190px" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="PreferredHTML" HeaderStyle-Width="190px" HeaderText="Preferred"
                                            UniqueName="PreferredHTML">
                                            <HeaderStyle Width="20px" />
                                        </telerik:GridBoundColumn>
                                        <telerik:GridTemplateColumn UniqueName="PaymentMethodDeleteCol">
                                            <ItemTemplate>
                                                <telerik:RadButton ID="PaymentMethodDeleteIB" CommandName="Delete" runat="server"
                                                    Width="20px" Height="20px" Style="vertical-align: top;" ToolTip="Remove">
                                                    <Image ImageUrl="/Images/Custom/XOut_Small.png" IsBackgroundImage="true" />
                                                </telerik:RadButton>
                                            </ItemTemplate>
                                        </telerik:GridTemplateColumn>
                                    </Columns>
                                    <PagerStyle PageSizeControlType="RadComboBox" />
                                </MasterTableView>
                                <PagerStyle PageSizeControlType="RadComboBox" />
                            </telerik:RadGrid>
                            <asp:SqlDataSource ID="PaymentMethodDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                SelectCommand="SELECT * FROM [v_PaymentMethod] WHERE [PartyID] = @PaymentMethodPartyID">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="PaymentMethodPartyID" PropertyName="Text"
                                        Type="Int32" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table class="dv" cellpadding="0" cellspacing="0" border="0">
                                <tr>
                                    <td>
                                        <asp:Panel ID="CreditCardPanel" runat="server">
                                            <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                                <tr>
                                                    <td>
                                                        <asp:Panel ID="Panel1" runat="server">
                                                            <table cellpadding="0" cellspacing="0" border="0">
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="CreditCardTypeLabel" Text="Credit Card Type">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <asp:SqlDataSource ID="CreditCardTypeDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                                            SelectCommand="SELECT * FROM [List] WHERE ListType = 'Credit Card'"></asp:SqlDataSource>
                                                                        <telerik:RadDropDownList ID="CreditCardTypeRDDL" runat="server" DataTextField="ListName"
                                                                            DataValueField="ListID" DataSourceID="CreditCardTypeDS">
                                                                        </telerik:RadDropDownList>
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="CreditCardNumberLabel" Text="Credit Card #">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <telerik:RadTextBox ID="CreditCardNumberRTB" runat="server" Width="167px" TabIndex="1"
                                                                            class="flSecurity">
                                                                        </telerik:RadTextBox>
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="CreditCardNameLabel" Text="Name On Card">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <telerik:RadTextBox ID="CreditCardNameRTB" runat="server" Width="167px" TabIndex="1"
                                                                            class="flSecurity">
                                                                        </telerik:RadTextBox>
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="StartDateLabel" Text="Start Date">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <telerik:RadMaskedTextBox ID="StartDateRTB" Mask="##/##" runat="server" Width="50px"
                                                                            TabIndex="1" class="flSecurity">
                                                                        </telerik:RadMaskedTextBox>
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="EndDateLabel" Text="End Date">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <telerik:RadMaskedTextBox ID="EndDateRTB" Mask="##/##" runat="server" Width="50px"
                                                                            TabIndex="1" class="flSecurity">
                                                                        </telerik:RadMaskedTextBox>
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="CVVLabel" Text="CCV">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <telerik:RadTextBox ID="CVVRTB" runat="server" Width="50px" TabIndex="1" class="flSecurity">
                                                                        </telerik:RadTextBox>
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <telerik:RadButton ID="PreferredCreditCardRB" runat="server" ToggleType="CheckBox"
                                                                            ButtonType="StandardButton" AutoPostBack="false">
                                                                            <ToggleStates>
                                                                                <telerik:RadButtonToggleState Text="Preferred" PrimaryIconCssClass="rbToggleCheckboxChecked">
                                                                                </telerik:RadButtonToggleState>
                                                                                <telerik:RadButtonToggleState Text="Not preferred" PrimaryIconCssClass="rbToggleCheckbox">
                                                                                </telerik:RadButtonToggleState>
                                                                            </ToggleStates>
                                                                        </telerik:RadButton>
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="dfv">
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <telerik:RadButton ID="SaveCreditCardRB" runat="server" Text="Save" AutoPostBack="true"
                                                                            ToolTip="Click to save this credit card.">
                                                                        </telerik:RadButton>
                                                                        <telerik:RadButton ID="CancelCreditCardRB" runat="server" Text="Cancel" AutoPostBack="true"
                                                                            ToolTip="Click to cancel.">
                                                                        </telerik:RadButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Panel ID="BankAccountPanel" runat="server">
                                            <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%">
                                                <tr>
                                                    <td>
                                                        <asp:Panel ID="Panel3" runat="server">
                                                            <table cellpadding="0" cellspacing="0" border="0">
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="BankAccountNumberLabel" Text="Bank Account Number">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <telerik:RadTextBox ID="BankAccountNumberRTB" runat="server" Width="167px" TabIndex="1"
                                                                            class="flSecurity">
                                                                        </telerik:RadTextBox>
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="BankSortCodeLabel" Text="Sort Code">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <telerik:RadTextBox ID="BankSortCodeRTB" runat="server" Width="167px" TabIndex="1"
                                                                            class="flSecurity">
                                                                        </telerik:RadTextBox>
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="BankAccountNameLabel" Text="Account Name">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <telerik:RadTextBox ID="BankAccountNameRTB" runat="server" Width="167px" TabIndex="1"
                                                                            class="flSecurity">
                                                                        </telerik:RadTextBox>
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                        <asp:Literal runat="server" ID="BankPaymentReferenceLabel" Text="Payment Reference">	</asp:Literal>
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <telerik:RadTextBox ID="BankPaymentReferenceRTB" runat="server" Width="167px" TabIndex="1"
                                                                            class="flSecurity">
                                                                        </telerik:RadTextBox>
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="fls">
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <telerik:RadButton ID="PreferredBankAccountRB" runat="server" ToggleType="CheckBox"
                                                                            ButtonType="StandardButton" AutoPostBack="false">
                                                                            <ToggleStates>
                                                                                <telerik:RadButtonToggleState Text="Preferred" PrimaryIconCssClass="rbToggleCheckboxChecked">
                                                                                </telerik:RadButtonToggleState>
                                                                                <telerik:RadButtonToggleState Text="Not preferred" PrimaryIconCssClass="rbToggleCheckbox">
                                                                                </telerik:RadButtonToggleState>
                                                                            </ToggleStates>
                                                                        </telerik:RadButton>
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                    <td class="dfv">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="dfv">
                                                                    </td>
                                                                    <td class="dfv">
                                                                        <telerik:RadButton ID="SaveBankAccountRB" runat="server" Text="Save" AutoPostBack="true"
                                                                            ToolTip="Click to save this bank account.">
                                                                        </telerik:RadButton>
                                                                        <telerik:RadButton ID="CancelBankAccountRB" runat="server" Text="Cancel" AutoPostBack="true"
                                                                            ToolTip="Click to cancel.">
                                                                        </telerik:RadButton>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Panel ID="CompanyPanel" runat="server">
                                            <div class="list-panel">
                                                <telerik:RadGrid ID="CompanyRG" runat="server" AutoGenerateColumns="False" CellSpacing="0"
                                                    DataSourceID="CompanyDS" GridLines="None" ShowHeader="False" CssClass="RemoveBorders"
                                                    OnItemCommand="CompanyRG_ItemCommand">
                                                    <ClientSettings EnableRowHoverStyle="True" EnablePostBackOnRowClick="True">
                                                    </ClientSettings>
                                                    <MasterTableView DataKeyNames="PartyID" DataSourceID="CompanyDS" Name="PaymentMethodTable">
                                                        <NoRecordsTemplate>
                                                            <div style="padding: 25px;">
                                                                No companies are associated with this payment method.
                                                            </div>
                                                        </NoRecordsTemplate>
                                                        <Columns>
                                                            <telerik:GridBoundColumn DataField="PartyHTML" HeaderStyle-Width="190px" UniqueName="PartyHTML">
                                                                <HeaderStyle Width="190px" />
                                                            </telerik:GridBoundColumn>
                                                        </Columns>
                                                        <PagerStyle PageSizeControlType="RadComboBox" />
                                                    </MasterTableView>
                                                    <PagerStyle PageSizeControlType="RadComboBox" />
                                                </telerik:RadGrid>
                                                <asp:SqlDataSource ID="CompanyDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                    SelectCommand="usp_PaymentMethod_Companies" SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="MeID" PropertyName="Text"
                                                            Type="Int32" />
                                                        <asp:ControlParameter ControlID="HiddenTB_PaymentMethodID" Name="PaymentMethodID"
                                                            PropertyName="Text" Type="String" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                            </div>
                                        </asp:Panel>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Panel ID="PeoplePanel" runat="server">
                                            <div class="list-panel">
                                                <telerik:RadListBox ID="PeopleRLB" runat="server" CheckBoxes="true" Width="100%"
                                                    Height="300px" DataSourceID="PeopleDS" DataKeyField="PersonID" DataValueField="PK"
                                                    DataTextField="PersonRoleHTML" OnItemDataBound="PeopleRLB_ItemDataBound" OnClientItemChecking="OnClientItemCheckingHandler">
                                                    <ItemTemplate>
                                                        <div>
                                                            <span style="display: inline" id="PersonHTML">
                                                                <%# DataBinder.Eval(Container.DataItem, "PersonRoleHTML")%>
                                                            </span>
                                                        </div>
                                                        <div>
                                                            <span style="display: none" id="PersonID">
                                                                <%# DataBinder.Eval(Container.DataItem, "PersonID")%>
                                                            </span>
                                                        </div>
                                                        <div>
                                                            <span style="display: none" id="RoleID">
                                                                <%# DataBinder.Eval(Container.DataItem, "RoleID")%>
                                                            </span>
                                                        </div>
                                                    </ItemTemplate>
                                                </telerik:RadListBox>
                                                <asp:SqlDataSource ID="PeopleDS" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseFASTPORT1 %>"
                                                    SelectCommand="usp_PaymentMethod_AvailTo" SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="HiddenTB_PartyID" Name="MeID" PropertyName="Text"
                                                            Type="Int32" />
                                                        <asp:ControlParameter ControlID="HiddenTB_PaymentMethodID" Name="PaymentMethodID"
                                                            PropertyName="Text" Type="String" />
                                                        <asp:ControlParameter ControlID="HiddenTB_PeopleParentID" Name="PeopleParentID" PropertyName="Text"
                                                            Type="String" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                            </div>
                                        </asp:Panel>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="HiddenPanel" runat="server">
                    <div id="HiddenDiv" style="display: none;">
                        PartyID:
                        <asp:TextBox ID="HiddenTB_PartyID" runat="server"></asp:TextBox><br />
                        PeopleParentID:
                        <asp:TextBox ID="HiddenTB_PeopleParentID" runat="server"></asp:TextBox><br />
                        PaymentMethodID:
                        <asp:TextBox ID="HiddenTB_PaymentMethodID" runat="server"></asp:TextBox><br />
                    </div>
                </asp:Panel>
            </td>
        </tr>
    </table>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();"
        onmouseover="clearTimeout(gPopupTimer);">
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="false"
        runat="server"></asp:ValidationSummary>
</asp:Content>
