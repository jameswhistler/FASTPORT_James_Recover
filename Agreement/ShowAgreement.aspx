<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ShowAgreement.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.ShowAgreement" %>
<%@ Register Tagprefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="FASTPORT" Namespace="FASTPORT.UI.Controls.ShowAgreement" Assembly="FASTPORT" %>

<%@ Register Tagprefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>


	<telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
    </telerik:RadStyleSheetManager>	
	
		<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type="text/javascript">
	
            function ChildCloseAndRedirect(args) {
                GetRadWindow().BrowserWindow.ParentCloseAndRedirect(args);
                GetRadWindow().close();
            }


            function ChildClose(args) {
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

    <asp:UpdateProgress runat="server" id="UpdatePanel1_UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1">
			<ProgressTemplate>
				<div class="ajaxUpdatePanel">
				</div>
				<div style=" position:absolute; padding:30px;">
					<img src="../Images/updating.gif" alt="Updating" />
				</div>
			</ProgressTemplate>
		</asp:UpdateProgress>
		<asp:UpdatePanel runat="server" id="UpdatePanel1" UpdateMode="Conditional">
			<ContentTemplate>
				<input type="hidden" id="_clientSideIsPostBack" name="clientSideIsPostBack" runat="server" />
<table cellpadding="0" cellspacing="0" border="0"><tr id="InstructionsRow" runat="server" visible="false"><td stle="width:833px;"><table><tr><td style="text-align:left;" class="dfv"><br />
<asp:Literal runat="server" id="InstructionsStandard" Text="602">	</asp:Literal>
<br /></td></tr></table>
</td></tr><tr><td runat="server" style="width: height:550px;vertical-align:top;"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <FASTPORT:AgreementRecordControl runat="server" id="AgreementRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><telerik:RadTabStrip ID="RadTabStrip1" runat="server" MultiPageID="RadMultiPage1" SelectedIndex="0" Width="800px">
 <Tabs>
   <telerik:RadTab runat="server" Text="Document Settings" Style="font-size: 4;" PageViewID="PageView1">
   </telerik:RadTab>
   <telerik:RadTab runat="server" Text="Custom Fields" PageViewID="PageView2">
   </telerik:RadTab>
   <telerik:RadTab runat="server" Text="Custom Instructions" PageViewID="PageView3">
   </telerik:RadTab>
 </Tabs>
</telerik:RadTabStrip>
<telerik:RadMultiPage id="RadMultiPage1" runat="server" SelectedIndex="0" Width="800px">
  	<telerik:RadPageView id="PageView1" runat="server" CssClass="nested_panel_cust">
		<asp:panel id="AgreementRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="RoleIDLabel" Text="Only For">	</asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RoleID"></asp:Literal></span>
</td><td class="dfv" style="width:50px"></td><td class="header_cust" rowspan="12"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<FASTPORT:FlowCollectionRecordControl runat="server" id="FlowCollectionRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="header_cust"><asp:Literal runat="server" id="HeaderCollectionLiteral" Text="Document Work Flow">	</asp:Literal></td></tr><tr><td><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="FlowCollectionRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dfv"><br />
<asp:Literal runat="server" id="CollectionName"></asp:Literal>
<br /></td></tr><tr><td class="dfv"><asp:Literal runat="server" id="CollectionDescription"></asp:Literal> </td></tr><tr><td class="dfv"><asp:Image runat="server" id="CollectionImage" style="max-width:250px;margin:5px;"></asp:Image></td></tr></table></asp:panel>
</td></tr></table>
</td></tr></table>
</FASTPORT:FlowCollectionRecordControl>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="fls"><asp:Literal runat="server" id="AgreementLabel" Text="Document">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Agreement"></asp:Literal> </td><td class="dfv" style="width:50px">&nbsp;</td></tr><tr><td class="fls"><asp:Literal runat="server" id="DescriptionLabel" Text="Description">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Description"></asp:Literal> </td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="AgreementFileLabel" Text="Document File">	</asp:Literal></td><td class="dfv"><asp:LinkButton runat="server" id="AgreementFile" CommandName="Redirect" filenamefield="AgreementFileName"></asp:LinkButton></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="RequiredDocLabel" Text="Required Document">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="RequiredDoc"></asp:Literal></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="UseStoredSignatureLabel" Text="Use Stored Signature">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="UseStoredSignature"></asp:Literal> </td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="ShowSignatureDateLabel" Text="Show Signature Date">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="ShowSignatureDate"></asp:Literal> </td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="ShowExpirationDateLabel" Text="Show Expiration Date">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="ShowExpirationDate"></asp:Literal> </td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="InitialsInDocumentLabel" Text="Initials In Document">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="InitialsInDocument"></asp:Literal> </td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="DocHasCustomFieldsLabel" Text="Document Has Custom Fields">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="DocHasCustomFields"></asp:Literal> </td><td class="dfv"></td></tr><tr><td class="fls" style="vertical-align:top;"><asp:Literal runat="server" id="ExecuteFromBoardLabel" Text="Block Execution">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><asp:Literal runat="server" id="ExecuteFromBoard"></asp:Literal></td><td class="dfv"></td></tr><tr><td class="fls"></td><td class="dfv"></td><td class="dfv"></td></tr></table></asp:panel>
 
	</telerik:RadPageView>
	<telerik:RadPageView id="PageView2" runat="server" CssClass="nested_panel_cust">
		<table><tr><td class="thc" style="text-align:left;vertical-align:bottom;"><asp:Label runat="server" id="ItemLabel" Text="Items">	</asp:Label></td><td class="thc" style="text-align:left;width:250px;vertical-align:bottom;"><asp:Label runat="server" id="DefaultLabel" Text="Default  Values">	</asp:Label></td><td class="thc" style="text-align:left;vertical-align:bottom;"><asp:Label runat="server" id="FieldTypeLbl" Text="Field Type">	</asp:Label></td><td class="thc" style="text-align:left;vertical-align:bottom;"><b><asp:Label runat="server" id="ForLbl" Text="For:">	</asp:Label><br /></b>
&nbsp;&nbsp;<asp:Label runat="server" id="OnlyCIXLbl" Text="Sender">	</asp:Label></td><td class="thc" style="text-align:left;vertical-align:bottom;"><b><asp:Label runat="server" id="ForLbl1" Text="For:">	</asp:Label> </b><br />
&nbsp;&nbsp;<asp:Label runat="server" id="OnlyOIXLbl" Text="Repicient">	</asp:Label></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="FirstItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FirstDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FirstTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="FirstByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FirstByOIX"></asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="SecondItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="SecondDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="SecondTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="SecondByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="SecondByOIX"></asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="ThirdItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="ThirdDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ThirdTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="ThirdByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="ThirdByOIX"></asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="FourthItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FourthDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FourthTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="FourthByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FourthByOIX"></asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="FifthItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FifthDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FifthTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="FifthByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FifthByOIX"></asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="SixthItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="SixthDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="SixthTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="SixthByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="SixthByOIX"></asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="SeventhItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="SeventhDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="SeventhTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="SeventhByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="SeventhByOIX"></asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="EighthItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="EighthDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="EighthTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="EighthByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="EighthByOIX"></asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="NinthItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="NinthDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NinthTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="NinthByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="NinthByOIX"></asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="TenthItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="TenthDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TenthTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="TenthByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="TenthByOIX"></asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="EleventhItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="EleventhDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="EleventhTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="EleventhByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="EleventhByOIX"></asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="TwelfthItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="TwelfthDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TwelfthTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="TwelfthByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="TwelfthByOIX"></asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="ThirteenthItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="ThirteenthDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ThirteenthTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="ThirteenthByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="ThirteenthByOIX"></asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="FourteenthItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FourteenthDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FourteenthTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="FourteenthByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FourteenthByOIX"></asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="FifteenthItem"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FifteenthDefault"></asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FifteenthTypeID"></asp:Literal></span>
</td><td class="dfv"><asp:Literal runat="server" id="FifteenthByCIX"></asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FifteenthByOIX"></asp:Literal></td></tr></table>

  	</telerik:RadPageView>
	<telerik:RadPageView id="PageView3" runat="server" CssClass="nested_panel_cust">
		<table><tr><td><asp:Panel id="CustomInstructionsSrollPanel" runat="server" Height="450px" Width="785px" ScrollBars="Auto">
<center>
<table><tr id="OtherInstructionsRow" runat="server" visible="true"><td><table><tr><td class="header_cust"><asp:literal id="OtherInstructionsLbl" runat="server" text="General Instructions"></asp:literal></td></tr><tr><td class="dfv"><asp:Literal runat="server" id="OtherInstructions"></asp:Literal></td></tr></table>

<br /></td></tr><tr id="SenderInstructionsRow" runat="server" visible="false"><td><table><tr><td class="header_cust"><asp:literal id="SenderInstrucitonsLbl" runat="server" text="Instructions for Sender Only"></asp:literal></td></tr><tr><td class="dfv"><asp:Literal runat="server" id="SenderInstructions"></asp:Literal></td></tr></table>

<br /></td></tr><tr id="RecipientInstructionsRow" runat="server" visible="false"><td> 
<table><tr><td class="header_cust"><asp:literal id="RecipientInstrucitonsLbl" runat="server" text="Instructions for Recipient Only"></asp:literal></td></tr><tr><td class="dfv"><asp:Literal runat="server" id="RecipientInstructions"></asp:Literal></td></tr></table>
</td></tr></table>

</center>
</asp:Panel></td></tr></table>
		
	</telerik:RadPageView>
</telerik:RadMultiPage>
	</td></tr></table>
</td></tr></table>
</FASTPORT:AgreementRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0"><tr><td><FASTPORT:ThemeButton runat="server" id="OKButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;FASTPORT&quot;) %>" postback="False"></FASTPORT:ThemeButton></td></tr></table>
</td></tr></table></ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>