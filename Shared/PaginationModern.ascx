﻿<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="PaginationModern.ascx.vb" Inherits="FASTPORT.UI.PaginationModern" %>
<%@ Register Tagprefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><table cellspacing="0" cellpadding="0" border="0" style="width: 100%"><tr><td style="width: 50%"><img src="../Images/space.gif" width="10" height="1" alt="" /></td><td style="width: 100%"><table><tr><td><asp:ImageButton runat="server" id="_FirstPage" causesvalidation="False" commandname="FirstPage" imageurl="../Images/ButtonBarFirst.gif" onmouseout="this.src='../Images/ButtonBarFirst.gif'" onmouseover="this.src='../Images/ButtonBarFirstOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:FirstPage&quot;, &quot;FASTPORT&quot;) %>" visible="False">		
	</asp:ImageButton></td><td><asp:ImageButton runat="server" id="_PreviousPage" causesvalidation="False" commandname="PreviousPage" imageurl="../Images/ButtonBarPrevious.gif" onmouseout="this.src='../Images/ButtonBarPrevious.gif'" onmouseover="this.src='../Images/ButtonBarPreviousOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:PreviousPage&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton></td><td class="prbg"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("_PageSizeButton")) %><asp:TextBox runat="server" id="_CurrentPage" cssclass="Pagination_Input" maxlength="10" size="5">	</asp:TextBox><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("_PageSizeButton")) %></td><td><asp:ImageButton runat="server" id="_NextPage" causesvalidation="False" commandname="NextPage" imageurl="../Images/ButtonBarNext.gif" onmouseout="this.src='../Images/ButtonBarNext.gif'" onmouseover="this.src='../Images/ButtonBarNextOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:NextPage&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:ImageButton></td><td><asp:ImageButton runat="server" id="_LastPage" causesvalidation="False" commandname="LastPage" imageurl="../Images/ButtonBarLast.gif" onmouseout="this.src='../Images/ButtonBarLast.gif'" onmouseover="this.src='../Images/ButtonBarLastOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:LastPage&quot;, &quot;FASTPORT&quot;) %>" visible="False">		
	</asp:ImageButton></td></tr></table>
</td><td style="width: 50%" text-align="right"><table><tr><td class="prbggo"><asp:LinkButton runat="server" id="_PageSizeButton" causesvalidation="False" commandname="PageSize" cssclass="button_link" text="&lt;%# GetResourceValue(&quot;Txt:PageSize&quot;, &quot;FASTPORT&quot;) %>">		
	</asp:LinkButton></td><td class="prbg"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("_PageSizeButton")) %><asp:TextBox runat="server" id="_PageSize" cssclass="Pagination_Input" maxlength="5" size="5" visible="False">	</asp:TextBox>
        <asp:dropdownlist id="_PageSizeSelector" runat="server" cssclass="Pagination_Input" AutoPostBack="false" onchange="ISD_CopyPageSize(this)">
	<asp:listitem id="PageSizeSelector5ListItem" value="5" text="5" />
	<asp:listitem id="PageSizeSelector10ListItem" value="10" text="10" selected="true" />
	<asp:listitem id="PageSizeSelector25ListItem" value="25" text="25" />
	<asp:listitem id="PageSizeSelector50ListItem" value="50" text="50" />
	<asp:listitem id="PageSizeSelector100ListItem" value="100" text="100" />
	</asp:dropdownlist>
        <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("_PageSizeButton")) %></td></tr></table>
</td></tr></table>