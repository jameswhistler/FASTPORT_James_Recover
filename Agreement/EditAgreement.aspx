<%@ Register Assembly="FASTPORT" Namespace="FASTPORT.UI" TagPrefix="custom" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="FASTPORT" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="FASTPORT" Namespace="FASTPORT.UI.Controls.EditAgreement" Assembly="FASTPORT" %>

<%@ Register Tagprefix="Selectors" Namespace="FASTPORT" Assembly="FASTPORT" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="EditAgreement.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="FASTPORT.UI.EditAgreement" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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
		</telerik:RadCodeBlock><table cellpadding="0" cellspacing="0" border="0"><tr><td style="width:875px;height:550px;vertical-align:top;" runat="server" class="panel_simplepadding_cust"><table><tr id="InstructionsRow" runat="server"><td><table><tr><td style="text-align:left;" class="dfv"><br />
<asp:Literal runat="server" id="InstructionsStandard" Text="600">	</asp:Literal>
<br /></td></tr></table>
</td></tr><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <FASTPORT:AgreementRecordControl runat="server" id="AgreementRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server">
<table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><telerik:RadTabStrip ID="RadTabStrip1" runat="server" MultiPageID="RadMultiPage1" SelectedIndex="0" Width="800px" Skin="BlackMetroTouch">
 <Tabs>
   <telerik:RadTab runat="server" Text="Document Settings" Style="font-size: 4;" PageViewID="PageView1" Value="Tab1_Click">
   </telerik:RadTab>
   <telerik:RadTab runat="server" Text="Signature Flow" PageViewID="PageView2" Value="Tab2_Click">
   </telerik:RadTab>
   <telerik:RadTab runat="server" Text="Configure Custom Fields" PageViewID="PageView3" Value="Tab3_Click">
   </telerik:RadTab>
   <telerik:RadTab runat="server" Text="Custom Instructions" PageViewID="PageView4" Value="Tab4_Click">
   </telerik:RadTab>
 </Tabs>
</telerik:RadTabStrip>
<telerik:RadMultiPage id="RadMultiPage1" runat="server" SelectedIndex="0" Width="800px">
  <telerik:RadPageView id="PageView1" runat="server" CssClass="nested_panel_cust">
	<asp:panel id="AgreementRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="RoleIDLabel" Text="Only For">	</asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="RoleID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="RoleIDFvLlsHyperLink" ControlToUpdate="RoleID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="Role" Field="Role_.RoleID" DisplayField="Role_.Role" Formula="%3d+Role.Role"></Selectors:FvLlsHyperLink></span>
</td></tr><tr><td class="fls"><asp:Literal runat="server" id="AgreementLabel" Text="Document">	</asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="Agreement" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="AgreementTextBoxMaxLengthValidator" ControlToValidate="Agreement" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Agreement&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="fls"><asp:Literal runat="server" id="DescriptionLabel" Text="Description">	</asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="Description" MaxLength="500" columns="60" cssclass="field_input" rows="6" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DescriptionTextBoxMaxLengthValidator" ControlToValidate="Description" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;FASTPORT&quot;).Replace(&quot;{FieldName}&quot;, &quot;Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="fls"><asp:Literal runat="server" id="AgreementFileLabel" Text="Document File">	</asp:Literal></td><td class="dfv"><asp:LinkButton runat="server" id="AgreementDownload" CommandName="Redirect" filenamefield="AgreementFileName" size="60"></asp:LinkButton> 
<asp:FileUpload runat="server" id="AgreementFile" cssclass="field_input" size="60"></asp:FileUpload> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="RequiredDocLabel" Text="Required Document">	</asp:Literal></td><td class="dfv"><asp:CheckBox runat="server" id="RequiredDoc"></asp:CheckBox></td></tr><tr><td class="fls"><asp:Literal runat="server" id="UseStoredSignatureLabel" Text="Use Stored Signature">	</asp:Literal></td><td class="dfv"><asp:CheckBox runat="server" id="UseStoredSignature"></asp:CheckBox></td></tr><tr><td class="fls"><asp:Literal runat="server" id="ShowSignatureDateLabel" Text="Show Signature Date">	</asp:Literal></td><td class="dfv"><asp:CheckBox runat="server" id="ShowSignatureDate"></asp:CheckBox></td></tr><tr><td class="fls"><asp:Literal runat="server" id="ShowExpirationDateLabel" Text="Show Expiration Date">	</asp:Literal></td><td class="dfv"><asp:CheckBox runat="server" id="ShowExpirationDate"></asp:CheckBox></td></tr><tr><td class="fls"><asp:Literal runat="server" id="InitialsInDocumentLabel" Text="Initials In Document">	</asp:Literal></td><td class="dfv"><asp:CheckBox runat="server" id="InitialsInDocument"></asp:CheckBox></td></tr><tr><td class="fls"><asp:Literal runat="server" id="DocHasCustomFieldsLabel" Text="Document Has Custom Fields">	</asp:Literal></td><td class="dfv"><asp:CheckBox runat="server" id="DocHasCustomFields" autopostback="True"></asp:CheckBox></td></tr><tr><td class="fls"><asp:Literal runat="server" id="ExecuteFromBoardLabel" Text="Block Execution">	</asp:Literal></td><td class="dfv"><asp:CheckBox runat="server" id="ExecuteFromBoard"></asp:CheckBox></td></tr></table></asp:panel>
 
  </telerik:RadPageView>
  <telerik:RadPageView id="PageView2" runat="server" CssClass="nested_panel_cust">
	<table><tr><td class="fls"><asp:Literal runat="server" id="FlowCollectionIDLabel" Text="Flow Collection">	</asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FlowCollectionID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="FlowCollectionIDFvLlsHyperLink" ControlToUpdate="FlowCollectionID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="FlowCollection" Field="FlowCollection_.FlowCollectionID" DisplayField="FlowCollection_.CollectionName" Formula="%3d+FlowCollection.CollectionName"></Selectors:FvLlsHyperLink></span>
