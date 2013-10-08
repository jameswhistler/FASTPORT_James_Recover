<%@ Register Tagprefix="FASTPORT" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="FASTPORT" Namespace="FASTPORT.UI.Controls.GroupByRoleTable" Assembly="FASTPORT" %>

<%@ Register Tagprefix="FASTPORT" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="GroupByRoleTable.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="FASTPORT.UI.GroupByRoleTable" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
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

                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td>
                        <FASTPORT:RoleTableControl runat="server" id="RoleTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb" style="width: 100%"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="RoleTitle" Text="&lt;%#String.Concat(&quot;Role&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="RoleButtonsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td></td><td></td><td style="text-align: right;"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="RoleNewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="RolePDFButton" causesvalidation="False" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src='../Images/ButtonBarPDFExport.gif'" onmouseover="this.src='../Images/ButtonBarPDFExportOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="RoleWordButton" causesvalidation="False" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src='../Images/ButtonBarWordExport.gif'" onmouseover="this.src='../Images/ButtonBarWordExportOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="RoleExportExcelButton" causesvalidation="False" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src='../Images/ButtonBarExcelExport.gif'" onmouseover="this.src='../Images/ButtonBarExcelExportOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="RoleImportButton" causesvalidation="False" commandname="ImportCSV" imageurl="../Images/ButtonBarImport.gif" onmouseout="this.src='../Images/ButtonBarImport.gif'" onmouseover="this.src='../Images/ButtonBarImportOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Import&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><FASTPORT:ThemeButtonWithArrow runat="server" id="RoleButtonsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel('RoleButtonsDiv','RoleButtonsButton',this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;FASTPORT&quot;) %>"></FASTPORT:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <FASTPORT:ThemeButtonWithArrow runat="server" id="RoleFiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel('RoleFiltersDiv','RoleFiltersButton',this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;FASTPORT&quot;) %>"></FASTPORT:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="panelSearchBox"><table><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("RoleSearchButton"))%>

                <asp:TextBox runat="server" id="RoleSearch" columns="80" cssclass="Search_Input">	</asp:TextBox>
<asp:AutoCompleteExtender id="RoleSearchAutoCompleteExtender" runat="server" TargetControlID="RoleSearch" ServiceMethod="GetAutoCompletionList_RoleSearch" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
</asp:AutoCompleteExtender>

              <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("RoleSearchButton"))%>
</td><td>
                <asp:ImageButton runat="server" id="RoleSearchButton" causesvalidation="False" commandname="Search" imageurl="../Images/panelSearchButton.png" tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton>
              </td></tr></table>
</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="RoleFiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="RoleTypeIDLabel1" Text="Role Type">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("RoleFilterButton"))%>
<asp:DropDownList runat="server" id="RoleTypeIDFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("RoleFilterButton"))%>
</td><td class="popupTableCellValue"><FASTPORT:ThemeButton runat="server" id="RoleFilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;FASTPORT&quot;) %>" postback="False"></FASTPORT:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="RoleResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarResetOver.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel">
                <%# GetResourceValue("Txt:SortBy", "FASTPORT") %>
              </td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="GeneralRoleIDSortLabel" tooltip="Sort by GeneralRoleID" Text="General Role" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="RoleRankSortLabel" tooltip="Sort by RoleRank" Text="Role Rank" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="RoleSortLabel" tooltip="Sort by Role" Text="Role" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="RoleTypeIDSortLabel" tooltip="Sort by RoleTypeID" Text="Role Type" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="RoleDescriptionSortLabel" tooltip="Sort by RoleDescription" Text="Role Description" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="RoleTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="3" style="display:none"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th></tr><asp:Repeater runat="server" id="RoleTableControlRepeater">		<ITEMTEMPLATE>		<FASTPORT:RoleTableControlRow runat="server" id="RoleTableControlRow">
<tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;" rowspan="3" colspan="3">
                                  <asp:ImageButton runat="server" id="RoleRowEditButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src='../Images/icon_edit.gif'" onmouseover="this.src='../Images/icon_edit_over.gif'" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton><br /><br />
                                
                                  <asp:ImageButton runat="server" id="RoleRowDeleteButton" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src='../Images/icon_delete.gif'" onmouseover="this.src='../Images/icon_delete_over.gif'" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton><br /><br />
                                
                                  <asp:ImageButton runat="server" id="RoleRowExpandCollapseRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton><br /><br />
                                </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="RoleLabel" Text="Role">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Role"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="RoleRankLabel" Text="Role Rank">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RoleRank"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="GeneralRoleIDLabel" Text="General Role">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:LinkButton runat="server" id="GeneralRoleID" causesvalidation="False" commandname="Redirect"></asp:LinkButton></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="RoleTypeIDLabel" Text="Role Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="RoleTypeID"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="RoleDescriptionLabel" Text="Role Description">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="RoleDescription"></asp:Literal> </td></tr><tr id="RoleTableControlAltRow" runat="server"><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableCellValue" colspan="6"><asp:TabContainer runat="server" id="RoleTabContainer">
 <asp:TabPanel runat="server" id="AgreementTabPanel" HeaderText="Agreement">	<ContentTemplate>
  <FASTPORT:AgreementTableControl runat="server" id="AgreementTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="AgreementTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th></tr><asp:Repeater runat="server" id="AgreementTableControlRepeater">		<ITEMTEMPLATE>		<FASTPORT:AgreementTableControlRow runat="server" id="AgreementTableControlRow">
<tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="AgreementLabel" Text="Agreement">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Agreement"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CreatedAtLabel" Text="Created At">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CreatedAt"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="AgreementFileNameLabel" Text="Agreement File Name">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="AgreementFileName"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="UpdatedAtLabel" Text="Updated At">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="UpdatedAt"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CustomIDLabel" Text="Custom">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CustomID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CIXLabel" Text="CIX">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CIX"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocTreeParentIDLabel" Text="Document Tree Parent">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="DocTreeParentID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CreatedByIDLabel" Text="Created By">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CreatedByID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FlowCollectionIDLabel" Text="Flow Collection">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FlowCollectionID"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocRankLabel" Text="Document Rank">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="DocRank"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EighthTypeIDLabel" Text="Eighth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="EighthTypeID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="UpdatedByIDLabel" Text="Updated By">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="UpdatedByID"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EleventhTypeIDLabel" Text="Eleventh Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="EleventhTypeID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocIndexLabel" Text="Document Index">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="DocIndex"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifteenthTypeIDLabel" Text="Fifteenth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FifteenthTypeID"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocSortLabel" Text="Document Sort">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="DocSort"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifthTypeIDLabel" Text="Fifth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FifthTypeID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocHasCustomFieldsLabel" Text="Document Has Custom Fields">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="DocHasCustomFields"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FirstTypeIDLabel" Text="First Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FirstTypeID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EighthByCIXLabel" Text="Eighth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="EighthByCIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourteenthTypeIDLabel" Text="Fourteenth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FourteenthTypeID"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EighthByOIXLabel" Text="Eighth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="EighthByOIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourthTypeIDLabel" Text="Fourth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FourthTypeID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EleventhByCIXLabel" Text="Eleventh By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="EleventhByCIX"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="NinthTypeIDLabel" Text="Ninth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="NinthTypeID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EleventhByOIXLabel" Text="Eleventh By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="EleventhByOIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SecondTypeIDLabel" Text="Second Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="SecondTypeID"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ExecuteFromBoardLabel" Text="Execute From Board">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ExecuteFromBoard"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SeventhTypeIDLabel" Text="Seventh Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="SeventhTypeID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifteenthByCIXLabel" Text="Fifteenth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="FifteenthByCIX"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SixthTypeIDLabel" Text="Sixth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="SixthTypeID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifteenthByOIXLabel" Text="Fifteenth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="FifteenthByOIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TenthTypeIDLabel" Text="Tenth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TenthTypeID"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifthByCIXLabel" Text="Fifth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="FifthByCIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirdTypeIDLabel" Text="Third Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ThirdTypeID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifthByOIXLabel" Text="Fifth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="FifthByOIX"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirteenthTypeIDLabel" Text="Thirteenth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ThirteenthTypeID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FirstByCIXLabel" Text="First By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="FirstByCIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TwelfthTypeIDLabel" Text="Twelfth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TwelfthTypeID"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FirstByOIXLabel" Text="First By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="FirstByOIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourteenthByCIXLabel" Text="Fourteenth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="FourteenthByCIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourteenthByOIXLabel" Text="Fourteenth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="FourteenthByOIX"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourthByCIXLabel" Text="Fourth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="FourthByCIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourthByOIXLabel" Text="Fourth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="FourthByOIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="HideLabel" Text="Hide">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Hide"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="InitialsInDocumentLabel" Text="Initials In Document">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="InitialsInDocument"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="NinthByCIXLabel" Text="Ninth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="NinthByCIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="NinthByOIXLabel" Text="Ninth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="NinthByOIX"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="RequiredDocLabel" Text="Required Document">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="RequiredDoc"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SecondByCIXLabel" Text="Second By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="SecondByCIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SecondByOIXLabel" Text="Second By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="SecondByOIX"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SeventhByCIXLabel" Text="Seventh By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="SeventhByCIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SeventhByOIXLabel" Text="Seventh By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="SeventhByOIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ShowExpirationDateLabel" Text="Show Expiration Date">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ShowExpirationDate"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ShowSignatureDateLabel" Text="Show Signature Date">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ShowSignatureDate"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SixthByCIXLabel" Text="Sixth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="SixthByCIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SixthByOIXLabel" Text="Sixth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="SixthByOIX"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TenthByCIXLabel" Text="Tenth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="TenthByCIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TenthByOIXLabel" Text="Tenth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="TenthByOIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirdByCIXLabel" Text="Third By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ThirdByCIX"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirdByOIXLabel" Text="Third By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ThirdByOIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirteenthByCIXLabel" Text="Thirteenth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ThirteenthByCIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirteenthByOIXLabel" Text="Thirteenth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ThirteenthByOIX"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TwelfthByCIXLabel" Text="Twelfth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="TwelfthByCIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TwelfthByOIXLabel" Text="Twelfth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="TwelfthByOIX"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="UseStoredSignatureLabel" Text="Use Stored Signature">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="UseStoredSignature"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DescriptionLabel" Text="Description">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="Description"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EighthDefaultLabel" Text="Eighth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="EighthDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EighthItemLabel" Text="Eighth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="EighthItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EleventhDefaultLabel" Text="Eleventh Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="EleventhDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EleventhItemLabel" Text="Eleventh Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="EleventhItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifteenthDefaultLabel" Text="Fifteenth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="FifteenthDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifteenthItemLabel" Text="Fifteenth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="FifteenthItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifthDefaultLabel" Text="Fifth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="FifthDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifthItemLabel" Text="Fifth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="FifthItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FirstDefaultLabel" Text="First Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="FirstDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FirstItemLabel" Text="First Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="FirstItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourteenthDefaultLabel" Text="Fourteenth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="FourteenthDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourteenthItemLabel" Text="Fourteenth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="FourteenthItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourthDefaultLabel" Text="Fourth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="FourthDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourthItemLabel" Text="Fourth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="FourthItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="NinthDefaultLabel" Text="Ninth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="NinthDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="NinthItemLabel" Text="Ninth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="NinthItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="OtherInstructionsLabel" Text="Other Instructions">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="OtherInstructions"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="RecipientInstructionsLabel" Text="Recipient Instructions">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="RecipientInstructions"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SecondDefaultLabel" Text="Second Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="SecondDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SecondItemLabel" Text="Second Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="SecondItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SenderInstructionsLabel" Text="Sender Instructions">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="SenderInstructions"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SeventhDefaultLabel" Text="Seventh Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="SeventhDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SeventhItemLabel" Text="Seventh Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="SeventhItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SixthDefaultLabel" Text="Sixth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="SixthDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SixthItemLabel" Text="Sixth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="SixthItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TenthDefaultLabel" Text="Tenth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="TenthDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TenthItemLabel" Text="Tenth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="TenthItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirdDefaultLabel" Text="Third Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="ThirdDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirdItemLabel" Text="Third Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="ThirdItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirteenthDefaultLabel" Text="Thirteenth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="ThirteenthDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirteenthItemLabel" Text="Thirteenth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="ThirteenthItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TwelfthDefaultLabel" Text="Twelfth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="TwelfthDefault"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TwelfthItemLabel" Text="Twelfth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="TwelfthItem"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="AgreementFileLabel" Text="Agreement File">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:LinkButton runat="server" id="AgreementFile" CommandName="Redirect"></asp:LinkButton> </td></tr><tr><td class="tableRowDivider" colspan="6">&nbsp;</td></tr></FASTPORT:AgreementTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <FASTPORT:PaginationModern runat="server" id="AgreementPagination"></FASTPORT:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
</FASTPORT:AgreementTableControl>

 </ContentTemplate></asp:TabPanel>
 <asp:TabPanel runat="server" id="CarrierAdContactsTabPanel" HeaderText="Carrier Advertisement Contacts">	<ContentTemplate>
  <FASTPORT:CarrierAdContactsTableControl runat="server" id="CarrierAdContactsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="CarrierAdContactsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th></tr><asp:Repeater runat="server" id="CarrierAdContactsTableControlRepeater">		<ITEMTEMPLATE>		<FASTPORT:CarrierAdContactsTableControlRow runat="server" id="CarrierAdContactsTableControlRow">
<tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="AdIDLabel" Text="Advertisement">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AdID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="PartyIDLabel" Text="Party">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="PartyID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ContactTypeIDLabel" Text="Contact Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ContactTypeID"></asp:Literal></span>
 </td></tr><tr><td class="tableRowDivider" colspan="6">&nbsp;</td></tr></FASTPORT:CarrierAdContactsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <FASTPORT:PaginationModern runat="server" id="CarrierAdContactsPagination"></FASTPORT:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
</FASTPORT:CarrierAdContactsTableControl>

 </ContentTemplate></asp:TabPanel>
 <asp:TabPanel runat="server" id="DocTreeTabPanel" HeaderText="Document Tree">	<ContentTemplate>
  <FASTPORT:DocTreeTableControl runat="server" id="DocTreeTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="DocTreeTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th></tr><asp:Repeater runat="server" id="DocTreeTableControlRepeater">		<ITEMTEMPLATE>		<FASTPORT:DocTreeTableControlRow runat="server" id="DocTreeTableControlRow">
<tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocNameLabel" Text="Document Name">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="DocName"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocIndexLabel1" Text="Document Index">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="DocIndex1"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CreatedAtLabel1" Text="Created At">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CreatedAt1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocTreeParentIDLabel1" Text="Document Tree Parent">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="DocTreeParentID1"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocSortLabel1" Text="Document Sort">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="DocSort1"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="UpdatedAtLabel1" Text="Updated At">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="UpdatedAt1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocTypeIDLabel" Text="Document Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="DocTypeID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="AlwaysShowLabel" Text="Always Show">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="AlwaysShow"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CIXLabel1" Text="CIX">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CIX1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FolderLabel" Text="Folder">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Folder"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="HideLabel1" Text="Hide">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Hide1"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CreatedByIDLabel1" Text="Created By">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CreatedByID1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="OnAppLabel" Text="On Application">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="OnApp"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="OneActiveCopyLabel" Text="One Active Copy">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="OneActiveCopy"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ItemRankLabel" Text="Item Rank">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ItemRank"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="PrivateFolderLabel" Text="Private Folder">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="PrivateFolder"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="RecordDocDetailsLabel" Text="Record Document Details">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="RecordDocDetails"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="UpdatedByIDLabel1" Text="Updated By">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="UpdatedByID1"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocDescriptionLabel" Text="Document Description">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="DocDescription"></asp:Literal> </td></tr><tr><td class="tableRowDivider" colspan="6">&nbsp;</td></tr></FASTPORT:DocTreeTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <FASTPORT:PaginationModern runat="server" id="DocTreePagination"></FASTPORT:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
</FASTPORT:DocTreeTableControl>

 </ContentTemplate></asp:TabPanel>
</asp:TabContainer></td></tr><tr><td class="tableRowDivider" colspan="9">&nbsp;</td></tr></FASTPORT:RoleTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <FASTPORT:PaginationModern runat="server" id="RolePagination"></FASTPORT:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</FASTPORT:RoleTableControl>

            </td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                