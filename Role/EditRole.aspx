<%@ Register Tagprefix="FASTPORT" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="FASTPORT" Namespace="FASTPORT.UI.Controls.EditRole" Assembly="FASTPORT" %>

<%@ Register Tagprefix="FASTPORT" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="EditRole.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="FASTPORT.UI.EditRole" %>
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

                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <FASTPORT:RoleRecordControl runat="server" id="RoleRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="RoleTitle" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Edit&quot;),&quot; Role&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="RoleRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="RoleRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="RoleLabel" Text="Role">	</asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="Role" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="RoleRequiredFieldValidator" ControlToValidate="Role" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Role&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="RoleTextBoxMaxLengthValidator" ControlToValidate="Role" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Role&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="fls"><asp:Literal runat="server" id="GeneralRoleIDLabel" Text="General Role">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="GeneralRoleID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="GeneralRoleIDFvLlsHyperLink" ControlToUpdate="GeneralRoleID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="Role" Field="Role_.RoleID" DisplayField="Role_.Role"></Selectors:FvLlsHyperLink></span>
 
<asp:ImageButton runat="server" id="GeneralRoleIDAddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="RoleTypeIDLabel" Text="Role Type">	</asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="RoleTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="RoleTypeIDFvLlsHyperLink" ControlToUpdate="RoleTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="Tree" Field="Tree_.TreeID" DisplayField="Tree_.ItemName"></Selectors:FvLlsHyperLink>&nbsp;
<asp:RequiredFieldValidator runat="server" id="RoleTypeIDRequiredFieldValidator" ControlToValidate="RoleTypeID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Role Type&quot;) %>" enabled="True" initialvalue="--PLEASE_SELECT--" text="*"></asp:RequiredFieldValidator></span>
 </td></tr><tr><td class="fls"><asp:Literal runat="server" id="RoleRankLabel" Text="Role Rank">	</asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="RoleRank" Columns="14" MaxLength="14" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="RoleRankTextBoxMaxLengthValidator" ControlToValidate="RoleRank" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Role Rank&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="fls"><asp:Literal runat="server" id="RoleDescriptionLabel" Text="Role Description">	</asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="RoleDescription" MaxLength="255" columns="120" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="RoleDescriptionTextBoxMaxLengthValidator" ControlToValidate="RoleDescription" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Role Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</FASTPORT:RoleRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td><asp:TabContainer runat="server" id="RoleTabContainer">
 <asp:TabPanel runat="server" id="AgreementTabPanel" HeaderText="Agreement">	<ContentTemplate>
  <FASTPORT:AgreementTableControl runat="server" id="AgreementTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb" style="width: 100%"></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="AgreementButtonsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td style="text-align: right;"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="AgreementAddButton" causesvalidation="False" commandname="AddRecord" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="AgreementDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" imageurl="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><FASTPORT:ThemeButtonWithArrow runat="server" id="AgreementButtonsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel('AgreementButtonsDiv','AgreementButtonsButton',this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;FASTPORT&quot;) %>"></FASTPORT:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <FASTPORT:ThemeButtonWithArrow runat="server" id="AgreementFiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel('AgreementFiltersDiv','AgreementFiltersButton',this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;FASTPORT&quot;) %>"></FASTPORT:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td></td></tr></table>