</td></tr></table>

   </telerik:RadPageView>
  <telerik:RadPageView id="PageView3" runat="server" CssClass="nested_panel_cust">
  	<table cellpadding="0" cellspacing="0" border="0"><tr><td class="dfv"><asp:Panel id="CustomFieldsSrollPanel" runat="server" Height="450px" Width="785px" ScrollBars="Auto">
<center>
<table><tr><td class="thc" style="text-align:left;width:75px;vertical-align:bottom;"><asp:Label runat="server" id="FieldLbl" Text="Field">	</asp:Label></td><td class="thc" style="text-align:left;vertical-align:bottom;"><asp:Label runat="server" id="FieldTypeLbl" Text="Field Type">	</asp:Label></td><td class="thc" style="text-align:left;vertical-align:bottom;"><asp:Label runat="server" id="ItemLabel" Text="Items">	</asp:Label></td><td class="thc" style="text-align:left;vertical-align:bottom;"><asp:Label runat="server" id="DefaultLabel" Text="Default  Values">	</asp:Label></td><td class="thc" style="text-align:left;vertical-align:bottom;"><b><asp:Label runat="server" id="ForLbl" Text="For:">	</asp:Label><br /></b>
&nbsp;&nbsp;<asp:Label runat="server" id="OnlyCIXLbl" Text="Sender">	</asp:Label> <br />
&nbsp;&nbsp;<asp:Label runat="server" id="OnlyOIXLbl" Text="Repicient">	</asp:Label></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="FirstTypeIDLabel" Text="First">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FirstTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="FirstTypeIDFvLlsHyperLink" ControlToUpdate="FirstTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName" Formula="%3d+List.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FirstItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FirstDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="FirstByCIX"></asp:CheckBox><br />
<asp:CheckBox runat="server" id="FirstByOIX"></asp:CheckBox></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="SecondTypeIDLabel" Text="Second">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="SecondTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="SecondTypeIDFvLlsHyperLink" ControlToUpdate="SecondTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName" Formula="%3d+List.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="SecondItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="SecondDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="SecondByCIX"></asp:CheckBox><br />
<asp:CheckBox runat="server" id="SecondByOIX"></asp:CheckBox></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="ThirdTypeIDLabel" Text="Third">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ThirdTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="ThirdTypeIDFvLlsHyperLink" ControlToUpdate="ThirdTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName" Formula="%3d+List.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="ThirdItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="ThirdDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="ThirdByCIX"></asp:CheckBox><br />
<asp:CheckBox runat="server" id="ThirdByOIX"></asp:CheckBox></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="FourthTypeIDLabel" Text="Fourth">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FourthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="FourthTypeIDFvLlsHyperLink" ControlToUpdate="FourthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName" Formula="%3d+List.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FourthItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FourthDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="FourthByCIX"></asp:CheckBox><br />
<asp:CheckBox runat="server" id="FourthByOIX"></asp:CheckBox></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="FifthTypeIDLabel" Text="Fifth">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FifthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="FifthTypeIDFvLlsHyperLink" ControlToUpdate="FifthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName" Formula="%3d+List.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FifthItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FifthDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="FifthByCIX"></asp:CheckBox><br />
<asp:CheckBox runat="server" id="FifthByOIX"></asp:CheckBox></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="SixthTypeIDLabel" Text="Sixth">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="SixthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="SixthTypeIDFvLlsHyperLink" ControlToUpdate="SixthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName" Formula="%3d+List.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="SixthItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="SixthDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="SixthByCIX"></asp:CheckBox><br />
<asp:CheckBox runat="server" id="SixthByOIX"></asp:CheckBox></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="SeventhTypeIDLabel" Text="Seventh">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="SeventhTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="SeventhTypeIDFvLlsHyperLink" ControlToUpdate="SeventhTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName" Formula="%3d+List.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="SeventhItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="SeventhDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="SeventhByCIX"></asp:CheckBox><br />
<asp:CheckBox runat="server" id="SeventhByOIX"></asp:CheckBox></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="EighthTypeIDLabel" Text="Eighth">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="EighthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="EighthTypeIDFvLlsHyperLink" ControlToUpdate="EighthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName" Formula="%3d+List.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="EighthItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="EighthDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="EighthByCIX"></asp:CheckBox><br />
<asp:CheckBox runat="server" id="EighthByOIX"></asp:CheckBox></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="NinthTypeIDLabel" Text="Ninth">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="NinthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="NinthTypeIDFvLlsHyperLink" ControlToUpdate="NinthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName" Formula="%3d+List.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="NinthItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="NinthDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="NinthByCIX"></asp:CheckBox><br />
<asp:CheckBox runat="server" id="NinthByOIX"></asp:CheckBox></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="TenthTypeIDLabel" Text="Tenth">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="TenthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="TenthTypeIDFvLlsHyperLink" ControlToUpdate="TenthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName" Formula="%3d+List.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="TenthItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="TenthDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="TenthByCIX"></asp:CheckBox><br />
<asp:CheckBox runat="server" id="TenthByOIX"></asp:CheckBox></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="EleventhTypeIDLabel" Text="Eleventh">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="EleventhTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="EleventhTypeIDFvLlsHyperLink" ControlToUpdate="EleventhTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="EleventhItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="EleventhDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="EleventhByCIX"></asp:CheckBox><br />
<asp:CheckBox runat="server" id="EleventhByOIX"></asp:CheckBox></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="TwelfthTypeIDLabel" Text="Twelfth">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="TwelfthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="TwelfthTypeIDFvLlsHyperLink" ControlToUpdate="TwelfthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="TwelfthItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="TwelfthDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="TwelfthByCIX"></asp:CheckBox><br />
<asp:CheckBox runat="server" id="TwelfthByOIX"></asp:CheckBox></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="ThirteenthTypeIDLabel" Text="Thirteenth">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="ThirteenthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="ThirteenthTypeIDFvLlsHyperLink" ControlToUpdate="ThirteenthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="ThirteenthItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="ThirteenthDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="ThirteenthByCIX"></asp:CheckBox><br />
<asp:CheckBox runat="server" id="ThirteenthByOIX"></asp:CheckBox></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="FourteenthTypeIDLabel" Text="Fourteeth">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FourteenthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="FourteenthTypeIDFvLlsHyperLink" ControlToUpdate="FourteenthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FourteenthItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FourteenthDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="FourteenthByCIX"></asp:CheckBox><br />
<asp:CheckBox runat="server" id="FourteenthByOIX"></asp:CheckBox></td></tr><tr><td class="fls" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="FifteenthTypeIDLabel" Text="Fifteenth">	</asp:Literal></td><td class="dfv" style="vertical-align:top;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="FifteenthTypeID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="125px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="FifteenthTypeIDFvLlsHyperLink" ControlToUpdate="FifteenthTypeID" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;FASTPORT&quot;) %>" MinListItems="100" Table="List" Field="List_.ListID" DisplayField="List_.ListName"></Selectors:FvLlsHyperLink></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FifteenthItem" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FifteenthDefault" MaxLength="2000" columns="60" cssclass="field_input" generatevalidator="False" height="60px" rows="6" textmode="MultiLine" width="200px"></asp:TextBox></span>
</td><td class="dfv" style="vertical-align:top;"><asp:CheckBox runat="server" id="FifteenthByCIX"></asp:CheckBox><br /> 
<asp:CheckBox runat="server" id="FifteenthByOIX"></asp:CheckBox></td></tr></table>