</td><td>
                          <div id="AgreementFiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel">
                <%# GetResourceValue("Txt:SortBy", "FASTPORT") %>
              </td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="AgreementSortLabel" tooltip="Sort by Agreement" Text="Agreement" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="CustomIDSortLabel" tooltip="Sort by CustomID" Text="Custom" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="AgreementFileNameSortLabel" tooltip="Sort by AgreementFileName" Text="Agreement File Name" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="DocRankSortLabel" tooltip="Sort by DocRank" Text="Document Rank" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="CIXSortLabel" tooltip="Sort by CIX" Text="CIX" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="DocTreeParentIDSortLabel" tooltip="Sort by DocTreeParentID" Text="Document Tree Parent" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="CreatedAtSortLabel" tooltip="Sort by CreatedAt" Text="Created At" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="FlowCollectionIDSortLabel" tooltip="Sort by FlowCollectionID" Text="Flow Collection" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="CreatedByIDSortLabel" tooltip="Sort by CreatedByID" Text="Created By" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="UpdatedAtSortLabel" tooltip="Sort by UpdatedAt" Text="Updated At" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="AgreementTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="2"><asp:CheckBox runat="server" id="AgreementToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thcwb" style="padding:0px;vertical-align:middle;">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th></tr><asp:Repeater runat="server" id="AgreementTableControlRepeater">		<ITEMTEMPLATE>		<FASTPORT:AgreementTableControlRow runat="server" id="AgreementTableControlRow">
<tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;" rowspan="68" colspan="2">
                              <asp:CheckBox runat="server" id="AgreementRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox><br /><br />
                            </td><td class="tableRowButton" rowspan="68">
                          <asp:ImageButton runat="server" id="AgreementRowEditButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src='../Images/icon_edit.gif'" onmouseover="this.src='../Images/icon_edit_over.gif'" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton><br /><br />
                        
                          <asp:ImageButton runat="server" id="AgreementRowDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src='../Images/icon_delete.gif'" onmouseover="this.src='../Images/icon_delete_over.gif'" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton><br /><br />
                        </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="AgreementLabel" Text="Agreement">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="Agreement" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="AgreementRequiredFieldValidator" ControlToValidate="Agreement" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Agreement&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="AgreementTextBoxMaxLengthValidator" ControlToValidate="Agreement" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Agreement&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CreatedAtLabel" Text="Created At">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="CreatedAt" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="CreatedAtCalendarExtender" TargetControlID="CreatedAt" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CreatedAtTextBoxMaxLengthValidator" ControlToValidate="CreatedAt" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Created At&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="AgreementFileNameLabel" Text="Agreement File Name">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="AgreementFileName" MaxLength="100" columns="50" cssclass="field_input" rows="2" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="AgreementFileNameTextBoxMaxLengthValidator" ControlToValidate="AgreementFileName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Agreement File Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="UpdatedAtLabel" Text="Updated At">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="UpdatedAt" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="UpdatedAtCalendarExtender" TargetControlID="UpdatedAt" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="UpdatedAtTextBoxMaxLengthValidator" ControlToValidate="UpdatedAt" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Updated At&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CustomIDLabel" Text="Custom">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="CustomID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="CustomIDFvLlsHyperLink" ControlToUpdate="CustomID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="Agreement" Field="Agreement_.AgreementID" DisplayField="Agreement_.Agreement"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CIXLabel" Text="CIX">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="CIX" Columns="14" MaxLength="14" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="CIXRequiredFieldValidator" ControlToValidate="CIX" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;CIX&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CIXTextBoxMaxLengthValidator" ControlToValidate="CIX" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;CIX&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocTreeParentIDLabel" Text="Document Tree Parent">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="DocTreeParentID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="DocTreeParentIDFvLlsHyperLink" ControlToUpdate="DocTreeParentID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="DocTree" Field="DocTree_.DocTreeID" DisplayField="DocTree_.DocName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CreatedByIDLabel" Text="Created By">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="CreatedByID" Columns="14" MaxLength="14" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CreatedByIDTextBoxMaxLengthValidator" ControlToValidate="CreatedByID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Created By&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FlowCollectionIDLabel" Text="Flow Collection">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FlowCollectionID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="FlowCollectionIDFvLlsHyperLink" ControlToUpdate="FlowCollectionID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="FlowCollection" Field="FlowCollection_.FlowCollectionID" DisplayField="FlowCollection_.CollectionName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocRankLabel" Text="Document Rank">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="DocRank" Columns="14" MaxLength="14" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DocRankTextBoxMaxLengthValidator" ControlToValidate="DocRank" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Rank&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EighthTypeIDLabel" Text="Eighth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="EighthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="EighthTypeIDFvLlsHyperLink" ControlToUpdate="EighthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="UpdatedByIDLabel" Text="Updated By">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="UpdatedByID" Columns="14" MaxLength="14" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="UpdatedByIDTextBoxMaxLengthValidator" ControlToValidate="UpdatedByID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Updated By&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EleventhTypeIDLabel" Text="Eleventh Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="EleventhTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="EleventhTypeIDFvLlsHyperLink" ControlToUpdate="EleventhTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocIndexLabel" Text="Document Index">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="DocIndex" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DocIndexTextBoxMaxLengthValidator" ControlToValidate="DocIndex" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Index&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifteenthTypeIDLabel" Text="Fifteenth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FifteenthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="FifteenthTypeIDFvLlsHyperLink" ControlToUpdate="FifteenthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocSortLabel" Text="Document Sort">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="DocSort" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DocSortTextBoxMaxLengthValidator" ControlToValidate="DocSort" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Sort&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifthTypeIDLabel" Text="Fifth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FifthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="FifthTypeIDFvLlsHyperLink" ControlToUpdate="FifthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocHasCustomFieldsLabel" Text="Document Has Custom Fields">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="DocHasCustomFields"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FirstTypeIDLabel" Text="First Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FirstTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="FirstTypeIDFvLlsHyperLink" ControlToUpdate="FirstTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EighthByCIXLabel" Text="Eighth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="EighthByCIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourteenthTypeIDLabel" Text="Fourteenth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FourteenthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="FourteenthTypeIDFvLlsHyperLink" ControlToUpdate="FourteenthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EighthByOIXLabel" Text="Eighth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="EighthByOIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourthTypeIDLabel" Text="Fourth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FourthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="FourthTypeIDFvLlsHyperLink" ControlToUpdate="FourthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EleventhByCIXLabel" Text="Eleventh By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="EleventhByCIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="NinthTypeIDLabel" Text="Ninth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="NinthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="NinthTypeIDFvLlsHyperLink" ControlToUpdate="NinthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EleventhByOIXLabel" Text="Eleventh By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="EleventhByOIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SecondTypeIDLabel" Text="Second Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="SecondTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="SecondTypeIDFvLlsHyperLink" ControlToUpdate="SecondTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ExecuteFromBoardLabel" Text="Execute From Board">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="ExecuteFromBoard"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SeventhTypeIDLabel" Text="Seventh Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="SeventhTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="SeventhTypeIDFvLlsHyperLink" ControlToUpdate="SeventhTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifteenthByCIXLabel" Text="Fifteenth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="FifteenthByCIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SixthTypeIDLabel" Text="Sixth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="SixthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="SixthTypeIDFvLlsHyperLink" ControlToUpdate="SixthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifteenthByOIXLabel" Text="Fifteenth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="FifteenthByOIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TenthTypeIDLabel" Text="Tenth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="TenthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="TenthTypeIDFvLlsHyperLink" ControlToUpdate="TenthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifthByCIXLabel" Text="Fifth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="FifthByCIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirdTypeIDLabel" Text="Third Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ThirdTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="ThirdTypeIDFvLlsHyperLink" ControlToUpdate="ThirdTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifthByOIXLabel" Text="Fifth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="FifthByOIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirteenthTypeIDLabel" Text="Thirteenth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ThirteenthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="ThirteenthTypeIDFvLlsHyperLink" ControlToUpdate="ThirteenthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FirstByCIXLabel" Text="First By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="FirstByCIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TwelfthTypeIDLabel" Text="Twelfth Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="TwelfthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="TwelfthTypeIDFvLlsHyperLink" ControlToUpdate="TwelfthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FirstByOIXLabel" Text="First By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="FirstByOIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourteenthByCIXLabel" Text="Fourteenth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="FourteenthByCIX"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourteenthByOIXLabel" Text="Fourteenth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="FourteenthByOIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourthByCIXLabel" Text="Fourth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="FourthByCIX"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourthByOIXLabel" Text="Fourth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="FourthByOIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="HideLabel" Text="Hide">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="Hide"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="InitialsInDocumentLabel" Text="Initials In Document">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="InitialsInDocument"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="NinthByCIXLabel" Text="Ninth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="NinthByCIX"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="NinthByOIXLabel" Text="Ninth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="NinthByOIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="RequiredDocLabel" Text="Required Document">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="RequiredDoc"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SecondByCIXLabel" Text="Second By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="SecondByCIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SecondByOIXLabel" Text="Second By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="SecondByOIX"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SeventhByCIXLabel" Text="Seventh By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="SeventhByCIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SeventhByOIXLabel" Text="Seventh By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="SeventhByOIX"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ShowExpirationDateLabel" Text="Show Expiration Date">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="ShowExpirationDate"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ShowSignatureDateLabel" Text="Show Signature Date">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="ShowSignatureDate"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SixthByCIXLabel" Text="Sixth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="SixthByCIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SixthByOIXLabel" Text="Sixth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="SixthByOIX"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TenthByCIXLabel" Text="Tenth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="TenthByCIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TenthByOIXLabel" Text="Tenth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="TenthByOIX"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirdByCIXLabel" Text="Third By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="ThirdByCIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirdByOIXLabel" Text="Third By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="ThirdByOIX"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirteenthByCIXLabel" Text="Thirteenth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="ThirteenthByCIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirteenthByOIXLabel" Text="Thirteenth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="ThirteenthByOIX"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TwelfthByCIXLabel" Text="Twelfth By CIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="TwelfthByCIX"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TwelfthByOIXLabel" Text="Twelfth By OIX">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="TwelfthByOIX"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="UseStoredSignatureLabel" Text="Use Stored Signature">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="UseStoredSignature"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DescriptionLabel" Text="Description">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="Description" MaxLength="500" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DescriptionTextBoxMaxLengthValidator" ControlToValidate="Description" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EighthDefaultLabel" Text="Eighth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="EighthDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="EighthDefaultTextBoxMaxLengthValidator" ControlToValidate="EighthDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Eighth Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EighthItemLabel" Text="Eighth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="EighthItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="EighthItemTextBoxMaxLengthValidator" ControlToValidate="EighthItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Eighth Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EleventhDefaultLabel" Text="Eleventh Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="EleventhDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="EleventhDefaultTextBoxMaxLengthValidator" ControlToValidate="EleventhDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Eleventh Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="EleventhItemLabel" Text="Eleventh Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="EleventhItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="EleventhItemTextBoxMaxLengthValidator" ControlToValidate="EleventhItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Eleventh Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifteenthDefaultLabel" Text="Fifteenth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FifteenthDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FifteenthDefaultTextBoxMaxLengthValidator" ControlToValidate="FifteenthDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fifteenth Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifteenthItemLabel" Text="Fifteenth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FifteenthItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FifteenthItemTextBoxMaxLengthValidator" ControlToValidate="FifteenthItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fifteenth Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifthDefaultLabel" Text="Fifth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FifthDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FifthDefaultTextBoxMaxLengthValidator" ControlToValidate="FifthDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fifth Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FifthItemLabel" Text="Fifth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FifthItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FifthItemTextBoxMaxLengthValidator" ControlToValidate="FifthItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fifth Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FirstDefaultLabel" Text="First Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FirstDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FirstDefaultTextBoxMaxLengthValidator" ControlToValidate="FirstDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;First Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FirstItemLabel" Text="First Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FirstItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FirstItemTextBoxMaxLengthValidator" ControlToValidate="FirstItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;First Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourteenthDefaultLabel" Text="Fourteenth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FourteenthDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FourteenthDefaultTextBoxMaxLengthValidator" ControlToValidate="FourteenthDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fourteenth Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourteenthItemLabel" Text="Fourteenth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FourteenthItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FourteenthItemTextBoxMaxLengthValidator" ControlToValidate="FourteenthItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fourteenth Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourthDefaultLabel" Text="Fourth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FourthDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FourthDefaultTextBoxMaxLengthValidator" ControlToValidate="FourthDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fourth Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FourthItemLabel" Text="Fourth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FourthItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FourthItemTextBoxMaxLengthValidator" ControlToValidate="FourthItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fourth Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="NinthDefaultLabel" Text="Ninth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="NinthDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NinthDefaultTextBoxMaxLengthValidator" ControlToValidate="NinthDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Ninth Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="NinthItemLabel" Text="Ninth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="NinthItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="NinthItemTextBoxMaxLengthValidator" ControlToValidate="NinthItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Ninth Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="OtherInstructionsLabel" Text="Other Instructions">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="OtherInstructions" MaxLength="4000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="OtherInstructionsTextBoxMaxLengthValidator" ControlToValidate="OtherInstructions" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Other Instructions&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="RecipientInstructionsLabel" Text="Recipient Instructions">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="RecipientInstructions" MaxLength="4000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="RecipientInstructionsTextBoxMaxLengthValidator" ControlToValidate="RecipientInstructions" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Recipient Instructions&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SecondDefaultLabel" Text="Second Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="SecondDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="SecondDefaultTextBoxMaxLengthValidator" ControlToValidate="SecondDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Second Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SecondItemLabel" Text="Second Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="SecondItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="SecondItemTextBoxMaxLengthValidator" ControlToValidate="SecondItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Second Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SenderInstructionsLabel" Text="Sender Instructions">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="SenderInstructions" MaxLength="4000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="SenderInstructionsTextBoxMaxLengthValidator" ControlToValidate="SenderInstructions" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Sender Instructions&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SeventhDefaultLabel" Text="Seventh Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="SeventhDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="SeventhDefaultTextBoxMaxLengthValidator" ControlToValidate="SeventhDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Seventh Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SeventhItemLabel" Text="Seventh Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="SeventhItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="SeventhItemTextBoxMaxLengthValidator" ControlToValidate="SeventhItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Seventh Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SixthDefaultLabel" Text="Sixth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="SixthDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="SixthDefaultTextBoxMaxLengthValidator" ControlToValidate="SixthDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Sixth Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="SixthItemLabel" Text="Sixth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="SixthItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="SixthItemTextBoxMaxLengthValidator" ControlToValidate="SixthItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Sixth Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TenthDefaultLabel" Text="Tenth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="TenthDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="TenthDefaultTextBoxMaxLengthValidator" ControlToValidate="TenthDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Tenth Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TenthItemLabel" Text="Tenth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="TenthItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="TenthItemTextBoxMaxLengthValidator" ControlToValidate="TenthItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Tenth Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirdDefaultLabel" Text="Third Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="ThirdDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ThirdDefaultTextBoxMaxLengthValidator" ControlToValidate="ThirdDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Third Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirdItemLabel" Text="Third Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="ThirdItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ThirdItemTextBoxMaxLengthValidator" ControlToValidate="ThirdItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Third Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirteenthDefaultLabel" Text="Thirteenth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="ThirteenthDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ThirteenthDefaultTextBoxMaxLengthValidator" ControlToValidate="ThirteenthDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Thirteenth Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ThirteenthItemLabel" Text="Thirteenth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="ThirteenthItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ThirteenthItemTextBoxMaxLengthValidator" ControlToValidate="ThirteenthItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Thirteenth Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TwelfthDefaultLabel" Text="Twelfth Default">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="TwelfthDefault" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="TwelfthDefaultTextBoxMaxLengthValidator" ControlToValidate="TwelfthDefault" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Twelfth Default&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TwelfthItemLabel" Text="Twelfth Item">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="TwelfthItem" MaxLength="2000" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="TwelfthItemTextBoxMaxLengthValidator" ControlToValidate="TwelfthItem" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Twelfth Item&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="AgreementFileLabel" Text="Agreement File">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><asp:FileUpload runat="server" id="AgreementFile" cssclass="field_input" size="60"></asp:FileUpload> </td></tr><tr><td class="tableRowDivider" colspan="7">&nbsp;</td></tr></FASTPORT:AgreementTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <FASTPORT:PaginationModern runat="server" id="AgreementPagination"></FASTPORT:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</FASTPORT:AgreementTableControl>

 </ContentTemplate></asp:TabPanel>
 <asp:TabPanel runat="server" id="CarrierAdContactsTabPanel" HeaderText="Carrier Advertisement Contacts">	<ContentTemplate>
  <FASTPORT:CarrierAdContactsTableControl runat="server" id="CarrierAdContactsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb" style="width: 100%"></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="CarrierAdContactsButtonsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td style="text-align: right;"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="CarrierAdContactsAddButton" causesvalidation="False" commandname="AddRecord" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="CarrierAdContactsDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" imageurl="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><FASTPORT:ThemeButtonWithArrow runat="server" id="CarrierAdContactsButtonsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel('CarrierAdContactsButtonsDiv','CarrierAdContactsButtonsButton',this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;FASTPORT&quot;) %>"></FASTPORT:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <FASTPORT:ThemeButtonWithArrow runat="server" id="CarrierAdContactsFiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel('CarrierAdContactsFiltersDiv','CarrierAdContactsFiltersButton',this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;FASTPORT&quot;) %>"></FASTPORT:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td></td></tr></table>
</td><td>
                          <div id="CarrierAdContactsFiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel">
                <%# GetResourceValue("Txt:SortBy", "FASTPORT") %>
              </td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="AdIDSortLabel" tooltip="Sort by AdID" Text="Advertisement" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="PartyIDSortLabel" tooltip="Sort by PartyID" Text="Party" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="ContactTypeIDSortLabel" tooltip="Sort by ContactTypeID" Text="Contact Type" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CarrierAdContactsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="2"><asp:CheckBox runat="server" id="CarrierAdContactsToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thcwb" style="padding:0px;vertical-align:middle;">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th></tr><asp:Repeater runat="server" id="CarrierAdContactsTableControlRepeater">		<ITEMTEMPLATE>		<FASTPORT:CarrierAdContactsTableControlRow runat="server" id="CarrierAdContactsTableControlRow">
<tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;" rowspan="2" colspan="2">
                              <asp:CheckBox runat="server" id="CarrierAdContactsRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox><br /><br />
                            </td><td class="tableRowButton" rowspan="2">
                          <asp:ImageButton runat="server" id="CarrierAdContactsRowEditButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src='../Images/icon_edit.gif'" onmouseover="this.src='../Images/icon_edit_over.gif'" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton><br /><br />
                        
                          <asp:ImageButton runat="server" id="CarrierAdContactsRowDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src='../Images/icon_delete.gif'" onmouseover="this.src='../Images/icon_delete_over.gif'" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton><br /><br />
                        </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="AdIDLabel" Text="Advertisement">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="AdID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="AdIDFvLlsHyperLink" ControlToUpdate="AdID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="CarrierAd" Field="CarrierAd_.AdID" DisplayField="CarrierAd_.AdName"></Selectors:FvLlsHyperLink>&nbsp;