</center>
</asp:Panel></td></tr></table>

  </telerik:RadPageView>
  <telerik:RadPageView id="PageView4" runat="server" CssClass="nested_panel_cust">
	<table><tr><td><asp:Panel id="CustomInstructionsSrollPanel" runat="server" Height="450px" Width="785px" ScrollBars="Auto">
<center>
<table><tr id="HiddenInstructionsRow" runat="server" visible="false"><td><span style="white-space:nowrap;">
<custom:HTMLEditor ID="SenderInstructions" runat="server" SenderInstructionsRequiredFieldValidator:Enabled="False" SenderInstructionsRequiredFieldValidator:Text="*" Height="350" Width="640" AutoFocus="False" /></span>
 
<span style="white-space:nowrap;">
<custom:HTMLEditor ID="RecipientInstructions" runat="server" RecipientInstructionsRequiredFieldValidator:Enabled="False" RecipientInstructionsRequiredFieldValidator:Text="*" Height="350" Width="640" AutoFocus="False" /></span>
 
<span style="white-space:nowrap;">
<custom:HTMLEditor ID="OtherInstructions" runat="server" OtherInstructionsRequiredFieldValidator:Enabled="False" OtherInstructionsRequiredFieldValidator:Text="*" Height="350" Width="640" AutoFocus="False" /></span>
</td></tr><tr id="OtherInstructionsRow" runat="server" visible="true"><td><table><tr><td class="header_cust"><asp:literal id="OtherInstructionsLbl" runat="server" text="General Instructions"></asp:literal></td></tr><tr><td><telerik:RadEditor ID="OtherInstructionsRE" Runat="server" Height="150" Width="450" toolsfile="~/ToolsFileMedium.xml" EditModes="Design">
</telerik:RadEditor></td></tr></table>

<br /></td></tr><tr id="SenderInstructionsRow" runat="server" visible="true"><td><table><tr><td class="header_cust"><asp:literal id="SenderInstrucitonsLbl" runat="server" text="Instructions for Sender Only"></asp:literal></td></tr><tr><td><telerik:RadEditor ID="SenderInstructionsRE" Runat="server" Height="150" Width="450" toolsfile="~/ToolsFileMedium.xml" EditModes="Design">
</telerik:RadEditor></td></tr></table>

<br /></td></tr><tr id="RecipientInstructionsRow" runat="server" visible="true"><td> 
<table><tr><td class="header_cust"><asp:literal id="RecipientInstrucitonsLbl" runat="server" text="Instructions for Recipient Only"></asp:literal></td></tr><tr><td><telerik:RadEditor ID="RecipientInstructionsRE" Runat="server" Height="150" Width="450" toolsfile="~/ToolsFileMedium.xml" EditModes="Design">
</telerik:RadEditor></td></tr></table>
</td></tr></table>

</center>
</asp:Panel></td></tr></table>
  		
  </telerik:RadPageView>
</telerik:RadMultiPage></td></tr></table>

</telerik:RadAjaxPanel></td></tr></table>
</FASTPORT:AgreementRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr></table>

</td></tr><tr><td class="recordPanelButtonsAlignment" style="text-align:center;"><center><table cellpadding="0" cellspacing="0" border="0"><tr><td><FASTPORT:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;FASTPORT&quot;) %>" postback="True"></FASTPORT:ThemeButton></td><td><FASTPORT:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;FASTPORT&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;FASTPORT&quot;) %>" postback="False"></FASTPORT:ThemeButton></td></tr></table>
</center></td></tr></table><div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>