<asp:RequiredFieldValidator runat="server" id="AdIDRequiredFieldValidator" ControlToValidate="AdID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Advertisement&quot;) %>" enabled="True" initialvalue="--PLEASE_SELECT--" text="*"></asp:RequiredFieldValidator></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="PartyIDLabel" Text="Party">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="PartyID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="PartyIDFvLlsHyperLink" ControlToUpdate="PartyID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="Party" Field="Party_.PartyID" DisplayField="Party_.Title"></Selectors:FvLlsHyperLink></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ContactTypeIDLabel" Text="Contact Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ContactTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="ContactTypeIDFvLlsHyperLink" ControlToUpdate="ContactTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="Tree" Field="Tree_.TreeID" DisplayField="Tree_.ItemName"></Selectors:FvLlsHyperLink>&nbsp;
<asp:RequiredFieldValidator runat="server" id="ContactTypeIDRequiredFieldValidator" ControlToValidate="ContactTypeID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Contact Type&quot;) %>" enabled="True" initialvalue="--PLEASE_SELECT--" text="*"></asp:RequiredFieldValidator></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="7">&nbsp;</td></tr></FASTPORT:CarrierAdContactsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <FASTPORT:PaginationModern runat="server" id="CarrierAdContactsPagination"></FASTPORT:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</FASTPORT:CarrierAdContactsTableControl>

 </ContentTemplate></asp:TabPanel>
 <asp:TabPanel runat="server" id="DocTreeTabPanel" HeaderText="Document Tree">	<ContentTemplate>
  <FASTPORT:DocTreeTableControl runat="server" id="DocTreeTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb" style="width: 100%"></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="DocTreeButtonsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td style="text-align: right;"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="DocTreeAddButton" causesvalidation="False" commandname="AddRecord" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="DocTreeDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" imageurl="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><FASTPORT:ThemeButtonWithArrow runat="server" id="DocTreeButtonsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel('DocTreeButtonsDiv','DocTreeButtonsButton',this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;FASTPORT&quot;) %>"></FASTPORT:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <FASTPORT:ThemeButtonWithArrow runat="server" id="DocTreeFiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel('DocTreeFiltersDiv','DocTreeFiltersButton',this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;FASTPORT&quot;) %>"></FASTPORT:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td></td></tr></table>
</td><td>
                          <div id="DocTreeFiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel">
                <%# GetResourceValue("Txt:SortBy", "FASTPORT") %>
              </td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="AlwaysShowSortLabel" tooltip="Sort by AlwaysShow" Text="Always Show" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="DocTreeParentIDSortLabel1" tooltip="Sort by DocTreeParentID" Text="Document Tree Parent" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="CIXSortLabel1" tooltip="Sort by CIX" Text="CIX" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="DocTypeIDSortLabel" tooltip="Sort by DocTypeID" Text="Document Type" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="CreatedAtSortLabel1" tooltip="Sort by CreatedAt" Text="Created At" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="FolderSortLabel" tooltip="Sort by Folder" Text="Folder" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="CreatedByIDSortLabel1" tooltip="Sort by CreatedByID" Text="Created By" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="ItemRankSortLabel" tooltip="Sort by ItemRank" Text="Item Rank" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="DocNameSortLabel" tooltip="Sort by DocName" Text="Document Name" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="UpdatedAtSortLabel1" tooltip="Sort by UpdatedAt" Text="Updated At" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="DocTreeTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="2"><asp:CheckBox runat="server" id="DocTreeToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thcwb" style="padding:0px;vertical-align:middle;">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th></tr><asp:Repeater runat="server" id="DocTreeTableControlRepeater">		<ITEMTEMPLATE>		<FASTPORT:DocTreeTableControlRow runat="server" id="DocTreeTableControlRow">
<tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;" rowspan="10" colspan="2">
                              <asp:CheckBox runat="server" id="DocTreeRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox><br /><br />
                            </td><td class="tableRowButton" rowspan="10">
                          <asp:ImageButton runat="server" id="DocTreeRowEditButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src='../Images/icon_edit.gif'" onmouseover="this.src='../Images/icon_edit_over.gif'" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton><br /><br />
                        
                          <asp:ImageButton runat="server" id="DocTreeRowDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src='../Images/icon_delete.gif'" onmouseover="this.src='../Images/icon_delete_over.gif'" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton><br /><br />
                        </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocNameLabel" Text="Document Name">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="DocName" MaxLength="100" columns="50" cssclass="field_input" rows="2" textmode="MultiLine"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="DocNameRequiredFieldValidator" ControlToValidate="DocName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Name&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DocNameTextBoxMaxLengthValidator" ControlToValidate="DocName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CreatedAtLabel1" Text="Created At">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="CreatedAt1" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="CreatedAt1CalendarExtender" TargetControlID="CreatedAt1" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CreatedAt1TextBoxMaxLengthValidator" ControlToValidate="CreatedAt1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Created At&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocTreeParentIDLabel1" Text="Document Tree Parent">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="DocTreeParentID1" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="DocTreeParentID1FvLlsHyperLink" ControlToUpdate="DocTreeParentID1" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="DocTree" Field="DocTree_.DocTreeID" DisplayField="DocTree_.DocName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="UpdatedAtLabel1" Text="Updated At">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="UpdatedAt1" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="UpdatedAt1CalendarExtender" TargetControlID="UpdatedAt1" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="UpdatedAt1TextBoxMaxLengthValidator" ControlToValidate="UpdatedAt1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Updated At&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocTypeIDLabel" Text="Document Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="DocTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="DocTypeIDFvLlsHyperLink" ControlToUpdate="DocTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="Tree" Field="Tree_.TreeID" DisplayField="Tree_.ItemName"></Selectors:FvLlsHyperLink></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CIXLabel1" Text="CIX">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="CIX1" Columns="14" MaxLength="14" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CIX1TextBoxMaxLengthValidator" ControlToValidate="CIX1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;CIX&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="AlwaysShowLabel" Text="Always Show">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="AlwaysShow"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CreatedByIDLabel1" Text="Created By">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="CreatedByID1" Columns="14" MaxLength="14" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CreatedByID1TextBoxMaxLengthValidator" ControlToValidate="CreatedByID1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Created By&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FolderLabel" Text="Folder">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="Folder"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ItemRankLabel" Text="Item Rank">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="ItemRank" Columns="14" MaxLength="14" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ItemRankTextBoxMaxLengthValidator" ControlToValidate="ItemRank" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Item Rank&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="HideLabel1" Text="Hide">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="Hide1"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="UpdatedByIDLabel1" Text="Updated By">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="UpdatedByID1" Columns="14" MaxLength="14" cssclass="field_input"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="UpdatedByID1TextBoxMaxLengthValidator" ControlToValidate="UpdatedByID1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Updated By&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="OnAppLabel" Text="On Application">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="OnApp"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocIndexLabel1" Text="Document Index">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="DocIndex1" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DocIndex1TextBoxMaxLengthValidator" ControlToValidate="DocIndex1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Index&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="OneActiveCopyLabel" Text="One Active Copy">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="OneActiveCopy"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocSortLabel1" Text="Document Sort">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="DocSort1" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DocSort1TextBoxMaxLengthValidator" ControlToValidate="DocSort1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Sort&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="PrivateFolderLabel" Text="Private Folder">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="PrivateFolder"></asp:CheckBox> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="RecordDocDetailsLabel" Text="Record Document Details">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="RecordDocDetails"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="DocDescriptionLabel" Text="Document Description">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="DocDescription" MaxLength="255" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DocDescriptionTextBoxMaxLengthValidator" ControlToValidate="DocDescription" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableRowDivider" colspan="7">&nbsp;</td></tr></FASTPORT:DocTreeTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <FASTPORT:PaginationModern runat="server" id="DocTreePagination"></FASTPORT:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</FASTPORT:DocTreeTableControl>

 </ContentTemplate></asp:TabPanel>
</asp:TabContainer></td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0"><tr><td><FASTPORT:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>" postback="True"></FASTPORT:ThemeButton></td><td><FASTPORT:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;FASTPORT&quot;) %>" postback="False"></FASTPORT:ThemeButton></td></tr></table>
</td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                